<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_Details
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
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Marital__StatusLabel As System.Windows.Forms.Label
        Dim ResidenceLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim HeightLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim PressureLabel As System.Windows.Forms.Label
        Dim DiagnosisLabel As System.Windows.Forms.Label
        Dim TreatmentLabel As System.Windows.Forms.Label
        Dim Registration_feeLabel As System.Windows.Forms.Label
        Dim Consultation_feeLabel As System.Windows.Forms.Label
        Dim Laboratory_feeLabel As System.Windows.Forms.Label
        Dim X_RAY_feeLabel As System.Windows.Forms.Label
        Dim Scanning_feeLabel As System.Windows.Forms.Label
        Dim Medication_feeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_Details))
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_Name = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Marital__StatusTextBox = New System.Windows.Forms.TextBox()
        Me.ResidenceTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.PressureTextBox = New System.Windows.Forms.TextBox()
        Me.DiagnosisTextBox = New System.Windows.Forms.TextBox()
        Me.TreatmentTextBox = New System.Windows.Forms.TextBox()
        Me.Registration_feeTextBox = New System.Windows.Forms.TextBox()
        Me.Consultation_feeTextBox = New System.Windows.Forms.TextBox()
        Me.Laboratory_feeTextBox = New System.Windows.Forms.TextBox()
        Me.X_RAY_feeTextBox = New System.Windows.Forms.TextBox()
        Me.Scanning_feeTextBox = New System.Windows.Forms.TextBox()
        Me.Medication_feeTextBox = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.searchbox = New System.Windows.Forms.TextBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.Total = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaritalStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PressureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiagnosisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TreatmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsultationFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaboratoryFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XRAYFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScanningFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicationFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Patient_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PalliativecareunitDataSet = New splashform.PalliativecareunitDataSet()
        Me.Patient_DetailsTableAdapter = New splashform.PalliativecareunitDataSetTableAdapters.Patient_DetailsTableAdapter()
        Me.TableAdapterManager = New splashform.PalliativecareunitDataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Marital__StatusLabel = New System.Windows.Forms.Label()
        ResidenceLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        HeightLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        PressureLabel = New System.Windows.Forms.Label()
        DiagnosisLabel = New System.Windows.Forms.Label()
        TreatmentLabel = New System.Windows.Forms.Label()
        Registration_feeLabel = New System.Windows.Forms.Label()
        Consultation_feeLabel = New System.Windows.Forms.Label()
        Laboratory_feeLabel = New System.Windows.Forms.Label()
        X_RAY_feeLabel = New System.Windows.Forms.Label()
        Scanning_feeLabel = New System.Windows.Forms.Label()
        Medication_feeLabel = New System.Windows.Forms.Label()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.Patient_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PalliativecareunitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(89, 36)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 25
        IDLabel.Text = "ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(89, 62)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 27
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(89, 88)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 29
        Last_NameLabel.Text = "Last Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(89, 114)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 31
        GenderLabel.Text = "Gender:"
        '
        'Marital__StatusLabel
        '
        Marital__StatusLabel.AutoSize = True
        Marital__StatusLabel.Location = New System.Drawing.Point(89, 140)
        Marital__StatusLabel.Name = "Marital__StatusLabel"
        Marital__StatusLabel.Size = New System.Drawing.Size(77, 13)
        Marital__StatusLabel.TabIndex = 33
        Marital__StatusLabel.Text = "Marital  Status:"
        '
        'ResidenceLabel
        '
        ResidenceLabel.AutoSize = True
        ResidenceLabel.Location = New System.Drawing.Point(89, 166)
        ResidenceLabel.Name = "ResidenceLabel"
        ResidenceLabel.Size = New System.Drawing.Size(61, 13)
        ResidenceLabel.TabIndex = 35
        ResidenceLabel.Text = "Residence:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(89, 192)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 37
        AgeLabel.Text = "Age:"
        '
        'HeightLabel
        '
        HeightLabel.AutoSize = True
        HeightLabel.Location = New System.Drawing.Point(89, 218)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New System.Drawing.Size(41, 13)
        HeightLabel.TabIndex = 39
        HeightLabel.Text = "Height:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(89, 244)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 41
        WeightLabel.Text = "Weight:"
        '
        'PressureLabel
        '
        PressureLabel.AutoSize = True
        PressureLabel.Location = New System.Drawing.Point(392, 40)
        PressureLabel.Name = "PressureLabel"
        PressureLabel.Size = New System.Drawing.Size(51, 13)
        PressureLabel.TabIndex = 43
        PressureLabel.Text = "Pressure:"
        '
        'DiagnosisLabel
        '
        DiagnosisLabel.AutoSize = True
        DiagnosisLabel.Location = New System.Drawing.Point(392, 66)
        DiagnosisLabel.Name = "DiagnosisLabel"
        DiagnosisLabel.Size = New System.Drawing.Size(56, 13)
        DiagnosisLabel.TabIndex = 45
        DiagnosisLabel.Text = "Diagnosis:"
        '
        'TreatmentLabel
        '
        TreatmentLabel.AutoSize = True
        TreatmentLabel.Location = New System.Drawing.Point(392, 92)
        TreatmentLabel.Name = "TreatmentLabel"
        TreatmentLabel.Size = New System.Drawing.Size(58, 13)
        TreatmentLabel.TabIndex = 47
        TreatmentLabel.Text = "Treatment:"
        '
        'Registration_feeLabel
        '
        Registration_feeLabel.AutoSize = True
        Registration_feeLabel.Location = New System.Drawing.Point(648, 37)
        Registration_feeLabel.Name = "Registration_feeLabel"
        Registration_feeLabel.Size = New System.Drawing.Size(84, 13)
        Registration_feeLabel.TabIndex = 49
        Registration_feeLabel.Text = "Registration fee:"
        '
        'Consultation_feeLabel
        '
        Consultation_feeLabel.AutoSize = True
        Consultation_feeLabel.Location = New System.Drawing.Point(648, 63)
        Consultation_feeLabel.Name = "Consultation_feeLabel"
        Consultation_feeLabel.Size = New System.Drawing.Size(86, 13)
        Consultation_feeLabel.TabIndex = 51
        Consultation_feeLabel.Text = "Consultation fee:"
        '
        'Laboratory_feeLabel
        '
        Laboratory_feeLabel.AutoSize = True
        Laboratory_feeLabel.Location = New System.Drawing.Point(648, 89)
        Laboratory_feeLabel.Name = "Laboratory_feeLabel"
        Laboratory_feeLabel.Size = New System.Drawing.Size(78, 13)
        Laboratory_feeLabel.TabIndex = 53
        Laboratory_feeLabel.Text = "Laboratory fee:"
        '
        'X_RAY_feeLabel
        '
        X_RAY_feeLabel.AutoSize = True
        X_RAY_feeLabel.Location = New System.Drawing.Point(648, 115)
        X_RAY_feeLabel.Name = "X_RAY_feeLabel"
        X_RAY_feeLabel.Size = New System.Drawing.Size(60, 13)
        X_RAY_feeLabel.TabIndex = 55
        X_RAY_feeLabel.Text = "X-RAY fee:"
        '
        'Scanning_feeLabel
        '
        Scanning_feeLabel.AutoSize = True
        Scanning_feeLabel.Location = New System.Drawing.Point(648, 141)
        Scanning_feeLabel.Name = "Scanning_feeLabel"
        Scanning_feeLabel.Size = New System.Drawing.Size(73, 13)
        Scanning_feeLabel.TabIndex = 57
        Scanning_feeLabel.Text = "Scanning fee:"
        '
        'Medication_feeLabel
        '
        Medication_feeLabel.AutoSize = True
        Medication_feeLabel.Location = New System.Drawing.Point(646, 170)
        Medication_feeLabel.Name = "Medication_feeLabel"
        Medication_feeLabel.Size = New System.Drawing.Size(80, 13)
        Medication_feeLabel.TabIndex = 59
        Medication_feeLabel.Text = "Medication fee:"
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(509, 546)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 21
        Me.btnsave.Text = "Save record"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(633, 546)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 23
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(767, 546)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 24
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.Patient_DetailsBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(899, 25)
        Me.BindingNavigator1.TabIndex = 25
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(181, 33)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 26
        '
        'First_Name
        '
        Me.First_Name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "First Name", True))
        Me.First_Name.Location = New System.Drawing.Point(181, 59)
        Me.First_Name.Name = "First_Name"
        Me.First_Name.Size = New System.Drawing.Size(100, 20)
        Me.First_Name.TabIndex = 28
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(181, 85)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 30
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(181, 111)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenderTextBox.TabIndex = 32
        '
        'Marital__StatusTextBox
        '
        Me.Marital__StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Marital  Status", True))
        Me.Marital__StatusTextBox.Location = New System.Drawing.Point(181, 137)
        Me.Marital__StatusTextBox.Name = "Marital__StatusTextBox"
        Me.Marital__StatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Marital__StatusTextBox.TabIndex = 34
        '
        'ResidenceTextBox
        '
        Me.ResidenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Residence", True))
        Me.ResidenceTextBox.Location = New System.Drawing.Point(181, 163)
        Me.ResidenceTextBox.Name = "ResidenceTextBox"
        Me.ResidenceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ResidenceTextBox.TabIndex = 36
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(181, 189)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AgeTextBox.TabIndex = 38
        '
        'HeightTextBox
        '
        Me.HeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Height", True))
        Me.HeightTextBox.Location = New System.Drawing.Point(181, 215)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HeightTextBox.TabIndex = 40
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(181, 241)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WeightTextBox.TabIndex = 42
        '
        'PressureTextBox
        '
        Me.PressureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Pressure", True))
        Me.PressureTextBox.Location = New System.Drawing.Point(484, 37)
        Me.PressureTextBox.Name = "PressureTextBox"
        Me.PressureTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PressureTextBox.TabIndex = 44
        '
        'DiagnosisTextBox
        '
        Me.DiagnosisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Diagnosis", True))
        Me.DiagnosisTextBox.Location = New System.Drawing.Point(484, 63)
        Me.DiagnosisTextBox.Name = "DiagnosisTextBox"
        Me.DiagnosisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DiagnosisTextBox.TabIndex = 46
        '
        'TreatmentTextBox
        '
        Me.TreatmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Treatment", True))
        Me.TreatmentTextBox.Location = New System.Drawing.Point(484, 89)
        Me.TreatmentTextBox.Name = "TreatmentTextBox"
        Me.TreatmentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TreatmentTextBox.TabIndex = 48
        '
        'Registration_feeTextBox
        '
        Me.Registration_feeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Registration fee", True))
        Me.Registration_feeTextBox.Location = New System.Drawing.Point(740, 34)
        Me.Registration_feeTextBox.Name = "Registration_feeTextBox"
        Me.Registration_feeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Registration_feeTextBox.TabIndex = 50
        '
        'Consultation_feeTextBox
        '
        Me.Consultation_feeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Consultation fee", True))
        Me.Consultation_feeTextBox.Location = New System.Drawing.Point(740, 60)
        Me.Consultation_feeTextBox.Name = "Consultation_feeTextBox"
        Me.Consultation_feeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Consultation_feeTextBox.TabIndex = 52
        '
        'Laboratory_feeTextBox
        '
        Me.Laboratory_feeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Laboratory fee", True))
        Me.Laboratory_feeTextBox.Location = New System.Drawing.Point(740, 86)
        Me.Laboratory_feeTextBox.Name = "Laboratory_feeTextBox"
        Me.Laboratory_feeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Laboratory_feeTextBox.TabIndex = 54
        '
        'X_RAY_feeTextBox
        '
        Me.X_RAY_feeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "X-RAY fee", True))
        Me.X_RAY_feeTextBox.Location = New System.Drawing.Point(740, 112)
        Me.X_RAY_feeTextBox.Name = "X_RAY_feeTextBox"
        Me.X_RAY_feeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.X_RAY_feeTextBox.TabIndex = 56
        '
        'Scanning_feeTextBox
        '
        Me.Scanning_feeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Scanning fee", True))
        Me.Scanning_feeTextBox.Location = New System.Drawing.Point(740, 138)
        Me.Scanning_feeTextBox.Name = "Scanning_feeTextBox"
        Me.Scanning_feeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Scanning_feeTextBox.TabIndex = 58
        '
        'Medication_feeTextBox
        '
        Me.Medication_feeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_DetailsBindingSource, "Medication fee", True))
        Me.Medication_feeTextBox.Location = New System.Drawing.Point(738, 167)
        Me.Medication_feeTextBox.Name = "Medication_feeTextBox"
        Me.Medication_feeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Medication_feeTextBox.TabIndex = 60
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(12, 321)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 21
        Me.btn_save.Text = "Save records"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.MaritalStatusDataGridViewTextBoxColumn, Me.ResidenceDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.HeightDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.PressureDataGridViewTextBoxColumn, Me.DiagnosisDataGridViewTextBoxColumn, Me.TreatmentDataGridViewTextBoxColumn, Me.RegistrationFeeDataGridViewTextBoxColumn, Me.ConsultationFeeDataGridViewTextBoxColumn, Me.LaboratoryFeeDataGridViewTextBoxColumn, Me.XRAYFeeDataGridViewTextBoxColumn, Me.ScanningFeeDataGridViewTextBoxColumn, Me.MedicationFeeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Patient_DetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 311)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(853, 217)
        Me.DataGridView1.TabIndex = 61
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(395, 546)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 23)
        Me.btnAdd.TabIndex = 62
        Me.btnAdd.Text = "Add new record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Btndelete
        '
        Me.Btndelete.Location = New System.Drawing.Point(233, 546)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(122, 23)
        Me.Btndelete.TabIndex = 64
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'searchbox
        '
        Me.searchbox.Location = New System.Drawing.Point(16, 546)
        Me.searchbox.Multiline = True
        Me.searchbox.Name = "searchbox"
        Me.searchbox.Size = New System.Drawing.Size(168, 20)
        Me.searchbox.TabIndex = 67
        Me.searchbox.Text = "search"
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(635, 221)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(91, 26)
        Me.btnTotal.TabIndex = 68
        Me.btnTotal.Text = "Total charges"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(764, 228)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(36, 13)
        Me.Total.TabIndex = 69
        Me.Total.Text = "Totals"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(16, 572)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(134, 23)
        Me.btnSearch.TabIndex = 70
        Me.btnSearch.Text = "Search records"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(42, 25)
        Me.FillByToolStrip.TabIndex = 71
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
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
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'MaritalStatusDataGridViewTextBoxColumn
        '
        Me.MaritalStatusDataGridViewTextBoxColumn.DataPropertyName = "Marital  Status"
        Me.MaritalStatusDataGridViewTextBoxColumn.HeaderText = "Marital  Status"
        Me.MaritalStatusDataGridViewTextBoxColumn.Name = "MaritalStatusDataGridViewTextBoxColumn"
        '
        'ResidenceDataGridViewTextBoxColumn
        '
        Me.ResidenceDataGridViewTextBoxColumn.DataPropertyName = "Residence"
        Me.ResidenceDataGridViewTextBoxColumn.HeaderText = "Residence"
        Me.ResidenceDataGridViewTextBoxColumn.Name = "ResidenceDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'HeightDataGridViewTextBoxColumn
        '
        Me.HeightDataGridViewTextBoxColumn.DataPropertyName = "Height"
        Me.HeightDataGridViewTextBoxColumn.HeaderText = "Height"
        Me.HeightDataGridViewTextBoxColumn.Name = "HeightDataGridViewTextBoxColumn"
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "Weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "Weight"
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        '
        'PressureDataGridViewTextBoxColumn
        '
        Me.PressureDataGridViewTextBoxColumn.DataPropertyName = "Pressure"
        Me.PressureDataGridViewTextBoxColumn.HeaderText = "Pressure"
        Me.PressureDataGridViewTextBoxColumn.Name = "PressureDataGridViewTextBoxColumn"
        '
        'DiagnosisDataGridViewTextBoxColumn
        '
        Me.DiagnosisDataGridViewTextBoxColumn.DataPropertyName = "Diagnosis"
        Me.DiagnosisDataGridViewTextBoxColumn.HeaderText = "Diagnosis"
        Me.DiagnosisDataGridViewTextBoxColumn.Name = "DiagnosisDataGridViewTextBoxColumn"
        '
        'TreatmentDataGridViewTextBoxColumn
        '
        Me.TreatmentDataGridViewTextBoxColumn.DataPropertyName = "Treatment"
        Me.TreatmentDataGridViewTextBoxColumn.HeaderText = "Treatment"
        Me.TreatmentDataGridViewTextBoxColumn.Name = "TreatmentDataGridViewTextBoxColumn"
        '
        'RegistrationFeeDataGridViewTextBoxColumn
        '
        Me.RegistrationFeeDataGridViewTextBoxColumn.DataPropertyName = "Registration fee"
        Me.RegistrationFeeDataGridViewTextBoxColumn.HeaderText = "Registration fee"
        Me.RegistrationFeeDataGridViewTextBoxColumn.Name = "RegistrationFeeDataGridViewTextBoxColumn"
        '
        'ConsultationFeeDataGridViewTextBoxColumn
        '
        Me.ConsultationFeeDataGridViewTextBoxColumn.DataPropertyName = "Consultation fee"
        Me.ConsultationFeeDataGridViewTextBoxColumn.HeaderText = "Consultation fee"
        Me.ConsultationFeeDataGridViewTextBoxColumn.Name = "ConsultationFeeDataGridViewTextBoxColumn"
        '
        'LaboratoryFeeDataGridViewTextBoxColumn
        '
        Me.LaboratoryFeeDataGridViewTextBoxColumn.DataPropertyName = "Laboratory fee"
        Me.LaboratoryFeeDataGridViewTextBoxColumn.HeaderText = "Laboratory fee"
        Me.LaboratoryFeeDataGridViewTextBoxColumn.Name = "LaboratoryFeeDataGridViewTextBoxColumn"
        '
        'XRAYFeeDataGridViewTextBoxColumn
        '
        Me.XRAYFeeDataGridViewTextBoxColumn.DataPropertyName = "X-RAY fee"
        Me.XRAYFeeDataGridViewTextBoxColumn.HeaderText = "X-RAY fee"
        Me.XRAYFeeDataGridViewTextBoxColumn.Name = "XRAYFeeDataGridViewTextBoxColumn"
        '
        'ScanningFeeDataGridViewTextBoxColumn
        '
        Me.ScanningFeeDataGridViewTextBoxColumn.DataPropertyName = "Scanning fee"
        Me.ScanningFeeDataGridViewTextBoxColumn.HeaderText = "Scanning fee"
        Me.ScanningFeeDataGridViewTextBoxColumn.Name = "ScanningFeeDataGridViewTextBoxColumn"
        '
        'MedicationFeeDataGridViewTextBoxColumn
        '
        Me.MedicationFeeDataGridViewTextBoxColumn.DataPropertyName = "Medication fee"
        Me.MedicationFeeDataGridViewTextBoxColumn.HeaderText = "Medication fee"
        Me.MedicationFeeDataGridViewTextBoxColumn.Name = "MedicationFeeDataGridViewTextBoxColumn"
        '
        'Patient_DetailsBindingSource
        '
        Me.Patient_DetailsBindingSource.DataMember = "Patient Details"
        Me.Patient_DetailsBindingSource.DataSource = Me.PalliativecareunitDataSet
        '
        'PalliativecareunitDataSet
        '
        Me.PalliativecareunitDataSet.DataSetName = "PalliativecareunitDataSet"
        Me.PalliativecareunitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Patient_DetailsTableAdapter
        '
        Me.Patient_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Employee_detailsTableAdapter = Nothing
        Me.TableAdapterManager.Hospice_Projects___EventsTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Patient_DetailsTableAdapter = Me.Patient_DetailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = splashform.PalliativecareunitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Patient_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(899, 615)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.searchbox)
        Me.Controls.Add(Me.Btndelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_Name)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Marital__StatusLabel)
        Me.Controls.Add(Me.Marital__StatusTextBox)
        Me.Controls.Add(ResidenceLabel)
        Me.Controls.Add(Me.ResidenceTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(HeightLabel)
        Me.Controls.Add(Me.HeightTextBox)
        Me.Controls.Add(WeightLabel)
        Me.Controls.Add(Me.WeightTextBox)
        Me.Controls.Add(PressureLabel)
        Me.Controls.Add(Me.PressureTextBox)
        Me.Controls.Add(DiagnosisLabel)
        Me.Controls.Add(Me.DiagnosisTextBox)
        Me.Controls.Add(TreatmentLabel)
        Me.Controls.Add(Me.TreatmentTextBox)
        Me.Controls.Add(Registration_feeLabel)
        Me.Controls.Add(Me.Registration_feeTextBox)
        Me.Controls.Add(Consultation_feeLabel)
        Me.Controls.Add(Me.Consultation_feeTextBox)
        Me.Controls.Add(Laboratory_feeLabel)
        Me.Controls.Add(Me.Laboratory_feeTextBox)
        Me.Controls.Add(X_RAY_feeLabel)
        Me.Controls.Add(Me.X_RAY_feeTextBox)
        Me.Controls.Add(Scanning_feeLabel)
        Me.Controls.Add(Me.Scanning_feeTextBox)
        Me.Controls.Add(Medication_feeLabel)
        Me.Controls.Add(Me.Medication_feeTextBox)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsave)
        Me.Name = "Patient_Details"
        Me.Text = "Patient_Details"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.Patient_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PalliativecareunitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents PalliativecareunitDataSet As splashform.PalliativecareunitDataSet
    Friend WithEvents Patient_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Patient_DetailsTableAdapter As splashform.PalliativecareunitDataSetTableAdapters.Patient_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As splashform.PalliativecareunitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_Name As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Marital__StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ResidenceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PressureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiagnosisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TreatmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Registration_feeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Consultation_feeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Laboratory_feeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents X_RAY_feeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Scanning_feeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Medication_feeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaritalStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResidenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PressureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiagnosisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TreatmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistrationFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsultationFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LaboratoryFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents XRAYFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScanningFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedicationFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
    Friend WithEvents searchbox As System.Windows.Forms.TextBox
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
End Class
