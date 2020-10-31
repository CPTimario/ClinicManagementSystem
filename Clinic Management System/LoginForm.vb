Public Class LoginForm

    Public userID, password, accountType, fname, lname As String
    Dim btnExitClick, btnExitHover, btnViewPassClick, btnViewPassHover, viewPassword As Boolean

    Private Sub btnExit_MouseHover() Handles btnExit.MouseEnter, btnExit.MouseLeave
        btnExitHover = Not btnExitHover
        If btnExitHover Then
            Me.btnExit.Image = Global.Clinic_Management_System.My.Resources.Resources.btnExitHover
        Else
            Me.btnExit.Image = Global.Clinic_Management_System.My.Resources.Resources.btnExit
        End If
    End Sub

    Private Sub btnExit_MouseDown() Handles btnExit.MouseDown, btnExit.MouseUp
        btnExitClick = Not btnExitClick
        If btnExitClick Then
            Me.btnExit.Image = Global.Clinic_Management_System.My.Resources.Resources.btnExitClick
        ElseIf btnExitHover Then
            Me.btnExit.Image = Global.Clinic_Management_System.My.Resources.Resources.btnExitHover
        Else
            Me.btnExit.Image = Global.Clinic_Management_System.My.Resources.Resources.btnExit
        End If
    End Sub

    Private Sub btnViewPassword_MouseHover() Handles btnViewPassword.MouseEnter, btnViewPassword.MouseLeave
        btnViewPassHover = Not btnViewPassHover
        If viewPassword Then
            If btnViewPassHover Then
                Me.btnViewPassword.Image = Global.Clinic_Management_System.My.Resources.Resources.btnNotViewPassHover
            Else
                Me.btnViewPassword.Image = Global.Clinic_Management_System.My.Resources.Resources.btnNotViewPass
            End If
        Else
            If btnViewPassHover Then
                Me.btnViewPassword.Image = Global.Clinic_Management_System.My.Resources.Resources.btnViewPassHover
            Else
                Me.btnViewPassword.Image = Global.Clinic_Management_System.My.Resources.Resources.btnViewPass
            End If
        End If
    End Sub

    Private Sub btnViewPassword_MouseDown() Handles btnViewPassword.MouseDown, btnViewPassword.MouseUp
        btnViewPassClick = Not btnViewPassClick
        If viewPassword Then
            If btnViewPassClick Then
                Me.btnViewPassword.Image = Global.Clinic_Management_System.My.Resources.Resources.btnNotViewPassClick
            Else
                Me.btnViewPassword.Image = Global.Clinic_Management_System.My.Resources.Resources.btnNotViewPassHover
            End If
        Else
            If btnViewPassClick Then
                Me.btnViewPassword.Image = Global.Clinic_Management_System.My.Resources.Resources.btnViewPassClick
            Else
                Me.btnViewPassword.Image = Global.Clinic_Management_System.My.Resources.Resources.btnViewPassHover
            End If
        End If
    End Sub

    Private Sub btnViewPassword_Click() Handles btnViewPassword.Click
        viewPassword = Not viewPassword
        txtPassword.UseSystemPasswordChar = Not txtPassword.UseSystemPasswordChar
        txtPassword.Focus()
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ResetLogin()
    End Sub

    Public Sub ResetLogin()
        If viewPassword Then
            btnViewPassword.PerformClick()
            Me.btnViewPassword.Image = Global.Clinic_Management_System.My.Resources.Resources.btnViewPass
        End If
        viewPassword = False
        userID = ""
        password = ""
        accountType = ""
        txtPassword.Text = ""
        btnLogin.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Select Case MessageBox.Show("Do you want to exit the program?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Me.Close()
            Case DialogResult.No
                txtUserID.Focus()
        End Select
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUserID.Text <> "" And txtPassword.Text <> "" Then
            Dim loginData As DataTable = UserAccountsTableAdapter.GetDataByUserIDPassword(txtUserID.Text, txtPassword.Text)
            Try
                userID = loginData.Rows.Item(0).Item("UserID")
                password = loginData.Rows.Item(0).Item("Password")
                accountType = loginData.Rows.Item(0).Item("UserType")
                fname = loginData.Rows.Item(0).Item("FirstName")
                lname = loginData.Rows.Item(0).Item("LastName")
                If txtPassword.Text = password Then
                    Select Case accountType
                        Case "Administrator"
                            txtPassword.Text = ""
                            AdminMenuForm.Show()
                            Me.Hide()
                        Case "Social Worker"
                            txtPassword.Text = ""
                            SWMenuForm.Show()
                            Me.Hide()
                        Case "Doctor"
                            txtPassword.Text = ""
                            DoctorMenuForm.Show()
                            Me.Hide()
                    End Select
                Else
                    MessageBox.Show("Incorrect User ID and/or Password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Incorrect User ID and/or Password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Kindly fill all necessary fields!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class
