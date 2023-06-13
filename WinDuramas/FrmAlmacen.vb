Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmAlmacen
    Private Sub FrmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListadoAlmacenes()
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
        'nueva consulta
        '  Dim Tabla As New Sql
        ' nuevo comentario
        'linea
        Dim Tabla As New ADODB.Recordset
        Dim Campo As String

        Tabla = ControlAlmacenes.ObtieneAlmacenes("", "")

        '        ListaDatos.ListItems.Clear
        Do While Not Tabla.EOF
            '           Set itmX = ListaDatos.ListItems.Add(, , CStr(Tabla.Fields("almacencod")))
            '            itmX.SubItems(1) = CStr(Tabla.Fields("almacendes"))
            Campo = Tabla.Fields("almacendes").Value
            MessageBox.Show(Tabla.Fields("almacendes").Value)
            Tabla.MoveNext()
        Loop

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

    End Sub

    Private Sub TxtCriterio1_TextChanged(sender As Object, e As EventArgs) Handles TxtCriterio1.TextChanged

    End Sub
End Class