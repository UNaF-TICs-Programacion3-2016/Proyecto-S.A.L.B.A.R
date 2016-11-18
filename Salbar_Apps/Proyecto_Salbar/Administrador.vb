Public Class Administrador
    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbSexo.Items.Add("MACHO")
        CmbSexo.Items.Add("HEMBRA")
        CmbEstaciones.Items.Add("VERANO")
        CmbEstaciones.Items.Add("OTOÑO")
        CmbEstaciones.Items.Add("INVIERNO")
        CmbEstaciones.Items.Add("PRIMAVERA")
    End Sub

    Private Sub CmbEspecie_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles CmbEspecie.SelectedIndexChanged, CmbSexo.SelectedIndexChanged,
                CmbSonido.SelectedIndexChanged, CmbEstaciones.SelectedIndexChanged,
                CmbPais.SelectedIndexChanged, CmbRegion.SelectedIndexChanged, CmbCiudad.SelectedIndexChanged
        MsgBox("HOLA :)", vbInformation)
    End Sub
End Class