<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(450, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GİRiŞ YAPMAK İSTEDİĞİNİZ HOBİNİZİ SEÇİNİZ"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(485, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "KULLANICI BİLGİLERİNİ GÖRÜNTÜLE"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(522, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 38)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "KULLANICI DEĞİŞTİR"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = true
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(635, 275)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Name = "menu"
        Me.Text = "menu"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
