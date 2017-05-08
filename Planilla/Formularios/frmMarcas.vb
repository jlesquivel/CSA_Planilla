Public Class frmMarcas
    Private Sub frmMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAno()
        CargarMeses()
        CargarPuestos()
        ContratosActivosTableAdapter.Fill(PlanillaDataSet1.ContratosActivos)
        SeleccionaTodos()
    End Sub


    Sub CargarAno()
        cbAno.Items.Add(Now.Year - 1)
        cbAno.Items.Add(Now.Year)
        cbAno.SelectedIndex = 1
    End Sub

    Sub CargarMeses()
        For i As Integer = 1 To 12
            cbMes.Items.Add(MonthName(i, False))
        Next
        cbMes.SelectedIndex = Now.Month - 1
    End Sub

    Sub CargarPuestos()
        Me.Puestos_ContratosActivosTableAdapter1.Fill(Me.PlanillaDataSet1.puestos_ContratosActivos)
        cbDpto.SelectedIndex = -1
    End Sub


    Private Sub cbDpto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDpto.SelectedIndexChanged
        ContratosActivosTableAdapter.FillByIdPuesto(PlanillaDataSet1.ContratosActivos, cbDpto.SelectedValue)
        SeleccionaTodos()

    End Sub

    Sub SeleccionaTodos()

        If ContratosActivosBindingSource.List.Count > 0 Then
            For i As Integer = 0 To ContratosActivosBindingSource.List.Count - 1
                ListBoxAdv1.SetItemCheckState(i, CheckState.Checked)
            Next
        End If
    End Sub

    Private Sub bReporte_Click(sender As Object, e As EventArgs) Handles bReporte.Click
        Dim rpt As New Reportes()

        Dim rptMarcas As New rptMarcasGuardas

        rpt.inserta_parametro(rptMarcas, "ano", CInt(cbAno.Text))
        rpt.inserta_parametro(rptMarcas, "mes", cbMes.SelectedIndex + 1)

        Dim datos As Array = ListaSeleccionado(ListBoxAdv1.CheckedItems)
        rptMarcas.SetParameterValue("@ced", datos)

        ''rpt.inserta_parametro_multivalores(rptMarcas, "@ced", datos)
        rpt.AsignaDatoServidor(rptMarcas, "servidor-bd", "BIT", "sa", "123")
        CrystalReportViewer1.ReportSource = rptMarcas

    End Sub

    Function ListaSeleccionado(datos As List(Of DevComponents.DotNetBar.ListBoxItem)) As Array

        Dim result As New List(Of String)

        For Each ele As DevComponents.DotNetBar.ListBoxItem In datos
            result.Add(ele.Tag.dataitem.row.cedula)
        Next

        Return result.ToArray
    End Function





End Class