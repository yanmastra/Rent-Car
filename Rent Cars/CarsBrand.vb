Imports MySql.Data.MySqlClient
Public Class CarsBrand
    Dim slcAllData As String = "SELECT * FROM tb_cars_brand"
    Dim isEditMode As Boolean = False
    Dim Connect As MySqlConnection = (New Database).GetConnection
    Dim SelectedRow As Integer = -1
    Private Sub CarsBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData(slcAllData)
        ResetField()
    End Sub

    Sub LoadData(sql As String)
        DGVCarsbrand.DataSource = (New Database).LoadData(sql)
    End Sub

    Sub ResetField()
        TbBrandName.Text = ""
        TbCostPerDay.Text = ""
        BtnAdd.Text = "Add"
        isEditMode = False
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TbCostPerDay.Text <> "" And TbBrandName.Text <> "" Then
            If isEditMode Then
                Using sqlCommd As New MySqlCommand
                    With sqlCommd
                        .Connection = Connect
                        .CommandType = CommandType.Text
                        .CommandText = "UPDATE tb_cars_brand SET BrandName = @brand, Cost = @cost WHERE _ID = @id"
                        .Parameters.AddWithValue("@brand", TbBrandName.Text.ToString)
                        .Parameters.AddWithValue("@cost", TbCostPerDay.Text.ToString)
                        .Parameters.AddWithValue("@id", DGVCarsbrand.Rows(SelectedRow).Cells(0).Value)
                    End With
                    Try
                        Connect.Open()
                        Dim Res As Integer = sqlCommd.ExecuteNonQuery()
                        If Res > 0 Then
                            LoadData(slcAllData)
                            MsgBox("Change has been saved :) ")
                            ResetField()
                        Else
                            MsgBox("Failed to save change :(")
                        End If
                    Catch ex As MySqlException
                        MsgBox(ex.StackTrace)
                    Finally
                        Connect.Close()
                    End Try
                End Using
            Else
                Using sqlCommd As New MySqlCommand
                    With sqlCommd
                        .Connection = Connect
                        .CommandType = CommandType.Text
                        .CommandText = "INSERT INTO tb_cars_brand(BrandName, Cost) VALUES (@brand, @cost)"
                        .Parameters.AddWithValue("@brand", TbBrandName.Text.ToString)
                        .Parameters.AddWithValue("@cost", TbCostPerDay.Text.ToString)
                    End With
                    Try
                        Connect.Open()
                        Dim Res As Integer = sqlCommd.ExecuteNonQuery()
                        If Res > 0 Then
                            LoadData(slcAllData)
                            MsgBox("New Brand has been saved :) ")
                            ResetField()
                        Else
                            MsgBox("Failed to save Brand :(")
                        End If
                    Catch ex As MySqlException
                        MsgBox(ex.StackTrace)
                    Finally
                        Connect.Close()
                    End Try
                End Using
            End If
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If SelectedRow > -1 Then
            TbBrandName.Text = DGVCarsbrand.Rows(SelectedRow).Cells(1).Value.ToString
            TbCostPerDay.Text = DGVCarsbrand.Rows(SelectedRow).Cells(2).Value.ToString
            BtnAdd.Text = "Save Change"
            isEditMode = True
        End If
    End Sub

    Private Sub TbSearch_TextChanged(sender As Object, e As EventArgs) Handles TbSearch.TextChanged
        If TbSearch.Text.Length Mod 4 = 0 Then
            ResetField()
            LoadData("SELECT * FROM tb_cars_brand WHERE BrandName LIKE '%" + TbSearch.Text.ToString + "%' OR Cost LIKE '%" + TbSearch.Text.ToString + "%'")
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If isEditMode Then
            ResetField()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub DGVCarsbrand_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCarsbrand.CellClick
        If DGVCarsbrand.CurrentRow.Index > -1 Then
            ResetField()
            SelectedRow = DGVCarsbrand.CurrentRow.Index
            BtnEdit.Enabled = True
            BtnDelete.Enabled = True
        End If
    End Sub
End Class