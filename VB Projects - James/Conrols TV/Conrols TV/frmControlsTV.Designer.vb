<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlsTV
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
        Me.pnlScreen = New System.Windows.Forms.Panel()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.radGreen = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'pnlScreen
        '
        Me.pnlScreen.Location = New System.Drawing.Point(28, 26)
        Me.pnlScreen.Name = "pnlScreen"
        Me.pnlScreen.Size = New System.Drawing.Size(600, 341)
        Me.pnlScreen.TabIndex = 0
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRed.Location = New System.Drawing.Point(25, 395)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(65, 27)
        Me.radRed.TabIndex = 1
        Me.radRed.TabStop = True
        Me.radRed.Text = "Red"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBlue.Location = New System.Drawing.Point(558, 395)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(70, 27)
        Me.radBlue.TabIndex = 2
        Me.radBlue.TabStop = True
        Me.radBlue.Text = "Blue"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGreen.Location = New System.Drawing.Point(245, 395)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(84, 27)
        Me.radGreen.TabIndex = 3
        Me.radGreen.TabStop = True
        Me.radGreen.Text = "Green"
        Me.radGreen.UseVisualStyleBackColor = True
        '
        'frmControlsTV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(656, 462)
        Me.Controls.Add(Me.radGreen)
        Me.Controls.Add(Me.radBlue)
        Me.Controls.Add(Me.radRed)
        Me.Controls.Add(Me.pnlScreen)
        Me.Name = "frmControlsTV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlScreen As Panel
    Friend WithEvents radRed As RadioButton
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents radGreen As RadioButton
End Class
