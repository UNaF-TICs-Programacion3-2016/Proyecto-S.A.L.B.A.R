Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Public Class Analizar
    Private Sub Analizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub

    Public Sub Conectar()
        Dim Conn As New OracleConnection
        Dim CMD As New OracleCommand("Select * from PAIS_ORIGEN", Conn)
        Dim Tabla As New DataTable
        Try
            Conn.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOC OL=TCP)(HOST= )(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME =XE)));" _
                                   + "User ID=SNGA089;Password=weightlifting;"

            Dim Reader As OracleDataReader = CMD.ExecuteReader()
            Tabla.Load(Reader)
            '  Grilla.DataSource = Tabla

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class