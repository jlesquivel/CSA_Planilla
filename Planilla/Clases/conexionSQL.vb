Imports System.Data.SqlClient
Imports System.IO

Public Class conexionSQL
    Implements IDisposable

#If DEBUG Then
    'Private vServidor As String = "(localdb)\ProjectsV12"
    Private vServidor As String = "servidor-bd"
#Else
    Private vServidor As String = "servidor-bd"
#End If

    Private seguridadIntegrada As Boolean = True
    Private vbd As String = "planilla"
    Public vusuario As String = "sa"
    Public vpassword As String = "123"
    Private vtabla As String = ""
    Private vcampos As String = ""
    Private vorden As String = ""
    Private vstrConn As String = ""
    Private colegioConnection As SqlConnection
    Private red As NetworkInformation = NetworkInformation.LocalComputer

#Region " Propiedades "
    Public Property servidor() As String
        Get
            Return vServidor
        End Get
        Set(ByVal Value As String)
            vServidor = Value
            Construye_String()
        End Set
    End Property

    Public Property bd() As String
        Get
            Return vbd
        End Get

        Set(ByVal Value As String)
            vbd = Value
            Construye_String()
            Me.colegioConnection.ConnectionString = vstrConn
        End Set
    End Property

    Public Property strConn() As String
        Get
            Return vstrConn
        End Get
        Set(ByVal Value As String)
            vstrConn = Value
        End Set
    End Property

    Public Property conexion() As SqlConnection
        Get
            Return colegioConnection
        End Get

        Set(ByVal Value As SqlConnection)
            colegioConnection = Value
        End Set
    End Property

