Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class ANC_Test
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim sqlq As String
    Dim rowno As Integer
    Dim flagaddmodify As Integer
    Dim str As String


    Private Sub ANC_Test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MyCon()
        Me.BackColor = Color.Gray
        optabsent.Text = "ABSENT"
        optpresent.Text = "PRESENT"

        Call DisableText()
        cmdadd.Enabled = True
        'cmdmodify.Enabled = True
        cmdadd.Enabled = True
        GroupBox2.Enabled = True
        GroupBox1.Enabled = True
        cmdsave.Enabled = False
        cmdback.Enabled = False
        cmbclear.Enabled = False
        GroupBox4.Enabled = True
        GroupBox3.Enabled = True
        GroupBox6.Enabled = True

        cmdadd.Enabled = True
        'cmdmodify.Enabled = True
        cmdsave.Enabled = False
        cmbclear.Enabled = False
        cmdexit.Enabled = True
        'cmddelete.Enabled = False
        GroupBox1.Enabled = False
        GroupBox6.Enabled = True
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
        PREGNANCYGrid.Enabled = False

        DisableText()

        refresh11()

    End Sub

    Public Sub refresh11()
        sqlq = "select * from ANC"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        rowno = 0
        If ds.Tables(0).Rows.Count <> 0 Then
            Call txtfill()
            PREGNANCYGrid.DataSource = ds.Tables(0)
        End If
    End Sub
    Public Sub txtfill()
        ' Try
        cmbpid.Text = ds.Tables(0).Rows(rowno).Item(0)
        cmbtest_id.Text = ds.Tables(0).Rows(rowno).Item(1)
        txtp_name.Text = ds.Tables(0).Rows(rowno).Item(2)
        txtFBS.Text = ds.Tables(0).Rows(rowno).Item(3)
        txtPLBS.Text = ds.Tables(0).Rows(rowno).Item(4)
        txtPPUA.Text = ds.Tables(0).Rows(rowno).Item(5)
        txtHbs.Text = ds.Tables(0).Rows(rowno).Item(6)
        txtVDRL.Text = ds.Tables(0).Rows(rowno).Item(7)
        txthaea.Text = ds.Tables(0).Rows(rowno).Item(8)
        txtrh.Text = ds.Tables(0).Rows(rowno).Item(9)
        lstbloodg.Text = ds.Tables(0).Rows(rowno).Item(10)
        If ds.Tables(0).Rows(0).Item(11) = "PRESENT" Then
            optpresent.Checked = True
        Else
            optabsent.Checked = True
        End If
        ' optpresent.Text = ds.Tables(0).Rows(rowno).Item(11)
        'optabsent.Text = ds.Tables(0).Rows(rowno).Item(12)
        'Catch

        'End Try
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


    Public Sub EnableText()
        cmbpid.Enabled = True
        cmbtest_id.Enabled = True
        txtp_name.Enabled = True
        txtFBS.Enabled = True
        txtPLBS.Enabled = True
        txtPPUA.Enabled = True
        txtHbs.Enabled = True
        txtVDRL.Enabled = True
        txthaea.Enabled = True
        txtrh.Enabled = True
        lstbloodg.Enabled = True
        optpresent.Enabled = True
        optabsent.Enabled = True
    End Sub
    Public Sub DisableText()
        cmbpid.Enabled = False
        cmbtest_id.Enabled = False
        txtp_name.Enabled = False
        txtFBS.Enabled = False
        txtPLBS.Enabled = False
        txtPPUA.Enabled = False
        txtHbs.Enabled = False
        txtVDRL.Enabled = False
        txthaea.Enabled = False
        txtrh.Enabled = False
        lstbloodg.Enabled = False
        optpresent.Enabled = False
        optabsent.Enabled = False
    End Sub






    Private Sub PREGNANCYGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PREGNANCYGrid.CellContentClick
        rowno = PREGNANCYGrid.CurrentRow.Index
        Call txtfill()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        MDIParent2.Show()
    End Sub
    Public Sub onlyread()
        ' cmbpid .ReadOnly = False
        txtp_name.ReadOnly = False
        txtFBS.ReadOnly = False
        txtPLBS.ReadOnly = False
        txtPPUA.ReadOnly = False
        txtHbs.ReadOnly = False
        txtVDRL.ReadOnly = False
        txthaea.ReadOnly = False
        'txtrh.ReadOnly = False

    End Sub

    Public Sub txtblank()
        cmbpid.Text = ""
        txtp_name.Text = ""
        txtFBS.Text = ""
        txtPLBS.Text = ""
        txtPPUA.Text = ""
        txtHbs.Text = ""
        txtVDRL.Text = ""
        txthaea.Text = ""
        txtrh.Text = ""



    End Sub

    Private Sub cmbpid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbpid.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtFBS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFBS.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txthaea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthaea.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtHbs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHbs.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtp_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtp_name.KeyPress
        Call onlyAlphabate(e)
    End Sub

    Private Sub txtPLBS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPLBS.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtPPUA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPPUA.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtrh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call onlyAlphabate(e)
    End Sub

    Private Sub txtVDRL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVDRL.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub lstbloodg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call onlyAlphabate(e)
    End Sub

    Private Sub cmbtest_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call onlynumbers(e)
    End Sub



    Private Sub cmdadd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        flagaddmodify = 1
        If cmdadd.Enabled = True Then
            Call txtblank()
            Call combfill()
            Call cmbtes()
            'cmdmodify.Enabled = False
            cmdadd.Enabled = False
            cmdsave.Enabled = True
            'cmddelete.Enabled = True
            'cmddelete.Text = "CANCEL"
            GroupBox1.Enabled = True
            GroupBox6.Enabled = True
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
            PREGNANCYGrid.Enabled = True
            cmbclear.Enabled = True
            cmdback.Enabled = True
            EnableText()
        Else
            'cmdmodify.Enabled = True
            cmdadd.Enabled = True
            cmdsave.Enabled = False
            GroupBox1.Enabled = False
            GroupBox6.Enabled = False
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
            PREGNANCYGrid.Enabled = False
            cmbclear.Enabled = False
            cmdback.Enabled = False
        End If

    End Sub

    Private Sub cmdmodify_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        flagaddmodify = 2
        GroupBox1.Enabled = True
        GroupBox4.Enabled = True
        Call EnableText()
        cmbpid.Enabled = False
        GroupBox3.Enabled = True
        GroupBox6.Enabled = True
        cmdadd.Enabled = False
        'cmdmodify.Enabled = False
        cmdsave.Enabled = True
        'cmddelete.Enabled = True
        'cmddelete.Text = "&DELETE"
        cmdexit.Enabled = True
        PREGNANCYGrid.Enabled = True
        cmbclear.Enabled = True
        cmbpid.Focus()
    End Sub

    Private Sub cmdsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim dr As DataRow
        sqlq = "select * from ANC"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)




        If flagaddmodify = 1 Then

            If cmbpid.Text <> "" And cmbtest_id.Text <> "" And txtp_name.Text <> "" And txtFBS.Text <> "" And txtPLBS.Text <> "" And txtPPUA.Text <> "" And txtHbs.Text <> "" And txtVDRL.Text <> "" And txthaea.Text <> "" And txtrh.Text <> "" And lstbloodg.Text <> "" And optpresent.Text <> "" And optabsent.Text <> "" Then

                dr = ds.Tables(0).NewRow

                dr.Item(0) = cmbpid.Text
                dr.Item(1) = cmbtest_id.Text
                dr.Item(2) = txtp_name.Text
                dr.Item(3) = txtFBS.Text
                dr.Item(4) = txtPLBS.Text
                dr.Item(5) = txtPPUA.Text
                dr.Item(6) = txtHbs.Text
                dr.Item(7) = txtVDRL.Text
                dr.Item(8) = txthaea.Text
                dr.Item(9) = txtrh.Text
                dr.Item(10) = lstbloodg.Text
                Dim s As String
                If optabsent.Checked = True Then
                    dr.Item(11) = optabsent.Text
                Else
                    dr.Item(11) = optpresent.Text
                End If
                If optpresent.Checked = True Then
                    s = optpresent.Text
                Else
                    s = optabsent.Text
                End If
                ds.Tables(0).Rows.Add(dr)
            Else
                'Else
                MsgBox("PLZ PROVIDE PROPER INFORMATION", MsgBoxStyle.Information)
                Exit Sub
            End If
        Else


            ' ds.Tables(0).Rows.Add(dr)

            ' Dim s As String
            'If optpresent.Checked = True Then
            '    s = optpresent.Text
            'Else
            '    s = optabsent.Text
            'End If

            '  Else


        End If
        '  End If



        Dim cb As New SqlCommandBuilder(da)
        da.Update(ds)
        MsgBox("record Saved")
        refresh11()
        sqlq = "select * from ANC"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        PREGNANCYGrid.DataSource = ds.Tables(0)
        cmdadd.Enabled = False
        'cmdmodify.Enabled = False
        cmbclear.Enabled = False
        cmdback.Enabled = True

    End Sub

    Private Sub cmbclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclear.Click
        Call txtblank()
    End Sub

    'Private Sub cmddelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If 'cmddelete.Text = "&DELETE" Then
    '        Dim x
    '        x = MsgBox("do u really want to delete records", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
    '        If x = vbYes Then
    '            ds.Tables(0).Rows(rowno).Delete()

    '            Dim mycmd As New SqlCommandBuilder(da)
    '            da.Update(ds)
    '            rowno = ds.Tables(0).Rows.Count - 1

    '            Call txtfill()

    '        End If
    '    Else
    '        rowno = 0

    '        Call txtfill()
    '        GroupBox1.Enabled = False
    '        GroupBox2.Enabled = True
    '        cmdadd.Enabled = True
    '        'cmdmodify.Enabled = True
    '        cmdsave.Enabled = True
    '        'cmddelete.Text = "&DELETE"
    '    End If
    'End Sub

    Private Sub cmdexit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
        MDIParent2.Show()
    End Sub


    Private Sub cmdmove_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmove_first.Click
        rowno = 0
        Call txtfill()
    End Sub

    Private Sub cmdmove_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmove_previous.Click
        rowno = rowno - 1
        If rowno < 0 Then
            rowno = 0
            MsgBox("you are already on first record", MsgBoxStyle.Information)
        End If
        Call txtfill()
    End Sub

    Private Sub cmdmove_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmove_next.Click
        GroupBox1.Enabled = True
        rowno = rowno + 1
        If rowno > ds.Tables(0).Rows.Count - 1 Then
            rowno = ds.Tables(0).Rows.Count - 1
            MsgBox("you are already on last record", MsgBoxStyle.Information)
        End If
        Call txtfill()
    End Sub

    Private Sub cmdmove_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmove_last.Click
        rowno = ds.Tables(0).Rows.Count - 1
        Call txtfill()
    End Sub
    Public Sub combfill()
        Dim daa As SqlDataAdapter
        Dim dss As DataSet
        Dim sqlq As String
        sqlq = "select p_id from PATIENT"
        daa = New SqlDataAdapter(sqlq, con)
        dss = New DataSet
        daa.Fill(dss)
        Dim i As Integer
        For i = 0 To dss.Tables(0).Rows.Count - 1
            cmbpid.Items.Add(dss.Tables(0).Rows(i).Item(0))
        Next
    End Sub
    Public Sub cmbtes()
        sqlq = "select test_id from TEST"
        da = New SqlDataAdapter(sqlq, con)
        Dim dst As New DataSet
        'ds = New DataSet
        da.Fill(dst)
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ' cmbtest_id.Item.Add(ds.Tables(0).Rows(i).Item(0))
        Next
    End Sub

    Private Sub cmbpid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbpid.LostFocus
        Dim daa As SqlDataAdapter
        Dim dss As DataSet
        Dim sqlq As String
        sqlq = "select * from anc where p_id=" & cmbpid.Text
        daa = New SqlDataAdapter(sqlq, con)
        dss = New DataSet
        daa.Fill(dss)
        If Not dss.Tables(0).Rows.Count > 0 Then
        Else
            MsgBox("Already present")
        End If
    End Sub



    Private Sub cmbpid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpid.SelectedIndexChanged
        sqlq = "select p_name from PATIENT where p_id ='" & cmbpid.Text & "'"
        Dim daa As New SqlDataAdapter(sqlq, con)
        Dim dss As New DataSet
        daa.Fill(dss)
        txtp_name.Text = dss.Tables(0).Rows(0).Item(0).ToString
    End Sub

    Private Sub cmdback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdback.Click
        Call DisableText()
        cmdadd.Enabled = True
        'cmdmodify.Enabled = True
        cmdadd.Enabled = True
        GroupBox2.Enabled = True
        GroupBox1.Enabled = True
        cmdsave.Enabled = False
        'cmddelete.Enabled = False
        cmbclear.Enabled = False
        GroupBox4.Enabled = True
        GroupBox3.Enabled = True
        GroupBox6.Enabled = True

    End Sub
End Class
