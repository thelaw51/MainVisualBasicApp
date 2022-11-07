<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlotMachine
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
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPull = New System.Windows.Forms.Button()
        Me.lblPullsCounter1 = New System.Windows.Forms.Label()
        Me.lblPullsCounter2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNum1
        '
        Me.lblNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNum1.Font = New System.Drawing.Font("JetBrains Mono", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum1.Location = New System.Drawing.Point(13, 9)
        Me.lblNum1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(212, 327)
        Me.lblNum1.TabIndex = 0
        Me.lblNum1.Text = "0"
        Me.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum3
        '
        Me.lblNum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNum3.Font = New System.Drawing.Font("JetBrains Mono", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum3.Location = New System.Drawing.Point(453, 9)
        Me.lblNum3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(212, 327)
        Me.lblNum3.TabIndex = 3
        Me.lblNum3.Text = "0"
        Me.lblNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum2
        '
        Me.lblNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNum2.Font = New System.Drawing.Font("JetBrains Mono", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum2.Location = New System.Drawing.Point(233, 9)
        Me.lblNum2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(212, 327)
        Me.lblNum2.TabIndex = 4
        Me.lblNum2.Text = "0"
        Me.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(12, 374)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(652, 30)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnPull
        '
        Me.btnPull.Location = New System.Drawing.Point(12, 339)
        Me.btnPull.Name = "btnPull"
        Me.btnPull.Size = New System.Drawing.Size(652, 29)
        Me.btnPull.TabIndex = 6
        Me.btnPull.Text = "Pull"
        Me.btnPull.UseVisualStyleBackColor = True
        '
        'lblPullsCounter1
        '
        Me.lblPullsCounter1.AutoSize = True
        Me.lblPullsCounter1.Location = New System.Drawing.Point(370, 407)
        Me.lblPullsCounter1.Name = "lblPullsCounter1"
        Me.lblPullsCounter1.Size = New System.Drawing.Size(20, 21)
        Me.lblPullsCounter1.TabIndex = 7
        Me.lblPullsCounter1.Text = "0"
        '
        'lblPullsCounter2
        '
        Me.lblPullsCounter2.Location = New System.Drawing.Point(233, 407)
        Me.lblPullsCounter2.Name = "lblPullsCounter2"
        Me.lblPullsCounter2.Size = New System.Drawing.Size(131, 21)
        Me.lblPullsCounter2.TabIndex = 8
        Me.lblPullsCounter2.Text = "Pulls Left : "
        '
        'SlotMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 429)
        Me.Controls.Add(Me.lblPullsCounter2)
        Me.Controls.Add(Me.lblPullsCounter1)
        Me.Controls.Add(Me.btnPull)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum3)
        Me.Controls.Add(Me.lblNum1)
        Me.Font = New System.Drawing.Font("JetBrains Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SlotMachine"
        Me.Text = "Slot Machine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum3 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPull As Button
    Friend WithEvents lblPullsCounter1 As Label
    Friend WithEvents lblPullsCounter2 As Label
End Class
