<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Details
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
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Second_NameLabel As System.Windows.Forms.Label
        Dim Maritual_StatusLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim ResidenceLabel As System.Windows.Forms.Label
        Dim Employee_StatusLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnenter = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PalliativecareunitDataSet = New splashform.PalliativecareunitDataSet()
        Me.Employee_detailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employee_detailsTableAdapter = New splashform.PalliativecareunitDataSetTableAdapters.Employee_detailsTableAdapter()
        Me.TableAdapterManager = New splashform.PalliativecareunitDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Second_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Maritual_StatusTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.ResidenceTextBox = New System.Windows.Forms.TextBox()
        Me.Employee_StatusTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecondNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaritualStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Second_NameLabel = New System.Windows.Forms.Label()
        Maritual_StatusLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        ResidenceLabel = New System.Windows.Forms.Label()
        Employee_StatusLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PalliativecareunitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_detailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(32, 19)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 22
        IDLabel.Text = "ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(32, 48)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 24
        First_NameLabel.Text = "First Name:"
        AddHandler First_NameLabel.Click, AddressOf Me.First_NameLabel_Click
        '
        'Second_NameLabel
        '
        Second_NameLabel.AutoSize = True
        Second_NameLabel.Location = New System.Drawing.Point(32, 74)
        Second_NameLabel.Name = "Second_NameLabel"
        Second_NameLabel.Size = New System.Drawing.Size(78, 13)
        Second_NameLabel.TabIndex = 26
        Second_NameLabel.Text = "Second Name:"
        AddHandler Second_NameLabel.Click, AddressOf Me.Second_NameLabel_Click
        '
        'Maritual_StatusLabel
        '
        Maritual_StatusLabel.AutoSize = True
        Maritual_StatusLabel.Location = New System.Drawing.Point(32, 100)
        Maritual_StatusLabel.Name = "Maritual_StatusLabel"
        Maritual_StatusLabel.Size = New System.Drawing.Size(80, 13)
        Maritual_StatusLabel.TabIndex = 28
        Maritual_StatusLabel.Text = "Maritual Status:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(32, 126)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 30
        GenderLabel.Text = "Gender:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(32, 152)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 32
        AgeLabel.Text = "Age:"
        '
        'ResidenceLabel
        '
        ResidenceLabel.AutoSize = True
        ResidenceLabel.Location = New System.Drawing.Point(32, 178)
        ResidenceLabel.Name = "ResidenceLabel"
        ResidenceLabel.Size = New System.Drawing.Size(61, 13)
        ResidenceLabel.TabIndex = 34
        ResidenceLabel.Text = "Residence:"
        '
        'Employee_StatusLabel
        '
        Employee_StatusLabel.AutoSize = True
        Employee_StatusLabel.Location = New System.Drawing.Point(32, 204)
        Employee_StatusLabel.Name = "Employee_StatusLabel"
        Employee_StatusLabel.Size = New System.Drawing.Size(89, 13)
        Employee_StatusLabel.TabIndex = 36
        Employee_StatusLabel.Text = "Employee Status:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(32, 230)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 38
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(32, 256)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 40
        PasswordLabel.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 2
        '
        'btnenter
        '
        Me.btnenter.Location = New System.Drawing.Point(883, 204)
        Me.btnenter.Name = "btnenter"
        Me.btnenter.Size = New System.Drawing.Size(75, 39)
        Me.btnenter.TabIndex = 6
        Me.btnenter.Text = "Save Record"
        Me.btnenter.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(883, 294)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 39)
        Me.btnclear.TabIndex = 7
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(883, 256)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 32)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.splashform.My.Resources.Resources.is__2_
        Me.PictureBox1.Location = New System.Drawing.Point(259, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(711, 172)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'PalliativecareunitDataSet
        '
        Me.PalliativecareunitDataSet.DataSetName = "PalliativecareunitDataSet"
        Me.PalliativecareunitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Employee_detailsBindingSource
        '
        Me.Employee_detailsBindingSource.DataMember = "Employee details"
        Me.Employee_detailsBindingSource.DataSource = Me.PalliativecareunitDataSet
        '
        'Employee_detailsTableAdapter
        '
        Me.Employee_detailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Employee_detailsTableAdapter = Me.Employee_detailsTableAdapter
        Me.TableAdapterManager.Hospice_Projects___EventsTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Patient_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = splashform.PalliativecareunitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_detailsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(127, 19)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 23
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_detailsBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(127, 45)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 25
        '
        'Second_NameTextBox
        '
        Me.Second_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_detailsBindingSource, "Second Name", True))
        Me.Second_NameTextBox.Location = New System.Drawing.Point(127, 71)
        Me.Second_NameTextBox.Name = "Second_NameTextBox"
        Me.Second_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Second_NameTextBox.TabIndex = 27
        '
        'Maritual_StatusTextBox
        '
        Me.Maritual_StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_detailsBindingSource, "Maritual Status", True))
        Me.Maritual_StatusTextBox.Location = New System.Drawing.Point(127, 97)
        Me.Maritual_StatusTextBox.Name = "Maritual_StatusTextBox"
        Me.Maritual_StatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Maritual_StatusTextBox.TabIndex = 29
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_detailsBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(127, 123)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenderTextBox.TabIndex = 31
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_detailsBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(127, 149)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AgeTextBox.TabIndex = 33
        '
        'ResidenceTextBox
        '
        Me.ResidenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_detailsBindingSource, "Residence", True))
        Me.ResidenceTextBox.Location = New System.Drawing.Point(127, 175)
        Me.ResidenceTextBox.Name = "ResidenceTextBox"
        Me.ResidenceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ResidenceTextBox.TabIndex = 35
        '
        'Employee_StatusTextBox
        '
        Me.Employee_StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_detailsBindingSource, "Employee Status", True))
        Me.Employee_StatusTextBox.Location = New System.Drawing.Point(127, 201)
        Me.Employee_StatusTextBox.Name = "Employee_StatusTextBox"
        Me.Employee_StatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Employee_StatusTextBox.TabIndex = 37
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_detailsBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(127, 227)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 39
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_detailsBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(127, 253)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 41
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(883, 356)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 40)
        Me.btndelete.TabIndex = 43
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(883, 417)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(87, 40)
        Me.btnadd.TabIndex = 45
        Me.btnadd.Text = "Add new record"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.SecondNameDataGridViewTextBoxColumn, Me.MaritualStatusDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.ResidenceDataGridViewTextBoxColumn, Me.EmployeeStatusDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Employee_detailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(246, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(608, 276)
        Me.DataGridView1.TabIndex = 46
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'SecondNameDataGridViewTextBoxColumn
        '
        Me.SecondNameDataGridViewTextBoxColumn.DataPropertyName = "Second Name"
        Me.SecondNameDataGridViewTextBoxColumn.HeaderText = "Second Name"
        Me.SecondNameDataGridViewTextBoxColumn.Name = "SecondNameDataGridViewTextBoxColumn"
        '
        'MaritualStatusDataGridViewTextBoxColumn
        '
        Me.MaritualStatusDataGridViewTextBoxColumn.DataPropertyName = "Maritual Status"
        Me.MaritualStatusDataGridViewTextBoxColumn.HeaderText = "Maritual Status"
        Me.MaritualStatusDataGridViewTextBoxColumn.Name = "MaritualStatusDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'ResidenceDataGridViewTextBoxColumn
        '
        Me.ResidenceDataGridViewTextBoxColumn.DataPropertyName = "Residence"
        Me.ResidenceDataGridViewTextBoxColumn.HeaderText = "Residence"
        Me.ResidenceDataGridViewTextBoxColumn.Name = "ResidenceDataGridViewTextBoxColumn"
        '
        'EmployeeStatusDataGridViewTextBoxColumn
        '
        Me.EmployeeStatusDataGridViewTextBoxColumn.DataPropertyName = "Employee Status"
        Me.EmployeeStatusDataGridViewTextBoxColumn.HeaderText = "Employee Status"
        Me.EmployeeStatusDataGridViewTextBoxColumn.Name = "EmployeeStatusDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'Employee_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 527)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Second_NameLabel)
        Me.Controls.Add(Me.Second_NameTextBox)
        Me.Controls.Add(Maritual_StatusLabel)
        Me.Controls.Add(Me.Maritual_StatusTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(ResidenceLabel)
        Me.Controls.Add(Me.ResidenceTextBox)
        Me.Controls.Add(Employee_StatusLabel)
        Me.Controls.Add(Me.Employee_StatusTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnenter)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Employee_Details"
        Me.Text = "Employee_Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PalliativecareunitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_detailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnenter As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PalliativecareunitDataSet As splashform.PalliativecareunitDataSet
    Friend WithEvents Employee_detailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Employee_detailsTableAdapter As splashform.PalliativecareunitDataSetTableAdapters.Employee_detailsTableAdapter
    Friend WithEvents TableAdapterManager As splashform.PalliativecareunitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Second_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Maritual_StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ResidenceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Employee_StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecondNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaritualStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResidenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
