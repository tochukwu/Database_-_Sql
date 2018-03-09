<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteActivity
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
        Me.Bco5013_assignmentDataSet = New DatabaseAssignment.bco5013_assignmentDataSet()
        Me.TblActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblActivityTableAdapter = New DatabaseAssignment.bco5013_assignmentDataSetTableAdapters.tblActivityTableAdapter()
        Me.TableAdapterManager = New DatabaseAssignment.bco5013_assignmentDataSetTableAdapters.TableAdapterManager()
        Me.cmd_Delete = New System.Windows.Forms.Button()
        Me.cmd_next = New System.Windows.Forms.Button()
        Me.cmd_previous = New System.Windows.Forms.Button()
        Me.txtRoomID = New System.Windows.Forms.TextBox()
        Me.lbl_RoomID = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.lbl_Time = New System.Windows.Forms.Label()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.lbl_Day = New System.Windows.Forms.Label()
        Me.txtMod = New System.Windows.Forms.TextBox()
        Me.lbl_ModuleID = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.lbl_Type = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.cmd_Search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_IDsearch = New System.Windows.Forms.TextBox()
        CType(Me.Bco5013_assignmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bco5013_assignmentDataSet
        '
        Me.Bco5013_assignmentDataSet.DataSetName = "bco5013_assignmentDataSet"
        Me.Bco5013_assignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblActivityBindingSource
        '
        Me.TblActivityBindingSource.DataMember = "tblActivity"
        Me.TblActivityBindingSource.DataSource = Me.Bco5013_assignmentDataSet
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
        'cmd_Delete
        '
        Me.cmd_Delete.Location = New System.Drawing.Point(279, 298)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(168, 38)
        Me.cmd_Delete.TabIndex = 2
        Me.cmd_Delete.Text = "Delete"
        Me.cmd_Delete.UseVisualStyleBackColor = True
        '
        'cmd_next
        '
        Me.cmd_next.Location = New System.Drawing.Point(379, 239)
        Me.cmd_next.Name = "cmd_next"
        Me.cmd_next.Size = New System.Drawing.Size(68, 33)
        Me.cmd_next.TabIndex = 38
        Me.cmd_next.Text = ">>"
        Me.cmd_next.UseVisualStyleBackColor = True
        '
        'cmd_previous
        '
        Me.cmd_previous.Location = New System.Drawing.Point(279, 239)
        Me.cmd_previous.Name = "cmd_previous"
        Me.cmd_previous.Size = New System.Drawing.Size(68, 33)
        Me.cmd_previous.TabIndex = 37
        Me.cmd_previous.Text = "<<"
        Me.cmd_previous.UseVisualStyleBackColor = True
        '
        'txtRoomID
        '
        Me.txtRoomID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "RoomID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtRoomID.Location = New System.Drawing.Point(125, 316)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.Size = New System.Drawing.Size(133, 20)
        Me.txtRoomID.TabIndex = 53
        '
        'lbl_RoomID
        '
        Me.lbl_RoomID.AutoSize = True
        Me.lbl_RoomID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RoomID.Location = New System.Drawing.Point(15, 316)
        Me.lbl_RoomID.Name = "lbl_RoomID"
        Me.lbl_RoomID.Size = New System.Drawing.Size(78, 24)
        Me.lbl_RoomID.TabIndex = 52
        Me.lbl_RoomID.Text = "RoomID"
        '
        'txtTime
        '
        Me.txtTime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "Time", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.txtTime.Location = New System.Drawing.Point(125, 277)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(133, 20)
        Me.txtTime.TabIndex = 51
        '
        'lbl_Time
        '
        Me.lbl_Time.AutoSize = True
        Me.lbl_Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time.Location = New System.Drawing.Point(15, 277)
        Me.lbl_Time.Name = "lbl_Time"
        Me.lbl_Time.Size = New System.Drawing.Size(53, 24)
        Me.lbl_Time.TabIndex = 50
        Me.lbl_Time.Text = "Time"
        '
        'txtDay
        '
        Me.txtDay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "Day", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.txtDay.Location = New System.Drawing.Point(125, 241)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(133, 20)
        Me.txtDay.TabIndex = 49
        '
        'lbl_Day
        '
        Me.lbl_Day.AutoSize = True
        Me.lbl_Day.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Day.Location = New System.Drawing.Point(15, 241)
        Me.lbl_Day.Name = "lbl_Day"
        Me.lbl_Day.Size = New System.Drawing.Size(42, 24)
        Me.lbl_Day.TabIndex = 48
        Me.lbl_Day.Text = "Day"
        '
        'txtMod
        '
        Me.txtMod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "ModuleID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtMod.Location = New System.Drawing.Point(125, 199)
        Me.txtMod.Name = "txtMod"
        Me.txtMod.Size = New System.Drawing.Size(133, 20)
        Me.txtMod.TabIndex = 47
        '
        'lbl_ModuleID
        '
        Me.lbl_ModuleID.AutoSize = True
        Me.lbl_ModuleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ModuleID.Location = New System.Drawing.Point(15, 199)
        Me.lbl_ModuleID.Name = "lbl_ModuleID"
        Me.lbl_ModuleID.Size = New System.Drawing.Size(91, 24)
        Me.lbl_ModuleID.TabIndex = 46
        Me.lbl_ModuleID.Text = "ModuleID"
        '
        'txtType
        '
        Me.txtType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "Type", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtType.Location = New System.Drawing.Point(125, 155)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(133, 20)
        Me.txtType.TabIndex = 45
        '
        'lbl_Type
        '
        Me.lbl_Type.AutoSize = True
        Me.lbl_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Type.Location = New System.Drawing.Point(15, 155)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(53, 24)
        Me.lbl_Type.TabIndex = 44
        Me.lbl_Type.Text = "Type"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "Name", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtName.Location = New System.Drawing.Point(125, 109)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(133, 20)
        Me.txtName.TabIndex = 43
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(15, 109)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(61, 24)
        Me.lbl_Name.TabIndex = 42
        Me.lbl_Name.Text = "Name"
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "ID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtID.Location = New System.Drawing.Point(125, 64)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(133, 20)
        Me.txtID.TabIndex = 41
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ID.Location = New System.Drawing.Point(15, 60)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(27, 24)
        Me.lbl_ID.TabIndex = 40
        Me.lbl_ID.Text = "ID"
        '
        'cmd_Search
        '
        Me.cmd_Search.Location = New System.Drawing.Point(273, 12)
        Me.cmd_Search.Name = "cmd_Search"
        Me.cmd_Search.Size = New System.Drawing.Size(82, 22)
        Me.cmd_Search.TabIndex = 56
        Me.cmd_Search.Text = "Search"
        Me.cmd_Search.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Search by ID:"
        '
        'txt_IDsearch
        '
        Me.txt_IDsearch.Location = New System.Drawing.Point(125, 12)
        Me.txt_IDsearch.Name = "txt_IDsearch"
        Me.txt_IDsearch.Size = New System.Drawing.Size(133, 20)
        Me.txt_IDsearch.TabIndex = 54
        '
        'DeleteActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 350)
        Me.Controls.Add(Me.cmd_Search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_IDsearch)
        Me.Controls.Add(Me.txtRoomID)
        Me.Controls.Add(Me.lbl_RoomID)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lbl_Time)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.lbl_Day)
        Me.Controls.Add(Me.txtMod)
        Me.Controls.Add(Me.lbl_ModuleID)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.lbl_Type)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.cmd_next)
        Me.Controls.Add(Me.cmd_previous)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Name = "DeleteActivity"
        Me.Text = "DeleteActivity"
        CType(Me.Bco5013_assignmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bco5013_assignmentDataSet As bco5013_assignmentDataSet
    Friend WithEvents TblActivityBindingSource As BindingSource
    Friend WithEvents TblActivityTableAdapter As bco5013_assignmentDataSetTableAdapters.tblActivityTableAdapter
    Friend WithEvents TableAdapterManager As bco5013_assignmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cmd_Delete As Button
    Friend WithEvents cmd_next As Button
    Friend WithEvents cmd_previous As Button
    Friend WithEvents txtRoomID As TextBox
    Friend WithEvents lbl_RoomID As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents lbl_Time As Label
    Friend WithEvents txtDay As TextBox
    Friend WithEvents lbl_Day As Label
    Friend WithEvents txtMod As TextBox
    Friend WithEvents lbl_ModuleID As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents lbl_Type As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lbl_ID As Label
    Friend WithEvents cmd_Search As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_IDsearch As TextBox
End Class
