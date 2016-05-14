Imports System.Security.Cryptography
Imports System.IO
Imports Microsoft.Office.Interop


Public Class cCoopeAnde

    Dim conn As New conexionSQL
    Dim excel As New cExcel


#Region "Envio de planilla"

    ''' <summary>
    ''' Consulta la base de datos y retorna en un arreglo los registros
    ''' </summary>
    ''' <param name="plani"></param>
    ''' <returns></returns>
    Private Function cargarDatos(ByVal plani As String) As ArrayList
        Dim conn As New conexionSQL
        Return conn.llena("EXEC PlanillaCoopeAnde " & plani)
    End Function


    ''' <summary>
    ''' Llenar archivo excel que se enviara a Coopeande conlos salarios de los empleados via correo
    ''' </summary>
    ''' <param name="pPlanilla"></param>
    ''' <param name="pArchivo"></param>
    ''' <returns></returns>
    Public Function llenaExcel(pPlanilla As String, pArchivo As String) As String

        Dim dato As ArrayList = cargarDatos(pPlanilla)
        Dim Excel As New cExcel

        Excel.AbrePlantillaPlanilla(My.Application.Info.DirectoryPath & "\plantillas\" & pArchivo)
        Excel.AlmacenarValor(dato)

        Return Excel.guarda(pArchivo, pPlanilla)
    End Function

#End Region

#Region "Excel => BD planilla coopeande "
    '' Cargar datos de planilla que ser recibe de coopeande "CA" con la informacion de prestamos
    '' y ahorros , se deben aplicar a la planilla que se este procesando


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="archivo">Nombre del archivo excel que debe cargar</param>
    ''' <returns> Retorna los registro cargados</returns>
    Function CargarPlanillaCA(archivo As String) As Integer
        Try

            If File.Exists(archivo) Then
                Dim nombre As String = Path.GetFileName(archivo)
                Dim md5 As String = getFileMd5(archivo)
                Dim ano As Integer = 0
                Dim mes As Integer = 0
                mes_ano(nombre, ano, mes)

                Dim datos As ArrayList    ' consulta si el mes y el año a sido insertado 
                Dim consulta As String = "select * from CoopeAndeXArchivos where " &
                    String.Format("ano = {0} and mes = {1}", ano.ToString, mes.ToString)
                datos = conn.llena(consulta)

                If datos.Count = 0 Then ' si no ha sido procesado el archivo
                    consulta = "INSERT INTO CoopeAndexArchivos (archivo, nombre, md5, ano, mes) VALUES( " &
                    String.Format(" '{0}', '{1}', '{2}', {3}, {4} )", archivo, nombre, md5, ano.ToString, mes.ToString)

                    conn.ejecuta(consulta)
                    Dim res As ArrayList
                    res = conn.llena("SELECT IDENT_CURRENT('CoopeAndexArchivos');")
                    Dim id_archivo As String = res(0)(0)

                    datos.Clear()
                    datos = leerExcel(archivo)
                    If datos.Count > 0 Then
                        InsertCoopeAndeX(datos, id_archivo, ano, mes)
                    End If
                Else
                    'UNDONE:  verificar si el mismo archivo comparando con MD5
                    MsgBox("Año y mes Cargados Anteriormente")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function leerExcel(parchivo As String) As ArrayList

        Dim datos As New ArrayList
        Dim libroXLS As Excel.Workbook
        libroXLS = excel.AbreExcel(parchivo)

        Dim HojaExcel As Excel.Worksheet = libroXLS.Worksheets.Item(1)
        Dim pos As Integer = 3

        If HojaExcel.Range("A8").Value = "Cédula" Then
            pos = 9

            While CStr(HojaExcel.Range("A" & pos.ToString).Value) <> ""
                Dim fila As New List(Of Object)
                fila.Add(HojaExcel.Range("A" & pos.ToString).Value)
                fila.Add(HojaExcel.Range("C" & pos.ToString).Value)
                fila.Add(HojaExcel.Range("D" & pos.ToString).Value)
                fila.Add(HojaExcel.Range("E" & pos.ToString).Value)
                datos.Add(fila)
                pos += 1
            End While
            excel.CerrarProcesoExcel()

            Return datos
        End If
    End Function

    Sub InsertCoopeAndeX(dat As ArrayList, id_archivo As String, ano As String, mes As String)
        Dim inserta, comando As String
        inserta = "INSERT INTO CoopeAndeX (ano, mes, cedula, capital, ahorros, creditos, id_archivo) VALUES( "

        Dim cedula, capital, ahorros, creditos As String

        For Each dato As Object In dat

            Select Case dato(0).ToString.Length
                Case 9
                    cedula = String.Format("{0:0#-####-####}", dato(0))
                Case 12
                    cedula = dato(0)
                Case Else
            End Select


            capital = dato(1)
            ahorros = dato(2)
            creditos = dato(3)

            comando = inserta & String.Format(" {0}, {1}, '{2}', {3}, {4}, {5}, {6} )", ano, mes, cedula, capital, ahorros, creditos, id_archivo)
            conn.ejecuta(comando)
        Next
    End Sub

    Function ExistenDatosMes() As Boolean
        Dim res As ArrayList
        res = conn.llena("SELECT * FROM vCoopeAnde;")
        Return res.Count > 0
    End Function

    Private Sub mes_ano(ByVal archivo As String, ByRef pano As Integer, ByRef pmes As Integer)
        pano = archivo.Substring(archivo.IndexOf("_") + 1, 4)
        pmes = archivo.Substring(archivo.IndexOf("_") + 5, 2)
    End Sub

    Function AplicarEnPlanilla(id_planilla, id_archivo)


    End Function


    Private Function getFileMd5(ByVal filePath As String) As String
        ' lee todo el contenido del archivo
        Dim File() As Byte = System.IO.File.ReadAllBytes(filePath)

        ' crea el objeto MD5
        Dim Md5 As New MD5CryptoServiceProvider()

        ' calcula el Hash
        Dim byteHash() As Byte = Md5.ComputeHash(File)


        ' retorna el valor en base 64
        Return Convert.ToBase64String(byteHash)
    End Function


