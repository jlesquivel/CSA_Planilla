Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource

Public Class frmPlanilla
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    Dim id_dpto As Integer
    Dim id_planilla As Integer
    Dim id_pago As Integer
    Dim _deducciones As Decimal
    Dim _ingresos As Decimal
    Dim fini, ffin As Date
    Dim planilla_estado As Integer

    Dim resultado As Object
    Dim conn As New conexionSQL("planilla")
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX 'conexion con la base de datos planilla
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AgregarRubroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarRubroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SqlCommand1 As SqlClient.SqlCommand
    Friend WithEvents CoopeAnde As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem14 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Ahorro As DevComponents.DotNetBar.Command
    Friend WithEvents Prestamo As DevComponents.DotNetBar.Command
    Friend WithEvents coope As DevComponents.DotNetBar.Command
    Friend WithEvents Label12 As Label
    Friend WithEvents TextboxFormat10 As TextboxFormat
    Friend WithEvents UcProgresoCircular1 As ucProgresoCircular
    Friend WithEvents bw1 As BackgroundWorker
    Friend WithEvents ButtonItem15 As DevComponents.DotNetBar.ButtonItem
    Dim plan As New cPlanilla    ' objeto de la clase planilla para cambiar estado de la planilla

    Public Sub New(ByVal pid_dpto As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        id_dpto = pid_dpto
        Me.cargarPlanillas()

    End Sub
#Region " Código generado por el Diseñador de Windows Forms "
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents PanelDockContainer2 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DockContainerItem2 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents RibbonBarMergeContainer1 As DevComponents.DotNetBar.RibbonBarMergeContainer
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PlanillasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonBar3 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem15 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem16 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem17 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem18 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem19 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem20 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem21 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem22 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem23 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem24 As DevComponents.Editors.ComboItem
    Friend WithEvents PanelDockContainer3 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents DockContainerItem3 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents IdplanillaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechainiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechafinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents IdplanillaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechainiDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechafinDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IddptoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlanillasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Dim filas As Integer = 0



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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Ds2planilla1 As Planilla.ds2planilla
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents TextboxFormat1 As Planilla.TextboxFormat
    Friend WithEvents TextboxFormat2 As Planilla.TextboxFormat
    Friend WithEvents TextboxFormat3 As Planilla.TextboxFormat
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Planillas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PlanillaPagosDetalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataViewIngresos As System.Data.DataView
    Friend WithEvents DataViewDeducciones As System.Data.DataView
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle5 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TextboxFormat4 As Planilla.TextboxFormat
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextboxFormat5 As Planilla.TextboxFormat
    Friend WithEvents TextboxFormat6 As Planilla.TextboxFormat
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataViewPlanillas As System.Data.DataView
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DVPlanillaPagosSelect As System.Data.DataView
    Friend WithEvents PlanillaResumenMonto As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextboxFormat7 As Planilla.TextboxFormat
    Friend WithEvents TextboxFormat8 As Planilla.TextboxFormat
    Friend WithEvents TextboxFormat9 As Planilla.TextboxFormat
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid5 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanilla))
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextboxFormat10 = New Planilla.TextboxFormat()
        Me.TextboxFormat6 = New Planilla.TextboxFormat()
        Me.TextboxFormat5 = New Planilla.TextboxFormat()
        Me.TextboxFormat3 = New Planilla.TextboxFormat()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextboxFormat1 = New Planilla.TextboxFormat()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGrid3 = New System.Windows.Forms.DataGrid()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarRubroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarRubroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataViewIngresos = New System.Data.DataView()
        Me.Ds2planilla1 = New Planilla.ds2planilla()
        Me.DataGridTableStyle5 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.TextboxFormat2 = New Planilla.TextboxFormat()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGrid2 = New System.Windows.Forms.DataGrid()
        Me.DataViewDeducciones = New System.Data.DataView()
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextboxFormat4 = New Planilla.TextboxFormat()
        Me.DataView1 = New System.Data.DataView()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.DVPlanillaPagosSelect = New System.Data.DataView()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.Planillas = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.PlanillaPagosDetalle = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.PlanillaResumenMonto = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGrid5 = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdplanillaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechainiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechafinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PlanillasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextboxFormat7 = New Planilla.TextboxFormat()
        Me.TextboxFormat8 = New Planilla.TextboxFormat()
        Me.TextboxFormat9 = New Planilla.TextboxFormat()
        Me.PanelDockContainer2 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.UcProgresoCircular1 = New Planilla.ucProgresoCircular()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelDockContainer3 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdplanillaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechainiDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechafinDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IddptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanillasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockContainerItem2 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockContainerItem3 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.RibbonBarMergeContainer1 = New DevComponents.DotNetBar.RibbonBarMergeContainer()
        Me.RibbonBar3 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem12 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.Ahorro = New DevComponents.DotNetBar.Command(Me.components)
        Me.ButtonItem13 = New DevComponents.DotNetBar.ButtonItem()
        Me.Prestamo = New DevComponents.DotNetBar.Command(Me.components)
        Me.ButtonItem14 = New DevComponents.DotNetBar.ButtonItem()
        Me.coope = New DevComponents.DotNetBar.Command(Me.components)
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem15 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.CoopeAnde = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.ComboItem12 = New DevComponents.Editors.ComboItem()
        Me.ComboItem13 = New DevComponents.Editors.ComboItem()
        Me.ComboItem14 = New DevComponents.Editors.ComboItem()
        Me.ComboItem15 = New DevComponents.Editors.ComboItem()
        Me.ComboItem16 = New DevComponents.Editors.ComboItem()
        Me.ComboItem17 = New DevComponents.Editors.ComboItem()
        Me.ComboItem18 = New DevComponents.Editors.ComboItem()
        Me.ComboItem19 = New DevComponents.Editors.ComboItem()
        Me.ComboItem20 = New DevComponents.Editors.ComboItem()
        Me.ComboItem21 = New DevComponents.Editors.ComboItem()
        Me.ComboItem22 = New DevComponents.Editors.ComboItem()
        Me.ComboItem23 = New DevComponents.Editors.ComboItem()
        Me.ComboItem24 = New DevComponents.Editors.ComboItem()
        Me.DataViewPlanillas = New System.Data.DataView()
        Me.bw1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DataViewIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds2planilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataViewDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVPlanillaPagosSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite1.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        Me.PanelDockContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDockContainer2.SuspendLayout()
        Me.PanelDockContainer3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonBarMergeContainer1.SuspendLayout()
        CType(Me.DataViewPlanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = " dd MMMM  yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(11, 60)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(150, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = " dd MMMM  yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(11, 26)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(150, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(14, 288)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 209)
        Me.Panel1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TextboxFormat10)
        Me.GroupBox1.Controls.Add(Me.TextboxFormat6)
        Me.GroupBox1.Controls.Add(Me.TextboxFormat5)
        Me.GroupBox1.Controls.Add(Me.TextboxFormat3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextboxFormat1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(469, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(222, 199)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumen Empleado"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(38, 65)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 21)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Anualidad"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextboxFormat10
        '
        Me.TextboxFormat10.Formato = "C2"
        Me.TextboxFormat10.Location = New System.Drawing.Point(100, 65)
        Me.TextboxFormat10.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextboxFormat10.Name = "TextboxFormat10"
        Me.TextboxFormat10.ReadOnly = True
        Me.TextboxFormat10.Size = New System.Drawing.Size(97, 20)
        Me.TextboxFormat10.TabIndex = 12
        Me.TextboxFormat10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextboxFormat6
        '
        Me.TextboxFormat6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextboxFormat6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxFormat6.Formato = "C2"
        Me.TextboxFormat6.Location = New System.Drawing.Point(100, 169)
        Me.TextboxFormat6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextboxFormat6.Name = "TextboxFormat6"
        Me.TextboxFormat6.Size = New System.Drawing.Size(97, 21)
        Me.TextboxFormat6.TabIndex = 10
        Me.TextboxFormat6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextboxFormat5
        '
        Me.TextboxFormat5.Formato = "C2"
        Me.TextboxFormat5.Location = New System.Drawing.Point(100, 146)
        Me.TextboxFormat5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextboxFormat5.Name = "TextboxFormat5"
        Me.TextboxFormat5.Size = New System.Drawing.Size(97, 20)
        Me.TextboxFormat5.TabIndex = 9
        Me.TextboxFormat5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextboxFormat3
        '
        Me.TextboxFormat3.Formato = "C2"
        Me.TextboxFormat3.Location = New System.Drawing.Point(100, 125)
        Me.TextboxFormat3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextboxFormat3.Name = "TextboxFormat3"
        Me.TextboxFormat3.Size = New System.Drawing.Size(97, 20)
        Me.TextboxFormat3.TabIndex = 8
        Me.TextboxFormat3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(23, 169)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 22)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Salario Neto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 146)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Deducciones"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 125)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Salario Bruto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 22)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(97, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(100, 86)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(97, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(38, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Categoria"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(38, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Valor unid."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(38, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "(horas/dias/lecciones)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextboxFormat1
        '
        Me.TextboxFormat1.Formato = "C2"
        Me.TextboxFormat1.Location = New System.Drawing.Point(100, 44)
        Me.TextboxFormat1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextboxFormat1.Name = "TextboxFormat1"
        Me.TextboxFormat1.ReadOnly = True
        Me.TextboxFormat1.Size = New System.Drawing.Size(97, 20)
        Me.TextboxFormat1.TabIndex = 7
        Me.TextboxFormat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.DataGrid3)
        Me.GroupBox3.Controls.Add(Me.TextboxFormat2)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(222, 199)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingresos"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(46, 178)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sub total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGrid3
        '
        Me.DataGrid3.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGrid3.CaptionVisible = False
        Me.DataGrid3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGrid3.DataMember = ""
        Me.DataGrid3.DataSource = Me.DataViewIngresos
        Me.DataGrid3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid3.Location = New System.Drawing.Point(2, 15)
        Me.DataGrid3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.RowHeaderWidth = 20
        Me.DataGrid3.Size = New System.Drawing.Size(218, 162)
        Me.DataGrid3.TabIndex = 9
        Me.DataGrid3.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle5})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarRubroToolStripMenuItem, Me.EliminarRubroToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 48)
        '
        'AgregarRubroToolStripMenuItem
        '
        Me.AgregarRubroToolStripMenuItem.Name = "AgregarRubroToolStripMenuItem"
        Me.AgregarRubroToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AgregarRubroToolStripMenuItem.Text = "+ Agregar Rubro"
        '
        'EliminarRubroToolStripMenuItem
        '
        Me.EliminarRubroToolStripMenuItem.Name = "EliminarRubroToolStripMenuItem"
        Me.EliminarRubroToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EliminarRubroToolStripMenuItem.Text = "- Eliminar Rubro"
        '
        'DataViewIngresos
        '
        Me.DataViewIngresos.AllowNew = False
        Me.DataViewIngresos.RowFilter = "categoria = 'Ingreso'"
        Me.DataViewIngresos.Table = Me.Ds2planilla1.pagos_detalle
        '
        'Ds2planilla1
        '
        Me.Ds2planilla1.DataSetName = "ds2planilla"
        Me.Ds2planilla1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.Ds2planilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle5
        '
        Me.DataGridTableStyle5.DataGrid = Me.DataGrid3
        Me.DataGridTableStyle5.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle5.MappingName = "pagos_detalle"
        Me.DataGridTableStyle5.RowHeaderWidth = 20
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.MappingName = "nombre"
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 115
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn14.Format = "n"
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.MappingName = "monto"
        Me.DataGridTextBoxColumn14.Width = 70
        '
        'TextboxFormat2
        '
        Me.TextboxFormat2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextboxFormat2.Formato = "C2"
        Me.TextboxFormat2.Location = New System.Drawing.Point(107, 178)
        Me.TextboxFormat2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextboxFormat2.Name = "TextboxFormat2"
        Me.TextboxFormat2.Size = New System.Drawing.Size(97, 20)
        Me.TextboxFormat2.TabIndex = 8
        Me.TextboxFormat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGrid2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextboxFormat4)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(238, 7)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(222, 199)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deducciones"
        '
        'DataGrid2
        '
        Me.DataGrid2.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGrid2.CaptionVisible = False
        Me.DataGrid2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.DataSource = Me.DataViewDeducciones
        Me.DataGrid2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(2, 15)
        Me.DataGrid2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.RowHeaderWidth = 20
        Me.DataGrid2.Size = New System.Drawing.Size(218, 162)
        Me.DataGrid2.TabIndex = 0
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataViewDeducciones
        '
        Me.DataViewDeducciones.AllowNew = False
        Me.DataViewDeducciones.RowFilter = "categoria = 'Deducción'"
        Me.DataViewDeducciones.Sort = "nombre"
        Me.DataViewDeducciones.Table = Me.Ds2planilla1.pagos_detalle
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.DataGrid = Me.DataGrid2
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn11})
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "pagos_detalle"
        Me.DataGridTableStyle4.RowHeaderWidth = 20
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "nombre"
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 115
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn11.Format = "n"
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "monto"
        Me.DataGridTextBoxColumn11.Width = 70
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(46, 178)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 14)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Sub total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextboxFormat4
        '
        Me.TextboxFormat4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextboxFormat4.Formato = "C2"
        Me.TextboxFormat4.Location = New System.Drawing.Point(107, 178)
        Me.TextboxFormat4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextboxFormat4.Name = "TextboxFormat4"
        Me.TextboxFormat4.Size = New System.Drawing.Size(97, 20)
        Me.TextboxFormat4.TabIndex = 11
        Me.TextboxFormat4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataView1
        '
        Me.DataView1.AllowNew = False
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.CaptionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.DVPlanillaPagosSelect
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGrid1.Location = New System.Drawing.Point(25, 18)
        Me.DataGrid1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 150
        Me.DataGrid1.RowHeaderWidth = 15
        Me.DataGrid1.Size = New System.Drawing.Size(430, 266)
        Me.DataGrid1.TabIndex = 6
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DVPlanillaPagosSelect
        '
        Me.DVPlanillaPagosSelect.AllowDelete = False
        Me.DVPlanillaPagosSelect.AllowEdit = False
        Me.DVPlanillaPagosSelect.AllowNew = False
        Me.DVPlanillaPagosSelect.Table = Me.Ds2planilla1.PlanillaPagoSelect
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "PlanillaPagoSelect"
        Me.DataGridTableStyle1.RowHeaderWidth = 15
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Cédula"
        Me.DataGridTextBoxColumn1.MappingName = "cedula"
        Me.DataGridTextBoxColumn1.Width = 80
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Apellidos"
        Me.DataGridTextBoxColumn2.MappingName = "apellidos"
        Me.DataGridTextBoxColumn2.Width = 140
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn3.MappingName = "nombre"
        Me.DataGridTextBoxColumn3.Width = 130
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Categoria"
        Me.DataGridTextBoxColumn4.MappingName = "nombreCat"
        Me.DataGridTextBoxColumn4.Width = 55
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=planilla;Persist Security Info=True;User " &
    "ID=sa;Password=123"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 20, "cedula"), New System.Data.SqlClient.SqlParameter("@Expr1", System.Data.SqlDbType.VarChar, 20, "Expr1"), New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar, 30, "apellidos"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@salario_base", System.Data.SqlDbType.Money, 8, "salario_base"), New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@anualidad", System.Data.SqlDbType.Money, 8, "anualidad"), New System.Data.SqlClient.SqlParameter("@salario_bruto", System.Data.SqlDbType.[Decimal], 17, System.Data.ParameterDirection.Input, False, CType(38, Byte), CType(4, Byte), "salario_bruto", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Expr2", System.Data.SqlDbType.VarChar, 50, "Expr2"), New System.Data.SqlClient.SqlParameter("@id_dpto", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre")})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PlanillaPagoSelect", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_contrato", "id_contrato"), New System.Data.Common.DataColumnMapping("id_pagos", "id_pagos"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("apellidos", "apellidos"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("id_cat", "id_cat"), New System.Data.Common.DataColumnMapping("nombreCat", "nombreCat"), New System.Data.Common.DataColumnMapping("salario_base", "salario_base"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("anualidadReconocida", "anualidadReconocida"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("id_emp", "id_emp")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[PlanillaPagoSelect]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_planilla", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=servidor-bd;Initial Catalog=planilla;Persist Security Info=True;User " &
    "ID=sa;Password=123"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'Planillas
        '
        Me.Planillas.DeleteCommand = Me.SqlDeleteCommand1
        Me.Planillas.InsertCommand = Me.SqlInsertCommand2
        Me.Planillas.SelectCommand = Me.SqlSelectCommand2
        Me.Planillas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "planillas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_planilla", "id_planilla"), New System.Data.Common.DataColumnMapping("fecha_ini", "fecha_ini"), New System.Data.Common.DataColumnMapping("fecha_fin", "fecha_fin"), New System.Data.Common.DataColumnMapping("id_dpto", "id_dpto"), New System.Data.Common.DataColumnMapping("estado", "estado")})})
        Me.Planillas.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_planilla", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_planilla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_ini", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_ini", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_fin", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_dpto", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection2
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@fecha_ini", System.Data.SqlDbType.DateTime, 0, "fecha_ini"), New System.Data.SqlClient.SqlParameter("@fecha_fin", System.Data.SqlDbType.DateTime, 0, "fecha_fin"), New System.Data.SqlClient.SqlParameter("@id_dpto", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.Bit, 0, "estado")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT     id_planilla, fecha_ini, fecha_fin, id_dpto,estado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         planil" &
    "las" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE     (id_dpto = @id_dpto)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY id_planilla DESC"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_dpto", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@fecha_ini", System.Data.SqlDbType.DateTime, 0, "fecha_ini"), New System.Data.SqlClient.SqlParameter("@fecha_fin", System.Data.SqlDbType.DateTime, 0, "fecha_fin"), New System.Data.SqlClient.SqlParameter("@id_dpto", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.Bit, 0, "estado"), New System.Data.SqlClient.SqlParameter("@Original_id_planilla", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_planilla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_ini", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_ini", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_fin", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_dpto", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_planilla", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_planilla", System.Data.DataRowVersion.Current, Nothing)})
        '
        'PlanillaPagosDetalle
        '
        Me.PlanillaPagosDetalle.DeleteCommand = Me.SqlCommand1
        Me.PlanillaPagosDetalle.SelectCommand = Me.SqlSelectCommand3
        Me.PlanillaPagosDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PlanillaPagosDetalleSelect", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("categoria", "categoria"), New System.Data.Common.DataColumnMapping("tipo", "tipo"), New System.Data.Common.DataColumnMapping("valor", "valor"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("id_rubro", "id_rubro")})})
        Me.PlanillaPagosDetalle.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "DELETE FROM pagos_detalle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (id_pago = @id_pago) AND (id_rubro = @id_" &
    "rubro)"
        Me.SqlCommand1.Connection = Me.SqlConnection1
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_pago", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "[PlanillaPagosDetalleSelect]"
        Me.SqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand3.Connection = Me.SqlConnection2
        Me.SqlSelectCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_pago", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, "2908")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "[PlanillaPagosDetalleUpdate]"
        Me.SqlUpdateCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_pago", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 4, "monto"), New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing)})
        '
        'PlanillaResumenMonto
        '
        Me.PlanillaResumenMonto.SelectCommand = Me.SqlSelectCommand4
        Me.PlanillaResumenMonto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PlanillaResumenMontos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_rubro", "id_rubro"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("categoria", "categoria")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "[PlanillaResumenMontos]"
        Me.SqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        Me.SqlSelectCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_planilla", System.Data.SqlDbType.Int, 4)})
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(19, 430)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 21)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Salario Neto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(19, 407)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 21)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Deducciones"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(19, 385)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 22)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Salario Bruto"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGrid5)
        Me.GroupBox4.Location = New System.Drawing.Point(452, 2)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(254, 283)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resumen Planilla"
        '
        'DataGrid5
        '
        Me.DataGrid5.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGrid5.CaptionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGrid5.DataMember = ""
        Me.DataGrid5.DataSource = Me.Ds2planilla1.PlanillaResumenMontos
        Me.DataGrid5.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGrid5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid5.Location = New System.Drawing.Point(2, 15)
        Me.DataGrid5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGrid5.Name = "DataGrid5"
        Me.DataGrid5.ReadOnly = True
        Me.DataGrid5.RowHeaderWidth = 15
        Me.DataGrid5.Size = New System.Drawing.Size(250, 267)
        Me.DataGrid5.TabIndex = 0
        Me.DataGrid5.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DataGrid5
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "PlanillaResumenMontos"
        Me.DataGridTableStyle2.RowHeaderWidth = 15
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "nombre"
        Me.DataGridTextBoxColumn5.Width = 90
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = "n"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.MappingName = "monto"
        Me.DataGridTextBoxColumn6.Width = 70
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "categoria"
        Me.DataGridTextBoxColumn7.Width = 60
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
        Me.DockSite4.Location = New System.Drawing.Point(0, 433)
        Me.DockSite4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(774, 0)
        Me.DockSite4.TabIndex = 15
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Controls.Add(Me.Bar1)
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar1, 212, 433), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Horizontal)
        Me.DockSite1.Location = New System.Drawing.Point(0, 0)
        Me.DockSite1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(215, 433)
        Me.DockSite1.TabIndex = 12
        Me.DockSite1.TabStop = False
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.Bar1.AlwaysDisplayDockTab = True
        Me.Bar1.AutoHide = True
        Me.Bar1.AutoHideAnimationTime = 30
        Me.Bar1.AutoSyncBarCaption = True
        Me.Bar1.BarType = DevComponents.DotNetBar.eBarType.DockWindow
        Me.Bar1.Controls.Add(Me.PanelDockContainer1)
        Me.Bar1.Controls.Add(Me.PanelDockContainer2)
        Me.Bar1.Controls.Add(Me.PanelDockContainer3)
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Bar1.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem1, Me.DockContainerItem2, Me.DockContainerItem3})
        Me.Bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.SelectedDockTab = 0
        Me.Bar1.Size = New System.Drawing.Size(212, 433)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Planillas"
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer1.Controls.Add(Me.DataGridView1)
        Me.PanelDockContainer1.Controls.Add(Me.TextboxFormat7)
        Me.PanelDockContainer1.Controls.Add(Me.Label11)
        Me.PanelDockContainer1.Controls.Add(Me.TextboxFormat8)
        Me.PanelDockContainer1.Controls.Add(Me.Label10)
        Me.PanelDockContainer1.Controls.Add(Me.TextboxFormat9)
        Me.PanelDockContainer1.Controls.Add(Me.Label9)
        Me.PanelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 48)
        Me.PanelDockContainer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(206, 382)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdplanillaDataGridViewTextBoxColumn, Me.FechainiDataGridViewTextBoxColumn, Me.FechafinDataGridViewTextBoxColumn, Me.estado})
        Me.DataGridView1.DataSource = Me.PlanillasBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 20
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(206, 378)
        Me.DataGridView1.TabIndex = 21
        '
        'IdplanillaDataGridViewTextBoxColumn
        '
        Me.IdplanillaDataGridViewTextBoxColumn.DataPropertyName = "id_planilla"
        Me.IdplanillaDataGridViewTextBoxColumn.FillWeight = 91.37056!
        Me.IdplanillaDataGridViewTextBoxColumn.HeaderText = "Planilla"
        Me.IdplanillaDataGridViewTextBoxColumn.Name = "IdplanillaDataGridViewTextBoxColumn"
        Me.IdplanillaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechainiDataGridViewTextBoxColumn
        '
        Me.FechainiDataGridViewTextBoxColumn.DataPropertyName = "fecha_ini"
        Me.FechainiDataGridViewTextBoxColumn.FillWeight = 104.3147!
        Me.FechainiDataGridViewTextBoxColumn.HeaderText = "Inicio"
        Me.FechainiDataGridViewTextBoxColumn.Name = "FechainiDataGridViewTextBoxColumn"
        '
        'FechafinDataGridViewTextBoxColumn
        '
        Me.FechafinDataGridViewTextBoxColumn.DataPropertyName = "fecha_fin"
        Me.FechafinDataGridViewTextBoxColumn.FillWeight = 104.3147!
        Me.FechafinDataGridViewTextBoxColumn.HeaderText = "Fin"
        Me.FechafinDataGridViewTextBoxColumn.Name = "FechafinDataGridViewTextBoxColumn"
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "estado"
        Me.estado.Name = "estado"
        Me.estado.Visible = False
        '
        'PlanillasBindingSource
        '
        Me.PlanillasBindingSource.DataMember = "planillas"
        Me.PlanillasBindingSource.DataSource = Me.Ds2planilla1
        Me.PlanillasBindingSource.Filter = "estado>=0"
        '
        'TextboxFormat7
        '
        Me.TextboxFormat7.BackColor = System.Drawing.Color.PaleGreen
        Me.TextboxFormat7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxFormat7.Formato = "C2"
        Me.TextboxFormat7.Location = New System.Drawing.Point(96, 426)
        Me.TextboxFormat7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextboxFormat7.Name = "TextboxFormat7"
        Me.TextboxFormat7.Size = New System.Drawing.Size(97, 21)
        Me.TextboxFormat7.TabIndex = 16
        Me.TextboxFormat7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextboxFormat8
        '
        Me.TextboxFormat8.Formato = "C2"
        Me.TextboxFormat8.Location = New System.Drawing.Point(96, 407)
        Me.TextboxFormat8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextboxFormat8.Name = "TextboxFormat8"
        Me.TextboxFormat8.Size = New System.Drawing.Size(97, 20)
        Me.TextboxFormat8.TabIndex = 15
        Me.TextboxFormat8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextboxFormat9
        '
        Me.TextboxFormat9.Formato = "C2"
        Me.TextboxFormat9.Location = New System.Drawing.Point(96, 388)
        Me.TextboxFormat9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextboxFormat9.Name = "TextboxFormat9"
        Me.TextboxFormat9.Size = New System.Drawing.Size(97, 20)
        Me.TextboxFormat9.TabIndex = 14
        Me.TextboxFormat9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanelDockContainer2
        '
        Me.PanelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer2.Controls.Add(Me.UcProgresoCircular1)
        Me.PanelDockContainer2.Controls.Add(Me.ButtonX1)
        Me.PanelDockContainer2.Controls.Add(Me.DateTimePicker1)
        Me.PanelDockContainer2.Controls.Add(Me.DateTimePicker2)
        Me.PanelDockContainer2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer2.Location = New System.Drawing.Point(3, 48)
        Me.PanelDockContainer2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelDockContainer2.Name = "PanelDockContainer2"
        Me.PanelDockContainer2.Size = New System.Drawing.Size(206, 382)
        Me.PanelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer2.Style.GradientAngle = 90
        Me.PanelDockContainer2.TabIndex = 2
        '
        'UcProgresoCircular1
        '
        Me.UcProgresoCircular1.BackColor = System.Drawing.Color.Transparent
        Me.UcProgresoCircular1.Location = New System.Drawing.Point(19, 168)
        Me.UcProgresoCircular1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UcProgresoCircular1.Name = "UcProgresoCircular1"
        Me.UcProgresoCircular1.Size = New System.Drawing.Size(96, 92)
        Me.UcProgresoCircular1.TabIndex = 4
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Location = New System.Drawing.Point(11, 109)
        Me.ButtonX1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(104, 38)
        Me.ButtonX1.TabIndex = 3
        Me.ButtonX1.Text = "Generar"
        '
        'PanelDockContainer3
        '
        Me.PanelDockContainer3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer3.Controls.Add(Me.ButtonX3)
        Me.PanelDockContainer3.Controls.Add(Me.ButtonX2)
        Me.PanelDockContainer3.Controls.Add(Me.DataGridView2)
        Me.PanelDockContainer3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer3.Location = New System.Drawing.Point(3, 48)
        Me.PanelDockContainer3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelDockContainer3.Name = "PanelDockContainer3"
        Me.PanelDockContainer3.Size = New System.Drawing.Size(206, 382)
        Me.PanelDockContainer3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer3.Style.GradientAngle = 90
        Me.PanelDockContainer3.TabIndex = 4
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(102, 385)
        Me.ButtonX3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(90, 40)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 2
        Me.ButtonX3.Text = "LIMPIAR"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(9, 385)
        Me.ButtonX2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(87, 40)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 1
        Me.ButtonX2.Text = "RECUPERAR"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdplanillaDataGridViewTextBoxColumn1, Me.FechainiDataGridViewTextBoxColumn1, Me.FechafinDataGridViewTextBoxColumn1, Me.IddptoDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.PlanillasBindingSource1
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(206, 378)
        Me.DataGridView2.TabIndex = 0
        '
        'IdplanillaDataGridViewTextBoxColumn1
        '
        Me.IdplanillaDataGridViewTextBoxColumn1.DataPropertyName = "id_planilla"
        Me.IdplanillaDataGridViewTextBoxColumn1.HeaderText = "id_planilla"
        Me.IdplanillaDataGridViewTextBoxColumn1.Name = "IdplanillaDataGridViewTextBoxColumn1"
        Me.IdplanillaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdplanillaDataGridViewTextBoxColumn1.Width = 60
        '
        'FechainiDataGridViewTextBoxColumn1
        '
        Me.FechainiDataGridViewTextBoxColumn1.DataPropertyName = "fecha_ini"
        Me.FechainiDataGridViewTextBoxColumn1.HeaderText = "fecha_ini"
        Me.FechainiDataGridViewTextBoxColumn1.Name = "FechainiDataGridViewTextBoxColumn1"
        Me.FechainiDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechainiDataGridViewTextBoxColumn1.Width = 60
        '
        'FechafinDataGridViewTextBoxColumn1
        '
        Me.FechafinDataGridViewTextBoxColumn1.DataPropertyName = "fecha_fin"
        Me.FechafinDataGridViewTextBoxColumn1.HeaderText = "fecha_fin"
        Me.FechafinDataGridViewTextBoxColumn1.Name = "FechafinDataGridViewTextBoxColumn1"
        Me.FechafinDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechafinDataGridViewTextBoxColumn1.Width = 60
        '
        'IddptoDataGridViewTextBoxColumn
        '
        Me.IddptoDataGridViewTextBoxColumn.DataPropertyName = "id_dpto"
        Me.IddptoDataGridViewTextBoxColumn.HeaderText = "id_dpto"
        Me.IddptoDataGridViewTextBoxColumn.Name = "IddptoDataGridViewTextBoxColumn"
        Me.IddptoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IddptoDataGridViewTextBoxColumn.Width = 50
        '
        'PlanillasBindingSource1
        '
        Me.PlanillasBindingSource1.DataMember = "planillas"
        Me.PlanillasBindingSource1.DataSource = Me.Ds2planilla1
        Me.PlanillasBindingSource1.Filter = "estado=-1"
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Control = Me.PanelDockContainer1
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.Text = "Planillas"
        '
        'DockContainerItem2
        '
        Me.DockContainerItem2.Control = Me.PanelDockContainer2
        Me.DockContainerItem2.Name = "DockContainerItem2"
        Me.DockContainerItem2.Text = "Crea Planilla"
        '
        'DockContainerItem3
        '
        Me.DockContainerItem3.Control = Me.PanelDockContainer3
        Me.DockContainerItem3.Name = "DockContainerItem3"
        Me.DockContainerItem3.Text = "Borrados"
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(774, 0)
        Me.DockSite2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 433)
        Me.DockSite2.TabIndex = 13
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 433)
        Me.DockSite8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(774, 0)
        Me.DockSite8.TabIndex = 19
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 0)
        Me.DockSite5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 433)
        Me.DockSite5.TabIndex = 16
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(774, 0)
        Me.DockSite6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 433)
        Me.DockSite6.TabIndex = 17
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(774, 0)
        Me.DockSite7.TabIndex = 18
        Me.DockSite7.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(0, 0)
        Me.DockSite3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(774, 0)
        Me.DockSite3.TabIndex = 14
        Me.DockSite3.TabStop = False
        '
        'RibbonBarMergeContainer1
        '
        Me.RibbonBarMergeContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBarMergeContainer1.Controls.Add(Me.RibbonBar3)
        Me.RibbonBarMergeContainer1.Controls.Add(Me.RibbonBar2)
        Me.RibbonBarMergeContainer1.Controls.Add(Me.RibbonBar1)
        Me.RibbonBarMergeContainer1.Location = New System.Drawing.Point(218, 82)
        Me.RibbonBarMergeContainer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RibbonBarMergeContainer1.Name = "RibbonBarMergeContainer1"
        Me.RibbonBarMergeContainer1.RibbonTabText = "Planilla"
        Me.RibbonBarMergeContainer1.Size = New System.Drawing.Size(800, 95)
        '
        '
        '
        Me.RibbonBarMergeContainer1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBarMergeContainer1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBarMergeContainer1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBarMergeContainer1.TabIndex = 20
        Me.RibbonBarMergeContainer1.Visible = False
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
        Me.RibbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem12, Me.ButtonItem11, Me.ButtonItem10, Me.ButtonItem13, Me.ButtonItem14})
        Me.RibbonBar3.Location = New System.Drawing.Point(564, 0)
        Me.RibbonBar3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RibbonBar3.Name = "RibbonBar3"
        Me.RibbonBar3.Size = New System.Drawing.Size(234, 95)
        Me.RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar3.TabIndex = 2
        Me.RibbonBar3.Text = "Reportes Mensuales"
        '
        '
        '
        Me.RibbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem12
        '
        Me.ButtonItem12.Enabled = False
        Me.ButtonItem12.Image = Global.Planilla.My.Resources.Resources.document
        Me.ButtonItem12.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem12.Name = "ButtonItem12"
        Me.ButtonItem12.Text = "Planilla"
        Me.ButtonItem12.Tooltip = "Planilla"
        '
        'ButtonItem11
        '
        Me.ButtonItem11.Image = Global.Planilla.My.Resources.Resources.document
        Me.ButtonItem11.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem11.Name = "ButtonItem11"
        Me.ButtonItem11.SubItemsExpandWidth = 14
        Me.ButtonItem11.Text = "SSVMN"
        '
        'ButtonItem10
        '
        Me.ButtonItem10.Command = Me.Ahorro
        Me.ButtonItem10.Image = Global.Planilla.My.Resources.Resources.coopeande32
        Me.ButtonItem10.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem10.Name = "ButtonItem10"
        Me.ButtonItem10.SubItemsExpandWidth = 14
        Me.ButtonItem10.Text = "Ahorro"
        '
        'Ahorro
        '
        Me.Ahorro.Name = "Ahorro"
        '
        'ButtonItem13
        '
        Me.ButtonItem13.Command = Me.Prestamo
        Me.ButtonItem13.Image = Global.Planilla.My.Resources.Resources.coopeande32
        Me.ButtonItem13.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem13.Name = "ButtonItem13"
        Me.ButtonItem13.SubItemsExpandWidth = 14
        Me.ButtonItem13.Text = "Préstamo"
        '
        'Prestamo
        '
        Me.Prestamo.Name = "Prestamo"
        '
        'ButtonItem14
        '
        Me.ButtonItem14.Command = Me.coope
        Me.ButtonItem14.Image = Global.Planilla.My.Resources.Resources.coopeande32
        Me.ButtonItem14.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem14.Name = "ButtonItem14"
        Me.ButtonItem14.SubItemsExpandWidth = 14
        Me.ButtonItem14.Text = "Capital"
        '
        'coope
        '
        Me.coope.Name = "coope"
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
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem6, Me.ButtonItem7, Me.ButtonItem15, Me.ButtonItem8, Me.CoopeAnde, Me.ButtonItem1, Me.ButtonItem3, Me.ButtonItem4})
        Me.RibbonBar2.Location = New System.Drawing.Point(150, 0)
        Me.RibbonBar2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(414, 95)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar2.TabIndex = 1
        Me.RibbonBar2.Text = "Reportes"
        '
        '
        '
        Me.RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem6
        '
        Me.ButtonItem6.Enabled = False
        Me.ButtonItem6.Image = CType(resources.GetObject("ButtonItem6.Image"), System.Drawing.Image)
        Me.ButtonItem6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.Text = "Planilla"
        Me.ButtonItem6.Tooltip = "Planilla"
        '
        'ButtonItem7
        '
        Me.ButtonItem7.Enabled = False
        Me.ButtonItem7.Image = CType(resources.GetObject("ButtonItem7.Image"), System.Drawing.Image)
        Me.ButtonItem7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.Text = "Colilla Pago"
        Me.ButtonItem7.Tooltip = "Rep. Pagos"
        '
        'ButtonItem15
        '
        Me.ButtonItem15.Enabled = False
        Me.ButtonItem15.Image = Global.Planilla.My.Resources.Resources.document
        Me.ButtonItem15.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem15.Name = "ButtonItem15"
        Me.ButtonItem15.SubItemsExpandWidth = 14
        Me.ButtonItem15.Text = "Colilla H.Extras"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.Enabled = False
        Me.ButtonItem8.Image = CType(resources.GetObject("ButtonItem8.Image"), System.Drawing.Image)
        Me.ButtonItem8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "Arch. Banco"
        Me.ButtonItem8.Tooltip = "Arch. Banco"
        '
        'CoopeAnde
        '
        Me.CoopeAnde.Enabled = False
        Me.CoopeAnde.Image = CType(resources.GetObject("CoopeAnde.Image"), System.Drawing.Image)
        Me.CoopeAnde.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.CoopeAnde.Name = "CoopeAnde"
        Me.CoopeAnde.SubItemsExpandWidth = 14
        Me.CoopeAnde.Text = "Arch. CoopeAnde"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Image = CType(resources.GetObject("ButtonItem1.Image"), System.Drawing.Image)
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "SSVMN"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Image = CType(resources.GetObject("ButtonItem3.Image"), System.Drawing.Image)
        Me.ButtonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "<div align = ""center""> JPMN   <br/> Capitalizable </div>"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.Image = CType(resources.GetObject("ButtonItem4.Image"), System.Drawing.Image)
        Me.ButtonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Text = "<div align = ""center""> JPMN   <br/> Reparto</div>"
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
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem2, Me.ButtonItem5, Me.ButtonItem9})
        Me.RibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonBar1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(150, 95)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar1.TabIndex = 0
        Me.RibbonBar1.Text = "Planilla"
        '
        '
        '
        Me.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Enabled = False
        Me.ButtonItem2.Image = CType(resources.GetObject("ButtonItem2.Image"), System.Drawing.Image)
        Me.ButtonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Borra Planilla"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.Enabled = False
        Me.ButtonItem5.Image = CType(resources.GetObject("ButtonItem5.Image"), System.Drawing.Image)
        Me.ButtonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "Recalcular"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.Image = Global.Planilla.My.Resources.Resources.security
        Me.ButtonItem9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.SubItemsExpandWidth = 14
        Me.ButtonItem9.Text = "Proteger"
        Me.ButtonItem9.Tooltip = "Impide hacer cambios en la planilla"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Enero"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Febrero"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Marzo"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Abril"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Mayo"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Junio"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Julio"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Agosto"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Septiembre"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "Octubre"
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "Noviembre"
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "Diciembre"
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "Enero"
        '
        'ComboItem14
        '
        Me.ComboItem14.Text = "Febrero"
        '
        'ComboItem15
        '
        Me.ComboItem15.Text = "Marzo"
        '
        'ComboItem16
        '
        Me.ComboItem16.Text = "Abril"
        '
        'ComboItem17
        '
        Me.ComboItem17.Text = "Mayo"
        '
        'ComboItem18
        '
        Me.ComboItem18.Text = "Junio"
        '
        'ComboItem19
        '
        Me.ComboItem19.Text = "Julio"
        '
        'ComboItem20
        '
        Me.ComboItem20.Text = "Agosto"
        '
        'ComboItem21
        '
        Me.ComboItem21.Text = "Septiembre"
        '
        'ComboItem22
        '
        Me.ComboItem22.Text = "Octubre"
        '
        'ComboItem23
        '
        Me.ComboItem23.Text = "Noviembre"
        '
        'ComboItem24
        '
        Me.ComboItem24.Text = "Diciembre"
        '
        'DataViewPlanillas
        '
        Me.DataViewPlanillas.AllowDelete = False
        Me.DataViewPlanillas.AllowEdit = False
        Me.DataViewPlanillas.AllowNew = False
        Me.DataViewPlanillas.Table = Me.Ds2planilla1.planillas
        '
        'bw1
        '
        '
        'frmPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(774, 433)
        Me.Controls.Add(Me.RibbonBarMergeContainer1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "frmPlanilla"
        Me.Text = "Planillas"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DataViewIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds2planilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataViewDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVPlanillaPagosSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite1.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        Me.PanelDockContainer1.ResumeLayout(False)
        Me.PanelDockContainer1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDockContainer2.ResumeLayout(False)
        Me.PanelDockContainer3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonBarMergeContainer1.ResumeLayout(False)
        CType(Me.DataViewPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmPlanilla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Me.RibbonBar3.Visible = False
        Me.Text = conn.llena("SELECT nombre FROM departamento WHERE id_dpto=" & id_dpto).Item(0)(0)
        Me.DataGridView1.RowHeadersWidth = 18
    End Sub

    Sub cargarPlanillas()
        ' carga la lista de planillas 
        Me.SqlConnection1.ConnectionString = conn.strConn
        Me.SqlConnection2.ConnectionString = conn.strConn

        Me.Ds2planilla1.Tables("planillas").Clear()
        Me.Planillas.SelectCommand.Parameters("@id_dpto").Value = id_dpto
        Me.Planillas.Fill(Me.Ds2planilla1, "planillas")

        Dim datos As Object = Ds2planilla1.planillas.Rows.Item(0).ItemArray
        Dim id_plan1 As String = datos(0)
        fini = datos(1)
        ffin = datos(2)

        cargarPlanilla(id_plan1)
        MuestraPlanilla(id_plan1)
    End Sub

    Sub cargarPlanilla(ByVal pid_planilla As String)
        '
        'CARGAR LA PLANILLA ENVIADA COMO PARAMETRO
        Me.Ds2planilla1.Tables("PlanillaPagoSelect").Clear()
        id_planilla = pid_planilla
        Me.SqlDataAdapter1.SelectCommand.Parameters("@id_planilla").Value = id_planilla
        Me.SqlDataAdapter1.Fill(Me.Ds2planilla1, "PlanillaPagoSelect")
        planilla_estado = plan.GetEstado(id_planilla)

        DataGrid2.Enabled = True
        DataGrid3.Enabled = True
        ' Bloquea los grids para cambiar los valores cuando esta borrado o bloqueado
        Select Case planilla_estado
            Case -1  'borrado
                DataGrid2.Enabled = False
                DataGrid3.Enabled = False
                Me.BackColor = Color.White
            Case 0 'Nuevo
                Me.BackColor = Color.White
            Case 1 'Pagado
                Me.BackColor = Color.PaleGreen
            Case 2  'Bloqueado
                DataGrid2.Enabled = False
                DataGrid3.Enabled = False
                Me.BackColor = Color.Pink
        End Select

    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged

        If filas > 0 Then       'guarda los cambios    
            Me.BindingContext(Me.Ds2planilla1).EndCurrentEdit()
            Me.PlanillaPagosDetalle.UpdateCommand.Parameters("@id_pago").Value = id_pago
            Me.PlanillaPagosDetalle.DeleteCommand.Parameters("@id_pago").Value = id_pago
            Me.PlanillaPagosDetalle.Update(Me.Ds2planilla1, "pagos_detalle")
        End If

        ' Get the Currency Manager by using the BindingContext of the DataGrid
        Dim cm As CurrencyManager = CType(Me.BindingContext(DataGrid1.DataSource, DataGrid1.DataMember), CurrencyManager)

        ' Retrieve the default DataView of the DataGrid
        Dim dv As DataView = CType(cm.List, DataView)

        If cm.Position >= 0 Then
            Dim dr As Object
            dr = dv.Item(cm.Position).Row.ItemArray

            id_pago = dr(1)
            Me.TextBox1.Text = dr(6)
            Me.TextboxFormat1.Text = dr(7)
            Me.TextBox3.Text = dr(8)

            ' muestra anualidad
            Dim respq As ArrayList
            respq = conn.llena("select anualidad from categorias where nombre = '" & dr(6) & "'")
            TextboxFormat10.Text = respq(0)(0)

            ' cargas los otros pagos y dividirlos en los dataview
            Me.Ds2planilla1.Tables("pagos_detalle").Clear()
            Me.PlanillaPagosDetalle.SelectCommand.Parameters("@id_pago").Value = id_pago
            filas = Me.PlanillaPagosDetalle.Fill(Me.Ds2planilla1, "pagos_detalle")
            totaliza()
        End If
    End Sub

    Private Sub DataGrid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid1.MouseUp
        Dim pt As Point = New Point(e.X, e.Y)
        Dim hit As DataGrid.HitTestInfo = DataGrid1.HitTest(pt)

        If hit.Type = Windows.Forms.DataGrid.HitTestType.Cell Then
            DataGrid1.CurrentCell = New DataGridCell(hit.Row, hit.Column)
            DataGrid1.Select(hit.Row)
        End If
    End Sub

    Private Sub DataGrid2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.CurrentCellChanged
        totaliza()
    End Sub
    Private Sub DataGrid3_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid3.CurrentCellChanged
        totaliza()
    End Sub

    Private Sub totaliza()
        If filas > 0 Then

            If (planilla_estado = 0) Then ' ACTUALIZA MONTOS EN LA BASE DE DATOS
                Me.BindingContext(Me.Ds2planilla1).EndCurrentEdit()
                Me.PlanillaPagosDetalle.UpdateCommand.Parameters("@id_pago").Value = id_pago
                Me.PlanillaPagosDetalle.DeleteCommand.Parameters("@id_pago").Value = id_pago
                Me.PlanillaPagosDetalle.Update(Me.Ds2planilla1, "pagos_detalle")
            End If
            '
            'SUMA LOS INGRESOS Y LOS MUESTRA 
            resultado = Me.Ds2planilla1.Tables("pagos_detalle").Compute("Sum(monto)",
                    "categoria = 'Ingreso'")
            _ingresos = IIf(resultado.GetType.ToString = "System.Decimal", resultado, 0)

            Me.TextboxFormat2.Text = _ingresos
            Me.TextboxFormat3.Text = _ingresos

            If (planilla_estado = 0) Then
                CalculaPorcentajeDeducciones(_ingresos)
            End If
            '
            'CALCULA LAS DEDUCCIONES Y LAS MUESTRA
            resultado = Me.Ds2planilla1.Tables("pagos_detalle").Compute("Sum(monto)",
                    "categoria = 'Deducción' ")
            _deducciones = IIf(resultado.GetType.ToString = "System.Decimal", resultado, 0)

            Me.TextboxFormat4.Text = _deducciones
            Me.TextboxFormat5.Text = _deducciones
            '
            ' CALCULA SALARIO NETO
            Me.TextboxFormat6.Text = _ingresos + _deducciones
            resumen_planilla(id_planilla)
            ' APLICA ESTADO DEL DATAGRIDVIEW SEGUN CONDICION
        Else
            Me.TextboxFormat2.Text = 0
            Me.TextboxFormat3.Text = 0

            Me.TextboxFormat4.Text = 0
            Me.TextboxFormat5.Text = 0

            Me.TextboxFormat6.Text = 0
        End If
    End Sub

    Private Sub CalculaPorcentajeDeducciones(ByVal pIngreso As Decimal)
        Dim result As ArrayList
        Dim id_contrato As Integer
        Dim formu, proce As String

        result = conn.llena("select id_contrato from pagos where id_pagos=" & id_pago)
        id_contrato = result(0)(0)

        For Each fila As DataRow In Me.Ds2planilla1.Tables("pagos_detalle").Rows
            formu = UCase(fila.Item("formula"))
            'If InStr(formu, "SB") Or InStr(formu, "AN") Or InStr(formu, "CANT") Or InStr(formu, "TSB") Or InStr(formu, "SAL") Then
            If ((InStr(formu, "TSB") + InStr(formu, "SAL")) > 0) Then
                proce = "exec formula_calcula2 " & id_contrato & "," & id_pago & "," & fila.Item("id_rubro")
                result = conn.llena(proce)
                If result.Count > 0 Then
                    fila.Item("monto") = result(0)(0)
                End If
            End If
        Next
        Me.DataGrid2.Refresh()
        Me.DataGrid3.Refresh()
    End Sub

    Private Sub resumen_planilla(ByVal pid_planilla As Integer)
        Try
            Dim res As Integer
            Dim Tingresos, TDeducciones As Decimal

            Me.Ds2planilla1.Tables("PlanillaResumenMontos").Clear()
            Me.PlanillaResumenMonto.SelectCommand.Parameters("@id_planilla").Value = pid_planilla
            res = Me.PlanillaResumenMonto.Fill(Me.Ds2planilla1, "PlanillaResumenMontos")

            If Me.Ds2planilla1.Tables("PlanillaResumenMontos").Rows.Count > 0 Then
                resultado = Me.Ds2planilla1.Tables("PlanillaResumenMontos").Compute("Sum(monto)",
                           "categoria = 'Ingreso' ")
                Tingresos = IIf(resultado.GetType.ToString = "System.Decimal", resultado, 0)
            End If

            If Me.Ds2planilla1.Tables("PlanillaResumenMontos").Rows.Count > 0 Then
                resultado = Me.Ds2planilla1.Tables("PlanillaResumenMontos").Compute("Sum(monto)",
                           "categoria = 'Deducción' ")
                TDeducciones = IIf(resultado.GetType.ToString = "System.Decimal", resultado, 0)
            End If

            Me.TextboxFormat9.Text = Tingresos
            Me.TextboxFormat8.Text = TDeducciones
            Me.TextboxFormat7.Text = Tingresos + TDeducciones
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Muestra los datos por los grids y campos de la ventana
    ''' </summary>
    ''' <param name="pid_planilla"> planilla a mostrar por el formulario</param>
    ''' <remarks></remarks>
    Private Sub MuestraPlanilla(pid_planilla As Integer)

        Me.cargarPlanilla(pid_planilla)
        Me.DataGrid1.CaptionText = " Planilla : " & fini & " - " & ffin
        Me.DataGrid5.CaptionText = " Planilla : " & pid_planilla

        Dim dias_reportes As Long = DateDiff(DateInterval.Day, fini, ffin)

        Me.resumen_planilla(pid_planilla)

        Me.ButtonItem6.Enabled = True
        Me.ButtonItem7.Enabled = True
        Me.ButtonItem8.Enabled = True
        Me.ButtonItem9.Enabled = True
        Me.ButtonItem15.Enabled = True
        Me.CoopeAnde.Enabled = True

        Select Case planilla_estado
            Case -1  'borrado
                Me.ButtonItem2.Enabled = False
                Me.ButtonItem5.Enabled = False
                Me.ButtonItem6.Enabled = False
                Me.ButtonItem7.Enabled = False
                Me.ButtonItem8.Enabled = False
                Me.ButtonItem9.Enabled = False
                Me.ButtonItem15.Enabled = False
                Me.CoopeAnde.Enabled = False
            Case 0  'nuevo
                Me.ButtonItem2.Enabled = True
                Me.ButtonItem5.Enabled = True

            Case 1 'pagado
                Me.ButtonItem2.Enabled = True
                Me.ButtonItem5.Enabled = False
            Case 2    ' bloqueado
                Me.ButtonItem2.Enabled = False
                Me.ButtonItem5.Enabled = False

        End Select
        Me.RibbonBar3.Visible = False

        If dias_reportes < 16 Then
            Me.RibbonBar3.Visible = True
            Me.ButtonItem11.Enabled = True
            Me.ButtonItem12.Enabled = True
        End If
    End Sub

    Private Sub MenuButtonItem2_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  reporte de colillas de Pago
        Dim rep As New Reportes
        Dim orptPlanilla As New rptPlanilla
        orptPlanilla.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLegal
        orptPlanilla.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape

        orptPlanilla.SetParameterValue("@planilla", id_planilla)
        rep.imprimir(orptPlanilla, False, Me.ParentForm)
    End Sub

    '
    '  GENERAR PLANILLA
    '
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        'carga 
        UcProgresoCircular1.Muestra()

        bw1.RunWorkerAsync()
    End Sub

    Private Sub bw1_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw1.DoWork
        Dim conn As New conexionSQL("planilla")
        Dim comando As String
        comando = "exec crea_pagos " & id_dpto & ", '" & DateTimePicker1.Value.Date & "' , '" & Me.DateTimePicker2.Value.Date & "'"
        conn.ejecuta(comando)


    End Sub


    Private Sub bw1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw1.RunWorkerCompleted


        id_planilla = conn.llena("SELECT TOP 1 id_planilla FROM planillas ORDER BY id_planilla DESC ").Item(0)(0)
        Me.cargarPlanillas()
        Me.cargarPlanilla(id_planilla)
        Me.resumen_planilla(id_planilla)

        UcProgresoCircular1.Oculta()
    End Sub

    '
    '
    '           BORRA PLANILLA
    '
    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        'conn.ejecuta("delete from planillas where id_planilla =" & id_planilla)

        plan.SetEstado(cPlanilla.Estado.Borrado, id_planilla)

        Me.cargarPlanillas()
        Me.cargarPlanilla(conn.llena("SELECT TOP 1 id_planilla FROM planillas ORDER BY id_planilla DESC ").Item(0)(0))

        Me.DataGridView1.Refresh()
        Me.DataGridView2.Refresh()
    End Sub
    '
    '
    '           RECALCULA PLANILLA
    '
    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        Dim tsResult As System.TimeSpan = ffin.Subtract(fini)

        If tsResult.Days > 0 Then
            conn.ejecuta("EXEC crea_recalculo_planilla " & id_planilla)
        Else
            conn.ejecuta("EXEC calcula_pagos " & id_planilla) ' calcula aguinaldo
        End If

        Me.cargarPlanillas()
        Me.cargarPlanilla(Me.id_planilla)
        Me.DataGridView1.Refresh()
        MuestraPlanilla(Me.id_planilla)
    End Sub


    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        Try

            Dim data As New DataSet
            Dim ruta As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) _
                            & "\" & "Planilla " & Me.Text & " " & CStr(id_planilla) & ".env"
            Dim encabezado As String = ""
            Dim resumen As String = ""

            ' Crea y carga la tabla con los datos
            data.Tables.Add("tabla1")
            Dim inst As String = "exec planilla_BNCR " & id_planilla.ToString & ",'Salarios'"
            conn.llena(data, "tabla1", inst)

            ' Genera encabezado 
            Dim datos As Array = conn.llena("Select idclienteBanco from bancos ").ToArray
            encabezado = "1" & datos(0)(0).ToString.PadLeft(6, "0") &
                        Date.Now.ToShortDateString.Replace("/", "") _
                        & Me.id_planilla.ToString.PadLeft(6, "0") & "0000001" &
                        StrDup(40, "0")

            ' Genera resumen
            Dim reg As DataRow
            Dim tmonto, tcuentas As Long             ' Suma las columnas monto y cuenta
            For Each reg In data.Tables("tabla1").Rows
                tmonto += CLng(reg("monto"))
                tcuentas += CLng(reg("cuenta"))
            Next
            ' genera el string resumen
            resumen = "4" &
                tmonto.ToString.PadLeft(15, "0") &
                tcuentas.ToString.PadLeft(10, "0") &
                StrDup(42, "0")

            ' Genera Archivo en Escritorio
            conn.GeneraArchivoEncabezadoResumen(ruta, data.Tables(0), encabezado, resumen)

            'cambia el estado a la planilla 
            plan.SetEstado(cPlanilla.Estado.Pagado, id_planilla)

            Dim oHE As New cHorasExtras()
            oHE.LiquidaHoras(id_planilla)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '
    '
    '       REPORTE DE PLANILLA
    '
    '
    Private Sub ButtonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem6.Click
        ' reporte de Planilla Resumido

        Dim rep As New Reportes
        Dim orptPlanilla As New rptPlanilla

        orptPlanilla.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLetter
        orptPlanilla.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape
        orptPlanilla.SetParameterValue(0, id_planilla)

        rep.imprimir(orptPlanilla, False, Me.ParentForm)
    End Sub
    ''' <summary>
    ''' Colilla de pago POS
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonItem10_Click(sender As Object, e As EventArgs)
        Dim reportes As New Reportes
        Dim rep As ReportClass
        Dim tsResult As System.TimeSpan = ffin.Subtract(fini)

        If tsResult.Days > 0 Then
            rep = New rptColillasPagoPOS
            rep.SummaryInfo.ReportComments = "Informe de Pago"
        Else
            rep = New rptAguinaldo
            rep.SummaryInfo.ReportComments = "Informe de Aguinaldo"
        End If

        reportes.inserta_parametro(rep, "@id_planilla", id_planilla)
        reportes.imprimir(rep, False, Me.ParentForm)
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click

        'actualizar el id de planilla en el que se pagaron las horas extras
        conn.ejecuta("HoraExtra_act_id_planilla " & id_planilla.ToString)

        Dim reportes As New Reportes
        Dim rep As ReportClass
        Dim tsResult As System.TimeSpan = ffin.Subtract(fini)

        If tsResult.Days > 0 Then
            rep = New rptColillasPago
            rep.SummaryInfo.ReportComments = "Informe de Pago"
        Else
            rep = New rptAguinaldo
            rep.SummaryInfo.ReportComments = "Informe de Aguinaldo"
        End If

        reportes.inserta_parametro(rep, "@id_planilla", id_planilla)
        reportes.imprimir(rep, False, Me.ParentForm)
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Dim reportes As New Reportes
        Dim rep As New rptSSVM

        reportes.inserta_parametro(rep, "@id_planilla", id_planilla)
        rep.SummaryInfo.ReportComments = "Planilla Sociedad de Seguros de Vida del Magisterio Nacional"
        reportes.imprimir(rep, False, Me.ParentForm)
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click
        Dim reportes As New Reportes
        Dim rep As New rptJPMN
        reportes.inserta_parametro(rep, "@id_planilla", id_planilla)
        rep.SummaryInfo.ReportComments = "Junta de Pensiones y Jubilaciones del Magisterio Nacional"
        reportes.imprimir(rep, False, Me.ParentForm)
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        Dim reportes As New Reportes
        Dim rep As New rptJPMNFondoReparto
        reportes.inserta_parametro(rep, "@id_planilla", id_planilla)
        rep.SummaryInfo.ReportComments = "Junta de Pensiones y Jubilaciones del Magisterio Nacional"
        reportes.imprimir(rep, False, Me.ParentForm)
    End Sub


    ''' <summary>
    '''  Define el color de fondo de la fila dependiendo del estado de la planilla
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        '
        With Me.DataGridView1.Rows(e.RowIndex)
            Select Case .Cells(3).Value
                Case 0
                    .DefaultCellStyle.BackColor = Color.White
                Case 1
                    .DefaultCellStyle.BackColor = Color.PaleGreen
                Case 2
                    .DefaultCellStyle.BackColor = Color.Pink
            End Select
        End With
    End Sub


    Private Sub DataGridView1_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseUp
        ' Muestra los datos por pantalla de la Planillas
        '
        Me.RibbonBar3.Visible = False
        id_planilla = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value
        planilla_estado = Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value

        fini = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        ffin = DataGridView1.Rows(e.RowIndex).Cells(2).Value

        MuestraPlanilla(id_planilla)
        DataGrid1.Focus()

    End Sub

    Private Sub ButtonItem12_Click(sender As Object, e As EventArgs) Handles ButtonItem12.Click
        ' reporte de Planilla sumado por mes
        Dim rep As New Reportes
        Dim orptPlanilla As New rptPlanillasMensual
        orptPlanilla.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLetter
        orptPlanilla.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape

        orptPlanilla.SetParameterValue(0, Month(fini))
        orptPlanilla.SetParameterValue(1, id_dpto)
        orptPlanilla.SetParameterValue(2, Year(fini))
        rep.imprimir(orptPlanilla, False, Me.ParentForm)
    End Sub

    Private Sub ButtonItem11_Click(sender As Object, e As EventArgs) Handles ButtonItem11.Click
        Dim reportes As New Reportes
        Dim rep As New rptSSVM_Mensual

        reportes.inserta_parametro(rep, "@id_planilla", id_planilla)
        rep.SummaryInfo.ReportComments = "Planilla Sociedad de Seguros de Vida del Magisterio Nacional"
        reportes.imprimir(rep, False, Me.ParentForm)
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        'RECUPERAR PLANILLA BORRADA
        '
        plan.SetEstado(cPlanilla.Estado.Pagado, id_planilla)
        Me.cargarPlanillas()
        Me.cargarPlanilla(conn.llena("SELECT TOP 1 id_planilla FROM planillas ORDER BY id_planilla DESC ").Item(0)(0))

        Me.DataGridView1.Refresh()
        Me.DataGridView2.Refresh()
    End Sub

    Private Sub DataGridView2_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseUp
        'Este es el datagrid de los borrados
        '
        id_planilla = Me.DataGridView2.Rows(e.RowIndex).Cells(0).Value
        planilla_estado = Me.DataGridView2.Rows(e.RowIndex).Cells(3).Value

        Me.RibbonBar3.Visible = False

        fini = DataGridView2.Rows(e.RowIndex).Cells(1).Value
        ffin = DataGridView2.Rows(e.RowIndex).Cells(2).Value

        MuestraPlanilla(id_planilla)

    End Sub
    ''' <summary>
    ''' PROTEGER  impide hacer cambios en la planilla
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ButtonItem9_Click(sender As Object, e As EventArgs) Handles ButtonItem9.Click
        If id_planilla > 0 Then
            If planilla_estado = cPlanilla.Estado.Bloqueado Then
                plan.SetEstado(cPlanilla.Estado.Pagado, id_planilla)
                planilla_estado = cPlanilla.Estado.Pagado
            Else
                plan.SetEstado(cPlanilla.Estado.Bloqueado, id_planilla)
                planilla_estado = cPlanilla.Estado.Bloqueado
            End If
            Me.cargarPlanillas()
            Me.cargarPlanilla(id_planilla)
        End If

    End Sub

    Private Sub AgregarRubroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarRubroToolStripMenuItem.Click
        Dim control As Object = ContextMenuStrip1.SourceControl

        Dim frmagrega As New frmPlanillaAgregaRubro(id_pago)
        frmagrega.ShowDialog()

        refrescaRubros()
    End Sub

    Private Sub EliminarRubroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRubroToolStripMenuItem.Click
        ' Ds2planilla1.pagos_detalle.Rows.RemoveAt(DataGrid2.CurrentRowIndex)
        ' DataViewDeducciones.Item(DataGrid2.CurrentRowIndex)

        Select Case ContextMenuStrip1.SourceControl.Name
            Case "DataGrid2"
                DataViewDeducciones.Delete(DataGrid2.CurrentRowIndex)
            Case "DataGrid3"
                DataViewIngresos.Delete(DataGrid3.CurrentRowIndex)
            Case Else
        End Select

        refrescaRubros()
    End Sub
    Sub refrescaRubros()
        Dim actual As Integer = DataGrid1.CurrentRowIndex
        DataGrid1.CurrentRowIndex = 0
        DataGrid1.CurrentRowIndex = actual
    End Sub

    Private Sub CoopeAnde_Click(sender As Object, e As EventArgs) Handles CoopeAnde.Click
        Dim vnt As New Ventanas
        vnt.cargarVentana(New frmCoopeAnde(id_planilla), ParentForm)
    End Sub

    Private Sub Ahorro_Executed(sender As Object, e As EventArgs) Handles Ahorro.Executed
        Dim reportes As New Reportes
        Dim rep As New rptCoopAnde_Mensual

        reportes.inserta_parametro(rep, "@id_planilla", id_planilla)
        reportes.inserta_parametro(rep, "@nomb_rubro", "COPEANDE AHORRO")
        rep.SummaryInfo.ReportComments = "CoopeAnde Ahorro"
        reportes.imprimir(rep, False, Me.ParentForm)
    End Sub

    Private Sub Prestamo_Executed(sender As Object, e As EventArgs) Handles Prestamo.Executed
        Dim reportes As New Reportes
        Dim rep As New rptCoopAnde_Mensual

        reportes.inserta_parametro(rep, "@id_planilla", id_planilla)
        reportes.inserta_parametro(rep, "@nomb_rubro", "COPEANDE CRÉDITO")
        rep.SummaryInfo.ReportComments = "CoopeAnde  Créditos "
        reportes.imprimir(rep, False, Me.ParentForm)
    End Sub

    Private Sub coope_Executed(sender As Object, e As EventArgs) Handles coope.Executed
        Dim reportes As New Reportes
        Dim rep As New rptCoopAnde_Mensual

        reportes.inserta_parametro(rep, "@id_planilla", id_planilla)
        reportes.inserta_parametro(rep, "@nomb_rubro", "COPEANDE CAPITAL")
        rep.SummaryInfo.ReportComments = "CoopeAnde Capital"
        reportes.imprimir(rep, False, Me.ParentForm)
    End Sub
    ''' <summary>
    ''' Reporte de Horas Extras
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonItem15_Click(sender As Object, e As EventArgs) Handles ButtonItem15.Click

        Dim reportes As New Reportes
        Dim rep As ReportClass

        rep = New rptColillasHorasExtras
        rep.SummaryInfo.ReportComments = "Informe Horas Extras"

        reportes.inserta_parametro(rep, "@id_planilla", id_planilla)
        reportes.imprimir(rep, False, Me.ParentForm)
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        'RECUPERAR PLANILLA BORRADA
        '
        conn.ejecuta("Planilla_borra " & CStr(id_dpto))

        Me.cargarPlanillas()
        Me.cargarPlanilla(conn.llena("SELECT TOP 1 id_planilla FROM planillas ORDER BY id_planilla DESC ").Item(0)(0))

        Me.DataGridView1.Refresh()
        Me.DataGridView2.Refresh()
    End Sub


End Class

