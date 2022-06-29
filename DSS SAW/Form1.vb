Imports MySql.Data.MySqlClient
Public Class Form1

    Dim i As Integer
    Dim perintah As String


#Region "Database"
    Sub TambahkanData()
        Call KoneksiDB()

        perintah = "insert into t_penerima values ('" &
            txnik.Text & "','" &
            txnama.Text & "','" &
            txpenghasilan.Text & "','" &
            txtanggungan.Text & "','" &
            txkondisi.Text & "','" &
            txpekerjaan.Text & "','" &
            txusia.Text & "','" &
            txstatus.Text & "')"
    End Sub
    Sub TampilkanHasil()
        Call KoneksiDB()
        da = New MySqlDataAdapter("Select * from hasil", conn)
        dt = New DataSet
        da.Fill(dt, "hasil")
        dgvhasil.DataSource = (dt.Tables("hasil"))
    End Sub
    Sub EditData()

    End Sub
    Sub HapusData()

    End Sub
    Sub CariData()

    End Sub
    Sub SortData()

    End Sub

#End Region
#Region "Other"
    Sub BugInfo()
        'Untuk jaga jaga jika program gagal ketika ada textbox kosong
    End Sub
    Sub Clear()
        'Bersihkan Textbox
    End Sub
#End Region
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button4.Click
        formdata.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call KoneksiDB()
        db = ("SELECT*FROM t_penerima WHERE nik='" & txnik.Text & "'")
        cmd = New MySqlCommand(db, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            rd.Close()
            Dim simpan As String = "insert into t_penerima VALUES ('" & txnik.Text & "','" &
            txnama.Text & "','" &
            txpenghasilan.Text & "','" &
            txtanggungan.Text & "','" &
            txkondisi.Text & "','" &
            txpekerjaan.Text & "','" &
            txusia.Text & "','" &
            txstatus.Text & "')"
            cmd = New MySqlCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di simpan", vbInformation, "simpan")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilkanHasil()

    End Sub
End Class
