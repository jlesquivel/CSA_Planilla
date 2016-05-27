Imports System.IO
Imports DevComponents.DotNetBar

Public Class frmContrato
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    Dim id_emp, id_pto As String
    Dim id_contrato As String
    Dim borra As Boolean
    Dim conn As New conexionSQL("planilla")
    Dim nuevor As Boolean = True
    Dim clista As New CargarLista
    Dim niveles As String()

#Region " Código generado por el Diseñador de Windows Forms "

    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem4 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents MonedaTextBox1 As Planilla.MonedaTextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents sexo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BEmpleado1 As Planilla.bEmpleado
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Sqltree As System.Data.SqlClient.SqlCommand
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents TreeViewSQL1 As Planilla.TreeViewSQL
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Contratos2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand As System.Data.SqlClient.SqlCommand
    Friend WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem5 As DevComponents.DotNetBar.TabItem
    Friend WithEvents CPagos1 As Planilla.cPagos
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As Planilla.ds2planillaTableAdapters.empleadosTableAdapter
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MonedaTextBox2 As Planilla.MonedaTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ComboBoxItem1 As DevComponents.DotNetBar.ComboBoxItem
    Friend WithEvents Label1 As Label
    Friend WithEvents SuperValidator1 As Validator.SuperValidator
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents Highlighter1 As Validator.Highlighter
    Friend WithEvents CustomValidator1 As Validator.CustomValidator
    Friend WithEvents ButtonItem3 As ButtonItem
    Friend WithEvents ButtonX3 As ButtonX
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewComboBoxColumn
    Friend WithEvents ContratosBindingSource As BindingSource
    Friend WithEvents ContratosDataGridViewX As Controls.DataGridViewX
    Friend WithEvents CategoriasBindingSource As BindingSource
    Friend WithEvents ContratoscategoriasBindingSource As BindingSource
    Friend WithEvents TabControlPanel6 As TabControlPanel
    Friend WithEvents TabItem6 As TabItem
    Friend WithEvents UcVacaciones1 As ucVacaciones
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Dim cargado As Boolean = False  ' para saber que no es la primera vez

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub
    Public Sub New(ByVal pptos As String, ByVal pid_emp As String, ByVal pborra As Boolean)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        id_emp = pid_emp
        id_pto = pptos
        borra = pborra
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
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents UserControl21 As Planilla.UserControl2
    Friend WithEvents Ds2planilla1 As Planilla.ds2planilla
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents BorraPuesto As System.Data.SqlClient.SqlCommand
    Friend WithEvents Puestos As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Contratos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DvContratos As System.Data.DataView
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContrato))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Planillas", 1, 1)
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Ds2planilla1 = New Planilla.ds2planilla()
        Me.DvContratos = New System.Data.DataView()
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.BorraPuesto = New System.Data.SqlClient.SqlCommand()
        Me.Puestos = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter5 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.Contratos = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SqlDataAdapter6 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.MonedaTextBox2 = New Planilla.MonedaTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.TreeViewSQL1 = New Planilla.TreeViewSQL()
        Me.Sqltree = New System.Data.SqlClient.SqlCommand()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.MonedaTextBox1 = New Planilla.MonedaTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ContratosDataGridViewX = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.sexo = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel6 = New DevComponents.DotNetBar.TabControlPanel()
        Me.UcVacaciones1 = New Planilla.ucVacaciones()
        Me.TabItem6 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TabItem4 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel()
        Me.CPagos1 = New Planilla.cPagos()
        Me.TabItem5 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ContratoscategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ComboBoxItem1 = New DevComponents.DotNetBar.ComboBoxItem()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.Contratos2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
        Me.EmpleadosTableAdapter = New Planilla.ds2planillaTableAdapters.empleadosTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuperValidator1 = New DevComponents.DotNetBar.Validator.SuperValidator()
        Me.CustomValidator1 = New DevComponents.DotNetBar.Validator.CustomValidator()
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.UserControl21 = New Planilla.UserControl2()
        Me.BEmpleado1 = New Planilla.bEmpleado()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.DataGridViewTextBoxColumn3 = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Ds2planilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.ExpandablePanel1.SuspendLayout()
        CType(Me.ContratosDataGridViewX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControlPanel6.SuspendLayout()
        Me.TabControlPanel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel5.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.ContratoscategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "empleados", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_emp", "id_emp"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("apellidos", "apellidos"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("categoria", "categoria"), New System.Data.Common.DataColumnMapping("nacimiento", "nacimiento"), New System.Data.Common.DataColumnMapping("cuenta", "cuenta"), New System.Data.Common.DataColumnMapping("ingreso", "ingreso"), New System.Data.Common.DataColumnMapping("banco", "banco"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("celular", "celular"), New System.Data.Common.DataColumnMapping("sexo", "sexo"), New System.Data.Common.DataColumnMapping("anualidadReconocida", "anualidadReconocida")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidadReconocida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellidos", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellidos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_banco", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cuenta", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sexo", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=planilla;Persist Security Info=True;User " &
    "ID=sa;Password=123"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection2
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 20, "cedula"), New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar, 30, "apellidos"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20, "nombre"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 8, "nacimiento"), New System.Data.SqlClient.SqlParameter("@cuenta", System.Data.SqlDbType.VarChar, 30, "cuenta"), New System.Data.SqlClient.SqlParameter("@ingreso", System.Data.SqlDbType.DateTime, 8, "ingreso"), New System.Data.SqlClient.SqlParameter("@banco", System.Data.SqlDbType.VarChar, 15, "banco"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.VarChar, 10, "celular"), New System.Data.SqlClient.SqlParameter("@sexo", System.Data.SqlDbType.TinyInt, 1, "sexo"), New System.Data.SqlClient.SqlParameter("@anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, "anualidadReconocida")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_emp, cedula, apellidos, nombre, categoria, nacimiento, cuenta, ingreso," &
    " banco, direccion, telefono, celular, sexo, anualidadReconocida FROM empleados W" &
    "HERE (id_emp = @id_emp)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 20, "cedula"), New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar, 30, "apellidos"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20, "nombre"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 8, "nacimiento"), New System.Data.SqlClient.SqlParameter("@cuenta", System.Data.SqlDbType.VarChar, 30, "cuenta"), New System.Data.SqlClient.SqlParameter("@ingreso", System.Data.SqlDbType.DateTime, 8, "ingreso"), New System.Data.SqlClient.SqlParameter("@banco", System.Data.SqlDbType.VarChar, 15, "banco"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.VarChar, 10, "celular"), New System.Data.SqlClient.SqlParameter("@sexo", System.Data.SqlDbType.TinyInt, 1, "sexo"), New System.Data.SqlClient.SqlParameter("@anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, "anualidadReconocida"), New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidadReconocida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellidos", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellidos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_banco", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cuenta", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sexo", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing)})
        '
        'Ds2planilla1
        '
        Me.Ds2planilla1.DataSetName = "ds2planilla"
        Me.Ds2planilla1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.Ds2planilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DvContratos
        '
        Me.DvContratos.AllowNew = False
        Me.DvContratos.Sort = "id_contrato DESC"
        Me.DvContratos.Table = Me.Ds2planilla1.contratos
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "categorias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_cat", "id_cat"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("salario_base", "salario_base"), New System.Data.Common.DataColumnMapping("anualidad", "anualidad")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM [categorias] WHERE (([id_cat] = @Original_id_cat) AND ([nombre] = @Or" &
    "iginal_nombre) AND ([salario_base] = @Original_salario_base) AND ([anualidad] = " &
    "@Original_anualidad))"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_cat", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_salario_base", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "salario_base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_anualidad", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidad", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection2
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@salario_base", System.Data.SqlDbType.Money, 0, "salario_base"), New System.Data.SqlClient.SqlParameter("@anualidad", System.Data.SqlDbType.Money, 0, "anualidad")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_cat, nombre, salario_base, anualidad FROM categorias"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@salario_base", System.Data.SqlDbType.Money, 0, "salario_base"), New System.Data.SqlClient.SqlParameter("@anualidad", System.Data.SqlDbType.Money, 0, "anualidad"), New System.Data.SqlClient.SqlParameter("@Original_id_cat", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_salario_base", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "salario_base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_anualidad", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_cat", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cat", System.Data.DataRowVersion.Current, Nothing)})
        '
        'BorraPuesto
        '
        Me.BorraPuesto.CommandText = "DELETE FROM puesto_empleado WHERE (id_puesto = @id_puesto) AND (id_emp = @id_emp)" &
    ""
        Me.BorraPuesto.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_puesto", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_puesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Puestos
        '
        Me.Puestos.CommandText = "SELECT COUNT(id_puesto) AS Expr1 FROM puesto_empleado GROUP BY id_emp HAVING (id_" &
    "emp = @id_emp)"
        Me.Puestos.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.DeleteCommand = Me.SqlDeleteCommand3
        Me.SqlDataAdapter3.InsertCommand = Me.SqlInsertCommand3
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "rubros", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_rubro", "id_rubro"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("categoria", "categoria"), New System.Data.Common.DataColumnMapping("formula", "formula")})})
        Me.SqlDataAdapter3.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_formula", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "formula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO rubros(nombre, categoria, formula) VALUES (@nombre, @categoria, @form" &
    "ula); SELECT id_rubro, nombre, categoria, formula FROM rubros WHERE (id_rubro = " &
    "@@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection2
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.VarChar, 15, "categoria"), New System.Data.SqlClient.SqlParameter("@formula", System.Data.SqlDbType.VarChar, 100, "formula")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT id_rubro, nombre, categoria, formula FROM rubros"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.VarChar, 15, "categoria"), New System.Data.SqlClient.SqlParameter("@formula", System.Data.SqlDbType.VarChar, 100, "formula"), New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_formula", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "formula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.DeleteCommand = Me.SqlDeleteCommand4
        Me.SqlDataAdapter4.InsertCommand = Me.SqlInsertCommand4
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "perfil_rubros", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        Me.SqlDataAdapter4.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM perfil_rubros WHERE (id = @Original_id) AND (nombre = @Original_nombr" &
    "e)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO perfil_rubros(nombre) VALUES (@nombre); SELECT id, nombre FROM perfil" &
    "_rubros WHERE (id = @@IDENTITY)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection2
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT id, nombre FROM perfil_rubros"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE perfil_rubros SET nombre = @nombre WHERE (id = @Original_id) AND (nombre =" &
    " @Original_nombre); SELECT id, nombre FROM perfil_rubros WHERE (id = @id)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDataAdapter5
        '
        Me.SqlDataAdapter5.DeleteCommand = Me.SqlDeleteCommand5
        Me.SqlDataAdapter5.InsertCommand = Me.SqlInsertCommand5
        Me.SqlDataAdapter5.SelectCommand = Me.SqlSelectCommand5
        Me.SqlDataAdapter5.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "empleado_rubro", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("id_rubro", "id_rubro"), New System.Data.Common.DataColumnMapping("id_contrato", "id_contrato")})})
        Me.SqlDataAdapter5.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM empleado_rubro WHERE (id = @Original_id) AND (id_contrato = @Original" &
    "_id_contrato) AND (id_rubro = @Original_id_rubro)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_contrato", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO empleado_rubro(id_rubro, id_contrato) VALUES (@id_rubro, @id_contrato" &
    "); SELECT id, id_rubro, id_contrato FROM empleado_rubro WHERE (id = @@IDENTITY)"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection2
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_contrato", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT id, id_rubro, id_contrato FROM empleado_rubro WHERE (id_contrato = @id_con" &
    "trato)"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection2
        Me.SqlSelectCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_contrato", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_contrato", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_contrato", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Current, Nothing)})
        '
        'Contratos
        '
        Me.Contratos.SelectCommand = Me.SqlSelectCommand6
        Me.Contratos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "categorias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_contrato", "id_contrato"), New System.Data.Common.DataColumnMapping("fecha_ini", "fecha_ini"), New System.Data.Common.DataColumnMapping("fecha_fin", "fecha_fin"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("NombCat", "NombCat"), New System.Data.Common.DataColumnMapping("DiasVigente", "DiasVigente"), New System.Data.Common.DataColumnMapping("recargo", "recargo"), New System.Data.Common.DataColumnMapping("estado", "estado"), New System.Data.Common.DataColumnMapping("id_categoria", "id_categoria")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = resources.GetString("SqlSelectCommand6.CommandText")
        Me.SqlSelectCommand6.Connection = Me.SqlConnection2
        Me.SqlSelectCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing)})
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SqlDataAdapter6
        '
        Me.SqlDataAdapter6.DeleteCommand = Me.SqlDeleteCommand6
        Me.SqlDataAdapter6.InsertCommand = Me.SqlInsertCommand6
        Me.SqlDataAdapter6.SelectCommand = Me.SqlSelectCommand7
        Me.SqlDataAdapter6.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "contratos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_puesto", "id_puesto"), New System.Data.Common.DataColumnMapping("id_emp", "id_emp"), New System.Data.Common.DataColumnMapping("fecha_ini", "fecha_ini"), New System.Data.Common.DataColumnMapping("fecha_fin", "fecha_fin"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("id_categoria", "id_categoria"), New System.Data.Common.DataColumnMapping("id_contrato", "id_contrato")})})
        Me.SqlDataAdapter6.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "[ContratoDelete]"
        Me.SqlDeleteCommand6.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_contrato", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_fin", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_ini", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_ini", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_puesto", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_puesto", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "[ContratoInsert]"
        Me.SqlInsertCommand6.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlInsertCommand6.Connection = Me.SqlConnection2
        Me.SqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_puesto", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_puesto", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@fecha_ini", System.Data.SqlDbType.DateTime, 4, "fecha_ini"), New System.Data.SqlClient.SqlParameter("@fecha_fin", System.Data.SqlDbType.DateTime, 4, "fecha_fin"), New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_categoria", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "[ContratoSelect]"
        Me.SqlSelectCommand7.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand7.Connection = Me.SqlConnection2
        Me.SqlSelectCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "[ContratoUpdate]"
        Me.SqlUpdateCommand6.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_puesto", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_puesto", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@fecha_ini", System.Data.SqlDbType.DateTime, 4, "fecha_ini"), New System.Data.SqlClient.SqlParameter("@fecha_fin", System.Data.SqlDbType.DateTime, 4, "fecha_fin"), New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_categoria", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_contrato", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_fin", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_ini", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_ini", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_puesto", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_puesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_contrato", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Current, Nothing)})
        '
        'TabControl2
        '
        Me.TabControl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl2.CanReorderTabs = True
        Me.TabControl2.Controls.Add(Me.TabControlPanel3)
        Me.TabControl2.Controls.Add(Me.TabControlPanel2)
        Me.TabControl2.Controls.Add(Me.TabControlPanel6)
        Me.TabControl2.Controls.Add(Me.TabControlPanel4)
        Me.TabControl2.Controls.Add(Me.TabControlPanel5)
        Me.TabControl2.Controls.Add(Me.TabControlPanel1)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.ForeColor = System.Drawing.Color.Black
        Me.TabControl2.Location = New System.Drawing.Point(265, 51)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(536, 325)
        Me.TabControl2.Style = DevComponents.DotNetBar.eTabStripStyle.Metro
        Me.TabControl2.TabIndex = 4
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.TabItem2)
        Me.TabControl2.Tabs.Add(Me.TabItem1)
        Me.TabControl2.Tabs.Add(Me.TabItem3)
        Me.TabControl2.Tabs.Add(Me.TabItem4)
        Me.TabControl2.Tabs.Add(Me.TabItem5)
        Me.TabControl2.Tabs.Add(Me.TabItem6)
        Me.TabControl2.Text = "TabControl2"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.AutoScroll = True
        Me.TabControlPanel3.Controls.Add(Me.PanelEx1)
        Me.TabControlPanel3.Controls.Add(Me.ContratosDataGridViewX)
        Me.TabControlPanel3.Controls.Add(Me.ButtonX3)
        Me.TabControlPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(536, 298)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabItem3
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.MonedaTextBox2)
        Me.PanelEx1.Controls.Add(Me.Label21)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.ExpandablePanel1)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.Label18)
        Me.PanelEx1.Controls.Add(Me.TextBox9)
        Me.PanelEx1.Controls.Add(Me.DateTimePicker4)
        Me.PanelEx1.Controls.Add(Me.Label19)
        Me.PanelEx1.Controls.Add(Me.DateTimePicker3)
        Me.PanelEx1.Controls.Add(Me.MonedaTextBox1)
        Me.PanelEx1.Controls.Add(Me.Label15)
        Me.PanelEx1.Controls.Add(Me.ComboBox2)
        Me.PanelEx1.Controls.Add(Me.Label16)
        Me.PanelEx1.Controls.Add(Me.Label17)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(108, 67)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(402, 219)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 32
        Me.PanelEx1.Visible = False
        '
        'MonedaTextBox2
        '
        Me.MonedaTextBox2.BackColor = System.Drawing.Color.White
        Me.MonedaTextBox2.ForeColor = System.Drawing.Color.Black
        Me.MonedaTextBox2.FormatoText = Planilla.MonedaTextBox.formatos.Numero
        Me.MonedaTextBox2.Location = New System.Drawing.Point(106, 133)
        Me.MonedaTextBox2.Name = "MonedaTextBox2"
        Me.MonedaTextBox2.Size = New System.Drawing.Size(85, 20)
        Me.MonedaTextBox2.TabIndex = 37
        Me.MonedaTextBox2.Text = "0.00"
        Me.MonedaTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(7, 136)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 16)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Recargo"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(106, 186)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(85, 26)
        Me.ButtonX1.TabIndex = 36
        Me.ButtonX1.Text = "Contratar"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel1.Controls.Add(Me.TreeViewSQL1)
        Me.ExpandablePanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.ExpandablePanel1.Location = New System.Drawing.Point(197, 29)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(167, 183)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 35
        Me.ExpandablePanel1.Text = "Puesto"
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Planilla y  Puesto"
        '
        'TreeViewSQL1
        '
        Me.TreeViewSQL1.BackColor = System.Drawing.Color.White
        Me.TreeViewSQL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewSQL1.Etiquetas = "Planillas,,,"
        Me.TreeViewSQL1.ForeColor = System.Drawing.Color.Black
        Me.TreeViewSQL1.InstruccionSQL = Me.Sqltree
        Me.TreeViewSQL1.Location = New System.Drawing.Point(0, 26)
        Me.TreeViewSQL1.Name = "TreeViewSQL1"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = ""
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "Planillas"
        Me.TreeViewSQL1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TreeViewSQL1.Size = New System.Drawing.Size(167, 157)
        Me.TreeViewSQL1.TabIndex = 33
        '
        'Sqltree
        '
        Me.Sqltree.CommandText = resources.GetString("Sqltree.CommandText")
        Me.Sqltree.Connection = Me.SqlConnection2
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(402, 28)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 28
        Me.PanelEx2.Text = "CONTRATO"
        '
        'Label18
        '
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(26, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Fecha Inicio"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.categoria", True))
        Me.TextBox9.ForeColor = System.Drawing.Color.Black
        Me.TextBox9.Location = New System.Drawing.Point(106, 31)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(85, 20)
        Me.TextBox9.TabIndex = 0
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker4.ForeColor = System.Drawing.Color.Black
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(106, 55)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(85, 20)
        Me.DateTimePicker4.TabIndex = 1
        Me.DateTimePicker4.Value = New Date(2015, 2, 1, 0, 0, 0, 0)
        '
        'Label19
        '
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(26, 159)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 16)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Categoria"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker3.ForeColor = System.Drawing.Color.Black
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(106, 81)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(85, 20)
        Me.DateTimePicker3.TabIndex = 2
        Me.DateTimePicker3.Value = New Date(2015, 2, 1, 0, 0, 0, 0)
        '
        'MonedaTextBox1
        '
        Me.MonedaTextBox1.BackColor = System.Drawing.Color.White
        Me.MonedaTextBox1.ForeColor = System.Drawing.Color.Black
        Me.MonedaTextBox1.FormatoText = Planilla.MonedaTextBox.formatos.Numero
        Me.MonedaTextBox1.Location = New System.Drawing.Point(106, 107)
        Me.MonedaTextBox1.Name = "MonedaTextBox1"
        Me.MonedaTextBox1.Size = New System.Drawing.Size(85, 20)
        Me.MonedaTextBox1.TabIndex = 3
        Me.MonedaTextBox1.Text = "0.00"
        Me.MonedaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(7, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 16)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Horas o lecciones "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox2.DataSource = Me.Ds2planilla1.categorias
        Me.ComboBox2.DisplayMember = "nombre"
        Me.ComboBox2.ForeColor = System.Drawing.Color.Black
        Me.ComboBox2.Location = New System.Drawing.Point(106, 159)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(85, 21)
        Me.ComboBox2.TabIndex = 4
        Me.ComboBox2.ValueMember = "id_cat"
        '
        'Label16
        '
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(26, 81)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 16)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Fecha Fin"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(34, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Puesto"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ContratosDataGridViewX
        '
        Me.ContratosDataGridViewX.AllowUserToAddRows = False
        Me.ContratosDataGridViewX.AllowUserToDeleteRows = False
        Me.ContratosDataGridViewX.AutoGenerateColumns = False
        Me.ContratosDataGridViewX.BackgroundColor = System.Drawing.Color.White
        Me.ContratosDataGridViewX.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ContratosDataGridViewX.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ContratosDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContratosDataGridViewX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12})
        Me.ContratosDataGridViewX.DataSource = Me.ContratosBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ContratosDataGridViewX.DefaultCellStyle = DataGridViewCellStyle4
        Me.ContratosDataGridViewX.EnableHeadersVisualStyles = False
        Me.ContratosDataGridViewX.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ContratosDataGridViewX.Location = New System.Drawing.Point(0, 33)
        Me.ContratosDataGridViewX.Name = "ContratosDataGridViewX"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ContratosDataGridViewX.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.ContratosDataGridViewX.RowHeadersWidth = 25
        Me.ContratosDataGridViewX.Size = New System.Drawing.Size(526, 261)
        Me.ContratosDataGridViewX.TabIndex = 40
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "categorias"
        Me.CategoriasBindingSource.DataSource = Me.Ds2planilla1
        '
        'ContratosBindingSource
        '
        Me.ContratosBindingSource.DataMember = "contratos"
        Me.ContratosBindingSource.DataSource = Me.Ds2planilla1
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.Location = New System.Drawing.Point(11, 7)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.TabIndex = 37
        Me.ButtonX3.Text = "Nuevo"
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel3
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "Contratos"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.TabControlPanel2.Controls.Add(Me.Label1)
        Me.TabControlPanel2.Controls.Add(Me.Bar1)
        Me.TabControlPanel2.Controls.Add(Me.PictureBox2)
        Me.TabControlPanel2.Controls.Add(Me.MaskedTextBox2)
        Me.TabControlPanel2.Controls.Add(Me.MaskedTextBox1)
        Me.TabControlPanel2.Controls.Add(Me.Label7)
        Me.TabControlPanel2.Controls.Add(Me.Label6)
        Me.TabControlPanel2.Controls.Add(Me.Label5)
        Me.TabControlPanel2.Controls.Add(Me.Label4)
        Me.TabControlPanel2.Controls.Add(Me.Label3)
        Me.TabControlPanel2.Controls.Add(Me.GroupBox1)
        Me.TabControlPanel2.Controls.Add(Me.TextBox5)
        Me.TabControlPanel2.Controls.Add(Me.DateTimePicker1)
        Me.TabControlPanel2.Controls.Add(Me.TextBox3)
        Me.TabControlPanel2.Controls.Add(Me.TextBox2)
        Me.TabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(536, 298)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Cédula o DIMEX"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.ButtonItem3})
        Me.Bar1.Location = New System.Drawing.Point(1, 269)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(534, 28)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.Bar1.TabIndex = 33
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Stretch = True
        Me.ButtonItem1.Symbol = ""
        Me.ButtonItem1.SymbolSize = 8.0!
        Me.ButtonItem1.Text = "Const.Salario"
        Me.ButtonItem1.Tooltip = "Constancia de Salario"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Stretch = True
        Me.ButtonItem3.Symbol = ""
        Me.ButtonItem3.SymbolSize = 8.0!
        Me.ButtonItem3.Text = "Const.Salario Detallada"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EmpleadosBindingSource, "foto", True))
        Me.PictureBox2.ForeColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(234, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(158, 199)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "empleados"
        Me.EmpleadosBindingSource.DataSource = Me.Ds2planilla1
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.BackColor = System.Drawing.Color.White
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.cuenta", True))
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox2.ForeColor = System.Drawing.Color.Black
        Me.MaskedTextBox2.Location = New System.Drawing.Point(92, 89)
        Me.MaskedTextBox2.Mask = "000-00-000-000000-0"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(128, 21)
        Me.MaskedTextBox2.TabIndex = 3
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.White
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.cedula", True))
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.ForeColor = System.Drawing.Color.Black
        Me.MaskedTextBox1.Location = New System.Drawing.Point(92, 20)
        Me.MaskedTextBox1.Mask = "00-0000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(128, 21)
        Me.MaskedTextBox1.TabIndex = 0
        Me.SuperValidator1.SetValidator1(Me.MaskedTextBox1, Me.CustomValidator1)
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(20, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Nacimiento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(20, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Banco"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(20, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Cuenta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(20, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nombre"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Apellidos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.sexo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(92, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 77)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'RadioButton2
        '
        Me.RadioButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(3, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(98, 23)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Femenino"
        '
        'RadioButton1
        '
        Me.RadioButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(3, 17)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(98, 23)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Masculino"
        '
        'sexo
        '
        Me.sexo.BackColor = System.Drawing.Color.White
        Me.sexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.sexo", True))
        Me.sexo.ForeColor = System.Drawing.Color.Black
        Me.sexo.Location = New System.Drawing.Point(6, 19)
        Me.sexo.Name = "sexo"
        Me.sexo.Size = New System.Drawing.Size(92, 21)
        Me.sexo.TabIndex = 24
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.banco", True))
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.Black
        Me.TextBox5.Location = New System.Drawing.Point(92, 115)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(128, 21)
        Me.TextBox5.TabIndex = 4
        Me.TextBox5.Text = "TEXTBOX5"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.nacimiento", True))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(92, 139)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 21)
        Me.DateTimePicker1.TabIndex = 5
        Me.DateTimePicker1.Value = New Date(2007, 2, 8, 0, 0, 0, 0)
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.nombre", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(92, 65)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(128, 21)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "TEXTBOX3"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.apellidos", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(92, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 21)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "TEXTBOX2"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Personal"
        '
        'TabControlPanel6
        '
        Me.TabControlPanel6.Controls.Add(Me.UcVacaciones1)
        Me.TabControlPanel6.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel6.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel6.Name = "TabControlPanel6"
        Me.TabControlPanel6.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel6.Size = New System.Drawing.Size(536, 298)
        Me.TabControlPanel6.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel6.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel6.Style.GradientAngle = 90
        Me.TabControlPanel6.TabIndex = 19
        Me.TabControlPanel6.TabItem = Me.TabItem6
        '
        'UcVacaciones1
        '
        Me.UcVacaciones1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.UcVacaciones1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcVacaciones1.Location = New System.Drawing.Point(1, 1)
        Me.UcVacaciones1.Name = "UcVacaciones1"
        Me.UcVacaciones1.Size = New System.Drawing.Size(534, 296)
        Me.UcVacaciones1.TabIndex = 0
        '
        'TabItem6
        '
        Me.TabItem6.AttachedControl = Me.TabControlPanel6
        Me.TabItem6.Name = "TabItem6"
        Me.TabItem6.Text = "Vacaciones"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.TextBoxX1)
        Me.TabControlPanel4.Controls.Add(Me.Label20)
        Me.TabControlPanel4.Controls.Add(Me.ComboBoxEx1)
        Me.TabControlPanel4.Controls.Add(Me.PictureBox1)
        Me.TabControlPanel4.Controls.Add(Me.CheckedListBox1)
        Me.TabControlPanel4.Controls.Add(Me.Label14)
        Me.TabControlPanel4.Controls.Add(Me.Label13)
        Me.TabControlPanel4.Controls.Add(Me.ListBox1)
        Me.TabControlPanel4.Controls.Add(Me.Label12)
        Me.TabControlPanel4.Controls.Add(Me.NumericUpDown1)
        Me.TabControlPanel4.Controls.Add(Me.Label8)
        Me.TabControlPanel4.Controls.Add(Me.Label2)
        Me.TabControlPanel4.Controls.Add(Me.DateTimePicker2)
        Me.TabControlPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(536, 298)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 4
        Me.TabControlPanel4.TabItem = Me.TabItem4
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DvContratos, "NombCat", True))
        Me.TextBoxX1.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(88, 37)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxX1.TabIndex = 37
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(16, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 17)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Contrato"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DataSource = Me.DvContratos
        Me.ComboBoxEx1.DisplayMember = "id_contrato"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 14
        Me.ComboBoxEx1.Location = New System.Drawing.Point(88, 9)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(100, 20)
        Me.ComboBoxEx1.TabIndex = 35
        Me.ComboBoxEx1.ValueMember = "id_contrato"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(200, 141)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckedListBox1.Location = New System.Drawing.Point(242, 6)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(210, 244)
        Me.CheckedListBox1.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(8, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 32)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Perfiles de rebajos"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(197, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 16)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Rubros"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListBox1.ForeColor = System.Drawing.Color.Black
        Me.ListBox1.Location = New System.Drawing.Point(88, 110)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(104, 134)
        Me.ListBox1.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(16, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 18)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Anualidad Reconocidas"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.White
        Me.NumericUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Ds2planilla1, "empleados.anualidadReconocida", True))
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.Black
        Me.NumericUpDown1.Location = New System.Drawing.Point(88, 83)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(100, 20)
        Me.NumericUpDown1.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(0, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Fecha Ingreso"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Categoria"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.ingreso", True))
        Me.DateTimePicker2.ForeColor = System.Drawing.Color.Black
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(88, 60)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 25
        '
        'TabItem4
        '
        Me.TabItem4.AttachedControl = Me.TabControlPanel4
        Me.TabItem4.Name = "TabItem4"
        Me.TabItem4.Text = "Rubros"
        '
        'TabControlPanel5
        '
        Me.TabControlPanel5.Controls.Add(Me.CPagos1)
        Me.TabControlPanel5.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel5.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel5.Name = "TabControlPanel5"
        Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel5.Size = New System.Drawing.Size(536, 298)
        Me.TabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel5.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel5.Style.GradientAngle = 90
        Me.TabControlPanel5.TabIndex = 5
        Me.TabControlPanel5.TabItem = Me.TabItem5
        '
        'CPagos1
        '
        Me.CPagos1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CPagos1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPagos1.ForeColor = System.Drawing.Color.Black
        Me.CPagos1.Location = New System.Drawing.Point(1, 1)
        Me.CPagos1.Name = "CPagos1"
        Me.CPagos1.Size = New System.Drawing.Size(534, 296)
        Me.CPagos1.TabIndex = 0
        '
        'TabItem5
        '
        Me.TabItem5.AttachedControl = Me.TabControlPanel5
        Me.TabItem5.Name = "TabItem5"
        Me.TabItem5.Text = "Pagos"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.Label11)
        Me.TabControlPanel1.Controls.Add(Me.Label10)
        Me.TabControlPanel1.Controls.Add(Me.Label9)
        Me.TabControlPanel1.Controls.Add(Me.TextBox8)
        Me.TabControlPanel1.Controls.Add(Me.TextBox7)
        Me.TabControlPanel1.Controls.Add(Me.TextBox6)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(536, 298)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Dirección"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Celular"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Teléfono"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.direccion", True))
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.Black
        Me.TextBox8.Location = New System.Drawing.Point(88, 74)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(184, 80)
        Me.TextBox8.TabIndex = 17
        Me.TextBox8.Text = "TextBox8"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.celular", True))
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.Black
        Me.TextBox7.Location = New System.Drawing.Point(88, 42)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(136, 21)
        Me.TextBox7.TabIndex = 16
        Me.TextBox7.Text = "TextBox7"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.telefono", True))
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.Black
        Me.TextBox6.Location = New System.Drawing.Point(88, 10)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(136, 21)
        Me.TextBox6.TabIndex = 15
        Me.TextBox6.Text = "TextBox6"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Localizacion"
        '
        'ContratoscategoriasBindingSource
        '
        Me.ContratoscategoriasBindingSource.DataMember = "contratos_categorias"
        Me.ContratoscategoriasBindingSource.DataSource = Me.ContratosBindingSource
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Certifi..."
        '
        'ComboBoxItem1
        '
        Me.ComboBoxItem1.DropDownHeight = 106
        Me.ComboBoxItem1.ItemHeight = 17
        Me.ComboBoxItem1.Name = "ComboBoxItem1"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx3.Location = New System.Drawing.Point(265, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(536, 25)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 6
        '
        'Contratos2
        '
        Me.Contratos2.DeleteCommand = Me.SqlDeleteCommand
        Me.Contratos2.SelectCommand = Me.SqlCommand1
        Me.Contratos2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "contratos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_contrato", "id_contrato"), New System.Data.Common.DataColumnMapping("fecha_ini", "fecha_ini"), New System.Data.Common.DataColumnMapping("fecha_fin", "fecha_fin"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("recargo", "recargo"), New System.Data.Common.DataColumnMapping("estado", "estado"), New System.Data.Common.DataColumnMapping("id_categoria", "id_categoria")})})
        Me.Contratos2.UpdateCommand = Me.SqlUpdateCommand
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.CommandText = resources.GetString("SqlDeleteCommand.CommandText")
        Me.SqlDeleteCommand.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_contrato", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_fecha_ini", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "fecha_ini", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_fecha_ini", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_ini", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_fecha_fin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_fecha_fin", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cantidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_recargo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "recargo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_recargo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "recargo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_estado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_categoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_categoria", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_categoria", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_categoria", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT     id_contrato, fecha_ini, fecha_fin, cantidad, recargo, estado, id_categ" &
    "oria" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM        contratos"
        Me.SqlCommand1.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
        Me.SqlUpdateCommand.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@fecha_ini", System.Data.SqlDbType.DateTime, 8, "fecha_ini"), New System.Data.SqlClient.SqlParameter("@fecha_fin", System.Data.SqlDbType.DateTime, 8, "fecha_fin"), New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@recargo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "recargo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.VarChar, 1, "estado"), New System.Data.SqlClient.SqlParameter("@id_categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_categoria", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_contrato", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_fecha_ini", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "fecha_ini", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_fecha_ini", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_ini", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_fecha_fin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_fecha_fin", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cantidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_recargo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "recargo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_recargo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "recargo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_estado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_categoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_categoria", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_categoria", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_contrato", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Original, Nothing)})
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SuperValidator1
        '
        Me.SuperValidator1.ContainerControl = Me
        Me.SuperValidator1.ErrorProvider = Me.ErrorProvider2
        Me.SuperValidator1.Highlighter = Me.Highlighter1
        Me.SuperValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl
        '
        'CustomValidator1
        '
        Me.CustomValidator1.ErrorMessage = "Longitud = 12 ; Inicie con 0 = Nacional (05-0269-0349) o DIMEX (12345678901) "
        Me.CustomValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'UserControl21
        '
        Me.UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.UserControl21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserControl21.ForeColor = System.Drawing.Color.Black
        Me.UserControl21.Location = New System.Drawing.Point(265, 25)
        Me.UserControl21.Name = "UserControl21"
        Me.UserControl21.Size = New System.Drawing.Size(536, 26)
        Me.UserControl21.TabIndex = 2
        '
        'BEmpleado1
        '
        Me.BEmpleado1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BEmpleado1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BEmpleado1.ForeColor = System.Drawing.Color.Black
        Me.BEmpleado1.Location = New System.Drawing.Point(0, 0)
        Me.BEmpleado1.Name = "BEmpleado1"
        Me.BEmpleado1.Size = New System.Drawing.Size(265, 376)
        Me.BEmpleado1.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_contrato"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Contrato"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        '
        '
        '
        Me.DataGridViewTextBoxColumn2.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.DataGridViewTextBoxColumn2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewTextBoxColumn2.ButtonDropDown.Visible = True
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha_ini"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Inicio"
        Me.DataGridViewTextBoxColumn2.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        '
        '
        '
        Me.DataGridViewTextBoxColumn2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewTextBoxColumn2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.DataGridViewTextBoxColumn2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewTextBoxColumn2.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.DataGridViewTextBoxColumn2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.Width = 77
        '
        'DataGridViewTextBoxColumn3
        '
        '
        '
        '
        Me.DataGridViewTextBoxColumn3.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.DataGridViewTextBoxColumn3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewTextBoxColumn3.ButtonDropDown.Visible = True
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fecha_fin"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fin"
        Me.DataGridViewTextBoxColumn3.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        '
        '
        '
        Me.DataGridViewTextBoxColumn3.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewTextBoxColumn3.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.DataGridViewTextBoxColumn3.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewTextBoxColumn3.MonthCalendar.DisplayMonth = New Date(2016, 5, 1, 0, 0, 0, 0)
        '
        '
        '
        Me.DataGridViewTextBoxColumn3.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.Width = 77
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "recargo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Recargo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DiasVigente"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "Vigente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "id_categoria"
        Me.DataGridViewTextBoxColumn10.DataSource = Me.CategoriasBindingSource
        Me.DataGridViewTextBoxColumn10.DisplayMember = "nombre"
        Me.DataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewTextBoxColumn10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DataGridViewTextBoxColumn10.HeaderText = "Categoría"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn10.ValueMember = "id_cat"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 45
        '
        'frmContrato
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.UserControl21)
        Me.Controls.Add(Me.PanelEx3)
        Me.Controls.Add(Me.BEmpleado1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmContrato"
        CType(Me.Ds2planilla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ExpandablePanel1.ResumeLayout(False)
        CType(Me.ContratosDataGridViewX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        Me.TabControlPanel2.PerformLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControlPanel6.ResumeLayout(False)
        Me.TabControlPanel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel5.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.ContratoscategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Sub borrar()
        Try
            If Me.DvContratos.Count = 0 Then

                Me.BindingContext(Ds2planilla1, "empleados").CancelCurrentEdit()
                Me.BindingContext(Ds2planilla1, "empleados").RemoveAt(Me.BindingContext(Ds2planilla1, "empleados").Position)

                Me.SqlDataAdapter1.Update(Ds2planilla1, "empleados")

                Me.BEmpleado1.refresca()
            Else
                MessageBoxEx.Show("Este empleado tiene contratos " & vbCrLf & "y no puede ser borrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmContrato_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Me.DesignMode Then
            EmpleadosTableAdapter.Connection.ConnectionString = conn.strConn
            Me.EmpleadosTableAdapter.Fill(Me.Ds2planilla1.empleados)
            Try
                ' Me.UserControl21.NuevoToolStripButton.Visible = False
                ' Me.UserControl21.AbrirToolStripButton.Visible = False
                ' Me.UserControl21.AyudaToolStripButton.Visible = False
                Me.UserControl21.Imprimir.Visible = False

                conn.bd = "planilla"
                Me.SqlConnection2.ConnectionString = conn.strConn

                SqlDataAdapter2.Fill(Ds2planilla1, "categorias")
                SqlDataAdapter3.Fill(Ds2planilla1, "rubros")
                SqlDataAdapter4.Fill(Ds2planilla1, "perfil_rubros")


                clista.DatosLista(Me.Ds2planilla1.Tables("perfil_rubros"), Me.ListBox1, "id", "nombre")
                clista.DatosLista(Me.Ds2planilla1.Tables("rubros"), Me.CheckedListBox1, "id_rubro", "nombre")
                cargado = True

                If id_emp = "" Then
                    Me.BindingContext(Ds2planilla1, "empleados").CancelCurrentEdit()
                    Me.BindingContext(Ds2planilla1, "empleados").AddNew()
                    nuevor = True
                    MaskedTextBox1.Focus()
                Else
                    nuevor = False
                    busca(id_emp)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Sub guardar()
        Try
            Dim tmpNombre As String = TextBox2.Text & " " & Me.TextBox3.Text

            Dim nuevoReg As DataRowView = BindingContext(Ds2planilla1, "empleados").Current
            Me.BindingContext(Ds2planilla1, "empleados").EndCurrentEdit()
            'Me.EmpleadosTableAdapter.Update(ds2planilla1.empleados)
            Me.SqlDataAdapter1.Update(Ds2planilla1, "empleados")
            'Me.SqlDataAdapter5.Update(Ds2planilla1, "empleado_rubro")  'modificado el 3-jul-2015 descativado por que al presionar varias veces guardar iserta el rubro varias veces

            Me.Validate()
            Me.ContratosBindingSource.EndEdit()
            Me.Contratos2.Update(Ds2planilla1.contratos)

            If Ds2planilla1.HasChanges Then

            End If

            ' If nuevor Then
            ' Me.id_emp = nuevoReg.Row.ItemArray(0)
            ' Dim inst As String = "insert contratos(id_puesto,id_emp) values(" & Me.id_pto & "," & Me.id_emp & ")"
            ' conn.ejecuta(inst)
            ' End If
            'Me.Close()
            Me.id_emp = Me.Ds2planilla1.empleados.Item(0).id_emp

            If nuevor Then
                Me.BEmpleado1.refresca()
                BEmpleado1.busca(tmpNombre)
                nuevor = False
            End If

            cargarContratos(id_emp)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub nuevo()
        Me.PanelEx3.Text = ""
        Me.BindingContext(Ds2planilla1, "empleados").CancelCurrentEdit()
        Me.BindingContext(Ds2planilla1, "empleados").AddNew()
        nuevor = True
        MaskedTextBox1.Focus()
    End Sub
    Sub busca(ByVal pvalor As String)
        Try
            Dim lista As ArrayList

            Me.Ds2planilla1.Tables("empleado_rubro").Clear()
            Me.Ds2planilla1.Tables("empleados").Clear()

            lista = conn.llena("select id_emp from contratos where id_contrato = " & pvalor)
            id_contrato = pvalor
            id_emp = lista(0)(0)

            Me.SqlDataAdapter1.SelectCommand.Parameters.Item("@id_emp").Value = id_emp
            Me.SqlDataAdapter5.SelectCommand.Parameters.Item("@id_contrato").Value = pvalor
            Me.SqlDataAdapter1.Fill(Ds2planilla1)
            Me.SqlDataAdapter5.Fill(Ds2planilla1)
            Me.PanelEx3.Text = Me.TextBox2.Text & " " & Me.TextBox3.Text

            cargado = False
            Dim dvLista As DataView = Ds2planilla1.Tables("empleado_rubro").DefaultView
            clista.MarcarLista(dvLista, Me.CheckedListBox1, 1)

            cargarContratos(id_emp)   ' carga los contratos
            cargado = True
            nuevor = False
        Catch ex As Exception
            MessageBox.Show("BUSCA : " & ex.Message)
        End Try
    End Sub

    Sub buscaEmpleado(ByVal pvalor As String)
        Try
            'Dim lista As ArrayList
            Me.Ds2planilla1.Tables("empleado_rubro").Clear()
            Me.Ds2planilla1.Tables("empleados").Clear()
            'lista = conn.llena("select id_emp from contratos where id_contrato = " & pvalor)
            'id_contrato = pvalor
            'id_emp = lista(0)(0)

            id_emp = pvalor
            cargarContratos(id_emp)   ' carga los contratos

            Me.SqlDataAdapter1.SelectCommand.Parameters.Item("@id_emp").Value = id_emp
            Me.SqlDataAdapter1.Fill(Ds2planilla1)

            Me.PanelEx3.Text = Me.TextBox2.Text & " " & Me.TextBox3.Text

            If id_contrato <> "" Then
                Me.SqlDataAdapter5.SelectCommand.Parameters.Item("@id_contrato").Value = id_contrato
                Me.SqlDataAdapter5.Fill(Ds2planilla1)

                cargado = False
                Dim dvLista As DataView = Ds2planilla1.Tables("empleado_rubro").DefaultView
                clista.MarcarLista(dvLista, Me.CheckedListBox1, 1)
                cargado = True
                nuevor = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub sexo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sexo.TextChanged

        If sexo.Text = "0" Then
            Me.RadioButton1.Checked = True
        Else
            Me.RadioButton2.Checked = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.sexo.Text = IIf(RadioButton1.Checked, "0", "1")
    End Sub

    Private Sub cargarContratos(ByVal pid_emp As Integer)
        Me.id_contrato = ""
        Me.Contratos.SelectCommand.Parameters("@id_emp").Value = pid_emp
        Me.Ds2planilla1.contratos.Clear()
        If Me.Contratos.Fill(Me.Ds2planilla1, "contratos") > 0 Then
            Me.id_contrato = Me.Ds2planilla1.contratos.Rows(0).Item("id_contrato").ToString
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ' asigna los rubros de un PERFIL al empleado 
        If Me.ComboBoxEx1.SelectedIndex >= 0 Then
            Dim cmd As String = "exec crea_rubros_empleado " & id_contrato & " , " & ListBox1.SelectedItem.codigo
            conn.ejecuta(cmd)
            ' busca(Me.id_contrato)
            actualiza_rubros(id_contrato)
        Else
            MessageBoxEx.Show("Cree o seleccione un contrato para asignar rubros", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub CheckedListBox1_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        ' asigna una rubro personalizado para cada empleado 
        If cargado Then
            If e.NewValue = CheckState.Checked Then
                Dim inst As String
                inst = "insert empleado_rubro(id_contrato,id_rubro) values(" & Me.id_contrato & "," & Me.CheckedListBox1.Items(e.Index).codigo & ")"
                conn.ejecuta(inst)
            Else
                Dim inst As String
                inst = "delete from empleado_rubro  where id_contrato = " & Me.id_contrato & " and id_rubro = " & Me.CheckedListBox1.Items(e.Index).codigo
                conn.ejecuta(inst)
            End If
        End If
    End Sub


    Function In_rango_fecha(ByVal lista As ArrayList, ByVal fini As Date, ByVal ffin As Date) As Boolean

        Dim bien As Boolean = False

        If lista IsNot Nothing Then
            Dim pos As Integer = lista.Count - 1
            Dim lini, lfin As Date

            While (Not bien) And (pos >= 0)
                lini = lista(pos)(0)
                lfin = lista(pos)(1)

                If fini >= lini And fini <= lfin Then
                    bien = True
                End If
                If ffin >= lini And ffin <= lfin Then
                    bien = True
                End If
                pos -= 1
            End While
        End If

        Return bien
    End Function

    Private Sub MonedaTextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MonedaTextBox1.Validating
        validad_cantidad()
    End Sub

    Function validad_cantidad() As Boolean
        If CInt(Me.MonedaTextBox1.Text) <= 0 Then
            ErrorProvider1.SetError(Me.MonedaTextBox1, "Debe tener un valor")
            Return True
        Else
            ErrorProvider1.SetError(Me.MonedaTextBox1, "")
            Return False
        End If
    End Function

    Private Sub DateTimePicker3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateTimePicker3.Validating
        If DateTimePicker3.Value < DateTimePicker4.Value Then
            ErrorProvider1.SetError(Me.DateTimePicker3, "Fecha final deber ser mayor que la de inicio")
        Else
            ErrorProvider1.SetError(Me.DateTimePicker3, "")
        End If
    End Sub

    Private Sub TabControl2_SelectedTabChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles TabControl2.SelectedTabChanged
        Select Case TabControl2.SelectedTabIndex
            Case 3
                cargado = False
                Dim dvLista As DataView = Ds2planilla1.Tables("empleado_rubro").DefaultView
                clista.MarcarLista(dvLista, Me.CheckedListBox1, 1)
                cargado = True
        End Select
    End Sub
    '****************
    '*
    '*
    '****************
    Private Sub BEmpleado1_selecionado(ByVal sender As Object, ByVal e As SeleccionadoEventArgs) Handles BEmpleado1.selecionado
        If e.Valor IsNot Nothing Then
            Me.buscaEmpleado(e.Valor)
            Me.CPagos1.buscar(e.Valor)
            Me.UcVacaciones1.buscar(e.Valor)
        End If
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        If ComboBoxEx1.SelectedValue IsNot Nothing Then
            Me.id_contrato = CStr(ComboBoxEx1.SelectedValue)
            Dim pvalor As String = Me.id_contrato

            Me.Ds2planilla1.Tables("empleado_rubro").Clear()
            Me.Ds2planilla1.Tables("empleados").Clear()

            Me.SqlDataAdapter1.SelectCommand.Parameters.Item("@id_emp").Value = id_emp
            Me.SqlDataAdapter1.Fill(Ds2planilla1.empleados)

            Me.SqlDataAdapter5.SelectCommand.Parameters.Item("@id_contrato").Value = pvalor
            Me.SqlDataAdapter5.Fill(Ds2planilla1.empleado_rubro)

            Me.PanelEx3.Text = Me.TextBox2.Text & " " & Me.TextBox3.Text

            cargado = False
            Dim dvLista As DataView = Ds2planilla1.Tables("empleado_rubro").DefaultView
            clista.MarcarLista(dvLista, Me.CheckedListBox1, 1)
            cargado = True
        End If

    End Sub

    Sub actualiza_rubros(pvalor As String)

        Me.Ds2planilla1.Tables("empleado_rubro").Clear()
        Me.SqlDataAdapter5.SelectCommand.Parameters.Item("@id_contrato").Value = pvalor
        Me.SqlDataAdapter5.Fill(Ds2planilla1.empleado_rubro)

        cargado = False
        Dim dvLista As DataView = Ds2planilla1.Tables("empleado_rubro").DefaultView
        clista.MarcarLista(dvLista, Me.CheckedListBox1, 1)
        cargado = True
    End Sub


    Private Sub TreeViewSQL1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeViewSQL1.MouseDown
        Dim nodo As TreeNode = TreeViewSQL1.GetNodeAt(e.X, e.Y)
        TreeViewSQL1.SelectedNode = nodo
        If nodo Is Nothing Then
            Array.Clear(niveles, 0, niveles.Length)
        Else
            niveles = Me.TreeViewSQL1.ruta(nodo.FullPath)
        End If

        If niveles.Length = 3 Then
            Me.id_pto = nodo.Tag(0).ToString.Trim
            Me.TextBox9.Text = niveles(2)
        End If
    End Sub


    Private Sub PanelEx1_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PanelEx1.VisibleChanged
        If PanelEx1.Visible Then
            TreeViewSQL1.llenar("planilla")
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim lista As ArrayList = Nothing

        If id_contrato <> "" Then
            lista = conn.llena("select fecha_ini, fecha_fin from contratos where id_contrato = " & id_contrato)
        End If

        'If In_rango_fecha(lista, Me.DateTimePicker4.Value, DateTimePicker3.Value) Or validad_cantidad() Then
        ' MsgBox("Ya existe pagos en este rango " & vbCr & " ó no hay cantidad", MsgBoxStyle.Critical)
        ' Else
        Dim comando As String
        comando = "exec ContratoInsert " & id_pto & "," & id_emp & ", '" & Me.DateTimePicker4.Value.Date &
                    "' , '" & DateTimePicker3.Value.Date & "' ," & CInt(MonedaTextBox1.Text) & "," &
                    Me.ComboBox2.SelectedValue & "," & CInt(MonedaTextBox2.Text)

        conn.ejecuta(comando)
        Me.PanelEx1.Dock = DockStyle.None
        Me.PanelEx1.Visible = False
        ContratosDataGridViewX.Enabled = True

        Me.buscaEmpleado(id_emp)
        Me.TabControl2.SelectedPanel = Me.TabControlPanel4

        'End If
    End Sub

    Private Sub MaskedTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.TextChanged
        If MaskedTextBox1.Text <> "" Then

            '' Activa o desctiva boton para agregar contrato
            If MaskedTextBox1.Text = "  -    -" Then
                Me.ButtonX3.Enabled = False
            Else
                Me.ButtonX3.Enabled = True
            End If


            '' cambia el formato de nacional a DIMEX
            If MaskedTextBox1.Text.Substring(0, 1) = "0" Then
                Label1.Text = "Cédula"
                MaskedTextBox1.Mask = "00-0000-0000"
            Else
                Label1.Text = "DIMEX"
                MaskedTextBox1.Mask = "000000000000"
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            Dim DlgOpenFile As New OpenFileDialog

            DlgOpenFile.ShowReadOnly = True
            If DlgOpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.PictureBox2.Image = Image.FromFile(DlgOpenFile.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' CONSTANCIA DE SALARIO WORD
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click

        If BEmpleado1.activos Then

            Dim archivo = My.Application.Info.DirectoryPath & "\contSalario.docx"

            Dim oConfig As New cConfiguracion
            Dim conn As New conexionSQL
            Dim comando As String = "exec SalarioMesAnterior " & id_emp

            Dim datos As ArrayList = conn.llena(comando)
            If datos.Count > 0 Then

                Dim oMontos = datos(0)
                datos.Clear()
                datos = conn.llena("SELECT ContratosActivos.fecha_ini,ContratosActivos.estado,categorias.descipcion " &
                            "FROM ContratosActivos INNER JOIN categorias ON ContratosActivos.id_categoria = categorias.id_cat " &
                            "WHERE id_emp = " & id_emp)

                Dim oContrato As Object = datos(0)

                Dim valores As New ArrayList
                valores.Add({"NO", ConstanciaConsecutivo()})
                valores.Add({"suscrita", oConfig.valores(15)})
                valores.Add({"suscritaCargo", oConfig.valores(16)})
                valores.Add({"empleado", Me.TextBox3.Text & " " & TextBox2.Text})
                valores.Add({"cedula", Me.MaskedTextBox1.Text})
                valores.Add({"bruto", fMoneda(oMontos(1))})
                valores.Add({"neto", fMoneda(oMontos(0))})
                valores.Add({"estadoSalario", IIf(oContrato(1) = "L", "Libre de embargos", "Con embargo")})
                valores.Add({"dias", Num2Text(Now.Day).ToLower})
                valores.Add({"administrador", oConfig.valores(15)})
                valores.Add({"cargoAdm", oConfig.valores(16)})
                valores.Add({"puesto", oContrato(2)})
                valores.Add({"desde", oContrato(0)})
                valores.Add({"slogan", ""})

                Dim wdDoc As New cWord(archivo)  'abre plantilla
                wdDoc.SustituyeValores(valores)

                Dim guardaComo = Me.TextBox3.Text & " " & TextBox2.Text
                wdDoc.guarda(guardaComo) 'guarda como
            Else
                MsgBox("Empleado sin salario el mes anterio")
            End If

        Else
            MessageBoxEx.Show("Selecciones contratos activos", "Solo empleados activos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    ''' <summary>
    ''' CONSTANCIA DE SALARIO WORD DETALLADA
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonItem3_Click(sender As Object, e As EventArgs) Handles ButtonItem3.Click
        If BEmpleado1.activos Then

            Dim archivo = My.Application.Info.DirectoryPath & "\contSalarioDetallado.docx"

            Dim oConfig As New cConfiguracion
            Dim conn As New conexionSQL
            Dim comando As String = "exec SalarioMesAnterior " & id_emp

            Dim datos As ArrayList = conn.llena(comando)
            If datos.Count > 0 Then

                Dim oMontos = datos(0)
                datos.Clear()
                datos = conn.llena("SELECT ContratosActivos.fecha_ini,ContratosActivos.estado,categorias.descipcion " &
                            "FROM ContratosActivos INNER JOIN categorias ON ContratosActivos.id_categoria = categorias.id_cat " &
                            "WHERE id_emp = " & id_emp)


                Dim oContrato As Object = datos(0)

                Dim valores As New ArrayList
                valores.Add({"NO", ConstanciaConsecutivo()})
                valores.Add({"suscrita", oConfig.valores(15)})
                valores.Add({"suscritaCargo", oConfig.valores(16)})
                valores.Add({"empleado", Me.TextBox3.Text & " " & TextBox2.Text})
                valores.Add({"cedula", Me.MaskedTextBox1.Text})
                valores.Add({"estadoSalario", IIf(oContrato(1) = "L", "Libre de embargos", "Con embargo")})
                valores.Add({"dias", Num2Text(Now.Day).ToLower})
                valores.Add({"administrador", oConfig.valores(15)})
                valores.Add({"cargoAdm", oConfig.valores(16)})
                valores.Add({"puesto", oContrato(2)})
                valores.Add({"desde", oContrato(0)})
                valores.Add({"slogan", ""})

                Dim wdDoc As New cWord(archivo)  'abre plantilla
                wdDoc.SustituyeValores(valores)

                Dim subreporte As String = My.Application.Info.DirectoryPath & "\rptColillasPagoEmpleado.html"

                If File.Exists(subreporte) Then
                    File.Delete(subreporte)
                End If

                Dim reporte As New Reportes
                Dim colilla As New rptColillasPagoEmpleado
                reporte.inserta_parametro(colilla, "@pid_emp", id_emp)

                reporte.Exportar(colilla, subreporte)

                wdDoc.SustituyeRTF("neto", subreporte) 'carga rft reporte detallado

                Dim guardaComo = Me.TextBox3.Text & " " & TextBox2.Text
                wdDoc.guarda(guardaComo) 'guarda como
            Else
                MsgBox("Empleado sin salario el mes anterio")
            End If

        Else
            MessageBoxEx.Show("Selecciones contratos activos", "Solo empleados activos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ''' <summary>
    ''' Valida el valor ingregado en campo cedula que contenga 10 o 12 caracters para DIMEX
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CustomValidator1_ValidateValue(sender As Object, e As Validator.ValidateValueEventArgs) Handles CustomValidator1.ValidateValue
        If e.ControlToValidate.Text.Length = 10 Or e.ControlToValidate.Text.Length = 12 Then
            e.IsValid = True
        Else
            e.IsValid = False
        End If
    End Sub

    Function ConstanciaConsecutivo() As String

        Dim conf As New cConfiguracion
        Dim valor As Integer
        Dim resp As String

        valor = conf.ValorConfiguracion("Constancias", "consecutivo")
        conf.ValorConfiguracionInc("Constancias", "consecutivo")

        resp = Now.Year.ToString & "/" & valor.ToString
        Return resp
    End Function


#Region "Conversiones"


    Public Function fMoneda(valor As Decimal)
        fMoneda = valor.ToString("##,##0.00")
    End Function

    Public Function Num2Text(ByVal value As Double) As String
        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select
    End Function

#End Region

    'para saber el primer dia del mes 
    Function PrimerDiaDelMes(ByVal dtmFecha As Date) As Date
        PrimerDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha), 1)
    End Function

    'para saber el ultimo dia del mes 
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function


    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Dim lista As ArrayList
        lista = conn.llena("select id_contrato from contratosActivos where id_emp = " & id_emp)

        If lista.Count = 0 Then
            If PanelEx1.Visible = False Then
                Me.PanelEx1.Visible = True
                Me.PanelEx1.Dock = DockStyle.Fill
                ContratosDataGridViewX.Enabled = False

                Me.DateTimePicker4.Value = PrimerDiaDelMes(Now.Date)
                Me.DateTimePicker3.Value = Me.DateTimePicker4.Value.AddDays(364)
            Else
                Me.PanelEx1.Dock = DockStyle.None
                Me.PanelEx1.Visible = False
                ContratosDataGridViewX.Enabled = True
            End If
            'Me.PanelEx1.Location = Me.DataGrid1.Location
            TextBox9.Focus()
            ' Me.DateTimePicker4.Focus()
        Else
            MsgBox("Existe contrato vigente", MsgBoxStyle.Critical)
        End If
    End Sub


End Class

