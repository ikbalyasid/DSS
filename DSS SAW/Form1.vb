Imports MySql.Data.MySqlClient
Public Class Form1
    Dim cn As New MySqlConnection


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cn.ConnectionString = "server=sql6.freemysqlhosting.net;user=sql6500359;password=jzTWkvE6rI;database=sql6500359;allow user variables=true"
        cn.Open()
        MsgBox("You are connected")
        cn.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button4.Click
        formdata.Show()

    End Sub
End Class
