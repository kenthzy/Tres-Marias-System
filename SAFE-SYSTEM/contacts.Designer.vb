<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class contacts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(contacts))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnItems = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2TileButton()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPhoneNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.comboBoxType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.comboBoxSex = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btnReset = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btnAddItem = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Guna2ImageButton4 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.DTGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DTGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDashboard.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnDashboard.HoverState.ImageSize = New System.Drawing.Size(55, 55)
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnDashboard.ImageRotate = 0!
        Me.btnDashboard.ImageSize = New System.Drawing.Size(55, 55)
        Me.btnDashboard.Location = New System.Drawing.Point(376, 26)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.PressedState.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnDashboard.Size = New System.Drawing.Size(82, 74)
        Me.btnDashboard.TabIndex = 13
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(55, 55)
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(55, 55)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(56, 31)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(84, 63)
        Me.Guna2ImageButton1.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(333, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 26)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "    Dashboard"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(60, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Billing"
        '
        'btnItems
        '
        Me.btnItems.BackColor = System.Drawing.Color.Transparent
        Me.btnItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnItems.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnItems.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnItems.Image = CType(resources.GetObject("btnItems.Image"), System.Drawing.Image)
        Me.btnItems.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnItems.ImageRotate = 0!
        Me.btnItems.Location = New System.Drawing.Point(208, 37)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.PressedState.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnItems.Size = New System.Drawing.Size(98, 63)
        Me.btnItems.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(203, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 26)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "   Items   "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.btnItems)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Guna2ImageButton1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1502, 154)
        Me.Panel1.TabIndex = 23
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.Goldenrod
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.Black
        Me.btnSearch.Font = New System.Drawing.Font("Rockwell", 10.8!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(1326, 68)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(145, 32)
        Me.btnSearch.TabIndex = 39
        Me.btnSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(767, 68)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search Contact"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(552, 32)
        Me.txtSearch.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(70, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(227, 26)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Contacts of the Shop"
        '
        'txtName
        '
        Me.txtName.AutoRoundedCorners = True
        Me.txtName.BorderColor = System.Drawing.Color.Black
        Me.txtName.BorderRadius = 18
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.Gold
        Me.txtName.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.txtName.Location = New System.Drawing.Point(35, 165)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtName.PlaceholderText = "Name"
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(310, 38)
        Me.txtName.TabIndex = 1
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.AutoRoundedCorners = True
        Me.txtPhoneNo.BorderColor = System.Drawing.Color.Black
        Me.txtPhoneNo.BorderRadius = 18
        Me.txtPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNo.DefaultText = ""
        Me.txtPhoneNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhoneNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhoneNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNo.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtPhoneNo.FocusedState.BorderColor = System.Drawing.Color.Gold
        Me.txtPhoneNo.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txtPhoneNo.ForeColor = System.Drawing.Color.Black
        Me.txtPhoneNo.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.txtPhoneNo.Location = New System.Drawing.Point(35, 221)
        Me.txtPhoneNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNo.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtPhoneNo.PlaceholderText = "Phone Number"
        Me.txtPhoneNo.SelectedText = ""
        Me.txtPhoneNo.Size = New System.Drawing.Size(310, 38)
        Me.txtPhoneNo.TabIndex = 2
        '
        'comboBoxType
        '
        Me.comboBoxType.AutoRoundedCorners = True
        Me.comboBoxType.BackColor = System.Drawing.Color.Transparent
        Me.comboBoxType.BorderRadius = 17
        Me.comboBoxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxType.FillColor = System.Drawing.Color.WhiteSmoke
        Me.comboBoxType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboBoxType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboBoxType.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.comboBoxType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comboBoxType.ItemHeight = 30
        Me.comboBoxType.Items.AddRange(New Object() {"Costumer", "Supplier"})
        Me.comboBoxType.Location = New System.Drawing.Point(36, 284)
        Me.comboBoxType.Name = "comboBoxType"
        Me.comboBoxType.Size = New System.Drawing.Size(309, 36)
        Me.comboBoxType.TabIndex = 3
        '
        'comboBoxSex
        '
        Me.comboBoxSex.AutoRoundedCorners = True
        Me.comboBoxSex.BackColor = System.Drawing.Color.Transparent
        Me.comboBoxSex.BorderRadius = 17
        Me.comboBoxSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxSex.FillColor = System.Drawing.Color.WhiteSmoke
        Me.comboBoxSex.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboBoxSex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboBoxSex.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.comboBoxSex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comboBoxSex.ItemHeight = 30
        Me.comboBoxSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.comboBoxSex.Location = New System.Drawing.Point(36, 348)
        Me.comboBoxSex.Name = "comboBoxSex"
        Me.comboBoxSex.Size = New System.Drawing.Size(300, 36)
        Me.comboBoxSex.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnAddItem)
        Me.Panel2.Controls.Add(Me.Guna2ImageButton4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.comboBoxSex)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.comboBoxType)
        Me.Panel2.Controls.Add(Me.txtPhoneNo)
        Me.Panel2.Location = New System.Drawing.Point(36, 197)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 621)
        Me.Panel2.TabIndex = 31
        '
        'btnDelete
        '
        Me.btnDelete.BorderRadius = 20
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.FillColor = System.Drawing.Color.Red
        Me.btnDelete.FillColor2 = System.Drawing.Color.Black
        Me.btnDelete.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(94, 563)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(180, 41)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete"
        '
        'btnReset
        '
        Me.btnReset.BorderRadius = 20
        Me.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReset.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReset.FillColor = System.Drawing.Color.Navy
        Me.btnReset.FillColor2 = System.Drawing.Color.DeepSkyBlue
        Me.btnReset.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(94, 508)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(180, 41)
        Me.btnReset.TabIndex = 34
        Me.btnReset.Text = "Reset"
        '
        'btnUpdate
        '
        Me.btnUpdate.BorderRadius = 20
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.FillColor = System.Drawing.Color.OrangeRed
        Me.btnUpdate.FillColor2 = System.Drawing.Color.DarkOrange
        Me.btnUpdate.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(91, 455)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(180, 41)
        Me.btnUpdate.TabIndex = 35
        Me.btnUpdate.Text = "Update"
        '
        'btnAddItem
        '
        Me.btnAddItem.BorderRadius = 20
        Me.btnAddItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddItem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddItem.FillColor = System.Drawing.Color.DarkGreen
        Me.btnAddItem.FillColor2 = System.Drawing.Color.Chartreuse
        Me.btnAddItem.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(89, 402)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(180, 41)
        Me.btnAddItem.TabIndex = 36
        Me.btnAddItem.Text = "Add Item"
        '
        'Guna2ImageButton4
        '
        Me.Guna2ImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2ImageButton4.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton4.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton4.Image = CType(resources.GetObject("Guna2ImageButton4.Image"), System.Drawing.Image)
        Me.Guna2ImageButton4.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton4.ImageRotate = 0!
        Me.Guna2ImageButton4.Location = New System.Drawing.Point(134, 27)
        Me.Guna2ImageButton4.Name = "Guna2ImageButton4"
        Me.Guna2ImageButton4.PressedState.ImageSize = New System.Drawing.Size(70, 70)
        Me.Guna2ImageButton4.Size = New System.Drawing.Size(90, 63)
        Me.Guna2ImageButton4.TabIndex = 32
        '
        'DTGV
        '
        Me.DTGV.AllowUserToAddRows = False
        Me.DTGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DTGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DTGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTGV.BackgroundColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DTGV.ColumnHeadersHeight = 35
        Me.DTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.DTGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTGV.Location = New System.Drawing.Point(433, 197)
        Me.DTGV.Name = "DTGV"
        Me.DTGV.ReadOnly = True
        Me.DTGV.RowHeadersVisible = False
        Me.DTGV.RowHeadersWidth = 51
        Me.DTGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DTGV.RowTemplate.Height = 24
        Me.DTGV.Size = New System.Drawing.Size(1037, 621)
        Me.DTGV.TabIndex = 39
        Me.DTGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DTGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DTGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DTGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DTGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DTGV.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.DTGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DTGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DTGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DTGV.ThemeStyle.HeaderStyle.Height = 35
        Me.DTGV.ThemeStyle.ReadOnly = True
        Me.DTGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DTGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DTGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DTGV.ThemeStyle.RowsStyle.Height = 24
        Me.DTGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'contacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1497, 842)
        Me.Controls.Add(Me.DTGV)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "contacts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "contacts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DTGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnItems As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhoneNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents comboBoxType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents comboBoxSex As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DTGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2ImageButton4 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btnAddItem As Guna.UI2.WinForms.Guna2GradientTileButton
End Class
