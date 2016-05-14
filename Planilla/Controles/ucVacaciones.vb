Public Class ucVacaciones


    Private Sub ucVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Calcular(pId_emp As Integer)

    End Sub

    Private Sub VacacionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VacacionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsVacaciones)

    End Sub

    Private Sub VacacionesDataGridViewX_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VacacionesDataGridViewX.CellContentClick

    End Sub
End Class
