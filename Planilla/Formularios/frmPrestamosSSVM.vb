
Imports System.ComponentModel
Imports CircularProgressBar
Imports WinFormAnimation

Public Class frmPrestamosSSVM

    Dim oSSVM As New cSSVM_Prestamo
    Dim vPeriodo As String = ""

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim archivo As String = ""

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            CircularProgressBar1.Visible = True

            TextBoxX1.Text = OpenFileDialog1.FileName
            archivo = TextBoxX1.Text


            Dim aplicados As Integer = oSSVM.CargarPlanillaCA(archivo, vPeriodo)

            Me.PlanillaDataSet.vCoopeAndeXLS.Clear()
            Me.VSSVM_PrestamosTableAdapter.Fill(Me.PlanillaDataSet.vSSVM_Prestamos)
            CircularProgressBar1.Visible = False

        End If
    End Sub

    Private Sub frmCoopeAndeX_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.VSSVM_PrestamosTableAdapter.Fill(Me.PlanillaDataSet.vSSVM_Prestamos)
        If PlanillaDataSet.vSSVM_Prestamos.Count > 0 Then
            ButtonX1.Enabled = False
        Else
            vPeriodo = Now.Year.ToString + Now.Month.ToString("00")
            ComboBoxEx1.Items.Add(vPeriodo)
            ComboBoxEx1.SelectedIndex = 0
        End If
        CircularProgressBar1.Visible = False

    End Sub

    Private Sub frmCoopeAndeX_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CircularProgressBar1.Dispose()
        CircularProgressBar1 = Nothing

    End Sub

End Class