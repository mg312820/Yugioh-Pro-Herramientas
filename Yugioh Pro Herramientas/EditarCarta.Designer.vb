<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditarCarta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ChbATKDEF = New System.Windows.Forms.CheckBox()
        Me.chbNombre = New System.Windows.Forms.CheckBox()
        Me.ChbId = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Chbnivel = New System.Windows.Forms.CheckBox()
        Me.CHBAtributo = New System.Windows.Forms.CheckBox()
        Me.cbnivel = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CHBTraducida = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBAtributo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(40, 308)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(261, 20)
        Me.txtNombre.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(26, 350)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(311, 166)
        Me.txtDescripcion.TabIndex = 8
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.ChbATKDEF)
        Me.Panel1.Controls.Add(Me.chbNombre)
        Me.Panel1.Controls.Add(Me.ChbId)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.Chbnivel)
        Me.Panel1.Controls.Add(Me.CHBAtributo)
        Me.Panel1.Controls.Add(Me.cbnivel)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.CHBTraducida)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CBAtributo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtnombreB)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtid)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(329, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 572)
        Me.Panel1.TabIndex = 13
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Yugioh_Pro_Herramientas.My.Resources.Resources.buscar
        Me.PictureBox3.Location = New System.Drawing.Point(190, 258)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(94, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 55
        Me.PictureBox3.TabStop = False
        '
        'ChbATKDEF
        '
        Me.ChbATKDEF.AutoSize = True
        Me.ChbATKDEF.Location = New System.Drawing.Point(322, 185)
        Me.ChbATKDEF.Name = "ChbATKDEF"
        Me.ChbATKDEF.Size = New System.Drawing.Size(15, 14)
        Me.ChbATKDEF.TabIndex = 54
        Me.ChbATKDEF.UseVisualStyleBackColor = True
        '
        'chbNombre
        '
        Me.chbNombre.AutoSize = True
        Me.chbNombre.Location = New System.Drawing.Point(322, 60)
        Me.chbNombre.Name = "chbNombre"
        Me.chbNombre.Size = New System.Drawing.Size(15, 14)
        Me.chbNombre.TabIndex = 53
        Me.chbNombre.UseVisualStyleBackColor = True
        '
        'ChbId
        '
        Me.ChbId.AutoSize = True
        Me.ChbId.Location = New System.Drawing.Point(322, 86)
        Me.ChbId.Name = "ChbId"
        Me.ChbId.Size = New System.Drawing.Size(15, 14)
        Me.ChbId.TabIndex = 52
        Me.ChbId.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 443)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 24)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Cartas"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Yugioh_Pro_Herramientas.My.Resources.Resources.carpeta
        Me.PictureBox6.Location = New System.Drawing.Point(119, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(107, 42)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 50
        Me.PictureBox6.TabStop = False
        '
        'Chbnivel
        '
        Me.Chbnivel.AutoSize = True
        Me.Chbnivel.Location = New System.Drawing.Point(322, 147)
        Me.Chbnivel.Name = "Chbnivel"
        Me.Chbnivel.Size = New System.Drawing.Size(15, 14)
        Me.Chbnivel.TabIndex = 47
        Me.Chbnivel.UseVisualStyleBackColor = True
        '
        'CHBAtributo
        '
        Me.CHBAtributo.AutoSize = True
        Me.CHBAtributo.Location = New System.Drawing.Point(322, 112)
        Me.CHBAtributo.Name = "CHBAtributo"
        Me.CHBAtributo.Size = New System.Drawing.Size(15, 14)
        Me.CHBAtributo.TabIndex = 46
        Me.CHBAtributo.UseVisualStyleBackColor = True
        '
        'cbnivel
        '
        Me.cbnivel.FormattingEnabled = True
        Me.cbnivel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbnivel.Location = New System.Drawing.Point(164, 138)
        Me.cbnivel.Name = "cbnivel"
        Me.cbnivel.Size = New System.Drawing.Size(153, 32)
        Me.cbnivel.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(2, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 24)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Nivel"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(417, 443)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 24)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "0"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Yugioh_Pro_Herramientas.My.Resources.Resources.Select_Bd
        Me.PictureBox5.Location = New System.Drawing.Point(602, 523)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(126, 39)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 36
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Yugioh_Pro_Herramientas.My.Resources.Resources.Reset
        Me.PictureBox4.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(107, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        '
        'CHBTraducida
        '
        Me.CHBTraducida.AutoSize = True
        Me.CHBTraducida.BackColor = System.Drawing.Color.Transparent
        Me.CHBTraducida.Location = New System.Drawing.Point(190, 224)
        Me.CHBTraducida.Name = "CHBTraducida"
        Me.CHBTraducida.Size = New System.Drawing.Size(115, 28)
        Me.CHBTraducida.TabIndex = 34
        Me.CHBTraducida.Text = "Traducido"
        Me.CHBTraducida.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(346, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.Size = New System.Drawing.Size(385, 430)
        Me.DataGridView1.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(202, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 24)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "DEF"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(89, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 24)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "ATK"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(254, 176)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(62, 29)
        Me.TextBox6.TabIndex = 28
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(142, 176)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(54, 29)
        Me.TextBox5.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(2, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Atributo"
        '
        'CBAtributo
        '
        Me.CBAtributo.FormattingEnabled = True
        Me.CBAtributo.Location = New System.Drawing.Point(164, 103)
        Me.CBAtributo.Name = "CBAtributo"
        Me.CBAtributo.Size = New System.Drawing.Size(153, 32)
        Me.CBAtributo.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(3, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Nombre"
        '
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(165, 51)
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(153, 29)
        Me.txtnombreB.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(2, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Codigo de Carta"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(165, 77)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(153, 29)
        Me.txtid.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Yugioh_Pro_Herramientas.My.Resources.Resources.Modificar
        Me.PictureBox1.InitialImage = Global.Yugioh_Pro_Herramientas.My.Resources.Resources.Modificar
        Me.PictureBox1.Location = New System.Drawing.Point(114, 522)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(71, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(194, 269)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(-17, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(343, 572)
        Me.Panel2.TabIndex = 14
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Yugioh_Pro_Herramientas.My.Resources.Resources._5b1872e2c3773
        Me.ClientSize = New System.Drawing.Size(1072, 576)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CHBTraducida As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombreB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label11 As Label
    Friend WithEvents cbnivel As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Chbnivel As CheckBox
    Friend WithEvents CHBAtributo As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Public WithEvents CBAtributo As ComboBox
    Friend WithEvents chbNombre As CheckBox
    Friend WithEvents ChbId As CheckBox
    Friend WithEvents ChbATKDEF As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
End Class
