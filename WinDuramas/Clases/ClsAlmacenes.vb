Imports System.Data.Odbc
Imports System.Data.SqlClient

Public Class ClsAlmacenes

    Sub IngresaAlmacen(AlmacenCod As String, AlmacenDes As String, AlmacenRUC As String, AlmacenSerie As String, Estado As String, UsuIde As String, Detalle As String)
        Conexion.Execute("insert into almacenes(AlmacenCod,AlmacenDes,AlmacenRUC,AlmacenSerie,Estado,UsuIde,Detalle) values ('" + AlmacenCod + "','" + AlmacenDes + "','" + AlmacenRUC + "','" + AlmacenSerie + "','" + Estado + "','" + UsuIde + "','" + Detalle + "')")
    End Sub

    Sub ActualizaAlmacen(AlmacenCod As String, AlmacenDes As String, AlmacenRUC As String, AlmacenSerie As String, Estado As String, UsuIde As String, Detalle As String)
        Conexion.Execute("update almacenes  set AlmacenDes='" + AlmacenDes + "',AlmacenRUC='" + AlmacenRUC + "',AlmacenSerie='" + AlmacenSerie + "',Estado='" + Estado + "',UsuIde='" + UsuIde + "',Detalle='" + Detalle + "' where almacencod='" + AlmacenCod + "'")
    End Sub

    Function EliminaAlmacen(Almacen As String) As Integer
        On Error GoTo Errores
        Dim Pos As Integer

        Conexion.Execute("delete from almacenes where almacencod='" + Almacen + "'")
        Exit Function

Errores:
        If Err.Number = -2147217900 Then
            Pos = InStr(1, Err.Description, "tabla")
            If Pos > 0 Then
                MessageBox.Show("No se puede eliminar INFORMACION porque tiene registros relacionados (" + Mid(Err.Description, Pos) + ")")
            Else
                MessageBox.Show("No se puede eliminar INFORMACION porque tiene registros relacionados.")
            End If
        End If
        Exit Function
    End Function

    Function ObtieneAlmacenes(AlmacenCod As String, AlmacenDes As String) As ADODB.Recordset

        ObtieneAlmacenes = Conexion.Execute("select * from almacenes where almacencod like '" + AlmacenCod + "%' and almacendes like '" + AlmacenDes + "%'")

    End Function

    Function BuscaAlmacen(Almacen As String) As ADODB.Recordset
        BuscaAlmacen = Conexion.Execute("select * from almacenes where almacencod='" + Almacen + "'")
    End Function

    Sub IngresaComprobanteAlmacen(AlmacenCod)
        Dim Tabla As New ADODB.Recordset
        Dim BenDeu As Integer

        Tabla = Conexion.Execute("select * from comprbt where almacencod='01'")
        Do While Not Tabla.EOF
            On Error Resume Next
            BenDeu = 0
            If Tabla.Fields("ComprbtBenDeu").Value Then
                BenDeu = 1
            End If
            Conexion.Execute("insert into comprbt(AlmacenCod,ComprbtCod,ComprbtDes,ComprbtNum,SistemaCod,ProtEncaNum,Estado,UsuIde,ComprbtBenDeu,ComprbtPriori,ComprbtReporte) values('" + AlmacenCod + "','" + Tabla.Fields("ComprbtCod").Value + "','" + Tabla.Fields("ComprbtDes").Value + "',0,'" + Tabla.Fields("SistemaCod").Value + "',0,'N','ASAI'," + CStr(BenDeu) + "," + CStr(Tabla.Fields("ComprbtPriori").Value) + ",'" + Tabla.Fields("ComprbtReporte").Value + "')")
            On Error GoTo 0
            Tabla.MoveNext()
        Loop
    End Sub

End Class


