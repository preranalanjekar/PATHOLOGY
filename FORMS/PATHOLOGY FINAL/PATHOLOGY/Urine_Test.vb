Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Urine_Test
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim sqlq As String
    Dim rowno As Integer
    Dim flagaddmodify As Integer
    Dim str As String

    Private Sub lblurine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MyCon()
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdsave.Enabled = False
        cmbclear.Enabled = False
        cmdexit.Enabled = True
        cmddelete.Enabled = False
        GroupBox3.Enabled = False
        cmdback.Enabled = False

        Me.BackColor = Color.Gray
        'Call my sub
        refresh11()
        DisableText()
        cmbtest_id.Text = 8

    End Sub
    Public Sub refresh11()
        sqlq = "select * from URINE"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        rowno = 0
        If ds.Tables(0).Rows.Count <> 0 Then
            Call txtfill()
            URINEGrid.DataSource = ds.Tables(0)
        End If
    End Sub
    Public Sub txtfill()
        cmbpid.Text = ds.Tables(0).Rows(rowno).Item(0)
        cmbtest_id.Text = ds.Tables(0).Rows(rowno).Item(1)
        txtp_name.Text = ds.Tables(0).Rows(rowno).Item(2)
        txtvol.Text = ds.Tables(0).Rows(rowno).Item(3)
        txtapp.Text = ds.Tables(0).Rows(rowno).Item(4)
        txtspecific.Text = ds.Tables(0).Rows(rowno).Item(5)
        txtsugar.Text = ds.Tables(0).Rows(rowno).Item(6)
        txtbp.Text = ds.Tables(0).Rows(rowno).Item(7)
        txtbs.Text = ds.Tables(0).Rows(rowno).Item(8)
        txtcast.Text = ds.Tables(0).Rows(rowno).Item(9)
        txtucolor.Text = ds.Tables(0).Rows(rowno).Item(10)
        txtocc_blood.Text = ds.Tables(0).Rows(rowno).Item(11)
        txtualbumin.Text = ds.Tables(0).Rows(rowno).Item(12)
        txtacet.Text = ds.Tables(0).Rows(rowno).Item(13)
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
            MsgBox("You are already on last record", MsgBoxStyle.Information)
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
        txtvol.Enabled = True
        txtapp.Enabled = True
        txtspecific.Enabled = True
        txtsugar.Enabled = True
        txtbp.Enabled = True
        txtbs.Enabled = True
        txtcast.Enabled = True
        txtucolor.Enabled = True
        txtocc_blood.Enabled = True
        txtualbumin.Enabled = True
        txtacet.Enabled = True
    End Sub
    Public Sub DisableText()
        cmbpid.Enabled = False
        cmbtest_id.Enabled = False
        txtp_name.Enabled = False
        txtvol.Enabled = False
        txtapp.Enabled = False
        txtspecific.Enabled = False
        txtsugar.Enabled = False
        txtbp.Enabled = False
        txtbs.Enabled = False
        txtcast.Enabled = False
        txtucolor.Enabled = False
        txtocc_blood.Enabled = False
        txtualbumin.Enabled = False
        txtacet.Enabled = False
    End Sub
    

    
    Private Sub cmddelete_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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


    Private Sub URINEGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles URINEGrid.CellContentClick
        rowno = URINEGrid.CurrentRow.Index
        Call txtfill()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MDIParent2.Show()
    End Sub
    Public Sub onlyread()
        ' cmbpid.ReadOnly = False
        txtp_name.ReadOnly = False
        txtvol.ReadOnly = False
        ' txtapp.ReadOnly = False
        txtspecific.ReadOnly = False
        txtsugar.ReadOnly = False
        txtbp.ReadOnly = False
        txtbs.ReadOnly = False
        'txtcast.ReadOnly = False
        ' txtucolor.ReadOnly = False
        txtocc_blood.ReadOnly = False
        txtualbumin.ReadOnly = False
        txtacet.ReadOnly = False


        'cboutype.Enabled = True
    End Sub

    Public Sub txtblank()
        cmbpid.Text = ""
        txtp_name.Text = ""
        txtvol.Text = ""
        txtapp.Text = ""
        txtspecific.Text = ""
        txtsugar.Text = ""
        txtbp.Text = ""
        txtbs.Text = ""
        txtcast.Text = ""
        txtucolor.Text = ""
        txtocc_blood.Text = ""
        txtualbumin.Text = ""
        txtacet.Text = ""


    End Sub



    Private Sub cmbpid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbpid.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtacet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtacet.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtapp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call onlyAlphabate(e)
    End Sub

    Private Sub txtbp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbp.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtbs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbs.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtcast_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call onlyAlphabate(e)
    End Sub

    Private Sub txtocc_blood_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtocc_blood.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtp_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtp_name.KeyPress
        Call onlyAlphabate(e)
    End Sub

    Private Sub txtspecific_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtspecific.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtsugar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsugar.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtualbumin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtualbumin.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtucolor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call onlyAlphabate(e)
    End Sub

    Private Sub txtvol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvol.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub cmbtest_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call onlynumbers(e)
    End Sub

    Private Sub cmdadd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If cmdadd.Enabled = True Then
            flagaddmodify = 1


            Call txtblank()
            Call combfill()
            Call cmbtes()

            cmdadd.Enabled = False
            cmdsave.Enabled = True
            cmddelete.Text = "CANCEL"
            cmdmodify.Enabled = False
            GroupBox1.Enabled = True
            GroupBox3.Enabled = False
            cmbclear.Enabled = True
            cmdback.Enabled = True
            EnableText()
        Else
            cmdadd.Enabled = True
            cmdsave.Enabled = False
            cmddelete.Text = "ADD"
            cmdmodify.Enabled = False
            GroupBox1.Enabled = True
            cmbclear.Enabled = True


        End If
    End Sub

    Private Sub cmdmodify_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodify.Click
        flagaddmodify = 2

        'GroupBox1.Enabled = True
        'GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        Call EnableText()
        cmdadd.Enabled = False
        cmdmodify.Enabled = False
        cmdback.Enabled = True
        cmdsave.Enabled = True
        cmddelete.Text = "&CANCEL"
        cmbclear.Enabled = True
        cmbpid.Focus()
    End Sub

    Private Sub cmdsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim dr As DataRow
        sqlq = "select * from URINE"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)




        '
        'Try
        If flagaddmodify = 1 Then

            If cmbpid.Text <> "" And cmbtest_id.Text <> "" And txtp_name.Text <> "" And txtvol.Text <> "" And txtapp.Text <> "" And txtspecific.Text <> "" And txtsugar.Text <> "" And txtbp.Text <> "" And txtbs.Text <> "" And txtcast.Text <> "" And txtucolor.Text <> "" And txtocc_blood.Text <> "" And txtualbumin.Text <> "" And txtacet.Text <> "" Then

                dr = ds.Tables(0).NewRow
                dr.Item(0) = cmbpid.Text
                dr.Item(1) = cmbtest_id.Text
                dr.Item(2) = txtp_name.Text
                dr.Item(3) = txtvol.Text
                dr.Item(4) = txtapp.Text
                dr.Item(5) = txtspecific.Text
                dr.Item(6) = txtsugar.Text
                dr.Item(7) = txtbp.Text
                dr.Item(8) = txtbs.Text
                dr.Item(9) = txtcast.Text
                dr.Item(10) = txtucolor.Text
                dr.Item(11) = txtocc_blood.Text
                dr.Item(12) = txtualbumin.Text
                dr.Item(13) = txtacet.Text
                ds.Tables(0).Rows.Add(dr)


            Else
                MsgBox("Plz Provide proper info")
                Exit Sub
            End If
        Else



            dr = ds.Tables(0).Rows(rowno)
            If cmbpid.Text <> "" Then
                If cmbpid.Text <> "" Or cmbtest_id.Text <> "" Or txtp_name.Text <> "" Or txtvol.Text <> "" Or txtapp.Text <> "" Or txtspecific.Text <> "" Or txtsugar.Text <> "" Or txtbp.Text <> "" Or txtbs.Text <> "" Or txtcast.Text <> "" Or txtucolor.Text <> "" Or txtocc_blood.Text <> "" Or txtualbumin.Text <> "" Or txtacet.Text <> "" Then
                    If cmbpid.Text = cmbpid.Text Then
                        dr.BeginEdit()
                        dr.Item(0) = cmbpid.Text
                        dr.Item(1) = cmbtest_id.Text
                        dr.Item(2) = txtp_name.Text
                        dr.Item(3) = txtvol.Text
                        dr.Item(4) = txtapp.Text
                        dr.Item(5) = txtspecific.Text
                        dr.Item(6) = txtsugar.Text
                        dr.Item(7) = txtbp.Text
                        dr.Item(8) = txtbs.Text
                        dr.Item(9) = txtcast.Text
                        dr.Item(10) = txtucolor.Text
                        dr.Item(11) = txtocc_blood.Text
                        dr.Item(12) = txtualbumin.Text
                        dr.Item(13) = txtacet.Text
                        'ds.Tables(0).Rows.Add(dr)
                        dr.EndEdit()
                    Else
                        MsgBox("Plz check the Reentered ")
                        Exit Sub
                    End If


                End If

            End If
        End If


            Dim cb As New SqlCommandBuilder(da)
            da.Update(ds)
        MsgBox("Record Saved")
       
        cmdadd.Enabled = False
        cmdmodify.Enabled = False
        cmdback.Enabled = True
        cmbclear.Enabled = True
            refresh11()
            
    End Sub

    Private Sub cmbclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclear.Click
        cmbpid.Text = ""
        txtp_name.Text = ""
        txtvol.Text = ""
        txtapp.Text = ""
        txtspecific.Text = ""
        txtsugar.Text = ""
        txtbp.Text = ""
        txtbs.Text = ""
        txtcast.Text = ""
        txtucolor.Text = ""
        txtocc_blood.Text = ""
        txtualbumin.Text = ""
        txtacet.Text = ""

    End Sub

    Private Sub cmddelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        If cmddelete.Text = "&DELETE" Then
            Dim x
            x = MsgBox("Do u really want to delete records", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If x = vbYes Then
                ds.Tables(0).Rows(rowno).Delete()

                Dim mycmd As New SqlCommandBuilder(da)
                da.Update(ds)
                rowno = ds.Tables(0).Rows.Count - 1
                Call txtfill()
            End If
        Else
            rowno = 0
            Call txtfill()
        End If
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdsave.Enabled = True
        cmddelete.Text = "&DELETE"

    End Sub

    Private Sub cmdexit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
        MDIParent2.Show()
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
        ds = New DataSet
        da.Fill(ds)
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ' cmbtest_id.Item.Add(ds.Tables(0).Rows(i).Item(0))
        Next
    End Sub



    Private Sub cmbpid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpid.SelectedIndexChanged
        sqlq = "select p_name from PATIENT where p_id ='" & cmbpid.Text & "'"
        Dim daa As New SqlDataAdapter(sqlq, con)
        Dim dss As New DataSet
        daa.Fill(dss)
        txtp_name.Text = dss.Tables(0).Rows(0).Item(0).ToString
    End Sub

    
    Private Sub cmdback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdback.Click
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmbclear.Enabled = False
        cmddelete.Enabled = True
        cmdsave.Enabled = False
    End Sub
    Private Sub cmbpid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbpid.LostFocus
        Dim daa As SqlDataAdapter
        Dim dss As DataSet
        Dim sqlq As String
        sqlq = "select * from URINE where p_id=" & cmbpid.Text
        daa = New SqlDataAdapter(sqlq, con)
        dss = New DataSet
        daa.Fill(dss)
        If Not dss.Tables(0).Rows.Count > 0 Then
        Else
            MsgBox("Already present")
        End If
    End Sub
End Class

