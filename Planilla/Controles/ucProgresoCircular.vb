Public Class ucProgresoCircular

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CircularProgress1.Value += 2
    End Sub

    Private Sub CircularProgress1_ValueChanged(sender As Object, e As EventArgs) Handles CircularProgress1.ValueChanged
        CircularProgress1.IsRunning = Not CircularProgress1.IsRunning
    End Sub

    Public Sub Muestra()
        CircularProgress1.Visible = True
        CircularProgress1.Refresh()
        CircularProgress1.IsRunning = True
    End Sub

    Public Sub Oculta()
        CircularProgress1.IsRunning = False
        CircularProgress1.Visible = False
    End Sub
End Class
