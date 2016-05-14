<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAusencias
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
        Dim MontoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAusencias))
        Me.PlanillaDataSet = New Planilla.planillaDataSet()
        Me.AusenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AusenciasTableAdapter = New Planilla.planillaDataSetTableAdapters.ausenciasTableAdapter()
        Me.AusenciasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AusenciasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FechaIniDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FechafinDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.VempleadoscontratadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_empleados_contratadosTableAdapter = New Planilla.planillaDataSetTableAdapters.v_empleados_contratadosTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DiasTextBox = New DevComponents.Editors.DoubleInput()
        Me.MontoTextBox = New DevComponents.Editors.DoubleInput()
        Me.LabelDias = New System.Windows.Forms.Label()
        Me.LabelValor = New System.Windows.Forms.Label()
        Id_contratoLabel = New System.Windows.Forms.Label()
        FechaIniLabel = New System.Windows.Forms.Label()
        FechafinLabel = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AusenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AusenciasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AusenciasBindingNavigator.SuspendLayout()
        CType(Me.VempleadoscontratadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiasTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MontoTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_contratoLabel
        '
        Id_contratoLabel.AutoSize = True
        Id_contratoLabel.Location = New System.Drawing.Point(13, 55)
        Id_contratoLabel.Name = "Id_contratoLabel"
        Id_contratoLabel.Size = New System.Drawing.Size(57, 13)
        Id_contratoLabel.TabIndex = 3
        Id_contratoLabel.Text = "Empleado:"
        '
        'FechaIniLabel
        '
        FechaIniLabel.AutoSize = True
        FechaIniLabel.Location = New System.Drawing.Point(5, 82)
        FechaIniLabel.Name = "FechaIniLabel"
        FechaIniLabel.Size = New System.Drawing.Size(65, 13)
        FechaIniLabel.TabIndex = 5
        FechaIniLabel.Text = "fecha Inicio:"
        '
        'FechafinLabel
        '
        FechafinLabel.AutoSize = True
        FechafinLabel.Location = New System.Drawing.Point(19, 108)
        FechafinLabel.Name = "FechafinLabel"
        FechafinLabel.Size = New System.Drawing.Size(51, 13)
        FechafinLabel.TabIndex = 7
        FechafinLabel.Text = "fecha fin:"
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.Location = New System.Drawing.Point(31, 159)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(39, 13)
        MontoLabel.TabIndex = 11
        MontoLabel.Text = "monto:"
        '
        'PlanillaDataSet
        '
        Me.PlanillaDataSet.DataSetName = "planillaDataSet"
        Me.PlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AusenciasBindingSource
        '
        Me.AusenciasBindingSource.DataMember = "ausencias"
        Me.AusenciasBindingSource.DataSource = Me.PlanillaDataSet
        '
        'AusenciasTableAdapter
        '
        Me.AusenciasTableAdapter.ClearBeforeFill = True
        '
        'AusenciasBindingNavigator
        '
        Me.AusenciasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AusenciasBindingNavigator.BackColor = System.Drawing.Color.AliceBlue
        Me.AusenciasBindingNavigator.BindingSource = Me.AusenciasBindingSource
        Me.AusenciasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AusenciasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AusenciasBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.AusenciasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AusenciasBindingNavigatorSaveItem})
        Me.AusenciasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AusenciasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AusenciasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AusenciasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AusenciasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AusenciasBindingNavigator.Name = "AusenciasBindingNavigator"
        Me.AusenciasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AusenciasBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.AusenciasBindingNavigator.Size = New System.Drawing.Size(534, 25)
        Me.AusenciasBindingNavigator.TabIndex = 0
        Me.AusenciasBindingNavigator.Text = "BindingNavigator1"
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
        'AusenciasBindingNavigatorSaveItem
        '
        Me.AusenciasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AusenciasBindingNavigatorSaveItem.Image = CType(resources.GetObject("AusenciasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AusenciasBindingNavigatorSaveItem.Name = "AusenciasBindingNavigatorSaveItem"
        Me.AusenciasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AusenciasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FechaIniDateTimePicker
        '
        Me.FechaIniDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AusenciasBindingSource, "fechaIni", True))
        Me.FechaIniDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaIniDateTimePicker.Location = New System.Drawing.Point(83, 78)
        Me.FechaIniDateTimePicker.Name = "FechaIniDateTimePicker"
        Me.FechaIniDateTimePicker.Size = New System.Drawing.Size(280, 22)
        Me.FechaIniDateTimePicker.TabIndex = 1
        '
        'FechafinDateTimePicker
        '
        Me.FechafinDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AusenciasBindingSource, "fechafin", True))
        Me.FechafinDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechafinDateTimePicker.Location = New System.Drawing.Point(83, 104)
        Me.FechafinDateTimePicker.Name = "FechafinDateTimePicker"
        Me.FechafinDateTimePicker.Size = New System.Drawing.Size(280, 22)
        Me.FechafinDateTimePicker.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AusenciasBindingSource, "id_contrato", True))
        Me.ComboBox1.DataSource = Me.VempleadoscontratadosBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(83, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(280, 23)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "id_contrato"
        '
        'VempleadoscontratadosBindingSource
        '
        Me.VempleadoscontratadosBindingSource.DataMember = "v_empleados_contratados"
        Me.VempleadoscontratadosBindingSource.DataSource = Me.PlanillaDataSet
        Me.VempleadoscontratadosBindingSource.Sort = "nombre"
        '
        'V_empleados_contratadosTableAdapter
        '
        Me.V_empleados_contratadosTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DiasTextBox
        '
        '
        '
        '
        Me.DiasTextBox.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DiasTextBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DiasTextBox.ButtonCalculator.Tooltip = ""
        Me.DiasTextBox.ButtonClear.Tooltip = ""
        Me.DiasTextBox.ButtonCustom.Tooltip = ""
        Me.DiasTextBox.ButtonCustom2.Tooltip = ""
        Me.DiasTextBox.ButtonDropDown.Tooltip = ""
        Me.DiasTextBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DiasTextBox.ButtonFreeText.Tooltip = ""
        Me.DiasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("ValueObject", Me.AusenciasBindingSource, "dias", True))
        Me.DiasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiasTextBox.Increment = 0.5R
        Me.DiasTextBox.Location = New System.Drawing.Point(83, 133)
        Me.DiasTextBox.Name = "DiasTextBox"
        Me.DiasTextBox.ShowUpDown = True
        Me.DiasTextBox.Size = New System.Drawing.Size(120, 22)
        Me.DiasTextBox.TabIndex = 3
        '
        'MontoTextBox
        '
        '
        '
        '
        Me.MontoTextBox.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.MontoTextBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MontoTextBox.ButtonCalculator.Tooltip = ""
        Me.MontoTextBox.ButtonClear.Tooltip = ""
        Me.MontoTextBox.ButtonCustom.Tooltip = ""
        Me.MontoTextBox.ButtonCustom2.Tooltip = ""
        Me.MontoTextBox.ButtonDropDown.Tooltip = ""
        Me.MontoTextBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.MontoTextBox.ButtonFreeText.Tooltip = ""
        Me.MontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("ValueObject", Me.AusenciasBindingSource, "monto", True))
        Me.MontoTextBox.DisplayFormat = "C"
        Me.MontoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoTextBox.Increment = 1.0R
        Me.MontoTextBox.Location = New System.Drawing.Point(83, 161)
        Me.MontoTextBox.Name = "MontoTextBox"
        Me.MontoTextBox.Size = New System.Drawing.Size(120, 22)
        Me.MontoTextBox.TabIndex = 12
        '
        'LabelDias
        '
        Me.LabelDias.AutoSize = True
        Me.LabelDias.Location = New System.Drawing.Point(22, 133)
        Me.LabelDias.Name = "LabelDias"
        Me.LabelDias.Size = New System.Drawing.Size(39, 13)
        Me.LabelDias.TabIndex = 13
        Me.LabelDias.Text = "Label1"
        '
        'LabelValor
        '
        Me.LabelValor.AutoSize = True
        Me.LabelValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValor.Location = New System.Drawing.Point(218, 137)
        Me.LabelValor.Name = "LabelValor"
        Me.LabelValor.Size = New System.Drawing.Size(32, 16)
        Me.LabelValor.TabIndex = 14
        Me.LabelValor.Text = "0.00"
        '
        'frmAusencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(534, 325)
        Me.Controls.Add(Me.LabelValor)
        Me.Controls.Add(Me.LabelDias)
        Me.Controls.Add(Me.MontoTextBox)
        Me.Controls.Add(Me.DiasTextBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Id_contratoLabel)
        Me.Controls.Add(FechaIniLabel)
        Me.Controls.Add(Me.FechaIniDateTimePicker)
        Me.Controls.Add(FechafinLabel)
        Me.Controls.Add(Me.FechafinDateTimePicker)
        Me.Controls.Add(MontoLabel)
        Me.Controls.Add(Me.AusenciasBindingNavigator)
        Me.DoubleBuffered = True
        Me.Name = "frmAusencias"
        Me.Text = "Ausencias"
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AusenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AusenciasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AusenciasBindingNavigator.ResumeLayout(False)
        Me.AusenciasBindingNavigator.PerformLayout()
        CType(Me.VempleadoscontratadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiasTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MontoTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlanillaDataSet As Planilla.planillaDataSet
    Friend WithEvents AusenciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AusenciasTableAdapter As Planilla.planillaDataSetTableAdapters.ausenciasTableAdapter
    Friend WithEvents AusenciasBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AusenciasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FechaIniDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechafinDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents VempleadoscontratadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents V_empleados_contratadosTableAdapter As Planilla.planillaDataSetTableAdapters.v_empleados_contratadosTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DiasTextBox As DevComponents.Editors.DoubleInput
    Friend WithEvents MontoTextBox As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelDias As System.Windows.Forms.Label
    Friend WithEvents LabelValor As System.Windows.Forms.Label

End Class
