Public Class FAgenda
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            Dim con As New Contact
            con.readAll()
            For Each contacto As Contact In con.myManager.myContactList
                lstContacts.Items.Add(contacto.myName)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim con As New Contact
            con.myNumber = txtNumber.Text
            con.myName = txtName.Text
            con.Insert()
            lstContacts.Items.Add(con.myNumber)

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim seguro As Integer
        seguro = MsgBox("¿Are you sure you want to delete this person?.", vbYesNo + vbExclamation + vbDefaultButton2, "Delete Person")
        If (seguro = vbYes) Then
            Try
                Dim con As New Contact(lstContacts.SelectedItem.ToString)
                con.delete()
            Catch ex As Exception
                MessageBox.Show("Error when deleting person", "Person Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End Try
            lstContacts.Items.RemoveAt(lstContacts.SelectedIndex)

        End If
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Try
            Dim con As New Contact(lstContacts.SelectedItem.ToString)
            con.myName = txtName.Text
            con.Modify()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub lstContacts_Click(sender As Object, e As EventArgs) Handles lstContacts.Click
        Dim con As New Contact(lstContacts.SelectedItem.ToString)
        con.read()
        txtName.Text = con.myName
        txtNumber.Text = con.myNumber
    End Sub

End Class