Imports MySql.Data.MySqlClient
Module Module1

    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public str_user, str_pass, str_name, str_role As String




    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost; user id=root;password=;database=restaurants_manager_sql"
        End With
    End Sub


End Module
