Public Class AddMedStockForm

    Dim btnBackHover, btnBackClick As Boolean
    Dim medicineID, medTypeID, stockNo, stocks As Integer
    Dim dateAcquired, dateExpiration As DateTime

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

    Private Sub ClearAll()
        Try
            stockNo = MedicineStocksTableAdapter.GetCurrStockNumber + 1
        Catch ex As Exception
            stockNo = 1
        End Try
        StockNumberTextBox.Text = Format(stockNo, "00000000")
        NumericUpDownStocks.Value = 1
        AcquiredDateDateTimePicker.Value = Now.Date
        ExpirationDateDateTimePicker.Value = Now.Date
    End Sub

    Private Sub AddMedStockForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
        medicineID = ViewMedicineStock.medicineID
        MedicineTableAdapter.FillByMedicineID(Me.ClinicMgtDbDataSet.Medicine, medicineID)
        ClearAll()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ViewMedicineStock.DisplayStock(medicineID)
        ViewMedicineStock.Show()
        Me.Close()
    End Sub

    Private Sub NumericUpDownStocks_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownStocks.ValueChanged
        stocks = NumericUpDownStocks.Value
    End Sub

    Private Sub AcquiredDateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcquiredDateDateTimePicker.ValueChanged
        If AcquiredDateDateTimePicker.Value.Date >= Now.Date Then
            dateAcquired = AcquiredDateDateTimePicker.Value.Date
        Else
            MessageBox.Show("Invalid Input!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ExpirationDateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpirationDateDateTimePicker.ValueChanged
        dateExpiration = ExpirationDateDateTimePicker.Value.Date
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If dateExpiration > Now.Date Then
            MedicineStocksTableAdapter.Insert(stockNo, medicineID, stocks, dateExpiration, dateAcquired)
            MessageBox.Show("Medicine Stock Added!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearAll()
        Else
            MessageBox.Show("Medicine's has already expired!", "Unable to Add", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class