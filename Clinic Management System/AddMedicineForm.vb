Public Class AddMedicineForm

    Dim btnBackHover, btnBackClick As Boolean
    Public medicineID, medTypeID, stockNo, stocks As Integer
    Dim genName, brandName, medType, itemToAdd As String
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
            medicineID = MedicineTableAdapter.GetCurrMedicineID + 1
        Catch ex As Exception
            medicineID = 1
        End Try
        Try
            medTypeID = MedTypeTableAdapter.GetMedTypeID + 1
        Catch ex As Exception
            medTypeID = 1
        End Try
        Try
            stockNo = MedicineStocksTableAdapter.GetCurrStockNumber + 1
        Catch ex As Exception
            stockNo = 1
        End Try
        MedicineIDTextBox.Text = Format(medicineID, "00000000")
        StockNumberTextBox.Text = Format(stockNo, "00000000")
        GenericNameTextBox.Clear()
        BrandTextBox.Clear()
        FormatComboBox.SelectedIndex = -1
        NumericUpDownStocks.Value = 1
        AcquiredDateDateTimePicker.Value = Now.Date
        ExpirationDateDateTimePicker.Value = Now.Date
    End Sub

    Private Sub AddMedicineForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
        Me.MedTypeTableAdapter.Fill(Me.ClinicMgtDbDataSet.MedType)
        ClearAll()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ViewMedicinesForm.Show()
        Me.Close()
    End Sub

    Private Sub FormatComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatComboBox.SelectedIndexChanged
        If FormatComboBox.SelectedIndex = 0 Then
            FormatComboBox.DropDownStyle = ComboBoxStyle.DropDown
            FormatComboBox.SelectedIndex = -1
        ElseIf FormatComboBox.SelectedIndex > 0 Then
            FormatComboBox.DropDownStyle = ComboBoxStyle.DropDownList
            medType = FormatComboBox.Text
        End If
    End Sub

    Private Sub GenericNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenericNameTextBox.TextChanged
        genName = GenericNameTextBox.Text
    End Sub

    Private Sub BrandTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrandTextBox.TextChanged
        brandName = BrandTextBox.Text
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        itemToAdd = StrConv(FormatComboBox.Text, VbStrConv.ProperCase)
        medType = itemToAdd
        If IsNothing(MedTypeTableAdapter.ExistingItem(itemToAdd)) Then
            MedTypeTableAdapter.Insert(itemToAdd, medTypeID)
        End If
        If genName <> "" And brandName <> "" And medType <> "" Then
            If IsNothing(MedicineTableAdapter.ExistingRecord(genName, brandName, medType)) Then
                If dateExpiration > Now.Date Then
                    MedicineTableAdapter.Insert(medicineID, genName, brandName, medType)
                    MedicineStocksTableAdapter.Insert(stockNo, medicineID, stocks, dateExpiration, dateAcquired)
                    MessageBox.Show("Medicine record added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearAll()
                Else
                    MessageBox.Show("Medicine's has already expired!", "Unable to Add", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Medicine's record is already existing!", "Unable to Add", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please fill all necessary items!", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub FormatComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormatComboBox.TextChanged
        itemToAdd = FormatComboBox.Text
    End Sub

    Private Sub NumericUpDownStocks_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownStocks.ValueChanged
        stocks = NumericUpDownStocks.Value
    End Sub

    Private Sub AcquiredDateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcquiredDateDateTimePicker.ValueChanged
        If AcquiredDateDateTimePicker.Value.Date >= Now.Date Then
            dateAcquired = AcquiredDateDateTimePicker.Value.Date
        Else
            MessageBox.Show("Invalid Input!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            AcquiredDateDateTimePicker.Value = Now.Date
        End If
    End Sub

    Private Sub ExpirationDateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpirationDateDateTimePicker.ValueChanged
        dateExpiration = ExpirationDateDateTimePicker.Value.Date
    End Sub
End Class
