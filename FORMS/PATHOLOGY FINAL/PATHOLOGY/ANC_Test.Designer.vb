<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ANC_Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ANC_Test))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtrh = New System.Windows.Forms.ComboBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.cmdML = New System.Windows.Forms.Button
        Me.cmdMN = New System.Windows.Forms.Button
        Me.cmdMP = New System.Windows.Forms.Button
        Me.cmdMF = New System.Windows.Forms.Button
        Me.txthaea = New System.Windows.Forms.TextBox
        Me.txtVDRL = New System.Windows.Forms.TextBox
        Me.txtHbs = New System.Windows.Forms.TextBox
        Me.txtPPUA = New System.Windows.Forms.TextBox
        Me.txtPLBS = New System.Windows.Forms.TextBox
        Me.txtFBS = New System.Windows.Forms.TextBox
        Me.lblRUA = New System.Windows.Forms.Label
        Me.lblhaem = New System.Windows.Forms.Label
        Me.lblVDRL = New System.Windows.Forms.Label
        Me.lblHbs = New System.Windows.Forms.Label
        Me.lblRBS = New System.Windows.Forms.Label
        Me.lblPLBS = New System.Windows.Forms.Label
        Me.lblFBS = New System.Windows.Forms.Label
        Me.txtp_name = New System.Windows.Forms.TextBox
        Me.lblp_name = New System.Windows.Forms.Label
        Me.lblp_id = New System.Windows.Forms.Label
        Me.LBLbloodg = New System.Windows.Forms.Label
        Me.lblvirus = New System.Windows.Forms.Label
        Me.optpresent = New System.Windows.Forms.RadioButton
        Me.optabsent = New System.Windows.Forms.RadioButton
        Me.lblpregnancy_test = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lstbloodg = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cmdmove_last = New System.Windows.Forms.Button
        Me.cmdmove_next = New System.Windows.Forms.Button
        Me.cmdmove_previous = New System.Windows.Forms.Button
        Me.cmdmove_first = New System.Windows.Forms.Button
        Me.PREGNANCYGrid = New System.Windows.Forms.DataGridView
        Me.cmbpid = New System.Windows.Forms.ComboBox
        Me.lbl_pytestid = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdback = New System.Windows.Forms.Button
        Me.cmbclear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdadd = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmbtest_id = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PREGNANCYGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtrh)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.txthaea)
        Me.GroupBox1.Controls.Add(Me.txtVDRL)
        Me.GroupBox1.Controls.Add(Me.txtHbs)
        Me.GroupBox1.Controls.Add(Me.txtPPUA)
        Me.GroupBox1.Controls.Add(Me.txtPLBS)
        Me.GroupBox1.Controls.Add(Me.txtFBS)
        Me.GroupBox1.Controls.Add(Me.lblRUA)
        Me.GroupBox1.Controls.Add(Me.lblhaem)
        Me.GroupBox1.Controls.Add(Me.lblVDRL)
        Me.GroupBox1.Controls.Add(Me.lblHbs)
        Me.GroupBox1.Controls.Add(Me.lblRBS)
        Me.GroupBox1.Controls.Add(Me.lblPLBS)
        Me.GroupBox1.Controls.Add(Me.lblFBS)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 291)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'txtrh
        '
        Me.txtrh.FormattingEnabled = True
        Me.txtrh.Items.AddRange(New Object() {"PRESENT", "ABSENT"})
        Me.txtrh.Location = New System.Drawing.Point(225, 244)
        Me.txtrh.Name = "txtrh"
        Me.txtrh.Size = New System.Drawing.Size(100, 21)
        Me.txtrh.TabIndex = 15
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmdML)
        Me.GroupBox5.Controls.Add(Me.cmdMN)
        Me.GroupBox5.Controls.Add(Me.cmdMP)
        Me.GroupBox5.Controls.Add(Me.cmdMF)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 292)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(450, 61)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        '
        'cmdML
        '
        Me.cmdML.Location = New System.Drawing.Point(339, 19)
        Me.cmdML.Name = "cmdML"
        Me.cmdML.Size = New System.Drawing.Size(75, 23)
        Me.cmdML.TabIndex = 3
        Me.cmdML.Text = ">|"
        Me.cmdML.UseVisualStyleBackColor = True
        '
        'cmdMN
        '
        Me.cmdMN.Location = New System.Drawing.Point(239, 19)
        Me.cmdMN.Name = "cmdMN"
        Me.cmdMN.Size = New System.Drawing.Size(75, 23)
        Me.cmdMN.TabIndex = 2
        Me.cmdMN.Text = ">"
        Me.cmdMN.UseVisualStyleBackColor = True
        '
        'cmdMP
        '
        Me.cmdMP.Location = New System.Drawing.Point(141, 19)
        Me.cmdMP.Name = "cmdMP"
        Me.cmdMP.Size = New System.Drawing.Size(75, 23)
        Me.cmdMP.TabIndex = 1
        Me.cmdMP.Text = "<"
        Me.cmdMP.UseVisualStyleBackColor = True
        '
        'cmdMF
        '
        Me.cmdMF.Location = New System.Drawing.Point(28, 19)
        Me.cmdMF.Name = "cmdMF"
        Me.cmdMF.Size = New System.Drawing.Size(75, 23)
        Me.cmdMF.TabIndex = 0
        Me.cmdMF.Text = "|<"
        Me.cmdMF.UseVisualStyleBackColor = True
        '
        'txthaea
        '
        Me.txthaea.Location = New System.Drawing.Point(226, 213)
        Me.txthaea.MaxLength = 3
        Me.txthaea.Name = "txthaea"
        Me.txthaea.Size = New System.Drawing.Size(100, 20)
        Me.txthaea.TabIndex = 12
        '
        'txtVDRL
        '
        Me.txtVDRL.Location = New System.Drawing.Point(226, 180)
        Me.txtVDRL.MaxLength = 3
        Me.txtVDRL.Name = "txtVDRL"
        Me.txtVDRL.Size = New System.Drawing.Size(100, 20)
        Me.txtVDRL.TabIndex = 11
        '
        'txtHbs
        '
        Me.txtHbs.Location = New System.Drawing.Point(226, 144)
        Me.txtHbs.MaxLength = 3
        Me.txtHbs.Name = "txtHbs"
        Me.txtHbs.Size = New System.Drawing.Size(100, 20)
        Me.txtHbs.TabIndex = 10
        '
        'txtPPUA
        '
        Me.txtPPUA.Location = New System.Drawing.Point(226, 99)
        Me.txtPPUA.MaxLength = 3
        Me.txtPPUA.Name = "txtPPUA"
        Me.txtPPUA.Size = New System.Drawing.Size(100, 20)
        Me.txtPPUA.TabIndex = 9
        '
        'txtPLBS
        '
        Me.txtPLBS.Location = New System.Drawing.Point(226, 66)
        Me.txtPLBS.MaxLength = 3
        Me.txtPLBS.Name = "txtPLBS"
        Me.txtPLBS.Size = New System.Drawing.Size(100, 20)
        Me.txtPLBS.TabIndex = 8
        '
        'txtFBS
        '
        Me.txtFBS.Location = New System.Drawing.Point(226, 23)
        Me.txtFBS.MaxLength = 3
        Me.txtFBS.Name = "txtFBS"
        Me.txtFBS.Size = New System.Drawing.Size(100, 20)
        Me.txtFBS.TabIndex = 7
        '
        'lblRUA
        '
        Me.lblRUA.AutoSize = True
        Me.lblRUA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUA.Location = New System.Drawing.Point(19, 243)
        Me.lblRUA.Name = "lblRUA"
        Me.lblRUA.Size = New System.Drawing.Size(78, 13)
        Me.lblRUA.TabIndex = 6
        Me.lblRUA.Text = "RH.FACTOR"
        '
        'lblhaem
        '
        Me.lblhaem.AutoSize = True
        Me.lblhaem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhaem.Location = New System.Drawing.Point(19, 207)
        Me.lblhaem.Name = "lblhaem"
        Me.lblhaem.Size = New System.Drawing.Size(97, 13)
        Me.lblhaem.TabIndex = 5
        Me.lblhaem.Text = "HAEMOGLOBIN"
        '
        'lblVDRL
        '
        Me.lblVDRL.AutoSize = True
        Me.lblVDRL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVDRL.Location = New System.Drawing.Point(19, 171)
        Me.lblVDRL.Name = "lblVDRL"
        Me.lblVDRL.Size = New System.Drawing.Size(40, 13)
        Me.lblVDRL.TabIndex = 4
        Me.lblVDRL.Text = "VDRL"
        '
        'lblHbs
        '
        Me.lblHbs.AutoSize = True
        Me.lblHbs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHbs.Location = New System.Drawing.Point(19, 135)
        Me.lblHbs.Name = "lblHbs"
        Me.lblHbs.Size = New System.Drawing.Size(86, 13)
        Me.lblHbs.TabIndex = 3
        Me.lblHbs.Text = "HbsAg(Au.Ag)"
        '
        'lblRBS
        '
        Me.lblRBS.AutoSize = True
        Me.lblRBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBS.Location = New System.Drawing.Point(19, 99)
        Me.lblRBS.Name = "lblRBS"
        Me.lblRBS.Size = New System.Drawing.Size(154, 13)
        Me.lblRBS.TabIndex = 2
        Me.lblRBS.Text = "RANDOM BLOOD SUGAR"
        '
        'lblPLBS
        '
        Me.lblPLBS.AutoSize = True
        Me.lblPLBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPLBS.Location = New System.Drawing.Point(19, 63)
        Me.lblPLBS.Name = "lblPLBS"
        Me.lblPLBS.Size = New System.Drawing.Size(179, 13)
        Me.lblPLBS.TabIndex = 1
        Me.lblPLBS.Text = "POST LUNCH BLOOD SUGAR"
        '
        'lblFBS
        '
        Me.lblFBS.AutoSize = True
        Me.lblFBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFBS.Location = New System.Drawing.Point(19, 27)
        Me.lblFBS.Name = "lblFBS"
        Me.lblFBS.Size = New System.Drawing.Size(153, 13)
        Me.lblFBS.TabIndex = 0
        Me.lblFBS.Text = "FASTING BLOOD SUGAR"
        '
        'txtp_name
        '
        Me.txtp_name.Location = New System.Drawing.Point(217, 253)
        Me.txtp_name.Name = "txtp_name"
        Me.txtp_name.Size = New System.Drawing.Size(100, 20)
        Me.txtp_name.TabIndex = 18
        '
        'lblp_name
        '
        Me.lblp_name.AutoSize = True
        Me.lblp_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_name.Location = New System.Drawing.Point(31, 256)
        Me.lblp_name.Name = "lblp_name"
        Me.lblp_name.Size = New System.Drawing.Size(99, 13)
        Me.lblp_name.TabIndex = 17
        Me.lblp_name.Text = "PATIENT NAME"
        '
        'lblp_id
        '
        Me.lblp_id.AutoSize = True
        Me.lblp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_id.Location = New System.Drawing.Point(31, 207)
        Me.lblp_id.Name = "lblp_id"
        Me.lblp_id.Size = New System.Drawing.Size(77, 13)
        Me.lblp_id.TabIndex = 16
        Me.lblp_id.Text = "PATIENT ID"
        '
        'LBLbloodg
        '
        Me.LBLbloodg.AutoSize = True
        Me.LBLbloodg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLbloodg.Location = New System.Drawing.Point(47, 16)
        Me.LBLbloodg.Name = "LBLbloodg"
        Me.LBLbloodg.Size = New System.Drawing.Size(97, 13)
        Me.LBLbloodg.TabIndex = 22
        Me.LBLbloodg.Text = "BLOOD GROUP"
        '
        'lblvirus
        '
        Me.lblvirus.AutoSize = True
        Me.lblvirus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvirus.Location = New System.Drawing.Point(53, 16)
        Me.lblvirus.Name = "lblvirus"
        Me.lblvirus.Size = New System.Drawing.Size(115, 13)
        Me.lblvirus.TabIndex = 23
        Me.lblvirus.Text = " HIV(AIDS) VIRUS "
        '
        'optpresent
        '
        Me.optpresent.AutoSize = True
        Me.optpresent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optpresent.Location = New System.Drawing.Point(29, 39)
        Me.optpresent.Name = "optpresent"
        Me.optpresent.Size = New System.Drawing.Size(83, 17)
        Me.optpresent.TabIndex = 25
        Me.optpresent.TabStop = True
        Me.optpresent.Text = "PRESENT"
        Me.optpresent.UseVisualStyleBackColor = True
        '
        'optabsent
        '
        Me.optabsent.AutoSize = True
        Me.optabsent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optabsent.Location = New System.Drawing.Point(29, 68)
        Me.optabsent.Name = "optabsent"
        Me.optabsent.Size = New System.Drawing.Size(74, 17)
        Me.optabsent.TabIndex = 26
        Me.optabsent.TabStop = True
        Me.optabsent.Text = "ABSENT"
        Me.optabsent.UseVisualStyleBackColor = True
        '
        'lblpregnancy_test
        '
        Me.lblpregnancy_test.AutoSize = True
        Me.lblpregnancy_test.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpregnancy_test.Location = New System.Drawing.Point(374, 157)
        Me.lblpregnancy_test.Name = "lblpregnancy_test"
        Me.lblpregnancy_test.Size = New System.Drawing.Size(208, 33)
        Me.lblpregnancy_test.TabIndex = 34
        Me.lblpregnancy_test.Text = "ANC PROFILE"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstbloodg)
        Me.GroupBox3.Controls.Add(Me.LBLbloodg)
        Me.GroupBox3.Location = New System.Drawing.Point(357, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 78)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        '
        'lstbloodg
        '
        Me.lstbloodg.FormattingEnabled = True
        Me.lstbloodg.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.lstbloodg.Location = New System.Drawing.Point(17, 40)
        Me.lstbloodg.Name = "lstbloodg"
        Me.lstbloodg.Size = New System.Drawing.Size(169, 21)
        Me.lstbloodg.TabIndex = 23
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblvirus)
        Me.GroupBox4.Controls.Add(Me.optpresent)
        Me.GroupBox4.Controls.Add(Me.optabsent)
        Me.GroupBox4.Location = New System.Drawing.Point(581, 193)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdmove_last)
        Me.GroupBox6.Controls.Add(Me.cmdmove_next)
        Me.GroupBox6.Controls.Add(Me.cmdmove_previous)
        Me.GroupBox6.Controls.Add(Me.cmdmove_first)
        Me.GroupBox6.Location = New System.Drawing.Point(418, 512)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(450, 61)
        Me.GroupBox6.TabIndex = 38
        Me.GroupBox6.TabStop = False
        '
        'cmdmove_last
        '
        Me.cmdmove_last.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmove_last.Location = New System.Drawing.Point(339, 19)
        Me.cmdmove_last.Name = "cmdmove_last"
        Me.cmdmove_last.Size = New System.Drawing.Size(75, 23)
        Me.cmdmove_last.TabIndex = 3
        Me.cmdmove_last.Text = ">|"
        Me.cmdmove_last.UseVisualStyleBackColor = True
        '
        'cmdmove_next
        '
        Me.cmdmove_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmove_next.Location = New System.Drawing.Point(239, 19)
        Me.cmdmove_next.Name = "cmdmove_next"
        Me.cmdmove_next.Size = New System.Drawing.Size(75, 23)
        Me.cmdmove_next.TabIndex = 2
        Me.cmdmove_next.Text = ">"
        Me.cmdmove_next.UseVisualStyleBackColor = True
        '
        'cmdmove_previous
        '
        Me.cmdmove_previous.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmove_previous.Location = New System.Drawing.Point(141, 19)
        Me.cmdmove_previous.Name = "cmdmove_previous"
        Me.cmdmove_previous.Size = New System.Drawing.Size(75, 23)
        Me.cmdmove_previous.TabIndex = 1
        Me.cmdmove_previous.Text = "<"
        Me.cmdmove_previous.UseVisualStyleBackColor = True
        '
        'cmdmove_first
        '
        Me.cmdmove_first.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmove_first.Location = New System.Drawing.Point(28, 21)
        Me.cmdmove_first.Name = "cmdmove_first"
        Me.cmdmove_first.Size = New System.Drawing.Size(75, 23)
        Me.cmdmove_first.TabIndex = 0
        Me.cmdmove_first.Text = "|<"
        Me.cmdmove_first.UseVisualStyleBackColor = True
        '
        'PREGNANCYGrid
        '
        Me.PREGNANCYGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PREGNANCYGrid.Location = New System.Drawing.Point(394, 305)
        Me.PREGNANCYGrid.Name = "PREGNANCYGrid"
        Me.PREGNANCYGrid.Size = New System.Drawing.Size(590, 180)
        Me.PREGNANCYGrid.TabIndex = 40
        '
        'cmbpid
        '
        Me.cmbpid.FormattingEnabled = True
        Me.cmbpid.Location = New System.Drawing.Point(217, 199)
        Me.cmbpid.Name = "cmbpid"
        Me.cmbpid.Size = New System.Drawing.Size(121, 21)
        Me.cmbpid.TabIndex = 41
        '
        'lbl_pytestid
        '
        Me.lbl_pytestid.AutoSize = True
        Me.lbl_pytestid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pytestid.Location = New System.Drawing.Point(31, 234)
        Me.lbl_pytestid.Name = "lbl_pytestid"
        Me.lbl_pytestid.Size = New System.Drawing.Size(56, 13)
        Me.lbl_pytestid.TabIndex = 43
        Me.lbl_pytestid.Text = "TEST ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(418, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 142)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdback)
        Me.GroupBox2.Controls.Add(Me.cmbclear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdadd)
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Location = New System.Drawing.Point(217, 593)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 58)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        '
        'cmdback
        '
        Me.cmdback.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(342, 19)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(75, 23)
        Me.cmdback.TabIndex = 6
        Me.cmdback.Text = "BACK"
        Me.cmdback.UseVisualStyleBackColor = True
        '
        'cmbclear
        '
        Me.cmbclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbclear.Location = New System.Drawing.Point(238, 19)
        Me.cmbclear.Name = "cmbclear"
        Me.cmbclear.Size = New System.Drawing.Size(75, 23)
        Me.cmbclear.TabIndex = 5
        Me.cmbclear.Text = "CLEAR"
        Me.cmbclear.UseVisualStyleBackColor = True
        '
        'cmdexit
        '
        Me.cmdexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.Location = New System.Drawing.Point(440, 19)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(75, 23)
        Me.cmdexit.TabIndex = 3
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = True
        '
        'cmdadd
        '
        Me.cmdadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.Location = New System.Drawing.Point(40, 19)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(75, 23)
        Me.cmdadd.TabIndex = 2
        Me.cmdadd.Text = "ADD"
        Me.cmdadd.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(140, 19)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 23)
        Me.cmdsave.TabIndex = 0
        Me.cmdsave.Text = "SAVE"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmbtest_id
        '
        Me.cmbtest_id.Enabled = False
        Me.cmbtest_id.Location = New System.Drawing.Point(217, 227)
        Me.cmbtest_id.Name = "cmbtest_id"
        Me.cmbtest_id.Size = New System.Drawing.Size(100, 20)
        Me.cmbtest_id.TabIndex = 46
        Me.cmbtest_id.Text = "4"
        '
        'ANC_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1028, 742)
        Me.Controls.Add(Me.cmbtest_id)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_pytestid)
        Me.Controls.Add(Me.cmbpid)
        Me.Controls.Add(Me.PREGNANCYGrid)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblpregnancy_test)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtp_name)
        Me.Controls.Add(Me.lblp_name)
        Me.Controls.Add(Me.lblp_id)
        Me.Name = "ANC_Test"
        Me.Text = "ANC_TEST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.PREGNANCYGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txthaea As System.Windows.Forms.TextBox
    Friend WithEvents txtVDRL As System.Windows.Forms.TextBox
    Friend WithEvents txtHbs As System.Windows.Forms.TextBox
    Friend WithEvents txtPPUA As System.Windows.Forms.TextBox
    Friend WithEvents txtPLBS As System.Windows.Forms.TextBox
    Friend WithEvents txtFBS As System.Windows.Forms.TextBox
    Friend WithEvents lblRUA As System.Windows.Forms.Label
    Friend WithEvents lblhaem As System.Windows.Forms.Label
    Friend WithEvents lblVDRL As System.Windows.Forms.Label
    Friend WithEvents lblHbs As System.Windows.Forms.Label
    Friend WithEvents lblRBS As System.Windows.Forms.Label
    Friend WithEvents lblPLBS As System.Windows.Forms.Label
    Friend WithEvents lblFBS As System.Windows.Forms.Label
    Friend WithEvents txtp_name As System.Windows.Forms.TextBox
    Friend WithEvents lblp_name As System.Windows.Forms.Label
    Friend WithEvents lblp_id As System.Windows.Forms.Label
    Friend WithEvents LBLbloodg As System.Windows.Forms.Label
    Friend WithEvents lblvirus As System.Windows.Forms.Label
    Friend WithEvents optpresent As System.Windows.Forms.RadioButton
    Friend WithEvents optabsent As System.Windows.Forms.RadioButton
    Friend WithEvents lblpregnancy_test As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdML As System.Windows.Forms.Button
    Friend WithEvents cmdMN As System.Windows.Forms.Button
    Friend WithEvents cmdMP As System.Windows.Forms.Button
    Friend WithEvents cmdMF As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdmove_last As System.Windows.Forms.Button
    Friend WithEvents cmdmove_next As System.Windows.Forms.Button
    Friend WithEvents cmdmove_previous As System.Windows.Forms.Button
    Friend WithEvents cmdmove_first As System.Windows.Forms.Button
    Friend WithEvents PREGNANCYGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbpid As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_pytestid As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbclear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmbtest_id As System.Windows.Forms.TextBox
    Friend WithEvents cmdback As System.Windows.Forms.Button
    Friend WithEvents lstbloodg As System.Windows.Forms.ComboBox
    Friend WithEvents txtrh As System.Windows.Forms.ComboBox
End Class
