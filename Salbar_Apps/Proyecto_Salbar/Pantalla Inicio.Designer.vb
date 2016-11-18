<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PInicio))
        Me.TITULO = New System.Windows.Forms.Label()
        Me.BtnAnalizar = New System.Windows.Forms.Button()
        Me.BtnAdministrar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAdmin = New System.Windows.Forms.Button()
        Me.BtnNormal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VentanaAcceso = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VentanaAcceso.SuspendLayout()
        Me.SuspendLayout()
        '
        'TITULO
        '
        Me.TITULO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TITULO.BackColor = System.Drawing.Color.Transparent
        Me.TITULO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TITULO.Font = New System.Drawing.Font("Verdana", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITULO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TITULO.Location = New System.Drawing.Point(377, 158)
        Me.TITULO.Name = "TITULO"
        Me.TITULO.Size = New System.Drawing.Size(687, 116)
        Me.TITULO.TabIndex = 0
        Me.TITULO.Text = "S.A.L.B.A.R."
        '
        'BtnAnalizar
        '
        Me.BtnAnalizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnAnalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnalizar.Image = Global.Proyecto_Salbar.My.Resources.Resources.sine_waves_analysis_318_86275
        Me.BtnAnalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAnalizar.Location = New System.Drawing.Point(820, 404)
        Me.BtnAnalizar.Name = "BtnAnalizar"
        Me.BtnAnalizar.Size = New System.Drawing.Size(151, 59)
        Me.BtnAnalizar.TabIndex = 7
        Me.BtnAnalizar.Text = "Analizar"
        Me.BtnAnalizar.UseVisualStyleBackColor = True
        Me.BtnAnalizar.Visible = False
        '
        'BtnAdministrar
        '
        Me.BtnAdministrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnAdministrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdministrar.Image = CType(resources.GetObject("BtnAdministrar.Image"), System.Drawing.Image)
        Me.BtnAdministrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdministrar.Location = New System.Drawing.Point(591, 404)
        Me.BtnAdministrar.Name = "BtnAdministrar"
        Me.BtnAdministrar.Size = New System.Drawing.Size(155, 59)
        Me.BtnAdministrar.TabIndex = 6
        Me.BtnAdministrar.Text = "Revisar Sonidos"
        Me.BtnAdministrar.UseVisualStyleBackColor = True
        Me.BtnAdministrar.Visible = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Image = Global.Proyecto_Salbar.My.Resources.Resources.agregar
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregar.Location = New System.Drawing.Point(372, 404)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(141, 59)
        Me.BtnAgregar.TabIndex = 5
        Me.BtnAgregar.Text = "Nuevo Sonido"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        Me.BtnAgregar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Proyecto_Salbar.My.Resources.Resources._21505311_Green_Parrot_Vector_de_dibujos_animados_Ilustraci_n_Foto_de_archivo
        Me.PictureBox1.InitialImage = Global.Proyecto_Salbar.My.Resources.Resources._21505311_Green_Parrot_Vector_de_dibujos_animados_Ilustraci_n_Foto_de_archivo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(366, 330)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnAdmin
        '
        Me.BtnAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnAdmin.Location = New System.Drawing.Point(493, 334)
        Me.BtnAdmin.Name = "BtnAdmin"
        Me.BtnAdmin.Size = New System.Drawing.Size(120, 23)
        Me.BtnAdmin.TabIndex = 8
        Me.BtnAdmin.Text = "ADMINISTRADOR"
        Me.BtnAdmin.UseVisualStyleBackColor = True
        '
        'BtnNormal
        '
        Me.BtnNormal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnNormal.Location = New System.Drawing.Point(695, 334)
        Me.BtnNormal.Name = "BtnNormal"
        Me.BtnNormal.Size = New System.Drawing.Size(114, 23)
        Me.BtnNormal.TabIndex = 9
        Me.BtnNormal.Text = "NORMAL"
        Me.BtnNormal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(591, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tipo de Usuario"
        '
        'VentanaAcceso
        '
        Me.VentanaAcceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.VentanaAcceso.Controls.Add(Me.BtnCancelar)
        Me.VentanaAcceso.Controls.Add(Me.BtnAceptar)
        Me.VentanaAcceso.Controls.Add(Me.TxtPass)
        Me.VentanaAcceso.Controls.Add(Me.TxtUser)
        Me.VentanaAcceso.Controls.Add(Me.Label3)
        Me.VentanaAcceso.Controls.Add(Me.Label2)
        Me.VentanaAcceso.Location = New System.Drawing.Point(1081, 12)
        Me.VentanaAcceso.Name = "VentanaAcceso"
        Me.VentanaAcceso.Size = New System.Drawing.Size(301, 204)
        Me.VentanaAcceso.TabIndex = 11
        Me.VentanaAcceso.TabStop = False
        Me.VentanaAcceso.Text = "Ventana de Acceso"
        Me.VentanaAcceso.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Location = New System.Drawing.Point(158, 161)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAceptar.Location = New System.Drawing.Point(77, 161)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(124, 118)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(100, 20)
        Me.TxtPass.TabIndex = 3
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(124, 62)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(100, 20)
        Me.TxtUser.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "CONTRASEÑA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "USUARIO"
        '
        'PInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = Global.Proyecto_Salbar.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1091, 475)
        Me.Controls.Add(Me.BtnAnalizar)
        Me.Controls.Add(Me.VentanaAcceso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnNormal)
        Me.Controls.Add(Me.BtnAdmin)
        Me.Controls.Add(Me.BtnAdministrar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TITULO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PInicio"
        Me.Text = "Pantalla de Inicio - SALBAR"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VentanaAcceso.ResumeLayout(False)
        Me.VentanaAcceso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TITULO As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnAdministrar As Button
    Friend WithEvents BtnAnalizar As Button
    Friend WithEvents BtnAdmin As Button
    Friend WithEvents BtnNormal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents VentanaAcceso As GroupBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
End Class
