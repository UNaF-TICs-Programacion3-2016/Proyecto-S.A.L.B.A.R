
Public Class Agregar
    Private IP As New Geolocalizacion
    Private Sub Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miip.Text = IP.myIp
    End Sub


End Class