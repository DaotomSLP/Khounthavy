<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addPawnImg
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
        Me.btnTurnback = New System.Windows.Forms.Button()
        Me.txtImgNo = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTurnback
        '
        Me.btnTurnback.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTurnback.FlatAppearance.BorderSize = 2
        Me.btnTurnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTurnback.Font = New System.Drawing.Font("Phetsarath OT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnTurnback.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnTurnback.Location = New System.Drawing.Point(337, 289)
        Me.btnTurnback.Name = "btnTurnback"
        Me.btnTurnback.Size = New System.Drawing.Size(281, 52)
        Me.btnTurnback.TabIndex = 7
        Me.btnTurnback.Text = "ຕົກລົງ"
        Me.btnTurnback.UseVisualStyleBackColor = True
        '
        'txtImgNo
        '
        Me.txtImgNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImgNo.BackColor = System.Drawing.SystemColors.Info
        Me.txtImgNo.Font = New System.Drawing.Font("Phetsarath OT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImgNo.ForeColor = System.Drawing.Color.Tomato
        Me.txtImgNo.Location = New System.Drawing.Point(203, 211)
        Me.txtImgNo.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.txtImgNo.Name = "txtImgNo"
        Me.txtImgNo.Size = New System.Drawing.Size(520, 45)
        Me.txtImgNo.TabIndex = 8
        '
        'Label29
        '
        Me.Label29.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.Font = New System.Drawing.Font("Phetsarath OT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label29.Location = New System.Drawing.Point(345, 122)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(239, 66)
        Me.Label29.TabIndex = 9
        Me.Label29.Text = "ປ້ອນໝາຍເລກຮູບ :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addPawnImg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 518)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtImgNo)
        Me.Controls.Add(Me.btnTurnback)
        Me.Name = "addPawnImg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTurnback As System.Windows.Forms.Button
    Friend WithEvents txtImgNo As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
End Class
