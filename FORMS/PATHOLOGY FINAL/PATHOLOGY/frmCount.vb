Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data
Public Class frmCount

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call MyCon()
        Dim sqlq As String


        Dim da As SqlDataAdapter
        Dim ds As DataSet
        'sqlq = "select count(*) from PATIENT where  p_date=getdate()"
        sqlq = "select count(*) from patient where day(p_date)=day(getdate())"
        ' sqlq = "select * from PATIENT where p-date="& date(Now())
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        TextBox1.Text = ds.Tables(0).Rows(0).Item(0)
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call MyCon()
        Dim sqlq As String
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim tdate As Date
        Dim wdate As Date
        tdate = Date.Today.Date
        wdate = DateAdd(DateInterval.Day, -7, tdate)
        sqlq = "select count(*) from PATIENT where p_date < ='" & tdate & "' and p_date > ='" & wdate & "'"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(0)
    End Sub

    
    Private Sub frmCount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
    End Sub
End Class