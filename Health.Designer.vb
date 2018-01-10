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
        Me.txtHealth = New System.Windows.Forms.TextBox()
        Me.btnHPDown = New System.Windows.Forms.Button()
        Me.btnHPUp = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMaxHealth = New System.Windows.Forms.TextBox()
        Me.btnMaxHPDown = New System.Windows.Forms.Button()
        Me.btnMaxHPUp = New System.Windows.Forms.Button()
        Me.btnHealthFormClose = New System.Windows.Forms.Button()
        Me.lstPlayers = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(10, 242)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 87)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Health"
        '
        'txtHealth
        '
        Me.txtHealth.Location = New System.Drawing.Point(42, 35)
        Me.txtHealth.Name = "txtHealth"
        Me.txtHealth.Size = New System.Drawing.Size(35, 20)
        Me.txtHealth.TabIndex = 4
        Me.txtHealth.Text = "20"
        '
        'btnHPDown
        '
        Me.btnHPDown.Location = New System.Drawing.Point(16, 31)
        Me.btnHPDown.Name = "btnHPDown"
        Me.btnHPDown.Size = New System.Drawing.Size(20, 25)
        Me.btnHPDown.TabIndex = 3
        Me.btnHPDown.Text = "↓"
        Me.btnHPDown.UseVisualStyleBackColor = True
        '
        'btnHPUp
        '
        Me.btnHPUp.Location = New System.Drawing.Point(83, 31)
        Me.btnHPUp.Name = "btnHPUp"
        Me.btnHPUp.Size = New System.Drawing.Size(20, 25)
        Me.btnHPUp.TabIndex = 2
        Me.btnHPUp.Text = "↑"
        Me.btnHPUp.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMaxHealth)
        Me.GroupBox3.Controls.Add(Me.btnMaxHPDown)
        Me.GroupBox3.Controls.Add(Me.btnMaxHPUp)
        Me.GroupBox3.Location = New System.Drawing.Point(253, 242)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(119, 87)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Max Health"
        '
        'txtMaxHealth
        '
        Me.txtMaxHealth.Location = New System.Drawing.Point(42, 35)
        Me.txtMaxHealth.Name = "txtMaxHealth"
        Me.txtMaxHealth.Size = New System.Drawing.Size(35, 20)
        Me.txtMaxHealth.TabIndex = 12
        Me.txtMaxHealth.Text = "20"
        '
        'btnMaxHPDown
        '
        Me.btnMaxHPDown.Location = New System.Drawing.Point(16, 31)
        Me.btnMaxHPDown.Name = "btnMaxHPDown"
        Me.btnMaxHPDown.Size = New System.Drawing.Size(20, 25)
        Me.btnMaxHPDown.TabIndex = 11
        Me.btnMaxHPDown.Text = "↓"
        Me.btnMaxHPDown.UseVisualStyleBackColor = True
        '
        'btnMaxHPUp
        '
        Me.btnMaxHPUp.Location = New System.Drawing.Point(83, 31)
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
        'lstPlayers
        '
        Me.lstPlayers.FormattingEnabled = True
        Me.lstPlayers.Location = New System.Drawing.Point(12, 12)
        Me.lstPlayers.Name = "lstPlayers"
        Me.lstPlayers.Size = New System.Drawing.Size(360, 225)
        Me.lstPlayers.TabIndex = 11
        '
        'Health
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 441)
        Me.Controls.Add(Me.lstPlayers)
        Me.Controls.Add(Me.btnHealthFormClose)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHealthFormConfirm)
        Me.Name = "Health"
        Me.Text = "Health"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHealthFormConfirm As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnHPDown As Button
    Friend WithEvents btnHPUp As Button
    Friend WithEvents txtHealth As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMaxHealth As TextBox
    Friend WithEvents btnMaxHPDown As Button
    Friend WithEvents btnMaxHPUp As Button
    Friend WithEvents btnHealthFormClose As Button
    Friend WithEvents lstPlayers As ListBox
End Class