#End Region
    ''' <summary>
    ''' 
    ''' </summary>
    Sub New()
        ' carga el archivo de password general
        Try
            Construye_String()
            colegioConnection = New SqlConnection(vstrConn)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub New(ByVal serv As String, ByVal base As String, ByVal cuenta As String, ByVal pass As String)

        vServidor = serv
        vbd = base
        vusuario = cuenta
        vpassword = pass

        Construye_String()
        colegioConnection = New SqlConnection(vstrConn)
    End Sub

    Sub New(ByVal base As String)
        vbd = base
        Construye_String()
        colegioConnection = New SqlConnection(vstrConn)
    End Sub
    Function conexionOK() As Boolean
        Dim isConnecting As Boolean = True
        While isConnecting
            Try
                colegioConnection.Open()
                colegioConnection.Close()
                isConnecting = False
                Return True
            Catch sqlExc As SqlException
                isConnecting = False
                Return False
            End Try
        End While
    End Function

    Function conexionOK(ByVal pbd As String) As Boolean
        Me.bd = pbd
        Return Me.conexionOK()
    End Function

    Sub llena(ByRef ds As DataSet, ByVal tabla As String, ByVal instruccion As String)
        Try
            If colegioConnection.State = ConnectionState.Closed Then
                colegioConnection.Open()
            End If
            Dim da As New SqlDataAdapter(instruccion, conexion)
            If ds.Tables.Item(tabla) Is Nothing Then
                ds.Tables.Add(tabla)
            End If

            ds.Tables(tabla).Clear()
            da.Fill(ds, tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub llena(ByRef ds As DataSet, ByVal tabla As String, ByVal instruccion As SqlCommand)
        Try
            If colegioConnection.State = ConnectionState.Closed Then
                colegioConnection.Open()
            End If
            Dim da As New SqlDataAdapter(instruccion)
            da.SelectCommand.Connection = conexion
            If ds.Tables.Item(tabla) Is Nothing Then
                ds.Tables.Add(tabla)
            End If

            ds.Tables(tabla).Clear()
            da.Fill(ds, tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Function llena(ByVal instruccion As String) As ArrayList
        Dim arreglo As New ArrayList
        Dim pos As Integer = 0
        Try

            Dim ds As New DataSet
            Dim registros As Integer
            If colegioConnection.State = ConnectionState.Closed Then
                colegioConnection.Open()
            End If
            Dim da As New SqlDataAdapter(instruccion, conexion)

            registros = da.Fill(ds, 0)
            ' convierte ds a un arreglo a partir de aqui

            For Each fila As DataRow In ds.Tables(0).Rows
                arreglo.Add(fila.ItemArray)
                pos = pos + 1
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return arreglo
    End Function

    Public Sub ejecuta(ByVal comando As String)
        Try
            Dim myCommand As New SqlCommand(comando)
            myCommand.Connection = colegioConnection
            If colegioConnection.State = ConnectionState.Closed Then
                colegioConnection.Open()
            End If
            myCommand.ExecuteNonQuery()
            myCommand.Connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ejecuta_sinerror(ByVal comando As String)

        Dim myCommand As New SqlCommand(comando)
        myCommand.Connection = colegioConnection
        If colegioConnection.State = ConnectionState.Closed Then
            colegioConnection.Open()
        End If
        myCommand.ExecuteNonQuery()
        myCommand.Connection.Close()
    End Sub

    Public Sub GeneraArchivo(ByVal FilePath As String, ByVal ds As DataTable)
        'Variables para abrir el archivo en modo de escritura  
        Dim strStreamW As Stream = File.OpenWrite(FilePath)

        Dim strStreamWriter As StreamWriter = New StreamWriter(strStreamW,
                     System.Text.Encoding.ASCII)

        Try
            Dim dr As DataRow
            Dim valor As Object
            Dim linea As String = ""

            For Each dr In ds.Rows         'Obtenemos los datos del dataset   
                For Each valor In dr.ItemArray
                    If valor.GetType.Name <> "String" Then
                        linea = linea & CStr(valor)
                    Else
                        linea = linea & valor
                    End If
                Next
                'Escribimos la línea en el achivo de texto 
                linea = linea.Replace("Ñ", "N")
                strStreamWriter.WriteLine(linea)
                linea = ""
            Next
            strStreamWriter.Close()
            MsgBox("El archivo se generó con éxito")
        Catch ex As Exception
            strStreamWriter.Close()
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub GeneraArchivoEncabezadoResumen(ByVal FilePath As String,
            ByVal ds As DataTable, ByVal encabezado As String, ByVal resumen As String)

        'Variables para abrir el archivo en modo de escritura  
        Dim strStreamW As Stream = File.OpenWrite(FilePath)

        Dim strStreamWriter As StreamWriter = New StreamWriter(strStreamW,
                     System.Text.Encoding.ASCII)

        Try
            Dim dr As DataRow
            Dim valor As Object
            Dim linea As String = ""

            ' escribe en el archivo el encabezado
            strStreamWriter.WriteLine(encabezado)

            For Each dr In ds.Rows         'Obtenemos los datos del dataset   
                For Each valor In dr.ItemArray
                    If valor.GetType.Name <> "String" Then
                        linea = linea & CStr(valor)
                    Else
                        linea = linea & valor
                    End If
                Next
                'Escribimos la línea en el achivo de texto 
                linea = linea.Replace("Ñ", "N")
                strStreamWriter.WriteLine(linea)
                linea = ""
            Next

            ' escribe en el archivo el parametro resumen
            strStreamWriter.WriteLine(resumen)

            strStreamWriter.Close()
            MsgBox("El archivo se generó con éxito")
        Catch ex As Exception
            strStreamWriter.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Construye_String()

        If red.Status = NetworkInformation.JoinStatus.Domain Then
            vstrConn = "data source=" & vServidor &
                     ";initial catalog=" & vbd &
                     ";integrated security=SSPI" &
                     ";persist security info=TRUE" &
                     ";packet size=4096;MultipleActiveResultSets=true"
        Else
            If vServidor.Substring(0, 9) = "(localdb)" Then
                vstrConn = "Data Source=(localdb)\ProjectsV12;Initial Catalog=planilla;Integrated Security=True;" &
                    "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" &
                    "ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            Else
                vstrConn = "data source=" & vServidor &
                            ";initial catalog=" & vbd & ";persist security info=TRUE" &
                            " ;user id=" & vusuario & ";password=" & vpassword &
                            ";packet size=4096;MultipleActiveResultSets=true"
            End If

        End If
    End Sub
    Public Function verifica_seguridad(ByVal pBasedato As String, ByVal ptabla As String) As Boolean
        Dim retorno As Boolean
        Try
            Me.ejecuta_sinerror("Select TOP 1 * from " & ptabla)
            retorno = True

        Catch ex As Exception
            retorno = False
        End Try

        Return retorno
    End Function

    Public Sub Dispose() Implements System.IDisposable.Dispose
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        Dispose()
        MyBase.Finalize()
    End Sub
End Class
