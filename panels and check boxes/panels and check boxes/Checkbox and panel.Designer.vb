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
        Me.chared = New System.Windows.Forms.CheckBox()
        Me.chagreen = New System.Windows.Forms.CheckBox()
        Me.chablue = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'pnlPanel1
        '
        Me.pnlPanel1.BackColor = System.Drawing.Color.White
        Me.pnlPanel1.Location = New System.Drawing.Point(55, 28)
        Me.pnlPanel1.Name = "pnlPanel1"
        Me.pnlPanel1.Size = New System.Drawing.Size(571, 257)
        Me.pnlPanel1.TabIndex = 0
        '
        'chared
        '
        Me.chared.AutoSize = True
        Me.chared.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chared.ForeColor = System.Drawing.Color.Red
        Me.chared.Location = New System.Drawing.Point(55, 339)
        Me.chared.Name = "chared"
        Me.chared.Size = New System.Drawing.Size(80, 33)
        Me.chared.TabIndex = 0
        Me.chared.Text = "Red"
        Me.chared.UseVisualStyleBackColor = True
        '
        'chagreen
        '
        Me.chagreen.AutoSize = True
        Me.chagreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chagreen.ForeColor = System.Drawing.Color.Lime
        Me.chagreen.Location = New System.Drawing.Point(278, 339)
        Me.chagreen.Name = "chagreen"
        Me.chagreen.Size = New System.Drawing.Size(104, 33)
        Me.chagreen.TabIndex = 1
        Me.chagreen.Text = "Green"
        Me.chagreen.UseVisualStyleBackColor = True
        '
        'chablue
        '
        Me.chablue.AutoSize = True
        Me.chablue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chablue.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.chablue.Location = New System.Drawing.Point(535, 339)
        Me.chablue.Name = "chablue"
        Me.chablue.Size = New System.Drawing.Size(85, 33)
        Me.chablue.TabIndex = 2
        Me.chablue.Text = "Blue"
        Me.chablue.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 412)
        Me.Controls.Add(Me.chablue)
        Me.Controls.Add(Me.chagreen)
        Me.Controls.Add(Me.chared)
        Me.Controls.Add(Me.pnlPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Checkboxes and panels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlPanel1 As Panel
    Friend WithEvents chared As CheckBox
    Friend WithEvents chagreen As CheckBox
    Friend WithEvents chablue As CheckBox
End Class
