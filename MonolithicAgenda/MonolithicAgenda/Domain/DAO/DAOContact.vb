Imports System.Data.OleDb
Public Class DAOContact
    Private contactList As Collection
    Dim myManager As DBBroker

    Public Sub New()
        contactList = New Collection
        myManager = DBBroker.getBroker
    End Sub
    Public ReadOnly Property myContactList As Collection
        Get
            Return contactList
        End Get
    End Property
    'Funcionalidad de añadir un contacto
    Public Sub insert(contacto As Contact)
        myManager.modify("INSERT INTO CONTACTOS (contact,Number) VALUES ('" & contacto.myName & "','" & contacto.myNumber & "');")
    End Sub
    'Funcionalidad de editar un contacto
    Public Sub update(contacto As Contact)
        myManager.modify("UPDATE CONTACTOS SET contact='" & contacto.myName & "' WHERE number='" & contacto.myNumber & "';")
    End Sub
    'Funcionalidad de borrar un contacto
    Public Sub delete(contacto As Contact)
        myManager.modify("DELETE FROM CONTACTOS WHERE number='" & contacto.myNumber & "';")
    End Sub
    'Leer un solo contacto
    Public Sub read(ByRef persona As Contact)
        Dim list As OleDbDataReader = myManager.read("SELECT * FROM CONTACTOS WHERE number='" & persona.myNumber & "';")
        If list.Read() Then
            persona.myName = list(1)
        End If
    End Sub
    'Funcionalidad de ver todos los contactos
    Public Sub readAll()
        Dim list As OleDbDataReader = myManager.read("SELECT * FROM CONTACTOS;")
        Dim persona As Contact

        While list.Read
            persona = New Contact(list(0))
            contactList.Add(persona)
        End While
    End Sub
End Class
