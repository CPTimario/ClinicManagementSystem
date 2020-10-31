<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMenuForm))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.tipAdminMenuForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMedReleases = New System.Windows.Forms.Button()
        Me.btnAccSettings = New System.Windows.Forms.Button()
        Me.btnMedStorage = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblWelcome.Location = New System.Drawing.Point(34, 187)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(275, 37)
        Me.lblWelcome.TabIndex = 11
        Me.lblWelcome.Text = "Welcome Admin!"
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
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.TabStop = False
        Me.tipAdminMenuForm.SetToolTip(Me.btnLogout, "Log-out")
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnMedReleases
        '
        Me.btnMedReleases.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMedReleases.FlatAppearance.BorderSize = 0
        Me.btnMedReleases.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMedReleases.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMedReleases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedReleases.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedReleases.ForeColor = System.Drawing.Color.Green
        Me.btnMedReleases.Image = Global.Clinic_Management_System.My.Resources.Resources.btnMedReleases
        Me.btnMedReleases.Location = New System.Drawing.Point(353, 276)
        Me.btnMedReleases.Margin = New System.Windows.Forms.Padding(100)
        Me.btnMedReleases.Name = "btnMedReleases"
        Me.btnMedReleases.Size = New System.Drawing.Size(190, 230)
        Me.btnMedReleases.TabIndex = 14
        Me.btnMedReleases.TabStop = False
        Me.btnMedReleases.Text = "Medicine" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Releases"
        Me.btnMedReleases.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnMedReleases.UseVisualStyleBackColor = True
        '
        'btnAccSettings
        '
        Me.btnAccSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAccSettings.FlatAppearance.BorderSize = 0
        Me.btnAccSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAccSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAccSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccSettings.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccSettings.ForeColor = System.Drawing.Color.Green
        Me.btnAccSettings.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAccSettings
        Me.btnAccSettings.Location = New System.Drawing.Point(646, 276)
        Me.btnAccSettings.Name = "btnAccSettings"
        Me.btnAccSettings.Size = New System.Drawing.Size(190, 230)
        Me.btnAccSettings.TabIndex = 13
        Me.btnAccSettings.TabStop = False
        Me.btnAccSettings.Text = "User Accounts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Settings"
        Me.btnAccSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnAccSettings.UseVisualStyleBackColor = True
        '
        'btnMedStorage
        '
        Me.btnMedStorage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMedStorage.FlatAppearance.BorderSize = 0
        Me.btnMedStorage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMedStorage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMedStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedStorage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedStorage.ForeColor = System.Drawing.Color.Green
        Me.btnMedStorage.Image = Global.Clinic_Management_System.My.Resources.Resources.btnMedStorage
        Me.btnMedStorage.Location = New System.Drawing.Point(60, 276)
        Me.btnMedStorage.Name = "btnMedStorage"
        Me.btnMedStorage.Size = New System.Drawing.Size(190, 230)
        Me.btnMedStorage.TabIndex = 12
        Me.btnMedStorage.TabStop = False
        Me.btnMedStorage.Text = "Medicine" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inventory"
        Me.btnMedStorage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnMedStorage.UseVisualStyleBackColor = True
        '
        'AdminMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.CancelButton = Me.btnLogout
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.btnMedReleases)
        Me.Controls.Add(Me.btnAccSettings)
        Me.Controls.Add(Me.btnMedStorage)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnLogout)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "AdminMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents timClock As System.Windows.Forms.Timer
    Friend WithEvents tipAdminMenuForm As System.Windows.Forms.ToolTip
    Friend WithEvents btnMedStorage As System.Windows.Forms.Button
    Friend WithEvents btnAccSettings As System.Windows.Forms.Button
    Friend WithEvents btnMedReleases As System.Windows.Forms.Button
End Class
