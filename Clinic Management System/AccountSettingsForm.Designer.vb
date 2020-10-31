<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountSettingsForm
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
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim UserTypeLabel As System.Windows.Forms.Label
        Dim BirthDateLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim HouseNumberLabel As System.Windows.Forms.Label
        Dim StreetLabel As System.Windows.Forms.Label
        Dim BarangayLabel As System.Windows.Forms.Label
        Dim City_MunicipalityLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountSettingsForm))
        Me.tipAccountSettings = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.dgvUserAccounts = New System.Windows.Forms.DataGridView()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewUserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicMgtDbDataSet = New Clinic_Management_System.ClinicMgtDbDataSet()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chkVisible = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.UserAccountsTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.UserAccountsTableAdapter()
        Me.TableAdapterManager = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager()
        Me.ViewUserAccountsTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.ViewUserAccountsTableAdapter()
        Me.EmployeeTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.EmployeeTableAdapter()
        Me.TextBoxUserID = New System.Windows.Forms.TextBox()
        Me.BirthDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.HouseNumberTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.BarangayTextBox = New System.Windows.Forms.TextBox()
        Me.City_MunicipalityTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        UserIDLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        UserTypeLabel = New System.Windows.Forms.Label()
        BirthDateLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        HouseNumberLabel = New System.Windows.Forms.Label()
        StreetLabel = New System.Windows.Forms.Label()
        BarangayLabel = New System.Windows.Forms.Label()
        City_MunicipalityLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUserAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(767, 74)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(89, 24)
        UserIDLabel.TabIndex = 41
        UserIDLabel.Text = "User ID:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(740, 112)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(116, 24)
        PasswordLabel.TabIndex = 43
        PasswordLabel.Text = "Password:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(731, 216)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(125, 24)
        FirstNameLabel.TabIndex = 45
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(732, 254)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(124, 24)
        LastNameLabel.TabIndex = 47
        LastNameLabel.Text = "Last Name:"
        '
        'UserTypeLabel
        '
        UserTypeLabel.AutoSize = True
        UserTypeLabel.Location = New System.Drawing.Point(740, 150)
        UserTypeLabel.Name = "UserTypeLabel"
        UserTypeLabel.Size = New System.Drawing.Size(116, 24)
        UserTypeLabel.TabIndex = 49
        UserTypeLabel.Text = "User Type:"
        '
        'BirthDateLabel
        '
        BirthDateLabel.AutoSize = True
        BirthDateLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BirthDateLabel.Location = New System.Drawing.Point(739, 297)
        BirthDateLabel.Name = "BirthDateLabel"
        BirthDateLabel.Size = New System.Drawing.Size(117, 24)
        BirthDateLabel.TabIndex = 69
        BirthDateLabel.Text = "Birth Date:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(765, 332)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(91, 24)
        GenderLabel.TabIndex = 71
        GenderLabel.Text = "Gender:"
        '
        'HouseNumberLabel
        '
        HouseNumberLabel.AutoSize = True
        HouseNumberLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HouseNumberLabel.Location = New System.Drawing.Point(736, 370)
        HouseNumberLabel.Name = "HouseNumberLabel"
        HouseNumberLabel.Size = New System.Drawing.Size(120, 24)
        HouseNumberLabel.TabIndex = 73
        HouseNumberLabel.Text = "House No.:"
        '
        'StreetLabel
        '
        StreetLabel.AutoSize = True
        StreetLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StreetLabel.Location = New System.Drawing.Point(777, 408)
        StreetLabel.Name = "StreetLabel"
        StreetLabel.Size = New System.Drawing.Size(77, 24)
        StreetLabel.TabIndex = 75
        StreetLabel.Text = "Street:"
        '
        'BarangayLabel
        '
        BarangayLabel.AutoSize = True
        BarangayLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BarangayLabel.Location = New System.Drawing.Point(743, 446)
        BarangayLabel.Name = "BarangayLabel"
        BarangayLabel.Size = New System.Drawing.Size(113, 24)
        BarangayLabel.TabIndex = 77
        BarangayLabel.Text = "Barangay:"
        '
        'City_MunicipalityLabel
        '
        City_MunicipalityLabel.AutoSize = True
        City_MunicipalityLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        City_MunicipalityLabel.Location = New System.Drawing.Point(801, 484)
        City_MunicipalityLabel.Name = "City_MunicipalityLabel"
        City_MunicipalityLabel.Size = New System.Drawing.Size(55, 24)
        City_MunicipalityLabel.TabIndex = 79
        City_MunicipalityLabel.Text = "City:"
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactNumberLabel.Location = New System.Drawing.Point(721, 522)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(135, 24)
        ContactNumberLabel.TabIndex = 81
        ContactNumberLabel.Text = "Contact No.:"
        '
        'btnBack
        '
        Me.btnBack.AutoSize = True
        Me.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBack
        Me.btnBack.Location = New System.Drawing.Point(1150, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(38, 38)
        Me.btnBack.TabIndex = 38
        Me.btnBack.TabStop = False
        Me.tipAccountSettings.SetToolTip(Me.btnBack, "Back")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblDateTime)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.picLogo)
        Me.pnlHeader.Location = New System.Drawing.Point(13, 12)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(555, 125)
        Me.pnlHeader.TabIndex = 12
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDateTime.Location = New System.Drawing.Point(151, 96)
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(5)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(240, 24)
        Me.lblDateTime.TabIndex = 2
        Me.lblDateTime.Text = "12/31/9999     88:88 AM"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Location = New System.Drawing.Point(147, 3)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(399, 88)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Barangay Clinic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'picLogo
        '
        Me.picLogo.BackgroundImage = Global.Clinic_Management_System.My.Resources.Resources.Logo
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogo.Location = New System.Drawing.Point(4, 3)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(138, 119)
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'timClock
        '
        '
        'dgvUserAccounts
        '
        Me.dgvUserAccounts.AllowUserToAddRows = False
        Me.dgvUserAccounts.AllowUserToDeleteRows = False
        Me.dgvUserAccounts.AllowUserToOrderColumns = True
        Me.dgvUserAccounts.AllowUserToResizeColumns = False
        Me.dgvUserAccounts.AllowUserToResizeRows = False
        Me.dgvUserAccounts.AutoGenerateColumns = False
        Me.dgvUserAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvUserAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvUserAccounts.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.dgvUserAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUserAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUserAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.UserTypeDataGridViewTextBoxColumn})
        Me.dgvUserAccounts.DataSource = Me.ViewUserAccountsBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUserAccounts.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvUserAccounts.Location = New System.Drawing.Point(19, 244)
        Me.dgvUserAccounts.Margin = New System.Windows.Forms.Padding(10)
        Me.dgvUserAccounts.MultiSelect = False
        Me.dgvUserAccounts.Name = "dgvUserAccounts"
        Me.dgvUserAccounts.ReadOnly = True
        Me.dgvUserAccounts.RowHeadersVisible = False
        Me.dgvUserAccounts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvUserAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserAccounts.Size = New System.Drawing.Size(589, 387)
        Me.dgvUserAccounts.TabIndex = 39
        Me.dgvUserAccounts.TabStop = False
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.UserIDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "User ID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.Width = 117
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.PasswordDataGridViewTextBoxColumn.Visible = False
        Me.PasswordDataGridViewTextBoxColumn.Width = 144
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.NameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserTypeDataGridViewTextBoxColumn
        '
        Me.UserTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UserTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.UserTypeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.UserTypeDataGridViewTextBoxColumn.HeaderText = "User Type"
        Me.UserTypeDataGridViewTextBoxColumn.Name = "UserTypeDataGridViewTextBoxColumn"
        Me.UserTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserTypeDataGridViewTextBoxColumn.Width = 144
        '
        'ViewUserAccountsBindingSource
        '
        Me.ViewUserAccountsBindingSource.DataMember = "ViewUserAccounts"
        Me.ViewUserAccountsBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'ClinicMgtDbDataSet
        '
        Me.ClinicMgtDbDataSet.DataSetName = "ClinicMgtDbDataSet"
        Me.ClinicMgtDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(43, 202)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(151, 24)
        Me.lblSearch.TabIndex = 40
        Me.lblSearch.Text = "Search Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(200, 199)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(300, 32)
        Me.NameTextBox.TabIndex = 0
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "Password", True))
        Me.PasswordTextBox.Enabled = False
        Me.PasswordTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(862, 109)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(178, 32)
        Me.PasswordTextBox.TabIndex = 2
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'UserAccountsBindingSource
        '
        Me.UserAccountsBindingSource.DataMember = "UserAccounts"
        Me.UserAccountsBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Enabled = False
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(862, 213)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(250, 32)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "LastName", True))
        Me.LastNameTextBox.Enabled = False
        Me.LastNameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(862, 251)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(250, 32)
        Me.LastNameTextBox.TabIndex = 5
        '
        'UserTypeComboBox
        '
        Me.UserTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "UserType", True))
        Me.UserTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserTypeComboBox.Enabled = False
        Me.UserTypeComboBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTypeComboBox.FormattingEnabled = True
        Me.UserTypeComboBox.Items.AddRange(New Object() {"Social Worker", "Doctor", "Administrator"})
        Me.UserTypeComboBox.Location = New System.Drawing.Point(862, 147)
        Me.UserTypeComboBox.Name = "UserTypeComboBox"
        Me.UserTypeComboBox.Size = New System.Drawing.Size(250, 32)
        Me.UserTypeComboBox.TabIndex = 3
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "UserAccountsEmployee"
        Me.EmployeeBindingSource.DataSource = Me.UserAccountsBindingSource
        '
        'chkVisible
        '
        Me.chkVisible.AutoSize = True
        Me.chkVisible.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVisible.Location = New System.Drawing.Point(1046, 116)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Size = New System.Drawing.Size(66, 20)
        Me.chkVisible.TabIndex = 66
        Me.chkVisible.TabStop = False
        Me.chkVisible.Text = "Visible"
        Me.chkVisible.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.Enabled = False
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.Clinic_Management_System.My.Resources.Resources.btnSave
        Me.btnSave.Location = New System.Drawing.Point(905, 570)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 52)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "UserID", True))
        Me.UserIDTextBox.Enabled = False
        Me.UserIDTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDTextBox.Location = New System.Drawing.Point(862, 71)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(250, 32)
        Me.UserIDTextBox.TabIndex = 1
        '
        'UserAccountsTableAdapter
        '
        Me.UserAccountsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorPrescriptionTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.MedicineStocksTableAdapter = Nothing
        Me.TableAdapterManager.MedicineTableAdapter = Nothing
        Me.TableAdapterManager.MedTypeTableAdapter = Nothing
        Me.TableAdapterManager.PatientInfoTableAdapter = Nothing
        Me.TableAdapterManager.PatientRecordsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserAccountsTableAdapter = Me.UserAccountsTableAdapter
        Me.TableAdapterManager.WaitListTableAdapter = Nothing
        '
        'ViewUserAccountsTableAdapter
        '
        Me.ViewUserAccountsTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TextBoxUserID
        '
        Me.TextBoxUserID.Enabled = False
        Me.TextBoxUserID.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUserID.Location = New System.Drawing.Point(862, 71)
        Me.TextBoxUserID.Name = "TextBoxUserID"
        Me.TextBoxUserID.Size = New System.Drawing.Size(250, 32)
        Me.TextBoxUserID.TabIndex = 67
        Me.TextBoxUserID.TabStop = False
        '
        'BirthDateDateTimePicker
        '
        Me.BirthDateDateTimePicker.CustomFormat = "MMMM dd, yyyy"
        Me.BirthDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "BirthDate", True))
        Me.BirthDateDateTimePicker.Enabled = False
        Me.BirthDateDateTimePicker.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BirthDateDateTimePicker.Location = New System.Drawing.Point(862, 291)
        Me.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker"
        Me.BirthDateDateTimePicker.Size = New System.Drawing.Size(250, 32)
        Me.BirthDateDateTimePicker.TabIndex = 6
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Gender", True))
        Me.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderComboBox.Enabled = False
        Me.GenderComboBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(862, 329)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(250, 32)
        Me.GenderComboBox.TabIndex = 7
        '
        'HouseNumberTextBox
        '
        Me.HouseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "HouseNumber", True))
        Me.HouseNumberTextBox.Enabled = False
        Me.HouseNumberTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HouseNumberTextBox.Location = New System.Drawing.Point(862, 367)
        Me.HouseNumberTextBox.Name = "HouseNumberTextBox"
        Me.HouseNumberTextBox.Size = New System.Drawing.Size(250, 32)
        Me.HouseNumberTextBox.TabIndex = 8
        '
        'StreetTextBox
        '
        Me.StreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Street", True))
        Me.StreetTextBox.Enabled = False
        Me.StreetTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StreetTextBox.Location = New System.Drawing.Point(862, 405)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(250, 32)
        Me.StreetTextBox.TabIndex = 9
        '
        'BarangayTextBox
        '
        Me.BarangayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Barangay", True))
        Me.BarangayTextBox.Enabled = False
        Me.BarangayTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarangayTextBox.Location = New System.Drawing.Point(862, 443)
        Me.BarangayTextBox.Name = "BarangayTextBox"
        Me.BarangayTextBox.Size = New System.Drawing.Size(250, 32)
        Me.BarangayTextBox.TabIndex = 10
        '
        'City_MunicipalityTextBox
        '
        Me.City_MunicipalityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "City/Municipality", True))
        Me.City_MunicipalityTextBox.Enabled = False
        Me.City_MunicipalityTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City_MunicipalityTextBox.Location = New System.Drawing.Point(862, 481)
        Me.City_MunicipalityTextBox.Name = "City_MunicipalityTextBox"
        Me.City_MunicipalityTextBox.Size = New System.Drawing.Size(250, 32)
        Me.City_MunicipalityTextBox.TabIndex = 11
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "ContactNumber", True))
        Me.ContactNumberTextBox.Enabled = False
        Me.ContactNumberTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(862, 519)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(250, 32)
        Me.ContactNumberTextBox.TabIndex = 12
        '
        'btnNew
        '
        Me.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNew.BackColor = System.Drawing.Color.Green
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(543, 199)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(65, 32)
        Me.btnNew.TabIndex = 83
        Me.btnNew.TabStop = False
        Me.btnNew.Text = "New"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'AccountSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(BirthDateLabel)
        Me.Controls.Add(Me.BirthDateDateTimePicker)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(HouseNumberLabel)
        Me.Controls.Add(Me.HouseNumberTextBox)
        Me.Controls.Add(StreetLabel)
        Me.Controls.Add(Me.StreetTextBox)
        Me.Controls.Add(BarangayLabel)
        Me.Controls.Add(Me.BarangayTextBox)
        Me.Controls.Add(City_MunicipalityLabel)
        Me.Controls.Add(Me.City_MunicipalityTextBox)
        Me.Controls.Add(ContactNumberLabel)
        Me.Controls.Add(Me.ContactNumberTextBox)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkVisible)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(UserTypeLabel)
        Me.Controls.Add(Me.UserTypeComboBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.dgvUserAccounts)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.TextBoxUserID)
        Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "AccountSettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUserAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tipAccountSettings As System.Windows.Forms.ToolTip
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents ClinicMgtDbDataSet As Clinic_Management_System.ClinicMgtDbDataSet
    Friend WithEvents UserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserAccountsTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.UserAccountsTableAdapter
    Friend WithEvents TableAdapterManager As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvUserAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents ViewUserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewUserAccountsTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.ViewUserAccountsTableAdapter
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents chkVisible As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUserID As System.Windows.Forms.TextBox
    Friend WithEvents BirthDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HouseNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StreetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BarangayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents City_MunicipalityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
