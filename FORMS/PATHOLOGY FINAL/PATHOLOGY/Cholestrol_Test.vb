Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Cholestrol_Test
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim sqlq As String
    Dim rowno As Integer
    Dim flagaddmodify As Integer
    Dim str As String

    Private Sub Cholestrol_Test_Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MyCon()
        Me.BackColor = Color.Gray
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdexit.Enabled = True
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        cmdback.Enabled = True
        cmdback_Click(Nothing, Nothing)
        DisableText()
        'sqlq = "select * from CHOLESTROL"
        'da = New SqlDataAdapter(sqlq, con)
        'ds = New DataSet
        'da.Fill(ds)
        'rowno = 0
        refresh11()

    End Sub
    Public Sub refresh11()
        sqlq = "select * from CHOLESTROL"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        rowno = 0
        If ds.Tables(0).Rows.Count <> 0 Then
            Call txtfill()
            CHOLESTROLGrid.DataSource = ds.Tables(0)
        End If
    End Sub


    Public Sub txtfill()
        cmbpid.Text = ds.Tables(0).Rows(rowno).Item(0)
        cmbtest_id.Text = ds.Tables(0).Rows(rowno).Item(1)
        txtp_name.Text = ds.Tables(0).Rows(rowno).Item(2) '.ToString
        txtuv.Text = ds.Tables(0).Rows(rowno).Item(3)
        txttri.Text = ds.Tables(0).Rows(rowno).Item(4)
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

    Private Sub cmdadd_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If cmdadd.Enabled = True Then
            flagaddmodify = 1
            'Call onlyread()
            Call txtblank()
            Call combfill()
            Call cmbtes()
            cmdadd.Enabled = False
            cmdsave.Enabled = True
            cmddelete.Text = "CANCEL"
            cmdback.Enabled = True

            cmdmodify.Enabled = False
            GroupBox1.Enabled = True
            GroupBox2.Enabled = False
            EnableText()
        Else
            cmdadd.Enabled = True
            cmdsave.Enabled = True
            cmddelete.Text = "ADD"
            cmdmodify.Enabled = True
            GroupBox1.Enabled = True
           


        End If
    End Sub



    Public Sub EnableText()
        cmbpid.Enabled = True
        txtp_name.Enabled = True
        txtuv.Enabled = True
        txttri.Enabled = True
        cmbtest_id.Enabled = True

    End Sub


    Public Sub DisableText()
        cmbpid.Enabled = False
        txtp_name.Enabled = False
        txtuv.Enabled = False
        txttri.Enabled = False
        cmbtest_id.Enabled = False
        cmddelete.Enabled = False
        cmdsave.Enabled = False
        cmbclear.Enabled = False
        

    End Sub
    Private Sub cmdsave_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim dr As DataRow

        sqlq = "select * from CHOLESTROL"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)

        If flagaddmodify = 1 Then

            If cmbpid.Text <> "" And cmbtest_id.Text <> "" And txtp_name.Text <> "" And txtuv.Text <> "" And txttri.Text <> "" Then
                dr = ds.Tables(0).NewRow
                dr.Item(0) = cmbpid.Text
                dr.Item(1) = cmbtest_id.Text
                dr.Item(2) = txtp_name.Text
                dr.Item(3) = txtuv.Text
                dr.Item(4) = txttri.Text
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
                If cmbpid.Text <> "" Or cmbtest_id.Text <> "" Or txtp_name.Text <> "" Or txtuv.Text <> "" Or txttri.Text <> " " Or cmbtest_id.Text <> " " Then
                    If cmbpid.Text = cmbpid.Text Then
                        dr.BeginEdit()
                        dr.Item(0) = cmbpid.Text
                        dr.Item(1) = cmbtest_id.Text
                        dr.Item(2) = txtp_name.Text
                        dr.Item(3) = txtuv.Text
                        dr.Item(4) = txttri.Text
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
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmbclear.Enabled = True
        cmddelete.Text = "&DELETE"
        cmdback.Enabled = True
    End Sub

    Private Sub cmdmodify_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodify.Click
        flagaddmodify = 2
        Call EnableText()
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        cmdadd.Enabled = False
        cmdmodify.Enabled = False
        cmdsave.Enabled = True
        cmddelete.Enabled = True
        cmddelete.Text = "&CANCEL"
        cmbclear.Enabled = True
        cmdback.Enabled = True
        cmbpid.Focus()
    End Sub

    Private Sub cmddelete_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click
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
    Private Sub CHOLESTROLGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CHOLESTROLGrid.CellContentClick
        rowno = CHOLESTROLGrid.CurrentRow.Index
        Call txtfill()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
        MDIParent2.Show()
    End Sub
    Public Sub onlyread()
        'cmbpid.ReadOnly = False
        txtp_name.ReadOnly = False
        txtuv.ReadOnly = False
        txttri.ReadOnly = False
    End Sub

    Public Sub txtblank()
        cmbpid.Text = ""
        txtp_name.Text = ""
        txtuv.Text = ""
        txttri.Text = ""
    End Sub
    Private Sub cmbpid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbpid.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtp_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtp_name.KeyPress
        Call onlyAlphabate(e)
    End Sub

    Private Sub txtuv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuv.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txttri_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttri.KeyPress
        Call onlynumbers(e)
    End Sub
    Private Sub cmbclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclear.Click
        txtp_name.Text = ""
        txtuv.Text = ""
        txttri.Text = ""
        cmbpid.Text = " "
        cmdadd.Enabled = True
    End Sub

    Private Sub cmbtest_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call onlynumbers(e)
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
        'ds = New DataSet
        Dim dst As New DataSet
        da.Fill(dst)
        Dim i As Integer
        For i = 0 To dst.Tables(0).Rows.Count - 1
            ' cmbtest_id.Item.Add(ds.Tables(0).Rows(i).Item(0))
        Next
        'sqlq = "select test_id from TEST"
        'da = New SqlDataAdapter(sqlq, con)
        'ds = New DataSet
        'da.Fill(ds)
        'Dim i As Integer
        'For i = 0 To ds.Tables(0).Rows.Count - 1
        '    'cmbtest_id.items.Add(ds.Tables(0).Rows(i).Item(0))
        'Next
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
        GroupBox2.Enabled = True
        GroupBox1.Enabled = True
        cmdsave.Enabled = False
        cmddelete.Enabled = False
        cmbclear.Enabled = False
    End Sub

    
    Private Sub cmbpid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbpid.LostFocus
        Dim daa As SqlDataAdapter
        Dim dss As DataSet
        Dim sqlq As String
        sqlq = "select * from CHOLESTROL where p_id=" & cmbpid.Text
        daa = New SqlDataAdapter(sqlq, con)
        dss = New DataSet
        daa.Fill(dss)
        If Not dss.Tables(0).Rows.Count > 0 Then
        Else
            MsgBox("Already present")
        End If
    End Sub
End Class
