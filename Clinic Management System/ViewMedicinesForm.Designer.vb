<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewMedicinesForm
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewMedicinesForm))
        Me.dgvViewMedicine = New System.Windows.Forms.DataGridView()
        Me.MedicineIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenericNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumOfStocksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewMedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicMgtDbDataSet = New Clinic_Management_System.ClinicMgtDbDataSet()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.SearchNameTextBox = New System.Windows.Forms.TextBox()
        Me.tipViewMedicines = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ViewMedicineTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.ViewMedicineTableAdapter()
        Me.TableAdapterManager = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager()
        Me.btnEditMedicine = New System.Windows.Forms.Button()
        Me.btnAddMedicine = New System.Windows.Forms.Button()
        Me.btnViewStock = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSkip = New System.Windows.Forms.Button()
        CType(Me.dgvViewMedicine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewMedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvViewMedicine
        '
        Me.dgvViewMedicine.AllowUserToAddRows = False
        Me.dgvViewMedicine.AllowUserToDeleteRows = False
        Me.dgvViewMedicine.AllowUserToOrderColumns = True
        Me.dgvViewMedicine.AllowUserToResizeColumns = False
        Me.dgvViewMedicine.AllowUserToResizeRows = False
        Me.dgvViewMedicine.AutoGenerateColumns = False
        Me.dgvViewMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvViewMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvViewMedicine.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.dgvViewMedicine.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvViewMedicine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvViewMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewMedicine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedicineIDDataGridViewTextBoxColumn, Me.GenericNameDataGridViewTextBoxColumn, Me.BrandDataGridViewTextBoxColumn, Me.MedTypeDataGridViewTextBoxColumn, Me.SumOfStocksDataGridViewTextBoxColumn})
        Me.dgvViewMedicine.DataSource = Me.ViewMedicineBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvViewMedicine.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvViewMedicine.Location = New System.Drawing.Point(29, 231)
        Me.dgvViewMedicine.Margin = New System.Windows.Forms.Padding(20)
        Me.dgvViewMedicine.MultiSelect = False
        Me.dgvViewMedicine.Name = "dgvViewMedicine"
        Me.dgvViewMedicine.ReadOnly = True
        Me.dgvViewMedicine.RowHeadersVisible = False
        Me.dgvViewMedicine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvViewMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvViewMedicine.Size = New System.Drawing.Size(942, 367)
        Me.dgvViewMedicine.TabIndex = 9
        Me.dgvViewMedicine.TabStop = False
        '
        'MedicineIDDataGridViewTextBoxColumn
        '
        Me.MedicineIDDataGridViewTextBoxColumn.DataPropertyName = "MedicineID"
        Me.MedicineIDDataGridViewTextBoxColumn.HeaderText = "MedicineID"
        Me.MedicineIDDataGridViewTextBoxColumn.Name = "MedicineIDDataGridViewTextBoxColumn"
        Me.MedicineIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedicineIDDataGridViewTextBoxColumn.Visible = False
        Me.MedicineIDDataGridViewTextBoxColumn.Width = 135
        '
        'GenericNameDataGridViewTextBoxColumn
        '
        Me.GenericNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GenericNameDataGridViewTextBoxColumn.DataPropertyName = "GenericName"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.GenericNameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.GenericNameDataGridViewTextBoxColumn.HeaderText = "Generic Name"
        Me.GenericNameDataGridViewTextBoxColumn.Name = "GenericNameDataGridViewTextBoxColumn"
        Me.GenericNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BrandDataGridViewTextBoxColumn
        '
        Me.BrandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BrandDataGridViewTextBoxColumn.DataPropertyName = "Brand"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.BrandDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.BrandDataGridViewTextBoxColumn.HeaderText = "Brand Name"
        Me.BrandDataGridViewTextBoxColumn.Name = "BrandDataGridViewTextBoxColumn"
        Me.BrandDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedTypeDataGridViewTextBoxColumn
        '
        Me.MedTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MedTypeDataGridViewTextBoxColumn.DataPropertyName = "MedType"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.MedTypeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.MedTypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.MedTypeDataGridViewTextBoxColumn.Name = "MedTypeDataGridViewTextBoxColumn"
        Me.MedTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedTypeDataGridViewTextBoxColumn.Width = 92
        '
        'SumOfStocksDataGridViewTextBoxColumn
        '
        Me.SumOfStocksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SumOfStocksDataGridViewTextBoxColumn.DataPropertyName = "SumOfStocks"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.SumOfStocksDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.SumOfStocksDataGridViewTextBoxColumn.HeaderText = "Stocks"
        Me.SumOfStocksDataGridViewTextBoxColumn.Name = "SumOfStocksDataGridViewTextBoxColumn"
        Me.SumOfStocksDataGridViewTextBoxColumn.ReadOnly = True
        Me.SumOfStocksDataGridViewTextBoxColumn.Width = 115
        '
        'ViewMedicineBindingSource
        '
        Me.ViewMedicineBindingSource.DataMember = "ViewMedicine"
        Me.ViewMedicineBindingSource.DataSource = Me.ClinicMgtDbDataSet
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
        Me.pnlHeader.TabIndex = 7
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
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(53, 187)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(235, 24)
        Me.lblSearch.TabIndex = 10
        Me.lblSearch.Text = "Search Generic Name:"
        '
        'SearchNameTextBox
        '
        Me.SearchNameTextBox.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchNameTextBox.Location = New System.Drawing.Point(298, 184)
        Me.SearchNameTextBox.Name = "SearchNameTextBox"
        Me.SearchNameTextBox.Size = New System.Drawing.Size(313, 32)
        Me.SearchNameTextBox.TabIndex = 0
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
        Me.btnBack.TabIndex = 8
        Me.btnBack.TabStop = False
        Me.tipViewMedicines.SetToolTip(Me.btnBack, "Back")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ViewMedicineTableAdapter
        '
        Me.ViewMedicineTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DoctorPrescriptionTableAdapter = Nothing
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
        'btnEditMedicine
        '
        Me.btnEditMedicine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEditMedicine.Enabled = False
        Me.btnEditMedicine.FlatAppearance.BorderSize = 0
        Me.btnEditMedicine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditMedicine.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditMedicine.Image = CType(resources.GetObject("btnEditMedicine.Image"), System.Drawing.Image)
        Me.btnEditMedicine.Location = New System.Drawing.Point(785, 108)
        Me.btnEditMedicine.Name = "btnEditMedicine"
        Me.btnEditMedicine.Size = New System.Drawing.Size(90, 110)
        Me.btnEditMedicine.TabIndex = 14
        Me.btnEditMedicine.TabStop = False
        Me.btnEditMedicine.Text = "Edit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Medicine"
        Me.btnEditMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEditMedicine.UseVisualStyleBackColor = True
        '
        'btnAddMedicine
        '
        Me.btnAddMedicine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddMedicine.FlatAppearance.BorderSize = 0
        Me.btnAddMedicine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMedicine.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMedicine.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddMedicine
        Me.btnAddMedicine.Location = New System.Drawing.Point(689, 108)
        Me.btnAddMedicine.Name = "btnAddMedicine"
        Me.btnAddMedicine.Size = New System.Drawing.Size(90, 110)
        Me.btnAddMedicine.TabIndex = 12
        Me.btnAddMedicine.TabStop = False
        Me.btnAddMedicine.Text = "Add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Medicine"
        Me.btnAddMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnAddMedicine.UseVisualStyleBackColor = True
        '
        'btnViewStock
        '
        Me.btnViewStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnViewStock.Enabled = False
        Me.btnViewStock.FlatAppearance.BorderSize = 0
        Me.btnViewStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnViewStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnViewStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewStock.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewStock.Image = Global.Clinic_Management_System.My.Resources.Resources.btnViewStock
        Me.btnViewStock.Location = New System.Drawing.Point(881, 108)
        Me.btnViewStock.Name = "btnViewStock"
        Me.btnViewStock.Size = New System.Drawing.Size(90, 110)
        Me.btnViewStock.TabIndex = 13
        Me.btnViewStock.TabStop = False
        Me.btnViewStock.Text = "View" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stock"
        Me.btnViewStock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnViewStock.UseVisualStyleBackColor = True
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
        Me.btnNext.Location = New System.Drawing.Point(340, 621)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(115, 47)
        Me.btnNext.TabIndex = 19
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "Next"
        Me.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnSkip
        '
        Me.btnSkip.BackColor = System.Drawing.Color.Green
        Me.btnSkip.Enabled = False
        Me.btnSkip.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnSkip.FlatAppearance.BorderSize = 0
        Me.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSkip.ForeColor = System.Drawing.Color.White
        Me.btnSkip.Image = Global.Clinic_Management_System.My.Resources.Resources.btnSkip
        Me.btnSkip.Location = New System.Drawing.Point(531, 621)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(115, 47)
        Me.btnSkip.TabIndex = 20
        Me.btnSkip.TabStop = False
        Me.btnSkip.Text = "Skip"
        Me.btnSkip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSkip.UseVisualStyleBackColor = False
        '
        'ViewMedicinesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnEditMedicine)
        Me.Controls.Add(Me.btnAddMedicine)
        Me.Controls.Add(Me.SearchNameTextBox)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.dgvViewMedicine)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnViewStock)
        Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "ViewMedicinesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvViewMedicine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewMedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvViewMedicine As System.Windows.Forms.DataGridView
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents FormatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents SearchNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAddMedicine As System.Windows.Forms.Button
    Friend WithEvents btnViewStock As System.Windows.Forms.Button
    Friend WithEvents tipViewMedicines As System.Windows.Forms.ToolTip
    Friend WithEvents ClinicMgtDbDataSet As Clinic_Management_System.ClinicMgtDbDataSet
    Friend WithEvents ViewMedicineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewMedicineTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.ViewMedicineTableAdapter
    Friend WithEvents TableAdapterManager As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MedicineIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenericNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrandDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SumOfStocksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEditMedicine As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSkip As System.Windows.Forms.Button
End Class
