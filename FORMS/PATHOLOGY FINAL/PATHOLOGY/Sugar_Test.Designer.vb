<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sugar_Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sugar_Test))
        Me.lblsugar_test = New System.Windows.Forms.Label
        Me.txtp_name = New System.Windows.Forms.TextBox
        Me.lblp_name = New System.Windows.Forms.Label
        Me.lblp_id = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRUA = New System.Windows.Forms.TextBox
        Me.txtPPUS = New System.Windows.Forms.TextBox
        Me.txtFUS = New System.Windows.Forms.TextBox
        Me.txtRBS = New System.Windows.Forms.TextBox
        Me.txtPPUA = New System.Windows.Forms.TextBox
        Me.txtPLBS = New System.Windows.Forms.TextBox
        Me.txtFBS = New System.Windows.Forms.TextBox
        Me.lblRUA = New System.Windows.Forms.Label
        Me.lblPPUS = New System.Windows.Forms.Label
        Me.lblFUS = New System.Windows.Forms.Label
        Me.lblRBS = New System.Windows.Forms.Label
        Me.lblPPUA = New System.Windows.Forms.Label
        Me.lblPLBS = New System.Windows.Forms.Label
        Me.lblFBS = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdML = New System.Windows.Forms.Button
        Me.cmdMN = New System.Windows.Forms.Button
        Me.cmdMP = New System.Windows.Forms.Button
        Me.cmdMF = New System.Windows.Forms.Button
        Me.SUGARGrid = New System.Windows.Forms.DataGridView
        Me.cmbpid = New System.Windows.Forms.ComboBox
        Me.lbltestid = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdback = New System.Windows.Forms.Button
        Me.cmbclear = New System.Windows.Forms.Button
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdadd = New System.Windows.Forms.Button
        Me.cmdmodify = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmbtest_id = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SUGARGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblsugar_test
        '
        Me.lblsugar_test.AutoSize = True
        Me.lblsugar_test.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsugar_test.Location = New System.Drawing.Point(368, 176)
        Me.lblsugar_test.Name = "lblsugar_test"
        Me.lblsugar_test.Size = New System.Drawing.Size(200, 33)
        Me.lblsugar_test.TabIndex = 0
        Me.lblsugar_test.Text = "SUGAR TEST"
        '
        'txtp_name
        '
        Me.txtp_name.Location = New System.Drawing.Point(173, 291)
        Me.txtp_name.Name = "txtp_name"
        Me.txtp_name.Size = New System.Drawing.Size(121, 20)
        Me.txtp_name.TabIndex = 2
        '
        'lblp_name
        '
        Me.lblp_name.AutoSize = True
        Me.lblp_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_name.Location = New System.Drawing.Point(33, 298)
        Me.lblp_name.Name = "lblp_name"
        Me.lblp_name.Size = New System.Drawing.Size(99, 13)
        Me.lblp_name.TabIndex = 10
        Me.lblp_name.Text = "PATIENT NAME"
        '
        'lblp_id
        '
        Me.lblp_id.AutoSize = True
        Me.lblp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_id.Location = New System.Drawing.Point(29, 212)
        Me.lblp_id.Name = "lblp_id"
        Me.lblp_id.Size = New System.Drawing.Size(77, 13)
        Me.lblp_id.TabIndex = 9
        Me.lblp_id.Text = "PATIENT ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRUA)
        Me.GroupBox1.Controls.Add(Me.txtPPUS)
        Me.GroupBox1.Controls.Add(Me.txtFUS)
        Me.GroupBox1.Controls.Add(Me.txtRBS)
        Me.GroupBox1.Controls.Add(Me.txtPPUA)
        Me.GroupBox1.Controls.Add(Me.txtPLBS)
        Me.GroupBox1.Controls.Add(Me.txtFBS)
        Me.GroupBox1.Controls.Add(Me.lblRUA)
        Me.GroupBox1.Controls.Add(Me.lblPPUS)
        Me.GroupBox1.Controls.Add(Me.lblFUS)
        Me.GroupBox1.Controls.Add(Me.lblRBS)
        Me.GroupBox1.Controls.Add(Me.lblPPUA)
        Me.GroupBox1.Controls.Add(Me.lblPLBS)
        Me.GroupBox1.Controls.Add(Me.lblFBS)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 312)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 291)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'txtRUA
        '
        Me.txtRUA.Location = New System.Drawing.Point(253, 236)
        Me.txtRUA.MaxLength = 3
        Me.txtRUA.Name = "txtRUA"
        Me.txtRUA.Size = New System.Drawing.Size(100, 20)
        Me.txtRUA.TabIndex = 9
        '
        'txtPPUS
        '
        Me.txtPPUS.Location = New System.Drawing.Point(253, 200)
        Me.txtPPUS.MaxLength = 3
        Me.txtPPUS.Name = "txtPPUS"
        Me.txtPPUS.Size = New System.Drawing.Size(100, 20)
        Me.txtPPUS.TabIndex = 8
        '
        'txtFUS
        '
        Me.txtFUS.Location = New System.Drawing.Point(253, 168)
        Me.txtFUS.MaxLength = 3
        Me.txtFUS.Name = "txtFUS"
        Me.txtFUS.Size = New System.Drawing.Size(100, 20)
        Me.txtFUS.TabIndex = 7
        '
        'txtRBS
        '
        Me.txtRBS.Location = New System.Drawing.Point(253, 132)
        Me.txtRBS.MaxLength = 3
        Me.txtRBS.Name = "txtRBS"
        Me.txtRBS.Size = New System.Drawing.Size(100, 20)
        Me.txtRBS.TabIndex = 6
        '
        'txtPPUA
        '
        Me.txtPPUA.Location = New System.Drawing.Point(253, 92)
        Me.txtPPUA.MaxLength = 3
        Me.txtPPUA.Name = "txtPPUA"
        Me.txtPPUA.Size = New System.Drawing.Size(100, 20)
        Me.txtPPUA.TabIndex = 5
        '
        'txtPLBS
        '
        Me.txtPLBS.Location = New System.Drawing.Point(253, 56)
        Me.txtPLBS.MaxLength = 3
        Me.txtPLBS.Name = "txtPLBS"
        Me.txtPLBS.Size = New System.Drawing.Size(100, 20)
        Me.txtPLBS.TabIndex = 4
        '
        'txtFBS
        '
        Me.txtFBS.Location = New System.Drawing.Point(253, 20)
        Me.txtFBS.MaxLength = 3
        Me.txtFBS.Name = "txtFBS"
        Me.txtFBS.Size = New System.Drawing.Size(100, 20)
        Me.txtFBS.TabIndex = 3
        '
        'lblRUA
        '
        Me.lblRUA.AutoSize = True
        Me.lblRUA.Location = New System.Drawing.Point(19, 243)
        Me.lblRUA.Name = "lblRUA"
        Me.lblRUA.Size = New System.Drawing.Size(166, 13)
        Me.lblRUA.TabIndex = 6
        Me.lblRUA.Text = "RANDOM URINE ACETONE"
        '
        'lblPPUS
        '
        Me.lblPPUS.AutoSize = True
        Me.lblPPUS.Location = New System.Drawing.Point(19, 207)
        Me.lblPPUS.Name = "lblPPUS"
        Me.lblPPUS.Size = New System.Drawing.Size(196, 13)
        Me.lblPPUS.TabIndex = 5
        Me.lblPPUS.Text = "POST PRANDIAL URINE SUGAR"
        '
        'lblFUS
        '
        Me.lblFUS.AutoSize = True
        Me.lblFUS.Location = New System.Drawing.Point(19, 171)
        Me.lblFUS.Name = "lblFUS"
        Me.lblFUS.Size = New System.Drawing.Size(150, 13)
        Me.lblFUS.TabIndex = 4
        Me.lblFUS.Text = "FASTING URINE SUGAR"
        '
        'lblRBS
        '
        Me.lblRBS.AutoSize = True
        Me.lblRBS.Location = New System.Drawing.Point(19, 135)
        Me.lblRBS.Name = "lblRBS"
        Me.lblRBS.Size = New System.Drawing.Size(154, 13)
        Me.lblRBS.TabIndex = 3
        Me.lblRBS.Text = "RANDOM BLOOD SUGAR"
        '
        'lblPPUA
        '
        Me.lblPPUA.AutoSize = True
        Me.lblPPUA.Location = New System.Drawing.Point(19, 99)
        Me.lblPPUA.Name = "lblPPUA"
        Me.lblPPUA.Size = New System.Drawing.Size(211, 13)
        Me.lblPPUA.TabIndex = 2
        Me.lblPPUA.Text = "POST PRANDIAL URINE ACETONE"
        '
        'lblPLBS
        '
        Me.lblPLBS.AutoSize = True
        Me.lblPLBS.Location = New System.Drawing.Point(19, 63)
        Me.lblPLBS.Name = "lblPLBS"
        Me.lblPLBS.Size = New System.Drawing.Size(179, 13)
        Me.lblPLBS.TabIndex = 1
        Me.lblPLBS.Text = "POST LUNCH BLOOD SUGAR"
        '
        'lblFBS
        '
        Me.lblFBS.AutoSize = True
        Me.lblFBS.Location = New System.Drawing.Point(19, 27)
        Me.lblFBS.Name = "lblFBS"
        Me.lblFBS.Size = New System.Drawing.Size(153, 13)
        Me.lblFBS.TabIndex = 0
        Me.lblFBS.Text = "FASTING BLOOD SUGAR"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdML)
        Me.GroupBox3.Controls.Add(Me.cmdMN)
        Me.GroupBox3.Controls.Add(Me.cmdMP)
        Me.GroupBox3.Controls.Add(Me.cmdMF)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(443, 483)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 61)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'cmdML
        '
        Me.cmdML.BackColor = System.Drawing.Color.Silver
        Me.cmdML.Location = New System.Drawing.Point(339, 19)
        Me.cmdML.Name = "cmdML"
        Me.cmdML.Size = New System.Drawing.Size(75, 23)
        Me.cmdML.TabIndex = 3
        Me.cmdML.Text = ">|"
        Me.cmdML.UseVisualStyleBackColor = False
        '
        'cmdMN
        '
        Me.cmdMN.BackColor = System.Drawing.Color.Silver
        Me.cmdMN.Location = New System.Drawing.Point(239, 19)
        Me.cmdMN.Name = "cmdMN"
        Me.cmdMN.Size = New System.Drawing.Size(75, 23)
        Me.cmdMN.TabIndex = 2
        Me.cmdMN.Text = ">"
        Me.cmdMN.UseVisualStyleBackColor = False
        '
        'cmdMP
        '
        Me.cmdMP.BackColor = System.Drawing.Color.Silver
        Me.cmdMP.Location = New System.Drawing.Point(141, 19)
        Me.cmdMP.Name = "cmdMP"
        Me.cmdMP.Size = New System.Drawing.Size(75, 23)
        Me.cmdMP.TabIndex = 1
        Me.cmdMP.Text = "<"
        Me.cmdMP.UseVisualStyleBackColor = False
        '
        'cmdMF
        '
        Me.cmdMF.BackColor = System.Drawing.Color.Silver
        Me.cmdMF.Location = New System.Drawing.Point(28, 19)
        Me.cmdMF.Name = "cmdMF"
        Me.cmdMF.Size = New System.Drawing.Size(75, 23)
        Me.cmdMF.TabIndex = 0
        Me.cmdMF.Text = "|<"
        Me.cmdMF.UseVisualStyleBackColor = False
        '
        'SUGARGrid
        '
        Me.SUGARGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SUGARGrid.Location = New System.Drawing.Point(443, 212)
        Me.SUGARGrid.Name = "SUGARGrid"
        Me.SUGARGrid.Size = New System.Drawing.Size(611, 252)
        Me.SUGARGrid.TabIndex = 39
        '
        'cmbpid
        '
        Me.cmbpid.FormattingEnabled = True
        Me.cmbpid.Location = New System.Drawing.Point(173, 212)
        Me.cmbpid.Name = "cmbpid"
        Me.cmbpid.Size = New System.Drawing.Size(121, 21)
        Me.cmbpid.TabIndex = 1
        '
        'lbltestid
        '
        Me.lbltestid.AutoSize = True
        Me.lbltestid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltestid.Location = New System.Drawing.Point(33, 258)
        Me.lbltestid.Name = "lbltestid"
        Me.lbltestid.Size = New System.Drawing.Size(56, 13)
        Me.lbltestid.TabIndex = 55
        Me.lbltestid.Text = "TEST ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdback)
        Me.GroupBox2.Controls.Add(Me.cmbclear)
        Me.GroupBox2.Controls.Add(Me.cmddelete)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdadd)
        Me.GroupBox2.Controls.Add(Me.cmdmodify)
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(36, 628)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(623, 58)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        '
        'cmdback
        '
        Me.cmdback.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(451, 19)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(75, 23)
        Me.cmdback.TabIndex = 7
        Me.cmdback.Text = "BACK"
        Me.cmdback.UseVisualStyleBackColor = True
        '
        'cmbclear
        '
        Me.cmbclear.BackColor = System.Drawing.Color.LightGray
        Me.cmbclear.Location = New System.Drawing.Point(285, 20)
        Me.cmbclear.Name = "cmbclear"
        Me.cmbclear.Size = New System.Drawing.Size(75, 23)
        Me.cmbclear.TabIndex = 5
        Me.cmbclear.Text = "CLEAR"
        Me.cmbclear.UseVisualStyleBackColor = False
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.LightGray
        Me.cmddelete.Location = New System.Drawing.Point(370, 20)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 23)
        Me.cmddelete.TabIndex = 4
        Me.cmddelete.Text = "DELETE"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.LightGray
        Me.cmdexit.Location = New System.Drawing.Point(532, 19)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(75, 23)
        Me.cmdexit.TabIndex = 3
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.LightGray
        Me.cmdadd.Location = New System.Drawing.Point(6, 19)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(75, 23)
        Me.cmdadd.TabIndex = 2
        Me.cmdadd.Text = "ADD"
        Me.cmdadd.UseVisualStyleBackColor = False
        '
        'cmdmodify
        '
        Me.cmdmodify.BackColor = System.Drawing.Color.LightGray
        Me.cmdmodify.Location = New System.Drawing.Point(97, 19)
        Me.cmdmodify.Name = "cmdmodify"
        Me.cmdmodify.Size = New System.Drawing.Size(75, 23)
        Me.cmdmodify.TabIndex = 1
        Me.cmdmodify.Text = "MODIFY"
        Me.cmdmodify.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.LightGray
        Me.cmdsave.Location = New System.Drawing.Point(190, 19)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 23)
        Me.cmdsave.TabIndex = 0
        Me.cmdsave.Text = "SAVE"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmbtest_id
        '
        Me.cmbtest_id.Enabled = False
        Me.cmbtest_id.Location = New System.Drawing.Point(173, 251)
        Me.cmbtest_id.Name = "cmbtest_id"
        Me.cmbtest_id.Size = New System.Drawing.Size(121, 20)
        Me.cmbtest_id.TabIndex = 59
        Me.cmbtest_id.TabStop = False
        Me.cmbtest_id.Text = "7"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(406, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 137)
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'Sugar_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1028, 742)
        Me.Controls.Add(Me.cmbtest_id)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbltestid)
        Me.Controls.Add(Me.cmbpid)
        Me.Controls.Add(Me.SUGARGrid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtp_name)
        Me.Controls.Add(Me.lblp_name)
        Me.Controls.Add(Me.lblp_id)
        Me.Controls.Add(Me.lblsugar_test)
        Me.Name = "Sugar_Test"
        Me.Text = "SUGAR_TEST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.SUGARGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblsugar_test As System.Windows.Forms.Label
    Friend WithEvents txtp_name As System.Windows.Forms.TextBox
    Friend WithEvents lblp_name As System.Windows.Forms.Label
    Friend WithEvents lblp_id As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRUA As System.Windows.Forms.TextBox
    Friend WithEvents txtPPUS As System.Windows.Forms.TextBox
    Friend WithEvents txtFUS As System.Windows.Forms.TextBox
    Friend WithEvents txtRBS As System.Windows.Forms.TextBox
    Friend WithEvents txtPPUA As System.Windows.Forms.TextBox
    Friend WithEvents txtPLBS As System.Windows.Forms.TextBox
    Friend WithEvents txtFBS As System.Windows.Forms.TextBox
    Friend WithEvents lblRUA As System.Windows.Forms.Label
    Friend WithEvents lblPPUS As System.Windows.Forms.Label
    Friend WithEvents lblFUS As System.Windows.Forms.Label
    Friend WithEvents lblRBS As System.Windows.Forms.Label
    Friend WithEvents lblPPUA As System.Windows.Forms.Label
    Friend WithEvents lblPLBS As System.Windows.Forms.Label
    Friend WithEvents lblFBS As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdML As System.Windows.Forms.Button
    Friend WithEvents cmdMN As System.Windows.Forms.Button
    Friend WithEvents cmdMP As System.Windows.Forms.Button
    Friend WithEvents cmdMF As System.Windows.Forms.Button
    Friend WithEvents SUGARGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbpid As System.Windows.Forms.ComboBox
    Friend WithEvents lbltestid As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbclear As System.Windows.Forms.Button
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents cmdmodify As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmbtest_id As System.Windows.Forms.TextBox
    Friend WithEvents cmdback As System.Windows.Forms.Button
End Class
