Imports System.Data.SqlClient
Imports System.IO

Module Main_Module
    Public conn As New SqlConnection
    Public conn2 As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable
    Public Sql As String
    'for dev:
    'Public fileReader As String = My.Computer.FileSystem.ReadAllText("../../test.txt")
    '''''''''''''''=================================================================
    'Public fileReader As String = My.Computer.FileSystem.ReadAllText("test.txt")
    Public connStr As String = "Data Source=DESKTOP-GJEPGIK;Initial Catalog=Khounthavy;Integrated Security=True"
    Public connStr2 As String = "Data Source=DESKTOP-GJEPGIK;Initial Catalog=master;Integrated Security=True"
    Public AutoID As String
    Public USID As String
    Public Sub databaseConn()
        With conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connStr
            .Open()
        End With
    End Sub

    Public Sub databaseConn2()
        conn.Close()
        With conn2
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connStr2
            .Open()
        End With
    End Sub

    Public Function LoadingData(sql As String) As DataTable
        Try
            databaseConn()
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader()
            Dim dt As New DataTable
            dt.Load(dr)
            Return dt
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດໂຫຼດຕາຕະລາງໄດ້ເນື່ອງຈາກ: " + ex.Message)
            Return dt
        End Try
    End Function

    Public Sub cbobindingData(cbo As ComboBox,
                      dt As DataTable, Discol As String, ValCol As String)
        With cbo
            .DataSource = dt
            .DisplayMember = Discol
            .ValueMember = ValCol
        End With
    End Sub


    Public Sub AutoNum(Query As String, FirstChar As String)
        databaseConn()
        Dim o As Object
        cmd = New SqlCommand(Query, conn)
        o = cmd.ExecuteScalar()
        Dim id As String
        Dim str As String = o.ToString
        If str = "" Then
            AutoID = FirstChar & "000001"
        Else
            id = str.Substring(2, str.Length - 2)
            If id = "" Then
                AutoID = FirstChar & "000001"
            ElseIf id < 9 Then
                AutoID = FirstChar & "00000" & id + 1
            ElseIf id < 99 Then
                AutoID = FirstChar & "0000" & id + 1
            ElseIf id < 999 Then
                AutoID = FirstChar & "000" & id + 1
            ElseIf id < 9999 Then
                AutoID = FirstChar & "00" & id + 1
            ElseIf id < 99999 Then
                AutoID = FirstChar & "0" & id + 1
            ElseIf id >= 99999 Then
                AutoID = FirstChar & id + 1
            End If
        End If
    End Sub
    Public Function getByteFromPic(pic As PictureBox)
        Try
            Dim data As Byte()
            Dim ms As New MemoryStream
            pic.Image.Save(ms, pic.Image.RawFormat)
            data = ms.GetBuffer()
            Return data
        Catch
        End Try
    End Function
    Public Sub deleteData(sql As String, id As String)
        Try
            Call databaseConn()
            If MessageBox.Show("ຢືນຢັນການລົບຂໍ້ມູນຂອງທ່ານ...!", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                cmd = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
                MessageBox.Show("ລຶບຂໍ້ມູນລົງຖານຂໍ້ມູນສໍາເລັດແລ້ວ")
            End If
        Catch ex As Exception
            MessageBox.Show("ບໍ່ສາມາດລຶບຂໍ້ມູນໄດ້ເນື່ອງຈາກ: " + ex.Message)
        End Try
    End Sub
End Module
