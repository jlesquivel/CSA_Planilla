<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLiquidacion
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Empleados_Salarios6mesesDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.id_planilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleados_Salarios6mesesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds2planilla = New Planilla.ds2planilla()
        Me.DoubleInput1 = New DevComponents.Editors.DoubleInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.DoubleInput2 = New DevComponents.Editors.DoubleInput()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.mSalarioDia = New DevComponents.Editors.DoubleInput()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.dVaca = New DevComponents.Editors.IntegerInput()
        Me.dPre = New DevComponents.Editors.IntegerInput()
        Me.dCesant = New DevComponents.Editors.IntegerInput()
        Me.mVaca = New DevComponents.Editors.DoubleInput()
        Me.mPre = New DevComponents.Editors.DoubleInput()
        Me.mCesant = New DevComponents.Editors.DoubleInput()
        Me.DateTimeInput1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.DateTimeInput2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.mAguinaldo = New DevComponents.Editors.DoubleInput()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.vdias = New DevComponents.Editors.IntegerInput()
        Me.vmeses = New DevComponents.Editors.IntegerInput()
        Me.vanos = New DevComponents.Editors.IntegerInput()
        Me.ExpandablePanel2 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SWResponPatronals = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.mTotal = New DevComponents.Editors.DoubleInput()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.SwitchButton1 = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.VacacionesDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VacacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsVacaciones = New Planilla.dsVacaciones()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.ContratosEmpleadoDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Liquidar = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.ContratosEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.VacacionesTableAdapter = New Planilla.dsVacacionesTableAdapters.VacacionesTableAdapter()
        Me.TableAdapterManager = New Planilla.dsVacacionesTableAdapters.TableAdapterManager()
        Me.Empleados_Salarios6mesesTableAdapter = New Planilla.ds2planillaTableAdapters.Empleados_Salarios6mesesTableAdapter()
        Me.AguinaldoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AguinaldoTableAdapter = New Planilla.ds2planillaTableAdapters.AguinaldoTableAdapter()
        Me.ContratosEmpleadoTableAdapter = New Planilla.ds2planillaTableAdapters.ContratosEmpleadoTableAdapter()
        Me.CuEmpleado1 = New Planilla.cuEmpleado()
        Me.BEmpleado1 = New Planilla.bEmpleado()
        CType(Me.Empleados_Salarios6mesesDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empleados_Salarios6mesesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds2planilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoubleInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoubleInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mSalarioDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dVaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dPre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dCesant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mVaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mPre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mCesant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimeInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mAguinaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpandablePanel1.SuspendLayout()
        CType(Me.vdias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vmeses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vanos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpandablePanel2.SuspendLayout()
        CType(Me.mTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.VacacionesDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel3.SuspendLayout()
        CType(Me.ContratosEmpleadoDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratosEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AguinaldoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Empleados_Salarios6mesesDataGridViewX
        '
        Me.Empleados_Salarios6mesesDataGridViewX.AllowUserToAddRows = False
        Me.Empleados_Salarios6mesesDataGridViewX.AllowUserToDeleteRows = False
        Me.Empleados_Salarios6mesesDataGridViewX.AllowUserToResizeColumns = False
        Me.Empleados_Salarios6mesesDataGridViewX.AllowUserToResizeRows = False
        Me.Empleados_Salarios6mesesDataGridViewX.AutoGenerateColumns = False
        Me.Empleados_Salarios6mesesDataGridViewX.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Empleados_Salarios6mesesDataGridViewX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Empleados_Salarios6mesesDataGridViewX.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Empleados_Salarios6mesesDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Empleados_Salarios6mesesDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_planilla, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Empleados_Salarios6mesesDataGridViewX.DataSource = Me.Empleados_Salarios6mesesBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Empleados_Salarios6mesesDataGridViewX.DefaultCellStyle = DataGridViewCellStyle4
        Me.Empleados_Salarios6mesesDataGridViewX.EnableHeadersVisualStyles = False
        Me.Empleados_Salarios6mesesDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Empleados_Salarios6mesesDataGridViewX.Location = New System.Drawing.Point(18, 48)
        Me.Empleados_Salarios6mesesDataGridViewX.Name = "Empleados_Salarios6mesesDataGridViewX"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Empleados_Salarios6mesesDataGridViewX.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Empleados_Salarios6mesesDataGridViewX.RowHeadersWidth = 22
        Me.Empleados_Salarios6mesesDataGridViewX.Size = New System.Drawing.Size(475, 369)
        Me.Empleados_Salarios6mesesDataGridViewX.TabIndex = 2
        '
        'id_planilla
        '
        Me.id_planilla.DataPropertyName = "id_planilla"
        Me.id_planilla.HeaderText = "id_planilla"
        Me.id_planilla.Name = "id_planilla"
        Me.id_planilla.ReadOnly = True
        Me.id_planilla.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ano"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ano"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "mes"
        Me.DataGridViewTextBoxColumn3.HeaderText = "mes"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "pagos"
        Me.DataGridViewTextBoxColumn4.HeaderText = "pagos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "bruto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "bruto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "neto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "neto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Empleados_Salarios6mesesBindingSource
        '
        Me.Empleados_Salarios6mesesBindingSource.DataMember = "Empleados_Salarios6meses"
        Me.Empleados_Salarios6mesesBindingSource.DataSource = Me.Ds2planilla
        Me.Empleados_Salarios6mesesBindingSource.Filter = "id_planilla is null"
        '
        'Ds2planilla
        '
        Me.Ds2planilla.DataSetName = "ds2planilla"
        Me.Ds2planilla.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.Ds2planilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DoubleInput1
        '
        Me.DoubleInput1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.DoubleInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DoubleInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DoubleInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DoubleInput1.ForeColor = System.Drawing.Color.Black
        Me.DoubleInput1.Increment = 1.0R
        Me.DoubleInput1.Location = New System.Drawing.Point(89, 39)
        Me.DoubleInput1.Name = "DoubleInput1"
        Me.DoubleInput1.Size = New System.Drawing.Size(83, 22)
        Me.DoubleInput1.TabIndex = 3
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(8, 37)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "Total Bruto"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(8, 66)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "Promedio Mesual"
        '
        'DoubleInput2
        '
        Me.DoubleInput2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.DoubleInput2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DoubleInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DoubleInput2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DoubleInput2.ForeColor = System.Drawing.Color.Black
        Me.DoubleInput2.Increment = 1.0R
        Me.DoubleInput2.Location = New System.Drawing.Point(89, 67)
        Me.DoubleInput2.Name = "DoubleInput2"
        Me.DoubleInput2.Size = New System.Drawing.Size(83, 22)
        Me.DoubleInput2.TabIndex = 5
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(8, 95)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 8
        Me.LabelX3.Text = "Salario Dia"
        '
        'mSalarioDia
        '
        Me.mSalarioDia.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.mSalarioDia.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.mSalarioDia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mSalarioDia.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.mSalarioDia.ForeColor = System.Drawing.Color.Black
        Me.mSalarioDia.Increment = 1.0R
        Me.mSalarioDia.Location = New System.Drawing.Point(89, 95)
        Me.mSalarioDia.Name = "mSalarioDia"
        Me.mSalarioDia.Size = New System.Drawing.Size(83, 22)
        Me.mSalarioDia.TabIndex = 7
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(84, 34)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(43, 23)
        Me.LabelX4.TabIndex = 9
        Me.LabelX4.Text = "DIAS"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(3, 90)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 23)
        Me.LabelX6.TabIndex = 11
        Me.LabelX6.Text = "Vacaciones"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(3, 119)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 23)
        Me.LabelX7.TabIndex = 12
        Me.LabelX7.Text = "Preaviso"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(3, 148)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(75, 23)
        Me.LabelX8.TabIndex = 13
        Me.LabelX8.Text = "Cesantía"
        '
        'dVaca
        '
        '
        '
        '
        Me.dVaca.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.dVaca.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dVaca.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dVaca.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.dVaca.Increment = 0
        Me.dVaca.Location = New System.Drawing.Point(84, 91)
        Me.dVaca.MouseWheelValueChangeEnabled = False
        Me.dVaca.Name = "dVaca"
        Me.dVaca.Size = New System.Drawing.Size(37, 22)
        Me.dVaca.TabIndex = 14
        '
        'dPre
        '
        '
        '
        '
        Me.dPre.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.dPre.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dPre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dPre.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.dPre.Increment = 0
        Me.dPre.Location = New System.Drawing.Point(84, 120)
        Me.dPre.MouseWheelValueChangeEnabled = False
        Me.dPre.Name = "dPre"
        Me.dPre.Size = New System.Drawing.Size(37, 22)
        Me.dPre.TabIndex = 15
        '
        'dCesant
        '
        '
        '
        '
        Me.dCesant.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.dCesant.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dCesant.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dCesant.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.dCesant.Increment = 0
        Me.dCesant.Location = New System.Drawing.Point(84, 148)
        Me.dCesant.MouseWheelValueChangeEnabled = False
        Me.dCesant.Name = "dCesant"
        Me.dCesant.Size = New System.Drawing.Size(37, 22)
        Me.dCesant.TabIndex = 16
        '
        'mVaca
        '
        '
        '
        '
        Me.mVaca.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.mVaca.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mVaca.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.mVaca.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mVaca.Increment = 1.0R
        Me.mVaca.IsInputReadOnly = True
        Me.mVaca.Location = New System.Drawing.Point(127, 90)
        Me.mVaca.Name = "mVaca"
        Me.mVaca.Size = New System.Drawing.Size(103, 27)
        Me.mVaca.TabIndex = 17
        '
        'mPre
        '
        '
        '
        '
        Me.mPre.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.mPre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mPre.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.mPre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mPre.Increment = 1.0R
        Me.mPre.IsInputReadOnly = True
        Me.mPre.Location = New System.Drawing.Point(127, 120)
        Me.mPre.Name = "mPre"
        Me.mPre.Size = New System.Drawing.Size(103, 27)
        Me.mPre.TabIndex = 18
        '
        'mCesant
        '
        '
        '
        '
        Me.mCesant.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.mCesant.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mCesant.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.mCesant.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mCesant.Increment = 1.0R
        Me.mCesant.IsInputReadOnly = True
        Me.mCesant.Location = New System.Drawing.Point(127, 148)
        Me.mCesant.Name = "mCesant"
        Me.mCesant.Size = New System.Drawing.Size(103, 27)
        Me.mCesant.TabIndex = 19
        '
        'DateTimeInput1
        '
        '
        '
        '
        Me.DateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimeInput1.ButtonDropDown.Visible = True
        Me.DateTimeInput1.IsPopupCalendarOpen = False
        Me.DateTimeInput1.Location = New System.Drawing.Point(208, 53)
        '
        '
        '
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateTimeInput1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.DisplayMonth = New Date(2016, 8, 1, 0, 0, 0, 0)
        Me.DateTimeInput1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.TodayButtonVisible = True
        Me.DateTimeInput1.Name = "DateTimeInput1"
        Me.DateTimeInput1.Size = New System.Drawing.Size(84, 22)
        Me.DateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimeInput1.TabIndex = 20
        Me.DateTimeInput1.Value = New Date(2016, 1, 1, 0, 0, 0, 0)
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(208, 37)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(168, 13)
        Me.LabelX9.TabIndex = 21
        Me.LabelX9.Text = "Periodo Laboral"
        '
        'DateTimeInput2
        '
        '
        '
        '
        Me.DateTimeInput2.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.DateTimeInput2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimeInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimeInput2.ButtonDropDown.Visible = True
        Me.DateTimeInput2.IsPopupCalendarOpen = False
        Me.DateTimeInput2.Location = New System.Drawing.Point(309, 53)
        '
        '
        '
        '
        '
        '
        Me.DateTimeInput2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateTimeInput2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput2.MonthCalendar.DisplayMonth = New Date(2016, 8, 1, 0, 0, 0, 0)
        Me.DateTimeInput2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimeInput2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput2.MonthCalendar.TodayButtonVisible = True
        Me.DateTimeInput2.Name = "DateTimeInput2"
        Me.DateTimeInput2.Size = New System.Drawing.Size(78, 22)
        Me.DateTimeInput2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimeInput2.TabIndex = 22
        Me.DateTimeInput2.Value = New Date(2016, 1, 1, 0, 0, 0, 0)
        '
        'mAguinaldo
        '
        '
        '
        '
        Me.mAguinaldo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.mAguinaldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mAguinaldo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.mAguinaldo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mAguinaldo.Increment = 1.0R
        Me.mAguinaldo.IsInputReadOnly = True
        Me.mAguinaldo.Location = New System.Drawing.Point(127, 62)
        Me.mAguinaldo.Name = "mAguinaldo"
        Me.mAguinaldo.Size = New System.Drawing.Size(103, 27)
        Me.mAguinaldo.TabIndex = 25
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(3, 62)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(75, 23)
        Me.LabelX10.TabIndex = 23
        Me.LabelX10.Text = "Aguinaldo"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExpandablePanel1.Controls.Add(Me.LabelX11)
        Me.ExpandablePanel1.Controls.Add(Me.vdias)
        Me.ExpandablePanel1.Controls.Add(Me.DoubleInput2)
        Me.ExpandablePanel1.Controls.Add(Me.vmeses)
        Me.ExpandablePanel1.Controls.Add(Me.DoubleInput1)
        Me.ExpandablePanel1.Controls.Add(Me.vanos)
        Me.ExpandablePanel1.Controls.Add(Me.LabelX1)
        Me.ExpandablePanel1.Controls.Add(Me.LabelX2)
        Me.ExpandablePanel1.Controls.Add(Me.mSalarioDia)
        Me.ExpandablePanel1.Controls.Add(Me.DateTimeInput1)
        Me.ExpandablePanel1.Controls.Add(Me.LabelX3)
        Me.ExpandablePanel1.Controls.Add(Me.LabelX9)
        Me.ExpandablePanel1.Controls.Add(Me.DateTimeInput2)
        Me.ExpandablePanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.ExpandablePanel1.ExpandButtonVisible = False
        Me.ExpandablePanel1.HideControlsWhenCollapsed = True
        Me.ExpandablePanel1.Location = New System.Drawing.Point(234, 137)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.ShowFocusRectangle = True
        Me.ExpandablePanel1.Size = New System.Drawing.Size(419, 136)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 26
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.White
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "INFORMACION BASE"
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(208, 81)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(108, 20)
        Me.LabelX11.TabIndex = 29
        Me.LabelX11.Text = "AÑOS   MESES   DIAS"
        '
        'vdias
        '
        '
        '
        '
        Me.vdias.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.vdias.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.vdias.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.vdias.Location = New System.Drawing.Point(285, 102)
        Me.vdias.Name = "vdias"
        Me.vdias.Size = New System.Drawing.Size(31, 22)
        Me.vdias.TabIndex = 28
        Me.vdias.WatermarkText = "dias"
        '
        'vmeses
        '
        '
        '
        '
        Me.vmeses.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.vmeses.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.vmeses.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.vmeses.Location = New System.Drawing.Point(248, 102)
        Me.vmeses.Name = "vmeses"
        Me.vmeses.Size = New System.Drawing.Size(31, 22)
        Me.vmeses.TabIndex = 27
        Me.vmeses.WatermarkText = "meses"
        '
        'vanos
        '
        '
        '
        '
        Me.vanos.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.vanos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.vanos.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.vanos.Location = New System.Drawing.Point(208, 102)
        Me.vanos.Name = "vanos"
        Me.vanos.Size = New System.Drawing.Size(31, 22)
        Me.vanos.TabIndex = 26
        Me.vanos.WatermarkText = "años"
        '
        'ExpandablePanel2
        '
        Me.ExpandablePanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExpandablePanel2.Controls.Add(Me.ButtonX1)
        Me.ExpandablePanel2.Controls.Add(Me.LabelX15)
        Me.ExpandablePanel2.Controls.Add(Me.TextBoxX1)
        Me.ExpandablePanel2.Controls.Add(Me.SWResponPatronals)
        Me.ExpandablePanel2.Controls.Add(Me.LabelX13)
        Me.ExpandablePanel2.Controls.Add(Me.mTotal)
        Me.ExpandablePanel2.Controls.Add(Me.mAguinaldo)
        Me.ExpandablePanel2.Controls.Add(Me.LabelX10)
        Me.ExpandablePanel2.Controls.Add(Me.LabelX4)
        Me.ExpandablePanel2.Controls.Add(Me.LabelX6)
        Me.ExpandablePanel2.Controls.Add(Me.LabelX7)
        Me.ExpandablePanel2.Controls.Add(Me.mCesant)
        Me.ExpandablePanel2.Controls.Add(Me.LabelX8)
        Me.ExpandablePanel2.Controls.Add(Me.mPre)
        Me.ExpandablePanel2.Controls.Add(Me.dVaca)
        Me.ExpandablePanel2.Controls.Add(Me.mVaca)
        Me.ExpandablePanel2.Controls.Add(Me.dPre)
        Me.ExpandablePanel2.Controls.Add(Me.dCesant)
        Me.ExpandablePanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.ExpandablePanel2.ExpandButtonVisible = False
        Me.ExpandablePanel2.HideControlsWhenCollapsed = True
        Me.ExpandablePanel2.Location = New System.Drawing.Point(234, 279)
        Me.ExpandablePanel2.Name = "ExpandablePanel2"
        Me.ExpandablePanel2.Size = New System.Drawing.Size(419, 225)
        Me.ExpandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel2.Style.GradientAngle = 90
        Me.ExpandablePanel2.TabIndex = 34
        Me.ExpandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel2.TitleStyle.ForeColor.Color = System.Drawing.Color.Gold
        Me.ExpandablePanel2.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel2.TitleText = "LIQUIDACIÓN"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Location = New System.Drawing.Point(237, 182)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(179, 28)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 32
        Me.ButtonX1.Text = "Guardar Liquidación"
        '
        'LabelX15
        '
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Location = New System.Drawing.Point(236, 33)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(108, 23)
        Me.LabelX15.TabIndex = 31
        Me.LabelX15.Text = "Repon. Patronal"
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(237, 62)
        Me.TextBoxX1.Multiline = True
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.PreventEnterBeep = True
        Me.TextBoxX1.Size = New System.Drawing.Size(179, 113)
        Me.TextBoxX1.TabIndex = 30
        Me.TextBoxX1.WatermarkText = "Razon de Liquidación"
        '
        'SWResponPatronals
        '
        '
        '
        '
        Me.SWResponPatronals.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SWResponPatronals.Location = New System.Drawing.Point(350, 34)
        Me.SWResponPatronals.Name = "SWResponPatronals"
        Me.SWResponPatronals.OffText = "NO"
        Me.SWResponPatronals.OnText = "SI"
        Me.SWResponPatronals.Size = New System.Drawing.Size(66, 22)
        Me.SWResponPatronals.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SWResponPatronals.SwitchBackColor = System.Drawing.Color.Yellow
        Me.SWResponPatronals.TabIndex = 29
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.FontBold = True
        Me.LabelX13.Location = New System.Drawing.Point(3, 181)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(75, 23)
        Me.LabelX13.TabIndex = 27
        Me.LabelX13.Text = "T O T A L"
        '
        'mTotal
        '
        '
        '
        '
        Me.mTotal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.mTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.mTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mTotal.Increment = 1.0R
        Me.mTotal.IsInputReadOnly = True
        Me.mTotal.Location = New System.Drawing.Point(84, 181)
        Me.mTotal.Name = "mTotal"
        Me.mTotal.Size = New System.Drawing.Size(146, 29)
        Me.mTotal.TabIndex = 26
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.BackColor = System.Drawing.Color.White
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperTabControl1.Location = New System.Drawing.Point(659, 28)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(505, 491)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 41
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2, Me.SuperTabItem3})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.AutoScroll = True
        Me.SuperTabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.SuperTabControlPanel1.Controls.Add(Me.LabelX12)
        Me.SuperTabControlPanel1.Controls.Add(Me.SwitchButton1)
        Me.SuperTabControlPanel1.Controls.Add(Me.Empleados_Salarios6mesesDataGridViewX)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(505, 466)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(18, 18)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(109, 23)
        Me.LabelX12.TabIndex = 4
        Me.LabelX12.Text = "Ingresos Detallados"
        '
        'SwitchButton1
        '
        '
        '
        '
        Me.SwitchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton1.Location = New System.Drawing.Point(133, 20)
        Me.SwitchButton1.Name = "SwitchButton1"
        Me.SwitchButton1.OffBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SwitchButton1.OffText = "NO"
        Me.SwitchButton1.OnBackColor = System.Drawing.Color.DarkGreen
        Me.SwitchButton1.OnText = "SI"
        Me.SwitchButton1.Size = New System.Drawing.Size(66, 21)
        Me.SwitchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton1.SwitchBackColor = System.Drawing.Color.DimGray
        Me.SwitchButton1.TabIndex = 3
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Ingresos"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.AutoScroll = True
        Me.SuperTabControlPanel2.Controls.Add(Me.VacacionesDataGridViewX)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(505, 466)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'VacacionesDataGridViewX
        '
        Me.VacacionesDataGridViewX.AutoGenerateColumns = False
        Me.VacacionesDataGridViewX.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.VacacionesDataGridViewX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VacacionesDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VacacionesDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.VacacionesDataGridViewX.DataSource = Me.VacacionesBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.VacacionesDataGridViewX.DefaultCellStyle = DataGridViewCellStyle6
        Me.VacacionesDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.VacacionesDataGridViewX.Location = New System.Drawing.Point(14, 46)
        Me.VacacionesDataGridViewX.Name = "VacacionesDataGridViewX"
        Me.VacacionesDataGridViewX.RowHeadersWidth = 21
        Me.VacacionesDataGridViewX.Size = New System.Drawing.Size(485, 220)
        Me.VacacionesDataGridViewX.TabIndex = 0
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "derecho"
        Me.DataGridViewTextBoxColumn12.HeaderText = "derecho"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 75
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "disfrutado"
        Me.DataGridViewTextBoxColumn13.HeaderText = "disfrutado"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 50
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "saldo"
        Me.DataGridViewTextBoxColumn17.HeaderText = "saldo"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 50
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "periodo"
        Me.DataGridViewTextBoxColumn18.HeaderText = "periodo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 50
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "fIni"
        Me.DataGridViewTextBoxColumn19.HeaderText = "fIni"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 75
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "ffin"
        Me.DataGridViewTextBoxColumn20.HeaderText = "ffin"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 75
        '
        'VacacionesBindingSource
        '
        Me.VacacionesBindingSource.DataMember = "Vacaciones"
        Me.VacacionesBindingSource.DataSource = Me.DsVacaciones
        '
        'DsVacaciones
        '
        Me.DsVacaciones.DataSetName = "dsVacaciones"
        Me.DsVacaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Vacaciones"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.ContratosEmpleadoDataGridViewX)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(505, 466)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem3
        '
        'ContratosEmpleadoDataGridViewX
        '
        Me.ContratosEmpleadoDataGridViewX.AllowUserToAddRows = False
        Me.ContratosEmpleadoDataGridViewX.AllowUserToDeleteRows = False
        Me.ContratosEmpleadoDataGridViewX.AllowUserToResizeColumns = False
        Me.ContratosEmpleadoDataGridViewX.AllowUserToResizeRows = False
        Me.ContratosEmpleadoDataGridViewX.AutoGenerateColumns = False
        Me.ContratosEmpleadoDataGridViewX.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ContratosEmpleadoDataGridViewX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContratosEmpleadoDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ContratosEmpleadoDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.fecha_ini, Me.fecha_fin, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn16, Me.Liquidar})
        Me.ContratosEmpleadoDataGridViewX.DataSource = Me.ContratosEmpleadoBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ContratosEmpleadoDataGridViewX.DefaultCellStyle = DataGridViewCellStyle7
        Me.ContratosEmpleadoDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ContratosEmpleadoDataGridViewX.Location = New System.Drawing.Point(3, 55)
        Me.ContratosEmpleadoDataGridViewX.Name = "ContratosEmpleadoDataGridViewX"
        Me.ContratosEmpleadoDataGridViewX.RowHeadersWidth = 21
        Me.ContratosEmpleadoDataGridViewX.Size = New System.Drawing.Size(496, 230)
        Me.ContratosEmpleadoDataGridViewX.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_contrato"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Contrato"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'fecha_ini
        '
        Me.fecha_ini.DataPropertyName = "fecha_ini"
        Me.fecha_ini.HeaderText = "Ingreso"
        Me.fecha_ini.Name = "fecha_ini"
        Me.fecha_ini.Width = 70
        '
        'fecha_fin
        '
        Me.fecha_fin.DataPropertyName = "fecha_fin"
        Me.fecha_fin.HeaderText = "Salida"
        Me.fecha_fin.Name = "fecha_fin"
        Me.fecha_fin.Width = 70
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn11.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 50
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "recargo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "recargo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 50
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Embargo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 50
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "liquidado"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Liquidado"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 70
        '
        'Liquidar
        '
        Me.Liquidar.DataPropertyName = "id_contrato"
        Me.Liquidar.HeaderText = "Liquidar"
        Me.Liquidar.Name = "Liquidar"
        Me.Liquidar.ReadOnly = True
        Me.Liquidar.Text = "Liquidar"
        Me.Liquidar.Width = 50
        '
        'ContratosEmpleadoBindingSource
        '
        Me.ContratosEmpleadoBindingSource.DataMember = "ContratosEmpleado"
        Me.ContratosEmpleadoBindingSource.DataSource = Me.Ds2planilla
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "Contratos"
        '
        'VacacionesTableAdapter
        '
        Me.VacacionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Planilla.dsVacacionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vacacion_regTableAdapter = Nothing
        Me.TableAdapterManager.VacacionesTableAdapter = Me.VacacionesTableAdapter
        '
        'Empleados_Salarios6mesesTableAdapter
        '
        Me.Empleados_Salarios6mesesTableAdapter.ClearBeforeFill = True
        '
        'AguinaldoBindingSource
        '
        Me.AguinaldoBindingSource.DataMember = "Aguinaldo"
        Me.AguinaldoBindingSource.DataSource = Me.Ds2planilla
        '
        'AguinaldoTableAdapter
        '
        Me.AguinaldoTableAdapter.ClearBeforeFill = True
        '
        'ContratosEmpleadoTableAdapter
        '
        Me.ContratosEmpleadoTableAdapter.ClearBeforeFill = True
        '
        'CuEmpleado1
        '
        Me.CuEmpleado1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CuEmpleado1.ForeColor = System.Drawing.Color.Black
        Me.CuEmpleado1.Location = New System.Drawing.Point(234, 12)
        Me.CuEmpleado1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CuEmpleado1.Name = "CuEmpleado1"
        Me.CuEmpleado1.Size = New System.Drawing.Size(419, 119)
        Me.CuEmpleado1.TabIndex = 1
        '
        'BEmpleado1
        '
        Me.BEmpleado1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BEmpleado1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BEmpleado1.ForeColor = System.Drawing.Color.Black
        Me.BEmpleado1.HoraExtra = False
        Me.BEmpleado1.Location = New System.Drawing.Point(0, 0)
        Me.BEmpleado1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BEmpleado1.Name = "BEmpleado1"
        Me.BEmpleado1.Size = New System.Drawing.Size(228, 531)
        Me.BEmpleado1.TabIndex = 0
        '
        'frmLiquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1170, 531)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.Controls.Add(Me.ExpandablePanel2)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Controls.Add(Me.CuEmpleado1)
        Me.Controls.Add(Me.BEmpleado1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLiquidacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liquidacion"
        CType(Me.Empleados_Salarios6mesesDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empleados_Salarios6mesesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds2planilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoubleInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoubleInput2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mSalarioDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dVaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dPre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dCesant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mVaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mPre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mCesant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimeInput2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mAguinaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpandablePanel1.ResumeLayout(False)
        CType(Me.vdias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vmeses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vanos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpandablePanel2.ResumeLayout(False)
        CType(Me.mTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        CType(Me.VacacionesDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel3.ResumeLayout(False)
        CType(Me.ContratosEmpleadoDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratosEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AguinaldoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BEmpleado1 As bEmpleado
    Friend WithEvents CuEmpleado1 As cuEmpleado
    Friend WithEvents Ds2planilla As ds2planilla
    Friend WithEvents Empleados_Salarios6mesesBindingSource As BindingSource
    Friend WithEvents Empleados_Salarios6mesesTableAdapter As ds2planillaTableAdapters.Empleados_Salarios6mesesTableAdapter
    Friend WithEvents Empleados_Salarios6mesesDataGridViewX As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DoubleInput1 As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DoubleInput2 As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents mSalarioDia As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dVaca As DevComponents.Editors.IntegerInput
    Friend WithEvents dPre As DevComponents.Editors.IntegerInput
    Friend WithEvents dCesant As DevComponents.Editors.IntegerInput
    Friend WithEvents mVaca As DevComponents.Editors.DoubleInput
    Friend WithEvents mPre As DevComponents.Editors.DoubleInput
    Friend WithEvents mCesant As DevComponents.Editors.DoubleInput
    Friend WithEvents DateTimeInput1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DateTimeInput2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents mAguinaldo As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents ExpandablePanel2 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents vmeses As DevComponents.Editors.IntegerInput
    Friend WithEvents vanos As DevComponents.Editors.IntegerInput
    Friend WithEvents vdias As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SwitchButton1 As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents id_planilla As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents AguinaldoBindingSource As BindingSource
    Friend WithEvents AguinaldoTableAdapter As ds2planillaTableAdapters.AguinaldoTableAdapter
    Friend WithEvents ContratosEmpleadoBindingSource As BindingSource
    Friend WithEvents ContratosEmpleadoTableAdapter As ds2planillaTableAdapters.ContratosEmpleadoTableAdapter
    Friend WithEvents ContratosEmpleadoDataGridViewX As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents mTotal As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents SWResponPatronals As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents DsVacaciones As dsVacaciones
    Friend WithEvents VacacionesBindingSource As BindingSource
    Friend WithEvents VacacionesTableAdapter As dsVacacionesTableAdapters.VacacionesTableAdapter
    Friend WithEvents TableAdapterManager As dsVacacionesTableAdapters.TableAdapterManager
    Friend WithEvents VacacionesDataGridViewX As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents fecha_ini As DataGridViewTextBoxColumn
    Friend WithEvents fecha_fin As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents Liquidar As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
