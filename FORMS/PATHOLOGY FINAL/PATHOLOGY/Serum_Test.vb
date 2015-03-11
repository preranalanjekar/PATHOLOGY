Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Serum_Test
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim sqlq As String
    Dim rowno As Integer
    Dim flagaddmodify As Integer
    Dim str As String


    
    Public Sub refresh11()
        sqlq = "select * from SERUM"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        rowno = 0
        If ds.Tables(0).Rows.Count <> 0 Then
            Call txtfill()
            SERUMGrid.DataSource = ds.Tables(0)
        End If
    End Sub


    Public Sub txtfill()
        cmbpid.Text = ds.Tables(0).Rows(rowno).Item(0)
        cmbtest_id.Text = ds.Tables(0).Rows(rowno).Item(1)
        txtp_name = ds.Tables(0).Rows(rowno).Item(2)
        txtsodium.Text = ds.Tables(0).Rows(rowno).Item(3)
        txtpotassium.Text = ds.Tables(0).Rows(rowno).Item(4)
        txtchloride.Text = ds.Tables(0).Rows(rowno).Item(5)
        txtsod.Text = ds.Tables(0).Rows(rowno).Item(6)
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
        txtsodium.Enabled = True
        txtpotassium.Enabled = True
        txtchloride.Enabled = True
        txtsod.Enabled = True

    End Sub


    Public Sub DisableText()
        cmbpid.Enabled = False
        cmbtest_id.Enabled = False
        txtp_name.Enabled = False
        txtsodium.Enabled = False
        txtpotassium.Enabled = False
        txtchloride.Enabled = False
        txtsod.Enabled = False


    End Sub
    

    


    


    Private Sub SERUMGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SERUMGrid.CellContentClick
        rowno = SERUMGrid.CurrentRow.Index
        Call txtfill()
    End Sub

    
    Public Sub onlyread()
        'cmbpid .ReadOnly = False
        txtp_name.ReadOnly = False
        txtsodium.ReadOnly = False
        txtpotassium.ReadOnly = False
        txtchloride.ReadOnly = False
        txtsod.ReadOnly = False

        'cboutype.Enabled = True
    End Sub

    Public Sub txtblank()
        'cmbpid .ReadOnly = ""
        txtp_name.ReadOnly = ""
        txtsodium.ReadOnly = ""
        txtpotassium.ReadOnly = ""
        txtchloride.ReadOnly = ""
        txtsod.ReadOnly = ""


    End Sub

    
    Private Sub txtchloride_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchloride.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtp_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtp_name.KeyPress
        Call onlyAlphabate(e)
    End Sub

    Private Sub txtpotassium_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpotassium.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtsod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsod.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtsodium_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsodium.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub Serum_Test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MyCon()

        Me.BackColor = Color.CadetBlue
        'Call my sub
        refresh11()
        DisableText()
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

    Private Sub cmdexit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        End
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

    Private Sub cmbclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclear.Click

    End Sub

    Private Sub cmdsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim dr As DataRow



        '
        'Try
        If flagaddmodify = 1 Then

            If cmbpid.Text <> "" And cmbtest_id.Text <> "" And txtp_name.Text <> "" And txtsodium.Text <> "" And txtpotassium.Text = "" And txtchloride.Text = "" And txtsod.Text = "" Then
                'If 'txtuserpassword.Text <> txtreenterpassword.Text Then
                MsgBox("Renter The Passwords")
                Exit Sub
            Else

                dr = ds.Tables(0).NewRow
                dr.Item(0) = cmbpid.Text
                dr.Item(1) = cmbtest_id.Text
                dr.Item(2) = txtp_name.Text
                dr.Item(3) = txtsodium.Text
                dr.Item(4) = txtpotassium.Text
                dr.Item(5) = txtchloride.Text
                dr.Item(6) = txtsod.Text
                ds.Tables(0).Rows.Add(dr)

            End If
            'Else
            '    MsgBox("Plz Provide proper info")
            '    Exit Sub
        Else




            dr = ds.Tables(0).Rows(rowno)
            If cmbpid.Text <> "" Then
                If cmbpid.Text <> "" Or cmbtest_id.Text <> "" Or txtp_name.Text <> "" Or txtsodium.Text <> "" Or txtpotassium.Text <> " " Or txtchloride.Text <> " " Or txtsod.Text <> " " Then
                    If cmbpid.Text = cmbpid.Text Then
                        dr.BeginEdit()
                        dr.Item(0) = cmbpid.Text
                        dr.Item(1) = cmbtest_id.Text
                        dr.Item(2) = txtp_name.Text
                        dr.Item(3) = txtsodium.Text
                        dr.Item(4) = txtpotassium.Text
                        dr.Item(5) = txtchloride.Text
                        dr.Item(6) = txtsod.Text
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
End Class