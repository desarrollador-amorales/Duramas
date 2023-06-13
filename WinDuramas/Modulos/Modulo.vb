Imports System.Data.Odbc

Module Modulo
    Public ControlGeneral As New ClsGeneral
    Public ControlAlmacenes As New ClsAlmacenes
    Public ControlUsuarios As New ClsUsuarios
    Public CadenaConexion As String = "Driver=DSNSai;uid=SA;pwd=AngJua1289"
    Public Conexion As New ADODB.Connection

End Module
