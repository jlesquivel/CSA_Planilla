Public Class cRubros
    Dim conn As New conexionSQL

    Private Sub RubrosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RubrosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RubrosBindingSource.EndEdit()
        Me.RubrosTableAdapter.Update(Me.PlanillaDataSet.rubros)
        Me.Tabla_valoresTableAdapter.Update(Me.PlanillaDataSet.tabla_valores)
    End Sub

    Private Sub cRubros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Tabla_valoresTableAdapter.Connection.ConnectionString = conn.strConn
        Me.RubrosTableAdapter.Connection.ConnectionString = conn.strConn

        Me.RubrosTableAdapter.Fill(Me.PlanillaDataSet.rubros)
        Me.Tabla_valoresTableAdapter.Fill(Me.PlanillaDataSet.tabla_valores)
    End Sub
End Class
