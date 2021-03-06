﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPatientForm
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
        Dim MNameLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim FNameLabel As System.Windows.Forms.Label
        Dim LNameLabel As System.Windows.Forms.Label
        Dim HouseNumberLabel As System.Windows.Forms.Label
        Dim StreetNameLabel As System.Windows.Forms.Label
        Dim BarangayLabel As System.Windows.Forms.Label
        Dim City_MunicipalityLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Contact_NumberLabel As System.Windows.Forms.Label
        Dim BirthDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditPatientForm))
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.timDelay = New System.Windows.Forms.Timer(Me.components)
        Me.ofdBrowsePicture = New System.Windows.Forms.OpenFileDialog()
        Me.tipEditPatient = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBrowsePic = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.MNameTextBox = New System.Windows.Forms.TextBox()
        Me.PatientInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicMgtDbDataSet = New Clinic_Management_System.ClinicMgtDbDataSet()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.FNameTextBox = New System.Windows.Forms.TextBox()
        Me.LNameTextBox = New System.Windows.Forms.TextBox()
        Me.HouseNumberTextBox = New System.Windows.Forms.TextBox()
        Me.StreetNameTextBox = New System.Windows.Forms.TextBox()
        Me.BarangayTextBox = New System.Windows.Forms.TextBox()
        Me.City_MunicipalityTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.Contact_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.BirthDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox()
        Me.PatientInfoTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.PatientInfoTableAdapter()
        Me.TableAdapterManager = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager()
        Me.PicturePathTextBox = New System.Windows.Forms.TextBox()
        MNameLabel = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        FNameLabel = New System.Windows.Forms.Label()
        LNameLabel = New System.Windows.Forms.Label()
        HouseNumberLabel = New System.Windows.Forms.Label()
        StreetNameLabel = New System.Windows.Forms.Label()
        BarangayLabel = New System.Windows.Forms.Label()
        City_MunicipalityLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Contact_NumberLabel = New System.Windows.Forms.Label()
        BirthDateLabel = New System.Windows.Forms.Label()
        CType(Me.PatientInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MNameLabel
        '
        MNameLabel.AutoSize = True
        MNameLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MNameLabel.Location = New System.Drawing.Point(270, 296)
        MNameLabel.Margin = New System.Windows.Forms.Padding(10)
        MNameLabel.Name = "MNameLabel"
        MNameLabel.Size = New System.Drawing.Size(145, 24)
        MNameLabel.TabIndex = 56
        MNameLabel.Text = "Middle Name:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PatientIDLabel.Location = New System.Drawing.Point(270, 192)
        PatientIDLabel.Margin = New System.Windows.Forms.Padding(10)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(113, 24)
        PatientIDLabel.TabIndex = 38
        PatientIDLabel.Text = "Patient ID:"
        '
        'FNameLabel
        '
        FNameLabel.AutoSize = True
        FNameLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FNameLabel.Location = New System.Drawing.Point(270, 244)
        FNameLabel.Margin = New System.Windows.Forms.Padding(10)
        FNameLabel.Name = "FNameLabel"
        FNameLabel.Size = New System.Drawing.Size(125, 24)
        FNameLabel.TabIndex = 45
        FNameLabel.Text = "First Name:"
        '
        'LNameLabel
        '
        LNameLabel.AutoSize = True
        LNameLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LNameLabel.Location = New System.Drawing.Point(270, 348)
        LNameLabel.Margin = New System.Windows.Forms.Padding(10)
        LNameLabel.Name = "LNameLabel"
        LNameLabel.Size = New System.Drawing.Size(124, 24)
        LNameLabel.TabIndex = 47
        LNameLabel.Text = "Last Name:"
        '
        'HouseNumberLabel
        '
        HouseNumberLabel.AutoSize = True
        HouseNumberLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HouseNumberLabel.Location = New System.Drawing.Point(46, 452)
        HouseNumberLabel.Margin = New System.Windows.Forms.Padding(10)
        HouseNumberLabel.Name = "HouseNumberLabel"
        HouseNumberLabel.Size = New System.Drawing.Size(120, 24)
        HouseNumberLabel.TabIndex = 48
        HouseNumberLabel.Text = "House No.:"
        '
        'StreetNameLabel
        '
        StreetNameLabel.AutoSize = True
        StreetNameLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StreetNameLabel.Location = New System.Drawing.Point(270, 452)
        StreetNameLabel.Margin = New System.Windows.Forms.Padding(10)
        StreetNameLabel.Name = "StreetNameLabel"
        StreetNameLabel.Size = New System.Drawing.Size(77, 24)
        StreetNameLabel.TabIndex = 49
        StreetNameLabel.Text = "Street:"
        '
        'BarangayLabel
        '
        BarangayLabel.AutoSize = True
        BarangayLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BarangayLabel.Location = New System.Drawing.Point(46, 504)
        BarangayLabel.Margin = New System.Windows.Forms.Padding(10)
        BarangayLabel.Name = "BarangayLabel"
        BarangayLabel.Size = New System.Drawing.Size(113, 24)
        BarangayLabel.TabIndex = 50
        BarangayLabel.Text = "Barangay:"
        '
        'City_MunicipalityLabel
        '
        City_MunicipalityLabel.AutoSize = True
        City_MunicipalityLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        City_MunicipalityLabel.Location = New System.Drawing.Point(406, 504)
        City_MunicipalityLabel.Margin = New System.Windows.Forms.Padding(10)
        City_MunicipalityLabel.Name = "City_MunicipalityLabel"
        City_MunicipalityLabel.Size = New System.Drawing.Size(55, 24)
        City_MunicipalityLabel.TabIndex = 51
        City_MunicipalityLabel.Text = "City:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(46, 403)
        GenderLabel.Margin = New System.Windows.Forms.Padding(10)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(91, 24)
        GenderLabel.TabIndex = 52
        GenderLabel.Text = "Gender:"
        '
        'Contact_NumberLabel
        '
        Contact_NumberLabel.AutoSize = True
        Contact_NumberLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contact_NumberLabel.Location = New System.Drawing.Point(46, 556)
        Contact_NumberLabel.Margin = New System.Windows.Forms.Padding(10)
        Contact_NumberLabel.Name = "Contact_NumberLabel"
        Contact_NumberLabel.Size = New System.Drawing.Size(181, 24)
        Contact_NumberLabel.TabIndex = 53
        Contact_NumberLabel.Text = "Contact Number:"
        '
        'BirthDateLabel
        '
        BirthDateLabel.AutoSize = True
        BirthDateLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BirthDateLabel.Location = New System.Drawing.Point(270, 403)
        BirthDateLabel.Margin = New System.Windows.Forms.Padding(10)
        BirthDateLabel.Name = "BirthDateLabel"
        BirthDateLabel.Size = New System.Drawing.Size(117, 24)
        BirthDateLabel.TabIndex = 54
        BirthDateLabel.Text = "Birth Date:"
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
        'timClock
        '
        '
        'timDelay
        '
        Me.timDelay.Interval = 500
        '
        'ofdBrowsePicture
        '
        Me.ofdBrowsePicture.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.jpeg;*.png"
        Me.ofdBrowsePicture.InitialDirectory = "%userprofile%\Downloads"
        '
        'btnBrowsePic
        '
        Me.btnBrowsePic.AutoSize = True
        Me.btnBrowsePic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBrowsePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBrowsePic.FlatAppearance.BorderSize = 0
        Me.btnBrowsePic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBrowsePic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBrowsePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowsePic.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBrowsePic
        Me.btnBrowsePic.Location = New System.Drawing.Point(179, 307)
        Me.btnBrowsePic.Name = "btnBrowsePic"
        Me.btnBrowsePic.Size = New System.Drawing.Size(70, 70)
        Me.btnBrowsePic.TabIndex = 55
        Me.tipEditPatient.SetToolTip(Me.btnBrowsePic, "Browse picture")
        Me.btnBrowsePic.UseVisualStyleBackColor = False
        Me.btnBrowsePic.Visible = False
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
        Me.btnBack.Location = New System.Drawing.Point(750, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(38, 38)
        Me.btnBack.TabIndex = 36
        Me.btnBack.TabStop = False
        Me.tipEditPatient.SetToolTip(Me.btnBack, "Back")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'MNameTextBox
        '
        Me.MNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInfoBindingSource, "MName", True))
        Me.MNameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNameTextBox.Location = New System.Drawing.Point(428, 293)
        Me.MNameTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.MNameTextBox.Name = "MNameTextBox"
        Me.MNameTextBox.Size = New System.Drawing.Size(320, 32)
        Me.MNameTextBox.TabIndex = 31
        '
        'PatientInfoBindingSource
        '
        Me.PatientInfoBindingSource.DataMember = "PatientInfo"
        Me.PatientInfoBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'ClinicMgtDbDataSet
        '
        Me.ClinicMgtDbDataSet.DataSetName = "ClinicMgtDbDataSet"
        Me.ClinicMgtDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInfoBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientIDTextBox.Location = New System.Drawing.Point(396, 189)
        Me.PatientIDTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.ReadOnly = True
        Me.PatientIDTextBox.Size = New System.Drawing.Size(352, 32)
        Me.PatientIDTextBox.TabIndex = 40
        Me.PatientIDTextBox.TabStop = False
        '
        'FNameTextBox
        '
        Me.FNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInfoBindingSource, "FName", True))
        Me.FNameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNameTextBox.Location = New System.Drawing.Point(407, 241)
        Me.FNameTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.Size = New System.Drawing.Size(341, 32)
        Me.FNameTextBox.TabIndex = 30
        '
        'LNameTextBox
        '
        Me.LNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInfoBindingSource, "LName", True))
        Me.LNameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNameTextBox.Location = New System.Drawing.Point(404, 345)
        Me.LNameTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.Size = New System.Drawing.Size(344, 32)
        Me.LNameTextBox.TabIndex = 32
        '
        'HouseNumberTextBox
        '
        Me.HouseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInfoBindingSource, "HouseNumber", True))
        Me.HouseNumberTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HouseNumberTextBox.Location = New System.Drawing.Point(179, 449)
        Me.HouseNumberTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.HouseNumberTextBox.Name = "HouseNumberTextBox"
        Me.HouseNumberTextBox.Size = New System.Drawing.Size(71, 32)
        Me.HouseNumberTextBox.TabIndex = 37
        '
        'StreetNameTextBox
        '
        Me.StreetNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInfoBindingSource, "StreetName", True))
        Me.StreetNameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StreetNameTextBox.Location = New System.Drawing.Point(358, 449)
        Me.StreetNameTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.StreetNameTextBox.Name = "StreetNameTextBox"
        Me.StreetNameTextBox.Size = New System.Drawing.Size(390, 32)
        Me.StreetNameTextBox.TabIndex = 39
        '
        'BarangayTextBox
        '
        Me.BarangayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInfoBindingSource, "Barangay", True))
        Me.BarangayTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarangayTextBox.Location = New System.Drawing.Point(170, 501)
        Me.BarangayTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.BarangayTextBox.Name = "BarangayTextBox"
        Me.BarangayTextBox.Size = New System.Drawing.Size(216, 32)
        Me.BarangayTextBox.TabIndex = 41
        '
        'City_MunicipalityTextBox
        '
        Me.City_MunicipalityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInfoBindingSource, "City/Municipality", True))
        Me.City_MunicipalityTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City_MunicipalityTextBox.Location = New System.Drawing.Point(473, 501)
        Me.City_MunicipalityTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.City_MunicipalityTextBox.Name = "City_MunicipalityTextBox"
        Me.City_MunicipalityTextBox.Size = New System.Drawing.Size(275, 32)
        Me.City_MunicipalityTextBox.TabIndex = 42
        '
        'GenderComboBox
        '
        Me.GenderComboBox.BackColor = System.Drawing.SystemColors.Window
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInfoBindingSource, "Gender", True))
        Me.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderComboBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(149, 400)
        Me.GenderComboBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(101, 32)
        Me.GenderComboBox.TabIndex = 33
        '
        'Contact_NumberTextBox
        '
        Me.Contact_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInfoBindingSource, "Contact Number", True))
        Me.Contact_NumberTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact_NumberTextBox.Location = New System.Drawing.Point(240, 553)
        Me.Contact_NumberTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.Contact_NumberTextBox.MaxLength = 100
        Me.Contact_NumberTextBox.Name = "Contact_NumberTextBox"
        Me.Contact_NumberTextBox.Size = New System.Drawing.Size(405, 32)
        Me.Contact_NumberTextBox.TabIndex = 44
        '
        'BirthDateDateTimePicker
        '
        Me.BirthDateDateTimePicker.CustomFormat = "MMMM dd, yyyy"
        Me.BirthDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientInfoBindingSource, "BirthDate", True))
        Me.BirthDateDateTimePicker.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BirthDateDateTimePicker.Location = New System.Drawing.Point(396, 397)
        Me.BirthDateDateTimePicker.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker"
        Me.BirthDateDateTimePicker.Size = New System.Drawing.Size(249, 32)
        Me.BirthDateDateTimePicker.TabIndex = 35
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
        Me.pnlHeader.TabIndex = 34
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
        Me.btnSave.Location = New System.Drawing.Point(324, 618)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 52)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.BackgroundImage = CType(resources.GetObject("PicturePictureBox.BackgroundImage"), System.Drawing.Image)
        Me.PicturePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicturePictureBox.Location = New System.Drawing.Point(50, 177)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(200, 200)
        Me.PicturePictureBox.TabIndex = 43
        Me.PicturePictureBox.TabStop = False
        '
        'PatientInfoTableAdapter
        '
        Me.PatientInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorPrescriptionTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.MedicineStocksTableAdapter = Nothing
        Me.TableAdapterManager.MedicineTableAdapter = Nothing
        Me.TableAdapterManager.MedTypeTableAdapter = Nothing
        Me.TableAdapterManager.PatientInfoTableAdapter = Me.PatientInfoTableAdapter
        Me.TableAdapterManager.PatientRecordsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.WaitListTableAdapter = Nothing
        '
        'PicturePathTextBox
        '
        Me.PicturePathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInfoBindingSource, "PicturePath", True))
        Me.PicturePathTextBox.Location = New System.Drawing.Point(62, 269)
        Me.PicturePathTextBox.Name = "PicturePathTextBox"
        Me.PicturePathTextBox.Size = New System.Drawing.Size(175, 32)
        Me.PicturePathTextBox.TabIndex = 57
        '
        'EditPatientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(800, 700)
        Me.Controls.Add(MNameLabel)
        Me.Controls.Add(Me.MNameTextBox)
        Me.Controls.Add(Me.btnBrowsePic)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDTextBox)
        Me.Controls.Add(FNameLabel)
        Me.Controls.Add(Me.FNameTextBox)
        Me.Controls.Add(LNameLabel)
        Me.Controls.Add(Me.LNameTextBox)
        Me.Controls.Add(HouseNumberLabel)
        Me.Controls.Add(Me.HouseNumberTextBox)
        Me.Controls.Add(Me.StreetNameTextBox)
        Me.Controls.Add(StreetNameLabel)
        Me.Controls.Add(BarangayLabel)
        Me.Controls.Add(Me.BarangayTextBox)
        Me.Controls.Add(City_MunicipalityLabel)
        Me.Controls.Add(Me.City_MunicipalityTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Contact_NumberLabel)
        Me.Controls.Add(Me.Contact_NumberTextBox)
        Me.Controls.Add(BirthDateLabel)
        Me.Controls.Add(Me.BirthDateDateTimePicker)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.PicturePictureBox)
        Me.Controls.Add(Me.PicturePathTextBox)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "EditPatientForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PatientInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents ClinicMgtDbDataSet As Clinic_Management_System.ClinicMgtDbDataSet
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents PatientInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents timDelay As System.Windows.Forms.Timer
    Friend WithEvents ofdBrowsePicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tipEditPatient As System.Windows.Forms.ToolTip
    Friend WithEvents btnBrowsePic As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents MNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents PatientIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HouseNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StreetNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientInfoTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.PatientInfoTableAdapter
    Friend WithEvents BarangayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents City_MunicipalityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Contact_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BirthDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents PicturePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TableAdapterManager As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PicturePathTextBox As System.Windows.Forms.TextBox
End Class
