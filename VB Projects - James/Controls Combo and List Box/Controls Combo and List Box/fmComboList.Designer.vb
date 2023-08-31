<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmComboList
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
        Me.cboAllSubjects = New System.Windows.Forms.ComboBox()
        Me.lblAll = New System.Windows.Forms.Label()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lstSelectedSubjects = New System.Windows.Forms.ListBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboAllSubjects
        '
        Me.cboAllSubjects.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAllSubjects.FormattingEnabled = True
        Me.cboAllSubjects.Items.AddRange(New Object() {"Accounts", "Commerce", "English", "Geography", "History", "Mathematics", "Science", "Shona"})
        Me.cboAllSubjects.Location = New System.Drawing.Point(63, 156)
        Me.cboAllSubjects.Name = "cboAllSubjects"
        Me.cboAllSubjects.Size = New System.Drawing.Size(146, 30)
        Me.cboAllSubjects.TabIndex = 0
        '
        'lblAll
        '
        Me.lblAll.AutoSize = True
        Me.lblAll.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAll.Location = New System.Drawing.Point(59, 122)
        Me.lblAll.Name = "lblAll"
        Me.lblAll.Size = New System.Drawing.Size(107, 22)
        Me.lblAll.TabIndex = 1
        Me.lblAll.Text = "All Subjects"
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelected.Location = New System.Drawing.Point(483, 122)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(152, 22)
        Me.lblSelected.TabIndex = 2
        Me.lblSelected.Text = "Selected Subjects"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(110, 21)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(433, 22)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "Use The Dropdown Below To Choose Your Subjects"
        '
        'lstSelectedSubjects
        '
        Me.lstSelectedSubjects.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSelectedSubjects.FormattingEnabled = True
        Me.lstSelectedSubjects.ItemHeight = 19
        Me.lstSelectedSubjects.Location = New System.Drawing.Point(487, 156)
        Me.lstSelectedSubjects.Name = "lstSelectedSubjects"
        Me.lstSelectedSubjects.Size = New System.Drawing.Size(161, 194)
        Me.lstSelectedSubjects.TabIndex = 4
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(295, 156)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(104, 38)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'fmComboList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 431)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lstSelectedSubjects)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.lblAll)
        Me.Controls.Add(Me.cboAllSubjects)
        Me.Name = "fmComboList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject Selection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboAllSubjects As ComboBox
    Friend WithEvents lblAll As Label
    Friend WithEvents lblSelected As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lstSelectedSubjects As ListBox
    Friend WithEvents btnSelect As Button
End Class
