Public Class cEmpleado

    Dim _id_emp As Integer
    Dim _cedula As String
    Public datos As ds2planilla.empleadosRow

    Dim dsEmp As New ds2planilla
    Dim taEmp As New ds2planillaTableAdapters.empleadosTableAdapter

    Sub New(pid_emp As Integer)
        _id_emp = pid_emp
        taEmp.FillById_Emp(dsEmp.empleados, _id_emp)
        datos = dsEmp.empleados.Rows.Item(0)
    End Sub

    Sub New(pcedula As String)
        _cedula = pcedula
        taEmp.FillByCedula(dsEmp.empleados, _cedula)
        datos = dsEmp.empleados.Rows.Item(0)
    End Sub

    Function Registro() As ds2planilla.empleadosRow
        If dsEmp.empleados.Rows.Count > 0 Then
            Return dsEmp.empleados.Rows.Item(0)
        Else
            Return Nothing
        End If

    End Function

End Class
