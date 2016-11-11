Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public MustInherit Class Conexion
    Public Shared Function Consultar_en_la_BD(Animal As String) As DataTable
        Dim Conn As New OracleConnection("Data Source = localhost;User id = SALBAR;Password = salbar")
        Dim DS_Frecuencia As New DataSet
        Dim Adapter As New OracleDataAdapter("SELECT * FROM ENTIDAD_CAB WHERE NOMBRE_ENT = " & Animal, Conn)
        Try
            Adapter.Fill(DS_Frecuencia, "ENTIDAD_CAB")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return DS_Frecuencia.Tables("ENTIDAD_CAB")
    End Function

    Public Shared Sub Guardar_Frecuencia()

    End Sub
End Class
