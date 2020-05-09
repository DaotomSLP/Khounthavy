Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing

Module AddNewPawn
    Function CustCotrlVisi(b As Boolean)
        Home.btnEdit.Visible = b
        Home.btnDel.Visible = b
        Home.btnSaveEdit.Visible = b
        Home.btnSave2.Visible = b
    End Function
    Function textEnable(b As Boolean)
        Home.txtCustName.Enabled = b
        Home.txtCustLastName.Enabled = b
        Home.txtCustTel.Enabled = b
        Home.txtCustVill.Enabled = b
        Home.txtCustDistri.Enabled = b
        Home.txtCustProvin.Enabled = b
        Home.txtImgNo.Enabled = b
    End Function
    Sub CustType()
        If Home.RadNewCust.Checked = True Then
            Home.CustDgvShow.Enabled = False
            AutoNum("Select max(Cust_id) from Customer", "CM")
            Home.txtCustId.Text = AutoID
            textEnable(True)
            textBoxClr()
        Else
            Home.CustDgvShow.Enabled = True
            Home.txtCustId.Clear()
            textEnable(False)
            textBoxClr()
        End If
    End Sub
    Sub ANPLoad()
        AutoNum("Select max(Pawn_id) from Pawn", "PN")
        Home.txtPawnId.Text = AutoID
        Home.txtPawnDate.Text = DateTime.Now.ToString("dd-MM-yyyy")
        With Home.CustDgvShow
            .DataSource = LoadingData("select * from Customer Order by Cust_id DESC")
            Dim headerText() As String = {"ລະຫັດລູກຄ້າ", "ຊື່", "ນາມສະກຸນ", "ເບີໂທ", "ບ້ານ", "ເມືອງ", "ແຂວງ", "ຮູບ"}
            For i = 0 To headerText.Length - 1
                .Columns(i).HeaderText = headerText(i)
                .Columns(i).Width = 150
            Next
        End With
        AutoNum("Select max(Cust_id) from Customer", "CM")
        Home.txtCustId.Text = AutoID

        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("1", "ໂທລະສັບ")
        comboSource.Add("2", "ຄອມ")
        Home.typeCombo.DataSource = New BindingSource(comboSource, Nothing)
        Home.typeCombo.DisplayMember = "Value"
        Home.typeCombo.ValueMember = "Key"

    End Sub
    Sub textBoxClr()
        With Home
            .txtCustName.Clear()
            .txtCustLastName.Clear()
            .txtCustProvin.Clear()
            .txtCustTel.Clear()
            .txtCustVill.Clear()
            .txtCustDistri.Clear()
            .txtCustSearch.Clear()
            .txtImgNo.Clear()
        End With
    End Sub
    Sub PawnEdit()
        Try
            With Home
                Sql = "UPDATE Customer SET Cust_name = @Cust_name, Cust_lastname= @Cust_lastname,Tel = @Tel, Village=@Village,District=@District,Province=@Province,Image=@Image  WHERE Cust_id = @Cust_id"
                    cmd = New SqlClient.SqlCommand(Sql, conn)
                cmd.Parameters.AddWithValue("@Cust_id", .txtCustId.Text)
                cmd.Parameters.AddWithValue("@Cust_name", .txtCustName.Text)
                cmd.Parameters.AddWithValue("@Cust_lastname", .txtCustLastName.Text)
                cmd.Parameters.AddWithValue("@Tel", .txtCustTel.Text)
                cmd.Parameters.AddWithValue("@Village", .txtCustVill.Text)
                cmd.Parameters.AddWithValue("@District", .txtCustDistri.Text)
                cmd.Parameters.AddWithValue("@Province", .txtCustProvin.Text)
                cmd.Parameters.AddWithValue("@Image", .txtImgNo.Text)
                cmd.ExecuteNonQuery()

                Sql = "UPDATE Pawn SET Pawn_date=getDate(),Prod_no=@ProdNo,Prod_name=@ProdName,Prod_color=@ProdColor,Pawn_amount_kip=@amountKip,Pawn_amount_bath=@amountBath,Pawn_exp=@exp,Password=@pass,Cust_id=@custId,type=@type WHERE Pawn_id=@id"
                cmd = New SqlClient.SqlCommand(Sql, conn)
                cmd.Parameters.AddWithValue("@id", .txtPawnId.Text)
                cmd.Parameters.AddWithValue("@ProdNo", .txtProdNo.Text)
                cmd.Parameters.AddWithValue("@ProdName", .txtProdName.Text)
                cmd.Parameters.AddWithValue("@ProdColor", .txtProdColor.Text)
                If .txtAmount_kipp.Text = "" Then
                    cmd.Parameters.AddWithValue("@amountKip", 0)
                Else
                    cmd.Parameters.AddWithValue("@amountKip", .txtAmount_kipp.Text)
                End If
                If .txtAmount_bath.Text = "" Then
                    cmd.Parameters.AddWithValue("@amountBath", 0)
                Else
                    cmd.Parameters.AddWithValue("@amountBath", .txtAmount_bath.Text)
                End If
                cmd.Parameters.AddWithValue("@exp", .DTPexp.Value)
                cmd.Parameters.AddWithValue("@custId", .txtCustId.Text)
                cmd.Parameters.AddWithValue("@pass", Home.txtPassword.Text)
                Dim type As String = DirectCast(Home.typeCombo.SelectedItem, KeyValuePair(Of String, String)).Value
                cmd.Parameters.AddWithValue("@type", type)
                cmd.ExecuteNonQuery()
                Bill()
                ANPLoad()
                Home.t = 1
            End With
            MessageBox.Show("ເພີ່ມຂໍ້ມູນສຳເລັດ")
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດເພີ່ມຂໍ້ມູນໄດ້ ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຖືກຕ້ອງ" + ex.Message)
        End Try
    End Sub
    Sub PawnSave()
        If MessageBox.Show("ບັນທຶກລົງຂໍ້ມູນ ຫຼືບໍ່...", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                With Home
                    If .RadOldCust.Checked = True Then
                        Sql = "insert into Pawn values(@id,getDate(),@ProdNo,@ProdName,@ProdColor,@amountKip,@amountBath,@exp,@custId,@userId,@status,@turnback,@pass,@img,@type)"
                        cmd = New SqlClient.SqlCommand(Sql, conn)
                        cmd.Parameters.AddWithValue("@id", .txtPawnId.Text)
                        cmd.Parameters.AddWithValue("@ProdNo", .txtProdNo.Text)
                        cmd.Parameters.AddWithValue("@ProdName", .txtProdName.Text)
                        cmd.Parameters.AddWithValue("@ProdColor", .txtProdColor.Text)
                        If .txtAmount_kipp.Text = "" Then
                            cmd.Parameters.AddWithValue("@amountKip", 0)
                        Else
                            cmd.Parameters.AddWithValue("@amountKip", .txtAmount_kipp.Text)
                        End If
                        If .txtAmount_bath.Text = "" Then
                            cmd.Parameters.AddWithValue("@amountBath", 0)
                        Else
                            cmd.Parameters.AddWithValue("@amountBath", .txtAmount_bath.Text)
                        End If
                        cmd.Parameters.AddWithValue("@exp", .DTPexp.Value)
                        cmd.Parameters.AddWithValue("@custId", .txtCustId.Text)
                        cmd.Parameters.AddWithValue("@userId", USID)
                        cmd.Parameters.AddWithValue("@status", "ຍັງບໍ່ມາເອົາ")
                        cmd.Parameters.AddWithValue("@turnback", "")
                        cmd.Parameters.AddWithValue("@pass", Home.txtPassword.Text)

                        cmd.Parameters.AddWithValue("@img", "")
                        Dim type As String = DirectCast(Home.typeCombo.SelectedItem, KeyValuePair(Of String, String)).Value
                        cmd.Parameters.AddWithValue("@type", type)
                        cmd.ExecuteNonQuery()
                        Bill()
                    Else
                        Sql = "insert into Customer values(@id,@name,@lastname,@tel,@vill,@dist,@provi,@img)"
                        cmd = New SqlClient.SqlCommand(Sql, conn)
                        cmd.Parameters.AddWithValue("@id", .txtCustId.Text)
                        cmd.Parameters.AddWithValue("@name", .txtCustName.Text)
                        cmd.Parameters.AddWithValue("@lastname", .txtCustLastName.Text)
                        cmd.Parameters.AddWithValue("@tel", .txtCustTel.Text)
                        cmd.Parameters.AddWithValue("@vill", .txtCustVill.Text)
                        cmd.Parameters.AddWithValue("@dist", .txtCustDistri.Text)
                        cmd.Parameters.AddWithValue("@provi", .txtCustProvin.Text)
                        cmd.Parameters.AddWithValue("@img", .txtImgNo.Text)
                        cmd.ExecuteNonQuery()

                        Sql = "insert into Pawn values(@id,getDate(),@ProdNo,@ProdName,@ProdColor,@amountKip,@amountBath,@exp,@custId,@userId,@status,@turnback,@pass,@img,@type)"
                        cmd = New SqlClient.SqlCommand(Sql, conn)
                        cmd.Parameters.AddWithValue("@id", .txtPawnId.Text)
                        cmd.Parameters.AddWithValue("@ProdNo", .txtProdNo.Text)
                        cmd.Parameters.AddWithValue("@ProdName", .txtProdName.Text)
                        cmd.Parameters.AddWithValue("@ProdColor", .txtProdColor.Text)
                        If .txtAmount_kipp.Text = "" Then
                            cmd.Parameters.AddWithValue("@amountKip", 0)
                        Else
                            cmd.Parameters.AddWithValue("@amountKip", .txtAmount_kipp.Text)
                        End If
                        If .txtAmount_bath.Text = "" Then
                            cmd.Parameters.AddWithValue("@amountBath", 0)
                        Else
                            cmd.Parameters.AddWithValue("@amountBath", .txtAmount_bath.Text)
                        End If
                        cmd.Parameters.AddWithValue("@exp", .DTPexp.Value)
                        cmd.Parameters.AddWithValue("@custId", .txtCustId.Text)
                        cmd.Parameters.AddWithValue("@userId", USID)
                        cmd.Parameters.AddWithValue("@status", "ຍັງບໍ່ມາເອົາ")
                        cmd.Parameters.AddWithValue("@turnback", "")
                        cmd.Parameters.AddWithValue("@pass", Home.txtPassword.Text)
                        cmd.Parameters.AddWithValue("@img", "")
                        Dim type As String = DirectCast(Home.typeCombo.SelectedItem, KeyValuePair(Of String, String)).Value
                        cmd.Parameters.AddWithValue("@type", type)
                        cmd.ExecuteNonQuery()
                        Bill()
                    End If
                    ANPLoad()
                End With
                MessageBox.Show("ເພີ່ມຂໍ້ມູນສຳເລັດ")
            Catch ex As Exception
                MessageBox.Show("ບໍ່ສາມາດເພີ່ມຂໍ້ມູນໄດ້ ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຖືກຕ້ອງ" + ex.Message)
            End Try
        End If
    End Sub
    Sub Bill()

        Dim dtb As New DataTable
        Sql = "SELECT * FROM   Pawn_view where Pawn_id='" + Home.txtPawnId.Text + "' "
        dtb = LoadingData(Sql)
        Dim rptsrc As New ReportDataSource("DataSet1", dtb)
        Print.ReportViewer1.LocalReport.DataSources.Clear()
        Print.ReportViewer1.LocalReport.DataSources.Add(rptsrc)

        Print.ReportViewer1.LocalReport.Refresh()
        Print.Show()
    End Sub

End Module
