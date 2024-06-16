Imports System.Drawing.Printing
Imports System.Reflection
Imports System.Security.Permissions
Imports Microsoft.Web.WebView2.Core
Imports ZstdSharp.Unsafe


Public Class Haxball

    Dim prueba As Integer = 0
    Dim si As Integer = 0
    Dim foro As String = ""
    Dim pedro As Integer = 0

    Private Async Sub Haxball_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        WebBrowser1.Visible = False
        Try
            ' Asegurar que WebView2 esté inicializado
            Await WebBrowser1.EnsureCoreWebView2Async(Nothing)

            ' Suscribirse al evento NavigationCompleted
            AddHandler WebBrowser1.CoreWebView2.NavigationCompleted, AddressOf WebView_NavigationCompleted

            ' Inicializar WebView2 y navegar a la URL
            Await conexion.InitializeWebView2(WebBrowser1, "https://haxballuruguay.forosactivos.net/login")
        Catch ex As Exception
            MessageBox.Show($"Error al inicializar WebView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub WebView_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs)
        Label3.Text = "Listo"
        MsgBox(prueba)
        Try
            ' Obtener el contenido HTML de la página cargada
            Dim htmlContent As String = Await WebBrowser1.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML")

            ' Realizar acciones basadas en el contenido HTML
            If prueba = 0 Then
                If htmlContent.Contains("i_icon_mini_logout") Then
                    MsgBox("me estan cagando")
                    Dim logoutScript As String = "document.getElementById('i_icon_mini_logout').click();"
                    Await WebBrowser1.CoreWebView2.ExecuteScriptAsync(logoutScript)
                    ' Await conexion.InitializeWebView2(WebBrowser1, "https://haxballuruguay.forosactivos.net/login")
                    prueba = 0

                    Button1.Enabled = True

                Else
                    si = 5
                    prueba = 40
                    Button1.Enabled = True
                End If
            ElseIf prueba = 30 Then
                If htmlContent.Contains("i_icon_mini_logout") Then
                    MsgBox("pase por elseif")
                    Dim logoutScript As String = "document.getElementById('i_icon_mini_logout').click();"
                    Await WebBrowser1.CoreWebView2.ExecuteScriptAsync(logoutScript)
                    foro = txtUser.Text
                    prueba = 123123
                    nick = txtUser.Text
                    pass = txtPass.Text

                    Login.txtUser.Text = nick
                    Login.txtPassword.Text = nick

                    MessageBox.Show("Datos correctos")
                    Login.Show()
                    Me.Close()
                    pedro = 1
                Else
                    MessageBox.Show("Datos incorrectos")
                    Await conexion.InitializeWebView2(WebBrowser1, "https://haxballuruguay.forosactivos.net/login")
                    prueba = 0
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Error durante la manipulación del contenido HTML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If si = 5 Then
            ' Ejecutar scripts JavaScript para establecer valores y hacer clic en el botón de login
            Dim script As String = $"document.getElementById('username').value = '{txtUser.Text}';" &
                                   $"document.getElementById('password').value = '{txtPass.Text}';" &
                                   $"document.getElementsByName('login')[0].click();"

            Await WebBrowser1.CoreWebView2.ExecuteScriptAsync(script)
            prueba = 30
            Dim htmlContent As String = Await WebBrowser1.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML")
            Button1.Enabled = False

        End If
    End Sub


    Private Sub WebView2_InitializationCompleted(sender As Object, e As EventArgs)
        ' Una vez que WebView2 está inicializado y listo

    End Sub

    Private Async Sub Haxball_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Realizar la inicialización asincrónica después de que el formulario esté visible
        ' Try
        ' Await WebBrowser1.EnsureCoreWebView2Async(Nothing)
        '  Await conexion.InitializeWebView2(WebBrowser1, "https://haxballuruguay.forosactivos.net/login")

        '   Catch ex As Exception
        '  ' Manejar excepciones si ocurren durante la inicialización
        '   MessageBox.Show($"Error al inicializar WebView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' '  End Try

    End Sub




End Class
