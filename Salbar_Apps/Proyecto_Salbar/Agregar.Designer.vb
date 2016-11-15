<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblPais = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LblRegion = New System.Windows.Forms.Label()
        Me.LblCoordenadas = New System.Windows.Forms.Label()
        Me.LblCiudad = New System.Windows.Forms.Label()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.TxtRegion = New System.Windows.Forms.TextBox()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.TxtCoordenadas = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CARGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(300, 146)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "GRABAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(475, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(201, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(475, 109)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(201, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(475, 193)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(201, 21)
        Me.ComboBox3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(472, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ESPECIE ANIMAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(475, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "TIPO DE ANIMAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(471, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "TIPO DE SONIDO"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(475, 252)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(21, 207)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(416, 269)
        Me.WebBrowser1.TabIndex = 10
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.BackColor = System.Drawing.Color.Lime
        Me.BtnConfirmar.Location = New System.Drawing.Point(475, 453)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConfirmar.TabIndex = 11
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Red
        Me.BtnCancelar.Location = New System.Drawing.Point(740, 453)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 12
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LblPais
        '
        Me.LblPais.AutoSize = True
        Me.LblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPais.Location = New System.Drawing.Point(474, 289)
        Me.LblPais.Name = "LblPais"
        Me.LblPais.Size = New System.Drawing.Size(55, 24)
        Me.LblPais.TabIndex = 13
        Me.LblPais.Text = "Pais:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Proyecto_Salbar.My.Resources.Resources._21505311_Green_Parrot_Vector_de_dibujos_animados_Ilustraci_n_Foto_de_archivo
        Me.PictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 189)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LblRegion
        '
        Me.LblRegion.AutoSize = True
        Me.LblRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegion.Location = New System.Drawing.Point(474, 321)
        Me.LblRegion.Name = "LblRegion"
        Me.LblRegion.Size = New System.Drawing.Size(83, 24)
        Me.LblRegion.TabIndex = 14
        Me.LblRegion.Text = "Region:"
        '
        'LblCoordenadas
        '
        Me.LblCoordenadas.AutoSize = True
        Me.LblCoordenadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCoordenadas.Location = New System.Drawing.Point(471, 383)
        Me.LblCoordenadas.Name = "LblCoordenadas"
        Me.LblCoordenadas.Size = New System.Drawing.Size(141, 24)
        Me.LblCoordenadas.TabIndex = 15
        Me.LblCoordenadas.Text = "Coordenadas:"
        '
        'LblCiudad
        '
        Me.LblCiudad.AutoSize = True
        Me.LblCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCiudad.Location = New System.Drawing.Point(474, 352)
        Me.LblCiudad.Name = "LblCiudad"
        Me.LblCiudad.Size = New System.Drawing.Size(82, 24)
        Me.LblCiudad.TabIndex = 16
        Me.LblCiudad.Text = "Ciudad:"
        '
        'TxtPais
        '
        Me.TxtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPais.Location = New System.Drawing.Point(535, 286)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.Size = New System.Drawing.Size(320, 29)
        Me.TxtPais.TabIndex = 17
        '
        'TxtRegion
        '
        Me.TxtRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegion.Location = New System.Drawing.Point(562, 318)
        Me.TxtRegion.Name = "TxtRegion"
        Me.TxtRegion.Size = New System.Drawing.Size(293, 29)
        Me.TxtRegion.TabIndex = 18
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiudad.Location = New System.Drawing.Point(562, 349)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(293, 29)
        Me.TxtCiudad.TabIndex = 19
        '
        'TxtCoordenadas
        '
        Me.TxtCoordenadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCoordenadas.Location = New System.Drawing.Point(618, 381)
        Me.TxtCoordenadas.Name = "TxtCoordenadas"
        Me.TxtCoordenadas.Size = New System.Drawing.Size(237, 29)
        Me.TxtCoordenadas.TabIndex = 20
        '
        'Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Proyecto_Salbar.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(880, 498)
        Me.Controls.Add(Me.TxtCoordenadas)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.TxtRegion)
        Me.Controls.Add(Me.TxtPais)
        Me.Controls.Add(Me.LblCiudad)
        Me.Controls.Add(Me.LblCoordenadas)
        Me.Controls.Add(Me.LblRegion)
        Me.Controls.Add(Me.LblPais)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnConfirmar)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Agregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblPais As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LblRegion As Label
    Friend WithEvents LblCoordenadas As Label
    Friend WithEvents LblCiudad As Label
    Friend WithEvents TxtPais As TextBox
    Friend WithEvents TxtRegion As TextBox
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents TxtCoordenadas As TextBox
End Class
