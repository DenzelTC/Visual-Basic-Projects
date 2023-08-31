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
        Me.rdngreen = New System.Windows.Forms.RadioButton()
        Me.rdnamber = New System.Windows.Forms.RadioButton()
        Me.rdnred = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'rdngreen
        '
        Me.rdngreen.AutoSize = True
        Me.rdngreen.Location = New System.Drawing.Point(43, 433)
        Me.rdngreen.Name = "rdngreen"
        Me.rdngreen.Size = New System.Drawing.Size(57, 17)
        Me.rdngreen.TabIndex = 0
        Me.rdngreen.TabStop = True
        Me.rdngreen.Text = "Green "
        Me.rdngreen.UseVisualStyleBackColor = True
        '
        'rdnamber
        '
        Me.rdnamber.AutoSize = True
        Me.rdnamber.Location = New System.Drawing.Point(354, 433)
        Me.rdnamber.Name = "rdnamber"
        Me.rdnamber.Size = New System.Drawing.Size(55, 17)
        Me.rdnamber.TabIndex = 1
        Me.rdnamber.TabStop = True
        Me.rdnamber.Text = "Amber"
        Me.rdnamber.UseVisualStyleBackColor = True
        '
        'rdnred
        '
        Me.rdnred.AutoSize = True
        Me.rdnred.Location = New System.Drawing.Point(682, 433)
        Me.rdnred.Name = "rdnred"
        Me.rdnred.Size = New System.Drawing.Size(48, 17)
        Me.rdnred.TabIndex = 2
        Me.rdnred.TabStop = True
        Me.rdnred.Text = "Red "
        Me.rdnred.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(989, 492)
        Me.Controls.Add(Me.rdnred)
        Me.Controls.Add(Me.rdnamber)
        Me.Controls.Add(Me.rdngreen)
        Me.Name = "Form1"
        Me.Text = "Traffic lights "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdngreen As RadioButton
    Friend WithEvents rdnamber As RadioButton
    Friend WithEvents rdnred As RadioButton
End Class
