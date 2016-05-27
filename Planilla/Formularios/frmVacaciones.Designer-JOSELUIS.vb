<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVacaciones
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdvacacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaI = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.fechaF = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.MotivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaDataGridViewTextBoxColumn = New DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn()
        Me.VacacionregBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsVacaciones = New Planilla.dsVacaciones()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.DiasRango = New DevComponents.Editors.IntegerInput()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.DiasSaldo = New DevComponents.Editors.IntegerInput()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.motivo = New DevComponents.DotNetBar.Controls.TextBoxDropDown()
        Me.nota = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DateTimeInput2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.DateTimeInput1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Vacacion_regTableAdapter = New Planilla.dsVacacionesTableAdapters.Vacacion_regTableAdapter()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacacionregBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me.DiasRango, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiasSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimeInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdvacacionDataGridViewTextBoxColumn, Me.DiasDataGridViewTextBoxColumn, Me.fechaI, Me.fechaF, Me.MotivoDataGridViewTextBoxColumn, Me.NotaDataGridViewTextBoxColumn})
        Me.DataGridViewX1.DataSource = Me.VacacionregBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.Size = New System.Drawing.Size(777, 243)
        Me.DataGridViewX1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'IdvacacionDataGridViewTextBoxColumn
        '
        Me.IdvacacionDataGridViewTextBoxColumn.DataPropertyName = "id_vacacion"
        Me.IdvacacionDataGridViewTextBoxColumn.HeaderText = "id_vacacion"
        Me.IdvacacionDataGridViewTextBoxColumn.Name = "IdvacacionDataGridViewTextBoxColumn"
        Me.IdvacacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdvacacionDataGridViewTextBoxColumn.Visible = False
        '
        'DiasDataGridViewTextBoxColumn
        '
        Me.DiasDataGridViewTextBoxColumn.DataPropertyName = "dias"
        Me.DiasDataGridViewTextBoxColumn.HeaderText = "dias"
        Me.DiasDataGridViewTextBoxColumn.Name = "DiasDataGridViewTextBoxColumn"
        Me.DiasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'fechaI
        '
        '
        '
        '
        Me.fechaI.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.fechaI.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.fechaI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI.BackgroundStyle.TextColor = System.Drawing.Color.Black
        Me.fechaI.ButtonCustom.Visible = True
        Me.fechaI.ButtonDropDown.Visible = True
        Me.fechaI.DataPropertyName = "fechaI"
        Me.fechaI.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.fechaI.HeaderText = "Fecha Inicio"
        Me.fechaI.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        '
        '
        '
        Me.fechaI.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.fechaI.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.fechaI.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI.Name = "fechaI"
        Me.fechaI.ReadOnly = True
        Me.fechaI.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaI.Width = 200
        '
        'fechaF
        '
        '
        '
        '
        Me.fechaF.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.fechaF.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.fechaF.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF.BackgroundStyle.TextColor = System.Drawing.Color.Black
        Me.fechaF.ButtonDropDown.Visible = True
        Me.fechaF.DataPropertyName = "fechaF"
        Me.fechaF.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.fechaF.HeaderText = "Fecha Fin"
        Me.fechaF.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        '
        '
        '
        Me.fechaF.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.fechaF.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.fechaF.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF.Name = "fechaF"
        Me.fechaF.ReadOnly = True
        Me.fechaF.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fechaF.Width = 200
        '
        'MotivoDataGridViewTextBoxColumn
        '
        Me.MotivoDataGridViewTextBoxColumn.DataPropertyName = "motivo"
        Me.MotivoDataGridViewTextBoxColumn.HeaderText = "motivo"
        Me.MotivoDataGridViewTextBoxColumn.Name = "MotivoDataGridViewTextBoxColumn"
        Me.MotivoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotaDataGridViewTextBoxColumn
        '
        Me.NotaDataGridViewTextBoxColumn.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.NotaDataGridViewTextBoxColumn.BackgroundStyle.Class = "DataGridViewBorder"
        Me.NotaDataGridViewTextBoxColumn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NotaDataGridViewTextBoxColumn.Culture = New System.Globalization.CultureInfo("es-MX")
        Me.NotaDataGridViewTextBoxColumn.DataPropertyName = "nota"
        Me.NotaDataGridViewTextBoxColumn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NotaDataGridViewTextBoxColumn.HeaderText = "nota"
        Me.NotaDataGridViewTextBoxColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NotaDataGridViewTextBoxColumn.Mask = ""
        Me.NotaDataGridViewTextBoxColumn.Name = "NotaDataGridViewTextBoxColumn"
        Me.NotaDataGridViewTextBoxColumn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NotaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NotaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NotaDataGridViewTextBoxColumn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NotaDataGridViewTextBoxColumn.Text = ""
        '
        'VacacionregBindingSource
        '
        Me.VacacionregBindingSource.DataMember = "Vacacion_reg"
        Me.VacacionregBindingSource.DataSource = Me.DsVacaciones
        '
        'DsVacaciones
        '
        Me.DsVacaciones.DataSetName = "dsVacaciones"
        Me.DsVacaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.LabelX6)
        Me.PanelEx1.Controls.Add(Me.DiasRango)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.DiasSaldo)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.motivo)
        Me.PanelEx1.Controls.Add(Me.nota)
        Me.PanelEx1.Controls.Add(Me.DateTimeInput2)
        Me.PanelEx1.Controls.Add(Me.DateTimeInput1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(12, 261)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.ShowFocusRectangle = True
        Me.PanelEx1.Size = New System.Drawing.Size(563, 138)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 3
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(434, 3)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(45, 20)
        Me.LabelX6.TabIndex = 12
        Me.LabelX6.Text = "Dias del Rango"
        '
        'DiasRango
        '
        '
        '
        '
        Me.DiasRango.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DiasRango.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DiasRango.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DiasRango.Location = New System.Drawing.Point(434, 21)
        Me.DiasRango.Name = "DiasRango"
        Me.DiasRango.Size = New System.Drawing.Size(32, 22)
        Me.DiasRango.TabIndex = 11
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(494, 0)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(45, 20)
        Me.LabelX5.TabIndex = 10
        Me.LabelX5.Text = "Saldo"
        '
        'DiasSaldo
        '
        '
        '
        '
        Me.DiasSaldo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DiasSaldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DiasSaldo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DiasSaldo.Location = New System.Drawing.Point(507, 21)
        Me.DiasSaldo.Name = "DiasSaldo"
        Me.DiasSaldo.Size = New System.Drawing.Size(32, 22)
        Me.DiasSaldo.TabIndex = 9
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(481, 67)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(58, 61)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 32.0!
        Me.ButtonX1.TabIndex = 8
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(48, 48)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(80, 14)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "Nota"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(310, 3)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(80, 17)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Fecha Fin"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(186, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(80, 17)
        Me.LabelX2.TabIndex = 5
        Me.LabelX2.Text = "Fecha Inicio"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(48, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(80, 14)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "Motivo"
        '
        'motivo
        '
        Me.motivo.AutoCompleteCustomSource.AddRange(New String() {"Vacaciones", "Permiso", "Ausencia"})
        Me.motivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.motivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.motivo.BackgroundStyle.Class = "TextBoxBorder"
        Me.motivo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.motivo.ButtonDropDown.Visible = True
        Me.motivo.Location = New System.Drawing.Point(48, 21)
        Me.motivo.Name = "motivo"
        Me.motivo.Size = New System.Drawing.Size(115, 21)
        Me.motivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.motivo.TabIndex = 3
        Me.motivo.Text = ""
        '
        'nota
        '
        Me.nota.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.nota.Border.Class = "TextBoxBorder"
        Me.nota.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nota.DisabledBackColor = System.Drawing.Color.White
        Me.nota.ForeColor = System.Drawing.Color.Black
        Me.nota.Location = New System.Drawing.Point(48, 67)
        Me.nota.Multiline = True
        Me.nota.Name = "nota"
        Me.nota.PreventEnterBeep = True
        Me.nota.Size = New System.Drawing.Size(380, 61)
        Me.nota.TabIndex = 2
        '
        'DateTimeInput2
        '
        '
        '
        '
        Me.DateTimeInput2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimeInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimeInput2.ButtonDropDown.Visible = True
        Me.DateTimeInput2.IsPopupCalendarOpen = False
        Me.DateTimeInput2.Location = New System.Drawing.Point(310, 21)
        '
        '
        '
        '
        '
        '
        Me.DateTimeInput2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateTimeInput2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput2.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        Me.DateTimeInput2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimeInput2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput2.MonthCalendar.TodayButtonVisible = True
        Me.DateTimeInput2.Name = "DateTimeInput2"
        Me.DateTimeInput2.Size = New System.Drawing.Size(118, 22)
        Me.DateTimeInput2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimeInput2.TabIndex = 1
        '
        'DateTimeInput1
        '
        '
        '
        '
        Me.DateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimeInput1.ButtonDropDown.Visible = True
        Me.DateTimeInput1.IsPopupCalendarOpen = False
        Me.DateTimeInput1.Location = New System.Drawing.Point(186, 20)
        '
        '
        '
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateTimeInput1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        Me.DateTimeInput1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.TodayButtonVisible = True
        Me.DateTimeInput1.Name = "DateTimeInput1"
        Me.DateTimeInput1.Size = New System.Drawing.Size(118, 22)
        Me.DateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimeInput1.TabIndex = 0
        '
        'Vacacion_regTableAdapter
        '
        Me.Vacacion_regTableAdapter.ClearBeforeFill = True
        '
        'frmVacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 436)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVacaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vacaciones"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacacionregBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.DiasRango, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiasSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimeInput2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DsVacaciones As dsVacaciones
    Friend WithEvents VacacionregBindingSource As BindingSource
    Friend WithEvents Vacacion_regTableAdapter As dsVacacionesTableAdapters.Vacacion_regTableAdapter
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents motivo As DevComponents.DotNetBar.Controls.TextBoxDropDown
    Friend WithEvents nota As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DateTimeInput2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents DateTimeInput1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DiasSaldo As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DiasRango As DevComponents.Editors.IntegerInput
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdvacacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents fechaI As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents fechaF As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents MotivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotaDataGridViewTextBoxColumn As DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
End Class
