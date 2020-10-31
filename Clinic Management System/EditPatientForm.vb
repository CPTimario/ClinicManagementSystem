Public Class EditPatientForm

    Dim btnBackHover, btnBackClick, picPictureFill, btnBrowsePicHover, btnBrowsePicClick, errorImage As Boolean
    Dim patientID As Integer
    Dim dateOfBirth As Date
    Dim imagePath, nameSearch As String

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

    Private Sub EditPatientForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
        nameSearch = ViewExistingPatient.fnx
        patientID = ViewExistingPatient.patientID
        Dim patientInfo As DataTable
        patientInfo = PatientInfoTableAdapter.GetDataByPatientID(patientID)
        imagePath = patientInfo.Rows(0).Item("PicturePath")
        If imagePath <> "" Then
            Try
                Me.PicturePictureBox.BackgroundImage = Image.FromFile(imagePath)
                picPictureFill = True
                errorImage = False
            Catch ex As Exception
                errorImage = True
                picPictureFill = False
            End Try
        Else
            picPictureFill = False
        End If
        PatientInfoTableAdapter.FillByPatientID(Me.ClinicMgtDbDataSet.PatientInfo, patientID)
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ViewExistingPatient.ViewSaved(nameSearch)
        ViewExistingPatient.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.PatientInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClinicMgtDbDataSet)
        MessageBox.Show("Saved!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnSave.Enabled = False
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
    End Sub

    Private Sub ofdBrowsePicture_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofdBrowsePicture.FileOk
        Me.PicturePictureBox.BackgroundImage = Image.FromFile(ofdBrowsePicture.FileName)
        PicturePathTextBox.Text = ofdBrowsePicture.FileName
        picPictureFill = True
    End Sub

    Private Sub btnBrowsePic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsePic.Click
        ofdBrowsePicture.ShowDialog()
    End Sub

    Private Sub EditPatientForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If errorImage Then
            MessageBox.Show("The file path does not exist. Kindly re-upload the image.", "Image Not Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ItemChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StreetNameTextBox.TextChanged, PicturePathTextBox.TextChanged, MNameTextBox.TextChanged, LNameTextBox.TextChanged, HouseNumberTextBox.TextChanged, GenderComboBox.TextChanged, FNameTextBox.TextChanged, Contact_NumberTextBox.TextChanged, City_MunicipalityTextBox.TextChanged, BarangayTextBox.TextChanged, BirthDateDateTimePicker.ValueChanged
        btnSave.Enabled = True
    End Sub

End Class