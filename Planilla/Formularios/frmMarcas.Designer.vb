<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMarcas
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
        Me.bReporte = New DevComponents.DotNetBar.ButtonX()
        Me.cbAno = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbMes = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cbDpto = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Puestos_ContratosActivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillaDataSet1 = New Planilla.planillaDataSet1()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ListBoxAdv1 = New DevComponents.DotNetBar.ListBoxAdv()
        Me.ContratosActivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Puestos_ContratosActivosTableAdapter1 = New Planilla.planillaDataSet1TableAdapters.puestos_ContratosActivosTableAdapter()
        Me.TableAdapterManager = New Planilla.planillaDataSet1TableAdapters.TableAdapterManager()
        Me.ContratosActivosTableAdapter = New Planilla.planillaDataSet1TableAdapters.ContratosActivosTableAdapter()
        CType(Me.Puestos_ContratosActivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratosActivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bReporte
        '
        Me.bReporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.bReporte.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.bReporte.Location = New System.Drawing.Point(65, 444)
        Me.bReporte.Name = "bReporte"
        Me.bReporte.Size = New System.Drawing.Size(121, 39)
        Me.bReporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.bReporte.TabIndex = 0
        Me.bReporte.Text = "Reporte"
        '
        'cbAno
        '
        Me.cbAno.DisplayMember = "Text"
        Me.cbAno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbAno.ForeColor = System.Drawing.Color.Black
        Me.cbAno.FormattingEnabled = True
        Me.cbAno.ItemHeight = 20
        Me.cbAno.Location = New System.Drawing.Point(65, 21)
        Me.cbAno.Name = "cbAno"
        Me.cbAno.Size = New System.Drawing.Size(121, 26)
        Me.cbAno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbAno.TabIndex = 1
        '
        'cbMes
        '
        Me.cbMes.DisplayMember = "Text"
        Me.cbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbMes.ForeColor = System.Drawing.Color.Black
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.ItemHeight = 20
        Me.cbMes.Location = New System.Drawing.Point(65, 49)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(121, 26)
        Me.cbMes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbMes.TabIndex = 2
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(7, 49)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(52, 23)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "Mes"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(7, 19)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX2.Size = New System.Drawing.Size(52, 24)
        Me.LabelX2.TabIndex = 5
        Me.LabelX2.Text = "Año"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(7, 112)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX3.Size = New System.Drawing.Size(52, 24)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Personas"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(7, 77)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX4.Size = New System.Drawing.Size(52, 23)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Puestos"
        '
        'cbDpto
        '
        Me.cbDpto.DataSource = Me.Puestos_ContratosActivosBindingSource
        Me.cbDpto.DisplayMember = "nombre"
        Me.cbDpto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDpto.ForeColor = System.Drawing.Color.Black
        Me.cbDpto.FormattingEnabled = True
        Me.cbDpto.ItemHeight = 20
        Me.cbDpto.Location = New System.Drawing.Point(65, 77)
        Me.cbDpto.Name = "cbDpto"
        Me.cbDpto.Size = New System.Drawing.Size(121, 26)
        Me.cbDpto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbDpto.TabIndex = 7
        Me.cbDpto.ValueMember = "id_puesto"
        '
        'Puestos_ContratosActivosBindingSource
        '
        Me.Puestos_ContratosActivosBindingSource.DataMember = "puestos_ContratosActivos"
        Me.Puestos_ContratosActivosBindingSource.DataSource = Me.PlanillaDataSet1
        '
        'PlanillaDataSet1
        '
        Me.PlanillaDataSet1.DataSetName = "planillaDataSet1"
        Me.PlanillaDataSet1.EnforceConstraints = False
        Me.PlanillaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.ForeColor = System.Drawing.Color.Black
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(303, 21)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(614, 462)
        Me.CrystalReportViewer1.TabIndex = 9
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ListBoxAdv1
        '
        Me.ListBoxAdv1.AutoScroll = True
        '
        '
        '
        Me.ListBoxAdv1.BackgroundStyle.Class = "ListBoxAdv"
        Me.ListBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ListBoxAdv1.CheckBoxesVisible = True
        Me.ListBoxAdv1.CheckStateMember = Nothing
        Me.ListBoxAdv1.ContainerControlProcessDialogKey = True
        Me.ListBoxAdv1.DataSource = Me.ContratosActivosBindingSource
        Me.ListBoxAdv1.DisplayMember = "nombre"
        Me.ListBoxAdv1.DragDropSupport = True
        Me.ListBoxAdv1.ItemTemplateBindings.Add(New DevComponents.DotNetBar.BindingDef("Text", "nombre"))
        Me.ListBoxAdv1.ItemTemplateBindings.Add(New DevComponents.DotNetBar.BindingDef("Text", "nombre"))
        Me.ListBoxAdv1.ItemTemplateBindings.Add(New DevComponents.DotNetBar.BindingDef("Text", "nombre"))
        Me.ListBoxAdv1.ItemTemplateBindings.Add(New DevComponents.DotNetBar.BindingDef("Text", "nombre"))
        Me.ListBoxAdv1.ItemTemplateBindings.Add(New DevComponents.DotNetBar.BindingDef("Text", "nombre"))
        Me.ListBoxAdv1.ItemTemplateBindings.Add(New DevComponents.DotNetBar.BindingDef("Text", "nombre"))
        Me.ListBoxAdv1.ItemTemplateBindings.Add(New DevComponents.DotNetBar.BindingDef("Text", "nombre"))
        Me.ListBoxAdv1.ItemTemplateBindings.Add(New DevComponents.DotNetBar.BindingDef("Text", "nombre"))
        Me.ListBoxAdv1.ItemTemplateBindings.Add(New DevComponents.DotNetBar.BindingDef("Text", "nombre"))
        Me.ListBoxAdv1.Location = New System.Drawing.Point(65, 112)
        Me.ListBoxAdv1.Name = "ListBoxAdv1"
        Me.ListBoxAdv1.Size = New System.Drawing.Size(232, 313)
        Me.ListBoxAdv1.TabIndex = 10
        Me.ListBoxAdv1.Tag = "cedula"
        Me.ListBoxAdv1.Text = "ListBoxAdv1"
        Me.ListBoxAdv1.ValueMember = "cedula"
        '
        'ContratosActivosBindingSource
        '
        Me.ContratosActivosBindingSource.DataMember = "ContratosActivos"
        Me.ContratosActivosBindingSource.DataSource = Me.PlanillaDataSet1
        '
        'Puestos_ContratosActivosTableAdapter1
        '
        Me.Puestos_ContratosActivosTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Planilla.planillaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ContratosActivosTableAdapter
        '
        Me.ContratosActivosTableAdapter.ClearBeforeFill = True
        '
        'frmMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 513)
        Me.Controls.Add(Me.ListBoxAdv1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.cbDpto)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.cbMes)
        Me.Controls.Add(Me.cbAno)
        Me.Controls.Add(Me.bReporte)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMarcas"
        Me.Text = "MARCAS DE ENTRADA"
        CType(Me.Puestos_ContratosActivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratosActivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bReporte As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbAno As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbMes As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbDpto As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ListBoxAdv1 As DevComponents.DotNetBar.ListBoxAdv
    Friend WithEvents PlanillaDataSet1 As planillaDataSet1
    Friend WithEvents Puestos_ContratosActivosBindingSource As BindingSource
    Friend WithEvents Puestos_ContratosActivosTableAdapter1 As planillaDataSet1TableAdapters.puestos_ContratosActivosTableAdapter
    Friend WithEvents TableAdapterManager As planillaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ContratosActivosBindingSource As BindingSource
    Friend WithEvents ContratosActivosTableAdapter As planillaDataSet1TableAdapters.ContratosActivosTableAdapter
End Class
