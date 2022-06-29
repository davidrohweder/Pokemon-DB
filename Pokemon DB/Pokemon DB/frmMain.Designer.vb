<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedQueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AnalyticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CardCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollectionWorthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PokemonTraderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.Location = New System.Drawing.Point(740, 439)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(79, 13)
        Me.lblConnection.TabIndex = 1
        Me.lblConnection.Text = "Not Connected"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 360)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 20)
        Me.TextBox1.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(12, 386)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(133, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshDataToolStripMenuItem, Me.AdvancedQueryToolStripMenuItem, Me.DeleteCardToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RefreshDataToolStripMenuItem
        '
        Me.RefreshDataToolStripMenuItem.Name = "RefreshDataToolStripMenuItem"
        Me.RefreshDataToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RefreshDataToolStripMenuItem.Text = "Refresh Data"
        '
        'AdvancedQueryToolStripMenuItem
        '
        Me.AdvancedQueryToolStripMenuItem.Name = "AdvancedQueryToolStripMenuItem"
        Me.AdvancedQueryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdvancedQueryToolStripMenuItem.Text = "Advanced Search"
        '
        'DeleteCardToolStripMenuItem
        '
        Me.DeleteCardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditCardToolStripMenuItem, Me.EditCardToolStripMenuItem1, Me.AddCardToolStripMenuItem, Me.AddMassToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.DeleteCardToolStripMenuItem.Name = "DeleteCardToolStripMenuItem"
        Me.DeleteCardToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteCardToolStripMenuItem.Text = "Card Actions"
        '
        'EditCardToolStripMenuItem
        '
        Me.EditCardToolStripMenuItem.Name = "EditCardToolStripMenuItem"
        Me.EditCardToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.EditCardToolStripMenuItem.Text = "Delete Card"
        '
        'EditCardToolStripMenuItem1
        '
        Me.EditCardToolStripMenuItem1.Name = "EditCardToolStripMenuItem1"
        Me.EditCardToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.EditCardToolStripMenuItem1.Text = "Edit Card"
        '
        'AddCardToolStripMenuItem
        '
        Me.AddCardToolStripMenuItem.Name = "AddCardToolStripMenuItem"
        Me.AddCardToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AddCardToolStripMenuItem.Text = "Add Card"
        '
        'AddMassToolStripMenuItem
        '
        Me.AddMassToolStripMenuItem.Name = "AddMassToolStripMenuItem"
        Me.AddMassToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AddMassToolStripMenuItem.Text = "Add Mass Collection"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LoadDataToolStripMenuItem
        '
        Me.LoadDataToolStripMenuItem.Name = "LoadDataToolStripMenuItem"
        Me.LoadDataToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.LoadDataToolStripMenuItem.Text = "Add Card"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AnalyticsToolStripMenuItem, Me.LoadDataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(892, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AnalyticsToolStripMenuItem
        '
        Me.AnalyticsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CardCountToolStripMenuItem, Me.CollectionWorthToolStripMenuItem, Me.PokemonTraderToolStripMenuItem})
        Me.AnalyticsToolStripMenuItem.Name = "AnalyticsToolStripMenuItem"
        Me.AnalyticsToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AnalyticsToolStripMenuItem.Text = "Analytics"
        '
        'CardCountToolStripMenuItem
        '
        Me.CardCountToolStripMenuItem.Name = "CardCountToolStripMenuItem"
        Me.CardCountToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CardCountToolStripMenuItem.Text = "Card Count"
        '
        'CollectionWorthToolStripMenuItem
        '
        Me.CollectionWorthToolStripMenuItem.Name = "CollectionWorthToolStripMenuItem"
        Me.CollectionWorthToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CollectionWorthToolStripMenuItem.Text = "Collection Worth"
        '
        'PokemonTraderToolStripMenuItem
        '
        Me.PokemonTraderToolStripMenuItem.Name = "PokemonTraderToolStripMenuItem"
        Me.PokemonTraderToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PokemonTraderToolStripMenuItem.Text = "Pokemon Trader"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(844, 314)
        Me.DataGridView1.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(151, 386)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(74, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(12, 415)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(213, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CSVToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'CSVToolStripMenuItem
        '
        Me.CSVToolStripMenuItem.Name = "CSVToolStripMenuItem"
        Me.CSVToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CSVToolStripMenuItem.Text = "CSV"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 461)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pokemon DB"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblConnection As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Public WithEvents DataGridView1 As DataGridView
    Friend WithEvents AdvancedQueryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClear As Button
    Friend WithEvents DeleteCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnReset As Button
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnalyticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CardCountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollectionWorthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditCardToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PokemonTraderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddMassToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CSVToolStripMenuItem As ToolStripMenuItem
End Class
