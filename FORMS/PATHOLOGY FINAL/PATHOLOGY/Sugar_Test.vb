Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Sugar_Test
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim sqlq As String
    Dim rowno As Integer
    Dim flagaddmodify As Integer
    Dim str As String

    Private Sub Sugar_Test_Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MyCon()
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdsave.Enabled = False
        cmbclear.Enabled = False
        cmdexit.Enabled = True
        cmddelete.Enabled = False
        cmdback.Enabled = False
        GroupBox3.Enabled = False


        Me.BackColor = Color.Gray
        refresh11()
        DisableText()

    End Sub
    Public Sub refresh11()
        sqlq = "select * from SUGAR"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        rowno = 0
        If ds.Tables(0).Rows.Count <> 0 Then
            Call txtfill()
            SUGARGrid.DataSource = ds.Tables(0)
        End If
    End Sub


    Public Sub txtfill()
        cmbpid.Text = ds.Tables(0).Rows(rowno).Item(0)
        cmbtest_id.Text = ds.Tables(0).Rows(rowno).Item(1)
        txtp_name.Text = ds.Tables(0).Rows(rowno).Item(2)
        txtFBS.Text = ds.Tables(0).Rows(rowno).Item(3)
        txtPLBS.Text = ds.Tables(0).Rows(rowno).Item(4)
        txtPPUA.Text = ds.Tables(0).Rows(rowno).Item(5)
        txtRBS.Text = ds.Tables(0).Rows(rowno).Item(6)
        txtFUS.Text = ds.Tables(0).Rows(rowno).Item(7)
        txtPPUS.Text = ds.Tables(0).Rows(rowno).Item(8)
        txtRUA.Text = ds.Tables(0).Rows(rowno).Item(9)

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
        txtFBS.Enabled = True
        txtPLBS.Enabled = True
        txtPPUA.Enabled = True
        txtRBS.Enabled = True
        txtFUS.Enabled = True
        txtPPUS.Enabled = True
        txtRUA.Enabled = True

    End Sub


    Public Sub DisableText()
        cmbpid.Enabled = False
        cmbtest_id.Enabled = False
        txtp_name.Enabled = False
        txtFBS.Enabled = False
        txtPLBS.Enabled = False
        txtPPUA.Enabled = False
        txtRBS.Enabled = False
        txtFUS.Enabled = False
        txtPPUS.Enabled = False
        txtRUA.Enabled = False

    End Sub
    Private Sub SUGARGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SUGARGrid.CellContentClick
        rowno = SUGARGrid.CurrentRow.Index
        Call txtfill()
    End Sub

    
    Public Sub onlyread()
        'cmbpid .ReadOnly = False
        txtp_name.ReadOnly = False
        txtFBS.ReadOnly = False
        txtPLBS.ReadOnly = False
        txtPPUA.ReadOnly = False
        txtRBS.ReadOnly = False
        txtFUS.ReadOnly = False
        txtPPUS.ReadOnly = False
        txtRUA.ReadOnly = False
    End Sub

    Public Sub txtblank()
        cmbpid.Text = ""
        txtp_name.Text = ""
        txtFBS.Text = ""
        txtPLBS.Text = ""
        txtPPUA.Text = ""
        txtRBS.Text = ""
        txtFUS.Text = ""
        txtPPUS.Text = ""
        txtRUA.Text = ""

    End Sub

    Private Sub cmbpid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbpid.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtFBS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFBS.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtFUS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFUS.KeyPress
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

    Private Sub txtPPUS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPPUS.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtRBS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRBS.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtRUA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRUA.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub lbltestid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltestid.Click

    End Sub

    Private Sub cmbtest_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call onlynumbers(e)
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
            cmddelete.Text = "CANCEL"
            cmdmodify.Enabled = False
            cmdback.Enabled = True
            GroupBox1.Enabled = True
            GroupBox3.Enabled = False
            EnableText()
        Else
            cmdadd.Enabled = True
            cmdsave.Enabled = False
            cmddelete.Text = "ADD"
            cmdmodify.Enabled = False
            GroupBox1.Enabled = True
            cmdback.Enabled = False
            End If
    End Sub

    Private Sub cmdmodify_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodify.Click
        flagaddmodify = 2
        Call EnableText()
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        cmdadd.Enabled = False
        cmdmodify.Enabled = False
        cmdback.Enabled = True
        cmdsave.Enabled = True
        cmddelete.Enabled = True
        cmddelete.Text = "&CANCEL"
        cmbclear.Enabled = True
        cmbpid.Focus()
    End Sub

    Private Sub cmdsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim dr As DataRow

        sqlq = "select * from SUGAR"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)



        If flagaddmodify = 1 Then

            If cmbpid.Text <> "" And cmbtest_id.Text <> "" And txtp_name.Text <> "" And txtFBS.Text <> "" And txtPLBS.Text <> "" And txtPPUA.Text <> "" And txtRBS.Text <> "" And txtFUS.Text <> "" And txtPPUA.Text <> "" And txtRUA.Text <> "" Then

                dr = ds.Tables(0).NewRow
                dr.Item(0) = cmbpid.Text
                dr.Item(1) = cmbtest_id.Text
                dr.Item(2) = txtp_name.Text
                dr.Item(3) = txtFBS.Text
                dr.Item(4) = txtPLBS.Text
                dr.Item(5) = txtPPUA.Text
                dr.Item(6) = txtRBS.Text
                dr.Item(7) = txtFUS.Text
                dr.Item(8) = txtPPUS.Text
                dr.Item(9) = txtRUA.Text
                ds.Tables(0).Rows.Add(dr)

            Else

                MsgBox("Plz provide proper info")
                Exit Sub
            End If
        Else



            dr = ds.Tables(0).Rows(rowno)
            If cmbpid.Text <> "" Then
                If cmbpid.Text <> "" Or cmbtest_id.Text <> "" Or txtp_name.Text <> "" Or txtFBS.Text <> "" Or txtPLBS.Text <> "" Or txtPPUA.Text <> "" Or txtRBS.Text <> "" Or txtFUS.Text <> "" Or txtPPUA.Text <> "" Or txtRUA.Text <> "" Then
                    If cmbpid.Text = cmbpid.Text Then
                        dr.BeginEdit()
                        dr.Item(0) = cmbpid.Text
                        dr.Item(1) = cmbtest_id.Text
                        dr.Item(2) = txtp_name.Text
                        dr.Item(3) = txtFBS.Text
                        dr.Item(4) = txtPLBS.Text
                        dr.Item(5) = txtPPUA.Text
                        dr.Item(6) = txtRBS.Text
                        dr.Item(7) = txtFUS.Text
                        dr.Item(8) = txtPPUS.Text
                        dr.Item(9) = txtRUA.Text
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
        MsgBox("Record Saved")
        cmdadd.Enabled = False
        cmdmodify.Enabled = False
        cmbclear.Enabled = True
        cmdback.Enabled = True
            refresh11()
        
    End Sub

    Private Sub cmbclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclear.Click
        cmbpid.Text = ""
        txtp_name.Text = ""
        txtFBS.Text = ""
        txtPLBS.Text = ""
        txtPPUA.Text = ""
        txtRBS.Text = ""
        txtFUS.Text = ""
        txtPPUS.Text = ""
        txtRUA.Text = ""
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
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdsave.Enabled = True
        cmddelete.Text = "&DELETE"

    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
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
        sqlq = "select * from SUGAR where p_id=" & cmbpid.Text
        daa = New SqlDataAdapter(sqlq, con)
        dss = New DataSet
        daa.Fill(dss)
        If Not dss.Tables(0).Rows.Count > 0 Then
        Else
            MsgBox("Already present")
        End If
    End Sub
End Class