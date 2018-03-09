Imports System.Data.SqlClient
Public Class VIEW
    Dim inc As Integer
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim maxRows As Integer
    Dim conn As SqlConnection
    Dim connString As String
    Dim sqlString As String
    Private sql As New SQLcontrol
    Private Sub TblActivityBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblActivityBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bco5013_assignmentDataSet)

    End Sub

    Private Sub VIEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        connString = "Data Source=ABDUSAMED\SQLEXPRESS;Initial Catalog=bco5013_assignment;Integrated Security=True"
        conn = New SqlConnection(connString)
        sqlString = "SELECT * FROM tblActivity"
        da = New SqlDataAdapter(sqlString, conn)
        ds = New DataSet
        da.Fill(ds, "tblActivity")
        Me.TblActivityTableAdapter.Fill(Me.Bco5013_assignmentDataSet.tblActivity)
        '   maxRows = ds.Tables("tblActivity").Rows.Count
        '   txt_IDsearch.Focus()
        'loadGrid()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class