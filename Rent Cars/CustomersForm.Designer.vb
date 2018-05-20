<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersForm
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
        Me.CustomerBox = New System.Windows.Forms.GroupBox()
        Me.CBGender = New System.Windows.Forms.ComboBox()
        Me.BtnSaveChange = New System.Windows.Forms.Button()
        Me.TbContactInfo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbCardNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TbSearch = New System.Windows.Forms.TextBox()
        Me.DGVCustomer = New System.Windows.Forms.DataGridView()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.CustomerBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerBox
        '
        Me.CustomerBox.Controls.Add(Me.BtnCancel)
        Me.CustomerBox.Controls.Add(Me.CBGender)
        Me.CustomerBox.Controls.Add(Me.BtnSaveChange)
        Me.CustomerBox.Controls.Add(Me.TbContactInfo)
        Me.CustomerBox.Controls.Add(Me.Label5)
        Me.CustomerBox.Controls.Add(Me.Label4)
        Me.CustomerBox.Controls.Add(Me.TbAddress)
        Me.CustomerBox.Controls.Add(Me.Label3)
        Me.CustomerBox.Controls.Add(Me.TbCardNumber)
        Me.CustomerBox.Controls.Add(Me.Label2)
        Me.CustomerBox.Controls.Add(Me.TbName)
        Me.CustomerBox.Controls.Add(Me.Label1)
        Me.CustomerBox.Location = New System.Drawing.Point(12, 24)
        Me.CustomerBox.Name = "CustomerBox"
        Me.CustomerBox.Size = New System.Drawing.Size(301, 213)
        Me.CustomerBox.TabIndex = 1
        Me.CustomerBox.TabStop = False
        Me.CustomerBox.Text = "Profile"
        '
        'CBGender
        '
        Me.CBGender.FormattingEnabled = True
        Me.CBGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.CBGender.Location = New System.Drawing.Point(93, 105)
        Me.CBGender.Name = "CBGender"
        Me.CBGender.Size = New System.Drawing.Size(197, 21)
        Me.CBGender.TabIndex = 12
        '
        'BtnSaveChange
        '
        Me.BtnSaveChange.AutoSize = True
        Me.BtnSaveChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSaveChange.Location = New System.Drawing.Point(245, 184)
        Me.BtnSaveChange.Name = "BtnSaveChange"
        Me.BtnSaveChange.Size = New System.Drawing.Size(45, 23)
        Me.BtnSaveChange.TabIndex = 11
        Me.BtnSaveChange.Text = "SAVE"
        Me.BtnSaveChange.UseVisualStyleBackColor = True
        '
        'TbContactInfo
        '
        Me.TbContactInfo.Location = New System.Drawing.Point(93, 131)
        Me.TbContactInfo.Multiline = True
        Me.TbContactInfo.Name = "TbContactInfo"
        Me.TbContactInfo.Size = New System.Drawing.Size(197, 47)
        Me.TbContactInfo.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contact Info"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gender"
        '
        'TbAddress
        '
        Me.TbAddress.Location = New System.Drawing.Point(93, 79)
        Me.TbAddress.Name = "TbAddress"
        Me.TbAddress.Size = New System.Drawing.Size(197, 20)
        Me.TbAddress.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Address"
        '
        'TbCardNumber
        '
        Me.TbCardNumber.Location = New System.Drawing.Point(93, 53)
        Me.TbCardNumber.Name = "TbCardNumber"
        Me.TbCardNumber.Size = New System.Drawing.Size(197, 20)
        Me.TbCardNumber.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Card Number"
        '
        'TbName
        '
        Me.TbName.Location = New System.Drawing.Point(93, 27)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(197, 20)
        Me.TbName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSelect)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.BtnEdit)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.TbSearch)
        Me.GroupBox1.Controls.Add(Me.DGVCustomer)
        Me.GroupBox1.Location = New System.Drawing.Point(319, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 452)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data"
        '
        'BtnSelect
        '
        Me.BtnSelect.AutoSize = True
        Me.BtnSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSelect.Location = New System.Drawing.Point(6, 24)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(47, 23)
        Me.BtnSelect.TabIndex = 6
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.AutoSize = True
        Me.BtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDelete.Location = New System.Drawing.Point(474, 25)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(78, 23)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Del Selected"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.AutoSize = True
        Me.BtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnEdit.Location = New System.Drawing.Point(386, 25)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(82, 23)
        Me.BtnEdit.TabIndex = 4
        Me.BtnEdit.Text = "Ediit Selected"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.AutoSize = True
        Me.BtnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSearch.Location = New System.Drawing.Point(329, 25)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(51, 23)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TbSearch
        '
        Me.TbSearch.Location = New System.Drawing.Point(136, 27)
        Me.TbSearch.Name = "TbSearch"
        Me.TbSearch.Size = New System.Drawing.Size(187, 20)
        Me.TbSearch.TabIndex = 2
        '
        'DGVCustomer
        '
        Me.DGVCustomer.AllowUserToAddRows = False
        Me.DGVCustomer.AllowUserToDeleteRows = False
        Me.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCustomer.Location = New System.Drawing.Point(6, 53)
        Me.DGVCustomer.Name = "DGVCustomer"
        Me.DGVCustomer.ReadOnly = True
        Me.DGVCustomer.Size = New System.Drawing.Size(546, 393)
        Me.DGVCustomer.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.AutoSize = True
        Me.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnCancel.Location = New System.Drawing.Point(180, 184)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(59, 23)
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.Text = "CANCEL"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'CustomersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 488)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CustomerBox)
        Me.Name = "CustomersForm"
        Me.Text = "CustomersForm"
        Me.CustomerBox.ResumeLayout(False)
        Me.CustomerBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerBox As GroupBox
    Friend WithEvents CBGender As ComboBox
    Friend WithEvents BtnSaveChange As Button
    Friend WithEvents TbContactInfo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbCardNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TbSearch As TextBox
    Friend WithEvents DGVCustomer As DataGridView
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnCancel As Button
End Class
