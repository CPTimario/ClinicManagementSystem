Public Class ViewMedicinesForm

    Dim btnBackHover, btnBackClick, btnAddMedicineHover, btnAddMedicineClick, btnViewStockHover, btnEditMedicineHover, btnEditMedicineClick, btnViewStockClick, dgvBlank As Boolean
    Public nameSearch As String
    Public medicineID, patientID As Integer
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

    Private Sub btnAddMedicine_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddMedicine.MouseEnter, btnAddMedicine.MouseLeave
        btnAddMedicineHover = Not btnAddMedicineHover
        If btnAddMedicineHover Then
            Me.btnAddMedicine.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddMedicineHover
            Me.btnAddMedicine.ForeColor = Color.LimeGreen
        Else
            Me.btnAddMedicine.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddMedicine
            Me.btnAddMedicine.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnAddMedicine_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAddMedicine.MouseDown, btnAddMedicine.MouseUp
        btnAddMedicineClick = Not btnAddMedicineClick
        If btnAddMedicineClick Then
            Me.btnAddMedicine.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddMedicineClick
            Me.btnAddMedicine.ForeColor = Color.DarkGreen
        ElseIf btnAddMedicineHover Then
            Me.btnAddMedicine.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddMedicineHover
            Me.btnAddMedicine.ForeColor = Color.LimeGreen
        Else
            Me.btnAddMedicine.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddMedicine
            Me.btnAddMedicine.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnEditMedicine_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditMedicine.MouseEnter, btnEditMedicine.MouseLeave
        btnEditMedicineHover = Not btnEditMedicineHover
        If btnEditMedicineHover Then
            Me.btnEditMedicine.Image = Global.Clinic_Management_System.My.Resources.Resources.btnEditMedicineHover
            Me.btnEditMedicine.ForeColor = Color.LimeGreen
        Else
            Me.btnEditMedicine.Image = Global.Clinic_Management_System.My.Resources.Resources.btnEditMedicine
            Me.btnEditMedicine.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnEditMedicine_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnEditMedicine.MouseDown, btnEditMedicine.MouseUp
        btnEditMedicineClick = Not btnEditMedicineClick
        If btnEditMedicineClick Then
            Me.btnEditMedicine.Image = Global.Clinic_Management_System.My.Resources.Resources.btnEditMedicineClick
            Me.btnEditMedicine.ForeColor = Color.DarkGreen
        ElseIf btnEditMedicineHover Then
            Me.btnEditMedicine.Image = Global.Clinic_Management_System.My.Resources.Resources.btnEditMedicineHover
            Me.btnEditMedicine.ForeColor = Color.LimeGreen
        Else
            Me.btnEditMedicine.Image = Global.Clinic_Management_System.My.Resources.Resources.btnEditMedicine
            Me.btnEditMedicine.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnViewStock_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnViewStock.MouseEnter, btnViewStock.MouseLeave
        btnViewStockHover = Not btnViewStockHover
        If btnViewStockHover Then
            Me.btnViewStock.Image = Global.Clinic_Management_System.My.Resources.Resources.btnViewStockHover
            Me.btnViewStock.ForeColor = Color.LimeGreen
        Else
            Me.btnViewStock.Image = Global.Clinic_Management_System.My.Resources.Resources.btnViewStock
            Me.btnViewStock.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnViewStock_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnViewStock.MouseDown, btnViewStock.MouseUp
        btnViewStockClick = Not btnViewStockClick
        If btnViewStockClick Then
            Me.btnViewStock.Image = Global.Clinic_Management_System.My.Resources.Resources.btnViewStockClick
            Me.btnViewStock.ForeColor = Color.DarkGreen
        ElseIf btnViewStockHover Then
            Me.btnViewStock.Image = Global.Clinic_Management_System.My.Resources.Resources.btnViewStockHover
            Me.btnViewStock.ForeColor = Color.LimeGreen
        Else
            Me.btnViewStock.Image = Global.Clinic_Management_System.My.Resources.Resources.btnViewStock
            Me.btnViewStock.ForeColor = Color.Green
        End If
    End Sub

    Public Sub SearchName(ByVal nameStr As String)
        SearchNameTextBox.Text = nameStr
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
    End Sub

    Private Sub ViewMedicinesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
        Select Case LoginForm.accountType
            Case "Administrator"
                ViewMedicineTableAdapter.FillSorted(Me.ClinicMgtDbDataSet.ViewMedicine)
                btnNext.Visible = False
                btnSkip.Visible = False
            Case "Doctor"
                btnAddMedicine.Visible = False
                btnEditMedicine.Visible = False
                btnViewStock.Visible = False
                btnBack.Visible = False
        End Select
        dgvViewMedicine.ClearSelection()
        dgvViewMedicine.CurrentCell = Nothing
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        AdminMenuForm.Show()
        Me.Close()
    End Sub

    Public Sub PatIDVal(ByVal patID As Integer)
        patientID = patID
    End Sub

    Private Sub SearchNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchNameTextBox.TextChanged
        If SearchNameTextBox.Text <> "" Or LoginForm.accountType = "Administrator" Then
            ViewMedicineTableAdapter.FillByGenericName(Me.ClinicMgtDbDataSet.ViewMedicine, SearchNameTextBox.Text)
            dgvViewMedicine.ClearSelection()
            dgvViewMedicine.CurrentCell = Nothing
        End If
        If dgvViewMedicine.RowCount > 0 Then
            dgvBlank = False
        Else
            dgvBlank = True
        End If
    End Sub

    Private Sub btnAddMedicine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMedicine.Click
        AddMedicineForm.Show()
        Me.Close()
    End Sub

    Private Sub dgvViewPatientInfo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvViewMedicine.MouseClick
        Try
            If Not dgvBlank Then
                ind = dgvViewMedicine.CurrentRow.Index
                medicineID = dgvViewMedicine.Rows(ind).Cells(0).Value
                btnViewStock.Enabled = True
                btnEditMedicine.Enabled = True
                btnNext.Enabled = True
                btnSkip.Enabled = True
            Else
                btnViewStock.Enabled = False
                btnViewStock.Enabled = False
                btnNext.Enabled = False
                btnSkip.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnViewStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewStock.Click
        ViewMedicineStock.DisplayStock(medicineID)
        ViewMedicineStock.Show()
        Me.Close()
    End Sub

    Private Sub btnEditMedicine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditMedicine.Click
        EditMedicineForm.Show()
        Me.Close()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        ViewMedicineStock.PatIDVal(patientID)
        ViewMedicineStock.DisplayStock(medicineID)
        ViewMedicineStock.Show()
        Me.Close()
    End Sub

    Private Sub btnSkip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkip.Click
        DoctorMenuForm.Show()
        Me.Close()
    End Sub

End Class