<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Haemotology_Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Haemotology_Test))
        Me.txtp_name = New System.Windows.Forms.TextBox
        Me.lblp_name = New System.Windows.Forms.Label
        Me.lblp_id = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtmonocyte = New System.Windows.Forms.TextBox
        Me.txtlargel = New System.Windows.Forms.TextBox
        Me.txtsmalll = New System.Windows.Forms.TextBox
        Me.txtbasophil = New System.Windows.Forms.TextBox
        Me.txteosinophil = New System.Windows.Forms.TextBox
        Me.txtneytrophil = New System.Windows.Forms.TextBox
        Me.lblmonocyte = New System.Windows.Forms.Label
        Me.lbllargel = New System.Windows.Forms.Label
        Me.lblsmalll = New System.Windows.Forms.Label
        Me.lblbasophil = New System.Windows.Forms.Label
        Me.lbleosinophil = New System.Windows.Forms.Label
        Me.lblneutrophil = New System.Windows.Forms.Label
        Me.lblhaemotology_test = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdML = New System.Windows.Forms.Button
        Me.cmdMN = New System.Windows.Forms.Button
        Me.cmdMP = New System.Windows.Forms.Button
        Me.cmdMF = New System.Windows.Forms.Button
        Me.HAEMOTOLOGYGrid = New System.Windows.Forms.DataGridView
        Me.cmbpid = New System.Windows.Forms.ComboBox
        Me.lblhtest_id = New System.Windows.Forms.Label
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
        CType(Me.HAEMOTOLOGYGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtp_name
        '
        Me.txtp_name.Location = New System.Drawing.Point(240, 236)
        Me.txtp_name.Name = "txtp_name"
        Me.txtp_name.Size = New System.Drawing.Size(100, 20)
        Me.txtp_name.TabIndex = 16
        '
        'lblp_name
        '
        Me.lblp_name.AutoSize = True
        Me.lblp_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_name.Location = New System.Drawing.Point(51, 243)
        Me.lblp_name.Name = "lblp_name"
        Me.lblp_name.Size = New System.Drawing.Size(99, 13)
        Me.lblp_name.TabIndex = 15
        Me.lblp_name.Text = "PATIENT NAME"
        '
        'lblp_id
        '
        Me.lblp_id.AutoSize = True
        Me.lblp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_id.Location = New System.Drawing.Point(51, 175)
        Me.lblp_id.Name = "lblp_id"
        Me.lblp_id.Size = New System.Drawing.Size(77, 13)
        Me.lblp_id.TabIndex = 14
        Me.lblp_id.Text = "PATIENT ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtmonocyte)
        Me.GroupBox1.Controls.Add(Me.txtlargel)
        Me.GroupBox1.Controls.Add(Me.txtsmalll)
        Me.GroupBox1.Controls.Add(Me.txtbasophil)
        Me.GroupBox1.Controls.Add(Me.txteosinophil)
        Me.GroupBox1.Controls.Add(Me.txtneytrophil)
        Me.GroupBox1.Controls.Add(Me.lblmonocyte)
        Me.GroupBox1.Controls.Add(Me.lbllargel)
        Me.GroupBox1.Controls.Add(Me.lblsmalll)
        Me.GroupBox1.Controls.Add(Me.lblbasophil)
        Me.GroupBox1.Controls.Add(Me.lbleosinophil)
        Me.GroupBox1.Controls.Add(Me.lblneutrophil)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 285)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'txtmonocyte
        '
        Me.txtmonocyte.Location = New System.Drawing.Point(228, 240)
        Me.txtmonocyte.MaxLength = 3
        Me.txtmonocyte.Name = "txtmonocyte"
        Me.txtmonocyte.Size = New System.Drawing.Size(100, 20)
        Me.txtmonocyte.TabIndex = 24
        '
        'txtlargel
        '
        Me.txtlargel.Location = New System.Drawing.Point(228, 200)
        Me.txtlargel.MaxLength = 3
        Me.txtlargel.Name = "txtlargel"
        Me.txtlargel.Size = New System.Drawing.Size(100, 20)
        Me.txtlargel.TabIndex = 23
        '
        'txtsmalll
        '
        Me.txtsmalll.Location = New System.Drawing.Point(228, 160)
        Me.txtsmalll.MaxLength = 3
        Me.txtsmalll.Name = "txtsmalll"
        Me.txtsmalll.Size = New System.Drawing.Size(100, 20)
        Me.txtsmalll.TabIndex = 22
        '
        'txtbasophil
        '
        Me.txtbasophil.Location = New System.Drawing.Point(228, 120)
        Me.txtbasophil.MaxLength = 3
        Me.txtbasophil.Name = "txtbasophil"
        Me.txtbasophil.Size = New System.Drawing.Size(100, 20)
        Me.txtbasophil.TabIndex = 21
        '
        'txteosinophil
        '
        Me.txteosinophil.Location = New System.Drawing.Point(228, 80)
        Me.txteosinophil.MaxLength = 3
        Me.txteosinophil.Name = "txteosinophil"
        Me.txteosinophil.Size = New System.Drawing.Size(100, 20)
        Me.txteosinophil.TabIndex = 20
        '
        'txtneytrophil
        '
        Me.txtneytrophil.Enabled = False
        Me.txtneytrophil.Location = New System.Drawing.Point(228, 40)
        Me.txtneytrophil.MaxLength = 3
        Me.txtneytrophil.Name = "txtneytrophil"
        Me.txtneytrophil.Size = New System.Drawing.Size(100, 20)
        Me.txtneytrophil.TabIndex = 19
        '
        'lblmonocyte
        '
        Me.lblmonocyte.AutoSize = True
        Me.lblmonocyte.Location = New System.Drawing.Point(21, 247)
        Me.lblmonocyte.Name = "lblmonocyte"
        Me.lblmonocyte.Size = New System.Drawing.Size(76, 13)
        Me.lblmonocyte.TabIndex = 18
        Me.lblmonocyte.Text = "MONOCYTE"
        '
        'lbllargel
        '
        Me.lbllargel.AutoSize = True
        Me.lbllargel.Location = New System.Drawing.Point(19, 207)
        Me.lbllargel.Name = "lbllargel"
        Me.lbllargel.Size = New System.Drawing.Size(135, 13)
        Me.lbllargel.TabIndex = 17
        Me.lbllargel.Text = "LARGE LYMPHOCYTE"
        '
        'lblsmalll
        '
        Me.lblsmalll.AutoSize = True
        Me.lblsmalll.Location = New System.Drawing.Point(19, 167)
        Me.lblsmalll.Name = "lblsmalll"
        Me.lblsmalll.Size = New System.Drawing.Size(134, 13)
        Me.lblsmalll.TabIndex = 16
        Me.lblsmalll.Text = "SMALL LYMPHOCYTE"
        '
        'lblbasophil
        '
        Me.lblbasophil.AutoSize = True
        Me.lblbasophil.Location = New System.Drawing.Point(21, 127)
        Me.lblbasophil.Name = "lblbasophil"
        Me.lblbasophil.Size = New System.Drawing.Size(68, 13)
        Me.lblbasophil.TabIndex = 15
        Me.lblbasophil.Text = "BASOPHIL"
        '
        'lbleosinophil
        '
        Me.lbleosinophil.AutoSize = True
        Me.lbleosinophil.Location = New System.Drawing.Point(21, 87)
        Me.lbleosinophil.Name = "lbleosinophil"
        Me.lbleosinophil.Size = New System.Drawing.Size(82, 13)
        Me.lbleosinophil.TabIndex = 14
        Me.lbleosinophil.Text = "EOSINOPHIL"
        '
        'lblneutrophil
        '
        Me.lblneutrophil.AutoSize = True
        Me.lblneutrophil.Location = New System.Drawing.Point(21, 47)
        Me.lblneutrophil.Name = "lblneutrophil"
        Me.lblneutrophil.Size = New System.Drawing.Size(87, 13)
        Me.lblneutrophil.TabIndex = 13
        Me.lblneutrophil.Text = "NEUTROPHIL"
        '
        'lblhaemotology_test
        '
        Me.lblhaemotology_test.AutoSize = True
        Me.lblhaemotology_test.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhaemotology_test.Location = New System.Drawing.Point(311, 122)
        Me.lblhaemotology_test.Name = "lblhaemotology_test"
        Me.lblhaemotology_test.Size = New System.Drawing.Size(326, 33)
        Me.lblhaemotology_test.TabIndex = 34
        Me.lblhaemotology_test.Text = "HAEMOTOLOGY TEST"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdML)
        Me.GroupBox3.Controls.Add(Me.cmdMN)
        Me.GroupBox3.Controls.Add(Me.cmdMP)
        Me.GroupBox3.Controls.Add(Me.cmdMF)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(387, 471)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 61)
        Me.GroupBox3.TabIndex = 38
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
        'HAEMOTOLOGYGrid
        '
        Me.HAEMOTOLOGYGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HAEMOTOLOGYGrid.Location = New System.Drawing.Point(387, 167)
        Me.HAEMOTOLOGYGrid.Name = "HAEMOTOLOGYGrid"
        Me.HAEMOTOLOGYGrid.Size = New System.Drawing.Size(602, 275)
        Me.HAEMOTOLOGYGrid.TabIndex = 39
        '
        'cmbpid
        '
        Me.cmbpid.FormattingEnabled = True
        Me.cmbpid.Location = New System.Drawing.Point(240, 167)
        Me.cmbpid.Name = "cmbpid"
        Me.cmbpid.Size = New System.Drawing.Size(100, 21)
        Me.cmbpid.TabIndex = 40
        '
        'lblhtest_id
        '
        Me.lblhtest_id.AutoSize = True
        Me.lblhtest_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhtest_id.Location = New System.Drawing.Point(53, 209)
        Me.lblhtest_id.Name = "lblhtest_id"
        Me.lblhtest_id.Size = New System.Drawing.Size(56, 13)
        Me.lblhtest_id.TabIndex = 41
        Me.lblhtest_id.Text = "TEST ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(387, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 116)
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
        Me.GroupBox2.Location = New System.Drawing.Point(67, 572)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(659, 58)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'cmdback
        '
        Me.cmdback.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(461, 20)
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
        Me.cmdexit.Location = New System.Drawing.Point(559, 19)
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
        Me.cmbtest_id.Location = New System.Drawing.Point(240, 202)
        Me.cmbtest_id.Name = "cmbtest_id"
        Me.cmbtest_id.Size = New System.Drawing.Size(100, 20)
        Me.cmbtest_id.TabIndex = 60
        Me.cmbtest_id.Text = "2"
        '
        'Haemotology_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(975, 655)
        Me.Controls.Add(Me.cmbtest_id)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblhtest_id)
        Me.Controls.Add(Me.cmbpid)
        Me.Controls.Add(Me.HAEMOTOLOGYGrid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblhaemotology_test)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtp_name)
        Me.Controls.Add(Me.lblp_name)
        Me.Controls.Add(Me.lblp_id)
        Me.Name = "Haemotology_Test"
        Me.Text = "HAEMOTOLOGY TEST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.HAEMOTOLOGYGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtp_name As System.Windows.Forms.TextBox
    Friend WithEvents lblp_name As System.Windows.Forms.Label
    Friend WithEvents lblp_id As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmonocyte As System.Windows.Forms.TextBox
    Friend WithEvents txtlargel As System.Windows.Forms.TextBox
    Friend WithEvents txtsmalll As System.Windows.Forms.TextBox
    Friend WithEvents txtbasophil As System.Windows.Forms.TextBox
    Friend WithEvents txteosinophil As System.Windows.Forms.TextBox
    Friend WithEvents txtneytrophil As System.Windows.Forms.TextBox
    Friend WithEvents lblmonocyte As System.Windows.Forms.Label
    Friend WithEvents lbllargel As System.Windows.Forms.Label
    Friend WithEvents lblsmalll As System.Windows.Forms.Label
    Friend WithEvents lblbasophil As System.Windows.Forms.Label
    Friend WithEvents lbleosinophil As System.Windows.Forms.Label
    Friend WithEvents lblneutrophil As System.Windows.Forms.Label
    Friend WithEvents lblhaemotology_test As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdML As System.Windows.Forms.Button
    Friend WithEvents cmdMN As System.Windows.Forms.Button
    Friend WithEvents cmdMP As System.Windows.Forms.Button
    Friend WithEvents cmdMF As System.Windows.Forms.Button
    Friend WithEvents HAEMOTOLOGYGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbpid As System.Windows.Forms.ComboBox
    Friend WithEvents lblhtest_id As System.Windows.Forms.Label
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
