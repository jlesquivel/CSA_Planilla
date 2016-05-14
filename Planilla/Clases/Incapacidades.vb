Imports System.Collections.Specialized

Public Class Incapacidades

    Dim _dias As Double
    Dim _dias_pagar As Double
    Dim _salario As Double
    Dim _unidades As String
    Dim _cantidad As Decimal
    Dim _tipo As Integer
    Dim _formula As String

    Dim conn As New conexionSQL("planilla")

    Public Sub New(ByVal dias As Double, ByVal idContrato As Integer)
        Dim datos As Array
        Dim id_cat As Integer

        datos = conn.llena("select * from contratos where id_contrato =" & idContrato).ToArray
        If datos.Length > 0 Then
            _cantidad = datos(0)(5)
            id_cat = datos(0)(6)

            datos = conn.llena("select * from categorias where id_cat =" & id_cat).ToArray
            _salario = datos(0)(2)
            _unidades = datos(0)(4)
            _dias = dias
        End If

    End Sub

    Public Function monto(ByVal dias As Double, ByVal salario As Double, ByVal unidad_pago As Integer) As Double
        _dias = dias
        _salario = salario
        _unidades = unidad_pago

        Return monto(1)
    End Function

    Public Function monto(ByVal tipo_incapacidad As Integer) As Double
        If tipo_incapacidad > 0 Then


            Dim base As Double = 0   ' las base es en dias para calcular el rebajo
            Select Case _unidades
                Case "Hora"  ' hora  * 8
                    base = _salario * 8
                Case "Día"  ' dia
                    base = _salario
                Case "Lección", "Salario" ' salario bruto  /30
                    base = (_salario * _cantidad) / 30
                Case Else
                    base = 0
            End Select

            Dim datos As Array
            Dim retorno As Double

            datos = conn.llena("select * from incapacidadesTipo where id_tipo =" & tipo_incapacidad).ToArray
            _formula = datos(0)(2)

            Dim mEval As New Evaluador
            Dim mExpresion As String = _formula

            Dim mParameters As New StringCollection()
            mParameters.Add("ByVal dias as Double")
            Dim mNameSpaces As New StringCollection()
            mNameSpaces.Add("System.Math")

            If mEval.PrecompilarAssembly(mExpresion, mParameters, mNameSpaces) Then
                Dim mParam() = {_dias}
                _dias_pagar = mEval.Evaluar(mParam)
            Else
                MsgBox("No se ha generado el Assembly")
            End If

            Select Case tipo_incapacidad
                Case 1
                Case 2
                Case 3
            End Select

            If _dias <= 3 Then
                retorno = base * (_dias * 0.5)
            Else
                retorno = base * (_dias - 1.5)
            End If
            Return retorno * -1
        End If
    End Function


End Class
