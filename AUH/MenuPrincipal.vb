Imports System.IO
Imports MySql.Data.MySqlClient
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms

Public Class MenuPrincipal
    Dim amistoso As Boolean = False

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mostrar el formulario de inmediato
        Me.Show()
        wbForo.SendToBack()

        ' Configurar visibilidad inicial del control WebView
        wbForo.Visible = False
        Login.Visible = False
        Me.TopMost = False

        ' Si el usuario es administrador, habilitar un ToolStripMenuItem
        If administrador Then
            ToolStripMenuItem1.Visible = True
            ToolStripMenuItem1.Enabled = True
        End If
    End Sub

    Private Async Sub Form2_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Realizar la inicialización asincrónica después de que el formulario esté visible
        Try
            Await conexion.InitializeWebView2(wbForo, "https://haxballuruguay.forosactivos.net")
        Catch ex As Exception
            ' Manejar excepciones si ocurren durante la inicialización
            MessageBox.Show($"Error al inicializar WebView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub AsdToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsdToolStripMenuItem.Click
        'Try
        conectar.Open()
        Dim local As String
        Dim visitante As String

        Dim cmd5 As New MySqlCommand("SELECT UsuarioTeam from Usuarios where UsuarioMAC = '" & mac & "'", conectar)
        team = cmd5.ExecuteScalar

        Dim cmd787 As New MySqlCommand("SELECT UsuarioJugador from Usuarios where UsuarioMAC = '" & mac & "'", conectar)

        jugador = cmd787.ExecuteScalar


        Dim cmd77 As New MySqlCommand("SELECT OficialHost from Oficial where OficialHost = '" & jugador & "'", conectar)

        If cmd77.ExecuteScalar <> "" Then
            host = True
        Else
            host = False
        End If



        Dim cmd8 As New MySqlCommand("SELECT OficialArbitro from Oficial where OficialArbitro = '" & jugador & "'", conectar)
        If cmd8.ExecuteScalar <> "" Then
            juez = True
        Else
            juez = False
        End If



        Dim cmd6 As New MySqlCommand("SELECT OficialLocal from Oficial where OficialLocal = '" & team & "'", conectar)
        local = cmd6.ExecuteScalar

        Dim cmd7 As New MySqlCommand("SELECT OficialVisitante from Oficial where OficialVisitante = '" & team & "'", conectar)
        visitante = cmd7.ExecuteScalar


        If local <> "" Or visitante <> "" Then
            conectar.Close()
            jugadoroficial = True
            Oficial.Show()
            Me.Close()

        Else
            If host Or juez = True Then
                conectar.Close()
                jugadoroficial = False
                Oficial.Show()
                Me.Close()
            Else
                jugadoroficial = False
                MsgBox("Usted no pertenece a los equipos que disputan el oficial")
                conectar.Close()
            End If
        End If


        ' Catch

        '    MsgBox("Error, compruebe la conexión")
        'End Try

    End Sub

    Private Sub ForoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForoToolStripMenuItem.Click
        wbForo.Visible = True
        txtLink.Visible = False
        btnCerrarRoom.Visible = False
        btnEliminar.Visible = False
        DG1.Visible = False
        btnBuscar.Visible = False
        wbForo.CoreWebView2.Navigate("https://haxballuruguay.forosactivos.net/forum")
        Me.TopMost = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub wbForo_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        If amistoso = True Then


        End If
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub TVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TVToolStripMenuItem.Click
        wbForo.Visible = True
        txtLink.Visible = False
        btnCerrarRoom.Visible = False
        wbForo.CoreWebView2.Navigate("http://www.twitch.tv/1comander")
        Me.TopMost = False
        btnEliminar.Visible = False
        DG1.Visible = False
        btnBuscar.Visible = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AToolStripMenuItem.Click
        wbForo.Visible = True
        txtLink.Visible = False
        btnCerrarRoom.Visible = False
        DG1.Visible = False
        btnEliminar.Visible = False
        wbForo.CoreWebView2.Navigate("https://haxballuruguay.forosactivos.net/t14541-fechas-y-horarios-fecha-n01-torneo-apertura")
        Me.TopMost = False
        btnBuscar.Visible = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BToolStripMenuItem.Click
        wbForo.Visible = True
        txtLink.Visible = False
        btnEliminar.Visible = False
        btnBuscar.Visible = False
        DG1.Visible = False
        btnCerrarRoom.Visible = False
        wbForo.CoreWebView2.Navigate("https://haxballuruguay.forosactivos.net/t14541-fechas-y-horarios-fecha-n01-torneo-apertura")
        Me.TopMost = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CToolStripMenuItem.Click

    End Sub

    Private Sub FixtureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FixtureToolStripMenuItem.Click

    End Sub

    Private Sub AperturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AperturaToolStripMenuItem.Click
        wbForo.Visible = True
        txtLink.Visible = False
        DG1.Visible = False
        btnCerrarRoom.Visible = False
        wbForo.CoreWebView2.Navigate("https://haxballuruguay.forosactivos.net/t14541-fechas-y-horarios-fecha-n01-torneo-apertura")
        Me.TopMost = False
        btnEliminar.Visible = False
        btnBuscar.Visible = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ClausuraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClausuraToolStripMenuItem.Click
        wbForo.Visible = True
        txtLink.Visible = False
        DG1.Visible = False
        btnEliminar.Visible = False
        btnCerrarRoom.Visible = False
        wbForo.CoreWebView2.Navigate("https://haxballuruguay.forosactivos.net/t14541-fechas-y-horarios-fecha-n01-torneo-apertura")
        Me.TopMost = False
        btnBuscar.Visible = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AnualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnualToolStripMenuItem.Click
        wbForo.Visible = True
        txtLink.Visible = False
        btnBuscar.Visible = False
        btnCerrarRoom.Visible = False
        btnEliminar.Visible = False
        DG1.Visible = False
        wbForo.CoreWebView2.Navigate("https://haxballuruguay.forosactivos.net/t14541-fechas-y-horarios-fecha-n01-torneo-apertura")
        Me.TopMost = False
        Me.WindowState = FormWindowState.Maximized
    End Sub



    Private Sub OficialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OficialesToolStripMenuItem.Click
        AdmOf.Show()
        Me.Close()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        MsgBox(" Codificador: Brahian Puschiasis " & vbNewLine & " Diseñador: Jona Ojeda " & vbNewLine & " Testers: Nacho Hernandez, Ezequiel Moreira ")
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AmistososToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmistososToolStripMenuItem.Click
        wbForo.Visible = True
        amistoso = True
        btnBuscar.Visible = True
        wbForo.CoreWebView2.Navigate("https://www.haxball.com/")
        Me.TopMost = False
        Me.WindowState = FormWindowState.Maximized
        txtLink.Visible = True
        btnCerrarRoom.Visible = False
    End Sub

    Private Sub txtLink_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLink.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                conectar.Open()
                Dim cmd15 As New MySqlCommand("INSERT INTO `Amistosos` (AmistosoTeam,AmistosoLink,AmistosoEstado,AmistosoHost) VALUES ('" & team & "','" & txtLink.Text & "','Abierto','" & jugador & "')", conectar)
                cmd15.ExecuteNonQuery()
                MsgBox("Amistoso creado con éxito")
                conectar.Close()
                txtLink.Enabled = False
                btnCerrarRoom.Visible = True
                btnEliminar.Visible = True
            Catch
                MsgBox("Solo se permite un host por team")
            End Try
        End If
    End Sub

    Private Sub txtLink_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLink.TextChanged

    End Sub

    Private Sub btnCerrarRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        conectar.Open()
        Dim cmd15 As New MySqlCommand("DELETE from Amistosos where AmistosoTeam = '" & team & "'", conectar)
        cmd15.ExecuteNonQuery()
        MsgBox("Amistoso Eliminado")
        btnEliminar.Visible = False
        txtLink.Enabled = True
        txtLink.Visible = True
        btnCerrarRoom.Visible = False
        btnCerrarRoom.Text = "Cerrar"
        conectar.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click


        If btnBuscar.Text = "Buscar" Then
            DG1.Visible = True
            btnBuscar.Text = "Cerrar"
            conectar.Open()

            Dim cmd As New MySqlCommand("select AmistosoTeam,AmistosoHost,AmistosoEstado from Amistosos ", conectar)

            Dim dt As New DataTable

            Dim da As New MySqlDataAdapter(cmd)





            da.Fill(dt)

            Me.DG1.DataSource = dt

            conectar.Close()
        Else
            btnBuscar.Text = "Buscar"
            DG1.Visible = False
        End If
    End Sub

    Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick
        Dim Variable As String = DG1.Item(0, DG1.CurrentRow.Index).Value
        Dim estado As String = DG1.Item(2, DG1.CurrentRow.Index).Value
        Dim resp As String
        If estado = "Abierto" Then

            resp = MsgBox("¿Desea entrar al room de " & Variable & "?", MsgBoxStyle.YesNo, "AUH")
            If resp = vbYes Then
                conectar.Open()

                DG1.Visible = False
                Dim cmd As New MySqlCommand("select AmistosoLink from Amistosos where AmistosoTeam = '" & Variable & "'", conectar)
                wbForo.CoreWebView2.Navigate(cmd.ExecuteScalar)
                amistoso = True
                conectar.Close()

            Else

            End If
        Else
            MsgBox("El room se encuentra cerrado, porfavor espere a que se abra")

        End If

    End Sub

    Private Sub AsdToolStripMenuItem_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles AsdToolStripMenuItem.MouseUp

    End Sub

    Private Sub btnCerrarRoom_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    
    End Sub

    Private Sub btnCerrarRoom_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarRoom.Click
        If btnCerrarRoom.Text = "Cerrar" Then
            conectar.Open()

            Dim cmd15 As New MySqlCommand("UPDATE Amistosos set AmistosoEstado= 'Cerrado' where AmistosoTeam = '" & team & "'", conectar)
            cmd15.ExecuteNonQuery()
            MsgBox("Amistoso Cerrado")
            btnCerrarRoom.Text = "Abrir"
            conectar.Close()
        Else
            conectar.Open()

            Dim cmd15 As New MySqlCommand("UPDATE Amistosos set AmistosoEstado= 'Abierto' where AmistosoTeam = '" & team & "'", conectar)
            cmd15.ExecuteNonQuery()
            MsgBox("Amistoso Abierto")
            btnCerrarRoom.Text = "Cerrar"
            conectar.Close()
        End If
    End Sub

    Private Sub TeamsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeamsToolStripMenuItem.Click
        Teams.Show()
        Me.Close()

    End Sub

    Private Sub wbForo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wbForo.Click

    End Sub

    Private Sub TVToolStripMenuItem_Click_1()

    End Sub

    Private Sub ForoToolStripMenuItem_Click_1()

    End Sub

    Private Sub btnBuscar_Click_1()

    End Sub

    Private Sub wbForo_Click_1()

    End Sub

    Private Sub CerrarToolStripMenuItem_Click_1()

    End Sub
End Class