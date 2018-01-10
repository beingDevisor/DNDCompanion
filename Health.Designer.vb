<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Health
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
        Me.btnHealthFormConfirm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHPUp = New System.Windows.Forms.Button()
        Me.btnHPDown = New System.Windows.Forms.Button()
        Me.txtHealth = New System.Windows.Forms.TextBox()
        Me.radParty1 = New System.Windows.Forms.RadioButton()
        Me.radParty2 = New System.Windows.Forms.RadioButton()
        Me.radParty3 = New System.Windows.Forms.RadioButton()
        Me.radParty4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMaxHealth = New System.Windows.Forms.TextBox()
        Me.btnMaxHPDown = New System.Windows.Forms.Button()
        Me.btnMaxHPUp = New System.Windows.Forms.Button()
        Me.btnHealthFormClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHealthFormConfirm
        '
        Me.btnHealthFormConfirm.Location = New System.Drawing.Point(10, 340)
        Me.btnHealthFormConfirm.Name = "btnHealthFormConfirm"
        Me.btnHealthFormConfirm.Size = New System.Drawing.Size(362, 46)
        Me.btnHealthFormConfirm.TabIndex = 0
        Me.btnHealthFormConfirm.Text = "Confirm"
        Me.btnHealthFormConfirm.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHealth)
        Me.GroupBox1.Controls.Add(Me.btnHPDown)
        Me.GroupBox1.Controls.Add(Me.btnHPUp)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 119)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Health"
        '
        'btnHPUp
        '
        Me.btnHPUp.Location = New System.Drawing.Point(83, 47)
        Me.btnHPUp.Name = "btnHPUp"
        Me.btnHPUp.Size = New System.Drawing.Size(20, 25)
        Me.btnHPUp.TabIndex = 2
        Me.btnHPUp.Text = "↑"
        Me.btnHPUp.UseVisualStyleBackColor = True
        '
        'btnHPDown
        '
        Me.btnHPDown.Location = New System.Drawing.Point(16, 47)
        Me.btnHPDown.Name = "btnHPDown"
        Me.btnHPDown.Size = New System.Drawing.Size(20, 25)
        Me.btnHPDown.TabIndex = 3
        Me.btnHPDown.Text = "↓"
        Me.btnHPDown.UseVisualStyleBackColor = True
        '
        'txtHealth
        '
        Me.txtHealth.Location = New System.Drawing.Point(42, 51)
        Me.txtHealth.Name = "txtHealth"
        Me.txtHealth.Size = New System.Drawing.Size(35, 20)
        Me.txtHealth.TabIndex = 4
        Me.txtHealth.Text = "20"
        '
        'radParty1
        '
        Me.radParty1.AutoSize = True
        Me.radParty1.Location = New System.Drawing.Point(6, 19)
        Me.radParty1.Name = "radParty1"
        Me.radParty1.Size = New System.Drawing.Size(72, 17)
        Me.radParty1.TabIndex = 4
        Me.radParty1.TabStop = True
        Me.radParty1.Text = "Member 1"
        Me.radParty1.UseVisualStyleBackColor = True
        '
        'radParty2
        '
        Me.radParty2.AutoSize = True
        Me.radParty2.Location = New System.Drawing.Point(6, 43)
        Me.radParty2.Name = "radParty2"
        Me.radParty2.Size = New System.Drawing.Size(72, 17)
        Me.radParty2.TabIndex = 5
        Me.radParty2.TabStop = True
        Me.radParty2.Text = "Member 2"
        Me.radParty2.UseVisualStyleBackColor = True
        '
        'radParty3
        '
        Me.radParty3.AutoSize = True
        Me.radParty3.Location = New System.Drawing.Point(6, 67)
        Me.radParty3.Name = "radParty3"
        Me.radParty3.Size = New System.Drawing.Size(72, 17)
        Me.radParty3.TabIndex = 6
        Me.radParty3.TabStop = True
        Me.radParty3.Text = "Member 3"
        Me.radParty3.UseVisualStyleBackColor = True
        '
        'radParty4
        '
        Me.radParty4.AutoSize = True
        Me.radParty4.Location = New System.Drawing.Point(6, 91)
        Me.radParty4.Name = "radParty4"
        Me.radParty4.Size = New System.Drawing.Size(72, 17)
        Me.radParty4.TabIndex = 7
        Me.radParty4.TabStop = True
        Me.radParty4.Text = "Member 4"
        Me.radParty4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radParty1)
        Me.GroupBox2.Controls.Add(Me.radParty4)
        Me.GroupBox2.Controls.Add(Me.radParty2)
        Me.GroupBox2.Controls.Add(Me.radParty3)
        Me.GroupBox2.Location = New System.Drawing.Point(262, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(119, 119)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Player"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMaxHealth)
        Me.GroupBox3.Controls.Add(Me.btnMaxHPDown)
        Me.GroupBox3.Controls.Add(Me.btnMaxHPUp)
        Me.GroupBox3.Location = New System.Drawing.Point(136, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(119, 119)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Max Health"
        '
        'txtMaxHealth
        '
        Me.txtMaxHealth.Location = New System.Drawing.Point(42, 48)
        Me.txtMaxHealth.Name = "txtMaxHealth"
        Me.txtMaxHealth.Size = New System.Drawing.Size(35, 20)
        Me.txtMaxHealth.TabIndex = 12
        Me.txtMaxHealth.Text = "20"
        '
        'btnMaxHPDown
        '
        Me.btnMaxHPDown.Location = New System.Drawing.Point(16, 44)
        Me.btnMaxHPDown.Name = "btnMaxHPDown"
        Me.btnMaxHPDown.Size = New System.Drawing.Size(20, 25)
        Me.btnMaxHPDown.TabIndex = 11
        Me.btnMaxHPDown.Text = "↓"
        Me.btnMaxHPDown.UseVisualStyleBackColor = True
        '
        'btnMaxHPUp
        '
        Me.btnMaxHPUp.Location = New System.Drawing.Point(83, 44)
        Me.btnMaxHPUp.Name = "btnMaxHPUp"
        Me.btnMaxHPUp.Size = New System.Drawing.Size(20, 25)
        Me.btnMaxHPUp.TabIndex = 10
        Me.btnMaxHPUp.Text = "↑"
        Me.btnMaxHPUp.UseVisualStyleBackColor = True
        '
        'btnHealthFormClose
        '
        Me.btnHealthFormClose.Location = New System.Drawing.Point(10, 392)
        Me.btnHealthFormClose.Name = "btnHealthFormClose"
        Me.btnHealthFormClose.Size = New System.Drawing.Size(362, 46)
        Me.btnHealthFormClose.TabIndex = 10
        Me.btnHealthFormClose.Text = "Close"
        Me.btnHealthFormClose.UseVisualStyleBackColor = True
        '
        'Health
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 441)
        Me.Controls.Add(Me.btnHealthFormClose)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHealthFormConfirm)
        Me.Name = "Health"
        Me.Text = "Health"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHealthFormConfirm As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnHPDown As Button
    Friend WithEvents btnHPUp As Button
    Friend WithEvents txtHealth As TextBox
    Friend WithEvents radParty1 As RadioButton
    Friend WithEvents radParty2 As RadioButton
    Friend WithEvents radParty3 As RadioButton
    Friend WithEvents radParty4 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMaxHealth As TextBox
    Friend WithEvents btnMaxHPDown As Button
    Friend WithEvents btnMaxHPUp As Button
    Friend WithEvents btnHealthFormClose As Button
End Class
