<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddFields
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
        Me.btnAddRarity = New System.Windows.Forms.Button()
        Me.btnAddType = New System.Windows.Forms.Button()
        Me.txtAddRarity = New System.Windows.Forms.TextBox()
        Me.txtAddtype = New System.Windows.Forms.TextBox()
        Me.txtAddSet = New System.Windows.Forms.TextBox()
        Me.txtDeleteSet = New System.Windows.Forms.TextBox()
        Me.txtDeleteType = New System.Windows.Forms.TextBox()
        Me.txtDeleteRarity = New System.Windows.Forms.TextBox()
        Me.btnDeleteType = New System.Windows.Forms.Button()
        Me.btnDeleteRarity = New System.Windows.Forms.Button()
        Me.btnDeleteSet = New System.Windows.Forms.Button()
        Me.btnAddSet = New System.Windows.Forms.Button()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddRarity
        '
        Me.btnAddRarity.Location = New System.Drawing.Point(23, 103)
        Me.btnAddRarity.Name = "btnAddRarity"
        Me.btnAddRarity.Size = New System.Drawing.Size(129, 40)
        Me.btnAddRarity.TabIndex = 0
        Me.btnAddRarity.Text = "Add Rarity"
        Me.btnAddRarity.UseVisualStyleBackColor = True
        '
        'btnAddType
        '
        Me.btnAddType.Location = New System.Drawing.Point(247, 103)
        Me.btnAddType.Name = "btnAddType"
        Me.btnAddType.Size = New System.Drawing.Size(113, 40)
        Me.btnAddType.TabIndex = 1
        Me.btnAddType.Text = "Add Type"
        Me.btnAddType.UseVisualStyleBackColor = True
        '
        'txtAddRarity
        '
        Me.txtAddRarity.Location = New System.Drawing.Point(23, 59)
        Me.txtAddRarity.Name = "txtAddRarity"
        Me.txtAddRarity.Size = New System.Drawing.Size(201, 26)
        Me.txtAddRarity.TabIndex = 6
        '
        'txtAddtype
        '
        Me.txtAddtype.Location = New System.Drawing.Point(247, 59)
        Me.txtAddtype.Name = "txtAddtype"
        Me.txtAddtype.Size = New System.Drawing.Size(201, 26)
        Me.txtAddtype.TabIndex = 7
        '
        'txtAddSet
        '
        Me.txtAddSet.Location = New System.Drawing.Point(471, 59)
        Me.txtAddSet.Name = "txtAddSet"
        Me.txtAddSet.Size = New System.Drawing.Size(201, 26)
        Me.txtAddSet.TabIndex = 8
        '
        'txtDeleteSet
        '
        Me.txtDeleteSet.Location = New System.Drawing.Point(471, 199)
        Me.txtDeleteSet.Name = "txtDeleteSet"
        Me.txtDeleteSet.Size = New System.Drawing.Size(201, 26)
        Me.txtDeleteSet.TabIndex = 13
        '
        'txtDeleteType
        '
        Me.txtDeleteType.Location = New System.Drawing.Point(247, 199)
        Me.txtDeleteType.Name = "txtDeleteType"
        Me.txtDeleteType.Size = New System.Drawing.Size(201, 26)
        Me.txtDeleteType.TabIndex = 12
        '
        'txtDeleteRarity
        '
        Me.txtDeleteRarity.Location = New System.Drawing.Point(23, 199)
        Me.txtDeleteRarity.Name = "txtDeleteRarity"
        Me.txtDeleteRarity.Size = New System.Drawing.Size(201, 26)
        Me.txtDeleteRarity.TabIndex = 11
        '
        'btnDeleteType
        '
        Me.btnDeleteType.Location = New System.Drawing.Point(247, 243)
        Me.btnDeleteType.Name = "btnDeleteType"
        Me.btnDeleteType.Size = New System.Drawing.Size(113, 53)
        Me.btnDeleteType.TabIndex = 10
        Me.btnDeleteType.Text = "Delete Type"
        Me.btnDeleteType.UseVisualStyleBackColor = True
        '
        'btnDeleteRarity
        '
        Me.btnDeleteRarity.Location = New System.Drawing.Point(23, 243)
        Me.btnDeleteRarity.Name = "btnDeleteRarity"
        Me.btnDeleteRarity.Size = New System.Drawing.Size(129, 53)
        Me.btnDeleteRarity.TabIndex = 9
        Me.btnDeleteRarity.Text = "Delete Rarity"
        Me.btnDeleteRarity.UseVisualStyleBackColor = True
        '
        'btnDeleteSet
        '
        Me.btnDeleteSet.Location = New System.Drawing.Point(471, 243)
        Me.btnDeleteSet.Name = "btnDeleteSet"
        Me.btnDeleteSet.Size = New System.Drawing.Size(117, 53)
        Me.btnDeleteSet.TabIndex = 14
        Me.btnDeleteSet.Text = "Delete Set"
        Me.btnDeleteSet.UseVisualStyleBackColor = True
        '
        'btnAddSet
        '
        Me.btnAddSet.Location = New System.Drawing.Point(471, 103)
        Me.btnAddSet.Name = "btnAddSet"
        Me.btnAddSet.Size = New System.Drawing.Size(117, 40)
        Me.btnAddSet.TabIndex = 15
        Me.btnAddSet.Text = "Add Set"
        Me.btnAddSet.UseVisualStyleBackColor = True
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Location = New System.Drawing.Point(23, 33)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(129, 20)
        Me.lblAdd.TabIndex = 16
        Me.lblAdd.Text = "Add Field Values"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Delete Field Values"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(688, 314)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 53)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(23, 330)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 20)
        Me.lblResult.TabIndex = 19
        '
        'frmAddFields
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 417)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.btnAddSet)
        Me.Controls.Add(Me.btnDeleteSet)
        Me.Controls.Add(Me.txtDeleteSet)
        Me.Controls.Add(Me.txtDeleteType)
        Me.Controls.Add(Me.txtDeleteRarity)
        Me.Controls.Add(Me.btnDeleteType)
        Me.Controls.Add(Me.btnDeleteRarity)
        Me.Controls.Add(Me.txtAddSet)
        Me.Controls.Add(Me.txtAddtype)
        Me.Controls.Add(Me.txtAddRarity)
        Me.Controls.Add(Me.btnAddType)
        Me.Controls.Add(Me.btnAddRarity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddFields"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Alter Field Values"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddRarity As Button
    Friend WithEvents btnAddType As Button
    Friend WithEvents txtAddRarity As TextBox
    Friend WithEvents txtAddtype As TextBox
    Friend WithEvents txtAddSet As TextBox
    Friend WithEvents txtDeleteSet As TextBox
    Friend WithEvents txtDeleteType As TextBox
    Friend WithEvents txtDeleteRarity As TextBox
    Friend WithEvents btnDeleteType As Button
    Friend WithEvents btnDeleteRarity As Button
    Friend WithEvents btnDeleteSet As Button
    Friend WithEvents btnAddSet As Button
    Friend WithEvents lblAdd As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblResult As Label
End Class
