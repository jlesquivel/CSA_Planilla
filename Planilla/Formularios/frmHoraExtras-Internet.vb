Imports System.ComponentModel
Imports Planilla

Public Class frmHoraExtras

    Dim conn As New conexionSQL

    Private Sub BEmpleado1_selecionado(sender As Object, e As SeleccionadoEventArgs) Handles BEmpleado1.selecionado
        If BEmpleado1.seleccionado IsNot Nothing Then
            guarda()
            CuEmpleado1.Muestra(BEmpleado1.seleccionado)
            Dim he As New cHorasExtras(BEmpleado1.seleccionado)

            If he.Rubro_HorasExtras Then  ' verifica si tiene el rubro de hora extra en el contrato activo

                Dim fini, ffin As Date
                If Now.Day <= 15 Then
                    fini = Now.AddDays(Now.Day * -1)
                    ffin = fini.AddDays(15)
                Else
                    fini = DateSerial(Year(Now), Month(Now), 16)
                    ffin = DateSerial(Year(Now), Month(Now) + 1, 0)
                End If
                Dim regs As Integer = 0

                regs = Horas_extrasTableAdapter.FillById_emp(Me.Ds2planilla.horas_extras, BEmpleado1.seleccionado, fini.ToString, ffin.ToString)
                If regs = 0 Then
                    conn.ejecuta("exec Horas_Extras_Inserta " & BEmpleado1.seleccionado & ",'" & fini.ToShortDateString & "','" & ffin.ToShortDateString & "'")
                    regs = Horas_extrasTableAdapter.FillById_emp(Me.Ds2planilla.horas_extras, BEmpleado1.seleccionado, fini.ToString, ffin.ToString)
                End If
            Else
                MsgBox("El contrato actual no tiene el rubro para horas extras", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub guarda()
        Me.Validate()
        Me.Horas_extrasBindingSource.EndEdit()
        Me.Horas_extrasTableAdapter.Update(Me.Ds2planilla.horas_extras)
    End Sub

    Private Sub Horas_extrasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Horas_extrasBindingSource.EndEdit()
        Me.Horas_extrasTableAdapter.Update(Me.Ds2planilla.horas_extras)

    End Sub

    Private Sub frmHoraExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Me.Horas_extrasTableAdapter.Fill(Me.Ds2planilla.horas_extras)
        Me.BEmpleado1.HoraExtra = True

    End Sub

    Private Sub frmHoraExtras_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        guarda()
    End Sub
End Class