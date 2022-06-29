Imports MySql.Data.MySqlClient
Module Koneksi
    Public conn As MySqlConnection
    Public da As MySqlDataAdapter
    Public rd As MySqlDataReader
    Public dt As DataSet
    Public cmd As MySqlCommand
    Public db As String
    Sub KoneksiDB()


        Try
            conn = New MySqlConnection("server=localhost;user=root;password=;database=saw;allow user variables=true")
            If conn.State = ConnectionState.Closed Then conn.Open()


            conn.Open()
            'MsgBox("You are Connected, Baby")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
End Module
