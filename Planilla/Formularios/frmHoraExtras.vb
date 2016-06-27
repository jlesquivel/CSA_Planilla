Imports System.ComponentModel
Imports Planilla

Public Class frmHoraExtras
    Dim tExtra, tNoc, tMix As Decimal
    Dim he As cHorasExtras
    Dim regs As Integer
    Dim conn As New conexionSQL

    Private Sub BEmpleado1_selecionado(sender As Object, e As SeleccionadoEventArgs) Handles BEmpleado1.selecionado
        If BEmpleado1.seleccionado IsNot Nothing Then
            guardar()
            CuEmpleado1.Muestra(BEmpleado1.seleccionado)
            he = New cHorasExtras(BEmpleado1.seleccionado)

            Dim fini, ffin As Date
            If Now.Day <= 15 Then
                fini = Now.AddDays(Now.Day * -1)
                ffin = fini.AddDays(15)
            Else
                fini = DateSerial(Year(Now), Month(Now), 16)
                ffin = DateSerial(Year(Now), Month(Now) + 1, 0)
            End If

            regs = Horas_extrasTableAdapter.FillById_emp(Me.Ds2planilla.horas_extras, BEmpleado1.seleccionado, fini.ToString, ffin.ToString)
            If regs = 0 Then
                ' Crea las hora extras si no existen
                If MsgBox("Desea Asignar Horas Extras ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    conn.ejecuta("Horas_Extras_Inserta " & BEmpleado1.seleccionado & ",'" & fini.ToShortDateString & "','" & ffin.ToShortDateString & "'")
                    regs = Horas_extrasTableAdapter.FillById_emp(Me.Ds2planilla.horas_extras, BEmpleado1.seleccionado, fini.ToString, ffin.ToString)
                End If
            End If

            sumarizar()
        End If
    End Sub
    Sub sumarizar()
        tExtra = 0
        tNoc = 0
        tMix = 0
        For Each row As DataGridViewRow In Horas_extrasDataGridViewX.Rows
            tExtra += row.Cells("extra").Value
            tNoc += row.Cells("nocturna").Value
            tMix += row.Cells("mixta").Value
        Next

        dExtra.Value = tExtra
        dNocturna.Value = tNoc
        dMixta.Value = tMix
        If he IsNot Nothing Then
            mExtra.Value = tExtra * he.HoraExtra
            mNoc.Value = tNoc * he.HoraNocturna
            mMix.Value = tMix * he.HoraMixta
            gTotal.Value = mExtra.Value + mNoc.Value + mMix.Value
        End If

    End Sub

    Private Sub frmHoraExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BEmpleado1.HoraExtra = True
    End Sub

    Private Sub Horas_extrasDataGridViewX_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Horas_extrasDataGridViewX.CellValueChanged
        sumarizar()
    End Sub

    Private Sub frmHoraExtras_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        guardar()
    End Sub
    ''' <summary>
    ''' Guarda los datos en la base de datos
    ''' </summary>
    Sub guardar()
        Me.Validate()
        Me.Horas_extrasBindingSource.EndEdit()
        Me.Horas_extrasTableAdapter.Update(Me.Ds2planilla.horas_extras)
    End Sub
End Class