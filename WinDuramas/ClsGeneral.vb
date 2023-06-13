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

    Friend Sub Desconectar()
        ' Throw New NotImplementedException()
        Conexion.Close()
        Conexion = Nothing

        End
    End Sub
End Class