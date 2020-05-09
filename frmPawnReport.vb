Imports Microsoft.Reporting.WinForms

Public Class frmPawnReport

    Private Sub frmPawnReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KhounthavyDataSet.Pawn_view' table. You can move, or remove it, as needed.
        Me.Pawn_viewTableAdapter.Fill(Me.KhounthavyDataSet.Pawn_view)
        'TODO: This line of code loads data into the 'KhounthavyDataSet.Pawn' table. You can move, or remove it, as needed.
        Me.PawnTableAdapter.Fill(Me.KhounthavyDataSet.Pawn)
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Dim pdfContent As Byte() = ReportViewer1.LocalReport.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Dim pdfPath As String = "C:\Users\DodoJa1\Desktop\report.PDF"
        Dim pdfFile As New System.IO.FileStream(pdfPath, System.IO.FileMode.Create)
        pdfFile.Write(pdfContent, 0, pdfContent.Length)
        pdfFile.Close()

        Me.ReportViewer1.RefreshReport()
        AxAcroPDF1.LoadFile(pdfPath)
    End Sub
End Class