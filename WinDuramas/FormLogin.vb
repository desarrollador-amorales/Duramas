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

        If AuthenticateUser(username, password) Then
            MessageBox.Show("Inicio de sesión exitoso")
            ' Aquí puedes redirigir al usuario a la página principal u otra funcionalidad
        Else
            MessageBox.Show("Nombre de usuario o contraseña incorrectos")
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Using connection As New SqlConnection()

            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Username AND Contraseña = @Password"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

End Class