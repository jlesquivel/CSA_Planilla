<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncapacidades
    Inherits Planilla.frm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_contratoLabel As System.Windows.Forms.Label
        Dim FechaIniLabel As System.Windows.Forms.Label
        Dim FechafinLabel As System.Windows.Forms.Label
        Dim Id_tipoLabel As System.Windows.Forms.Label
        Dim MontoLabel As System.Windows.Forms.Label
        Dim DiasLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncapacidades))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.MontoTextBox = New DevComponents.Editors.DoubleInput()
        Me.IncapacidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillaDataSet = New Planilla.planillaDataSet()
        Me.DiasTextBox = New DevComponents.Editors.DoubleInput()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.VempleadoscontratadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.FechaIniDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechafinDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Id_tipoComboBox = New System.Windows.Forms.ComboBox()
        Me.IncapacidadesTipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.IncapacidadesTipoDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncapacidadesTipoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IncapacidadesTipoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.IncapacidadesTipoTableAdapter = New Planilla.planillaDataSetTableAdapters.incapacidadesTipoTableAdapter()
        Me.IncapacidadesTableAdapter = New Planilla.planillaDataSetTableAdapters.IncapacidadesTableAdapter()
        Me.IncapacidadesTipoIncapacidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_empleados_contratadosTableAdapter = New Planilla.planillaDataSetTableAdapters.v_empleados_contratadosTableAdapter()
        Id_contratoLabel = New System.Windows.Forms.Label()
        FechaIniLabel = New System.Windows.Forms.Label()
        FechafinLabel = New System.Windows.Forms.Label()
        Id_tipoLabel = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        DiasLabel = New System.Windows.Forms.Label()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.MontoTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncapacidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiasTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VempleadoscontratadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.IncapacidadesTipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.IncapacidadesTipoDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncapacidadesTipoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IncapacidadesTipoBindingNavigator.SuspendLayout()
        CType(Me.IncapacidadesTipoIncapacidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_contratoLabel
        '
        Id_contratoLabel.AutoSize = True
        Id_contratoLabel.BackColor = System.Drawing.Color.Transparent
        Id_contratoLabel.Location = New System.Drawing.Point(35, 54)
        Id_contratoLabel.Name = "Id_contratoLabel"
        Id_contratoLabel.Size = New System.Drawing.Size(50, 13)
        Id_contratoLabel.TabIndex = 2
        Id_contratoLabel.Text = "Contrato:"
        '
        'FechaIniLabel
        '
        FechaIniLabel.AutoSize = True
        FechaIniLabel.BackColor = System.Drawing.Color.Transparent
        FechaIniLabel.Location = New System.Drawing.Point(20, 108)
        FechaIniLabel.Name = "FechaIniLabel"
        FechaIniLabel.Size = New System.Drawing.Size(65, 13)
        FechaIniLabel.TabIndex = 4
        FechaIniLabel.Text = "fecha Inicio:"
        '
        'FechafinLabel
        '
        FechafinLabel.AutoSize = True
        FechafinLabel.BackColor = System.Drawing.Color.Transparent
        FechafinLabel.Location = New System.Drawing.Point(31, 134)
        FechafinLabel.Name = "FechafinLabel"
        FechafinLabel.Size = New System.Drawing.Size(54, 13)
        FechafinLabel.TabIndex = 6
        FechafinLabel.Text = "fecha Fin:"
        '
        'Id_tipoLabel
        '
        Id_tipoLabel.AutoSize = True
        Id_tipoLabel.BackColor = System.Drawing.Color.Transparent
        Id_tipoLabel.Location = New System.Drawing.Point(46, 81)
        Id_tipoLabel.Name = "Id_tipoLabel"
        Id_tipoLabel.Size = New System.Drawing.Size(39, 13)
        Id_tipoLabel.TabIndex = 8
        Id_tipoLabel.Text = "Id tipo:"
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.BackColor = System.Drawing.Color.Transparent
        MontoLabel.Location = New System.Drawing.Point(46, 188)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(39, 13)
        MontoLabel.TabIndex = 12
        MontoLabel.Text = "monto:"
        '
        'DiasLabel
        '
        DiasLabel.AutoSize = True
        DiasLabel.BackColor = System.Drawing.Color.Transparent
        DiasLabel.Location = New System.Drawing.Point(56, 157)
        DiasLabel.Name = "DiasLabel"
        DiasLabel.Size = New System.Drawing.Size(29, 13)
        DiasLabel.TabIndex = 14
        DiasLabel.Text = "dias:"
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ForeColor = System.Drawing.Color.Black
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(450, 393)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.AutoScroll = True
        Me.TabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.TabControlPanel1.Controls.Add(Me.MontoTextBox)
        Me.TabControlPanel1.Controls.Add(Me.DiasTextBox)
        Me.TabControlPanel1.Controls.Add(DiasLabel)
        Me.TabControlPanel1.Controls.Add(Me.ComboBox1)
        Me.TabControlPanel1.Controls.Add(Me.BindingNavigator1)
        Me.TabControlPanel1.Controls.Add(Id_contratoLabel)
        Me.TabControlPanel1.Controls.Add(FechaIniLabel)
        Me.TabControlPanel1.Controls.Add(Me.FechaIniDateTimePicker)
        Me.TabControlPanel1.Controls.Add(FechafinLabel)
        Me.TabControlPanel1.Controls.Add(Me.FechafinDateTimePicker)
        Me.TabControlPanel1.Controls.Add(Id_tipoLabel)
        Me.TabControlPanel1.Controls.Add(Me.Id_tipoComboBox)
        Me.TabControlPanel1.Controls.Add(MontoLabel)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(450, 366)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 0
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'MontoTextBox
        '
        '
        '
        '
        Me.MontoTextBox.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.MontoTextBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MontoTextBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.MontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncapacidadesBindingSource, "monto", True))
        Me.MontoTextBox.DisplayFormat = "C"
        Me.MontoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoTextBox.Increment = 1.0R
        Me.MontoTextBox.Location = New System.Drawing.Point(91, 186)
        Me.MontoTextBox.Name = "MontoTextBox"
        Me.MontoTextBox.Size = New System.Drawing.Size(139, 26)
        Me.MontoTextBox.TabIndex = 5
        '
        'IncapacidadesBindingSource
        '
        Me.IncapacidadesBindingSource.DataMember = "Incapacidades"
        Me.IncapacidadesBindingSource.DataSource = Me.PlanillaDataSet
        '
        'PlanillaDataSet
        '
        Me.PlanillaDataSet.DataSetName = "planillaDataSet"
        Me.PlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DiasTextBox
        '
        '
        '
        '
        Me.DiasTextBox.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DiasTextBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DiasTextBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DiasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncapacidadesBindingSource, "dias", True))
        Me.DiasTextBox.DisplayFormat = "0.00"
        Me.DiasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiasTextBox.Increment = 0.5R
        Me.DiasTextBox.Location = New System.Drawing.Point(91, 160)
        Me.DiasTextBox.MaxValue = 31.0R
        Me.DiasTextBox.MinValue = 1.0R
        Me.DiasTextBox.Name = "DiasTextBox"
        Me.DiasTextBox.ShowUpDown = True
        Me.DiasTextBox.Size = New System.Drawing.Size(139, 22)
        Me.DiasTextBox.TabIndex = 4
        Me.DiasTextBox.Value = 1.0R
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IncapacidadesBindingSource, "id_contrato", True))
        Me.ComboBox1.DataSource = Me.VempleadoscontratadosBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(91, 46)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(322, 24)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "id_contrato"
        '
        'VempleadoscontratadosBindingSource
        '
        Me.VempleadoscontratadosBindingSource.DataMember = "v_empleados_contratados"
        Me.VempleadoscontratadosBindingSource.DataSource = Me.PlanillaDataSet
        Me.VempleadoscontratadosBindingSource.Sort = "nombre"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BackColor = System.Drawing.Color.AliceBlue
        Me.BindingNavigator1.BindingSource = Me.IncapacidadesBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(1, 1)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BindingNavigator1.Size = New System.Drawing.Size(448, 25)
        Me.BindingNavigator1.TabIndex = 14
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem1.Text = "de {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Mover último"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Guardar Datos"
        '
        'FechaIniDateTimePicker
        '
        Me.FechaIniDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IncapacidadesBindingSource, "fechaIni", True))
        Me.FechaIniDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaIniDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaIniDateTimePicker.Location = New System.Drawing.Point(91, 106)
        Me.FechaIniDateTimePicker.Name = "FechaIniDateTimePicker"
        Me.FechaIniDateTimePicker.Size = New System.Drawing.Size(139, 22)
        Me.FechaIniDateTimePicker.TabIndex = 2
        '
        'FechafinDateTimePicker
        '
        Me.FechafinDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IncapacidadesBindingSource, "fechafin", True))
        Me.FechafinDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechafinDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechafinDateTimePicker.Location = New System.Drawing.Point(91, 132)
        Me.FechafinDateTimePicker.Name = "FechafinDateTimePicker"
        Me.FechafinDateTimePicker.Size = New System.Drawing.Size(139, 22)
        Me.FechafinDateTimePicker.TabIndex = 3
        '
        'Id_tipoComboBox
        '
        Me.Id_tipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IncapacidadesBindingSource, "Id_tipo", True))
        Me.Id_tipoComboBox.DataSource = Me.IncapacidadesTipoBindingSource
        Me.Id_tipoComboBox.DisplayMember = "Nombre"
        Me.Id_tipoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_tipoComboBox.FormattingEnabled = True
        Me.Id_tipoComboBox.Location = New System.Drawing.Point(91, 76)
        Me.Id_tipoComboBox.Name = "Id_tipoComboBox"
        Me.Id_tipoComboBox.Size = New System.Drawing.Size(139, 24)
        Me.Id_tipoComboBox.TabIndex = 1
        Me.Id_tipoComboBox.ValueMember = "id_tipo"
        '
        'IncapacidadesTipoBindingSource
        '
        Me.IncapacidadesTipoBindingSource.DataMember = "incapacidadesTipo"
        Me.IncapacidadesTipoBindingSource.DataSource = Me.PlanillaDataSet
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Incapacidades"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.AutoScroll = True
        Me.TabControlPanel2.Controls.Add(Me.IncapacidadesTipoDataGridViewX)
        Me.TabControlPanel2.Controls.Add(Me.IncapacidadesTipoBindingNavigator)
        Me.TabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(450, 366)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'IncapacidadesTipoDataGridViewX
        '
        Me.IncapacidadesTipoDataGridViewX.AutoGenerateColumns = False
        Me.IncapacidadesTipoDataGridViewX.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.IncapacidadesTipoDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IncapacidadesTipoDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.IncapacidadesTipoDataGridViewX.DataSource = Me.IncapacidadesTipoBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IncapacidadesTipoDataGridViewX.DefaultCellStyle = DataGridViewCellStyle2
        Me.IncapacidadesTipoDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.IncapacidadesTipoDataGridViewX.Location = New System.Drawing.Point(0, 29)
        Me.IncapacidadesTipoDataGridViewX.Name = "IncapacidadesTipoDataGridViewX"
        Me.IncapacidadesTipoDataGridViewX.RowHeadersVisible = False
        Me.IncapacidadesTipoDataGridViewX.Size = New System.Drawing.Size(387, 222)
        Me.IncapacidadesTipoDataGridViewX.TabIndex = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "formula"
        Me.DataGridViewTextBoxColumn3.HeaderText = "formula"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'IncapacidadesTipoBindingNavigator
        '
        Me.IncapacidadesTipoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.IncapacidadesTipoBindingNavigator.BackColor = System.Drawing.Color.AliceBlue
        Me.IncapacidadesTipoBindingNavigator.BindingSource = Me.IncapacidadesTipoBindingSource
        Me.IncapacidadesTipoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.IncapacidadesTipoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.IncapacidadesTipoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.IncapacidadesTipoBindingNavigatorSaveItem})
        Me.IncapacidadesTipoBindingNavigator.Location = New System.Drawing.Point(1, 1)
        Me.IncapacidadesTipoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.IncapacidadesTipoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.IncapacidadesTipoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.IncapacidadesTipoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.IncapacidadesTipoBindingNavigator.Name = "IncapacidadesTipoBindingNavigator"
        Me.IncapacidadesTipoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.IncapacidadesTipoBindingNavigator.Size = New System.Drawing.Size(448, 25)
        Me.IncapacidadesTipoBindingNavigator.TabIndex = 1
        Me.IncapacidadesTipoBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'IncapacidadesTipoBindingNavigatorSaveItem
        '
        Me.IncapacidadesTipoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IncapacidadesTipoBindingNavigatorSaveItem.Image = CType(resources.GetObject("IncapacidadesTipoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.IncapacidadesTipoBindingNavigatorSaveItem.Name = "IncapacidadesTipoBindingNavigatorSaveItem"
        Me.IncapacidadesTipoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.IncapacidadesTipoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Tipos de Incapacidad"
        '
        'IncapacidadesTipoTableAdapter
        '
        Me.IncapacidadesTipoTableAdapter.ClearBeforeFill = True
        '
        'IncapacidadesTableAdapter
        '
        Me.IncapacidadesTableAdapter.ClearBeforeFill = True
        '
        'IncapacidadesTipoIncapacidadesBindingSource
        '
        Me.IncapacidadesTipoIncapacidadesBindingSource.DataMember = "incapacidadesTipo_Incapacidades"
        Me.IncapacidadesTipoIncapacidadesBindingSource.DataSource = Me.IncapacidadesTipoBindingSource
        '
        'V_empleados_contratadosTableAdapter
        '
        Me.V_empleados_contratadosTableAdapter.ClearBeforeFill = True
        '
        'frmIncapacidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(450, 393)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Name = "frmIncapacidades"
        Me.Text = "Incapacidades"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.MontoTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncapacidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiasTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VempleadoscontratadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.IncapacidadesTipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        Me.TabControlPanel2.PerformLayout()
        CType(Me.IncapacidadesTipoDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncapacidadesTipoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IncapacidadesTipoBindingNavigator.ResumeLayout(False)
        Me.IncapacidadesTipoBindingNavigator.PerformLayout()
        CType(Me.IncapacidadesTipoIncapacidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents PlanillaDataSet As Planilla.planillaDataSet
    Friend WithEvents IncapacidadesTipoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IncapacidadesTipoTableAdapter As Planilla.planillaDataSetTableAdapters.incapacidadesTipoTableAdapter
    Friend WithEvents IncapacidadesTipoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents IncapacidadesTipoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IncapacidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IncapacidadesTableAdapter As Planilla.planillaDataSetTableAdapters.IncapacidadesTableAdapter
    Friend WithEvents FechaIniDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechafinDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Id_tipoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IncapacidadesTipoIncapacidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents VempleadoscontratadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents V_empleados_contratadosTableAdapter As Planilla.planillaDataSetTableAdapters.v_empleados_contratadosTableAdapter
    Friend WithEvents IncapacidadesTipoDataGridViewX As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasTextBox As DevComponents.Editors.DoubleInput
    Friend WithEvents MontoTextBox As DevComponents.Editors.DoubleInput

End Class
