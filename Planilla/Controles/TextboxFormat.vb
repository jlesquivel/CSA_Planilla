Imports System.ComponentModel

Public Class TextboxFormat
    Inherits System.Windows.Forms.TextBox

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'TextboxFormat
        '
        Me.Name = "TextboxFormat"
        'Me.Size = New System.Drawing.Size(312, 232)

    End Sub

#End Region
    Dim _format As String
    Dim teclado As Boolean

    'COMENT : Coloca el mensaje para lenguaje
    <Description("Seleccione el formato del control"), Category("Format")> _
    Public Property Formato() As String
        Get
            Return _format

        End Get
        Set(ByVal Value As String)
            _format = Value
        End Set
    End Property

    Private Sub MonedaTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Validated
        MyBase.Text = convertirFormato(Me.Text)
        teclado = False
    End Sub

    Private Sub MonedaTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged
        If teclado Then
        Else
            MyBase.Text = convertirFormato(Me.Text)
            teclado = False
        End If
    End Sub

    Private Sub MonedaTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        teclado = True
    End Sub

    Private Function convertirFormato(ByVal valor As String) As String
        If IsNumeric(valor) Then
            convertirFormato = CDec(valor).ToString(Me.Formato)
        Else
            convertirFormato = valor
        End If
    End Function

    Private Sub MonedaTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        Me.SelectAll()
    End Sub

    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal Value As String)
            MyBase.Text = Value
        End Set
    End Property

End Class
