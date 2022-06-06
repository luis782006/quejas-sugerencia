<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneral
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneral))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnInsertarQueja = New System.Windows.Forms.Button()
        Me.btnQuejasPendientes = New System.Windows.Forms.Button()
        Me.btnEnviarQuejas = New System.Windows.Forms.Button()
        Me.btnAjustes = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MInsertarQuejas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MQuejasPendientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MMostrarQuejas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MEnviarQuejas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAjusteDeSistema = New System.Windows.Forms.ToolStripMenuItem()
        Me.MConfiguracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerLaAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcercaDeSistemasQuejasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "user_headset_Black.png")
        Me.ImageList1.Images.SetKeyName(1, "usuario-final.png")
        Me.ImageList1.Images.SetKeyName(2, "user_headsetMas.png")
        Me.ImageList1.Images.SetKeyName(3, "user_headsetMasBlancoNegro.png")
        Me.ImageList1.Images.SetKeyName(4, "user_headsetRealizado.png")
        Me.ImageList1.Images.SetKeyName(5, "user_headsetRealizadoBlacoNegro.png")
        Me.ImageList1.Images.SetKeyName(6, "user_headsetEnviar.png")
        Me.ImageList1.Images.SetKeyName(7, "user_headsetEnviarBlancoNegro.png")
        Me.ImageList1.Images.SetKeyName(8, "user_headsetAjustes.png")
        Me.ImageList1.Images.SetKeyName(9, "user_headsetAjustesBlancoNegro.png")
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnMostrar.ForeColor = System.Drawing.Color.White
        Me.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMostrar.ImageIndex = 0
        Me.btnMostrar.ImageList = Me.ImageList1
        Me.btnMostrar.Location = New System.Drawing.Point(11, 245)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMostrar.Size = New System.Drawing.Size(90, 100)
        Me.btnMostrar.TabIndex = 3
        Me.btnMostrar.Text = "Mostrar Quejas"
        Me.btnMostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnMostrar, "Muestra todas las quejas realizadas")
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'btnInsertarQueja
        '
        Me.btnInsertarQueja.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnInsertarQueja.ForeColor = System.Drawing.Color.White
        Me.btnInsertarQueja.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInsertarQueja.ImageIndex = 3
        Me.btnInsertarQueja.ImageList = Me.ImageList1
        Me.btnInsertarQueja.Location = New System.Drawing.Point(11, 33)
        Me.btnInsertarQueja.Name = "btnInsertarQueja"
        Me.btnInsertarQueja.Size = New System.Drawing.Size(90, 100)
        Me.btnInsertarQueja.TabIndex = 1
        Me.btnInsertarQueja.Text = "Insertar Queja"
        Me.btnInsertarQueja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnInsertarQueja, "Insertar Nueva queja por el Huesped")
        Me.btnInsertarQueja.UseVisualStyleBackColor = False
        '
        'btnQuejasPendientes
        '
        Me.btnQuejasPendientes.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnQuejasPendientes.ForeColor = System.Drawing.Color.White
        Me.btnQuejasPendientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnQuejasPendientes.ImageIndex = 5
        Me.btnQuejasPendientes.ImageList = Me.ImageList1
        Me.btnQuejasPendientes.Location = New System.Drawing.Point(11, 139)
        Me.btnQuejasPendientes.Name = "btnQuejasPendientes"
        Me.btnQuejasPendientes.Size = New System.Drawing.Size(90, 100)
        Me.btnQuejasPendientes.TabIndex = 2
        Me.btnQuejasPendientes.Text = "Quejas Pendientes"
        Me.btnQuejasPendientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnQuejasPendientes, "Muestra las quejas Pendientes No Realizadas")
        Me.btnQuejasPendientes.UseVisualStyleBackColor = False
        '
        'btnEnviarQuejas
        '
        Me.btnEnviarQuejas.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnEnviarQuejas.ForeColor = System.Drawing.Color.White
        Me.btnEnviarQuejas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEnviarQuejas.ImageIndex = 7
        Me.btnEnviarQuejas.ImageList = Me.ImageList1
        Me.btnEnviarQuejas.Location = New System.Drawing.Point(11, 351)
        Me.btnEnviarQuejas.Name = "btnEnviarQuejas"
        Me.btnEnviarQuejas.Size = New System.Drawing.Size(90, 100)
        Me.btnEnviarQuejas.TabIndex = 4
        Me.btnEnviarQuejas.Text = "Enviar Quejas "
        Me.btnEnviarQuejas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnEnviarQuejas, "Enviar las quejas del Dia")
        Me.btnEnviarQuejas.UseVisualStyleBackColor = False
        Me.btnEnviarQuejas.Visible = False
        '
        'btnAjustes
        '
        Me.btnAjustes.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnAjustes.ForeColor = System.Drawing.Color.White
        Me.btnAjustes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAjustes.ImageIndex = 9
        Me.btnAjustes.ImageList = Me.ImageList1
        Me.btnAjustes.Location = New System.Drawing.Point(11, 492)
        Me.btnAjustes.Name = "btnAjustes"
        Me.btnAjustes.Size = New System.Drawing.Size(90, 100)
        Me.btnAjustes.TabIndex = 5
        Me.btnAjustes.Text = "Ajuste de Sistema"
        Me.btnAjustes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnAjustes, "Ajustes y Configuracion del Sistemas")
        Me.btnAjustes.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAjustes)
        Me.Panel1.Controls.Add(Me.btnInsertarQueja)
        Me.Panel1.Controls.Add(Me.btnEnviarQuejas)
        Me.Panel1.Controls.Add(Me.btnQuejasPendientes)
        Me.Panel1.Controls.Add(Me.btnMostrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(116, 604)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(29, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Opciones"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem1, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(130, 0, 0, 0)
        Me.MenuStrip1.Size = New System.Drawing.Size(1117, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem1
        '
        Me.MenúToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MInsertarQuejas, Me.MQuejasPendientes, Me.MMostrarQuejas, Me.MEnviarQuejas, Me.MAjusteDeSistema, Me.MConfiguracion, Me.SalirToolStripMenuItem})
        Me.MenúToolStripMenuItem1.Name = "MenúToolStripMenuItem1"
        Me.MenúToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.MenúToolStripMenuItem1.Size = New System.Drawing.Size(50, 24)
        Me.MenúToolStripMenuItem1.Text = "Menú"
        '
        'MInsertarQuejas
        '
        Me.MInsertarQuejas.Image = Global.Quejas.My.Resources.Resources.user_headset2
        Me.MInsertarQuejas.Name = "MInsertarQuejas"
        Me.MInsertarQuejas.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.MInsertarQuejas.Size = New System.Drawing.Size(210, 22)
        Me.MInsertarQuejas.Text = "Insertar Quejas"
        '
        'MQuejasPendientes
        '
        Me.MQuejasPendientes.Image = Global.Quejas.My.Resources.Resources.user_headsetRealizado
        Me.MQuejasPendientes.Name = "MQuejasPendientes"
        Me.MQuejasPendientes.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.MQuejasPendientes.Size = New System.Drawing.Size(210, 22)
        Me.MQuejasPendientes.Text = "Quejas Pendientes"
        '
        'MMostrarQuejas
        '
        Me.MMostrarQuejas.Image = Global.Quejas.My.Resources.Resources.user_headset2
        Me.MMostrarQuejas.Name = "MMostrarQuejas"
        Me.MMostrarQuejas.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MMostrarQuejas.Size = New System.Drawing.Size(210, 22)
        Me.MMostrarQuejas.Text = "Mostrar Quejas"
        '
        'MEnviarQuejas
        '
        Me.MEnviarQuejas.Enabled = False
        Me.MEnviarQuejas.Name = "MEnviarQuejas"
        Me.MEnviarQuejas.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.MEnviarQuejas.Size = New System.Drawing.Size(210, 22)
        Me.MEnviarQuejas.Text = "Enviar Quejas"
        '
        'MAjusteDeSistema
        '
        Me.MAjusteDeSistema.Image = Global.Quejas.My.Resources.Resources.exec1
        Me.MAjusteDeSistema.Name = "MAjusteDeSistema"
        Me.MAjusteDeSistema.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.MAjusteDeSistema.Size = New System.Drawing.Size(210, 22)
        Me.MAjusteDeSistema.Text = "Ajuste de Sistema"
        '
        'MConfiguracion
        '
        Me.MConfiguracion.Enabled = False
        Me.MConfiguracion.Name = "MConfiguracion"
        Me.MConfiguracion.Size = New System.Drawing.Size(210, 22)
        Me.MConfiguracion.Text = "Configuracion de Correo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.Quejas.My.Resources.Resources._1rightarrow1
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerLaAyudaToolStripMenuItem, Me.ToolStripSeparator1, Me.AcercaDeSistemasQuejasToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'VerLaAyudaToolStripMenuItem
        '
        Me.VerLaAyudaToolStripMenuItem.Image = Global.Quejas.My.Resources.Resources.kuser1
        Me.VerLaAyudaToolStripMenuItem.Name = "VerLaAyudaToolStripMenuItem"
        Me.VerLaAyudaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.VerLaAyudaToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.VerLaAyudaToolStripMenuItem.Text = "Ver la ayuda"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(227, 6)
        '
        'AcercaDeSistemasQuejasToolStripMenuItem
        '
        Me.AcercaDeSistemasQuejasToolStripMenuItem.Image = Global.Quejas.My.Resources.Resources.security_agent2
        Me.AcercaDeSistemasQuejasToolStripMenuItem.Name = "AcercaDeSistemasQuejasToolStripMenuItem"
        Me.AcercaDeSistemasQuejasToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.AcercaDeSistemasQuejasToolStripMenuItem.Text = "Acerca de Sistemas de Quejas"
        '
        'frmGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Quejas.My.Resources.Resources.recepcionistas_g__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1117, 628)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmGeneral"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistemas de Quejas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents btnInsertarQueja As System.Windows.Forms.Button
    Friend WithEvents btnQuejasPendientes As System.Windows.Forms.Button
    Friend WithEvents btnEnviarQuejas As System.Windows.Forms.Button
    Friend WithEvents btnAjustes As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenúToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MInsertarQuejas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MQuejasPendientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MMostrarQuejas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MEnviarQuejas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MAjusteDeSistema As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerLaAyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AcercaDeSistemasQuejasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MConfiguracion As System.Windows.Forms.ToolStripMenuItem
End Class
