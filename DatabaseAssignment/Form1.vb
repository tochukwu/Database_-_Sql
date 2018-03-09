Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        Try
            Me.TblActivityTableAdapter.FillBy(Me.Bco5013_assignmentDataSet.tblActivity)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        AddActivity.Show()

    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        DeleteActivity.Show()

    End Sub

    Private Sub cmd_amend_Click(sender As Object, e As EventArgs) Handles cmd_amend.Click
        amend.Show()
    End Sub

    Private Sub cmd_view_Click(sender As Object, e As EventArgs) Handles cmd_view.Click
        VIEW.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblActivityTableAdapter.Fill(Me.Bco5013_assignmentDataSet.tblActivity)
    End Sub
End Class
