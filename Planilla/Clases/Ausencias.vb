
Imports System.Collections.Specialized

Public Class Ausencias
    Dim _dias As Double
    Public _salario As Decimal
    Public _unidades As String
    Dim _cantidad As Integer
    Dim _tipo As Integer
    Dim _formula As String
    Public _base As Double


    Dim conn As New conexionSQL("planilla")

    Public Sub New(ByVal dias As Double, ByVal idContrato As Integer)
        If idContrato > 0 Then

            Dim datos As Array
            Dim id_cat As Integer

            datos = conn.llena("select * from contratos where id_contrato =" & idContrato).ToArray
            _cantidad = datos(0)(5)
            id_cat = datos(0)(6)

            datos = conn.llena("select * from categorias where id_cat =" & id_cat).ToArray
            _salario = datos(0)(2)
            _unidades = datos(0)(4)
            _dias = dias

            _base = 0
            Select Case _unidades
                Case "Hora"  ' hora  * 8
                    _base = _salario * 8
                Case "Día"  ' dia
                    _base = _salario
                Case "Salario" ' salario bruto  /30
                    _base = (_salario * _cantidad) / 30
                Case "Lección"
                    _base = (_salario / 4)
                Case Else
                    _base = 0
            End Select
        End If
    End Sub

    Public Function monto() As Double

        _formula = "dias "
        Dim mEval As New Evaluador
        Dim mExpresion As String = _formula

        Dim mParameters As New StringCollection()
        mParameters.Add("ByVal dias as Double")
        Dim mNameSpaces As New StringCollection()
        mNameSpaces.Add("System.Math")

        If mEval.PrecompilarAssembly(mExpresion, mParameters, mNameSpaces) Then
            Dim mParam() = {_dias}
            _dias = mEval.Evaluar(mParam)
        Else
            MsgBox("No se ha generado el Assembly")
        End If

        Return (_base * _dias) * -1
    End Function
End Class
