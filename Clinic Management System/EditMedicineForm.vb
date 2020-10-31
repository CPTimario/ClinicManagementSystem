Public Class EditMedicineForm

    Dim btnBackHover, btnBackClick As Boolean
    Dim medicineID, medTypeID As Integer
    Dim medType, itemToAdd As String

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

    Private Sub EditMedicineForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = Format(Now, "MM/dd/yyyy     hh:mm tt")
        timClock.Enabled = True
        medicineID = ViewMedicinesForm.medicineID
        MedTypeTableAdapter.Fill(Me.ClinicMgtDbDataSet.MedType)
        MedicineTableAdapter.FillByMedicineID(Me.ClinicMgtDbDataSet.Medicine, medicineID)
        MedicineIDTextBox.Text = Format(medicineID, "00000000")
        btnSave.Enabled = False
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

    Private Sub FormatComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormatComboBox.TextChanged
        itemToAdd = FormatComboBox.Text
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        itemToAdd = StrConv(FormatComboBox.Text, VbStrConv.ProperCase)
        medType = itemToAdd
        If IsNothing(MedTypeTableAdapter.ExistingItem(itemToAdd)) Then
            MedTypeTableAdapter.Insert(itemToAdd, medTypeID)
        End If
        Me.Validate()
        Me.MedicineBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClinicMgtDbDataSet)
        MessageBox.Show("Saved!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnSave.Enabled = False
    End Sub

    Private Sub ItemChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenericNameTextBox.TextChanged, FormatComboBox.TextChanged, BrandTextBox.TextChanged
        btnSave.Enabled = True
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ViewMedicinesForm.Show()
        Me.Close()
    End Sub
End Class