<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gaktivite
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
        Me.components = New System.ComponentModel.Container()
        Me.ktxt = New System.Windows.Forms.MaskedTextBox()
        Me.itxt = New System.Windows.Forms.MaskedTextBox()
        Me.utxt = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ktxt
        '
        Me.ktxt.Location = New System.Drawing.Point(147, 126)
        Me.ktxt.Mask = "00:00"
        Me.ktxt.Name = "ktxt"
        Me.ktxt.Size = New System.Drawing.Size(129, 20)
        Me.ktxt.TabIndex = 33
        Me.ktxt.ValidatingType = GetType(Date)
        '
        'itxt
        '
        Me.itxt.Location = New System.Drawing.Point(147, 86)
        Me.itxt.Mask = "00:00"
        Me.itxt.Name = "itxt"
        Me.itxt.Size = New System.Drawing.Size(129, 20)
        Me.itxt.TabIndex = 32
        Me.itxt.ValidatingType = GetType(Date)
        '
        'utxt
        '
        Me.utxt.Location = New System.Drawing.Point(147, 36)
        Me.utxt.Mask = "00:00"
        Me.utxt.Name = "utxt"
        Me.utxt.Size = New System.Drawing.Size(129, 20)
        Me.utxt.TabIndex = 31
        Me.utxt.ValidatingType = GetType(Date)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Location = New System.Drawing.Point(527, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 177)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "RENK DAĞILIMLARI"
        Me.GroupBox1.Visible = false
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(64, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "KENDİ ZAMANINIZ"
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(62, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "AKTİVİTE ZAMANI"
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(61, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "KİŞİSEL ZAMAN"
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(64, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "UYUMA"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Blue
        Me.TextBox6.Location = New System.Drawing.Point(34, 73)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(21, 20)
        Me.TextBox6.TabIndex = 26
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.TextBox7.Location = New System.Drawing.Point(34, 99)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(21, 20)
        Me.TextBox7.TabIndex = 25
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Yellow
        Me.TextBox8.Location = New System.Drawing.Point(34, 128)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(21, 20)
        Me.TextBox8.TabIndex = 24
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Green
        Me.TextBox9.Location = New System.Drawing.Point(34, 46)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(21, 20)
        Me.TextBox9.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(61, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "İŞ/OKUL"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Red
        Me.TextBox10.Location = New System.Drawing.Point(34, 21)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(21, 20)
        Me.TextBox10.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 50)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "HESAPLA"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(10, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Kişisel işlere ayrılan süre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(25, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "İş/okul'a ayrılan süre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(38, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Uyuma Süresi:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Günlük Aktivitelerini Giriniz"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(18, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 50)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "KAYDET"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'gaktivite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 287)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ktxt)
        Me.Controls.Add(Me.itxt)
        Me.Controls.Add(Me.utxt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "gaktivite"
        Me.Text = "gaktivite"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ktxt As MaskedTextBox
    Friend WithEvents itxt As MaskedTextBox
    Friend WithEvents utxt As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Button2 As Button
End Class
