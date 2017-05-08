Imports System.ComponentModel
Imports DevComponents.Editors
Imports Planilla

Public Class frmLiquidacion

    Dim totalBruto As Double = 0
    Dim promBruto As Double = 0
    Dim SalarioDia As Double = 0

    Dim preaviso As Integer = 0
    Dim vacaciones As Integer = 0
    Dim cesantia As Integer = 0
    Dim antiguedad As Integer = 0

    Dim conn As New conexionSQL


    Private Sub BEmpleado1_selecionado(sender As Object, e As SeleccionadoEventArgs) Handles BEmpleado1.selecionado

        Try
            Me.CuEmpleado1.Muestra(BEmpleado1.seleccionado)
            Me.Empleados_Salarios6mesesTableAdapter.Fill(Me.Ds2planilla.Empleados_Salarios6meses, New System.Nullable(Of Integer)(CType(BEmpleado1.seleccionado, Integer)))
            Me.ContratosEmpleadoTableAdapter.Fill(Me.Ds2planilla.ContratosEmpleado, New System.Nullable(Of Integer)(CType(BEmpleado1.seleccionado, Integer)))
            Me.VacacionesTableAdapter.FillByIdEmp(DsVacaciones.Vacaciones, BEmpleado1.seleccionado)

            VacacionesBindingSource.Filter = "periodo = " & Now.Year.ToString

            SumarColumna()  ' sumar salarios ultimos 6 meses

            dPre.Value = 0
            dCesant.Value = 0
            mPre.Value = 0
            mCesant.Value = 0
            SWResponPatronals.Value = False

            DateTimeInput1.Value = FechaContratoAntiguo()
            DateTimeInput2.Value = Now.Date

            DoubleInput1.Value = totalBruto
            DoubleInput2.Value = promBruto
            mSalarioDia.Value = SalarioDia
            mAguinaldo.Value = fAguinaldo(CuEmpleado1.tContrato.Text)

            dVaca.Value = dVacaciones()

            antiguedad = DateDiff("d", DateTimeInput1.Value, DateTimeInput2.Value)
            'dPre.Value = dPreaviso()
            'dCesant.Value = dCesantia()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("frmLiquidacion::seleccionado ==> " & ex.Message)
        End Try

    End Sub

#Region "Calculos y datos"

    ''Aguinaldo
    Private Function fAguinaldo(pContrato As String) As Double

        Try
            Dim aguinaldo As Decimal = 0
            If pContrato <> "" Then
                Me.AguinaldoTableAdapter.Aguinaldo(New System.Nullable(Of Integer)(CType(pContrato, Integer)), aguinaldo)
            End If
            Return aguinaldo

        Catch ex As Exception
            MessageBox.Show("frmLiquidacion::fAguinaldo ==> " & ex.Message)
        End Try
    End Function

    Private Function dVacaciones() As Integer
        'TODO revisar bien este calculo de las vacaciones para liquidacion
        Dim fDic_anterior As Date = DateSerial(Now.Year - 1, 12, 1)
        If DateTimeInput1.Value > fDic_anterior Then
            vacaciones = DateDiff("m", DateTimeInput1.Value, DateTimeInput2.Value)
        Else
            vacaciones = DateDiff("m", fDic_anterior, DateTimeInput2.Value)
        End If


        Return vacaciones
    End Function


    Private Function dCesantia() As Integer
        Try
            Dim diasContrato As Integer = DateDiff("d", DateTimeInput1.Value, DateTimeInput2.Value)
            Dim datos As ArrayList
            datos = conn.llena("select dbo.fTablaValoresXRubro('Cesantia'," & CStr(diasContrato) & ")")

            If datos.Count > 0 Then
                Return datos(0)(0)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("frmLiquidacion::dPreaviso ==> " & ex.Message)
            Return 0
        End Try

    End Function

    Private Function dPreaviso() As Integer

        Try
            Dim diasContrato As Integer = DateDiff("d", DateTimeInput1.Value, DateTimeInput2.Value)
            Dim datos As ArrayList
            datos = conn.llena("select dbo.fTablaValoresXRubro('Preaviso'," & CStr(diasContrato) & ")")

            If datos.Count > 0 Then
                Return datos(0)(0)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("frmLiquidacion::dPreaviso ==> " & ex.Message)
            Return 0

        End Try
    End Function


    Private Sub SumarColumna()
        Dim resultado As Double = 0
        Dim contador As Integer = 0

        For Each row As Object In Empleados_Salarios6mesesDataGridViewX.Rows
            resultado += row.Cells(4).Value
            contador += 1
        Next

        totalBruto = resultado
        promBruto = resultado / contador
        SalarioDia = promBruto / 30

    End Sub
    'Tiempo trancurrido

    Private Sub fechas()
        Dim fecha1 As Date = DateTimeInput1.Value
        Dim fecha2 As Date = DateTimeInput2.Value
        Dim Años, Meses, Dias As Integer

        If fecha1.Date < fecha2.Date Then

            Dim DiasMes As Integer
            Dias = fecha2.Day - fecha1.Day
            Meses = DatePart("m", fecha2) - DatePart("m", fecha1)
            Años = DateDiff("yyyy", fecha1, fecha2)

            If Dias < 0 Then
                DiasMes = DateAndTime.Day(DateSerial(Year(fecha1), Month(fecha2) + 1, 0))
                Dias = (DiasMes - DateAndTime.Day(fecha1)) + DateAndTime.Day(fecha2)
                Meses = Meses - 1
            End If

            If Meses < 0 Then
                Meses = 12 + Meses
                Años = Años - 1
            End If

            vdias.Value = Dias
            vmeses.Value = Meses
            vanos.Value = Años

        End If
    End Sub

    Private Function FechaContratoAntiguo() As Date
        Dim antiguo As Date = Now.Date
        Dim col As Integer = GetColIndex(ContratosEmpleadoDataGridViewX, "fecha_ini")

        If col > 0 Then
            For Each fila As DataGridViewRow In ContratosEmpleadoDataGridViewX.Rows
                If antiguo > fila.Cells(col).Value Then
                    antiguo = fila.Cells(col).Value
                End If
            Next
        End If
        Return antiguo
    End Function

    Private Function GetColIndex(ByVal _dgv As DataGridView, ByVal _colname As String) As Integer
        Try
            Return _dgv.Columns.Item(_colname).Index
        Catch
            'asked name not found
            Return -1
        End Try
    End Function
