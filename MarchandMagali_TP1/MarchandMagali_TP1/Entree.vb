
Public Class Entree
    Implements IComparable

    Private _dateEntree As Date
    Private _categorie As String
    Private _listeMotscle As New ArrayList
    Private _texte As String

    'CONSTRUCTEUR
    Public Sub New(dateEntree As Date, categorie As String, listeMotscle As ArrayList, texte As String)
        _dateEntree = dateEntree
        _categorie = categorie
        _listeMotscle = listeMotscle
        _texte = texte
    End Sub

    'METHODES GET & SET
    Property dateEntree()
        Get
            Return _dateEntree
        End Get
        Set(ByVal value)
            _dateEntree = value
        End Set
    End Property

    Property categorie()
        Get
            Return _categorie
        End Get
        Set(ByVal value)
            _categorie = value
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

    Property texte()
        Get
            Return _texte
        End Get
        Set(ByVal value)
            _texte = value
        End Set
    End Property

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

        Return dateEntree & " : " & categorie & " : " & mot & " : " & texte
    End Function

    'METHODE DE TRI PAR DATE D'ENTRÉE
    Public Function compareto(ByVal d As Object) As Integer Implements IComparable.CompareTo
        Dim e As Entree = CType(d, Entree)
        Return dateEntree.compareto(e.dateEntree)
    End Function

End Class
