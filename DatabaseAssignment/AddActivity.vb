Imports System.Data.SqlClient

Public Class AddActivity
    Dim inc As Integer
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim maxRows As Integer
    Dim conn As SqlConnection
    Dim connString As String
    Dim sqlString As String

    Private Sub TblActivityBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblActivityBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bco5013_assignmentDataSet)


    End Sub

    Private Sub AddActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bco5013_assignmentDataSet.tblActivity' table. You can move, or remove it, as needed.
        Me.TblActivityTableAdapter.Fill(Me.Bco5013_assignmentDataSet.tblActivity)


        ' Me.BindingNavigatorAddNewItem.Visible = False
        ' Me.TblActivityBindingNavigatorSaveItem.Visible = False

        Me.cmd_Clear.PerformClick()
        Me.txt_Id.Focus()
        connString = "Data Source=ABDUSAMED\SQLEXPRESS;Initial Catalog=bco5013_assignment;Integrated Security=True"
        conn = New SqlConnection(connString)
        sqlString = "SELECT * From tblActivity"
        da = New SqlDataAdapter(sqlString, conn)
        ds = New DataSet
        da.Fill(ds, "tblActivity")

        maxRows = ds.Tables("tblActivity").Rows.Count
        inc = 0
        navigate()
        'watinbe cmd
        Me.cmd_Clear.PerformClick()
    End Sub


    Private Sub cmd_Clear_Click(sender As Object, e As EventArgs) Handles cmd_Clear.Click
        Me.txt_Day.Text = ""
        Me.txt_Id.Text = ""
        Me.txt_ModuleID.Text = ""
        Me.txt_Name.Text = ""
        Me.txt_RoomID.Text = ""
        Me.txt_Time.Text = ""
        Me.txt_Type.Text = ""



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

    Private Sub cmd_add_Click(sender As Object, e As EventArgs) Handles cmd_add.Click
        Try

            If inc <> -1 Then
                Dim cb As SqlCommandBuilder = New SqlCommandBuilder(da)
                Dim dsNewRow As DataRow
                dsNewRow = ds.Tables("tblActivity").NewRow()

                dsNewRow.Item("ID") = txt_Id.Text
                dsNewRow.Item("Name") = txt_Name.Text
                dsNewRow.Item("Type") = txt_Type.Text
                dsNewRow.Item("ModuleID") = txt_ModuleID.Text
                dsNewRow.Item("Day") = txt_Day.Text
                dsNewRow.Item("Time") = txt_Time.Text
                dsNewRow.Item("RoomID") = txt_RoomID.Text

                ds.Tables("tblActivity").Rows.Add(dsNewRow)
                da.Update(ds, "tblActivity")
                Me.Close()
                frmMain.Show()
                MsgBox("activity added")

            End If
            cmd_Clear.PerformClick()
        Catch EX As Exception
            MsgBox(EX.Message + "please enter fields in the correct format")

        End Try
    End Sub


End Class