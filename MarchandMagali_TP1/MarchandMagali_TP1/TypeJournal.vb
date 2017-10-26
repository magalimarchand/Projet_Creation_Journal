Public Class TypeJournal

    Private _extension As String
    Private _listeMotscle As New ArrayList
    Private _listeCategories As New ArrayList


    'CONSTRUCTEUR
    Public Sub New(ByVal extension As String, ByVal listeMotscle As ArrayList, ByVal listeCategories As ArrayList)
        _extension = extension
        _listeMotscle = listeMotscle
        _listeCategories = listeCategories

    End Sub

    'METHODES GET & SET
    Property extension()
        Get
            Return _extension
        End Get
        Set(ByVal value)
            _extension = value
        End Set
    End Property

    Property listeMotscle()
        Get
            Return _listeMotscle
        End Get
        Set(ByVal value)
            _listeMotscle = value
        End Set
    End Property

    Property listeCategories()
        Get
            Return _listeCategories
        End Get
        Set(ByVal value)
            _listeCategories = value
        End Set
    End Property

    'METHODES D'AJOUT DE MOTS-CLÉ ET DE CATEGORIES
    Public Sub ajouterMotcle(ByVal motcle As String)
        _listeMotscle.Add(motcle)
    End Sub

    Public Sub ajouterCategorie(ByVal categorie As String)
        _listeCategories.Add(categorie)
    End Sub

    'METHODE TOSTRING
    Public Overrides Function toString() As String

        Dim mot As String = ""
        Dim index As Integer = 0
        Dim nbMots As Integer = listeMotscle.count

        For Each m As String In listeMotscle
            If index < nbMots - 1 Then
                mot &= m & ","
            Else
                mot &= m
            End If
            index += 1
        Next

        Dim categorie As String = ""
        Dim index2 As Integer = 0
        Dim nbCategories As Integer = listeCategories.count

        For Each c As String In listeCategories
            If index2 < nbCategories - 1 Then
                categorie &= c & ","
            Else
                categorie &= c
            End If
            index2 += 1
        Next

        Return extension & " : " & mot & " : " & Categorie

    End Function

End Class

