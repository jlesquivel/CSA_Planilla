Public Class cConfiguracion


    Dim conn As New conexionSQL
    Dim datos As New ArrayList
    Public valores As Object


    Public Sub New()
        datos = conn.llena("select * from configuracion")
        valores = datos(0)
    End Sub



    Public Function campo(ByRef pcampo) As Object
        campo = ""
        For Each valor As Object In datos(0)
            If valor(0) = pcampo Then
                campo = valor(1)
            End If
        Next
    End Function

    Public Function ValorConfiguracion(grupo As String, valorNombre As String) As Object

        Dim con2 As New conexionSQL
        Dim dat2 As ArrayList
        Dim inst As String = " EXEC [pValoresConfiguracion] "
        Dim ret As Object

        inst = inst & String.Format(" '{0}' , '{1}'", grupo, valorNombre)

        dat2 = conn.llena(inst)

        If dat2(0)(4) IsNot DBNull.Value Then
            ret = dat2(0)(4)
        Else
            ret = dat2(0)(5)
        End If

        Return ret
    End Function

    Sub ValorConfiguracionInc(grupo As String, valorNombre As String)
        Dim con2 As New conexionSQL
        Dim dat2 As ArrayList
        Dim inst As String = " EXEC [pValoresConfiguracionIncrementa] "
        Dim ret As Object

        inst = inst & String.Format(" '{0}' , '{1}'", grupo, valorNombre)
        con2.ejecuta(inst)

    End Sub






End Class
