Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        'Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        btnRegistrar.Visible = True
        btnRegistro.Visible = False
        Try
            conectar.Open()


            Dim cmd As New MySqlCommand("SELECT TeamNombre  from Team", conectar)

            dr = cmd.ExecuteReader()


            cmbTeam.Items.Clear()

            While dr.Read
                cmbTeam.Items.Add(dr("TeamNombre"))
                'MsgBox(cmbTeam.Text)
            End While


            conectar.Close()



        Catch

            MsgBox("Imposible establecer conexión, intente nuevamente")
        End Try
    End Sub

    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



       
    End Sub

    Private Sub txtMac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
       

    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnConectar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  btnRegistrar.Visible = False
        '  btnRegistro.Visible = True
        panel.Visible = True
    End Sub

    Private Sub btnRegistro_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnConectar_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        If txtPassword.Text = "" Or txtUser.Text = "" Then
            MsgBox("No puede dejar datos sin completar")
        Else

            Try
                conectar.Open()
                Dim pass As String
                Dim user As String


                Dim cmd2 As New MySqlCommand("SELECT UsuarioNombre from Usuarios where UsuarioNombre = '" & txtUser.Text & "'", conectar)
                user = cmd2.ExecuteScalar

                Dim cmd3 As New MySqlCommand("SELECT UsuarioContraseña from Usuarios where UsuarioContraseña = '" & txtPassword.Text & "'", conectar)
                pass = cmd3.ExecuteScalar



                Dim cmd4 As New MySqlCommand("SELECT UsuarioJugador from Usuarios where UsuarioNombre = '" & txtUser.Text & "'", conectar)
                jugador = cmd4.ExecuteScalar


                Dim cmd5 As New MySqlCommand("SELECT UsuarioTeam from Usuarios where UsuarioNombre = '" & txtUser.Text & "'", conectar)
                team = cmd5.ExecuteScalar



                ' Dim cmd6 As New MySqlCommand("SELECT TeamTag from Team where TeamID = '" & team & "'", conectar)
                ' teamm = cmd6.ExecuteScalar




                If user = txtUser.Text And pass = txtPassword.Text Then


                    Dim cmd78 As New MySqlCommand("SELECT Usuario from Administrador where Usuario = '" & jugador & "'", conectar)
                    If cmd78.ExecuteScalar <> "" Then
                        administrador = True
                    End If


                    Dim cmd7 As New MySqlCommand("SELECT OficialHost from Oficial where OficialHost = '" & jugador & "'", conectar)




                    MsgBox("Bienvenido  " & jugador & " del team " & team & "")


                    If cmd7.ExecuteScalar <> "" Then
                        host = True
                        MsgBox("¡Recuerde que es host del partido a disputar!")
                    End If

                    Dim cmd8 As New MySqlCommand("SELECT OficialArbitro from Oficial where OficialArbitro = '" & jugador & "'", conectar)


                    If cmd8.ExecuteScalar <> "" Then
                        juez = True
                        MsgBox("¡Recuerde que es arbitro del partido a disputar!")
                    End If
                    MenuPrincipal.Show()
                    Me.Hide()

                Else
                    MsgBox("Datos incorrectos")
                End If


                conectar.Close()
            Catch ex As System.Exception
                MsgBox($"Error inesperado: {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub btnRegistro_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnRegistrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnRegistro_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistro.Click
        btnRegistrar.Visible = True
        btnRegistro.Visible = False
        panel.Visible = True


        Haxball.Show()

    End Sub

    Private Sub btnRegistrar_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim colNetAdapters, objWMIService As Object

        Dim strComputer As String
        Dim _Message As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient

        txtJugador.Text = foro



        strComputer = "."

        objWMIService = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")

        colNetAdapters = objWMIService.ExecQuery("Select * from Win32_NetworkAdapterConfiguration where IPEnabled=TRUE")





        For Each objitem In colNetAdapters


            txtMac.Text = objitem.MACAddress
            mac = txtMac.Text



        Next





        If txtPassword.Text = "" Or txtUser.Text = "" Then
            MsgBox("No puede dejar datos sin completar")
        Else

            Try
                Dim autonumerico As Integer
                conectar.Open()

                Dim pass As String
                Dim user As String
                pass = txtPassword.Text

                Dim cmd2 As New MySqlCommand("SELECT count(*) from Usuarios", conectar)

                autonumerico = cmd2.ExecuteScalar
                autonumerico = autonumerico + 1

                Dim team As String
                Dim cmd3 As New MySqlCommand("SELECT TeamTag from Team where TeamNombre = '" & cmbTeam.Text & "'", conectar)
                team = cmd3.ExecuteScalar

                Dim cmd As New MySqlCommand("INSERT INTO `Usuarios` (UsuarioMAC,UsuarioID,UsuarioTeam,UsuarioNombre,UsuarioContraseña,UsuarioJugador,UsuarioEstado) VALUES ('" & mac & "'," & autonumerico & ",'" & team & "','" & nick & "','" & pass & "','" & nick & "','Habilitado')", conectar)
                cmd.ExecuteNonQuery()

                MsgBox("¡Registro completado con éxito!")


                conectar.Close()

            Catch ex As Exception
                MsgBox("Ocurrió un error al procesar la página: " & ex.Message)


                Dim cmd3 As New MySqlCommand("SELECT UsuarioMAC from Usuarios where UsuarioNombre='Brahian'")
                Dim juan As String
                juan = cmd3.ExecuteScalar

                MsgBox("No se puede registrar mas de una vez por persona")


            End Try


        End If
    End Sub

    Private Sub txtPassword_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then

            If txtPassword.Text = "" Or txtUser.Text = "" Then
                MsgBox("No puede dejar datos sin completar")
            Else

                Try
                    conectar.Open()
                    Dim pass As String
                    Dim user As String


                    Dim cmd2 As New MySqlCommand("SELECT UsuarioNombre from Usuarios where UsuarioNombre = '" & txtUser.Text & "'", conectar)
                    user = cmd2.ExecuteScalar

                    Dim cmd3 As New MySqlCommand("SELECT UsuarioContraseña from Usuarios where UsuarioContraseña = '" & txtPassword.Text & "'", conectar)
                    pass = cmd3.ExecuteScalar



                    Dim cmd4 As New MySqlCommand("SELECT UsuarioJugador from Usuarios where UsuarioNombre = '" & txtUser.Text & "'", conectar)
                    jugador = cmd4.ExecuteScalar


                    Dim cmd5 As New MySqlCommand("SELECT UsuarioTeam from Usuarios where UsuarioNombre = '" & txtUser.Text & "'", conectar)
                    team = cmd5.ExecuteScalar



                    Dim cmd6 As New MySqlCommand("SELECT TeamTag from Team where TeamID = '" & team & "'", conectar)
                    teamm = cmd6.ExecuteScalar




                    If user = txtUser.Text And pass = txtPassword.Text Then


                        Dim cmd78 As New MySqlCommand("SELECT Usuario from Administrador where Usuario = '" & jugador & "'", conectar)
                        If cmd78.ExecuteScalar <> "" Then
                            administrador = True
                        End If


                        Dim cmd7 As New MySqlCommand("SELECT OficialHost from Oficial where OficialHost = '" & jugador & "'", conectar)




                        MsgBox("Bienvenido  " & jugador & " del team " & team & "")

                        If cmd7.ExecuteScalar <> "" Then
                            host = True
                            MsgBox("¡Recuerde que es host del partido a disputar!")
                        End If

                        Dim cmd8 As New MySqlCommand("SELECT OficialArbitro from Oficial where OficialArbitro = '" & jugador & "'", conectar)


                        If cmd8.ExecuteScalar <> "" Then
                            juez = True
                            MsgBox("¡Recuerde que es arbitro del partido a disputar!")
                        End If


                        MenuPrincipal.Show()
                        Me.Hide()
                    Else
                        MsgBox("Datos incorrectos")
                    End If


                    conectar.Close()
                Catch ex As System.Exception
                    MsgBox($"Error inesperado: {ex.Message}")
                End Try
            End If

        End If
    End Sub

    Private Sub txtPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.LostFocus

    End Sub

    Private Sub txtPassword_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Login_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtUser.Enabled = false
        txtPassword.Enabled = False

        btnRegistrar.Visible = False
        btnRegistro.Visible = True

        Dim colNetAdapters, objWMIService As Object

        Dim strComputer As String
        Dim _Message As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient





        strComputer = "."

        objWMIService = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & strComputer & "\root\cimv2")

        colNetAdapters = objWMIService.ExecQuery("Select * from Win32_NetworkAdapterConfiguration where IPEnabled=TRUE")





        For Each objitem In colNetAdapters


            txtMac.Text = objitem.MACAddress

            mac = txtMac.Text



        Next
        conectar.Open()


        Dim cmd111 As New MySqlCommand("SELECT Version from Version", conectar)
        If cmd111.ExecuteScalar = "2.0" Then






            Dim cmd6 As New MySqlCommand("SELECT UsuarioMAC from Usuarios where UsuarioMAC = '" & txtMac.Text & "'", conectar)

            If cmd6.ExecuteScalar <> "" Then



                Dim cmd4 As New MySqlCommand("SELECT UsuarioJugador from Usuarios where UsuarioMAC = '" & txtMac.Text & "'", conectar)
                jugador = cmd4.ExecuteScalar


                Dim cmd5 As New MySqlCommand("SELECT UsuarioTeam from Usuarios where UsuarioMAC = '" & txtMac.Text & "'", conectar)
                team = cmd5.ExecuteScalar

                Dim cmd78 As New MySqlCommand("SELECT Usuario from Administrador where Usuario = '" & jugador & "'", conectar)
                If cmd78.ExecuteScalar <> "" Then
                    administrador = True
                End If


                Dim cmd7 As New MySqlCommand("SELECT OficialHost from Oficial where OficialHost = '" & jugador & "'", conectar)




                MsgBox("Bienvenido  " & jugador & " del team " & team & "")

                If cmd7.ExecuteScalar <> "" Then
                    host = True
                    MsgBox("¡Recuerde que es host del partido a disputar!")
                End If

                Dim cmd8 As New MySqlCommand("SELECT OficialArbitro from Oficial where OficialArbitro = '" & jugador & "'", conectar)


                If cmd8.ExecuteScalar <> "" Then
                    juez = True
                    MsgBox("¡Recuerde que es arbitro del partido a disputar!")


                End If



                autologin = True
                MenuPrincipal.Show()
                Me.Close()


            End If
        Else
            MsgBox("Debe actualizar la versión, consulte el foro, usted tiene la versión 1.5 y la actual es " & cmd111.ExecuteScalar & "")
            Me.Close()
        End If
        conectar.Close()



    End Sub

    Private Sub btnRegistro_Click_4()

    End Sub

    Private Sub btnConectar_Click_3()

    End Sub
End Class