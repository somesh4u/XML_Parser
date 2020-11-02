Public Class PaxInfo
    Private FirstNameValue As String
    Public Property FirstName() As String
        Get
            Return FirstNameValue
        End Get
        Set(ByVal value As String)
            FirstNameValue = value
        End Set
    End Property

    Private LastNameValue As String
    Public Property LastName() As String
        Get
            Return LastNameValue
        End Get
        Set(ByVal value As String)
            LastNameValue = value
        End Set
    End Property

    Private PaxTypeValue As String
    Public Property PaxType() As String
        Get
            Return PaxTypeValue
        End Get
        Set(ByVal value As String)
            PaxTypeValue = value
        End Set
    End Property

End Class
