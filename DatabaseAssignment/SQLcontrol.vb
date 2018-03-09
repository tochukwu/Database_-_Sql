Imports System.Data.SqlClient
Public Class SQLcontrol




    Dim dbDataSet As New DataTable



    Private conn = New SqlConnection("Data Source=ABDUSAMED\SQLEXPRESS;Initial Catalog=bco5013_assignment;Integrated Security=True")

    Private sqlcmd As SqlCommand

    Public da As SqlDataAdapter
    Public ds = New DataSet

    Public countRec As Integer
    Public Exception As String

    Public params As New List(Of SqlParameter)

    Public Sub ExecuteQuery(Query As String)
        countRec = 0
        Exception = ""

        Try
            conn.open()
            sqlcmd = New SqlCommand(Query, conn)
            'load the parameters into sql command
            params.ForEach(Sub(p) sqlcmd.Parameters.Add(p))
            params.Clear()
            'execute the command and fill the dataset
            ds = New DataSet
            da = New SqlDataAdapter
            countRec = da.Fill(ds)
            conn.close()
        Catch ex As Exception
            Exception = ex.Message
        End Try
        If conn.state = ConnectionState.Open Then
            conn.close()
        End If


    End Sub


    Public Sub addparam(Name As String, value As Object)
        Dim newparam As New SqlParameter(Name, value)

        params.Add(newparam)
    End Sub
End Class
