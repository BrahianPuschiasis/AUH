<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmOf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdmOf))
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.txtArbitro = New System.Windows.Forms.TextBox()
        Me.txtVisitante = New System.Windows.Forms.TextBox()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnTeam = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(471, 230)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMenu.TabIndex = 6
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.Location = New System.Drawing.Point(227, 230)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 5
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        AddHandler Me.btnConfirmar.Click, AddressOf Me.btnConfirmar_Click_1
        '
        'txtLocal
        '
        Me.txtLocal.Location = New System.Drawing.Point(206, 63)
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(100, 20)
        Me.txtLocal.TabIndex = 1
        '
        'txtArbitro
        '
        Me.txtArbitro.Location = New System.Drawing.Point(206, 134)
        Me.txtArbitro.Name = "txtArbitro"
        Me.txtArbitro.Size = New System.Drawing.Size(100, 20)
        Me.txtArbitro.TabIndex = 3
        '
        'txtVisitante
        '
        Me.txtVisitante.Location = New System.Drawing.Point(206, 96)
        Me.txtVisitante.Name = "txtVisitante"
        Me.txtVisitante.Size = New System.Drawing.Size(100, 20)
        Me.txtVisitante.TabIndex = 2
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(206, 169)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(100, 20)
        Me.txtHost.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Local:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Visitante:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Arbitro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Host:"
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.Color.Blue
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(331, 63)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(215, 161)
        Me.DGV.TabIndex = 10
        Me.DGV.Visible = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Image = CType(resources.GetObject("btnUsuarios.Image"), System.Drawing.Image)
        Me.btnUsuarios.Location = New System.Drawing.Point(449, 34)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(97, 23)
        Me.btnUsuarios.TabIndex = 11
        Me.btnUsuarios.Text = "Buscar Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnTeam
        '
        Me.btnTeam.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeam.Image = CType(resources.GetObject("btnTeam.Image"), System.Drawing.Image)
        Me.btnTeam.Location = New System.Drawing.Point(325, 34)
        Me.btnTeam.Name = "btnTeam"
        Me.btnTeam.Size = New System.Drawing.Size(102, 23)
        Me.btnTeam.TabIndex = 12
        Me.btnTeam.Text = "Buscar Teams"
        Me.btnTeam.UseVisualStyleBackColor = True
        '
        'AdmOf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 265)
        Me.Controls.Add(Me.btnTeam)
        Me.Controls.Add(Me.btnUsuarios)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.txtVisitante)
        Me.Controls.Add(Me.txtArbitro)
        Me.Controls.Add(Me.txtLocal)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdmOf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdmOf"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents txtLocal As System.Windows.Forms.TextBox
    Friend WithEvents txtArbitro As System.Windows.Forms.TextBox
    Friend WithEvents txtVisitante As System.Windows.Forms.TextBox
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
    Friend WithEvents btnTeam As System.Windows.Forms.Button
End Class
