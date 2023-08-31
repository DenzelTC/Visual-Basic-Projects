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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlPanel1 = New System.Windows.Forms.Panel()
        Me.rdnred = New System.Windows.Forms.RadioButton()
        Me.rdngreen = New System.Windows.Forms.RadioButton()
        Me.rdnblue = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'pnlPanel1
        '
        Me.pnlPanel1.BackColor = System.Drawing.Color.White
        Me.pnlPanel1.Location = New System.Drawing.Point(68, 12)
        Me.pnlPanel1.Name = "pnlPanel1"
        Me.pnlPanel1.Size = New System.Drawing.Size(601, 295)
        Me.pnlPanel1.TabIndex = 0
        '
        'rdnred
        '
        Me.rdnred.AutoSize = True
        Me.rdnred.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdnred.ForeColor = System.Drawing.Color.Red
        Me.rdnred.Location = New System.Drawing.Point(68, 336)
        Me.rdnred.Name = "rdnred"
        Me.rdnred.Size = New System.Drawing.Size(76, 33)
        Me.rdnred.TabIndex = 1
        Me.rdnred.TabStop = True
        Me.rdnred.Text = "Red"
        Me.rdnred.UseVisualStyleBackColor = True
        '
        'rdngreen
        '
        Me.rdngreen.AutoSize = True
        Me.rdngreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdngreen.ForeColor = System.Drawing.Color.Lime
        Me.rdngreen.Location = New System.Drawing.Point(338, 336)
        Me.rdngreen.Name = "rdngreen"
        Me.rdngreen.Size = New System.Drawing.Size(98, 33)
        Me.rdngreen.TabIndex = 2
        Me.rdngreen.TabStop = True
        Me.rdngreen.Text = "Green"
        Me.rdngreen.UseVisualStyleBackColor = True
        '
        'rdnblue
        '
        Me.rdnblue.AutoSize = True
        Me.rdnblue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdnblue.Location = New System.Drawing.Point(579, 336)
        Me.rdnblue.Name = "rdnblue"
        Me.rdnblue.Size = New System.Drawing.Size(80, 33)
        Me.rdnblue.TabIndex = 3
        Me.rdnblue.TabStop = True
        Me.rdnblue.Text = "Blue"
        Me.rdnblue.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 409)
        Me.Controls.Add(Me.rdnblue)
        Me.Controls.Add(Me.rdngreen)
        Me.Controls.Add(Me.rdnred)
        Me.Controls.Add(Me.pnlPanel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Radio buttons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlPanel1 As Panel
    Friend WithEvents rdnred As RadioButton
    Friend WithEvents rdngreen As RadioButton
    Friend WithEvents rdnblue As RadioButton
End Class
