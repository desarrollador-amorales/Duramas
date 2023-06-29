Public Class FrmBancos

    Dim Nuevo As Integer
    Dim Estado As String
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TxtCampos0_TextChanged(sender As Object, e As EventArgs) Handles TxtCampos0.TextChanged

    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click
        Close()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        EnceraPantalla()
    End Sub

    Sub EnceraPantalla()

        TxtCriterio.Text = ""
        TxtCriterio1.Text = ""
        TxtCampos0.Text = ""
        TxtDescripcion.Text = ""
        TxtCodPichincha.Text = ""
        TxtCodProdubanco.Text = ""
        TxtCodGye.Text = ""
        TxtCoopJep.Text = ""
        CmdEliminar.Enabled = False
        Nuevo = 1
    End Sub
End Class