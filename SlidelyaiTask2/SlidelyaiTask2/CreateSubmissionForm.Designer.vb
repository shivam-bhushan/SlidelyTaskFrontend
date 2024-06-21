<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.StopwatchField = New System.Windows.Forms.TextBox()
        Me.GithubLinkField = New System.Windows.Forms.TextBox()
        Me.GithubLinkLabel = New System.Windows.Forms.Label()
        Me.PhoneNumberField = New System.Windows.Forms.TextBox()
        Me.PhoneNumberLabel = New System.Windows.Forms.Label()
        Me.EmailField = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.NameField = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToggleStopwatchButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(36, 336)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(319, 31)
        Me.SubmitButton.TabIndex = 25
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'StopwatchField
        '
        Me.StopwatchField.Location = New System.Drawing.Point(202, 276)
        Me.StopwatchField.Name = "StopwatchField"
        Me.StopwatchField.Size = New System.Drawing.Size(153, 20)
        Me.StopwatchField.TabIndex = 24
        '
        'GithubLinkField
        '
        Me.GithubLinkField.Location = New System.Drawing.Point(137, 217)
        Me.GithubLinkField.Multiline = True
        Me.GithubLinkField.Name = "GithubLinkField"
        Me.GithubLinkField.Size = New System.Drawing.Size(218, 35)
        Me.GithubLinkField.TabIndex = 22
        '
        'GithubLinkLabel
        '
        Me.GithubLinkLabel.AutoSize = True
        Me.GithubLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GithubLinkLabel.Location = New System.Drawing.Point(33, 216)
        Me.GithubLinkLabel.Name = "GithubLinkLabel"
        Me.GithubLinkLabel.Size = New System.Drawing.Size(77, 36)
        Me.GithubLinkLabel.TabIndex = 21
        Me.GithubLinkLabel.Text = "Github link" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for task 2"
        Me.GithubLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PhoneNumberField
        '
        Me.PhoneNumberField.Location = New System.Drawing.Point(137, 174)
        Me.PhoneNumberField.Name = "PhoneNumberField"
        Me.PhoneNumberField.Size = New System.Drawing.Size(218, 20)
        Me.PhoneNumberField.TabIndex = 20
        '
        'PhoneNumberLabel
        '
        Me.PhoneNumberLabel.AutoSize = True
        Me.PhoneNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.PhoneNumberLabel.Location = New System.Drawing.Point(33, 175)
        Me.PhoneNumberLabel.Name = "PhoneNumberLabel"
        Me.PhoneNumberLabel.Size = New System.Drawing.Size(87, 18)
        Me.PhoneNumberLabel.TabIndex = 19
        Me.PhoneNumberLabel.Text = "Phone Num"
        '
        'EmailField
        '
        Me.EmailField.Location = New System.Drawing.Point(137, 133)
        Me.EmailField.Name = "EmailField"
        Me.EmailField.Size = New System.Drawing.Size(218, 20)
        Me.EmailField.TabIndex = 18
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.EmailLabel.Location = New System.Drawing.Point(33, 134)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(45, 18)
        Me.EmailLabel.TabIndex = 17
        Me.EmailLabel.Text = "Email"
        '
        'NameField
        '
        Me.NameField.Location = New System.Drawing.Point(137, 94)
        Me.NameField.Name = "NameField"
        Me.NameField.Size = New System.Drawing.Size(218, 20)
        Me.NameField.TabIndex = 16
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.NameLabel.Location = New System.Drawing.Point(33, 95)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(48, 18)
        Me.NameLabel.TabIndex = 15
        Me.NameLabel.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Slidely Task 2 - Create Submission"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToggleStopwatchButton
        '
        Me.ToggleStopwatchButton.Location = New System.Drawing.Point(36, 273)
        Me.ToggleStopwatchButton.Name = "ToggleStopwatchButton"
        Me.ToggleStopwatchButton.Size = New System.Drawing.Size(153, 25)
        Me.ToggleStopwatchButton.TabIndex = 27
        Me.ToggleStopwatchButton.Text = "Toggle Stopwatch"
        Me.ToggleStopwatchButton.UseVisualStyleBackColor = True
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 416)
        Me.Controls.Add(Me.ToggleStopwatchButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.StopwatchField)
        Me.Controls.Add(Me.GithubLinkField)
        Me.Controls.Add(Me.GithubLinkLabel)
        Me.Controls.Add(Me.PhoneNumberField)
        Me.Controls.Add(Me.PhoneNumberLabel)
        Me.Controls.Add(Me.EmailField)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.NameField)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents StopwatchField As TextBox
    Friend WithEvents GithubLinkField As TextBox
    Friend WithEvents GithubLinkLabel As Label
    Friend WithEvents PhoneNumberField As TextBox
    Friend WithEvents PhoneNumberLabel As Label
    Friend WithEvents EmailField As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents NameField As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToggleStopwatchButton As Button
End Class
