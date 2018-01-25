<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartyBuilder
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
        Me.btnPartyBuilderConfirm = New System.Windows.Forms.Button()
        Me.btnPartyBuilderCancel = New System.Windows.Forms.Button()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCharName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaxHP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAC = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPartyBuilderConfirm
        '
        Me.btnPartyBuilderConfirm.Location = New System.Drawing.Point(327, 82)
        Me.btnPartyBuilderConfirm.Name = "btnPartyBuilderConfirm"
        Me.btnPartyBuilderConfirm.Size = New System.Drawing.Size(136, 46)
        Me.btnPartyBuilderConfirm.TabIndex = 9
        Me.btnPartyBuilderConfirm.Text = "Confirm"
        Me.btnPartyBuilderConfirm.UseVisualStyleBackColor = True
        '
        'btnPartyBuilderCancel
        '
        Me.btnPartyBuilderCancel.Location = New System.Drawing.Point(327, 12)
        Me.btnPartyBuilderCancel.Name = "btnPartyBuilderCancel"
        Me.btnPartyBuilderCancel.Size = New System.Drawing.Size(136, 46)
        Me.btnPartyBuilderCancel.TabIndex = 10
        Me.btnPartyBuilderCancel.Text = "Cancel"
        Me.btnPartyBuilderCancel.UseVisualStyleBackColor = True
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Location = New System.Drawing.Point(113, 10)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(192, 20)
        Me.txtPlayerName.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Player Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Character Name"
        '
        'txtCharName
        '
        Me.txtCharName.Location = New System.Drawing.Point(113, 46)
        Me.txtCharName.Name = "txtCharName"
        Me.txtCharName.Size = New System.Drawing.Size(192, 20)
        Me.txtCharName.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Maximum HP"
        '
        'txtMaxHP
        '
        Me.txtMaxHP.Location = New System.Drawing.Point(113, 82)
        Me.txtMaxHP.Name = "txtMaxHP"
        Me.txtMaxHP.Size = New System.Drawing.Size(192, 20)
        Me.txtMaxHP.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Armor Class"
        '
        'txtAC
        '
        Me.txtAC.Location = New System.Drawing.Point(113, 118)
        Me.txtAC.Name = "txtAC"
        Me.txtAC.Size = New System.Drawing.Size(192, 20)
        Me.txtAC.TabIndex = 18
        '
        'PartyBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 153)
        Me.Controls.Add(Me.txtAC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMaxHP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCharName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.btnPartyBuilderCancel)
        Me.Controls.Add(Me.btnPartyBuilderConfirm)
        Me.Name = "PartyBuilder"
        Me.Text = "Add Party Member"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPartyBuilderConfirm As Button
    Friend WithEvents btnPartyBuilderCancel As Button
    Friend WithEvents txtPlayerName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCharName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaxHP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAC As TextBox
End Class
