<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucVacaciones
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsVacaciones = New Planilla.dsVacaciones()
        Me.VacacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VacacionesTableAdapter = New Planilla.dsVacacionesTableAdapters.VacacionesTableAdapter()
        Me.TableAdapterManager = New Planilla.dsVacacionesTableAdapters.TableAdapterManager()
        Me.VacacionesDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.id_vacacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcontratoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periodo = New DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn()
        Me.fIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ffin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DerechoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisfrutadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        CType(Me.DsVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacacionesDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsVacaciones
        '
        Me.DsVacaciones.DataSetName = "dsVacaciones"
        Me.DsVacaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VacacionesBindingSource
        '
        Me.VacacionesBindingSource.DataMember = "Vacaciones"
        Me.VacacionesBindingSource.DataSource = Me.DsVacaciones
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
        'VacacionesDataGridViewX
        '
        Me.VacacionesDataGridViewX.AllowUserToAddRows = False
        Me.VacacionesDataGridViewX.AllowUserToDeleteRows = False
        Me.VacacionesDataGridViewX.AllowUserToOrderColumns = True
        Me.VacacionesDataGridViewX.AutoGenerateColumns = False
        Me.VacacionesDataGridViewX.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VacacionesDataGridViewX.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.VacacionesDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VacacionesDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_vacacion, Me.IdcontratoDataGridViewTextBoxColumn, Me.periodo, Me.fIni, Me.ffin, Me.DerechoDataGridViewTextBoxColumn, Me.DisfrutadoDataGridViewTextBoxColumn, Me.saldo})
        Me.VacacionesDataGridViewX.DataSource = Me.VacacionesBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.VacacionesDataGridViewX.DefaultCellStyle = DataGridViewCellStyle2
        Me.VacacionesDataGridViewX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VacacionesDataGridViewX.EnableHeadersVisualStyles = False
        Me.VacacionesDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.VacacionesDataGridViewX.Location = New System.Drawing.Point(0, 0)
        Me.VacacionesDataGridViewX.Name = "VacacionesDataGridViewX"
        Me.VacacionesDataGridViewX.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VacacionesDataGridViewX.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.VacacionesDataGridViewX.Size = New System.Drawing.Size(502, 331)
        Me.VacacionesDataGridViewX.TabIndex = 1
        '
        'id_vacacion
        '
        Me.id_vacacion.DataPropertyName = "id_vacacion"
        Me.id_vacacion.HeaderText = "id_vacacion"
        Me.id_vacacion.Name = "id_vacacion"
        Me.id_vacacion.ReadOnly = True
        Me.id_vacacion.Width = 50
        '
        'IdcontratoDataGridViewTextBoxColumn
        '
        Me.IdcontratoDataGridViewTextBoxColumn.DataPropertyName = "id_contrato"
        Me.IdcontratoDataGridViewTextBoxColumn.HeaderText = "id_contrato"
        Me.IdcontratoDataGridViewTextBoxColumn.Name = "IdcontratoDataGridViewTextBoxColumn"
        Me.IdcontratoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdcontratoDataGridViewTextBoxColumn.Visible = False
        '
        'periodo
        '
        '
        '
        '
        Me.periodo.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.periodo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.periodo.DataPropertyName = "periodo"
        Me.periodo.HeaderText = "periodo"
        Me.periodo.Name = "periodo"
        Me.periodo.ReadOnly = True
        Me.periodo.Width = 50
        '
        'fIni
        '
        Me.fIni.DataPropertyName = "fIni"
        Me.fIni.HeaderText = "fIni"
        Me.fIni.Name = "fIni"
        Me.fIni.ReadOnly = True
        Me.fIni.Width = 90
        '
        'ffin
        '
        Me.ffin.DataPropertyName = "ffin"
        Me.ffin.HeaderText = "ffin"
        Me.ffin.Name = "ffin"
        Me.ffin.ReadOnly = True
        Me.ffin.Width = 90
        '
        'DerechoDataGridViewTextBoxColumn
        '
        Me.DerechoDataGridViewTextBoxColumn.DataPropertyName = "derecho"
        Me.DerechoDataGridViewTextBoxColumn.HeaderText = "derecho"
        Me.DerechoDataGridViewTextBoxColumn.Name = "DerechoDataGridViewTextBoxColumn"
        Me.DerechoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DerechoDataGridViewTextBoxColumn.Width = 60
        '
        'DisfrutadoDataGridViewTextBoxColumn
        '
        Me.DisfrutadoDataGridViewTextBoxColumn.DataPropertyName = "disfrutado"
        Me.DisfrutadoDataGridViewTextBoxColumn.HeaderText = "disfrutado"
        Me.DisfrutadoDataGridViewTextBoxColumn.Name = "DisfrutadoDataGridViewTextBoxColumn"
        Me.DisfrutadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DisfrutadoDataGridViewTextBoxColumn.Width = 60
        '
        'saldo
        '
        Me.saldo.DataPropertyName = "saldo"
        Me.saldo.HeaderText = "saldo"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Width = 60
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReflectionLabel1.Location = New System.Drawing.Point(0, 0)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(502, 39)
        Me.ReflectionLabel1.TabIndex = 2
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>Control</i><font color=""#22B14C""> Vacaciones</font></font><" &
    "/b>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx1.Location = New System.Drawing.Point(0, 370)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(502, 40)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 3
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(366, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(92, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Dias disponible"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.FontBold = True
        Me.LabelX1.Location = New System.Drawing.Point(435, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX1.Size = New System.Drawing.Size(55, 23)
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "0"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.ReflectionLabel1)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(502, 39)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 7
        Me.PanelEx2.Text = "PanelEx2"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.VacacionesDataGridViewX)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Location = New System.Drawing.Point(0, 39)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(502, 331)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 11
        Me.PanelEx3.Text = "PanelEx3"
        '
        'ucVacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.PanelEx3)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "ucVacaciones"
        Me.Size = New System.Drawing.Size(502, 410)
        CType(Me.DsVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacacionesDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsVacaciones As dsVacaciones
    Friend WithEvents VacacionesBindingSource As BindingSource
    Friend WithEvents VacacionesTableAdapter As dsVacacionesTableAdapters.VacacionesTableAdapter
    Friend WithEvents TableAdapterManager As dsVacacionesTableAdapters.TableAdapterManager
    Friend WithEvents VacacionesDataGridViewX As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents id_vacacion As DataGridViewTextBoxColumn
    Friend WithEvents IdcontratoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents periodo As DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn
    Friend WithEvents fIni As DataGridViewTextBoxColumn
    Friend WithEvents ffin As DataGridViewTextBoxColumn
    Friend WithEvents DerechoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DisfrutadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewTextBoxColumn
End Class
