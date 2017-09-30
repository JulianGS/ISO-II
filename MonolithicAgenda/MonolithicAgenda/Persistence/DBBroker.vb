Imports System.Data.OleDb
Public Class DBBroker
    Private Shared StrConection
    Private Shared mConection As OleDbConnection
    Private Shared mInstance As DBBroker

    Private Sub New()
        StrConection = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & FConection.txtPath.Text
        DBBroker.mConection = New OleDbConnection(StrConection)
        DBBroker.mConection.Open()
    End Sub

    Public Shared Function getBroker() As DBBroker

        If mInstance Is Nothing Then
            mInstance = New DBBroker()
        End If

        Return mInstance
    End Function

    ReadOnly Property get_oleDb() As OleDbConnection
        Get
            Return mConection
        End Get
    End Property

    Public Function modify(ByVal sql As String) As Integer

        Dim com As New OleDbCommand(sql, mConection)
        Return com.ExecuteNonQuery()

    End Function

    Public Function read(ByVal sql As String) As OleDbDataReader

        Dim com As New OleDbCommand(sql, mConection)
        Return com.ExecuteReader()

    End Function
End Class


