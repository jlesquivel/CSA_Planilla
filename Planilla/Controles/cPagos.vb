Public Class cPagos


    Sub buscar(ByVal pId_emp As Integer)
        Dim conn As New conexionSQL("planilla")

        PagosEmpleadoTableAdapter.Connection = conn.conexion

        Me.PlanillaDataSet.PagosEmpleado.Rows.Clear()
        Me.PagosEmpleadoTableAdapter.Fill(Me.PlanillaDataSet.PagosEmpleado, pId_emp)

    End Sub

End Class
