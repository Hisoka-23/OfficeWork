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
        Me.LstBoxSelectGames = New System.Windows.Forms.ListBox()
        Me.LstBoxSelectedGames = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtBoxFirstName
        '
        Me.TxtBoxFirstName.Location = New System.Drawing.Point(247, 60)
        Me.TxtBoxFirstName.Name = "TxtBoxFirstName"
        Me.TxtBoxFirstName.Size = New System.Drawing.Size(230, 22)
        Me.TxtBoxFirstName.TabIndex = 0
        '
        'TxtBoxLastName
        '
        Me.TxtBoxLastName.Location = New System.Drawing.Point(247, 123)
        Me.TxtBoxLastName.Name = "TxtBoxLastName"
        Me.TxtBoxLastName.Size = New System.Drawing.Size(230, 22)
        Me.TxtBoxLastName.TabIndex = 1
        '
        'TxtBoxEmail
        '
        Me.TxtBoxEmail.Location = New System.Drawing.Point(247, 181)
        Me.TxtBoxEmail.Name = "TxtBoxEmail"
        Me.TxtBoxEmail.Size = New System.Drawing.Size(230, 22)
        Me.TxtBoxEmail.TabIndex = 2
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Location = New System.Drawing.Point(139, 63)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(76, 17)
        Me.FirstName.TabIndex = 3
        Me.FirstName.Text = "First Name"
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Location = New System.Drawing.Point(139, 126)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(76, 17)
        Me.LastName.TabIndex = 4
        Me.LastName.Text = "Last Name"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(139, 184)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(47, 17)
        Me.Email.TabIndex = 5
        Me.Email.Text = "E-mail"
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(176, 233)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(119, 34)
        Me.Submit.TabIndex = 6
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'LstBoxSelectGames
        '
        Me.LstBoxSelectGames.FormattingEnabled = True
        Me.LstBoxSelectGames.ItemHeight = 16
        Me.LstBoxSelectGames.Items.AddRange(New Object() {"Cricket", "Football", "baskball", "Handball"})
        Me.LstBoxSelectGames.Location = New System.Drawing.Point(513, 63)
        Me.LstBoxSelectGames.Name = "LstBoxSelectGames"
        Me.LstBoxSelectGames.Size = New System.Drawing.Size(120, 84)
        Me.LstBoxSelectGames.TabIndex = 7
        '
        'LstBoxSelectedGames
        '
        Me.LstBoxSelectedGames.FormattingEnabled = True
        Me.LstBoxSelectedGames.ItemHeight = 16
        Me.LstBoxSelectedGames.Location = New System.Drawing.Point(763, 63)
        Me.LstBoxSelectedGames.Name = "LstBoxSelectedGames"
        Me.LstBoxSelectedGames.Size = New System.Drawing.Size(120, 84)
        Me.LstBoxSelectedGames.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(544, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Select Game"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(760, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Selected Games"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(673, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 28)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(673, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 28)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "<<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 316)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LstBoxSelectedGames)
        Me.Controls.Add(Me.LstBoxSelectGames)
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
    Friend WithEvents LstBoxSelectGames As System.Windows.Forms.ListBox
    Friend WithEvents LstBoxSelectedGames As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
