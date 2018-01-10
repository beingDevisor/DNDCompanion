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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblPlayer3 = New System.Windows.Forms.Label()
        Me.lblPlayer4 = New System.Windows.Forms.Label()
        Me.btnHealth1 = New System.Windows.Forms.Button()
        Me.btnNewParty = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNumOfDice = New System.Windows.Forms.TextBox()
        Me.lblDiced = New System.Windows.Forms.Label()
        Me.txtNumOfSides = New System.Windows.Forms.TextBox()
        Me.btnCustomRoll = New System.Windows.Forms.Button()
        Me.lblDiceOutput = New System.Windows.Forms.Label()
        Me.btnD4 = New System.Windows.Forms.Button()
        Me.btnD6 = New System.Windows.Forms.Button()
        Me.btnD8 = New System.Windows.Forms.Button()
        Me.btnD10 = New System.Windows.Forms.Button()
        Me.btnD12 = New System.Windows.Forms.Button()
        Me.btnD20 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(500, 175)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(261, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(500, 19)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(261, 23)
        Me.ProgressBar2.TabIndex = 2
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(500, 97)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(261, 23)
        Me.ProgressBar3.TabIndex = 3
        '
        'ProgressBar4
        '
        Me.ProgressBar4.Location = New System.Drawing.Point(500, 253)
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(261, 23)
        Me.ProgressBar4.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHealth1)
        Me.GroupBox1.Controls.Add(Me.lblPlayer4)
        Me.GroupBox1.Controls.Add(Me.lblPlayer3)
        Me.GroupBox1.Controls.Add(Me.lblPlayer2)
        Me.GroupBox1.Controls.Add(Me.lblPlayer1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar2)
        Me.GroupBox1.Controls.Add(Me.ProgressBar3)
        Me.GroupBox1.Controls.Add(Me.ProgressBar4)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(767, 320)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Player Characters"
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Location = New System.Drawing.Point(10, 29)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(38, 13)
        Me.lblPlayer1.TabIndex = 5
        Me.lblPlayer1.Text = "NONE"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Location = New System.Drawing.Point(10, 107)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(38, 13)
        Me.lblPlayer2.TabIndex = 6
        Me.lblPlayer2.Text = "NONE"
        '
        'lblPlayer3
        '
        Me.lblPlayer3.AutoSize = True
        Me.lblPlayer3.Location = New System.Drawing.Point(10, 185)
        Me.lblPlayer3.Name = "lblPlayer3"
        Me.lblPlayer3.Size = New System.Drawing.Size(38, 13)
        Me.lblPlayer3.TabIndex = 7
        Me.lblPlayer3.Text = "NONE"
        '
        'lblPlayer4
        '
        Me.lblPlayer4.AutoSize = True
        Me.lblPlayer4.Location = New System.Drawing.Point(10, 263)
        Me.lblPlayer4.Name = "lblPlayer4"
        Me.lblPlayer4.Size = New System.Drawing.Size(38, 13)
        Me.lblPlayer4.TabIndex = 8
        Me.lblPlayer4.Text = "NONE"
        '
        'btnHealth1
        '
        Me.btnHealth1.Location = New System.Drawing.Point(500, 286)
        Me.btnHealth1.Name = "btnHealth1"
        Me.btnHealth1.Size = New System.Drawing.Size(261, 23)
        Me.btnHealth1.TabIndex = 9
        Me.btnHealth1.Text = "Health Point Control"
        Me.btnHealth1.UseVisualStyleBackColor = True
        '
        'btnNewParty
        '
        Me.btnNewParty.Location = New System.Drawing.Point(804, 28)
        Me.btnNewParty.Name = "btnNewParty"
        Me.btnNewParty.Size = New System.Drawing.Size(345, 41)
        Me.btnNewParty.TabIndex = 6
        Me.btnNewParty.Text = "New Party"
        Me.btnNewParty.UseVisualStyleBackColor = True
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
        'txtNumOfDice
        '
        Me.txtNumOfDice.Location = New System.Drawing.Point(158, 102)
        Me.txtNumOfDice.Name = "txtNumOfDice"
        Me.txtNumOfDice.Size = New System.Drawing.Size(75, 20)
        Me.txtNumOfDice.TabIndex = 0
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
        'txtNumOfSides
        '
        Me.txtNumOfSides.Location = New System.Drawing.Point(252, 102)
        Me.txtNumOfSides.Name = "txtNumOfSides"
        Me.txtNumOfSides.Size = New System.Drawing.Size(28, 20)
        Me.txtNumOfSides.TabIndex = 2
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
        'btnD4
        '
        Me.btnD4.Location = New System.Drawing.Point(58, 19)
        Me.btnD4.Name = "btnD4"
        Me.btnD4.Size = New System.Drawing.Size(36, 23)
        Me.btnD4.TabIndex = 5
        Me.btnD4.Text = "d4"
        Me.btnD4.UseVisualStyleBackColor = True
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
        'btnD8
        '
        Me.btnD8.Location = New System.Drawing.Point(142, 19)
        Me.btnD8.Name = "btnD8"
        Me.btnD8.Size = New System.Drawing.Size(36, 23)
        Me.btnD8.TabIndex = 7
        Me.btnD8.Text = "d8"
        Me.btnD8.UseVisualStyleBackColor = True
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
        'btnD12
        '
        Me.btnD12.Location = New System.Drawing.Point(226, 19)
        Me.btnD12.Name = "btnD12"
        Me.btnD12.Size = New System.Drawing.Size(36, 23)
        Me.btnD12.TabIndex = 9
        Me.btnD12.Text = "d12"
        Me.btnD12.UseVisualStyleBackColor = True
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 546)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnNewParty)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "D&D Companion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPlayer4 As Label
    Friend WithEvents lblPlayer3 As Label
    Friend WithEvents lblPlayer2 As Label
    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents btnHealth1 As Button
    Friend WithEvents btnNewParty As Button
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
End Class
