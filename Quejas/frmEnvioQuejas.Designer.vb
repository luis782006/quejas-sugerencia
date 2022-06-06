<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvioQuejas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnvioQuejas))
        Me.QuejasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuejasDataSet = New Quejas.QuejasDataSet()
        Me.QuejasTableAdapter = New Quejas.QuejasDataSetTableAdapters.QuejasTableAdapter()
        Me.QuejasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblDestinatario = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAgregarD = New System.Windows.Forms.Button()
        Me.comboMail = New System.Windows.Forms.ComboBox()
        Me.CorreosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.lbAdjunto = New System.Windows.Forms.Label()
        Me.txtTema = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btEnviarM = New System.Windows.Forms.Button()
        Me.CorreosTableAdapter = New Quejas.QuejasDataSetTableAdapters.CorreosTableAdapter()
        Me.txtDirecciones_Mail = New System.Windows.Forms.TextBox()
        CType(Me.QuejasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuejasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuejasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CorreosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuejasBindingSource
        '
        Me.QuejasBindingSource.DataMember = "Quejas"
        Me.QuejasBindingSource.DataSource = Me.QuejasDataSet
        '
        'QuejasDataSet
        '
        Me.QuejasDataSet.DataSetName = "QuejasDataSet"
        Me.QuejasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuejasTableAdapter
        '
        Me.QuejasTableAdapter.ClearBeforeFill = True
        '
        'QuejasBindingSource1
        '
        Me.QuejasBindingSource1.DataMember = "Quejas"
        Me.QuejasBindingSource1.DataSource = Me.QuejasDataSet
        '
        'lblDestinatario
        '
        Me.lblDestinatario.AutoSize = True
        Me.lblDestinatario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestinatario.Location = New System.Drawing.Point(59, 102)
        Me.lblDestinatario.Name = "lblDestinatario"
        Me.lblDestinatario.Size = New System.Drawing.Size(0, 16)
        Me.lblDestinatario.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Direccion Mail:"
        '
        'btnAgregarD
        '
        Me.btnAgregarD.Enabled = False
        Me.btnAgregarD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregarD.Location = New System.Drawing.Point(253, 66)
        Me.btnAgregarD.Name = "btnAgregarD"
        Me.btnAgregarD.Size = New System.Drawing.Size(59, 23)
        Me.btnAgregarD.TabIndex = 26
        Me.btnAgregarD.Text = "Aceptar"
        Me.btnAgregarD.UseVisualStyleBackColor = True
        '
        'comboMail
        '
        Me.comboMail.DataSource = Me.CorreosBindingSource
        Me.comboMail.DisplayMember = "Direccion_Correos"
        Me.comboMail.FormattingEnabled = True
        Me.comboMail.Location = New System.Drawing.Point(126, 67)
        Me.comboMail.Name = "comboMail"
        Me.comboMail.Size = New System.Drawing.Size(121, 21)
        Me.comboMail.TabIndex = 25
        Me.comboMail.ValueMember = "Id"
        '
        'CorreosBindingSource
        '
        Me.CorreosBindingSource.DataMember = "Correos"
        Me.CorreosBindingSource.DataSource = Me.QuejasDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Para:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, -31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Quejas del Dia "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Ruta: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Asunto:"
        '
        'txtAsunto
        '
        Me.txtAsunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsunto.Location = New System.Drawing.Point(126, 30)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(294, 22)
        Me.txtAsunto.TabIndex = 16
        '
        'lbAdjunto
        '
        Me.lbAdjunto.AutoSize = True
        Me.lbAdjunto.BackColor = System.Drawing.Color.Transparent
        Me.lbAdjunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAdjunto.Location = New System.Drawing.Point(83, 339)
        Me.lbAdjunto.Name = "lbAdjunto"
        Me.lbAdjunto.Size = New System.Drawing.Size(52, 16)
        Me.lbAdjunto.TabIndex = 22
        Me.lbAdjunto.Text = "archivo"
        '
        'txtTema
        '
        Me.txtTema.Location = New System.Drawing.Point(11, 156)
        Me.txtTema.Multiline = True
        Me.txtTema.Name = "txtTema"
        Me.txtTema.Size = New System.Drawing.Size(518, 161)
        Me.txtTema.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Quejas.My.Resources.Resources.acroread
        Me.PictureBox2.Location = New System.Drawing.Point(13, 323)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Quejas.My.Resources.Resources.mail2
        Me.PictureBox1.Location = New System.Drawing.Point(11, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'btEnviarM
        '
        Me.btEnviarM.Enabled = False
        Me.btEnviarM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEnviarM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btEnviarM.Image = Global.Quejas.My.Resources.Resources.mail_generic
        Me.btEnviarM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEnviarM.Location = New System.Drawing.Point(437, 100)
        Me.btEnviarM.Name = "btEnviarM"
        Me.btEnviarM.Size = New System.Drawing.Size(92, 45)
        Me.btEnviarM.TabIndex = 21
        Me.btEnviarM.Text = "Enviar"
        Me.btEnviarM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEnviarM.UseVisualStyleBackColor = True
        '
        'CorreosTableAdapter
        '
        Me.CorreosTableAdapter.ClearBeforeFill = True
        '
        'txtDirecciones_Mail
        '
        Me.txtDirecciones_Mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirecciones_Mail.Location = New System.Drawing.Point(74, 100)
        Me.txtDirecciones_Mail.Multiline = True
        Me.txtDirecciones_Mail.Name = "txtDirecciones_Mail"
        Me.txtDirecciones_Mail.ReadOnly = True
        Me.txtDirecciones_Mail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDirecciones_Mail.Size = New System.Drawing.Size(345, 45)
        Me.txtDirecciones_Mail.TabIndex = 30
        '
        'frmEnvioQuejas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(544, 366)
        Me.Controls.Add(Me.txtDirecciones_Mail)
        Me.Controls.Add(Me.lblDestinatario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAgregarD)
        Me.Controls.Add(Me.comboMail)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btEnviarM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.lbAdjunto)
        Me.Controls.Add(Me.txtTema)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEnvioQuejas"
        CType(Me.QuejasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuejasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuejasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CorreosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents QuejasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QuejasDataSet As Quejas.QuejasDataSet
    Friend WithEvents QuejasTableAdapter As Quejas.QuejasDataSetTableAdapters.QuejasTableAdapter
    Friend WithEvents QuejasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents lblDestinatario As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarD As System.Windows.Forms.Button
    Friend WithEvents comboMail As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btEnviarM As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents lbAdjunto As System.Windows.Forms.Label
    Friend WithEvents txtTema As System.Windows.Forms.TextBox
    Friend WithEvents CorreosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CorreosTableAdapter As Quejas.QuejasDataSetTableAdapters.CorreosTableAdapter
    Friend WithEvents txtDirecciones_Mail As System.Windows.Forms.TextBox
End Class
