Public Class Form1
    Dim programtorun As String
    Dim timerinterval As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'center op primary screen
        Me.Left = (Screen.PrimaryScreen.Bounds.Width / 2) - (Me.Width / 2)
        Me.Top = (Screen.PrimaryScreen.Bounds.Height / 2) - (Me.Height / 2)
        Randomize()
        'load config.xml
        If My.Computer.FileSystem.FileExists("config.xml") = False Then
            MsgBox("no config found, creating default", MsgBoxStyle.Information)
            Dim objWriter As New System.IO.StreamWriter("config.xml")
            objWriter.Write("<screenshaver config>" & vbCrLf)
            objWriter.Write("  defaultmode=images" & vbCrLf)
            objWriter.Write("  defaultfolder=" & Environ("USERPROFILE") & "\Pictures" & vbCrLf)
            objWriter.Write("  defaultimagestime=3000" & vbCrLf)
            objWriter.Write("  <urls>" & vbCrLf)
            objWriter.Write("   http://www.flightradar24.com/50.96,5.28/13" & vbCrLf)
            objWriter.Write("   https://mobile.twitter.com/hs_hasselt" & vbCrLf)
            objWriter.Write("   http://www.buienradar.be" & vbCrLf)
            objWriter.Write("   http://buienradar.be/weer/hasselt/be/2796491#nu" & vbCrLf)
            objWriter.Write("   http://xkcd.com/" & vbCrLf)
            objWriter.Write("   http://www.verkeerscentrum.be/verkeersinfo/camerabeelden/antwerpen" & vbCrLf)
            objWriter.Write("   http://www.meteo.be/meteo/view/nl/65239-Home.html" & vbCrLf)
            objWriter.Write("   http://deredactie.be/cm/vrtnieuws" & vbCrLf)
            objWriter.Write("   http://randomstreetview.com/be" & vbCrLf)
            objWriter.Write("   http://www.haneke.net/" & vbCrLf)
            objWriter.Write("   http://randomcolour.com/" & vbCrLf)
            objWriter.Write("   http://www.chiptune.com/kaleidoscope/" & vbCrLf)
            objWriter.Write("   http://www.chiptune.com/starfield/starfield.html" & vbCrLf)
            objWriter.Write("   http://www.internetlivestats.com/" & vbCrLf)
            objWriter.Write("   http://hisz.rsoe.hu/alertmap/index2.php?area=eu" & vbCrLf)
            objWriter.Write("   http://services.vrt.be/data/weather/img/style_1/1024x576/map_belgie_streken_huidig_dag.png" & vbCrLf)
            objWriter.Write("   http://services.vrt.be/data/weather/img/style_1/1024x576/belgie_streken_volgende_dagen.png" & vbCrLf)

            objWriter.Write("  </urls>" & vbCrLf)
            objWriter.Write("</screenshaver config>" & vbCrLf)
            objWriter.Close()
        End If

        Dim objReader As New System.IO.StreamReader("config.xml")
        Dim lijn As String
        Dim pos1 As Integer
        Do While objReader.Peek() <> -1
            lijn = objReader.ReadLine()
            'get configs
            If InStr(lijn, "defaultmode=", CompareMethod.Text) > 0 Then
                pos1 = InStr(lijn, "=", CompareMethod.Text)
                'determine program to run
                programtorun = Command()
                If programtorun = "" Then
                    programtorun = Mid(lijn, pos1 + 1, (Len(lijn) - pos1))
                End If
                ToolStripStatusLabel1.Text = "Program: " & programtorun
            End If
            If InStr(lijn, "defaultfolder=", CompareMethod.Text) > 0 Then
                'load list
                Dim foldername As String
                pos1 = InStr(lijn, "=", CompareMethod.Text)
                foldername = Mid(lijn, pos1 + 1, (Len(lijn) - pos1))
                If My.Computer.FileSystem.DirectoryExists(foldername) = False Then
                    MsgBox("Default folder name does not exist!", MsgBoxStyle.Critical)
                    End
                Else
                    Dim di As New IO.DirectoryInfo(foldername)
                    Dim diar1 As IO.FileInfo() = di.GetFiles()
                    Dim dra As IO.FileInfo
                    'list the names of all files in the specified directory
                    For Each dra In diar1
                        If ispicture(dra.Name) = True Then
                            lst_files.Items.Add(dra.FullName)
                        End If
                    Next
                End If
            End If
            If InStr(lijn, "defaultimagestime=", CompareMethod.Text) Then
                pos1 = InStr(lijn, "=", CompareMethod.Text)
                timerinterval = Mid(lijn, pos1 + 1, (Len(lijn) - pos1))
            End If
            If InStr(lijn, "<urls>", CompareMethod.Text) Then
                Dim found As Integer
                Do
                    found = 0
                    lijn = objReader.ReadLine()
                    If InStr(lijn, "</urls>", CompareMethod.Text) = 0 Then
                        lst_urls.Items.Add(Trim(lijn))
                        found = 1
                    End If
                Loop Until found = 0
            End If
        Loop



        'run program
        If programtorun = "images" Then
            For Each scr As Screen In Screen.AllScreens
                'MsgBox(scr.DeviceName)
                If scr.Primary = False Then
                    lst_screens.Items.Add(scr.DeviceName)
                    Dim frm As New images
                    frm.StartPosition = FormStartPosition.Manual
                    frm.WindowState = FormWindowState.Maximized
                    frm.Location = scr.Bounds.Location
                    frm.PictureBox1.Left = 0
                    frm.PictureBox1.Width = scr.Bounds.Width
                    frm.PictureBox1.Top = 0
                    frm.PictureBox1.Height = scr.Bounds.Height
                    Dim rndnr As Integer
                    rndnr = Int(Rnd() * lst_files.Items.Count)
                    frm.PictureBox1.Image = Image.FromFile(lst_files.Items.Item(rndnr))
                    frm.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                    frm.tmr_nextimage.Interval = timerinterval
                    frm.Show()
                End If
            Next
        End If

        If programtorun = "websites" Then
            For Each scr As Screen In Screen.AllScreens
                'MsgBox(scr.DeviceName)
                If scr.Primary = False Then
                    lst_screens.Items.Add(scr.DeviceName)
                    Dim frm As New websites
                    frm.StartPosition = FormStartPosition.Manual
                    frm.WindowState = FormWindowState.Maximized
                    frm.Location = scr.Bounds.Location
                    frm.WebBrowser1.ScriptErrorsSuppressed = True
                    Dim rndnr As Integer
                    rndnr = Int(Rnd() * lst_urls.Items.Count)
                    frm.WebBrowser1.Navigate(lst_urls.Items.Item(rndnr))
                    frm.tmr_nexturl.Interval = timerinterval
                    frm.Show()
                End If
            Next
        End If

        If programtorun = "slots" Then
            For Each scr As Screen In Screen.AllScreens
                'MsgBox(scr.DeviceName)

                If scr.Primary = False Then
                    lst_screens.Items.Add(scr.DeviceName)
                    Dim frm As New slots
                    frm.StartPosition = FormStartPosition.Manual
                    frm.WindowState = FormWindowState.Maximized
                    frm.Location = scr.Bounds.Location
                    Dim objWriter As New System.IO.StreamWriter("slots.html")
                    objWriter.Write(My.Resources.fancy.ToString)
                    objWriter.Close()
                    Dim path As String
                    path = Application.ExecutablePath
                    path = Replace(path, Application.ProductName & ".scr", "", 1, -1, CompareMethod.Text)
                    frm.WebBrowser1.Navigate(path & "slots.html")
                    frm.Show()
                End If
            Next
        End If


    End Sub



    Function ispicture(ByVal filename As String)
        If Microsoft.VisualBasic.Right(filename, 3) = "jpg" Then Return True
        If Microsoft.VisualBasic.Right(filename, 3) = "JPG" Then Return True
        If Microsoft.VisualBasic.Right(filename, 3) = "gif" Then Return True
        If Microsoft.VisualBasic.Right(filename, 3) = "GIF" Then Return True
        If Microsoft.VisualBasic.Right(filename, 3) = "png" Then Return True
        If Microsoft.VisualBasic.Right(filename, 3) = "PNG" Then Return True
        If Microsoft.VisualBasic.Right(filename, 4) = "jpeg" Then Return True
        If Microsoft.VisualBasic.Right(filename, 4) = "JPEG" Then Return True
        Return False
    End Function

    Private Sub lst_screens_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_screens.SelectedIndexChanged

    End Sub
End Class
