Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Patient_Record
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim sqlq As String
    Dim rowno As Integer
    Dim flagaddmodify As Integer
    Dim str As String

    Private Sub Patient_Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MyCon()

        cmdadd.Enabled = True
        cmdmodify.Enabled = True
        cmdsave.Enabled = False
        cmdclear.Enabled = False
        cmdexit.Enabled = True
        cmddelete.Enabled = False
        cmdback.Enabled = False
        GroupBox2.Enabled = True
        Me.BackColor = Color.SkyBlue
        'Call my sub
        refresh11()
        DisableText()

    End Sub
    Public Sub refresh11()
        sqlq = "select * from PATIENT"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        rowno = 0
        If ds.Tables(0).Rows.Count <> 0 Then
            Call txtfill()
            PATIENTGrid.DataSource = ds.Tables(0)
        End If
    End Sub


    Public Sub txtfill()
        txtp_id.Text = ds.Tables(0).Rows(rowno).Item(0)
        txtp_name.Text = ds.Tables(0).Rows(rowno).Item(1)
        txtp_address.Text = ds.Tables(0).Rows(rowno).Item(2)
        txtp_phone.Text = ds.Tables(0).Rows(rowno).Item(3)
        txtp_age.Text = ds.Tables(0).Rows(rowno).Item(5)
        txtp_gender.Text = ds.Tables(0).Rows(rowno).Item(4)
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

    Private Sub cmdadd_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If cmdadd.Enabled = True Then
            flagaddmodify = 1
            Call txtblank()
            Call PatientAutogen()

            cmdadd.Enabled = False
            cmdsave.Enabled = True
            'cmddelete.Text = "CANCEL"
            cmdclear.Enabled = True
            cmdmodify.Enabled = False
            cmdback.Enabled = True
            GroupBox2.Enabled = False
            GroupBox1.Enabled = True
            EnableText()
        Else
            cmdadd.Visible = True
            cmdsave.Enabled = False
            ' cmddelete.Text = "ADD"
            cmdmodify.Enabled = True
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
           
        End If
    End Sub



    Public Sub EnableText()
        txtp_address.Enabled = True
        txtp_age.Enabled = True
        txtp_name.Enabled = True
        txtp_id.Enabled = False
        txtp_phone.Enabled = True
        txtp_gender.Enabled = True


    End Sub


    Public Sub DisableText()
        txtp_address.Enabled = False
        txtp_age.Enabled = False
        txtp_name.Enabled = False
        txtp_id.Enabled = False
        txtp_phone.Enabled = False
        txtp_gender.Enabled = False


    End Sub
    Private Sub cmdsave_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim dr As DataRow
       
        'Try
        If flagaddmodify = 1 Then

            If txtp_id.Text <> "" And txtp_name.Text <> "" And txtp_address.Text <> "" And txtp_age.Text <> "" And txtp_gender.Text <> "" And txtp_phone.Text <> "" Then



                dr = ds.Tables(0).NewRow
                dr.Item(0) = txtp_id.Text
                dr.Item(1) = txtp_name.Text
                dr.Item(2) = txtp_address.Text
                dr.Item(3) = txtp_phone.Text
                dr.Item(5) = txtp_age.Text
                dr.Item(4) = txtp_gender.Text
                dr.Item(6) = DateTimePicker1.Value
                ds.Tables(0).Rows.Add(dr)


            Else
                MsgBox("PLZ PROVIDE PROPER INFORMATION", MsgBoxStyle.Information)
                Exit Sub
            End If
        Else
            dr = ds.Tables(0).Rows(rowno)
            If txtp_id.Text <> "" Then
                If txtp_id.Text <> "" Or txtp_name.Text <> "" Or txtp_address.Text <> "" Or txtp_age.Text <> " " Or txtp_gender.Text <> "" Or txtp_phone.Text <> "" Then
                    If txtp_id.Text = txtp_id.Text Then
                        dr.BeginEdit()
                        dr.Item(0) = txtp_id.Text
                        dr.Item(1) = txtp_name.Text
                        dr.Item(2) = txtp_address.Text
                        dr.Item(3) = txtp_phone.Text
                        dr.Item(5) = txtp_age.Text
                        dr.Item(4) = txtp_gender.Text
                        dr.Item(6) = DateTimePicker1.Value
                        'ds.Tables(0).Rows.Add(dr)
                        dr.EndEdit()
                    Else
                        MsgBox("PLZ CHECK THE RE-ENTERED ")
                        Exit Sub
                    End If
                End If
            End If
        End If



        Dim cb As New SqlCommandBuilder(da)
        da.Update(ds)
        rowno = ds.Tables(0).Rows.Count - 1
        Call txtfill()
        PATIENTGrid.DataSource = ds.Tables(0)
        MsgBox("record Saved", MsgBoxStyle.Information)
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        cmdsave.Enabled = False
        cmdmodify.Enabled = False
        cmdadd.Enabled = True
        cmddelete.Text = "DELETE"

        refresh11()
        

    End Sub

    Private Sub cmdmodify_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodify.Click
        flagaddmodify = 2
        cmdback.Enabled = True
        cmddelete.Enabled = True
        cmdexit.Enabled = True
        cmdclear.Enabled = True
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        cmdadd.Enabled = False
        cmdmodify.Enabled = False 
        cmdsave.Enabled = True
        txtp_id.Enabled = True
        txtp_name.Enabled = True
        txtp_address.Enabled = True
        txtp_gender.Enabled = True
        txtp_age.Enabled = True
        txtp_phone.Enabled = True
        cmddelete.Text = "&DELETE"
        txtp_id.Focus()
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
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        cmdadd.Enabled = False
        cmdmodify.Enabled = False
        cmdsave.Enabled = False
        cmddelete.Enabled = False
        cmdback.Enabled = True
        cmdsave.Enabled = False
        cmddelete.Text = "&DELETE"



    End Sub


    Private Sub PATIENTGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PATIENTGrid.CellContentClick
        rowno = PATIENTGrid.CurrentRow.Index
        Call txtfill()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click


        Me.Hide()
        MDIParent2.Show()
    End Sub
    Public Sub onlyread()
        txtp_id.ReadOnly = False
        txtp_name.ReadOnly = False
        txtp_address.ReadOnly = False
        'txtp_gender.ReadOnly = False
        txtp_age.ReadOnly = False
        txtp_phone.ReadOnly = False

    End Sub

    Public Sub txtblank()
        txtp_id.Text = ""
        txtp_name.Text = ""
        txtp_address.Text = ""
        txtp_gender.Text = ""
        txtp_age.Text = ""
        txtp_phone.Text = ""

    End Sub

    Private Sub txtp_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtp_id.KeyPress
        Call onlynumbers(e)
    End Sub



    

    Private Sub txtp_age_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtp_age.KeyPress
        Call onlynumbers(e)
    End Sub

    Private Sub txtp_gender_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call onlyAlphabate(e)
    End Sub

    Private Sub txtp_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtp_name.KeyPress
        Call onlyAlphabate(e)
    End Sub

    Private Sub txtp_phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtp_phone.KeyPress
        Call onlynumbers(e)
       
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtp_id.Text = ""
        txtp_name.Text = ""
        txtp_address.Text = ""
        txtp_gender.Text = ""
        txtp_age.Text = ""
        txtp_phone.Text = ""

    End Sub
    Sub PatientAutogen()
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim i As Integer
        Dim sql1 As String
        Call MyCon()
        sql1 = "select * from PATIENT"
        da = New SqlDataAdapter(sqlq, con)
        ds = New DataSet
        da.Fill(ds)
        i = ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item(0)
        txtp_id.Text = i + 1
    End Sub

    
    
    
    

    
    Private Sub cmdback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdback.Click
        
        Call txtblank()
        Call PatientAutogen()
        cmdadd.Enabled = True



        cmdmodify.Enabled = True
        GroupBox2.Enabled = True
        GroupBox1.Enabled = True


        cmdsave.Enabled = False
        cmddelete.Enabled = False
        cmdclear.Enabled = False


    End Sub

    
    
End Class