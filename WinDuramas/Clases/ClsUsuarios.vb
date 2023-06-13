Public Class ClsUsuarios

    Function RevisaUsuario(Usuario As String, Clave As String, Tipo As String) As Integer
        Dim Tabla As New ADODB.Recordset

        RevisaUsuario = 1
        'Tabla.Open "select * from usuarios where usuide='" + Usuario + "'", Conexion.ConnectionString, adOpenDynamic, adLockOptimistic
        Tabla = Conexion.Execute("select * from usuarios where usuide='" + Usuario + "'")
        If Not Tabla.EOF Then
            If Tabla.Fields("ususistema").Value = 0 Then
                MessageBox.Show("No es usuario del sistema.")
                RevisaUsuario = 0
                Exit Function
            End If
            If UCase(Clave) <> UCase(Tabla.Fields(Tipo).Value) Then
                MessageBox.Show("Clave del Usuario Incorrecta.")
                RevisaUsuario = 0
                Exit Function
            End If
        Else
            MessageBox.Show("Usuario no existe.")
            RevisaUsuario = 0
        End If
    End Function
End Class
