
Public Class Agregar
    Private Sub Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miip.Text = "Coordenadas:" + Pantalla_de_Cargavb.IP.latitud + "," + Pantalla_de_Cargavb.IP.longitud
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Archivos WAV(.wav)|*.wav"
        OpenFileDialog1.ShowDialog()

    End Sub
End Class