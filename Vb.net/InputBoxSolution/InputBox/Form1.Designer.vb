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
        Me.TxtBoxFirstName = New System.Windows.Forms.TextBox()
        Me.TxtBoxLastName = New System.Windows.Forms.MaskedTextBox()
        Me.TxtBoxEmail = New System.Windows.Forms.MaskedTextBox()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtBoxFirstName
        '
        Me.TxtBoxFirstName.Location = New System.Drawing.Point(182, 93)
        Me.TxtBoxFirstName.Name = "TxtBoxFirstName"
        Me.TxtBoxFirstName.Size = New System.Drawing.Size(174, 22)
        Me.TxtBoxFirstName.TabIndex = 0
        '
        'TxtBoxLastName
        '
        Me.TxtBoxLastName.Location = New System.Drawing.Point(182, 140)
        Me.TxtBoxLastName.Name = "TxtBoxLastName"
        Me.TxtBoxLastName.Size = New System.Drawing.Size(174, 22)
        Me.TxtBoxLastName.TabIndex = 1
        '
        'TxtBoxEmail
        '
        Me.TxtBoxEmail.Location = New System.Drawing.Point(184, 190)
        Me.TxtBoxEmail.Name = "TxtBoxEmail"
        Me.TxtBoxEmail.Size = New System.Drawing.Size(172, 22)
        Me.TxtBoxEmail.TabIndex = 2
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Location = New System.Drawing.Point(94, 96)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(76, 17)
        Me.FirstName.TabIndex = 3
        Me.FirstName.Text = "First Name"
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Location = New System.Drawing.Point(94, 140)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(76, 17)
        Me.LastName.TabIndex = 4
        Me.LastName.Text = "Last Name"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(94, 193)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(47, 17)
        Me.Email.TabIndex = 5
        Me.Email.Text = "E-Mail"
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(150, 236)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(94, 44)
        Me.Submit.TabIndex = 7
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 347)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.TxtBoxEmail)
        Me.Controls.Add(Me.TxtBoxLastName)
        Me.Controls.Add(Me.TxtBoxFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBoxFirstName As TextBox
    Friend WithEvents TxtBoxLastName As MaskedTextBox
    Friend WithEvents TxtBoxEmail As MaskedTextBox
    Friend WithEvents FirstName As Label
    Friend WithEvents LastName As Label
    Friend WithEvents Email As Label
    Friend WithEvents Submit As Button
End Class
