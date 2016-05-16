Public Class ucVacaciones


    Private Sub ucVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VacacionesTableAdapter.Fill(DsVacaciones.Vacaciones)
    End Sub


    Public Sub Calcular(pId_emp As Integer)

    End Sub

    Private Sub VacacionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VacacionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsVacaciones)

    End Sub

End Class
