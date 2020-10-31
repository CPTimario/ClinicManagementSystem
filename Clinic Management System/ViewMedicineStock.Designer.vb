<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewMedicineStock
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewMedicineStock))
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.tipViewMedicines = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvViewMedicineStock = New System.Windows.Forms.DataGridView()
        Me.StockNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcquiredDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpirationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StocksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineStocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicMgtDbDataSet = New Clinic_Management_System.ClinicMgtDbDataSet()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.GenericNameTextBox = New System.Windows.Forms.TextBox()
        Me.MedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.MedicineStocksTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineStocksTableAdapter()
        Me.TableAdapterManager = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager()
        Me.MedicineTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineTableAdapter()
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        GenericNameLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        CType(Me.dgvViewMedicineStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineStocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenericNameLabel
        '
        GenericNameLabel.AutoSize = True
        GenericNameLabel.Location = New System.Drawing.Point(51, 181)
        GenericNameLabel.Name = "GenericNameLabel"
        GenericNameLabel.Size = New System.Drawing.Size(158, 24)
        GenericNameLabel.TabIndex = 14
        GenericNameLabel.Text = "Generic Name:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Location = New System.Drawing.Point(51, 275)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(141, 24)
        BrandLabel.TabIndex = 15
        BrandLabel.Text = "Brand Name:"
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
        Me.btnBack.Location = New System.Drawing.Point(850, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(38, 38)
        Me.btnBack.TabIndex = 13
        Me.btnBack.TabStop = False
        Me.tipViewMedicines.SetToolTip(Me.btnBack, "Back")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvViewMedicineStock
        '
        Me.dgvViewMedicineStock.AllowUserToAddRows = False
        Me.dgvViewMedicineStock.AllowUserToDeleteRows = False
        Me.dgvViewMedicineStock.AllowUserToOrderColumns = True
        Me.dgvViewMedicineStock.AllowUserToResizeColumns = False
        Me.dgvViewMedicineStock.AllowUserToResizeRows = False
        Me.dgvViewMedicineStock.AutoGenerateColumns = False
        Me.dgvViewMedicineStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvViewMedicineStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvViewMedicineStock.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.dgvViewMedicineStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvViewMedicineStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvViewMedicineStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewMedicineStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockNumberDataGridViewTextBoxColumn, Me.MedicineIDDataGridViewTextBoxColumn, Me.AcquiredDateDataGridViewTextBoxColumn, Me.ExpirationDateDataGridViewTextBoxColumn, Me.StocksDataGridViewTextBoxColumn})
        Me.dgvViewMedicineStock.DataSource = Me.MedicineStocksBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvViewMedicineStock.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvViewMedicineStock.Location = New System.Drawing.Point(29, 319)
        Me.dgvViewMedicineStock.Margin = New System.Windows.Forms.Padding(20)
        Me.dgvViewMedicineStock.MultiSelect = False
        Me.dgvViewMedicineStock.Name = "dgvViewMedicineStock"
        Me.dgvViewMedicineStock.ReadOnly = True
        Me.dgvViewMedicineStock.RowHeadersVisible = False
        Me.dgvViewMedicineStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvViewMedicineStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvViewMedicineStock.Size = New System.Drawing.Size(842, 326)
        Me.dgvViewMedicineStock.TabIndex = 14
        Me.dgvViewMedicineStock.TabStop = False
        '
        'StockNumberDataGridViewTextBoxColumn
        '
        Me.StockNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StockNumberDataGridViewTextBoxColumn.DataPropertyName = "StockNumber"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Format = "00000000"
        Me.StockNumberDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.StockNumberDataGridViewTextBoxColumn.HeaderText = "Stock No."
        Me.StockNumberDataGridViewTextBoxColumn.Name = "StockNumberDataGridViewTextBoxColumn"
        Me.StockNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockNumberDataGridViewTextBoxColumn.Width = 142
        '
        'MedicineIDDataGridViewTextBoxColumn
        '
        Me.MedicineIDDataGridViewTextBoxColumn.DataPropertyName = "MedicineID"
        Me.MedicineIDDataGridViewTextBoxColumn.HeaderText = "MedicineID"
        Me.MedicineIDDataGridViewTextBoxColumn.Name = "MedicineIDDataGridViewTextBoxColumn"
        Me.MedicineIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedicineIDDataGridViewTextBoxColumn.Visible = False
        Me.MedicineIDDataGridViewTextBoxColumn.Width = 154
        '
        'AcquiredDateDataGridViewTextBoxColumn
        '
        Me.AcquiredDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AcquiredDateDataGridViewTextBoxColumn.DataPropertyName = "AcquiredDate"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Format = "MM/dd/yyyy"
        Me.AcquiredDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.AcquiredDateDataGridViewTextBoxColumn.HeaderText = "Date Acquired"
        Me.AcquiredDateDataGridViewTextBoxColumn.Name = "AcquiredDateDataGridViewTextBoxColumn"
        Me.AcquiredDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExpirationDateDataGridViewTextBoxColumn
        '
        Me.ExpirationDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ExpirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Format = "MM/dd/yyyy"
        Me.ExpirationDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ExpirationDateDataGridViewTextBoxColumn.HeaderText = "Expiration Date"
        Me.ExpirationDateDataGridViewTextBoxColumn.Name = "ExpirationDateDataGridViewTextBoxColumn"
        Me.ExpirationDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StocksDataGridViewTextBoxColumn
        '
        Me.StocksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StocksDataGridViewTextBoxColumn.DataPropertyName = "Stocks"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.StocksDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.StocksDataGridViewTextBoxColumn.HeaderText = "Stocks"
        Me.StocksDataGridViewTextBoxColumn.Name = "StocksDataGridViewTextBoxColumn"
        Me.StocksDataGridViewTextBoxColumn.ReadOnly = True
        Me.StocksDataGridViewTextBoxColumn.Width = 115
        '
        'MedicineStocksBindingSource
        '
        Me.MedicineStocksBindingSource.DataMember = "MedicineStocks"
        Me.MedicineStocksBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'ClinicMgtDbDataSet
        '
        Me.ClinicMgtDbDataSet.DataSetName = "ClinicMgtDbDataSet"
        Me.ClinicMgtDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'GenericNameTextBox
        '
        Me.GenericNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "GenericName", True))
        Me.GenericNameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenericNameTextBox.Location = New System.Drawing.Point(215, 178)
        Me.GenericNameTextBox.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.GenericNameTextBox.Multiline = True
        Me.GenericNameTextBox.Name = "GenericNameTextBox"
        Me.GenericNameTextBox.ReadOnly = True
        Me.GenericNameTextBox.Size = New System.Drawing.Size(373, 84)
        Me.GenericNameTextBox.TabIndex = 15
        Me.GenericNameTextBox.TabStop = False
        Me.GenericNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MedicineBindingSource
        '
        Me.MedicineBindingSource.DataMember = "Medicine"
        Me.MedicineBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'BrandTextBox
        '
        Me.BrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "Brand", True))
        Me.BrandTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandTextBox.Location = New System.Drawing.Point(215, 272)
        Me.BrandTextBox.Margin = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.ReadOnly = True
        Me.BrandTextBox.Size = New System.Drawing.Size(373, 32)
        Me.BrandTextBox.TabIndex = 16
        Me.BrandTextBox.TabStop = False
        Me.BrandTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'MedicineTableAdapter
        '
        Me.MedicineTableAdapter.ClearBeforeFill = True
        '
        'btnAddStock
        '
        Me.btnAddStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddStock.FlatAppearance.BorderSize = 0
        Me.btnAddStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStock.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStock.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddStock
        Me.btnAddStock.Location = New System.Drawing.Point(781, 194)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(90, 110)
        Me.btnAddStock.TabIndex = 17
        Me.btnAddStock.TabStop = False
        Me.btnAddStock.Text = "Add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stock"
        Me.btnAddStock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnAddStock.UseVisualStyleBackColor = True
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
        Me.btnNext.Location = New System.Drawing.Point(392, 668)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(115, 47)
        Me.btnNext.TabIndex = 21
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "Next"
        Me.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'ViewMedicineStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(900, 749)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnAddStock)
        Me.Controls.Add(BrandLabel)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(GenericNameLabel)
        Me.Controls.Add(Me.GenericNameTextBox)
        Me.Controls.Add(Me.dgvViewMedicineStock)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "ViewMedicineStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvViewMedicineStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineStocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents tipViewMedicines As System.Windows.Forms.ToolTip
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvViewMedicineStock As System.Windows.Forms.DataGridView
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ClinicMgtDbDataSet As Clinic_Management_System.ClinicMgtDbDataSet
    Friend WithEvents MedicineStocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicineStocksTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineStocksTableAdapter
    Friend WithEvents TableAdapterManager As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MedicineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicineTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.MedicineTableAdapter
    Friend WithEvents GenericNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAddStock As System.Windows.Forms.Button
    Friend WithEvents StockNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedicineIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcquiredDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpirationDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StocksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNext As System.Windows.Forms.Button
End Class
