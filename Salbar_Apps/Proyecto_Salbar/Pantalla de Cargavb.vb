Public Class Pantalla_de_Cargavb
    Friend IP As New Geolocalizacion
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 25
        Else
            Me.Hide()
            PInicio.Show()
            Timer1.Enabled = False
        End If


    End Sub

    Private Sub Pantalla_de_Cargavb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = True
        Me.Show()
        IP.myIp()
    End Sub
End Class