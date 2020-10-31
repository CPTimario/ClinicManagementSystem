<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReleaseMedicineForm
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
        Dim GenericNameLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim MedTypeLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim StocksLabel As System.Windows.Forms.Label
        Dim StockNumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReleaseMedicineForm))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.GenericNameTextBox = New System.Windows.Forms.TextBox()
        Me.MedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicMgtDbDataSet = New Clinic_Management_System.ClinicMgtDbDataSet()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.MedTypeTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnGive = New System.Windows.Forms.Button()
        Me.StocksTextBox = New System.Windows.Forms.TextBox()
        Me.MedicineStocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockNumberTextBox = New System.Windows.Forms.TextBox()
        Me.DoctorPrescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorPrescriptionTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.DoctorPrescriptionTableAdapter()
        Me.TableAdapterManager = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager()
        Me.MedicineTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineTableAdapter()
        Me.MedicineStocksTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineStocksTableAdapter()
        GenericNameLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        MedTypeLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        StocksLabel = New System.Windows.Forms.Label()
        StockNumberLabel = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineStocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorPrescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenericNameLabel
        '
        GenericNameLabel.AutoSize = True
        GenericNameLabel.Location = New System.Drawing.Point(44, 182)
        GenericNameLabel.Name = "GenericNameLabel"
        GenericNameLabel.Size = New System.Drawing.Size(158, 24)
        GenericNameLabel.TabIndex = 17
        GenericNameLabel.Text = "Generic Name:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Location = New System.Drawing.Point(46, 280)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(78, 24)
        BrandLabel.TabIndex = 19
        BrandLabel.Text = "Brand:"
        '
        'MedTypeLabel
        '
        MedTypeLabel.AutoSize = True
        MedTypeLabel.Location = New System.Drawing.Point(46, 335)
        MedTypeLabel.Name = "MedTypeLabel"
        MedTypeLabel.Size = New System.Drawing.Size(123, 24)
        MedTypeLabel.TabIndex = 21
        MedTypeLabel.Text = "Form/Type:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(351, 446)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(51, 24)
        QuantityLabel.TabIndex = 22
        QuantityLabel.Text = "Qty:"
        '
        'StocksLabel
        '
        StocksLabel.AutoSize = True
        StocksLabel.Location = New System.Drawing.Point(46, 434)
        StocksLabel.Name = "StocksLabel"
        StocksLabel.Size = New System.Drawing.Size(117, 48)
        StocksLabel.TabIndex = 24
        StocksLabel.Text = "Remaining" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stocks:"
        '
        'StockNumberLabel
        '
        StockNumberLabel.AutoSize = True
        StockNumberLabel.Location = New System.Drawing.Point(44, 387)
        StockNumberLabel.Name = "StockNumberLabel"
        StockNumberLabel.Size = New System.Drawing.Size(114, 24)
        StockNumberLabel.TabIndex = 25
        StockNumberLabel.Text = "Stock No.:"
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
        Me.pnlHeader.TabIndex = 14
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
        'GenericNameTextBox
        '
        Me.GenericNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "GenericName", True))
        Me.GenericNameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenericNameTextBox.Location = New System.Drawing.Point(208, 179)
        Me.GenericNameTextBox.Margin = New System.Windows.Forms.Padding(10)
        Me.GenericNameTextBox.Multiline = True
        Me.GenericNameTextBox.Name = "GenericNameTextBox"
        Me.GenericNameTextBox.ReadOnly = True
        Me.GenericNameTextBox.Size = New System.Drawing.Size(300, 81)
        Me.GenericNameTextBox.TabIndex = 18
        Me.GenericNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'BrandTextBox
        '
        Me.BrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "Brand", True))
        Me.BrandTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandTextBox.Location = New System.Drawing.Point(208, 280)
        Me.BrandTextBox.Margin = New System.Windows.Forms.Padding(10)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.ReadOnly = True
        Me.BrandTextBox.Size = New System.Drawing.Size(300, 32)
        Me.BrandTextBox.TabIndex = 20
        Me.BrandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MedTypeTextBox
        '
        Me.MedTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "MedType", True))
        Me.MedTypeTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedTypeTextBox.Location = New System.Drawing.Point(208, 332)
        Me.MedTypeTextBox.Margin = New System.Windows.Forms.Padding(10)
        Me.MedTypeTextBox.Name = "MedTypeTextBox"
        Me.MedTypeTextBox.ReadOnly = True
        Me.MedTypeTextBox.Size = New System.Drawing.Size(300, 32)
        Me.MedTypeTextBox.TabIndex = 22
        Me.MedTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'QuantityNumericUpDown
        '
        Me.QuantityNumericUpDown.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityNumericUpDown.Location = New System.Drawing.Point(408, 443)
        Me.QuantityNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantityNumericUpDown.Name = "QuantityNumericUpDown"
        Me.QuantityNumericUpDown.Size = New System.Drawing.Size(100, 32)
        Me.QuantityNumericUpDown.TabIndex = 23
        Me.QuantityNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        Me.btnBack.TabIndex = 15
        Me.btnBack.TabStop = False
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnGive
        '
        Me.btnGive.BackColor = System.Drawing.Color.Green
        Me.btnGive.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnGive.FlatAppearance.BorderSize = 0
        Me.btnGive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGive.ForeColor = System.Drawing.Color.White
        Me.btnGive.Location = New System.Drawing.Point(261, 513)
        Me.btnGive.Name = "btnGive"
        Me.btnGive.Size = New System.Drawing.Size(182, 47)
        Me.btnGive.TabIndex = 24
        Me.btnGive.TabStop = False
        Me.btnGive.Text = "Give Medicine"
        Me.btnGive.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnGive.UseVisualStyleBackColor = False
        '
        'StocksTextBox
        '
        Me.StocksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineStocksBindingSource, "Stocks", True))
        Me.StocksTextBox.Location = New System.Drawing.Point(208, 443)
        Me.StocksTextBox.Margin = New System.Windows.Forms.Padding(10)
        Me.StocksTextBox.Name = "StocksTextBox"
        Me.StocksTextBox.ReadOnly = True
        Me.StocksTextBox.Size = New System.Drawing.Size(100, 32)
        Me.StocksTextBox.TabIndex = 25
        '
        'MedicineStocksBindingSource
        '
        Me.MedicineStocksBindingSource.DataMember = "MedicineStocks"
        Me.MedicineStocksBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'StockNumberTextBox
        '
        Me.StockNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineStocksBindingSource, "StockNumber", True))
        Me.StockNumberTextBox.Location = New System.Drawing.Point(208, 384)
        Me.StockNumberTextBox.Margin = New System.Windows.Forms.Padding(10)
        Me.StockNumberTextBox.Name = "StockNumberTextBox"
        Me.StockNumberTextBox.ReadOnly = True
        Me.StockNumberTextBox.Size = New System.Drawing.Size(300, 32)
        Me.StockNumberTextBox.TabIndex = 26
        '
        'DoctorPrescriptionBindingSource
        '
        Me.DoctorPrescriptionBindingSource.DataMember = "DoctorPrescription"
        Me.DoctorPrescriptionBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'DoctorPrescriptionTableAdapter
        '
        Me.DoctorPrescriptionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorPrescriptionTableAdapter = Me.DoctorPrescriptionTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.MedicineStocksTableAdapter = Nothing
        Me.TableAdapterManager.MedicineTableAdapter = Nothing
        Me.TableAdapterManager.MedTypeTableAdapter = Nothing
        Me.TableAdapterManager.PatientInfoTableAdapter = Nothing
        Me.TableAdapterManager.PatientRecordsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.WaitListTableAdapter = Nothing
        '
        'MedicineTableAdapter
        '
        Me.MedicineTableAdapter.ClearBeforeFill = True
        '
        'MedicineStocksTableAdapter
        '
        Me.MedicineStocksTableAdapter.ClearBeforeFill = True
        '
        'ReleaseMedicineForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(700, 600)
        Me.Controls.Add(StockNumberLabel)
        Me.Controls.Add(Me.StockNumberTextBox)
        Me.Controls.Add(StocksLabel)
        Me.Controls.Add(Me.StocksTextBox)
        Me.Controls.Add(Me.btnGive)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityNumericUpDown)
        Me.Controls.Add(GenericNameLabel)
        Me.Controls.Add(Me.GenericNameTextBox)
        Me.Controls.Add(BrandLabel)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(MedTypeLabel)
        Me.Controls.Add(Me.MedTypeTextBox)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "ReleaseMedicineForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineStocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorPrescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents ClinicMgtDbDataSet As Clinic_Management_System.ClinicMgtDbDataSet
    Friend WithEvents DoctorPrescriptionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DoctorPrescriptionTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.DoctorPrescriptionTableAdapter
    Friend WithEvents TableAdapterManager As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MedicineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicineTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineTableAdapter
    Friend WithEvents GenericNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnGive As System.Windows.Forms.Button
    Friend WithEvents MedicineStocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicineStocksTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineStocksTableAdapter
    Friend WithEvents StocksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockNumberTextBox As System.Windows.Forms.TextBox
End Class
