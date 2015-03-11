<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kidney_Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kidney_Test))
        Me.txtp_name = New System.Windows.Forms.TextBox
        Me.lblp_name = New System.Windows.Forms.Label
        Me.lblp_id = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtchloride = New System.Windows.Forms.TextBox
        Me.txtpotassium = New System.Windows.Forms.TextBox
        Me.lblchloride = New System.Windows.Forms.Label
        Me.lblpotassium = New System.Windows.Forms.Label
        Me.txtRUA = New System.Windows.Forms.TextBox
        Me.txtser = New System.Windows.Forms.TextBox
        Me.txtphos = New System.Windows.Forms.TextBox
        Me.txtcalcium = New System.Windows.Forms.TextBox
        Me.txtua = New System.Windows.Forms.TextBox
        Me.txtcreatinine = New System.Windows.Forms.TextBox
        Me.lblsodium = New System.Windows.Forms.Label
        Me.lblser = New System.Windows.Forms.Label
        Me.lblphos = New System.Windows.Forms.Label
        Me.lblcalcium = New System.Windows.Forms.Label
        Me.lblua = New System.Windows.Forms.Label
        Me.lblcreatinine = New System.Windows.Forms.Label
        Me.lblkidney = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdML = New System.Windows.Forms.Button
        Me.cmdMN = New System.Windows.Forms.Button
        Me.cmdMP = New System.Windows.Forms.Button
        Me.cmdMF = New System.Windows.Forms.Button
        Me.KIDNEYGrid = New System.Windows.Forms.DataGridView
        Me.cmbpid = New System.Windows.Forms.ComboBox
        Me.lbl_ktestid = New System.Windows.Forms.Label
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
        CType(Me.KIDNEYGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtp_name
        '
        Me.txtp_name.Location = New System.Drawing.Point(590, 255)
        Me.txtp_name.Name = "txtp_name"
        Me.txtp_name.Size = New System.Drawing.Size(100, 20)
        Me.txtp_name.TabIndex = 16
        '
        'lblp_name
        '
        Me.lblp_name.AutoSize = True
        Me.lblp_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_name.Location = New System.Drawing.Point(465, 258)
        Me.lblp_name.Name = "lblp_name"
        Me.lblp_name.Size = New System.Drawing.Size(99, 13)
        Me.lblp_name.TabIndex = 15
        Me.lblp_name.Text = "PATIENT NAME"
        '
        'lblp_id
        '
        Me.lblp_id.AutoSize = True
        Me.lblp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_id.Location = New System.Drawing.Point(465, 186)
        Me.lblp_id.Name = "lblp_id"
        Me.lblp_id.Size = New System.Drawing.Size(77, 13)
        Me.lblp_id.TabIndex = 14
        Me.lblp_id.Text = "PATIENT ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtchloride)
        Me.GroupBox1.Controls.Add(Me.txtpotassium)
        Me.GroupBox1.Controls.Add(Me.lblchloride)
        Me.GroupBox1.Controls.Add(Me.lblpotassium)
        Me.GroupBox1.Controls.Add(Me.txtRUA)
        Me.GroupBox1.Controls.Add(Me.txtser)
        Me.GroupBox1.Controls.Add(Me.txtphos)
        Me.GroupBox1.Controls.Add(Me.txtcalcium)
        Me.GroupBox1.Controls.Add(Me.txtua)
        Me.GroupBox1.Controls.Add(Me.txtcreatinine)
        Me.GroupBox1.Controls.Add(Me.lblsodium)
        Me.GroupBox1.Controls.Add(Me.lblser)
        Me.GroupBox1.Controls.Add(Me.lblphos)
        Me.GroupBox1.Controls.Add(Me.lblcalcium)
        Me.GroupBox1.Controls.Add(Me.lblua)
        Me.GroupBox1.Controls.Add(Me.lblcreatinine)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 334)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'txtchloride
        '
        Me.txtchloride.Location = New System.Drawing.Point(211, 296)
        Me.txtchloride.MaxLength = 3
        Me.txtchloride.Name = "txtchloride"
        Me.txtchloride.Size = New System.Drawing.Size(100, 20)
        Me.txtchloride.TabIndex = 32
        '
        'txtpotassium
        '
        Me.txtpotassium.Location = New System.Drawing.Point(211, 262)
        Me.txtpotassium.MaxLength = 3
        Me.txtpotassium.Name = "txtpotassium"
        Me.txtpotassium.Size = New System.Drawing.Size(100, 20)
        Me.txtpotassium.TabIndex = 31
        '
        'lblchloride
        '
        Me.lblchloride.AutoSize = True
        Me.lblchloride.Location = New System.Drawing.Point(15, 299)
        Me.lblchloride.Name = "lblchloride"
        Me.lblchloride.Size = New System.Drawing.Size(70, 13)
        Me.lblchloride.TabIndex = 29
        Me.lblchloride.Text = "CHLORIDE"
        '
        'lblpotassium
        '
        Me.lblpotassium.AutoSize = True
        Me.lblpotassium.Location = New System.Drawing.Point(15, 265)
        Me.lblpotassium.Name = "lblpotassium"
        Me.lblpotassium.Size = New System.Drawing.Size(79, 13)
        Me.lblpotassium.TabIndex = 28
        Me.lblpotassium.Text = "POTASSIUM"
        '
        'txtRUA
        '
        Me.txtRUA.Location = New System.Drawing.Point(211, 228)
        Me.txtRUA.MaxLength = 3
        Me.txtRUA.Name = "txtRUA"
        Me.txtRUA.Size = New System.Drawing.Size(100, 20)
        Me.txtRUA.TabIndex = 27
        '
        'txtser
        '
        Me.txtser.Location = New System.Drawing.Point(211, 194)
        Me.txtser.MaxLength = 3
        Me.txtser.Name = "txtser"
        Me.txtser.Size = New System.Drawing.Size(100, 20)
        Me.txtser.TabIndex = 26
        '
        'txtphos
        '
        Me.txtphos.Location = New System.Drawing.Point(211, 161)
        Me.txtphos.MaxLength = 3
        Me.txtphos.Name = "txtphos"
        Me.txtphos.Size = New System.Drawing.Size(100, 20)
        Me.txtphos.TabIndex = 25
        '
        'txtcalcium
        '
        Me.txtcalcium.Location = New System.Drawing.Point(211, 126)
        Me.txtcalcium.MaxLength = 3
        Me.txtcalcium.Name = "txtcalcium"
        Me.txtcalcium.Size = New System.Drawing.Size(100, 20)
        Me.txtcalcium.TabIndex = 24
        '
        'txtua
        '
        Me.txtua.Location = New System.Drawing.Point(211, 92)
        Me.txtua.MaxLength = 3
        Me.txtua.Name = "txtua"
        Me.txtua.Size = New System.Drawing.Size(100, 20)
        Me.txtua.TabIndex = 23
        '
        'txtcreatinine
        '
        Me.txtcreatinine.Location = New System.Drawing.Point(211, 56)
        Me.txtcreatinine.MaxLength = 3
        Me.txtcreatinine.Name = "txtcreatinine"
        Me.txtcreatinine.Size = New System.Drawing.Size(100, 20)
        Me.txtcreatinine.TabIndex = 22
        '
        'lblsodium
        '
        Me.lblsodium.AutoSize = True
        Me.lblsodium.Location = New System.Drawing.Point(15, 231)
        Me.lblsodium.Name = "lblsodium"
        Me.lblsodium.Size = New System.Drawing.Size(56, 13)
        Me.lblsodium.TabIndex = 20
        Me.lblsodium.Text = "SODIUM"
        '
        'lblser
        '
        Me.lblser.AutoSize = True
        Me.lblser.Location = New System.Drawing.Point(14, 197)
        Me.lblser.Name = "lblser"
        Me.lblser.Size = New System.Drawing.Size(110, 13)
        Me.lblser.TabIndex = 19
        Me.lblser.Text = "SERUM PROTIEN"
        '
        'lblphos
        '
        Me.lblphos.AutoSize = True
        Me.lblphos.Location = New System.Drawing.Point(15, 164)
        Me.lblphos.Name = "lblphos"
        Me.lblphos.Size = New System.Drawing.Size(93, 13)
        Me.lblphos.TabIndex = 18
        Me.lblphos.Text = "PHOSPHORUS"
        '
        'lblcalcium
        '
        Me.lblcalcium.AutoSize = True
        Me.lblcalcium.Location = New System.Drawing.Point(15, 129)
        Me.lblcalcium.Name = "lblcalcium"
        Me.lblcalcium.Size = New System.Drawing.Size(61, 13)
        Me.lblcalcium.TabIndex = 17
        Me.lblcalcium.Text = "CALCIUM"
        '
        'lblua
        '
        Me.lblua.AutoSize = True
        Me.lblua.Location = New System.Drawing.Point(15, 95)
        Me.lblua.Name = "lblua"
        Me.lblua.Size = New System.Drawing.Size(70, 13)
        Me.lblua.TabIndex = 16
        Me.lblua.Text = "URIC ACID"
        '
        'lblcreatinine
        '
        Me.lblcreatinine.AutoSize = True
        Me.lblcreatinine.Location = New System.Drawing.Point(15, 59)
        Me.lblcreatinine.Name = "lblcreatinine"
        Me.lblcreatinine.Size = New System.Drawing.Size(82, 13)
        Me.lblcreatinine.TabIndex = 15
        Me.lblcreatinine.Text = "CREATININE"
        '
        'lblkidney
        '
        Me.lblkidney.AutoSize = True
        Me.lblkidney.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkidney.Location = New System.Drawing.Point(363, 128)
        Me.lblkidney.Name = "lblkidney"
        Me.lblkidney.Size = New System.Drawing.Size(205, 33)
        Me.lblkidney.TabIndex = 34
        Me.lblkidney.Text = "KIDNEY TEST"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdML)
        Me.GroupBox3.Controls.Add(Me.cmdMN)
        Me.GroupBox3.Controls.Add(Me.cmdMP)
        Me.GroupBox3.Controls.Add(Me.cmdMF)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(383, 505)
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
        'KIDNEYGrid
        '
        Me.KIDNEYGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KIDNEYGrid.Location = New System.Drawing.Point(369, 285)
        Me.KIDNEYGrid.Name = "KIDNEYGrid"
        Me.KIDNEYGrid.Size = New System.Drawing.Size(725, 214)
        Me.KIDNEYGrid.TabIndex = 38
        '
        'cmbpid
        '
        Me.cmbpid.FormattingEnabled = True
        Me.cmbpid.Location = New System.Drawing.Point(590, 185)
        Me.cmbpid.Name = "cmbpid"
        Me.cmbpid.Size = New System.Drawing.Size(100, 21)
        Me.cmbpid.TabIndex = 40
        '
        'lbl_ktestid
        '
        Me.lbl_ktestid.AutoSize = True
        Me.lbl_ktestid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ktestid.Location = New System.Drawing.Point(465, 224)
        Me.lbl_ktestid.Name = "lbl_ktestid"
        Me.lbl_ktestid.Size = New System.Drawing.Size(56, 13)
        Me.lbl_ktestid.TabIndex = 41
        Me.lbl_ktestid.Text = "TEST ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(383, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 102)
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
        Me.GroupBox2.Location = New System.Drawing.Point(100, 586)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(683, 58)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'cmdback
        '
        Me.cmdback.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(468, 20)
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
        Me.cmdexit.Location = New System.Drawing.Point(559, 20)
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
        Me.cmbtest_id.Location = New System.Drawing.Point(590, 222)
        Me.cmbtest_id.Name = "cmbtest_id"
        Me.cmbtest_id.Size = New System.Drawing.Size(100, 20)
        Me.cmbtest_id.TabIndex = 60
        Me.cmbtest_id.Text = "3"
        '
        'Kidney_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1028, 649)
        Me.Controls.Add(Me.cmbtest_id)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_ktestid)
        Me.Controls.Add(Me.cmbpid)
        Me.Controls.Add(Me.KIDNEYGrid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblkidney)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtp_name)
        Me.Controls.Add(Me.lblp_name)
        Me.Controls.Add(Me.lblp_id)
        Me.Name = "Kidney_Test"
        Me.Text = "KIDNEY_TEST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.KIDNEYGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtp_name As System.Windows.Forms.TextBox
    Friend WithEvents lblp_name As System.Windows.Forms.Label
    Friend WithEvents lblp_id As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRUA As System.Windows.Forms.TextBox
    Friend WithEvents txtser As System.Windows.Forms.TextBox
    Friend WithEvents txtphos As System.Windows.Forms.TextBox
    Friend WithEvents txtcalcium As System.Windows.Forms.TextBox
    Friend WithEvents txtua As System.Windows.Forms.TextBox
    Friend WithEvents txtcreatinine As System.Windows.Forms.TextBox
    Friend WithEvents lblsodium As System.Windows.Forms.Label
    Friend WithEvents lblser As System.Windows.Forms.Label
    Friend WithEvents lblphos As System.Windows.Forms.Label
    Friend WithEvents lblcalcium As System.Windows.Forms.Label
    Friend WithEvents lblua As System.Windows.Forms.Label
    Friend WithEvents lblcreatinine As System.Windows.Forms.Label
    Friend WithEvents txtchloride As System.Windows.Forms.TextBox
    Friend WithEvents txtpotassium As System.Windows.Forms.TextBox
    Friend WithEvents lblchloride As System.Windows.Forms.Label
    Friend WithEvents lblpotassium As System.Windows.Forms.Label
    Friend WithEvents lblkidney As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdML As System.Windows.Forms.Button
    Friend WithEvents cmdMN As System.Windows.Forms.Button
    Friend WithEvents cmdMP As System.Windows.Forms.Button
    Friend WithEvents cmdMF As System.Windows.Forms.Button
    Friend WithEvents KIDNEYGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbpid As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_ktestid As System.Windows.Forms.Label
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
