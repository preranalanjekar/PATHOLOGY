Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Test_Record
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim sqlq As String
    Dim rowno As Integer
    Dim flagaddmodify As Integer
    Dim str As String

    Private Sub Test_Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MyCon()
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdsave.Enabled = False
        cmdclear.Enabled = False
        cmdexit.Enabled = True
        cmdback.Enabled = False
        cmddelete.Enabled = False
        GroupBox2.Enabled = False
        GroupBox1.Enabled = True



        'Call my sub
        refresh11()
        DisableText()

    End Sub
    Public Sub refresh11()
        sqlq = "select * from TEST"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        rowno = 0
        If ds.Tables(0).Rows.Count <> 0 Then
            Call txtfill()
            TESTGrid.DataSource = ds.Tables(0)
        End If
    End Sub


    Public Sub txtfill()
        txttestid.Text = ds.Tables(0).Rows(rowno).Item(0)
        txttestname.Text = ds.Tables(0).Rows(rowno).Item(1)
        txttestdesc.Text = ds.Tables(0).Rows(rowno).Item(2)
        txtcost.Text = ds.Tables(0).Rows(rowno).Item(3)
    End Sub

    Private Sub cmdMF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMF.Click
        rowno = 0
        Call txtfill()
    End Sub


    Private Sub cmdMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMP.Click
        rowno = rowno - 1
        If rowno < 0 Then
            rowno = 0
            MsgBox("you are already on first record", MsgBoxStyle.Information)
        End If
        Call txtfill()
    End Sub


    Private Sub cmdMN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMN.Click
        rowno = rowno + 1
        If rowno > ds.Tables(0).Rows.Count - 1 Then
            rowno = ds.Tables(0).Rows.Count - 1
            MsgBox("you are already on last record", MsgBoxStyle.Information)
        End If
        Call txtfill()
    End Sub


    Private Sub cmdML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdML.Click
        rowno = ds.Tables(0).Rows.Count - 1
        Call txtfill()
    End Sub

    Private Sub btnadd_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmdadd.Enabled = True Then
            flagaddmodify = 1
            Call TestAutogen()
            Call txtblank()
            cmdclear.Enabled = True
            cmdadd.Enabled = False
            cmdsave.Enabled = True
            cmdback.Enabled = True
            cmddelete.Text = "CANCEL"
            cmdmodify.Enabled = False
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            EnableText()
        End If
    End Sub



    Public Sub EnableText()
        txttestid.Enabled = True
        txttestname.Enabled = True
        txttestdesc.Enabled = True
        txtcost.Enabled = True

    End Sub


    Public Sub DisableText()
        txttestid.Enabled = False
        txttestname.Enabled = False
        txttestdesc.Enabled = False
        txtcost.Enabled = False


    End Sub
    Private Sub cmdsave_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim dr As DataRow



        '
        'Try
        If flagaddmodify = 1 Then

            If txttestid.Text <> "" And txttestname.Text <> "" And txttestdesc.Text <> "" And txtcost.Text <> "" Then

                
                dr = ds.Tables(0).NewRow
                dr.Item(0) = txttestid.Text
                dr.Item(1) = txttestname.Text
                dr.Item(2) = txttestdesc.Text
                dr.Item(3) = txtcost.Text
                ds.Tables(0).Rows.Add(dr)

            Else
                MsgBox("Plz Provide proper info")
                Exit Sub
            End If
        Else




            dr = ds.Tables(0).Rows(rowno)
            If txttestid.Text <> "" Then
                If txttestid.Text <> "" Or txttestname.Text <> "" Or txttestdesc.Text <> "" Or txtcost.Text <> " " Then
                    If txttestid.Text = txttestid.Text Then
                        dr.BeginEdit()
                        dr.Item(0) = txttestid.Text
                        dr.Item(1) = txttestname.Text
                        dr.Item(2) = txttestdesc.Text
                        dr.Item(3) = txtcost.Text
                        'ds.Tables(0).Rows.Add(dr)
                        dr.EndEdit()
                    Else
                        MsgBox("PLZ CHECK RE-ENTERED")
                        Exit Sub
                    End If


                End If

            End If
        End If


            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds)
        MsgBox("RECORD SAVED")
            refresh11()

        cmdclear.Enabled = True
        cmdadd.Enabled = True
        cmdsave.Enabled = False
        cmddelete.Text = "CANCEL"
        cmdmodify.Enabled = True
        GroupBox3.Enabled = True
      

    End Sub

    Private Sub cmdmodify_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodify.Click
        flagaddmodify = 2


        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        txtcost.Enabled = True
        cmdadd.Enabled = False
        cmdclear.Enabled = True
        cmdmodify.Enabled = False
        cmdback.Enabled = True
        cmdsave.Enabled = True
        cmddelete.Enabled = True
        cmddelete.Text = "&DELETE"
        txttestid.Focus()
    End Sub


    Private Sub cmddelete_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        If cmddelete.Text = "&DELETE" Then
            Dim x
            x = MsgBox("Do u really want to delete records", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If x = vbYes Then
                ds.Tables(0).Rows(rowno).Delete()
            End If
            Dim mycmd As New SqlCommandBuilder(da)
            da.Update(ds)
            rowno = ds.Tables(0).Rows.Count - 1
            rowno = 0
            refresh11()
        End If

        Call txtfill()
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdsave.Enabled = True
        cmddelete.Text = "&DELETE"
        'txtp_id.ReadOnly = True
        'txtp_name.ReadOnly = True
        'txtp_address.ReadOnly = True
        'txtp_age.ReadOnly = True
        'txtp_gender.ReadOnly = True
        'txtp_phone.ReadOnly = True



    End Sub


    Private Sub TESTGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TESTGrid.CellContentClick
        rowno = TESTGrid.CurrentRow.Index
        Call txtfill()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
        MDIParent2.Show()
    End Sub
    Public Sub onlyread()
        ' lsttestid.ReadOnly = False
        txttestname.ReadOnly = False
        txttestdesc.ReadOnly = False
        txtcost.ReadOnly = False
        
        'cboutype.Enabled = True
    End Sub

    Public Sub txtblank()
        txttestid.Text = ""
        txttestname.Text = ""
        txttestdesc.Text = ""
        txtcost.Text = ""
        
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txttestid.Text = ""
        txttestname.Text = ""
        txttestdesc.Text = ""
        txtcost.Text = ""
    End Sub

    
    
    
    Private Sub txtcost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcost.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txttestdesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttestdesc.KeyPress
        Call onlyAlphabate(e)
    End Sub

    Private Sub txttestid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttestid.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txttestname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttestname.KeyPress
        Call onlyAlphabate(e)
    End Sub

    
    Private Sub cmdback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdback.Click
        Call TestAutogen()
        Call txtblank()
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdsave.Enabled = False
    End Sub
    Sub TestAutogen()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim i As Integer
        Dim sql1 As String
        Call MyCon()
        sql1 = "select * from STAFF"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        i = ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item(0)
        txttestid.Text = i + 1
    End Sub
End Class