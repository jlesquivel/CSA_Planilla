Imports System.Security.Cryptography
Imports System.IO
Imports Microsoft.Office.Interop


Public Class cSSVM_Prestamo

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

#Region "Excel => BD planilla SSVM_Prestamo "
    '' Cargar datos de planilla que ser recibe de coopeande "CA" con la informacion de prestamos
    '' y ahorros , se deben aplicar a la planilla que se este procesando


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="archivo">Nombre del archivo excel que debe cargar</param>
    ''' <returns> Retorna los registro cargados</returns>
    Function CargarPlanillaCA(archivo As String, periodo As String) As Integer
        Try

            If File.Exists(archivo) Then
                Dim nombre As String = Path.GetFileName(archivo)
                Dim ano As Integer = periodo.Substring(0, 4)
                Dim mes As Integer = periodo.Substring(4, 2)

                Dim datos As ArrayList    ' consulta si el mes y el año a sido insertado 
                Dim consulta As String = "select * from SSVM_Prestamos where " &
                    String.Format("ano = {0} and mes = {1}", ano.ToString, mes.ToString)
                datos = conn.llena(consulta)

                If datos.Count = 0 Then ' si no ha sido procesado el archivo

                    datos.Clear()
                    datos = leerExcel(archivo)
                    If datos.Count > 0 Then
                        InsertaBD(datos, ano, mes)
                    End If
                Else
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
        Dim pos As Integer = 7

        Dim odir, ocol, cCuota As String
        odir = HojaExcel.Range("a1:a10").Find("CEDULA").Row

        ocol = HojaExcel.Range("a1:E10").Find("CUOTA").Address
        cCuota = ocol.Substring(1, 1)

        If HojaExcel.Range("A" & odir).Value.ToString.Trim = "CEDULA" Then
            pos = odir + 1  'fila de inicio de lectura de datos

            While HojaExcel.Range("A" & pos.ToString).Value.ToString <> "TOTAL"
                Dim fila As New List(Of Object)
                fila.Add(HojaExcel.Range("A" & pos.ToString).Value)
                fila.Add(HojaExcel.Range(cCuota & pos.ToString).Value)
                datos.Add(fila)
                pos += 1
            End While

            excel.CerrarProcesoExcel()

            Return datos
        Else
            MsgBox("Formato Archivo Incorrecto")
        End If
    End Function

    Sub InsertaBD(dat As ArrayList, ano As Integer, mes As Integer)
        Dim inserta, comando As String
        inserta = "INSERT INTO SSVM_Prestamos (ano, mes, cedula, credito) VALUES( "

        Dim cedula, creditos As String

        Try
            For Each dato As Object In dat
                Select Case dato(0).ToString.Length
                    Case 9
                        cedula = String.Format("{0:0#-####-####}", dato(0))
                    Case 12
                        cedula = dato(0)
                    Case Else
                End Select

                creditos = dato(1)

                comando = inserta & String.Format(" {0}, {1}, '{2}', {3} )", ano, mes, cedula, creditos)
                conn.ejecuta(comando)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


#End Region


End Class
