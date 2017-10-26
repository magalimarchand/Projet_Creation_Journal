Public Class Categorie

    Private _nom As String

    'CONSTRUCTEUR
    Public Sub New(ByVal nom As String)
        _nom = nom
    End Sub

    'METHODES GET & SET
    Property nom
        Get
            Return _nom
        End Get
        Set(ByVal value)
            _nom = value
        End Set
    End Property

    'METHODE TOSTRING
    Public Overrides Function toString() As String
        Return nom
    End Function

End Class
