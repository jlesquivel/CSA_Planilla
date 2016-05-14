Public Class frmCategoria

    Private Sub CategoriasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoriasBindingSource.EndEdit()
        Me.CategoriasTableAdapter.Update(Me.PlanillaDataSet.categorias)
    End Sub

    Private Sub frmCategoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New conexionSQL

        Me.CategoriasTableAdapter.Connection = conn.conexion
        Me.CategoriasTableAdapter.Fill(Me.PlanillaDataSet.categorias)
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        Me.CategoriasBindingSource.Position = ComboBoxEx1.SelectedIndex
    End Sub
End Class