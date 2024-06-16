Imports MySql.Data.MySqlClient
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms
Imports System.Windows.Forms.LinkLabel
Public Class Registros
    Dim registrarse As String
    Private Sub wbRegistro_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub


    Private Async Sub Form4_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Realizar la inicialización asincrónica después de que el formulario esté visible
        Try
            Await conexion.InitializeWebView2(wbRegistro, "https://haxballuruguay.forosactivos.net")

            If juez = True Then
                btnCrear.Visible = True
            End If
            If registrar = 10 Then


                wbRegistro.CoreWebView2.Navigate("https://haxballuruguay.forosactivos.net/f53-registros-de-jugadores")

            End If



            If registrar = 15 Then

                btnCrear.Visible = False


                '  Try


                conectar.Open()



                Dim cmd21 As New MySqlCommand("SELECT OficialRegistro from Oficial", conectar)
                wbRegistro.CoreWebView2.Navigate(cmd21.ExecuteScalar)
                conectar.Close()


                '  Catch
                'MsgBox("Error, compruebe la conexión")

                'End Try
            End If


        Catch ex As Exception
            ' Manejar excepciones si ocurren durante la inicialización
            MessageBox.Show($"Error al inicializar WebView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = SystemInformation.PrimaryMonitorSize
        Me.Text = ""
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        wbRegistro.SendToBack()



    End Sub

    Private Sub btnListo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListo.Click
        Oficial.Show()
  
        Me.Close()

    End Sub



    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        Try
            conectar.Open()
            registrarse = wbRegistro.CoreWebView2.Source.ToString()
            Dim cmd15 As New MySqlCommand("UPDATE Oficial set OficialRegistro= '" & registrarse & "'", conectar)
            cmd15.ExecuteNonQuery()
            MsgBox("Registro creado con éxito")
            conectar.Close()

        Catch ex As Exception

        End Try
      

    End Sub

    Private Sub btnCrear_Click_1()

    End Sub

    Private Sub btnListo_Click_1()

    End Sub

    Private Sub wbRegistro_DocumentCompleted_2()

    End Sub

    Private Sub wbRegistro_Click()

    End Sub
End Class