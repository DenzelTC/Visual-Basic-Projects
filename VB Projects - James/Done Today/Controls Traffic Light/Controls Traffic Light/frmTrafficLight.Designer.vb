<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrafficLight
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
        Me.radGreen = New System.Windows.Forms.RadioButton()
        Me.radAmber = New System.Windows.Forms.RadioButton()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGreen.Location = New System.Drawing.Point(12, 458)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(83, 28)
        Me.radGreen.TabIndex = 0
        Me.radGreen.TabStop = True
        Me.radGreen.Text = "Green"
        Me.radGreen.UseVisualStyleBackColor = True
        Me.radGreen.Visible = False
        '
        'radAmber
        '
        Me.radAmber.AutoSize = True
        Me.radAmber.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAmber.Location = New System.Drawing.Point(409, 458)
        Me.radAmber.Name = "radAmber"
        Me.radAmber.Size = New System.Drawing.Size(89, 28)
        Me.radAmber.TabIndex = 1
        Me.radAmber.TabStop = True
        Me.radAmber.Text = "Amber"
        Me.radAmber.UseVisualStyleBackColor = True
        Me.radAmber.Visible = False
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRed.Location = New System.Drawing.Point(791, 458)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(64, 28)
        Me.radRed.TabIndex = 2
        Me.radRed.TabStop = True
        Me.radRed.Text = "Red"
        Me.radRed.UseVisualStyleBackColor = True
        Me.radRed.Visible = False
        '
        'frmTrafficLight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(927, 487)
        Me.Controls.Add(Me.radRed)
        Me.Controls.Add(Me.radAmber)
        Me.Controls.Add(Me.radGreen)
        Me.Name = "frmTrafficLight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traffic"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radGreen As RadioButton
    Friend WithEvents radAmber As RadioButton
    Friend WithEvents radRed As RadioButton
End Class
