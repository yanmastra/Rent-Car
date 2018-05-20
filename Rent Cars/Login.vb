Public Class Login

    Dim isUsernameValid As Boolean = False
    Dim isPasswordValid As Boolean = False

    Dim vLoginListener As LoginListener

    Public Sub SetLoginListener(vLoginListener As LoginListener)
        Me.vLoginListener = vLoginListener
    End Sub

    Private Sub TBUsername_Validating(sender As Object, e As EventArgs) Handles TBUsername.Validating
        If TBUsername.Text = "" Then
            LoginErrorProvider.SetError(TBUsername, "This field can't be Empty")
        End If
    End Sub
    Private Sub TBUsername_Validated(sender As Object, e As EventArgs) Handles TBUsername.Validated
        If TBUsername.Text <> "" Then
            LoginErrorProvider.SetError(TBUsername, "")
            isUsernameValid = True
        End If
    End Sub

    Private Sub TBPassword_Validating(sender As Object, e As EventArgs) Handles TBUsername.Validating
        If TBPassword.Text = "" Then
            LoginErrorProvider.SetError(TBPassword, "This field can't be Empty")
        End If
    End Sub

    Private Sub TBPassword_Validated(sender As Object, e As EventArgs) Handles TBPassword.Validated
        If TBPassword.Text <> "" Then
            LoginErrorProvider.SetError(TBPassword, "")
            isPasswordValid = True
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If isUsernameValid And isPasswordValid Then
            vLoginListener.OnLogin(TBUsername.Text, TBPassword.Text)
        End If
    End Sub

    Private Sub OnClose() Handles Me.Closing
        vLoginListener.OnClose()
    End Sub

    Private Sub OnCancel() Handles Cancel.Click
        vLoginListener.OnCancel()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsNothing(vLoginListener) Then
            MessageBox.Show("Something wrong! Login Form must be closed!")
            Me.Close()
        End If
    End Sub
End Class