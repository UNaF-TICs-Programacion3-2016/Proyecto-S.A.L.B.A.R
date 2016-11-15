
Public Class Agregar
    Private Sub Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miip.Text = "Coordenadas:" + Pantalla_de_Cargavb.IP.latitud + "," + Pantalla_de_Cargavb.IP.longitud
    End Sub
End Class