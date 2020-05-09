Module Backup
    Sub backup()
        Call databaseConn()
        cmd = New SqlClient.SqlCommand("BACKUP DATABASE Khounthavy TO DISK = 'F:\Tom\DB\DB.bak'", conn)
        cmd.ExecuteNonQuery()

    End Sub

    Sub restore()
        Call databaseConn2()
        cmd = New SqlClient.SqlCommand("RESTORE DATABASE Khounthavy FROM DISK = 'F:\Tom\DB\DB.bak'", conn2)
        cmd.ExecuteNonQuery()
    End Sub

End Module
