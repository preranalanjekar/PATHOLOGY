Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Stool_Test
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim sqlq As String
    Dim rowno As Integer
    Dim flagaddmodify As Integer
    Dim str As String

    Private Sub lblstool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MyCon()
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdsave.Enabled = False
        cmbclear.Enabled = False
        cmdexit.Enabled = True
        cmdback.Enabled = False
        cmddelete.Enabled = False
        GroupBox3.Enabled = False

        Me.BackColor = Color.Gray
        refresh11()
        DisableText()
    End Sub
    Public Sub refresh11()
        sqlq = "select * from STOOL"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        rowno = 0
        If ds.Tables(0).Rows.Count <> 0 Then
            Call txtfill()
            STOOLGrid.DataSource = ds.Tables(0)
        End If
    End Sub
    Public Sub txtfill()
        cmbpid.Text = ds.Tables(0).Rows(rowno).Item(0)
        cmbtest_id.Text = ds.Tables(0).Rows(rowno).Item(1)
        txtp_name.Text = ds.Tables(0).Rows(rowno).Item(2)
        txtparasites.Text = ds.Tables(0).Rows(rowno).Item(3)
        txconsistency.Text = ds.Tables(0).Rows(rowno).Item(4)
        txtstarch.Text = ds.Tables(0).Rows(rowno).Item(5)
        txtblood.Text = ds.Tables(0).Rows(rowno).Item(6)
        txtreaction.Text = ds.Tables(0).Rows(rowno).Item(7)
        txtocc.Text = ds.Tables(0).Rows(rowno).Item(8)
        txtredu.Text = ds.Tables(0).Rows(rowno).Item(9)
        txtcolour.Text = ds.Tables(0).Rows(rowno).Item(10)

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
        txtparasites.Enabled = True
        txconsistency.Enabled = True
        txtstarch.Enabled = True
        txtblood.Enabled = True
        txtreaction.Enabled = True
        txtocc.Enabled = True
        txtredu.Enabled = True
        txtcolour.Enabled = True

    End Sub
    Public Sub DisableText()
        cmbpid.Enabled = False
        cmbtest_id.Enabled = False
        txtp_name.Enabled = False
        txtparasites.Enabled = False
        txconsistency.Enabled = False
        txtstarch.Enabled = False
        txtblood.Enabled = False
        txtreaction.Enabled = False
        txtocc.Enabled = False
        txtredu.Enabled = False
        txtcolour.Enabled = False

    End Sub
    

    
    


    Private Sub STOOLGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles STOOLGrid.CellContentClick

        Call txtfill()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub
    Public Sub onlyread()
        ' cmbpid.ReadOnly = False
        txtp_name.ReadOnly = False
        txtparasites.ReadOnly = False
        ' txconsistency.ReadOnly = False
        txtstarch.ReadOnly = False
        txtblood.ReadOnly = False
        txtreaction.ReadOnly = False
        txtocc.ReadOnly = False
        txtredu.ReadOnly = False
        'txtcolour.ReadOnly = False

        'cboutype.Enabled = True
    End Sub

    Public Sub txtblank()
        cmbpid.Text = ""
        txtp_name.Text = ""
        txtparasites.Text = ""
        txconsistency.Text = ""
        txtstarch.Text = ""
        txtblood.Text = ""
        txtreaction.Text = ""
        txtocc.Text = ""
        txtredu.Text = ""
        txtcolour.Text = ""



    End Sub



    Private Sub txconsistency_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub txtblood_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtblood.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtcolour_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call onlyAlphabate(e)
    End Sub

    Private Sub txtocc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtocc.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtp_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtp_name.KeyPress
        Call onlyAlphabate(e)
    End Sub

    Private Sub txtparasites_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtparasites.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtreaction_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreaction.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtredu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtredu.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtstarch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstarch.KeyPress
        Call onlynumbers(e)
    End Sub

    
    Private Sub cmbtest_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call onlynumbers(e)
    End Sub

    Private Sub cmdexit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
        MDIParent2.Show()
    End Sub

    Private Sub cmddelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
        If cmddelete.Text = "&DELETE" Then
            Dim x
            x = MsgBox("do u really want to delete records", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
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

    Private Sub cmdmodify_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodify.Click
        flagaddmodify = 2
        Call EnableText()
        GroupBox1.Enabled = True
        cmdback.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        cmdadd.Enabled = False
        cmdmodify.Enabled = False
        cmbclear.Enabled = True
        cmdsave.Enabled = True
        cmddelete.Text = "&CANCEL"
        cmbpid.Focus()
    End Sub

    Private Sub cmdsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim dr As DataRow
        sqlq = "select * from STOOL"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)



        '
        'Try
        If flagaddmodify = 1 Then

            If cmbpid.Text <> "" And cmbtest_id.Text <> "" And txtp_name.Text <> "" And txtparasites.Text <> "" And txconsistency.Text <> "" And txtstarch.Text <> "" And txtblood.Text <> "" And txtreaction.Text <> "" And txtocc.Text <> "" And txtredu.Text <> "" And txtcolour.Text <> "" Then
                dr = ds.Tables(0).NewRow
                dr.Item(0) = cmbpid.Text
                dr.Item(1) = cmbtest_id.Text
                dr.Item(2) = txtp_name.Text
                dr.Item(3) = txtparasites.Text
                dr.Item(4) = txconsistency.Text
                dr.Item(5) = txtstarch.Text
                dr.Item(6) = txtblood.Text
                dr.Item(7) = txtreaction.Text
                dr.Item(8) = txtocc.Text
                dr.Item(9) = txtredu.Text
                dr.Item(10) = txtcolour.Text
                ds.Tables(0).Rows.Add(dr)

            Else

                MsgBox("Plz Provide proper info")
                Exit Sub
            End If
        Else
            dr = ds.Tables(0).Rows(rowno)
            If cmbpid.Text <> "" Then
                If cmbpid.Text <> "" Or cmbtest_id.Text <> "" Or txtp_name.Text <> "" Or txtparasites.Text <> "" Or txconsistency.Text <> "" Or txtstarch.Text <> "" Or txtblood.Text <> "" Or txtreaction.Text <> "" Or txtocc.Text <> "" Or txtredu.Text <> "" Or txtcolour.Text <> "" Then
                    If cmbpid.Text = cmbpid.Text Then
                        dr.BeginEdit()
                        dr.Item(0) = cmbpid.Text
                        dr.Item(1) = cmbtest_id.Text
                        dr.Item(2) = txtp_name.Text
                        dr.Item(3) = txtparasites.Text
                        dr.Item(4) = txconsistency.Text
                        dr.Item(5) = txtstarch.Text
                        dr.Item(6) = txtblood.Text
                        dr.Item(7) = txtreaction.Text
                        dr.Item(8) = txtocc.Text
                        dr.Item(9) = txtredu.Text
                        dr.Item(10) = txtcolour.Text
                        ' ds.Tables(0).Rows.Add(dr)
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
        MsgBox("record Saved")
        refresh11()
        cmdadd.Enabled = False
        cmdmodify.Enabled = False
        cmdback.Enabled = True
        cmbclear.Enabled = False

       
    End Sub

    Private Sub cmdadd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If cmdadd.Enabled = True Then
            flagaddmodify = 1
            'Call onlyread()
            Call txtblank()
            Call combfill()
            Call cmbtes()

            cmdadd.Enabled = False
            cmdsave.Enabled = True
            cmdback.Enabled = True
            cmddelete.Text = "CANCEL"
            cmdmodify.Enabled = False
            cmbclear.Enabled = True
            GroupBox1.Enabled = True
            GroupBox3.Enabled = False
            EnableText()
        Else
            cmdadd.Enabled = True
            cmdsave.Enabled = False
            cmddelete.Text = "ADD"
            cmdmodify.Enabled = False
            GroupBox1.Enabled = True
            GroupBox3.Enabled = True
            cmbclear.Enabled = True
           


        End If

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

    Private Sub cmbclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclear.Click
        cmbpid.Text = ""
        txtp_name.Text = ""
        txtparasites.Text = ""
        txconsistency.Text = ""
        txtstarch.Text = ""
        txtblood.Text = ""
        txtreaction.Text = ""
        txtocc.Text = ""
        txtredu.Text = ""
        txtcolour.Text = ""
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
        sqlq = "select * from STOOL where p_id=" & cmbpid.Text
        daa = New SqlDataAdapter(sqlq, con)
        dss = New DataSet
        daa.Fill(dss)
        If Not dss.Tables(0).Rows.Count > 0 Then
        Else
            MsgBox("Already present")
        End If
    End Sub
End Class
