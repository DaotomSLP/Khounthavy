Imports System.Data.SqlClient
Public Class Home
    Public flag As Integer = 0
    Public y As Integer
    Public x As Integer
    Dim r As Double
    Dim F As Double
    Dim fn As Double
    Dim c As Integer = 0
    Dim a As Integer = 0
    Dim w(200) As Integer
    Dim z(200) As Integer
    Public t As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DateTime.Now.ToString("dd") = 28 Then
            Backup.backup()
        End If
        outOfPawn()
        t = 1
        'Me.Size = New Size(1470, 861)
        Call firstCheck()
        ' Call Pawn_firstCheck()
        Me.WindowState = FormWindowState.Maximized
        Call secondCheck()
        Call ANPLoad()
        'Call Pawn_secondCheck()
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Call secondCheck()
        'Call Pawn_secondCheck()
    End Sub
    Sub firstCheck()
        x = 0
        For Each table0 As Control In Me.Controls
            For Each table As Control In table0.Controls
                For Each table2 As Control In table.Controls
                    If TypeOf table2 Is Label Then
                        w(x) = table2.Height
                        x += 1
                    End If
                    For Each table3 As Control In table2.Controls
                        For Each table4 As Control In table3.Controls
                            table4.AutoSize = False
                            w(x) = table4.Height
                            x += 1
                            For Each table5 As Control In table4.Controls
                                For Each table6 As Control In table5.Controls
                                    table6.AutoSize = False
                                    w(x) = table6.Height
                                    x += 1
                                Next
                                table5.AutoSize = False
                                w(x) = table5.Height
                                x += 1
                            Next
                        Next
                        table3.AutoSize = False
                        w(x) = table3.Height
                        x += 1
                    Next
                Next
            Next
        Next
    End Sub
    Sub secondCheck()
        Try
            If c >= 1 Then
                x = 0
                For Each table0 As Control In Me.Controls
                    For Each table As Control In table0.Controls
                        For Each table2 As Control In table.Controls
                            If TypeOf table2 Is Label Then
                                z(x) = table2.Height
                                r = z(x) / w(x)
                                F = table2.Font.Size
                                fn = F * r
                                table2.Font = New Font("Phetsarath OT", fn)
                                w(x) = table2.Height
                                x += 1
                            End If
                            For Each table3 As Control In table2.Controls
                                For Each table4 As Control In table3.Controls
                                    z(x) = table4.Height
                                    r = z(x) / w(x)
                                    F = table4.Font.Size
                                    fn = F * r
                                    table4.Font = New Font("Phetsarath OT", fn)
                                    w(x) = table4.Height
                                    x += 1
                                    For Each table5 As Control In table4.Controls
                                        For Each table6 As Control In table5.Controls
                                            z(x) = table6.Height
                                            r = z(x) / w(x)
                                            ' MessageBox.Show(z(x))
                                            F = table6.Font.Size
                                            fn = F * r
                                            table6.Font = New Font("Phetsarath OT", fn)
                                            w(x) = table6.Height
                                            x += 1
                                        Next
                                        z(x) = table5.Height
                                        r = z(x) / w(x)
                                        ' MessageBox.Show(z(x))
                                        F = table5.Font.Size
                                        fn = F * r
                                        table5.Font = New Font("Phetsarath OT", fn)
                                        w(x) = table5.Height
                                        x += 1
                                    Next
                                Next
                                z(x) = table3.Height
                                r = z(x) / w(x)
                                ' MessageBox.Show(z(x))
                                F = table3.Font.Size
                                fn = F * r
                                table3.Font = New Font("Phetsarath OT", fn)
                                w(x) = table3.Height
                                x += 1
                            Next
                        Next
                    Next
                Next
                Call firstCheck()
            End If
            c += 1

        Catch
        End Try
    End Sub

    Private Sub menuCust_Click(sender As Object, e As EventArgs) Handles menuCust.Click
        PawnPannnnn.Visible = False
        TableLayoutPanel10.Visible = True
        TableLayoutPanel12.Visible = True
        pawn.Location = New Point(5000, 5000)
        Users.Location = New Point(5000, 5000)
        menuCust.BackColor = SystemColors.Info
        menuCust.ForeColor = Color.FromArgb(16, 22, 23)
        Menu_addNewPawn.BackColor = Color.FromArgb(16, 22, 23)
        Menu_addNewPawn.ForeColor = Color.Gold
        Pan_AddNewPawn.Location = New Point(0, 0)
        btnSaveEdit.Visible = False
        If flag = 0 Then
            flag = 1
            ANPLoad()
        Else

        End If
        textBoxClr()
        CustDgvShow.Enabled = True
        textEnable(True)
        txtCustId.Text = AutoID
    End Sub
    Private Sub menuCust2_Click(sender As Object, e As EventArgs) Handles menuCust2.Click
        PawnPannnnn.Visible = False
        TableLayoutPanel10.Visible = True
        TableLayoutPanel12.Visible = True
        menuCust.BackColor = SystemColors.Info
        menuCust.ForeColor = Color.FromArgb(16, 22, 23)
        Menu_addNewPawn.BackColor = Color.FromArgb(16, 22, 23)
        Menu_addNewPawn.ForeColor = Color.Gold
        pawn.Location = New Point(5000, 5000)
        Users.Location = New Point(5000, 5000)
        Pan_AddNewPawn.Location = New Point(0, 0)
        btnSaveEdit.Visible = True
        btnSave2.Text = "ເພິ່ມ"
        If flag = 0 Then
            flag = 1
            ANPLoad()
        Else

        End If
        textBoxClr()
        CustDgvShow.Enabled = True
        textEnable(True)
        txtCustId.Text = AutoID
    End Sub
    Private Sub menuCust3_Click(sender As Object, e As EventArgs) Handles menuCust3.Click
        PawnPannnnn.Visible = False
        TableLayoutPanel10.Visible = True
        TableLayoutPanel12.Visible = True
        menuCust.BackColor = SystemColors.Info
        menuCust.ForeColor = Color.FromArgb(16, 22, 23)
        Menu_addNewPawn.BackColor = Color.FromArgb(16, 22, 23)
        Menu_addNewPawn.ForeColor = Color.Gold
        pawn.Location = New Point(5000, 5000)
        Users.Location = New Point(5000, 5000)
        Pan_AddNewPawn.Location = New Point(0, 0)
        btnSaveEdit.Visible = True
        btnSave2.Text = "ເພິ່ມ"
        If flag = 0 Then
            flag = 1
            ANPLoad()
        Else

        End If
        textBoxClr()
        CustDgvShow.Enabled = True
        textEnable(True)
        txtCustId.Text = AutoID
    End Sub

    Private Sub Menu_addNewPawn_Click(sender As Object, e As EventArgs) Handles Menu_addNewPawn.Click
        PawnPannnnn.Visible = True
        pawn.Location = New Point(5000, 5000)
        Users.Location = New Point(5000, 5000)
        Pan_AddNewPawn.Location = New Point(0, 0)
        Menu_addNewPawn.BackColor = SystemColors.Info
        Menu_addNewPawn.ForeColor = Color.FromArgb(16, 22, 23)
        menuCust.BackColor = Color.FromArgb(16, 22, 23)
        menuCust.ForeColor = Color.Gold
        TableLayoutPanel10.Visible = False
        TableLayoutPanel12.Visible = False
        textBoxClr()
        If flag = 0 Then
            flag = 1
            ANPLoad()
            t = 1
        Else

        End If
        CustDgvShow.Enabled = False
        textEnable(False)
        CustType()
    End Sub
    Private Sub Menu_addNewPawn2_Click(sender As Object, e As EventArgs) Handles Menu_addNewPawn2.Click
        PawnPannnnn.Visible = True
        pawn.Location = New Point(5000, 5000)
        Users.Location = New Point(5000, 5000)
        Menu_addNewPawn.BackColor = SystemColors.Info
        Menu_addNewPawn.ForeColor = Color.FromArgb(16, 22, 23)
        menuCust.BackColor = Color.FromArgb(16, 22, 23)
        menuCust.ForeColor = Color.Gold
        Pan_AddNewPawn.Location = New Point(0, 0)
        TableLayoutPanel10.Visible = False
        TableLayoutPanel12.Visible = False
        textBoxClr()
        If flag = 0 Then
            flag = 1
            ANPLoad()
            t = 1
        Else

        End If
        CustDgvShow.Enabled = False
        textEnable(False)
        CustType()
    End Sub
    Private Sub Menu_addNewPawn3_Click(sender As Object, e As EventArgs) Handles Menu_addNewPawn3.Click
        PawnPannnnn.Visible = True
        pawn.Location = New Point(5000, 5000)
        Users.Location = New Point(5000, 5000)
        Menu_addNewPawn.BackColor = SystemColors.Info
        Menu_addNewPawn.ForeColor = Color.FromArgb(16, 22, 23)
        menuCust.BackColor = Color.FromArgb(16, 22, 23)
        menuCust.ForeColor = Color.Gold
        Pan_AddNewPawn.Location = New Point(0, 0)
        TableLayoutPanel10.Visible = False
        TableLayoutPanel12.Visible = False
        textBoxClr()
        If flag = 0 Then
            flag = 1
            ANPLoad()
            t = 1
        Else

        End If
        CustDgvShow.Enabled = False
        textEnable(False)
        CustType()
    End Sub

    Private Sub Menu_Pawn_Click(sender As Object, e As EventArgs) Handles Menu_Pawn.Click
        Pan_AddNewPawn.Location = New Point(5000, 5000)
        Users.Location = New Point(5000, 5000)
        pawn.Location = New Point(0, 0)
        PawnLoad()
        AutoNum("Select max(Cust_id) from Customer", "CM")
    End Sub
    Private Sub Menu_Pawn2_Click(sender As Object, e As EventArgs) Handles Menu_Pawn2.Click
        Pan_AddNewPawn.Location = New Point(5000, 5000)
        Users.Location = New Point(5000, 5000)
        pawn.Location = New Point(0, 0)
        PawnLoad()
        AutoNum("Select max(Cust_id) from Customer", "CM")
    End Sub

    Private Sub Menu_Pawn3_Click(sender As Object, e As EventArgs) Handles Menu_Pawn3.Click
        Pan_AddNewPawn.Location = New Point(5000, 5000)
        Users.Location = New Point(5000, 5000)
        pawn.Location = New Point(0, 0)
        PawnLoad()
        AutoNum("Select max(Cust_id) from Customer", "CM")
    End Sub
    Private Sub MenuUser_Click(sender As Object, e As EventArgs) Handles MenuUser.Click
        pawn.Location = New Point(5000, 5000)
        Pan_AddNewPawn.Location = New Point(5000, 5000)
        Users.Location = New Point(0, 0)

    End Sub
    Private Sub MenuUser2_Click(sender As Object, e As EventArgs) Handles MenuUser2.Click
        pawn.Location = New Point(5000, 5000)
        Pan_AddNewPawn.Location = New Point(5000, 5000)
        Users.Location = New Point(0, 0)

    End Sub
    Private Sub MenuUser3_Click(sender As Object, e As EventArgs) Handles MenuUser3.Click
        pawn.Location = New Point(5000, 5000)
        Pan_AddNewPawn.Location = New Point(5000, 5000)
        Users.Location = New Point(0, 0)

    End Sub

    Private Sub RadOldCust_CheckedChanged(sender As Object, e As EventArgs) Handles RadOldCust.CheckedChanged
            CustType()
        End Sub

        Private Sub RadNewCust_CheckedChanged(sender As Object, e As EventArgs) Handles RadNewCust.CheckedChanged
            CustType()
        End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSaveEdit.Visible = True
        btnSave2.Text = "ເພີ່ມຂໍ້ມູນໃໝ່"
        CustdgvCli()
    End Sub
        Private Sub btnDel_Click(sender As Object, e As MouseEventArgs) Handles btnDel.Click
            CustDel()
        End Sub
        Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
            CustEdit()
        End Sub
        Private Sub btnSave2_Click(sender As Object, e As EventArgs) Handles btnSave2.Click
            If btnSave2.Text = "ເພີ່ມຂໍ້ມູນໃໝ່" Then
                btnSave2.Text = "ບັນທຶກ"
                btnSaveEdit.Visible = False
                textBoxClr()
                AutoNum("Select max(Pawn_id) from Pawn", "PN")
            txtCustId.Text = AutoID
                txtPawnDate.Text = DateTime.Now.ToString("dd-MM-yyyy")
            Else
                CustSave()
            End If
        End Sub

    'Private Sub txtCustSearch_TextChanged(sender As Object, e As EventArgs) Handles txtCustSearch.TextChanged, TextBox1.TextChanged
    '    custSearch(txtCustSearch.Text)
    'End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If t = 1 Then
            PawnSave()
        Else
            PawnEdit()
        End If

    End Sub


        Private Sub CustDgvShow_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CustDgvShow.CellMouseClick
        If Menu_addNewPawn.BackColor = SystemColors.Info Then
            CustdgvCli()
            RadOldCust.Checked = True
        Else
        End If

        End Sub

        Private Sub txtProdNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProdNo.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtProdName.Select()
            End If
        End Sub
        Private Sub txtProdName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProdName.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtProdColor.Select()
            End If
        End Sub
        Private Sub txtProdColor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProdColor.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtAmount_kipp.Select()
            End If
        End Sub
        Private Sub txtAmount_kipp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAmount_kipp.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtAmount_bath.Select()
            End If
        End Sub
        Private Sub txtCustName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustName.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtCustLastName.Select()
            End If
        End Sub
        Private Sub txtCustLastName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustLastName.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtCustTel.Select()
            End If
        End Sub
        Private Sub txtCustTel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustTel.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtCustVill.Select()
            End If
        End Sub
        Private Sub txtCustVill_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustVill.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtCustDistri.Select()
            End If
        End Sub
        Private Sub txtCustDistri_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustDistri.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtCustProvin.Select()
            End If
        End Sub

    Private Sub btnPawnDel_Click(sender As Object, e As EventArgs)
        PawnDel()
    End Sub
    Private Sub btnTurnback_Click(sender As Object, e As EventArgs)
        turnBackStatus()
    End Sub

    'Private Sub txtPawnSearch_TextChanged(sender As Object, e As EventArgs)
    '    PawnSch(txtPawnSearch.Text)
    'End Sub

    Private Sub DTPPawnSch1_ValueChanged(sender As Object, e As EventArgs)
        PanwDgvshow.DataSource = LoadingData("select Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date from Pawn_view where Pawn_date between '" + Format(CDate(DTPPawnSch1.Value), "yyyy-MM-dd") +
                                                "' AND  '" + Format(CDate(DTPPawnSch2.Value), "yyyy-MM-dd") + "'")
    End Sub

    Private Sub DTPPawnSch2_ValueChanged(sender As Object, e As EventArgs)
        PanwDgvshow.DataSource = LoadingData("select Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date from Pawn_view where Pawn_date between '" + Format(CDate(DTPPawnSch1.Value), "yyyy-MM-dd") +
                                                "' AND  '" + Format(CDate(DTPPawnSch2.Value), "yyyy-MM-dd") + "'")
    End Sub

    Private Sub PanwDgvshow_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PanwDgvshow.CellMouseClick
        pawnDgvCli()
    End Sub

    'Private Sub RadOutofPawn_CheckedChanged(sender As Object, e As EventArgs) Handles RadOutofPawn.CheckedChanged
    '    StatusRadioChange()
    'End Sub

    'Private Sub RadWait_CheckedChanged(sender As Object, e As EventArgs) Handles RadWait.CheckedChanged
    '    StatusRadioChange()
    'End Sub

    'Private Sub RadSucc_CheckedChanged(sender As Object, e As EventArgs) Handles RadSucc.CheckedChanged
    '    StatusRadioChange()
    'End Sub

    Private Sub TxtAmount_bath_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAmount_bath.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtPassword.Select()
            End If
        End Sub

        Private Sub TxtCustProvin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustProvin.KeyDown
            If e.KeyCode = Keys.Enter Then
                txtImgNo.Select()
            End If
        End Sub

        Private Sub txtAmount_kipp_TextChanged(sender As Object, e As EventArgs) Handles txtAmount_kipp.TextChanged
            Try
                txtAmount_kipp.Text = Format(CInt(txtAmount_kipp.Text), "#,##")
                txtAmount_kipp.SelectionStart = txtAmount_kipp.TextLength
            Catch ex As Exception

            End Try
        End Sub

        Private Sub txtAmount_bath_TextChanged(sender As Object, e As EventArgs) Handles txtAmount_bath.TextChanged
            Try
                txtAmount_bath.Text = Format(CInt(txtAmount_bath.Text), "#,##")
                txtAmount_bath.SelectionStart = txtAmount_bath.TextLength
            Catch ex As Exception

            End Try
        End Sub

    Private Sub btnPawnEdit_Click(sender As Object, e As EventArgs) Handles btnPawnEdit.Click
        PawnPannnnn.Visible = True
        pawn.Location = New Point(5000, 5000)
        Users.Location = New Point(5000, 5000)
        Pan_AddNewPawn.Location = New Point(0, 0)
        Menu_addNewPawn.BackColor = SystemColors.Info
        Menu_addNewPawn.ForeColor = Color.FromArgb(16, 22, 23)
        menuCust.BackColor = Color.FromArgb(16, 22, 23)
        menuCust.ForeColor = Color.Gold
        TableLayoutPanel10.Visible = False
        TableLayoutPanel12.Visible = False
        textBoxClr()
        If flag = 0 Then
            flag = 1
        Else

        End If
        CustDgvShow.Enabled = False
        textEnable(True)
        txtCustId.Text = txtCustId2.Text
        txtCustName.Text = txtCustName2.Text
        txtCustLastName.Text = txtCustLastName2.Text
        txtCustDistri.Text = txtCustDist2.Text
        txtCustProvin.Text = txtCustProvi2.Text
        txtCustVill.Text = txtCustVill2.Text
        txtCustTel.Text = txtCustTel2.Text
        txtImgNo.Text = txtImgNo2.Text
        EditPawnClick()
        t = 0
    End Sub

    'Private Sub DTPPawnSch1_ValueChanged_1(sender As Object, e As EventArgs) Handles DTPPawnSch1.ValueChanged
    '    PawnSch(txtPawnSearch.Text, DTPPawnSch1, DTPPawnSch2)
    'End Sub

    'Private Sub DTPPawnSch2_ValueChanged_1(sender As Object, e As EventArgs) Handles DTPPawnSch2.ValueChanged
    '    PawnSch(txtPawnSearch.Text, DTPPawnSch1, DTPPawnSch2)
    'End Sub

    Private Sub btnTurnback_Click_1(sender As Object, e As EventArgs) Handles btnTurnback.Click
        addPawnImg.ShowDialog()
    End Sub

    Private Sub btnChangeUser_Click(sender As Object, e As EventArgs) Handles btnChangeUser.Click
        Backup.backup()
        MessageBox.Show("Success fully")
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Backup.restore()
            MessageBox.Show("success fully")
    End Sub

    Private Sub PanwDgvshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PanwDgvshow.CellContentClick

    End Sub

    Private Sub btnSearchPawn_Click(sender As Object, e As EventArgs) Handles btnSearchPawn.Click
        PawnSch(txtPawnSearch.Text, DTPPawnSch1, DTPPawnSch2)
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

    End Sub

    Private Sub btnCliSearch_Click(sender As Object, e As EventArgs) Handles btnCliSearch.Click
        custSearch(txtCustSearch.Text)
    End Sub

    Private Sub btnPawnReport_Click(sender As Object, e As EventArgs) Handles btnPawnReport.Click
        PawnReport()
    End Sub

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class