<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CmbEspecie = New System.Windows.Forms.ComboBox()
        Me.CmbPais = New System.Windows.Forms.ComboBox()
        Me.CmbEstaciones = New System.Windows.Forms.ComboBox()
        Me.CmbSonido = New System.Windows.Forms.ComboBox()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CmbRegion = New System.Windows.Forms.ComboBox()
        Me.CmbCiudad = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.Location = New System.Drawing.Point(12, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(908, 382)
        Me.DataGridView1.TabIndex = 0
        '
        'CmbEspecie
        '
        Me.CmbEspecie.FormattingEnabled = True
        Me.CmbEspecie.Location = New System.Drawing.Point(42, 36)
        Me.CmbEspecie.Name = "CmbEspecie"
        Me.CmbEspecie.Size = New System.Drawing.Size(121, 21)
        Me.CmbEspecie.TabIndex = 1
        '
        'CmbPais
        '
        Me.CmbPais.FormattingEnabled = True
        Me.CmbPais.Location = New System.Drawing.Point(406, 36)
        Me.CmbPais.Name = "CmbPais"
        Me.CmbPais.Size = New System.Drawing.Size(121, 21)
        Me.CmbPais.TabIndex = 2
        '
        'CmbEstaciones
        '
        Me.CmbEstaciones.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CmbEstaciones.FormattingEnabled = True
        Me.CmbEstaciones.Location = New System.Drawing.Point(222, 94)
        Me.CmbEstaciones.Name = "CmbEstaciones"
        Me.CmbEstaciones.Size = New System.Drawing.Size(121, 21)
        Me.CmbEstaciones.TabIndex = 4
        '
        'CmbSonido
        '
        Me.CmbSonido.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CmbSonido.FormattingEnabled = True
        Me.CmbSonido.Location = New System.Drawing.Point(42, 94)
        Me.CmbSonido.Name = "CmbSonido"
        Me.CmbSonido.Size = New System.Drawing.Size(121, 21)
        Me.CmbSonido.TabIndex = 5
        '
        'CmbSexo
        '
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Location = New System.Drawing.Point(222, 36)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(121, 21)
        Me.CmbSexo.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(39, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ESPECIE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker1.Location = New System.Drawing.Point(406, 95)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(195, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'CmbRegion
        '
        Me.CmbRegion.FormattingEnabled = True
        Me.CmbRegion.Location = New System.Drawing.Point(533, 36)
        Me.CmbRegion.Name = "CmbRegion"
        Me.CmbRegion.Size = New System.Drawing.Size(121, 21)
        Me.CmbRegion.TabIndex = 14
        '
        'CmbCiudad
        '
        Me.CmbCiudad.FormattingEnabled = True
        Me.CmbCiudad.Location = New System.Drawing.Point(660, 36)
        Me.CmbCiudad.Name = "CmbCiudad"
        Me.CmbCiudad.Size = New System.Drawing.Size(121, 21)
        Me.CmbCiudad.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.Location = New System.Drawing.Point(660, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button2.Location = New System.Drawing.Point(753, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(39, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "CATEGORIA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(219, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "SEXO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(219, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "ESTACION DEL AÑO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(403, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "PAIS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(530, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "REGION "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(660, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "CIUDAD"
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(932, 515)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmbCiudad)
        Me.Controls.Add(Me.CmbRegion)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbSexo)
        Me.Controls.Add(Me.CmbSonido)
        Me.Controls.Add(Me.CmbEstaciones)
        Me.Controls.Add(Me.CmbPais)
        Me.Controls.Add(Me.CmbEspecie)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Administrador"
        Me.Text = "ADMINISTRADOR"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CmbEspecie As ComboBox
    Friend WithEvents CmbPais As ComboBox
    Friend WithEvents CmbEstaciones As ComboBox
    Friend WithEvents CmbSonido As ComboBox
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CmbRegion As ComboBox
    Friend WithEvents CmbCiudad As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
