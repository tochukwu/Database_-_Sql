Imports System.Data.SqlClient

Public Class amend
    Dim inc As Integer
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim maxRows As Integer
    Dim conn As SqlConnection
    Dim connString As String
    Private sql As New SQLcontrol

    Private Sub amend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlString As String
        'TODO: This line of code loads data into the 'Bco5013_assignmentDataSet.tblActivity' table. You can move, or remove it, as needed.
        ' Me.TblActivityTableAdapter.Fill(Me.Bco5013_assignmentDataSet.tblActivity)

        connString = "Data Source=ABDUSAMED\SQLEXPRESS;Initial Catalog=bco5013_assignment;Integrated Security=True"
        conn = New SqlConnection(connString)
        sqlString = "SELECT * From tblActivity"
        da = New SqlDataAdapter(sqlString, conn)
        ds = New DataSet
        da.Fill(ds, "tblActivity")

        maxRows = ds.Tables("tblActivity").Rows.Count
        inc = 0
        navigate()

    End Sub

    Private Sub navigate()
        txt_Id.Text = ds.Tables("tblActivity").Rows(inc).Item(0)
        txt_Name.Text = ds.Tables("tblActivity").Rows(inc).Item(1)
        txt_Type.Text = ds.Tables("tblActivity").Rows(inc).Item(2)
        txt_ModuleID.Text = ds.Tables("tblActivity").Rows(inc).Item(3)
        txt_Day.Text = ds.Tables("tblActivity").Rows(inc).Item(4)
        txt_Time.Text = ds.Tables("tblActivity").Rows(inc).Item(5)
        txt_RoomID.Text = ds.Tables("tblActivity").Rows(inc).Item(6)
    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_next.Click
        If inc <> maxRows - 1 Then
            inc = inc + 1
            navigate()
        Else
            MsgBox("no more rows")
        End If
    End Sub

    Private Sub cmd_previous_Click(sender As Object, e As EventArgs) Handles cmd_previous.Click
        If inc > 0 Then
            inc = inc - 1
            navigate()
        Else
            MsgBox("First Record")
        End If
    End Sub

    Private Sub cmd_Save_Click(sender As Object, e As EventArgs) Handles cmd_Save.Click
        Dim cb As SqlCommandBuilder = New SqlCommandBuilder(da)
        ds.Tables("tblActivity").Rows(inc).Item(1) = txt_Name.Text
        ds.Tables("tblActivity").Rows(inc).Item(2) = txt_Type.Text
        ds.Tables("tblActivity").Rows(inc).Item(3) = txt_ModuleID.Text
        ds.Tables("tblActivity").Rows(inc).Item(4) = txt_Day.Text
        ds.Tables("tblActivity").Rows(inc).Item(5) = txt_Time.Text
        ds.Tables("tblActivity").Rows(inc).Item(6) = txt_RoomID.Text
        da.Update(ds, "tblActivity")
        MsgBox("Database updated")
        navigate()

        Me.TblActivityTableAdapter.Fill(Me.Bco5013_assignmentDataSet.tblActivity)


    End Sub


End Class

