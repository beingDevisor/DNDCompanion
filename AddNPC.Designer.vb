<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNPC
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
        Me.txtArmorClass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaxHP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCharName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPartyBuilderCancel = New System.Windows.Forms.Button()
        Me.btnPartyBuilderConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtArmorClass
        '
        Me.txtArmorClass.Location = New System.Drawing.Point(115, 84)
        Me.txtArmorClass.Name = "txtArmorClass"
        Me.txtArmorClass.Size = New System.Drawing.Size(192, 20)
        Me.txtArmorClass.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Armor Class"
        '
        'txtMaxHP
        '
        Me.txtMaxHP.Location = New System.Drawing.Point(115, 48)
        Me.txtMaxHP.Name = "txtMaxHP"
        Me.txtMaxHP.Size = New System.Drawing.Size(192, 20)
        Me.txtMaxHP.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Maximum HP"
        '
        'txtCharName
        '
        Me.txtCharName.Location = New System.Drawing.Point(115, 12)
        Me.txtCharName.Name = "txtCharName"
        Me.txtCharName.Size = New System.Drawing.Size(192, 20)
        Me.txtCharName.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Character Name"
        '
        'btnPartyBuilderCancel
        '
        Me.btnPartyBuilderCancel.Location = New System.Drawing.Point(335, 12)
        Me.btnPartyBuilderCancel.Name = "btnPartyBuilderCancel"
        Me.btnPartyBuilderCancel.Size = New System.Drawing.Size(136, 46)
        Me.btnPartyBuilderCancel.TabIndex = 26
        Me.btnPartyBuilderCancel.Text = "Cancel"
        Me.btnPartyBuilderCancel.UseVisualStyleBackColor = True
        '
        'btnPartyBuilderConfirm
        '
        Me.btnPartyBuilderConfirm.Location = New System.Drawing.Point(335, 70)
        Me.btnPartyBuilderConfirm.Name = "btnPartyBuilderConfirm"
        Me.btnPartyBuilderConfirm.Size = New System.Drawing.Size(136, 46)
        Me.btnPartyBuilderConfirm.TabIndex = 25
        Me.btnPartyBuilderConfirm.Text = "Confirm"
        Me.btnPartyBuilderConfirm.UseVisualStyleBackColor = True
        '
        'AddNPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 134)
        Me.Controls.Add(Me.btnPartyBuilderCancel)
        Me.Controls.Add(Me.btnPartyBuilderConfirm)
        Me.Controls.Add(Me.txtArmorClass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMaxHP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCharName)
        Me.Controls.Add(Me.Label2)
        Me.Name = "AddNPC"
        Me.Text = "Add Non-Playable Character"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtArmorClass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaxHP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCharName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPartyBuilderCancel As Button
    Friend WithEvents btnPartyBuilderConfirm As Button
End Class
