<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableOfData
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
        Me.TbSelected = New System.Windows.Forms.TextBox()
        Me.OptionsBox = New System.Windows.Forms.GroupBox()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnShowDetail = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.GroupBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GDVData = New System.Windows.Forms.DataGridView()
        Me.OptionsBox.SuspendLayout()
        Me.SearchBox.SuspendLayout()
        CType(Me.GDVData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbSelected
        '
        Me.TbSelected.Location = New System.Drawing.Point(6, 42)
        Me.TbSelected.Name = "TbSelected"
        Me.TbSelected.ReadOnly = True
        Me.TbSelected.Size = New System.Drawing.Size(250, 20)
        Me.TbSelected.TabIndex = 3
        '
        'OptionsBox
        '
        Me.OptionsBox.Controls.Add(Me.BtnAddNew)
        Me.OptionsBox.Controls.Add(Me.BtnDelete)
        Me.OptionsBox.Controls.Add(Me.BtnEdit)
        Me.OptionsBox.Controls.Add(Me.TbSelected)
        Me.OptionsBox.Controls.Add(Me.BtnShowDetail)
        Me.OptionsBox.Controls.Add(Me.Label1)
        Me.OptionsBox.Location = New System.Drawing.Point(12, 12)
        Me.OptionsBox.Name = "OptionsBox"
        Me.OptionsBox.Size = New System.Drawing.Size(560, 69)
        Me.OptionsBox.TabIndex = 3
        Me.OptionsBox.TabStop = False
        Me.OptionsBox.Text = "Options"
        '
        'BtnAddNew
        '
        Me.BtnAddNew.AutoSize = True
        Me.BtnAddNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnAddNew.Location = New System.Drawing.Point(493, 39)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(61, 23)
        Me.BtnAddNew.TabIndex = 6
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.AutoSize = True
        Me.BtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDelete.Location = New System.Drawing.Point(383, 39)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(48, 23)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.AutoSize = True
        Me.BtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnEdit.Location = New System.Drawing.Point(342, 40)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(35, 23)
        Me.BtnEdit.TabIndex = 4
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnShowDetail
        '
        Me.BtnShowDetail.AutoSize = True
        Me.BtnShowDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnShowDetail.Location = New System.Drawing.Point(262, 40)
        Me.BtnShowDetail.Name = "BtnShowDetail"
        Me.BtnShowDetail.Size = New System.Drawing.Size(74, 23)
        Me.BtnShowDetail.TabIndex = 2
        Me.BtnShowDetail.Text = "Show Detail"
        Me.BtnShowDetail.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selected Item"
        '
        'SearchBox
        '
        Me.SearchBox.Controls.Add(Me.BtnSearch)
        Me.SearchBox.Controls.Add(Me.TextBox1)
        Me.SearchBox.Location = New System.Drawing.Point(12, 87)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(560, 40)
        Me.SearchBox.TabIndex = 5
        Me.SearchBox.TabStop = False
        Me.SearchBox.Text = "SearchBox"
        '
        'BtnSearch
        '
        Me.BtnSearch.AutoSize = True
        Me.BtnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSearch.Location = New System.Drawing.Point(503, 11)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(51, 23)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(491, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GDVData
        '
        Me.GDVData.AllowUserToAddRows = False
        Me.GDVData.AllowUserToDeleteRows = False
        Me.GDVData.AllowUserToOrderColumns = True
        Me.GDVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GDVData.Location = New System.Drawing.Point(12, 133)
        Me.GDVData.Name = "GDVData"
        Me.GDVData.ReadOnly = True
        Me.GDVData.Size = New System.Drawing.Size(560, 416)
        Me.GDVData.TabIndex = 4
        '
        'TableOfData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.OptionsBox)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.GDVData)
        Me.Name = "TableOfData"
        Me.Text = "TableOfData"
        Me.OptionsBox.ResumeLayout(False)
        Me.OptionsBox.PerformLayout()
        Me.SearchBox.ResumeLayout(False)
        Me.SearchBox.PerformLayout()
        CType(Me.GDVData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TbSelected As TextBox
    Friend WithEvents OptionsBox As GroupBox
    Friend WithEvents BtnAddNew As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnShowDetail As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchBox As GroupBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GDVData As DataGridView
End Class
