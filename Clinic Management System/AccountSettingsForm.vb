Public Class AccountSettingsForm

    Dim btnBackHover, btnBackClick, newAccount As Boolean
    Dim userID As String
    Dim ind As Integer

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

    Private Sub AccountSettingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
        Me.ViewUserAccountsTableAdapter.FillByName(Me.ClinicMgtDbDataSet.ViewUserAccounts, NameTextBox.Text)
        dgvUserAccounts.ClearSelection()
        dgvUserAccounts.CurrentCell = Nothing
    End Sub

    Private Sub NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameTextBox.TextChanged
        Me.ViewUserAccountsTableAdapter.FillByName(Me.ClinicMgtDbDataSet.ViewUserAccounts, NameTextBox.Text)
        dgvUserAccounts.ClearSelection()
        dgvUserAccounts.CurrentCell = Nothing
        Clear()
    End Sub

    Private Sub Clear()
        UserIDTextBox.Clear()
        TextBoxUserID.Clear()
        TextBoxUserID.DataBindings.Clear()
        PasswordTextBox.Clear()
        UserTypeComboBox.SelectedIndex = -1
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        BirthDateDateTimePicker.Value = Now.Date
        GenderComboBox.SelectedIndex = -1
        HouseNumberTextBox.Clear()
        StreetTextBox.Clear()
        BarangayTextBox.Clear()
        City_MunicipalityTextBox.Clear()
        ContactNumberTextBox.Clear()
        dgvUserAccounts.ClearSelection()
        dgvUserAccounts.CurrentCell = Nothing
        btnSave.Enabled = False
        newAccount = False
    End Sub

    Private Sub dgvUserAccounts_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvUserAccounts.MouseClick
        If ind > -1 Then
            ind = dgvUserAccounts.CurrentCell.RowIndex
            userID = dgvUserAccounts.Rows(ind).Cells(0).Value.ToString
            UserAccountsTableAdapter.FillByUserID(Me.ClinicMgtDbDataSet.UserAccounts, userID)
            EmployeeTableAdapter.FillByUserID(Me.ClinicMgtDbDataSet.Employee, userID)
            btnSave.Enabled = True
            UserIDTextBox.Enabled = True
            PasswordTextBox.Enabled = True
            UserTypeComboBox.Enabled = True
            FirstNameTextBox.Enabled = True
            LastNameTextBox.Enabled = True
            BirthDateDateTimePicker.Enabled = True
            GenderComboBox.Enabled = True
            HouseNumberTextBox.Enabled = True
            StreetTextBox.Enabled = True
            BarangayTextBox.Enabled = True
            City_MunicipalityTextBox.Enabled = True
            ContactNumberTextBox.Enabled = True
        Else
            btnSave.Enabled = False
            btnSave.Enabled = False
            UserIDTextBox.Enabled = False
            PasswordTextBox.Enabled = False
            UserTypeComboBox.Enabled = False
            FirstNameTextBox.Enabled = False
            LastNameTextBox.Enabled = False
            BirthDateDateTimePicker.Enabled = False
            GenderComboBox.Enabled = False
            HouseNumberTextBox.Enabled = False
            StreetTextBox.Enabled = False
            BarangayTextBox.Enabled = False
            City_MunicipalityTextBox.Enabled = False
            ContactNumberTextBox.Enabled = False
            Clear()
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        AdminMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub UserIDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserIDTextBox.TextChanged
        TextBoxUserID.Text = UserIDTextBox.Text
    End Sub

    Private Sub chkVisible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVisible.CheckedChanged
        If chkVisible.Checked Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If newAccount Then
            If UserIDTextBox.Text <> "" And PasswordTextBox.Text <> "" And UserTypeComboBox.Text <> "" And FirstNameTextBox.Text <> "" And LastNameTextBox.Text <> "" And GenderComboBox.Text <> "" And HouseNumberTextBox.Text <> "" And StreetTextBox.Text <> "" And BarangayTextBox.Text <> "" And City_MunicipalityTextBox.Text <> "" And ContactNumberTextBox.Text <> "" Then
                UserAccountsTableAdapter.Insert(UserIDTextBox.Text, PasswordTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, UserTypeComboBox.Text)
                EmployeeTableAdapter.Insert(UserIDTextBox.Text, BirthDateDateTimePicker.Value.Date, GenderComboBox.Text, HouseNumberTextBox.Text, StreetTextBox.Text, BarangayTextBox.Text, City_MunicipalityTextBox.Text, ContactNumberTextBox.Text)
                MessageBox.Show("Saved!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear()
                dgvUserAccounts.Enabled = True
                ViewUserAccountsTableAdapter.Fill(Me.ClinicMgtDbDataSet.ViewUserAccounts)
                Rebind()
                NameTextBox.Enabled = True
                NameTextBox.Focus()
            Else
                MessageBox.Show("Please fill all necessary items!", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            Me.TextBoxUserID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "UserID", True))
            Me.Validate()
            Me.UserAccountsBindingSource.EndEdit()
            Me.EmployeeBindingSource.EndEdit()
            Me.UserAccountsTableAdapter.Update(Me.ClinicMgtDbDataSet)
            Me.EmployeeTableAdapter.Update(Me.ClinicMgtDbDataSet)
            Me.TableAdapterManager.UpdateAll(Me.ClinicMgtDbDataSet)
            ViewUserAccountsTableAdapter.Fill(Me.ClinicMgtDbDataSet.ViewUserAccounts)
            MessageBox.Show("Saved!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
            NameTextBox.Focus()
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        newAccount = True
        btnSave.Enabled = True
        dgvUserAccounts.ClearSelection()
        dgvUserAccounts.CurrentCell = Nothing
        dgvUserAccounts.Enabled = False
        NameTextBox.Enabled = False
        UserIDTextBox.Enabled = True
        PasswordTextBox.Enabled = True
        UserTypeComboBox.Enabled = True
        FirstNameTextBox.Enabled = True
        LastNameTextBox.Enabled = True
        BirthDateDateTimePicker.Enabled = True
        GenderComboBox.Enabled = True
        HouseNumberTextBox.Enabled = True
        StreetTextBox.Enabled = True
        BarangayTextBox.Enabled = True
        City_MunicipalityTextBox.Enabled = True
        ContactNumberTextBox.Enabled = True
        UserIDTextBox.DataBindings.Clear()
        PasswordTextBox.DataBindings.Clear()
        UserTypeComboBox.DataBindings.Clear()
        FirstNameTextBox.DataBindings.Clear()
        LastNameTextBox.DataBindings.Clear()
        BirthDateDateTimePicker.DataBindings.Clear()
        GenderComboBox.DataBindings.Clear()
        HouseNumberTextBox.DataBindings.Clear()
        StreetTextBox.DataBindings.Clear()
        BarangayTextBox.DataBindings.Clear()
        City_MunicipalityTextBox.DataBindings.Clear()
        ContactNumberTextBox.DataBindings.Clear()
        UserIDTextBox.Clear()
        PasswordTextBox.Clear()
        UserTypeComboBox.SelectedIndex = -1
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        BirthDateDateTimePicker.Value = Now.Date
        GenderComboBox.SelectedIndex = -1
        HouseNumberTextBox.Clear()
        StreetTextBox.Clear()
        BarangayTextBox.Clear()
        City_MunicipalityTextBox.Clear()
        ContactNumberTextBox.Clear()
    End Sub

    Public Sub Rebind()
        UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "UserID", True))
        PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "Password", True))
        UserTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "UserType", True))
        FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "FirstName", True))
        LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountsBindingSource, "LastName", True))
        BirthDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "BirthDate", True))
        GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Gender", True))
        HouseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "HouseNumber", True))
        StreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Street", True))
        BarangayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Barangay", True))
        City_MunicipalityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "City/Municipality", True))
        ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "ContactNumber", True))
    End Sub

End Class