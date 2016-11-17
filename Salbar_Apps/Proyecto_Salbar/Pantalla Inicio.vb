
Public Class PInicio
    Friend Ip_Original As New Geolocalizacion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Agregar.Show()
    End Sub

    Private Sub BtnAdministrar_Click_1(sender As Object, e As EventArgs) Handles BtnAdministrar.Click
        Administrador.Show()
    End Sub

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        VentanaAcceso.Left = 514
        VentanaAcceso.Top = 173
        TxtUser.Text = ""
        TxtPass.Text = ""
        VentanaAcceso.Visible = True
    End Sub

    Private Sub BtnNormal_Click(sender As Object, e As EventArgs) Handles BtnNormal.Click
        BtnAnalizar.Left = 591
        BtnAnalizar.Top = 404
        BtnAdministrar.Visible = False
        BtnAgregar.Visible = False
        BtnAnalizar.Visible = True
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        '======Control de acceso========
        Dim Usuario As String
        Dim Contraseña As String
        Usuario = TxtUser.Text
        Contraseña = TxtPass.Text
        If Usuario = "admin" And Contraseña = "admin" Then

            BtnAdministrar.Visible = True
            BtnAgregar.Visible = True
            BtnAnalizar.Visible = True
            BtnAnalizar.Left = 820
            BtnAnalizar.Top = 404
            VentanaAcceso.Visible = False
        Else
            MsgBox("Usuario y/o Contraseña invalida. Por favor vuelva a intentar.")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        VentanaAcceso.Visible = False
    End Sub

    Private Sub BtnAnalizar_Click(sender As Object, e As EventArgs) Handles BtnAnalizar.Click
        Analizar.Show()
    End Sub
End Class
