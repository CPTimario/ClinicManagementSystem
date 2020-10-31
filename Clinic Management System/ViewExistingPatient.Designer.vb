<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewExistingPatient
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewExistingPatient))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.dgvViewPatientInfo = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewPatientInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicMgtDbDataSet = New Clinic_Management_System.ClinicMgtDbDataSet()
        Me.lblName = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAddPatients = New System.Windows.Forms.Button()
        Me.btnEditPatient = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.ViewPatientInfoTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.ViewPatientInfoTableAdapter()
        Me.TableAdapterManager = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvViewPatientInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewPatientInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'timClock
        '
        '
        'dgvViewPatientInfo
        '
        Me.dgvViewPatientInfo.AllowUserToAddRows = False
        Me.dgvViewPatientInfo.AllowUserToDeleteRows = False
        Me.dgvViewPatientInfo.AllowUserToOrderColumns = True
        Me.dgvViewPatientInfo.AllowUserToResizeColumns = False
        Me.dgvViewPatientInfo.AllowUserToResizeRows = False
        Me.dgvViewPatientInfo.AutoGenerateColumns = False
        Me.dgvViewPatientInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvViewPatientInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvViewPatientInfo.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.dgvViewPatientInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViewPatientInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvViewPatientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewPatientInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgvViewPatientInfo.DataSource = Me.ViewPatientInfoBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvViewPatientInfo.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvViewPatientInfo.Location = New System.Drawing.Point(29, 228)
        Me.dgvViewPatientInfo.Margin = New System.Windows.Forms.Padding(20)
        Me.dgvViewPatientInfo.MultiSelect = False
        Me.dgvViewPatientInfo.Name = "dgvViewPatientInfo"
        Me.dgvViewPatientInfo.ReadOnly = True
        Me.dgvViewPatientInfo.RowHeadersVisible = False
        Me.dgvViewPatientInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvViewPatientInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvViewPatientInfo.Size = New System.Drawing.Size(942, 375)
        Me.dgvViewPatientInfo.TabIndex = 6
        Me.dgvViewPatientInfo.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PatientID"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Format = "00000000"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 144
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Full Name"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Full Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Gender"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 121
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Age"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 85
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'ViewPatientInfoBindingSource
        '
        Me.ViewPatientInfoBindingSource.DataMember = "ViewPatientInfo"
        Me.ViewPatientInfoBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'ClinicMgtDbDataSet
        '
        Me.ClinicMgtDbDataSet.DataSetName = "ClinicMgtDbDataSet"
        Me.ClinicMgtDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(54, 184)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(151, 24)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Search Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(213, 181)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(384, 32)
        Me.NameTextBox.TabIndex = 0
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
        Me.btnBack.Location = New System.Drawing.Point(950, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(38, 38)
        Me.btnBack.TabIndex = 5
        Me.btnBack.TabStop = False
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAddPatients
        '
        Me.btnAddPatients.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddPatients.FlatAppearance.BorderSize = 0
        Me.btnAddPatients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddPatients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAddPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPatients.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPatients.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddPatients
        Me.btnAddPatients.Location = New System.Drawing.Point(815, 118)
        Me.btnAddPatients.Name = "btnAddPatients"
        Me.btnAddPatients.Size = New System.Drawing.Size(75, 95)
        Me.btnAddPatients.TabIndex = 11
        Me.btnAddPatients.TabStop = False
        Me.btnAddPatients.Text = "Add"
        Me.btnAddPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnAddPatients.UseVisualStyleBackColor = True
        '
        'btnEditPatient
        '
        Me.btnEditPatient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditPatient.Enabled = False
        Me.btnEditPatient.FlatAppearance.BorderSize = 0
        Me.btnEditPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPatient.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnEditPatient
        Me.btnEditPatient.Location = New System.Drawing.Point(896, 118)
        Me.btnEditPatient.Name = "btnEditPatient"
        Me.btnEditPatient.Size = New System.Drawing.Size(75, 95)
        Me.btnEditPatient.TabIndex = 10
        Me.btnEditPatient.TabStop = False
        Me.btnEditPatient.Text = "Edit"
        Me.btnEditPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEditPatient.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Green
        Me.btnNext.Enabled = False
        Me.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Image = Global.Clinic_Management_System.My.Resources.Resources.btnNext
        Me.btnNext.Location = New System.Drawing.Point(444, 626)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(115, 47)
        Me.btnNext.TabIndex = 9
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "Next"
        Me.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'ViewPatientInfoTableAdapter
        '
        Me.ViewPatientInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DoctorPrescriptionTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.MedicineStocksTableAdapter = Nothing
        Me.TableAdapterManager.MedicineTableAdapter = Nothing
        Me.TableAdapterManager.PatientInfoTableAdapter = Nothing
        Me.TableAdapterManager.PatientRecordsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.WaitListTableAdapter = Nothing
        '
        'ViewExistingPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.btnAddPatients)
        Me.Controls.Add(Me.btnEditPatient)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.dgvViewPatientInfo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "ViewExistingPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewExistingPatient"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvViewPatientInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewPatientInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents ClinicMgtDbDataSet As Clinic_Management_System.ClinicMgtDbDataSet
    Friend WithEvents ViewPatientInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewPatientInfoTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.ViewPatientInfoTableAdapter
    Friend WithEvents TableAdapterManager As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvViewPatientInfo As System.Windows.Forms.DataGridView
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnEditPatient As System.Windows.Forms.Button
    Friend WithEvents btnAddPatients As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
