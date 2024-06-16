Imports MySql.Data.MySqlClient
Public Class AdmOf

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        Try
            conectar.Open()

            Dim cmd55 As New MySqlCommand("UPDATE Oficial set OficialLocal='" & txtLocal.Text & "', OficialVisitante='" & txtVisitante.Text & "', OficialArbitro='" & txtArbitro.Text & "', OficialHost='" & txtHost.Text & "'", conectar)
            cmd55.ExecuteNonQuery()
            MsgBox("Partido creado con éxito")
            conectar.Close()
        Catch
            MsgBox("Error, compruebe la conexión a internet")
        End Try

    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        MenuPrincipal.Show()
        Me.Close()

    End Sub

    Private Sub AdmOf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

    End Sub

    Private Sub btnUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuarios.Click
        DGV.Visible = True
        conectar.Open()


        Dim cmd As New MySqlCommand("select UsuarioJugador from Usuarios ", conectar)

        Dim dt As New DataTable

        Dim da As New MySqlDataAdapter(cmd)





        da.Fill(dt)

        Me.DGV.DataSource = dt

        conectar.Close()
    End Sub

    Private Sub btnTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeam.Click
        DGV.Visible = True
        conectar.Open()


        Dim cmd As New MySqlCommand("select TeamTag from Team ", conectar)

        Dim dt As New DataTable

        Dim da As New MySqlDataAdapter(cmd)





        da.Fill(dt)

        Me.DGV.DataSource = dt

        conectar.Close()
    End Sub

    Private Sub btnConfirmar_Click_1()

    End Sub
End Class