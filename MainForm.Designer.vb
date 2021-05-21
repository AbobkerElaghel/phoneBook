<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.phoneBooksGrid = New System.Windows.Forms.DataGridView()
        Me.welcomeLabel = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.phoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.editIcon = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.firstNameLabel = New System.Windows.Forms.Label()
        Me.lastNameLabel = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.phoneNumberLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.phoneBooksGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.phoneBooksGrid)
        Me.Panel1.Controls.Add(Me.welcomeLabel)
        Me.Panel1.Controls.Add(Me.addButton)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 694)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Phone Books"
        '
        'phoneBooksGrid
        '
        Me.phoneBooksGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.phoneBooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.phoneBooksGrid.GridColor = System.Drawing.Color.White
        Me.phoneBooksGrid.Location = New System.Drawing.Point(12, 65)
        Me.phoneBooksGrid.Name = "phoneBooksGrid"
        Me.phoneBooksGrid.RowHeadersWidth = 51
        Me.phoneBooksGrid.RowTemplate.Height = 29
        Me.phoneBooksGrid.Size = New System.Drawing.Size(663, 615)
        Me.phoneBooksGrid.TabIndex = 3
        '
        'welcomeLabel
        '
        Me.welcomeLabel.AutoSize = True
        Me.welcomeLabel.Location = New System.Drawing.Point(12, 11)
        Me.welcomeLabel.Name = "welcomeLabel"
        Me.welcomeLabel.Size = New System.Drawing.Size(75, 20)
        Me.welcomeLabel.TabIndex = 2
        Me.welcomeLabel.Text = "Welcome "
        '
        'addButton
        '
        Me.addButton.Image = CType(resources.GetObject("addButton.Image"), System.Drawing.Image)
        Me.addButton.Location = New System.Drawing.Point(629, 11)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(46, 48)
        Me.addButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addButton.TabIndex = 1
        Me.addButton.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-40, -69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(300, 188)
        Me.DataGridView1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(721, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(510, 327)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.firstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.firstNameTextBox.Location = New System.Drawing.Point(794, 427)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.ReadOnly = True
        Me.firstNameTextBox.Size = New System.Drawing.Size(162, 27)
        Me.firstNameTextBox.TabIndex = 3
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lastNameTextBox.Location = New System.Drawing.Point(1009, 427)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.ReadOnly = True
        Me.lastNameTextBox.Size = New System.Drawing.Size(162, 27)
        Me.lastNameTextBox.TabIndex = 4
        '
        'phoneNumberTextBox
        '
        Me.phoneNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.phoneNumberTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.phoneNumberTextBox.Location = New System.Drawing.Point(905, 513)
        Me.phoneNumberTextBox.Name = "phoneNumberTextBox"
        Me.phoneNumberTextBox.ReadOnly = True
        Me.phoneNumberTextBox.Size = New System.Drawing.Size(162, 27)
        Me.phoneNumberTextBox.TabIndex = 5
        '
        'emailTextBox
        '
        Me.emailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.emailTextBox.Location = New System.Drawing.Point(905, 611)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.ReadOnly = True
        Me.emailTextBox.Size = New System.Drawing.Size(162, 27)
        Me.emailTextBox.TabIndex = 6
        '
        'editIcon
        '
        Me.editIcon.Image = Global.PhoneBook.My.Resources.Resources.outline_edit_white_24dp
        Me.editIcon.Location = New System.Drawing.Point(1201, 345)
        Me.editIcon.Name = "editIcon"
        Me.editIcon.Size = New System.Drawing.Size(30, 28)
        Me.editIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.editIcon.TabIndex = 7
        Me.editIcon.TabStop = False
        Me.editIcon.WaitOnLoad = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1160, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Edit"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PhoneBook.My.Resources.Resources._0c3b3adb1a7530892e55ef36d3be6cb8
        Me.PictureBox2.Location = New System.Drawing.Point(923, 277)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(117, 114)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'firstNameLabel
        '
        Me.firstNameLabel.AutoSize = True
        Me.firstNameLabel.Location = New System.Drawing.Point(794, 404)
        Me.firstNameLabel.Name = "firstNameLabel"
        Me.firstNameLabel.Size = New System.Drawing.Size(80, 20)
        Me.firstNameLabel.TabIndex = 10
        Me.firstNameLabel.Text = "First Name"
        '
        'lastNameLabel
        '
        Me.lastNameLabel.AutoSize = True
        Me.lastNameLabel.Location = New System.Drawing.Point(1009, 404)
        Me.lastNameLabel.Name = "lastNameLabel"
        Me.lastNameLabel.Size = New System.Drawing.Size(79, 20)
        Me.lastNameLabel.TabIndex = 11
        Me.lastNameLabel.Text = "Last Name"
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Location = New System.Drawing.Point(905, 490)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(108, 20)
        Me.emailLabel.TabIndex = 12
        Me.emailLabel.Text = "Phone Number"
        '
        'phoneNumberLabel
        '
        Me.phoneNumberLabel.AutoSize = True
        Me.phoneNumberLabel.Location = New System.Drawing.Point(905, 588)
        Me.phoneNumberLabel.Name = "phoneNumberLabel"
        Me.phoneNumberLabel.Size = New System.Drawing.Size(46, 20)
        Me.phoneNumberLabel.TabIndex = 13
        Me.phoneNumberLabel.Text = "Email"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1243, 718)
        Me.Controls.Add(Me.phoneNumberLabel)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.lastNameLabel)
        Me.Controls.Add(Me.firstNameLabel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.editIcon)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.phoneNumberTextBox)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.phoneBooksGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents addButton As PictureBox
    Friend WithEvents welcomeLabel As Label
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents phoneBooksGrid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents phoneNumberTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents editIcon As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents firstNameLabel As Label
    Friend WithEvents lastNameLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents phoneNumberLabel As Label
End Class
