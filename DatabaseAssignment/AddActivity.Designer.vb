<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddActivity
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
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.lbl_Type = New System.Windows.Forms.Label()
        Me.txt_Type = New System.Windows.Forms.TextBox()
        Me.lbl_ModuleID = New System.Windows.Forms.Label()
        Me.txt_ModuleID = New System.Windows.Forms.TextBox()
        Me.lbl_Day = New System.Windows.Forms.Label()
        Me.txt_Day = New System.Windows.Forms.TextBox()
        Me.lbl_Time = New System.Windows.Forms.Label()
        Me.txt_Time = New System.Windows.Forms.TextBox()
        Me.lbl_RoomID = New System.Windows.Forms.Label()
        Me.txt_RoomID = New System.Windows.Forms.TextBox()
        Me.cmd_add = New System.Windows.Forms.Button()
        Me.cmd_Clear = New System.Windows.Forms.Button()
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
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ID.Location = New System.Drawing.Point(12, 44)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(27, 24)
        Me.lbl_ID.TabIndex = 2
        Me.lbl_ID.Text = "ID"
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(160, 49)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(133, 20)
        Me.txt_Id.TabIndex = 3
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(12, 93)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(61, 24)
        Me.lbl_Name.TabIndex = 4
        Me.lbl_Name.Text = "Name"
        '
        'txt_Name
        '
        Me.txt_Name.Location = New System.Drawing.Point(160, 94)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(133, 20)
        Me.txt_Name.TabIndex = 9
        '
        'lbl_Type
        '
        Me.lbl_Type.AutoSize = True
        Me.lbl_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Type.Location = New System.Drawing.Point(12, 139)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(53, 24)
        Me.lbl_Type.TabIndex = 10
        Me.lbl_Type.Text = "Type"
        '
        'txt_Type
        '
        Me.txt_Type.Location = New System.Drawing.Point(160, 140)
        Me.txt_Type.Name = "txt_Type"
        Me.txt_Type.Size = New System.Drawing.Size(133, 20)
        Me.txt_Type.TabIndex = 11
        '
        'lbl_ModuleID
        '
        Me.lbl_ModuleID.AutoSize = True
        Me.lbl_ModuleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ModuleID.Location = New System.Drawing.Point(12, 183)
        Me.lbl_ModuleID.Name = "lbl_ModuleID"
        Me.lbl_ModuleID.Size = New System.Drawing.Size(91, 24)
        Me.lbl_ModuleID.TabIndex = 12
        Me.lbl_ModuleID.Text = "ModuleID"
        '
        'txt_ModuleID
        '
        Me.txt_ModuleID.Location = New System.Drawing.Point(160, 184)
        Me.txt_ModuleID.Name = "txt_ModuleID"
        Me.txt_ModuleID.Size = New System.Drawing.Size(133, 20)
        Me.txt_ModuleID.TabIndex = 13
        '
        'lbl_Day
        '
        Me.lbl_Day.AutoSize = True
        Me.lbl_Day.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Day.Location = New System.Drawing.Point(12, 225)
        Me.lbl_Day.Name = "lbl_Day"
        Me.lbl_Day.Size = New System.Drawing.Size(42, 24)
        Me.lbl_Day.TabIndex = 14
        Me.lbl_Day.Text = "Day"
        '
        'txt_Day
        '
        Me.txt_Day.Location = New System.Drawing.Point(160, 226)
        Me.txt_Day.Name = "txt_Day"
        Me.txt_Day.Size = New System.Drawing.Size(133, 20)
        Me.txt_Day.TabIndex = 15
        '
        'lbl_Time
        '
        Me.lbl_Time.AutoSize = True
        Me.lbl_Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time.Location = New System.Drawing.Point(12, 261)
        Me.lbl_Time.Name = "lbl_Time"
        Me.lbl_Time.Size = New System.Drawing.Size(53, 24)
        Me.lbl_Time.TabIndex = 16
        Me.lbl_Time.Text = "Time"
        '
        'txt_Time
        '
        Me.txt_Time.Location = New System.Drawing.Point(160, 262)
        Me.txt_Time.Name = "txt_Time"
        Me.txt_Time.Size = New System.Drawing.Size(133, 20)
        Me.txt_Time.TabIndex = 17
        '
        'lbl_RoomID
        '
        Me.lbl_RoomID.AutoSize = True
        Me.lbl_RoomID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RoomID.Location = New System.Drawing.Point(12, 300)
        Me.lbl_RoomID.Name = "lbl_RoomID"
        Me.lbl_RoomID.Size = New System.Drawing.Size(78, 24)
        Me.lbl_RoomID.TabIndex = 18
        Me.lbl_RoomID.Text = "RoomID"
        '
        'txt_RoomID
        '
        Me.txt_RoomID.Location = New System.Drawing.Point(160, 301)
        Me.txt_RoomID.Name = "txt_RoomID"
        Me.txt_RoomID.Size = New System.Drawing.Size(133, 20)
        Me.txt_RoomID.TabIndex = 19
        '
        'cmd_add
        '
        Me.cmd_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_add.Location = New System.Drawing.Point(16, 352)
        Me.cmd_add.Name = "cmd_add"
        Me.cmd_add.Size = New System.Drawing.Size(123, 42)
        Me.cmd_add.TabIndex = 20
        Me.cmd_add.Text = "Add"
        Me.cmd_add.UseVisualStyleBackColor = True
        '
        'cmd_Clear
        '
        Me.cmd_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.Location = New System.Drawing.Point(170, 352)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(123, 42)
        Me.cmd_Clear.TabIndex = 21
        Me.cmd_Clear.Text = "Clear"
        Me.cmd_Clear.UseVisualStyleBackColor = True
        '
        'AddActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 437)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_add)
        Me.Controls.Add(Me.txt_RoomID)
        Me.Controls.Add(Me.lbl_RoomID)
        Me.Controls.Add(Me.txt_Time)
        Me.Controls.Add(Me.lbl_Time)
        Me.Controls.Add(Me.txt_Day)
        Me.Controls.Add(Me.lbl_Day)
        Me.Controls.Add(Me.txt_ModuleID)
        Me.Controls.Add(Me.lbl_ModuleID)
        Me.Controls.Add(Me.txt_Type)
        Me.Controls.Add(Me.lbl_Type)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.txt_Id)
        Me.Controls.Add(Me.lbl_ID)
        Me.Name = "AddActivity"
        Me.Text = "AddActivity"
        CType(Me.Bco5013_assignmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bco5013_assignmentDataSet As bco5013_assignmentDataSet
    Friend WithEvents TblActivityBindingSource As BindingSource
    Friend WithEvents TblActivityTableAdapter As bco5013_assignmentDataSetTableAdapters.tblActivityTableAdapter
    Friend WithEvents TableAdapterManager As bco5013_assignmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lbl_ID As Label
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents lbl_Type As Label
    Friend WithEvents txt_Type As TextBox
    Friend WithEvents lbl_ModuleID As Label
    Friend WithEvents txt_ModuleID As TextBox
    Friend WithEvents lbl_Day As Label
    Friend WithEvents txt_Day As TextBox
    Friend WithEvents lbl_Time As Label
    Friend WithEvents txt_Time As TextBox
    Friend WithEvents lbl_RoomID As Label
    Friend WithEvents txt_RoomID As TextBox
    Friend WithEvents cmd_add As Button
    Friend WithEvents cmd_Clear As Button
End Class
