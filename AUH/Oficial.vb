Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports Microsoft.Web.WebView2.Core
Imports System.Net
Imports Microsoft.Web.WebView2.WinForms
'Imports Skybound.Gecko


Public Class Oficial
    Dim switch As Boolean = False
    Dim switch2 As Boolean = False


    '  Public Sub New()

    '   InitializeComponent()


    '
    '  End Sub

    Private Async Sub Form3_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        wbHaxball.SendToBack()

        Try
            ' Inicialización asincrónica del WebView2 después de que el formulario esté visible
            Await conexion.InitializeWebView2(wbHaxball, "https://haxball.com")

            ' Lógica para la navegación del WebView2 basada en las variables host y juez
            If host And juez Then
                ' Navegar a la URL inicial para hosts y jueces
                wbHaxball.CoreWebView2.Navigate("https://haxball.com")
            ElseIf juez Then
                ' Otro comportamiento de navegación según sea necesario para jueces
                Try
                    conectar.Open()
                    Dim cmd7 As New MySqlCommand("SELECT OficialPartido FROM Oficial", conectar)
                    wbHaxball.CoreWebView2.Navigate(cmd7.ExecuteScalar)
                    conectar.Close()
                Catch ex As Exception
                    MessageBox.Show("Error al cargar la URL para jueces: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            ElseIf host Then
                ' Navegación específica para hosts
                wbHaxball.CoreWebView2.Navigate("https://haxball.com")
            Else
                ' Otros casos según sea necesario
            End If
        Catch ex As Exception
            ' Manejar excepciones si ocurren durante la inicialización del WebView2
            MessageBox.Show($"Error al inicializar WebView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conectar.Open()

        ' Configuración inicial de los botones y etiquetas
        Dim cmd2 As New MySqlCommand("SELECT OficialLocal FROM Oficial", conectar)
        locale = cmd2.ExecuteScalar
        btnLocal.Text = locale

        Dim cmd3 As New MySqlCommand("SELECT OficialVisitante FROM Oficial", conectar)
        visitantee = cmd3.ExecuteScalar
        btnVisitante.Text = visitantee

        Dim cmd33 As New MySqlCommand("SELECT TeamCapitan FROM Team WHERE TeamTag = '" & locale & "'", conectar)
        lblLocal.Text = "Capitán: " & cmd33.ExecuteScalar

        Dim cmd333 As New MySqlCommand("SELECT TeamCapitan FROM Team WHERE TeamTag = '" & visitantee & "'", conectar)
        lblVisitante.Text = "Capitán: " & cmd333.ExecuteScalar

        ' Cargar datos para los controles Local y Visitante
        Dim cmd As New MySqlCommand("SELECT UsuarioJugador FROM Usuarios WHERE UsuarioTeam = '" & locale & "'", conectar)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        Me.Local.DataSource = dt

        Dim cmd5 As New MySqlCommand("SELECT UsuarioJugador FROM Usuarios WHERE UsuarioTeam = '" & visitantee & "'", conectar)
        Dim dt5 As New DataTable
        Dim da5 As New MySqlDataAdapter(cmd5)
        da5.Fill(dt5)
        Me.Visitante.DataSource = dt5

        conectar.Close()

        ' Configuración adicional del formulario
        Me.Size = SystemInformation.PrimaryMonitorSize
        Me.Text = ""
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        ' Lógica específica según el estado de las variables host, juez, jugadoroficial
        If host And juez Then
            ' Configurar visibilidad de controles y navegar a la URL inicial
            txtHost.Visible = True
            btnArbitro.Visible = True
            btnTerminado.Visible = True
            btnHacerRegistro.Visible = True
            btnRegistro.Visible = True
        ElseIf juez Then
            btnArbitro.Visible = True
            btnTerminado.Visible = True
            btnHacerRegistro.Visible = True
            ' Otros ajustes según sea necesario para jueces
        ElseIf host Then
            txtHost.Visible = True
            btnRegistro.Visible = False
            btnHacerRegistro.Visible = False
            ' Otros ajustes según sea necesario para hosts
        Else
            ' Configuraciones adicionales para otros casos
        End If

        ' Aquí no incluimos la navegación del WebView2, se manejará en Form3_Shown
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub





    Private Sub Form3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Right) Then Return

    End Sub






    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub wbHaxball_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Right) Then Return
    End Sub

    Private Sub btnRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistro.Click
        registrar = 15
        Registros.Show()
        Me.Hide()
    End Sub

    Private Sub AsdToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnTerminado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub wbHaxball_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
       
    End Sub

    Private Sub btnMenuPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub

    Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Registros.Show()
        registro = 2
        Me.Hide()
    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Registros.Show()
        registro = 3
        Me.Hide()
    End Sub

    Private Sub btnArbitro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     

    End Sub

    Private Sub btnTerminado_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub btnHacerRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHacerRegistro.Click
        registrar = 10
        Registros.Show()

        Me.Hide()


    End Sub



    Private Sub txtHost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHost.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                conectar.Open()
                'Dim cmd15 As New MySqlCommand("UPDATE Oficial set OficialPartido= '" & txtHost.Text & "'", conectar)
                Dim cmd15 As New MySqlCommand("UPDATE Oficial set OficialPartido= '" & txtHost.Text & "'", conectar)
                cmd15.ExecuteNonQuery()
                MsgBox("Partido creado con éxito")
                conectar.Close()
                txtHost.Enabled = False
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub btnVisitante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

   
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Visitante_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Visitante.CellContentClick

    End Sub

    Private Sub Local_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Local.CellContentClick

    End Sub

    Private Sub txtHost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHost.TextChanged

    End Sub

    Private Sub btnLocal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnArbitro_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArbitro.Click
        Me.Size = SystemInformation.PrimaryMonitorSize
        Me.Text = ""
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        ' wbHaxball.Navigate("http://www.haxball.iz.rs/swf/stats/12.swf")
        arbitro = 10
    End Sub

    Private Sub btnTerminado_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminado.Click
        Dim area As Rectangle
        Dim attachment As System.Net.Mail.Attachment
        Dim attachment2 As System.Net.Mail.Attachment
        Dim capture As System.Drawing.Bitmap
        Dim save As New SaveFileDialog
        Dim graph As Graphics
        Dim mail As New MailMessage()
        Dim SmtpServer As New SmtpClient("smtp.gmail.com")


        area = Me.Bounds

        capture = New System.Drawing.Bitmap(Bounds.Width, Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)

        graph = Graphics.FromImage(capture)

        graph.CopyFromScreen(area.X, area.Y, 0, 0, area.Size, CopyPixelOperation.SourceCopy)

        PictureBox2.Image = capture
        '  wb.Visible = False


        Try

            save.Title = "Save File"

            save.FileName = "Partido"

            save.Filter = "Png |*.Png"

            'If save.ShowDialog() = DialogResult.OK Then

            PictureBox2.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png)

            ' End If

        Catch ex As Exception

        End Try


        Dim vs As String
        Dim vs1 As String



        conectar.Open()

        Dim cmd70 As New MySqlCommand("SELECT OficialLocal from Oficial", conectar)
        vs = cmd70.ExecuteScalar

        Dim cmd71 As New MySqlCommand("SELECT OficialVisitante from Oficial", conectar)
        vs1 = cmd71.ExecuteScalar


        Dim vst As String

        vst = vs + " " + "vs" + " " + vs1


        mail.From = New MailAddress("AUHregistros@gmail.com")
        mail.[To].Add("AUHregistros@gmail.com")
        mail.Subject = "Replay: " & vst & ""
        mail.Body = "Replay"


        attachment = New System.Net.Mail.Attachment("Partido")
        attachment2 = New System.Net.Mail.Attachment("replay.hbr")
        mail.Attachments.Add(attachment)
        mail.Attachments.Add(attachment2)

        SmtpServer.Port = 25
        SmtpServer.Credentials = New System.Net.NetworkCredential("AUHregistros@gmail.com", "BrahianAUH")
        SmtpServer.EnableSsl = True
        Try
            SmtpServer.Send(mail)



            Dim cmd55 As New MySqlCommand("UPDATE Oficial set OficialPartido='', OficialRegistro='', OficialLocal='', OficialVisitante='', OficialArbitro='', OficialHost=''", conectar)
            cmd55.ExecuteNonQuery()




            MessageBox.Show("Enviado con éxito")
            conectar.Close()
        Catch
            MsgBox(ErrorToString)
        End Try






    End Sub

    Private Sub btnLocal_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocal.Click
        If Local.Visible = True Then
            Local.Visible = False
            lblLocal.Visible = False


        Else
            Local.Visible = True
            lblLocal.Visible = True
        End If

    End Sub

    Private Sub btnVisitante_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisitante.Click
        If Visitante.Visible = True Then
            Visitante.Visible = False
            lblVisitante.Visible = False

        Else
            lblVisitante.Visible = True
            Visitante.Visible = True
        End If
    End Sub

    Private Sub btnMenuPrincipal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuPrincipal.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub




    'Private Sub GeckoWebBrowser1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wbHaxball.Click
    '
    '  End Sub

    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click
        '  wbHaxball.Refresh()

    End Sub

    Private Sub PictureBox2_Click_1()

    End Sub

    ' Private Sub wbHaxball_Click()

    'End Sub

    Private Sub Visitante_CellContentClick_1()

    End Sub

    Private Sub Oficial_Load()

    End Sub

    Private Sub wbHaxball_Click()

    End Sub
End Class