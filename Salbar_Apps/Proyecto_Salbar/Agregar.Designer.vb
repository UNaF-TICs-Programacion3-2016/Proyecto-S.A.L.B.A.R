<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agregar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CmbEspecie = New System.Windows.Forms.ComboBox()
        Me.CmbCategoriaAnimal = New System.Windows.Forms.ComboBox()
        Me.CmbTipoSonido = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblPais = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LblRegion = New System.Windows.Forms.Label()
        Me.LblCiudad = New System.Windows.Forms.Label()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.TxtRegion = New System.Windows.Forms.TextBox()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.CmbEstaciones = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CARGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(300, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "GRABAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CmbEspecie
        '
        Me.CmbEspecie.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.CmbEspecie.FormattingEnabled = True
        Me.CmbEspecie.Location = New System.Drawing.Point(415, 54)
        Me.CmbEspecie.Name = "CmbEspecie"
        Me.CmbEspecie.Size = New System.Drawing.Size(201, 21)
        Me.CmbEspecie.TabIndex = 2
        '
        'CmbCategoriaAnimal
        '
        Me.CmbCategoriaAnimal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.CmbCategoriaAnimal.FormattingEnabled = True
        Me.CmbCategoriaAnimal.Location = New System.Drawing.Point(412, 99)
        Me.CmbCategoriaAnimal.Name = "CmbCategoriaAnimal"
        Me.CmbCategoriaAnimal.Size = New System.Drawing.Size(201, 21)
        Me.CmbCategoriaAnimal.TabIndex = 3
        '
        'CmbTipoSonido
        '
        Me.CmbTipoSonido.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.CmbTipoSonido.FormattingEnabled = True
        Me.CmbTipoSonido.Location = New System.Drawing.Point(412, 207)
        Me.CmbTipoSonido.Name = "CmbTipoSonido"
        Me.CmbTipoSonido.Size = New System.Drawing.Size(201, 21)
        Me.CmbTipoSonido.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(412, 33)
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
        Me.Label2.Location = New System.Drawing.Point(412, 78)
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
        Me.Label3.Location = New System.Drawing.Point(408, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "TIPO DE SONIDO"
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.BackColor = System.Drawing.Color.Lime
        Me.BtnConfirmar.Location = New System.Drawing.Point(472, 463)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConfirmar.TabIndex = 11
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Red
        Me.BtnCancelar.Location = New System.Drawing.Point(601, 463)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 12
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LblPais
        '
        Me.LblPais.AutoSize = True
        Me.LblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPais.Location = New System.Drawing.Point(412, 290)
        Me.LblPais.Name = "LblPais"
        Me.LblPais.Size = New System.Drawing.Size(48, 20)
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
        Me.LblRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegion.Location = New System.Drawing.Point(389, 336)
        Me.LblRegion.Name = "LblRegion"
        Me.LblRegion.Size = New System.Drawing.Size(71, 20)
        Me.LblRegion.TabIndex = 14
        Me.LblRegion.Text = "Region:"
        '
        'LblCiudad
        '
        Me.LblCiudad.AutoSize = True
        Me.LblCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCiudad.Location = New System.Drawing.Point(390, 386)
        Me.LblCiudad.Name = "LblCiudad"
        Me.LblCiudad.Size = New System.Drawing.Size(70, 20)
        Me.LblCiudad.TabIndex = 16
        Me.LblCiudad.Text = "Ciudad:"
        '
        'TxtPais
        '
        Me.TxtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPais.Location = New System.Drawing.Point(472, 288)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.Size = New System.Drawing.Size(204, 22)
        Me.TxtPais.TabIndex = 17
        '
        'TxtRegion
        '
        Me.TxtRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegion.Location = New System.Drawing.Point(472, 333)
        Me.TxtRegion.Name = "TxtRegion"
        Me.TxtRegion.Size = New System.Drawing.Size(203, 22)
        Me.TxtRegion.TabIndex = 18
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiudad.Location = New System.Drawing.Point(472, 381)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(201, 22)
        Me.TxtCiudad.TabIndex = 19
        '
        'CmbSexo
        '
        Me.CmbSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Location = New System.Drawing.Point(412, 146)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(201, 21)
        Me.CmbSexo.TabIndex = 21
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.BackColor = System.Drawing.Color.Transparent
        Me.LblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSexo.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblSexo.Location = New System.Drawing.Point(414, 123)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(58, 20)
        Me.LblSexo.TabIndex = 22
        Me.LblSexo.Text = "SEXO"
        '
        'CmbEstaciones
        '
        Me.CmbEstaciones.FormattingEnabled = True
        Me.CmbEstaciones.Location = New System.Drawing.Point(22, 235)
        Me.CmbEstaciones.Name = "CmbEstaciones"
        Me.CmbEstaciones.Size = New System.Drawing.Size(201, 21)
        Me.CmbEstaciones.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(18, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "ESTACION DEL AÑO"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 329)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(18, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "FECHA"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(124, 277)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker1.TabIndex = 27
        Me.DateTimePicker1.Value = New Date(2016, 11, 17, 11, 36, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(18, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "HORA"
        '
        'Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Proyecto_Salbar.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(687, 498)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbEstaciones)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.CmbSexo)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.TxtRegion)
        Me.Controls.Add(Me.TxtPais)
        Me.Controls.Add(Me.LblCiudad)
        Me.Controls.Add(Me.LblRegion)
        Me.Controls.Add(Me.LblPais)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnConfirmar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbTipoSonido)
        Me.Controls.Add(Me.CmbCategoriaAnimal)
        Me.Controls.Add(Me.CmbEspecie)
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
    Friend WithEvents CmbEspecie As ComboBox
    Friend WithEvents CmbCategoriaAnimal As ComboBox
    Friend WithEvents CmbTipoSonido As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblPais As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LblRegion As Label
    Friend WithEvents LblCiudad As Label
    Friend WithEvents TxtPais As TextBox
    Friend WithEvents TxtRegion As TextBox
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents LblSexo As Label
    Friend WithEvents CmbEstaciones As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents DateTimePicker1 As DateTimePicker
End Class
