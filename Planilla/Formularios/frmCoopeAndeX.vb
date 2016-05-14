

Imports System.ComponentModel

Public Class frmCoopeAndeX

    Dim oCoope As New cCoopeAnde

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim archivo As String = ""

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBoxX1.Text = OpenFileDialog1.FileName
            archivo = TextBoxX1.Text

            Dim aplicados As Integer = oCoope.CargarPlanillaCA(archivo)

            Me.PlanillaDataSet.vCoopeAndeXLS.Clear()
            Me.VCoopeAndeXLSTableAdapter.Fill(Me.PlanillaDataSet.vCoopeAndeXLS)

        End If
    End Sub


    Private Sub frmCoopeAndeX_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.VCoopeAndeXLSTableAdapter.Fill(Me.PlanillaDataSet.vCoopeAndeXLS)

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            UcProgresoCircular1.Muestra()

            TextBoxX1.Text = OpenFileDialog1.FileName
            BackgroundWorker1.RunWorkerAsync()

        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim oCoope2 As New cCoopeAnde
        Dim aplicados As Integer = oCoope2.CargarCapitalExcel(TextBoxX1.Text)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        UcProgresoCircular1.Oculta()
    End Sub
End Class