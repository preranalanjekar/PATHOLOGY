<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Electrolyte_Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Electrolyte_Test))
        Me.txtp_name = New System.Windows.Forms.TextBox
        Me.lblp_name = New System.Windows.Forms.Label
        Me.lblp_id = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtsod = New System.Windows.Forms.TextBox
        Me.txtchloride = New System.Windows.Forms.TextBox
        Me.txtpotassium = New System.Windows.Forms.TextBox
        Me.txtsodium = New System.Windows.Forms.TextBox
        Me.lblsod = New System.Windows.Forms.Label
        Me.lblchloride = New System.Windows.Forms.Label
        Me.lblpotassium = New System.Windows.Forms.Label
        Me.lblsodium = New System.Windows.Forms.Label
        Me.lblserum_test = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdML = New System.Windows.Forms.Button
        Me.cmdMN = New System.Windows.Forms.Button
        Me.cmdMP = New System.Windows.Forms.Button
        Me.cmdMF = New System.Windows.Forms.Button
        Me.SERUMGrid = New System.Windows.Forms.DataGridView
        Me.cmbpid = New System.Windows.Forms.ComboBox
        Me.lbl_setestid = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdback = New System.Windows.Forms.Button
        Me.cmbclear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdadd = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmbtest_id = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SERUMGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtp_name
        '
        Me.txtp_name.Location = New System.Drawing.Point(175, 289)
        Me.txtp_name.Name = "txtp_name"
        Me.txtp_name.Size = New System.Drawing.Size(100, 20)
        Me.txtp_name.TabIndex = 23
        '
        'lblp_name
        '
        Me.lblp_name.AutoSize = True
        Me.lblp_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_name.Location = New System.Drawing.Point(40, 296)
        Me.lblp_name.Name = "lblp_name"
        Me.lblp_name.Size = New System.Drawing.Size(99, 13)
        Me.lblp_name.TabIndex = 22
        Me.lblp_name.Text = "PATIENT NAME"
        '
        'lblp_id
        '
        Me.lblp_id.AutoSize = True
        Me.lblp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_id.Location = New System.Drawing.Point(40, 219)
        Me.lblp_id.Name = "lblp_id"
        Me.lblp_id.Size = New System.Drawing.Size(77, 13)
        Me.lblp_id.TabIndex = 21
        Me.lblp_id.Text = "PATIENT ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsod)
        Me.GroupBox1.Controls.Add(Me.txtchloride)
        Me.GroupBox1.Controls.Add(Me.txtpotassium)
        Me.GroupBox1.Controls.Add(Me.txtsodium)
        Me.GroupBox1.Controls.Add(Me.lblsod)
        Me.GroupBox1.Controls.Add(Me.lblchloride)
        Me.GroupBox1.Controls.Add(Me.lblpotassium)
        Me.GroupBox1.Controls.Add(Me.lblsodium)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 312)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 238)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'txtsod
        '
        Me.txtsod.Location = New System.Drawing.Point(149, 197)
        Me.txtsod.MaxLength = 3
        Me.txtsod.Name = "txtsod"
        Me.txtsod.Size = New System.Drawing.Size(100, 20)
        Me.txtsod.TabIndex = 7
        '
        'txtchloride
        '
        Me.txtchloride.Location = New System.Drawing.Point(149, 143)
        Me.txtchloride.MaxLength = 3
        Me.txtchloride.Name = "txtchloride"
        Me.txtchloride.Size = New System.Drawing.Size(100, 20)
        Me.txtchloride.TabIndex = 6
        '
        'txtpotassium
        '
        Me.txtpotassium.Location = New System.Drawing.Point(149, 95)
        Me.txtpotassium.MaxLength = 3
        Me.txtpotassium.Name = "txtpotassium"
        Me.txtpotassium.Size = New System.Drawing.Size(100, 20)
        Me.txtpotassium.TabIndex = 5
        '
        'txtsodium
        '
        Me.txtsodium.Location = New System.Drawing.Point(149, 38)
        Me.txtsodium.MaxLength = 3
        Me.txtsodium.Name = "txtsodium"
        Me.txtsodium.Size = New System.Drawing.Size(100, 20)
        Me.txtsodium.TabIndex = 4
        '
        'lblsod
        '
        Me.lblsod.AutoSize = True
        Me.lblsod.Location = New System.Drawing.Point(14, 200)
        Me.lblsod.Name = "lblsod"
        Me.lblsod.Size = New System.Drawing.Size(105, 13)
        Me.lblsod.TabIndex = 3
        Me.lblsod.Text = "SODIUM BICARB"
        '
        'lblchloride
        '
        Me.lblchloride.AutoSize = True
        Me.lblchloride.Location = New System.Drawing.Point(14, 150)
        Me.lblchloride.Name = "lblchloride"
        Me.lblchloride.Size = New System.Drawing.Size(70, 13)
        Me.lblchloride.TabIndex = 2
        Me.lblchloride.Text = "CHLORIDE"
        '
        'lblpotassium
        '
        Me.lblpotassium.AutoSize = True
        Me.lblpotassium.Location = New System.Drawing.Point(14, 102)
        Me.lblpotassium.Name = "lblpotassium"
        Me.lblpotassium.Size = New System.Drawing.Size(79, 13)
        Me.lblpotassium.TabIndex = 1
        Me.lblpotassium.Text = "POTASSIUM"
        '
        'lblsodium
        '
        Me.lblsodium.AutoSize = True
        Me.lblsodium.Location = New System.Drawing.Point(14, 45)
        Me.lblsodium.Name = "lblsodium"
        Me.lblsodium.Size = New System.Drawing.Size(56, 13)
        Me.lblsodium.TabIndex = 0
        Me.lblsodium.Text = "SODIUM"
        '
        'lblserum_test
        '
        Me.lblserum_test.AutoSize = True
        Me.lblserum_test.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblserum_test.Location = New System.Drawing.Point(377, 140)
        Me.lblserum_test.Name = "lblserum_test"
        Me.lblserum_test.Size = New System.Drawing.Size(307, 33)
        Me.lblserum_test.TabIndex = 34
        Me.lblserum_test.Text = "ELECTROLYTE TEST"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdML)
        Me.GroupBox3.Controls.Add(Me.cmdMN)
        Me.GroupBox3.Controls.Add(Me.cmdMP)
        Me.GroupBox3.Controls.Add(Me.cmdMF)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(157, 556)
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
        'SERUMGrid
        '
        Me.SERUMGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SERUMGrid.Location = New System.Drawing.Point(338, 312)
        Me.SERUMGrid.Name = "SERUMGrid"
        Me.SERUMGrid.Size = New System.Drawing.Size(531, 238)
        Me.SERUMGrid.TabIndex = 38
        '
        'cmbpid
        '
        Me.cmbpid.FormattingEnabled = True
        Me.cmbpid.Location = New System.Drawing.Point(175, 211)
        Me.cmbpid.Name = "cmbpid"
        Me.cmbpid.Size = New System.Drawing.Size(121, 21)
        Me.cmbpid.TabIndex = 40
        '
        'lbl_setestid
        '
        Me.lbl_setestid.AutoSize = True
        Me.lbl_setestid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_setestid.Location = New System.Drawing.Point(40, 255)
        Me.lbl_setestid.Name = "lbl_setestid"
        Me.lbl_setestid.Size = New System.Drawing.Size(56, 13)
        Me.lbl_setestid.TabIndex = 41
        Me.lbl_setestid.Text = "TEST ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(419, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 119)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdback)
        Me.GroupBox2.Controls.Add(Me.cmbclear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdadd)
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(120, 633)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 58)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'cmdback
        '
        Me.cmdback.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(304, 19)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(75, 23)
        Me.cmdback.TabIndex = 7
        Me.cmdback.Text = "BACK"
        Me.cmdback.UseVisualStyleBackColor = True
        '
        'cmbclear
        '
        Me.cmbclear.BackColor = System.Drawing.Color.LightGray
        Me.cmbclear.Location = New System.Drawing.Point(209, 19)
        Me.cmbclear.Name = "cmbclear"
        Me.cmbclear.Size = New System.Drawing.Size(75, 23)
        Me.cmbclear.TabIndex = 5
        Me.cmbclear.Text = "CLEAR"
        Me.cmbclear.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.LightGray
        Me.cmdexit.Location = New System.Drawing.Point(397, 19)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(75, 23)
        Me.cmdexit.TabIndex = 3
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.LightGray
        Me.cmdadd.Location = New System.Drawing.Point(30, 19)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(75, 23)
        Me.cmdadd.TabIndex = 2
        Me.cmdadd.Text = "ADD"
        Me.cmdadd.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.LightGray
        Me.cmdsave.Location = New System.Drawing.Point(121, 19)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 23)
        Me.cmdsave.TabIndex = 0
        Me.cmdsave.Text = "SAVE"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmbtest_id
        '
        Me.cmbtest_id.Enabled = False
        Me.cmbtest_id.Location = New System.Drawing.Point(177, 248)
        Me.cmbtest_id.Name = "cmbtest_id"
        Me.cmbtest_id.Size = New System.Drawing.Size(100, 20)
        Me.cmbtest_id.TabIndex = 45
        Me.cmbtest_id.Text = "5"
        '
        'Electrolyte_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(993, 742)
        Me.Controls.Add(Me.cmbtest_id)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_setestid)
        Me.Controls.Add(Me.cmbpid)
        Me.Controls.Add(Me.SERUMGrid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblserum_test)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtp_name)
        Me.Controls.Add(Me.lblp_name)
        Me.Controls.Add(Me.lblp_id)
        Me.Name = "Electrolyte_Test"
        Me.Text = "ELECTROLYTE_TEST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.SERUMGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtp_name As System.Windows.Forms.TextBox
    Friend WithEvents lblp_name As System.Windows.Forms.Label
    Friend WithEvents lblp_id As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsod As System.Windows.Forms.TextBox
    Friend WithEvents txtchloride As System.Windows.Forms.TextBox
    Friend WithEvents txtpotassium As System.Windows.Forms.TextBox
    Friend WithEvents txtsodium As System.Windows.Forms.TextBox
    Friend WithEvents lblsod As System.Windows.Forms.Label
    Friend WithEvents lblchloride As System.Windows.Forms.Label
    Friend WithEvents lblpotassium As System.Windows.Forms.Label
    Friend WithEvents lblsodium As System.Windows.Forms.Label
    Friend WithEvents lblserum_test As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdML As System.Windows.Forms.Button
    Friend WithEvents cmdMN As System.Windows.Forms.Button
    Friend WithEvents cmdMP As System.Windows.Forms.Button
    Friend WithEvents cmdMF As System.Windows.Forms.Button
    Friend WithEvents SERUMGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbpid As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_setestid As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbclear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmbtest_id As System.Windows.Forms.TextBox
    Friend WithEvents cmdback As System.Windows.Forms.Button
End Class
