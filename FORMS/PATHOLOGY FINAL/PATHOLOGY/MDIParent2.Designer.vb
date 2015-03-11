<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent2
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent2))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MASTERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PATIENTRECORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.STAFFRECORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TESTRECORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CHOLESTROLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HAEMOTOLOGYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KIDNEYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ANCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ELECTROLYTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.STOOLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SUGARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.URINEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PROTIENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.COUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 724)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(4, 0, 47, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1028, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERSToolStripMenuItem, Me.TESTToolStripMenuItem, Me.ToolStripMenuItem1, Me.COUNTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(20, 7, 0, 7)
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 38)
        Me.MenuStrip1.TabIndex = 9
        '
        'MASTERSToolStripMenuItem
        '
        Me.MASTERSToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.MASTERSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PATIENTRECORDToolStripMenuItem, Me.STAFFRECORDToolStripMenuItem, Me.TESTRECORDToolStripMenuItem})
        Me.MASTERSToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MASTERSToolStripMenuItem.Name = "MASTERSToolStripMenuItem"
        Me.MASTERSToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.MASTERSToolStripMenuItem.Text = "MASTERS"
        '
        'PATIENTRECORDToolStripMenuItem
        '
        Me.PATIENTRECORDToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.PATIENTRECORDToolStripMenuItem.Name = "PATIENTRECORDToolStripMenuItem"
        Me.PATIENTRECORDToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.PATIENTRECORDToolStripMenuItem.Text = "PATIENT RECORD"
        '
        'STAFFRECORDToolStripMenuItem
        '
        Me.STAFFRECORDToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.STAFFRECORDToolStripMenuItem.Name = "STAFFRECORDToolStripMenuItem"
        Me.STAFFRECORDToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.STAFFRECORDToolStripMenuItem.Text = "STAFF RECORD"
        '
        'TESTRECORDToolStripMenuItem
        '
        Me.TESTRECORDToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.TESTRECORDToolStripMenuItem.Name = "TESTRECORDToolStripMenuItem"
        Me.TESTRECORDToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.TESTRECORDToolStripMenuItem.Text = "TEST RECORD"
        '
        'TESTToolStripMenuItem
        '
        Me.TESTToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.TESTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CHOLESTROLToolStripMenuItem, Me.HAEMOTOLOGYToolStripMenuItem, Me.KIDNEYToolStripMenuItem, Me.ANCToolStripMenuItem, Me.ELECTROLYTEToolStripMenuItem, Me.STOOLToolStripMenuItem, Me.SUGARToolStripMenuItem, Me.URINEToolStripMenuItem, Me.PROTIENToolStripMenuItem})
        Me.TESTToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TESTToolStripMenuItem.Name = "TESTToolStripMenuItem"
        Me.TESTToolStripMenuItem.ShowShortcutKeys = False
        Me.TESTToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.TESTToolStripMenuItem.Text = "TEST"
        '
        'CHOLESTROLToolStripMenuItem
        '
        Me.CHOLESTROLToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.CHOLESTROLToolStripMenuItem.Name = "CHOLESTROLToolStripMenuItem"
        Me.CHOLESTROLToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.CHOLESTROLToolStripMenuItem.Text = "1. CHOLESTROL"
        '
        'HAEMOTOLOGYToolStripMenuItem
        '
        Me.HAEMOTOLOGYToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.HAEMOTOLOGYToolStripMenuItem.Name = "HAEMOTOLOGYToolStripMenuItem"
        Me.HAEMOTOLOGYToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.HAEMOTOLOGYToolStripMenuItem.Text = "2. HAEMOTOLOGY"
        '
        'KIDNEYToolStripMenuItem
        '
        Me.KIDNEYToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.KIDNEYToolStripMenuItem.Name = "KIDNEYToolStripMenuItem"
        Me.KIDNEYToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.KIDNEYToolStripMenuItem.Text = "3. KIDNEY"
        '
        'ANCToolStripMenuItem
        '
        Me.ANCToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.ANCToolStripMenuItem.Name = "ANCToolStripMenuItem"
        Me.ANCToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.ANCToolStripMenuItem.Text = "4. ANC"
        '
        'ELECTROLYTEToolStripMenuItem
        '
        Me.ELECTROLYTEToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.ELECTROLYTEToolStripMenuItem.Name = "ELECTROLYTEToolStripMenuItem"
        Me.ELECTROLYTEToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.ELECTROLYTEToolStripMenuItem.Text = "5. ELECTROLYTE"
        '
        'STOOLToolStripMenuItem
        '
        Me.STOOLToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.STOOLToolStripMenuItem.Name = "STOOLToolStripMenuItem"
        Me.STOOLToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.STOOLToolStripMenuItem.Text = "6. STOOL"
        '
        'SUGARToolStripMenuItem
        '
        Me.SUGARToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.SUGARToolStripMenuItem.Name = "SUGARToolStripMenuItem"
        Me.SUGARToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.SUGARToolStripMenuItem.Text = "7. SUGAR"
        '
        'URINEToolStripMenuItem
        '
        Me.URINEToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.URINEToolStripMenuItem.Name = "URINEToolStripMenuItem"
        Me.URINEToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.URINEToolStripMenuItem.Text = "8. URINE"
        '
        'PROTIENToolStripMenuItem
        '
        Me.PROTIENToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray
        Me.PROTIENToolStripMenuItem.Name = "PROTIENToolStripMenuItem"
        Me.PROTIENToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.PROTIENToolStripMenuItem.Text = "9. PROTIEN"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(93, 24)
        Me.ToolStripMenuItem1.Text = "REPORT"
        '
        'COUNTToolStripMenuItem
        '
        Me.COUNTToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COUNTToolStripMenuItem.Name = "COUNTToolStripMenuItem"
        Me.COUNTToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.COUNTToolStripMenuItem.Text = "COUNT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 38)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "APOLLO PATHOLOGY LAB"
        '
        'MDIParent2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(20.0!, 44.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.Name = "MDIParent2"
        Me.Text = "APOLLO PATHOLOGY LAB"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MASTERSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PATIENTRECORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STAFFRECORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TESTRECORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TESTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CHOLESTROLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HAEMOTOLOGYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KIDNEYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ANCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ELECTROLYTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STOOLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUGARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents URINEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PROTIENToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COUNTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
