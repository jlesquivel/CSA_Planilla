<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cPagos
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ContratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlanillaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PagosEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillaDataSet = New Planilla.planillaDataSet
        Me.PagosEmpleadoTableAdapter = New Planilla.planillaDataSetTableAdapters.PagosEmpleadoTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ContratoDataGridViewTextBoxColumn, Me.PlanillaDataGridViewTextBoxColumn, Me.FechaInicio, Me.FechaFin, Me.MontoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PagosEmpleadoBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 21
        Me.DataGridView1.Size = New System.Drawing.Size(357, 257)
        Me.DataGridView1.TabIndex = 0
        '
        'ContratoDataGridViewTextBoxColumn
        '
        Me.ContratoDataGridViewTextBoxColumn.DataPropertyName = "Contrato"
        Me.ContratoDataGridViewTextBoxColumn.HeaderText = "Contrato"
        Me.ContratoDataGridViewTextBoxColumn.Name = "ContratoDataGridViewTextBoxColumn"
        Me.ContratoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContratoDataGridViewTextBoxColumn.Width = 50
        '
        'PlanillaDataGridViewTextBoxColumn
        '
        Me.PlanillaDataGridViewTextBoxColumn.DataPropertyName = "Planilla"
        Me.PlanillaDataGridViewTextBoxColumn.HeaderText = "Planilla"
        Me.PlanillaDataGridViewTextBoxColumn.Name = "PlanillaDataGridViewTextBoxColumn"
        Me.PlanillaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PlanillaDataGridViewTextBoxColumn.Width = 50
        '
        'FechaInicio
        '
        Me.FechaInicio.DataPropertyName = "FechaInicio"
        Me.FechaInicio.HeaderText = "Fecha Inicio"
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.ReadOnly = True
        Me.FechaInicio.Width = 75
        '
        'FechaFin
        '
        Me.FechaFin.DataPropertyName = "FechaFin"
        Me.FechaFin.HeaderText = "Fecha Fin"
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.ReadOnly = True
        Me.FechaFin.Width = 75
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagosEmpleadoBindingSource
        '
        Me.PagosEmpleadoBindingSource.DataMember = "PagosEmpleado"
        Me.PagosEmpleadoBindingSource.DataSource = Me.PlanillaDataSet
        '
        'PlanillaDataSet
        '
        Me.PlanillaDataSet.DataSetName = "planillaDataSet"
        Me.PlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PagosEmpleadoTableAdapter
        '
        Me.PagosEmpleadoTableAdapter.ClearBeforeFill = True
        '
        'cPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "cPagos"
        Me.Size = New System.Drawing.Size(357, 257)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PagosEmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanillaDataSet As Planilla.planillaDataSet
    Friend WithEvents PagosEmpleadoTableAdapter As Planilla.planillaDataSetTableAdapters.PagosEmpleadoTableAdapter
    Friend WithEvents ContratoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlanillaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
