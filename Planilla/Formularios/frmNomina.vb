﻿Imports System.Threading
Imports System.Threading.Tasks
Imports AutoUpdaterDotNET

'OK permitir cedula de extranjeros DIMEX  16.000
'OK auto actualizar  
'OK reportes para CoopeAnde : Ahorro, prestamo, y 1.5   32.000 X 3  = 96 000
'OK Falta parametrizar envio de correo , seleccionar correo a enviar 48.000
'OK LLenar archivo de Coopeande con el dato CAPITAL ; seleccionar archivo y llenar

'||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

'TODO llenar archivo planilla para INS 
'TODO Aguinaldo las Incapacidades por maternidad no se deben aplicar
'TODO a cada pago , agregar informacion, categoria, salario-base, cantidad , recargo ,anualidad,anualidad-reconocida


Public Class frmNomina
    Inherits DevComponents.DotNetBar.Office2007RibbonForm

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsPlanilla1 As Planilla.dsPlanilla
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents old_ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents old_MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents old_MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents old_MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Private WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Private WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Private WithEvents RibbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    Private WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Private WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Private WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Private WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Private WithEvents Bar2 As DevComponents.DotNetBar.Bar
    Private WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents TreeViewSQL1 As Planilla.TreeViewSQL
    Private WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Private WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Private WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Private WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Private WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Private WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Private WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Private WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Sqltree2 As System.Data.SqlClient.SqlCommand
    Private WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Private WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Private WithEvents ComboBoxItem1 As DevComponents.DotNetBar.ComboBoxItem
    Private WithEvents RibbonBar3 As DevComponents.DotNetBar.RibbonBar
    Private WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Private WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Private WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem

    Private WithEvents CoopeAnde As DevComponents.DotNetBar.ButtonItem

    Private WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bMarcas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem11 As DevComponents.DotNetBar.ButtonItem
    Private WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNomina))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Planillas", 1, 1)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.old_ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.old_MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.old_MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.old_MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.DsPlanilla1 = New Planilla.dsPlanilla()
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar3 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.CoopeAnde = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.bMarcas = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ComboBoxItem1 = New DevComponents.DotNetBar.ComboBoxItem()
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.Bar2 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TreeViewSQL1 = New Planilla.TreeViewSQL()
        Me.Sqltree2 = New System.Data.SqlClient.SqlCommand()
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonControl1.SuspendLayout()
        Me.RibbonPanel1.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite1.SuspendLayout()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar2.SuspendLayout()
        Me.PanelDockContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "flechaRoja.ico")
        Me.ImageList1.Images.SetKeyName(1, "Document New.png")
        Me.ImageList1.Images.SetKeyName(2, "Group.png")
        Me.ImageList1.Images.SetKeyName(3, "User 3.png")
        Me.ImageList1.Images.SetKeyName(4, "User.png")
        '
        'old_ContextMenu1
        '
        Me.old_ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.old_MenuItem1, Me.old_MenuItem2, Me.old_MenuItem3, Me.MenuItem2, Me.MenuItem1})
        '
        'old_MenuItem1
        '
        Me.old_MenuItem1.Index = 0
        Me.old_MenuItem1.Text = "Insertar"
        '
        'old_MenuItem2
        '
        Me.old_MenuItem2.Index = 1
        Me.old_MenuItem2.OwnerDraw = True
        Me.old_MenuItem2.Text = "Modificar"
        '
        'old_MenuItem3
        '
        Me.old_MenuItem3.Index = 2
        Me.old_MenuItem3.Text = "Borrar"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Enabled = False
        Me.MenuItem1.Index = 4
        Me.MenuItem1.Text = "Genera Planilla"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=servidor-bd;Initial Catalog=planilla;Persist Security Info=True;User " &
    "ID=sa;Password=123"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "Documents.png")
        Me.ImageList2.Images.SetKeyName(2, "Group.png")
        Me.ImageList2.Images.SetKeyName(3, "User 3.png")
        Me.ImageList2.Images.SetKeyName(4, "User.png")
        '
        'DsPlanilla1
        '
        Me.DsPlanilla1.DataSetName = "dsPlanilla"
        Me.DsPlanilla1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsPlanilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RibbonControl1
        '
        Me.RibbonControl1.BackColor = System.Drawing.SystemColors.ControlLight
        '
        '
        '
        Me.RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl1.CanCustomize = False
        Me.RibbonControl1.CaptionVisible = True
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel1)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl1.ForeColor = System.Drawing.Color.Black
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.RibbonTabItem1})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(5, 1)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1118, 172)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.RibbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.RibbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.RibbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.RibbonControl1.SystemText.QatDialogAddButton = "&Add >>"
        Me.RibbonControl1.SystemText.QatDialogCancelButton = "Cancel"
        Me.RibbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.RibbonControl1.SystemText.QatDialogOkButton = "OK"
        Me.RibbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.RibbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.RibbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 15
        Me.RibbonControl1.Text = " "
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar3)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar2)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar1)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 55)
        Me.RibbonPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(2, 0, 2, 2)
        Me.RibbonPanel1.Size = New System.Drawing.Size(1118, 117)
        '
        '
        '
        Me.RibbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel1.TabIndex = 1
        '
        'RibbonBar3
        '
        Me.RibbonBar3.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar3.ContainerControlProcessDialogKey = True
        Me.RibbonBar3.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar3.DragDropSupport = True
        Me.RibbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem7, Me.ButtonItem6, Me.ButtonItem8, Me.CoopeAnde, Me.ButtonItem11, Me.ButtonItem2, Me.ButtonItem9, Me.bMarcas})
        Me.RibbonBar3.Location = New System.Drawing.Point(535, 0)
        Me.RibbonBar3.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonBar3.Name = "RibbonBar3"
        Me.RibbonBar3.Size = New System.Drawing.Size(588, 115)
        Me.RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar3.TabIndex = 2
        Me.RibbonBar3.Text = "Ajustes"
        '
        '
        '
        Me.RibbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem7
        '
        Me.ButtonItem7.Image = CType(resources.GetObject("ButtonItem7.Image"), System.Drawing.Image)
        Me.ButtonItem7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.Text = "<div align = ""center""> Ausencias </div>"
        '
        'ButtonItem6
        '
        Me.ButtonItem6.Image = CType(resources.GetObject("ButtonItem6.Image"), System.Drawing.Image)
        Me.ButtonItem6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.Text = "<div align = ""center""> Incapacidades    </div>"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.Image = CType(resources.GetObject("ButtonItem8.Image"), System.Drawing.Image)
        Me.ButtonItem8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "Colegiaturas"
        '
        'CoopeAnde
        '
        Me.CoopeAnde.Image = Global.Planilla.My.Resources.Resources.coopeande32
        Me.CoopeAnde.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.CoopeAnde.Name = "CoopeAnde"
        Me.CoopeAnde.NotificationMarkColor = System.Drawing.Color.Red
        Me.CoopeAnde.SubItemsExpandWidth = 14
        Me.CoopeAnde.Text = "CoopAnde <br/> Archivo"
        '
        'ButtonItem11
        '
        Me.ButtonItem11.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem11.Name = "ButtonItem11"
        Me.ButtonItem11.SubItemsExpandWidth = 14
        Me.ButtonItem11.Symbol = "57686"
        Me.ButtonItem11.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonItem11.SymbolSize = 32.0!
        Me.ButtonItem11.Text = "SSVM Archivo"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItemsExpandWidth = 14
        Me.ButtonItem2.Symbol = "57935"
        Me.ButtonItem2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonItem2.SymbolSize = 32.0!
        Me.ButtonItem2.Text = "Vacaciones"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.SubItemsExpandWidth = 14
        Me.ButtonItem9.Symbol = ""
        Me.ButtonItem9.SymbolSize = 32.0!
        Me.ButtonItem9.Text = "Horas Extras"
        '
        'bMarcas
        '
        Me.bMarcas.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bMarcas.Name = "bMarcas"
        Me.bMarcas.SubItemsExpandWidth = 14
        Me.bMarcas.Symbol = ""
        Me.bMarcas.SymbolSize = 32.0!
        Me.bMarcas.Text = "Marcas"
        '
        'RibbonBar2
        '
        Me.RibbonBar2.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar2.ContainerControlProcessDialogKey = True
        Me.RibbonBar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar2.DragDropSupport = True
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.RibbonBar2.Location = New System.Drawing.Point(323, 0)
        Me.RibbonBar2.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(212, 115)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar2.TabIndex = 1
        Me.RibbonBar2.Text = "Planillas"
        '
        '
        '
        Me.RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ComboBoxItem1})
        '
        '
        '
        Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ComboBoxItem1
        '
        Me.ComboBoxItem1.ComboWidth = 128
        Me.ComboBoxItem1.DropDownHeight = 106
        Me.ComboBoxItem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.ComboBoxItem1.ItemHeight = 14
        Me.ComboBoxItem1.Name = "ComboBoxItem1"
        Me.ComboBoxItem1.Text = "Seleccione Planilla"
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar1.ContainerControlProcessDialogKey = True
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar1.DragDropSupport = True
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem3, Me.ButtonItem4, Me.ButtonItem5, Me.ButtonItem10})
        Me.RibbonBar1.Location = New System.Drawing.Point(2, 0)
        Me.RibbonBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(321, 115)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar1.TabIndex = 1
        Me.RibbonBar1.Text = "Empleados"
        '
        '
        '
        Me.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Image = CType(resources.GetObject("ButtonItem3.Image"), System.Drawing.Image)
        Me.ButtonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "Empleados"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.Image = CType(resources.GetObject("ButtonItem4.Image"), System.Drawing.Image)
        Me.ButtonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Text = "Categorias"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.Image = CType(resources.GetObject("ButtonItem5.Image"), System.Drawing.Image)
        Me.ButtonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "Perfiles y Rubros"
        '
        'ButtonItem10
        '
        Me.ButtonItem10.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem10.Name = "ButtonItem10"
        Me.ButtonItem10.SubItemsExpandWidth = 14
        Me.ButtonItem10.Symbol = ""
        Me.ButtonItem10.SymbolSize = 32.0!
        Me.ButtonItem10.Text = "Liquidación"
        '
        'RibbonTabItem1
        '
        Me.RibbonTabItem1.Checked = True
        Me.RibbonTabItem1.Name = "RibbonTabItem1"
        Me.RibbonTabItem1.Panel = Me.RibbonPanel1
        Me.RibbonTabItem1.Text = "Empleados"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Image = CType(resources.GetObject("ButtonItem1.Image"), System.Drawing.Image)
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Configuracion"
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1})
        Me.Bar1.Location = New System.Drawing.Point(5, 514)
        Me.Bar1.Margin = New System.Windows.Forms.Padding(2)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(1118, 23)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Bar1.TabIndex = 17
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "LabelItem1"
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins)
        Me.DotNetBarManager1.BottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.EnableFullSizeDock = False
        Me.DotNetBarManager1.LeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.ParentForm = Me
        Me.DotNetBarManager1.RightDockSite = Me.DockSite2
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite8
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite5
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite6
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite7
        Me.DotNetBarManager1.TopDockSite = Me.DockSite3
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite4.Location = New System.Drawing.Point(5, 514)
        Me.DockSite4.Margin = New System.Windows.Forms.Padding(2)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(1118, 0)
        Me.DockSite4.TabIndex = 22
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Controls.Add(Me.Bar2)
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar2, 365, 341), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Horizontal)
        Me.DockSite1.Location = New System.Drawing.Point(5, 173)
        Me.DockSite1.Margin = New System.Windows.Forms.Padding(2)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(368, 341)
        Me.DockSite1.TabIndex = 19
        Me.DockSite1.TabStop = False
        '
        'Bar2
        '
        Me.Bar2.AccessibleDescription = "DotNetBar Bar (Bar2)"
        Me.Bar2.AccessibleName = "DotNetBar Bar"
        Me.Bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.Bar2.AutoHideAnimationTime = 400
        Me.Bar2.AutoSyncBarCaption = True
        Me.Bar2.Controls.Add(Me.PanelDockContainer1)
        Me.Bar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption
        Me.Bar2.IsMaximized = False
        Me.Bar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem1})
        Me.Bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar2.Location = New System.Drawing.Point(0, 0)
        Me.Bar2.Margin = New System.Windows.Forms.Padding(2)
        Me.Bar2.Name = "Bar2"
        Me.Bar2.Size = New System.Drawing.Size(365, 341)
        Me.Bar2.Stretch = True
        Me.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar2.TabIndex = 0
        Me.Bar2.TabStop = False
        Me.Bar2.Text = "Planillas"
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer1.Controls.Add(Me.ExpandableSplitter1)
        Me.PanelDockContainer1.Controls.Add(Me.ListView1)
        Me.PanelDockContainer1.Controls.Add(Me.TreeViewSQL1)
        Me.PanelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 23)
        Me.PanelDockContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(359, 315)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 0
        '
        'ExpandableSplitter1
        '
        Me.ExpandableSplitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.ExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.ForeColor = System.Drawing.Color.Black
        Me.ExpandableSplitter1.GripDarkColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ExpandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.ExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.HotExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableSplitter1.Location = New System.Drawing.Point(166, 0)
        Me.ExpandableSplitter1.Margin = New System.Windows.Forms.Padding(2)
        Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(2, 315)
        Me.ExpandableSplitter1.TabIndex = 18
        Me.ExpandableSplitter1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.LargeImageList = Me.ImageList2
        Me.ListView1.Location = New System.Drawing.Point(166, 0)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(193, 315)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 15
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'TreeViewSQL1
        '
        Me.TreeViewSQL1.ContextMenu = Me.old_ContextMenu1
        Me.TreeViewSQL1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeViewSQL1.Etiquetas = "Planillas,,,"
        Me.TreeViewSQL1.ImageIndex = 1
        Me.TreeViewSQL1.ImageList = Me.ImageList1
        Me.TreeViewSQL1.InstruccionSQL = Me.Sqltree2
        Me.TreeViewSQL1.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewSQL1.Margin = New System.Windows.Forms.Padding(2)
        Me.TreeViewSQL1.Name = "TreeViewSQL1"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = ""
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "Planillas"
        Me.TreeViewSQL1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TreeViewSQL1.SelectedImageIndex = 0
        Me.TreeViewSQL1.Size = New System.Drawing.Size(166, 315)
        Me.TreeViewSQL1.TabIndex = 14
        '
        'Sqltree2
        '
        Me.Sqltree2.CommandText = "SELECT        Depto, Puesto, empleado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            v_TreeViewEmpleados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER" &
    " BY Depto, Puesto, empleado"
        Me.Sqltree2.Connection = Me.SqlConnection1
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Control = Me.PanelDockContainer1
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.Text = "Planillas"
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(1123, 173)
        Me.DockSite2.Margin = New System.Windows.Forms.Padding(2)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 341)
        Me.DockSite2.TabIndex = 20
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(5, 514)
        Me.DockSite8.Margin = New System.Windows.Forms.Padding(2)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(1118, 0)
        Me.DockSite8.TabIndex = 26
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(5, 173)
        Me.DockSite5.Margin = New System.Windows.Forms.Padding(2)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 341)
        Me.DockSite5.TabIndex = 23
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(1123, 173)
        Me.DockSite6.Margin = New System.Windows.Forms.Padding(2)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 341)
        Me.DockSite6.TabIndex = 24
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(5, 173)
        Me.DockSite7.Margin = New System.Windows.Forms.Padding(2)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(1118, 0)
        Me.DockSite7.TabIndex = 25
        Me.DockSite7.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(5, 173)
        Me.DockSite3.Margin = New System.Windows.Forms.Padding(2)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(1118, 0)
        Me.DockSite3.TabIndex = 21
        Me.DockSite3.TabStop = False
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(71, Byte), Integer)))
        '
        'frmNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1128, 539)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.Bar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmNomina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nomina"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonControl1.ResumeLayout(False)
        Me.RibbonControl1.PerformLayout()
        Me.RibbonPanel1.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite1.ResumeLayout(False)
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar2.ResumeLayout(False)
        Me.PanelDockContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim niveles As String()
    Dim llave As String
    Private mHiloArch As Thread
    Dim vnt As New Ventanas

    Dim dptos As New ArrayList
    Dim i As Integer


    Private Sub AutoUpdaterRevisarEvent(args As UpdateInfoEventArgs)
        If args IsNot Nothing Then

            If (args.IsUpdateAvailable) Then
                Dim dialogResult = MessageBox.Show(String.Format(
               "Existe una nueva versión {0} desea actualizarla ?",
               args.CurrentVersion), "Actualización Disponible",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If (dialogResult.Equals(dialogResult.Yes)) Then
                    Try
                        AutoUpdater.DownloadUpdate()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        Else
            'MessageBox.Show(
            '   "Problemas con la conexión internet. intente más tarde.",
            '   "Error servidor ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub frmNomina_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub frmNomina_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Dim conn As conexionSQL = New conexionSQL

        TreeViewSQL1.llenar("planilla")
        vnt.cambia_fondoMDI(Me)

        Me.SqlConnection1.ConnectionString = conn.strConn
        dptos = conn.llena("select nombre,id_dpto from departamento")
        If dptos.Count > 0 Then

            For i = 0 To dptos.Count - 1
                Me.ComboBoxItem1.Items.Add(dptos(i)(0))
            Next
            'Me.ComboBoxItem1.SelectedIndex = 0
        End If

        LabelItem1.Text = conn.servidor

    End Sub

    Private Sub frmNomina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

#If DEBUG Then

#Else
                Try
                    Dim myUri As New Uri(My.Settings.ServActualizacion)
                    Dim host As String = myUri.Host

                    If My.Computer.Network.Ping(host, 1000) Then
                        AddHandler AutoUpdater.CheckForUpdateEvent, AddressOf AutoUpdaterRevisarEvent
                        AutoUpdater.Start(My.Settings.ServActualizacion)
                    Else
                        MsgBox("Comunicacion muy lenta con el servidor", MsgBoxStyle.Exclamation, "Advertencia")
                        Application.Exit()
                    End If
                    Me.Tag = "Colegio Santa Ana"
                Catch ex As Exception
                    MsgBox("Sin comunicación con la Base de Datos", MsgBoxStyle.Critical, "ERROR")
                    Application.Exit()
                End Try
#End If


    End Sub


    Private Sub frmNomina_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Dim coope As New cCoopeAnde
        If Not coope.ExistenDatosMes Then
            CoopeAnde.NotificationMarkText = " "
        Else
            CoopeAnde.NotificationMarkText = ""
        End If
    End Sub

    Private Sub llenar_list(ByRef pnodo As TreeNode)
        Dim nodo As TreeNode
        Me.ListView1.Clear()
        For Each nodo In pnodo.Nodes
            Dim nuevo As New ListViewItem
            nuevo.Text = nodo.Text
            nuevo.ImageIndex = nodo.ImageIndex
            nuevo.Tag = nodo.Tag
            Me.ListView1.Items.Add(nuevo)
        Next
    End Sub
    Private Sub TreeViewSQL1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewSQL1.AfterSelect
        niveles = Me.TreeViewSQL1.ruta(e.Node.FullPath)
        llenar_list(e.Node)
        If niveles.Length = 4 Then
            llave = e.Node.Tag(0)
            'Dim pto As Integer = BID_pto(BID_dpto(niveles(1)), niveles(2))
            'cargarVentana(New frmEmpleado(pto, llave, False))
        End If
    End Sub
    ' on right click 
    Private Sub TreeViewSQL1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeViewSQL1.MouseDown
        Dim nodo As TreeNode = TreeViewSQL1.GetNodeAt(e.X, e.Y)
        TreeViewSQL1.SelectedNode = nodo
        If nodo Is Nothing Then
            Array.Clear(niveles, 0, niveles.Length)
        Else
            niveles = Me.TreeViewSQL1.ruta(nodo.FullPath)
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles old_MenuItem1.Click
        Select Case niveles.Length
            Case 1 ' inserta departamento
                vnt.cargarVentana(New frmDepartamento, Me)
            Case 2
                Dim dpto As Integer = BID_dpto(niveles(1))
                vnt.cargarVentana(New frmPuesto(dpto), Me)
            Case 3  ' contrata empleado
                Dim pto As Integer = BID_pto(BID_dpto(niveles(1)), niveles(2))
                vnt.cargarVentana(New frmContrato(pto, llave, False), Me)
                'vnt.cargarVentana(New frmContrataEmpleado(pto), Me) '(pto, "", False))
            Case Else
        End Select

    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles old_MenuItem2.Click
        Select Case niveles.Length - 1
            Case 1 ' actualiza departamento
                vnt.cargarVentana(New frmDepartamento(niveles(niveles.Length - 1), False), Me)
            Case 2
                vnt.cargarVentana(New frmPuesto(niveles(niveles.Length - 1), False), Me)
            Case 3
                Dim pto As Integer = BID_pto(BID_dpto(niveles(1)), niveles(2))
                vnt.cargarVentana(New frmContrato(pto, llave, False), Me)
            Case Else
        End Select
    End Sub
    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles old_MenuItem3.Click
        Select Case niveles.Length - 1
            Case 1 ' borra departamento
                vnt.cargarVentana(New frmDepartamento(niveles(niveles.Length - 1), True), Me)
            Case 2
                Dim puesto As frmPuesto = New frmPuesto(niveles(niveles.Length - 1), True)
                puesto.borrap()
                puesto.Close()
                puesto = Nothing
            Case 3
                Dim pto As Integer = BID_pto(BID_dpto(niveles(1)), niveles(2))
                vnt.cargarVentana(New frmContrato(pto, llave, True), Me)
            Case Else
        End Select
        Me.TreeViewSQL1.llenarP("planilla")
    End Sub

    Private Sub TreeViewSQL1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeViewSQL1.GotFocus
        Me.ListView1.Visible = True
        ' Me.TreeViewSQL1.llenar("planilla")
    End Sub

    Private Function BID_dpto(ByVal nombre As String) As Integer
        Dim conn As New conexionSQL
        conn.bd = "planilla"
        Dim ds As New DataSet
        ds.Tables.Add(New DataTable("una"))
        Dim instruccion As String = "Select * from departamento where nombre='" & nombre & "'"
        conn.llena(ds, "una", instruccion)
        If ds.Tables("una").Rows.Count > 0 Then
            Return ds.Tables("una").Rows(0).Item("id_dpto")
        Else
            Return 0
        End If
    End Function

    Private Function BID_pto(ByVal depto As String, ByVal nombre As String) As Integer
        Dim conn As New conexionSQL
        conn.bd = "planilla"
        Dim ds As New DataSet
        ds.Tables.Add(New DataTable("una"))
        Dim SQLinst As String = "Select * from puestos where nombre='" & nombre & "' and id_dpto =" & depto
        conn.llena(ds, "una", SQLinst)
        If ds.Tables("una").Rows.Count > 0 Then
            Return ds.Tables("una").Rows(0).Item("id_puesto")
        Else
            Return 0
        End If
    End Function
    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim item As String = ListView1.SelectedItems(0).Text
            'Dim llavel As String = ListView1.SelectedItems(0).Tag(0)
            Select Case niveles.Length
                Case 1 ' actualiza departamento
                    vnt.cargarVentana(New frmDepartamento(item, False), Me)
                Case 2
                    vnt.cargarVentana(New frmPuesto(item, False), Me)
                Case 3
                    Dim llavel As String = ListView1.SelectedItems(0).Tag(0)
                    Dim pto As Integer = BID_pto(BID_dpto(niveles(1)), niveles(2))
                    vnt.cargarVentana(New frmContrato(pto, llavel, False), Me)
                Case Else
            End Select
        End If
    End Sub

    Private Sub ButtonItem1_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        vnt.cargarVentana(New frmCategoria2, Me.ParentForm)
    End Sub

    Private Sub old_ContextMenu1_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles old_ContextMenu1.Popup
        Me.MenuItem1.Enabled = False
        Select Case niveles.Length
            Case 2 ' actualiza departamento
                Me.MenuItem1.Enabled = True
        End Select
    End Sub

    Private Sub MenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim id_departamento As Integer = BID_dpto(Me.TreeViewSQL1.SelectedNode.Text)
        vnt.cargarVentana(New frmPlanilla(id_departamento), Me)
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        vnt.cargarVentana(New frmContrato, Me)
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        vnt.cargarVentana(New frmCategoria, Me)
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        vnt.cargarVentana(New frmPerfiles2, Me)
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        vnt.cargarVentana(New frmConfiguracion, Me)
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        vnt.cargarVentana(New frmColegiatura, Me)
    End Sub

    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        vnt.cargarVentana(New frmIncapacidades, Me)
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        vnt.cargarVentana(New frmAusencias, Me)
    End Sub

    Private Sub CoopeAnde_Click(sender As Object, e As EventArgs) Handles CoopeAnde.Click
        vnt.cargarVentana(New frmCoopeAndeX, Me)
    End Sub

    Private Sub ComboBoxItem1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxItem1.SelectedIndexChanged
        Dim id_departamento As Integer = dptos(Me.ComboBoxItem1.SelectedIndex)(1)
        vnt.cargarVentana(New frmPlanilla(id_departamento), Me)
    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        vnt.cargarVentana(New frmVacaXPlanilla, Me)
    End Sub

    Private Sub ButtonItem9_Click(sender As Object, e As EventArgs) Handles ButtonItem9.Click
        vnt.cargarVentana(New frmHoraExtras, Me)
    End Sub

    Private Sub ButtonItem10_Click(sender As Object, e As EventArgs) Handles ButtonItem10.Click
        vnt.cargarVentana(New frmLiquidacion, Me)
    End Sub

    Public Sub ocultarBar2()
        Bar2.AutoHide = True
    End Sub
    Public Sub MostrarBar2()
        Bar2.AutoHide = False
    End Sub

    Private Sub bMarcas_Click(sender As Object, e As EventArgs) Handles bMarcas.Click
        vnt.cargarVentana(New frmMarcas, Me)
    End Sub

    Private Sub ButtonItem11_Click(sender As Object, e As EventArgs) Handles ButtonItem11.Click
        vnt.cargarVentana(New frmPrestamosSSVM, Me)
    End Sub
End Class
