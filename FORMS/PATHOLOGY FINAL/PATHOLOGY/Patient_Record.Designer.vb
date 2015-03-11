<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_Record
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_Record))
        Me.lblp_id = New System.Windows.Forms.Label
        Me.lblp_name = New System.Windows.Forms.Label
        Me.lblp_address = New System.Windows.Forms.Label
        Me.lblp_phone = New System.Windows.Forms.Label
        Me.lblp_gender = New System.Windows.Forms.Label
        Me.lblp_age = New System.Windows.Forms.Label
        Me.txtp_age = New System.Windows.Forms.TextBox
        Me.txtp_phone = New System.Windows.Forms.TextBox
        Me.txtp_address = New System.Windows.Forms.TextBox
        Me.txtp_name = New System.Windows.Forms.TextBox
        Me.txtp_id = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdML = New System.Windows.Forms.Button
        Me.cmdMN = New System.Windows.Forms.Button
        Me.cmdMP = New System.Windows.Forms.Button
        Me.cmdMF = New System.Windows.Forms.Button
        Me.cmdadd = New System.Windows.Forms.Button
        Me.cmdmodify = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.lblpatient_record = New System.Windows.Forms.Label
        Me.PATIENTGrid = New System.Windows.Forms.DataGridView
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdclear = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtp_gender = New System.Windows.Forms.ComboBox
        Me.p_date = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdback = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2.SuspendLayout()
        CType(Me.PATIENTGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblp_id
        '
        Me.lblp_id.AutoSize = True
        Me.lblp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_id.Location = New System.Drawing.Point(18, 28)
        Me.lblp_id.Name = "lblp_id"
        Me.lblp_id.Size = New System.Drawing.Size(81, 15)
        Me.lblp_id.TabIndex = 0
        Me.lblp_id.Text = "PATIENT ID"
        '
        'lblp_name
        '
        Me.lblp_name.AutoSize = True
        Me.lblp_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_name.Location = New System.Drawing.Point(18, 67)
        Me.lblp_name.Name = "lblp_name"
        Me.lblp_name.Size = New System.Drawing.Size(106, 15)
        Me.lblp_name.TabIndex = 1
        Me.lblp_name.Text = "PATIENT NAME"
        '
        'lblp_address
        '
        Me.lblp_address.AutoSize = True
        Me.lblp_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_address.Location = New System.Drawing.Point(18, 102)
        Me.lblp_address.Name = "lblp_address"
        Me.lblp_address.Size = New System.Drawing.Size(132, 15)
        Me.lblp_address.TabIndex = 2
        Me.lblp_address.Text = "PATIENT ADDRESS"
        '
        'lblp_phone
        '
        Me.lblp_phone.AutoSize = True
        Me.lblp_phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_phone.Location = New System.Drawing.Point(18, 137)
        Me.lblp_phone.Name = "lblp_phone"
        Me.lblp_phone.Size = New System.Drawing.Size(139, 15)
        Me.lblp_phone.TabIndex = 3
        Me.lblp_phone.Text = "PATIENT PHONE NO"
        '
        'lblp_gender
        '
        Me.lblp_gender.AutoSize = True
        Me.lblp_gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_gender.Location = New System.Drawing.Point(18, 172)
        Me.lblp_gender.Name = "lblp_gender"
        Me.lblp_gender.Size = New System.Drawing.Size(125, 15)
        Me.lblp_gender.TabIndex = 4
        Me.lblp_gender.Text = "PATIENT GENDER"
        '
        'lblp_age
        '
        Me.lblp_age.AutoSize = True
        Me.lblp_age.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_age.Location = New System.Drawing.Point(18, 207)
        Me.lblp_age.Name = "lblp_age"
        Me.lblp_age.Size = New System.Drawing.Size(94, 15)
        Me.lblp_age.TabIndex = 5
        Me.lblp_age.Text = "PATIENT AGE"
        '
        'txtp_age
        '
        Me.txtp_age.Location = New System.Drawing.Point(177, 202)
        Me.txtp_age.MaxLength = 3
        Me.txtp_age.Name = "txtp_age"
        Me.txtp_age.Size = New System.Drawing.Size(98, 20)
        Me.txtp_age.TabIndex = 5
        '
        'txtp_phone
        '
        Me.txtp_phone.Location = New System.Drawing.Point(177, 132)
        Me.txtp_phone.MaxLength = 10
        Me.txtp_phone.Name = "txtp_phone"
        Me.txtp_phone.Size = New System.Drawing.Size(98, 20)
        Me.txtp_phone.TabIndex = 3
        '
        'txtp_address
        '
        Me.txtp_address.Location = New System.Drawing.Point(177, 97)
        Me.txtp_address.Name = "txtp_address"
        Me.txtp_address.Size = New System.Drawing.Size(98, 20)
        Me.txtp_address.TabIndex = 2
        '
        'txtp_name
        '
        Me.txtp_name.Location = New System.Drawing.Point(177, 62)
        Me.txtp_name.Name = "txtp_name"
        Me.txtp_name.Size = New System.Drawing.Size(98, 20)
        Me.txtp_name.TabIndex = 1
        '
        'txtp_id
        '
        Me.txtp_id.Location = New System.Drawing.Point(177, 27)
        Me.txtp_id.Name = "txtp_id"
        Me.txtp_id.Size = New System.Drawing.Size(98, 20)
        Me.txtp_id.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdML)
        Me.GroupBox2.Controls.Add(Me.cmdMN)
        Me.GroupBox2.Controls.Add(Me.cmdMP)
        Me.GroupBox2.Controls.Add(Me.cmdMF)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 536)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 61)
        Me.GroupBox2.TabIndex = 7
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
        Me.cmdMF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMF.Location = New System.Drawing.Point(28, 19)
        Me.cmdMF.Name = "cmdMF"
        Me.cmdMF.Size = New System.Drawing.Size(75, 23)
        Me.cmdMF.TabIndex = 0
        Me.cmdMF.Text = "|<"
        Me.cmdMF.UseVisualStyleBackColor = False
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.Silver
        Me.cmdadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.Location = New System.Drawing.Point(22, 19)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(75, 23)
        Me.cmdadd.TabIndex = 8
        Me.cmdadd.Text = "ADD"
        Me.cmdadd.UseVisualStyleBackColor = False
        '
        'cmdmodify
        '
        Me.cmdmodify.BackColor = System.Drawing.Color.Silver
        Me.cmdmodify.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmodify.Location = New System.Drawing.Point(114, 19)
        Me.cmdmodify.Name = "cmdmodify"
        Me.cmdmodify.Size = New System.Drawing.Size(75, 23)
        Me.cmdmodify.TabIndex = 9
        Me.cmdmodify.Text = "MODIFY"
        Me.cmdmodify.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.Silver
        Me.cmdsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(206, 19)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 23)
        Me.cmdsave.TabIndex = 10
        Me.cmdsave.Text = "SAVE"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.Silver
        Me.cmdexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.Location = New System.Drawing.Point(582, 19)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(75, 23)
        Me.cmdexit.TabIndex = 11
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'lblpatient_record
        '
        Me.lblpatient_record.AutoSize = True
        Me.lblpatient_record.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpatient_record.Location = New System.Drawing.Point(329, 194)
        Me.lblpatient_record.Name = "lblpatient_record"
        Me.lblpatient_record.Size = New System.Drawing.Size(271, 33)
        Me.lblpatient_record.TabIndex = 34
        Me.lblpatient_record.Text = "PATIENT RECORD"
        '
        'PATIENTGrid
        '
        Me.PATIENTGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PATIENTGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PATIENTGrid.Location = New System.Drawing.Point(356, 243)
        Me.PATIENTGrid.Name = "PATIENTGrid"
        Me.PATIENTGrid.Size = New System.Drawing.Size(702, 286)
        Me.PATIENTGrid.TabIndex = 35
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.Silver
        Me.cmddelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.Location = New System.Drawing.Point(388, 19)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 23)
        Me.cmddelete.TabIndex = 36
        Me.cmddelete.Text = "&DELETE"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.Color.Silver
        Me.cmdclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.Location = New System.Drawing.Point(297, 19)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(75, 23)
        Me.cmdclear.TabIndex = 37
        Me.cmdclear.Text = "CLEAR"
        Me.cmdclear.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtp_gender)
        Me.GroupBox3.Controls.Add(Me.p_date)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.txtp_age)
        Me.GroupBox3.Controls.Add(Me.lblp_id)
        Me.GroupBox3.Controls.Add(Me.lblp_name)
        Me.GroupBox3.Controls.Add(Me.txtp_phone)
        Me.GroupBox3.Controls.Add(Me.lblp_address)
        Me.GroupBox3.Controls.Add(Me.txtp_address)
        Me.GroupBox3.Controls.Add(Me.lblp_phone)
        Me.GroupBox3.Controls.Add(Me.txtp_name)
        Me.GroupBox3.Controls.Add(Me.lblp_gender)
        Me.GroupBox3.Controls.Add(Me.txtp_id)
        Me.GroupBox3.Controls.Add(Me.lblp_age)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 242)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 288)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'txtp_gender
        '
        Me.txtp_gender.FormattingEnabled = True
        Me.txtp_gender.Items.AddRange(New Object() {"F", "M"})
        Me.txtp_gender.Location = New System.Drawing.Point(173, 166)
        Me.txtp_gender.Name = "txtp_gender"
        Me.txtp_gender.Size = New System.Drawing.Size(101, 21)
        Me.txtp_gender.TabIndex = 9
        '
        'p_date
        '
        Me.p_date.AutoSize = True
        Me.p_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_date.Location = New System.Drawing.Point(18, 244)
        Me.p_date.Name = "p_date"
        Me.p_date.Size = New System.Drawing.Size(98, 13)
        Me.p_date.TabIndex = 8
        Me.p_date.Text = "VISITING DATE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(176, 237)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdback)
        Me.GroupBox1.Controls.Add(Me.cmdadd)
        Me.GroupBox1.Controls.Add(Me.cmdmodify)
        Me.GroupBox1.Controls.Add(Me.cmddelete)
        Me.GroupBox1.Controls.Add(Me.cmdclear)
        Me.GroupBox1.Controls.Add(Me.cmdexit)
        Me.GroupBox1.Controls.Add(Me.cmdsave)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 612)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 63)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'cmdback
        '
        Me.cmdback.BackColor = System.Drawing.Color.Silver
        Me.cmdback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(485, 19)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(75, 23)
        Me.cmdback.TabIndex = 38
        Me.cmdback.Text = "BACK"
        Me.cmdback.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(400, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 170)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Patient_Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1028, 696)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PATIENTGrid)
        Me.Controls.Add(Me.lblpatient_record)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Patient_Record"
        Me.Text = "PATIENT_RECORD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PATIENTGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblp_id As System.Windows.Forms.Label
    Friend WithEvents lblp_name As System.Windows.Forms.Label
    Friend WithEvents lblp_address As System.Windows.Forms.Label
    Friend WithEvents lblp_phone As System.Windows.Forms.Label
    Friend WithEvents lblp_gender As System.Windows.Forms.Label
    Friend WithEvents lblp_age As System.Windows.Forms.Label
    Friend WithEvents txtp_age As System.Windows.Forms.TextBox
    Friend WithEvents txtp_phone As System.Windows.Forms.TextBox
    Friend WithEvents txtp_address As System.Windows.Forms.TextBox
    Friend WithEvents txtp_name As System.Windows.Forms.TextBox
    Friend WithEvents txtp_id As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdML As System.Windows.Forms.Button
    Friend WithEvents cmdMN As System.Windows.Forms.Button
    Friend WithEvents cmdMP As System.Windows.Forms.Button
    Friend WithEvents cmdMF As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents cmdmodify As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents lblpatient_record As System.Windows.Forms.Label
    Friend WithEvents PATIENTGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents p_date As System.Windows.Forms.Label
    Friend WithEvents cmdback As System.Windows.Forms.Button
    Friend WithEvents txtp_gender As System.Windows.Forms.ComboBox
End Class
