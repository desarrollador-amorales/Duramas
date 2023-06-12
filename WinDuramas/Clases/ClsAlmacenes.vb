Imports System.Data.Odbc
Imports System.Data.SqlClient

Public Class ClsAlmacenes

    Function ObtieneAlmacenes(AlmacenCod As String, AlmacenDes As String) As ADODB.Recordset

        ObtieneAlmacenes = Conexion.Execute("select * from almacenes where almacencod like '" + AlmacenCod + "%' and almacendes like '" + AlmacenDes + "%'")

    End Function

End Class


