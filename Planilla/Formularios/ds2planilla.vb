

Partial Public Class ds2planilla
    Partial Public Class categoriasDataTable
        Private Sub categoriasDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.id_catColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Public Class v_empleadosDataTable

    End Class

    Partial Class contratosDataTable

    End Class

    Partial Class planillasDataTable



    End Class

End Class
