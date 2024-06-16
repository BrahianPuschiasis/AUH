Imports MySql.Data.MySqlClient
Public Class Teams

    Private Sub Teams_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conectar.Open()

            Dim cmd As New MySqlCommand("SELECT TeamTag  from Team", conectar)

            dr = cmd.ExecuteReader()


            cmbTeam.Items.Clear()

            While dr.Read
                cmbTeam.Items.Add(dr("TeamTag"))

            End While


            conectar.Close()

        Catch

            MsgBox("Imposible establecer conexión, intente nuevamente")
        End Try
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        MenuPrincipal.Show()
        Me.Close()
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

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim Variable As String = DGV.Item(0, DGV.CurrentRow.Index).Value
        txtJugador.Text = Variable

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        Try
            conectar.Open()
            Dim cmd15 As New MySqlCommand("UPDATE Usuarios set UsuarioTeam= '" & cmbTeam.Text & "' where UsuarioJugador= '" & txtJugador.Text & "'", conectar)
            cmd15.ExecuteNonQuery()
            MsgBox("Team modificado")
            conectar.Close()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnMenu_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class