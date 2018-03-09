<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class amend
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txt_RoomID = New System.Windows.Forms.TextBox()
        Me.TblActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bco5013assignmentDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bco5013_assignmentDataSet = New DatabaseAssignment.bco5013_assignmentDataSet()
        Me.lbl_RoomID = New System.Windows.Forms.Label()
        Me.txt_Time = New System.Windows.Forms.TextBox()
        Me.lbl_Time = New System.Windows.Forms.Label()
        Me.txt_Day = New System.Windows.Forms.TextBox()
        Me.lbl_Day = New System.Windows.Forms.Label()
        Me.txt_ModuleID = New System.Windows.Forms.TextBox()
        Me.lbl_ModuleID = New System.Windows.Forms.Label()
        Me.txt_Type = New System.Windows.Forms.TextBox()
        Me.lbl_Type = New System.Windows.Forms.Label()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.cmd_previous = New System.Windows.Forms.Button()
        Me.cmd_next = New System.Windows.Forms.Button()
        Me.cmd_Save = New System.Windows.Forms.Button()
        Me.TblActivityBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblActivityTableAdapter = New DatabaseAssignment.bco5013_assignmentDataSetTableAdapters.tblActivityTableAdapter()
        Me.cmd_Search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_IDsearch = New System.Windows.Forms.TextBox()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bco5013assignmentDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bco5013_assignmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblActivityBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_RoomID
        '
        Me.txt_RoomID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "RoomID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_RoomID.Location = New System.Drawing.Point(127, 301)
        Me.txt_RoomID.Name = "txt_RoomID"
        Me.txt_RoomID.Size = New System.Drawing.Size(133, 20)
        Me.txt_RoomID.TabIndex = 33
        '
        'TblActivityBindingSource
        '
        Me.TblActivityBindingSource.DataMember = "tblActivity"
        Me.TblActivityBindingSource.DataSource = Me.Bco5013assignmentDataSetBindingSource
        '
        'Bco5013assignmentDataSetBindingSource
        '
        Me.Bco5013assignmentDataSetBindingSource.DataSource = Me.Bco5013_assignmentDataSet
        Me.Bco5013assignmentDataSetBindingSource.Position = 0
        '
        'Bco5013_assignmentDataSet
        '
        Me.Bco5013_assignmentDataSet.DataSetName = "bco5013_assignmentDataSet"
        Me.Bco5013_assignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_RoomID
        '
        Me.lbl_RoomID.AutoSize = True
        Me.lbl_RoomID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RoomID.Location = New System.Drawing.Point(17, 301)
        Me.lbl_RoomID.Name = "lbl_RoomID"
        Me.lbl_RoomID.Size = New System.Drawing.Size(78, 24)
        Me.lbl_RoomID.TabIndex = 32
        Me.lbl_RoomID.Text = "RoomID"
        '
        'txt_Time
        '
        Me.txt_Time.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "Time", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.txt_Time.Location = New System.Drawing.Point(127, 262)
        Me.txt_Time.Name = "txt_Time"
        Me.txt_Time.Size = New System.Drawing.Size(133, 20)
        Me.txt_Time.TabIndex = 31
        '
        'lbl_Time
        '
        Me.lbl_Time.AutoSize = True
        Me.lbl_Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time.Location = New System.Drawing.Point(17, 262)
        Me.lbl_Time.Name = "lbl_Time"
        Me.lbl_Time.Size = New System.Drawing.Size(53, 24)
        Me.lbl_Time.TabIndex = 30
        Me.lbl_Time.Text = "Time"
        '
        'txt_Day
        '
        Me.txt_Day.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "Day", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.txt_Day.Location = New System.Drawing.Point(127, 226)
        Me.txt_Day.Name = "txt_Day"
        Me.txt_Day.Size = New System.Drawing.Size(133, 20)
        Me.txt_Day.TabIndex = 29
        '
        'lbl_Day
        '
        Me.lbl_Day.AutoSize = True
        Me.lbl_Day.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Day.Location = New System.Drawing.Point(17, 226)
        Me.lbl_Day.Name = "lbl_Day"
        Me.lbl_Day.Size = New System.Drawing.Size(42, 24)
        Me.lbl_Day.TabIndex = 28
        Me.lbl_Day.Text = "Day"
        '
        'txt_ModuleID
        '
        Me.txt_ModuleID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "ModuleID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_ModuleID.Location = New System.Drawing.Point(127, 184)
        Me.txt_ModuleID.Name = "txt_ModuleID"
        Me.txt_ModuleID.Size = New System.Drawing.Size(133, 20)
        Me.txt_ModuleID.TabIndex = 27
        '
        'lbl_ModuleID
        '
        Me.lbl_ModuleID.AutoSize = True
        Me.lbl_ModuleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ModuleID.Location = New System.Drawing.Point(17, 184)
        Me.lbl_ModuleID.Name = "lbl_ModuleID"
        Me.lbl_ModuleID.Size = New System.Drawing.Size(91, 24)
        Me.lbl_ModuleID.TabIndex = 26
        Me.lbl_ModuleID.Text = "ModuleID"
        '
        'txt_Type
        '
        Me.txt_Type.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "Type", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Type.Location = New System.Drawing.Point(127, 140)
        Me.txt_Type.Name = "txt_Type"
        Me.txt_Type.Size = New System.Drawing.Size(133, 20)
        Me.txt_Type.TabIndex = 25
        '
        'lbl_Type
        '
        Me.lbl_Type.AutoSize = True
        Me.lbl_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Type.Location = New System.Drawing.Point(17, 140)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(53, 24)
        Me.lbl_Type.TabIndex = 24
        Me.lbl_Type.Text = "Type"
        '
        'txt_Name
        '
        Me.txt_Name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "Name", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Name.Location = New System.Drawing.Point(127, 94)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(133, 20)
        Me.txt_Name.TabIndex = 23
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(17, 94)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(61, 24)
        Me.lbl_Name.TabIndex = 22
        Me.lbl_Name.Text = "Name"
        '
        'txt_Id
        '
        Me.txt_Id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblActivityBindingSource, "ID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Id.Location = New System.Drawing.Point(127, 49)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(133, 20)
        Me.txt_Id.TabIndex = 21
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ID.Location = New System.Drawing.Point(17, 45)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(27, 24)
        Me.lbl_ID.TabIndex = 20
        Me.lbl_ID.Text = "ID"
        '
        'cmd_previous
        '
        Me.cmd_previous.Location = New System.Drawing.Point(301, 213)
        Me.cmd_previous.Name = "cmd_previous"
        Me.cmd_previous.Size = New System.Drawing.Size(68, 33)
        Me.cmd_previous.TabIndex = 34
        Me.cmd_previous.Text = "<<"
        Me.cmd_previous.UseVisualStyleBackColor = True
        '
        'cmd_next
        '
        Me.cmd_next.Location = New System.Drawing.Point(401, 213)
        Me.cmd_next.Name = "cmd_next"
        Me.cmd_next.Size = New System.Drawing.Size(68, 33)
        Me.cmd_next.TabIndex = 35
        Me.cmd_next.Text = ">>"
        Me.cmd_next.UseVisualStyleBackColor = True
        '
        'cmd_Save
        '
        Me.cmd_Save.Location = New System.Drawing.Point(301, 287)
        Me.cmd_Save.Name = "cmd_Save"
        Me.cmd_Save.Size = New System.Drawing.Size(168, 34)
        Me.cmd_Save.TabIndex = 36
        Me.cmd_Save.Text = "Save"
        Me.cmd_Save.UseVisualStyleBackColor = True
        '
        'TblActivityBindingSource1
        '
        Me.TblActivityBindingSource1.DataMember = "tblActivity"
        Me.TblActivityBindingSource1.DataSource = Me.Bco5013assignmentDataSetBindingSource
        '
        'TblActivityTableAdapter
        '
        Me.TblActivityTableAdapter.ClearBeforeFill = True
        '
        'cmd_Search
        '
        Me.cmd_Search.Location = New System.Drawing.Point(275, 12)
        Me.cmd_Search.Name = "cmd_Search"
        Me.cmd_Search.Size = New System.Drawing.Size(82, 22)
        Me.cmd_Search.TabIndex = 39
        Me.cmd_Search.Text = "Search"
        Me.cmd_Search.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Search by ID:"
        '
        'txt_IDsearch
        '
        Me.txt_IDsearch.Location = New System.Drawing.Point(127, 12)
        Me.txt_IDsearch.Name = "txt_IDsearch"
        Me.txt_IDsearch.Size = New System.Drawing.Size(133, 20)
        Me.txt_IDsearch.TabIndex = 37
        '
        'amend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 351)
        Me.Controls.Add(Me.cmd_Search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_IDsearch)
        Me.Controls.Add(Me.cmd_Save)
        Me.Controls.Add(Me.cmd_next)
        Me.Controls.Add(Me.cmd_previous)
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
        Me.Name = "amend"
        Me.Text = "amend"
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bco5013assignmentDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bco5013_assignmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblActivityBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_RoomID As TextBox
    Friend WithEvents lbl_RoomID As Label
    Friend WithEvents txt_Time As TextBox
    Friend WithEvents lbl_Time As Label
    Friend WithEvents txt_Day As TextBox
    Friend WithEvents lbl_Day As Label
    Friend WithEvents txt_ModuleID As TextBox
    Friend WithEvents lbl_ModuleID As Label
    Friend WithEvents txt_Type As TextBox
    Friend WithEvents lbl_Type As Label
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents txt_Id As TextBox
    Friend WithEvents lbl_ID As Label
    Friend WithEvents cmd_previous As Button
    Friend WithEvents cmd_next As Button
    Friend WithEvents cmd_Save As Button
    Friend WithEvents Bco5013assignmentDataSetBindingSource As BindingSource
    Friend WithEvents Bco5013_assignmentDataSet As bco5013_assignmentDataSet
    Friend WithEvents TblActivityBindingSource As BindingSource
    Friend WithEvents TblActivityTableAdapter As bco5013_assignmentDataSetTableAdapters.tblActivityTableAdapter
    Friend WithEvents TblActivityBindingSource1 As BindingSource
    Friend WithEvents cmd_Search As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_IDsearch As TextBox
End Class
