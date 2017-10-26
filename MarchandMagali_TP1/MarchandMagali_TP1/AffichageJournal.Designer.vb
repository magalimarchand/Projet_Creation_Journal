<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AffichageJournal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbJournal = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cbCateg = New System.Windows.Forms.ComboBox()
        Me.cbMots = New System.Windows.Forms.ComboBox()
        Me.cbChrono = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lbJournal
        '
        Me.lbJournal.AutoSize = True
        Me.lbJournal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbJournal.Font = New System.Drawing.Font("Doppio One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJournal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbJournal.Location = New System.Drawing.Point(35, 17)
        Me.lbJournal.Name = "lbJournal"
        Me.lbJournal.Size = New System.Drawing.Size(2, 22)
        Me.lbJournal.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(718, 550)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 30)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "FERMER"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cbCateg
        '
        Me.cbCateg.Font = New System.Drawing.Font("Doppio One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCateg.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cbCateg.FormattingEnabled = True
        Me.cbCateg.Location = New System.Drawing.Point(672, 84)
        Me.cbCateg.Name = "cbCateg"
        Me.cbCateg.Size = New System.Drawing.Size(146, 22)
        Me.cbCateg.TabIndex = 7
        Me.cbCateg.Text = "Filtre catégorie"
        '
        'cbMots
        '
        Me.cbMots.Font = New System.Drawing.Font("Doppio One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMots.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cbMots.FormattingEnabled = True
        Me.cbMots.Location = New System.Drawing.Point(672, 126)
        Me.cbMots.Name = "cbMots"
        Me.cbMots.Size = New System.Drawing.Size(147, 22)
        Me.cbMots.TabIndex = 8
        Me.cbMots.Text = "Filtre mot-clé"
        '
        'cbChrono
        '
        Me.cbChrono.Font = New System.Drawing.Font("Doppio One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChrono.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cbChrono.FormattingEnabled = True
        Me.cbChrono.Location = New System.Drawing.Point(672, 164)
        Me.cbChrono.Name = "cbChrono"
        Me.cbChrono.Size = New System.Drawing.Size(147, 22)
        Me.cbChrono.TabIndex = 9
        Me.cbChrono.Text = "Tri ordre chronologique"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Teal
        Me.Button1.Location = New System.Drawing.Point(664, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 35)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "AFFICHAGE PAR DÉFAUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(12, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(646, 511)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = ""
        '
        'AffichageJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(834, 592)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbChrono)
        Me.Controls.Add(Me.cbMots)
        Me.Controls.Add(Me.cbCateg)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lbJournal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AffichageJournal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbJournal As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents cbCateg As ComboBox
    Friend WithEvents cbMots As ComboBox
    Friend WithEvents cbChrono As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As RichTextBox
End Class
