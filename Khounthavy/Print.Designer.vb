<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Print))
        Me.KhounthavyDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KhounthavyDataSet = New Khounthavy.KhounthavyDataSet()
        Me.Pawn_viewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Pawn_viewTableAdapter = New Khounthavy.KhounthavyDataSetTableAdapters.Pawn_viewTableAdapter()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.KhounthavyDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KhounthavyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pawn_viewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KhounthavyDataSetBindingSource
        '
        Me.KhounthavyDataSetBindingSource.DataSource = Me.KhounthavyDataSet
        Me.KhounthavyDataSetBindingSource.Position = 0
        '
        'KhounthavyDataSet
        '
        Me.KhounthavyDataSet.DataSetName = "KhounthavyDataSet"
        Me.KhounthavyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pawn_viewBindingSource
        '
        Me.Pawn_viewBindingSource.DataMember = "Pawn_view"
        Me.Pawn_viewBindingSource.DataSource = Me.KhounthavyDataSet
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.KhounthavyDataSetBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Khounthavy.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 1)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(737, 716)
        Me.ReportViewer1.TabIndex = 0
        '
        'Pawn_viewTableAdapter
        '
        Me.Pawn_viewTableAdapter.ClearBeforeFill = True
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(1095, 924)
        Me.AxAcroPDF1.TabIndex = 1
        '
        'Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 924)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Print"
        Me.Text = "Bill"
        CType(Me.KhounthavyDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KhounthavyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pawn_viewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Pawn_viewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KhounthavyDataSet As Khounthavy.KhounthavyDataSet
    Friend WithEvents Pawn_viewTableAdapter As Khounthavy.KhounthavyDataSetTableAdapters.Pawn_viewTableAdapter
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents KhounthavyDataSetBindingSource As System.Windows.Forms.BindingSource

End Class
