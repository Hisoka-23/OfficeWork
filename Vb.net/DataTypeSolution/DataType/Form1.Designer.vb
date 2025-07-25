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
        Me.BtnPhone16Properities = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnPhone16Properities
        '
        Me.BtnPhone16Properities.Location = New System.Drawing.Point(75, 102)
        Me.BtnPhone16Properities.Name = "BtnPhone16Properities"
        Me.BtnPhone16Properities.Size = New System.Drawing.Size(130, 49)
        Me.BtnPhone16Properities.TabIndex = 0
        Me.BtnPhone16Properities.Text = "IPhone 16"
        Me.BtnPhone16Properities.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.BtnPhone16Properities)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPhone16Properities As Button
End Class
