<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreationJournal
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbJournal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbCateg = New System.Windows.Forms.TextBox()
        Me.tbMots = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddCat = New System.Windows.Forms.Button()
        Me.btnSupCat = New System.Windows.Forms.Button()
        Me.lbxCategs = New System.Windows.Forms.ListBox()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.btnAddMot = New System.Windows.Forms.Button()
        Me.btnSupMot = New System.Windows.Forms.Button()
        Me.lbxMots = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbType = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.LightGray
        Me.ListView1.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 101)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(128, 148)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(521, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nom du nouveau journal : "
        '
        'tbJournal
        '
        Me.tbJournal.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbJournal.Location = New System.Drawing.Point(521, 73)
        Me.tbJournal.Name = "tbJournal"
        Me.tbJournal.Size = New System.Drawing.Size(270, 24)
        Me.tbJournal.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Choix du type de journal : "
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Teal
        Me.Button3.Location = New System.Drawing.Point(521, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 35)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "ENREGISTRER"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Teal
        Me.Button2.Location = New System.Drawing.Point(660, 214)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 35)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "ANNULER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbCateg
        '
        Me.tbCateg.BackColor = System.Drawing.Color.Azure
        Me.tbCateg.CausesValidation = False
        Me.tbCateg.Font = New System.Drawing.Font("Doppio One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCateg.Location = New System.Drawing.Point(142, 101)
        Me.tbCateg.Multiline = True
        Me.tbCateg.Name = "tbCateg"
        Me.tbCateg.ReadOnly = True
        Me.tbCateg.Size = New System.Drawing.Size(176, 148)
        Me.tbCateg.TabIndex = 12
        '
        'tbMots
        '
        Me.tbMots.BackColor = System.Drawing.Color.Azure
        Me.tbMots.CausesValidation = False
        Me.tbMots.Font = New System.Drawing.Font("Doppio One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMots.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbMots.Location = New System.Drawing.Point(321, 101)
        Me.tbMots.Multiline = True
        Me.tbMots.Name = "tbMots"
        Me.tbMots.ReadOnly = True
        Me.tbMots.Size = New System.Drawing.Size(177, 148)
        Me.tbMots.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Doppio One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(31, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(3)
        Me.Label4.Size = New System.Drawing.Size(73, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "EXTENSION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Doppio One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(187, 80)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(3)
        Me.Label5.Size = New System.Drawing.Size(77, 22)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "CATÉGORIES"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Doppio One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(362, 80)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(3)
        Me.Label6.Size = New System.Drawing.Size(66, 22)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "MOTS-CLÉ"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tbJournal)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tbMots)
        Me.Panel1.Controls.Add(Me.tbCateg)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 264)
        Me.Panel1.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Location = New System.Drawing.Point(521, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(270, 35)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "SUPPRIMER LE TYPE DE JOURNAL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Doppio One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 22)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "NOUVEAU JOURNAL :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(94, 647)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(94, 619)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Nom de l'extension : "
        '
        'btnAddCat
        '
        Me.btnAddCat.Font = New System.Drawing.Font("Doppio One", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCat.ForeColor = System.Drawing.Color.Green
        Me.btnAddCat.Location = New System.Drawing.Point(226, 118)
        Me.btnAddCat.Name = "btnAddCat"
        Me.btnAddCat.Size = New System.Drawing.Size(25, 35)
        Me.btnAddCat.TabIndex = 47
        Me.btnAddCat.Text = "+"
        Me.btnAddCat.UseVisualStyleBackColor = True
        '
        'btnSupCat
        '
        Me.btnSupCat.Font = New System.Drawing.Font("Doppio One", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupCat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSupCat.Location = New System.Drawing.Point(226, 159)
        Me.btnSupCat.Name = "btnSupCat"
        Me.btnSupCat.Size = New System.Drawing.Size(25, 35)
        Me.btnSupCat.TabIndex = 46
        Me.btnSupCat.Text = "-"
        Me.btnSupCat.UseVisualStyleBackColor = True
        '
        'lbxCategs
        '
        Me.lbxCategs.BackColor = System.Drawing.Color.Azure
        Me.lbxCategs.Font = New System.Drawing.Font("Doppio One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxCategs.FormattingEnabled = True
        Me.lbxCategs.ItemHeight = 14
        Me.lbxCategs.Location = New System.Drawing.Point(12, 116)
        Me.lbxCategs.Name = "lbxCategs"
        Me.lbxCategs.Size = New System.Drawing.Size(212, 130)
        Me.lbxCategs.TabIndex = 45
        '
        'tb1
        '
        Me.tb1.Font = New System.Drawing.Font("Doppio One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb1.Location = New System.Drawing.Point(12, 90)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(212, 21)
        Me.tb1.TabIndex = 44
        '
        'btnAddMot
        '
        Me.btnAddMot.Font = New System.Drawing.Font("Doppio One", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMot.ForeColor = System.Drawing.Color.Green
        Me.btnAddMot.Location = New System.Drawing.Point(480, 118)
        Me.btnAddMot.Name = "btnAddMot"
        Me.btnAddMot.Size = New System.Drawing.Size(25, 35)
        Me.btnAddMot.TabIndex = 43
        Me.btnAddMot.Text = "+"
        Me.btnAddMot.UseVisualStyleBackColor = True
        '
        'btnSupMot
        '
        Me.btnSupMot.Font = New System.Drawing.Font("Doppio One", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupMot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSupMot.Location = New System.Drawing.Point(480, 159)
        Me.btnSupMot.Name = "btnSupMot"
        Me.btnSupMot.Size = New System.Drawing.Size(25, 35)
        Me.btnSupMot.TabIndex = 42
        Me.btnSupMot.Text = "-"
        Me.btnSupMot.UseVisualStyleBackColor = True
        '
        'lbxMots
        '
        Me.lbxMots.BackColor = System.Drawing.Color.Azure
        Me.lbxMots.Font = New System.Drawing.Font("Doppio One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxMots.FormattingEnabled = True
        Me.lbxMots.ItemHeight = 14
        Me.lbxMots.Location = New System.Drawing.Point(266, 116)
        Me.lbxMots.Name = "lbxMots"
        Me.lbxMots.Size = New System.Drawing.Size(212, 130)
        Me.lbxMots.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(12, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 16)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Ajout de catégories : "
        '
        'tb2
        '
        Me.tb2.Font = New System.Drawing.Font("Doppio One", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb2.Location = New System.Drawing.Point(266, 90)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(212, 21)
        Me.tb2.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(266, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Ajout de mots-clé  : "
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(643, 672)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 30)
        Me.Button7.TabIndex = 37
        Me.Button7.Text = "CRÉER"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(537, 672)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 30)
        Me.Button8.TabIndex = 36
        Me.Button8.Text = "ANNULER"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.tbType)
        Me.Panel2.Controls.Add(Me.Button10)
        Me.Panel2.Controls.Add(Me.Button11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.tb1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnAddCat)
        Me.Panel2.Controls.Add(Me.tb2)
        Me.Panel2.Controls.Add(Me.btnSupCat)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lbxCategs)
        Me.Panel2.Controls.Add(Me.lbxMots)
        Me.Panel2.Controls.Add(Me.btnSupMot)
        Me.Panel2.Controls.Add(Me.btnAddMot)
        Me.Panel2.Location = New System.Drawing.Point(12, 282)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(810, 259)
        Me.Panel2.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(521, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 16)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Nom du nouveau type : "
        '
        'tbType
        '
        Me.tbType.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbType.Location = New System.Drawing.Point(521, 87)
        Me.tbType.Name = "tbType"
        Me.tbType.Size = New System.Drawing.Size(270, 24)
        Me.tbType.TabIndex = 56
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Teal
        Me.Button10.Location = New System.Drawing.Point(521, 206)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(131, 35)
        Me.Button10.TabIndex = 53
        Me.Button10.Text = "ENREGISTRER"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Teal
        Me.Button11.Location = New System.Drawing.Point(660, 206)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(131, 35)
        Me.Button11.TabIndex = 54
        Me.Button11.Text = "ANNULER"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Doppio One", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(12, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 22)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "NOUVEAU TYPE DE JOURNAL :"
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Doppio One", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(722, 550)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 30)
        Me.Button9.TabIndex = 51
        Me.Button9.Text = "FERMER"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'CreationJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(834, 592)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CreationJournal"
        Me.Text = "NOUVEAU JOURNAL / TYPE DE JOURNAL"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents tbJournal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tbCateg As TextBox
    Friend WithEvents tbMots As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddCat As Button
    Friend WithEvents btnSupCat As Button
    Friend WithEvents lbxCategs As ListBox
    Friend WithEvents tb1 As TextBox
    Friend WithEvents btnAddMot As Button
    Friend WithEvents btnSupMot As Button
    Friend WithEvents lbxMots As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbType As TextBox
    Friend WithEvents Button1 As Button
End Class
