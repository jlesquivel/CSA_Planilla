<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlanillaAgregaRubro
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
        Me.PlanillaDataSet = New Planilla.planillaDataSet()
        Me.RubrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RubrosTableAdapter = New Planilla.planillaDataSetTableAdapters.rubrosTableAdapter()
        Me.ListBoxAdv1 = New DevComponents.DotNetBar.ListBoxAdv()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RubrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlanillaDataSet
        '
        Me.PlanillaDataSet.DataSetName = "planillaDataSet"
        Me.PlanillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RubrosBindingSource
        '
        Me.RubrosBindingSource.DataMember = "rubros"
        Me.RubrosBindingSource.DataSource = Me.PlanillaDataSet
        '
        'RubrosTableAdapter
        '
        Me.RubrosTableAdapter.ClearBeforeFill = True
        '
        'ListBoxAdv1
        '
        Me.ListBoxAdv1.AutoScroll = True
        '
        '
        '
        Me.ListBoxAdv1.BackgroundStyle.Class = "ListBoxAdv"
        Me.ListBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ListBoxAdv1.CheckStateMember = Nothing
        Me.ListBoxAdv1.ContainerControlProcessDialogKey = True
        Me.ListBoxAdv1.DataSource = Me.RubrosBindingSource
        Me.ListBoxAdv1.DisplayMember = "nombre"
        Me.ListBoxAdv1.DragDropSupport = True
        Me.ListBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxAdv1.ItemTemplateBindings.Add(New DevComponents.DotNetBar.BindingDef("Text", "nombre"))
        Me.ListBoxAdv1.Location = New System.Drawing.Point(12, 12)
        Me.ListBoxAdv1.Name = "ListBoxAdv1"
        Me.ListBoxAdv1.Size = New System.Drawing.Size(320, 452)
        Me.ListBoxAdv1.TabIndex = 0
        Me.ListBoxAdv1.Text = "ListBoxAdv1"
        Me.ListBoxAdv1.ValueMember = "id_rubro"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(13, 471)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(319, 52)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Text = "AGREGAR RUBRO"
        '
        'frmPlanillaAgregaRubro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 535)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.ListBoxAdv1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPlanillaAgregaRubro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RUBROS"
        CType(Me.PlanillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RubrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlanillaDataSet As planillaDataSet
    Friend WithEvents RubrosBindingSource As BindingSource
    Friend WithEvents RubrosTableAdapter As planillaDataSetTableAdapters.rubrosTableAdapter
    Friend WithEvents ListBoxAdv1 As DevComponents.DotNetBar.ListBoxAdv
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
