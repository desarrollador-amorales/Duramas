Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class ClsGeneral
    '    Dim CadenaConexion As String = "Driver=DSNSai;uid='SA;pwd=AngJua1289"
    '    Dim Conexion As New OdbcConnection(CadenaConexion)


    Function Conectar() As Boolean

        'Función para realizar la conexión con la base de datos.

        On Error GoTo ConectarErrores

        Conexion = New ADODB.Connection

        Conexion.Open("DSN=DSNSai;uid=SA;pwd=AngJua1289")
        '     Conexion1.Open "DSN=DsnTiger;uid=SA;pwd="

        Conectar = True
        Exit Function

ConectarErrores:
        For Each er In Conexion.Errors
            '        MsgBox er.Description
            '        MsgBox er.Number
            Conectar = False
        Next

    End Function

    Sub Conectar1()

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