Public Class Pantalla_de_Cargavb
    Friend temp As New Geolocalizacion
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        '==========PROCESO DE CARGA=========
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 25
        Else
            PInicio.Ip_Original = temp
            PInicio.Show()
            Timer1.Stop()
            Me.Hide()
        End If
        '==================================

    End Sub

    Private Sub Pantalla_de_Cargavb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()

        '===========OPTENCION DE DIRECCION==========
        temp.myIp()
        '===========================================
    End Sub
End Class