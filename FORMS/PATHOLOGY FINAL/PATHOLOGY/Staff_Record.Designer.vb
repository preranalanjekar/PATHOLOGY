<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Record
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_Record))
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdmodify = New System.Windows.Forms.Button
        Me.cmdadd = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdML = New System.Windows.Forms.Button
        Me.cmdMN = New System.Windows.Forms.Button
        Me.cmdMP = New System.Windows.Forms.Button
        Me.cmdMF = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txts_post = New System.Windows.Forms.ComboBox
        Me.txts_phone = New System.Windows.Forms.TextBox
        Me.txts_doj = New System.Windows.Forms.TextBox
        Me.txts_salary = New System.Windows.Forms.TextBox
        Me.txts_address = New System.Windows.Forms.TextBox
        Me.lbls_phone = New System.Windows.Forms.Label
        Me.txts_name = New System.Windows.Forms.TextBox
        Me.txts_id = New System.Windows.Forms.TextBox
        Me.lbls_id = New System.Windows.Forms.Label
        Me.lbls_name = New System.Windows.Forms.Label
        Me.lbls_address = New System.Windows.Forms.Label
        Me.lbls_salary = New System.Windows.Forms.Label
        Me.lbls_doj = New System.Windows.Forms.Label
        Me.lbls_post = New System.Windows.Forms.Label
        Me.lblstaff_record = New System.Windows.Forms.Label
        Me.STAFFGrid = New System.Windows.Forms.DataGridView
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdclear = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdback = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.STAFFGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.Silver
        Me.cmdexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.Location = New System.Drawing.Point(494, 19)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(75, 23)
        Me.cmdexit.TabIndex = 23
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.Silver
        Me.cmdsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(178, 19)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 23)
        Me.cmdsave.TabIndex = 22
        Me.cmdsave.Text = "SAVE"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmdmodify
        '
        Me.cmdmodify.BackColor = System.Drawing.Color.Silver
        Me.cmdmodify.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmodify.Location = New System.Drawing.Point(97, 19)
        Me.cmdmodify.Name = "cmdmodify"
        Me.cmdmodify.Size = New System.Drawing.Size(75, 23)
        Me.cmdmodify.TabIndex = 21
        Me.cmdmodify.Text = "MODIFY"
        Me.cmdmodify.UseVisualStyleBackColor = False
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.Silver
        Me.cmdadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.Location = New System.Drawing.Point(16, 19)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(75, 23)
        Me.cmdadd.TabIndex = 20
        Me.cmdadd.Text = "ADD"
        Me.cmdadd.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdML)
        Me.GroupBox2.Controls.Add(Me.cmdMN)
        Me.GroupBox2.Controls.Add(Me.cmdMP)
        Me.GroupBox2.Controls.Add(Me.cmdMF)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 532)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 61)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'cmdML
        '
        Me.cmdML.BackColor = System.Drawing.Color.LightGray
        Me.cmdML.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cmdMN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cmdMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMP.Location = New System.Drawing.Point(133, 19)
        Me.cmdMP.Name = "cmdMP"
        Me.cmdMP.Size = New System.Drawing.Size(75, 23)
        Me.cmdMP.TabIndex = 1
        Me.cmdMP.Text = "<"
        Me.cmdMP.UseVisualStyleBackColor = False
        '
        'cmdMF
        '
        Me.cmdMF.BackColor = System.Drawing.Color.LightGray
        Me.cmdMF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMF.Location = New System.Drawing.Point(28, 19)
        Me.cmdMF.Name = "cmdMF"
        Me.cmdMF.Size = New System.Drawing.Size(75, 23)
        Me.cmdMF.TabIndex = 0
        Me.cmdMF.Text = "|<"
        Me.cmdMF.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txts_post)
        Me.GroupBox1.Controls.Add(Me.txts_phone)
        Me.GroupBox1.Controls.Add(Me.txts_doj)
        Me.GroupBox1.Controls.Add(Me.txts_salary)
        Me.GroupBox1.Controls.Add(Me.txts_address)
        Me.GroupBox1.Controls.Add(Me.lbls_phone)
        Me.GroupBox1.Controls.Add(Me.txts_name)
        Me.GroupBox1.Controls.Add(Me.txts_id)
        Me.GroupBox1.Controls.Add(Me.lbls_id)
        Me.GroupBox1.Controls.Add(Me.lbls_name)
        Me.GroupBox1.Controls.Add(Me.lbls_address)
        Me.GroupBox1.Controls.Add(Me.lbls_salary)
        Me.GroupBox1.Controls.Add(Me.lbls_doj)
        Me.GroupBox1.Controls.Add(Me.lbls_post)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 316)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'txts_post
        '
        Me.txts_post.FormattingEnabled = True
        Me.txts_post.Items.AddRange(New Object() {"NURSE", "DOCTOR", "PATHOLOGIST"})
        Me.txts_post.Location = New System.Drawing.Point(190, 235)
        Me.txts_post.Name = "txts_post"
        Me.txts_post.Size = New System.Drawing.Size(97, 21)
        Me.txts_post.TabIndex = 25
        '
        'txts_phone
        '
        Me.txts_phone.Location = New System.Drawing.Point(188, 274)
        Me.txts_phone.MaxLength = 10
        Me.txts_phone.Name = "txts_phone"
        Me.txts_phone.Size = New System.Drawing.Size(100, 20)
        Me.txts_phone.TabIndex = 6
        '
        'txts_doj
        '
        Me.txts_doj.Location = New System.Drawing.Point(188, 196)
        Me.txts_doj.Name = "txts_doj"
        Me.txts_doj.Size = New System.Drawing.Size(100, 20)
        Me.txts_doj.TabIndex = 4
        '
        'txts_salary
        '
        Me.txts_salary.Location = New System.Drawing.Point(188, 153)
        Me.txts_salary.Name = "txts_salary"
        Me.txts_salary.Size = New System.Drawing.Size(100, 20)
        Me.txts_salary.TabIndex = 3
        '
        'txts_address
        '
        Me.txts_address.Location = New System.Drawing.Point(188, 113)
        Me.txts_address.Name = "txts_address"
        Me.txts_address.Size = New System.Drawing.Size(100, 20)
        Me.txts_address.TabIndex = 2
        '
        'lbls_phone
        '
        Me.lbls_phone.AutoSize = True
        Me.lbls_phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbls_phone.Location = New System.Drawing.Point(30, 281)
        Me.lbls_phone.Name = "lbls_phone"
        Me.lbls_phone.Size = New System.Drawing.Size(114, 13)
        Me.lbls_phone.TabIndex = 24
        Me.lbls_phone.Text = "STAFF PHONE NO"
        '
        'txts_name
        '
        Me.txts_name.Location = New System.Drawing.Point(188, 74)
        Me.txts_name.Name = "txts_name"
        Me.txts_name.Size = New System.Drawing.Size(100, 20)
        Me.txts_name.TabIndex = 1
        '
        'txts_id
        '
        Me.txts_id.Location = New System.Drawing.Point(188, 33)
        Me.txts_id.Name = "txts_id"
        Me.txts_id.Size = New System.Drawing.Size(100, 20)
        Me.txts_id.TabIndex = 0
        '
        'lbls_id
        '
        Me.lbls_id.AutoSize = True
        Me.lbls_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbls_id.Location = New System.Drawing.Point(30, 40)
        Me.lbls_id.Name = "lbls_id"
        Me.lbls_id.Size = New System.Drawing.Size(62, 13)
        Me.lbls_id.TabIndex = 12
        Me.lbls_id.Text = "STAFF ID"
        '
        'lbls_name
        '
        Me.lbls_name.AutoSize = True
        Me.lbls_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbls_name.Location = New System.Drawing.Point(30, 81)
        Me.lbls_name.Name = "lbls_name"
        Me.lbls_name.Size = New System.Drawing.Size(84, 13)
        Me.lbls_name.TabIndex = 13
        Me.lbls_name.Text = "STAFF NAME"
        '
        'lbls_address
        '
        Me.lbls_address.AutoSize = True
        Me.lbls_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbls_address.Location = New System.Drawing.Point(30, 120)
        Me.lbls_address.Name = "lbls_address"
        Me.lbls_address.Size = New System.Drawing.Size(108, 13)
        Me.lbls_address.TabIndex = 14
        Me.lbls_address.Text = "STAFF ADDRESS"
        '
        'lbls_salary
        '
        Me.lbls_salary.AutoSize = True
        Me.lbls_salary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbls_salary.Location = New System.Drawing.Point(30, 160)
        Me.lbls_salary.Name = "lbls_salary"
        Me.lbls_salary.Size = New System.Drawing.Size(97, 13)
        Me.lbls_salary.TabIndex = 15
        Me.lbls_salary.Text = "STAFF SALARY"
        '
        'lbls_doj
        '
        Me.lbls_doj.AutoSize = True
        Me.lbls_doj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbls_doj.Location = New System.Drawing.Point(30, 199)
        Me.lbls_doj.Name = "lbls_doj"
        Me.lbls_doj.Size = New System.Drawing.Size(73, 13)
        Me.lbls_doj.TabIndex = 16
        Me.lbls_doj.Text = "STAFF DOJ"
        '
        'lbls_post
        '
        Me.lbls_post.AutoSize = True
        Me.lbls_post.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbls_post.Location = New System.Drawing.Point(30, 245)
        Me.lbls_post.Name = "lbls_post"
        Me.lbls_post.Size = New System.Drawing.Size(82, 13)
        Me.lbls_post.TabIndex = 17
        Me.lbls_post.Text = "STAFF POST"
        '
        'lblstaff_record
        '
        Me.lblstaff_record.AutoSize = True
        Me.lblstaff_record.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaff_record.Location = New System.Drawing.Point(356, 143)
        Me.lblstaff_record.Name = "lblstaff_record"
        Me.lblstaff_record.Size = New System.Drawing.Size(241, 33)
        Me.lblstaff_record.TabIndex = 34
        Me.lblstaff_record.Text = "STAFF RECORD"
        '
        'STAFFGrid
        '
        Me.STAFFGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.STAFFGrid.Location = New System.Drawing.Point(362, 210)
        Me.STAFFGrid.Name = "STAFFGrid"
        Me.STAFFGrid.Size = New System.Drawing.Size(654, 316)
        Me.STAFFGrid.TabIndex = 35
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.Silver
        Me.cmddelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.Location = New System.Drawing.Point(259, 19)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 23)
        Me.cmddelete.TabIndex = 36
        Me.cmddelete.Text = "DELETE"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.Color.Silver
        Me.cmdclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.Location = New System.Drawing.Point(340, 19)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(75, 23)
        Me.cmdclear.TabIndex = 37
        Me.cmdclear.Text = "CLEAR"
        Me.cmdclear.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(393, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 119)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdback)
        Me.GroupBox3.Controls.Add(Me.cmdadd)
        Me.GroupBox3.Controls.Add(Me.cmdmodify)
        Me.GroupBox3.Controls.Add(Me.cmdclear)
        Me.GroupBox3.Controls.Add(Me.cmdsave)
        Me.GroupBox3.Controls.Add(Me.cmdexit)
        Me.GroupBox3.Controls.Add(Me.cmddelete)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 614)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(585, 54)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        '
        'cmdback
        '
        Me.cmdback.BackColor = System.Drawing.Color.Silver
        Me.cmdback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(420, 19)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(64, 22)
        Me.cmdback.TabIndex = 38
        Me.cmdback.Text = "BACK"
        Me.cmdback.UseVisualStyleBackColor = False
        '
        'Staff_Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1025, 691)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.STAFFGrid)
        Me.Controls.Add(Me.lblstaff_record)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Staff_Record"
        Me.Text = "STAFF_RECORD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.STAFFGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdmodify As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdML As System.Windows.Forms.Button
    Friend WithEvents cmdMN As System.Windows.Forms.Button
    Friend WithEvents cmdMP As System.Windows.Forms.Button
    Friend WithEvents cmdMF As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txts_doj As System.Windows.Forms.TextBox
    Friend WithEvents txts_salary As System.Windows.Forms.TextBox
    Friend WithEvents txts_address As System.Windows.Forms.TextBox
    Friend WithEvents txts_name As System.Windows.Forms.TextBox
    Friend WithEvents txts_id As System.Windows.Forms.TextBox
    Friend WithEvents lbls_post As System.Windows.Forms.Label
    Friend WithEvents lbls_doj As System.Windows.Forms.Label
    Friend WithEvents lbls_salary As System.Windows.Forms.Label
    Friend WithEvents lbls_address As System.Windows.Forms.Label
    Friend WithEvents lbls_name As System.Windows.Forms.Label
    Friend WithEvents lbls_id As System.Windows.Forms.Label
    Friend WithEvents txts_phone As System.Windows.Forms.TextBox
    Friend WithEvents lbls_phone As System.Windows.Forms.Label
    Friend WithEvents lblstaff_record As System.Windows.Forms.Label
    Friend WithEvents STAFFGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txts_post As System.Windows.Forms.ComboBox
    Friend WithEvents cmdback As System.Windows.Forms.Button
End Class
