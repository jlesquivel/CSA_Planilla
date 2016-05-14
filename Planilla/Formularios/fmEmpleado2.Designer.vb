<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmEmpleado_2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmEmpleado_2))
        Dim NacimientoLabel As System.Windows.Forms.Label
        Dim CuentaLabel As System.Windows.Forms.Label
        Dim IngresoLabel As System.Windows.Forms.Label
        Dim BancoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim AnualidadReconocidaLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DsEmpleados = New Planilla.dsEmpleados
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.EmpleadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.CuentaTextBox = New System.Windows.Forms.TextBox
        Me.IngresoDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.BancoTextBox = New System.Windows.Forms.TextBox
        Me.DireccionTextBox = New System.Windows.Forms.TextBox
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox
        Me.CelularTextBox = New System.Windows.Forms.TextBox
        Me.SexoTextBox = New System.Windows.Forms.TextBox
        Me.AnualidadReconocidaTextBox = New System.Windows.Forms.TextBox
        NacimientoLabel = New System.Windows.Forms.Label
        CuentaLabel = New System.Windows.Forms.Label
        IngresoLabel = New System.Windows.Forms.Label
        BancoLabel = New System.Windows.Forms.Label
        DireccionLabel = New System.Windows.Forms.Label
        TelefonoLabel = New System.Windows.Forms.Label
        CelularLabel = New System.Windows.Forms.Label
        SexoLabel = New System.Windows.Forms.Label
        AnualidadReconocidaLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadosBindingNavigator.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(574, 409)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.EmpleadosDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(566, 383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(AnualidadReconocidaLabel)
        Me.TabPage2.Controls.Add(Me.AnualidadReconocidaTextBox)
        Me.TabPage2.Controls.Add(SexoLabel)
        Me.TabPage2.Controls.Add(Me.SexoTextBox)
        Me.TabPage2.Controls.Add(CelularLabel)
        Me.TabPage2.Controls.Add(Me.CelularTextBox)
        Me.TabPage2.Controls.Add(TelefonoLabel)
        Me.TabPage2.Controls.Add(Me.TelefonoTextBox)
        Me.TabPage2.Controls.Add(DireccionLabel)
        Me.TabPage2.Controls.Add(Me.DireccionTextBox)
        Me.TabPage2.Controls.Add(BancoLabel)
        Me.TabPage2.Controls.Add(Me.BancoTextBox)
        Me.TabPage2.Controls.Add(IngresoLabel)
        Me.TabPage2.Controls.Add(Me.IngresoDateTimePicker)
        Me.TabPage2.Controls.Add(CuentaLabel)
        Me.TabPage2.Controls.Add(Me.CuentaTextBox)
        Me.TabPage2.Controls.Add(NacimientoLabel)
        Me.TabPage2.Controls.Add(Me.NacimientoDateTimePicker)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(566, 383)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DsEmpleados
        '
        Me.DsEmpleados.DataSetName = "dsEmpleados"
        Me.DsEmpleados.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DsEmpleados
        '
        'EmpleadosBindingNavigator
        '
        Me.EmpleadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpleadosBindingNavigator.BindingSource = Me.EmpleadosBindingSource
        Me.EmpleadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadosBindingNavigatorSaveItem})
        Me.EmpleadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadosBindingNavigator.Name = "EmpleadosBindingNavigator"
        Me.EmpleadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadosBindingNavigator.Size = New System.Drawing.Size(574, 25)
        Me.EmpleadosBindingNavigator.TabIndex = 1
        Me.EmpleadosBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'EmpleadosBindingNavigatorSaveItem
        '
        Me.EmpleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpleadosBindingNavigatorSaveItem.Enabled = False
        Me.EmpleadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpleadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpleadosBindingNavigatorSaveItem.Name = "EmpleadosBindingNavigatorSaveItem"
        Me.EmpleadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpleadosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(560, 377)
        Me.EmpleadosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cedula"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cedula"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "apellidos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "categoria"
        Me.DataGridViewTextBoxColumn5.HeaderText = "categoria"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nacimiento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "nacimiento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cuenta"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cuenta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ingreso"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ingreso"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "banco"
        Me.DataGridViewTextBoxColumn9.HeaderText = "banco"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn10.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn11.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "celular"
        Me.DataGridViewTextBoxColumn12.HeaderText = "celular"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "sexo"
        Me.DataGridViewTextBoxColumn13.HeaderText = "sexo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "anualidadReconocida"
        Me.DataGridViewTextBoxColumn14.HeaderText = "anualidadReconocida"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'NacimientoLabel
        '
        NacimientoLabel.AutoSize = True
        NacimientoLabel.Location = New System.Drawing.Point(70, 49)
        NacimientoLabel.Name = "NacimientoLabel"
        NacimientoLabel.Size = New System.Drawing.Size(61, 13)
        NacimientoLabel.TabIndex = 0
        NacimientoLabel.Text = "nacimiento:"
        '
        'NacimientoDateTimePicker
        '
        Me.NacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "nacimiento", True))
        Me.NacimientoDateTimePicker.Location = New System.Drawing.Point(137, 45)
        Me.NacimientoDateTimePicker.Name = "NacimientoDateTimePicker"
        Me.NacimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.NacimientoDateTimePicker.TabIndex = 1
        '
        'CuentaLabel
        '
        CuentaLabel.AutoSize = True
        CuentaLabel.Location = New System.Drawing.Point(88, 86)
        CuentaLabel.Name = "CuentaLabel"
        CuentaLabel.Size = New System.Drawing.Size(43, 13)
        CuentaLabel.TabIndex = 2
        CuentaLabel.Text = "cuenta:"
        '
        'CuentaTextBox
        '
        Me.CuentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "cuenta", True))
        Me.CuentaTextBox.Location = New System.Drawing.Point(137, 83)
        Me.CuentaTextBox.Name = "CuentaTextBox"
        Me.CuentaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CuentaTextBox.TabIndex = 3
        '
        'IngresoLabel
        '
        IngresoLabel.AutoSize = True
        IngresoLabel.Location = New System.Drawing.Point(87, 113)
        IngresoLabel.Name = "IngresoLabel"
        IngresoLabel.Size = New System.Drawing.Size(44, 13)
        IngresoLabel.TabIndex = 4
        IngresoLabel.Text = "ingreso:"
        '
        'IngresoDateTimePicker
        '
        Me.IngresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "ingreso", True))
        Me.IngresoDateTimePicker.Location = New System.Drawing.Point(137, 109)
        Me.IngresoDateTimePicker.Name = "IngresoDateTimePicker"
        Me.IngresoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.IngresoDateTimePicker.TabIndex = 5
        '
        'BancoLabel
        '
        BancoLabel.AutoSize = True
        BancoLabel.Location = New System.Drawing.Point(91, 152)
        BancoLabel.Name = "BancoLabel"
        BancoLabel.Size = New System.Drawing.Size(40, 13)
        BancoLabel.TabIndex = 6
        BancoLabel.Text = "banco:"
        '
        'BancoTextBox
        '
        Me.BancoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "banco", True))
        Me.BancoTextBox.Location = New System.Drawing.Point(137, 149)
        Me.BancoTextBox.Name = "BancoTextBox"
        Me.BancoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BancoTextBox.TabIndex = 7
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(78, 196)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 8
        DireccionLabel.Text = "direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(137, 175)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(250, 67)
        Me.DireccionTextBox.TabIndex = 9
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(83, 251)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(48, 13)
        TelefonoLabel.TabIndex = 10
        TelefonoLabel.Text = "telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(137, 248)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 11
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(240, 251)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(41, 13)
        CelularLabel.TabIndex = 12
        CelularLabel.Text = "celular:"
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(287, 248)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CelularTextBox.TabIndex = 13
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(99, 22)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(32, 13)
        SexoLabel.TabIndex = 14
        SexoLabel.Text = "sexo:"
        '
        'SexoTextBox
        '
        Me.SexoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "sexo", True))
        Me.SexoTextBox.Location = New System.Drawing.Point(137, 19)
        Me.SexoTextBox.Name = "SexoTextBox"
        Me.SexoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SexoTextBox.TabIndex = 15
        '
        'AnualidadReconocidaLabel
        '
        AnualidadReconocidaLabel.AutoSize = True
        AnualidadReconocidaLabel.Location = New System.Drawing.Point(14, 287)
        AnualidadReconocidaLabel.Name = "AnualidadReconocidaLabel"
        AnualidadReconocidaLabel.Size = New System.Drawing.Size(117, 13)
        AnualidadReconocidaLabel.TabIndex = 16
        AnualidadReconocidaLabel.Text = "anualidad Reconocida:"
        '
        'AnualidadReconocidaTextBox
        '
        Me.AnualidadReconocidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "anualidadReconocida", True))
        Me.AnualidadReconocidaTextBox.Location = New System.Drawing.Point(137, 284)
        Me.AnualidadReconocidaTextBox.Name = "AnualidadReconocidaTextBox"
        Me.AnualidadReconocidaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnualidadReconocidaTextBox.TabIndex = 17
        '
        'fmEmpleado_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 434)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.EmpleadosBindingNavigator)
        Me.Name = "fmEmpleado_2"
        Me.Text = "fmEmpleado_2"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadosBindingNavigator.ResumeLayout(False)
        Me.EmpleadosBindingNavigator.PerformLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents EmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsEmpleados As Planilla.dsEmpleados
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents EmpleadosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EmpleadosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AnualidadReconocidaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BancoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IngresoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CuentaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NacimientoDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
