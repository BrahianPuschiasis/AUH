<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Oficial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Oficial))
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnHacerRegistro = New System.Windows.Forms.Button()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.Local = New System.Windows.Forms.DataGridView()
        Me.Visitante = New System.Windows.Forms.DataGridView()
        Me.lblLocal = New System.Windows.Forms.Label()
        Me.lblVisitante = New System.Windows.Forms.Label()
        Me.btnArbitro = New System.Windows.Forms.PictureBox()
        Me.btnTerminado = New System.Windows.Forms.PictureBox()
        Me.btnMenuPrincipal = New System.Windows.Forms.PictureBox()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.btnVisitante = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.wbHaxball = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Local, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visitante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnArbitro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTerminado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenuPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wbHaxball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegistro
        '
        Me.btnRegistro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistro.Image = CType(resources.GetObject("btnRegistro.Image"), System.Drawing.Image)
        Me.btnRegistro.Location = New System.Drawing.Point(343, 356)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(67, 23)
        Me.btnRegistro.TabIndex = 3
        Me.btnRegistro.TabStop = False
        Me.btnRegistro.Text = "Registro"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(73, 282)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        AddHandler Me.PictureBox2.Click, AddressOf Me.PictureBox2_Click_1
        '
        'btnHacerRegistro
        '
        Me.btnHacerRegistro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHacerRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHacerRegistro.Image = CType(resources.GetObject("btnHacerRegistro.Image"), System.Drawing.Image)
        Me.btnHacerRegistro.Location = New System.Drawing.Point(343, 316)
        Me.btnHacerRegistro.Name = "btnHacerRegistro"
        Me.btnHacerRegistro.Size = New System.Drawing.Size(67, 23)
        Me.btnHacerRegistro.TabIndex = 26
        Me.btnHacerRegistro.TabStop = False
        Me.btnHacerRegistro.Text = "RegistroJ"
        Me.btnHacerRegistro.UseVisualStyleBackColor = True
        Me.btnHacerRegistro.Visible = False
        '
        'txtHost
        '
        Me.txtHost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtHost.Location = New System.Drawing.Point(125, 353)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(80, 20)
        Me.txtHost.TabIndex = 27
        Me.txtHost.Text = "Link Room"
        Me.txtHost.Visible = False
        '
        'Local
        '
        Me.Local.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Local.BackgroundColor = System.Drawing.Color.Blue
        Me.Local.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Local.Location = New System.Drawing.Point(277, -3)
        Me.Local.Name = "Local"
        Me.Local.ReadOnly = True
        Me.Local.Size = New System.Drawing.Size(191, 142)
        Me.Local.TabIndex = 28
        Me.Local.Visible = False
        '
        'Visitante
        '
        Me.Visitante.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Visitante.BackgroundColor = System.Drawing.Color.Blue
        Me.Visitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Visitante.Location = New System.Drawing.Point(277, 163)
        Me.Visitante.Name = "Visitante"
        Me.Visitante.ReadOnly = True
        Me.Visitante.Size = New System.Drawing.Size(191, 134)
        Me.Visitante.TabIndex = 29
        Me.Visitante.Visible = False
        AddHandler Me.Visitante.CellContentClick, AddressOf Me.Visitante_CellContentClick_1
        '
        'lblLocal
        '
        Me.lblLocal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLocal.AutoSize = True
        Me.lblLocal.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblLocal.Image = CType(resources.GetObject("lblLocal.Image"), System.Drawing.Image)
        Me.lblLocal.Location = New System.Drawing.Point(340, 142)
        Me.lblLocal.Name = "lblLocal"
        Me.lblLocal.Size = New System.Drawing.Size(46, 13)
        Me.lblLocal.TabIndex = 32
        Me.lblLocal.Text = "Capitan:"
        Me.lblLocal.Visible = False
        '
        'lblVisitante
        '
        Me.lblVisitante.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVisitante.AutoSize = True
        Me.lblVisitante.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblVisitante.Image = CType(resources.GetObject("lblVisitante.Image"), System.Drawing.Image)
        Me.lblVisitante.Location = New System.Drawing.Point(340, 300)
        Me.lblVisitante.Name = "lblVisitante"
        Me.lblVisitante.Size = New System.Drawing.Size(46, 13)
        Me.lblVisitante.TabIndex = 33
        Me.lblVisitante.Text = "Capitan:"
        Me.lblVisitante.Visible = False
        '
        'btnArbitro
        '
        Me.btnArbitro.Image = CType(resources.GetObject("btnArbitro.Image"), System.Drawing.Image)
        Me.btnArbitro.Location = New System.Drawing.Point(9, 9)
        Me.btnArbitro.Margin = New System.Windows.Forms.Padding(0)
        Me.btnArbitro.Name = "btnArbitro"
        Me.btnArbitro.Size = New System.Drawing.Size(83, 30)
        Me.btnArbitro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnArbitro.TabIndex = 34
        Me.btnArbitro.TabStop = False
        '
        'btnTerminado
        '
        Me.btnTerminado.Image = CType(resources.GetObject("btnTerminado.Image"), System.Drawing.Image)
        Me.btnTerminado.Location = New System.Drawing.Point(9, 53)
        Me.btnTerminado.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTerminado.Name = "btnTerminado"
        Me.btnTerminado.Size = New System.Drawing.Size(83, 30)
        Me.btnTerminado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnTerminado.TabIndex = 35
        Me.btnTerminado.TabStop = False
        '
        'btnMenuPrincipal
        '
        Me.btnMenuPrincipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnMenuPrincipal.BackgroundImage = CType(resources.GetObject("btnMenuPrincipal.BackgroundImage"), System.Drawing.Image)
        Me.btnMenuPrincipal.Image = CType(resources.GetObject("btnMenuPrincipal.Image"), System.Drawing.Image)
        Me.btnMenuPrincipal.Location = New System.Drawing.Point(9, 347)
        Me.btnMenuPrincipal.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMenuPrincipal.Name = "btnMenuPrincipal"
        Me.btnMenuPrincipal.Size = New System.Drawing.Size(100, 32)
        Me.btnMenuPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMenuPrincipal.TabIndex = 38
        Me.btnMenuPrincipal.TabStop = False
        '
        'btnLocal
        '
        Me.btnLocal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLocal.BackColor = System.Drawing.Color.Transparent
        Me.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocal.Image = CType(resources.GetObject("btnLocal.Image"), System.Drawing.Image)
        Me.btnLocal.Location = New System.Drawing.Point(182, 28)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(61, 24)
        Me.btnLocal.TabIndex = 39
        Me.btnLocal.UseVisualStyleBackColor = False
        '
        'btnVisitante
        '
        Me.btnVisitante.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisitante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVisitante.BackColor = System.Drawing.Color.Transparent
        Me.btnVisitante.BackgroundImage = CType(resources.GetObject("btnVisitante.BackgroundImage"), System.Drawing.Image)
        Me.btnVisitante.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVisitante.Location = New System.Drawing.Point(112, 28)
        Me.btnVisitante.Name = "btnVisitante"
        Me.btnVisitante.Size = New System.Drawing.Size(61, 24)
        Me.btnVisitante.TabIndex = 40
        Me.btnVisitante.UseVisualStyleBackColor = False
        '
        'btnReload
        '
        Me.btnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Image = CType(resources.GetObject("btnReload.Image"), System.Drawing.Image)
        Me.btnReload.Location = New System.Drawing.Point(222, 351)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(67, 23)
        Me.btnReload.TabIndex = 43
        Me.btnReload.TabStop = False
        Me.btnReload.Text = "Recargar"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'wbHaxball
        '
        Me.wbHaxball.AllowExternalDrop = True
        Me.wbHaxball.BackColor = System.Drawing.Color.WhiteSmoke
        Me.wbHaxball.CreationProperties = Nothing
        Me.wbHaxball.DefaultBackgroundColor = System.Drawing.Color.White
        Me.wbHaxball.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbHaxball.Location = New System.Drawing.Point(0, 0)
        Me.wbHaxball.Name = "wbHaxball"
        Me.wbHaxball.Size = New System.Drawing.Size(468, 385)
        Me.wbHaxball.TabIndex = 44
        Me.wbHaxball.ZoomFactor = 1.0R
        AddHandler Me.wbHaxball.Click, AddressOf Me.wbHaxball_Click
        '
        'Oficial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(468, 385)
        Me.Controls.Add(Me.wbHaxball)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnVisitante)
        Me.Controls.Add(Me.btnLocal)
        Me.Controls.Add(Me.btnMenuPrincipal)
        Me.Controls.Add(Me.btnTerminado)
        Me.Controls.Add(Me.btnArbitro)
        Me.Controls.Add(Me.lblVisitante)
        Me.Controls.Add(Me.lblLocal)
        Me.Controls.Add(Me.Visitante)
        Me.Controls.Add(Me.Local)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.btnHacerRegistro)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnRegistro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Oficial"
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        AddHandler Load, AddressOf Me.Oficial_Load
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Local, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visitante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnArbitro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTerminado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenuPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wbHaxball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegistro As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnHacerRegistro As System.Windows.Forms.Button
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents Local As System.Windows.Forms.DataGridView
    Friend WithEvents Visitante As System.Windows.Forms.DataGridView
    Friend WithEvents lblLocal As System.Windows.Forms.Label
    Friend WithEvents lblVisitante As System.Windows.Forms.Label
    Friend WithEvents btnArbitro As System.Windows.Forms.PictureBox
    Friend WithEvents btnTerminado As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenuPrincipal As System.Windows.Forms.PictureBox
    Friend WithEvents btnLocal As System.Windows.Forms.Button
    Friend WithEvents btnVisitante As System.Windows.Forms.Button
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents wbHaxball As Microsoft.Web.WebView2.WinForms.WebView2
    '  Friend WithEvents wbHaxball As Skybound.Gecko.GeckoWebBrowser
End Class
