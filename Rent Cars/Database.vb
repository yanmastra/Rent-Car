Imports MySql.Data.MySqlClient
Public Class Database

    Dim ComdString As String = "server=localhost;port=3366;user id=root;password=;database=db_rent_car;SslMode=none"
    Public Function GetConnection() As MySqlConnection
        Try
            Return New MySqlConnection(ComdString)
        Catch ex As MySqlException
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function LoadData(Sql As String) As DataTable
        Dim MySqlConn As MySqlConnection = GetConnection()

        Try
            MySqlConn.Open()
            Dim Adapter As New MySqlDataAdapter(Sql, MySqlConn)
            Dim xDataSet As New DataSet
            xDataSet.Clear()
            Adapter.Fill(xDataSet, "LoadData")
            MySqlConn.Close()
            Return xDataSet.Tables("LoadData")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Return New DataTable
        End Try
    End Function
End Class
