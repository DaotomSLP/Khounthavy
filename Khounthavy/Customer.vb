Imports System.IO

Module Customer
    Function custSearch(str As String)
        If str = "" Then
            Home.CustDgvShow.DataSource = LoadingData("select * from Customer order by Cust_id DESC")
        Else
            Home.CustDgvShow.DataSource = LoadingData("select * from Customer where Cust_id like '%" + str +
                                                 "%' OR Cust_name like N'%" + str + "%' OR  Cust_lastname like N'%" + str +
                                                 "%' OR Village like N'%" + str + "%' OR District like  N'%" + str +
                                                 "%' OR Province like N'%" + str + "%' order by Cust_id DESC")
        End If
    End Function
    Sub CustdgvCli()
        Try
            With Home
                Dim cindex As Integer = .CustDgvShow.CurrentRow.Index
                .txtCustId.Text = .CustDgvShow.Item(0, cindex).Value.ToString
                .txtCustName.Text = .CustDgvShow.Item(1, cindex).Value.ToString
                .txtCustLastName.Text = .CustDgvShow.Item(2, cindex).Value.ToString
                .txtCustTel.Text = .CustDgvShow.Item(3, cindex).Value.ToString
                .txtCustVill.Text = .CustDgvShow.Item(4, cindex).Value.ToString
                .txtCustDistri.Text = .CustDgvShow.Item(5, cindex).Value.ToString
                .txtCustProvin.Text = .CustDgvShow.Item(6, cindex).Value.ToString
                .txtImgNo.Text = .CustDgvShow.Item(7, cindex).Value.ToString
            End With
        Catch
        End Try
    End Sub
    Function CustParameter(sql As String)
        With Home
            cmd = New SqlClient.SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", .txtCustId.Text)
            cmd.Parameters.AddWithValue("@name", .txtCustName.Text)
            cmd.Parameters.AddWithValue("@lastname", .txtCustLastName.Text)
            cmd.Parameters.AddWithValue("@tel", .txtCustTel.Text)
            cmd.Parameters.AddWithValue("@vill", .txtCustVill.Text)
            cmd.Parameters.AddWithValue("@dist", .txtCustDistri.Text)
            cmd.Parameters.AddWithValue("@provi", .txtCustProvin.Text)
            cmd.Parameters.AddWithValue("@img", .txtImgNo.Text)
            cmd.ExecuteNonQuery()
        End With
    End Function
    Sub CustSave()
        If MessageBox.Show("ບັນທຶກລົງຂໍ້ມູນ ຫຼືບໍ່...", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                With Home
                    Sql = "insert into Customer values(@id,@name,@lastname,@tel,@vill,@dist,@provi,@img)"
                    Call CustParameter(Sql)
                    Call ANPLoad()
                    Call textBoxClr()
                End With
                MessageBox.Show("ເພີ່ມຂໍ້ມູນສຳເລັດ")
            Catch ex As Exception
                MessageBox.Show("ບໍ່ສາມາດເພີ່ມຂໍ້ມູນໄດ້ ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຖືກຕ້ອງ" + ex.ToString)
            End Try
        End If
    End Sub
    Sub CustDel()
        If MessageBox.Show("ລົບຂໍ້ມູນລູກຄ້າ ຫຼືບໍ່...", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim cindex As Integer = Home.CustDgvShow.CurrentRow.Index
            deleteData("delete from Customer where Cust_id=@id", Home.CustDgvShow.Item(0, cindex).Value.ToString)
            Call ANPLoad()
        End If
    End Sub
    Sub CustEdit()
        If MessageBox.Show("ປ່ຽນແປງຂໍ້ມູນລູກຄ້າ ຫຼືບໍ່...", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim cindex As Integer = Home.CustDgvShow.CurrentRow.Index
                Sql = "update Customer set Cust_name=@name ,Cust_lastname=@lastname ,Tel=@tel,Village=@vill,District=@dist,Province=@provi,Image=@img where Cust_id = @id"
                Call CustParameter(Sql)
                Call ANPLoad()
                Call textBoxClr()
                Home.btnSaveEdit.Visible = False
                Home.btnSave2.Text = "ບັນທຶກ"
                Home.CustDgvShow.Enabled = True
                MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສຳເລັດ")
            Catch ex As Exception
                MessageBox.Show("ບໍ່ສາມາດແກ້ໄຂຂໍ້ມູນໄດ້ ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຖືກຕ້ອງ" + ex.ToString)
            End Try
        End If
    End Sub
End Module
