<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignInUpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignInUpForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.startHereLabel = New System.Windows.Forms.Label()
        Me.CreateAnAccountWithUsLabel = New System.Windows.Forms.Label()
        Me.alreadyAMemberLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.firstNameLabel = New System.Windows.Forms.Label()
        Me.lastNameLabel = New System.Windows.Forms.Label()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.phoneNumberLabel = New System.Windows.Forms.Label()
        Me.phoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.confirmPasswordLabel = New System.Windows.Forms.Label()
        Me.confirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 728)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 31.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(188, 555)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 126)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Never Miss" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A Contact"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(54, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(570, 486)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.BackColor = System.Drawing.Color.White
        Me.firstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.firstNameTextBox.Location = New System.Drawing.Point(765, 170)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(369, 27)
        Me.firstNameTextBox.TabIndex = 2
        '
        'startHereLabel
        '
        Me.startHereLabel.AutoSize = True
        Me.startHereLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.startHereLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.startHereLabel.Location = New System.Drawing.Point(739, 26)
        Me.startHereLabel.Name = "startHereLabel"
        Me.startHereLabel.Size = New System.Drawing.Size(86, 23)
        Me.startHereLabel.TabIndex = 8
        Me.startHereLabel.Text = "Start Here"
        '
        'CreateAnAccountWithUsLabel
        '
        Me.CreateAnAccountWithUsLabel.AutoSize = True
        Me.CreateAnAccountWithUsLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CreateAnAccountWithUsLabel.ForeColor = System.Drawing.Color.White
        Me.CreateAnAccountWithUsLabel.Location = New System.Drawing.Point(724, 49)
        Me.CreateAnAccountWithUsLabel.Name = "CreateAnAccountWithUsLabel"
        Me.CreateAnAccountWithUsLabel.Size = New System.Drawing.Size(411, 46)
        Me.CreateAnAccountWithUsLabel.TabIndex = 9
        Me.CreateAnAccountWithUsLabel.Text = "Create an Account with us"
        '
        'alreadyAMemberLabel
        '
        Me.alreadyAMemberLabel.AutoSize = True
        Me.alreadyAMemberLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.alreadyAMemberLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.alreadyAMemberLabel.Location = New System.Drawing.Point(739, 107)
        Me.alreadyAMemberLabel.Name = "alreadyAMemberLabel"
        Me.alreadyAMemberLabel.Size = New System.Drawing.Size(158, 23)
        Me.alreadyAMemberLabel.TabIndex = 10
        Me.alreadyAMemberLabel.Text = "Already a member?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(894, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Log in"
        '
        'firstNameLabel
        '
        Me.firstNameLabel.AutoSize = True
        Me.firstNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.firstNameLabel.Location = New System.Drawing.Point(754, 144)
        Me.firstNameLabel.Name = "firstNameLabel"
        Me.firstNameLabel.Size = New System.Drawing.Size(92, 23)
        Me.firstNameLabel.TabIndex = 12
        Me.firstNameLabel.Text = "First Name"
        '
        'lastNameLabel
        '
        Me.lastNameLabel.AutoSize = True
        Me.lastNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lastNameLabel.Location = New System.Drawing.Point(754, 231)
        Me.lastNameLabel.Name = "lastNameLabel"
        Me.lastNameLabel.Size = New System.Drawing.Size(91, 23)
        Me.lastNameLabel.TabIndex = 14
        Me.lastNameLabel.Text = "Last Name"
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.BackColor = System.Drawing.Color.White
        Me.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lastNameTextBox.Location = New System.Drawing.Point(765, 257)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(369, 27)
        Me.lastNameTextBox.TabIndex = 13
        '
        'phoneNumberLabel
        '
        Me.phoneNumberLabel.AutoSize = True
        Me.phoneNumberLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.phoneNumberLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.phoneNumberLabel.Location = New System.Drawing.Point(755, 329)
        Me.phoneNumberLabel.Name = "phoneNumberLabel"
        Me.phoneNumberLabel.Size = New System.Drawing.Size(102, 23)
        Me.phoneNumberLabel.TabIndex = 16
        Me.phoneNumberLabel.Text = "Phone Book"
        '
        'phoneNumberTextBox
        '
        Me.phoneNumberTextBox.BackColor = System.Drawing.Color.White
        Me.phoneNumberTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.phoneNumberTextBox.Location = New System.Drawing.Point(766, 355)
        Me.phoneNumberTextBox.Name = "phoneNumberTextBox"
        Me.phoneNumberTextBox.Size = New System.Drawing.Size(369, 27)
        Me.phoneNumberTextBox.TabIndex = 15
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.emailLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.emailLabel.Location = New System.Drawing.Point(754, 410)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(51, 23)
        Me.emailLabel.TabIndex = 18
        Me.emailLabel.Text = "Email"
        '
        'emailTextBox
        '
        Me.emailTextBox.BackColor = System.Drawing.Color.White
        Me.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.emailTextBox.Location = New System.Drawing.Point(765, 436)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(369, 27)
        Me.emailTextBox.TabIndex = 17
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.passwordLabel.Location = New System.Drawing.Point(754, 503)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(80, 23)
        Me.passwordLabel.TabIndex = 20
        Me.passwordLabel.Text = "Password"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.BackColor = System.Drawing.Color.White
        Me.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.passwordTextBox.Location = New System.Drawing.Point(765, 529)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(369, 27)
        Me.passwordTextBox.TabIndex = 19
        '
        'confirmPasswordLabel
        '
        Me.confirmPasswordLabel.AutoSize = True
        Me.confirmPasswordLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.confirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.confirmPasswordLabel.Location = New System.Drawing.Point(754, 591)
        Me.confirmPasswordLabel.Name = "confirmPasswordLabel"
        Me.confirmPasswordLabel.Size = New System.Drawing.Size(146, 23)
        Me.confirmPasswordLabel.TabIndex = 22
        Me.confirmPasswordLabel.Text = "Confirm Password"
        '
        'confirmPasswordTextBox
        '
        Me.confirmPasswordTextBox.BackColor = System.Drawing.Color.White
        Me.confirmPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.confirmPasswordTextBox.Location = New System.Drawing.Point(765, 617)
        Me.confirmPasswordTextBox.Name = "confirmPasswordTextBox"
        Me.confirmPasswordTextBox.Size = New System.Drawing.Size(369, 27)
        Me.confirmPasswordTextBox.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.AutoEllipsis = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(884, 668)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 43)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Sign Up"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SignInUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1188, 769)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.confirmPasswordLabel)
        Me.Controls.Add(Me.confirmPasswordTextBox)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.phoneNumberLabel)
        Me.Controls.Add(Me.phoneNumberTextBox)
        Me.Controls.Add(Me.lastNameLabel)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.firstNameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.alreadyAMemberLabel)
        Me.Controls.Add(Me.CreateAnAccountWithUsLabel)
        Me.Controls.Add(Me.startHereLabel)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SignInUpForm"
        Me.Text = "Sign In"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents startHereLabel As Label
    Friend WithEvents CreateAnAccountWithUsLabel As Label
    Friend WithEvents alreadyAMemberLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents firstNameLabel As Label
    Friend WithEvents lastNameLabel As Label
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents phoneNumberLabel As Label
    Friend WithEvents phoneNumberTextBox As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents confirmPasswordLabel As Label
    Friend WithEvents confirmPasswordTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
