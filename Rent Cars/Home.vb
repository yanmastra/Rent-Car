Imports Rent_Cars
Imports MySql.Data.MySqlClient
Public Class Home
    Implements LoginListener, EmployesFormListener, CarSelectionListener, CustomerSelectionListener

    Dim isLoged As Boolean = False
    Dim fLogin As Login
    Dim fCarForm As CarForm
    Dim fCustomersForm As CustomersForm
    Dim fEmployesForm As EmployesForm
    Dim fCarsBrand As CarsBrand
    Dim vDatabase As New Database
    Dim vEmployes As New EmployesModel

    Dim vTransaction As New TransactionModel

    Dim emSQL As String = "SELECT * FROM tb_employes WHERE Username = '"
    Dim trxSql As String = "SELECT * FROM vw_transaction "

    Dim slcTrxID As String = ""

    Sub SetComponentEnable(isEnable As Boolean)
        LoginToolStripMenuItem.Enabled = Not isEnable
        LogoutToolStripMenuItem.Enabled = isEnable
        CarsToolStripMenuItem.Enabled = isEnable
        CreateUserToolStripMenuItem.Enabled = isEnable
        CustomersToolStripMenuItem.Enabled = isEnable
        CarBrandToolStripMenuItem.Enabled = isEnable
        CarBrandToolStripMenuItem.Enabled = isEnable
        AddNewCarBrandToolStripMenuItem.Enabled = isEnable
        AddNewCarToolStripMenuItem.Enabled = isEnable
        AddNewCustomerToolStripMenuItem.Enabled = isEnable
        TransactionToolStripMenuItem.Enabled = isEnable
        TransactionReportToolStripMenuItem.Enabled = isEnable
        ProfileBox.Visible = isEnable
        TransactionBox.Visible = isEnable
        DoTransactionBox.Visible = isEnable
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isLoged Then
            SetComponentEnable(True)
        Else
            SetComponentEnable(False)
        End If
    End Sub

    Public Sub OnLogin(Username As String, Password As String) Implements LoginListener.OnLogin
        Dim xSql As String = emSQL + Username + "' AND Password = '" + Password + "'"
        Dim xTempTable As DataTable = vDatabase.LoadData(xSql)
        If xTempTable.Rows.Count > 0 Then

            ApllyEmployData(xTempTable)
            Me.Show()
            fLogin.Close()
            SetComponentEnable(True)
            TransactionLoad(trxSql)
        Else
            MessageBox.Show("Your Username or your Password is invalid :(")
        End If
    End Sub

    Public Sub OnCancel() Implements LoginListener.OnCancel
        Me.Show()
        fLogin.Close()
    End Sub

    Public Sub OnClose() Implements LoginListener.OnClose
        Me.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        fLogin = New Login
        fLogin.SetLoginListener(Me)
        fLogin.Show()
        Me.Hide()
    End Sub

    Private Sub BtnEditProfile_Click(sender As Object, e As EventArgs) Handles BtnEditProfile.Click
        fEmployesForm = New EmployesForm
        fEmployesForm.SetListener(Me)
        fEmployesForm.SetField(vEmployes)
        fEmployesForm.Show()
        BtnEditProfile.Enabled = False
    End Sub

    Sub ApllyEmployData(xTempTable As DataTable)
        vEmployes.Username = xTempTable.Rows(0).Item(0)
        vEmployes.Name = xTempTable.Rows(0).Item(2)
        vEmployes.Address = xTempTable.Rows(0).Item(3)
        vEmployes.PhoneNumber = xTempTable.Rows(0).Item(4)

        TbUsername.Text = vEmployes.Username
        TbName.Text = vEmployes.Name
        TbAddress.Text = vEmployes.Address
        TbPhoneNumber.Text = vEmployes.PhoneNumber
    End Sub

    Public Sub OnSaveProfileChange(Profile As EmployesModel) Implements EmployesFormListener.OnSaveProfileChange
        Using sqlCommand As New MySqlCommand
            With sqlCommand
                .Connection = vDatabase.GetConnection
                .CommandType = CommandType.Text
                .CommandText = "UPDATE tb_employes SET Name = @name, Address = @address, PhoneNumber = @phone WHERE Username = @user"
                .Parameters.AddWithValue("@name", Profile.Name)
                .Parameters.AddWithValue("@address", Profile.Address)
                .Parameters.AddWithValue("@phone", Profile.PhoneNumber)
                .Parameters.AddWithValue("@user", Profile.Username)
            End With
            Dim i As Integer
            Try
                vDatabase.GetConnection.Open()
                i = sqlCommand.ExecuteNonQuery()
                If i > 0 Then
                    ApllyEmployData(vDatabase.LoadData(emSQL + Profile.Username + "'"))
                    MessageBox.Show("Success")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Public Sub OnSavePasswordChange(Old As String, xNew As String) Implements EmployesFormListener.OnSavePasswordChange
        Dim xResult As DataTable = vDatabase.LoadData(emSQL + vEmployes.Username + "' AND Password = '" + Old + "'")
        If xResult.Rows.Count > 0 Then
            Using sqlComd As New MySqlCommand
                With sqlComd
                    .Connection = vDatabase.GetConnection
                    .CommandType = CommandType.Text
                    .CommandText = "UPDATE tb_employes SET Password = @pass WHERE Username = @user"
                    .Parameters.AddWithValue("@pass", xNew)
                    .Parameters.AddWithValue("@user", vEmployes.Username)
                End With
                Try
                    vDatabase.GetConnection.Open()
                    Dim res = sqlComd.ExecuteNonQuery
                    If (res > 0) Then
                        MessageBox.Show("Change password has been successfully :)")
                    Else
                        MessageBox.Show("Change Password failed! :( ")
                    End If
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Your current password is incorrect! ")
        End If
    End Sub

    Public Sub OnSaveNewUser(NUser As EmployesModel, Pass As String) Implements EmployesFormListener.OnSaveNewUser
        Throw New NotImplementedException()
    End Sub

    Public Sub OnFinish() Implements EmployesFormListener.OnFinish
        fEmployesForm.Close()
        BtnEditProfile.Enabled = False
    End Sub

    Private Sub CreateUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateUserToolStripMenuItem.Click
        fEmployesForm = New EmployesForm
        fEmployesForm.SetListener(Me)
        fEmployesForm.Show()
    End Sub

    Private Sub TbTrxCar_Click(sender As Object, e As EventArgs) Handles TbTrxCar.Click
        fCarForm = New CarForm
        fCarForm.SetListener(Me)
        fCarForm.Show()
    End Sub

    Private Sub CarsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarsToolStripMenuItem.Click
        fCarForm = New CarForm
        fCarForm.Show()
    End Sub

    Public Sub OnSelected(PlatNumber As String, Cost As Integer, Name As String) Implements CarSelectionListener.OnSelected
        vTransaction.CarNumber = PlatNumber
        TbTrxCar.Text = Name
        TbCostPerDay.Text = Cost
        TbRange.ReadOnly = False
        TbCustomer.ReadOnly = True
        TbRange.Focus()
        fCarForm.Close()
    End Sub

    Private Sub TbRange_Enter(sender As Object, e As EventArgs) Handles TbRange.TextChanged
        If TbRange.Text <> "" And TbCostPerDay.Text <> "" Then
            Try
                Dim costPerDay As Integer = TbCostPerDay.Text
                Dim cost As Integer = TbRange.Text
                TbCostTotal.Text = costPerDay * cost
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            vTransaction.Range = TbRange.Text
        End If
    End Sub

    Private Sub TbCustomer_TextClick(sender As Object, e As EventArgs) Handles TbCustomer.Click
        fCustomersForm = New CustomersForm
        fCustomersForm.SetListener(Me)
        fCustomersForm.Show()
    End Sub

    Public Sub OnCustomerSelected(ID As String, Name As String) Implements CustomerSelectionListener.OnCustomerSelected
        vTransaction.Customers = ID
        TbCustomer.Text = Name
        TbPayment.ReadOnly = False
        fCustomersForm.Close()
    End Sub

    Private Sub TbPayment_TextChanged(sender As Object, e As EventArgs) Handles TbPayment.TextChanged
        If TbPayment.Text <> "" And TbCostTotal.Text <> "" Then
            Try
                Dim Total As Integer = TbCostTotal.Text
                Dim Pay As Integer = TbPayment.Text
                Dim CashBack As Integer = Pay - Total
                TbCashBack.Text = CashBack
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            vTransaction.DateLease = DTPDateLease.Value.ToString
        End If

        If TbCashBack.Text <> "" And TbCashBack.Text >= 0 Then
            BtnPay.Enabled = True
        Else
            BtnPay.Enabled = False
        End If
    End Sub

    Sub ResetTransactionForm()
        vTransaction = New TransactionModel
        TbTrxCar.Text = ""
        TbRange.Text = ""
        TbCostPerDay.Text = ""
        TbCostTotal.Text = ""
        TbCustomer.Text = ""
        TbPayment.Text = ""
        TbCashBack.Text = ""
        TbRange.ReadOnly = True
        TbCustomer.ReadOnly = False
        TbPayment.ReadOnly = True
        TbCashBack.ReadOnly = True
        BtnPay.Enabled = False
    End Sub

    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        If Not IsNothing(vTransaction) Then
            Dim conn As MySqlConnection = (New Database).GetConnection
            Using sqlComd As New MySqlCommand
                With sqlComd
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = "INSERT INTO tb_transaction(CarNumber, DateLease, Renter, RentRange) VALUES (@car, @date, @renter, @range)"
                    .Parameters.AddWithValue("@car", vTransaction.CarNumber)
                    .Parameters.AddWithValue("@date", vTransaction.DateLease)
                    .Parameters.AddWithValue("@renter", vTransaction.Customers)
                    .Parameters.AddWithValue("@range", vTransaction.Range)
                End With
                Try
                    conn.Open()
                    Dim res As Integer = sqlComd.ExecuteNonQuery
                    If res > 0 Then
                        MessageBox.Show("Transaction has been saved :)")
                        ResetTransactionForm()
                        TransactionLoad(trxSql)
                    Else
                        MessageBox.Show("Failed to save Transaction! :(")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conn.Close()
                End Try
            End Using
        End If
    End Sub

    Sub TransactionLoad(sql As String)
        DGVTransaction.DataSource = (New Database).LoadData(sql)
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        fCustomersForm = New CustomersForm
        fCustomersForm.Show()
    End Sub

    Private Sub CarBrandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarBrandToolStripMenuItem.Click
        fCarsBrand = New CarsBrand
        fCarsBrand.Show()
    End Sub

    Private Sub DGVTransaction_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTransaction.CellClick
        If DGVTransaction.CurrentRow.Index > -1 Then
            TBSlctdCarGarage.Text = DGVTransaction.CurrentRow.Cells(0).Value.ToString + " " _
                    & DGVTransaction.CurrentRow.Cells(1).Value.ToString + " " _
                    & DGVTransaction.CurrentRow.Cells(4).Value.ToString
            slcTrxID = DGVTransaction.CurrentRow.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub BtnRefreshDate_Click(sender As Object, e As EventArgs) Handles BtnRefreshDate.Click
        Dim cDateTime As DateTime = DateTime.Now
        DTPDateLease.Value = cDateTime.ToString
    End Sub

    Private Sub BtnShowCG_Click(sender As Object, e As EventArgs) Handles BtnShowCG.Click

    End Sub

    Private Sub BtnReturned_Click(sender As Object, e As EventArgs) Handles BtnReturned.Click

    End Sub

    Private Sub TbSearch_TextChanged(sender As Object, e As EventArgs) Handles TbSearch.TextChanged

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If TbSearch.Text <> "" Then
            ResetTransactionForm()
            TransactionLoad(trxSql + " WHERE tb_cars.PlatNumber LIKE '%" + TbSearch.Text.ToString + "%' OR " _
                            & "tb_cars.Color LIKE '%" + TbSearch.Text.ToString + "%' OR " _
                            & "tb_transaction.DateLease LIKE '%" + TbSearch.Text.ToString + "%' OR " _
                            & "tb_customers.Name LIKE '%" + TbSearch.Text.ToString + "%'")
        End If
    End Sub
End Class