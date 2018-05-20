Imports Rent_Cars
Imports MySql.Data.MySqlClient
Public Class CustomersForm
    Dim isSelectMode As Boolean = False
    Dim Listener As CustomerSelectionListener
    Dim conn As MySqlConnection
    Dim isEditMode As Boolean = False
    Dim selected As String = ""

    Dim selectedRow As Integer = -1
    Public Sub SetListener(vListener As CustomerSelectionListener)
        isSelectMode = True
        Listener = vListener
    End Sub

    Private Sub CustomersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerDataLoad()
        If isSelectMode Then
            BtnSelect.Enabled = True
        Else
            BtnSelect.Enabled = False
        End If
    End Sub

    Sub CustomerDataLoad()
        Dim db As New Database
        Dim xCustomerData As DataTable = db.LoadData("SELECT * FROM tb_customers")
        DGVCustomer.DataSource = xCustomerData
    End Sub

    Private Sub BtnSaveChange_Click(sender As Object, e As EventArgs) Handles BtnSaveChange.Click
        If TbCardNumber.Text <> "" And TbName.Text <> "" Then
            conn = (New Database).GetConnection
            If Not isEditMode Then
                Using sqlComd As New MySqlCommand
                    With sqlComd
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = "INSERT INTO tb_customers VALUES (@cardnumber, @name, @address, @gender, @contact)"
                        .Parameters.AddWithValue("@cardnumber", TbCardNumber.Text)
                        .Parameters.AddWithValue("@name", TbName.Text)
                        .Parameters.AddWithValue("@address", TbAddress.Text)
                        .Parameters.AddWithValue("@gender", CBGender.Text.ToString)
                        .Parameters.AddWithValue("@contact", TbContactInfo.Text)
                    End With
                    Try
                        conn.Open()
                        Dim res As Integer = sqlComd.ExecuteNonQuery
                        If res > 0 Then
                            MessageBox.Show("Data has been recorded :)")
                            CustomerDataLoad()
                            ClearField()
                        Else
                            MessageBox.Show("Failed to save data! :( ")
                        End If
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message)
                    Finally
                        conn.Close()
                    End Try
                End Using
            Else
                Using sqlComd As New MySqlCommand
                    With sqlComd
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = "UPDATE tb_customers SET IDCardNUmber = @cardnumber, Name = @name, Address = @address, Gender = @gender, ContactInfo = @contact WHERE IDCardNumber = @oldCardNumber"
                        .Parameters.AddWithValue("@cardnumber", TbCardNumber.Text)
                        .Parameters.AddWithValue("@name", TbName.Text)
                        .Parameters.AddWithValue("@address", TbAddress.Text)
                        .Parameters.AddWithValue("@gender", CBGender.Text.ToString)
                        .Parameters.AddWithValue("@contact", TbContactInfo.Text)
                        .Parameters.AddWithValue("@oldCardNumber", selected)
                    End With
                    Try
                        conn.Open()
                        Dim res As Integer = sqlComd.ExecuteNonQuery
                        If res > 0 Then
                            MessageBox.Show("Change has been saved :)")
                            CustomerDataLoad()
                            ClearField()
                        Else
                            MessageBox.Show("Failed to save Change! :( ")
                        End If
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message)
                    Finally
                        conn.Close()
                    End Try
                End Using
            End If
        End If
    End Sub

    Sub ClearField()
        TbCardNumber.Text = ""
        TbName.Text = ""
        TbAddress.Text = ""
        TbContactInfo.Text = ""
        CBGender.SelectedIndex = -1
        isEditMode = False
        BtnEdit.Enabled = True
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If DGVCustomer.CurrentRow.Index > -1 Then
            Listener.OnCustomerSelected(DGVCustomer.CurrentRow.Cells(0).Value.ToString, DGVCustomer.CurrentRow.Cells(1).Value.ToString)
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If selectedRow > -1 Then
            isEditMode = True
            TbCardNumber.Text = DGVCustomer.CurrentRow.Cells(0).Value
            TbName.Text = DGVCustomer.CurrentRow.Cells(1).Value
            TbAddress.Text = DGVCustomer.CurrentRow.Cells(2).Value
            TbContactInfo.Text = DGVCustomer.CurrentRow.Cells(4).Value
            If DGVCustomer.CurrentRow.Cells(3).Value = "Male" Then
                CBGender.SelectedIndex = 0
            Else
                CBGender.SelectedIndex = 1
            End If
            BtnEdit.Enabled = False
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If selectedRow > -1 Then
            If MsgBox("Are you sure you want to delete this Customer?", MsgBoxStyle.YesNo).value__ = 6 Then
                Using sqlComd As New MySqlCommand
                    With sqlComd
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = "DELETE FROM tb_customers WHERE IDCardNumber = @number"
                        .Parameters.AddWithValue("@number", DGVCustomer.Rows(selectedRow).Cells(0).Value)
                    End With
                    Try
                        conn.Open()
                        Dim res As Integer = sqlComd.ExecuteNonQuery
                        If res > 0 Then
                            MessageBox.Show("Customer has been deleted :)")
                            CustomerDataLoad()
                            ClearField()
                        Else
                            MessageBox.Show("Failed to delete customer! :( ")
                        End If
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message)
                    Finally
                        conn.Close()
                    End Try
                End Using
            End If
        End If
    End Sub

    Private Sub DGVCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCustomer.CellClick
        selected = DGVCustomer.CurrentRow.Cells(0).Value.ToString
        selectedRow = DGVCustomer.CurrentRow.Index
        ClearField()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If isEditMode Then
            ClearField()
        Else
            Me.Close()
        End If
    End Sub
End Class