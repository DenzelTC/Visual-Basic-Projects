<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPicture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPicture))
        Me.picBx1 = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picBx2 = New System.Windows.Forms.PictureBox()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        CType(Me.picBx1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBx2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBx1
        '
        Me.picBx1.Image = CType(resources.GetObject("picBx1.Image"), System.Drawing.Image)
        Me.picBx1.InitialImage = CType(resources.GetObject("picBx1.InitialImage"), System.Drawing.Image)
        Me.picBx1.Location = New System.Drawing.Point(26, 27)
        Me.picBx1.Name = "picBx1"
        Me.picBx1.Size = New System.Drawing.Size(350, 377)
        Me.picBx1.TabIndex = 0
        Me.picBx1.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Lime
        Me.btnNext.Location = New System.Drawing.Point(130, 420)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(90, 50)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'picBx2
        '
        Me.picBx2.Location = New System.Drawing.Point(498, 27)
        Me.picBx2.Name = "picBx2"
        Me.picBx2.Size = New System.Drawing.Size(350, 377)
        Me.picBx2.TabIndex = 2
        Me.picBx2.TabStop = False
        '
        'btnPrev
        '
        Me.btnPrev.Enabled = False
        Me.btnPrev.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.Color.Lime
        Me.btnPrev.Location = New System.Drawing.Point(640, 420)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(90, 50)
        Me.btnPrev.TabIndex = 3
        Me.btnPrev.Text = "<<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblInfo.Location = New System.Drawing.Point(388, 420)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(110, 31)
        Me.lblInfo.TabIndex = 4
        Me.lblInfo.Text = "Pictures"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(879, 512)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.picBx2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.picBx1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPicture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pictures"
        CType(Me.picBx1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBx2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBx1 As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents picBx2 As PictureBox
    Friend WithEvents btnPrev As Button
    Friend WithEvents lblInfo As Label
End Class
