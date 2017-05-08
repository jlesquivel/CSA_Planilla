<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bEmpleado
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
        Me.components = New System.ComponentModel.Container()
        Me.V_empleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillaDataSet = New Planilla.planillaDataSet()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.SwitchButton1 = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.V_empleadosTableAdapter = New Planilla.planillaDataSetTableAdapters.v_empleadosTableAdapter()
        CType(Me.V_empleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'V_empleadosBindingSource
        '
        Me.V_empleadosBindingSource.DataMember = "v_empleados"
        Me.V_empleadosBindingSource.DataSource = Me.PlanillaDataSet
        '
        'PlanillaDataSet
        '
        Me.PlanillaDataSet.DataSetName = "planillaDataSet"
        Me.PlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.ComboBoxEx1)
        Me.PanelEx1.Controls.Add(Me.SwitchButton1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(267, 432)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        Me.PanelEx1.Text = "PanelEx1"
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DataSource = Me.V_empleadosBindingSource
        Me.ComboBoxEx1.DisplayMember = "nombre"
        Me.ComboBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxEx1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEx1.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 21
        Me.ComboBoxEx1.Location = New System.Drawing.Point(0, 37)
        Me.ComboBoxEx1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(267, 395)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx1.TabIndex = 2
        Me.ComboBoxEx1.ValueMember = "id_emp"
        '
        'SwitchButton1
        '
        '
        '
        '
        Me.SwitchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SwitchButton1.Location = New System.Drawing.Point(0, 0)
        Me.SwitchButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SwitchButton1.Name = "SwitchButton1"
        Me.SwitchButton1.OffText = "Empleados Activos"
        Me.SwitchButton1.OnBackColor = System.Drawing.Color.PaleGreen
        Me.SwitchButton1.OnText = "Todos los empleados"
        Me.SwitchButton1.Size = New System.Drawing.Size(267, 37)
        Me.SwitchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton1.TabIndex = 0
        '
        'V_empleadosTableAdapter
        '
        Me.V_empleadosTableAdapter.ClearBeforeFill = True
        '
        'bEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "bEmpleado"
        Me.Size = New System.Drawing.Size(267, 432)
        CType(Me.V_empleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PlanillaDataSet As Planilla.planillaDataSet
    Friend WithEvents V_empleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents V_empleadosTableAdapter As Planilla.planillaDataSetTableAdapters.v_empleadosTableAdapter
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents SwitchButton1 As DevComponents.DotNetBar.Controls.SwitchButton

End Class
