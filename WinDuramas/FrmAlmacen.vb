Public Class FrmAlmacen
    Private Sub FrmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlGeneral.Conectar()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GboxListado.Enter

    End Sub

    Private Sub ListaDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaDatos.SelectedIndexChanged

    End Sub

    Private Sub ListaDatos_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListaDatos.ColumnClick
        ListaDatos.Sort()
        If ListaDatos.Sorting = 0 Then
            ListaDatos.Sorting = 1
        Else
            ListaDatos.Sorting = 0
        End If
        ListaDatos.Refresh()
    End Sub

    Sub ListadoAlmacenes()
        '  Dim Tabla As New Sql
        ' nuevo comentario
        'linea
    End Sub

End Class