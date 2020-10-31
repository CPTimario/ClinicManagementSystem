Public Class AddFindingsForm

    Dim btnBackHover, btnBackClick As Boolean
    Public patientID, recordID, waitListID As Integer

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

    Private Sub AddFindingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
        recordID = ViewPatientRecord.recordID
        PatientRecordsTableAdapter.FillByRecordID(Me.ClinicMgtDbDataSet.PatientRecords, recordID)
        WaitListTableAdapter.FillByWaitList(Me.ClinicMgtDbDataSet.WaitList, waitListID)
    End Sub

    Public Sub WaitListValue(ByVal wait As Integer)
        waitListID = wait
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If FindingsTextBox.Text <> "" And RemarksTextBox.Text <> "" Then
            StatusTextBox.Text = "Finished"
            Me.Validate()
            Me.PatientRecordsBindingSource.EndEdit()
            Me.WaitListBindingSource.EndEdit()
            Me.PatientRecordsTableAdapter.Update(Me.ClinicMgtDbDataSet)
            Me.WaitListTableAdapter.Update(Me.ClinicMgtDbDataSet)
            Me.TableAdapterManager.UpdateAll(Me.ClinicMgtDbDataSet)
            ViewMedicinesForm.PatIDVal(patientID)
            ViewMedicinesForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Please fill all necessary items!", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Sub PatIDValue(ByVal patID As Integer)
        patientID = patID
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ViewPatientRecord.DisplayRecord(patientID)
        ViewPatientRecord.Show()
        Me.Close()
    End Sub

    Private Sub RemarksTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemarksTextBox.TextChanged, FindingsTextBox.TextChanged
        btnNext.Enabled = True
    End Sub
End Class