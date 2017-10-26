Imports System.IO

Public Class AffichageJournal

    Dim listeEntrees As New List(Of Entree)
    Dim type As TypeJournal

    'MÉTHODE D'AFFICHAGE DU JOURNAL
    Private Sub AffichageJournal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Affichage dans les combo-box
        cbChrono.Items.Add("plus récent")
        cbChrono.Items.Add("moins récent")

        'Récupération des entrées du journal à afficher
        Dim sr As New StreamReader(Accueil.path, System.Text.Encoding.UTF8)
        Dim ligne As String
        Do
            ligne = sr.ReadLine()
            If ligne = Nothing Then Exit Do
            Dim ent() = ligne.Split("|")

            Dim m As String = ent(2)
            Dim motscle() = m.Split("*")
            Dim listeMotscle As ArrayList = New ArrayList(motscle)

            listeEntrees.Add(New Entree(ent(0), ent(1), listeMotscle, ent(3))) 'date, categorie, liste Motsclé et texte
        Loop
        sr.Close()
        afficherEntrees()
        lbJournal.Text = Accueil.jour

        'Affichage des catégories et mots-clé dans les combo-box
        Dim stream As New StreamReader("Liste_Types_Journaux.txt", System.Text.Encoding.UTF8)
        Dim l As String
        Dim extension As String
        Dim checkExtension As String = Accueil.ext

        Do
            l = stream.ReadLine()
            If l = Nothing Then Exit Do
            Dim attributs() = l.Split("|")
            extension = attributs(0)

            If extension = checkExtension Then

                Dim a1 As String = attributs(1)
                Dim motscle() = a1.Split("*")
                Dim listeMotscle As ArrayList = New ArrayList(motscle)

                Dim a2 As String = attributs(2)
                Dim categories() = a2.Split("*")
                Dim listeCategories As ArrayList = New ArrayList(categories)

                type = New TypeJournal(extension, listeMotscle, listeCategories)

                For Each c As String In type.listeCategories
                    cbCateg.Items.Add(c)
                Next
                For Each m As String In type.listeMotscle
                    cbMots.Items.Add(m)
                Next
            End If
        Loop
        stream.Close()
    End Sub

    'METHODE D'AFFICHAGE DE LA LISTE DES ENTRÉES
    Private Sub afficherEntrees()

        TextBox1.Clear()
        cbCateg.Items.Clear()
        cbCateg.Text = "Filtre catégorie"
        cbMots.Items.Clear()
        cbMots.Text = "Filtre mot-clé"

        Dim index As Integer = 0
        For Each e As Entree In listeEntrees
            Dim dateEntree As String = e.dateEntree
            Dim categorie As String = e.categorie
            Dim texte As String = e.texte
            Dim lignesTexte() = texte.Split("*") 'Re-sépare les lignes compilées dans le fichier texte

            With TextBox1
                .SelectionFont = New Font("Doppio One", 11)
                .SelectionColor = Color.DarkCyan
                .AppendText(dateEntree + "          " + categorie + vbCrLf)
            End With
            For Each t In lignesTexte 'Affiche toutes les lignes du texte
                With TextBox1
                    .SelectionFont = New Font("Doppio One", 10)
                    .SelectionColor = Color.Black
                    .AppendText(t + vbCrLf)
                End With
            Next
            TextBox1.AppendText(vbCrLf)
            index = index + 1
        Next

    End Sub

    'METHODE DE FILTRAGE PAR CATÉGORIE
    Private Sub cbCateg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCateg.SelectedIndexChanged
        TextBox1.Clear()
        Dim filtre As String = ""
        filtre = cbCateg.SelectedItem
        For Each ent As Entree In listeEntrees
            Dim dateEntree As String = ent.dateEntree
            Dim categorie As String = ent.categorie
            Dim texte As String = ent.texte
            Dim lignesTexte() = texte.Split("*") 'Re-sépare les lignes compilées dans le fichier texte

            If ent.categorie = filtre Then
                With TextBox1
                    .SelectionFont = New Font("Doppio One", 11)
                    .SelectionColor = Color.DarkCyan
                    .AppendText(dateEntree + "          " + categorie + vbCrLf)
                End With
                For Each t In lignesTexte 'Affiche toutes les lignes du texte
                    With TextBox1
                        .SelectionFont = New Font("Doppio One", 10)
                        .SelectionColor = Color.Black
                        .AppendText(t + vbCrLf)
                    End With
                Next
                TextBox1.AppendText(vbCrLf)
            End If
        Next
    End Sub

    'METHODE DE FILTRAGE PAR MOT-CLÉ
    Private Sub cbMots_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMots.SelectedIndexChanged
        TextBox1.Clear()
        Dim filtre As String = ""
        filtre = cbMots.SelectedItem
        For Each ent As Entree In listeEntrees
            Dim dateEntree As String = ent.dateEntree
            Dim categorie As String = ent.categorie
            Dim texte As String = ent.texte
            Dim lignesTexte() = texte.Split("*") 'Re-sépare les lignes compilées dans le fichier texte

            For Each mot As String In ent.listeMotscle
                If mot = filtre Then
                    With TextBox1
                        .SelectionFont = New Font("Doppio One", 11)
                        .SelectionColor = Color.DarkCyan
                        .AppendText(dateEntree + "          " + categorie + vbCrLf)
                    End With
                    For Each t In lignesTexte 'Affiche toutes les lignes du texte
                        With TextBox1
                            .SelectionFont = New Font("Doppio One", 10)
                            .SelectionColor = Color.Black
                            .AppendText(t + vbCrLf)
                        End With
                    Next
                    TextBox1.AppendText(vbCrLf)
                End If
            Next
        Next
    End Sub

    'METHODE DE TRI PAR ORDRE CHRONOLOGIQUE OU INVERSE
    Private Sub cbChrono_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbChrono.SelectedIndexChanged
        If cbChrono.SelectedItem = "moins récent" Then
            listeEntrees.Sort()
            afficherEntrees()
        ElseIf cbChrono.SelectedItem = "plus récent" Then
            listeEntrees.Reverse()
            afficherEntrees()
        End If
        For Each c As String In type.listeCategories
            cbCateg.Items.Add(c)
        Next
        For Each m As String In type.listeMotscle
            cbMots.Items.Add(m)
        Next
    End Sub

    'AFFICHAGE PAR DÉFAUT
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cbCateg.Text = "Filtre catégorie"
        cbMots.Text = "Filtre mot-clé"
        cbChrono.Text = "Ordre chronologique"
        listeEntrees.Sort()
        afficherEntrees()
        For Each c As String In type.listeCategories
            cbCateg.Items.Add(c)
        Next
        For Each m As String In type.listeMotscle
            cbMots.Items.Add(m)
        Next

    End Sub

    'FERMETURE DE LA FENÊTRE
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub


End Class