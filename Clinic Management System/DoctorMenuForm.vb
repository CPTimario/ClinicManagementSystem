Public Class DoctorMenuForm

    Dim btnLogoutClick, btnLogoutHover As Boolean
    Public patientID, waitID As Integer
    Dim ind As Integer

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

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
    End Sub

    Private Sub DoctorForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        lblWelcome.Text = "Welcome Dr. " + LoginForm.lname + "!"
        timClock.Enabled = True
        WaitListTableAdapter.FillByDatePending(Me.ClinicMgtDbDataSet.WaitList, Now.Date)
        dgvWaitList.ClearSelection()
        dgvWaitList.CurrentCell = Nothing
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Select Case MessageBox.Show("Do you want to log-out?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                LoginForm.ResetLogin()
                LoginForm.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub dgvWaitList_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvWaitList.MouseClick
        Try
            ind = dgvWaitList.CurrentCell.RowIndex
            patientID = dgvWaitList.Rows(ind).Cells(0).Value
            waitID = dgvWaitList.Rows(ind).Cells(5).Value
            btnNext.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        ViewPatientRecord.DisplayRecord(patientID)
        ViewPatientRecord.WaitIDValue(waitID)
        ViewPatientRecord.Show()
        Me.Close()
    End Sub

End Class