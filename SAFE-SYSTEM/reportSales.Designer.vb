<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportSales))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBilling = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnContacts = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnItems = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DTGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.btnDeleteData = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.txtbxTableName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dataGridViewTransactionLog = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.dataGridViewHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DTGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dataGridViewTransactionLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridViewHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnBilling)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnContacts)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.btnItems)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1432, 159)
        Me.Panel1.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(79, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(415, 17)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Tables: LoginHistory , SalesTransactions , TransactionLog"
        '
        'btnBilling
        '
        Me.btnBilling.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBilling.BackColor = System.Drawing.Color.Transparent
        Me.btnBilling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBilling.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnBilling.HoverState.ImageSize = New System.Drawing.Size(55, 55)
        Me.btnBilling.Image = CType(resources.GetObject("btnBilling.Image"), System.Drawing.Image)
        Me.btnBilling.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnBilling.ImageRotate = 0!
        Me.btnBilling.ImageSize = New System.Drawing.Size(55, 55)
        Me.btnBilling.Location = New System.Drawing.Point(822, 23)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnBilling.Size = New System.Drawing.Size(84, 63)
        Me.btnBilling.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(827, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 26)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Billing"
        '
        'btnContacts
        '
        Me.btnContacts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContacts.BackColor = System.Drawing.Color.Transparent
        Me.btnContacts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnContacts.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnContacts.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnContacts.Image = CType(resources.GetObject("btnContacts.Image"), System.Drawing.Image)
        Me.btnContacts.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnContacts.ImageRotate = 0!
        Me.btnContacts.Location = New System.Drawing.Point(1116, 23)
        Me.btnContacts.Name = "btnContacts"
        Me.btnContacts.PressedState.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnContacts.Size = New System.Drawing.Size(90, 63)
        Me.btnContacts.TabIndex = 24
        '
        'btnDashboard
        '
        Me.btnDashboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDashboard.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnDashboard.HoverState.ImageSize = New System.Drawing.Size(55, 55)
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnDashboard.ImageRotate = 0!
        Me.btnDashboard.ImageSize = New System.Drawing.Size(55, 55)
        Me.btnDashboard.Location = New System.Drawing.Point(1269, 23)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.PressedState.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnDashboard.Size = New System.Drawing.Size(82, 74)
        Me.btnDashboard.TabIndex = 25
        '
        'btnItems
        '
        Me.btnItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnItems.BackColor = System.Drawing.Color.Transparent
        Me.btnItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnItems.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnItems.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnItems.Image = CType(resources.GetObject("btnItems.Image"), System.Drawing.Image)
        Me.btnItems.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnItems.ImageRotate = 0!
        Me.btnItems.Location = New System.Drawing.Point(964, 23)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.PressedState.ImageSize = New System.Drawing.Size(70, 70)
        Me.btnItems.Size = New System.Drawing.Size(98, 63)
        Me.btnItems.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1236, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 26)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "    Dashboard"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1087, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 26)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "  Contacts"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(946, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 26)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "   Items   "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(77, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(375, 26)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Transaction and Inventory Reports"
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Guna2TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage3)
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(22, 192)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1371, 512)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.Gold
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 1
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.Gold
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DTGV)
        Me.TabPage1.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1183, 504)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sales"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DTGV.ColumnHeadersHeight = 35
        Me.DTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.DTGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DTGV.Location = New System.Drawing.Point(0, -4)
        Me.DTGV.Name = "DTGV"
        Me.DTGV.ReadOnly = True
        Me.DTGV.RowHeadersVisible = False
        Me.DTGV.RowHeadersWidth = 51
        Me.DTGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DTGV.RowTemplate.Height = 24
        Me.DTGV.Size = New System.Drawing.Size(1181, 505)
        Me.DTGV.TabIndex = 40
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dataGridViewTransactionLog)
        Me.TabPage2.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1183, 504)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Inventory"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dataGridViewHistory)
        Me.TabPage3.Font = New System.Drawing.Font("Rockwell", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1183, 504)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Login History"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.AutoRoundedCorners = True
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.BorderRadius = 13
        Me.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRefresh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRefresh.FillColor = System.Drawing.Color.MediumBlue
        Me.btnRefresh.FillColor2 = System.Drawing.Color.DeepSkyBlue
        Me.btnRefresh.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(1069, 717)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(318, 29)
        Me.btnRefresh.TabIndex = 13
        Me.btnRefresh.Text = "Refresh"
        '
        'btnDeleteData
        '
        Me.btnDeleteData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteData.AutoRoundedCorners = True
        Me.btnDeleteData.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteData.BorderRadius = 13
        Me.btnDeleteData.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteData.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteData.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeleteData.FillColor = System.Drawing.Color.Red
        Me.btnDeleteData.FillColor2 = System.Drawing.Color.Crimson
        Me.btnDeleteData.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteData.ForeColor = System.Drawing.Color.White
        Me.btnDeleteData.Location = New System.Drawing.Point(629, 717)
        Me.btnDeleteData.Name = "btnDeleteData"
        Me.btnDeleteData.Size = New System.Drawing.Size(312, 29)
        Me.btnDeleteData.TabIndex = 13
        Me.btnDeleteData.Text = "Clear Data"
        '
        'txtbxTableName
        '
        Me.txtbxTableName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtbxTableName.AutoRoundedCorners = True
        Me.txtbxTableName.BackColor = System.Drawing.Color.Transparent
        Me.txtbxTableName.BorderColor = System.Drawing.Color.Black
        Me.txtbxTableName.BorderRadius = 15
        Me.txtbxTableName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxTableName.DefaultText = ""
        Me.txtbxTableName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxTableName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxTableName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxTableName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxTableName.FillColor = System.Drawing.Color.WhiteSmoke
        Me.txtbxTableName.FocusedState.BorderColor = System.Drawing.Color.Gold
        Me.txtbxTableName.Font = New System.Drawing.Font("Rockwell", 10.2!)
        Me.txtbxTableName.ForeColor = System.Drawing.Color.Black
        Me.txtbxTableName.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.txtbxTableName.Location = New System.Drawing.Point(320, 714)
        Me.txtbxTableName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbxTableName.Name = "txtbxTableName"
        Me.txtbxTableName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbxTableName.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbxTableName.PlaceholderText = "Name of Table"
        Me.txtbxTableName.SelectedText = ""
        Me.txtbxTableName.Size = New System.Drawing.Size(288, 32)
        Me.txtbxTableName.TabIndex = 14
        '
        'dataGridViewTransactionLog
        '
        Me.dataGridViewTransactionLog.AllowUserToAddRows = False
        Me.dataGridViewTransactionLog.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dataGridViewTransactionLog.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridViewTransactionLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridViewTransactionLog.BackgroundColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewTransactionLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataGridViewTransactionLog.ColumnHeadersHeight = 35
        Me.dataGridViewTransactionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewTransactionLog.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataGridViewTransactionLog.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewTransactionLog.Location = New System.Drawing.Point(1, 0)
        Me.dataGridViewTransactionLog.Name = "dataGridViewTransactionLog"
        Me.dataGridViewTransactionLog.ReadOnly = True
        Me.dataGridViewTransactionLog.RowHeadersVisible = False
        Me.dataGridViewTransactionLog.RowHeadersWidth = 51
        Me.dataGridViewTransactionLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGridViewTransactionLog.RowTemplate.Height = 24
        Me.dataGridViewTransactionLog.Size = New System.Drawing.Size(1181, 505)
        Me.dataGridViewTransactionLog.TabIndex = 41
        Me.dataGridViewTransactionLog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dataGridViewTransactionLog.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataGridViewTransactionLog.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataGridViewTransactionLog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataGridViewTransactionLog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataGridViewTransactionLog.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.dataGridViewTransactionLog.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewTransactionLog.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewTransactionLog.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataGridViewTransactionLog.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataGridViewTransactionLog.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dataGridViewTransactionLog.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dataGridViewTransactionLog.ThemeStyle.HeaderStyle.Height = 35
        Me.dataGridViewTransactionLog.ThemeStyle.ReadOnly = True
        Me.dataGridViewTransactionLog.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dataGridViewTransactionLog.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataGridViewTransactionLog.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataGridViewTransactionLog.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dataGridViewTransactionLog.ThemeStyle.RowsStyle.Height = 24
        Me.dataGridViewTransactionLog.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewTransactionLog.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'dataGridViewHistory
        '
        Me.dataGridViewHistory.AllowUserToAddRows = False
        Me.dataGridViewHistory.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.dataGridViewHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dataGridViewHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridViewHistory.BackgroundColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dataGridViewHistory.ColumnHeadersHeight = 35
        Me.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewHistory.DefaultCellStyle = DataGridViewCellStyle9
        Me.dataGridViewHistory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewHistory.Location = New System.Drawing.Point(1, 0)
        Me.dataGridViewHistory.Name = "dataGridViewHistory"
        Me.dataGridViewHistory.ReadOnly = True
        Me.dataGridViewHistory.RowHeadersVisible = False
        Me.dataGridViewHistory.RowHeadersWidth = 51
        Me.dataGridViewHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGridViewHistory.RowTemplate.Height = 24
        Me.dataGridViewHistory.Size = New System.Drawing.Size(1181, 505)
        Me.dataGridViewHistory.TabIndex = 41
        Me.dataGridViewHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dataGridViewHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataGridViewHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataGridViewHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataGridViewHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataGridViewHistory.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.dataGridViewHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataGridViewHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataGridViewHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dataGridViewHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dataGridViewHistory.ThemeStyle.HeaderStyle.Height = 35
        Me.dataGridViewHistory.ThemeStyle.ReadOnly = True
        Me.dataGridViewHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dataGridViewHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataGridViewHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataGridViewHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dataGridViewHistory.ThemeStyle.RowsStyle.Height = 24
        Me.dataGridViewHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataGridViewHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'reportSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1424, 766)
        Me.Controls.Add(Me.txtbxTableName)
        Me.Controls.Add(Me.btnDeleteData)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "reportSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reportSales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DTGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dataGridViewTransactionLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridViewHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBilling As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label3 As Label
    Friend WithEvents btnContacts As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnItems As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DTGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents btnDeleteData As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents txtbxTableName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dataGridViewTransactionLog As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents dataGridViewHistory As Guna.UI2.WinForms.Guna2DataGridView
End Class
