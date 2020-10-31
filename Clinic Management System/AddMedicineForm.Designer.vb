<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMedicineForm
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
        Dim StockNumberLabel As System.Windows.Forms.Label
        Dim StocksLabel As System.Windows.Forms.Label
        Dim ExpirationDateLabel As System.Windows.Forms.Label
        Dim AcquiredDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMedicineForm))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.tipAddMedicine = New System.Windows.Forms.ToolTip(Me.components)
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.MedicineIDTextBox = New System.Windows.Forms.TextBox()
        Me.GenericNameTextBox = New System.Windows.Forms.TextBox()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.FormatComboBox = New System.Windows.Forms.ComboBox()
        Me.MedTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicMgtDbDataSet = New Clinic_Management_System.ClinicMgtDbDataSet()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.MedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicineTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineTableAdapter()
        Me.TableAdapterManager = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager()
        Me.MedTypeTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedTypeTableAdapter()
        Me.MedicineStocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicineStocksTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineStocksTableAdapter()
        Me.StockNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ExpirationDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AcquiredDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NumericUpDownStocks = New System.Windows.Forms.NumericUpDown()
        MedicineIDLabel = New System.Windows.Forms.Label()
        GenericNameLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        FormatLabel = New System.Windows.Forms.Label()
        StockNumberLabel = New System.Windows.Forms.Label()
        StocksLabel = New System.Windows.Forms.Label()
        ExpirationDateLabel = New System.Windows.Forms.Label()
        AcquiredDateLabel = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineStocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MedicineIDLabel
        '
        MedicineIDLabel.AutoSize = True
        MedicineIDLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MedicineIDLabel.Location = New System.Drawing.Point(39, 193)
        MedicineIDLabel.Name = "MedicineIDLabel"
        MedicineIDLabel.Size = New System.Drawing.Size(132, 24)
        MedicineIDLabel.TabIndex = 10
        MedicineIDLabel.Text = "Medicine ID:"
        '
        'GenericNameLabel
        '
        GenericNameLabel.AutoSize = True
        GenericNameLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenericNameLabel.Location = New System.Drawing.Point(39, 246)
        GenericNameLabel.Name = "GenericNameLabel"
        GenericNameLabel.Size = New System.Drawing.Size(158, 24)
        GenericNameLabel.TabIndex = 12
        GenericNameLabel.Text = "Generic Name:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BrandLabel.Location = New System.Drawing.Point(39, 358)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(78, 24)
        BrandLabel.TabIndex = 14
        BrandLabel.Text = "Brand:"
        '
        'FormatLabel
        '
        FormatLabel.AutoSize = True
        FormatLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormatLabel.Location = New System.Drawing.Point(39, 409)
        FormatLabel.Name = "FormatLabel"
        FormatLabel.Size = New System.Drawing.Size(64, 24)
        FormatLabel.TabIndex = 16
        FormatLabel.Text = "Type:"
        '
        'StockNumberLabel
        '
        StockNumberLabel.AutoSize = True
        StockNumberLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StockNumberLabel.Location = New System.Drawing.Point(535, 193)
        StockNumberLabel.Name = "StockNumberLabel"
        StockNumberLabel.Size = New System.Drawing.Size(114, 24)
        StockNumberLabel.TabIndex = 0
        StockNumberLabel.Text = "Stock No.:"
        '
        'StocksLabel
        '
        StocksLabel.AutoSize = True
        StocksLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StocksLabel.Location = New System.Drawing.Point(785, 193)
        StocksLabel.Name = "StocksLabel"
        StocksLabel.Size = New System.Drawing.Size(87, 24)
        StocksLabel.TabIndex = 4
        StocksLabel.Text = "Stocks:"
        '
        'ExpirationDateLabel
        '
        ExpirationDateLabel.AutoSize = True
        ExpirationDateLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ExpirationDateLabel.Location = New System.Drawing.Point(535, 298)
        ExpirationDateLabel.Name = "ExpirationDateLabel"
        ExpirationDateLabel.Size = New System.Drawing.Size(171, 24)
        ExpirationDateLabel.TabIndex = 6
        ExpirationDateLabel.Text = "Expiration Date:"
        '
        'AcquiredDateLabel
        '
        AcquiredDateLabel.AutoSize = True
        AcquiredDateLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AcquiredDateLabel.Location = New System.Drawing.Point(535, 246)
        AcquiredDateLabel.Name = "AcquiredDateLabel"
        AcquiredDateLabel.Size = New System.Drawing.Size(160, 24)
        AcquiredDateLabel.TabIndex = 8
        AcquiredDateLabel.Text = "Acquired Date:"
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
        Me.btnBack.TabIndex = 10
        Me.btnBack.TabStop = False
        Me.tipAddMedicine.SetToolTip(Me.btnBack, "Back")
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
        Me.pnlHeader.TabIndex = 9
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
        'MedicineIDTextBox
        '
        Me.MedicineIDTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineIDTextBox.Location = New System.Drawing.Point(204, 190)
        Me.MedicineIDTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.MedicineIDTextBox.Name = "MedicineIDTextBox"
        Me.MedicineIDTextBox.ReadOnly = True
        Me.MedicineIDTextBox.Size = New System.Drawing.Size(120, 32)
        Me.MedicineIDTextBox.TabIndex = 11
        Me.MedicineIDTextBox.TabStop = False
        Me.MedicineIDTextBox.Text = "00000000"
        Me.MedicineIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GenericNameTextBox
        '
        Me.GenericNameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenericNameTextBox.Location = New System.Drawing.Point(204, 243)
        Me.GenericNameTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.GenericNameTextBox.Multiline = True
        Me.GenericNameTextBox.Name = "GenericNameTextBox"
        Me.GenericNameTextBox.Size = New System.Drawing.Size(300, 92)
        Me.GenericNameTextBox.TabIndex = 0
        '
        'BrandTextBox
        '
        Me.BrandTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandTextBox.Location = New System.Drawing.Point(204, 354)
        Me.BrandTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(300, 32)
        Me.BrandTextBox.TabIndex = 1
        '
        'FormatComboBox
        '
        Me.FormatComboBox.DataSource = Me.MedTypeBindingSource
        Me.FormatComboBox.DisplayMember = "MedType"
        Me.FormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FormatComboBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormatComboBox.FormattingEnabled = True
        Me.FormatComboBox.Location = New System.Drawing.Point(204, 406)
        Me.FormatComboBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.FormatComboBox.Name = "FormatComboBox"
        Me.FormatComboBox.Size = New System.Drawing.Size(300, 32)
        Me.FormatComboBox.TabIndex = 2
        '
        'MedTypeBindingSource
        '
        Me.MedTypeBindingSource.DataMember = "MedType"
        Me.MedTypeBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'ClinicMgtDbDataSet
        '
        Me.ClinicMgtDbDataSet.DataSetName = "ClinicMgtDbDataSet"
        Me.ClinicMgtDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.btnAdd.Location = New System.Drawing.Point(693, 386)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(260, 52)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add Medicine"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'MedicineBindingSource
        '
        Me.MedicineBindingSource.DataMember = "Medicine"
        Me.MedicineBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'MedicineTableAdapter
        '
        Me.MedicineTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorPrescriptionTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.MedicineStocksTableAdapter = Nothing
        Me.TableAdapterManager.MedicineTableAdapter = Me.MedicineTableAdapter
        Me.TableAdapterManager.MedTypeTableAdapter = Nothing
        Me.TableAdapterManager.PatientInfoTableAdapter = Nothing
        Me.TableAdapterManager.PatientRecordsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.WaitListTableAdapter = Nothing
        '
        'MedTypeTableAdapter
        '
        Me.MedTypeTableAdapter.ClearBeforeFill = True
        '
        'MedicineStocksBindingSource
        '
        Me.MedicineStocksBindingSource.DataMember = "MedicineStocks"
        Me.MedicineStocksBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'MedicineStocksTableAdapter
        '
        Me.MedicineStocksTableAdapter.ClearBeforeFill = True
        '
        'StockNumberTextBox
        '
        Me.StockNumberTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockNumberTextBox.Location = New System.Drawing.Point(652, 190)
        Me.StockNumberTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.StockNumberTextBox.Name = "StockNumberTextBox"
        Me.StockNumberTextBox.ReadOnly = True
        Me.StockNumberTextBox.Size = New System.Drawing.Size(120, 32)
        Me.StockNumberTextBox.TabIndex = 1
        Me.StockNumberTextBox.TabStop = False
        '
        'ExpirationDateDateTimePicker
        '
        Me.ExpirationDateDateTimePicker.CustomFormat = "MMMM dd, yyyy"
        Me.ExpirationDateDateTimePicker.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpirationDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ExpirationDateDateTimePicker.Location = New System.Drawing.Point(709, 292)
        Me.ExpirationDateDateTimePicker.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.ExpirationDateDateTimePicker.Name = "ExpirationDateDateTimePicker"
        Me.ExpirationDateDateTimePicker.Size = New System.Drawing.Size(244, 32)
        Me.ExpirationDateDateTimePicker.TabIndex = 7
        '
        'AcquiredDateDateTimePicker
        '
        Me.AcquiredDateDateTimePicker.CustomFormat = "MMMM dd, yyyy"
        Me.AcquiredDateDateTimePicker.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcquiredDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AcquiredDateDateTimePicker.Location = New System.Drawing.Point(709, 240)
        Me.AcquiredDateDateTimePicker.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.AcquiredDateDateTimePicker.Name = "AcquiredDateDateTimePicker"
        Me.AcquiredDateDateTimePicker.Size = New System.Drawing.Size(244, 32)
        Me.AcquiredDateDateTimePicker.TabIndex = 9
        '
        'NumericUpDownStocks
        '
        Me.NumericUpDownStocks.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownStocks.Location = New System.Drawing.Point(878, 190)
        Me.NumericUpDownStocks.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDownStocks.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownStocks.Name = "NumericUpDownStocks"
        Me.NumericUpDownStocks.Size = New System.Drawing.Size(75, 32)
        Me.NumericUpDownStocks.TabIndex = 17
        Me.NumericUpDownStocks.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'AddMedicineForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.Controls.Add(Me.NumericUpDownStocks)
        Me.Controls.Add(MedicineIDLabel)
        Me.Controls.Add(StockNumberLabel)
        Me.Controls.Add(Me.MedicineIDTextBox)
        Me.Controls.Add(GenericNameLabel)
        Me.Controls.Add(Me.StockNumberTextBox)
        Me.Controls.Add(Me.GenericNameTextBox)
        Me.Controls.Add(StocksLabel)
        Me.Controls.Add(BrandLabel)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(FormatLabel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.FormatComboBox)
        Me.Controls.Add(ExpirationDateLabel)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ExpirationDateDateTimePicker)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(AcquiredDateLabel)
        Me.Controls.Add(Me.AcquiredDateDateTimePicker)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "AddMedicineForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineStocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents tipAddMedicine As System.Windows.Forms.ToolTip
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents ClinicMgtDbDataSet As Clinic_Management_System.ClinicMgtDbDataSet
    Friend WithEvents MedicineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicineTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineTableAdapter
    Friend WithEvents TableAdapterManager As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MedicineIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenericNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FormatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents MedTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedTypeTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedTypeTableAdapter
    Friend WithEvents MedicineStocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicineStocksTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineStocksTableAdapter
    Friend WithEvents StockNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpirationDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AcquiredDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumericUpDownStocks As System.Windows.Forms.NumericUpDown
End Class
