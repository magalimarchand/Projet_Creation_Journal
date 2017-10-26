Imports System.IO

Public Class Accueil

    Dim listeJournaux As New List(Of Journal)
    Dim journal As ListViewItem 'Journal sélectionné
    Dim categorie As String 'Catégorie sélectionnée
    Dim motsCle As ArrayList 'Liste des mots-clé sélectionnés
    Public Property path As String 'Chemin d'accès du journal
    Public Property jour As String 'Nom du journal
    Public Property ext As String 'Type du journal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Récupération de la liste des journaux à l'ouverture de l'application
        Dim sr As New StreamReader("Liste_Journaux.txt", System.Text.Encoding.UTF8)
        Dim s As String
        Do
            s = sr.ReadLine()
            If s = Nothing Then Exit Do
            Dim j() = s.Split("|")
            listeJournaux.Add(New Journal(j(0), j(1))) 'extension et mots-clé
        Loop
        sr.Close()
        afficherJournaux()

    End Sub

    'METHODE D'AFFICHAGE DE LA LISTE DES JOURNAUX
    Private Sub afficherJournaux()

        ListView1.Items.Clear()

        Dim index As Integer = 0
        For Each j As Journal In listeJournaux
            journal = New ListViewItem
            journal.Text = listeJournaux(index).nom
            journal.SubItems.Add(listeJournaux(index).type)
            ListView1.Items.Add(journal)
            index = index + 1
        Next

    End Sub

    'MÉTHODE DE GESTION DES CATÉGORIES ET DES MOTS-CLÉ POUR LA CONSIGNATION
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

        ComboBox1.Items.Clear()
        ComboBox1.Text = "Choix de la catégorie : "
        ComboBox2.Items.Clear()
        ComboBox2.Text = "Choix des mots-clés : "
        lbxMots.Items.Clear()

        categorie = Nothing
        motsCle = New ArrayList

        If ListView1.SelectedIndices.Count > 0 Then

            'Affichage des catégories et mots-clé dans les combo-box
            Dim stream As New StreamReader("Liste_Types_Journaux.txt", System.Text.Encoding.UTF8)
            Dim ligne As String
            Dim extension As String
            Dim type As TypeJournal
            Dim checkExtension As String = ListView1.SelectedItems(0).SubItems(1).Text

            Do
                ligne = stream.ReadLine()
                If ligne = Nothing Then Exit Do
                Dim attributs() = ligne.Split("|")
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
                        ComboBox1.Items.Add(c)
                    Next
                    For Each m As String In type.listeMotscle
                        ComboBox2.Items.Add(m)
                    Next
                End If
            Loop
            stream.Close()
        End If
    End Sub

    'CHOIX DE 1 À 5 MOTS-CLÉ POUR LA CONSIGNATION
    Private Sub btnAddMot_Click(sender As Object, e As EventArgs) Handles btnAddMot.Click
        If ComboBox2.SelectedItem = "" Then
            Return
        Else
            If lbxMots.Items.Count < 5 Then
                lbxMots.Items.Add(ComboBox2.SelectedItem)
                ComboBox2.Items.Remove(ComboBox2.SelectedItem)
                ComboBox2.Text = "Choix des mots-clé : "
            Else
                MsgBox("Vous ne pouvez ajouter que 5 mots-clé")
            End If
        End If
    End Sub

    Private Sub btnSupMot_Click(sender As Object, e As EventArgs) Handles btnSupMot.Click
        If ComboBox2.SelectedItem = "" Then
            Return
        Else
            ComboBox2.Items.Add(lbxMots.SelectedItem)
            lbxMots.Items.Remove(lbxMots.SelectedItem)
            ComboBox2.Text = "Choix des mots-clé : "
        End If
    End Sub

    'RESTRICTIONS D'ÉCRITURE POUR LA CONSIGNATION D'UNE ENTRÉE
    Private Sub tbEntree_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbEntree.TextChanged

        If CType(sender, TextBox).Lines.Length > 3 Then
            MsgBox("Vous ne pouvez écrire que 3 lignes maximum par entrée")
            Array.Resize(tbEntree.Lines, 3)
        End If

    End Sub


    'BOUTON DE CONSIGNATION D'UN JOURNAL
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim dateEntree As Date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        Dim listeMotscle As String = ""
        Dim texteEntree As String = tbEntree.Text
        Dim index As Integer = 0
        Dim nbMots As Integer = motsCle.Count
        Dim rep As DialogResult


        If ListView1.SelectedIndices.Count > 0 Then

            If texteEntree = Nothing Then
                MsgBox("Vous devez entrer un texte")

            ElseIf texteEntree.Contains("|") OrElse texteEntree.Contains("*") Then
                MsgBox("Les caractères | et * ne sont pas autorisés")

            ElseIf ComboBox1.SelectedItem = Nothing Then
                MsgBox("Vous devez choisir une catégorie")

            ElseIf lbxMots.Items.Count = Nothing Then
                MsgBox("Vous devez choisir au moins un mot-clé")

            Else
                'Confirmation d'enregistrement de l'entrée
                rep = MessageBox.Show("Désirez-vous vraiment ajouter cette entrée au journal ?", "Confirmation d'ajout", MessageBoxButtons.YesNo)
                If rep <> DialogResult.Yes Then
                    Return
                Else
                    categorie = ComboBox1.SelectedItem 'Categorie

                    For Each mot In lbxMots.Items 'Mots-clé
                        motsCle.Add(mot.ToString())
                    Next

                    'Ecriture de l'entree dans le journal
                    path = ListView1.SelectedItems(0).Text + ListView1.SelectedItems(0).SubItems(1).Text + ".txt"

                    For Each m As String In motsCle
                        If index < nbMots - 1 Then
                            listeMotscle &= m & "*"
                        Else
                            listeMotscle &= m
                        End If
                        index += 1
                    Next

                    texteEntree = tbEntree.Text.Replace(vbCrLf, "*") 'Permet de compiler les multiples lignes d'input sur une seule dans le fichier texte
                    Dim sw As New StreamWriter(path, append:=True)
                    sw.WriteLine(dateEntree + "|" + categorie + "|" + listeMotscle + "|" + texteEntree)
                    sw.Close()

                    'Enregistrement de l'entree dans la classe journal
                    categorie = ComboBox1.SelectedItem
                    Dim entree As New Entree(dateEntree, categorie, motsCle, texteEntree)
                    Dim journal As New Journal(ListView1.SelectedItems(0).Text, ListView1.SelectedItems(0).SubItems(1).Text)

                    'Effacement de l'affichage
                    ComboBox1.Text = "Choix de la catégorie : "
                    ComboBox1.Items.Clear()
                    ComboBox2.Text = "Choix des mots-clé : "
                    ComboBox2.Items.Clear()
                    lbxMots.Items.Clear()
                    tbEntree.Clear()
                End If
            End If
        Else
                MsgBox("Vous devez sélectionner un journal")
        End If

    End Sub

    'BOUTON D'ANNULATION DE CONSIGNATION
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComboBox1.Text = "Choix de la catégorie : "
        ComboBox1.Items.Clear()
        ComboBox2.Text = "Choix des mots-clé : "
        ComboBox2.Items.Clear()
        lbxMots.Items.Clear()
        tbEntree.Clear()
    End Sub


    'BOUTON DE CONSULTATION D'UN JOURNAL
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ListView1.SelectedIndices.Count > 0 Then
            jour = ListView1.SelectedItems(0).Text
            ext = ListView1.SelectedItems(0).SubItems(1).Text
            path = jour + ext + ".txt"
            'Ouverture de la fenêtre d'affichage du journal
            Dim affichageJournal As New AffichageJournal
            affichageJournal.StartPosition = FormStartPosition.Manual
            affichageJournal.DesktopLocation = Me.DesktopLocation
            affichageJournal.Show()
        Else
            MsgBox("Vous devez sélectionner un journal")
        End If
    End Sub


    'BOUTON CREATION JOURNAL
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.DialogResult = DialogResult.OK
        Dim creationJournal As New CreationJournal
        creationJournal.StartPosition = FormStartPosition.Manual
        creationJournal.DesktopLocation = Me.DesktopLocation
        creationJournal.Show()

    End Sub

    'BOUTON DE SUPPRESSION D'UN JOURNAL
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        'Supression dans la liste des journaux
        If ListView1.SelectedIndices.Count > 0 Then

            Dim rep As DialogResult
            rep = MessageBox.Show("Désirez-vous vraiment supprimer le journal ?", "Confirmation de suppression", MessageBoxButtons.YesNo)
            If rep <> DialogResult.Yes Then
                    Return
                End If

                jour = ListView1.SelectedItems(0).Text
            ext = ListView1.SelectedItems(0).SubItems(1).Text
            path = jour + ext + ".txt"
            Dim nouvelleListe As New List(Of String)

            For Each line In File.ReadLines("Liste_Journaux.txt")
                If Not (line.StartsWith(jour)) Then
                    nouvelleListe.Add(line)
                End If
            Next

            Dim sw As New StreamWriter("Liste_Journaux.txt")
            For Each l In nouvelleListe
                sw.WriteLine(l)
            Next
            sw.Close()

            'Suppression du fichier texte du journal
            My.Computer.FileSystem.DeleteFile(path)

            Application.Restart()
        Else
            MsgBox("Vous devez sélectionner un journal")
        End If
    End Sub

    'BOUTON CREATION TYPE DE JOURNAL
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim creationJournal As New CreationJournal
        creationJournal.StartPosition = FormStartPosition.Manual
        creationJournal.DesktopLocation = Me.DesktopLocation
        creationJournal.Show()
    End Sub

    'BOUTON DE FERMETURE DE L'APPLICATION
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
