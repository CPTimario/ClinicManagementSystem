Public Class ViewPatientRecord

    Dim btnBackHover, btnBackClick As Boolean
    Public patientID, ind, recordID, waitListID As Integer

    Private Sub btnBack_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        btnBackHover = Not btnBackHover
        If btnBackHover Then
            Me.btnBack.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBackHover
        Else
            Me.btnBack.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBack
        End If
    End Sub

    Private Sub btnBack_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
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

    Public Sub DisplayRecord(ByVal patID As Integer)
        patientID = patID
    End Sub

    Public Sub WaitIDValue(ByVal wait As Integer)
        waitListID = wait
    End Sub

    Private Sub ViewPatientRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
        PatientRecordsTableAdapter.FillByPatientID(Me.ClinicMgtDbDataSet.PatientRecords, patientID)
        dgvViewRecords.ClearSelection()
        dgvViewRecords.CurrentCell = Nothing
    End Sub

    Private Sub dgvViewRecords_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvViewRecords.MouseClick
        Try
            ind = dgvViewRecords.CurrentCell.RowIndex
            recordID = dgvViewRecords.Rows(ind).Cells(9).Value
            btnNext.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        DoctorMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        AddFindingsForm.PatIDValue(patientID)
        AddFindingsForm.WaitListValue(waitListID)
        AddFindingsForm.Show()
        Me.Close()
    End Sub

End Class