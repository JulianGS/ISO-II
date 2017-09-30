Public Class FConection
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            btnOk.Enabled = False
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.InitialDirectory = "c:\Desktop"
            openFileDialog1.RestoreDirectory = True

            If (openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                txtPath.Text = openFileDialog1.FileName()
                btnOk.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
            btnOk.Enabled = False
        End Try
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            MsgBox("DATABASE CONNECTED")
            FAgenda.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Incompatible Database", "Error in database", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
