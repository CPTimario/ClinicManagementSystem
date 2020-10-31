<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMedStockForm
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
        Dim StockNumberLabel As System.Windows.Forms.Label
        Dim StocksLabel As System.Windows.Forms.Label
        Dim ExpirationDateLabel As System.Windows.Forms.Label
        Dim AcquiredDateLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim GenericNameLabel As System.Windows.Forms.Label
        Dim MedTypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMedStockForm))
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.tipAddMedStock = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.NumericUpDownStocks = New System.Windows.Forms.NumericUpDown()
        Me.StockNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ExpirationDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AcquiredDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ClinicMgtDbDataSet = New Clinic_Management_System.ClinicMgtDbDataSet()
        Me.MedicineStocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicineStocksTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineStocksTableAdapter()
        Me.TableAdapterManager = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.GenericNameTextBox = New System.Windows.Forms.TextBox()
        Me.MedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicineTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineTableAdapter()
        Me.MedTypeTextBox = New System.Windows.Forms.TextBox()
        Me.grpStock = New System.Windows.Forms.GroupBox()
        StockNumberLabel = New System.Windows.Forms.Label()
        StocksLabel = New System.Windows.Forms.Label()
        ExpirationDateLabel = New System.Windows.Forms.Label()
        AcquiredDateLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        GenericNameLabel = New System.Windows.Forms.Label()
        MedTypeLabel = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineStocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStock.SuspendLayout()
        Me.SuspendLayout()
        '
        'StockNumberLabel
        '
        StockNumberLabel.AutoSize = True
        StockNumberLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StockNumberLabel.Location = New System.Drawing.Point(47, 50)
        StockNumberLabel.Name = "StockNumberLabel"
        StockNumberLabel.Size = New System.Drawing.Size(114, 24)
        StockNumberLabel.TabIndex = 18
        StockNumberLabel.Text = "Stock No.:"
        '
        'StocksLabel
        '
        StocksLabel.AutoSize = True
        StocksLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StocksLabel.Location = New System.Drawing.Point(297, 50)
        StocksLabel.Name = "StocksLabel"
        StocksLabel.Size = New System.Drawing.Size(87, 24)
        StocksLabel.TabIndex = 20
        StocksLabel.Text = "Stocks:"
        '
        'ExpirationDateLabel
        '
        ExpirationDateLabel.AutoSize = True
        ExpirationDateLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ExpirationDateLabel.Location = New System.Drawing.Point(47, 155)
        ExpirationDateLabel.Name = "ExpirationDateLabel"
        ExpirationDateLabel.Size = New System.Drawing.Size(171, 24)
        ExpirationDateLabel.TabIndex = 21
        ExpirationDateLabel.Text = "Expiration Date:"
        '
        'AcquiredDateLabel
        '
        AcquiredDateLabel.AutoSize = True
        AcquiredDateLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AcquiredDateLabel.Location = New System.Drawing.Point(47, 103)
        AcquiredDateLabel.Name = "AcquiredDateLabel"
        AcquiredDateLabel.Size = New System.Drawing.Size(160, 24)
        AcquiredDateLabel.TabIndex = 23
        AcquiredDateLabel.Text = "Acquired Date:"
        '
        'timClock
        '
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblDateTime)
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
        Me.btnBack.TabIndex = 11
        Me.btnBack.TabStop = False
        Me.btnBack.UseVisualStyleBackColor = True
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
        Me.btnAdd.Location = New System.Drawing.Point(251, 618)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(208, 52)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add Stock"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'NumericUpDownStocks
        '
        Me.NumericUpDownStocks.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownStocks.Location = New System.Drawing.Point(390, 47)
        Me.NumericUpDownStocks.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDownStocks.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownStocks.Name = "NumericUpDownStocks"
        Me.NumericUpDownStocks.Size = New System.Drawing.Size(75, 32)
        Me.NumericUpDownStocks.TabIndex = 25
        Me.NumericUpDownStocks.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'StockNumberTextBox
        '
        Me.StockNumberTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockNumberTextBox.Location = New System.Drawing.Point(164, 47)
        Me.StockNumberTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.StockNumberTextBox.Name = "StockNumberTextBox"
        Me.StockNumberTextBox.ReadOnly = True
        Me.StockNumberTextBox.Size = New System.Drawing.Size(120, 32)
        Me.StockNumberTextBox.TabIndex = 19
        Me.StockNumberTextBox.TabStop = False
        '
        'ExpirationDateDateTimePicker
        '
        Me.ExpirationDateDateTimePicker.CustomFormat = "MMMM dd, yyyy"
        Me.ExpirationDateDateTimePicker.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpirationDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ExpirationDateDateTimePicker.Location = New System.Drawing.Point(221, 149)
        Me.ExpirationDateDateTimePicker.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.ExpirationDateDateTimePicker.Name = "ExpirationDateDateTimePicker"
        Me.ExpirationDateDateTimePicker.Size = New System.Drawing.Size(244, 32)
        Me.ExpirationDateDateTimePicker.TabIndex = 22
        '
        'AcquiredDateDateTimePicker
        '
        Me.AcquiredDateDateTimePicker.CustomFormat = "MMMM dd, yyyy"
        Me.AcquiredDateDateTimePicker.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcquiredDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AcquiredDateDateTimePicker.Location = New System.Drawing.Point(221, 97)
        Me.AcquiredDateDateTimePicker.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.AcquiredDateDateTimePicker.Name = "AcquiredDateDateTimePicker"
        Me.AcquiredDateDateTimePicker.Size = New System.Drawing.Size(244, 32)
        Me.AcquiredDateDateTimePicker.TabIndex = 24
        '
        'ClinicMgtDbDataSet
        '
        Me.ClinicMgtDbDataSet.DataSetName = "ClinicMgtDbDataSet"
        Me.ClinicMgtDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorPrescriptionTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.MedicineStocksTableAdapter = Me.MedicineStocksTableAdapter
        Me.TableAdapterManager.MedicineTableAdapter = Nothing
        Me.TableAdapterManager.MedTypeTableAdapter = Nothing
        Me.TableAdapterManager.PatientInfoTableAdapter = Nothing
        Me.TableAdapterManager.PatientRecordsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.WaitListTableAdapter = Nothing
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Location = New System.Drawing.Point(76, 280)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(141, 24)
        BrandLabel.TabIndex = 28
        BrandLabel.Text = "Brand Name:"
        '
        'BrandTextBox
        '
        Me.BrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "Brand", True))
        Me.BrandTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandTextBox.Location = New System.Drawing.Point(237, 277)
        Me.BrandTextBox.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.ReadOnly = True
        Me.BrandTextBox.Size = New System.Drawing.Size(373, 32)
        Me.BrandTextBox.TabIndex = 29
        Me.BrandTextBox.TabStop = False
        Me.BrandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GenericNameLabel
        '
        GenericNameLabel.AutoSize = True
        GenericNameLabel.Location = New System.Drawing.Point(76, 181)
        GenericNameLabel.Name = "GenericNameLabel"
        GenericNameLabel.Size = New System.Drawing.Size(158, 24)
        GenericNameLabel.TabIndex = 26
        GenericNameLabel.Text = "Generic Name:"
        '
        'GenericNameTextBox
        '
        Me.GenericNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "GenericName", True))
        Me.GenericNameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenericNameTextBox.Location = New System.Drawing.Point(237, 178)
        Me.GenericNameTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.GenericNameTextBox.Multiline = True
        Me.GenericNameTextBox.Name = "GenericNameTextBox"
        Me.GenericNameTextBox.ReadOnly = True
        Me.GenericNameTextBox.Size = New System.Drawing.Size(373, 84)
        Me.GenericNameTextBox.TabIndex = 27
        Me.GenericNameTextBox.TabStop = False
        Me.GenericNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'MedTypeLabel
        '
        MedTypeLabel.AutoSize = True
        MedTypeLabel.Location = New System.Drawing.Point(76, 327)
        MedTypeLabel.Name = "MedTypeLabel"
        MedTypeLabel.Size = New System.Drawing.Size(112, 24)
        MedTypeLabel.TabIndex = 29
        MedTypeLabel.Text = "Med Type:"
        '
        'MedTypeTextBox
        '
        Me.MedTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "MedType", True))
        Me.MedTypeTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedTypeTextBox.Location = New System.Drawing.Point(237, 324)
        Me.MedTypeTextBox.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.MedTypeTextBox.Name = "MedTypeTextBox"
        Me.MedTypeTextBox.ReadOnly = True
        Me.MedTypeTextBox.Size = New System.Drawing.Size(373, 32)
        Me.MedTypeTextBox.TabIndex = 30
        Me.MedTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpStock
        '
        Me.grpStock.Controls.Add(Me.NumericUpDownStocks)
        Me.grpStock.Controls.Add(StockNumberLabel)
        Me.grpStock.Controls.Add(Me.StockNumberTextBox)
        Me.grpStock.Controls.Add(StocksLabel)
        Me.grpStock.Controls.Add(ExpirationDateLabel)
        Me.grpStock.Controls.Add(Me.ExpirationDateDateTimePicker)
        Me.grpStock.Controls.Add(AcquiredDateLabel)
        Me.grpStock.Controls.Add(Me.AcquiredDateDateTimePicker)
        Me.grpStock.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStock.ForeColor = System.Drawing.Color.DarkGreen
        Me.grpStock.Location = New System.Drawing.Point(92, 390)
        Me.grpStock.Name = "grpStock"
        Me.grpStock.Size = New System.Drawing.Size(530, 206)
        Me.grpStock.TabIndex = 31
        Me.grpStock.TabStop = False
        Me.grpStock.Text = "Stock Details"
        '
        'AddMedStockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(708, 700)
        Me.Controls.Add(Me.grpStock)
        Me.Controls.Add(MedTypeLabel)
        Me.Controls.Add(Me.MedTypeTextBox)
        Me.Controls.Add(BrandLabel)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(GenericNameLabel)
        Me.Controls.Add(Me.GenericNameTextBox)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "AddMedStockForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineStocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStock.ResumeLayout(False)
        Me.grpStock.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents tipAddMedStock As System.Windows.Forms.ToolTip
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownStocks As System.Windows.Forms.NumericUpDown
    Friend WithEvents StockNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpirationDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AcquiredDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ClinicMgtDbDataSet As Clinic_Management_System.ClinicMgtDbDataSet
    Friend WithEvents MedicineStocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicineStocksTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineStocksTableAdapter
    Friend WithEvents TableAdapterManager As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenericNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedicineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicineTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineTableAdapter
    Friend WithEvents MedTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grpStock As System.Windows.Forms.GroupBox
End Class
