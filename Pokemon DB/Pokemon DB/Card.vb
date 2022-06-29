' Pokemon class wrapper 
Public Class Card

    Private pokemon_id As Integer
    Private pokemon_name As String
    Private pokemon_rarity As String
    Private pokemon_type As String
    Private pokemon_pSet As String
    Private pokemon_release As String
    Private pokemon_quanity As Integer
    Private pokemon_grade As String

    Public Property id() As String
        Get
            Return pokemon_id
        End Get
        Set(ByVal value As String)
            pokemon_id = value
        End Set
    End Property

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

    Public Property quanity() As Integer
        Get
            Return pokemon_quanity
        End Get
        Set(ByVal value As Integer)
            pokemon_quanity = value
        End Set
    End Property

    Public Property grade() As String
        Get
            Return pokemon_grade
        End Get
        Set(ByVal value As String)
            pokemon_grade = value
        End Set
    End Property

    Public Sub New(ByRef id As Integer, ByRef name As String, ByRef rarity As String, ByRef type As String, ByRef pSet As String, ByRef release As String, ByRef quanity As Integer, ByRef grade As String)

        pokemon_id = id
        pokemon_name = name
        pokemon_rarity = rarity
        pokemon_type = type
        pokemon_pSet = pSet
        pokemon_release = release
        pokemon_quanity = quanity
        pokemon_grade = grade

    End Sub

End Class