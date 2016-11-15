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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Proyecto_Salbar.My.Resources.Resources.sine_waves_analysis_318_86275
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(820, 404)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 59)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Analizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(591, 404)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 59)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Revisar Sonidos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Image = Global.Proyecto_Salbar.My.Resources.Resources.agregar
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregar.Location = New System.Drawing.Point(372, 404)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(141, 59)
        Me.BtnAgregar.TabIndex = 5
        Me.BtnAgregar.Text = "Nuevo Sonido"
        Me.BtnAgregar.UseVisualStyleBackColor = True
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
        'PInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = Global.Proyecto_Salbar.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1091, 475)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TITULO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "PInicio"
        Me.Text = "SALBAR - Pantalla Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TITULO As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
