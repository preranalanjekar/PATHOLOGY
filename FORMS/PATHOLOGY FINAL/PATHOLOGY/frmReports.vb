Imports CrystalDecisions
Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmReports
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim sqlq As String

    Private Sub btnanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanc.Click
        flagreport = 1
        LoadReport.Show()
    End Sub
    Private Sub cmdCholestrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCholestrol.Click
        flagreport = 2
        LoadReport.Show()
    End Sub

    Private Sub cmdHaemotology_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHaemotology.Click
        flagreport = 7
        LoadReport.Show()

    End Sub

    Private Sub cmdKidney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKidney.Click
        flagreport = 5
        LoadReport.Show()

    End Sub

    Private Sub cmdProtien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProtien.Click
        flagreport = 3
        LoadReport.Show()
    End Sub

    Private Sub cmdElectrolyte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdElectrolyte.Click
        flagreport = 8
        LoadReport.Show()
    End Sub

    Private Sub cmdSugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSugar.Click
        flagreport = 4
        LoadReport.Show()
    End Sub

    Private Sub cmdStool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStool.Click
        flagreport = 6
        LoadReport.Show()
    End Sub

    Private Sub cmdUrine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUrine.Click
        flagreport = 9
        LoadReport.Show()
    End Sub

    


    'Public Sub combfill()
    '    Dim daa As SqlDataAdapter
    '    Dim dss As DataSet
    '    Dim sqlq As String
    '    sqlq = "select p_id from PATIENT"
    '    daa = New SqlDataAdapter(sqlq, con)
    '    dss = New DataSet
    '    daa.Fill(dss)
    '    Dim i As Integer
    '    For i = 0 To dss.Tables(0).Rows.Count - 1
    '        cmbANC.Items.Add(dss.Tables(0).Rows(i).Item(0))
    '    Next
    'End Sub
    'Public Sub cmbtes()
    '    sqlq = "select test_id from TEST"
    '    da = New SqlDataAdapter(sqlq, con)
    '    ds = New DataSet
    '    da.Fill(ds)
    '    Dim i As Integer
    '    For i = 0 To ds.Tables(0).Rows.Count - 1
    '        '  cmbtest_id.Items.Add(ds.Tables(0).Rows(i).Item(0))
    '    Next
    'End Sub


    'Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Call cmbtes()
    '    Call combfill()
    'End Sub

    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbANC.Focus()
    End Sub

    
End Class