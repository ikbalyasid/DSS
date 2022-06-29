Imports MySql.Data.MySqlClient
Public Class formdata
    Private Sub formdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil()




    End Sub
    Sub tampil()
        Call KoneksiDB()
        da = New MySqlDataAdapter("Select * from t_penerima", conn)
        dt = New DataSet
        da.Fill(dt, "t_penerima")
        dgvdata.DataSource = (dt.Tables("t_penerima"))
    End Sub
    Sub hapusPenerima()


        For i As Integer = 0 To dgvdata.SelectedRows.Count - 1
            Dim cmd As New MySqlCommand("delete from t_penerima where nik=@nik", conn)
            cmd.Parameters.AddWithValue("nik", dgvdata.SelectedRows(1).Cells(0).Value.ToString())
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

        Next
        tampil()
        MessageBox.Show("data deleted")
    End Sub

    Private Sub btnhps_Click(sender As Object, e As EventArgs) Handles btnhps.Click
        Call hapusPenerima()

    End Sub


End Class