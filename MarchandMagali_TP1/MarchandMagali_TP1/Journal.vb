Public Class Journal

    Private _nom As String
    Private _type As String
    Private _listeEntrees As New List(Of Entree)


    'CONSTRUCTEUR
    Public Sub New(ByVal nom As String, ByVal type As String)
        _nom = nom
        _type = type
    End Sub

    'METHODES GET & SET
    Property nom()
        Get
            Return _nom
        End Get
        Set(ByVal value)
            _nom = value
        End Set
    End Property

    Property type()
        Get
            Return _type
        End Get
        Set(ByVal value)
            _type = value
        End Set
    End Property

    Property listeEntrees()
        Get
            Return _listeEntrees.ToArray
        End Get
        Set(ByVal value)
            _listeEntrees = value
        End Set
    End Property

    'METHODES LISTE DES ENTREES
    Public Sub ajouterEntree(ByVal entree As Entree)
        _listeEntrees.Add(entree)
    End Sub

    'METHODE TOSTRING
    Public Overrides Function toString() As String
        Return nom & "," & type
    End Function

End Class
