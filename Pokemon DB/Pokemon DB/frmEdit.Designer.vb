<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboGrade = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pkrQuanity = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRelease = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSet = New System.Windows.Forms.ComboBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboRarity = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpControl = New System.Windows.Forms.GroupBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        CType(Me.pkrQuanity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(24, 86)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(88, 44)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "Edit Card"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(24, 45)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(203, 26)
        Me.txtid.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(842, 522)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 42)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblEdit
        '
        Me.lblEdit.AutoSize = True
        Me.lblEdit.Location = New System.Drawing.Point(24, 13)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(107, 20)
        Me.lblEdit.TabIndex = 3
        Me.lblEdit.Text = "Enter Card ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(520, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Grade"
        '
        'cboGrade
        '
        Me.cboGrade.FormattingEnabled = True
        Me.cboGrade.Items.AddRange(New Object() {"10", "9.9", "9", "8.5", "8", "7.5", "7", "6", "5", "4", "3", "2", "1"})
        Me.cboGrade.Location = New System.Drawing.Point(300, 252)
        Me.cboGrade.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(272, 28)
        Me.cboGrade.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(228, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Quanity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(823, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Set"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(528, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Rarity"
        '
        'pkrQuanity
        '
        Me.pkrQuanity.Location = New System.Drawing.Point(16, 252)
        Me.pkrQuanity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pkrQuanity.Name = "pkrQuanity"
        Me.pkrQuanity.Size = New System.Drawing.Size(274, 26)
        Me.pkrQuanity.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(445, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Date"
        '
        'txtRelease
        '
        Me.txtRelease.Location = New System.Drawing.Point(450, 67)
        Me.txtRelease.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRelease.Name = "txtRelease"
        Me.txtRelease.Size = New System.Drawing.Size(406, 26)
        Me.txtRelease.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Card Name"
        '
        'cboSet
        '
        Me.cboSet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSet.FormattingEnabled = True
        Me.cboSet.Location = New System.Drawing.Point(583, 147)
        Me.cboSet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboSet.Name = "cboSet"
        Me.cboSet.Size = New System.Drawing.Size(272, 28)
        Me.cboSet.TabIndex = 23
        '
        'cboType
        '
        Me.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(300, 147)
        Me.cboType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(272, 28)
        Me.cboType.TabIndex = 22
        '
        'cboRarity
        '
        Me.cboRarity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRarity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRarity.DisplayMember = "(none)"
        Me.cboRarity.FormattingEnabled = True
        Me.cboRarity.Location = New System.Drawing.Point(20, 147)
        Me.cboRarity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboRarity.Name = "cboRarity"
        Me.cboRarity.Size = New System.Drawing.Size(272, 28)
        Me.cboRarity.TabIndex = 21
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(16, 67)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(426, 26)
        Me.txtName.TabIndex = 19
        '
        'grpControl
        '
        Me.grpControl.Controls.Add(Me.lblResult)
        Me.grpControl.Controls.Add(Me.btnSubmit)
        Me.grpControl.Controls.Add(Me.Label1)
        Me.grpControl.Controls.Add(Me.Label7)
        Me.grpControl.Controls.Add(Me.cboGrade)
        Me.grpControl.Controls.Add(Me.txtName)
        Me.grpControl.Controls.Add(Me.Label6)
        Me.grpControl.Controls.Add(Me.cboRarity)
        Me.grpControl.Controls.Add(Me.Label5)
        Me.grpControl.Controls.Add(Me.cboType)
        Me.grpControl.Controls.Add(Me.Label4)
        Me.grpControl.Controls.Add(Me.cboSet)
        Me.grpControl.Controls.Add(Me.Label3)
        Me.grpControl.Controls.Add(Me.txtRelease)
        Me.grpControl.Controls.Add(Me.pkrQuanity)
        Me.grpControl.Controls.Add(Me.Label2)
        Me.grpControl.Location = New System.Drawing.Point(24, 140)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Size = New System.Drawing.Size(915, 362)
        Me.grpControl.TabIndex = 33
        Me.grpControl.TabStop = False
        Me.grpControl.Text = "Edit Card Details"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(20, 315)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 30)
        Me.btnSubmit.TabIndex = 33
        Me.btnSubmit.Text = "Save Changes"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(116, 320)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 20)
        Me.lblResult.TabIndex = 34
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 608)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpControl)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEdit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Card"
        Me.TopMost = True
        CType(Me.pkrQuanity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEdit As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents lblEdit As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboGrade As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pkrQuanity As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRelease As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSet As ComboBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents cboRarity As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents grpControl As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblResult As Label
End Class
