Imports System.IO
Imports Microsoft.Reporting.WinForms

Module Pawn
    Sub textbox2Clr()
        With Home
            .txtCustId2.Clear()
            .txtCustName2.Clear()
            .txtCustLastName2.Clear()
            .txtCustTel2.Clear()
            .txtCustVill2.Clear()
            .txtCustDist2.Clear()
            .txtCustProvi2.Clear()
        End With
    End Sub
    Sub PawnLoad()
        With Home.PanwDgvshow
            .DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view Order by Pawn_id DESC")
            Dim headerText() As String = {"ລະຫັດການຮັບຈຳນຳ", "ວັນທີ", "ມື້ຫຼຸດຈຳນຳ", "ໝາຍເລກເຄື່ອງ", "ຊື່ສິນຄ້າ", "ສີ", "ຈຳນວນເງິນ(ກີບ)", "ຈຳນວນເງິນ(ບາດ)", "ສະຖານະ", "ວັນທີສົ່ງເຄື່ອງຄືນ", "ລະຫັດລ໋ອກໜ້າຈໍ", "ລະຫັດຮູບຜູ້ມາເອົາເຄື່ອງ"}
            For i = 0 To headerText.Length - 1
                .Columns(i).HeaderText = headerText(i)
            Next
        End With
    End Sub
    Function PawnSch(str As String, str1 As DateTimePicker, str2 As DateTimePicker)
        If Home.RadOutofPawn.Checked = True Then
            If Home.radCom.Checked = True Then
                If str = "" Then
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຫຼຸດຈຳນຳ' AND type=N'ຄອມ' Order by Pawn_id DESC")
                Else
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where (Pawn_id like '%" + str +
                                                         "%' OR Prod_no like N'%" + str + "%' OR  Prod_name like N'%" + str + "' OR Cust_name like N'%" + str + "%' OR Cust_lastname like N'%" + str + "%') AND Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຫຼຸດຈຳນຳ' AND type=N'ຄອມ' Order by Pawn_id DESC")
                End If
            ElseIf Home.radMobile.Checked = True Then
                If str = "" Then
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຫຼຸດຈຳນຳ' AND type=N'ໂທລະສັບ' Order by Pawn_id DESC")
                Else
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where (Pawn_id like '%" + str +
                                                         "%' OR Prod_no like N'%" + str + "%' OR  Prod_name like N'%" + str + "' OR Cust_name like N'%" + str + "%' OR Cust_lastname like N'%" + str + "%') AND Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຫຼຸດຈຳນຳ' AND type=N'ໂທລະສັບ' Order by Pawn_id DESC")
                End If
            Else
                If str = "" Then
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຫຼຸດຈຳນຳ' Order by Pawn_id DESC")
                Else
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where (Pawn_id like '%" + str +
                                                         "%' OR Prod_no like N'%" + str + "%' OR  Prod_name like N'%" + str + "' OR Cust_name like N'%" + str + "%' OR Cust_lastname like N'%" + str + "%') AND Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຫຼຸດຈຳນຳ' Order by Pawn_id DESC")
                End If

            End If
            'Else
            '    If str = "" Then
            '        Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password from Pawn_view where Pawn_date between '" + str1.Value +
            '                                            "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຫຼຸດຈຳນຳ' AND type=N'ຄອມ' Order by Pawn_id DESC")
            '    Else
            '        Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password from Pawn_view where (Pawn_id like '%" + str +
            '                                             "%' OR Prod_no like N'%" + str + "%' OR  Prod_name like N'%" + str + "' OR Cust_name like N'%" + str + "%' OR Cust_lastname like N'%" + str + "%') AND Pawn_date between '" + str1.Value +
            '                                            "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຫຼຸດຈຳນຳ' AND type=N'ຄອມ' Order by Pawn_id DESC")
            '    End If

            'End If


            'Home.PanwDgvshow.DataSource = LoadingData("select Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password from Pawn_view Where Pawn_status=N'ຫຼຸດຈຳນຳ' Order by Pawn_id DESC")
        ElseIf Home.RadWait.Checked = True Then
            If Home.radCom.Checked = True Then
                If str = "" Then
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຍັງບໍ່ມາເອົາ' AND type=N'ຄອມ' Order by Pawn_id DESC")
                Else
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where (Pawn_id like '%" + str +
                                                         "%' OR Prod_no like N'%" + str + "%' OR  Prod_name like N'%" + str + "' OR Cust_name like N'%" + str + "%' OR Cust_lastname like N'%" + str + "%') AND Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຍັງບໍ່ມາເອົາ' AND type=N'ຄອມ' Order by Pawn_id DESC")
                End If
            ElseIf Home.radMobile.Checked = True Then
                If str = "" Then
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຍັງບໍ່ມາເອົາ' AND type=N'ໂທລະສັບ' Order by Pawn_id DESC")
                Else
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where (Pawn_id like '%" + str +
                                                         "%' OR Prod_no like N'%" + str + "%' OR  Prod_name like N'%" + str + "' OR Cust_name like N'%" + str + "%' OR Cust_lastname like N'%" + str + "%') AND Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຍັງບໍ່ມາເອົາ' AND type=N'ໂທລະສັບ' Order by Pawn_id DESC")
                End If
            Else
                If str = "" Then
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຍັງບໍ່ມາເອົາ' Order by Pawn_id DESC")
                Else
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where (Pawn_id like '%" + str +
                                                         "%' OR Prod_no like N'%" + str + "%' OR  Prod_name like N'%" + str + "' OR Cust_name like N'%" + str + "%' OR Cust_lastname like N'%" + str + "%') AND Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ຍັງບໍ່ມາເອົາ' Order by Pawn_id DESC")
                End If

            End If
        ElseIf Home.RadSucc.Checked = True Then
            If Home.radCom.Checked = True Then
                If str = "" Then
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ສົ່ງເຄື່ອງຄືນແລ້ວ' AND type=N'ຄອມ' Order by Pawn_id DESC")
                Else
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where (Pawn_id like '%" + str +
                                                         "%' OR Prod_no like N'%" + str + "%' OR  Prod_name like N'%" + str + "' OR Cust_name like N'%" + str + "%' OR Cust_lastname like N'%" + str + "%') AND Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ສົ່ງເຄື່ອງຄືນແລ້ວ' AND type=N'ຄອມ' Order by Pawn_id DESC")
                End If
            ElseIf Home.radMobile.Checked = True Then
                If str = "" Then
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ສົ່ງເຄື່ອງຄືນແລ້ວ' AND type=N'ໂທລະສັບ' Order by Pawn_id DESC")
                Else
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where (Pawn_id like '%" + str +
                                                         "%' OR Prod_no like N'%" + str + "%' OR  Prod_name like N'%" + str + "' OR Cust_name like N'%" + str + "%' OR Cust_lastname like N'%" + str + "%') AND Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ສົ່ງເຄື່ອງຄືນແລ້ວ' AND type=N'ໂທລະສັບ' Order by Pawn_id DESC")
                End If
            Else
                If str = "" Then
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ສົ່ງເຄື່ອງຄືນແລ້ວ' Order by Pawn_id DESC")
                Else
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where (Pawn_id like '%" + str +
                                                         "%' OR Prod_no like N'%" + str + "%' OR  Prod_name like N'%" + str + "' OR Cust_name like N'%" + str + "%' OR Cust_lastname like N'%" + str + "%') AND Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND  Pawn_status=N'ສົ່ງເຄື່ອງຄືນແລ້ວ' Order by Pawn_id DESC")
                End If

            End If
        Else
            If Home.radCom.Checked = True Then
                If str = "" Then
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND type=N'ຄອມ' Order by Pawn_id DESC")
                Else
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where (Pawn_id like '%" + str +
                                                         "%' OR Prod_no like N'%" + str + "%' OR  Prod_name like N'%" + str + "' OR Cust_name like N'%" + str + "%' OR Cust_lastname like N'%" + str + "%') AND Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND type=N'ຄອມ' Order by Pawn_id DESC")
                End If
            ElseIf Home.radMobile.Checked = True Then
                If str = "" Then
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND type=N'ໂທລະສັບ' Order by Pawn_id DESC")
                Else
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where (Pawn_id like '%" + str +
                                                         "%' OR Prod_no like N'%" + str + "%' OR  Prod_name like N'%" + str + "' OR Cust_name like N'%" + str + "%' OR Cust_lastname like N'%" + str + "%') AND Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' AND type=N'ໂທລະສັບ' Order by Pawn_id DESC")
                End If
            Else
                If str = "" Then
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' Order by Pawn_id DESC")
                Else
                    Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where (Pawn_id like '%" + str +
                                                         "%' OR Prod_no like N'%" + str + "%' OR  Prod_name like N'%" + str + "' OR Cust_name like N'%" + str + "%' OR Cust_lastname like N'%" + str + "%') AND Pawn_date between '" + str1.Value +
                                                        "' AND  '" + str2.Value + "' Order by Pawn_id DESC")
                End If

            End If
        End If

        textbox2Clr()
    End Function
    Function PawnSchDate(str1 As DateTimePicker, str2 As DateTimePicker)
        Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view where  Pawn_date between '" + str1.Value +
                                                "' AND  '" + str2.Value + "' Order by Pawn_id DESC")
    End Function
    Sub pawnDgvCli()
        Try
            Dim cindex As Integer = Home.PanwDgvshow.CurrentRow.Index
            dt = LoadingData("select Cust_id,Cust_name,Cust_lastname,Tel,Village,District,Province,Image from Pawn_view where Pawn_id = '" + Home.PanwDgvshow.Item(0, cindex).Value.ToString + "' Order by Pawn_id DESC")
            For Each row In dt.Rows
                With Home
                    .txtCustId2.Text = row(0)
                    .txtCustName2.Text = row(1)
                    .txtCustLastName2.Text = row(2)
                    .txtCustTel2.Text = row(3)
                    .txtCustVill2.Text = row(4)
                    .txtCustDist2.Text = row(5)
                    .txtCustProvi2.Text = row(6)
                    .txtImgNo2.Text = row(7)
                End With
            Next
        Catch
        End Try
    End Sub
    Sub turnBackStatus()
        Dim cindex As Integer = Home.PanwDgvshow.CurrentRow.Index
        Sql = "update Pawn set Pawn_status=@status,Pawn_turnBa_date=getDate(),img=@img where Pawn_id=@id"
        cmd = New SqlClient.SqlCommand(Sql, conn)
        cmd.Parameters.AddWithValue("@id", Home.PanwDgvshow.Item(0, cindex).Value.ToString)
        cmd.Parameters.AddWithValue("@status", "ສົ່ງເຄື່ອງຄືນແລ້ວ")
        cmd.Parameters.AddWithValue("@img", addPawnImg.txtImgNo.Text)
        cmd.ExecuteNonQuery()
        PawnLoad()
    End Sub
    Sub PawnDel()
        Dim cindex As Integer = Home.PanwDgvshow.CurrentRow.Index
        If Home.PanwDgvshow.Item(8, cindex).Value.ToString = "ຍັງບໍ່ມາເອົາ" Then
            MessageBox.Show("ບໍ່ສາມາດລົບການຮັບຈຳນຳນີ້ໄດ້")
        Else
            If MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນການຮັບຈຳນຳ ຫຼືບໍ່...", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                deleteData("delete from Pawn where Pawn_id=@id", Home.PanwDgvshow.Item(0, cindex).Value.ToString)
                Call PawnLoad()
            End If
        End If
    End Sub
    Sub outOfPawn()
        dt = LoadingData("SELECT Pawn_id,Pawn_exp from Pawn where Pawn_exp < convert (date,GETDATE()) and Pawn_status = N'ຍັງບໍ່ມາເອົາ'")
        If dt Is Nothing Then

        Else
            For Each row In dt.Rows
                Dim sql As String
                sql = "update Pawn set Pawn_status=@status where Pawn_id = @id"
                cmd = New SqlClient.SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@status", "ຫຼຸດຈຳນຳ")
                cmd.Parameters.AddWithValue("@id", row(0))
                cmd.ExecuteNonQuery()
            Next
        End If
    End Sub
    Sub StatusRadioChange()
        If Home.RadOutofPawn.Checked = True Then
            Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view Where Pawn_status=N'ຫຼຸດຈຳນຳ' Order by Pawn_id DESC")
        ElseIf Home.RadWait.Checked = True Then
            Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view Where Pawn_status=N'ຍັງບໍ່ມາເອົາ' Order by Pawn_id DESC")
        ElseIf Home.RadSucc.Checked = True Then
            Home.PanwDgvshow.DataSource = LoadingData("select TOP (1000) Pawn_id,Pawn_date,Pawn_exp,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Pawn_status,Pawn_turnBa_date,Password,img from Pawn_view Where Pawn_status=N'ສົ່ງເຄື່ອງຄືນແລ້ວ' Order by Pawn_id DESC")
        Else

        End If
        textbox2Clr()
    End Sub
    Sub EditPawnClick()
        Try
            Dim cindex As Integer = Home.PanwDgvshow.CurrentRow.Index
            dt = LoadingData("select Pawn_id,Pawn_date,Prod_no,Prod_name,Prod_color,Pawn_amount_kip,Pawn_amount_bath,Password from Pawn_view where Pawn_id = '" + Home.PanwDgvshow.Item(0, cindex).Value.ToString + "' Order by Pawn_id DESC")
            For Each row In dt.Rows
                With Home
                    .txtPawnId.Text = row(0)
                    .txtPawnDate.Text = row(1)
                    .txtProdNo.Text = row(2)
                    .txtProdName.Text = row(3)
                    .txtProdColor.Text = row(4)
                    .txtAmount_kipp.Text = row(5)
                    .txtAmount_bath.Text = row(6)
                    .txtPassword.Text = row(7)
                End With
            Next
        Catch
        End Try
    End Sub

    Sub PawnReport()

        Dim dtb As New DataTable
        If Home.radCom.Checked = True Then
            Sql = "SELECT * FROM   Pawn_view where Pawn_date BETWEEN '" + Home.DTPPawnSch1.Value + "' AND '" + Home.DTPPawnSch2.Value + "' AND type='ຄອມ'"
        ElseIf Home.radMobile.Checked = True Then
            Sql = "SELECT * FROM   Pawn_view where Pawn_date BETWEEN '" + Home.DTPPawnSch1.Value + "' AND '" + Home.DTPPawnSch2.Value + "' AND type='ໂທລະສັບ'"
        Else
            Sql = "SELECT * FROM   Pawn_view where Pawn_date BETWEEN '" + Home.DTPPawnSch1.Value + "' AND '" + Home.DTPPawnSch2.Value + "'"
        End If
        dtb = LoadingData(Sql)
        Dim rptsrc As New ReportDataSource("DataSet1", dtb)
        frmPawnReport.ReportViewer1.LocalReport.DataSources.Clear()
        frmPawnReport.ReportViewer1.LocalReport.DataSources.Add(rptsrc)

        frmPawnReport.ReportViewer1.LocalReport.Refresh()
        frmPawnReport.Show()
    End Sub
End Module
