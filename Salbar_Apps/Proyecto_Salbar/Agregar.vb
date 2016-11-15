
Public Class Agregar
    Private Sub Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PInicio.Ip_Original.IPEncontrada = False Then
            MsgBox("Ubicacion no encontrada. Por favor ingrese su ubicacion manualmente")
        Else
            TxtPais.Text += PInicio.Ip_Original.Pais
            TxtRegion.Text += PInicio.Ip_Original.Region.Replace("Province", "")
            TxtCiudad.Text += PInicio.Ip_Original.Ciudad
            TxtCoordenadas.Text += PInicio.Ip_Original.latitud + " , " + PInicio.Ip_Original.longitud
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click

    End Sub
End Class