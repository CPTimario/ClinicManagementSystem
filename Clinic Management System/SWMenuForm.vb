Public Class SWMenuForm

    Dim btnLogoutClick, btnLogoutHover, btnUpdateInfoHover, btnUpdateInfoClick, btnWaitListHover, btnWaitListClick, btnAddCheckupHover, btnAddCheckupClick, btnAddPatientHover, btnAddPatientClick, btnExistPatientHover, btnExistPatientClick, pnlCheckupVisible As Boolean
    Public fnx As String

    Private Sub btnLogout_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.MouseEnter, btnLogout.MouseLeave
        btnLogoutHover = Not btnLogoutHover
        If btnLogoutHover Then
            Me.btnLogout.Image = Global.Clinic_Management_System.My.Resources.Resources.btnLogoutHover
        Else
            Me.btnLogout.Image = Global.Clinic_Management_System.My.Resources.Resources.btnLogout
        End If
    End Sub

    Private Sub btnLogout_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnLogout.MouseDown, btnLogout.MouseUp
        btnLogoutClick = Not btnLogoutClick
        If btnLogoutClick Then
            Me.btnLogout.Image = Global.Clinic_Management_System.My.Resources.Resources.btnLogoutClick
        ElseIf btnLogoutHover Then
            Me.btnLogout.Image = Global.Clinic_Management_System.My.Resources.Resources.btnLogoutHover
        Else
            Me.btnLogout.Image = Global.Clinic_Management_System.My.Resources.Resources.btnLogout
        End If
    End Sub

    Private Sub btnUpdateInfo_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateInfo.MouseEnter, btnUpdateInfo.MouseLeave
        btnUpdateInfoHover = Not btnUpdateInfoHover
        If btnUpdateInfoHover Then
            Me.btnUpdateInfo.Image = Global.Clinic_Management_System.My.Resources.Resources.btnUpdateInfoHover
            btnUpdateInfo.ForeColor = Color.LimeGreen
        Else
            Me.btnUpdateInfo.Image = Global.Clinic_Management_System.My.Resources.Resources.btnUpdateInfo
            btnUpdateInfo.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnUpdateInfo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnUpdateInfo.MouseDown, btnUpdateInfo.MouseUp
        btnUpdateInfoClick = Not btnUpdateInfoClick
        If btnUpdateInfoClick Then
            Me.btnUpdateInfo.Image = Global.Clinic_Management_System.My.Resources.Resources.btnUpdateInfoClick
            btnUpdateInfo.ForeColor = Color.DarkGreen
        ElseIf btnUpdateInfoHover Then
            Me.btnUpdateInfo.Image = Global.Clinic_Management_System.My.Resources.Resources.btnUpdateInfoHover
            btnUpdateInfo.ForeColor = Color.LimeGreen
        Else
            Me.btnUpdateInfo.Image = Global.Clinic_Management_System.My.Resources.Resources.btnUpdateInfo
            btnUpdateInfo.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnWaitList_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWaitList.MouseEnter, btnWaitList.MouseLeave
        btnWaitListHover = Not btnWaitListHover
        If btnWaitListHover Then
            Me.btnWaitList.Image = Global.Clinic_Management_System.My.Resources.Resources.btnWaitListHover
            btnWaitList.ForeColor = Color.LimeGreen
        Else
            Me.btnWaitList.Image = Global.Clinic_Management_System.My.Resources.Resources.btnWaitList
            btnWaitList.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnWaitList_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnWaitList.MouseDown, btnWaitList.MouseUp
        btnWaitListClick = Not btnWaitListClick
        If btnWaitListClick Then
            Me.btnWaitList.Image = Global.Clinic_Management_System.My.Resources.Resources.btnWaitListClick
            btnWaitList.ForeColor = Color.DarkGreen
        ElseIf btnWaitListHover Then
            Me.btnWaitList.Image = Global.Clinic_Management_System.My.Resources.Resources.btnWaitListHover
            btnWaitList.ForeColor = Color.LimeGreen
        Else
            Me.btnWaitList.Image = Global.Clinic_Management_System.My.Resources.Resources.btnWaitList
            btnWaitList.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnAddCheckup_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddCheckup.MouseEnter, btnAddCheckup.MouseLeave
        btnAddCheckupHover = Not btnAddCheckupHover
        If btnAddCheckupHover Then
            Me.btnAddCheckup.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddCheckupHover
            btnAddCheckup.ForeColor = Color.LimeGreen
            pnlCheckup.Visible = True
            timDelay.Enabled = False
        Else
            Me.btnAddCheckup.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddCheckup
            btnAddCheckup.ForeColor = Color.Green
            If Not pnlCheckupVisible Then
                timDelay.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnAddCheckup_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAddCheckup.MouseDown, btnAddCheckup.MouseUp
        btnAddCheckupClick = Not btnAddCheckupClick
        If btnAddCheckupClick Then
            Me.btnAddCheckup.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddCheckupClick
            btnAddCheckup.ForeColor = Color.DarkGreen
        ElseIf btnAddCheckupHover Then
            Me.btnAddCheckup.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddCheckupHover
            btnAddCheckup.ForeColor = Color.LimeGreen
        Else
            Me.btnAddCheckup.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddCheckup
            btnAddCheckup.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnAddPatient_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddPatient.MouseEnter, btnAddPatient.MouseLeave
        btnAddPatientHover = Not btnAddPatientHover
        If btnAddPatientHover Then
            Me.btnAddPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddPatientHover
            btnAddPatient.ForeColor = Color.LimeGreen
        Else
            Me.btnAddPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddPatient
            btnAddPatient.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnAddPatient_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAddPatient.MouseDown, btnAddPatient.MouseUp
        btnAddPatientClick = Not btnAddPatientClick
        If btnAddPatientClick Then
            Me.btnAddPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddPatientClick
            btnAddPatient.ForeColor = Color.DarkGreen
        ElseIf btnAddPatientHover Then
            Me.btnAddPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddPatientHover
            btnAddPatient.ForeColor = Color.LimeGreen
        Else
            Me.btnAddPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddPatient
            btnAddPatient.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnExistPatient_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExistPatient.MouseEnter, btnExistPatient.MouseLeave
        btnExistPatientHover = Not btnExistPatientHover
        If btnExistPatientHover Then
            Me.btnExistPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnExistPatientHover
            btnExistPatient.ForeColor = Color.LimeGreen
        Else
            Me.btnExistPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnExistPatient
            btnExistPatient.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnExistPatient_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnExistPatient.MouseDown, btnExistPatient.MouseUp
        btnExistPatientClick = Not btnExistPatientClick
        If btnExistPatientClick Then
            Me.btnExistPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnExistPatientClick
            btnExistPatient.ForeColor = Color.DarkGreen
        ElseIf btnExistPatientHover Then
            Me.btnExistPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnExistPatientHover
            btnExistPatient.ForeColor = Color.LimeGreen
        Else
            Me.btnExistPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnExistPatient
            btnExistPatient.ForeColor = Color.Green
        End If
    End Sub

    Private Sub timDelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timDelay.Tick
        pnlCheckup.Visible = False
    End Sub

    Private Sub pnlCheckup_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlCheckup.MouseEnter, btnAddPatient.MouseEnter, btnExistPatient.MouseEnter
        pnlCheckup.Visible = True
        timDelay.Enabled = False
    End Sub

    Private Sub pnlCheckup_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlCheckup.MouseLeave, btnAddPatient.MouseLeave, btnExistPatient.MouseLeave
        If Not pnlCheckupVisible Then
            timDelay.Enabled = True
        End If
    End Sub

    Private Sub pnlCheckup_Visible(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlHeader.Click, picLogo.Click, MyBase.Click, lblTitle.Click, lblDateTime.Click, btnWaitList.Click, btnUpdateInfo.Click, btnLogout.Click
        pnlCheckup.Visible = False
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
    End Sub

    Private Sub SWMenuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        lblWelcome.Text = "Welcome " + LoginForm.fname + "!"
        timClock.Enabled = True
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Select Case MessageBox.Show("Do you want to log-out?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                LoginForm.ResetLogin()
                LoginForm.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub btnAddCheckup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCheckup.Click
        pnlCheckupVisible = Not pnlCheckupVisible
        If pnlCheckupVisible Then
            pnlCheckup.Visible = True
        Else
            pnlCheckup.Visible = False
        End If
    End Sub

    Private Sub btnAddPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPatient.Click
        fnx = "Add Patient"
        AddPatientForm.Show()
        Me.Close()
    End Sub

    Private Sub btnExistPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExistPatient.Click
        fnx = "Add Record"
        ViewExistingPatient.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdateInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateInfo.Click
        fnx = "Edit Patient Info"
        ViewExistingPatient.Show()
        Me.Close()
    End Sub

    Private Sub btnWaitList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWaitList.Click
        WaitListForm.Show()
        Me.Close()
    End Sub

End Class