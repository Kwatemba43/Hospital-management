<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hospice_Projects
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim ProjectsLabel As System.Windows.Forms.Label
        Dim EventsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hospice_Projects))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnenter = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PalliativecareunitDataSet = New splashform.PalliativecareunitDataSet()
        Me.Hospice_Projects___EventsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hospice_Projects___EventsTableAdapter = New splashform.PalliativecareunitDataSetTableAdapters.Hospice_Projects___EventsTableAdapter()
        Me.TableAdapterManager = New splashform.PalliativecareunitDataSetTableAdapters.TableAdapterManager()
        Me.Hospice_Projects___EventsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Hospice_Projects___EventsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ProjectsTextBox = New System.Windows.Forms.TextBox()
        Me.EventsTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        ProjectsLabel = New System.Windows.Forms.Label()
        EventsLabel = New System.Windows.Forms.Label()
        CType(Me.PalliativecareunitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospice_Projects___EventsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hospice_Projects___EventsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Hospice_Projects___EventsBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 54)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 15
        IDLabel.Text = "ID:"
        '
        'ProjectsLabel
        '
        ProjectsLabel.AutoSize = True
        ProjectsLabel.Location = New System.Drawing.Point(12, 80)
        ProjectsLabel.Name = "ProjectsLabel"
        ProjectsLabel.Size = New System.Drawing.Size(48, 13)
        ProjectsLabel.TabIndex = 17
        ProjectsLabel.Text = "Projects:"
        '
        'EventsLabel
        '
        EventsLabel.AutoSize = True
        EventsLabel.Location = New System.Drawing.Point(12, 106)
        EventsLabel.Name = "EventsLabel"
        EventsLabel.Size = New System.Drawing.Size(43, 13)
        EventsLabel.TabIndex = 19
        EventsLabel.Text = "Events:"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(417, 218)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        '
        'btnenter
        '
        Me.btnenter.Location = New System.Drawing.Point(3, 309)
        Me.btnenter.Name = "btnenter"
        Me.btnenter.Size = New System.Drawing.Size(99, 56)
        Me.btnenter.TabIndex = 5
        Me.btnenter.Text = "Save new project"
        Me.btnenter.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(143, 309)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 56)
        Me.btnclear.TabIndex = 7
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(238, 309)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 56)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(3, 258)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 45)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'PalliativecareunitDataSet
        '
        Me.PalliativecareunitDataSet.DataSetName = "PalliativecareunitDataSet"
        Me.PalliativecareunitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Hospice_Projects___EventsBindingSource
        '
        Me.Hospice_Projects___EventsBindingSource.DataMember = "Hospice Projects & Events"
        Me.Hospice_Projects___EventsBindingSource.DataSource = Me.PalliativecareunitDataSet
        '
        'Hospice_Projects___EventsTableAdapter
        '
        Me.Hospice_Projects___EventsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Employee_detailsTableAdapter = Nothing
        Me.TableAdapterManager.Hospice_Projects___EventsTableAdapter = Me.Hospice_Projects___EventsTableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Patient_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = splashform.PalliativecareunitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Hospice_Projects___EventsBindingNavigator
        '
        Me.Hospice_Projects___EventsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Hospice_Projects___EventsBindingNavigator.BindingSource = Me.Hospice_Projects___EventsBindingSource
        Me.Hospice_Projects___EventsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Hospice_Projects___EventsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Hospice_Projects___EventsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Hospice_Projects___EventsBindingNavigatorSaveItem})
        Me.Hospice_Projects___EventsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Hospice_Projects___EventsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Hospice_Projects___EventsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Hospice_Projects___EventsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Hospice_Projects___EventsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Hospice_Projects___EventsBindingNavigator.Name = "Hospice_Projects___EventsBindingNavigator"
        Me.Hospice_Projects___EventsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Hospice_Projects___EventsBindingNavigator.Size = New System.Drawing.Size(662, 25)
        Me.Hospice_Projects___EventsBindingNavigator.TabIndex = 15
        Me.Hospice_Projects___EventsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Hospice_Projects___EventsBindingNavigatorSaveItem
        '
        Me.Hospice_Projects___EventsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Hospice_Projects___EventsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Hospice_Projects___EventsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Hospice_Projects___EventsBindingNavigatorSaveItem.Name = "Hospice_Projects___EventsBindingNavigatorSaveItem"
        Me.Hospice_Projects___EventsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Hospice_Projects___EventsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Hospice_Projects___EventsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(66, 51)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 16
        '
        'ProjectsTextBox
        '
        Me.ProjectsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Hospice_Projects___EventsBindingSource, "Projects", True))
        Me.ProjectsTextBox.Location = New System.Drawing.Point(66, 77)
        Me.ProjectsTextBox.Name = "ProjectsTextBox"
        Me.ProjectsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProjectsTextBox.TabIndex = 18
        '
        'EventsTextBox
        '
        Me.EventsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Hospice_Projects___EventsBindingSource, "Events", True))
        Me.EventsTextBox.Location = New System.Drawing.Point(66, 103)
        Me.EventsTextBox.Name = "EventsTextBox"
        Me.EventsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EventsTextBox.TabIndex = 20
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ProjectsDataGridViewTextBoxColumn, Me.EventsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Hospice_Projects___EventsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(182, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(462, 150)
        Me.DataGridView1.TabIndex = 21
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'ProjectsDataGridViewTextBoxColumn
        '
        Me.ProjectsDataGridViewTextBoxColumn.DataPropertyName = "Projects"
        Me.ProjectsDataGridViewTextBoxColumn.HeaderText = "Projects"
        Me.ProjectsDataGridViewTextBoxColumn.Name = "ProjectsDataGridViewTextBoxColumn"
        '
        'EventsDataGridViewTextBoxColumn
        '
        Me.EventsDataGridViewTextBoxColumn.DataPropertyName = "Events"
        Me.EventsDataGridViewTextBoxColumn.HeaderText = "Events"
        Me.EventsDataGridViewTextBoxColumn.Name = "EventsDataGridViewTextBoxColumn"
        '
        'Hospice_Projects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(662, 385)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(ProjectsLabel)
        Me.Controls.Add(Me.ProjectsTextBox)
        Me.Controls.Add(EventsLabel)
        Me.Controls.Add(Me.EventsTextBox)
        Me.Controls.Add(Me.Hospice_Projects___EventsBindingNavigator)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnenter)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "Hospice_Projects"
        Me.Text = "Hospice_Projects"
        CType(Me.PalliativecareunitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospice_Projects___EventsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hospice_Projects___EventsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Hospice_Projects___EventsBindingNavigator.ResumeLayout(False)
        Me.Hospice_Projects___EventsBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnenter As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents PalliativecareunitDataSet As splashform.PalliativecareunitDataSet
    Friend WithEvents Hospice_Projects___EventsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Hospice_Projects___EventsTableAdapter As splashform.PalliativecareunitDataSetTableAdapters.Hospice_Projects___EventsTableAdapter
    Friend WithEvents TableAdapterManager As splashform.PalliativecareunitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Hospice_Projects___EventsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Hospice_Projects___EventsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProjectsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EventsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
