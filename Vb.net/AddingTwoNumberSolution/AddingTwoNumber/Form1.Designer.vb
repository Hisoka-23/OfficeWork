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
        Me.TxtBoxNumber1 = New System.Windows.Forms.TextBox()
        Me.TxtBoxNumber2 = New System.Windows.Forms.TextBox()
        Me.TxtBoxSum = New System.Windows.Forms.TextBox()
        Me.Btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtBoxNumber1
        '
        Me.TxtBoxNumber1.Location = New System.Drawing.Point(255, 88)
        Me.TxtBoxNumber1.Name = "TxtBoxNumber1"
        Me.TxtBoxNumber1.Size = New System.Drawing.Size(100, 22)
        Me.TxtBoxNumber1.TabIndex = 0
        '
        'TxtBoxNumber2
        '
        Me.TxtBoxNumber2.Location = New System.Drawing.Point(255, 157)
        Me.TxtBoxNumber2.Name = "TxtBoxNumber2"
        Me.TxtBoxNumber2.Size = New System.Drawing.Size(100, 22)
        Me.TxtBoxNumber2.TabIndex = 1
        '
        'TxtBoxSum
        '
        Me.TxtBoxSum.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TxtBoxSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxSum.Location = New System.Drawing.Point(255, 230)
        Me.TxtBoxSum.Multiline = True
        Me.TxtBoxSum.Name = "TxtBoxSum"
        Me.TxtBoxSum.Size = New System.Drawing.Size(100, 41)
        Me.TxtBoxSum.TabIndex = 2
        Me.TxtBoxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn
        '
        Me.Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn.Location = New System.Drawing.Point(112, 230)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(94, 41)
        Me.Btn.TabIndex = 3
        Me.Btn.Text = "Sum"
        Me.Btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Number 2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 392)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn)
        Me.Controls.Add(Me.TxtBoxSum)
        Me.Controls.Add(Me.TxtBoxNumber2)
        Me.Controls.Add(Me.TxtBoxNumber1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBoxNumber1 As TextBox
    Friend WithEvents TxtBoxNumber2 As TextBox
    Friend WithEvents TxtBoxSum As TextBox
    Friend WithEvents Btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
