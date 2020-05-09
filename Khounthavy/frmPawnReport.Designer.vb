<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPawnReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPawnReport))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PawnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KhounthavyDataSet = New Khounthavy.KhounthavyDataSet()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PawnTableAdapter = New Khounthavy.KhounthavyDataSetTableAdapters.PawnTableAdapter()
        Me.KhounthavyDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PawnviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pawn_viewTableAdapter = New Khounthavy.KhounthavyDataSetTableAdapters.Pawn_viewTableAdapter()
        CType(Me.PawnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KhounthavyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KhounthavyDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PawnviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PawnBindingSource
        '
        Me.PawnBindingSource.DataMember = "Pawn"
        Me.PawnBindingSource.DataSource = Me.KhounthavyDataSet
        '
        'KhounthavyDataSet
        '
        Me.KhounthavyDataSet.DataSetName = "KhounthavyDataSet"
        Me.KhounthavyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF1.Margin = New System.Windows.Forms.Padding(2)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(1278, 1326)
        Me.AxAcroPDF1.TabIndex = 2
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.KhounthavyDataSetBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Khounthavy.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1174, 1110)
        Me.ReportViewer1.TabIndex = 3
        '
        'PawnTableAdapter
        '
        Me.PawnTableAdapter.ClearBeforeFill = True
        '
        'KhounthavyDataSetBindingSource
        '
        Me.KhounthavyDataSetBindingSource.DataSource = Me.KhounthavyDataSet
        Me.KhounthavyDataSetBindingSource.Position = 0
        '
        'PawnviewBindingSource
        '
        Me.PawnviewBindingSource.DataMember = "Pawn_view"
        Me.PawnviewBindingSource.DataSource = Me.KhounthavyDataSetBindingSource
        '
        'Pawn_viewTableAdapter
        '
        Me.Pawn_viewTableAdapter.ClearBeforeFill = True
        '
        'frmPawnReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 1326)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmPawnReport"
        Me.Text = "frmPawnReport"
        CType(Me.PawnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KhounthavyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KhounthavyDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PawnviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PawnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KhounthavyDataSet As Khounthavy.KhounthavyDataSet
    Friend WithEvents PawnTableAdapter As Khounthavy.KhounthavyDataSetTableAdapters.PawnTableAdapter
    Friend WithEvents KhounthavyDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PawnviewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pawn_viewTableAdapter As Khounthavy.KhounthavyDataSetTableAdapters.Pawn_viewTableAdapter
End Class
