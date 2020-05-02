<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnLoadIntoMap = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLong2 = New System.Windows.Forms.TextBox()
        Me.txtLat2 = New System.Windows.Forms.TextBox()
        Me.txtLong = New System.Windows.Forms.TextBox()
        Me.txtLat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cmbComPort = New System.Windows.Forms.ComboBox()
        Me.myMap = New GMap.NET.WindowsForms.GMapControl()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.northwest = New System.Windows.Forms.TextBox()
        Me.west = New System.Windows.Forms.TextBox()
        Me.southwest = New System.Windows.Forms.TextBox()
        Me.south = New System.Windows.Forms.TextBox()
        Me.southeast = New System.Windows.Forms.TextBox()
        Me.east = New System.Windows.Forms.TextBox()
        Me.northeast = New System.Windows.Forms.TextBox()
        Me.north = New System.Windows.Forms.TextBox()
        Me.Warning = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer_jam = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort_data = New System.IO.Ports.SerialPort(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnAddPoint = New System.Windows.Forms.Button()
        Me.btnGetRouteInfo = New System.Windows.Forms.Button()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.ForestGreen
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1326, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRecordToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewRecordToolStripMenuItem
        '
        Me.NewRecordToolStripMenuItem.Name = "NewRecordToolStripMenuItem"
        Me.NewRecordToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NewRecordToolStripMenuItem.Text = "New Record"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(1278, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 23)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label12.Location = New System.Drawing.Point(1212, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "20 Juli 2019 20:00:00"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(92, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1172, 78)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Monitoring System Human Track In Forest"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1244, 537)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnClearList)
        Me.GroupBox7.Controls.Add(Me.btnGetRouteInfo)
        Me.GroupBox7.Controls.Add(Me.btnAddPoint)
        Me.GroupBox7.Controls.Add(Me.btnLoadIntoMap)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.txtLong2)
        Me.GroupBox7.Controls.Add(Me.txtLat2)
        Me.GroupBox7.Controls.Add(Me.txtLong)
        Me.GroupBox7.Controls.Add(Me.txtLat)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.Button4)
        Me.GroupBox7.Controls.Add(Me.RichTextBox1)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.Button2)
        Me.GroupBox7.Controls.Add(Me.CheckBox1)
        Me.GroupBox7.Controls.Add(Me.cmbComPort)
        Me.GroupBox7.Controls.Add(Me.myMap)
        Me.GroupBox7.Controls.Add(Me.lblInfo)
        Me.GroupBox7.Controls.Add(Me.northwest)
        Me.GroupBox7.Controls.Add(Me.west)
        Me.GroupBox7.Controls.Add(Me.southwest)
        Me.GroupBox7.Controls.Add(Me.south)
        Me.GroupBox7.Controls.Add(Me.southeast)
        Me.GroupBox7.Controls.Add(Me.east)
        Me.GroupBox7.Controls.Add(Me.northeast)
        Me.GroupBox7.Controls.Add(Me.north)
        Me.GroupBox7.Controls.Add(Me.Warning)
        Me.GroupBox7.Controls.Add(Me.TextBox1)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Location = New System.Drawing.Point(581, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(657, 496)
        Me.GroupBox7.TabIndex = 54
        Me.GroupBox7.TabStop = False
        '
        'btnLoadIntoMap
        '
        Me.btnLoadIntoMap.BackColor = System.Drawing.Color.ForestGreen
        Me.btnLoadIntoMap.ForeColor = System.Drawing.Color.White
        Me.btnLoadIntoMap.Location = New System.Drawing.Point(38, 128)
        Me.btnLoadIntoMap.Name = "btnLoadIntoMap"
        Me.btnLoadIntoMap.Size = New System.Drawing.Size(99, 23)
        Me.btnLoadIntoMap.TabIndex = 90
        Me.btnLoadIntoMap.Text = "Load Into Map"
        Me.btnLoadIntoMap.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label7.Location = New System.Drawing.Point(16, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label6.Location = New System.Drawing.Point(16, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "1"
        '
        'txtLong2
        '
        Me.txtLong2.Location = New System.Drawing.Point(167, 102)
        Me.txtLong2.Name = "txtLong2"
        Me.txtLong2.Size = New System.Drawing.Size(100, 20)
        Me.txtLong2.TabIndex = 87
        '
        'txtLat2
        '
        Me.txtLat2.Location = New System.Drawing.Point(39, 102)
        Me.txtLat2.Name = "txtLat2"
        Me.txtLat2.Size = New System.Drawing.Size(100, 20)
        Me.txtLat2.TabIndex = 86
        '
        'txtLong
        '
        Me.txtLong.Location = New System.Drawing.Point(167, 73)
        Me.txtLong.Name = "txtLong"
        Me.txtLong.Size = New System.Drawing.Size(100, 20)
        Me.txtLong.TabIndex = 85
        '
        'txtLat
        '
        Me.txtLat.Location = New System.Drawing.Point(38, 73)
        Me.txtLat.Name = "txtLat"
        Me.txtLat.Size = New System.Drawing.Size(100, 20)
        Me.txtLat.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label3.Location = New System.Drawing.Point(164, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Longitude"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(36, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Lattitude"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.ForestGreen
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(385, 461)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 24)
        Me.Button4.TabIndex = 64
        Me.Button4.Text = "Buka Folder"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.Location = New System.Drawing.Point(359, 467)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(20, 18)
        Me.RichTextBox1.TabIndex = 57
        Me.RichTextBox1.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label10.Location = New System.Drawing.Point(205, 472)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Difa 20 00 20 Juli 2019"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label9.Location = New System.Drawing.Point(108, 472)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "File (Auto Backup)"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.ForestGreen
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(13, 464)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 24)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Simpan Log Manual"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.ForestGreen
        Me.CheckBox1.Location = New System.Drawing.Point(90, 441)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox1.TabIndex = 82
        Me.CheckBox1.Text = "Start"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cmbComPort
        '
        Me.cmbComPort.BackColor = System.Drawing.Color.ForestGreen
        Me.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbComPort.DropDownWidth = 71
        Me.cmbComPort.FormattingEnabled = True
        Me.cmbComPort.Location = New System.Drawing.Point(13, 438)
        Me.cmbComPort.Name = "cmbComPort"
        Me.cmbComPort.Size = New System.Drawing.Size(71, 21)
        Me.cmbComPort.TabIndex = 81
        '
        'myMap
        '
        Me.myMap.Bearing = 0!
        Me.myMap.CanDragMap = True
        Me.myMap.EmptyTileColor = System.Drawing.Color.Navy
        Me.myMap.GrayScaleMode = False
        Me.myMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.myMap.LevelsKeepInMemmory = 5
        Me.myMap.Location = New System.Drawing.Point(13, 190)
        Me.myMap.MarkersEnabled = True
        Me.myMap.MaxZoom = 2
        Me.myMap.MinZoom = 2
        Me.myMap.MouseWheelZoomEnabled = True
        Me.myMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.myMap.Name = "myMap"
        Me.myMap.NegativeMode = False
        Me.myMap.PolygonsEnabled = True
        Me.myMap.RetryLoadTile = 0
        Me.myMap.RoutesEnabled = True
        Me.myMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.myMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.myMap.ShowTileGridLines = False
        Me.myMap.Size = New System.Drawing.Size(635, 239)
        Me.myMap.TabIndex = 69
        Me.myMap.Zoom = 0R
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblInfo.Location = New System.Drawing.Point(16, 174)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(25, 13)
        Me.lblInfo.TabIndex = 59
        Me.lblInfo.Text = "Info"
        '
        'northwest
        '
        Me.northwest.ForeColor = System.Drawing.SystemColors.Window
        Me.northwest.Location = New System.Drawing.Point(430, 52)
        Me.northwest.Name = "northwest"
        Me.northwest.Size = New System.Drawing.Size(77, 20)
        Me.northwest.TabIndex = 77
        Me.northwest.Text = "NORTHWEST"
        '
        'west
        '
        Me.west.ForeColor = System.Drawing.SystemColors.Window
        Me.west.Location = New System.Drawing.Point(403, 77)
        Me.west.Name = "west"
        Me.west.Size = New System.Drawing.Size(41, 20)
        Me.west.TabIndex = 73
        Me.west.Text = "WEST"
        '
        'southwest
        '
        Me.southwest.ForeColor = System.Drawing.SystemColors.Window
        Me.southwest.Location = New System.Drawing.Point(430, 102)
        Me.southwest.Name = "southwest"
        Me.southwest.Size = New System.Drawing.Size(77, 20)
        Me.southwest.TabIndex = 76
        Me.southwest.Text = "SOUTHWEST"
        '
        'south
        '
        Me.south.ForeColor = System.Drawing.SystemColors.Window
        Me.south.Location = New System.Drawing.Point(498, 128)
        Me.south.Name = "south"
        Me.south.Size = New System.Drawing.Size(46, 20)
        Me.south.TabIndex = 71
        Me.south.Text = "SOUTH"
        '
        'southeast
        '
        Me.southeast.ForeColor = System.Drawing.SystemColors.Window
        Me.southeast.Location = New System.Drawing.Point(540, 102)
        Me.southeast.Name = "southeast"
        Me.southeast.Size = New System.Drawing.Size(74, 20)
        Me.southeast.TabIndex = 75
        Me.southeast.Text = "SOUTHEAST"
        '
        'east
        '
        Me.east.ForeColor = System.Drawing.SystemColors.Window
        Me.east.Location = New System.Drawing.Point(600, 77)
        Me.east.Name = "east"
        Me.east.Size = New System.Drawing.Size(39, 20)
        Me.east.TabIndex = 72
        Me.east.Text = "EAST"
        '
        'northeast
        '
        Me.northeast.ForeColor = System.Drawing.SystemColors.Window
        Me.northeast.Location = New System.Drawing.Point(540, 51)
        Me.northeast.Name = "northeast"
        Me.northeast.Size = New System.Drawing.Size(74, 20)
        Me.northeast.TabIndex = 74
        Me.northeast.Text = "NORTHEAST"
        '
        'north
        '
        Me.north.ForeColor = System.Drawing.Color.White
        Me.north.Location = New System.Drawing.Point(498, 25)
        Me.north.Name = "north"
        Me.north.Size = New System.Drawing.Size(46, 20)
        Me.north.TabIndex = 70
        Me.north.Text = "NORTH"
        '
        'Warning
        '
        Me.Warning.ForeColor = System.Drawing.Color.White
        Me.Warning.Location = New System.Drawing.Point(224, 17)
        Me.Warning.Name = "Warning"
        Me.Warning.Size = New System.Drawing.Size(71, 20)
        Me.Warning.TabIndex = 80
        Me.Warning.Text = "Out Of Track"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.ForestGreen
        Me.TextBox1.Location = New System.Drawing.Point(90, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(60, 26)
        Me.TextBox1.TabIndex = 45
        Me.TextBox1.Text = "Difa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label4.Location = New System.Drawing.Point(495, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Direction"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label5.Location = New System.Drawing.Point(172, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Status : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label13.Location = New System.Drawing.Point(10, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Nama Mesin :"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.ForeColor = System.Drawing.Color.ForestGreen
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(478, 491)
        Me.ListView1.TabIndex = 55
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Waktu"
        Me.ColumnHeader1.Width = 144
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 36
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Latitude"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 81
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Longitude"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Degree"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 75
        '
        'Timer_jam
        '
        Me.Timer_jam.Enabled = True
        '
        'SerialPort_data
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox1.Location = New System.Drawing.Point(19, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 10)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox2.Location = New System.Drawing.Point(19, 100)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 615)
        Me.PictureBox2.TabIndex = 56
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox3.Location = New System.Drawing.Point(26, 705)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1278, 10)
        Me.PictureBox3.TabIndex = 57
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox4.Location = New System.Drawing.Point(1294, 100)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 615)
        Me.PictureBox4.TabIndex = 58
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox5.Location = New System.Drawing.Point(1258, 100)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(46, 10)
        Me.PictureBox5.TabIndex = 59
        Me.PictureBox5.TabStop = False
        '
        'btnAddPoint
        '
        Me.btnAddPoint.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAddPoint.ForeColor = System.Drawing.Color.White
        Me.btnAddPoint.Location = New System.Drawing.Point(167, 131)
        Me.btnAddPoint.Name = "btnAddPoint"
        Me.btnAddPoint.Size = New System.Drawing.Size(89, 20)
        Me.btnAddPoint.TabIndex = 91
        Me.btnAddPoint.Text = "Add Point"
        Me.btnAddPoint.UseVisualStyleBackColor = False
        '
        'btnGetRouteInfo
        '
        Me.btnGetRouteInfo.BackColor = System.Drawing.Color.ForestGreen
        Me.btnGetRouteInfo.ForeColor = System.Drawing.Color.White
        Me.btnGetRouteInfo.Location = New System.Drawing.Point(290, 71)
        Me.btnGetRouteInfo.Name = "btnGetRouteInfo"
        Me.btnGetRouteInfo.Size = New System.Drawing.Size(89, 23)
        Me.btnGetRouteInfo.TabIndex = 92
        Me.btnGetRouteInfo.Text = "Get Route"
        Me.btnGetRouteInfo.UseVisualStyleBackColor = False
        '
        'btnClearList
        '
        Me.btnClearList.BackColor = System.Drawing.Color.ForestGreen
        Me.btnClearList.ForeColor = System.Drawing.Color.White
        Me.btnClearList.Location = New System.Drawing.Point(290, 105)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(89, 20)
        Me.btnClearList.TabIndex = 93
        Me.btnClearList.Text = "Clear"
        Me.btnClearList.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1326, 745)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoring System Human Track In Forest"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Warning As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cmbComPort As ComboBox
    Friend WithEvents myMap As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents lblInfo As Label
    Friend WithEvents northwest As TextBox
    Friend WithEvents west As TextBox
    Friend WithEvents southwest As TextBox
    Friend WithEvents south As TextBox
    Friend WithEvents southeast As TextBox
    Friend WithEvents east As TextBox
    Friend WithEvents northeast As TextBox
    Friend WithEvents north As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer_jam As Timer
    Friend WithEvents SerialPort_data As IO.Ports.SerialPort
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnLoadIntoMap As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLong2 As TextBox
    Friend WithEvents txtLat2 As TextBox
    Friend WithEvents txtLong As TextBox
    Friend WithEvents txtLat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClearList As Button
    Friend WithEvents btnGetRouteInfo As Button
    Friend WithEvents btnAddPoint As Button
End Class
