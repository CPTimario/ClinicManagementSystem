<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorMenuForm))
        Me.tipDoctorMenuForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.dgvWaitList = New System.Windows.Forms.DataGridView()
        Me.PatientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaitDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaitTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaitListID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaitListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicMgtDbDataSet = New Clinic_Management_System.ClinicMgtDbDataSet()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.WaitListTableAdapter = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.WaitListTableAdapter()
        Me.TableAdapterManager = New Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvWaitList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaitListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.AutoSize = True
        Me.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Image = Global.Clinic_Management_System.My.Resources.Resources.btnLogout
        Me.btnLogout.Location = New System.Drawing.Point(603, 9)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(38, 38)
        Me.btnLogout.TabIndex = 11
        Me.btnLogout.TabStop = False
        Me.tipDoctorMenuForm.SetToolTip(Me.btnLogout, "Log-out")
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'timClock
        '
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblWelcome.Location = New System.Drawing.Point(34, 187)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(280, 37)
        Me.lblWelcome.TabIndex = 13
        Me.lblWelcome.Text = "Welcome Doctor!"
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
        'dgvWaitList
        '
        Me.dgvWaitList.AllowUserToAddRows = False
        Me.dgvWaitList.AllowUserToDeleteRows = False
        Me.dgvWaitList.AllowUserToOrderColumns = True
        Me.dgvWaitList.AllowUserToResizeColumns = False
        Me.dgvWaitList.AllowUserToResizeRows = False
        Me.dgvWaitList.AutoGenerateColumns = False
        Me.dgvWaitList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvWaitList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvWaitList.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.dgvWaitList.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvWaitList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvWaitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWaitList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientIDDataGridViewTextBoxColumn, Me.WaitDateDataGridViewTextBoxColumn, Me.WaitTimeDataGridViewTextBoxColumn, Me.PatientDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.WaitListID})
        Me.dgvWaitList.DataSource = Me.WaitListBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvWaitList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvWaitList.Location = New System.Drawing.Point(29, 260)
        Me.dgvWaitList.Margin = New System.Windows.Forms.Padding(20)
        Me.dgvWaitList.MultiSelect = False
        Me.dgvWaitList.Name = "dgvWaitList"
        Me.dgvWaitList.ReadOnly = True
        Me.dgvWaitList.RowHeadersVisible = False
        Me.dgvWaitList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvWaitList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWaitList.Size = New System.Drawing.Size(592, 328)
        Me.dgvWaitList.TabIndex = 14
        Me.dgvWaitList.TabStop = False
        '
        'PatientIDDataGridViewTextBoxColumn
        '
        Me.PatientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID"
        Me.PatientIDDataGridViewTextBoxColumn.HeaderText = "PatientID"
        Me.PatientIDDataGridViewTextBoxColumn.Name = "PatientIDDataGridViewTextBoxColumn"
        Me.PatientIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientIDDataGridViewTextBoxColumn.Visible = False
        Me.PatientIDDataGridViewTextBoxColumn.Width = 116
        '
        'WaitDateDataGridViewTextBoxColumn
        '
        Me.WaitDateDataGridViewTextBoxColumn.DataPropertyName = "WaitDate"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Format = "MM/dd/yyyy"
        Me.WaitDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.WaitDateDataGridViewTextBoxColumn.HeaderText = "Arrival Date"
        Me.WaitDateDataGridViewTextBoxColumn.Name = "WaitDateDataGridViewTextBoxColumn"
        Me.WaitDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.WaitDateDataGridViewTextBoxColumn.Visible = False
        Me.WaitDateDataGridViewTextBoxColumn.Width = 144
        '
        'WaitTimeDataGridViewTextBoxColumn
        '
        Me.WaitTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.WaitTimeDataGridViewTextBoxColumn.DataPropertyName = "WaitTime"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Format = "hh:mm tt"
        Me.WaitTimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.WaitTimeDataGridViewTextBoxColumn.HeaderText = "Arrival Time"
        Me.WaitTimeDataGridViewTextBoxColumn.Name = "WaitTimeDataGridViewTextBoxColumn"
        Me.WaitTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.WaitTimeDataGridViewTextBoxColumn.Width = 166
        '
        'PatientDataGridViewTextBoxColumn
        '
        Me.PatientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PatientDataGridViewTextBoxColumn.DataPropertyName = "Patient"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.PatientDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PatientDataGridViewTextBoxColumn.HeaderText = "Patient"
        Me.PatientDataGridViewTextBoxColumn.Name = "PatientDataGridViewTextBoxColumn"
        Me.PatientDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.StatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Visible = False
        '
        'WaitListID
        '
        Me.WaitListID.DataPropertyName = "WaitListID"
        Me.WaitListID.HeaderText = "WaitListID"
        Me.WaitListID.Name = "WaitListID"
        Me.WaitListID.ReadOnly = True
        Me.WaitListID.Visible = False
        Me.WaitListID.Width = 146
        '
        'WaitListBindingSource
        '
        Me.WaitListBindingSource.DataMember = "WaitList"
        Me.WaitListBindingSource.DataSource = Me.ClinicMgtDbDataSet
        '
        'ClinicMgtDbDataSet
        '
        Me.ClinicMgtDbDataSet.DataSetName = "ClinicMgtDbDataSet"
        Me.ClinicMgtDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.btnNext.Location = New System.Drawing.Point(269, 625)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(115, 47)
        Me.btnNext.TabIndex = 15
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "Next"
        Me.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'WaitListTableAdapter
        '
        Me.WaitListTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.UserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.WaitListTableAdapter = Me.WaitListTableAdapter
        '
        'DoctorMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(650, 700)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.dgvWaitList)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnLogout)
        Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "DoctorMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvWaitList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaitListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicMgtDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents tipDoctorMenuForm As System.Windows.Forms.ToolTip
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents dgvWaitList As System.Windows.Forms.DataGridView
    Friend WithEvents ClinicMgtDbDataSet As Clinic_Management_System.ClinicMgtDbDataSet
    Friend WithEvents WaitListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WaitListTableAdapter As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.WaitListTableAdapter
    Friend WithEvents TableAdapterManager As Clinic_Management_System.ClinicMgtDbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents PatientIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaitDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaitTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaitListID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
