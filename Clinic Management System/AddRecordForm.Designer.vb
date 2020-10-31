<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRecordForm
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
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim HeightLabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim BPLabel As System.Windows.Forms.Label
        Dim PulseRateLabel As System.Windows.Forms.Label
        Dim SymptomsLabel As System.Windows.Forms.Label
        Dim lblName As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddRecordForm))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.BPTextBox = New System.Windows.Forms.TextBox()
        Me.PulseRateTextBox = New System.Windows.Forms.TextBox()
        Me.SymptomsTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblBP = New System.Windows.Forms.Label()
        Me.lblPulseRate = New System.Windows.Forms.Label()
        Me.ClinicMgtDbDataSet = New Clinic_Management_System.ClinicMgtDbDataSet()
        Me.PatientRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientRecordsTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.PatientRecordsTableAdapter()
        Me.TableAdapterManager = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager()
        Me.PatientInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientInfoTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.PatientInfoTableAdapter()
        Me.WaitListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WaitListTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.WaitListTableAdapter()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tipAddRecord = New System.Windows.Forms.ToolTip(Me.components)
        PatientIDLabel = New System.Windows.Forms.Label()
        HeightLabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        BPLabel = New System.Windows.Forms.Label()
        PulseRateLabel = New System.Windows.Forms.Label()
        SymptomsLabel = New System.Windows.Forms.Label()
        lblName = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaitListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PatientIDLabel.Location = New System.Drawing.Point(36, 180)
        PatientIDLabel.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(113, 24)
        PatientIDLabel.TabIndex = 6
        PatientIDLabel.Text = "Patient ID:"
        '
        'HeightLabel
        '
        HeightLabel.AutoSize = True
        HeightLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HeightLabel.Location = New System.Drawing.Point(36, 284)
        HeightLabel.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New System.Drawing.Size(81, 24)
        HeightLabel.TabIndex = 10
        HeightLabel.Text = "Height:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WeightLabel.Location = New System.Drawing.Point(36, 336)
        WeightLabel.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(88, 24)
        WeightLabel.TabIndex = 12
        WeightLabel.Text = "Weight:"
        '
        'BPLabel
        '
        BPLabel.AutoSize = True
        BPLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BPLabel.Location = New System.Drawing.Point(347, 284)
        BPLabel.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        BPLabel.Name = "BPLabel"
        BPLabel.Size = New System.Drawing.Size(173, 24)
        BPLabel.TabIndex = 14
        BPLabel.Text = "Blood Pressure:"
        '
        'PulseRateLabel
        '
        PulseRateLabel.AutoSize = True
        PulseRateLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PulseRateLabel.Location = New System.Drawing.Point(347, 336)
        PulseRateLabel.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        PulseRateLabel.Name = "PulseRateLabel"
        PulseRateLabel.Size = New System.Drawing.Size(125, 24)
        PulseRateLabel.TabIndex = 16
        PulseRateLabel.Text = "Pulse Rate:"
        '
        'SymptomsLabel
        '
        SymptomsLabel.AutoSize = True
        SymptomsLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SymptomsLabel.Location = New System.Drawing.Point(36, 388)
        SymptomsLabel.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        SymptomsLabel.Name = "SymptomsLabel"
        SymptomsLabel.Size = New System.Drawing.Size(125, 24)
        SymptomsLabel.TabIndex = 18
        SymptomsLabel.Text = "Symptoms:"
        '
        'lblName
        '
        lblName.AutoSize = True
        lblName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblName.Location = New System.Drawing.Point(36, 232)
        lblName.Margin = New System.Windows.Forms.Padding(10, 0, 3, 0)
        lblName.Name = "lblName"
        lblName.Size = New System.Drawing.Size(74, 24)
        lblName.TabIndex = 20
        lblName.Text = "Name:"
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
        Me.pnlHeader.TabIndex = 4
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
        Me.btnBack.TabIndex = 5
        Me.btnBack.TabStop = False
        Me.tipAddRecord.SetToolTip(Me.btnBack, "Back")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'timClock
        '
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientIDTextBox.Location = New System.Drawing.Point(155, 177)
        Me.PatientIDTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.ReadOnly = True
        Me.PatientIDTextBox.Size = New System.Drawing.Size(200, 32)
        Me.PatientIDTextBox.TabIndex = 7
        Me.PatientIDTextBox.TabStop = False
        Me.PatientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HeightTextBox
        '
        Me.HeightTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightTextBox.Location = New System.Drawing.Point(127, 281)
        Me.HeightTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 5, 10)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(150, 32)
        Me.HeightTextBox.TabIndex = 0
        Me.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WeightTextBox
        '
        Me.WeightTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTextBox.Location = New System.Drawing.Point(127, 333)
        Me.WeightTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 5, 10)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(150, 32)
        Me.WeightTextBox.TabIndex = 1
        Me.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BPTextBox
        '
        Me.BPTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPTextBox.Location = New System.Drawing.Point(523, 281)
        Me.BPTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 5, 10)
        Me.BPTextBox.Name = "BPTextBox"
        Me.BPTextBox.Size = New System.Drawing.Size(150, 32)
        Me.BPTextBox.TabIndex = 2
        Me.BPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PulseRateTextBox
        '
        Me.PulseRateTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulseRateTextBox.Location = New System.Drawing.Point(523, 333)
        Me.PulseRateTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 5, 10)
        Me.PulseRateTextBox.Name = "PulseRateTextBox"
        Me.PulseRateTextBox.Size = New System.Drawing.Size(150, 32)
        Me.PulseRateTextBox.TabIndex = 3
        Me.PulseRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SymptomsTextBox
        '
        Me.SymptomsTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SymptomsTextBox.Location = New System.Drawing.Point(163, 385)
        Me.SymptomsTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.SymptomsTextBox.Multiline = True
        Me.SymptomsTextBox.Name = "SymptomsTextBox"
        Me.SymptomsTextBox.Size = New System.Drawing.Size(595, 127)
        Me.SymptomsTextBox.TabIndex = 4
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(123, 229)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(635, 32)
        Me.NameTextBox.TabIndex = 21
        Me.NameTextBox.TabStop = False
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblHeight.Location = New System.Drawing.Point(285, 284)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(41, 24)
        Me.lblHeight.TabIndex = 23
        Me.lblHeight.Text = "cm"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblWeight.Location = New System.Drawing.Point(285, 336)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(35, 24)
        Me.lblWeight.TabIndex = 24
        Me.lblWeight.Text = "kg"
        '
        'lblBP
        '
        Me.lblBP.AutoSize = True
        Me.lblBP.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBP.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblBP.Location = New System.Drawing.Point(681, 284)
        Me.lblBP.Name = "lblBP"
        Me.lblBP.Size = New System.Drawing.Size(75, 24)
        Me.lblBP.TabIndex = 25
        Me.lblBP.Text = "mmHg"
        '
        'lblPulseRate
        '
        Me.lblPulseRate.AutoSize = True
        Me.lblPulseRate.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPulseRate.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblPulseRate.Location = New System.Drawing.Point(681, 336)
        Me.lblPulseRate.Name = "lblPulseRate"
        Me.lblPulseRate.Size = New System.Drawing.Size(55, 24)
        Me.lblPulseRate.TabIndex = 26
        Me.lblPulseRate.Text = "bpm"
        '
        'ClinicMgtDbDataSet
        '
        Me.ClinicMgtDbDataSet.DataSetName = "ClinicMgtDbDataSet"
        Me.ClinicMgtDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientRecordsBindingSource
        '
        Me.PatientRecordsBindingSource.DataMember = "PatientRecords"
        Me.PatientRecordsBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'PatientRecordsTableAdapter
        '
        Me.PatientRecordsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorPrescriptionTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.MedicineStocksTableAdapter = Nothing
        Me.TableAdapterManager.MedicineTableAdapter = Nothing
        Me.TableAdapterManager.PatientInfoTableAdapter = Nothing
        Me.TableAdapterManager.PatientRecordsTableAdapter = Me.PatientRecordsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.WaitListTableAdapter = Nothing
        '
        'PatientInfoBindingSource
        '
        Me.PatientInfoBindingSource.DataMember = "PatientInfo"
        Me.PatientInfoBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'PatientInfoTableAdapter
        '
        Me.PatientInfoTableAdapter.ClearBeforeFill = True
        '
        'WaitListBindingSource
        '
        Me.WaitListBindingSource.DataMember = "WaitList"
        Me.WaitListBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'WaitListTableAdapter
        '
        Me.WaitListTableAdapter.ClearBeforeFill = True
        '
        'btnAdd
        '
        Me.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAdd.BackColor = System.Drawing.Color.Green
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Global.Clinic_Management_System.My.Resources.Resources.btnPlus
        Me.btnAdd.Location = New System.Drawing.Point(281, 545)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(239, 52)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'AddRecordForm
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(800, 630)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblPulseRate)
        Me.Controls.Add(Me.lblBP)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(lblName)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDTextBox)
        Me.Controls.Add(HeightLabel)
        Me.Controls.Add(Me.HeightTextBox)
        Me.Controls.Add(WeightLabel)
        Me.Controls.Add(Me.WeightTextBox)
        Me.Controls.Add(BPLabel)
        Me.Controls.Add(Me.BPTextBox)
        Me.Controls.Add(PulseRateLabel)
        Me.Controls.Add(Me.PulseRateTextBox)
        Me.Controls.Add(SymptomsLabel)
        Me.Controls.Add(Me.SymptomsTextBox)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "AddRecordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaitListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents ClinicMgtDbDataSet As Clinic_Management_System.ClinicMgtDbDataSet
    Friend WithEvents PatientRecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatientRecordsTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.PatientRecordsTableAdapter
    Friend WithEvents TableAdapterManager As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PulseRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SymptomsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents lblBP As System.Windows.Forms.Label
    Friend WithEvents lblPulseRate As System.Windows.Forms.Label
    Friend WithEvents PatientInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatientInfoTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.PatientInfoTableAdapter
    Friend WithEvents WaitListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WaitListTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.WaitListTableAdapter
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents tipAddRecord As System.Windows.Forms.ToolTip
End Class
