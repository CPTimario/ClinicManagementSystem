Public Class ViewExistingPatient

    Dim btnBackHover, btnBackClick, btnEditPatientHover, btnEditPatientClick, btnAddPatientsHover, btnAddPatientsClick As Boolean
    Dim ind As Integer
    Public fnx As String
    Public patientID As Integer

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

    Private Sub btnEditPatient_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditPatient.MouseEnter, btnEditPatient.MouseLeave
        btnEditPatientHover = Not btnEditPatientHover
        If btnEditPatientHover Then
            Me.btnEditPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnEditPatientHover
            Me.btnEditPatient.ForeColor = Color.LimeGreen
        Else
            Me.btnEditPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnEditPatient
            Me.btnEditPatient.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnEditPatient_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnEditPatient.MouseDown, btnEditPatient.MouseUp
        btnEditPatientClick = Not btnEditPatientClick
        If btnEditPatientClick Then
            Me.btnEditPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnEditPatientClick
            Me.btnEditPatient.ForeColor = Color.DarkGreen
        ElseIf btnEditPatientHover Then
            Me.btnEditPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnEditPatientHover
            Me.btnEditPatient.ForeColor = Color.LimeGreen
        Else
            Me.btnEditPatient.Image = Global.Clinic_Management_System.My.Resources.Resources.btnEditPatient
            Me.btnEditPatient.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnAddPatients_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddPatients.MouseEnter, btnAddPatients.MouseLeave
        btnAddPatientsHover = Not btnAddPatientsHover
        If btnAddPatientsHover Then
            Me.btnAddPatients.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddPatientsHover
            Me.btnAddPatients.ForeColor = Color.LimeGreen
        Else
            Me.btnAddPatients.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddPatients
            Me.btnAddPatients.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnAddPatients_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAddPatients.MouseDown, btnAddPatients.MouseUp
        btnAddPatientsClick = Not btnAddPatientsClick
        If btnAddPatientsClick Then
            Me.btnAddPatients.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddPatientsClick
            Me.btnAddPatients.ForeColor = Color.DarkGreen
        ElseIf btnAddPatientsHover Then
            Me.btnAddPatients.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddPatientsHover
            Me.btnAddPatients.ForeColor = Color.LimeGreen
        Else
            Me.btnAddPatients.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddPatients
            Me.btnAddPatients.ForeColor = Color.Green
        End If
    End Sub

    Private Sub ViewExistingPatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
        fnx = SWMenuForm.fnx
        Select Case fnx
            Case "Add Record"
                btnNext.Visible = True
                btnAddPatients.Visible = False
                btnEditPatient.Visible = False
            Case "Edit Patient Info"
                btnNext.Visible = False
                btnAddPatients.Visible = True
                btnEditPatient.Visible = True
        End Select
    End Sub

    Public Sub ViewSaved(ByVal nameSearch As String)
        NameTextBox.Text = nameSearch
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        SWMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameTextBox.TextChanged
        If NameTextBox.Text <> "" Then
            Me.ViewPatientInfoTableAdapter.FillByName(Me.ClinicMgtDbDataSet.ViewPatientInfo, NameTextBox.Text)
            If ind > -1 Then
                btnNext.Enabled = True
                btnEditPatient.Enabled = True
            Else
                btnNext.Enabled = False
                btnEditPatient.Enabled = False
            End If
        End If
    End Sub

    Private Sub dgvViewPatientInfo_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvViewPatientInfo.CellEnter
        ind = dgvViewPatientInfo.CurrentCell.RowIndex
        patientID = dgvViewPatientInfo.Rows(ind).Cells(0).Value
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        AddRecordForm.Show()
        Me.Close()
    End Sub

    Private Sub btnAddPatients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPatients.Click
        fnx = "Add Patients"
        AddPatientForm.Show()
        Me.Close()
    End Sub

    Private Sub btnEditPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPatient.Click
        fnx = NameTextBox.Text
        EditPatientForm.Show()
        Me.Close()
    End Sub
End Class