<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVars
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
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblComplete = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblOuput = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAccept
        '
        Me.btnAccept.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.Location = New System.Drawing.Point(319, 331)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(124, 41)
        Me.btnAccept.TabIndex = 0
        Me.btnAccept.Text = "Proceed"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(57, 84)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(78, 23)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(180, 84)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(245, 30)
        Me.txtName.TabIndex = 0
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(57, 140)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(59, 23)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "Age :"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(180, 137)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(245, 30)
        Me.txtAge.TabIndex = 1
        '
        'lblComplete
        '
        Me.lblComplete.AutoSize = True
        Me.lblComplete.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplete.Location = New System.Drawing.Point(163, 31)
        Me.lblComplete.Name = "lblComplete"
        Me.lblComplete.Size = New System.Drawing.Size(223, 23)
        Me.lblComplete.TabIndex = 5
        Me.lblComplete.Text = "Please Fill In The Forn"
        Me.lblComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(666, 148)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(37, 19)
        Me.lblOutput.TabIndex = 6
        Me.lblOutput.Text = "----"
        '
        'lblOuput
        '
        Me.lblOuput.AutoSize = True
        Me.lblOuput.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOuput.Location = New System.Drawing.Point(526, 84)
        Me.lblOuput.Name = "lblOuput"
        Me.lblOuput.Size = New System.Drawing.Size(261, 19)
        Me.lblOuput.TabIndex = 7
        Me.lblOuput.Text = "This is what has been retrived:"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(57, 194)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(102, 23)
        Me.lblPass.TabIndex = 8
        Me.lblPass.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(180, 194)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 30)
        Me.TextBox1.TabIndex = 9
        '
        'frmVars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(877, 465)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblOuput)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblComplete)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnAccept)
        Me.Name = "frmVars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Working With Variables"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAccept As Button
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblComplete As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblOuput As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents TextBox1 As TextBox
End Class
