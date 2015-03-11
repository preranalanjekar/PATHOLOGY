<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cholestrol_Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cholestrol_Test))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbluv = New System.Windows.Forms.Label
        Me.lbltri = New System.Windows.Forms.Label
        Me.txtp_name = New System.Windows.Forms.TextBox
        Me.txtuv = New System.Windows.Forms.TextBox
        Me.txttri = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdback = New System.Windows.Forms.Button
        Me.cmbclear = New System.Windows.Forms.Button
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdadd = New System.Windows.Forms.Button
        Me.cmdmodify = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.lblcholestrol_test = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdML = New System.Windows.Forms.Button
        Me.cmdMN = New System.Windows.Forms.Button
        Me.cmdMP = New System.Windows.Forms.Button
        Me.cmdMF = New System.Windows.Forms.Button
        Me.CHOLESTROLGrid = New System.Windows.Forms.DataGridView
        Me.cmbpid = New System.Windows.Forms.ComboBox
        Me.lbltestid = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmbtest_id = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CHOLESTROLGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PATIENT ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(126, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PATIENT NAME"
        '
        'lbluv
        '
        Me.lbluv.AutoSize = True
        Me.lbluv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluv.Location = New System.Drawing.Point(126, 403)
        Me.lbluv.Name = "lbluv"
        Me.lbluv.Size = New System.Drawing.Size(85, 13)
        Me.lbluv.TabIndex = 2
        Me.lbluv.Text = "UREA VALUE"
        '
        'lbltri
        '
        Me.lbltri.AutoSize = True
        Me.lbltri.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltri.Location = New System.Drawing.Point(126, 456)
        Me.lbltri.Name = "lbltri"
        Me.lbltri.Size = New System.Drawing.Size(98, 13)
        Me.lbltri.TabIndex = 3
        Me.lbltri.Text = "TRIGLYCERIDE"
        '
        'txtp_name
        '
        Me.txtp_name.Location = New System.Drawing.Point(240, 350)
        Me.txtp_name.Name = "txtp_name"
        Me.txtp_name.Size = New System.Drawing.Size(121, 20)
        Me.txtp_name.TabIndex = 5
        '
        'txtuv
        '
        Me.txtuv.Location = New System.Drawing.Point(240, 403)
        Me.txtuv.MaxLength = 3
        Me.txtuv.Name = "txtuv"
        Me.txtuv.Size = New System.Drawing.Size(121, 20)
        Me.txtuv.TabIndex = 6
        '
        'txttri
        '
        Me.txttri.Location = New System.Drawing.Point(240, 456)
        Me.txttri.MaxLength = 3
        Me.txttri.Name = "txttri"
        Me.txttri.Size = New System.Drawing.Size(121, 20)
        Me.txttri.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdback)
        Me.GroupBox1.Controls.Add(Me.cmbclear)
        Me.GroupBox1.Controls.Add(Me.cmddelete)
        Me.GroupBox1.Controls.Add(Me.cmdexit)
        Me.GroupBox1.Controls.Add(Me.cmdadd)
        Me.GroupBox1.Controls.Add(Me.cmdmodify)
        Me.GroupBox1.Controls.Add(Me.cmdsave)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 593)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 58)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'cmdback
        '
        Me.cmdback.BackColor = System.Drawing.Color.Silver
        Me.cmdback.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(472, 19)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(75, 23)
        Me.cmdback.TabIndex = 7
        Me.cmdback.Text = "BACK"
        Me.cmdback.UseVisualStyleBackColor = False
        '
        'cmbclear
        '
        Me.cmbclear.BackColor = System.Drawing.Color.Silver
        Me.cmbclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cmddelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cmdexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.Location = New System.Drawing.Point(566, 20)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(75, 23)
        Me.cmdexit.TabIndex = 3
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.Silver
        Me.cmdadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cmdmodify.Enabled = False
        Me.cmdmodify.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.cmdsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(190, 19)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 23)
        Me.cmdsave.TabIndex = 0
        Me.cmdsave.Text = "SAVE"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'lblcholestrol_test
        '
        Me.lblcholestrol_test.AutoSize = True
        Me.lblcholestrol_test.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcholestrol_test.Location = New System.Drawing.Point(330, 151)
        Me.lblcholestrol_test.Name = "lblcholestrol_test"
        Me.lblcholestrol_test.Size = New System.Drawing.Size(294, 33)
        Me.lblcholestrol_test.TabIndex = 34
        Me.lblcholestrol_test.Text = "CHOLESTROL TEST"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdML)
        Me.GroupBox2.Controls.Add(Me.cmdMN)
        Me.GroupBox2.Controls.Add(Me.cmdMP)
        Me.GroupBox2.Controls.Add(Me.cmdMF)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 526)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 61)
        Me.GroupBox2.TabIndex = 37
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
        'CHOLESTROLGrid
        '
        Me.CHOLESTROLGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CHOLESTROLGrid.Location = New System.Drawing.Point(378, 216)
        Me.CHOLESTROLGrid.Name = "CHOLESTROLGrid"
        Me.CHOLESTROLGrid.Size = New System.Drawing.Size(586, 292)
        Me.CHOLESTROLGrid.TabIndex = 38
        '
        'cmbpid
        '
        Me.cmbpid.FormattingEnabled = True
        Me.cmbpid.Location = New System.Drawing.Point(240, 243)
        Me.cmbpid.Name = "cmbpid"
        Me.cmbpid.Size = New System.Drawing.Size(121, 21)
        Me.cmbpid.TabIndex = 39
        '
        'lbltestid
        '
        Me.lbltestid.AutoSize = True
        Me.lbltestid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltestid.Location = New System.Drawing.Point(126, 304)
        Me.lbltestid.Name = "lbltestid"
        Me.lbltestid.Size = New System.Drawing.Size(56, 13)
        Me.lbltestid.TabIndex = 54
        Me.lbltestid.Text = "TEST ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(396, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 124)
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'cmbtest_id
        '
        Me.cmbtest_id.Enabled = False
        Me.cmbtest_id.Location = New System.Drawing.Point(240, 297)
        Me.cmbtest_id.Name = "cmbtest_id"
        Me.cmbtest_id.Size = New System.Drawing.Size(121, 20)
        Me.cmbtest_id.TabIndex = 57
        Me.cmbtest_id.TabStop = False
        Me.cmbtest_id.Text = "1"
        '
        'Cholestrol_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(976, 697)
        Me.Controls.Add(Me.cmbtest_id)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbltestid)
        Me.Controls.Add(Me.cmbpid)
        Me.Controls.Add(Me.CHOLESTROLGrid)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblcholestrol_test)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txttri)
        Me.Controls.Add(Me.txtuv)
        Me.Controls.Add(Me.txtp_name)
        Me.Controls.Add(Me.lbltri)
        Me.Controls.Add(Me.lbluv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cholestrol_Test"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHOLESTROL TEST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CHOLESTROLGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbluv As System.Windows.Forms.Label
    Friend WithEvents lbltri As System.Windows.Forms.Label
    Friend WithEvents txtp_name As System.Windows.Forms.TextBox
    Friend WithEvents txtuv As System.Windows.Forms.TextBox
    Friend WithEvents txttri As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdmodify As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents lblcholestrol_test As System.Windows.Forms.Label
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdML As System.Windows.Forms.Button
    Friend WithEvents cmdMN As System.Windows.Forms.Button
    Friend WithEvents cmdMP As System.Windows.Forms.Button
    Friend WithEvents cmdMF As System.Windows.Forms.Button
    Friend WithEvents CHOLESTROLGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbpid As System.Windows.Forms.ComboBox
    Friend WithEvents lbltestid As System.Windows.Forms.Label
    Friend WithEvents cmbclear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbtest_id As System.Windows.Forms.TextBox
    Friend WithEvents cmdback As System.Windows.Forms.Button
End Class
