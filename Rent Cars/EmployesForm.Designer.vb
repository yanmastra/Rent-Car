<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployesForm
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnFinish = New System.Windows.Forms.Button()
        Me.BtnEditProfile = New System.Windows.Forms.Button()
        Me.TbPhoneNumber = New System.Windows.Forms.TextBox()
        Me.TbAddress = New System.Windows.Forms.TextBox()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.TbUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBNewPass = New System.Windows.Forms.TextBox()
        Me.TBOldPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSavePassword = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TBConfNewPass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFinish
        '
        Me.BtnFinish.AutoSize = True
        Me.BtnFinish.Location = New System.Drawing.Point(263, 355)
        Me.BtnFinish.Name = "BtnFinish"
        Me.BtnFinish.Size = New System.Drawing.Size(55, 23)
        Me.BtnFinish.TabIndex = 32
        Me.BtnFinish.Text = "Finish"
        Me.BtnFinish.UseVisualStyleBackColor = True
        '
        'BtnEditProfile
        '
        Me.BtnEditProfile.AutoSize = True
        Me.BtnEditProfile.Location = New System.Drawing.Point(196, 157)
        Me.BtnEditProfile.Name = "BtnEditProfile"
        Me.BtnEditProfile.Size = New System.Drawing.Size(94, 23)
        Me.BtnEditProfile.TabIndex = 25
        Me.BtnEditProfile.Text = "Save Change"
        Me.BtnEditProfile.UseVisualStyleBackColor = True
        '
        'TbPhoneNumber
        '
        Me.TbPhoneNumber.Location = New System.Drawing.Point(109, 131)
        Me.TbPhoneNumber.Name = "TbPhoneNumber"
        Me.TbPhoneNumber.Size = New System.Drawing.Size(181, 20)
        Me.TbPhoneNumber.TabIndex = 30
        '
        'TbAddress
        '
        Me.TbAddress.Location = New System.Drawing.Point(109, 75)
        Me.TbAddress.Multiline = True
        Me.TbAddress.Name = "TbAddress"
        Me.TbAddress.Size = New System.Drawing.Size(181, 50)
        Me.TbAddress.TabIndex = 29
        '
        'TbName
        '
        Me.TbName.Location = New System.Drawing.Point(109, 49)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(181, 20)
        Me.TbName.TabIndex = 28
        '
        'TbUsername
        '
        Me.TbUsername.Location = New System.Drawing.Point(109, 23)
        Me.TbUsername.Name = "TbUsername"
        Me.TbUsername.ReadOnly = True
        Me.TbUsername.Size = New System.Drawing.Size(181, 20)
        Me.TbUsername.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Confirm Password"
        '
        'TBNewPass
        '
        Me.TBNewPass.Location = New System.Drawing.Point(109, 52)
        Me.TBNewPass.Name = "TBNewPass"
        Me.TBNewPass.Size = New System.Drawing.Size(181, 20)
        Me.TBNewPass.TabIndex = 25
        Me.TBNewPass.UseSystemPasswordChar = True
        '
        'TBOldPass
        '
        Me.TBOldPass.Location = New System.Drawing.Point(109, 26)
        Me.TBOldPass.Name = "TBOldPass"
        Me.TBOldPass.Size = New System.Drawing.Size(181, 20)
        Me.TBOldPass.TabIndex = 24
        Me.TBOldPass.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Username"
        '
        'BtnSavePassword
        '
        Me.BtnSavePassword.AutoSize = True
        Me.BtnSavePassword.Location = New System.Drawing.Point(196, 104)
        Me.BtnSavePassword.Name = "BtnSavePassword"
        Me.BtnSavePassword.Size = New System.Drawing.Size(94, 23)
        Me.BtnSavePassword.TabIndex = 28
        Me.BtnSavePassword.Text = "Save Change"
        Me.BtnSavePassword.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnSavePassword)
        Me.GroupBox2.Controls.Add(Me.TBConfNewPass)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TBNewPass)
        Me.GroupBox2.Controls.Add(Me.TBOldPass)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 135)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Password"
        '
        'TBConfNewPass
        '
        Me.TBConfNewPass.Location = New System.Drawing.Point(109, 78)
        Me.TBConfNewPass.Name = "TBConfNewPass"
        Me.TBConfNewPass.Size = New System.Drawing.Size(181, 20)
        Me.TBConfNewPass.TabIndex = 27
        Me.TBConfNewPass.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Old Password"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnEditProfile)
        Me.GroupBox1.Controls.Add(Me.TbPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.TbAddress)
        Me.GroupBox1.Controls.Add(Me.TbName)
        Me.GroupBox1.Controls.Add(Me.TbUsername)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 195)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profile"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'EmployesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 391)
        Me.Controls.Add(Me.BtnFinish)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EmployesForm"
        Me.Text = "EmployesForm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnFinish As Button
    Friend WithEvents BtnEditProfile As Button
    Friend WithEvents TbPhoneNumber As TextBox
    Friend WithEvents TbAddress As TextBox
    Friend WithEvents TbName As TextBox
    Friend WithEvents TbUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TBNewPass As TextBox
    Friend WithEvents TBOldPass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSavePassword As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TBConfNewPass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
