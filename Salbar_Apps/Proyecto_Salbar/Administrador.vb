Public Class Administrador
    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbSexo.Items.Add("MACHO")
        CmbSexo.Items.Add("HEMBRA")
        CmbEstaciones.Items.Add("VERANO")
        CmbEstaciones.Items.Add("OTOÑO")
        CmbEstaciones.Items.Add("INVIERNO")
        CmbEstaciones.Items.Add("PRIMAVERA")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEspecie.SelectedIndexChanged, CmbSexo.SelectedIndexChanged, CmbSonido.SelectedIndexChanged,


    End Sub
End Class