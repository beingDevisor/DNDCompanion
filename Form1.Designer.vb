<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHealth1 = New System.Windows.Forms.Button()
        Me.btnNewPlayer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnD20 = New System.Windows.Forms.Button()
        Me.btnD12 = New System.Windows.Forms.Button()
        Me.btnD10 = New System.Windows.Forms.Button()
        Me.btnD8 = New System.Windows.Forms.Button()
        Me.btnD6 = New System.Windows.Forms.Button()
        Me.btnD4 = New System.Windows.Forms.Button()
        Me.lblDiceOutput = New System.Windows.Forms.Label()
        Me.btnCustomRoll = New System.Windows.Forms.Button()
        Me.txtNumOfSides = New System.Windows.Forms.TextBox()
        Me.lblDiced = New System.Windows.Forms.Label()
        Me.txtNumOfDice = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstPlayers = New System.Windows.Forms.ListBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblArmorClass = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNewEnemy = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1161, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MenuToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnHealth1
        '
        Me.btnHealth1.Location = New System.Drawing.Point(619, 20)
        Me.btnHealth1.Name = "btnHealth1"
        Me.btnHealth1.Size = New System.Drawing.Size(135, 23)
        Me.btnHealth1.TabIndex = 9
        Me.btnHealth1.Text = "Health Point Control"
        Me.btnHealth1.UseVisualStyleBackColor = True
        '
        'btnNewPlayer
        '
        Me.btnNewPlayer.Location = New System.Drawing.Point(802, 28)
        Me.btnNewPlayer.Name = "btnNewPlayer"
        Me.btnNewPlayer.Size = New System.Drawing.Size(345, 40)
        Me.btnNewPlayer.TabIndex = 6
        Me.btnNewPlayer.Text = "New Player Character"
        Me.btnNewPlayer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnD20)
        Me.GroupBox2.Controls.Add(Me.btnD12)
        Me.GroupBox2.Controls.Add(Me.btnD10)
        Me.GroupBox2.Controls.Add(Me.btnD8)
        Me.GroupBox2.Controls.Add(Me.btnD6)
        Me.GroupBox2.Controls.Add(Me.btnD4)
        Me.GroupBox2.Controls.Add(Me.lblDiceOutput)
        Me.GroupBox2.Controls.Add(Me.btnCustomRoll)
        Me.GroupBox2.Controls.Add(Me.txtNumOfSides)
        Me.GroupBox2.Controls.Add(Me.lblDiced)
        Me.GroupBox2.Controls.Add(Me.txtNumOfDice)
        Me.GroupBox2.Location = New System.Drawing.Point(786, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 139)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dice"
        '
        'btnD20
        '
        Me.btnD20.Location = New System.Drawing.Point(268, 19)
        Me.btnD20.Name = "btnD20"
        Me.btnD20.Size = New System.Drawing.Size(36, 23)
        Me.btnD20.TabIndex = 10
        Me.btnD20.Text = "d20"
        Me.btnD20.UseVisualStyleBackColor = True
        '
        'btnD12
        '
        Me.btnD12.Location = New System.Drawing.Point(226, 19)
        Me.btnD12.Name = "btnD12"
        Me.btnD12.Size = New System.Drawing.Size(36, 23)
        Me.btnD12.TabIndex = 9
        Me.btnD12.Text = "d12"
        Me.btnD12.UseVisualStyleBackColor = True
        '
        'btnD10
        '
        Me.btnD10.Location = New System.Drawing.Point(184, 19)
        Me.btnD10.Name = "btnD10"
        Me.btnD10.Size = New System.Drawing.Size(36, 23)
        Me.btnD10.TabIndex = 8
        Me.btnD10.Text = "d10"
        Me.btnD10.UseVisualStyleBackColor = True
        '
        'btnD8
        '
        Me.btnD8.Location = New System.Drawing.Point(142, 19)
        Me.btnD8.Name = "btnD8"
        Me.btnD8.Size = New System.Drawing.Size(36, 23)
        Me.btnD8.TabIndex = 7
        Me.btnD8.Text = "d8"
        Me.btnD8.UseVisualStyleBackColor = True
        '
        'btnD6
        '
        Me.btnD6.Location = New System.Drawing.Point(100, 19)
        Me.btnD6.Name = "btnD6"
        Me.btnD6.Size = New System.Drawing.Size(36, 23)
        Me.btnD6.TabIndex = 6
        Me.btnD6.Text = "d6"
        Me.btnD6.UseVisualStyleBackColor = True
        '
        'btnD4
        '
        Me.btnD4.Location = New System.Drawing.Point(58, 19)
        Me.btnD4.Name = "btnD4"
        Me.btnD4.Size = New System.Drawing.Size(36, 23)
        Me.btnD4.TabIndex = 5
        Me.btnD4.Text = "d4"
        Me.btnD4.UseVisualStyleBackColor = True
        '
        'lblDiceOutput
        '
        Me.lblDiceOutput.AutoSize = True
        Me.lblDiceOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiceOutput.Location = New System.Drawing.Point(162, 58)
        Me.lblDiceOutput.Name = "lblDiceOutput"
        Me.lblDiceOutput.Size = New System.Drawing.Size(38, 25)
        Me.lblDiceOutput.TabIndex = 4
        Me.lblDiceOutput.Text = "20"
        '
        'btnCustomRoll
        '
        Me.btnCustomRoll.Location = New System.Drawing.Point(77, 100)
        Me.btnCustomRoll.Name = "btnCustomRoll"
        Me.btnCustomRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnCustomRoll.TabIndex = 3
        Me.btnCustomRoll.Text = "Roll"
        Me.btnCustomRoll.UseVisualStyleBackColor = True
        '
        'txtNumOfSides
        '
        Me.txtNumOfSides.Location = New System.Drawing.Point(252, 102)
        Me.txtNumOfSides.Name = "txtNumOfSides"
        Me.txtNumOfSides.Size = New System.Drawing.Size(28, 20)
        Me.txtNumOfSides.TabIndex = 2
        '
        'lblDiced
        '
        Me.lblDiced.AutoSize = True
        Me.lblDiced.Location = New System.Drawing.Point(241, 105)
        Me.lblDiced.Name = "lblDiced"
        Me.lblDiced.Size = New System.Drawing.Size(13, 13)
        Me.lblDiced.TabIndex = 1
        Me.lblDiced.Text = "d"
        '
        'txtNumOfDice
        '
        Me.txtNumOfDice.Location = New System.Drawing.Point(158, 102)
        Me.txtNumOfDice.Name = "txtNumOfDice"
        Me.txtNumOfDice.Size = New System.Drawing.Size(75, 20)
        Me.txtNumOfDice.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblArmorClass)
        Me.GroupBox1.Controls.Add(Me.btnHealth1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.lstPlayers)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 319)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Players"
        '
        'lstPlayers
        '
        Me.lstPlayers.FormattingEnabled = True
        Me.lstPlayers.Location = New System.Drawing.Point(7, 20)
        Me.lstPlayers.Name = "lstPlayers"
        Me.lstPlayers.Size = New System.Drawing.Size(250, 290)
        Me.lstPlayers.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(296, 20)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(259, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(266, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "HP"
        '
        'lblArmorClass
        '
        Me.lblArmorClass.AutoSize = True
        Me.lblArmorClass.Location = New System.Drawing.Point(266, 63)
        Me.lblArmorClass.Name = "lblArmorClass"
        Me.lblArmorClass.Size = New System.Drawing.Size(48, 13)
        Me.lblArmorClass.TabIndex = 3
        Me.lblArmorClass.Text = "AC:    20"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(561, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "20/20"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Initiative: 20"
        '
        'btnNewEnemy
        '
        Me.btnNewEnemy.Location = New System.Drawing.Point(802, 86)
        Me.btnNewEnemy.Name = "btnNewEnemy"
        Me.btnNewEnemy.Size = New System.Drawing.Size(345, 40)
        Me.btnNewEnemy.TabIndex = 11
        Me.btnNewEnemy.Text = "New Non-Playable Character"
        Me.btnNewEnemy.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 546)
        Me.Controls.Add(Me.btnNewEnemy)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnNewPlayer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "D&D Companion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnHealth1 As Button
    Friend WithEvents btnNewPlayer As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnD20 As Button
    Friend WithEvents btnD12 As Button
    Friend WithEvents btnD10 As Button
    Friend WithEvents btnD8 As Button
    Friend WithEvents btnD6 As Button
    Friend WithEvents btnD4 As Button
    Friend WithEvents lblDiceOutput As Label
    Friend WithEvents btnCustomRoll As Button
    Friend WithEvents txtNumOfSides As TextBox
    Friend WithEvents lblDiced As Label
    Friend WithEvents txtNumOfDice As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblArmorClass As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lstPlayers As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNewEnemy As Button
End Class