#End Region

#Region "Controles formulario"

    Private Sub frmLiquidacion_Load(sender As Object, e As EventArgs) Handles Me.Load

        ContratosEmpleadoTableAdapter.Connection = conn.conexion
        Empleados_Salarios6mesesTableAdapter.Connection = conn.conexion
        AguinaldoTableAdapter.Connection = conn.conexion
        VacacionesTableAdapter.Connection = conn.conexion

        'TODO: esta línea de código carga datos en la tabla 'DsVacaciones.Vacaciones' Puede moverla o quitarla según sea necesario.
        Me.VacacionesTableAdapter.Fill(Me.DsVacaciones.Vacaciones)
        DirectCast(MdiParent, Planilla.frmNomina).ocultarBar2()
    End Sub


    Private Sub DateTimeInput1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeInput1.ValueChanged
        fechas()
        dVaca.Value = dVacaciones()
    End Sub

    Private Sub DateTimeInput2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeInput2.ValueChanged
        fechas()
        dVaca.Value = dVacaciones()
    End Sub
    Private Sub SwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles SwitchButton1.ValueChanged
        If SwitchButton1.Value Then
            Empleados_Salarios6mesesBindingSource.Filter = "id_planilla is not null"
            Empleados_Salarios6mesesDataGridViewX.Columns.Item("id_planilla").Visible = True
        Else
            Empleados_Salarios6mesesBindingSource.Filter = "id_planilla is null"
            Empleados_Salarios6mesesDataGridViewX.Columns.Item("id_planilla").Visible = False
        End If
    End Sub


    Function totaliza() As Double
        Return (mVaca.Value + mAguinaldo.Value + mPre.Value + mCesant.Value)
    End Function
    Private Sub mAguinaldo_ValueChanged(sender As Object, e As EventArgs) Handles mAguinaldo.ValueChanged
        mTotal.Value = totaliza()
    End Sub

    Private Sub mVaca_ValueChanged(sender As Object, e As EventArgs) Handles mVaca.ValueChanged
        mTotal.Value = totaliza()
    End Sub

    Private Sub mPre_ValueChanged(sender As Object, e As EventArgs) Handles mPre.ValueChanged
        mTotal.Value = totaliza()
    End Sub

    Private Sub mCesant_ValueChanged(sender As Object, e As EventArgs) Handles mCesant.ValueChanged
        mTotal.Value = totaliza()
    End Sub

    Private Sub SwitchButton2_ValueChanged(sender As Object, e As EventArgs) Handles SWResponPatronals.ValueChanged
        If SWResponPatronals.Value Then
            dPre.Value = dPreaviso()
            dCesant.Value = dCesantia()
            mPre.Value = dPreaviso() * SalarioDia
            mCesant.Value = dCesantia() * SalarioDia
        Else
            dPre.Value = 0
            dCesant.Value = 0
            mPre.Value = 0
            mCesant.Value = 0

        End If
    End Sub

    Private Sub dVaca_ValueChanged(sender As Object, e As EventArgs) Handles dVaca.ValueChanged
        vacaciones = dVaca.Value
        mVaca.Value = vacaciones * SalarioDia
    End Sub

    Private Sub dPre_ValueChanged(sender As Object, e As EventArgs) Handles dPre.ValueChanged
        preaviso = dPre.Value
        mPre.Value = preaviso * SalarioDia
    End Sub

    Private Sub dCesant_ValueChanged(sender As Object, e As EventArgs) Handles dCesant.ValueChanged
        cesantia = dCesant.Value
        mCesant.Value = cesantia * SalarioDia
    End Sub

    Private Sub frmLiquidacion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        DirectCast(MdiParent, Planilla.frmNomina).MostrarBar2()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Dim taLiquida As New ds2planillaTableAdapters.LiquidacionTableAdapter
        Dim tablaLiquida As New ds2planilla.LiquidacionDataTable

        Dim fecha1 As Date = DateTimeInput1.Value
        Dim fecha2 As Date = DateTimeInput2.Value
        Dim promSalario As Decimal = DoubleInput2.Value

        cartaLiquidacion("")

        taLiquida.Connection = conn.conexion
        taLiquida.Insert(Now.Date, CuEmpleado1.id_contrato, antiguedad, fecha1, fecha2, promSalario, mSalarioDia.Value, dVaca.Value, mAguinaldo.Value, dPre.Value, mPre.Value, dCesant.Value, mCesant.Value)


    End Sub
    Sub cartaLiquidacion(directorio As String)

        Dim oConfig = New cConfiguracion
        Dim repLegal As String = oConfig.ValorConfiguracion("RepLegal", "Nombre")
        Dim repCargo As String = oConfig.ValorConfiguracion("RepLegal", "Cargo")
        Dim adm As String = oConfig.valores(15)
        Dim admCargo As String = oConfig.valores(16)

        Dim archivo = My.Application.Info.DirectoryPath & "\contLiquidacion.docx"
        Dim nombreEmp As String = CuEmpleado1.tNombre.Text & " " & CuEmpleado1.tApellidos.Text


        Dim valores As New ArrayList     '' Valores que se envian al documento Word   
        valores.Add({"NO", "000000"})
        valores.Add({"icedula", CuEmpleado1.tCedula.Text})
        valores.Add({"inombre", nombreEmp})

        valores.Add({"iLaborado", vanos.Text & " años -" & vmeses.Text & " meses - " & vdias.Text & " días"})
        valores.Add({"iIngreso", DateTimeInput1.Text})
        valores.Add({"fCarta", Now.ToString("dd 'de' MMMM 'del' yyyy")})
        valores.Add({"iPuesto", CuEmpleado1.tCategoria.Text})
        valores.Add({"iSalida", DateTimeInput2.Text})
        valores.Add({"iSalPromedio", DoubleInput2.Value.ToString("n2")})
        valores.Add({"iModalidad", "Mensual"})

        '' TABLA 1
        valores.Add({"dAguinaldo", DoubleInput1.Value.ToString("n2")})
        valores.Add({"dVacaciones", DoubleInput1.Value.ToString("n2")})
        valores.Add({"dPreaCesan", DoubleInput1.Value.ToString("n2")})
        valores.Add({"dDiarioVac", mSalarioDia.Value.ToString("n2")})
        valores.Add({"dDiarioPreaCesa", mSalarioDia.Value.ToString("n2")})

        Dim salpromedio As String = mSalarioDia.Value.ToString("n2")
        '' TABLA LIQUIDACION
        valores.Add({"tAguinaldo", fAguinaldo(CuEmpleado1.tContrato.Text).ToString("n2")})
        valores.Add({"dVac", dVaca.Value.ToString("n")})
        valores.Add({"mVac", salpromedio})
        valores.Add({"tVac", mVaca.Value.ToString("n2")})
        valores.Add({"dPreav", dPre.Value.ToString("n2")})
        valores.Add({"mdPreav", salpromedio})
        valores.Add({"tPreav", mPre.Value.ToString("n2")})
        valores.Add({"dCesant", dCesant.Value.ToString("n2")})
        valores.Add({"mdCesant", salpromedio})
        valores.Add({"tCesant", mCesant.Value.ToString("n2")})
        valores.Add({"gTotal", mTotal.Value.ToString("n2")})


        valores.Add({"nRepresentant", repLegal})
        valores.Add({"cRepresentant", repCargo})
        valores.Add({"nEmpleado", nombreEmp})

        Dim wdDoc As New cWord(archivo)  'abre plantilla
        wdDoc.SustituyeValores(valores)

        Dim guardaComo = "Liquidación_" & nombreEmp
        If directorio = "" Then
            wdDoc.guarda(guardaComo)
        Else
            wdDoc.guarda(guardaComo, directorio)
        End If
    End Sub

#End Region

End Class

