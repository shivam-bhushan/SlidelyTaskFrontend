<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameLable = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EmailLable = New System.Windows.Forms.Label()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumLabel = New System.Windows.Forms.Label()
        Me.GithubLinkTextBox = New System.Windows.Forms.TextBox()
        Me.GithubLinkLabel = New System.Windows.Forms.Label()
        Me.StopwatchTextBox = New System.Windows.Forms.TextBox()
        Me.StopwatchLabel = New System.Windows.Forms.Label()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Slidely Task 2 - View Submission"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameLable
        '
        Me.NameLable.AutoSize = True
        Me.NameLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.NameLable.Location = New System.Drawing.Point(32, 89)
        Me.NameLable.Name = "NameLable"
        Me.NameLable.Size = New System.Drawing.Size(48, 18)
        Me.NameLable.TabIndex = 2
        Me.NameLable.Text = "Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(133, 88)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(218, 20)
        Me.NameTextBox.TabIndex = 3
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(133, 127)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(218, 20)
        Me.EmailTextBox.TabIndex = 5
        '
        'EmailLable
        '
        Me.EmailLable.AutoSize = True
        Me.EmailLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.EmailLable.Location = New System.Drawing.Point(32, 128)
        Me.EmailLable.Name = "EmailLable"
        Me.EmailLable.Size = New System.Drawing.Size(45, 18)
        Me.EmailLable.TabIndex = 4
        Me.EmailLable.Text = "Email"
        '
        'PhoneNumTextBox
        '
        Me.PhoneNumTextBox.Location = New System.Drawing.Point(133, 168)
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        Me.PhoneNumTextBox.ReadOnly = True
        Me.PhoneNumTextBox.Size = New System.Drawing.Size(218, 20)
        Me.PhoneNumTextBox.TabIndex = 7
        '
        'PhoneNumLabel
        '
        Me.PhoneNumLabel.AutoSize = True
        Me.PhoneNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.PhoneNumLabel.Location = New System.Drawing.Point(32, 169)
        Me.PhoneNumLabel.Name = "PhoneNumLabel"
        Me.PhoneNumLabel.Size = New System.Drawing.Size(87, 18)
        Me.PhoneNumLabel.TabIndex = 6
        Me.PhoneNumLabel.Text = "Phone Num"
        '
        'GithubLinkTextBox
        '
        Me.GithubLinkTextBox.Location = New System.Drawing.Point(133, 211)
        Me.GithubLinkTextBox.Multiline = True
        Me.GithubLinkTextBox.Name = "GithubLinkTextBox"
        Me.GithubLinkTextBox.ReadOnly = True
        Me.GithubLinkTextBox.Size = New System.Drawing.Size(218, 35)
        Me.GithubLinkTextBox.TabIndex = 9
        '
        'GithubLinkLabel
        '
        Me.GithubLinkLabel.AutoSize = True
        Me.GithubLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GithubLinkLabel.Location = New System.Drawing.Point(32, 210)
        Me.GithubLinkLabel.Name = "GithubLinkLabel"
        Me.GithubLinkLabel.Size = New System.Drawing.Size(77, 36)
        Me.GithubLinkLabel.TabIndex = 8
        Me.GithubLinkLabel.Text = "Github link" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for task 2"
        Me.GithubLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StopwatchTextBox
        '
        Me.StopwatchTextBox.Location = New System.Drawing.Point(133, 270)
        Me.StopwatchTextBox.Name = "StopwatchTextBox"
        Me.StopwatchTextBox.ReadOnly = True
        Me.StopwatchTextBox.Size = New System.Drawing.Size(218, 20)
        Me.StopwatchTextBox.TabIndex = 11
        '
        'StopwatchLabel
        '
        Me.StopwatchLabel.AutoSize = True
        Me.StopwatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.StopwatchLabel.Location = New System.Drawing.Point(32, 263)
        Me.StopwatchLabel.Name = "StopwatchLabel"
        Me.StopwatchLabel.Size = New System.Drawing.Size(82, 36)
        Me.StopwatchLabel.TabIndex = 10
        Me.StopwatchLabel.Text = "Stopwatch " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "time"
        Me.StopwatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PreviousButton
        '
        Me.PreviousButton.Location = New System.Drawing.Point(35, 330)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(153, 31)
        Me.PreviousButton.TabIndex = 12
        Me.PreviousButton.Text = "Previous "
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(198, 330)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(153, 31)
        Me.NextButton.TabIndex = 13
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 399)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.StopwatchTextBox)
        Me.Controls.Add(Me.StopwatchLabel)
        Me.Controls.Add(Me.GithubLinkTextBox)
        Me.Controls.Add(Me.GithubLinkLabel)
        Me.Controls.Add(Me.PhoneNumTextBox)
        Me.Controls.Add(Me.PhoneNumLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.EmailLable)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.NameLable)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameLable As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EmailLable As Label
    Friend WithEvents PhoneNumTextBox As TextBox
    Friend WithEvents PhoneNumLabel As Label
    Friend WithEvents GithubLinkTextBox As TextBox
    Friend WithEvents GithubLinkLabel As Label
    Friend WithEvents StopwatchTextBox As TextBox
    Friend WithEvents StopwatchLabel As Label
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
End Class
