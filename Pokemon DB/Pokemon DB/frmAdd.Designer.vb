<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddCard
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cboRarity = New System.Windows.Forms.ComboBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboSet = New System.Windows.Forms.ComboBox()
        Me.btnAddCard = New System.Windows.Forms.Button()
        Me.lblSuccess = New System.Windows.Forms.Label()
        Me.btnAddDat = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pkrQuanity = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboGrade = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.pkrQuanity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(285, 20)
        Me.TextBox1.TabIndex = 0
        '
        'cboRarity
        '
        Me.cboRarity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRarity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRarity.DisplayMember = "(none)"
        Me.cboRarity.FormattingEnabled = True
        Me.cboRarity.Location = New System.Drawing.Point(15, 75)
        Me.cboRarity.Name = "cboRarity"
        Me.cboRarity.Size = New System.Drawing.Size(183, 21)
        Me.cboRarity.TabIndex = 2
        '
        'cboType
        '
        Me.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(201, 75)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(183, 21)
        Me.cboType.TabIndex = 3
        '
        'cboSet
        '
        Me.cboSet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSet.FormattingEnabled = True
        Me.cboSet.Location = New System.Drawing.Point(390, 75)
        Me.cboSet.Name = "cboSet"
        Me.cboSet.Size = New System.Drawing.Size(183, 21)
        Me.cboSet.TabIndex = 4
        '
        'btnAddCard
        '
        Me.btnAddCard.Location = New System.Drawing.Point(12, 226)
        Me.btnAddCard.Name = "btnAddCard"
        Me.btnAddCard.Size = New System.Drawing.Size(199, 23)
        Me.btnAddCard.TabIndex = 7
        Me.btnAddCard.Text = "Add Card"
        Me.btnAddCard.UseVisualStyleBackColor = True
        '
        'lblSuccess
        '
        Me.lblSuccess.AutoSize = True
        Me.lblSuccess.Location = New System.Drawing.Point(328, 231)
        Me.lblSuccess.Name = "lblSuccess"
        Me.lblSuccess.Size = New System.Drawing.Size(0, 13)
        Me.lblSuccess.TabIndex = 6
        '
        'btnAddDat
        '
        Me.btnAddDat.Location = New System.Drawing.Point(217, 226)
        Me.btnAddDat.Name = "btnAddDat"
        Me.btnAddDat.Size = New System.Drawing.Size(93, 23)
        Me.btnAddDat.TabIndex = 9
        Me.btnAddDat.Text = "Field Values"
        Me.btnAddDat.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(486, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Card Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(301, 23)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(272, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Date"
        '
        'pkrQuanity
        '
        Me.pkrQuanity.Location = New System.Drawing.Point(12, 143)
        Me.pkrQuanity.Name = "pkrQuanity"
        Me.pkrQuanity.Size = New System.Drawing.Size(183, 20)
        Me.pkrQuanity.TabIndex = 5
        Me.pkrQuanity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Rarity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(353, 59)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(550, 59)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Set"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(153, 127)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Quanity"
        '
        'cboGrade
        '
        Me.cboGrade.FormattingEnabled = True
        Me.cboGrade.Items.AddRange(New Object() {"Ungraded", "10", "9.5", "9", "8.5", "8", "7.5", "7", "6", "5", "4", "3", "2", "1"})
        Me.cboGrade.Location = New System.Drawing.Point(201, 143)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(183, 21)
        Me.cboGrade.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(348, 127)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Grade"
        '
        'frmAddCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboGrade)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pkrQuanity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAddDat)
        Me.Controls.Add(Me.lblSuccess)
        Me.Controls.Add(Me.btnAddCard)
        Me.Controls.Add(Me.cboSet)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.cboRarity)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddCard"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Card"
        Me.TopMost = True
        CType(Me.pkrQuanity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cboRarity As ComboBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents cboSet As ComboBox
    Friend WithEvents btnAddCard As Button
    Friend WithEvents lblSuccess As Label
    Friend WithEvents btnAddDat As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pkrQuanity As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboGrade As ComboBox
    Friend WithEvents Label7 As Label
End Class
