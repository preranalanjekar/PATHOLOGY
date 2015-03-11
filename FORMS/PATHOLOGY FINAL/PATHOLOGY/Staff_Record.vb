Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Staff_Record
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim sqlq As String
    Dim rowno As Integer
    Dim flagaddmodify As Integer
    Dim str As String

    Private Sub Staff_Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MyCon()
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdsave.Enabled = False
        cmdclear.Enabled = False
        cmdexit.Enabled = True
        cmddelete.Enabled = False
        cmdback.Enabled = False
        GroupBox2.Enabled = False
        'Call my sub
        refresh11()
        DisableText()

    End Sub
    Public Sub refresh11()
        sqlq = "select * from STAFF"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        rowno = 0
        If ds.Tables(0).Rows.Count <> 0 Then
            Call txtfill()
            STAFFGrid.DataSource = ds.Tables(0)
        End If
    End Sub


    Public Sub txtfill()
        txts_id.Text = ds.Tables(0).Rows(rowno).Item(0)
        txts_name.Text = ds.Tables(0).Rows(rowno).Item(1)
        txts_address.Text = ds.Tables(0).Rows(rowno).Item(2)
        txts_salary.Text = ds.Tables(0).Rows(rowno).Item(3)
        txts_doj.Text = ds.Tables(0).Rows(rowno).Item(4)
        txts_post.Text = ds.Tables(0).Rows(rowno).Item(5)
        txts_phone.Text = ds.Tables(0).Rows(rowno).Item(6)
    End Sub

    Private Sub cmdMF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMF.Click
        rowno = 0
        Call txtfill()
    End Sub


    Private Sub cmdMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMP.Click
        rowno = rowno - 1
        If rowno < 0 Then
            rowno = 0
            MsgBox("You are already on first record", MsgBoxStyle.Information)
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

    Private Sub cmdadd_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If cmdadd.Enabled = True Then
            flagaddmodify = 1
            Call txtblank()
            Call StaffAutogen()


            cmdadd.Enabled = False
            cmdsave.Enabled = True
            ' cmddelete.Text = "CANCEL"
            cmdmodify.Enabled = False
            GroupBox1.Enabled = True
            GroupBox2.Enabled = False
            cmdback.Enabled = True
            cmdclear.Enabled = True


            EnableText()
        Else
            cmdadd.Enabled = True
            cmdsave.Enabled = False
            'cmddelete.Text = "ADD"
            cmdmodify.Enabled = False
            GroupBox2.Enabled = True
            GroupBox1.Enabled = False
            cmdback.Enabled = False
            cmdclear.Enabled = False
            

        End If
    End Sub



    Public Sub EnableText()
        txts_id.Enabled = True
        txts_name.Enabled = True
        txts_address.Enabled = True
        txts_salary.Enabled = True
        txts_doj.Enabled = True
        txts_post.Enabled = True
        txts_phone.Enabled = True

    End Sub


    Public Sub DisablEText()
        txts_id.Enabled = False
        txts_name.Enabled = False
        txts_address.Enabled = False
        txts_salary.Enabled = False
        txts_doj.Enabled = False
        txts_post.Enabled = False
        txts_phone.Enabled = False

    End Sub
    Private Sub cmdsave_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim dr As DataRow



        '
        'Try
        If flagaddmodify = 1 Then

            If txts_id.Text <> "" And txts_name.Text <> "" And txts_address.Text <> "" And txts_salary.Text <> "" And txts_doj.Text <> "" And txts_post.Text <> "" And txts_phone.Text <> "" Then
                'If 'txtuserpassword.Text <> txtreenterpassword.Text Then

               

                dr = ds.Tables(0).NewRow
                dr.Item(0) = txts_id.Text
                dr.Item(1) = txts_name.Text
                dr.Item(2) = txts_address.Text
                dr.Item(3) = txts_salary.Text
                dr.Item(4) = txts_doj.Text
                dr.Item(5) = txts_post.Text
                dr.Item(6) = txts_phone.Text
                ds.Tables(0).Rows.Add(dr)


            Else
                MsgBox("Plz Provide proper info")
                Exit Sub
            End If
        Else




            dr = ds.Tables(0).Rows(rowno)
            If txts_id.Text <> "" Then
                If txts_id.Text <> "" Or txts_name.Text <> "" Or txts_address.Text <> "" Or txts_salary.Text <> " " Or txts_doj.Text <> "" Or txts_post.Text <> "" Or txts_phone.Text <> "" Then
                    If txts_id.Text = txts_id.Text Then
                        dr.BeginEdit()
                        dr.Item(0) = txts_id.Text
                        dr.Item(1) = txts_name.Text
                        dr.Item(2) = txts_address.Text
                        dr.Item(3) = txts_salary.Text
                        dr.Item(4) = txts_doj.Text
                        dr.Item(5) = txts_post.Text
                        dr.Item(6) = txts_phone.Text
                        'ds.Tables(0).Rows.Add(dr)
                        dr.EndEdit()
                    Else
                        MsgBox("Plc check the Reentered ")
                        Exit Sub
                    End If


                End If

            End If
        End If

       

            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds)
            rowno = ds.Tables(0).Rows.Count - 1
            Call txtfill()
            STAFFGrid.DataSource = ds.Tables(0)
        MsgBox("record Saved")
        GroupBox3.Enabled = True
        GroupBox2.Enabled = True
        cmddelete.Text = "&DELETE"
        cmdadd.Enabled = False
        cmdmodify.Enabled = False
        cmdclear.Enabled = True
        cmdback.Enabled = True


        
        refresh11()
            

    End Sub

    Private Sub cmdmodify_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodify.Click
        flagaddmodify = 2
        cmdclear.Enabled = True
        cmddelete.Enabled = True
        cmdback.Enabled = True
        cmdexit.Enabled = True
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        cmdadd.Enabled = False
        cmdmodify.Enabled = False
        cmdsave.Enabled = True
        txts_id.Enabled = True
        txts_name.Enabled = True
        txts_address.Enabled = True
        txts_salary.Enabled = True
        txts_doj.Enabled = True
        txts_phone.Enabled = True
        txts_post.Enabled = True

        cmddelete.Enabled = True
        cmddelete.Text = "&CANCEL"
        txts_id.Focus()
    End Sub


    Private Sub cmddelete_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        If cmddelete.Text = "&DELETE" Then
            Dim x
            x = MsgBox("do u really want to delete records", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
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
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdsave.Enabled = True
        cmddelete.Text = "&DELETE"
       End Sub


    Private Sub STAFFGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles STAFFGrid.CellContentClick

        Call txtfill()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
        MDIParent2.Show()
    End Sub
    Public Sub onlyread()
        txts_id.ReadOnly = False
        txts_name.ReadOnly = False
        txts_address.ReadOnly = False
        txts_salary.ReadOnly = False
        txts_doj.ReadOnly = False
        'txts_post.ReadOnly = False
        txts_phone.ReadOnly = False
        'cboutype.Enabled = True
    End Sub

    Public Sub txtblank()
        txts_id.Text = ""
        txts_name.Text = ""
        txts_address.Text = ""
        txts_salary.Text = ""
        txts_doj.Text = ""
        txts_post.Text = ""
        txts_phone.Text = ""

    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txts_id.Text = ""
        txts_name.Text = ""
        txts_address.Text = ""
        txts_salary.Text = ""
        txts_doj.Text = ""
        txts_post.Text = ""
        txts_phone.Text = ""
        cmdadd.Enabled = True

    End Sub

    
    Private Sub txts_address_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txts_address.KeyPress
        Call onlyAlphabate(e)
    End Sub


    Private Sub txts_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txts_id.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txts_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txts_name.KeyPress
        Call onlyAlphabate(e)
    End Sub

    Private Sub txts_phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txts_phone.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txts_post_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call onlyAlphabate(e)
    End Sub

    Private Sub txts_salary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txts_salary.KeyPress
        Call onlynumbers(e)
    End Sub
    Sub StaffAutogen()
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
        txts_id.Text = i + 1
    End Sub

    
    
    Private Sub cmdback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdback.Click
        Call StaffAutogen()
        Call txtblank()
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdsave.Enabled = False
        cmddelete.Enabled = False
        cmdclear.Enabled = False
    End Sub
End Class