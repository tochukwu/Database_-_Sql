Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class DeleteActivity
    Dim inc As Integer
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim maxRows As Integer
    Dim conn As SqlConnection
    Dim connString As String
    Private Sub TblActivityBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblActivityBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bco5013_assignmentDataSet)

    End Sub

    Private Sub DeleteActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaddb()


    End Sub
    Private Sub loaddb()
        Dim sqlString As String
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
        Try


            txtID.Text = ds.Tables("tblActivity").Rows(inc).Item(0)
            txtName.Text = ds.Tables("tblActivity").Rows(inc).Item(1)
            txtType.Text = ds.Tables("tblActivity").Rows(inc).Item(2)
            txtMod.Text = ds.Tables("tblActivity").Rows(inc).Item(3)
            txtDay.Text = ds.Tables("tblActivity").Rows(inc).Item(4)
            txtTime.Text = ds.Tables("tblActivity").Rows(inc).Item(5)
            txtRoomID.Text = ds.Tables("tblActivity").Rows(inc).Item(6)
        Catch ex As Exception
            MsgBox("activity has been deleted")
        End Try
    End Sub

    Private Sub cmd_Delete_Click(sender As Object, e As EventArgs) Handles cmd_Delete.Click
        Dim cb As SqlCommandBuilder = New SqlCommandBuilder(da)

        If MessageBox.Show("Do you really want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Operation")

        Else
            ds.Tables("tblActivity").Rows(inc).Delete()
            MaxRows = MaxRows - 1
            inc = 0
            da.Update(ds, "tblActivity")
            ds.AcceptChanges()
            loaddb()
            navigate()
        End If

    End Sub

    Private Sub cmd_Save_Click(sender As Object, e As EventArgs)
        Try

            MsgBox("database saved")
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try

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


End Class