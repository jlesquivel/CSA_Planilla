Public Class frmIncapacidades
    Dim conn As New conexionSQL

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.IncapacidadesBindingSource.EndEdit()
        Me.IncapacidadesTableAdapter.Update(Me.PlanillaDataSet.Incapacidades)
    End Sub
    Private Sub IncapacidadesTipoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncapacidadesTipoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IncapacidadesTipoBindingSource.EndEdit()
        Me.IncapacidadesTipoTableAdapter.Update(Me.PlanillaDataSet.incapacidadesTipo)
    End Sub

    Private Sub frmIncapacidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        V_empleados_contratadosTableAdapter.Connection = conn.conexion
        IncapacidadesTableAdapter.Connection = conn.conexion
        IncapacidadesTipoTableAdapter.Connection = conn.conexion

        Me.V_empleados_contratadosTableAdapter.Fill(Me.PlanillaDataSet.v_empleados_contratados)
        Me.IncapacidadesTableAdapter.Fill(Me.PlanillaDataSet.Incapacidades)
        Me.IncapacidadesTipoTableAdapter.Fill(Me.PlanillaDataSet.incapacidadesTipo)
        Me.IncapacidadesBindingSource.MoveLast()
        Me.FechaIniDateTimePicker.Value = Now
        Me.FechafinDateTimePicker.Value = Now
    End Sub

    Private Sub BindingNavigatorAddNewItem1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BindingNavigatorAddNewItem1.MouseUp
        Me.IncapacidadesBindingSource.Current.item("fechaini") = Me.FechaIniDateTimePicker.Value
        Me.IncapacidadesBindingSource.Current.item("fechafin") = Me.FechafinDateTimePicker.Value
    End Sub
    Private Sub Id_tipoComboBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Id_tipoComboBox.Leave
        Select Case Id_tipoComboBox.Text
            Case "CCSS"
                Me.DiasTextBox.MaxValue = 31
            Case "CCSS Maternidad"
                Me.DiasTextBox.MaxValue = 365
            Case "INS"
                Me.DiasTextBox.MaxValue = 0
        End Select
        Dim incap As New Incapacidades(Me.DiasTextBox.Text, Me.ComboBox1.SelectedValue)
        Me.MontoTextBox.Text = incap.monto(Me.Id_tipoComboBox.SelectedValue)
    End Sub
    Private Sub FechafinDateTimePicker_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles FechafinDateTimePicker.Leave
        Me.DiasTextBox.Text = Me.FechafinDateTimePicker.Value.Subtract(Me.FechaIniDateTimePicker.Value).TotalDays + 1
        Dim incap As New Incapacidades(Me.DiasTextBox.Text, Me.ComboBox1.SelectedValue)
        Me.MontoTextBox.Text = incap.monto(Me.Id_tipoComboBox.SelectedValue)
    End Sub
    Private Sub DiasTextBox_ValueChanged(sender As Object, e As EventArgs) Handles DiasTextBox.ValueChanged
        Dim incap As New Incapacidades(Me.DiasTextBox.Text, Me.ComboBox1.SelectedValue)
        Me.MontoTextBox.Text = incap.monto(Me.Id_tipoComboBox.SelectedValue)
    End Sub

    Private Sub BindingNavigatorAddNewItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem1.Click
        Me.FechaIniDateTimePicker.Value = Now
        Me.FechafinDateTimePicker.Value = Now
    End Sub

    Private Sub FechaIniDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FechaIniDateTimePicker.ValueChanged
        Me.DiasTextBox.Text = Me.FechafinDateTimePicker.Value.Subtract(Me.FechaIniDateTimePicker.Value).TotalDays + 1
    End Sub

    Private Sub FechafinDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FechafinDateTimePicker.ValueChanged
        Me.DiasTextBox.Text = Me.FechafinDateTimePicker.Value.Subtract(Me.FechaIniDateTimePicker.Value).TotalDays + 1
    End Sub
End Class
