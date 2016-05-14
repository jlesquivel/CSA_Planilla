Public Class frmPlanillaAgregaRubro
    Dim id_pago As Decimal



    Sub New(pid_pago As Decimal)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        id_pago = pid_pago

    End Sub
    Private Sub frmPlanillaAgregaRubro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RubrosTableAdapter.FillBy(PlanillaDataSet.rubros, id_pago)

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim pagoDetalleTA As New planillaDataSetTableAdapters.pagos_detalleTableAdapter
        pagoDetalleTA.Insert(id_pago, ListBoxAdv1.SelectedValue, 0, 0)

        Close()
    End Sub
End Class