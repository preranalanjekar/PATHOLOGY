<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stool_Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stool_Test))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtcolour = New System.Windows.Forms.ComboBox
        Me.txconsistency = New System.Windows.Forms.ComboBox
        Me.lblcolour = New System.Windows.Forms.Label
        Me.txtredu = New System.Windows.Forms.TextBox
        Me.txtocc = New System.Windows.Forms.TextBox
        Me.txtreaction = New System.Windows.Forms.TextBox
        Me.txtblood = New System.Windows.Forms.TextBox
        Me.txtstarch = New System.Windows.Forms.TextBox
        Me.txtparasites = New System.Windows.Forms.TextBox
        Me.lblredu = New System.Windows.Forms.Label
        Me.lblocc = New System.Windows.Forms.Label
        Me.lblreaction = New System.Windows.Forms.Label
        Me.lblblood = New System.Windows.Forms.Label
        Me.lblstarch = New System.Windows.Forms.Label
        Me.lblconsistency = New System.Windows.Forms.Label
        Me.lblparasites = New System.Windows.Forms.Label
        Me.txtp_name = New System.Windows.Forms.TextBox
        Me.lblp_name = New System.Windows.Forms.Label
        Me.lblp_id = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblstool_test = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdML = New System.Windows.Forms.Button
        Me.cmdMN = New System.Windows.Forms.Button
        Me.cmdMP = New System.Windows.Forms.Button
        Me.cmdMF = New System.Windows.Forms.Button
        Me.STOOLGrid = New System.Windows.Forms.DataGridView
        Me.cmbpid = New System.Windows.Forms.ComboBox
        Me.lbl_sttestid = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdback = New System.Windows.Forms.Button
        Me.cmbclear = New System.Windows.Forms.Button
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdadd = New System.Windows.Forms.Button
        Me.cmdmodify = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmbtest_id = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.STOOLGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcolour)
        Me.GroupBox1.Controls.Add(Me.txconsistency)
        Me.GroupBox1.Controls.Add(Me.lblcolour)
        Me.GroupBox1.Controls.Add(Me.txtredu)
        Me.GroupBox1.Controls.Add(Me.txtocc)
        Me.GroupBox1.Controls.Add(Me.txtreaction)
        Me.GroupBox1.Controls.Add(Me.txtblood)
        Me.GroupBox1.Controls.Add(Me.txtstarch)
        Me.GroupBox1.Controls.Add(Me.txtparasites)
        Me.GroupBox1.Controls.Add(Me.lblredu)
        Me.GroupBox1.Controls.Add(Me.lblocc)
        Me.GroupBox1.Controls.Add(Me.lblreaction)
        Me.GroupBox1.Controls.Add(Me.lblblood)
        Me.GroupBox1.Controls.Add(Me.lblstarch)
        Me.GroupBox1.Controls.Add(Me.lblconsistency)
        Me.GroupBox1.Controls.Add(Me.lblparasites)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(37, 278)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 307)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'txtcolour
        '
        Me.txtcolour.FormattingEnabled = True
        Me.txtcolour.Items.AddRange(New Object() {"NORMAL", "DARK", "LIGHT"})
        Me.txtcolour.Location = New System.Drawing.Point(226, 270)
        Me.txtcolour.Name = "txtcolour"
        Me.txtcolour.Size = New System.Drawing.Size(99, 21)
        Me.txtcolour.TabIndex = 9
        '
        'txconsistency
        '
        Me.txconsistency.FormattingEnabled = True
        Me.txconsistency.Items.AddRange(New Object() {"NORMAL", "VERY HARD", "HARD", "LOOSE", "LIQUID"})
        Me.txconsistency.Location = New System.Drawing.Point(222, 58)
        Me.txconsistency.Name = "txconsistency"
        Me.txconsistency.Size = New System.Drawing.Size(103, 21)
        Me.txconsistency.TabIndex = 3
        '
        'lblcolour
        '
        Me.lblcolour.AutoSize = True
        Me.lblcolour.Location = New System.Drawing.Point(23, 273)
        Me.lblcolour.Name = "lblcolour"
        Me.lblcolour.Size = New System.Drawing.Size(58, 13)
        Me.lblcolour.TabIndex = 14
        Me.lblcolour.Text = "COLOUR"
        '
        'txtredu
        '
        Me.txtredu.Location = New System.Drawing.Point(226, 240)
        Me.txtredu.MaxLength = 3
        Me.txtredu.Name = "txtredu"
        Me.txtredu.Size = New System.Drawing.Size(100, 20)
        Me.txtredu.TabIndex = 8
        '
        'txtocc
        '
        Me.txtocc.Location = New System.Drawing.Point(226, 207)
        Me.txtocc.MaxLength = 3
        Me.txtocc.Name = "txtocc"
        Me.txtocc.Size = New System.Drawing.Size(100, 20)
        Me.txtocc.TabIndex = 7
        '
        'txtreaction
        '
        Me.txtreaction.Location = New System.Drawing.Point(226, 171)
        Me.txtreaction.MaxLength = 3
        Me.txtreaction.Name = "txtreaction"
        Me.txtreaction.Size = New System.Drawing.Size(100, 20)
        Me.txtreaction.TabIndex = 6
        '
        'txtblood
        '
        Me.txtblood.Location = New System.Drawing.Point(226, 135)
        Me.txtblood.MaxLength = 3
        Me.txtblood.Name = "txtblood"
        Me.txtblood.Size = New System.Drawing.Size(100, 20)
        Me.txtblood.TabIndex = 5
        '
        'txtstarch
        '
        Me.txtstarch.Location = New System.Drawing.Point(226, 99)
        Me.txtstarch.MaxLength = 3
        Me.txtstarch.Name = "txtstarch"
        Me.txtstarch.Size = New System.Drawing.Size(100, 20)
        Me.txtstarch.TabIndex = 4
        '
        'txtparasites
        '
        Me.txtparasites.Location = New System.Drawing.Point(226, 23)
        Me.txtparasites.MaxLength = 3
        Me.txtparasites.Name = "txtparasites"
        Me.txtparasites.Size = New System.Drawing.Size(100, 20)
        Me.txtparasites.TabIndex = 2
        '
        'lblredu
        '
        Me.lblredu.AutoSize = True
        Me.lblredu.Location = New System.Drawing.Point(19, 243)
        Me.lblredu.Name = "lblredu"
        Me.lblredu.Size = New System.Drawing.Size(158, 13)
        Me.lblredu.TabIndex = 6
        Me.lblredu.Text = "REDUCING SUBSTANCES"
        '
        'lblocc
        '
        Me.lblocc.AutoSize = True
        Me.lblocc.Location = New System.Drawing.Point(19, 207)
        Me.lblocc.Name = "lblocc"
        Me.lblocc.Size = New System.Drawing.Size(102, 13)
        Me.lblocc.TabIndex = 5
        Me.lblocc.Text = "OCCULT BLOOD"
        '
        'lblreaction
        '
        Me.lblreaction.AutoSize = True
        Me.lblreaction.Location = New System.Drawing.Point(19, 171)
        Me.lblreaction.Name = "lblreaction"
        Me.lblreaction.Size = New System.Drawing.Size(70, 13)
        Me.lblreaction.TabIndex = 4
        Me.lblreaction.Text = "REACTION"
        '
        'lblblood
        '
        Me.lblblood.AutoSize = True
        Me.lblblood.Location = New System.Drawing.Point(19, 135)
        Me.lblblood.Name = "lblblood"
        Me.lblblood.Size = New System.Drawing.Size(49, 13)
        Me.lblblood.TabIndex = 3
        Me.lblblood.Text = "BLOOD"
        '
        'lblstarch
        '
        Me.lblstarch.AutoSize = True
        Me.lblstarch.Location = New System.Drawing.Point(19, 99)
        Me.lblstarch.Name = "lblstarch"
        Me.lblstarch.Size = New System.Drawing.Size(57, 13)
        Me.lblstarch.TabIndex = 2
        Me.lblstarch.Text = "STARCH"
        '
        'lblconsistency
        '
        Me.lblconsistency.AutoSize = True
        Me.lblconsistency.Location = New System.Drawing.Point(19, 63)
        Me.lblconsistency.Name = "lblconsistency"
        Me.lblconsistency.Size = New System.Drawing.Size(94, 13)
        Me.lblconsistency.TabIndex = 1
        Me.lblconsistency.Text = "CONSISTENCY"
        '
        'lblparasites
        '
        Me.lblparasites.AutoSize = True
        Me.lblparasites.Location = New System.Drawing.Point(19, 27)
        Me.lblparasites.Name = "lblparasites"
        Me.lblparasites.Size = New System.Drawing.Size(76, 13)
        Me.lblparasites.TabIndex = 0
        Me.lblparasites.Text = "PARASITES"
        '
        'txtp_name
        '
        Me.txtp_name.Location = New System.Drawing.Point(175, 247)
        Me.txtp_name.Name = "txtp_name"
        Me.txtp_name.Size = New System.Drawing.Size(100, 20)
        Me.txtp_name.TabIndex = 1
        '
        'lblp_name
        '
        Me.lblp_name.AutoSize = True
        Me.lblp_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_name.Location = New System.Drawing.Point(56, 247)
        Me.lblp_name.Name = "lblp_name"
        Me.lblp_name.Size = New System.Drawing.Size(99, 13)
        Me.lblp_name.TabIndex = 17
        Me.lblp_name.Text = "PATIENT NAME"
        '
        'lblp_id
        '
        Me.lblp_id.AutoSize = True
        Me.lblp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_id.Location = New System.Drawing.Point(56, 183)
        Me.lblp_id.Name = "lblp_id"
        Me.lblp_id.Size = New System.Drawing.Size(77, 13)
        Me.lblp_id.TabIndex = 16
        Me.lblp_id.Text = "PATIENT ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, -53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Label1"
        '
        'lblstool_test
        '
        Me.lblstool_test.AutoSize = True
        Me.lblstool_test.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstool_test.Location = New System.Drawing.Point(364, 146)
        Me.lblstool_test.Name = "lblstool_test"
        Me.lblstool_test.Size = New System.Drawing.Size(196, 33)
        Me.lblstool_test.TabIndex = 34
        Me.lblstool_test.Text = "STOOL TEST"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdML)
        Me.GroupBox3.Controls.Add(Me.cmdMN)
        Me.GroupBox3.Controls.Add(Me.cmdMP)
        Me.GroupBox3.Controls.Add(Me.cmdMF)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(463, 551)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 61)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        '
        'cmdML
        '
        Me.cmdML.BackColor = System.Drawing.Color.LightGray
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
        'STOOLGrid
        '
        Me.STOOLGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.STOOLGrid.Location = New System.Drawing.Point(463, 290)
        Me.STOOLGrid.Name = "STOOLGrid"
        Me.STOOLGrid.Size = New System.Drawing.Size(553, 248)
        Me.STOOLGrid.TabIndex = 38
        '
        'cmbpid
        '
        Me.cmbpid.FormattingEnabled = True
        Me.cmbpid.Location = New System.Drawing.Point(175, 183)
        Me.cmbpid.Name = "cmbpid"
        Me.cmbpid.Size = New System.Drawing.Size(100, 21)
        Me.cmbpid.TabIndex = 1
        '
        'lbl_sttestid
        '
        Me.lbl_sttestid.AutoSize = True
        Me.lbl_sttestid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sttestid.Location = New System.Drawing.Point(56, 212)
        Me.lbl_sttestid.Name = "lbl_sttestid"
        Me.lbl_sttestid.Size = New System.Drawing.Size(56, 13)
        Me.lbl_sttestid.TabIndex = 41
        Me.lbl_sttestid.Text = "TEST ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(371, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 113)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
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
        Me.GroupBox2.Location = New System.Drawing.Point(175, 630)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(636, 58)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'cmdback
        '
        Me.cmdback.BackColor = System.Drawing.Color.Silver
        Me.cmdback.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(460, 19)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(75, 23)
        Me.cmdback.TabIndex = 7
        Me.cmdback.Text = "BACK"
        Me.cmdback.UseVisualStyleBackColor = False
        '
        'cmbclear
        '
        Me.cmbclear.BackColor = System.Drawing.Color.Silver
        Me.cmbclear.Location = New System.Drawing.Point(285, 20)
        Me.cmbclear.Name = "cmbclear"
        Me.cmbclear.Size = New System.Drawing.Size(75, 23)
        Me.cmbclear.TabIndex = 5
        Me.cmbclear.Text = "CLEAR"
        Me.cmbclear.UseVisualStyleBackColor = False
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.Silver
        Me.cmddelete.Location = New System.Drawing.Point(375, 19)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 23)
        Me.cmddelete.TabIndex = 4
        Me.cmddelete.Text = "DELETE"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.Silver
        Me.cmdexit.Location = New System.Drawing.Point(541, 19)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(75, 23)
        Me.cmdexit.TabIndex = 3
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.Silver
        Me.cmdadd.Location = New System.Drawing.Point(6, 19)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(75, 23)
        Me.cmdadd.TabIndex = 2
        Me.cmdadd.Text = "ADD"
        Me.cmdadd.UseVisualStyleBackColor = False
        '
        'cmdmodify
        '
        Me.cmdmodify.BackColor = System.Drawing.Color.Silver
        Me.cmdmodify.Location = New System.Drawing.Point(97, 19)
        Me.cmdmodify.Name = "cmdmodify"
        Me.cmdmodify.Size = New System.Drawing.Size(75, 23)
        Me.cmdmodify.TabIndex = 1
        Me.cmdmodify.Text = "MODIFY"
        Me.cmdmodify.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.Silver
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
        Me.cmbtest_id.Location = New System.Drawing.Point(175, 212)
        Me.cmbtest_id.Name = "cmbtest_id"
        Me.cmbtest_id.Size = New System.Drawing.Size(100, 20)
        Me.cmbtest_id.TabIndex = 60
        Me.cmbtest_id.TabStop = False
        Me.cmbtest_id.Text = "6"
        '
        'Stool_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1028, 742)
        Me.Controls.Add(Me.cmbtest_id)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_sttestid)
        Me.Controls.Add(Me.cmbpid)
        Me.Controls.Add(Me.STOOLGrid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblstool_test)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtp_name)
        Me.Controls.Add(Me.lblp_name)
        Me.Controls.Add(Me.lblp_id)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Stool_Test"
        Me.Text = "STOOL_TEST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.STOOLGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtredu As System.Windows.Forms.TextBox
    Friend WithEvents txtocc As System.Windows.Forms.TextBox
    Friend WithEvents txtreaction As System.Windows.Forms.TextBox
    Friend WithEvents txtblood As System.Windows.Forms.TextBox
    Friend WithEvents txtstarch As System.Windows.Forms.TextBox
    Friend WithEvents txtparasites As System.Windows.Forms.TextBox
    Friend WithEvents lblredu As System.Windows.Forms.Label
    Friend WithEvents lblocc As System.Windows.Forms.Label
    Friend WithEvents lblreaction As System.Windows.Forms.Label
    Friend WithEvents lblblood As System.Windows.Forms.Label
    Friend WithEvents lblstarch As System.Windows.Forms.Label
    Friend WithEvents lblconsistency As System.Windows.Forms.Label
    Friend WithEvents lblparasites As System.Windows.Forms.Label
    Friend WithEvents txtp_name As System.Windows.Forms.TextBox
    Friend WithEvents lblp_name As System.Windows.Forms.Label
    Friend WithEvents lblp_id As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblcolour As System.Windows.Forms.Label
    Friend WithEvents lblstool_test As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdML As System.Windows.Forms.Button
    Friend WithEvents cmdMN As System.Windows.Forms.Button
    Friend WithEvents cmdMP As System.Windows.Forms.Button
    Friend WithEvents cmdMF As System.Windows.Forms.Button
    Friend WithEvents STOOLGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbpid As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_sttestid As System.Windows.Forms.Label
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
    Friend WithEvents txtcolour As System.Windows.Forms.ComboBox
    Friend WithEvents txconsistency As System.Windows.Forms.ComboBox
End Class
