Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data

Public Class MDIParent2

    Private Sub PATIENTRECORDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PATIENTRECORDToolStripMenuItem.Click
        Patient_Record.Show()
    End Sub

    Private Sub STAFFRECORDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STAFFRECORDToolStripMenuItem.Click
        Staff_Record.Show()
    End Sub

    Private Sub TESTRECORDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TESTRECORDToolStripMenuItem.Click
        Test_Record.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frmReports.Show()
    End Sub

    

    Private Sub CHOLESTROLToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHOLESTROLToolStripMenuItem.Click
        Cholestrol_Test.Show()


    End Sub

    Private Sub HAEMOTOLOGYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HAEMOTOLOGYToolStripMenuItem.Click
        Haemotology_Test.Show()

    End Sub

    Private Sub KIDNEYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KIDNEYToolStripMenuItem.Click
        Kidney_Test.Show()

    End Sub

    Private Sub ANCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ANCToolStripMenuItem.Click
        ANC_Test.Show()

    End Sub

    Private Sub ELECTROLYTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ELECTROLYTEToolStripMenuItem.Click
        Electrolyte_Test.Show()


    End Sub

    Private Sub STOOLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOOLToolStripMenuItem.Click
        Stool_Test.Show()


    End Sub

    Private Sub SUGARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUGARToolStripMenuItem.Click
        Sugar_Test.Show()

    End Sub

    Private Sub URINEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles URINEToolStripMenuItem.Click
        Urine_Test.Show()
    End Sub

    Private Sub PROTIENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROTIENToolStripMenuItem.Click
        Protien_Test.Show()

    End Sub

    

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Call MyCon()
    '    Dim sqlq As String
    '    Dim da As SqlDataAdapter
    '    Dim ds As DataSet
    '    sqlq = "select count(*) from patient where p_date=" & Now.Date.ToShortDateString() & ""
    '    da = New SqlDataAdapter(sqlq, con)
    '    ds = New DataSet
    '    da.Fill(ds)
    '    TextBox1.Text = ds.Tables(0).Rows(0).Item(0)
    '  End Sub

    Private Sub COUNTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COUNTToolStripMenuItem.Click
        frmCount.Show()
        '    Call MyCon()
        '    Dim sqlq As String
        '    Dim da As SqlDataAdapter
        '    Dim ds As DataSet
        '    sqlq = "select count(*) from patient where p_date=" & Now.Date.ToShortDateString() & ""
        '    da = New SqlDataAdapter(sqlq, con)
        '    ds = New DataSet
        '    da.Fill(ds)
        '    TextBox1.Text = ds.Tables(0).Rows(0).Item(0)
    End Sub

    Private Sub MDIParent2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class