<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditMedicineForm
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
        Dim MedicineIDLabel As System.Windows.Forms.Label
        Dim GenericNameLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim FormatLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditMedicineForm))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.tipEditMedicine = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.MedicineIDTextBox = New System.Windows.Forms.TextBox()
        Me.MedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicMgtDbDataSet = New Clinic_Management_System.ClinicMgtDbDataSet()
        Me.GenericNameTextBox = New System.Windows.Forms.TextBox()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.FormatComboBox = New System.Windows.Forms.ComboBox()
        Me.MedTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.MedicineTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineTableAdapter()
        Me.MedTypeTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedTypeTableAdapter()
        Me.TableAdapterManager = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager()
        MedicineIDLabel = New System.Windows.Forms.Label()
        GenericNameLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        FormatLabel = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MedicineIDLabel
        '
        MedicineIDLabel.AutoSize = True
        MedicineIDLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MedicineIDLabel.Location = New System.Drawing.Point(94, 187)
        MedicineIDLabel.Name = "MedicineIDLabel"
        MedicineIDLabel.Size = New System.Drawing.Size(132, 24)
        MedicineIDLabel.TabIndex = 41
        MedicineIDLabel.Text = "Medicine ID:"
        '
        'GenericNameLabel
        '
        GenericNameLabel.AutoSize = True
        GenericNameLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenericNameLabel.Location = New System.Drawing.Point(94, 240)
        GenericNameLabel.Name = "GenericNameLabel"
        GenericNameLabel.Size = New System.Drawing.Size(158, 24)
        GenericNameLabel.TabIndex = 43
        GenericNameLabel.Text = "Generic Name:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BrandLabel.Location = New System.Drawing.Point(94, 352)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(78, 24)
        BrandLabel.TabIndex = 44
        BrandLabel.Text = "Brand:"
        '
        'FormatLabel
        '
        FormatLabel.AutoSize = True
        FormatLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormatLabel.Location = New System.Drawing.Point(94, 403)
        FormatLabel.Name = "FormatLabel"
        FormatLabel.Size = New System.Drawing.Size(64, 24)
        FormatLabel.TabIndex = 45
        FormatLabel.Text = "Type:"
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
        Me.pnlHeader.TabIndex = 10
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
        Me.btnBack.Location = New System.Drawing.Point(650, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(38, 38)
        Me.btnBack.TabIndex = 37
        Me.btnBack.TabStop = False
        Me.tipEditMedicine.SetToolTip(Me.btnBack, "Back")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'MedicineIDTextBox
        '
        Me.MedicineIDTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineIDTextBox.Location = New System.Drawing.Point(259, 184)
        Me.MedicineIDTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.MedicineIDTextBox.Name = "MedicineIDTextBox"
        Me.MedicineIDTextBox.ReadOnly = True
        Me.MedicineIDTextBox.Size = New System.Drawing.Size(120, 32)
        Me.MedicineIDTextBox.TabIndex = 42
        Me.MedicineIDTextBox.TabStop = False
        Me.MedicineIDTextBox.Text = "00000000"
        Me.MedicineIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MedicineBindingSource
        '
        Me.MedicineBindingSource.DataMember = "Medicine"
        Me.MedicineBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'ClinicMgtDbDataSet
        '
        Me.ClinicMgtDbDataSet.DataSetName = "ClinicMgtDbDataSet"
        Me.ClinicMgtDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GenericNameTextBox
        '
        Me.GenericNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "GenericName", True))
        Me.GenericNameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenericNameTextBox.Location = New System.Drawing.Point(259, 237)
        Me.GenericNameTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.GenericNameTextBox.Multiline = True
        Me.GenericNameTextBox.Name = "GenericNameTextBox"
        Me.GenericNameTextBox.Size = New System.Drawing.Size(300, 92)
        Me.GenericNameTextBox.TabIndex = 38
        '
        'BrandTextBox
        '
        Me.BrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "Brand", True))
        Me.BrandTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandTextBox.Location = New System.Drawing.Point(259, 348)
        Me.BrandTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(300, 32)
        Me.BrandTextBox.TabIndex = 39
        '
        'FormatComboBox
        '
        Me.FormatComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "MedType", True))
        Me.FormatComboBox.DataSource = Me.MedTypeBindingSource
        Me.FormatComboBox.DisplayMember = "MedType"
        Me.FormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FormatComboBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormatComboBox.FormattingEnabled = True
        Me.FormatComboBox.Location = New System.Drawing.Point(259, 400)
        Me.FormatComboBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.FormatComboBox.Name = "FormatComboBox"
        Me.FormatComboBox.Size = New System.Drawing.Size(300, 32)
        Me.FormatComboBox.TabIndex = 40
        '
        'MedTypeBindingSource
        '
        Me.MedTypeBindingSource.DataMember = "MedType"
        Me.MedTypeBindingSource.DataSource = Me.ClinicMgtDbDataSet
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
        Me.btnSave.Location = New System.Drawing.Point(275, 463)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 52)
        Me.btnSave.TabIndex = 47
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'MedicineTableAdapter
        '
        Me.MedicineTableAdapter.ClearBeforeFill = True
        '
        'MedTypeTableAdapter
        '
        Me.MedTypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorPrescriptionTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.MedicineStocksTableAdapter = Nothing
        Me.TableAdapterManager.MedicineTableAdapter = Me.MedicineTableAdapter
        Me.TableAdapterManager.MedTypeTableAdapter = Me.MedTypeTableAdapter
        Me.TableAdapterManager.PatientInfoTableAdapter = Nothing
        Me.TableAdapterManager.PatientRecordsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.WaitListTableAdapter = Nothing
        '
        'EditMedicineForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(700, 550)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(MedicineIDLabel)
        Me.Controls.Add(Me.MedicineIDTextBox)
        Me.Controls.Add(GenericNameLabel)
        Me.Controls.Add(Me.GenericNameTextBox)
        Me.Controls.Add(BrandLabel)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(FormatLabel)
        Me.Controls.Add(Me.FormatComboBox)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "EditMedicineForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents tipEditMedicine As System.Windows.Forms.ToolTip
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents MedicineIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenericNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FormatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ClinicMgtDbDataSet As Clinic_Management_System.ClinicMgtDbDataSet
    Friend WithEvents MedicineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicineTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineTableAdapter
    Friend WithEvents MedTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedTypeTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedTypeTableAdapter
    Friend WithEvents TableAdapterManager As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager
End Class
