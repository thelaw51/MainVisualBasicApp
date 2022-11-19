<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMMTitle2 = New System.Windows.Forms.Label()
        Me.lblMMTitle1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSlotMachine = New System.Windows.Forms.Button()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblMMTitle2)
        Me.Panel1.Controls.Add(Me.lblMMTitle1)
        Me.Panel1.Location = New System.Drawing.Point(19, 20)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1224, 84)
        Me.Panel1.TabIndex = 0
        '
        'lblMMTitle2
        '
        Me.lblMMTitle2.AutoSize = True
        Me.lblMMTitle2.Font = New System.Drawing.Font("JetBrains Mono ExtraBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMMTitle2.Location = New System.Drawing.Point(436, 43)
        Me.lblMMTitle2.Name = "lblMMTitle2"
        Me.lblMMTitle2.Size = New System.Drawing.Size(309, 25)
        Me.lblMMTitle2.TabIndex = 1
        Me.lblMMTitle2.Text = "Choose what project to open"
        '
        'lblMMTitle1
        '
        Me.lblMMTitle1.AutoSize = True
        Me.lblMMTitle1.Font = New System.Drawing.Font("JetBrains Mono ExtraBold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMMTitle1.Location = New System.Drawing.Point(494, 0)
        Me.lblMMTitle1.Name = "lblMMTitle1"
        Me.lblMMTitle1.Size = New System.Drawing.Size(190, 43)
        Me.lblMMTitle1.TabIndex = 0
        Me.lblMMTitle1.Text = "Main Menu"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnCalculator)
        Me.Panel2.Controls.Add(Me.btnSlotMachine)
        Me.Panel2.Location = New System.Drawing.Point(19, 114)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1224, 622)
        Me.Panel2.TabIndex = 1
        '
        'btnSlotMachine
        '
        Me.btnSlotMachine.AutoSize = True
        Me.btnSlotMachine.Location = New System.Drawing.Point(0, 0)
        Me.btnSlotMachine.Name = "btnSlotMachine"
        Me.btnSlotMachine.Size = New System.Drawing.Size(154, 43)
        Me.btnSlotMachine.TabIndex = 0
        Me.btnSlotMachine.Text = "Slot Machine"
        Me.btnSlotMachine.UseVisualStyleBackColor = True
        '
        'btnCalculator
        '
        Me.btnCalculator.AutoSize = True
        Me.btnCalculator.Location = New System.Drawing.Point(160, 0)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(154, 43)
        Me.btnCalculator.TabIndex = 1
        Me.btnCalculator.Text = "Calculator"
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 750)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblMMTitle1 As Label
    Friend WithEvents lblMMTitle2 As Label
    Friend WithEvents btnSlotMachine As Button
    Friend WithEvents btnCalculator As Button
End Class
