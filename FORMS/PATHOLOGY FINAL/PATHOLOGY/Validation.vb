Imports System.Text.RegularExpressions
Module Validation

    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean


        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"

        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)

        If emailAddressMatch.Success Then

            EmailAddressCheck = True

        Else

            EmailAddressCheck = False

        End If

    End Function

    Function CheckBlank(ByVal blank As String) As Boolean
        If blank = "Plz. enter value" Then
            CheckBlank = True
        Else
            CheckBlank = False
        End If
    End Function

    Public Function CheckNumeric(ByVal strVal As String) As Boolean
        If IsNumeric(strVal) = True Then
            CheckNumeric = True
        Else
            CheckNumeric = False

        End If
    End Function

    Public Sub onlynumbers(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Asc(e.KeyChar) = 8 Then      'For Backspace Work.
            If InStr("0123456789.", e.KeyChar) = 0 Then
                e.Handled = True
                'Same Like Keyascii=0 in vb6.0
                MsgBox("Enter Only Numbers")
            End If
        End If

    End Sub

    Public Sub onlyAlphabate(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Asc(e.KeyChar) = 8 Then      'For Backspace Work.
            If InStr("abcdefghijklmnopqrstuvwxyz .", e.KeyChar, CompareMethod.Text) = 0 Then
                e.Handled = True
                MsgBox("Enter Only Alphabate") 'Same Like Keyascii=0 in vb6.0
            End If
        End If
    End Sub

    Public Function CheckRange(ByVal range As Integer) As Boolean
        If range >= 0 And range <= 20 Then
            CheckRange = True
        Else
            CheckRange = False
        End If
    End Function

End Module

