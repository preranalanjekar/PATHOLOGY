<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Urine_Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Urine_Test))
        Me.txtp_name = New System.Windows.Forms.TextBox
        Me.lblp_name = New System.Windows.Forms.Label
        Me.lblp_id = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtucolor = New System.Windows.Forms.ComboBox
        Me.txtcast = New System.Windows.Forms.ComboBox
        Me.txtapp = New System.Windows.Forms.ComboBox
        Me.lblacetone = New System.Windows.Forms.Label
        Me.lblalbumin = New System.Windows.Forms.Label
        Me.lblocc = New System.Windows.Forms.Label
        Me.txtacet = New System.Windows.Forms.TextBox
        Me.txtualbumin = New System.Windows.Forms.TextBox
        Me.txtocc_blood = New System.Windows.Forms.TextBox
        Me.lblcolour = New System.Windows.Forms.Label
        Me.txtbs = New System.Windows.Forms.TextBox
        Me.txtbp = New System.Windows.Forms.TextBox
        Me.txtsugar = New System.Windows.Forms.TextBox
        Me.txtspecific = New System.Windows.Forms.TextBox
        Me.txtvol = New System.Windows.Forms.TextBox
        Me.lblcast = New System.Windows.Forms.Label
        Me.lblbs = New System.Windows.Forms.Label
        Me.lblbp = New System.Windows.Forms.Label
        Me.lblsugar = New System.Windows.Forms.Label
        Me.lblspecific = New System.Windows.Forms.Label
        Me.lblapp = New System.Windows.Forms.Label
        Me.lblvol = New System.Windows.Forms.Label
        Me.lblurine_test = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdML = New System.Windows.Forms.Button
        Me.cmdMN = New System.Windows.Forms.Button
        Me.cmdMP = New System.Windows.Forms.Button
        Me.cmdMF = New System.Windows.Forms.Button
        Me.URINEGrid = New System.Windows.Forms.DataGridView
        Me.cmbpid = New System.Windows.Forms.ComboBox
        Me.lblutestid = New System.Windows.Forms.Label
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
        CType(Me.URINEGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtp_name
        '
        Me.txtp_name.Location = New System.Drawing.Point(238, 271)
        Me.txtp_name.Name = "txtp_name"
        Me.txtp_name.Size = New System.Drawing.Size(100, 20)
        Me.txtp_name.TabIndex = 2
        '
        'lblp_name
        '
        Me.lblp_name.AutoSize = True
        Me.lblp_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_name.Location = New System.Drawing.Point(31, 271)
        Me.lblp_name.Name = "lblp_name"
        Me.lblp_name.Size = New System.Drawing.Size(99, 13)
        Me.lblp_name.TabIndex = 21
        Me.lblp_name.Text = "PATIENT NAME"
        '
        'lblp_id
        '
        Me.lblp_id.AutoSize = True
        Me.lblp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_id.Location = New System.Drawing.Point(31, 197)
        Me.lblp_id.Name = "lblp_id"
        Me.lblp_id.Size = New System.Drawing.Size(77, 13)
        Me.lblp_id.TabIndex = 20
        Me.lblp_id.Text = "PATIENT ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtucolor)
        Me.GroupBox1.Controls.Add(Me.txtcast)
        Me.GroupBox1.Controls.Add(Me.txtapp)
        Me.GroupBox1.Controls.Add(Me.lblacetone)
        Me.GroupBox1.Controls.Add(Me.lblalbumin)
        Me.GroupBox1.Controls.Add(Me.lblocc)
        Me.GroupBox1.Controls.Add(Me.txtacet)
        Me.GroupBox1.Controls.Add(Me.txtualbumin)
        Me.GroupBox1.Controls.Add(Me.txtocc_blood)
        Me.GroupBox1.Controls.Add(Me.lblcolour)
        Me.GroupBox1.Controls.Add(Me.txtbs)
        Me.GroupBox1.Controls.Add(Me.txtbp)
        Me.GroupBox1.Controls.Add(Me.txtsugar)
        Me.GroupBox1.Controls.Add(Me.txtspecific)
        Me.GroupBox1.Controls.Add(Me.txtvol)
        Me.GroupBox1.Controls.Add(Me.lblcast)
        Me.GroupBox1.Controls.Add(Me.lblbs)
        Me.GroupBox1.Controls.Add(Me.lblbp)
        Me.GroupBox1.Controls.Add(Me.lblsugar)
        Me.GroupBox1.Controls.Add(Me.lblspecific)
        Me.GroupBox1.Controls.Add(Me.lblapp)
        Me.GroupBox1.Controls.Add(Me.lblvol)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 297)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 392)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'txtucolor
        '
        Me.txtucolor.FormattingEnabled = True
        Me.txtucolor.Items.AddRange(New Object() {"YELLOW", "PALE YELLOW", "NEUTRAL"})
        Me.txtucolor.Location = New System.Drawing.Point(226, 256)
        Me.txtucolor.Name = "txtucolor"
        Me.txtucolor.Size = New System.Drawing.Size(101, 21)
        Me.txtucolor.TabIndex = 10
        '
        'txtcast
        '
        Me.txtcast.FormattingEnabled = True
        Me.txtcast.Items.AddRange(New Object() {"NORMAL", "LOOSE", "HARD", "CRYSTAL"})
        Me.txtcast.Location = New System.Drawing.Point(225, 223)
        Me.txtcast.Name = "txtcast"
        Me.txtcast.Size = New System.Drawing.Size(99, 21)
        Me.txtcast.TabIndex = 9
        '
        'txtapp
        '
        Me.txtapp.FormattingEnabled = True
        Me.txtapp.Items.AddRange(New Object() {"YELLOW", "PALE YELLOW", "NEUTRAL"})
        Me.txtapp.Location = New System.Drawing.Point(224, 59)
        Me.txtapp.Name = "txtapp"
        Me.txtapp.Size = New System.Drawing.Size(101, 21)
        Me.txtapp.TabIndex = 4
        '
        'lblacetone
        '
        Me.lblacetone.AutoSize = True
        Me.lblacetone.Location = New System.Drawing.Point(19, 366)
        Me.lblacetone.Name = "lblacetone"
        Me.lblacetone.Size = New System.Drawing.Size(65, 13)
        Me.lblacetone.TabIndex = 21
        Me.lblacetone.Text = "ACETONE"
        '
        'lblalbumin
        '
        Me.lblalbumin.AutoSize = True
        Me.lblalbumin.Location = New System.Drawing.Point(19, 332)
        Me.lblalbumin.Name = "lblalbumin"
        Me.lblalbumin.Size = New System.Drawing.Size(62, 13)
        Me.lblalbumin.TabIndex = 20
        Me.lblalbumin.Text = "ALBUMIN"
        '
        'lblocc
        '
        Me.lblocc.AutoSize = True
        Me.lblocc.Location = New System.Drawing.Point(19, 298)
        Me.lblocc.Name = "lblocc"
        Me.lblocc.Size = New System.Drawing.Size(102, 13)
        Me.lblocc.TabIndex = 19
        Me.lblocc.Text = "OCCULT BLOOD"
        '
        'txtacet
        '
        Me.txtacet.Location = New System.Drawing.Point(226, 363)
        Me.txtacet.MaxLength = 3
        Me.txtacet.Name = "txtacet"
        Me.txtacet.Size = New System.Drawing.Size(100, 20)
        Me.txtacet.TabIndex = 13
        '
        'txtualbumin
        '
        Me.txtualbumin.Location = New System.Drawing.Point(226, 329)
        Me.txtualbumin.MaxLength = 3
        Me.txtualbumin.Name = "txtualbumin"
        Me.txtualbumin.Size = New System.Drawing.Size(100, 20)
        Me.txtualbumin.TabIndex = 12
        '
        'txtocc_blood
        '
        Me.txtocc_blood.Location = New System.Drawing.Point(226, 295)
        Me.txtocc_blood.MaxLength = 3
        Me.txtocc_blood.Name = "txtocc_blood"
        Me.txtocc_blood.Size = New System.Drawing.Size(100, 20)
        Me.txtocc_blood.TabIndex = 11
        '
        'lblcolour
        '
        Me.lblcolour.AutoSize = True
        Me.lblcolour.Location = New System.Drawing.Point(19, 264)
        Me.lblcolour.Name = "lblcolour"
        Me.lblcolour.Size = New System.Drawing.Size(58, 13)
        Me.lblcolour.TabIndex = 14
        Me.lblcolour.Text = "COLOUR"
        '
        'txtbs
        '
        Me.txtbs.Location = New System.Drawing.Point(226, 193)
        Me.txtbs.MaxLength = 3
        Me.txtbs.Name = "txtbs"
        Me.txtbs.Size = New System.Drawing.Size(100, 20)
        Me.txtbs.TabIndex = 8
        '
        'txtbp
        '
        Me.txtbp.Location = New System.Drawing.Point(226, 159)
        Me.txtbp.MaxLength = 3
        Me.txtbp.Name = "txtbp"
        Me.txtbp.Size = New System.Drawing.Size(100, 20)
        Me.txtbp.TabIndex = 7
        '
        'txtsugar
        '
        Me.txtsugar.Location = New System.Drawing.Point(226, 125)
        Me.txtsugar.MaxLength = 3
        Me.txtsugar.Name = "txtsugar"
        Me.txtsugar.Size = New System.Drawing.Size(100, 20)
        Me.txtsugar.TabIndex = 6
        '
        'txtspecific
        '
        Me.txtspecific.Location = New System.Drawing.Point(226, 91)
        Me.txtspecific.MaxLength = 3
        Me.txtspecific.Name = "txtspecific"
        Me.txtspecific.Size = New System.Drawing.Size(100, 20)
        Me.txtspecific.TabIndex = 5
        '
        'txtvol
        '
        Me.txtvol.Location = New System.Drawing.Point(226, 23)
        Me.txtvol.MaxLength = 2
        Me.txtvol.Name = "txtvol"
        Me.txtvol.Size = New System.Drawing.Size(100, 20)
        Me.txtvol.TabIndex = 3
        '
        'lblcast
        '
        Me.lblcast.AutoSize = True
        Me.lblcast.Location = New System.Drawing.Point(19, 231)
        Me.lblcast.Name = "lblcast"
        Me.lblcast.Size = New System.Drawing.Size(39, 13)
        Me.lblcast.TabIndex = 6
        Me.lblcast.Text = "CAST"
        '
        'lblbs
        '
        Me.lblbs.AutoSize = True
        Me.lblbs.Location = New System.Drawing.Point(19, 197)
        Me.lblbs.Name = "lblbs"
        Me.lblbs.Size = New System.Drawing.Size(77, 13)
        Me.lblbs.TabIndex = 5
        Me.lblbs.Text = "BILE SALTS"
        '
        'lblbp
        '
        Me.lblbp.AutoSize = True
        Me.lblbp.Location = New System.Drawing.Point(19, 159)
        Me.lblbp.Name = "lblbp"
        Me.lblbp.Size = New System.Drawing.Size(102, 13)
        Me.lblbp.TabIndex = 4
        Me.lblbp.Text = "BILE PIGMENTS"
        '
        'lblsugar
        '
        Me.lblsugar.AutoSize = True
        Me.lblsugar.Location = New System.Drawing.Point(19, 129)
        Me.lblsugar.Name = "lblsugar"
        Me.lblsugar.Size = New System.Drawing.Size(50, 13)
        Me.lblsugar.TabIndex = 3
        Me.lblsugar.Text = "SUGAR"
        '
        'lblspecific
        '
        Me.lblspecific.AutoSize = True
        Me.lblspecific.Location = New System.Drawing.Point(19, 94)
        Me.lblspecific.Name = "lblspecific"
        Me.lblspecific.Size = New System.Drawing.Size(120, 13)
        Me.lblspecific.TabIndex = 2
        Me.lblspecific.Text = "SPECIFIC GRAVITY"
        '
        'lblapp
        '
        Me.lblapp.AutoSize = True
        Me.lblapp.Location = New System.Drawing.Point(19, 61)
        Me.lblapp.Name = "lblapp"
        Me.lblapp.Size = New System.Drawing.Size(89, 13)
        Me.lblapp.TabIndex = 1
        Me.lblapp.Text = "APPERANACE"
        '
        'lblvol
        '
        Me.lblvol.AutoSize = True
        Me.lblvol.Location = New System.Drawing.Point(19, 27)
        Me.lblvol.Name = "lblvol"
        Me.lblvol.Size = New System.Drawing.Size(121, 13)
        Me.lblvol.TabIndex = 0
        Me.lblvol.Text = "VOLUME OF URINE"
        '
        'lblurine_test
        '
        Me.lblurine_test.AutoSize = True
        Me.lblurine_test.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblurine_test.Location = New System.Drawing.Point(394, 145)
        Me.lblurine_test.Name = "lblurine_test"
        Me.lblurine_test.Size = New System.Drawing.Size(187, 33)
        Me.lblurine_test.TabIndex = 34
        Me.lblurine_test.Text = "URINE TEST"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdML)
        Me.GroupBox3.Controls.Add(Me.cmdMN)
        Me.GroupBox3.Controls.Add(Me.cmdMP)
        Me.GroupBox3.Controls.Add(Me.cmdMF)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(411, 547)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 61)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        '
        'cmdML
        '
        Me.cmdML.BackColor = System.Drawing.Color.Silver
        Me.cmdML.Location = New System.Drawing.Point(339, 19)
        Me.cmdML.Name = "cmdML"
        Me.cmdML.Size = New System.Drawing.Size(75, 23)
        Me.cmdML.TabIndex = 17
        Me.cmdML.Text = ">|"
        Me.cmdML.UseVisualStyleBackColor = False
        '
        'cmdMN
        '
        Me.cmdMN.BackColor = System.Drawing.Color.Silver
        Me.cmdMN.Location = New System.Drawing.Point(239, 19)
        Me.cmdMN.Name = "cmdMN"
        Me.cmdMN.Size = New System.Drawing.Size(75, 23)
        Me.cmdMN.TabIndex = 16
        Me.cmdMN.Text = ">"
        Me.cmdMN.UseVisualStyleBackColor = False
        '
        'cmdMP
        '
        Me.cmdMP.BackColor = System.Drawing.Color.Silver
        Me.cmdMP.Location = New System.Drawing.Point(141, 19)
        Me.cmdMP.Name = "cmdMP"
        Me.cmdMP.Size = New System.Drawing.Size(75, 23)
        Me.cmdMP.TabIndex = 15
        Me.cmdMP.Text = "<"
        Me.cmdMP.UseVisualStyleBackColor = False
        '
        'cmdMF
        '
        Me.cmdMF.BackColor = System.Drawing.Color.Silver
        Me.cmdMF.Location = New System.Drawing.Point(28, 19)
        Me.cmdMF.Name = "cmdMF"
        Me.cmdMF.Size = New System.Drawing.Size(75, 23)
        Me.cmdMF.TabIndex = 14
        Me.cmdMF.Text = "|<"
        Me.cmdMF.UseVisualStyleBackColor = False
        '
        'URINEGrid
        '
        Me.URINEGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.URINEGrid.Location = New System.Drawing.Point(411, 297)
        Me.URINEGrid.Name = "URINEGrid"
        Me.URINEGrid.Size = New System.Drawing.Size(906, 237)
        Me.URINEGrid.TabIndex = 39
        '
        'cmbpid
        '
        Me.cmbpid.FormattingEnabled = True
        Me.cmbpid.Location = New System.Drawing.Point(238, 189)
        Me.cmbpid.Name = "cmbpid"
        Me.cmbpid.Size = New System.Drawing.Size(121, 21)
        Me.cmbpid.TabIndex = 1
        '
        'lblutestid
        '
        Me.lblutestid.AutoSize = True
        Me.lblutestid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblutestid.Location = New System.Drawing.Point(31, 236)
        Me.lblutestid.Name = "lblutestid"
        Me.lblutestid.Size = New System.Drawing.Size(56, 13)
        Me.lblutestid.TabIndex = 42
        Me.lblutestid.Text = "TEST ID"
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
        Me.GroupBox2.Location = New System.Drawing.Point(411, 626)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 58)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'cmdback
        '
        Me.cmdback.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(454, 19)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(75, 23)
        Me.cmdback.TabIndex = 23
        Me.cmdback.Text = "BACK"
        Me.cmdback.UseVisualStyleBackColor = True
        '
        'cmbclear
        '
        Me.cmbclear.BackColor = System.Drawing.Color.LightGray
        Me.cmbclear.Location = New System.Drawing.Point(285, 20)
        Me.cmbclear.Name = "cmbclear"
        Me.cmbclear.Size = New System.Drawing.Size(75, 23)
        Me.cmbclear.TabIndex = 21
        Me.cmbclear.Text = "CLEAR"
        Me.cmbclear.UseVisualStyleBackColor = False
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.LightGray
        Me.cmddelete.Location = New System.Drawing.Point(375, 19)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 23)
        Me.cmddelete.TabIndex = 22
        Me.cmddelete.Text = "DELETE"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.Location = New System.Drawing.Point(535, 20)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(75, 23)
        Me.cmdexit.TabIndex = 24
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = True
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.LightGray
        Me.cmdadd.Location = New System.Drawing.Point(6, 19)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(75, 23)
        Me.cmdadd.TabIndex = 18
        Me.cmdadd.Text = "ADD"
        Me.cmdadd.UseVisualStyleBackColor = False
        '
        'cmdmodify
        '
        Me.cmdmodify.BackColor = System.Drawing.Color.LightGray
        Me.cmdmodify.Location = New System.Drawing.Point(97, 19)
        Me.cmdmodify.Name = "cmdmodify"
        Me.cmdmodify.Size = New System.Drawing.Size(75, 23)
        Me.cmdmodify.TabIndex = 19
        Me.cmdmodify.Text = "MODIFY"
        Me.cmdmodify.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.LightGray
        Me.cmdsave.Location = New System.Drawing.Point(190, 19)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 23)
        Me.cmdsave.TabIndex = 20
        Me.cmdsave.Text = "SAVE"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmbtest_id
        '
        Me.cmbtest_id.Location = New System.Drawing.Point(238, 229)
        Me.cmbtest_id.Name = "cmbtest_id"
        Me.cmbtest_id.Size = New System.Drawing.Size(100, 20)
        Me.cmbtest_id.TabIndex = 45
        Me.cmbtest_id.TabStop = False
        Me.cmbtest_id.Text = "8"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(428, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 124)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Urine_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1028, 707)
        Me.Controls.Add(Me.cmbtest_id)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblutestid)
        Me.Controls.Add(Me.cmbpid)
        Me.Controls.Add(Me.URINEGrid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblurine_test)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtp_name)
        Me.Controls.Add(Me.lblp_name)
        Me.Controls.Add(Me.lblp_id)
        Me.Name = "Urine_Test"
        Me.Text = "URINE_TEST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.URINEGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtp_name As System.Windows.Forms.TextBox
    Friend WithEvents lblp_name As System.Windows.Forms.Label
    Friend WithEvents lblp_id As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblacetone As System.Windows.Forms.Label
    Friend WithEvents lblalbumin As System.Windows.Forms.Label
    Friend WithEvents lblocc As System.Windows.Forms.Label
    Friend WithEvents txtacet As System.Windows.Forms.TextBox
    Friend WithEvents txtualbumin As System.Windows.Forms.TextBox
    Friend WithEvents txtocc_blood As System.Windows.Forms.TextBox
    Friend WithEvents lblcolour As System.Windows.Forms.Label
    Friend WithEvents txtbs As System.Windows.Forms.TextBox
    Friend WithEvents txtbp As System.Windows.Forms.TextBox
    Friend WithEvents txtsugar As System.Windows.Forms.TextBox
    Friend WithEvents txtspecific As System.Windows.Forms.TextBox
    Friend WithEvents txtvol As System.Windows.Forms.TextBox
    Friend WithEvents lblcast As System.Windows.Forms.Label
    Friend WithEvents lblbs As System.Windows.Forms.Label
    Friend WithEvents lblbp As System.Windows.Forms.Label
    Friend WithEvents lblsugar As System.Windows.Forms.Label
    Friend WithEvents lblspecific As System.Windows.Forms.Label
    Friend WithEvents lblapp As System.Windows.Forms.Label
    Friend WithEvents lblvol As System.Windows.Forms.Label
    Friend WithEvents lblurine_test As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdML As System.Windows.Forms.Button
    Friend WithEvents cmdMN As System.Windows.Forms.Button
    Friend WithEvents cmdMP As System.Windows.Forms.Button
    Friend WithEvents cmdMF As System.Windows.Forms.Button
    Friend WithEvents URINEGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbpid As System.Windows.Forms.ComboBox
    Friend WithEvents lblutestid As System.Windows.Forms.Label
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
    Friend WithEvents txtucolor As System.Windows.Forms.ComboBox
    Friend WithEvents txtcast As System.Windows.Forms.ComboBox
    Friend WithEvents txtapp As System.Windows.Forms.ComboBox
End Class
