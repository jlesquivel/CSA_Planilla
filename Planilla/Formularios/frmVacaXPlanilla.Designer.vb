<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVacaXPlanilla
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.SwitchButton1 = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.bt_carta = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Periodo = New DevComponents.Editors.IntegerInput()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.DiasRangoAdic = New DevComponents.Editors.IntegerInput()
        Me.fechaI_Adic = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.fechaF_Adic = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.DiasRango = New DevComponents.Editors.IntegerInput()
        Me.bt_crear = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.motivo = New DevComponents.DotNetBar.Controls.TextBoxDropDown()
        Me.nota = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.fechaF_ord = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.fechaI_ord = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.ListBoxAdv1 = New DevComponents.DotNetBar.ListBoxAdv()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.derecho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disfrutado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hilo = New System.ComponentModel.BackgroundWorker()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.FechaCarta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.UcProgresoCircular1 = New Planilla.ucProgresoCircular()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContratosActivosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsVacaciones = New Planilla.dsVacaciones()
        Me.ContratosActivosTableAdapter = New Planilla.dsVacacionesTableAdapters.ContratosActivosTableAdapter()
        Me.TableAdapterManager = New Planilla.dsVacacionesTableAdapters.TableAdapterManager()
        Me.PanelEx1.SuspendLayout()
        CType(Me.Periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiasRangoAdic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fechaI_Adic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fechaF_Adic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiasRango, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fechaF_ord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fechaI_ord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaCarta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratosActivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.FechaCarta)
        Me.PanelEx1.Controls.Add(Me.LabelX7)
        Me.PanelEx1.Controls.Add(Me.SwitchButton1)
        Me.PanelEx1.Controls.Add(Me.bt_carta)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.Periodo)
        Me.PanelEx1.Controls.Add(Me.UcProgresoCircular1)
        Me.PanelEx1.Controls.Add(Me.LabelX9)
        Me.PanelEx1.Controls.Add(Me.LabelX8)
        Me.PanelEx1.Controls.Add(Me.DiasRangoAdic)
        Me.PanelEx1.Controls.Add(Me.fechaI_Adic)
        Me.PanelEx1.Controls.Add(Me.fechaF_Adic)
        Me.PanelEx1.Controls.Add(Me.LabelX6)
        Me.PanelEx1.Controls.Add(Me.DiasRango)
        Me.PanelEx1.Controls.Add(Me.bt_crear)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.motivo)
        Me.PanelEx1.Controls.Add(Me.nota)
        Me.PanelEx1.Controls.Add(Me.fechaF_ord)
        Me.PanelEx1.Controls.Add(Me.fechaI_ord)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(194, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(691, 215)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 7
        '
        'SwitchButton1
        '
        '
        '
        '
        Me.SwitchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton1.Location = New System.Drawing.Point(424, 94)
        Me.SwitchButton1.Name = "SwitchButton1"
        Me.SwitchButton1.OffText = "SIN"
        Me.SwitchButton1.OnText = "CON"
        Me.SwitchButton1.Size = New System.Drawing.Size(66, 22)
        Me.SwitchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton1.TabIndex = 22
        Me.SwitchButton1.Value = True
        Me.SwitchButton1.ValueObject = "Y"
        '
        'bt_carta
        '
        Me.bt_carta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.bt_carta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.bt_carta.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bt_carta.Location = New System.Drawing.Point(508, 120)
        Me.bt_carta.Name = "bt_carta"
        Me.bt_carta.Size = New System.Drawing.Size(58, 81)
        Me.bt_carta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.bt_carta.Symbol = ""
        Me.bt_carta.SymbolColor = System.Drawing.Color.Green
        Me.bt_carta.SymbolSize = 32.0!
        Me.bt_carta.TabIndex = 21
        Me.bt_carta.Text = "Generar Cartas"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(255, 21)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(43, 20)
        Me.LabelX5.TabIndex = 20
        Me.LabelX5.Text = "Periodo"
        '
        'Periodo
        '
        '
        '
        '
        Me.Periodo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Periodo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Periodo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Periodo.Location = New System.Drawing.Point(302, 20)
        Me.Periodo.Name = "Periodo"
        Me.Periodo.ShowUpDown = True
        Me.Periodo.Size = New System.Drawing.Size(72, 22)
        Me.Periodo.TabIndex = 19
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX9.Location = New System.Drawing.Point(7, 66)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX9.Size = New System.Drawing.Size(119, 21)
        Me.LabelX9.TabIndex = 17
        Me.LabelX9.Text = "Vacaciones Ordinarias"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX8.Location = New System.Drawing.Point(7, 93)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelX8.Size = New System.Drawing.Size(119, 21)
        Me.LabelX8.TabIndex = 16
        Me.LabelX8.Text = "Vacaciones Adicionales"
        '
        'DiasRangoAdic
        '
        '
        '
        '
        Me.DiasRangoAdic.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DiasRangoAdic.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DiasRangoAdic.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DiasRangoAdic.Location = New System.Drawing.Point(380, 93)
        Me.DiasRangoAdic.Name = "DiasRangoAdic"
        Me.DiasRangoAdic.Size = New System.Drawing.Size(32, 22)
        Me.DiasRangoAdic.TabIndex = 15
        '
        'fechaI_Adic
        '
        '
        '
        '
        Me.fechaI_Adic.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fechaI_Adic.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_Adic.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.fechaI_Adic.ButtonDropDown.Visible = True
        Me.fechaI_Adic.IsPopupCalendarOpen = False
        Me.fechaI_Adic.Location = New System.Drawing.Point(132, 93)
        '
        '
        '
        '
        '
        '
        Me.fechaI_Adic.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_Adic.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.fechaI_Adic.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fechaI_Adic.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_Adic.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        Me.fechaI_Adic.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.fechaI_Adic.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fechaI_Adic.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaI_Adic.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fechaI_Adic.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_Adic.MonthCalendar.TodayButtonVisible = True
        Me.fechaI_Adic.Name = "fechaI_Adic"
        Me.fechaI_Adic.Size = New System.Drawing.Size(118, 22)
        Me.fechaI_Adic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fechaI_Adic.TabIndex = 14
        '
        'fechaF_Adic
        '
        '
        '
        '
        Me.fechaF_Adic.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fechaF_Adic.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_Adic.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.fechaF_Adic.ButtonDropDown.Visible = True
        Me.fechaF_Adic.IsPopupCalendarOpen = False
        Me.fechaF_Adic.Location = New System.Drawing.Point(256, 94)
        '
        '
        '
        '
        '
        '
        Me.fechaF_Adic.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_Adic.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.fechaF_Adic.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fechaF_Adic.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_Adic.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        Me.fechaF_Adic.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.fechaF_Adic.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fechaF_Adic.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaF_Adic.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fechaF_Adic.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_Adic.MonthCalendar.TodayButtonVisible = True
        Me.fechaF_Adic.Name = "fechaF_Adic"
        Me.fechaF_Adic.Size = New System.Drawing.Size(118, 22)
        Me.fechaF_Adic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fechaF_Adic.TabIndex = 13
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(352, 45)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(82, 20)
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
        Me.DiasRango.Location = New System.Drawing.Point(380, 66)
        Me.DiasRango.Name = "DiasRango"
        Me.DiasRango.Size = New System.Drawing.Size(32, 22)
        Me.DiasRango.TabIndex = 11
        '
        'bt_crear
        '
        Me.bt_crear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.bt_crear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.bt_crear.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bt_crear.Location = New System.Drawing.Point(424, 120)
        Me.bt_crear.Name = "bt_crear"
        Me.bt_crear.Size = New System.Drawing.Size(58, 81)
        Me.bt_crear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.bt_crear.Symbol = ""
        Me.bt_crear.SymbolColor = System.Drawing.Color.Green
        Me.bt_crear.SymbolSize = 32.0!
        Me.bt_crear.TabIndex = 8
        Me.bt_crear.Text = "Crear Vacaciones"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX4.Location = New System.Drawing.Point(46, 140)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
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
        Me.LabelX3.Location = New System.Drawing.Point(256, 48)
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
        Me.LabelX2.Location = New System.Drawing.Point(132, 48)
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
        Me.LabelX1.Location = New System.Drawing.Point(46, 20)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
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
        Me.motivo.Location = New System.Drawing.Point(132, 20)
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
        Me.nota.Location = New System.Drawing.Point(132, 140)
        Me.nota.Multiline = True
        Me.nota.Name = "nota"
        Me.nota.PreventEnterBeep = True
        Me.nota.Size = New System.Drawing.Size(286, 61)
        Me.nota.TabIndex = 2
        '
        'fechaF_ord
        '
        '
        '
        '
        Me.fechaF_ord.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fechaF_ord.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_ord.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.fechaF_ord.ButtonDropDown.Visible = True
        Me.fechaF_ord.IsPopupCalendarOpen = False
        Me.fechaF_ord.Location = New System.Drawing.Point(256, 66)
        '
        '
        '
        '
        '
        '
        Me.fechaF_ord.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_ord.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.fechaF_ord.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fechaF_ord.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_ord.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        Me.fechaF_ord.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.fechaF_ord.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fechaF_ord.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaF_ord.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fechaF_ord.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaF_ord.MonthCalendar.TodayButtonVisible = True
        Me.fechaF_ord.Name = "fechaF_ord"
        Me.fechaF_ord.Size = New System.Drawing.Size(118, 22)
        Me.fechaF_ord.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fechaF_ord.TabIndex = 1
        '
        'fechaI_ord
        '
        '
        '
        '
        Me.fechaI_ord.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fechaI_ord.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_ord.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.fechaI_ord.ButtonDropDown.Visible = True
        Me.fechaI_ord.IsPopupCalendarOpen = False
        Me.fechaI_ord.Location = New System.Drawing.Point(132, 65)
        '
        '
        '
        '
        '
        '
        Me.fechaI_ord.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_ord.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.fechaI_ord.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fechaI_ord.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_ord.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        Me.fechaI_ord.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.fechaI_ord.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fechaI_ord.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaI_ord.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fechaI_ord.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaI_ord.MonthCalendar.TodayButtonVisible = True
        Me.fechaI_ord.Name = "fechaI_ord"
        Me.fechaI_ord.Size = New System.Drawing.Size(118, 22)
        Me.fechaI_ord.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fechaI_ord.TabIndex = 0
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.ListBoxAdv1)
        Me.PanelEx2.Controls.Add(Me.ReflectionLabel1)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(194, 517)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 8
        Me.PanelEx2.Text = "PanelEx2"
        '
        'ListBoxAdv1
        '
        Me.ListBoxAdv1.AutoScroll = True
        '
        '
        '
        Me.ListBoxAdv1.BackgroundStyle.Class = "ListBoxAdv"
        Me.ListBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ListBoxAdv1.ContainerControlProcessDialogKey = True
        Me.ListBoxAdv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxAdv1.DragDropSupport = True
        Me.ListBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxAdv1.Location = New System.Drawing.Point(0, 47)
        Me.ListBoxAdv1.Name = "ListBoxAdv1"
        Me.ListBoxAdv1.Size = New System.Drawing.Size(194, 470)
        Me.ListBoxAdv1.TabIndex = 0
        Me.ListBoxAdv1.Text = "ListBoxAdv1"
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ReflectionLabel1.Location = New System.Drawing.Point(0, 0)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(194, 47)
        Me.ReflectionLabel1.TabIndex = 1
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><i>.</i><font color=""#B02B2C"">Planillas</font></font></b>"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.AllowUserToOrderColumns = True
        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CedulaDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.derecho, Me.disfrutado, Me.saldo})
        Me.DataGridViewX1.DataSource = Me.ContratosActivosBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(194, 215)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.Size = New System.Drawing.Size(691, 302)
        Me.DataGridViewX1.TabIndex = 12
        '
        'derecho
        '
        Me.derecho.DataPropertyName = "derecho"
        Me.derecho.HeaderText = "derecho"
        Me.derecho.Name = "derecho"
        Me.derecho.ReadOnly = True
        Me.derecho.Width = 60
        '
        'disfrutado
        '
        Me.disfrutado.DataPropertyName = "disfrutado"
        Me.disfrutado.HeaderText = "disfrutado"
        Me.disfrutado.Name = "disfrutado"
        Me.disfrutado.ReadOnly = True
        Me.disfrutado.Width = 60
        '
        'saldo
        '
        Me.saldo.DataPropertyName = "saldo"
        Me.saldo.HeaderText = "saldo"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Width = 60
        '
        'hilo
        '
        Me.hilo.WorkerReportsProgress = True
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(394, 20)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(78, 20)
        Me.LabelX7.TabIndex = 24
        Me.LabelX7.Text = "Fecha Carta"
        '
        'FechaCarta
        '
        '
        '
        '
        Me.FechaCarta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.FechaCarta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FechaCarta.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.FechaCarta.ButtonDropDown.Visible = True
        Me.FechaCarta.IsPopupCalendarOpen = False
        Me.FechaCarta.Location = New System.Drawing.Point(461, 20)
        '
        '
        '
        '
        '
        '
        Me.FechaCarta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FechaCarta.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.FechaCarta.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.FechaCarta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.FechaCarta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.FechaCarta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.FechaCarta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.FechaCarta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.FechaCarta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.FechaCarta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FechaCarta.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        Me.FechaCarta.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.FechaCarta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.FechaCarta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.FechaCarta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.FechaCarta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FechaCarta.MonthCalendar.TodayButtonVisible = True
        Me.FechaCarta.Name = "FechaCarta"
        Me.FechaCarta.Size = New System.Drawing.Size(118, 22)
        Me.FechaCarta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.FechaCarta.TabIndex = 25
        '
        'UcProgresoCircular1
        '
        Me.UcProgresoCircular1.Location = New System.Drawing.Point(470, 12)
        Me.UcProgresoCircular1.Name = "UcProgresoCircular1"
        Me.UcProgresoCircular1.Size = New System.Drawing.Size(96, 96)
        Me.UcProgresoCircular1.TabIndex = 18
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidosDataGridViewTextBoxColumn.Width = 150
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'ContratosActivosBindingSource
        '
        Me.ContratosActivosBindingSource.DataMember = "ContratosActivos"
        Me.ContratosActivosBindingSource.DataSource = Me.DsVacaciones
        '
        'DsVacaciones
        '
        Me.DsVacaciones.DataSetName = "dsVacaciones"
        Me.DsVacaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContratosActivosTableAdapter
        '
        Me.ContratosActivosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Planilla.dsVacacionesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Vacacion_regTableAdapter = Nothing
        Me.TableAdapterManager.VacacionesTableAdapter = Nothing
        '
        'frmVacaXPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 517)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.PanelEx2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmVacaXPlanilla"
        Me.Text = "Vacaciones por Planilla"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.Periodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiasRangoAdic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fechaI_Adic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fechaF_Adic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiasRango, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fechaF_ord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fechaI_ord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaCarta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratosActivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents UcProgresoCircular1 As ucProgresoCircular
    Friend WithEvents DsVacaciones As dsVacaciones
    Friend WithEvents ContratosActivosBindingSource As BindingSource
    Friend WithEvents ContratosActivosTableAdapter As dsVacacionesTableAdapters.ContratosActivosTableAdapter
    Friend WithEvents TableAdapterManager As dsVacacionesTableAdapters.TableAdapterManager
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents derecho As DataGridViewTextBoxColumn
    Friend WithEvents disfrutado As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewTextBoxColumn
    Private WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Private WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Private WithEvents DiasRangoAdic As DevComponents.Editors.IntegerInput
    Private WithEvents fechaI_Adic As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents fechaF_Adic As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents DiasRango As DevComponents.Editors.IntegerInput
    Private WithEvents bt_crear As DevComponents.DotNetBar.ButtonX
    Private WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents motivo As DevComponents.DotNetBar.Controls.TextBoxDropDown
    Private WithEvents nota As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents fechaF_ord As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents fechaI_ord As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Private WithEvents ListBoxAdv1 As DevComponents.DotNetBar.ListBoxAdv
    Private WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Private WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents Periodo As DevComponents.Editors.IntegerInput
    Private WithEvents bt_carta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents hilo As System.ComponentModel.BackgroundWorker
    Friend WithEvents SwitchButton1 As DevComponents.DotNetBar.Controls.SwitchButton
    Private WithEvents FechaCarta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
End Class