#End Region

#Region "Capital Planillas ==>  Excel "

    Function CargarCapitalExcel(parchivo As String) As Integer

        If File.Exists(parchivo) Then
            Dim nombre As String = Path.GetFileName(parchivo)
            Dim ano As Integer = 0
            Dim mes As Integer = 0
            Dim cedula As String = ""
            mes_ano(nombre, ano, mes)


            Dim datos As New ArrayList
            Dim libroXLS As Excel.Workbook
            libroXLS = excel.AbreExcel(parchivo)

            Dim HojaExcel As Excel.Worksheet = libroXLS.Worksheets.Item(1)
            Dim pos As Integer = 3
            Dim valor As Decimal = 0
            Dim linea As String = ""

            If HojaExcel.Range("A8").Value = "Cédula" Then
                pos = 9

                While CStr(HojaExcel.Range("A" & pos.ToString).Value) <> ""

                    linea = pos.ToString
                    cedula = FormatoCedula(HojaExcel.Range("A" & linea).Value)
                    valor = CoopeandeCapital(cedula, ano, mes)
                    HojaExcel.Range("C" & linea).Value = valor
                    pos += 1
                End While

                libroXLS.Save()
                libroXLS.Close()
                excel.CerrarProcesoExcel()

                ''  MsgBox("Archivo Procesados con datos")
            End If
        Else
            Return 0
        End If
    End Function

    Function CoopeandeCapital(pcedula As String, pano As String, pmes As String) As Decimal

        Dim inst As String = ""
        Dim res As ArrayList
        Dim retorna As Decimal = 0

        inst = String.Format("EXEC CoopeAndeCapital '{0}', {1}, {2}", pcedula, pano, pmes)
        res = conn.llena(inst)
        If res.Count > 0 Then
            retorna = Math.Abs(res(0)(0))
        End If
        Return retorna
    End Function


    Function FormatoCedula(pced As String) As String
        Dim res As String

        Select Case pced.Length
            Case 9
                res = String.Format("{0:0#-####-####}", CInt(pced))
            Case 12
                res = pced
            Case Else
        End Select

        Return res
    End Function
#End Region

End Class
