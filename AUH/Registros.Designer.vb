<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registros))
        Me.btnListo = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.wbRegistro = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(Me.wbRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnListo
        '
        Me.btnListo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListo.BackColor = System.Drawing.Color.Transparent
        Me.btnListo.FlatAppearance.BorderSize = 0
        Me.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListo.Image = CType(resources.GetObject("btnListo.Image"), System.Drawing.Image)
        Me.btnListo.Location = New System.Drawing.Point(358, 351)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(104, 28)
        Me.btnListo.TabIndex = 1
        Me.btnListo.Text = "Listo"
        Me.btnListo.UseVisualStyleBackColor = False
        AddHandler Me.btnListo.Click, AddressOf Me.btnListo_Click_1
        '
        'btnCrear
        '
        Me.btnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCrear.BackColor = System.Drawing.Color.Transparent
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Image = CType(resources.GetObject("btnCrear.Image"), System.Drawing.Image)
        Me.btnCrear.Location = New System.Drawing.Point(358, 297)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(104, 28)
        Me.btnCrear.TabIndex = 2
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        Me.btnCrear.Visible = False
        AddHandler Me.btnCrear.Click, AddressOf Me.btnCrear_Click_1
        '
        'wbRegistro
        '
        Me.wbRegistro.AllowExternalDrop = True
        Me.wbRegistro.CreationProperties = Nothing
        Me.wbRegistro.DefaultBackgroundColor = System.Drawing.Color.White
        Me.wbRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbRegistro.Location = New System.Drawing.Point(0, 0)
        Me.wbRegistro.Name = "wbRegistro"
        Me.wbRegistro.Size = New System.Drawing.Size(501, 391)
        Me.wbRegistro.TabIndex = 3
        Me.wbRegistro.ZoomFactor = 1.0R
        AddHandler Me.wbRegistro.Click, AddressOf Me.wbRegistro_Click
        '
        'Registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(501, 391)
        Me.Controls.Add(Me.wbRegistro)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnListo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Registros"
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.wbRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnListo As System.Windows.Forms.Button
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents wbRegistro As Microsoft.Web.WebView2.WinForms.WebView2
End Class
