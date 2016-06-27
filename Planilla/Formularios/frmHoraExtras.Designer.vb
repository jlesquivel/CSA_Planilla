<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoraExtras
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.gTotal = New DevComponents.Editors.DoubleInput()
        Me.mMix = New DevComponents.Editors.DoubleInput()
        Me.mNoc = New DevComponents.Editors.DoubleInput()
        Me.mExtra = New DevComponents.Editors.DoubleInput()
        Me.dMixta = New DevComponents.Editors.DoubleInput()
        Me.dNocturna = New DevComponents.Editors.DoubleInput()
        Me.dExtra = New DevComponents.Editors.DoubleInput()
        Me.Horas_extrasDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.extra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nocturna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mixta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horas_extrasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds2planilla = New Planilla.ds2planilla()
        Me.Horas_extrasTableAdapter = New Planilla.ds2planillaTableAdapters.horas_extrasTableAdapter()
        Me.CuEmpleado1 = New Planilla.cuEmpleado()
        Me.BEmpleado1 = New Planilla.bEmpleado()
        Me.PanelEx1.SuspendLayout()
        CType(Me.gTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mMix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mNoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dMixta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dNocturna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas_extrasDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas_extrasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds2planilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.gTotal)
        Me.PanelEx1.Controls.Add(Me.mMix)
        Me.PanelEx1.Controls.Add(Me.mNoc)
        Me.PanelEx1.Controls.Add(Me.mExtra)
        Me.PanelEx1.Controls.Add(Me.dMixta)
        Me.PanelEx1.Controls.Add(Me.dNocturna)
        Me.PanelEx1.Controls.Add(Me.dExtra)
        Me.PanelEx1.Controls.Add(Me.Horas_extrasDataGridViewX)
        Me.PanelEx1.Controls.Add(Me.CuEmpleado1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(230, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(586, 531)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'gTotal
        '
        '
        '
        '
        Me.gTotal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.gTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gTotal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.gTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gTotal.Increment = 1.0R
        Me.gTotal.Location = New System.Drawing.Point(468, 500)
        Me.gTotal.Name = "gTotal"
        Me.gTotal.Size = New System.Drawing.Size(101, 25)
        Me.gTotal.TabIndex = 8
        '
        'mMix
        '
        '
        '
        '
        Me.mMix.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.mMix.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mMix.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.mMix.Increment = 1.0R
        Me.mMix.Location = New System.Drawing.Point(367, 500)
        Me.mMix.Name = "mMix"
        Me.mMix.Size = New System.Drawing.Size(80, 22)
        Me.mMix.TabIndex = 7
        '
        'mNoc
        '
        '
        '
        '
        Me.mNoc.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.mNoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mNoc.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.mNoc.Increment = 1.0R
        Me.mNoc.Location = New System.Drawing.Point(268, 500)
        Me.mNoc.Name = "mNoc"
        Me.mNoc.Size = New System.Drawing.Size(80, 22)
        Me.mNoc.TabIndex = 6
        '
        'mExtra
        '
        '
        '
        '
        Me.mExtra.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.mExtra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mExtra.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.mExtra.Increment = 1.0R
        Me.mExtra.Location = New System.Drawing.Point(171, 500)
        Me.mExtra.Name = "mExtra"
        Me.mExtra.Size = New System.Drawing.Size(80, 22)
        Me.mExtra.TabIndex = 5
        '
        'dMixta
        '
        '
        '
        '
        Me.dMixta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dMixta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dMixta.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.dMixta.Increment = 1.0R
        Me.dMixta.Location = New System.Drawing.Point(367, 472)
        Me.dMixta.Name = "dMixta"
        Me.dMixta.Size = New System.Drawing.Size(80, 22)
        Me.dMixta.TabIndex = 4
        '
        'dNocturna
        '
        '
        '
        '
        Me.dNocturna.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dNocturna.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dNocturna.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.dNocturna.Increment = 1.0R
        Me.dNocturna.Location = New System.Drawing.Point(268, 472)
        Me.dNocturna.Name = "dNocturna"
        Me.dNocturna.Size = New System.Drawing.Size(80, 22)
        Me.dNocturna.TabIndex = 3
        '
        'dExtra
        '
        '
        '
        '
        Me.dExtra.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dExtra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dExtra.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.dExtra.Increment = 1.0R
        Me.dExtra.Location = New System.Drawing.Point(171, 472)
        Me.dExtra.Name = "dExtra"
        Me.dExtra.Size = New System.Drawing.Size(80, 22)
        Me.dExtra.TabIndex = 2
        '
        'Horas_extrasDataGridViewX
        '
        Me.Horas_extrasDataGridViewX.AllowUserToAddRows = False
        Me.Horas_extrasDataGridViewX.AllowUserToDeleteRows = False
        Me.Horas_extrasDataGridViewX.AllowUserToResizeColumns = False
        Me.Horas_extrasDataGridViewX.AllowUserToResizeRows = False
        Me.Horas_extrasDataGridViewX.AutoGenerateColumns = False
        Me.Horas_extrasDataGridViewX.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Horas_extrasDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Horas_extrasDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.extra, Me.nocturna, Me.mixta})
        Me.Horas_extrasDataGridViewX.DataSource = Me.Horas_extrasBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Horas_extrasDataGridViewX.DefaultCellStyle = DataGridViewCellStyle4
        Me.Horas_extrasDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Horas_extrasDataGridViewX.Location = New System.Drawing.Point(6, 116)
        Me.Horas_extrasDataGridViewX.Name = "Horas_extrasDataGridViewX"
        Me.Horas_extrasDataGridViewX.RowHeadersWidth = 31
        Me.Horas_extrasDataGridViewX.Size = New System.Drawing.Size(568, 350)
        Me.Horas_extrasDataGridViewX.TabIndex = 1
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'extra
        '
        Me.extra.DataPropertyName = "extra"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "n0"
        Me.extra.DefaultCellStyle = DataGridViewCellStyle1
        Me.extra.HeaderText = "extra"
        Me.extra.Name = "extra"
        '
        'nocturna
        '
        Me.nocturna.DataPropertyName = "nocturna"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.Format = "N0"
        Me.nocturna.DefaultCellStyle = DataGridViewCellStyle2
        Me.nocturna.HeaderText = "nocturna"
        Me.nocturna.Name = "nocturna"
        '
        'mixta
        '
        Me.mixta.DataPropertyName = "mixta"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "n0"
        Me.mixta.DefaultCellStyle = DataGridViewCellStyle3
        Me.mixta.HeaderText = "mixta"
        Me.mixta.Name = "mixta"
        '
        'Horas_extrasBindingSource
        '
        Me.Horas_extrasBindingSource.DataMember = "horas_extras"
        Me.Horas_extrasBindingSource.DataSource = Me.Ds2planilla
        '
        'Ds2planilla
        '
        Me.Ds2planilla.DataSetName = "ds2planilla"
        Me.Ds2planilla.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.Ds2planilla.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Horas_extrasTableAdapter
        '
        Me.Horas_extrasTableAdapter.ClearBeforeFill = True
        '
        'CuEmpleado1
        '
        Me.CuEmpleado1.Location = New System.Drawing.Point(6, 3)
        Me.CuEmpleado1.Name = "CuEmpleado1"
        Me.CuEmpleado1.Size = New System.Drawing.Size(563, 107)
        Me.CuEmpleado1.TabIndex = 0
        '
        'BEmpleado1
        '
        Me.BEmpleado1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BEmpleado1.HoraExtra = False
        Me.BEmpleado1.Location = New System.Drawing.Point(0, 0)
        Me.BEmpleado1.Name = "BEmpleado1"
        Me.BEmpleado1.Size = New System.Drawing.Size(230, 531)
        Me.BEmpleado1.TabIndex = 0
        '
        'frmHoraExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 531)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.BEmpleado1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHoraExtras"
        Me.Text = "Horas Extras"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.gTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mMix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mNoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mExtra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dMixta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dNocturna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dExtra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas_extrasDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas_extrasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds2planilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BEmpleado1 As bEmpleado
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents CuEmpleado1 As cuEmpleado
    Friend WithEvents Ds2planilla As ds2planilla
    Friend WithEvents Horas_extrasBindingSource As BindingSource
    Friend WithEvents Horas_extrasTableAdapter As ds2planillaTableAdapters.horas_extrasTableAdapter
    Friend WithEvents Horas_extrasDataGridViewX As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dMixta As DevComponents.Editors.DoubleInput
    Friend WithEvents dNocturna As DevComponents.Editors.DoubleInput
    Friend WithEvents dExtra As DevComponents.Editors.DoubleInput
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents extra As DataGridViewTextBoxColumn
    Friend WithEvents nocturna As DataGridViewTextBoxColumn
    Friend WithEvents mixta As DataGridViewTextBoxColumn
    Friend WithEvents mMix As DevComponents.Editors.DoubleInput
    Friend WithEvents mNoc As DevComponents.Editors.DoubleInput
    Friend WithEvents mExtra As DevComponents.Editors.DoubleInput
    Friend WithEvents gTotal As DevComponents.Editors.DoubleInput
End Class
