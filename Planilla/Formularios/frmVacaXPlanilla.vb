Imports System.ComponentModel

Public Class frmVacaXPlanilla


    Dim dsPlanilla1 As New dsPlanilla
    Dim dsVac1 As New dsVacaciones
    Dim Adicionales As Boolean = True

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

        FechaCarta.MinDate = Now

    End Sub


    Private Sub frmVacaXPlanilla_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        taContratos.Fill(dsVac1.ContratosActivos, ListBoxAdv1.SelectedItem.row.id_dpto, Periodo.Value)
        Verifica_derechos()
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
                    row.DefaultCellStyle.BackColor = Color.LightYellow
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

    Private Sub bt_crear_Click(sender As Object, e As EventArgs) Handles bt_crear.Click
        Dim Vacacion_regTableAdapter As New Planilla.dsVacacionesTableAdapters.Vacacion_regTableAdapter
        Dim _id_vac, _id_emp As Integer
        Dim oVacacion As New cVacaciones

        UcProgresoCircular1.Muestra()

        For Each fila As DataGridViewRow In DataGridViewX1.SelectedRows
            _id_vac = fila.DataBoundItem.row.id_vacacion
            _id_emp = fila.DataBoundItem.row.id_emp

            If Adicionales Then
                Vacacion_regTableAdapter.Insertar(_id_vac, DiasRango.Value, nota.Text, fechaI_ord.Value, fechaF_ord.Value, motivo.Text, fechaI_Adic.Value, fechaF_Adic.Value, FechaCarta.Value)
            Else
                Vacacion_regTableAdapter.Insertar(_id_vac, DiasRango.Value, nota.Text, fechaI_ord.Value, fechaF_ord.Value, motivo.Text, Nothing, Nothing, FechaCarta.Value)
            End If

        Next

        UcProgresoCircular1.Oculta()

        taContratos.Fill(dsVac1.ContratosActivos, ListBoxAdv1.SelectedItem.row.id_dpto, Periodo.Value)
        Verifica_derechos()
    End Sub

    Private Sub bt_carta_Click(sender As Object, e As EventArgs) Handles bt_carta.Click

        UcProgresoCircular1.Muestra()
        UcProgresoCircular1.CircularProgress1.ProgressTextVisible = True

        '        Cursor.Hide()
        If Not hilo.IsBusy Then
            hilo.RunWorkerAsync()
        End If
    End Sub


    Private Sub hilo_DoWork(sender As Object, e As DoWorkEventArgs) Handles hilo.DoWork
        Dim Vacacion_regTableAdapter As New Planilla.dsVacacionesTableAdapters.Vacacion_regTableAdapter
        Dim dsVaca As New dsVacaciones

        Dim _id_vac, _id_emp As Integer
        Dim oVacacion As New cVacaciones
        Dim porc As Decimal = 100 / DataGridViewX1.SelectedRows.Count
        Dim tot As Decimal

        For Each fila As DataGridViewRow In DataGridViewX1.SelectedRows
            _id_vac = fila.DataBoundItem.row.id_vacacion
            _id_emp = fila.DataBoundItem.row.id_emp
            Vacacion_regTableAdapter.FillById_emp(dsVaca.Vacacion_reg, Periodo.Value, _id_emp)
            If dsVaca.Vacacion_reg.Rows.Count > 0 Then
                oVacacion.carta(_id_emp, dsVaca.Vacacion_reg.Rows.Item(0), "Vacaciones", Adicionales)
            End If
            tot = tot + porc
            hilo.ReportProgress(tot)
        Next
    End Sub


    Private Sub hilo_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles hilo.RunWorkerCompleted
        UcProgresoCircular1.Oculta()
        'Cursor.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub hilo_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles hilo.ProgressChanged
        UcProgresoCircular1.CircularProgress1.ProgressText = CStr(e.ProgressPercentage)
    End Sub

    Private Sub SwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles SwitchButton1.ValueChanged
        Adicionales = SwitchButton1.Value
        Vac_adic(Adicionales)

    End Sub
    ''' <summary>
    ''' Desactiva los controles de vacaciones adicionales
    ''' </summary>
    ''' <param name="valor"></param>
    Sub Vac_adic(valor As Boolean)
        LabelX8.Enabled = valor
        fechaI_Adic.Enabled = valor
        fechaF_Adic.Enabled = valor
        DiasRangoAdic.Enabled = valor
    End Sub
#End Region

End Class