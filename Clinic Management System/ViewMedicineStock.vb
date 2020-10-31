Public Class ViewMedicineStock

    Dim btnBackHover, btnBackClick, btnAddStockHover, btnAddStockClick As Boolean
    Public medicineID, patientID, medStock, stockNo As Integer
    Dim nameSearch As String

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

    Private Sub btnAddStock_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddStock.MouseEnter, btnAddStock.MouseLeave
        btnAddStockHover = Not btnAddStockHover
        If btnAddStockHover Then
            Me.btnAddStock.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddStockHover
            Me.btnAddStock.ForeColor = Color.LimeGreen
        Else
            Me.btnAddStock.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddStock
            Me.btnAddStock.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnAddStock_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAddStock.MouseDown, btnAddStock.MouseUp
        btnAddStockClick = Not btnAddStockClick
        If btnAddStockClick Then
            Me.btnAddStock.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddStockClick
            Me.btnAddStock.ForeColor = Color.DarkGreen
        ElseIf btnAddStockHover Then
            Me.btnAddStock.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddStockHover
            Me.btnAddStock.ForeColor = Color.LimeGreen
        Else
            Me.btnAddStock.Image = Global.Clinic_Management_System.My.Resources.Resources.btnAddStock
            Me.btnAddStock.ForeColor = Color.Green
        End If
    End Sub

    Private Sub timClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timClock.Tick
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
    End Sub

    Private Sub ViewMedicineStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
        nameSearch = ViewMedicinesForm.nameSearch
        MedicineTableAdapter.FillByMedicineID(Me.ClinicMgtDbDataSet.Medicine, medicineID)
        MedicineStocksTableAdapter.FillByMedicineID(Me.ClinicMgtDbDataSet.MedicineStocks, medicineID)
        dgvViewMedicineStock.ClearSelection()
        dgvViewMedicineStock.CurrentCell = Nothing
        Select Case LoginForm.accountType
            Case "Administrator"
                btnNext.Visible = False
            Case "Doctor"
                btnAddStock.Visible = False
                btnBack.Visible = False
        End Select
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ViewMedicinesForm.SearchName(nameSearch)
        ViewMedicinesForm.Show()
        Me.Close()
    End Sub

    Private Sub btnAddStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStock.Click
        AddMedStockForm.Show()
        Me.Close()
    End Sub

    Public Sub DisplayStock(ByVal medID As Integer)
        medicineID = medID
    End Sub

    Public Sub PatIDVal(ByVal patID As Integer)
        patientID = patID
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        ReleaseMedicineForm.PatIDVal(patientID)
        ReleaseMedicineForm.MedIDVal(medicineID)
        ReleaseMedicineForm.StockVal(stockNo)
        ReleaseMedicineForm.MedStockVal(medStock)
        ReleaseMedicineForm.Show()
        Me.Close()
    End Sub

    Private Sub dgvViewMedicineStock_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvViewMedicineStock.MouseClick
        Try
            Dim ind As Integer
            ind = dgvViewMedicineStock.CurrentCell.RowIndex
            medStock = dgvViewMedicineStock.Rows(ind).Cells(4).Value
            stockNo = dgvViewMedicineStock.Rows(ind).Cells(0).Value
            btnNext.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
End Class