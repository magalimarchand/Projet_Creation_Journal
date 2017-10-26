Imports System.IO

Public Class CreationJournal

    'DECLARATION DE lA LISTE DE TYPES DE JOURNAUX
    Dim listeTypeJournaux As New List(Of TypeJournal)
    Dim typejournal As ListViewItem
    Dim categorie As ListViewItem

    'RECUPERATION DE LA LISTE DE TYPES DE JOURNAUX AU CHARGEMENT
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim stream As New StreamReader("Liste_Types_Journaux.txt", System.Text.Encoding.UTF8)
        Dim ligne As String
        Dim extension As String

        Do
            ligne = stream.ReadLine()
            If ligne = Nothing Then Exit Do
            Dim attributs() = ligne.Split("|")
            extension = attributs(0)

            Dim a1 As String = attributs(1)
            Dim motscle() = a1.Split("*")
            Dim listeMotscle As ArrayList = New ArrayList(motscle)

            Dim a2 As String = attributs(2)
            Dim categories() = a2.Split("*")
            Dim listeCategories As ArrayList = New ArrayList(categories)

            listeTypeJournaux.Add(New TypeJournal(extension, listeMotscle, listeCategories))
        Loop

            stream.Close()
        afficherTypesJournaux()

    End Sub

    'AFFICHAGE DANS LE LISTVIEW DE LA LISTE DES TYPES DE JOURNAUX
    Private Sub afficherTypesJournaux()

        ListView1.Items.Clear()

        Dim index As Integer = 0
        For Each t As TypeJournal In listeTypeJournaux
            typejournal = New ListViewItem
            typejournal.Text = listeTypeJournaux(index).extension
            ListView1.Items.Add(typejournal)
            index = index + 1
        Next
    End Sub

    'AFFICHAGE DES CATÉGORIES ET DES MOTS-CLÉ POUR CHAQUE TYPE DE JOURNAL
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

        tbMots.Clear()
        tbCateg.Clear()

        If ListView1.SelectedIndices.Count > 0 Then
            Dim index As Integer
            index = ListView1.SelectedIndices(0)
            For Each m As String In listeTypeJournaux(index).listeCategories
                tbCateg.Text &= m + vbCrLf
            Next
            For Each c As String In listeTypeJournaux(index).listeMotscle
                tbMots.Text &= c + vbCrLf
            Next
        End If
    End Sub

    'BOUTON DE CRÉATION D'UN JOURNAL
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim path As String = ""

        If ListView1.SelectedIndices.Count > 0 Then

            Dim nomJournal As String = tbJournal.Text
            If nomJournal = Nothing Then
                MsgBox("Vous devez entrer le nom du nouveau journal")
            ElseIf nomJournal.Contains("|") OrElse nomJournal.Contains("*") Then
                MsgBox("Les caractères | et * ne sont pas autorisés")
            Else
                path = tbJournal.Text + ListView1.SelectedItems(0).Text + ".txt"
                If My.Computer.FileSystem.FileExists(path) Then
                    MsgBox("Ce journal existe déjà, veuillez choisir un autre nom")
                Else
                    'Création du fichier texte pour le nouveau journal
                    File.Create(path).Dispose()

                    'Ajout du nouveau journal dans la liste des journaux
                    Dim sw As New StreamWriter("Liste_Journaux.txt", append:=True)
                    sw.WriteLine(tbJournal.Text + "|" + ListView1.SelectedItems(0).Text)
                    sw.Close()

                    'Mise à jour de l'affichage
                    ListView1.SelectedItems.Clear()
                    lbxCategs.Items.Clear()
                    lbxMots.Items.Clear()
                    tbJournal.Clear()
                    Application.Restart()
                End If
            End If
                Else
            MsgBox("Vous devez sélectionner un type de journal")
        End If

    End Sub

    'BOUTON D'ANNULATION DE CRÉATION DE JOURNAL
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbxCategs.Items.Clear()
        lbxMots.Items.Clear()
        tbJournal.Clear()
    End Sub

    'AJOUT DES CATÉGORIES POUR LA CRÉATION DE TYPE DE JOURNAL
    Private Sub btnAddCat_Click(sender As Object, e As EventArgs) Handles btnAddCat.Click
        Dim cat As String = tb1.Text
        If cat.Contains("|") OrElse cat.Contains("*") Then
            MsgBox("Les caractères | et * ne sont pas autorisés")
        Else
            lbxCategs.Items.Add(cat)
            tb1.Clear()
        End If
    End Sub

    Private Sub btnSupCat_Click(sender As Object, e As EventArgs) Handles btnSupCat.Click
        lbxCategs.Items.Remove(lbxCategs.SelectedItem)
    End Sub

    'AJOUT DES MOTS-CLÉ POUR LA CRÉATION DE TYPE DE JOURNAL
    Private Sub btnAddMot_Click(sender As Object, e As EventArgs) Handles btnAddMot.Click
        Dim mot As String = tb2.Text
        If mot.Contains("|") OrElse mot.Contains("*") Then
            MsgBox("Les caractères | et * ne sont pas autorisés")
        Else
            lbxMots.Items.Add(mot)
            tb2.Clear()
        End If
    End Sub

    Private Sub btnSupMot_Click(sender As Object, e As EventArgs) Handles btnSupMot.Click
        lbxMots.Items.Remove(lbxMots.SelectedItem)
    End Sub

    'BOUTON DE CRÉATION D'UN TYPE DE JOURNAL (AJOUT DANS LA LISTE DES TYPES DE JOURNAUX)
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim path As String = ""
        Dim categories As String = ""
        Dim mots As String = ""
        Dim ic As Integer = 1
        For Each c In lbxCategs.Items
            If ic < lbxCategs.Items.Count() Then
                categories &= c.ToString() + "*"
            Else
                categories &= c.ToString()
            End If
            ic += 1
        Next
        Dim im As Integer = 1
        For Each c In lbxMots.Items
            If im < lbxMots.Items.Count() Then
                mots &= c.ToString() + "*"
            Else
                mots &= c.ToString()
            End If
            im += 1
        Next

        Dim nomType As String = tbType.Text
        Dim stream As New StreamReader("Liste_Types_Journaux.txt", System.Text.Encoding.UTF8)
        Dim ligne As String
        Dim extension As String=""

        Do
            ligne = stream.ReadLine()
            If ligne = Nothing Then Exit Do
            Dim attributs() = ligne.Split("|")
            extension = attributs(0)
            If extension = "." & nomType Then
                Exit Do
            End If
        Loop
        stream.Close()

        If extension = "." & nomType Then
            MsgBox("Ce nom de type de journal existe déjà, veuillez le modifier")
        ElseIf nomType = Nothing Then
            MsgBox("Vous devez entrer le nom du nouveau type de journal")
        ElseIf nomType.Contains("|") OrElse nomType.Contains("*") Then
            MsgBox("Les caractères | et * ne sont pas autorisés")
        ElseIf lbxCategs.Items.Count() = Nothing Then
            MsgBox("Vous devez entrer au moins une catégorie")
        ElseIf lbxMots.Items.Count() = Nothing Then
            MsgBox("Vous devez entrer au moins un mot-clé")
        Else
            Dim sw As New StreamWriter("Liste_Types_Journaux.txt", append:=True)
            sw.WriteLine("." + nomType + "|" + mots + "|" + categories)
            sw.Close()

            'Mise à jour de l'affichage
            tbType.Clear()
            lbxCategs.Items.Clear()
            lbxMots.Items.Clear()
            Application.Restart()
        End If
    End Sub

    'BOUTON D'ANNULATION DE CRÉATION DE JOURNAL
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        lbxCategs.Items.Clear()
        lbxMots.Items.Clear()
        tbType.Clear()
    End Sub

    'BOUTON DE SUPPRESSION DU TYPE DE JOURNAL
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ListView1.SelectedIndices.Count > 0 Then

            Dim rep As DialogResult
            rep = MessageBox.Show("Désirez-vous vraiment supprimer le type de journal ?", "Confirmation de suppression", MessageBoxButtons.YesNo)
            If rep <> DialogResult.Yes Then
                Return
            End If

            Dim ext As String = ListView1.SelectedItems(0).Text
            Dim nouvelleListe As New List(Of String)

            For Each line In File.ReadLines("Liste_Types_Journaux.txt")
                If Not (line.StartsWith(ext)) Then
                    nouvelleListe.Add(line)
                End If
            Next

            Dim sw As New StreamWriter("Liste_Types_Journaux.txt")
            For Each l In nouvelleListe
                sw.WriteLine(l)
            Next
            sw.Close()

            Application.Restart()
        Else
            MsgBox("Vous devez sélectionner un journal")
        End If
    End Sub

    'BOUTON FERMETURE DE LA FENÊTRE
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

End Class