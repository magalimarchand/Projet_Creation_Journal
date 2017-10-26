<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tbEntree = New System.Windows.Forms.TextBox()
        Me.btnAddMot = New System.Windows.Forms.Button()
        Me.btnSupMot = New System.Windows.Forms.Button()
        Me.lbxMots = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Azure
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(11, 46)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(503, 175)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NOM"
        Me.ColumnHeader1.Width = 317
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "TYPE"
        Me.ColumnHeader2.Width = 180
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Doppio One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTE DES JOURNAUX"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Teal
        Me.Button1.Location = New System.Drawing.Point(522, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "NOUVEAU JOURNAL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Teal
        Me.Button2.Location = New System.Drawing.Point(522, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(267, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "CONSULTATION JOURNAL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(721, 551)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 30)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "FERMER"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Teal
        Me.Button4.Location = New System.Drawing.Point(521, 242)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 35)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "ENREGISTRER"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'tbEntree
        '
        Me.tbEntree.BackColor = System.Drawing.Color.Azure
        Me.tbEntree.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEntree.Location = New System.Drawing.Point(10, 48)
        Me.tbEntree.Multiline = True
        Me.tbEntree.Name = "tbEntree"
        Me.tbEntree.Size = New System.Drawing.Size(503, 185)
        Me.tbEntree.TabIndex = 6
        '
        'btnAddMot
        '
        Me.btnAddMot.Font = New System.Drawing.Font("Doppio One", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMot.ForeColor = System.Drawing.Color.Green
        Me.btnAddMot.Location = New System.Drawing.Point(763, 126)
        Me.btnAddMot.Name = "btnAddMot"
        Me.btnAddMot.Size = New System.Drawing.Size(25, 35)
        Me.btnAddMot.TabIndex = 38
        Me.btnAddMot.Text = "+"
        Me.btnAddMot.UseVisualStyleBackColor = True
        '
        'btnSupMot
        '
        Me.btnSupMot.Font = New System.Drawing.Font("Doppio One", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupMot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSupMot.Location = New System.Drawing.Point(763, 167)
        Me.btnSupMot.Name = "btnSupMot"
        Me.btnSupMot.Size = New System.Drawing.Size(25, 35)
        Me.btnSupMot.TabIndex = 37
        Me.btnSupMot.Text = "-"
        Me.btnSupMot.UseVisualStyleBackColor = True
        '
        'lbxMots
        '
        Me.lbxMots.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbxMots.Font = New System.Drawing.Font("Doppio One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxMots.FormattingEnabled = True
        Me.lbxMots.ItemHeight = 14
        Me.lbxMots.Location = New System.Drawing.Point(521, 124)
        Me.lbxMots.Name = "lbxMots"
        Me.lbxMots.Size = New System.Drawing.Size(238, 102)
        Me.lbxMots.TabIndex = 36
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.ComboBox1.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(521, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(238, 24)
        Me.ComboBox1.TabIndex = 44
        Me.ComboBox1.Text = "Choix de la catégorie : "
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.ComboBox2.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(521, 94)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(238, 24)
        Me.ComboBox2.TabIndex = 45
        Me.ComboBox2.Text = "Choix des mots-clé :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Doppio One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(11, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 22)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "NOUVELLE ENTRÉE :"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Teal
        Me.Button5.Location = New System.Drawing.Point(659, 116)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 35)
        Me.Button5.TabIndex = 47
        Me.Button5.Text = "NOUVEAU TYPE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.btnAddMot)
        Me.Panel1.Controls.Add(Me.lbxMots)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.btnSupMot)
        Me.Panel1.Controls.Add(Me.tbEntree)
        Me.Panel1.Location = New System.Drawing.Point(13, 252)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 290)
        Me.Panel1.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(22, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Ajout de 3 lignes maximum"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Teal
        Me.Button6.Location = New System.Drawing.Point(643, 242)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(116, 35)
        Me.Button6.TabIndex = 46
        Me.Button6.Text = "ANNULER"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(809, 234)
        Me.Panel2.TabIndex = 49
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.DimGray
        Me.Button7.Location = New System.Drawing.Point(522, 170)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(267, 35)
        Me.Button7.TabIndex = 50
        Me.Button7.Text = "SUPPRIMER JOURNAL"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(834, 592)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Accueil"
        Me.Text = "ACCUEIL"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents tbEntree As TextBox
    Friend WithEvents btnAddMot As Button
    Friend WithEvents btnSupMot As Button
    Friend WithEvents lbxMots As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label2 As Label
End Class
