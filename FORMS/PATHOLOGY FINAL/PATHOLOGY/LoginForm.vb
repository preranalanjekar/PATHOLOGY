Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data
Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Dim q As String
        'If UsernameTextBox.Text = " " Then
        '    MsgBox("PLZ ENTER USERNAMR", MsgBoxStyle.Information)
        'ElseIf PasswordTextBox.Text = " " Then
        '    MsgBox("PLZ ENTER PASSWORD ", MsgBoxStyle.Information)

        'End If
        q = "Select * from login where username='" & UsernameTextBox.Text & "' and passwd='" & PasswordTextBox.Text & "'"
        Call MyCon()
        da = New SqlDataAdapter(q, con)
        da.Fill(ds)
        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("Invalid user", MsgBoxStyle.Critical, "Retry")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            UsernameTextBox.Focus()
        Else
            Me.Hide()
            MDIParent2.Show()

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub




    
End Class
