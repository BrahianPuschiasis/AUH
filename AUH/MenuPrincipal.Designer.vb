<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AsdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmistososToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FixtureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClausuraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperturaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClausuraToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnualToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperturaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClausuraToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnualToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OficialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtLink = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.btnCerrarRoom = New System.Windows.Forms.Button()
        Me.wbForo = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wbForo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsdToolStripMenuItem, Me.AmistososToolStripMenuItem, Me.FixtureToolStripMenuItem, Me.ForoToolStripMenuItem, Me.TVToolStripMenuItem, Me.ToolStripMenuItem1, Me.CerrarToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem12})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(892, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AsdToolStripMenuItem
        '
        Me.AsdToolStripMenuItem.BackgroundImage = CType(resources.GetObject("AsdToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.AsdToolStripMenuItem.MergeIndex = -11
        Me.AsdToolStripMenuItem.Name = "AsdToolStripMenuItem"
        Me.AsdToolStripMenuItem.Size = New System.Drawing.Size(106, 31)
        Me.AsdToolStripMenuItem.Text = "                             "
        Me.AsdToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AmistososToolStripMenuItem
        '
        Me.AmistososToolStripMenuItem.BackgroundImage = CType(resources.GetObject("AmistososToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.AmistososToolStripMenuItem.Name = "AmistososToolStripMenuItem"
        Me.AmistososToolStripMenuItem.Size = New System.Drawing.Size(112, 31)
        Me.AmistososToolStripMenuItem.Text = "                               "
        '
        'FixtureToolStripMenuItem
        '
        Me.FixtureToolStripMenuItem.BackgroundImage = CType(resources.GetObject("FixtureToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.FixtureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem, Me.BToolStripMenuItem, Me.CToolStripMenuItem})
        Me.FixtureToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Green
        Me.FixtureToolStripMenuItem.Name = "FixtureToolStripMenuItem"
        Me.FixtureToolStripMenuItem.Size = New System.Drawing.Size(106, 31)
        Me.FixtureToolStripMenuItem.Text = "                             "
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AperturaToolStripMenuItem, Me.ClausuraToolStripMenuItem, Me.AnualToolStripMenuItem})
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(82, 22)
        Me.AToolStripMenuItem.Text = "A"
        '
        'AperturaToolStripMenuItem
        '
        Me.AperturaToolStripMenuItem.Name = "AperturaToolStripMenuItem"
        Me.AperturaToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AperturaToolStripMenuItem.Text = "Apertura"
        '
        'ClausuraToolStripMenuItem
        '
        Me.ClausuraToolStripMenuItem.Name = "ClausuraToolStripMenuItem"
        Me.ClausuraToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ClausuraToolStripMenuItem.Text = "Clausura"
        '
        'AnualToolStripMenuItem
        '
        Me.AnualToolStripMenuItem.Name = "AnualToolStripMenuItem"
        Me.AnualToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AnualToolStripMenuItem.Text = "Anual"
        '
        'BToolStripMenuItem
        '
        Me.BToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AperturaToolStripMenuItem1, Me.ClausuraToolStripMenuItem1, Me.AnualToolStripMenuItem1})
        Me.BToolStripMenuItem.Name = "BToolStripMenuItem"
        Me.BToolStripMenuItem.Size = New System.Drawing.Size(82, 22)
        Me.BToolStripMenuItem.Text = "B"
        '
        'AperturaToolStripMenuItem1
        '
        Me.AperturaToolStripMenuItem1.Name = "AperturaToolStripMenuItem1"
        Me.AperturaToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.AperturaToolStripMenuItem1.Text = "Apertura"
        '
        'ClausuraToolStripMenuItem1
        '
        Me.ClausuraToolStripMenuItem1.Name = "ClausuraToolStripMenuItem1"
        Me.ClausuraToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.ClausuraToolStripMenuItem1.Text = "Clausura"
        '
        'AnualToolStripMenuItem1
        '
        Me.AnualToolStripMenuItem1.Name = "AnualToolStripMenuItem1"
        Me.AnualToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.AnualToolStripMenuItem1.Text = "Anual"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AperturaToolStripMenuItem2, Me.ClausuraToolStripMenuItem2, Me.AnualToolStripMenuItem2})
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(82, 22)
        Me.CToolStripMenuItem.Text = "C"
        '
        'AperturaToolStripMenuItem2
        '
        Me.AperturaToolStripMenuItem2.Name = "AperturaToolStripMenuItem2"
        Me.AperturaToolStripMenuItem2.Size = New System.Drawing.Size(120, 22)
        Me.AperturaToolStripMenuItem2.Text = "Apertura"
        '
        'ClausuraToolStripMenuItem2
        '
        Me.ClausuraToolStripMenuItem2.Name = "ClausuraToolStripMenuItem2"
        Me.ClausuraToolStripMenuItem2.Size = New System.Drawing.Size(120, 22)
        Me.ClausuraToolStripMenuItem2.Text = "Clausura"
        '
        'AnualToolStripMenuItem2
        '
        Me.AnualToolStripMenuItem2.Name = "AnualToolStripMenuItem2"
        Me.AnualToolStripMenuItem2.Size = New System.Drawing.Size(120, 22)
        Me.AnualToolStripMenuItem2.Text = "Anual"
        '
        'ForoToolStripMenuItem
        '
        Me.ForoToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ForoToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ForoToolStripMenuItem.Name = "ForoToolStripMenuItem"
        Me.ForoToolStripMenuItem.Size = New System.Drawing.Size(91, 31)
        Me.ForoToolStripMenuItem.Text = "                        "
        AddHandler Me.ForoToolStripMenuItem.Click, AddressOf Me.ForoToolStripMenuItem_Click_1
        '
        'TVToolStripMenuItem
        '
        Me.TVToolStripMenuItem.BackgroundImage = CType(resources.GetObject("TVToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.TVToolStripMenuItem.Name = "TVToolStripMenuItem"
        Me.TVToolStripMenuItem.Size = New System.Drawing.Size(97, 31)
        Me.TVToolStripMenuItem.Text = "                          "
        AddHandler Me.TVToolStripMenuItem.Click, AddressOf Me.TVToolStripMenuItem_Click_1
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackgroundImage = CType(resources.GetObject("ToolStripMenuItem1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OficialesToolStripMenuItem, Me.TeamsToolStripMenuItem})
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(130, 31)
        Me.ToolStripMenuItem1.Text = "                                     "
        Me.ToolStripMenuItem1.Visible = False
        '
        'OficialesToolStripMenuItem
        '
        Me.OficialesToolStripMenuItem.Name = "OficialesToolStripMenuItem"
        Me.OficialesToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.OficialesToolStripMenuItem.Text = "Oficiales"
        '
        'TeamsToolStripMenuItem
        '
        Me.TeamsToolStripMenuItem.Name = "TeamsToolStripMenuItem"
        Me.TeamsToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.TeamsToolStripMenuItem.Text = "Teams"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.BackgroundImage = CType(resources.GetObject("CerrarToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(100, 31)
        Me.CerrarToolStripMenuItem.Text = "                           "
        AddHandler Me.CerrarToolStripMenuItem.Click, AddressOf Me.CerrarToolStripMenuItem_Click_1
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackgroundImage = CType(resources.GetObject("ToolStripMenuItem2.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(130, 31)
        Me.ToolStripMenuItem2.Text = "                                     "
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.BackgroundImage = CType(resources.GetObject("ToolStripMenuItem12.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(130, 31)
        Me.ToolStripMenuItem12.Text = "                                     "
        Me.ToolStripMenuItem12.Visible = False
        '
        'txtLink
        '
        Me.txtLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLink.Location = New System.Drawing.Point(780, 314)
        Me.txtLink.Name = "txtLink"
        Me.txtLink.Size = New System.Drawing.Size(100, 23)
        Me.txtLink.TabIndex = 3
        Me.txtLink.Text = "Link room"
        Me.txtLink.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(665, 314)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 26)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        Me.btnEliminar.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(780, 38)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 27)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        Me.btnBuscar.Visible = False
        AddHandler Me.btnBuscar.Click, AddressOf Me.btnBuscar_Click_1
        '
        'DG1
        '
        Me.DG1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Location = New System.Drawing.Point(406, 116)
        Me.DG1.Name = "DG1"
        Me.DG1.ReadOnly = True
        Me.DG1.Size = New System.Drawing.Size(368, 176)
        Me.DG1.TabIndex = 6
        Me.DG1.Visible = False
        '
        'btnCerrarRoom
        '
        Me.btnCerrarRoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarRoom.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrarRoom.FlatAppearance.BorderColor = System.Drawing.Color.Aqua
        Me.btnCerrarRoom.FlatAppearance.BorderSize = 0
        Me.btnCerrarRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCerrarRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnCerrarRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarRoom.Image = CType(resources.GetObject("btnCerrarRoom.Image"), System.Drawing.Image)
        Me.btnCerrarRoom.Location = New System.Drawing.Point(559, 314)
        Me.btnCerrarRoom.Name = "btnCerrarRoom"
        Me.btnCerrarRoom.Size = New System.Drawing.Size(100, 26)
        Me.btnCerrarRoom.TabIndex = 33
        Me.btnCerrarRoom.Text = "Cerrar"
        Me.btnCerrarRoom.UseVisualStyleBackColor = False
        Me.btnCerrarRoom.Visible = False
        '
        'wbForo
        '
        Me.wbForo.AllowExternalDrop = True
        Me.wbForo.CreationProperties = Nothing
        Me.wbForo.DefaultBackgroundColor = System.Drawing.Color.White
        Me.wbForo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbForo.Location = New System.Drawing.Point(0, 35)
        Me.wbForo.Name = "wbForo"
        Me.wbForo.Size = New System.Drawing.Size(892, 305)
        Me.wbForo.TabIndex = 34
        Me.wbForo.ZoomFactor = 1.0R
        AddHandler Me.wbForo.Click, AddressOf Me.wbForo_Click_1
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(892, 340)
        Me.Controls.Add(Me.wbForo)
        Me.Controls.Add(Me.btnCerrarRoom)
        Me.Controls.Add(Me.DG1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtLink)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wbForo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AsdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FixtureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AperturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClausuraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AperturaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClausuraToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnualToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AperturaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClausuraToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnualToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmistososToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OficialesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtLink As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents DG1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCerrarRoom As System.Windows.Forms.Button
    Friend WithEvents TeamsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wbForo As Microsoft.Web.WebView2.WinForms.WebView2
End Class
