Public Class bEmpleado
    Public seleccionado As String
    Public activos As Boolean = True
    Private conn As conexionSQL
    Private regs As Integer
    Private _hora_extra As Boolean = False

    Public Property HoraExtra() As Boolean
        Get
            Return _hora_extra
        End Get
        Set(ByVal Value As Boolean)
            _hora_extra = Value
            If _hora_extra Then
                Me.V_empleadosBindingSource.Filter = "contrato>0 and horaExtra>0"
            Else
                Me.V_empleadosBindingSource.Filter = "contrato>0"
            End If
        End Set
    End Property

    Public Event selecionado(ByVal sender As Object, ByVal e As SeleccionadoEventArgs)

    Protected Friend Overridable Sub OnSeleccion(ByVal e As SeleccionadoEventArgs)
        RaiseEvent selecionado(Me, e)
    End Sub

    Private Sub bEmpleado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not DesignMode Then
            conn = New conexionSQL("planilla")
            refresca()
        End If
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        seleccionado = ComboBoxEx1.SelectedValue
        OnSeleccion(New SeleccionadoEventArgs(seleccionado))
    End Sub

    Public Sub refresca()

        Dim actual As String = Me.ComboBoxEx1.Text
        V_empleadosTableAdapter.Connection = conn.conexion

        ComboBoxEx1.BeginUpdate()

        PlanillaDataSet.v_empleados.Clear()
        regs = V_empleadosTableAdapter.Fill(PlanillaDataSet.v_empleados)

        ComboBoxEx1.EndUpdate()
        Me.V_empleadosBindingSource.Filter = "contrato>0"

        activos = True

        Dim pos As Integer = Me.ComboBoxEx1.FindStringExact(actual)
        If pos > 0 Then
            Me.ComboBoxEx1.SelectedIndex = pos
        End If

    End Sub

    Public Sub busca(ByVal val As String)
        Me.ComboBoxEx1.SelectedIndex = Me.ComboBoxEx1.FindStringExact(val)
    End Sub

    Private Sub SwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles SwitchButton1.ValueChanged

        If SwitchButton1.Value Then
            If _hora_extra Then
                Me.V_empleadosBindingSource.Filter = "horaExtra>0"
            Else
                Me.V_empleadosBindingSource.Filter = ""
            End If
            activos = False
        Else
            If _hora_extra Then
                Me.V_empleadosBindingSource.Filter = "contrato>0 and horaExtra>0"
            Else
                Me.V_empleadosBindingSource.Filter = "contrato>0"
            End If
            activos = True

        End If
    End Sub
End Class
'
'
'   Evento de Seleccion
'
'
Public Class SeleccionadoEventArgs
    Inherits EventArgs

    Private ivalor As String

    Public Sub New(ByVal pval As String)
        ivalor = pval
    End Sub

    Public Property Valor() As String
        Get
            Return ivalor
        End Get
        Set(ByVal Value As String)
            ivalor = Value
        End Set
    End Property


End Class
