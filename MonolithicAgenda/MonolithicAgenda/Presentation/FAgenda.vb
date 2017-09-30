Public Class FAgenda
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim con As New Contact
        con.readAll()
        For Each contacto As Contact In con.myManager.myContactList
            lstContacts.Items.Add(contacto.myName)
        Next
    End Sub
    Private Sub lstContacts_Click(sender As Object, e As EventArgs) Handles lstContacts.Click
        Dim con As New Contact(lstContacts.SelectedItem.ToString)
        con.read()
        txtName.Text = con.myName
        txtNumber.Text = con.myNumber
    End Sub
End Class