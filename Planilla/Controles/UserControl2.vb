Imports System.Reflection
Imports System.Text
'Imports Extensions.CustomAttributes

Public Class UserControl2
    Inherits System.Windows.Forms.UserControl

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents Imprimir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Borra As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Guardar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Nuevo As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents Ayuda As DevComponents.DotNetBar.ButtonItem

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl2))
        Me.Imprimir = New DevComponents.DotNetBar.ButtonItem
        Me.Borra = New DevComponents.DotNetBar.ButtonItem
        Me.Guardar = New DevComponents.DotNetBar.ButtonItem
        Me.Nuevo = New DevComponents.DotNetBar.ButtonItem
        Me.Bar1 = New DevComponents.DotNetBar.Bar
        Me.Ayuda = New DevComponents.DotNetBar.ButtonItem
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Imprimir
        '
        Me.Imprimir.Icon = CType(resources.GetObject("Imprimir.Icon"), System.Drawing.Icon)
        Me.Imprimir.Name = "Imprimir"
        resources.ApplyResources(Me.Imprimir, "Imprimir")
        '
        'Borra
        '
        Me.Borra.Icon = CType(resources.GetObject("Borra.Icon"), System.Drawing.Icon)
        Me.Borra.Name = "Borra"
        resources.ApplyResources(Me.Borra, "Borra")
        '
        'Guardar
        '
        Me.Guardar.Image = CType(resources.GetObject("Guardar.Image"), System.Drawing.Image)
        Me.Guardar.Name = "Guardar"
        resources.ApplyResources(Me.Guardar, "Guardar")
        '
        'Nuevo
        '
        Me.Nuevo.Icon = CType(resources.GetObject("Nuevo.Icon"), System.Drawing.Icon)
        Me.Nuevo.Name = "Nuevo"
        resources.ApplyResources(Me.Nuevo, "Nuevo")
        '
        'Bar1
        '
        resources.ApplyResources(Me.Bar1, "Bar1")
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Nuevo, Me.Guardar, Me.Borra, Me.Imprimir, Me.Ayuda})
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Bar1.TabStop = False
        '
        'Ayuda
        '
        Me.Ayuda.BeginGroup = True
        Me.Ayuda.Icon = CType(resources.GetObject("Ayuda.Icon"), System.Drawing.Icon)
        Me.Ayuda.Name = "Ayuda"
        resources.ApplyResources(Me.Ayuda, "Ayuda")
        '
        'UserControl2
        '
        Me.Controls.Add(Me.Bar1)
        Me.Name = "UserControl2"
        resources.ApplyResources(Me, "$this")
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Try
            Dim f As Object = Me.Parent
            f.nuevo()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Try
            Dim f As Object = Me.Parent
            f.guardar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Borra.Click
        Try
            Dim f As Object = Me.Parent
            f.borrar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        Try
            Dim f As Object = Me.Parent
            f.imprimir()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ayuda.Click
        Try
            Dim f As Object = Me.Parent
            f.buscar()
        Catch ex As Exception

        End Try
    End Sub
End Class
