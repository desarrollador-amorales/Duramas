Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class ClsGeneral
    Dim CadenaConexion As String = "Driver=DSNSai;uid=SA;pwd=AngJua1289"
    Dim Conexion As New OdbcConnection(CadenaConexion)


    Sub Conectar()

        Try
            Conexion.Open()
            ' La conexión se ha abierto correctamente
            ' Puedes realizar operaciones en la base de datos aquí
        Catch ex As Exception
            ' Ocurrió un error al abrir la conexión
            Console.WriteLine("Error al abrir la conexión: " & ex.Message)
        Finally
            ' Asegúrate de cerrar la conexión cuando hayas terminado
        End Try

    End Sub

    Sub Conectar1()
        Dim CadenaConexion As String = "Driver=DSNSai;uid=SA;pwd=AngJua1289"
        Dim Conexion As New SqlConnection(CadenaConexion)

        Try
            Conexion.Open()
            ' La conexión se ha abierto correctamente
            ' Puedes realizar operaciones en la base de datos aquí
        Catch ex As Exception
            ' Ocurrió un error al abrir la conexión
            Console.WriteLine("Error al abrir la conexión: " & ex.Message)
        Finally
            ' Asegúrate de cerrar la conexión cuando hayas terminado
        End Try

    End Sub

    Friend Sub Desconectar()
        ' Throw New NotImplementedException()
        Conexion.Close()
        Conexion = Nothing

        End
    End Sub
End Class