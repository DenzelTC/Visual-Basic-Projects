<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExactAge
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
        Me.dtpAge = New System.Windows.Forms.DateTimePicker()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblExactAge = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpAge
        '
        Me.dtpAge.Location = New System.Drawing.Point(164, 76)
        Me.dtpAge.Name = "dtpAge"
        Me.dtpAge.Size = New System.Drawing.Size(200, 20)
        Me.dtpAge.TabIndex = 0
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(220, 161)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(114, 44)
        Me.btnConfirm.TabIndex = 1
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblExactAge
        '
        Me.lblExactAge.AutoSize = True
        Me.lblExactAge.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExactAge.Location = New System.Drawing.Point(159, 262)
        Me.lblExactAge.Name = "lblExactAge"
        Me.lblExactAge.Size = New System.Drawing.Size(48, 25)
        Me.lblExactAge.TabIndex = 2
        Me.lblExactAge.Text = "----"
        '
        'frmExactAge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 440)
        Me.Controls.Add(Me.lblExactAge)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.dtpAge)
        Me.Name = "frmExactAge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exact Age"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpAge As DateTimePicker
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblExactAge As Label
End Class
