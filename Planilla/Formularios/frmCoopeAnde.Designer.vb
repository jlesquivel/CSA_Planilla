<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCoopeAnde
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCoopeAnde))
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ListBoxAdv1 = New DevComponents.DotNetBar.ListBoxAdv()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.PlanillaDataSet = New Planilla.planillaDataSet()
        Me.ConfiguracionValoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConfiguracionValoresTableAdapter = New Planilla.planillaDataSetTableAdapters.configuracionValoresTableAdapter()
        Me.SuperValidator1 = New DevComponents.DotNetBar.Validator.SuperValidator()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.RegularExpressionValidator1 = New DevComponents.DotNetBar.Validator.RegularExpressionValidator()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfiguracionValoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.Location = New System.Drawing.Point(12, 169)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(283, 64)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Enviar Correo Planilla"
        '
        'ListBoxAdv1
        '
        Me.ListBoxAdv1.AutoScroll = True
        Me.ListBoxAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ListBoxAdv1.BackgroundStyle.Class = "ListBoxAdv"
        Me.ListBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ListBoxAdv1.ContainerControlProcessDialogKey = True
        Me.ListBoxAdv1.DragDropSupport = True
        Me.ListBoxAdv1.ForeColor = System.Drawing.Color.Black
        Me.ListBoxAdv1.Items.Add("wcamacho@coopeande1.com")
        Me.ListBoxAdv1.Items.Add("pruebas@coopeande1.com")
        Me.ListBoxAdv1.Location = New System.Drawing.Point(13, 13)
        Me.ListBoxAdv1.Name = "ListBoxAdv1"
        Me.ListBoxAdv1.Size = New System.Drawing.Size(244, 120)
        Me.ListBoxAdv1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.ListBoxAdv1.TabIndex = 1
        Me.ListBoxAdv1.Text = "ListBoxAdv1"
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
        Me.TextBoxX1.Location = New System.Drawing.Point(13, 140)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.PreventEnterBeep = True
        Me.TextBoxX1.Size = New System.Drawing.Size(244, 22)
        Me.TextBoxX1.TabIndex = 3
        Me.SuperValidator1.SetValidator1(Me.TextBoxX1, Me.RegularExpressionValidator1)
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(263, 139)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(32, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX2.TabIndex = 4
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(263, 68)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(32, 23)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.SymbolColor = System.Drawing.Color.Red
        Me.ButtonX3.TabIndex = 5
        '
        'PlanillaDataSet
        '
        Me.PlanillaDataSet.DataSetName = "planillaDataSet"
        Me.PlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConfiguracionValoresBindingSource
        '
        Me.ConfiguracionValoresBindingSource.DataMember = "configuracionValores"
        Me.ConfiguracionValoresBindingSource.DataSource = Me.PlanillaDataSet
        '
        'ConfiguracionValoresTableAdapter
        '
        Me.ConfiguracionValoresTableAdapter.ClearBeforeFill = True
        '
        'SuperValidator1
        '
        Me.SuperValidator1.ContainerControl = Me
        Me.SuperValidator1.ErrorProvider = Me.ErrorProvider1
        Me.SuperValidator1.Highlighter = Me.Highlighter1
        Me.SuperValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'RegularExpressionValidator1
        '
        Me.RegularExpressionValidator1.ErrorMessage = "Correo mal escrito"
        Me.RegularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        Me.RegularExpressionValidator1.ValidationExpression = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9" &
    "})$"
        '
        'frmCoopeAnde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 250)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.TextBoxX1)
        Me.Controls.Add(Me.ListBoxAdv1)
        Me.Controls.Add(Me.ButtonX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmCoopeAnde"
        Me.ShowIcon = False
        Me.Text = "CoopeAnde"
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfiguracionValoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ListBoxAdv1 As DevComponents.DotNetBar.ListBoxAdv
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PlanillaDataSet As planillaDataSet
    Friend WithEvents ConfiguracionValoresBindingSource As BindingSource
    Friend WithEvents ConfiguracionValoresTableAdapter As planillaDataSetTableAdapters.configuracionValoresTableAdapter
    Friend WithEvents SuperValidator1 As DevComponents.DotNetBar.Validator.SuperValidator
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents RegularExpressionValidator1 As DevComponents.DotNetBar.Validator.RegularExpressionValidator
End Class
