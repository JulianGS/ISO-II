Public Class Contact
    Private name As String
    Private number As String
    Private contactManager As DAOContact

    Sub New()
        contactManager = New DAOContact
    End Sub

    Sub New(ByVal number As String)
        contactManager = New DAOContact
        Me.number = number
    End Sub
    Sub New(ByVal name As String, ByVal number As String)
        contactManager = New DAOContact
        Me.name = name
        Me.number = number
    End Sub
    Public ReadOnly Property myManager As DAOContact
        Get
            Return contactManager
        End Get
    End Property

    Public Property myName As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property myNumber As String
        Get
            Return number
        End Get
        Set(value As String)
            number = value
        End Set
    End Property
    'Read everything
    Public Sub readAll()
        contactManager.readAll()
    End Sub

    'Read
    Public Sub read()
        contactManager.read(Me)
    End Sub

    'Delete
    Public Sub delete()
        contactManager.delete(Me)
    End Sub

    'Update
    Public Sub Modify()
        contactManager.update(Me)
    End Sub

    'Insert values
    Public Sub Insert()
        contactManager.insert(Me)
    End Sub
End Class
