Public Class AdminMenuForm

    Dim btnLogoutClick, btnLogoutHover, btnMedStorageHover, btnMedStorageClick, btnAccSettingsHover, btnAccSettingsClick, btnMedReleasesHover, btnMedReleasesClick As Boolean

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

    Private Sub btnMedStorage_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMedStorage.MouseEnter, btnMedStorage.MouseLeave
        btnMedStorageHover = Not btnMedStorageHover
        If btnMedStorageHover Then
            Me.btnMedStorage.Image = Global.Clinic_Management_System.My.Resources.Resources.btnMedStorageHover
            btnMedStorage.ForeColor = Color.LimeGreen
        Else
            Me.btnMedStorage.Image = Global.Clinic_Management_System.My.Resources.Resources.btnMedStorage
            btnMedStorage.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnMedStorage_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMedStorage.MouseDown, btnMedStorage.MouseUp
        btnMedStorageClick = Not btnMedStorageClick
        If btnMedStorageClick Then
            Me.btnMedStorage.Image = Global.Clinic_Management_System.My.Resources.Resources.btnMedStorageClick
            btnMedStorage.ForeColor = Color.DarkGreen
        ElseIf btnMedStorageHover Then
            Me.btnMedStorage.Image = Global.Clinic_Management_System.My.Resources.Resources.btnMedStorageHover
            btnMedStorage.ForeColor = Color.LimeGreen
        Else
            Me.btnMedStorage.Image = Global.Clinic_Management_System.My.Resources.Resources.btnMedStorage
            btnMedStorage.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnAccSettings_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAccSettings.MouseEnter, btnAccSettings.MouseLeave
        btnAccSettingsHover = Not btnAccSettingsHover
        If btnAccSettingsHover Then
            Me.btnAccSettings.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAccSettingsHover
            btnAccSettings.ForeColor = Color.LimeGreen
        Else
            Me.btnAccSettings.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAccSettings
            btnAccSettings.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnAccSettings_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAccSettings.MouseDown, btnAccSettings.MouseUp
        btnAccSettingsClick = Not btnAccSettingsClick
        If btnAccSettingsClick Then
            Me.btnAccSettings.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAccSettingsClick
            btnAccSettings.ForeColor = Color.DarkGreen
        ElseIf btnAccSettingsHover Then
            Me.btnAccSettings.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAccSettingsHover
            btnAccSettings.ForeColor = Color.LimeGreen
        Else
            Me.btnAccSettings.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAccSettings
            btnAccSettings.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnMedReleases_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMedReleases.MouseEnter, btnMedReleases.MouseLeave
        btnMedReleasesHover = Not btnMedReleasesHover
        If btnMedReleasesHover Then
            Me.btnMedReleases.Image = Global.Clinic_Management_System.My.Resources.Resources.btnMedReleasesHover
            btnMedReleases.ForeColor = Color.LimeGreen
        Else
            Me.btnMedReleases.Image = Global.Clinic_Management_System.My.Resources.Resources.btnMedReleases
            btnMedReleases.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnMedReleases_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMedReleases.MouseDown, btnMedReleases.MouseUp
        btnMedReleasesClick = Not btnMedReleasesClick
        If btnMedReleasesClick Then
            Me.btnMedReleases.Image = Global.Clinic_Management_System.My.Resources.Resources.btnMedReleasesClick
            btnMedReleases.ForeColor = Color.DarkGreen
        ElseIf btnMedReleasesHover Then
            Me.btnMedReleases.Image = Global.Clinic_Management_System.My.Resources.Resources.btnMedReleasesHover
            btnMedReleases.ForeColor = Color.LimeGreen
        Else
            Me.btnMedReleases.Image = Global.Clinic_Management_System.My.Resources.Resources.btnMedReleases
            btnMedReleases.ForeColor = Color.Green
        End If
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
    End Sub

    Private Sub AdminMenuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnMedStorage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedStorage.Click
        ViewMedicinesForm.Show()
        Me.Close()
    End Sub

    Private Sub btnAccSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccSettings.Click
        AccountSettingsForm.Show()
        Me.Close()
    End Sub

    Private Sub btnMedReleases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedReleases.Click
        ViewMedicineReleases.Show()
        Me.Close()
    End Sub
End Class