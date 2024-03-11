<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxNewPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.txtPassAd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(380, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(91, 89)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(28, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "INVENTORY SYSTEM"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 38)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "TRES MARIAS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtbxConfirmPass
        '
        Me.txtbxConfirmPass.BorderColor = System.Drawing.Color.Black
        Me.txtbxConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxConfirmPass.DefaultText = ""
        Me.txtbxConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxConfirmPass.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtbxConfirmPass.FocusedState.BorderColor = System.Drawing.Color.Gold
        Me.txtbxConfirmPass.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txtbxConfirmPass.ForeColor = System.Drawing.Color.Black
        Me.txtbxConfirmPass.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.txtbxConfirmPass.Location = New System.Drawing.Point(89, 339)
        Me.txtbxConfirmPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbxConfirmPass.Name = "txtbxConfirmPass"
        Me.txtbxConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtbxConfirmPass.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbxConfirmPass.PlaceholderText = "Confirm Password"
        Me.txtbxConfirmPass.SelectedText = ""
        Me.txtbxConfirmPass.Size = New System.Drawing.Size(314, 38)
        Me.txtbxConfirmPass.TabIndex = 3
        '
        'txtbxusername
        '
        Me.txtbxusername.BorderColor = System.Drawing.Color.Black
        Me.txtbxusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxusername.DefaultText = ""
        Me.txtbxusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxusername.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtbxusername.FocusedState.BorderColor = System.Drawing.Color.Gold
        Me.txtbxusername.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txtbxusername.ForeColor = System.Drawing.Color.Black
        Me.txtbxusername.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.txtbxusername.Location = New System.Drawing.Point(90, 233)
        Me.txtbxusername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbxusername.Name = "txtbxusername"
        Me.txtbxusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxusername.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbxusername.PlaceholderText = "Username"
        Me.txtbxusername.SelectedText = ""
        Me.txtbxusername.Size = New System.Drawing.Size(314, 38)
        Me.txtbxusername.TabIndex = 1
        '
        'txtbxNewPass
        '
        Me.txtbxNewPass.BorderColor = System.Drawing.Color.Black
        Me.txtbxNewPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxNewPass.DefaultText = ""
        Me.txtbxNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxNewPass.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtbxNewPass.FocusedState.BorderColor = System.Drawing.Color.Gold
        Me.txtbxNewPass.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txtbxNewPass.ForeColor = System.Drawing.Color.Black
        Me.txtbxNewPass.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.txtbxNewPass.Location = New System.Drawing.Point(89, 285)
        Me.txtbxNewPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbxNewPass.Name = "txtbxNewPass"
        Me.txtbxNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxNewPass.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbxNewPass.PlaceholderText = "New Password"
        Me.txtbxNewPass.SelectedText = ""
        Me.txtbxNewPass.Size = New System.Drawing.Size(314, 38)
        Me.txtbxNewPass.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(171, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Fill up the form"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(107, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(273, 35)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Register New User"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(123, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Ask System Admin For Passowrd"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Gold
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(89, 486)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(314, 37)
        Me.btnRegister.TabIndex = 5
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(4, 681)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(92, 35)
        Me.Guna2ImageButton1.TabIndex = 6
        '
        'txtPassAd
        '
        Me.txtPassAd.BorderColor = System.Drawing.Color.Black
        Me.txtPassAd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassAd.DefaultText = ""
        Me.txtPassAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassAd.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassAd.FocusedState.BorderColor = System.Drawing.Color.Gold
        Me.txtPassAd.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txtPassAd.ForeColor = System.Drawing.Color.Black
        Me.txtPassAd.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.txtPassAd.Location = New System.Drawing.Point(89, 441)
        Me.txtPassAd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassAd.Name = "txtPassAd"
        Me.txtPassAd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassAd.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPassAd.PlaceholderText = "Admin Password"
        Me.txtPassAd.SelectedText = ""
        Me.txtPassAd.Size = New System.Drawing.Size(314, 38)
        Me.txtPassAd.TabIndex = 4
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckedState.BorderColor = System.Drawing.Color.White
        Me.CheckBox1.CheckedState.BorderRadius = 0
        Me.CheckBox1.CheckedState.BorderThickness = 0
        Me.CheckBox1.CheckedState.FillColor = System.Drawing.Color.Gold
        Me.CheckBox1.CheckMarkColor = System.Drawing.Color.Black
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Bold)
        Me.CheckBox1.Location = New System.Drawing.Point(378, 451)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 30
        Me.CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.White
        Me.CheckBox1.UncheckedState.BorderRadius = 0
        Me.CheckBox1.UncheckedState.BorderThickness = 0
        Me.CheckBox1.UncheckedState.FillColor = System.Drawing.Color.Gold
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(495, 728)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtPassAd)
        Me.Controls.Add(Me.Guna2ImageButton1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbxConfirmPass)
        Me.Controls.Add(Me.txtbxNewPass)
        Me.Controls.Add(Me.txtbxusername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "register"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxNewPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents txtPassAd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
End Class
