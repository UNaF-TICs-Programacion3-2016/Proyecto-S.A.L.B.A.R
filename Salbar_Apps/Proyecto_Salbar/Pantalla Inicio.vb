
Public Class PInicio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Analizar.Show()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Agregar.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Administrador.Show()
    End Sub
End Class
