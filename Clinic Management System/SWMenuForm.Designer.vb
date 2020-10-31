<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SWMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SWMenuForm))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.pnlCheckup = New System.Windows.Forms.Panel()
        Me.timDelay = New System.Windows.Forms.Timer(Me.components)
        Me.tipSWMenuForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAddCheckup = New System.Windows.Forms.Button()
        Me.btnWaitList = New System.Windows.Forms.Button()
        Me.btnUpdateInfo = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnExistPatient = New System.Windows.Forms.Button()
        Me.btnAddPatient = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlCheckup.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlHeader.TabIndex = 1
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
        'pnlCheckup
        '
        Me.pnlCheckup.Controls.Add(Me.btnExistPatient)
        Me.pnlCheckup.Controls.Add(Me.btnAddPatient)
        Me.pnlCheckup.Location = New System.Drawing.Point(13, 516)
        Me.pnlCheckup.Name = "pnlCheckup"
        Me.pnlCheckup.Size = New System.Drawing.Size(284, 172)
        Me.pnlCheckup.TabIndex = 7
        Me.pnlCheckup.Visible = False
        '
        'timDelay
        '
        Me.timDelay.Interval = 250
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblWelcome.Location = New System.Drawing.Point(34, 187)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(393, 37)
        Me.lblWelcome.TabIndex = 8
        Me.lblWelcome.Text = "Welcome Social Worker!"
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
        Me.btnLogout.Location = New System.Drawing.Point(853, 9)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(38, 38)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.TabStop = False
        Me.tipSWMenuForm.SetToolTip(Me.btnLogout, "Log-out")
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnAddCheckup
        '
        Me.btnAddCheckup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddCheckup.FlatAppearance.BorderSize = 0
        Me.btnAddCheckup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddCheckup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAddCheckup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCheckup.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCheckup.ForeColor = System.Drawing.Color.Green
        Me.btnAddCheckup.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddCheckup
        Me.btnAddCheckup.Location = New System.Drawing.Point(60, 280)
        Me.btnAddCheckup.Name = "btnAddCheckup"
        Me.btnAddCheckup.Size = New System.Drawing.Size(190, 230)
        Me.btnAddCheckup.TabIndex = 4
        Me.btnAddCheckup.TabStop = False
        Me.btnAddCheckup.Text = "Add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Checkup"
        Me.btnAddCheckup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnAddCheckup.UseVisualStyleBackColor = True
        '
        'btnWaitList
        '
        Me.btnWaitList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnWaitList.FlatAppearance.BorderSize = 0
        Me.btnWaitList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnWaitList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnWaitList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWaitList.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaitList.ForeColor = System.Drawing.Color.Green
        Me.btnWaitList.Image = CType(resources.GetObject("btnWaitList.Image"), System.Drawing.Image)
        Me.btnWaitList.Location = New System.Drawing.Point(353, 280)
        Me.btnWaitList.Margin = New System.Windows.Forms.Padding(100)
        Me.btnWaitList.Name = "btnWaitList"
        Me.btnWaitList.Size = New System.Drawing.Size(190, 230)
        Me.btnWaitList.TabIndex = 3
        Me.btnWaitList.TabStop = False
        Me.btnWaitList.Text = "View" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Waiting List"
        Me.btnWaitList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnWaitList.UseVisualStyleBackColor = True
        '
        'btnUpdateInfo
        '
        Me.btnUpdateInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdateInfo.FlatAppearance.BorderSize = 0
        Me.btnUpdateInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUpdateInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateInfo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateInfo.ForeColor = System.Drawing.Color.Green
        Me.btnUpdateInfo.Image = CType(resources.GetObject("btnUpdateInfo.Image"), System.Drawing.Image)
        Me.btnUpdateInfo.Location = New System.Drawing.Point(646, 280)
        Me.btnUpdateInfo.Name = "btnUpdateInfo"
        Me.btnUpdateInfo.Size = New System.Drawing.Size(190, 230)
        Me.btnUpdateInfo.TabIndex = 2
        Me.btnUpdateInfo.TabStop = False
        Me.btnUpdateInfo.Text = "Update Patient" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Information"
        Me.btnUpdateInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnUpdateInfo.UseVisualStyleBackColor = True
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
        'btnExistPatient
        '
        Me.btnExistPatient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExistPatient.FlatAppearance.BorderSize = 0
        Me.btnExistPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExistPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExistPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExistPatient.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExistPatient.ForeColor = System.Drawing.Color.Green
        Me.btnExistPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnExistPatient
        Me.btnExistPatient.Location = New System.Drawing.Point(164, 10)
        Me.btnExistPatient.Margin = New System.Windows.Forms.Padding(10)
        Me.btnExistPatient.Name = "btnExistPatient"
        Me.btnExistPatient.Size = New System.Drawing.Size(110, 150)
        Me.btnExistPatient.TabIndex = 6
        Me.btnExistPatient.TabStop = False
        Me.btnExistPatient.Text = " Existing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Patient"
        Me.btnExistPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExistPatient.UseVisualStyleBackColor = True
        '
        'btnAddPatient
        '
        Me.btnAddPatient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddPatient.FlatAppearance.BorderSize = 0
        Me.btnAddPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPatient.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPatient.ForeColor = System.Drawing.Color.Green
        Me.btnAddPatient.Image = CType(resources.GetObject("btnAddPatient.Image"), System.Drawing.Image)
        Me.btnAddPatient.Location = New System.Drawing.Point(10, 10)
        Me.btnAddPatient.Margin = New System.Windows.Forms.Padding(10)
        Me.btnAddPatient.Name = "btnAddPatient"
        Me.btnAddPatient.Size = New System.Drawing.Size(110, 150)
        Me.btnAddPatient.TabIndex = 5
        Me.btnAddPatient.TabStop = False
        Me.btnAddPatient.Text = "Add New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Patient"
        Me.btnAddPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddPatient.UseVisualStyleBackColor = True
        '
        'SWMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.CancelButton = Me.btnLogout
        Me.ClientSize = New System.Drawing.Size(900, 700)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnAddCheckup)
        Me.Controls.Add(Me.btnWaitList)
        Me.Controls.Add(Me.btnUpdateInfo)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.pnlCheckup)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "SWMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlCheckup.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents btnUpdateInfo As System.Windows.Forms.Button
    Friend WithEvents btnWaitList As System.Windows.Forms.Button
    Friend WithEvents btnAddCheckup As System.Windows.Forms.Button
    Friend WithEvents btnAddPatient As System.Windows.Forms.Button
    Friend WithEvents btnExistPatient As System.Windows.Forms.Button
    Friend WithEvents pnlCheckup As System.Windows.Forms.Panel
    Friend WithEvents timDelay As System.Windows.Forms.Timer
    Friend WithEvents tipSWMenuForm As System.Windows.Forms.ToolTip
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
End Class
