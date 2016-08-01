
Public Class cLiquidacion
    Private _id_contrato As Integer
    Private _antiguedad As Integer
    Private _prom_Salarios As Integer

    Sub New(pid_contrato As Integer)


    End Sub

#Region "Propiedades"

    Public Property id_contrato As Integer
        Get
            Return _id_contrato
        End Get
        Set(value As Integer)
            _id_contrato = value
        End Set
    End Property

#End Region
    ''' <summary>
    ''' Consulta salario 6 meses
    ''' </summary>
    Private Sub Salario6meses()


    End Sub

    ''' <summary>
    ''' Busca Contratos sin liquidar
    ''' 
    ''' </summary>
    Private Sub ContratosSinLiquidar()

    End Sub
    ''' <summary>
    ''' Calcula los dias laborados de los contratos sin liquidar
    ''' </summary>
    ''' <returns></returns>
    Private Function DiasLaborados() As Integer

        Return 0
    End Function

    Public Function Vacaciones() As Decimal

        Return 0
    End Function

    Public Function Preaviso() As Decimal

        Return 0
    End Function

    Public Function Cesantia() As Decimal

        Return 0
    End Function

End Class


'LIQUIDACION


'VACACIONES
'=======================



'PREAVISO
'===================
'1.- Antes de los tres meses no hay obligación de dar preaviso pues se trata del período de prueba.
'2.- Si tiene más de 3 meses pero menos de 6 meses de labores, debe darse 1 semana de preaviso.
'3.- Si tiene más de 6 meses pero menos de 1 año de labores, debe darse 15 días de preaviso.
'4.- Después de 1 año de labores debe darse 1 mes de preaviso. El preaviso debe darse en tiempo y solamente n casos especiales se puede dar en dinero.

'¿CÓMO SE CALCULA EL PAGO DE PREAVISO?
'Se calcula tomando en cuenta el promedio de los salarios ordinarios y
'extraordinarios efectivamente devengados por la persona trabajadora
'durante los últimos seis meses (se suman los salarios de los últimos seis
'meses y se divide entre seis para obtener el monto mensual) de vigencia del
'contrato, o fracción de tiempo menor si no hubiese ajustado dicho término.
'Para personas trabajadoras con pago mensual se divide el monto mensual
'entre 30 días y para el pago en forma semanal (excepto comercio), se divide
'el monto mensual entre 26 días, para obtener la proporción por día.
'Para el promedio no se toma en cuenta el tiempo que la persona trabajadora
'estuvo incapacitada por enfermedad. En tal caso se suman los lapsos anterior y
'posterior a dicha incapacidad, para completar los 6 meses efectivos de trabajo.
'Cuando se trata de licencias por maternidad disfrutada durante ese lapso de los
'últimos 6 meses de labores, sí se toma en cuenta lo percibido por la trabajadora
'durante los 4 meses de la licencia porque dichas sumas se consideran salario

'CESANTIA
'=============
'1. Después de un trabajo continuo no menor de tres meses ni mayor de seis,un importe igual a siete días de salario.
'2. Después de un trabajo continuo mayor de seis meses pero menor de un año, un importe igual a catorce días de salario.
'3. Después de un trabajo continuo mayor de un año, con el importe de días de salario indicado en la siguiente tabla:
'a) AÑO 1 19,5 días por año laborado.
'b) AÑO 2 20 días por año laborado o fracción superior a seis meses.
'c) AÑO 3 20,5 días por año laborado o fracción superior a seis meses.
'd) AÑO 4 21 días por año laborado o fracción superior a seis meses.
'e) AÑO 5 21,24 días por año laborado o fracción superior a seis meses.
'f) AÑO 6 21,5 días por año laborado o fracción superior a seis meses.
'g) AÑO 7 22 días por año laborado o fracción superior a seis meses.
'h) AÑO 8 22 días por año laborado o fracción superior a seis meses.
'i) AÑO 9 22 días por año laborado o fracción superior a seis meses.
'j) AÑO 10 21,5 días por año laborado o fracción superior a seis meses.
'k) AÑO 11 21 días por año laborado o fracción superior a seis meses.
'l) AÑO 12 20,5 días por año laborado o fracción superior a seis meses.
'm) AÑO 13 y siguientes: 20 días por año laborado o fracción superior a seis meses.

'4. En ningún caso podrá indemnizar dicho auxilio de cesantía más que los últimos ocho años de relación laboral.
'5. El auxilio de cesantía deberá pagarse aunque el trabajador pase inmediatamente a servir a las órdenes de otro patrono.

'***Al pago de la cesantía no se le aplica ningún tipo de deducción por cargas sociales.

'¿QUE SE TOMA EN CUENTA PARA EL CÁLCULO DEL AUXILIO 'CESANTÍA?
'Para el cálculo se toma en cuenta el promedio de todos los salarios
'ordinarios y extraordinarios devengados por la persona trabajadora en los
'últimos seis meses (se suman los salarios de los últimos seis meses y se
'divide entre 6 para obtener el monto mensual) de vigencia del contrato,
'o fracción de tiempo menor si no hubiere ajustado dicho término. Para
'personas trabajadoras con pago mensual se divide el monto mensual entre
'30 días y para el pago en forma semanal (excepto comercio), se divide el
'monto mensual entre 26 días, para obtener la proporción por día.
'No se cuenta el tiempo en que la persona trabajadora estuvo incapacitada
'por enfermedad. En tal caso se suman los salarios devengados durante
'los lapsos anteriores
