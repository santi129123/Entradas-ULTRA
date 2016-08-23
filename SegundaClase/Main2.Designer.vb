<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SUPERVIP1 = New System.Windows.Forms.Button()
        Me.VIP1 = New System.Windows.Forms.Button()
        Me.GENERAL1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PRECIOTOTAL = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TOTAL2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(347, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(347, 311)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'SUPERVIP1
        '
        Me.SUPERVIP1.BackColor = System.Drawing.Color.Black
        Me.SUPERVIP1.ForeColor = System.Drawing.Color.White
        Me.SUPERVIP1.Location = New System.Drawing.Point(12, 114)
        Me.SUPERVIP1.Name = "SUPERVIP1"
        Me.SUPERVIP1.Size = New System.Drawing.Size(75, 23)
        Me.SUPERVIP1.TabIndex = 4
        Me.SUPERVIP1.Text = "SUPER VIP"
        Me.SUPERVIP1.UseVisualStyleBackColor = False
        '
        'VIP1
        '
        Me.VIP1.BackColor = System.Drawing.Color.Black
        Me.VIP1.ForeColor = System.Drawing.Color.White
        Me.VIP1.Location = New System.Drawing.Point(12, 156)
        Me.VIP1.Name = "VIP1"
        Me.VIP1.Size = New System.Drawing.Size(75, 23)
        Me.VIP1.TabIndex = 5
        Me.VIP1.Text = "VIP"
        Me.VIP1.UseVisualStyleBackColor = False
        '
        'GENERAL1
        '
        Me.GENERAL1.BackColor = System.Drawing.Color.Black
        Me.GENERAL1.ForeColor = System.Drawing.Color.White
        Me.GENERAL1.Location = New System.Drawing.Point(12, 199)
        Me.GENERAL1.Name = "GENERAL1"
        Me.GENERAL1.Size = New System.Drawing.Size(75, 23)
        Me.GENERAL1.TabIndex = 6
        Me.GENERAL1.Text = "GENERAL"
        Me.GENERAL1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(26, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ENTRADAS DE EVENTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(12, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(319, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "FECHA: 30 AGO. 10PM COSTA VERDE - BARRANCO "
        '
        'PRECIOTOTAL
        '
        Me.PRECIOTOTAL.AutoSize = True
        Me.PRECIOTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRECIOTOTAL.Location = New System.Drawing.Point(147, 156)
        Me.PRECIOTOTAL.Name = "PRECIOTOTAL"
        Me.PRECIOTOTAL.Size = New System.Drawing.Size(0, 24)
        Me.PRECIOTOTAL.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(141, 243)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "COMPRAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(320, 69)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(29, 24)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "X"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TOTAL2
        '
        Me.TOTAL2.AutoSize = True
        Me.TOTAL2.BackColor = System.Drawing.Color.Black
        Me.TOTAL2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TOTAL2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL2.ForeColor = System.Drawing.Color.White
        Me.TOTAL2.Location = New System.Drawing.Point(27, 311)
        Me.TOTAL2.Name = "TOTAL2"
        Me.TOTAL2.Size = New System.Drawing.Size(0, 12)
        Me.TOTAL2.TabIndex = 12
        '
        'Main2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(349, 379)
        Me.ControlBox = False
        Me.Controls.Add(Me.TOTAL2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PRECIOTOTAL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GENERAL1)
        Me.Controls.Add(Me.VIP1)
        Me.Controls.Add(Me.SUPERVIP1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SUPERVIP1 As Button
    Friend WithEvents VIP1 As Button
    Friend WithEvents GENERAL1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PRECIOTOTAL As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TOTAL2 As Label
End Class
