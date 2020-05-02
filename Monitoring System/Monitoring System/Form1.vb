Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders

Public Class Form1
    Private copter_lat, copter_lon As Double
    Private WithEvents copter_marker As Markers.GMarkerGoogle
    Private WithEvents marker1 As Markers.GMarkerGoogle
    Private WithEvents marker2 As Markers.GMarkerGoogle
    Private WithEvents copter_layer As GMapOverlay
    Private Property points As List(Of PointLatLng)
    Private Property points2 As List(Of PointLatLng)
    Private Property points3 As List(Of PointLatLng)

    Dim lat, longt As String
    Dim lat2, longt2 As String
    Dim Clat, Clongt As Double
    Dim Clat2, Clongt2 As Double

    Dim flag_masuk As Integer
    Dim flag_first As Integer
    Dim flag_terima As Integer
    Dim nilai3 As Double
    Dim nilai_lat As Double
    Dim nilai_long As Double
    Dim nilai_derajat As Double
    Dim user As Double
    Dim s As String
    Dim sp() As String
    Dim sep As String

    Dim Folder As String = Environment.CurrentDirectory + "\\Backup\\"

    Private Sub port_available()
        cmbComPort.Items.Clear()
        For Each port_name As String In IO.Ports.SerialPort.GetPortNames
            Dim myPort As New IO.Ports.SerialPort(port_name)
            cmbComPort.Items.Add(port_name)
            cmbComPort.Text = port_name
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Try
                cmbComPort.Enabled = False
                SerialPort_data.PortName = cmbComPort.Text
                SerialPort_data.Open()
                flag_masuk = 1
            Catch
                MessageBox.Show("Error")
                CheckBox1.Checked = False
            End Try
        Else
            cmbComPort.Enabled = True
            flag_masuk = 0
            If SerialPort_data.IsOpen Then
                SerialPort_data.Close()
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label10.Text = String.Format("{0} {1}.csv", DateTime.Now.ToString("dd MMMM yyy HHmmss"), TextBox1.Text)
        Folder = Folder + Label10.Text
        sep = ","
        flag_terima = 0
        flag_first = 0
        flag_masuk = 0
        copter_lat = -6.9731035
        copter_lon = 107.63258
        myMap.DragButton = Windows.Forms.MouseButtons.Left
        myMap.Position = New PointLatLng(copter_lat, copter_lon)
        myMap.MapProvider = MapProviders.GMapProviders.GoogleMap
        myMap.Manager.Mode = AccessMode.ServerAndCache

        GMapProviders.GoogleMap.ApiKey = ""
        copter_marker = New Markers.GMarkerGoogle(New PointLatLng(copter_lat, copter_lon), Markers.GMarkerGoogleType.green_dot)

        copter_layer = New GMapOverlay()
        myMap.Overlays.Add(copter_layer)
        copter_layer.Markers.Add(copter_marker)
    End Sub

    Private Sub update_map()
        copter_marker.Position = New PointLatLng(copter_lat, copter_lon)
        myMap.UpdateMarkerLocalPosition(copter_marker)
        lblInfo.Text = "Info : Lat= " + CStr(copter_lat) + ", Lon= " + CStr(copter_lon) + ", Zoom Level= " + CStr(myMap.Zoom)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        points = New List(Of PointLatLng)()
        points2 = New List(Of PointLatLng)()
        points3 = New List(Of PointLatLng)()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Timer_jam_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_jam.Tick
        Label12.Text = DateTime.Now.ToString("dd MMM yyy HH:mm:ss")
        If flag_masuk = 1 Then
            If flag_terima = 1 Then
                flag_terima = 0
                copter_lat = nilai_lat
                copter_lon = nilai_long
                nilai3 = nilai_derajat
                update_map()
                warna_putih()

                'Untuk kondisi perbandingan range jalur
                If copter_lon > Clongt2 Or copter_lon < Clongt Then
                    Warning.BackColor = Color.Red
                End If
                If copter_lat > Clat Or copter_lat < Clat2 Then
                    Warning.BackColor = Color.Red
                End If

                'Kondisi untuk merubah tampilan arah mata angin
                If nilai3 >= 24 And nilai3 <= 67 Then
                        northeast.BackColor = Color.ForestGreen
                    End If
                    If nilai3 >= 68 And nilai3 <= 112 Then
                        east.BackColor = Color.ForestGreen
                    End If
                    If nilai3 >= 113 And nilai3 <= 155 Then
                        southeast.BackColor = Color.ForestGreen
                    End If
                    If nilai3 >= 156 And nilai3 <= 206 Then
                        south.BackColor = Color.ForestGreen
                    End If
                    If nilai3 >= 207 And nilai3 <= 247 Then
                        southwest.BackColor = Color.ForestGreen
                    End If
                    If nilai3 >= 248 And nilai3 <= 292 Then
                        west.BackColor = Color.ForestGreen
                    End If
                    If nilai3 >= 293 And nilai3 <= 337 Then
                        northwest.BackColor = Color.ForestGreen
                    End If
                    If (nilai3 >= 338 And nilai3 <= 360) Or (nilai3 >= 1 And nilai3 <= 23) Then
                        north.BackColor = Color.ForestGreen
                    End If

                    If flag_first = 0 Then
                        flag_first = 1
                        RichTextBox1.AppendText("Waktu" + sep + "User" + sep + "Lattitude" + sep + "Longitude" + "Degree" + vbNewLine)
                    End If

                    Call isi_list_view()
                    Call isi_rich_text()
                    RichTextBox1.SaveFile(Folder, RichTextBoxStreamType.PlainText)

                End If
            End If
    End Sub

    Private Sub warna_putih()
        northeast.BackColor = Color.White
        east.BackColor = Color.White
        southeast.BackColor = Color.White
        south.BackColor = Color.White
        southwest.BackColor = Color.White
        west.BackColor = Color.White
        northwest.BackColor = Color.White
        north.BackColor = Color.White
        Warning.BackColor = Color.White
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SaveFileDialog1.Filter = "csv files (*.csv)|*.csv"
        SaveFileDialog1.FileName = String.Format("{0} {1}.csv", DateTime.Now.ToString("dd MMMM yyy HHmmss"), TextBox1.Text)
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK And SaveFileDialog1.FileName.Length > 0 Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Sub isi_list_view()
        Dim lvi As New ListViewItem(DateTime.Now.ToString("dd MMM yyy HH.mm.ss"))
        lvi.SubItems.Add(user)
        lvi.SubItems.Add(nilai_lat)
        lvi.SubItems.Add(nilai_long)
        lvi.SubItems.Add(nilai_derajat)
        ListView1.Items.Add(lvi)
        lvi.Selected = True
        lvi.EnsureVisible()
        lvi = Nothing
    End Sub

    Sub isi_rich_text()
        RichTextBox1.AppendText(DateTime.Now.ToString("dd MMM yyy HH.mm.ss") + sep + user.ToString() + sep + nilai_lat.ToString() + sep + nilai_long.ToString() + sep + nilai_derajat.ToString() + vbNewLine)
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub SerialPort_data_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort_data.DataReceived
        Dim str As String
        str = SerialPort_data.ReadLine()
        s = str
        sp = s.Split(",")
        user = Val(sp(0))
        nilai_lat = Val(sp(1))
        nilai_long = Val(sp(2))
        nilai_derajat = Val(sp(3))
        flag_terima = 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("Aplikasi akan ditutup?", "Caution", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Activate()
        ElseIf result = DialogResult.Yes Then
            If SerialPort_data.IsOpen Then
                SerialPort_data.Close()
            End If
            Application.Exit()
        End If
    End Sub

    Private Sub cmbComPort_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmbComPort.Click
        port_available()
    End Sub

    Private Sub btnGetRouteInfo_Click(sender As Object, e As EventArgs) Handles btnGetRouteInfo.Click
        Dim route = GoogleMapProvider.Instance.GetRoute(points(0), points(1), False, True, 14)
        Dim r = New GMapRoute(route.Points, "My Route")
        Dim routes = New GMapOverlay("route")
        routes.Routes.Add(r)
        myMap.Overlays.Add(routes)
        r.Stroke.Width = 10
        r.Stroke.Color = Color.ForestGreen
        points2.Add(New PointLatLng(Clat, Clongt))
        points2.Add(New PointLatLng(Clat, Clongt2))
        points2.Add(New PointLatLng(Clat2, Clongt2))
        points2.Add(New PointLatLng(Clat2, Clongt))
        Dim polygon = New GMapPolygon(points2, "MyArea")
        polygon.Stroke.Color = Color.Red
        polygon.Stroke.Width = 1
        polygon.Fill = New SolidBrush(Color.FromArgb(20, Color.Blue))
        Dim polygons = New GMapOverlay("polygons")
        myMap.Overlays.Add(polygons)
        polygons.Polygons.Add(polygon)
    End Sub

    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        points.Clear()
        txtLat.Text = ""
        txtLong.Text = ""
        txtLat2.Text = ""
        txtLong2.Text = ""
        If (myMap.Overlays.Count > 0) Then
            myMap.Overlays.RemoveAt(0)
            myMap.Refresh()
        End If
    End Sub

    Private Sub NewRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecordToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Data akan hilang?", "Caution", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Activate()
        ElseIf result = DialogResult.Yes Then
            If SerialPort_data.IsOpen Then
                SerialPort_data.Close()
            End If
            Application.Restart()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Process.Start(Environment.CurrentDirectory + "\\Backup\\")
    End Sub

    Private Sub btnLoadIntoMap_Click(sender As Object, e As EventArgs) Handles btnLoadIntoMap.Click
        myMap.MapProvider = MapProviders.GMapProviders.GoogleMap
        lat = txtLat.Text
        longt = txtLong.Text
        lat2 = txtLat2.Text
        longt2 = txtLong2.Text
        Clat = CDbl(Val(lat))
        Clongt = CDbl(Val(longt))
        Clat2 = CDbl(Val(lat2))
        Clongt2 = CDbl(Val(longt2))
        myMap.MinZoom = 5
        myMap.MaxZoom = 20
        myMap.Zoom = 17
        myMap.Position = New PointLatLng(copter_lat, copter_lon)
        copter_marker = New Markers.GMarkerGoogle(New PointLatLng(copter_lat, copter_lon), Markers.GMarkerGoogleType.green_dot)
        marker1 = New Markers.GMarkerGoogle(New PointLatLng(Clat, Clongt), Markers.GMarkerGoogleType.lightblue_dot)
        marker2 = New Markers.GMarkerGoogle(New PointLatLng(Clat2, Clongt2), Markers.GMarkerGoogleType.lightblue_dot)
        copter_layer = New GMapOverlay()
        myMap.Overlays.Add(copter_layer)
        copter_layer.Markers.Add(copter_marker)
        copter_layer.Markers.Add(copter_marker)
        copter_layer.Markers.Add(marker1)
        copter_layer.Markers.Add(marker2)
    End Sub

    Private Sub btnAddPoint_Click(sender As Object, e As EventArgs) Handles btnAddPoint.Click
        points.Add(New PointLatLng(Clat, Clongt))
        points.Add(New PointLatLng(Clat2, Clongt2))
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'About.Show()
        Dim result As Integer = MessageBox.Show("Aplikasi ini dapat menampilkan data dari user, berupa titik koordinat, arah, dan peringatan ketika sudah terlalu jauh dari jalur.", "About")
    End Sub

End Class
