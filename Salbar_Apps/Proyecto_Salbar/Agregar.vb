Public Class Agregar
    Private Sub Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Hora As Date
        DateTimePicker1.Value = Hora.Now
        CmbSexo.Items.Add("MACHO")
        CmbSexo.Items.Add("HEMBRA")
        CmbEstaciones.Items.Add("VERANO")
        CmbEstaciones.Items.Add("OTOÑO")
        CmbEstaciones.Items.Add("INVIERNO")
        CmbEstaciones.Items.Add("PRIMAVERA")


        If PInicio.Ip_Original.IPEncontrada = False Then
            MsgBox("Ubicacion no encontrada. Por favor ingrese su ubicacion manualmente")
        Else
            TxtPais.Text += PInicio.Ip_Original.Pais
            TxtRegion.Text += PInicio.Ip_Original.Region.Replace("Province", "")
            TxtCiudad.Text += PInicio.Ip_Original.Ciudad
        End If

    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("Hola :) , aun no lo terminamos. Perdón")

    End Sub
End Class