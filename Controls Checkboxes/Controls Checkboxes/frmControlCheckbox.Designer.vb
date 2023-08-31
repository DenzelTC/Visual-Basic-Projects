<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlCheckbox
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
        Me.chkRed = New System.Windows.Forms.CheckBox()
        Me.chkBlue = New System.Windows.Forms.CheckBox()
        Me.chkGreen = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'pnlScreen
        '
        Me.pnlScreen.BackColor = System.Drawing.SystemColors.Control
        Me.pnlScreen.Location = New System.Drawing.Point(39, 26)
        Me.pnlScreen.Name = "pnlScreen"
        Me.pnlScreen.Size = New System.Drawing.Size(550, 314)
        Me.pnlScreen.TabIndex = 0
        '
        'chkRed
        '
        Me.chkRed.AutoSize = True
        Me.chkRed.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRed.Location = New System.Drawing.Point(42, 373)
        Me.chkRed.Name = "chkRed"
        Me.chkRed.Size = New System.Drawing.Size(66, 27)
        Me.chkRed.TabIndex = 1
        Me.chkRed.Text = "Red"
        Me.chkRed.UseVisualStyleBackColor = True
        '
        'chkBlue
        '
        Me.chkBlue.AutoSize = True
        Me.chkBlue.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBlue.Location = New System.Drawing.Point(518, 373)
        Me.chkBlue.Name = "chkBlue"
        Me.chkBlue.Size = New System.Drawing.Size(71, 27)
        Me.chkBlue.TabIndex = 2
        Me.chkBlue.Text = "Blue"
        Me.chkBlue.UseVisualStyleBackColor = True
        '
        'chkGreen
        '
        Me.chkGreen.AutoSize = True
        Me.chkGreen.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGreen.Location = New System.Drawing.Point(258, 373)
        Me.chkGreen.Name = "chkGreen"
        Me.chkGreen.Size = New System.Drawing.Size(85, 27)
        Me.chkGreen.TabIndex = 3
        Me.chkGreen.Text = "Green"
        Me.chkGreen.UseVisualStyleBackColor = True
        '
        'frmControlCheckbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 442)
        Me.Controls.Add(Me.chkGreen)
        Me.Controls.Add(Me.chkBlue)
        Me.Controls.Add(Me.chkRed)
        Me.Controls.Add(Me.pnlScreen)
        Me.Name = "frmControlCheckbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlScreen As Panel
    Friend WithEvents chkRed As CheckBox
    Friend WithEvents chkBlue As CheckBox
    Friend WithEvents chkGreen As CheckBox
End Class
