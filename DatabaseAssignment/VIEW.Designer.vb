<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VIEW
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModuleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Bco5013_assignmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.ModuleIDDataGridViewTextBoxColumn, Me.DayDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.RoomIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblActivityBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(35, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(731, 201)
        Me.DataGridView1.TabIndex = 4
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'ModuleIDDataGridViewTextBoxColumn
        '
        Me.ModuleIDDataGridViewTextBoxColumn.DataPropertyName = "ModuleID"
        Me.ModuleIDDataGridViewTextBoxColumn.HeaderText = "ModuleID"
        Me.ModuleIDDataGridViewTextBoxColumn.Name = "ModuleIDDataGridViewTextBoxColumn"
        '
        'DayDataGridViewTextBoxColumn
        '
        Me.DayDataGridViewTextBoxColumn.DataPropertyName = "Day"
        Me.DayDataGridViewTextBoxColumn.HeaderText = "Day"
        Me.DayDataGridViewTextBoxColumn.Name = "DayDataGridViewTextBoxColumn"
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        '
        'RoomIDDataGridViewTextBoxColumn
        '
        Me.RoomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID"
        Me.RoomIDDataGridViewTextBoxColumn.HeaderText = "RoomID"
        Me.RoomIDDataGridViewTextBoxColumn.Name = "RoomIDDataGridViewTextBoxColumn"
        '
        'VIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 347)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "VIEW"
        Me.Text = "VIEW"
        CType(Me.Bco5013_assignmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bco5013_assignmentDataSet As bco5013_assignmentDataSet
    Friend WithEvents TblActivityBindingSource As BindingSource
    Friend WithEvents TblActivityTableAdapter As bco5013_assignmentDataSetTableAdapters.tblActivityTableAdapter
    Friend WithEvents TableAdapterManager As bco5013_assignmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModuleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
