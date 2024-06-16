<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtMac = New System.Windows.Forms.TextBox()
        Me.txtJugador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.cmbTeam = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panel = New System.Windows.Forms.Panel()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMac
        '
        Me.txtMac.Location = New System.Drawing.Point(139, 63)
        Me.txtMac.Name = "txtMac"
        Me.txtMac.Size = New System.Drawing.Size(119, 20)
        Me.txtMac.TabIndex = 9
        Me.txtMac.Visible = False
        '
        'txtJugador
        '
        Me.txtJugador.Enabled = False
        Me.txtJugador.Location = New System.Drawing.Point(128, 28)
        Me.txtJugador.Name = "txtJugador"
        Me.txtJugador.Size = New System.Drawing.Size(177, 20)
        Me.txtJugador.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(33, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nickname"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(322, 174)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(177, 20)
        Me.txtPassword.TabIndex = 2
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(322, 129)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(177, 20)
        Me.txtUser.TabIndex = 1
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(226, 174)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(61, 13)
        Me.lblPassword.TabIndex = 22
        Me.lblPassword.Text = "Contraseña"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(227, 129)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(43, 13)
        Me.lblUser.TabIndex = 21
        Me.lblUser.Text = "Usuario"
        '
        'cmbTeam
        '
        Me.cmbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTeam.FormattingEnabled = True
        Me.cmbTeam.Location = New System.Drawing.Point(128, 65)
        Me.cmbTeam.Name = "cmbTeam"
        Me.cmbTeam.Size = New System.Drawing.Size(177, 21)
        Me.cmbTeam.TabIndex = 4
        Me.cmbTeam.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(38, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Team"
        Me.Label3.Visible = False
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Transparent
        Me.panel.Controls.Add(Me.Label3)
        Me.panel.Controls.Add(Me.cmbTeam)
        Me.panel.Controls.Add(Me.Label2)
        Me.panel.Controls.Add(Me.txtJugador)
        Me.panel.Controls.Add(Me.txtMac)
        Me.panel.Location = New System.Drawing.Point(194, 195)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(361, 97)
        Me.panel.TabIndex = 29
        Me.panel.Visible = False
        '
        'btnConectar
        '
        Me.btnConectar.BackColor = System.Drawing.Color.Transparent
        Me.btnConectar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnConectar.FlatAppearance.BorderSize = 0
        Me.btnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConectar.Image = CType(resources.GetObject("btnConectar.Image"), System.Drawing.Image)
        Me.btnConectar.Location = New System.Drawing.Point(407, 310)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(148, 33)
        Me.btnConectar.TabIndex = 32
        Me.btnConectar.UseVisualStyleBackColor = False
        AddHandler Me.btnConectar.Click, AddressOf Me.btnConectar_Click_3
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnRegistrar.FlatAppearance.BorderSize = 0
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"), System.Drawing.Image)
        Me.btnRegistrar.Location = New System.Drawing.Point(229, 310)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(147, 33)
        Me.btnRegistrar.TabIndex = 33
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnRegistro
        '
        Me.btnRegistro.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnRegistro.FlatAppearance.BorderSize = 0
        Me.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistro.Image = CType(resources.GetObject("btnRegistro.Image"), System.Drawing.Image)
        Me.btnRegistro.Location = New System.Drawing.Point(229, 310)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(147, 33)
        Me.btnRegistro.TabIndex = 34
        Me.btnRegistro.UseVisualStyleBackColor = False
        AddHandler Me.btnRegistro.Click, AddressOf Me.btnRegistro_Click_4
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(746, 371)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUser)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asosiación de Haxball Uruguayo"
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMac As System.Windows.Forms.TextBox
    Friend WithEvents txtJugador As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents cmbTeam As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panel As System.Windows.Forms.Panel
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnRegistro As System.Windows.Forms.Button

End Class
