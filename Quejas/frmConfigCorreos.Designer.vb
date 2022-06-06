<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigCorreos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigCorreos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.ConfigCorreosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuejasDataSet2 = New Quejas.QuejasDataSet2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCredencial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.ConfigCorreosTableAdapter = New Quejas.QuejasDataSet2TableAdapters.ConfigCorreosTableAdapter()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IdConfig = New System.Windows.Forms.TextBox()
        Me.btnModificarConfig = New System.Windows.Forms.Button()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.borrarConfig = New System.Windows.Forms.Button()
        Me.btnConfigGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ConfigCorreosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuejasDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host"
        '
        'txtHost
        '
        Me.txtHost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfigCorreosBindingSource, "Host", True))
        Me.txtHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHost.Location = New System.Drawing.Point(114, 44)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.ReadOnly = True
        Me.txtHost.Size = New System.Drawing.Size(160, 22)
        Me.txtHost.TabIndex = 1
        '
        'ConfigCorreosBindingSource
        '
        Me.ConfigCorreosBindingSource.DataMember = "ConfigCorreos"
        Me.ConfigCorreosBindingSource.DataSource = Me.QuejasDataSet2
        '
        'QuejasDataSet2
        '
        Me.QuejasDataSet2.DataSetName = "QuejasDataSet2"
        Me.QuejasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Desde"
        '
        'txtDesde
        '
        Me.txtDesde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfigCorreosBindingSource, "Mail", True))
        Me.txtDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesde.Location = New System.Drawing.Point(114, 81)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.ReadOnly = True
        Me.txtDesde.Size = New System.Drawing.Size(175, 22)
        Me.txtDesde.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Credencial"
        '
        'txtCredencial
        '
        Me.txtCredencial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfigCorreosBindingSource, "Credencial", True))
        Me.txtCredencial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredencial.Location = New System.Drawing.Point(114, 116)
        Me.txtCredencial.Name = "txtCredencial"
        Me.txtCredencial.ReadOnly = True
        Me.txtCredencial.Size = New System.Drawing.Size(175, 22)
        Me.txtCredencial.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Puerto"
        '
        'txtPort
        '
        Me.txtPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfigCorreosBindingSource, "Port", True))
        Me.txtPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Location = New System.Drawing.Point(114, 154)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.ReadOnly = True
        Me.txtPort.Size = New System.Drawing.Size(49, 22)
        Me.txtPort.TabIndex = 7
        '
        'ConfigCorreosTableAdapter
        '
        Me.ConfigCorreosTableAdapter.ClearBeforeFill = True
        '
        'txtContraseña
        '
        Me.txtContraseña.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfigCorreosBindingSource, "Contraseña", True))
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(114, 194)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtContraseña.ReadOnly = True
        Me.txtContraseña.Size = New System.Drawing.Size(100, 22)
        Me.txtContraseña.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contraseña"
        '
        'IdConfig
        '
        Me.IdConfig.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConfigCorreosBindingSource, "Id", True))
        Me.IdConfig.Location = New System.Drawing.Point(38, 43)
        Me.IdConfig.Name = "IdConfig"
        Me.IdConfig.Size = New System.Drawing.Size(17, 20)
        Me.IdConfig.TabIndex = 15
        '
        'btnModificarConfig
        '
        Me.btnModificarConfig.Enabled = False
        Me.btnModificarConfig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnModificarConfig.Image = Global.Quejas.My.Resources.Resources.socket_reload
        Me.btnModificarConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarConfig.Location = New System.Drawing.Point(295, 133)
        Me.btnModificarConfig.Name = "btnModificarConfig"
        Me.btnModificarConfig.Size = New System.Drawing.Size(93, 38)
        Me.btnModificarConfig.TabIndex = 14
        Me.btnModificarConfig.Text = "Modificar"
        Me.btnModificarConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificarConfig.UseVisualStyleBackColor = True
        '
        'btnConfig
        '
        Me.btnConfig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnConfig.Image = Global.Quejas.My.Resources.Resources.socket_decriptado
        Me.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfig.Location = New System.Drawing.Point(295, 43)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(93, 38)
        Me.btnConfig.TabIndex = 13
        Me.btnConfig.Text = "Configurar"
        Me.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'borrarConfig
        '
        Me.borrarConfig.Enabled = False
        Me.borrarConfig.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.borrarConfig.Image = Global.Quejas.My.Resources.Resources.socket_copia
        Me.borrarConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.borrarConfig.Location = New System.Drawing.Point(295, 179)
        Me.borrarConfig.Name = "borrarConfig"
        Me.borrarConfig.Size = New System.Drawing.Size(93, 38)
        Me.borrarConfig.TabIndex = 11
        Me.borrarConfig.Text = "Eliminar"
        Me.borrarConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.borrarConfig.UseVisualStyleBackColor = True
        '
        'btnConfigGuardar
        '
        Me.btnConfigGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnConfigGuardar.Image = Global.Quejas.My.Resources.Resources.socket1
        Me.btnConfigGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfigGuardar.Location = New System.Drawing.Point(295, 88)
        Me.btnConfigGuardar.Name = "btnConfigGuardar"
        Me.btnConfigGuardar.Size = New System.Drawing.Size(93, 38)
        Me.btnConfigGuardar.TabIndex = 10
        Me.btnConfigGuardar.Tag = ""
        Me.btnConfigGuardar.Text = "Guardar"
        Me.btnConfigGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfigGuardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Quejas.My.Resources.Resources.connect_to_network1
        Me.PictureBox1.Location = New System.Drawing.Point(18, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 51)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'frmConfigCorreos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(397, 236)
        Me.Controls.Add(Me.btnModificarConfig)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.borrarConfig)
        Me.Controls.Add(Me.btnConfigGuardar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCredencial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.IdConfig)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfigCorreos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion"
        CType(Me.ConfigCorreosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuejasDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCredencial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents QuejasDataSet2 As Quejas.QuejasDataSet2
    Friend WithEvents ConfigCorreosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfigCorreosTableAdapter As Quejas.QuejasDataSet2TableAdapters.ConfigCorreosTableAdapter
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnConfigGuardar As System.Windows.Forms.Button
    Friend WithEvents borrarConfig As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnConfig As System.Windows.Forms.Button
    Friend WithEvents btnModificarConfig As System.Windows.Forms.Button
    Friend WithEvents IdConfig As System.Windows.Forms.TextBox
End Class
