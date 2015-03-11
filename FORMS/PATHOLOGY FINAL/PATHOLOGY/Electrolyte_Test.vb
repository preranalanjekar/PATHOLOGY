Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Electrolyte_Test
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim sqlq As String
    Dim rowno As Integer
    Dim flagaddmodify As Integer
    Dim str As String



    Public Sub refresh11()
        sqlq = "select * from ELECTROLYTE"
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
        Try
            cmbpid.Text = ds.Tables(0).Rows(rowno).Item(0)
            cmbtest_id.Text = ds.Tables(0).Rows(rowno).Item(1)
            txtp_name.Text = ds.Tables(0).Rows(rowno).Item(2)
            txtsodium.Text = ds.Tables(0).Rows(rowno).Item(3)
            txtpotassium.Text = ds.Tables(0).Rows(rowno).Item(4)
            txtchloride.Text = ds.Tables(0).Rows(rowno).Item(5)
            txtsod.Text = ds.Tables(0).Rows(rowno).Item(6)
        Catch

        End Try

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
        Try
            rowno = rowno + 1
            If rowno > ds.Tables(0).Rows.Count - 1 Then
                rowno = ds.Tables(0).Rows.Count - 1
                MsgBox("you are already on last record", MsgBoxStyle.Information)
            End If
            Call txtfill()
        Catch
        End Try
    End Sub


    Private Sub cmdML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdML.Click
        Try
            rowno = ds.Tables(0).Rows.Count - 1
            Call txtfill()
        Catch

        End Try
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
        cmbpid.Text = ""
        txtp_name.Text = ""
        txtsodium.Text = ""
        txtpotassium.Text = ""
        txtchloride.Text = ""
        txtsod.Text = ""


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
            'cmddelete.Enabled = True
            'mddelete.Text = "CANCEL"
            cmbclear.Enabled = True
            GroupBox1.Enabled = True
            GroupBox3.Enabled = True
            cmdback.Enabled = True
            EnableText()
        Else
            cmdadd.Enabled = True
            cmdsave.Enabled = False
            ' cmddelete.Text = "ADD"
            'cmdmodify.Enabled = False
            ' GroupBox1.Enabled = True
            'GroupBox3.Enabled = True
            


        End If

    End Sub

    Private Sub cmdexit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
        MDIParent2.Show()
    End Sub

    'Private Sub cmddelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cmddelete.Text = "&DELETE" Then
    '        Dim x
    '        x = MsgBox("Do u really want to delete records", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
    '        If x = vbYes Then
    '            ds.Tables(0).Rows(rowno).Delete()

    '            Dim mycmd As New SqlCommandBuilder(da)
    '            da.Update(ds)
    '            rowno = ds.Tables(0).Rows.Count - 1
    '            Call txtfill()

    '            refresh11()
    '        End If
    '    Else
    '        rowno = 0


    '        GroupBox1.Enabled = True
    '        GroupBox2.Enabled = True
    '        cmdadd.Enabled = True
    '        'cmdmodify.Enabled = True
    '        cmdsave.Enabled = True
    '        'cmddelete.Text = "&DELETE"
    '    End If




    'End Sub

    Private Sub cmbclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclear.Click
        cmbpid.Text = " "
        txtp_name.Text = " "
        txtsodium.Text = " "
        txtpotassium.Text = " "
        txtchloride.Text = " "
        txtsod.Text = " "

    End Sub

    Private Sub cmdsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click


        Dim dr As DataRow

        sqlq = "select * from ELECTROLYTE"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)

        If flagaddmodify = 1 Then

            If cmbpid.Text <> "" And cmbtest_id.Text <> "" And txtp_name.Text <> "" And txtsodium.Text <> "" And txtpotassium.Text <> "" And txtchloride.Text <> "" And txtsod.Text <> "" Then
                dr = ds.Tables(0).NewRow
                dr.Item(0) = cmbpid.Text
                dr.Item(1) = cmbtest_id.Text
                dr.Item(2) = txtp_name.Text
                dr.Item(3) = txtsodium.Text
                dr.Item(4) = txtpotassium.Text
                dr.Item(5) = txtchloride.Text
                dr.Item(6) = txtsod.Text
                ds.Tables(0).Rows.Add(dr)

                'Dim sqlq As String
                'sqlq = "insert into cholestrol values(" & cmbpid.Text & "," & cmbtest_id.Text & ",'" & txtp_name.Text & "'," & txtuv.Text & "," & txttri.Text & ")"
                'da = New SqlDataAdapter(sqlq, con)
                'ds = New DataSet
                'da.Fill(ds)

            Else
                MsgBox("PLZ PROVIDE PROPER INFO")
                Exit Sub
            End If

        Else




            dr = ds.Tables(0).Rows(rowno)
            If cmbpid.Text <> "" Then
                If cmbpid.Text <> "" Or cmbtest_id.Text <> "" Or txtp_name.Text <> "" Or txtsodium.Text <> "" Or txtpotassium.Text <> " " Or txtchloride.Text <> " " Or txtsod.Text Then
                    If cmbpid.Text = cmbpid.Text Then
                        dr.BeginEdit()
                        dr.Item(0) = cmbpid.Text
                        dr.Item(1) = cmbtest_id.Text
                        dr.Item(2) = txtp_name.Text
                        dr.Item(3) = txtsodium.Text
                        dr.Item(4) = txtpotassium.Text
                        dr.Item(5) = txtchloride.Text
                        dr.Item(6) = txtsod.Text
                        ' ds.Tables(0).Rows.Add(dr)
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
        MsgBox("record Saved")
        refresh11()
        cmdadd.Enabled = True
        'cmdmodify.Enabled = True
        cmbclear.Enabled = True
        'cmddelete.Text = "&DELETE"
        cmdback.Enabled = True





























        'sqlq = "insert into ELECTROLYTE values(" & cmbpid.Text & "," & cmbtest_id.Text & ",'" & txtp_name.Text & "'," & txtsodium.Text & "," & txtpotassium.Text & "," & txtchloride.Text & "," & txtsod.Text & ")"
        'da = New SqlDataAdapter(sqlq, con)
        'ds = New DataSet
        'da.Fill(ds)
        'MsgBox("Record is saved")

        ''If cmbpid.Text = " " & cmbtest_id.Text = " " & txtp_name.Text = " " & txtsodium.Text = " " & txtpotassium.Text = " " & txtchloride.Text = " " & txtsod.Text = " " Then
        ''    MsgBox("plz provide info properly", MsgBoxStyle.Information)
        ''End If
        'cmdadd.Enabled = False
        ''cmdmodify.Enabled = False
        'cmdback.Enabled = True
        ''cmddelete.Enabled = False
    End Sub

    'Private Sub cmdmodify_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    flagaddmodify = 2
    '    Call EnableText()
    '    GroupBox1.Enabled = True
    '    cmdback.Enabled = True
    '    GroupBox2.Enabled = True
    '    GroupBox3.Enabled = True
    '    cmdadd.Enabled = False
    '    'cmdmodify.Enabled = False
    '    cmbclear.Enabled = True
    '    cmdsave.Enabled = True
    '    'cmddelete.Text = "&CANCEL"
    '    cmbpid.Focus()
    'End Sub



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
        'ds = New DataSet
        Dim dst As New DataSet
        da.Fill(dst)
        Dim i As Integer
        For i = 0 To dst.Tables(0).Rows.Count - 1
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



    Private Sub Electrolyte_Test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MyCon()
        GroupBox3.Enabled = True
        GroupBox1.Enabled = False
        'cmddelete.Enabled = False
        'cmdmodify.Enabled = True
        cmdsave.Enabled = False
        cmdadd.Enabled = True
        cmdexit.Enabled = True
        cmdback.Enabled = False




        Me.BackColor = Color.Gray
        'Call my sub
        refresh11()
        DisableText()
    End Sub

    Private Sub cmdback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdback.Click
        cmdadd.Enabled = True
        GroupBox1.Enabled = False
        'cmdmodify.Enabled = True
        cmbclear.Enabled = True
        cmdsave.Enabled = False
    End Sub
    Private Sub cmbpid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbpid.LostFocus
        Dim daa As SqlDataAdapter
        Dim dss As DataSet
        Dim sqlq As String
        sqlq = "select * from ELECTROLYTE where p_id=" & cmbpid.Text
        daa = New SqlDataAdapter(sqlq, con)
        dss = New DataSet
        daa.Fill(dss)
        If Not dss.Tables(0).Rows.Count > 0 Then
        Else
            MsgBox("Already present")
        End If
    End Sub
End Class