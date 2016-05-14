Public Class cPlanilla
    ''' <summary>
    ''' Define los estados de la planilla
    ''' </summary>
    ''' <remarks>
    '''     Borrado = -1
    '''     Nuevo = 0
    '''     Pagado = 1
    '''     Bloqueado = 2
    ''' </remarks>
    Enum Estado
        ' NO cambiar esto valores por que afecta el funcionmiento del formulario frmPlanilla
        ' ya qye ahi se defininen los comportamiento de los estados

        Borrado = -1
        Nuevo = 0
        Pagado = 1
        Bloqueado = 2
    End Enum

    ''' <summary>
    ''' Define la conexión con la base de datos planilla
    ''' </summary>
    ''' <remarks></remarks>
    Dim conn As New conexionSQL("planilla")

    ''' <summary>
    ''' Establece el valor del enum Estado en la tabla planilla
    ''' </summary>
    ''' <param name="estado"> valor del enum Estado que se va almacenar en la tabla planilla</param>
    ''' <param name="id_planilla">identifacador para buscar la planilla para establecer el estado</param>
    ''' <remarks>
    ''' 
    ''' </remarks>
    Public Sub SetEstado(estado As Estado, id_planilla As Integer)
        conn.ejecuta("UPDATE dbo.planillas SET estado = " & estado & _
                     " WHERE dbo.planillas.id_planilla = " & id_planilla.ToString)
    End Sub

    ''' <summary>
    ''' Obtiene el estado de la planilla almacenada en la tabla planilla
    ''' </summary>
    ''' <param name="id_planilla"> Se utiliza para buscar en la tabla planillas </param>
    ''' <returns> Un entero con el valor del estado de la planilla </returns>
    ''' <remarks></remarks>
    Public Function GetEstado(id_planilla As Integer) As Integer
        Dim resultado As New ArrayList()

        resultado = conn.llena("Select estado from dbo.planillas where id_planilla = " & id_planilla.ToString)
        Return resultado.Item(0)(0)
    End Function

End Class
