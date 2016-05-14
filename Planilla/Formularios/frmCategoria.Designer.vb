<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoria
    Inherits DevComponents.DotNetBar.Office2007Form


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
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Salario_baseLabel As System.Windows.Forms.Label
        Dim AnualidadLabel As System.Windows.Forms.Label
        Dim Tipo_pagoLabel As System.Windows.Forms.Label
        Dim DescipcionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategoria))
        Me.PlanillaDataSet = New Planilla.planillaDataSet()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriasTableAdapter = New Planilla.planillaDataSetTableAdapters.categoriasTableAdapter()
        Me.CategoriasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CategoriasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Salario_baseTextBox = New System.Windows.Forms.TextBox()
        Me.AnualidadTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Tipo_pagoComboBox = New System.Windows.Forms.ComboBox()
        Me.DescipcionTextBox = New System.Windows.Forms.TextBox()
        NombreLabel = New System.Windows.Forms.Label()
        Salario_baseLabel = New System.Windows.Forms.Label()
        AnualidadLabel = New System.Windows.Forms.Label()
        Tipo_pagoLabel = New System.Windows.Forms.Label()
        DescipcionLabel = New System.Windows.Forms.Label()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CategoriasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(233, 45)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "nombre:"
        '
        'Salario_baseLabel
        '
        Salario_baseLabel.AutoSize = True
        Salario_baseLabel.Location = New System.Drawing.Point(212, 71)
        Salario_baseLabel.Name = "Salario_baseLabel"
        Salario_baseLabel.Size = New System.Drawing.Size(66, 13)
        Salario_baseLabel.TabIndex = 5
        Salario_baseLabel.Text = "salario base:"
        '
        'AnualidadLabel
        '
        AnualidadLabel.AutoSize = True
        AnualidadLabel.Location = New System.Drawing.Point(222, 97)
        AnualidadLabel.Name = "AnualidadLabel"
        AnualidadLabel.Size = New System.Drawing.Size(56, 13)
        AnualidadLabel.TabIndex = 7
        AnualidadLabel.Text = "anualidad:"
        '
        'Tipo_pagoLabel
        '
        Tipo_pagoLabel.AutoSize = True
        Tipo_pagoLabel.Location = New System.Drawing.Point(224, 123)
        Tipo_pagoLabel.Name = "Tipo_pagoLabel"
        Tipo_pagoLabel.Size = New System.Drawing.Size(54, 13)
        Tipo_pagoLabel.TabIndex = 9
        Tipo_pagoLabel.Text = "tipo pago:"
        '
        'DescipcionLabel
        '
        DescipcionLabel.AutoSize = True
        DescipcionLabel.Location = New System.Drawing.Point(217, 150)
        DescipcionLabel.Name = "DescipcionLabel"
        DescipcionLabel.Size = New System.Drawing.Size(61, 13)
        DescipcionLabel.TabIndex = 10
        DescipcionLabel.Text = "descipcion:"
        '
        'PlanillaDataSet
        '
        Me.PlanillaDataSet.DataSetName = "planillaDataSet"
        Me.PlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "categorias"
        Me.CategoriasBindingSource.DataSource = Me.PlanillaDataSet
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'CategoriasBindingNavigator
        '
        Me.CategoriasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CategoriasBindingNavigator.BackColor = System.Drawing.Color.AliceBlue
        Me.CategoriasBindingNavigator.BindingSource = Me.CategoriasBindingSource
        Me.CategoriasBindingNavigator.CountItem = Nothing
        Me.CategoriasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CategoriasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CategoriasBindingNavigatorSaveItem})
        Me.CategoriasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CategoriasBindingNavigator.MoveFirstItem = Nothing
        Me.CategoriasBindingNavigator.MoveLastItem = Nothing
        Me.CategoriasBindingNavigator.MoveNextItem = Nothing
        Me.CategoriasBindingNavigator.MovePreviousItem = Nothing
        Me.CategoriasBindingNavigator.Name = "CategoriasBindingNavigator"
        Me.CategoriasBindingNavigator.PositionItem = Nothing
        Me.CategoriasBindingNavigator.Size = New System.Drawing.Size(491, 25)
        Me.CategoriasBindingNavigator.TabIndex = 0
        Me.CategoriasBindingNavigator.Text = "BindingNavigator1"
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
        'CategoriasBindingNavigatorSaveItem
        '
        Me.CategoriasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CategoriasBindingNavigatorSaveItem.Image = CType(resources.GetObject("CategoriasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CategoriasBindingNavigatorSaveItem.Name = "CategoriasBindingNavigatorSaveItem"
        Me.CategoriasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CategoriasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(284, 42)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(126, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'Salario_baseTextBox
        '
        Me.Salario_baseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "salario_base", True))
        Me.Salario_baseTextBox.Location = New System.Drawing.Point(284, 68)
        Me.Salario_baseTextBox.Name = "Salario_baseTextBox"
        Me.Salario_baseTextBox.Size = New System.Drawing.Size(126, 20)
        Me.Salario_baseTextBox.TabIndex = 6
        Me.Salario_baseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AnualidadTextBox
        '
        Me.AnualidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "anualidad", True))
        Me.AnualidadTextBox.Location = New System.Drawing.Point(284, 94)
        Me.AnualidadTextBox.Name = "AnualidadTextBox"
        Me.AnualidadTextBox.Size = New System.Drawing.Size(126, 20)
        Me.AnualidadTextBox.TabIndex = 8
        Me.AnualidadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DataSource = Me.PlanillaDataSet
        Me.ComboBoxEx1.DisplayMember = "categorias.nombre"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEx1.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 16
        Me.ComboBoxEx1.Location = New System.Drawing.Point(0, 28)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(189, 298)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.ComboBoxEx1.TabIndex = 9
        '
        'Tipo_pagoComboBox
        '
        Me.Tipo_pagoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "tipo_pago", True))
        Me.Tipo_pagoComboBox.FormattingEnabled = True
        Me.Tipo_pagoComboBox.Items.AddRange(New Object() {"Hora", "Día", "Lección", "Salario"})
        Me.Tipo_pagoComboBox.Location = New System.Drawing.Point(284, 120)
        Me.Tipo_pagoComboBox.Name = "Tipo_pagoComboBox"
        Me.Tipo_pagoComboBox.Size = New System.Drawing.Size(126, 21)
        Me.Tipo_pagoComboBox.TabIndex = 10
        '
        'DescipcionTextBox
        '
        Me.DescipcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "descipcion", True))
        Me.DescipcionTextBox.Location = New System.Drawing.Point(284, 147)
        Me.DescipcionTextBox.Name = "DescipcionTextBox"
        Me.DescipcionTextBox.Size = New System.Drawing.Size(194, 20)
        Me.DescipcionTextBox.TabIndex = 11
        '
        'frmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 331)
        Me.Controls.Add(DescipcionLabel)
        Me.Controls.Add(Me.DescipcionTextBox)
        Me.Controls.Add(Tipo_pagoLabel)
        Me.Controls.Add(Me.Tipo_pagoComboBox)
        Me.Controls.Add(Me.ComboBoxEx1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Salario_baseLabel)
        Me.Controls.Add(Me.Salario_baseTextBox)
        Me.Controls.Add(AnualidadLabel)
        Me.Controls.Add(Me.AnualidadTextBox)
        Me.Controls.Add(Me.CategoriasBindingNavigator)
        Me.DoubleBuffered = True
        Me.Name = "frmCategoria"
        Me.Text = "Categoria"
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CategoriasBindingNavigator.ResumeLayout(False)
        Me.CategoriasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlanillaDataSet As Planilla.planillaDataSet
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As Planilla.planillaDataSetTableAdapters.categoriasTableAdapter
    Friend WithEvents CategoriasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CategoriasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Salario_baseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnualidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Tipo_pagoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DescipcionTextBox As System.Windows.Forms.TextBox
End Class
