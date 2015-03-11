<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test_Record
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Test_Record))
        Me.cmddelete = New System.Windows.Forms.Button
        Me.TESTGrid = New System.Windows.Forms.DataGridView
        Me.lblpatient_record = New System.Windows.Forms.Label
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdmodify = New System.Windows.Forms.Button
        Me.cmdadd = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txttestid = New System.Windows.Forms.TextBox
        Me.lbltestid = New System.Windows.Forms.Label
        Me.lbltestname = New System.Windows.Forms.Label
        Me.lbltestdesc = New System.Windows.Forms.Label
        Me.lblcost = New System.Windows.Forms.Label
        Me.txtcost = New System.Windows.Forms.TextBox
        Me.txttestdesc = New System.Windows.Forms.TextBox
        Me.txttestname = New System.Windows.Forms.TextBox
        Me.lblp_age = New System.Windows.Forms.Label
        Me.lblp_gender = New System.Windows.Forms.Label
        Me.lblp_phone = New System.Windows.Forms.Label
        Me.lblp_address = New System.Windows.Forms.Label
        Me.lblp_name = New System.Windows.Forms.Label
        Me.lblp_id = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdML = New System.Windows.Forms.Button
        Me.cmdMN = New System.Windows.Forms.Button
        Me.cmdMP = New System.Windows.Forms.Button
        Me.cmdMF = New System.Windows.Forms.Button
        Me.cmdclear = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdback = New System.Windows.Forms.Button
        Me.lbltest = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.TESTGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.Silver
        Me.cmddelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.Location = New System.Drawing.Point(320, 19)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 23)
        Me.cmddelete.TabIndex = 51
        Me.cmddelete.Text = "DELETE"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'TESTGrid
        '
        Me.TESTGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TESTGrid.Location = New System.Drawing.Point(419, 248)
        Me.TESTGrid.Name = "TESTGrid"
        Me.TESTGrid.Size = New System.Drawing.Size(524, 236)
        Me.TESTGrid.TabIndex = 50
        '
        'lblpatient_record
        '
        Me.lblpatient_record.AutoSize = True
        Me.lblpatient_record.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpatient_record.Location = New System.Drawing.Point(71, -43)
        Me.lblpatient_record.Name = "lblpatient_record"
        Me.lblpatient_record.Size = New System.Drawing.Size(149, 20)
        Me.lblpatient_record.TabIndex = 49
        Me.lblpatient_record.Text = "PATIENT RECORD"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.Silver
        Me.cmdexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.Location = New System.Drawing.Point(496, 19)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(75, 23)
        Me.cmdexit.TabIndex = 48
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.Silver
        Me.cmdsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(129, 19)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 23)
        Me.cmdsave.TabIndex = 47
        Me.cmdsave.Text = "SAVE"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmdmodify
        '
        Me.cmdmodify.BackColor = System.Drawing.Color.Silver
        Me.cmdmodify.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmodify.Location = New System.Drawing.Point(33, 19)
        Me.cmdmodify.Name = "cmdmodify"
        Me.cmdmodify.Size = New System.Drawing.Size(75, 23)
        Me.cmdmodify.TabIndex = 46
        Me.cmdmodify.Text = "MODIFY"
        Me.cmdmodify.UseVisualStyleBackColor = False
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(-98, 339)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(75, 23)
        Me.cmdadd.TabIndex = 45
        Me.cmdadd.Text = "ADD"
        Me.cmdadd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.txttestid)
        Me.GroupBox1.Controls.Add(Me.lbltestid)
        Me.GroupBox1.Controls.Add(Me.lbltestname)
        Me.GroupBox1.Controls.Add(Me.lbltestdesc)
        Me.GroupBox1.Controls.Add(Me.lblcost)
        Me.GroupBox1.Controls.Add(Me.txtcost)
        Me.GroupBox1.Controls.Add(Me.txttestdesc)
        Me.GroupBox1.Controls.Add(Me.txttestname)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 274)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 225)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'txttestid
        '
        Me.txttestid.Location = New System.Drawing.Point(214, 38)
        Me.txttestid.Name = "txttestid"
        Me.txttestid.Size = New System.Drawing.Size(100, 20)
        Me.txttestid.TabIndex = 1
        '
        'lbltestid
        '
        Me.lbltestid.AutoSize = True
        Me.lbltestid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltestid.Location = New System.Drawing.Point(36, 45)
        Me.lbltestid.Name = "lbltestid"
        Me.lbltestid.Size = New System.Drawing.Size(56, 13)
        Me.lbltestid.TabIndex = 53
        Me.lbltestid.Text = "TEST ID"
        '
        'lbltestname
        '
        Me.lbltestname.AutoSize = True
        Me.lbltestname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltestname.Location = New System.Drawing.Point(36, 89)
        Me.lbltestname.Name = "lbltestname"
        Me.lbltestname.Size = New System.Drawing.Size(78, 13)
        Me.lbltestname.TabIndex = 54
        Me.lbltestname.Text = "TEST NAME"
        '
        'lbltestdesc
        '
        Me.lbltestdesc.AutoSize = True
        Me.lbltestdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltestdesc.Location = New System.Drawing.Point(36, 139)
        Me.lbltestdesc.Name = "lbltestdesc"
        Me.lbltestdesc.Size = New System.Drawing.Size(127, 13)
        Me.lbltestdesc.TabIndex = 55
        Me.lbltestdesc.Text = "TEST DESCRIPTION"
        '
        'lblcost
        '
        Me.lblcost.AutoSize = True
        Me.lblcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcost.Location = New System.Drawing.Point(36, 189)
        Me.lblcost.Name = "lblcost"
        Me.lblcost.Size = New System.Drawing.Size(76, 13)
        Me.lblcost.TabIndex = 56
        Me.lblcost.Text = "TEST COST"
        '
        'txtcost
        '
        Me.txtcost.Location = New System.Drawing.Point(214, 182)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(100, 20)
        Me.txtcost.TabIndex = 4
        '
        'txttestdesc
        '
        Me.txttestdesc.Location = New System.Drawing.Point(214, 132)
        Me.txttestdesc.Name = "txttestdesc"
        Me.txttestdesc.Size = New System.Drawing.Size(100, 20)
        Me.txttestdesc.TabIndex = 3
        '
        'txttestname
        '
        Me.txttestname.Location = New System.Drawing.Point(214, 82)
        Me.txttestname.Name = "txttestname"
        Me.txttestname.Size = New System.Drawing.Size(100, 20)
        Me.txttestname.TabIndex = 2
        '
        'lblp_age
        '
        Me.lblp_age.AutoSize = True
        Me.lblp_age.Location = New System.Drawing.Point(-145, 219)
        Me.lblp_age.Name = "lblp_age"
        Me.lblp_age.Size = New System.Drawing.Size(90, 13)
        Me.lblp_age.TabIndex = 42
        Me.lblp_age.Text = "Enter Patient Age"
        '
        'lblp_gender
        '
        Me.lblp_gender.AutoSize = True
        Me.lblp_gender.Location = New System.Drawing.Point(-145, 176)
        Me.lblp_gender.Name = "lblp_gender"
        Me.lblp_gender.Size = New System.Drawing.Size(106, 13)
        Me.lblp_gender.TabIndex = 41
        Me.lblp_gender.Text = "Enter Patient Gender"
        '
        'lblp_phone
        '
        Me.lblp_phone.AutoSize = True
        Me.lblp_phone.Location = New System.Drawing.Point(-144, 135)
        Me.lblp_phone.Name = "lblp_phone"
        Me.lblp_phone.Size = New System.Drawing.Size(122, 13)
        Me.lblp_phone.TabIndex = 40
        Me.lblp_phone.Text = "Enter Patient Phone_No"
        '
        'lblp_address
        '
        Me.lblp_address.AutoSize = True
        Me.lblp_address.Location = New System.Drawing.Point(-144, 89)
        Me.lblp_address.Name = "lblp_address"
        Me.lblp_address.Size = New System.Drawing.Size(109, 13)
        Me.lblp_address.TabIndex = 39
        Me.lblp_address.Text = "Enter Patient Address"
        '
        'lblp_name
        '
        Me.lblp_name.AutoSize = True
        Me.lblp_name.Location = New System.Drawing.Point(-144, 43)
        Me.lblp_name.Name = "lblp_name"
        Me.lblp_name.Size = New System.Drawing.Size(99, 13)
        Me.lblp_name.TabIndex = 38
        Me.lblp_name.Text = "Enter Patient Name"
        '
        'lblp_id
        '
        Me.lblp_id.AutoSize = True
        Me.lblp_id.Location = New System.Drawing.Point(-144, 9)
        Me.lblp_id.Name = "lblp_id"
        Me.lblp_id.Size = New System.Drawing.Size(82, 13)
        Me.lblp_id.TabIndex = 37
        Me.lblp_id.Text = "Enter Patient ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdML)
        Me.GroupBox2.Controls.Add(Me.cmdMN)
        Me.GroupBox2.Controls.Add(Me.cmdMP)
        Me.GroupBox2.Controls.Add(Me.cmdMF)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 529)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 54)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        '
        'cmdML
        '
        Me.cmdML.BackColor = System.Drawing.Color.LightGray
        Me.cmdML.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdML.Location = New System.Drawing.Point(339, 19)
        Me.cmdML.Name = "cmdML"
        Me.cmdML.Size = New System.Drawing.Size(75, 23)
        Me.cmdML.TabIndex = 3
        Me.cmdML.Text = ">|"
        Me.cmdML.UseVisualStyleBackColor = False
        '
        'cmdMN
        '
        Me.cmdMN.BackColor = System.Drawing.Color.LightGray
        Me.cmdMN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMN.Location = New System.Drawing.Point(239, 19)
        Me.cmdMN.Name = "cmdMN"
        Me.cmdMN.Size = New System.Drawing.Size(75, 23)
        Me.cmdMN.TabIndex = 2
        Me.cmdMN.Text = ">"
        Me.cmdMN.UseVisualStyleBackColor = False
        '
        'cmdMP
        '
        Me.cmdMP.BackColor = System.Drawing.Color.LightGray
        Me.cmdMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMP.Location = New System.Drawing.Point(141, 19)
        Me.cmdMP.Name = "cmdMP"
        Me.cmdMP.Size = New System.Drawing.Size(75, 23)
        Me.cmdMP.TabIndex = 1
        Me.cmdMP.Text = "<"
        Me.cmdMP.UseVisualStyleBackColor = False
        '
        'cmdMF
        '
        Me.cmdMF.BackColor = System.Drawing.Color.LightGray
        Me.cmdMF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMF.Location = New System.Drawing.Point(28, 19)
        Me.cmdMF.Name = "cmdMF"
        Me.cmdMF.Size = New System.Drawing.Size(75, 23)
        Me.cmdMF.TabIndex = 0
        Me.cmdMF.Text = "|<"
        Me.cmdMF.UseVisualStyleBackColor = False
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.Color.Silver
        Me.cmdclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.Location = New System.Drawing.Point(225, 18)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(75, 23)
        Me.cmdclear.TabIndex = 58
        Me.cmdclear.Text = "CLEAR"
        Me.cmdclear.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdback)
        Me.GroupBox3.Controls.Add(Me.cmdclear)
        Me.GroupBox3.Controls.Add(Me.cmdmodify)
        Me.GroupBox3.Controls.Add(Me.cmddelete)
        Me.GroupBox3.Controls.Add(Me.cmdsave)
        Me.GroupBox3.Controls.Add(Me.cmdexit)
        Me.GroupBox3.Location = New System.Drawing.Point(76, 611)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(601, 60)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        '
        'cmdback
        '
        Me.cmdback.BackColor = System.Drawing.Color.Silver
        Me.cmdback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(414, 20)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(64, 22)
        Me.cmdback.TabIndex = 60
        Me.cmdback.Text = "BACK"
        Me.cmdback.UseVisualStyleBackColor = False
        '
        'lbltest
        '
        Me.lbltest.AutoSize = True
        Me.lbltest.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltest.Location = New System.Drawing.Point(369, 170)
        Me.lbltest.Name = "lbltest"
        Me.lbltest.Size = New System.Drawing.Size(223, 33)
        Me.lbltest.TabIndex = 61
        Me.lbltest.Text = "TEST RECORD"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(392, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 132)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'Test_Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(984, 707)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbltest)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TESTGrid)
        Me.Controls.Add(Me.lblpatient_record)
        Me.Controls.Add(Me.cmdadd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblp_age)
        Me.Controls.Add(Me.lblp_gender)
        Me.Controls.Add(Me.lblp_phone)
        Me.Controls.Add(Me.lblp_address)
        Me.Controls.Add(Me.lblp_name)
        Me.Controls.Add(Me.lblp_id)
        Me.Name = "Test_Record"
        Me.Text = "TEST_RECORD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TESTGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents TESTGrid As System.Windows.Forms.DataGridView
    Friend WithEvents lblpatient_record As System.Windows.Forms.Label
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdmodify As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txttestdesc As System.Windows.Forms.TextBox
    Friend WithEvents txttestname As System.Windows.Forms.TextBox
    Friend WithEvents lblp_age As System.Windows.Forms.Label
    Friend WithEvents lblp_gender As System.Windows.Forms.Label
    Friend WithEvents lblp_phone As System.Windows.Forms.Label
    Friend WithEvents lblp_address As System.Windows.Forms.Label
    Friend WithEvents lblp_name As System.Windows.Forms.Label
    Friend WithEvents lblp_id As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdML As System.Windows.Forms.Button
    Friend WithEvents cmdMN As System.Windows.Forms.Button
    Friend WithEvents cmdMP As System.Windows.Forms.Button
    Friend WithEvents cmdMF As System.Windows.Forms.Button
    Friend WithEvents txtcost As System.Windows.Forms.TextBox
    Friend WithEvents lbltestid As System.Windows.Forms.Label
    Friend WithEvents lbltestname As System.Windows.Forms.Label
    Friend WithEvents lbltestdesc As System.Windows.Forms.Label
    Friend WithEvents lblcost As System.Windows.Forms.Label
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents txttestid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltest As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdback As System.Windows.Forms.Button
End Class
