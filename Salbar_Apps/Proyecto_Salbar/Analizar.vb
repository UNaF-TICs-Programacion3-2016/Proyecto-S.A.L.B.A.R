Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Public Class Analizar
    Private Sub Analizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub

    Public Sub Conectar()


        Try
            MsgBox("Holi. aun no termino esta parte")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class