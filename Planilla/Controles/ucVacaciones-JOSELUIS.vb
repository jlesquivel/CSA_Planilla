Public Class ucVacaciones
    Dim conn As New conexionSQL("planilla")
    Private _Id_empleado
    Dim conta As Integer = 0


    Sub actualizar()
        VacacionesTableAdapter.FillByIdEmp(DsVacaciones.Vacaciones, _Id_empleado)
        LabelX1.Text = CStr(SumarDias("saldo", VacacionesDataGridViewX))
    End Sub
    Sub buscar(ByVal pId_emp As Integer)
        VacacionesTableAdapter.Connection = conn.conexion
        _Id_empleado = pId_emp
        actualizar()
    End Sub


    Private Sub VacacionesDataGridViewX_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles VacacionesDataGridViewX.RowHeaderMouseClick
        Dim Dgv As DataGridView = VacacionesDataGridViewX
        Dim val As Integer = Dgv.Item("id_vacacion", Dgv.CurrentRow.Index).Value
        Dim sald As Integer = Dgv.Item("saldo", Dgv.CurrentRow.Index).Value

        'Dim vent As New Ventanas
        'vent.cargarVentana(frmVacaciones, Me.ParentForm.ParentForm)
        Dim frmVaca1 As New frmVacaciones(val, sald)
        frmVaca1.Show()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="nombre_Columna"></param>
    ''' <param name="Dgv"></param>
    ''' <returns></returns>
    Private Function Sumar(
     ByVal nombre_Columna As String,
     ByVal Dgv As DataGridView) As Double

        Dim total As Double = 0
        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = total + CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return total
    End Function


    Private Function SumarDias(
  ByVal nombre_Columna As String,
  ByVal Dgv As DataGridView) As Double

        Dim total As Double = 0
        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                If Dgv.Item("periodo", i).Value <= Year(Now) Then
                    total = total + CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return total

    End Function

    Private Sub VacacionesDataGridViewX_GotFocus(sender As Object, e As EventArgs) Handles VacacionesDataGridViewX.GotFocus
        conta += 1
        actualizar()
    End Sub
End Class
