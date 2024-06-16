
Imports System.Threading.Tasks
Imports Microsoft.Web.WebView2.WinForms
Imports Microsoft.Web.WebView2.Core
Imports MySql.Data.MySqlClient
Public Module conexion
    Public teamm As String
    Public autologin As Boolean
    Public foro As String
    Public mac As String
    Public administrador As Boolean = False
    Public team As String
    Public dr As MySqlDataReader
    Public registrar As Integer
    Public registro As Integer
    Public arbitro As Integer
    Public jugadoroficial As Boolean
    Public locale As String
    Public visitantee As String
    Public jugador As String
    Public email As String
    Public cambiar As Integer
    Public nick As String
    Public pass As String
    'Public conectar As New MySqlConnection("server=sql4.freemysqlhosting.net;user=sql435371;password=hZ6!bQ9%;database=sql435371;port=3306")
    Public conectar As New MySqlConnection("Server=localhost;Port=3306;Database=auh;Uid=root;Pwd=asease22")
    Public juez As Boolean = False
    Public host As Boolean = False

    Public Async Function InitializeWebView2(wb As WebView2, url As String) As Task
        Try
            ' Inicializa el entorno de WebView2
            Await wb.EnsureCoreWebView2Async(Nothing)

            ' Navega a la URL deseada
            wb.CoreWebView2.Navigate(url)
        Catch ex As Exception
            ' Manejar cualquier excepción aquí
            MessageBox.Show($"Error al inicializar WebView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


End Module
