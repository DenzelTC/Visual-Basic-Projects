<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.chkAccounts = New System.Windows.Forms.CheckBox()
        Me.chkCommerce = New System.Windows.Forms.CheckBox()
        Me.chkEnglish = New System.Windows.Forms.CheckBox()
        Me.chkGeography = New System.Windows.Forms.CheckBox()
        Me.chkHistory = New System.Windows.Forms.CheckBox()
        Me.chkMathematics = New System.Windows.Forms.CheckBox()
        Me.chkScience = New System.Windows.Forms.CheckBox()
        Me.chkShona = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Times New Roman", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(171, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(267, 25)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Complete The Form Below"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(20, 57)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(90, 19)
        Me.lblID.TabIndex = 14
        Me.lblID.Text = "ID Number:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(376, 127)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(89, 19)
        Me.lblName.TabIndex = 56
        Me.lblName.Text = "First Name:"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(20, 127)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(92, 19)
        Me.lblSurname.TabIndex = 34
        Me.lblSurname.Text = "Last Name: "
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(20, 199)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(64, 19)
        Me.lblGender.TabIndex = 44
        Me.lblGender.Text = "Gender:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 22)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Select Subjects You Wish To Take(3 Max)"
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(580, 495)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(150, 35)
        Me.btnConfirm.TabIndex = 13
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.Location = New System.Drawing.Point(86, 224)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(63, 23)
        Me.radMale.TabIndex = 3
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.Location = New System.Drawing.Point(207, 224)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(76, 23)
        Me.radFemale.TabIndex = 4
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(24, 79)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(125, 26)
        Me.txtID.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(380, 149)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(350, 26)
        Me.txtName.TabIndex = 2
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(24, 149)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(350, 26)
        Me.txtSurname.TabIndex = 1
        '
        'chkAccounts
        '
        Me.chkAccounts.AutoSize = True
        Me.chkAccounts.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAccounts.Location = New System.Drawing.Point(24, 332)
        Me.chkAccounts.Name = "chkAccounts"
        Me.chkAccounts.Size = New System.Drawing.Size(89, 23)
        Me.chkAccounts.TabIndex = 5
        Me.chkAccounts.Text = "Accounts"
        Me.chkAccounts.UseVisualStyleBackColor = True
        '
        'chkCommerce
        '
        Me.chkCommerce.AutoSize = True
        Me.chkCommerce.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCommerce.Location = New System.Drawing.Point(167, 332)
        Me.chkCommerce.Name = "chkCommerce"
        Me.chkCommerce.Size = New System.Drawing.Size(100, 23)
        Me.chkCommerce.TabIndex = 6
        Me.chkCommerce.Text = "Commerce"
        Me.chkCommerce.UseVisualStyleBackColor = True
        '
        'chkEnglish
        '
        Me.chkEnglish.AutoSize = True
        Me.chkEnglish.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnglish.Location = New System.Drawing.Point(318, 332)
        Me.chkEnglish.Name = "chkEnglish"
        Me.chkEnglish.Size = New System.Drawing.Size(77, 23)
        Me.chkEnglish.TabIndex = 7
        Me.chkEnglish.Text = "English"
        Me.chkEnglish.UseVisualStyleBackColor = True
        '
        'chkGeography
        '
        Me.chkGeography.AutoSize = True
        Me.chkGeography.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGeography.Location = New System.Drawing.Point(469, 332)
        Me.chkGeography.Name = "chkGeography"
        Me.chkGeography.Size = New System.Drawing.Size(102, 23)
        Me.chkGeography.TabIndex = 8
        Me.chkGeography.Text = "Geography"
        Me.chkGeography.UseVisualStyleBackColor = True
        '
        'chkHistory
        '
        Me.chkHistory.AutoSize = True
        Me.chkHistory.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHistory.Location = New System.Drawing.Point(24, 402)
        Me.chkHistory.Name = "chkHistory"
        Me.chkHistory.Size = New System.Drawing.Size(78, 23)
        Me.chkHistory.TabIndex = 9
        Me.chkHistory.Text = "History"
        Me.chkHistory.UseVisualStyleBackColor = True
        '
        'chkMathematics
        '
        Me.chkMathematics.AutoSize = True
        Me.chkMathematics.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMathematics.Location = New System.Drawing.Point(167, 402)
        Me.chkMathematics.Name = "chkMathematics"
        Me.chkMathematics.Size = New System.Drawing.Size(116, 23)
        Me.chkMathematics.TabIndex = 10
        Me.chkMathematics.Text = "Mathematics"
        Me.chkMathematics.UseVisualStyleBackColor = True
        '
        'chkScience
        '
        Me.chkScience.AutoSize = True
        Me.chkScience.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScience.Location = New System.Drawing.Point(318, 402)
        Me.chkScience.Name = "chkScience"
        Me.chkScience.Size = New System.Drawing.Size(79, 23)
        Me.chkScience.TabIndex = 11
        Me.chkScience.Text = "Science"
        Me.chkScience.UseVisualStyleBackColor = True
        '
        'chkShona
        '
        Me.chkShona.AutoSize = True
        Me.chkShona.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShona.Location = New System.Drawing.Point(469, 402)
        Me.chkShona.Name = "chkShona"
        Me.chkShona.Size = New System.Drawing.Size(69, 23)
        Me.chkShona.TabIndex = 12
        Me.chkShona.Text = "Shona"
        Me.chkShona.UseVisualStyleBackColor = True
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(762, 542)
        Me.Controls.Add(Me.chkShona)
        Me.Controls.Add(Me.chkScience)
        Me.Controls.Add(Me.chkMathematics)
        Me.Controls.Add(Me.chkHistory)
        Me.Controls.Add(Me.chkGeography)
        Me.Controls.Add(Me.chkEnglish)
        Me.Controls.Add(Me.chkCommerce)
        Me.Controls.Add(Me.chkAccounts)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.radFemale)
        Me.Controls.Add(Me.radMale)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents chkAccounts As CheckBox
    Friend WithEvents chkCommerce As CheckBox
    Friend WithEvents chkEnglish As CheckBox
    Friend WithEvents chkGeography As CheckBox
    Friend WithEvents chkHistory As CheckBox
    Friend WithEvents chkMathematics As CheckBox
    Friend WithEvents chkScience As CheckBox
    Friend WithEvents chkShona As CheckBox
End Class
