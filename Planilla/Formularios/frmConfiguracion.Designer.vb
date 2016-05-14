<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Me.components = New System.ComponentModel.Container
        Dim Id_dptoLabel As System.Windows.Forms.Label
        Dim Nombre_JurídicoLabel As System.Windows.Forms.Label
        Dim Cédula_JurídicaLabel As System.Windows.Forms.Label
        Dim Nombre_ComercialLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim DirecciónLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim WebLabel As System.Windows.Forms.Label
        Dim LogoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracion))
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.Id_dptoTextBox = New System.Windows.Forms.TextBox
        Me.ConfiguracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillaDataSet = New Planilla.planillaDataSet
        Me.Nombre_JurídicoTextBox = New System.Windows.Forms.TextBox
        Me.Cédula_JurídicaTextBox = New System.Windows.Forms.TextBox
        Me.Nombre_ComercialTextBox = New System.Windows.Forms.TextBox
        Me.CiudadTextBox = New System.Windows.Forms.TextBox
        Me.DirecciónTextBox = New System.Windows.Forms.TextBox
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox
        Me.FaxTextBox = New System.Windows.Forms.TextBox
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.WebTextBox = New System.Windows.Forms.TextBox
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.TabItem4 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.AdmSysCargoTextBox = New System.Windows.Forms.TextBox
        Me.AdmSysTratoTextBox = New System.Windows.Forms.TextBox
        Me.AdmSysNombreTextBox = New System.Windows.Forms.TextBox
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.AdmOrgTratoTextBox = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.AdmOrgNombreTextBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.AdmOrgCargoTextBox = New System.Windows.Forms.TextBox
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel
        Me.ConfiguracionValoresDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConfiguracionValoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ConfiguracionTableAdapter = New Planilla.planillaDataSetTableAdapters.configuracionTableAdapter
        Me.ConfiguracionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ConfiguracionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ConfiguracionValoresTableAdapter = New Planilla.planillaDataSetTableAdapters.configuracionValoresTableAdapter
        Id_dptoLabel = New System.Windows.Forms.Label
        Nombre_JurídicoLabel = New System.Windows.Forms.Label
        Cédula_JurídicaLabel = New System.Windows.Forms.Label
        Nombre_ComercialLabel = New System.Windows.Forms.Label
        CiudadLabel = New System.Windows.Forms.Label
        DirecciónLabel = New System.Windows.Forms.Label
        TelefonoLabel = New System.Windows.Forms.Label
        FaxLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        WebLabel = New System.Windows.Forms.Label
        LogoLabel = New System.Windows.Forms.Label
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.ConfiguracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel4.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.ConfiguracionValoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfiguracionValoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfiguracionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConfiguracionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_dptoLabel
        '
        Id_dptoLabel.AutoSize = True
        Id_dptoLabel.BackColor = System.Drawing.Color.Transparent
        Id_dptoLabel.Location = New System.Drawing.Point(70, 19)
        Id_dptoLabel.Name = "Id_dptoLabel"
        Id_dptoLabel.Size = New System.Drawing.Size(42, 13)
        Id_dptoLabel.TabIndex = 8
        Id_dptoLabel.Text = "id dpto:"
        '
        'Nombre_JurídicoLabel
        '
        Nombre_JurídicoLabel.AutoSize = True
        Nombre_JurídicoLabel.BackColor = System.Drawing.Color.Transparent
        Nombre_JurídicoLabel.Location = New System.Drawing.Point(24, 45)
        Nombre_JurídicoLabel.Name = "Nombre_JurídicoLabel"
        Nombre_JurídicoLabel.Size = New System.Drawing.Size(88, 13)
        Nombre_JurídicoLabel.TabIndex = 10
        Nombre_JurídicoLabel.Text = "Nombre Jurídico:"
        '
        'Cédula_JurídicaLabel
        '
        Cédula_JurídicaLabel.AutoSize = True
        Cédula_JurídicaLabel.BackColor = System.Drawing.Color.Transparent
        Cédula_JurídicaLabel.Location = New System.Drawing.Point(28, 71)
        Cédula_JurídicaLabel.Name = "Cédula_JurídicaLabel"
        Cédula_JurídicaLabel.Size = New System.Drawing.Size(84, 13)
        Cédula_JurídicaLabel.TabIndex = 12
        Cédula_JurídicaLabel.Text = "Cédula Jurídica:"
        '
        'Nombre_ComercialLabel
        '
        Nombre_ComercialLabel.AutoSize = True
        Nombre_ComercialLabel.BackColor = System.Drawing.Color.Transparent
        Nombre_ComercialLabel.Location = New System.Drawing.Point(16, 97)
        Nombre_ComercialLabel.Name = "Nombre_ComercialLabel"
        Nombre_ComercialLabel.Size = New System.Drawing.Size(96, 13)
        Nombre_ComercialLabel.TabIndex = 14
        Nombre_ComercialLabel.Text = "Nombre Comercial:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.BackColor = System.Drawing.Color.Transparent
        CiudadLabel.Location = New System.Drawing.Point(69, 123)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 16
        CiudadLabel.Text = "Ciudad:"
        '
        'DirecciónLabel
        '
        DirecciónLabel.AutoSize = True
        DirecciónLabel.BackColor = System.Drawing.Color.Transparent
        DirecciónLabel.Location = New System.Drawing.Point(57, 149)
        DirecciónLabel.Name = "DirecciónLabel"
        DirecciónLabel.Size = New System.Drawing.Size(55, 13)
        DirecciónLabel.TabIndex = 18
        DirecciónLabel.Text = "Dirección:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.BackColor = System.Drawing.Color.Transparent
        TelefonoLabel.Location = New System.Drawing.Point(60, 175)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 20
        TelefonoLabel.Text = "Telefono:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.BackColor = System.Drawing.Color.Transparent
        FaxLabel.Location = New System.Drawing.Point(85, 201)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 22
        FaxLabel.Text = "Fax:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = System.Drawing.Color.Transparent
        EmailLabel.Location = New System.Drawing.Point(78, 227)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 24
        EmailLabel.Text = "email:"
        '
        'WebLabel
        '
        WebLabel.AutoSize = True
        WebLabel.BackColor = System.Drawing.Color.Transparent
        WebLabel.Location = New System.Drawing.Point(82, 253)
        WebLabel.Name = "WebLabel"
        WebLabel.Size = New System.Drawing.Size(30, 13)
        WebLabel.TabIndex = 26
        WebLabel.Text = "web:"
        '
        'LogoLabel
        '
        LogoLabel.AutoSize = True
        LogoLabel.BackColor = System.Drawing.Color.Transparent
        LogoLabel.Location = New System.Drawing.Point(18, 18)
        LogoLabel.Name = "LogoLabel"
        LogoLabel.Size = New System.Drawing.Size(30, 13)
        LogoLabel.TabIndex = 0
        LogoLabel.Text = "logo:"
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel3)
        Me.TabControl1.Controls.Add(Me.TabControlPanel4)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(378, 302)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Tabs.Add(Me.TabItem3)
        Me.TabControl1.Tabs.Add(Me.TabItem4)
        Me.TabControl1.Text = "Logo"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.AutoScroll = True
        Me.TabControlPanel1.Controls.Add(Id_dptoLabel)
        Me.TabControlPanel1.Controls.Add(Me.Id_dptoTextBox)
        Me.TabControlPanel1.Controls.Add(Nombre_JurídicoLabel)
        Me.TabControlPanel1.Controls.Add(Me.Nombre_JurídicoTextBox)
        Me.TabControlPanel1.Controls.Add(Cédula_JurídicaLabel)
        Me.TabControlPanel1.Controls.Add(Me.Cédula_JurídicaTextBox)
        Me.TabControlPanel1.Controls.Add(Nombre_ComercialLabel)
        Me.TabControlPanel1.Controls.Add(Me.Nombre_ComercialTextBox)
        Me.TabControlPanel1.Controls.Add(CiudadLabel)
        Me.TabControlPanel1.Controls.Add(Me.CiudadTextBox)
        Me.TabControlPanel1.Controls.Add(DirecciónLabel)
        Me.TabControlPanel1.Controls.Add(Me.DirecciónTextBox)
        Me.TabControlPanel1.Controls.Add(TelefonoLabel)
        Me.TabControlPanel1.Controls.Add(Me.TelefonoTextBox)
        Me.TabControlPanel1.Controls.Add(FaxLabel)
        Me.TabControlPanel1.Controls.Add(Me.FaxTextBox)
        Me.TabControlPanel1.Controls.Add(EmailLabel)
        Me.TabControlPanel1.Controls.Add(Me.EmailTextBox)
        Me.TabControlPanel1.Controls.Add(WebLabel)
        Me.TabControlPanel1.Controls.Add(Me.WebTextBox)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(378, 280)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'Id_dptoTextBox
        '
        Me.Id_dptoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "id_dpto", True))
        Me.Id_dptoTextBox.Location = New System.Drawing.Point(118, 16)
        Me.Id_dptoTextBox.Name = "Id_dptoTextBox"
        Me.Id_dptoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_dptoTextBox.TabIndex = 9
        '
        'ConfiguracionBindingSource
        '
        Me.ConfiguracionBindingSource.DataMember = "configuracion"
        Me.ConfiguracionBindingSource.DataSource = Me.PlanillaDataSet
        '
        'PlanillaDataSet
        '
        Me.PlanillaDataSet.DataSetName = "planillaDataSet"
        Me.PlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nombre_JurídicoTextBox
        '
        Me.Nombre_JurídicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Nombre Jurídico", True))
        Me.Nombre_JurídicoTextBox.Location = New System.Drawing.Point(118, 42)
        Me.Nombre_JurídicoTextBox.Name = "Nombre_JurídicoTextBox"
        Me.Nombre_JurídicoTextBox.Size = New System.Drawing.Size(230, 20)
        Me.Nombre_JurídicoTextBox.TabIndex = 11
        '
        'Cédula_JurídicaTextBox
        '
        Me.Cédula_JurídicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Cédula Jurídica", True))
        Me.Cédula_JurídicaTextBox.Location = New System.Drawing.Point(118, 68)
        Me.Cédula_JurídicaTextBox.Name = "Cédula_JurídicaTextBox"
        Me.Cédula_JurídicaTextBox.Size = New System.Drawing.Size(230, 20)
        Me.Cédula_JurídicaTextBox.TabIndex = 13
        '
        'Nombre_ComercialTextBox
        '
        Me.Nombre_ComercialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Nombre Comercial", True))
        Me.Nombre_ComercialTextBox.Location = New System.Drawing.Point(118, 94)
        Me.Nombre_ComercialTextBox.Name = "Nombre_ComercialTextBox"
        Me.Nombre_ComercialTextBox.Size = New System.Drawing.Size(230, 20)
        Me.Nombre_ComercialTextBox.TabIndex = 15
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(118, 120)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(230, 20)
        Me.CiudadTextBox.TabIndex = 17
        '
        'DirecciónTextBox
        '
        Me.DirecciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Dirección", True))
        Me.DirecciónTextBox.Location = New System.Drawing.Point(118, 146)
        Me.DirecciónTextBox.Name = "DirecciónTextBox"
        Me.DirecciónTextBox.Size = New System.Drawing.Size(230, 20)
        Me.DirecciónTextBox.TabIndex = 19
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(118, 172)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(230, 20)
        Me.TelefonoTextBox.TabIndex = 21
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(118, 198)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(230, 20)
        Me.FaxTextBox.TabIndex = 23
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(118, 224)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(230, 20)
        Me.EmailTextBox.TabIndex = 25
        '
        'WebTextBox
        '
        Me.WebTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "web", True))
        Me.WebTextBox.Location = New System.Drawing.Point(118, 250)
        Me.WebTextBox.Name = "WebTextBox"
        Me.WebTextBox.Size = New System.Drawing.Size(230, 20)
        Me.WebTextBox.TabIndex = 27
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Organización"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(LogoLabel)
        Me.TabControlPanel4.Controls.Add(Me.LogoPictureBox)
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(378, 280)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 4
        Me.TabControlPanel4.TabItem = Me.TabItem4
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ConfiguracionBindingSource, "logo", True))
        Me.LogoPictureBox.Location = New System.Drawing.Point(54, 18)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(222, 250)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.LogoPictureBox.TabIndex = 1
        Me.LogoPictureBox.TabStop = False
        '
        'TabItem4
        '
        Me.TabItem4.AttachedControl = Me.TabControlPanel4
        Me.TabItem4.Name = "TabItem4"
        Me.TabItem4.Text = "Logo"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.GroupPanel2)
        Me.TabControlPanel2.Controls.Add(Me.GroupPanel1)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(378, 280)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Label7)
        Me.GroupPanel2.Controls.Add(Me.Label10)
        Me.GroupPanel2.Controls.Add(Me.Label11)
        Me.GroupPanel2.Controls.Add(Me.AdmSysCargoTextBox)
        Me.GroupPanel2.Controls.Add(Me.AdmSysTratoTextBox)
        Me.GroupPanel2.Controls.Add(Me.AdmSysNombreTextBox)
        Me.GroupPanel2.Location = New System.Drawing.Point(24, 117)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(330, 105)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel2.TabIndex = 8
        Me.GroupPanel2.Text = "Sistema"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(33, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cargo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(24, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(36, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Trato"
        '
        'AdmSysCargoTextBox
        '
        Me.AdmSysCargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "AdmSysCargo", True))
        Me.AdmSysCargoTextBox.Location = New System.Drawing.Point(74, 52)
        Me.AdmSysCargoTextBox.Name = "AdmSysCargoTextBox"
        Me.AdmSysCargoTextBox.Size = New System.Drawing.Size(224, 20)
        Me.AdmSysCargoTextBox.TabIndex = 51
        '
        'AdmSysTratoTextBox
        '
        Me.AdmSysTratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "AdmSysTrato", True))
        Me.AdmSysTratoTextBox.Location = New System.Drawing.Point(74, -1)
        Me.AdmSysTratoTextBox.Name = "AdmSysTratoTextBox"
        Me.AdmSysTratoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdmSysTratoTextBox.TabIndex = 47
        '
        'AdmSysNombreTextBox
        '
        Me.AdmSysNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "AdmSysNombre", True))
        Me.AdmSysNombreTextBox.Location = New System.Drawing.Point(74, 26)
        Me.AdmSysNombreTextBox.Name = "AdmSysNombreTextBox"
        Me.AdmSysNombreTextBox.Size = New System.Drawing.Size(224, 20)
        Me.AdmSysNombreTextBox.TabIndex = 49
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.AdmOrgTratoTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label9)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.AdmOrgNombreTextBox)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.AdmOrgCargoTextBox)
        Me.GroupPanel1.Location = New System.Drawing.Point(24, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(330, 105)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 7
        Me.GroupPanel1.Text = "Organización"
        '
        'AdmOrgTratoTextBox
        '
        Me.AdmOrgTratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "AdmOrgTrato", True))
        Me.AdmOrgTratoTextBox.Location = New System.Drawing.Point(74, 3)
        Me.AdmOrgTratoTextBox.Name = "AdmOrgTratoTextBox"
        Me.AdmOrgTratoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdmOrgTratoTextBox.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(33, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Cargo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(24, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Nombre"
        '
        'AdmOrgNombreTextBox
        '
        Me.AdmOrgNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "AdmOrgNombre", True))
        Me.AdmOrgNombreTextBox.Location = New System.Drawing.Point(74, 28)
        Me.AdmOrgNombreTextBox.Name = "AdmOrgNombreTextBox"
        Me.AdmOrgNombreTextBox.Size = New System.Drawing.Size(224, 20)
        Me.AdmOrgNombreTextBox.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(36, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Trato"
        '
        'AdmOrgCargoTextBox
        '
        Me.AdmOrgCargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfiguracionBindingSource, "AdmOrgCargo", True))
        Me.AdmOrgCargoTextBox.Location = New System.Drawing.Point(74, 54)
        Me.AdmOrgCargoTextBox.Name = "AdmOrgCargoTextBox"
        Me.AdmOrgCargoTextBox.Size = New System.Drawing.Size(224, 20)
        Me.AdmOrgCargoTextBox.TabIndex = 45
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Administrador"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.AutoScroll = True
        Me.TabControlPanel3.Controls.Add(Me.ConfiguracionValoresDataGridView)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(378, 280)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabItem3
        '
        'ConfiguracionValoresDataGridView
        '
        Me.ConfiguracionValoresDataGridView.AutoGenerateColumns = False
        Me.ConfiguracionValoresDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.ConfiguracionValoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ConfiguracionValoresDataGridView.DataSource = Me.ConfiguracionValoresBindingSource
        Me.ConfiguracionValoresDataGridView.Location = New System.Drawing.Point(12, 13)
        Me.ConfiguracionValoresDataGridView.Name = "ConfiguracionValoresDataGridView"
        Me.ConfiguracionValoresDataGridView.RowHeadersWidth = 21
        Me.ConfiguracionValoresDataGridView.Size = New System.Drawing.Size(354, 255)
        Me.ConfiguracionValoresDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_config"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_config"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Grupo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Grupo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre Valor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre Valor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "valorT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "valorT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "valorN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "valorN"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'ConfiguracionValoresBindingSource
        '
        Me.ConfiguracionValoresBindingSource.DataMember = "FK_configuracionValores_configuracion"
        Me.ConfiguracionValoresBindingSource.DataSource = Me.ConfiguracionBindingSource
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel3
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "Valores"
        '
        'ConfiguracionTableAdapter
        '
        Me.ConfiguracionTableAdapter.ClearBeforeFill = True
        '
        'ConfiguracionBindingNavigator
        '
        Me.ConfiguracionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ConfiguracionBindingNavigator.BackColor = System.Drawing.Color.AliceBlue
        Me.ConfiguracionBindingNavigator.BindingSource = Me.ConfiguracionBindingSource
        Me.ConfiguracionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ConfiguracionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ConfiguracionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ConfiguracionBindingNavigatorSaveItem})
        Me.ConfiguracionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ConfiguracionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ConfiguracionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ConfiguracionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ConfiguracionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ConfiguracionBindingNavigator.Name = "ConfiguracionBindingNavigator"
        Me.ConfiguracionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ConfiguracionBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ConfiguracionBindingNavigator.Size = New System.Drawing.Size(378, 25)
        Me.ConfiguracionBindingNavigator.TabIndex = 1
        Me.ConfiguracionBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 22)
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
        'ConfiguracionBindingNavigatorSaveItem
        '
        Me.ConfiguracionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConfiguracionBindingNavigatorSaveItem.Image = CType(resources.GetObject("ConfiguracionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ConfiguracionBindingNavigatorSaveItem.Name = "ConfiguracionBindingNavigatorSaveItem"
        Me.ConfiguracionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ConfiguracionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ConfiguracionValoresTableAdapter
        '
        Me.ConfiguracionValoresTableAdapter.ClearBeforeFill = True
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 327)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ConfiguracionBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfiguracion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración"
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.ConfiguracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel4.ResumeLayout(False)
        Me.TabControlPanel4.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.TabControlPanel3.ResumeLayout(False)
        CType(Me.ConfiguracionValoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfiguracionValoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfiguracionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConfiguracionBindingNavigator.ResumeLayout(False)
        Me.ConfiguracionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PlanillaDataSet As Planilla.planillaDataSet
    Friend WithEvents ConfiguracionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfiguracionTableAdapter As Planilla.planillaDataSetTableAdapters.configuracionTableAdapter
    Friend WithEvents ConfiguracionBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ConfiguracionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AdmOrgTratoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdmOrgNombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdmSysCargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdmOrgCargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdmSysNombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdmSysTratoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_dptoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_JurídicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cédula_JurídicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_ComercialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CiudadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DirecciónTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConfiguracionValoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfiguracionValoresTableAdapter As Planilla.planillaDataSetTableAdapters.configuracionValoresTableAdapter
    Friend WithEvents ConfiguracionValoresDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem4 As DevComponents.DotNetBar.TabItem
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox

End Class
