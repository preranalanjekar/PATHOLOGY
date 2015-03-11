<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Protien_Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Protien_Test))
        Me.txtp_name = New System.Windows.Forms.TextBox
        Me.lblp_name = New System.Windows.Forms.Label
        Me.lblp_id = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txttotal_protien = New System.Windows.Forms.TextBox
        Me.txtalbumin = New System.Windows.Forms.TextBox
        Me.txtglobulin = New System.Windows.Forms.TextBox
        Me.txtsprotein = New System.Windows.Forms.TextBox
        Me.lbltotal_protien = New System.Windows.Forms.Label
        Me.lblalbumin = New System.Windows.Forms.Label
        Me.lblglobulin = New System.Windows.Forms.Label
        Me.lblsprotien = New System.Windows.Forms.Label
        Me.lblprotien_test = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdML = New System.Windows.Forms.Button
        Me.cmdMN = New System.Windows.Forms.Button
        Me.cmdMP = New System.Windows.Forms.Button
        Me.cmdMF = New System.Windows.Forms.Button
        Me.PROTIENGrid = New System.Windows.Forms.DataGridView
        Me.cmbpid = New System.Windows.Forms.ComboBox
        Me.lbl_prtestid = New System.Windows.Forms.Label
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
        CType(Me.PROTIENGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtp_name
        '
        Me.txtp_name.Location = New System.Drawing.Point(133, 294)
        Me.txtp_name.Name = "txtp_name"
        Me.txtp_name.Size = New System.Drawing.Size(100, 20)
        Me.txtp_name.TabIndex = 2
        '
        'lblp_name
        '
        Me.lblp_name.AutoSize = True
        Me.lblp_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_name.Location = New System.Drawing.Point(26, 294)
        Me.lblp_name.Name = "lblp_name"
        Me.lblp_name.Size = New System.Drawing.Size(99, 13)
        Me.lblp_name.TabIndex = 25
        Me.lblp_name.Text = "PATIENT NAME"
        '
        'lblp_id
        '
        Me.lblp_id.AutoSize = True
        Me.lblp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_id.Location = New System.Drawing.Point(26, 222)
        Me.lblp_id.Name = "lblp_id"
        Me.lblp_id.Size = New System.Drawing.Size(77, 13)
        Me.lblp_id.TabIndex = 24
        Me.lblp_id.Text = "PATIENT ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttotal_protien)
        Me.GroupBox1.Controls.Add(Me.txtalbumin)
        Me.GroupBox1.Controls.Add(Me.txtglobulin)
        Me.GroupBox1.Controls.Add(Me.txtsprotein)
        Me.GroupBox1.Controls.Add(Me.lbltotal_protien)
        Me.GroupBox1.Controls.Add(Me.lblalbumin)
        Me.GroupBox1.Controls.Add(Me.lblglobulin)
        Me.GroupBox1.Controls.Add(Me.lblsprotien)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 317)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 238)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'txttotal_protien
        '
        Me.txttotal_protien.Location = New System.Drawing.Point(121, 185)
        Me.txttotal_protien.Name = "txttotal_protien"
        Me.txttotal_protien.Size = New System.Drawing.Size(100, 20)
        Me.txttotal_protien.TabIndex = 6
        '
        'txtalbumin
        '
        Me.txtalbumin.Location = New System.Drawing.Point(121, 143)
        Me.txtalbumin.MaxLength = 3
        Me.txtalbumin.Name = "txtalbumin"
        Me.txtalbumin.Size = New System.Drawing.Size(100, 20)
        Me.txtalbumin.TabIndex = 5
        '
        'txtglobulin
        '
        Me.txtglobulin.Location = New System.Drawing.Point(121, 92)
        Me.txtglobulin.MaxLength = 3
        Me.txtglobulin.Name = "txtglobulin"
        Me.txtglobulin.Size = New System.Drawing.Size(100, 20)
        Me.txtglobulin.TabIndex = 4
        '
        'txtsprotein
        '
        Me.txtsprotein.Location = New System.Drawing.Point(121, 42)
        Me.txtsprotein.MaxLength = 3
        Me.txtsprotein.Name = "txtsprotein"
        Me.txtsprotein.Size = New System.Drawing.Size(100, 20)
        Me.txtsprotein.TabIndex = 3
        '
        'lbltotal_protien
        '
        Me.lbltotal_protien.AutoSize = True
        Me.lbltotal_protien.Location = New System.Drawing.Point(14, 188)
        Me.lbltotal_protien.Name = "lbltotal_protien"
        Me.lbltotal_protien.Size = New System.Drawing.Size(106, 13)
        Me.lbltotal_protien.TabIndex = 3
        Me.lbltotal_protien.Text = "TOTAL PROTIEN"
        '
        'lblalbumin
        '
        Me.lblalbumin.AutoSize = True
        Me.lblalbumin.Location = New System.Drawing.Point(14, 143)
        Me.lblalbumin.Name = "lblalbumin"
        Me.lblalbumin.Size = New System.Drawing.Size(62, 13)
        Me.lblalbumin.TabIndex = 2
        Me.lblalbumin.Text = "ALBUMIN"
        '
        'lblglobulin
        '
        Me.lblglobulin.AutoSize = True
        Me.lblglobulin.Location = New System.Drawing.Point(14, 95)
        Me.lblglobulin.Name = "lblglobulin"
        Me.lblglobulin.Size = New System.Drawing.Size(69, 13)
        Me.lblglobulin.TabIndex = 1
        Me.lblglobulin.Text = "GLOBULIN"
        '
        'lblsprotien
        '
        Me.lblsprotien.AutoSize = True
        Me.lblsprotien.Location = New System.Drawing.Point(14, 45)
        Me.lblsprotien.Name = "lblsprotien"
        Me.lblsprotien.Size = New System.Drawing.Size(74, 13)
        Me.lblsprotien.TabIndex = 0
        Me.lblsprotien.Text = "S.PROTIEN"
        '
        'lblprotien_test
        '
        Me.lblprotien_test.AutoSize = True
        Me.lblprotien_test.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprotien_test.Location = New System.Drawing.Point(376, 150)
        Me.lblprotien_test.Name = "lblprotien_test"
        Me.lblprotien_test.Size = New System.Drawing.Size(226, 33)
        Me.lblprotien_test.TabIndex = 34
        Me.lblprotien_test.Text = "PROTIEN TEST"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdML)
        Me.GroupBox3.Controls.Add(Me.cmdMN)
        Me.GroupBox3.Controls.Add(Me.cmdMP)
        Me.GroupBox3.Controls.Add(Me.cmdMF)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(351, 482)
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
        'PROTIENGrid
        '
        Me.PROTIENGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PROTIENGrid.Location = New System.Drawing.Point(351, 222)
        Me.PROTIENGrid.Name = "PROTIENGrid"
        Me.PROTIENGrid.Size = New System.Drawing.Size(629, 230)
        Me.PROTIENGrid.TabIndex = 38
        '
        'cmbpid
        '
        Me.cmbpid.FormattingEnabled = True
        Me.cmbpid.Location = New System.Drawing.Point(133, 214)
        Me.cmbpid.Name = "cmbpid"
        Me.cmbpid.Size = New System.Drawing.Size(100, 21)
        Me.cmbpid.TabIndex = 1
        '
        'lbl_prtestid
        '
        Me.lbl_prtestid.AutoSize = True
        Me.lbl_prtestid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prtestid.Location = New System.Drawing.Point(26, 258)
        Me.lbl_prtestid.Name = "lbl_prtestid"
        Me.lbl_prtestid.Size = New System.Drawing.Size(56, 13)
        Me.lbl_prtestid.TabIndex = 41
        Me.lbl_prtestid.Text = "TEST ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(422, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 135)
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
        Me.GroupBox2.Location = New System.Drawing.Point(133, 575)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(639, 58)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'cmdback
        '
        Me.cmdback.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(465, 20)
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
        Me.cmddelete.Location = New System.Drawing.Point(375, 19)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 23)
        Me.cmddelete.TabIndex = 4
        Me.cmddelete.Text = "DELETE"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.LightGray
        Me.cmdexit.Location = New System.Drawing.Point(546, 19)
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
        Me.cmbtest_id.Location = New System.Drawing.Point(133, 255)
        Me.cmbtest_id.Name = "cmbtest_id"
        Me.cmbtest_id.Size = New System.Drawing.Size(100, 20)
        Me.cmbtest_id.TabIndex = 60
        Me.cmbtest_id.TabStop = False
        Me.cmbtest_id.Text = "9"
        '
        'Protien_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(992, 712)
        Me.Controls.Add(Me.cmbtest_id)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_prtestid)
        Me.Controls.Add(Me.cmbpid)
        Me.Controls.Add(Me.PROTIENGrid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblprotien_test)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtp_name)
        Me.Controls.Add(Me.lblp_name)
        Me.Controls.Add(Me.lblp_id)
        Me.Name = "Protien_Test"
        Me.Text = "PROTIEN_TEST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PROTIENGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtp_name As System.Windows.Forms.TextBox
    Friend WithEvents lblp_name As System.Windows.Forms.Label
    Friend WithEvents lblp_id As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txttotal_protien As System.Windows.Forms.TextBox
    Friend WithEvents txtalbumin As System.Windows.Forms.TextBox
    Friend WithEvents txtglobulin As System.Windows.Forms.TextBox
    Friend WithEvents txtsprotein As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal_protien As System.Windows.Forms.Label
    Friend WithEvents lblalbumin As System.Windows.Forms.Label
    Friend WithEvents lblglobulin As System.Windows.Forms.Label
    Friend WithEvents lblsprotien As System.Windows.Forms.Label
    Friend WithEvents lblprotien_test As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdML As System.Windows.Forms.Button
    Friend WithEvents cmdMN As System.Windows.Forms.Button
    Friend WithEvents cmdMP As System.Windows.Forms.Button
    Friend WithEvents cmdMF As System.Windows.Forms.Button
    Friend WithEvents PROTIENGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbpid As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_prtestid As System.Windows.Forms.Label
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
