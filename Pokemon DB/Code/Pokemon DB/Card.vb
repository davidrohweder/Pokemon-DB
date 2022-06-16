' Pokemon class wrapper 
Public Class Card

    Private pokemon_name As String
    Private pokemon_rarity As String
    Private pokemon_type As String
    Private pokemon_pSet As String
    Private pokemon_release As String

    Public Property name() As String
        Get
            Return pokemon_name
        End Get
        Set(ByVal value As String)
            pokemon_name = value
        End Set
    End Property

    Public Property rarity() As String
        Get
            Return pokemon_rarity
        End Get
        Set(ByVal value As String)
            pokemon_rarity = value
        End Set
    End Property

    Public Property type() As String
        Get
            Return pokemon_type
        End Get
        Set(ByVal value As String)
            pokemon_type = value
        End Set
    End Property

    Public Property pSet() As String
        Get
            Return pokemon_pSet
        End Get
        Set(ByVal value As String)
            pokemon_pSet = value
        End Set
    End Property

    Public Property release() As String
        Get
            Return pokemon_release
        End Get
        Set(ByVal value As String)
            pokemon_release = value
        End Set
    End Property

    Public Sub New(ByRef name, ByRef rarity, ByRef type, ByRef pSet, ByRef release)
        pokemon_name = name
        pokemon_rarity = rarity
        pokemon_type = type
        pokemon_pSet = pSet
        pokemon_release = release
    End Sub


End Class
