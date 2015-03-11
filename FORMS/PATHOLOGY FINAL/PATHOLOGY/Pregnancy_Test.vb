Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Pregnancy_Test
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim sqlq As String
    Dim rowno As Integer
    Dim flagaddmodify As Integer
    Dim str As String


    Private Sub Pregnancy_Test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MyCon()
        Me.BackColor = Color.CadetBlue
        'Call my sub
        refresh11()
        DisableText()

    End Sub

    Public Sub refresh11()
        sqlq = "select * from PREGNANCY"
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
        cmbpid.Text = ds.Tables(0).Rows(rowno).Item(0)
        cmbtest_id.Text = ds.Tables(0).Rows(rowno).Item(1)
        txtp_name = ds.Tables(0).Rows(rowno).Item(2)
        txtFBS.Text = ds.Tables(0).Rows(rowno).Item(3)
        txtPLBS.Text = ds.Tables(0).Rows(rowno).Item(4)
        txtPPUA.Text = ds.Tables(0).Rows(rowno).Item(5)
        txtHbs.Text = ds.Tables(0).Rows(rowno).Item(6)
        txtVDRL.Text = ds.Tables(0).Rows(rowno).Item(7)
        txthaea.Text = ds.Tables(0).Rows(rowno).Item(8)
        txtrh.Text = ds.Tables(0).Rows(rowno).Item(9)
        lstbloodg.Text = ds.Tables(0).Rows(rowno).Item(10)
        optpresent.Text = ds.Tables(0).Rows(rowno).Item(11)
        optabsent.Text = ds.Tables(0).Rows(rowno).Item(12)
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
        End
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
        txtrh.ReadOnly = False
        

        'cboutype.Enabled = True
    End Sub

    Public Sub txtblank()
        ' cmbpid.ReadOnly = ""
        txtp_name.ReadOnly = ""
        txtFBS.ReadOnly = ""
        txtPLBS.ReadOnly = ""
        txtPPUA.ReadOnly = ""
        txtHbs.ReadOnly = ""
        txtVDRL.ReadOnly = ""
        txthaea.ReadOnly = ""
        txtrh.ReadOnly = ""
        


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

    Private Sub txtrh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrh.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtVDRL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVDRL.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub lstbloodg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstbloodg.KeyPress
        Call onlyAlphabate(e)
    End Sub

    Private Sub cmbtest_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtest_id.KeyPress
        Call onlynumbers(e)
    End Sub

   
    
    Private Sub cmdadd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If cmdadd.Enabled = True Then
            flagaddmodify = 1
            'Call onlyread()
            ' Call txtblank()

            cmdadd.Enabled = False
            cmdsave.Enabled = True
            cmddelete.Text = "CANCEL"
            cmdmodify.Enabled = False
            GroupBox1.Enabled = True '
            EnableText()
        Else
            cmdadd.Enabled = True
            cmdsave.Enabled = False
            cmddelete.Text = "ADD"
            cmdmodify.Enabled = True
            GroupBox1.Enabled = True
            'txtp_id.ReadOnly = True
            'txtp_name.ReadOnly = True
            'txtp_address.ReadOnly = True
            'txtp_age.ReadOnly = True
            'txtp_gender.ReadOnly = True
            'txtp_phone.ReadOnly = True


        End If

    End Sub

    Private Sub cmdmodify_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodify.Click
        flagaddmodify = 2

        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        cmdadd.Enabled = False
        cmdmodify.Enabled = False
        cmdsave.Enabled = True
        cmddelete.Text = "&CANCEL"
        cmbpid.Focus()
    End Sub

    Private Sub cmdsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim dr As DataRow



        '
        'Try
        If flagaddmodify = 1 Then

            If cmbpid.Text <> "" And cmbtest_id.Text <> "" And txtp_name.Text <> "" And txtFBS.Text <> "" And txtPLBS.Text = "" And txtPPUA.Text <> "" And txtHbs.Text <> "" And txtVDRL.Text <> "" And txthaea.Text <> "" And txtrh.Text <> "" And lstbloodg.Text <> "" And optpresent.Text <> "" And optabsent.Text <> "" Then
                'If 'txtuserpassword.Text <> txtreenterpassword.Text Then
                MsgBox("Renter The Passwords")
                Exit Sub
            Else

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
                dr.Item(11) = optpresent.Text
                dr.Item(12) = optabsent.Text
                ds.Tables(0).Rows.Add(dr)

            End If
            'Else
            '    MsgBox("Plz Provide proper info")
            '    Exit Sub
        Else




            dr = ds.Tables(0).Rows(rowno)
            If cmbpid.Text <> "" Then
                If cmbpid.Text <> "" Or cmbtest_id.Text <> "" Or txtp_name.Text <> "" Or txtFBS.Text <> "" Or txtPLBS.Text = "" Or txtPPUA.Text <> "" Or txtHbs.Text <> "" Or txtVDRL.Text <> "" Or txthaea.Text <> "" Or txtrh.Text <> "" Or lstbloodg.Text <> "" Or optpresent.Text <> "" Or optabsent.Text <> "" Then
                    If cmbpid.Text = cmbpid.Text Then
                        dr.BeginEdit()
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
                        dr.Item(11) = optpresent.Text
                        dr.Item(12) = optabsent.Text

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
        MsgBox("record Saved")
        refresh11()
        'Catch
        '    MsgBox("You Not allowed to perform the operation")
        'End Try
    End Sub

    Private Sub cmbclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclear.Click

    End Sub

    Private Sub cmddelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
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
        'txtp_id.ReadOnly = True
        'txtp_name.ReadOnly = True
        'txtp_address.ReadOnly = True
        'txtp_age.ReadOnly = True
        'txtp_gender.ReadOnly = True
        'txtp_phone.ReadOnly = True




    End Sub

    Private Sub cmdexit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        End
    End Sub
End Class
