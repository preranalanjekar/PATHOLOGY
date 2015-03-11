Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Haemotology_Test
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim sqlq As String
    Dim rowno As Integer
    Dim flagaddmodify As Integer
    Dim str As String

    Private Sub Haemotology_Test_Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MyCon()
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdsave.Enabled = False
        cmbclear.Enabled = False
        cmdexit.Enabled = True
        cmddelete.Enabled = False
        GroupBox3.Enabled = False

        Me.BackColor = Color.Gray
        'Call my sub
        refresh11()
        DisableText()

    End Sub
    Public Sub refresh11()
        sqlq = "select * from HAEMOTOLOGY"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        rowno = 0
        If ds.Tables(0).Rows.Count <> 0 Then
            Call txtfill()
            HAEMOTOLOGYGrid.DataSource = ds.Tables(0)
        End If
    End Sub


    Public Sub txtfill()
        cmbpid.Text = ds.Tables(0).Rows(rowno).Item(0)
        cmbtest_id.Text = ds.Tables(0).Rows(rowno).Item(1)
        txtp_name.Text = ds.Tables(0).Rows(rowno).Item(2)
        txtneytrophil.Text = ds.Tables(0).Rows(rowno).Item(3)
        txteosinophil.Text = ds.Tables(0).Rows(rowno).Item(4)
        txtbasophil.Text = ds.Tables(0).Rows(rowno).Item(5)
        txtsmalll.Text = ds.Tables(0).Rows(rowno).Item(6)
        txtlargel.Text = ds.Tables(0).Rows(rowno).Item(7)
        txtmonocyte.Text = ds.Tables(0).Rows(rowno).Item(8)
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
        txtneytrophil.Enabled = True
        txteosinophil.Enabled = True
        txtbasophil.Enabled = True
        txtsmalll.Enabled = True
        txtlargel.Enabled = True
        txtmonocyte.Enabled = True


    End Sub


    Public Sub DisableText()
        cmbpid.Enabled = False
        cmbtest_id.Enabled = False
        txtp_name.Enabled = False
        txtneytrophil.Enabled = False
        txteosinophil.Enabled = False
        txtbasophil.Enabled = False
        txtsmalll.Enabled = False
        txtlargel.Enabled = False
        txtmonocyte.Enabled = False



    End Sub
    

    


    


    Private Sub HAEMOTOLOGYGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles HAEMOTOLOGYGrid.CellContentClick
        rowno = HAEMOTOLOGYGrid.CurrentRow.Index
        Call txtfill()
    End Sub

    
    Public Sub onlyread()
        ' cmbpid.ReadOnly = False
        txtp_name.ReadOnly = False
        txtneytrophil.ReadOnly = False
        txteosinophil.ReadOnly = False
        txtbasophil.ReadOnly = False
        txtsmalll.ReadOnly = False
        txtlargel.ReadOnly = False
        txtmonocyte.ReadOnly = False
        

        'cboutype.Enabled = True
    End Sub

    Public Sub txtblank()
        txtp_name.Text = ""
        txtneytrophil.Text = ""
        txteosinophil.Text = ""
        txtbasophil.Text = ""
        txtsmalll.Text = ""
        txtlargel.Text = ""
        txtmonocyte.Text = ""
        cmbpid.Text = " "



    End Sub

    
    Private Sub txtbasophil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbasophil.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txteosinophil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txteosinophil.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtlargel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlargel.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtmonocyte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmonocyte.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtneytrophil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtneytrophil.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtp_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtp_name.KeyPress
        Call onlyAlphabate(e)
    End Sub

    Private Sub txtsmalll_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsmalll.KeyPress
        Call onlynumbers(e)
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
            GroupBox1.Enabled = True
            cmbclear.Enabled = True
            cmdback.Enabled = True
            GroupBox3.Enabled = False
            EnableText()
        Else
            cmdadd.Enabled = True
            cmdsave.Enabled = False
            cmddelete.Text = "ADD"
            cmdmodify.Enabled = False
            GroupBox1.Enabled = True


        End If
    End Sub

    Private Sub cmdsave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim dr As DataRow

        sqlq = "select * from HAEMOTOLOGY"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
       
        If flagaddmodify = 1 Then

            If cmbpid.Text <> "" And cmbtest_id.Text <> "" And txtp_name.Text <> "" And txtneytrophil.Text <> "" And txteosinophil.Text <> "" And txtbasophil.Text <> "" And txtsmalll.Text <> "" And txtlargel.Text <> "" And txtmonocyte.Text <> "" Then
                dr = ds.Tables(0).NewRow
                dr.Item(0) = cmbpid.Text
                dr.Item(1) = cmbtest_id.Text
                dr.Item(2) = txtp_name.Text
                dr.Item(3) = txtneytrophil.Text
                dr.Item(4) = txteosinophil.Text
                dr.Item(5) = txtbasophil.Text
                dr.Item(6) = txtsmalll.Text
                dr.Item(7) = txtlargel.Text
                dr.Item(8) = txtmonocyte.Text
                ds.Tables(0).Rows.Add(dr)

               
            Else
                MsgBox("Provide proper information")
                Exit Sub
            End If
        Else
            dr = ds.Tables(0).Rows(rowno)
            If cmbpid.Text <> "" Then
                If cmbpid.Text <> "" Or cmbtest_id.Text <> "" Or txtp_name.Text <> "" Or txtneytrophil.Text <> "" Or txteosinophil.Text <> "" Or txtbasophil.Text <> "" Or txtsmalll.Text <> "" Or txtlargel.Text <> "" Or txtmonocyte.Text <> "" Then
                    If cmbpid.Text = cmbpid.Text Then
                        dr.BeginEdit()
                        dr.Item(0) = cmbpid.Text
                        dr.Item(1) = cmbtest_id.Text
                        dr.Item(2) = txtp_name.Text
                        dr.Item(3) = txtneytrophil.Text
                        dr.Item(4) = txteosinophil.Text
                        dr.Item(5) = txtbasophil.Text
                        dr.Item(6) = txtsmalll.Text
                        dr.Item(7) = txtlargel.Text
                        dr.Item(8) = txtmonocyte.Text
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
        cmdexit.Enabled = True
        cmdback.Enabled = True


        

    End Sub

    Private Sub cmdmodify_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodify.Click
        flagaddmodify = 2

        'GroupBox1.Enabled = True
        'GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        Call EnableText()
        cmdadd.Enabled = False
        cmdmodify.Enabled = False
        cmdsave.Enabled = True
        cmddelete.Text = "&CANCEL"
        cmbclear.Enabled = True
        cmdback.Enabled = True
        cmbpid.Focus()
    End Sub

    Private Sub cmbclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclear.Click
        txtp_name.Text = ""
        txtneytrophil.Text = ""
        txteosinophil.Text = ""
        txtbasophil.Text = ""
        txtsmalll.Text = ""
        txtlargel.Text = ""
        txtmonocyte.Text = ""
        cmdadd.Enabled = True
        cmdmodify.Enabled = True
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
        cmdadd.Enabled = False
        cmdmodify.Enabled = False
        cmdsave.Enabled = False
        cmdback.Enabled = True
        cmddelete.Text = "&DELETE"
    End Sub

    Private Sub cmdexit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
        MDIParent2.Show()
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
        sqlq = "select * from HAEMOTOLOGY where p_id=" & cmbpid.Text
        daa = New SqlDataAdapter(sqlq, con)
        dss = New DataSet
        daa.Fill(dss)
        If Not dss.Tables(0).Rows.Count > 0 Then
        Else
            MsgBox("Already present")
        End If
    End Sub

End Class