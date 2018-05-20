Public Interface EmployesFormListener
    Sub OnSaveProfileChange(Profile As EmployesModel)
    Sub OnSavePasswordChange(Old As String, xNew As String)
    Sub OnSaveNewUser(NUser As EmployesModel, Pass As String)
    Sub OnFinish()

End Interface
