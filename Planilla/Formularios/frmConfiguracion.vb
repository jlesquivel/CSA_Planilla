Imports System.Windows.Forms

Public Class frmConfiguracion

  
    Private Sub ConfiguracionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ConfiguracionBindingSource.EndEdit()
        Me.ConfiguracionTableAdapter.Update(Me.PlanillaDataSet.configuracion)

        Me.ConfiguracionBindingSource.EndEdit()
        Me.ConfiguracionValoresTableAdapter.Update(Me.PlanillaDataSet.configuracionValores)

    End Sub

    Private Sub frmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ConfiguracionValoresTableAdapter.Fill(Me.PlanillaDataSet.configuracionValores)
        Me.ConfiguracionTableAdapter.Fill(Me.PlanillaDataSet.configuracion)
        Me.ConfiguracionValoresTableAdapter.Fill(Me.PlanillaDataSet.configuracionValores)
    End Sub

  
    Private Sub LogoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoPictureBox.Click
        Try
            Dim DlgOpenFile As New OpenFileDialog

            DlgOpenFile.ShowReadOnly = True
            If Windows.Forms.DialogResult.OK = DlgOpenFile.ShowDialog() Then
                Me.LogoPictureBox.Image = Image.FromFile(DlgOpenFile.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
