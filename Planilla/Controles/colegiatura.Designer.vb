<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class colegiatura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(colegiatura))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PlanillaDataSet = New Planilla.planillaDataSet
        Me.ColegiaturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColegiaturaTableAdapter = New Planilla.planillaDataSetTableAdapters.colegiaturaTableAdapter
        Me.ColegiaturaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ColegiaturaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ColegiaturaDataGridView = New System.Windows.Forms.DataGridView
        Me.VempleadoscontratadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_empleados_contratadosTableAdapter = New Planilla.planillaDataSetTableAdapters.v_empleados_contratadosTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColegiaturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColegiaturaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ColegiaturaBindingNavigator.SuspendLayout()
        CType(Me.ColegiaturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VempleadoscontratadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlanillaDataSet
        '
        Me.PlanillaDataSet.DataSetName = "planillaDataSet"
        Me.PlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ColegiaturaBindingSource
        '
        Me.ColegiaturaBindingSource.DataMember = "colegiatura"
        Me.ColegiaturaBindingSource.DataSource = Me.PlanillaDataSet
        '
        'ColegiaturaTableAdapter
        '
        Me.ColegiaturaTableAdapter.ClearBeforeFill = True
        '
        'ColegiaturaBindingNavigator
        '
        Me.ColegiaturaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ColegiaturaBindingNavigator.BackColor = System.Drawing.Color.AliceBlue
        Me.ColegiaturaBindingNavigator.BindingSource = Me.ColegiaturaBindingSource
        Me.ColegiaturaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ColegiaturaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ColegiaturaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ColegiaturaBindingNavigatorSaveItem})
        Me.ColegiaturaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ColegiaturaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ColegiaturaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ColegiaturaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ColegiaturaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ColegiaturaBindingNavigator.Name = "ColegiaturaBindingNavigator"
        Me.ColegiaturaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ColegiaturaBindingNavigator.Size = New System.Drawing.Size(418, 25)
        Me.ColegiaturaBindingNavigator.TabIndex = 0
        Me.ColegiaturaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 20)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ColegiaturaBindingNavigatorSaveItem
        '
        Me.ColegiaturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ColegiaturaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ColegiaturaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ColegiaturaBindingNavigatorSaveItem.Name = "ColegiaturaBindingNavigatorSaveItem"
        Me.ColegiaturaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ColegiaturaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ColegiaturaDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.ColegiaturaDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ColegiaturaDataGridView.AutoGenerateColumns = False
        Me.ColegiaturaDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColegiaturaDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ColegiaturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ColegiaturaDataGridView.DataSource = Me.ColegiaturaBindingSource
        Me.ColegiaturaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColegiaturaDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.ColegiaturaDataGridView.Name = "ColegiaturaDataGridView"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColegiaturaDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ColegiaturaDataGridView.RowHeadersWidth = 21
        Me.ColegiaturaDataGridView.Size = New System.Drawing.Size(418, 440)
        Me.ColegiaturaDataGridView.TabIndex = 1
        '
        'VempleadoscontratadosBindingSource
        '
        Me.VempleadoscontratadosBindingSource.DataMember = "v_empleados_contratados"
        Me.VempleadoscontratadosBindingSource.DataSource = Me.PlanillaDataSet
        '
        'V_empleados_contratadosTableAdapter
        '
        Me.V_empleados_contratadosTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_contrato"
        Me.DataGridViewTextBoxColumn1.DataSource = Me.VempleadoscontratadosBindingSource
        Me.DataGridViewTextBoxColumn1.DisplayMember = "nombre"
        Me.DataGridViewTextBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewTextBoxColumn1.HeaderText = "Empleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.ValueMember = "id_contrato"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "carnet"
        Me.DataGridViewTextBoxColumn2.HeaderText = "carnet"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "monto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n2"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "monto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'colegiatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ColegiaturaDataGridView)
        Me.Controls.Add(Me.ColegiaturaBindingNavigator)
        Me.Name = "colegiatura"
        Me.Size = New System.Drawing.Size(418, 465)
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColegiaturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColegiaturaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ColegiaturaBindingNavigator.ResumeLayout(False)
        Me.ColegiaturaBindingNavigator.PerformLayout()
        CType(Me.ColegiaturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VempleadoscontratadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlanillaDataSet As Planilla.planillaDataSet
    Friend WithEvents ColegiaturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ColegiaturaTableAdapter As Planilla.planillaDataSetTableAdapters.colegiaturaTableAdapter
    Friend WithEvents ColegiaturaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ColegiaturaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColegiaturaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VempleadoscontratadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents V_empleados_contratadosTableAdapter As Planilla.planillaDataSetTableAdapters.v_empleados_contratadosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
