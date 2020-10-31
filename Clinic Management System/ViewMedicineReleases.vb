Public Class ViewMedicineReleases

    Dim btnBackHover, btnBackClick As Boolean

    Private Sub btnBack_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.MouseEnter, btnBack.MouseLeave
        btnBackHover = Not btnBackHover
        If btnBackHover Then
            Me.btnBack.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBackHover
        Else
            Me.btnBack.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBack
        End If
    End Sub

    Private Sub btnBack_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnBack.MouseDown, btnBack.MouseUp
        btnBackClick = Not btnBackClick
        If btnBackClick Then
            Me.btnBack.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBackClick
        ElseIf btnBackHover Then
            Me.btnBack.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBackHover
        Else
            Me.btnBack.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBack
        End If
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
    End Sub

    Private Sub ViewMedicineReleases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MedsReleaseTableAdapter.FillSorted(Me.ClinicMgtDbDataSet.MedsRelease)
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        AdminMenuForm.Show()
        Me.Close()
    End Sub

End Class