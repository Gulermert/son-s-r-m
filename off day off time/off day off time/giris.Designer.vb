﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Giris
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 35!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(670, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BAŞLAMAYA HAZIR MIYIZ?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(738, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 61)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "YENİ KULLANICI KAYDI"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 10!)
        Me.Label2.Location = New System.Drawing.Point(316, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(366, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "GİRİŞ YAPMAK İSTEDİĞİNİZ KULLANICIYI SEÇİNİZ"
        '
        'giris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1167, 315)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "giris"
        Me.Text = "giris"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
