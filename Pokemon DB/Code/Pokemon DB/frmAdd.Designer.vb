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
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 35)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(425, 26)
        Me.TextBox1.TabIndex = 0
        '
        'cboRarity
        '
        Me.cboRarity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRarity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRarity.DisplayMember = "(none)"
        Me.cboRarity.FormattingEnabled = True
        Me.cboRarity.Location = New System.Drawing.Point(18, 75)
        Me.cboRarity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboRarity.Name = "cboRarity"
        Me.cboRarity.Size = New System.Drawing.Size(272, 28)
        Me.cboRarity.TabIndex = 1
        '
        'cboType
        '
        Me.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(302, 75)
        Me.cboType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(272, 28)
        Me.cboType.TabIndex = 2
        '
        'cboSet
        '
        Me.cboSet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSet.FormattingEnabled = True
        Me.cboSet.Location = New System.Drawing.Point(585, 75)
        Me.cboSet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboSet.Name = "cboSet"
        Me.cboSet.Size = New System.Drawing.Size(272, 28)
        Me.cboSet.TabIndex = 3
        '
        'btnAddCard
        '
        Me.btnAddCard.Location = New System.Drawing.Point(18, 229)
        Me.btnAddCard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddCard.Name = "btnAddCard"
        Me.btnAddCard.Size = New System.Drawing.Size(298, 35)
        Me.btnAddCard.TabIndex = 4
        Me.btnAddCard.Text = "Add Card"
        Me.btnAddCard.UseVisualStyleBackColor = True
        '
        'lblSuccess
        '
        Me.lblSuccess.AutoSize = True
        Me.lblSuccess.Location = New System.Drawing.Point(465, 237)
        Me.lblSuccess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSuccess.Name = "lblSuccess"
        Me.lblSuccess.Size = New System.Drawing.Size(0, 20)
        Me.lblSuccess.TabIndex = 6
        '
        'btnAddDat
        '
        Me.btnAddDat.Location = New System.Drawing.Point(326, 229)
        Me.btnAddDat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddDat.Name = "btnAddDat"
        Me.btnAddDat.Size = New System.Drawing.Size(139, 35)
        Me.btnAddDat.TabIndex = 7
        Me.btnAddDat.Text = "Field Values"
        Me.btnAddDat.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(727, 229)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Card Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(451, 35)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(406, 26)
        Me.TextBox2.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(447, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Date"
        '
        'frmAddCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 312)
        Me.ControlBox = False
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAddCard"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Card"
        Me.TopMost = True
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
End Class
