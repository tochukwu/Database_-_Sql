<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.TblActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bco5013_assignmentDataSet = New DatabaseAssignment.bco5013_assignmentDataSet()
        Me.TblActivityTableAdapter = New DatabaseAssignment.bco5013_assignmentDataSetTableAdapters.tblActivityTableAdapter()
        Me.TableAdapterManager = New DatabaseAssignment.bco5013_assignmentDataSetTableAdapters.TableAdapterManager()
        Me.TblActivityBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmd_amend = New System.Windows.Forms.Button()
        Me.cmd_view = New System.Windows.Forms.Button()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bco5013_assignmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblActivityBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(70, 129)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(99, 50)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Location = New System.Drawing.Point(218, 129)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(99, 50)
        Me.cmdRemove.TabIndex = 1
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'TblActivityBindingSource
        '
        Me.TblActivityBindingSource.DataMember = "tblActivity"
        Me.TblActivityBindingSource.DataSource = Me.Bco5013_assignmentDataSet
        '
        'Bco5013_assignmentDataSet
        '
        Me.Bco5013_assignmentDataSet.DataSetName = "bco5013_assignmentDataSet"
        Me.Bco5013_assignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblActivityTableAdapter
        '
        Me.TblActivityTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblActivityTableAdapter = Me.TblActivityTableAdapter
        Me.TableAdapterManager.UpdateOrder = DatabaseAssignment.bco5013_assignmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblActivityBindingSource1
        '
        Me.TblActivityBindingSource1.DataMember = "tblActivity"
        Me.TblActivityBindingSource1.DataSource = Me.Bco5013_assignmentDataSet
        '
        'cmd_amend
        '
        Me.cmd_amend.Location = New System.Drawing.Point(391, 129)
        Me.cmd_amend.Name = "cmd_amend"
        Me.cmd_amend.Size = New System.Drawing.Size(99, 50)
        Me.cmd_amend.TabIndex = 2
        Me.cmd_amend.Text = "Amend"
        Me.cmd_amend.UseVisualStyleBackColor = True
        '
        'cmd_view
        '
        Me.cmd_view.Location = New System.Drawing.Point(561, 129)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(99, 50)
        Me.cmd_view.TabIndex = 3
        Me.cmd_view.Text = "View"
        Me.cmd_view.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 291)
        Me.Controls.Add(Me.cmd_view)
        Me.Controls.Add(Me.cmd_amend)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdAdd)
        Me.Name = "frmMain"
        Me.Text = "Main"
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bco5013_assignmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblActivityBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdRemove As Button
    Friend WithEvents Bco5013_assignmentDataSet As bco5013_assignmentDataSet
    Friend WithEvents TblActivityBindingSource As BindingSource
    Friend WithEvents TblActivityTableAdapter As bco5013_assignmentDataSetTableAdapters.tblActivityTableAdapter
    Friend WithEvents TableAdapterManager As bco5013_assignmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblActivityBindingSource1 As BindingSource
    Friend WithEvents cmd_amend As Button
    Friend WithEvents cmd_view As Button
End Class
