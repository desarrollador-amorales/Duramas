Imports System.Data.SqlClient

Public Class FormLogin
    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlGeneral.Conectar()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim username As String = txtUser.Text
        Dim password As String = txtPass.Text

        If ControlUsuarios.RevisaUsuario(username, password, "usucod") = 1 Then
            MessageBox.Show("Inicio de sesión exitoso")
            FrmAlmacen.Show()
        Else
            MessageBox.Show("Nombre de usuario o contraseña incorrectos")
        End If
    End Sub

    Private Function AutenticacionUsuario(username As String, password As String) As Boolean
        '        Using connection As New SqlConnection()

        '        connection.Open()
        '       Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Username AND Contraseña = @Password"
        '      Using command As New SqlCommand(query, connection)
        '        Command.Parameters.AddWithValue("@Username", username)
        '        Command.Parameters.AddWithValue("@Password", password)
        '        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
        '       Return count > 0
        '        End Using
        '        End Using
        AutenticacionUsuario = True
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ControlGeneral.Desconectar()
    End Sub

    Private Sub lblContrasena_Click(sender As Object, e As EventArgs) Handles lblContrasena.Click

    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
    End Sub
End Class