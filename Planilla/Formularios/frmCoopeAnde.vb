Imports System.ComponentModel
Imports System.IO

Public Class frmCoopeAnde
    Dim id_planilla As Integer
    Dim correos As String
    Dim dv As DataView

    Sub New(pid_planilla As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id_planilla = pid_planilla

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click


        Dim excel As New cCoopeAnde
        Dim Archivo As String = "PlantillaSalarios.xls"
        Archivo = excel.llenaExcel(CStr(id_planilla), Archivo)

        Dim de, para, asunto, mensaje As String
        de = "administracion@csalib.org"
        asunto = "Planilla Colegio Santa Ana, Liberia"
        mensaje = "Favor procesar planilla"
        If ListBoxAdv1.SelectedItem IsNot Nothing Then
            para = ListBoxAdv1.SelectedItem
        Else
            MsgBox("Seleccione un correo electronico")
            Exit Sub
        End If
        If Not IsFileInUse(Archivo) Then
            Dim oMail As New cCorreo(de, para, asunto, mensaje, Archivo)
            Me.Close()
        Else
            MsgBox("archivo en uso")
        End If

    End Sub



    Private Function IsFileInUse(ByVal filePath As String) As Boolean
        Dim fs As System.IO.FileStream = Nothing
        Try
            fs = New FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
            Return False
        Catch ex As Exception
            Return True
        Finally
            If Not fs Is Nothing Then
                fs.Close()
                fs.Dispose()
            End If
        End Try
    End Function

    Private Sub ListBoxAdv1_ItemClick(sender As Object, e As EventArgs) Handles ListBoxAdv1.ItemClick
        TextBoxX1.Text = ListBoxAdv1.SelectedItem
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        ListBoxAdv1.Items.RemoveAt(ListBoxAdv1.SelectedIndex)
        TextBoxX1.Text = ""

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        If TextBoxX1.Text <> "" Then
            ListBoxAdv1.Items.Add(TextBoxX1.Text)
            TextBoxX1.Text = ""
            correos_guarda()
        End If
    End Sub


    Sub correos_guarda()
        Dim res, sBD As String
        For Each lin As Object In ListBoxAdv1.Items
            res += "," & lin
        Next
        sBD = res.Substring(1, res.Length - 1)

        dv(0).Item("valorT") = sBD

    End Sub

    Sub correos_carga()

        correos = If(IsDBNull(dv(0).Item("valorT")), "", dv(0).Item("valorT"))
        ListBoxAdv1.Items.Clear()
        If correos <> "" Then
            Dim arreglo() As String = correos.Split(",")
            For Each lin As String In arreglo
                ListBoxAdv1.Items.Add(lin)
            Next
        End If

    End Sub

    Private Sub frmCoopeAnde_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.ConfiguracionValoresTableAdapter.Fill(Me.PlanillaDataSet.configuracionValores)
        dv = New DataView(PlanillaDataSet.configuracionValores,
                               "[Nombre Valor] = 'correos'", "valorT",
                               DataViewRowState.CurrentRows)

        correos_carga()
    End Sub

    Private Sub frmCoopeAnde_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.ConfiguracionValoresTableAdapter.Update(Me.PlanillaDataSet.configuracionValores)
    End Sub
End Class