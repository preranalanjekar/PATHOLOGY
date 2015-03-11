Imports CrystalDecisions
Public Class LoadReport

    Private Sub LoadReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If flagreport = 1 Then
            Dim an As New ANC
            CrystalReportViewer1.ReportSource = an
            CrystalReportViewer1.SelectionFormula = "{ANC.P_id}=" & frmReports.cmbANC.Text
            CrystalReportViewer1.Refresh()
        ElseIf flagreport = 2 Then
            Dim an As New Cholestrol
            CrystalReportViewer1.ReportSource = an
            CrystalReportViewer1.SelectionFormula = "{CHOLESTROL.p_id}=" & frmReports.cmbANC.Text
            CrystalReportViewer1.Refresh()
        ElseIf flagreport = 3 Then
            Dim an As New Protien
            CrystalReportViewer1.ReportSource = an
            CrystalReportViewer1.SelectionFormula = "{PROTIEN.p_id}=" & frmReports.cmbANC.Text
            CrystalReportViewer1.Refresh()
        ElseIf flagreport = 4 Then
            Dim an As New Sugar
            CrystalReportViewer1.ReportSource = an
            CrystalReportViewer1.SelectionFormula = "{SUGAR.p_id}=" & frmReports.cmbANC.Text
            CrystalReportViewer1.Refresh()
        ElseIf flagreport = 5 Then
            Dim an As New Kidney
            CrystalReportViewer1.ReportSource = an
            CrystalReportViewer1.SelectionFormula = "{KIDNEY.p_id}=" & frmReports.cmbANC.Text
            CrystalReportViewer1.Refresh()
        ElseIf flagreport = 6 Then
            Dim an As New Stool
            CrystalReportViewer1.ReportSource = an
            CrystalReportViewer1.SelectionFormula = "{STOOL.p_id}=" & frmReports.cmbANC.Text
            CrystalReportViewer1.Refresh()
        ElseIf flagreport = 7 Then
            Dim an As New Haemotology
            CrystalReportViewer1.ReportSource = an
            CrystalReportViewer1.SelectionFormula = "{HAEMOTOLOGY.p_id}=" & frmReports.cmbANC.Text
            CrystalReportViewer1.Refresh()
        ElseIf flagreport = 8 Then
            Dim an As New Electrolyte
            CrystalReportViewer1.ReportSource = an
            CrystalReportViewer1.SelectionFormula = "{ELECTROLYTE.p_id}=" & frmReports.cmbANC.Text
            CrystalReportViewer1.Refresh()
        ElseIf flagreport = 9 Then
            Dim an As New Urine
            CrystalReportViewer1.ReportSource = an
            CrystalReportViewer1.SelectionFormula = "{URINE.p_id}=" & frmReports.cmbANC.Text
            CrystalReportViewer1.Refresh()
        End If

    End Sub

    
End Class