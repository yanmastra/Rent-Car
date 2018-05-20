<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ProfileBox = New System.Windows.Forms.GroupBox()
        Me.CbColor = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.CBBrand = New System.Windows.Forms.ComboBox()
        Me.CBYear = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbPlatNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TbSearch = New System.Windows.Forms.TextBox()
        Me.DGVCar = New System.Windows.Forms.DataGridView()
        Me.BtnCancle = New System.Windows.Forms.Button()
        Me.ProfileBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfileBox
        '
        Me.ProfileBox.Controls.Add(Me.BtnCancle)
        Me.ProfileBox.Controls.Add(Me.CbColor)
        Me.ProfileBox.Controls.Add(Me.BtnSave)
        Me.ProfileBox.Controls.Add(Me.CBBrand)
        Me.ProfileBox.Controls.Add(Me.CBYear)
        Me.ProfileBox.Controls.Add(Me.Label4)
        Me.ProfileBox.Controls.Add(Me.Label3)
        Me.ProfileBox.Controls.Add(Me.Label2)
        Me.ProfileBox.Controls.Add(Me.TbPlatNumber)
        Me.ProfileBox.Controls.Add(Me.Label1)
        Me.ProfileBox.Location = New System.Drawing.Point(12, 20)
        Me.ProfileBox.Name = "ProfileBox"
        Me.ProfileBox.Size = New System.Drawing.Size(296, 213)
        Me.ProfileBox.TabIndex = 14
        Me.ProfileBox.TabStop = False
        Me.ProfileBox.Text = "Car Profile"
        '
        'CbColor
        '
        Me.CbColor.FormattingEnabled = True
        Me.CbColor.Items.AddRange(New Object() {"Red", "Black", "White", "Silver"})
        Me.CbColor.Location = New System.Drawing.Point(77, 59)
        Me.CbColor.Name = "CbColor"
        Me.CbColor.Size = New System.Drawing.Size(207, 21)
        Me.CbColor.TabIndex = 13
        '
        'BtnSave
        '
        Me.BtnSave.AutoSize = True
        Me.BtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSave.Location = New System.Drawing.Point(202, 169)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(82, 23)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save Change"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'CBBrand
        '
        Me.CBBrand.FormattingEnabled = True
        Me.CBBrand.Location = New System.Drawing.Point(77, 132)
        Me.CBBrand.Name = "CBBrand"
        Me.CBBrand.Size = New System.Drawing.Size(207, 21)
        Me.CBBrand.TabIndex = 11
        '
        'CBYear
        '
        Me.CBYear.FormattingEnabled = True
        Me.CBYear.Location = New System.Drawing.Point(77, 96)
        Me.CBYear.Name = "CBYear"
        Me.CBYear.Size = New System.Drawing.Size(207, 21)
        Me.CBYear.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Brand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Color"
        '
        'TbPlatNumber
        '
        Me.TbPlatNumber.Location = New System.Drawing.Point(77, 27)
        Me.TbPlatNumber.Name = "TbPlatNumber"
        Me.TbPlatNumber.Size = New System.Drawing.Size(207, 20)
        Me.TbPlatNumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plat Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.BtnSelect)
        Me.GroupBox1.Controls.Add(Me.BtnEdit)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.TbSearch)
        Me.GroupBox1.Controls.Add(Me.DGVCar)
        Me.GroupBox1.Location = New System.Drawing.Point(314, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 487)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data"
        '
        'BtnDelete
        '
        Me.BtnDelete.AutoSize = True
        Me.BtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDelete.Location = New System.Drawing.Point(474, 25)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(78, 23)
        Me.BtnDelete.TabIndex = 6
        Me.BtnDelete.Text = "Del Selected"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSelect
        '
        Me.BtnSelect.AutoSize = True
        Me.BtnSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSelect.Location = New System.Drawing.Point(6, 25)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(50, 23)
        Me.BtnSelect.TabIndex = 5
        Me.BtnSelect.Text = "Select "
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.AutoSize = True
        Me.BtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnEdit.Location = New System.Drawing.Point(388, 25)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(80, 23)
        Me.BtnEdit.TabIndex = 4
        Me.BtnEdit.Text = "Edit Selected"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.AutoSize = True
        Me.BtnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSearch.Location = New System.Drawing.Point(331, 25)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(51, 23)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TbSearch
        '
        Me.TbSearch.Location = New System.Drawing.Point(138, 27)
        Me.TbSearch.Name = "TbSearch"
        Me.TbSearch.Size = New System.Drawing.Size(187, 20)
        Me.TbSearch.TabIndex = 2
        '
        'DGVCar
        '
        Me.DGVCar.AllowUserToAddRows = False
        Me.DGVCar.AllowUserToDeleteRows = False
        Me.DGVCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCar.Location = New System.Drawing.Point(6, 53)
        Me.DGVCar.Name = "DGVCar"
        Me.DGVCar.ReadOnly = True
        Me.DGVCar.Size = New System.Drawing.Size(546, 428)
        Me.DGVCar.TabIndex = 0
        '
        'BtnCancle
        '
        Me.BtnCancle.AutoSize = True
        Me.BtnCancle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnCancle.Location = New System.Drawing.Point(146, 169)
        Me.BtnCancle.Name = "BtnCancle"
        Me.BtnCancle.Size = New System.Drawing.Size(50, 23)
        Me.BtnCancle.TabIndex = 14
        Me.BtnCancle.Text = "Cancel"
        Me.BtnCancle.UseVisualStyleBackColor = True
        '
        'CarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 519)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProfileBox)
        Me.Name = "CarForm"
        Me.Text = "Car Form"
        Me.ProfileBox.ResumeLayout(False)
        Me.ProfileBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProfileBox As GroupBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents CBBrand As ComboBox
    Friend WithEvents CBYear As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbPlatNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TbSearch As TextBox
    Friend WithEvents DGVCar As DataGridView
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents CbColor As ComboBox
    Friend WithEvents BtnCancle As Button
End Class
