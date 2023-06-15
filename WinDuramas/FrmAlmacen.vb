Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Security.Principal
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmAlmacen
    Dim Nuevo As Integer
    Dim Estado As String

    Sub EnceraPantalla()

        TxtCriterio.Text = ""
        TxtCriterio1.Text = ""
        '        cmdEliminar.Enabled = False
        Nuevo = 1
    End Sub

    Private Sub FrmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '        MDIPrincipal.MnuOpcion4(0).Enabled = False
        '        Me.Left = ((MDIPrincipal.Width - MDIPrincipal.Picture1.Width - Me.Width) / 2)
        '        Me.Top = ((MDIPrincipal.Height - Me.Height) / 2) - 500
        ListaDatos.Columns.Add("Almacén", 80, 0)
        ListaDatos.Columns.Add("Descripción", 250, 0)
        ListaDatos.Alignment = 0
        ListadoAlmacenes()
        EnceraPantalla()
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
        Dim Tabla As New ADODB.Recordset
        Dim ItmX As ListViewItem

        Tabla = ControlAlmacenes.ObtieneAlmacenes(TxtCriterio.Text, TxtCriterio1.Text)

        ListaDatos.Items.Clear()
        Do While Not Tabla.EOF
            ItmX = ListaDatos.Items.Add(CStr(Tabla.Fields("almacencod").Value))
            ItmX.SubItems.Add(CStr(Tabla.Fields("almacendes").Value))
            '          ItmX.SubItems.Add(CStr(Tabla.Fields("almacendes")))

            Tabla.MoveNext()
        Loop

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

    End Sub

    Private Sub TxtCriterio_TextChanged(sender As Object, e As EventArgs) Handles TxtCriterio.TextChanged
        ListadoAlmacenes()
    End Sub

    Private Sub TxtCriterio1_TextChanged(sender As Object, e As EventArgs) Handles TxtCriterio1.TextChanged
        ListadoAlmacenes()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click
        Close()
    End Sub

    Private Sub CmdImprimir_Click(sender As Object, e As EventArgs) Handles CmdImprimir.Click

    End Sub

    Private Sub CmdEliminar_Click(sender As Object, e As EventArgs) Handles CmdEliminar.Click
    End Sub

    Private Sub CmdGrabar_Click(sender As Object, e As EventArgs) Handles CmdGrabar.Click
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub TxtCampos0_TextChanged(sender As Object, e As EventArgs) Handles TxtCampos0.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtCampos1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtCampos3.TextChanged
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TxtCampos2.TextChanged
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TxtCampos4.TextChanged
    End Sub
End Class