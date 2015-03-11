Imports System
Imports System.Data.SqlClient

Module connectionModule
    Public con As SqlConnection
    Public flagreport As Integer
    Public Sub MyCon()
        con = New SqlConnection("Data Source=.;Initial Catalog=patho_data_Data;Integrated Security=True")
        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
    End Sub
End Module
