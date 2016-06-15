Public Class frmVacaXPlanilla


    Dim dsPlanilla1 As New dsPlanilla
    Dim dsVac1 As New dsVacaciones

    Dim taDepart As New dsPlanillaTableAdapters.departamentoTableAdapter
    Dim taContratos As New dsVacacionesTableAdapters.ContratosActivosTableAdapter

    Private Sub frmVacaXPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        taDepart.Fill(dsPlanilla1.departamento)
        ListBoxAdv1.DataSource = dsPlanilla1.departamento
        ListBoxAdv1.DisplayMember = "nombre"

        DataGridViewX1.DataSource = dsVac1.ContratosActivos
        Periodo.Value = Now.Year

        fechaI_ord.Value = Now
        fechaF_ord.Value = Now.AddDays(6)

        fechaI_Adic.Value = fechaF_ord.Value.AddDays(1)
        fechaF_Adic.Value = fechaF_ord.Value.AddDays(7)
    End Sub

    Private Sub frmVacaXPlanilla_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        If ListBoxAdv1.SelectedItem IsNot Nothing Then
            taContratos.Fill(dsVac1.ContratosActivos, ListBoxAdv1.SelectedItem.row.id_dpto, Periodo.Value)
            Verifica_derechos()
        End If
    End Sub

    Private Sub ListBoxAdv1_ItemClick(sender As Object, e As EventArgs) Handles ListBoxAdv1.ItemClick
        taContratos.Fill(dsVac1.ContratosActivos, ListBoxAdv1.SelectedItem.row.id_dpto, Periodo.Value)
        Verifica_derechos()
    End Sub

    Private Sub Verifica_derechos()
        For Each row As DataGridViewRow In DataGridViewX1.Rows
            Select Case row.Cells(5).Value
                Case 0
                    row.DefaultCellStyle.BackColor = Color.LightPink
                Case < DiasRango.Value
                    row.DefaultCellStyle.BackColor = Color.Yellow
                Case Else
                    row.DefaultCellStyle.BackColor = Color.White
                    row.Selected = True
            End Select
        Next
    End Sub


#Region "ordinario"
    Private Function dias() As Integer
        Dim saldox As Integer = DateDiff(DateInterval.Day, fechaI_ord.Value, fechaF_ord.Value) + 1
        Return (saldox)
    End Function

    Private Sub DateTimeInput1_ValueChanged(sender As Object, e As EventArgs) Handles fechaI_ord.ValueChanged
        DiasRango.Value = dias()
        Verifica_derechos()
    End Sub

    Private Sub DateTimeInput2_ValueChanged(sender As Object, e As EventArgs) Handles fechaF_ord.ValueChanged
        DiasRango.Value = dias()
        Verifica_derechos()
    End Sub

#End Region

#Region "Adicionales"
    Private Sub fechaI_Adic_ValueChanged(sender As Object, e As EventArgs) Handles fechaI_Adic.ValueChanged
        DiasRangoAdic.Value = diasAdicionales()
    End Sub

    Private Sub fechaF_Adic_ValueChanged(sender As Object, e As EventArgs) Handles fechaF_Adic.ValueChanged
        DiasRangoAdic.Value = diasAdicionales()
    End Sub
    Private Function diasAdicionales() As Integer
        Dim saldox As Integer = DateDiff(DateInterval.Day, fechaI_Adic.Value, fechaF_Adic.Value) + 1
        Return (saldox)
    End Function

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim Vacacion_regTableAdapter As New Planilla.dsVacacionesTableAdapters.Vacacion_regTableAdapter
        Dim _id As Integer
        For Each fila As DataGridViewRow In DataGridViewX1.SelectedRows
            _id = fila.DataBoundItem.row.id_vacacion
            Vacacion_regTableAdapter.Insertar(_id, DiasRango.Value, nota.Text, fechaI_ord.Value, fechaF_ord.Value, motivo.Text, fechaI_Adic.Value, fechaF_Adic.Value)

        Next

        'TODO carta

        taContratos.Fill(dsVac1.ContratosActivos, ListBoxAdv1.SelectedItem.row.id_dpto, Periodo.Value)
        Verifica_derechos()
    End Sub

#End Region


End Class