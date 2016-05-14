Public Class colegiatura

    Private Sub ColegiaturaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ColegiaturaBindingSource.EndEdit()
        Me.ColegiaturaTableAdapter.Update(Me.PlanillaDataSet.colegiatura)

    End Sub

    Private Sub colegiatura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ColegiaturaTableAdapter.Fill(Me.PlanillaDataSet.colegiatura)
        Me.V_empleados_contratadosTableAdapter.Fill(Me.PlanillaDataSet.v_empleados_contratados)
    End Sub

    Private Sub ColegiaturaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColegiaturaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ColegiaturaBindingSource.EndEdit()
        Me.ColegiaturaTableAdapter.Update(Me.PlanillaDataSet.colegiatura)

    End Sub
End Class
