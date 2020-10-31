Public Class ReleaseMedicineForm

    Dim btnBackHover, btnBackClick As Boolean
    Public patientID, medicineID, stockNo, qty, medstock As Integer

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

    Private Sub ReleaseMedicineForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MedicineStocksTableAdapter.FillByStockNo(Me.ClinicMgtDbDataSet.MedicineStocks, stockNo)
        Me.MedicineTableAdapter.FillByMedicineID(Me.ClinicMgtDbDataSet.Medicine, medicineID)
        StockNumberTextBox.Text = Format(Val(StockNumberTextBox.Text), "00000000")
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
        QuantityNumericUpDown.Maximum = medstock
    End Sub

    Public Sub PatIDVal(ByVal patID As Integer)
        patientID = patID
    End Sub

    Public Sub MedIDVal(ByVal medID As Integer)
        medicineID = medID
    End Sub

    Public Sub StockVal(ByVal stock As Integer)
        stockNo = stock
    End Sub

    Public Sub MedStockVal(ByVal medStocks As Integer)
        medstock = medStocks
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ViewMedicinesForm.PatIDVal(patientID)
        ViewMedicinesForm.Show()
        Me.Close()
    End Sub

    Private Sub btnGive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGive.Click
        DoctorPrescriptionTableAdapter.Insert(LoginForm.userID, Now.Date, patientID, medicineID, qty)
        StocksTextBox.Text = (medstock - qty).ToString
        Me.Validate()
        Me.MedicineStocksBindingSource.EndEdit()
        Me.MedicineStocksTableAdapter.Update(Me.ClinicMgtDbDataSet)
        Me.TableAdapterManager.UpdateAll(Me.ClinicMgtDbDataSet)
        MessageBox.Show("Inventory Updated!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Select Case MessageBox.Show("Do you want to release more medicine?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case DialogResult.Yes
                btnBack.PerformClick()
            Case DialogResult.No
                DoctorMenuForm.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub QuantityNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantityNumericUpDown.ValueChanged
        qty = QuantityNumericUpDown.Value
    End Sub
End Class