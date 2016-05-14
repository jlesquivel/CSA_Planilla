Public Class frmAusencias
    Dim conn As New conexionSQL

    Private Sub AusenciasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AusenciasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AusenciasBindingSource.EndEdit()
        Me.AusenciasTableAdapter.Update(Me.PlanillaDataSet.ausencias)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_empleados_contratadosTableAdapter.Connection = conn.conexion
        AusenciasTableAdapter.Connection = conn.conexion

        Me.V_empleados_contratadosTableAdapter.Fill(Me.PlanillaDataSet.v_empleados_contratados)
        Me.AusenciasTableAdapter.Fill(Me.PlanillaDataSet.ausencias)
        Me.AusenciasBindingSource.MoveLast()
    End Sub

    Private Sub FechafinDateTimePicker_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles FechafinDateTimePicker.Leave

        Me.DiasTextBox.Text = Me.FechafinDateTimePicker.Value.Subtract(Me.FechaIniDateTimePicker.Value).TotalDays + 1
        Dim ausencias As New Ausencias(Me.DiasTextBox.Text, Me.ComboBox1.SelectedValue)
        Me.MontoTextBox.Text = ausencias.monto()
    End Sub

    Private Sub BindingNavigatorAddNewItem_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BindingNavigatorAddNewItem.MouseUp
        Me.FechaIniDateTimePicker.Value = Now.Date
        Me.FechafinDateTimePicker.Value = Now.Date
        Me.AusenciasBindingSource.Current.item("fechaini") = Me.FechaIniDateTimePicker.Value
        Me.AusenciasBindingSource.Current.item("fechafin") = Me.FechafinDateTimePicker.Value
    End Sub

    Private Sub DoubleInput1_ValueChanged(sender As Object, e As EventArgs) Handles DiasTextBox.ValueChanged
        Dim ausencias As New Ausencias(Me.DiasTextBox.Text, Me.ComboBox1.SelectedValue)
        Me.MontoTextBox.Text = ausencias.monto()
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        If ComboBox1.SelectedValue IsNot Nothing Then
            Dim id_contrato = Me.ComboBox1.SelectedValue
            Dim ausencias As New Ausencias("1", id_contrato)
            LabelDias.Text = ausencias._unidades
            LabelValor.Text = String.Format("{0:C2}", ausencias._base)

        End If
    End Sub
End Class
