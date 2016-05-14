Public Class frmColegiatura

    Private Sub Guardar()

        Try
            Me.Validate()
            Me.ColegiaturaBindingSource.EndEdit()
            Me.ColegiaturaTableAdapter.Update(Me.PlanillaDataSet.colegiatura)

            'CustomersTableAdapter.Update(NorthwindDataSet)

        Catch ex As DBConcurrencyException

            'Dim customErrorMessage As String
            'customErrorMessage = "Concurrency violation" & vbCrLf
            'customErrorMessage += CType(ex.Row.Item(0), String)
            'MessageBox.Show(customErrorMessage)

            ' Add business logic code to resolve the concurrency violation...

        End Try


    End Sub
    Private Sub ColegiaturaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColegiaturaBindingNavigatorSaveItem.Click
        Me.Guardar()
    End Sub

    'Private Sub frmColegiatura_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    Me.Guardar()
    'End Sub

    Private Sub frmColegiatura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New conexionSQL
        'borra las colegiaturas sin contrato vigente
        conn.ejecuta("delete from colegiatura where not (id_contrato in (select id_contrato from v_empleados_contratados))")

        Me.V_empleados_contratadosTableAdapter.Connection = conn.conexion
        Me.ColegiaturaTableAdapter.Connection = conn.conexion

        Me.V_empleados_contratadosTableAdapter.Fill(Me.PlanillaDataSet.v_empleados_contratados)
        Me.ColegiaturaTableAdapter.Fill(Me.PlanillaDataSet.colegiatura)

        conn.ejecuta("delete from colegiatura where not (id_contrato in (select id_contrato from v_empleados_contratados))")
    End Sub

End Class