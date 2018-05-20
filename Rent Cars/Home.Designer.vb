<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TBSlctdCarGarage = New System.Windows.Forms.TextBox()
        Me.ProfileBox = New System.Windows.Forms.GroupBox()
        Me.BtnEditProfile = New System.Windows.Forms.Button()
        Me.TbPhoneNumber = New System.Windows.Forms.TextBox()
        Me.TbAddress = New System.Windows.Forms.TextBox()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.TbUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransactionBox = New System.Windows.Forms.GroupBox()
        Me.BtnReturned = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TbSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnShowCG = New System.Windows.Forms.Button()
        Me.DGVTransaction = New System.Windows.Forms.DataGridView()
        Me.UsedCarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarBrandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewCarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewCarBrandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoTransactionBox = New System.Windows.Forms.GroupBox()
        Me.DTPDateLease = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbCustomer = New System.Windows.Forms.TextBox()
        Me.BtnPay = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TbCostPerDay = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbCashBack = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbPayment = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbCostTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbRange = New System.Windows.Forms.TextBox()
        Me.TbTrxCar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnRefreshDate = New System.Windows.Forms.Button()
        Me.ProfileBox.SuspendLayout()
        Me.TransactionBox.SuspendLayout()
        CType(Me.DGVTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.DoTransactionBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBSlctdCarGarage
        '
        Me.TBSlctdCarGarage.CausesValidation = False
        Me.TBSlctdCarGarage.Location = New System.Drawing.Point(6, 41)
        Me.TBSlctdCarGarage.Name = "TBSlctdCarGarage"
        Me.TBSlctdCarGarage.ReadOnly = True
        Me.TBSlctdCarGarage.Size = New System.Drawing.Size(165, 20)
        Me.TBSlctdCarGarage.TabIndex = 7
        '
        'ProfileBox
        '
        Me.ProfileBox.Controls.Add(Me.BtnEditProfile)
        Me.ProfileBox.Controls.Add(Me.TbPhoneNumber)
        Me.ProfileBox.Controls.Add(Me.TbAddress)
        Me.ProfileBox.Controls.Add(Me.TbName)
        Me.ProfileBox.Controls.Add(Me.TbUsername)
        Me.ProfileBox.Controls.Add(Me.Label4)
        Me.ProfileBox.Controls.Add(Me.Label3)
        Me.ProfileBox.Controls.Add(Me.Label2)
        Me.ProfileBox.Controls.Add(Me.Label1)
        Me.ProfileBox.Location = New System.Drawing.Point(12, 27)
        Me.ProfileBox.Name = "ProfileBox"
        Me.ProfileBox.Size = New System.Drawing.Size(720, 93)
        Me.ProfileBox.TabIndex = 6
        Me.ProfileBox.TabStop = False
        Me.ProfileBox.Text = "Your Profile"
        '
        'BtnEditProfile
        '
        Me.BtnEditProfile.AutoSize = True
        Me.BtnEditProfile.Location = New System.Drawing.Point(629, 65)
        Me.BtnEditProfile.Name = "BtnEditProfile"
        Me.BtnEditProfile.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditProfile.TabIndex = 3
        Me.BtnEditProfile.Text = "Edit Profile"
        Me.BtnEditProfile.UseVisualStyleBackColor = True
        '
        'TbPhoneNumber
        '
        Me.TbPhoneNumber.CausesValidation = False
        Me.TbPhoneNumber.Location = New System.Drawing.Point(465, 39)
        Me.TbPhoneNumber.Name = "TbPhoneNumber"
        Me.TbPhoneNumber.ReadOnly = True
        Me.TbPhoneNumber.Size = New System.Drawing.Size(239, 20)
        Me.TbPhoneNumber.TabIndex = 7
        '
        'TbAddress
        '
        Me.TbAddress.CausesValidation = False
        Me.TbAddress.Location = New System.Drawing.Point(79, 42)
        Me.TbAddress.Multiline = True
        Me.TbAddress.Name = "TbAddress"
        Me.TbAddress.ReadOnly = True
        Me.TbAddress.Size = New System.Drawing.Size(239, 37)
        Me.TbAddress.TabIndex = 6
        '
        'TbName
        '
        Me.TbName.CausesValidation = False
        Me.TbName.Location = New System.Drawing.Point(465, 13)
        Me.TbName.Name = "TbName"
        Me.TbName.ReadOnly = True
        Me.TbName.Size = New System.Drawing.Size(239, 20)
        Me.TbName.TabIndex = 5
        '
        'TbUsername
        '
        Me.TbUsername.CausesValidation = False
        Me.TbUsername.Location = New System.Drawing.Point(79, 16)
        Me.TbUsername.Name = "TbUsername"
        Me.TbUsername.ReadOnly = True
        Me.TbUsername.Size = New System.Drawing.Size(239, 20)
        Me.TbUsername.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(381, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'TransactionBox
        '
        Me.TransactionBox.Controls.Add(Me.BtnReturned)
        Me.TransactionBox.Controls.Add(Me.BtnSearch)
        Me.TransactionBox.Controls.Add(Me.TbSearch)
        Me.TransactionBox.Controls.Add(Me.Label6)
        Me.TransactionBox.Controls.Add(Me.BtnShowCG)
        Me.TransactionBox.Controls.Add(Me.TBSlctdCarGarage)
        Me.TransactionBox.Controls.Add(Me.DGVTransaction)
        Me.TransactionBox.Location = New System.Drawing.Point(12, 238)
        Me.TransactionBox.Name = "TransactionBox"
        Me.TransactionBox.Size = New System.Drawing.Size(720, 343)
        Me.TransactionBox.TabIndex = 8
        Me.TransactionBox.TabStop = False
        Me.TransactionBox.Text = "Transaction Data"
        '
        'BtnReturned
        '
        Me.BtnReturned.AutoSize = True
        Me.BtnReturned.Location = New System.Drawing.Point(258, 38)
        Me.BtnReturned.Name = "BtnReturned"
        Me.BtnReturned.Size = New System.Drawing.Size(75, 23)
        Me.BtnReturned.TabIndex = 12
        Me.BtnReturned.Text = "Returned ?"
        Me.BtnReturned.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.AutoSize = True
        Me.BtnSearch.Location = New System.Drawing.Point(639, 38)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 11
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TbSearch
        '
        Me.TbSearch.CausesValidation = False
        Me.TbSearch.Location = New System.Drawing.Point(469, 41)
        Me.TbSearch.Name = "TbSearch"
        Me.TbSearch.Size = New System.Drawing.Size(164, 20)
        Me.TbSearch.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Selected Car "
        '
        'BtnShowCG
        '
        Me.BtnShowCG.AutoSize = True
        Me.BtnShowCG.Location = New System.Drawing.Point(177, 38)
        Me.BtnShowCG.Name = "BtnShowCG"
        Me.BtnShowCG.Size = New System.Drawing.Size(75, 23)
        Me.BtnShowCG.TabIndex = 8
        Me.BtnShowCG.Text = "Show Detail"
        Me.BtnShowCG.UseVisualStyleBackColor = True
        '
        'DGVTransaction
        '
        Me.DGVTransaction.AllowUserToAddRows = False
        Me.DGVTransaction.AllowUserToDeleteRows = False
        Me.DGVTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTransaction.Location = New System.Drawing.Point(6, 67)
        Me.DGVTransaction.Name = "DGVTransaction"
        Me.DGVTransaction.ReadOnly = True
        Me.DGVTransaction.Size = New System.Drawing.Size(708, 270)
        Me.DGVTransaction.TabIndex = 0
        '
        'UsedCarToolStripMenuItem
        '
        Me.UsedCarToolStripMenuItem.Name = "UsedCarToolStripMenuItem"
        Me.UsedCarToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.UsedCarToolStripMenuItem.Text = "Used Cars"
        '
        'TransactionReportToolStripMenuItem
        '
        Me.TransactionReportToolStripMenuItem.Name = "TransactionReportToolStripMenuItem"
        Me.TransactionReportToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.TransactionReportToolStripMenuItem.Text = "Transaction"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.DataToolStripMenuItem, Me.DoToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(744, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.CreateUserToolStripMenuItem, Me.CheckConnectionToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'CreateUserToolStripMenuItem
        '
        Me.CreateUserToolStripMenuItem.Name = "CreateUserToolStripMenuItem"
        Me.CreateUserToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CreateUserToolStripMenuItem.Text = "Create User"
        '
        'CheckConnectionToolStripMenuItem
        '
        Me.CheckConnectionToolStripMenuItem.Name = "CheckConnectionToolStripMenuItem"
        Me.CheckConnectionToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CheckConnectionToolStripMenuItem.Text = "Check Connection"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarsToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.CarBrandToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'CarsToolStripMenuItem
        '
        Me.CarsToolStripMenuItem.Name = "CarsToolStripMenuItem"
        Me.CarsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CarsToolStripMenuItem.Text = "Cars"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'CarBrandToolStripMenuItem
        '
        Me.CarBrandToolStripMenuItem.Name = "CarBrandToolStripMenuItem"
        Me.CarBrandToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CarBrandToolStripMenuItem.Text = "Car Brand"
        '
        'DoToolStripMenuItem
        '
        Me.DoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCarToolStripMenuItem, Me.AddNewCustomerToolStripMenuItem, Me.AddNewCarBrandToolStripMenuItem, Me.TransactionToolStripMenuItem})
        Me.DoToolStripMenuItem.Name = "DoToolStripMenuItem"
        Me.DoToolStripMenuItem.Size = New System.Drawing.Size(34, 20)
        Me.DoToolStripMenuItem.Text = "Do"
        '
        'AddNewCarToolStripMenuItem
        '
        Me.AddNewCarToolStripMenuItem.Name = "AddNewCarToolStripMenuItem"
        Me.AddNewCarToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AddNewCarToolStripMenuItem.Text = "Add New Car"
        '
        'AddNewCustomerToolStripMenuItem
        '
        Me.AddNewCustomerToolStripMenuItem.Name = "AddNewCustomerToolStripMenuItem"
        Me.AddNewCustomerToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AddNewCustomerToolStripMenuItem.Text = "Add New Customer"
        '
        'AddNewCarBrandToolStripMenuItem
        '
        Me.AddNewCarBrandToolStripMenuItem.Name = "AddNewCarBrandToolStripMenuItem"
        Me.AddNewCarBrandToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AddNewCarBrandToolStripMenuItem.Text = "Add New Car Brand"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionReportToolStripMenuItem, Me.UsedCarToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'DoTransactionBox
        '
        Me.DoTransactionBox.Controls.Add(Me.BtnRefreshDate)
        Me.DoTransactionBox.Controls.Add(Me.DTPDateLease)
        Me.DoTransactionBox.Controls.Add(Me.Label15)
        Me.DoTransactionBox.Controls.Add(Me.Label14)
        Me.DoTransactionBox.Controls.Add(Me.TbCustomer)
        Me.DoTransactionBox.Controls.Add(Me.BtnPay)
        Me.DoTransactionBox.Controls.Add(Me.Label13)
        Me.DoTransactionBox.Controls.Add(Me.TbCostPerDay)
        Me.DoTransactionBox.Controls.Add(Me.Label12)
        Me.DoTransactionBox.Controls.Add(Me.TbCashBack)
        Me.DoTransactionBox.Controls.Add(Me.Label11)
        Me.DoTransactionBox.Controls.Add(Me.TbPayment)
        Me.DoTransactionBox.Controls.Add(Me.Label10)
        Me.DoTransactionBox.Controls.Add(Me.TbCostTotal)
        Me.DoTransactionBox.Controls.Add(Me.Label9)
        Me.DoTransactionBox.Controls.Add(Me.Label8)
        Me.DoTransactionBox.Controls.Add(Me.TbRange)
        Me.DoTransactionBox.Controls.Add(Me.TbTrxCar)
        Me.DoTransactionBox.Controls.Add(Me.Label7)
        Me.DoTransactionBox.Controls.Add(Me.Label5)
        Me.DoTransactionBox.Location = New System.Drawing.Point(12, 126)
        Me.DoTransactionBox.Name = "DoTransactionBox"
        Me.DoTransactionBox.Size = New System.Drawing.Size(720, 106)
        Me.DoTransactionBox.TabIndex = 9
        Me.DoTransactionBox.TabStop = False
        Me.DoTransactionBox.Text = "Transaction"
        '
        'DTPDateLease
        '
        Me.DTPDateLease.Enabled = False
        Me.DTPDateLease.Location = New System.Drawing.Point(537, 32)
        Me.DTPDateLease.MinDate = New Date(2018, 5, 20, 0, 0, 0, 0)
        Me.DTPDateLease.Name = "DTPDateLease"
        Me.DTPDateLease.Size = New System.Drawing.Size(177, 20)
        Me.DTPDateLease.TabIndex = 25
        Me.DTPDateLease.Value = New Date(2018, 5, 20, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(534, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Date Lease"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(257, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Customer"
        '
        'TbCustomer
        '
        Me.TbCustomer.CausesValidation = False
        Me.TbCustomer.Location = New System.Drawing.Point(260, 32)
        Me.TbCustomer.Name = "TbCustomer"
        Me.TbCustomer.ReadOnly = True
        Me.TbCustomer.Size = New System.Drawing.Size(131, 20)
        Me.TbCustomer.TabIndex = 20
        '
        'BtnPay
        '
        Me.BtnPay.AutoSize = True
        Me.BtnPay.Location = New System.Drawing.Point(540, 75)
        Me.BtnPay.Name = "BtnPay"
        Me.BtnPay.Size = New System.Drawing.Size(56, 23)
        Me.BtnPay.TabIndex = 8
        Me.BtnPay.Text = "Pay"
        Me.BtnPay.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Rent Cost per Day "
        '
        'TbCostPerDay
        '
        Me.TbCostPerDay.CausesValidation = False
        Me.TbCostPerDay.Location = New System.Drawing.Point(6, 78)
        Me.TbCostPerDay.Name = "TbCostPerDay"
        Me.TbCostPerDay.ReadOnly = True
        Me.TbCostPerDay.Size = New System.Drawing.Size(165, 20)
        Me.TbCostPerDay.TabIndex = 18
        Me.TbCostPerDay.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(397, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Cash Back"
        '
        'TbCashBack
        '
        Me.TbCashBack.CausesValidation = False
        Me.TbCashBack.Location = New System.Drawing.Point(400, 78)
        Me.TbCashBack.Name = "TbCashBack"
        Me.TbCashBack.ReadOnly = True
        Me.TbCashBack.Size = New System.Drawing.Size(131, 20)
        Me.TbCashBack.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(397, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Payment"
        '
        'TbPayment
        '
        Me.TbPayment.CausesValidation = False
        Me.TbPayment.Location = New System.Drawing.Point(400, 32)
        Me.TbPayment.Name = "TbPayment"
        Me.TbPayment.ReadOnly = True
        Me.TbPayment.Size = New System.Drawing.Size(131, 20)
        Me.TbPayment.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(174, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Cost Total"
        '
        'TbCostTotal
        '
        Me.TbCostTotal.CausesValidation = False
        Me.TbCostTotal.Location = New System.Drawing.Point(177, 78)
        Me.TbCostTotal.Name = "TbCostTotal"
        Me.TbCostTotal.ReadOnly = True
        Me.TbCostTotal.Size = New System.Drawing.Size(131, 20)
        Me.TbCostTotal.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(226, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Day"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(174, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Range Rent"
        '
        'TbRange
        '
        Me.TbRange.CausesValidation = False
        Me.TbRange.Location = New System.Drawing.Point(177, 32)
        Me.TbRange.Name = "TbRange"
        Me.TbRange.ReadOnly = True
        Me.TbRange.Size = New System.Drawing.Size(46, 20)
        Me.TbRange.TabIndex = 9
        '
        'TbTrxCar
        '
        Me.TbTrxCar.CausesValidation = False
        Me.TbTrxCar.Location = New System.Drawing.Point(6, 32)
        Me.TbTrxCar.Name = "TbTrxCar"
        Me.TbTrxCar.Size = New System.Drawing.Size(165, 20)
        Me.TbTrxCar.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Car"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 1
        '
        'BtnRefreshDate
        '
        Me.BtnRefreshDate.AutoSize = True
        Me.BtnRefreshDate.Location = New System.Drawing.Point(658, 57)
        Me.BtnRefreshDate.Name = "BtnRefreshDate"
        Me.BtnRefreshDate.Size = New System.Drawing.Size(56, 23)
        Me.BtnRefreshDate.TabIndex = 26
        Me.BtnRefreshDate.Text = "Refresh"
        Me.BtnRefreshDate.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 593)
        Me.Controls.Add(Me.DoTransactionBox)
        Me.Controls.Add(Me.ProfileBox)
        Me.Controls.Add(Me.TransactionBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ProfileBox.ResumeLayout(False)
        Me.ProfileBox.PerformLayout()
        Me.TransactionBox.ResumeLayout(False)
        Me.TransactionBox.PerformLayout()
        CType(Me.DGVTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.DoTransactionBox.ResumeLayout(False)
        Me.DoTransactionBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBSlctdCarGarage As TextBox
    Friend WithEvents ProfileBox As GroupBox
    Friend WithEvents BtnEditProfile As Button
    Friend WithEvents TbPhoneNumber As TextBox
    Friend WithEvents TbAddress As TextBox
    Friend WithEvents TbName As TextBox
    Friend WithEvents TbUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TransactionBox As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnShowCG As Button
    Friend WithEvents DGVTransaction As DataGridView
    Friend WithEvents UsedCarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarBrandToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewCarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewCarBrandToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TbSearch As TextBox
    Friend WithEvents DoTransactionBox As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TbRange As TextBox
    Friend WithEvents TbTrxCar As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TbCostPerDay As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TbCashBack As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TbPayment As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TbCostTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnPay As Button
    Friend WithEvents BtnReturned As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents TbCustomer As TextBox
    Friend WithEvents DTPDateLease As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnRefreshDate As Button
End Class
