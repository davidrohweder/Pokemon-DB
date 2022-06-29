<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cboRarity = New System.Windows.Forms.ComboBox()
        Me.cboSet = New System.Windows.Forms.ComboBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboGrade = New System.Windows.Forms.ComboBox()
        Me.lblRarity = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblSearchInventory = New System.Windows.Forms.Label()
        Me.btnClearFilters = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(788, 471)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 27)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cboRarity
        '
        Me.cboRarity.FormattingEnabled = True
        Me.cboRarity.Location = New System.Drawing.Point(13, 43)
        Me.cboRarity.Name = "cboRarity"
        Me.cboRarity.Size = New System.Drawing.Size(121, 21)
        Me.cboRarity.TabIndex = 1
        '
        'cboSet
        '
        Me.cboSet.FormattingEnabled = True
        Me.cboSet.Location = New System.Drawing.Point(267, 43)
        Me.cboSet.Name = "cboSet"
        Me.cboSet.Size = New System.Drawing.Size(121, 21)
        Me.cboSet.TabIndex = 2
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(140, 43)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 21)
        Me.cboType.TabIndex = 3
        '
        'cboGrade
        '
        Me.cboGrade.FormattingEnabled = True
        Me.cboGrade.Items.AddRange(New Object() {"Ungraded", "10", "9.5", "9", "8.5", "8", "7.5", "7", "6", "5", "4", "3", "2", "1"})
        Me.cboGrade.Location = New System.Drawing.Point(394, 43)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(121, 21)
        Me.cboGrade.TabIndex = 4
        '
        'lblRarity
        '
        Me.lblRarity.AutoSize = True
        Me.lblRarity.Location = New System.Drawing.Point(13, 24)
        Me.lblRarity.Name = "lblRarity"
        Me.lblRarity.Size = New System.Drawing.Size(34, 13)
        Me.lblRarity.TabIndex = 5
        Me.lblRarity.Text = "Rarity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Set"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Grade"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(16, 475)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(213, 23)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(155, 446)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(74, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(16, 446)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(133, 23)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 420)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 20)
        Me.TextBox1.TabIndex = 10
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(522, 41)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(134, 23)
        Me.btnFilter.TabIndex = 15
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(844, 314)
        Me.DataGridView1.TabIndex = 16
        '
        'lblSearchInventory
        '
        Me.lblSearchInventory.AutoSize = True
        Me.lblSearchInventory.Location = New System.Drawing.Point(16, 401)
        Me.lblSearchInventory.Name = "lblSearchInventory"
        Me.lblSearchInventory.Size = New System.Drawing.Size(88, 13)
        Me.lblSearchInventory.TabIndex = 17
        Me.lblSearchInventory.Text = "Search Inventory"
        '
        'btnClearFilters
        '
        Me.btnClearFilters.Location = New System.Drawing.Point(662, 43)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.Size = New System.Drawing.Size(134, 23)
        Me.btnClearFilters.TabIndex = 18
        Me.btnClearFilters.Text = "Clear Filters"
        Me.btnClearFilters.UseVisualStyleBackColor = True
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClearFilters)
        Me.Controls.Add(Me.lblSearchInventory)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblRarity)
        Me.Controls.Add(Me.cboGrade)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.cboSet)
        Me.Controls.Add(Me.cboRarity)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmSearch"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advanced Search"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents cboRarity As ComboBox
    Friend WithEvents cboSet As ComboBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents cboGrade As ComboBox
    Friend WithEvents lblRarity As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnFilter As Button
    Public WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblSearchInventory As Label
    Friend WithEvents btnClearFilters As Button
End Class
