Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Security.Principal
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports WinDuramas.WinDuramas
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.ReportAppServer
Imports System
Imports System.ComponentModel

Public Class FrmAlmacen
    Dim Nuevo As Integer
    Dim Estado As String

    Sub EnceraPantalla()

        TxtCriterio.Text = ""
        TxtCriterio1.Text = ""
        TxtCampos0.Text = ""
        TxtCampos1.Text = ""
        TxtCampos2.Text = ""
        TxtCampos3.Text = ""
        TxtCampos4.Text = ""
        CmdEliminar.Enabled = False
        Nuevo = 1
    End Sub

    Private Sub FrmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '        MDIPrincipal.MnuOpcion4(0).Enabled = False

        ListaDatos.Columns.Add("Almacén", 80, 0)
        ListaDatos.Columns.Add("Descripción", 250, 0)
        ListaDatos.Alignment = 0
        ListadoAlmacenes()
        EnceraPantalla()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GboxListado.Enter

    End Sub

    Private Sub ListaDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaDatos.SelectedIndexChanged
        If ListaDatos.SelectedItems.Count > 0 Then
            TxtCampos0.Text = ListaDatos.SelectedItems(0).Text
            SacaDatos()
        End If
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
            '            ItmX.SubItems.Add(CStr(Tabla.Fields("almacendes")))

            Tabla.MoveNext()
        Loop

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        EnceraPantalla()
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

    Sub SacaDatos()
        Dim Tabla As New ADODB.Recordset

        TxtCampos1.Text = ""
        TxtCampos2.Text = ""
        TxtCampos3.Text = ""
        TxtCampos4.Text = ""

        Tabla = ControlAlmacenes.BuscaAlmacen(TxtCampos0.Text)
        If Not Tabla.EOF Then
            TxtCampos1.Text = Tabla.Fields("almacendes").Value
            If Not IsDBNull(Tabla.Fields("almacenruc").Value) Then
                TxtCampos2.Text = Tabla.Fields("almacenruc").Value
            End If
            If Not IsDBNull(Tabla.Fields("almacenserie").Value) Then
                TxtCampos3.Text = Tabla.Fields("almacenserie").Value
            End If
            If Not IsDBNull(Tabla.Fields("detalle").Value) Then
                TxtCampos4.Text = Tabla.Fields("detalle").Value
            End If
            If Not IsDBNull(Tabla.Fields("estado").Value) Then
                Estado = Tabla.Fields("estado").Value
            End If
            CmdGrabar.Enabled = True
            CmdEliminar.Enabled = True
            Nuevo = 0
        Else
            TxtCampos1.Text = ""
            TxtCampos2.Text = ""
            TxtCampos3.Text = ""
            TxtCampos4.Text = ""
            Estado = "N"
            CmdGrabar.Enabled = True
            CmdEliminar.Enabled = False
            Nuevo = 1
        End If
    End Sub

    Private Sub CmdEliminar_Click(sender As Object, e As EventArgs) Handles CmdEliminar.Click

        If MessageBox.Show("Esta seguro de eliminar el ALMACEN ?...") = DialogResult.No Then
            Exit Sub
        End If
        ControlAlmacenes.EliminaAlmacen(TxtCampos0.Text)
        TxtCampos0.Text = ""
        TxtCampos1.Text = ""
        TxtCampos2.Text = ""
        TxtCampos3.Text = ""
        TxtCampos4.Text = ""
        EnceraPantalla()
        ListadoAlmacenes()
        Nuevo = 1

    End Sub

    Private Sub CmdGrabar_Click(sender As Object, e As EventArgs) Handles CmdGrabar.Click
        If Len(Trim(TxtCampos0.Text)) = 0 Then
            MessageBox.Show("Ingrese CODIGO DEL ALMACEN")
            TxtCampos0.Focus()
            Exit Sub
        End If
        If Len(Trim(TxtCampos1.Text)) = 0 Then
            MessageBox.Show("Ingrese DESCRIPCION DEL ALMACEN")
            TxtCampos1.Focus()
            Exit Sub
        End If
        If Len(Trim(TxtCampos2.Text)) = 0 Then
            MessageBox.Show("Ingrese RUC DEL ALMACEN")
            TxtCampos2.Focus()
            Exit Sub
        End If
        If Len(Trim(TxtCampos3.Text)) = 0 Then
            MessageBox.Show("Ingrese SERIE DEL ALMACEN")
            TxtCampos3.Focus()
            Exit Sub
        End If
        If Nuevo = 1 Then
            ControlAlmacenes.IngresaAlmacen(TxtCampos0.Text, TxtCampos1.Text, TxtCampos2.Text, TxtCampos3.Text, "N", CodigoUsuario, TxtCampos4.Text)
        Else
            ControlAlmacenes.ActualizaAlmacen(TxtCampos0.Text, TxtCampos1.Text, TxtCampos2.Text, TxtCampos3.Text, Estado, CodigoUsuario, TxtCampos4.Text)
        End If

        ControlAlmacenes.IngresaComprobanteAlmacen(TxtCampos0.Text)
        CmdEliminar.Enabled = False
        EnceraPantalla()
        ListadoAlmacenes()
        Nuevo = 1

    End Sub

    Private Sub CmdImprimir_Click(sender As Object, e As EventArgs) Handles CmdImprimir.Click
        Dim Consulta As String
        Dim Tabla As New ADODB.Recordset
        Dim Reporte As ReportDocument

        Consulta = " select * from almacenes "

        Reporte = New CRAlmacenes

        '        EnterpriseReport1.ReportSource = Reporte
        '        Reporte.SetDataSource(Consulta)
    End Sub
End Class
