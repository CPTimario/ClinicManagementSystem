Public Class AddRecordForm

    Dim btnBackHover, btnBackClick As Boolean
    Dim patientID, recordID, waitListID As Integer
    Dim patHeight, weight, pulseRate As Double
    Dim fName, mName, lName, bp, symptoms As String

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

    Private Sub PatientRecordsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
        If AddPatientForm.patientID > 0 Then
            patientID = AddPatientForm.patientID
        Else
            patientID = ViewExistingPatient.patientID
        End If
        PatientIDTextBox.Text = Format(patientID, "00000000")
        Try
            recordID = PatientRecordsTableAdapter.GetCurrRecordID + 1
        Catch ex As Exception
            recordID = 1
        End Try
        Try
            waitListID = WaitListTableAdapter.GetCurrWaitListID + 1
        Catch ex As Exception
            waitListID = 1
        End Try
        Dim patientInfo As DataTable
        patientInfo = PatientInfoTableAdapter.GetDataByPatientID(patientID)
        fName = patientInfo.Rows(0).Item("FName")
        mName = patientInfo.Rows(0).Item("MName")
        lName = patientInfo.Rows(0).Item("LName")
        NameTextBox.Text = fName + " " + mName + " " + lName
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        SWMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub HeightTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeightTextBox.TextChanged
        patHeight = Val(HeightTextBox.Text)
    End Sub

    Private Sub WeightTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeightTextBox.TextChanged
        weight = Val(WeightTextBox.Text)
    End Sub

    Private Sub BPTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPTextBox.TextChanged
        bp = BPTextBox.Text
    End Sub

    Private Sub PulseRateTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PulseRateTextBox.TextChanged
        pulseRate = Val(PulseRateTextBox.Text)
    End Sub

    Private Sub SymptomsTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SymptomsTextBox.TextChanged
        symptoms = SymptomsTextBox.Text
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If HeightTextBox.Text <> "" And WeightTextBox.Text <> "" And PulseRateTextBox.Text <> "" And SymptomsTextBox.Text <> "" Then
            If patHeight > 0 And weight > 0 And pulseRate > 0 And symptoms <> "" Then
                PatientRecordsTableAdapter.Insert(patientID, Now.Date, patHeight, weight, bp, pulseRate, symptoms, "", "", recordID)
                WaitListTableAdapter.Insert(patientID, Now.Date, Now, fName + " " + lName, "Pending", waitListID)
                MessageBox.Show("Record Added!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SWMenuForm.Show()
                Me.Close()
            Else
                MessageBox.Show("Some items have incorrect data values!", "Unable To Add", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please fill all necessary items!", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class