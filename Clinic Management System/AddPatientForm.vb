Public Class AddPatientForm

    Dim btnBackHover, btnBackClick, picPictureFill, btnBrowsePicHover, btnBrowsePicClick As Boolean
    Public patientID As Integer
    Dim dateOfBirth As Date
    Dim fName, lName, gender, houseNo, street, barangay, city, contact, fnx As String

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

    Private Sub PicturePictureBox_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicturePictureBox.MouseEnter
        btnBrowsePic.BackColor = Color.Transparent
        btnBrowsePic.Parent = PicturePictureBox
        btnBrowsePic.Location = New Point(130, 130)
        btnBrowsePic.Visible = True
        timDelay.Enabled = False
    End Sub

    Private Sub btnBrowsePic_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrowsePic.MouseEnter, btnBrowsePic.MouseLeave
        btnBrowsePicHover = Not btnBrowsePicHover
        If btnBrowsePicHover Then
            Me.btnBrowsePic.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBrowsePicHover
        Else
            Me.btnBrowsePic.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBrowsePic
        End If
    End Sub

    Private Sub btnBrowsePic_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnBrowsePic.MouseDown
        btnBrowsePicClick = Not btnBrowsePicClick
        If btnBrowsePicClick Then
            Me.btnBrowsePic.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBrowsePicClick
        ElseIf btnBrowsePicHover Then
            Me.btnBrowsePic.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBrowsePicHover
        Else
            Me.btnBrowsePic.Image = Global.Clinic_Management_System.My.Resources.Resources.btnBrowsePic
        End If
    End Sub

    Private Sub timDelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timDelay.Tick
        btnBrowsePic.Visible = False
    End Sub

    Private Sub PicturePictureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicturePictureBox.MouseLeave
        timDelay.Enabled = True
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
    End Sub

    Private Sub ClearAll()
        GenderComboBox.SelectedIndex = 0
        Try
            patientID = PatientInfoTableAdapter.GetCurrPatientID + 1
        Catch ex As Exception
            patientID = 1
        End Try
        PatientIDTextBox.Text = Format(patientID, "00000000")
        FNameTextBox.Clear()
        MNameTextBox.Clear()
        LNameTextBox.Clear()
        HouseNumberTextBox.Clear()
        StreetNameTextBox.Clear()
        BarangayTextBox.Clear()
        City_MunicipalityTextBox.Clear()
        Contact_NumberTextBox.Clear()
        BirthDateDateTimePicker.Value = Now.Date
    End Sub

    Private Sub AddPatientForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
        ClearAll()
        If SWMenuForm.fnx <> "" Then
            fnx = SWMenuForm.fnx
        Else
            fnx = ViewExistingPatient.fnx
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        SWMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub GenderComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenderComboBox.SelectedIndexChanged
        If Not picPictureFill Then
            Select Case GenderComboBox.SelectedIndex
                Case 0
                    Me.PicturePictureBox.BackgroundImage = Global.Clinic_Management_System.My.Resources.Resources.picMale
                Case 1
                    Me.PicturePictureBox.BackgroundImage = Global.Clinic_Management_System.My.Resources.Resources.picFemale
            End Select
        End If
        gender = GenderComboBox.Text
    End Sub

    Private Sub ofdBrowsePicture_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofdBrowsePicture.FileOk
        Me.PicturePictureBox.BackgroundImage = Image.FromFile(ofdBrowsePicture.FileName)
        picPictureFill = True
    End Sub

    Private Sub btnBrowsePic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsePic.Click
        ofdBrowsePicture.ShowDialog()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If fName <> "" And lName <> "" And houseNo <> "" And street <> "" And barangay <> "" And city <> "" Then
            If IsNothing(PatientInfoTableAdapter.ExistingRecord(fName, lName, gender, dateOfBirth)) Then
                PatientInfoTableAdapter.Insert(patientID, ofdBrowsePicture.FileName, fName, MNameTextBox.Text, lName, houseNo, street, barangay, city, gender, contact, dateOfBirth)
                MessageBox.Show("Patient Added!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Select Case fnx
                    Case "Add Patient"
                        AddRecordForm.Show()
                        Me.Close()
                    Case "Add Patients"
                        ClearAll()
                End Select
            Else
                MessageBox.Show("Patient's record is already existing!", "Unable to Add", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please fill all necessary items!", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BirthDateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BirthDateDateTimePicker.ValueChanged
        If BirthDateDateTimePicker.Value <= Now.Date Then
            dateOfBirth = BirthDateDateTimePicker.Value.Date
        Else
            MessageBox.Show("Invalid Input!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BirthDateDateTimePicker.Value = Now.Date
            BirthDateDateTimePicker.Focus()
        End If
    End Sub

    Private Sub FNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FNameTextBox.TextChanged
        fName = FNameTextBox.Text
    End Sub

    Private Sub LNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LNameTextBox.TextChanged
        lName = LNameTextBox.Text
    End Sub

    Private Sub HouseNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HouseNumberTextBox.TextChanged
        houseNo = HouseNumberTextBox.Text
    End Sub

    Private Sub StreetNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StreetNameTextBox.TextChanged
        street = StreetNameTextBox.Text
    End Sub

    Private Sub BarangayTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangayTextBox.TextChanged
        barangay = BarangayTextBox.Text
    End Sub

    Private Sub City_MunicipalityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles City_MunicipalityTextBox.TextChanged
        city = City_MunicipalityTextBox.Text
    End Sub

    Private Sub Contact_NumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contact_NumberTextBox.TextChanged
        contact = Contact_NumberTextBox.Text
    End Sub

End Class
