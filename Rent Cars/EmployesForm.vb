Public Class EmployesForm
    Dim isEditMode As Boolean = False
    Dim isValid As Boolean = False

    Dim myListener As EmployesFormListener

    Sub SetListener(Listener As EmployesFormListener)
        myListener = Listener
    End Sub

    Sub SetField(vModel As EmployesModel)
        TbUsername.Text = vModel.Username
        TbAddress.Text = vModel.Address
        TbName.Text = vModel.Name
        TbPhoneNumber.Text = vModel.PhoneNumber
        isEditMode = True
    End Sub

    Private Sub EmployesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isEditMode Then
            TbUsername.ReadOnly = True
            BtnEditProfile.Enabled = True
            BtnSavePassword.Enabled = True
            TBOldPass.Enabled = True
            BtnFinish.Text = "Finish"
        Else
            TbUsername.ReadOnly = False
            BtnEditProfile.Enabled = False
            BtnSavePassword.Enabled = False
            TBOldPass.Enabled = False
            BtnFinish.Text = "Save"
        End If
    End Sub

    Private Sub BtnEditProfile_Click(sender As Object, e As EventArgs) Handles BtnEditProfile.Click
        If TbName.Text <> "" And TbAddress.Text <> "" And TbPhoneNumber.Text <> "" Then
            myListener.OnSaveProfileChange(GetFieldValue())
        End If
    End Sub

    Private Sub BtnSavePassword_Click(sender As Object, e As EventArgs) Handles BtnSavePassword.Click
        If TBNewPass.Text = TBConfNewPass.Text And TBNewPass.Text <> "" And TBConfNewPass.Text <> "" And TBOldPass.Text <> "" Then
            myListener.OnSavePasswordChange(TBOldPass.Text, TBNewPass.Text)
        Else
            MessageBox.Show("Please insert corect value!")
        End If
    End Sub

    Private Sub BtnFinish_Click(sender As Object, e As EventArgs) Handles BtnFinish.Click
        If isEditMode Then
            myListener.OnFinish()
        Else
            myListener.OnSaveNewUser(GetFieldValue(), TBNewPass.Text)
        End If
    End Sub

    Function GetFieldValue() As EmployesModel
        Dim vModel As New EmployesModel
        vModel.Username = TbUsername.Text
        vModel.Name = TbName.Text
        vModel.Address = TbAddress.Text
        vModel.PhoneNumber = TbPhoneNumber.Text
        Return vModel
    End Function
End Class