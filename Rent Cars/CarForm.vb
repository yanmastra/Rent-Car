Imports MySql.Data.MySqlClient
Public Class CarForm
    Dim isEditMode As Boolean = False
    Dim SelectedRow As Integer = -1

    Dim BrandId(50) As Integer
    Dim isSelectionMode As Boolean = False
    Dim Listener As CarSelectionListener
    Dim slcAllData As String = "SELECT tb_cars.PlatNumber, tb_cars.Year, tb_cars_brand.BrandName, tb_cars.Color, tb_cars_brand.Cost, tb_cars.Condition " _
            & " FROM tb_cars_brand INNER JOIN tb_cars ON tb_cars.Brand = tb_cars_brand._ID "
    Dim sqlAllData As String = slcAllData + " WHERE 1 ORDER BY tb_cars.Year DESC"
    Dim conn As MySqlConnection = (New Database).GetConnection

    Public Sub SetListener(Listener As CarSelectionListener)
        isSelectionMode = True
        Me.Listener = Listener
    End Sub

    Private Sub CarsDataLoad(sql As String)
        Dim xCarsData As DataTable = (New Database).LoadData(sql)
        DGVCar.DataSource = xCarsData
    End Sub
    Private Sub CarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xCarBrand As New DataTable
        xCarBrand = (New Database).LoadData("SELECT * FROM tb_cars_brand")
        For i As Integer = 0 To xCarBrand.Rows.Count - 1
            BrandId(i) = xCarBrand.Rows(i).Item(0)
            CBBrand.Items.Add(xCarBrand.Rows(i).Item(1).ToString)
        Next
        CarsDataLoad(sqlAllData)

        If isSelectionMode Then
            BtnSelect.Enabled = True
        Else
            BtnSelect.Enabled = False
        End If
        Dim x As Integer = 0
        For th As Integer = 2005 To 2018
            CBYear.Items.Add(th)
            x = x + 1
        Next
        Reset()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Listener.OnSelected(DGVCar.CurrentRow.Cells(0).Value, DGVCar.CurrentRow.Cells(4).Value, DGVCar.CurrentRow.Cells(2).Value + " " + DGVCar.CurrentRow.Cells(3).Value + " " + DGVCar.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TbPlatNumber.Text <> "" And CBBrand.SelectedIndex > -1 And CbColor.SelectedIndex > -1 And CBYear.SelectedIndex > -1 Then
            If isEditMode Then
                Using sqlComd As New MySqlCommand
                    With sqlComd
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = "UPDATE tb_cars SET PlatNumber = @plat, Year = @year, Brand = @brand, Color = @color WHERE PlatNumber = @oldPlat"
                        .Parameters.AddWithValue("@plat", TbPlatNumber.Text)
                        .Parameters.AddWithValue("@year", CBYear.Text)
                        .Parameters.AddWithValue("@brand", BrandId(CBBrand.SelectedIndex))
                        .Parameters.AddWithValue("@color", CbColor.Text)
                        .Parameters.AddWithValue("@oldPlat", DGVCar.Rows(SelectedRow).Cells(0).Value.ToString)
                        'error on editing data
                    End With
                    Try
                        conn.Open()
                        Dim res As Integer = sqlComd.ExecuteNonQuery()
                        If res > 0 Then
                            MessageBox.Show("Data Recorded :) ")
                            CarsDataLoad(sqlAllData)
                            Reset()
                        Else
                            MessageBox.Show("Failed to save data :(")
                        End If
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message)
                    Finally
                        conn.Close()
                    End Try
                End Using
            Else
                Dim conn As MySqlConnection = (New Database).GetConnection
                Using sqlComd As New MySqlCommand
                    With sqlComd
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = "INSERT INTO tb_cars(PlatNumber, Year, Brand, Color) VALUES (@plat, @year, @brand, @color)"
                        .Parameters.AddWithValue("@plat", TbPlatNumber.Text)
                        .Parameters.AddWithValue("@year", CBYear.Text)
                        .Parameters.AddWithValue("@brand", BrandId(CBBrand.SelectedIndex))
                        .Parameters.AddWithValue("@color", CbColor.Text)
                    End With
                    Try
                        conn.Open()
                        Dim res As Integer = sqlComd.ExecuteNonQuery()
                        If res > 0 Then
                            MessageBox.Show("Data Recorded :) ")
                            CarsDataLoad(sqlAllData)
                            Reset()
                        Else
                            MessageBox.Show("Failed to save data :(")
                        End If
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message)
                    Finally
                        conn.Close()
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Please isert valid value! :) ")
        End If
    End Sub

    Sub Reset()
        TbPlatNumber.Text = ""
        CbColor.SelectedIndex = -1
        CBYear.SelectedIndex = -1
        CBBrand.SelectedIndex = -1
        BtnSave.Text = "SAVE"
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        isEditMode = False
    End Sub

    Private Sub DGVCar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCar.CellClick
        SelectedRow = DGVCar.CurrentRow.Index
        If SelectedRow > -1 Then
            Reset()
            BtnEdit.Enabled = True
            BtnDelete.Enabled = True
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        isEditMode = True
        TbPlatNumber.Text = DGVCar.Rows(SelectedRow).Cells(0).Value.ToString
        CbColor.Text = DGVCar.Rows(SelectedRow).Cells(3).Value.ToString
        CBBrand.Text = DGVCar.Rows(SelectedRow).Cells(2).Value.ToString
        CBYear.Text = DGVCar.Rows(SelectedRow).Cells(1).Value.ToString
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If SelectedRow > -1 Then
            If MsgBox("Are yo u sure want  to delete this car? Plat Number : " + DGVCar.Rows(SelectedRow).Cells(0).Value.ToString, MsgBoxStyle.YesNo).value__ = 6 Then
                Using sqlComd As New MySqlCommand
                    With sqlComd
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = "DELETE FROM tb_cars WHERE PlatNumber = @id"
                        .Parameters.AddWithValue("@id", DGVCar.Rows(SelectedRow).Cells(0).Value.ToString)
                    End With
                    Try
                        conn.Open()
                        Dim res As Integer = sqlComd.ExecuteNonQuery()
                        If res > 0 Then
                            MessageBox.Show("Data deleted ")
                            CarsDataLoad(sqlAllData)
                        Else
                            MessageBox.Show("Can't delete data")
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

    Private Sub BtnCancle_Click(sender As Object, e As EventArgs) Handles BtnCancle.Click
        If isEditMode Then
            Reset()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub TbSearch_TextChanged(sender As Object, e As EventArgs) Handles TbSearch.TextChanged
        If TbSearch.Text.Length Mod 3 = 0 Then
            Reset()
            CarsDataLoad(slcAllData + " WHERE tb_cars.PlatNumber LIKE '%" + TbSearch.Text.ToString + "%' OR tb_cars_brand.BrandName LIKE '%" + TbSearch.Text.ToString + "%' OR tb_cars.Color LIKE '%" + TbSearch.Text.ToString + "%' ORDER BY tb_cars.Year DESC")
        End If
    End Sub
End Class
