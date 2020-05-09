Imports System.Data.SqlClient
Imports System.IO
Public Class Login
    Sub login()
        Dim dr As SqlDataReader
        databaseConn()
        Sql = "select * from Users where Users_name='" + txtUsersName.Text + "' and Users_pass='" + Encrypt(txtUsersPass.Text, "abc") + "'"
        cmd = New SqlCommand(Sql, conn)
        dr = cmd.ExecuteReader
        While dr.Read
            USID = dr("Users_id").ToString
            Home.Show()
            Home.lblUser.Text = txtUsersName.Text
            Me.Close()
            conn.Close()
            Exit Sub
        End While
        MessageBox.Show("ຊື່ຜູ້ໃຊ້ ຫຼື ລະຫັດຜ່ານບໍ່ຖືກຕ້ອງ")
        txtUsersPass.Clear()
    End Sub
    Private Sub txtUsersName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsersName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtUsersPass.Select()
        End If
    End Sub

    Private Sub txtUsersPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsersPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(fileReader)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '  Try
        Dim txt As String = File.ReadAllText("test.txt")
        txt = txt.Replace(txt, txtUsersName.Text)
        File.WriteAllText("test.txt", txt)
        MessageBox.Show("Change Server name success, Please start Program again")
        Me.Close()
        '  Catch
        'Dim txt As String = File.ReadAllText("../../test.txt")
        'txt = txt.Replace(txt, txtUsersName.Text)
        'File.WriteAllText("../../test.txt", txt)
        'MessageBox.Show("Change Server name success, Please start Program again")
        'Me.Close()
        '   End Try
    End Sub
End Class