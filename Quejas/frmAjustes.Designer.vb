<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjustes
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
        Dim PersonalLabel As System.Windows.Forms.Label
        Dim DepartamentosLabel As System.Windows.Forms.Label
        Dim HabLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAjustes))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblAjusteNombreH = New System.Windows.Forms.Label()
        Me.lblFirma = New System.Windows.Forms.Label()
        Me.btnCancelarFirma = New System.Windows.Forms.Button()
        Me.btnAplicarFirma = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreFirma = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreInst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnAjusteCancelarP = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblAyudaP = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.btnAjusteEliminarP = New System.Windows.Forms.Button()
        Me.btnAjusteModificarP = New System.Windows.Forms.Button()
        Me.btnAjusteGuardarP = New System.Windows.Forms.Button()
        Me.btnAjusteNuevoP = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuejasDataSet = New Quejas.QuejasDataSet()
        Me.PersonalTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblExplicacionP = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.lblAyudaD = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnAjusteCancelarD = New System.Windows.Forms.Button()
        Me.btnAjusteEliminarD = New System.Windows.Forms.Button()
        Me.btnAjusteNuevoD = New System.Windows.Forms.Button()
        Me.btnAjusteModificarD = New System.Windows.Forms.Button()
        Me.btnAjusteGuardarD = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DepartamentosTextBox = New System.Windows.Forms.TextBox()
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblExplicacionD = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.IdTextBox2 = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnAjusteCancelarH = New System.Windows.Forms.Button()
        Me.lblAjusteH = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnAjusteEliminarH = New System.Windows.Forms.Button()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.btnAjusteNuevoH = New System.Windows.Forms.Button()
        Me.btnAjusteModificarH = New System.Windows.Forms.Button()
        Me.btnAjusteGuardar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.HabTextBox = New System.Windows.Forms.TextBox()
        Me.HabitacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblExplicacionH = New System.Windows.Forms.Label()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAjusteCancelarM = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAyudaM = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAjusteEliminarM = New System.Windows.Forms.Button()
        Me.btnAjusteModificarM = New System.Windows.Forms.Button()
        Me.btnAjusteGuardarM = New System.Windows.Forms.Button()
        Me.btnAjusteNuevoM = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnConfigAjuste = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtDireccionM = New System.Windows.Forms.TextBox()
        Me.CorreosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button12 = New System.Windows.Forms.Button()
        Me.lblExplicacionM = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.IdTextBox3 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PersonalTableAdapter = New Quejas.QuejasDataSetTableAdapters.PersonalTableAdapter()
        Me.TableAdapterManager = New Quejas.QuejasDataSetTableAdapters.TableAdapterManager()
        Me.HabitacionesTableAdapter = New Quejas.QuejasDataSetTableAdapters.HabitacionesTableAdapter()
        Me.DepartamentosTableAdapter = New Quejas.QuejasDataSetTableAdapters.DepartamentosTableAdapter()
        Me.CorreosTableAdapter = New Quejas.QuejasDataSetTableAdapters.CorreosTableAdapter()
        PersonalLabel = New System.Windows.Forms.Label()
        DepartamentosLabel = New System.Windows.Forms.Label()
        HabLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuejasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CorreosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PersonalLabel
        '
        PersonalLabel.AutoSize = True
        PersonalLabel.Location = New System.Drawing.Point(77, 78)
        PersonalLabel.Name = "PersonalLabel"
        PersonalLabel.Size = New System.Drawing.Size(65, 16)
        PersonalLabel.TabIndex = 16
        PersonalLabel.Text = "Personal:"
        '
        'DepartamentosLabel
        '
        DepartamentosLabel.AutoSize = True
        DepartamentosLabel.Location = New System.Drawing.Point(6, 82)
        DepartamentosLabel.Name = "DepartamentosLabel"
        DepartamentosLabel.Size = New System.Drawing.Size(104, 16)
        DepartamentosLabel.TabIndex = 15
        DepartamentosLabel.Text = "Departamentos:"
        '
        'HabLabel
        '
        HabLabel.AutoSize = True
        HabLabel.Location = New System.Drawing.Point(84, 80)
        HabLabel.Name = "HabLabel"
        HabLabel.Size = New System.Drawing.Size(37, 16)
        HabLabel.TabIndex = 14
        HabLabel.Text = "Hab:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(13, 78)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(68, 16)
        Label7.TabIndex = 16
        Label7.Text = "Direccion:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.HabitacionesBindingSource, "Hab", True))
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(22, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(601, 305)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.lblAjusteNombreH)
        Me.TabPage1.Controls.Add(Me.lblFirma)
        Me.TabPage1.Controls.Add(Me.btnCancelarFirma)
        Me.TabPage1.Controls.Add(Me.btnAplicarFirma)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtNombreFirma)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtNombreInst)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(593, 276)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ajuste de Firma"
        '
        'lblAjusteNombreH
        '
        Me.lblAjusteNombreH.AutoSize = True
        Me.lblAjusteNombreH.Font = New System.Drawing.Font("Lucida Fax", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblAjusteNombreH.ForeColor = System.Drawing.Color.White
        Me.lblAjusteNombreH.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAjusteNombreH.Location = New System.Drawing.Point(16, 166)
        Me.lblAjusteNombreH.Name = "lblAjusteNombreH"
        Me.lblAjusteNombreH.Size = New System.Drawing.Size(185, 22)
        Me.lblAjusteNombreH.TabIndex = 6
        Me.lblAjusteNombreH.Text = "Nombre del Hotel"
        '
        'lblFirma
        '
        Me.lblFirma.AutoSize = True
        Me.lblFirma.BackColor = System.Drawing.Color.Transparent
        Me.lblFirma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirma.Location = New System.Drawing.Point(16, 239)
        Me.lblFirma.Name = "lblFirma"
        Me.lblFirma.Size = New System.Drawing.Size(158, 16)
        Me.lblFirma.TabIndex = 5
        Me.lblFirma.Text = "Melia International Hotels"
        '
        'btnCancelarFirma
        '
        Me.btnCancelarFirma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelarFirma.Location = New System.Drawing.Point(454, 227)
        Me.btnCancelarFirma.Name = "btnCancelarFirma"
        Me.btnCancelarFirma.Size = New System.Drawing.Size(84, 33)
        Me.btnCancelarFirma.TabIndex = 4
        Me.btnCancelarFirma.Text = "Cancelar"
        Me.btnCancelarFirma.UseVisualStyleBackColor = True
        '
        'btnAplicarFirma
        '
        Me.btnAplicarFirma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAplicarFirma.Location = New System.Drawing.Point(357, 227)
        Me.btnAplicarFirma.Name = "btnAplicarFirma"
        Me.btnAplicarFirma.Size = New System.Drawing.Size(90, 33)
        Me.btnAplicarFirma.TabIndex = 3
        Me.btnAplicarFirma.Text = "Aplicar"
        Me.btnAplicarFirma.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Instalacion Actual"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Instalacion Actual"
        '
        'txtNombreFirma
        '
        Me.txtNombreFirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreFirma.Location = New System.Drawing.Point(17, 92)
        Me.txtNombreFirma.Name = "txtNombreFirma"
        Me.txtNombreFirma.ReadOnly = True
        Me.txtNombreFirma.Size = New System.Drawing.Size(240, 26)
        Me.txtNombreFirma.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre de la Instalacion:"
        '
        'txtNombreInst
        '
        Me.txtNombreInst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreInst.Location = New System.Drawing.Point(17, 41)
        Me.txtNombreInst.Name = "txtNombreInst"
        Me.txtNombreInst.ReadOnly = True
        Me.txtNombreInst.Size = New System.Drawing.Size(266, 26)
        Me.txtNombreInst.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Firma"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.Color.Gray
        Me.TabPage3.Controls.Add(Me.btnAjusteCancelarP)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.lblAyudaP)
        Me.TabPage3.Controls.Add(Me.PictureBox8)
        Me.TabPage3.Controls.Add(Me.btnAjusteEliminarP)
        Me.TabPage3.Controls.Add(Me.btnAjusteModificarP)
        Me.TabPage3.Controls.Add(Me.btnAjusteGuardarP)
        Me.TabPage3.Controls.Add(Me.btnAjusteNuevoP)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(593, 276)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Personal"
        '
        'btnAjusteCancelarP
        '
        Me.btnAjusteCancelarP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteCancelarP.Location = New System.Drawing.Point(440, 208)
        Me.btnAjusteCancelarP.Name = "btnAjusteCancelarP"
        Me.btnAjusteCancelarP.Size = New System.Drawing.Size(89, 38)
        Me.btnAjusteCancelarP.TabIndex = 9
        Me.btnAjusteCancelarP.Text = "Cancelar"
        Me.btnAjusteCancelarP.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Ajustes del Personal"
        '
        'lblAyudaP
        '
        Me.lblAyudaP.AutoSize = True
        Me.lblAyudaP.Location = New System.Drawing.Point(482, 15)
        Me.lblAyudaP.Name = "lblAyudaP"
        Me.lblAyudaP.Size = New System.Drawing.Size(47, 16)
        Me.lblAyudaP.TabIndex = 2
        Me.lblAyudaP.Text = "Ayuda"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Quejas.My.Resources.Resources.status_unknown
        Me.PictureBox8.Location = New System.Drawing.Point(440, 9)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 15
        Me.PictureBox8.TabStop = False
        '
        'btnAjusteEliminarP
        '
        Me.btnAjusteEliminarP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteEliminarP.Image = Global.Quejas.My.Resources.Resources.user1_delete
        Me.btnAjusteEliminarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteEliminarP.Location = New System.Drawing.Point(348, 208)
        Me.btnAjusteEliminarP.Name = "btnAjusteEliminarP"
        Me.btnAjusteEliminarP.Size = New System.Drawing.Size(89, 38)
        Me.btnAjusteEliminarP.TabIndex = 8
        Me.btnAjusteEliminarP.Text = "Eliminar"
        Me.btnAjusteEliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteEliminarP.UseVisualStyleBackColor = True
        '
        'btnAjusteModificarP
        '
        Me.btnAjusteModificarP.Enabled = False
        Me.btnAjusteModificarP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteModificarP.Image = Global.Quejas.My.Resources.Resources.user1_refresh
        Me.btnAjusteModificarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteModificarP.Location = New System.Drawing.Point(160, 208)
        Me.btnAjusteModificarP.Name = "btnAjusteModificarP"
        Me.btnAjusteModificarP.Size = New System.Drawing.Size(93, 38)
        Me.btnAjusteModificarP.TabIndex = 7
        Me.btnAjusteModificarP.Text = "Modificar"
        Me.btnAjusteModificarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteModificarP.UseVisualStyleBackColor = True
        '
        'btnAjusteGuardarP
        '
        Me.btnAjusteGuardarP.Enabled = False
        Me.btnAjusteGuardarP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteGuardarP.Image = Global.Quejas.My.Resources.Resources.user1_preferences
        Me.btnAjusteGuardarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteGuardarP.Location = New System.Drawing.Point(256, 208)
        Me.btnAjusteGuardarP.Name = "btnAjusteGuardarP"
        Me.btnAjusteGuardarP.Size = New System.Drawing.Size(89, 38)
        Me.btnAjusteGuardarP.TabIndex = 6
        Me.btnAjusteGuardarP.Text = "Guardar"
        Me.btnAjusteGuardarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteGuardarP.UseVisualStyleBackColor = True
        '
        'btnAjusteNuevoP
        '
        Me.btnAjusteNuevoP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteNuevoP.Image = Global.Quejas.My.Resources.Resources.user1_new1
        Me.btnAjusteNuevoP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteNuevoP.Location = New System.Drawing.Point(74, 208)
        Me.btnAjusteNuevoP.Name = "btnAjusteNuevoP"
        Me.btnAjusteNuevoP.Size = New System.Drawing.Size(83, 38)
        Me.btnAjusteNuevoP.TabIndex = 5
        Me.btnAjusteNuevoP.Text = "Nuevo"
        Me.btnAjusteNuevoP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteNuevoP.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(PersonalLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(Me.PersonalTextBox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.lblExplicacionP)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 211)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Quejas.My.Resources.Resources.users21
        Me.PictureBox5.Location = New System.Drawing.Point(31, 21)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(31, 47)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(23, 22)
        Me.IdTextBox.TabIndex = 18
        '
        'PersonalBindingSource
        '
        Me.PersonalBindingSource.DataMember = "Personal"
        Me.PersonalBindingSource.DataSource = Me.QuejasDataSet
        '
        'QuejasDataSet
        '
        Me.QuejasDataSet.DataSetName = "QuejasDataSet"
        Me.QuejasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonalTextBox
        '
        Me.PersonalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "Personal", True))
        Me.PersonalTextBox.Location = New System.Drawing.Point(148, 75)
        Me.PersonalTextBox.Name = "PersonalTextBox"
        Me.PersonalTextBox.ReadOnly = True
        Me.PersonalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PersonalTextBox.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(200, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 23)
        Me.Button1.TabIndex = 91
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(158, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 23)
        Me.Button2.TabIndex = 90
        Me.Button2.Text = "<<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblExplicacionP
        '
        Me.lblExplicacionP.AutoSize = True
        Me.lblExplicacionP.BackColor = System.Drawing.Color.Transparent
        Me.lblExplicacionP.Location = New System.Drawing.Point(227, 33)
        Me.lblExplicacionP.Name = "lblExplicacionP"
        Me.lblExplicacionP.Size = New System.Drawing.Size(309, 80)
        Me.lblExplicacionP.TabIndex = 14
        Me.lblExplicacionP.Text = resources.GetString("lblExplicacionP.Text")
        Me.lblExplicacionP.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Gray
        Me.TabPage4.Controls.Add(Me.PictureBox12)
        Me.TabPage4.Controls.Add(Me.lblAyudaD)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.btnAjusteCancelarD)
        Me.TabPage4.Controls.Add(Me.btnAjusteEliminarD)
        Me.TabPage4.Controls.Add(Me.btnAjusteNuevoD)
        Me.TabPage4.Controls.Add(Me.btnAjusteModificarD)
        Me.TabPage4.Controls.Add(Me.btnAjusteGuardarD)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(593, 276)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Departamentos"
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.Quejas.My.Resources.Resources.status_unknown
        Me.PictureBox12.Location = New System.Drawing.Point(440, 9)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox12.TabIndex = 17
        Me.PictureBox12.TabStop = False
        '
        'lblAyudaD
        '
        Me.lblAyudaD.AutoSize = True
        Me.lblAyudaD.Location = New System.Drawing.Point(482, 15)
        Me.lblAyudaD.Name = "lblAyudaD"
        Me.lblAyudaD.Size = New System.Drawing.Size(47, 16)
        Me.lblAyudaD.TabIndex = 16
        Me.lblAyudaD.Text = "Ayuda"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(167, 16)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Ajustes de Departamentos"
        '
        'btnAjusteCancelarD
        '
        Me.btnAjusteCancelarD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteCancelarD.Location = New System.Drawing.Point(425, 194)
        Me.btnAjusteCancelarD.Name = "btnAjusteCancelarD"
        Me.btnAjusteCancelarD.Size = New System.Drawing.Size(89, 38)
        Me.btnAjusteCancelarD.TabIndex = 14
        Me.btnAjusteCancelarD.Text = "Cancelar"
        Me.btnAjusteCancelarD.UseVisualStyleBackColor = True
        '
        'btnAjusteEliminarD
        '
        Me.btnAjusteEliminarD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteEliminarD.Image = Global.Quejas.My.Resources.Resources.office_buildingEliminar
        Me.btnAjusteEliminarD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteEliminarD.Location = New System.Drawing.Point(333, 194)
        Me.btnAjusteEliminarD.Name = "btnAjusteEliminarD"
        Me.btnAjusteEliminarD.Size = New System.Drawing.Size(89, 38)
        Me.btnAjusteEliminarD.TabIndex = 13
        Me.btnAjusteEliminarD.Text = "Eliminar"
        Me.btnAjusteEliminarD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteEliminarD.UseVisualStyleBackColor = True
        '
        'btnAjusteNuevoD
        '
        Me.btnAjusteNuevoD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteNuevoD.Image = Global.Quejas.My.Resources.Resources.office_buildingNuevo
        Me.btnAjusteNuevoD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteNuevoD.Location = New System.Drawing.Point(59, 194)
        Me.btnAjusteNuevoD.Name = "btnAjusteNuevoD"
        Me.btnAjusteNuevoD.Size = New System.Drawing.Size(83, 38)
        Me.btnAjusteNuevoD.TabIndex = 10
        Me.btnAjusteNuevoD.Text = "Nuevo"
        Me.btnAjusteNuevoD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteNuevoD.UseVisualStyleBackColor = True
        '
        'btnAjusteModificarD
        '
        Me.btnAjusteModificarD.Enabled = False
        Me.btnAjusteModificarD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteModificarD.Image = Global.Quejas.My.Resources.Resources.office_buildingModificar
        Me.btnAjusteModificarD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteModificarD.Location = New System.Drawing.Point(145, 194)
        Me.btnAjusteModificarD.Name = "btnAjusteModificarD"
        Me.btnAjusteModificarD.Size = New System.Drawing.Size(93, 38)
        Me.btnAjusteModificarD.TabIndex = 12
        Me.btnAjusteModificarD.Text = "Modificar"
        Me.btnAjusteModificarD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteModificarD.UseVisualStyleBackColor = True
        '
        'btnAjusteGuardarD
        '
        Me.btnAjusteGuardarD.Enabled = False
        Me.btnAjusteGuardarD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteGuardarD.Image = Global.Quejas.My.Resources.Resources.office_buildingGuardar
        Me.btnAjusteGuardarD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteGuardarD.Location = New System.Drawing.Point(241, 194)
        Me.btnAjusteGuardarD.Name = "btnAjusteGuardarD"
        Me.btnAjusteGuardarD.Size = New System.Drawing.Size(89, 38)
        Me.btnAjusteGuardarD.TabIndex = 11
        Me.btnAjusteGuardarD.Text = "Guardar"
        Me.btnAjusteGuardarD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteGuardarD.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(DepartamentosLabel)
        Me.GroupBox2.Controls.Add(Me.DepartamentosTextBox)
        Me.GroupBox2.Controls.Add(Me.lblExplicacionD)
        Me.GroupBox2.Controls.Add(Me.PictureBox11)
        Me.GroupBox2.Controls.Add(Me.IdTextBox2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(14, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 218)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Departamentos"
        '
        'Button6
        '
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(183, 105)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(39, 23)
        Me.Button6.TabIndex = 94
        Me.Button6.Text = ">>"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(138, 105)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 23)
        Me.Button5.TabIndex = 93
        Me.Button5.Text = "<<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DepartamentosTextBox
        '
        Me.DepartamentosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentosBindingSource, "Departamentos", True))
        Me.DepartamentosTextBox.Location = New System.Drawing.Point(114, 79)
        Me.DepartamentosTextBox.Name = "DepartamentosTextBox"
        Me.DepartamentosTextBox.ReadOnly = True
        Me.DepartamentosTextBox.Size = New System.Drawing.Size(127, 22)
        Me.DepartamentosTextBox.TabIndex = 16
        '
        'DepartamentosBindingSource
        '
        Me.DepartamentosBindingSource.DataMember = "Departamentos"
        Me.DepartamentosBindingSource.DataSource = Me.QuejasDataSet
        '
        'lblExplicacionD
        '
        Me.lblExplicacionD.AutoSize = True
        Me.lblExplicacionD.BackColor = System.Drawing.Color.Transparent
        Me.lblExplicacionD.Location = New System.Drawing.Point(198, 52)
        Me.lblExplicacionD.Name = "lblExplicacionD"
        Me.lblExplicacionD.Size = New System.Drawing.Size(327, 80)
        Me.lblExplicacionD.TabIndex = 14
        Me.lblExplicacionD.Text = resources.GetString("lblExplicacionD.Text")
        Me.lblExplicacionD.Visible = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.Quejas.My.Resources.Resources.office_building1
        Me.PictureBox11.Location = New System.Drawing.Point(31, 21)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox11.TabIndex = 8
        Me.PictureBox11.TabStop = False
        '
        'IdTextBox2
        '
        Me.IdTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentosBindingSource, "Id", True))
        Me.IdTextBox2.Location = New System.Drawing.Point(45, 21)
        Me.IdTextBox2.Name = "IdTextBox2"
        Me.IdTextBox2.ReadOnly = True
        Me.IdTextBox2.Size = New System.Drawing.Size(10, 22)
        Me.IdTextBox2.TabIndex = 15
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Gray
        Me.TabPage5.Controls.Add(Me.btnAjusteCancelarH)
        Me.TabPage5.Controls.Add(Me.lblAjusteH)
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Controls.Add(Me.btnAjusteEliminarH)
        Me.TabPage5.Controls.Add(Me.PictureBox13)
        Me.TabPage5.Controls.Add(Me.btnAjusteNuevoH)
        Me.TabPage5.Controls.Add(Me.btnAjusteModificarH)
        Me.TabPage5.Controls.Add(Me.btnAjusteGuardar)
        Me.TabPage5.Controls.Add(Me.GroupBox3)
        Me.TabPage5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(593, 276)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Habitaciones"
        '
        'btnAjusteCancelarH
        '
        Me.btnAjusteCancelarH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteCancelarH.Location = New System.Drawing.Point(440, 200)
        Me.btnAjusteCancelarH.Name = "btnAjusteCancelarH"
        Me.btnAjusteCancelarH.Size = New System.Drawing.Size(89, 38)
        Me.btnAjusteCancelarH.TabIndex = 19
        Me.btnAjusteCancelarH.Text = "Cancelar"
        Me.btnAjusteCancelarH.UseVisualStyleBackColor = True
        '
        'lblAjusteH
        '
        Me.lblAjusteH.AutoSize = True
        Me.lblAjusteH.Location = New System.Drawing.Point(482, 15)
        Me.lblAjusteH.Name = "lblAjusteH"
        Me.lblAjusteH.Size = New System.Drawing.Size(47, 16)
        Me.lblAjusteH.TabIndex = 19
        Me.lblAjusteH.Text = "Ayuda"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(154, 16)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Ajustes de Habitaciones"
        '
        'btnAjusteEliminarH
        '
        Me.btnAjusteEliminarH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteEliminarH.Image = Global.Quejas.My.Resources.Resources.office_buildingEliminar
        Me.btnAjusteEliminarH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteEliminarH.Location = New System.Drawing.Point(348, 200)
        Me.btnAjusteEliminarH.Name = "btnAjusteEliminarH"
        Me.btnAjusteEliminarH.Size = New System.Drawing.Size(89, 38)
        Me.btnAjusteEliminarH.TabIndex = 18
        Me.btnAjusteEliminarH.Text = "Eliminar"
        Me.btnAjusteEliminarH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteEliminarH.UseVisualStyleBackColor = True
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.Quejas.My.Resources.Resources.status_unknown
        Me.PictureBox13.Location = New System.Drawing.Point(440, 9)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox13.TabIndex = 20
        Me.PictureBox13.TabStop = False
        '
        'btnAjusteNuevoH
        '
        Me.btnAjusteNuevoH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteNuevoH.Image = Global.Quejas.My.Resources.Resources.office_buildingNuevo
        Me.btnAjusteNuevoH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteNuevoH.Location = New System.Drawing.Point(74, 200)
        Me.btnAjusteNuevoH.Name = "btnAjusteNuevoH"
        Me.btnAjusteNuevoH.Size = New System.Drawing.Size(83, 38)
        Me.btnAjusteNuevoH.TabIndex = 15
        Me.btnAjusteNuevoH.Text = "Nuevo"
        Me.btnAjusteNuevoH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteNuevoH.UseVisualStyleBackColor = True
        '
        'btnAjusteModificarH
        '
        Me.btnAjusteModificarH.Enabled = False
        Me.btnAjusteModificarH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteModificarH.Image = Global.Quejas.My.Resources.Resources.office_buildingModificar
        Me.btnAjusteModificarH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteModificarH.Location = New System.Drawing.Point(160, 200)
        Me.btnAjusteModificarH.Name = "btnAjusteModificarH"
        Me.btnAjusteModificarH.Size = New System.Drawing.Size(93, 38)
        Me.btnAjusteModificarH.TabIndex = 17
        Me.btnAjusteModificarH.Text = "Modificar"
        Me.btnAjusteModificarH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteModificarH.UseVisualStyleBackColor = True
        '
        'btnAjusteGuardar
        '
        Me.btnAjusteGuardar.Enabled = False
        Me.btnAjusteGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteGuardar.Image = Global.Quejas.My.Resources.Resources.office_buildingGuardar
        Me.btnAjusteGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteGuardar.Location = New System.Drawing.Point(256, 200)
        Me.btnAjusteGuardar.Name = "btnAjusteGuardar"
        Me.btnAjusteGuardar.Size = New System.Drawing.Size(89, 38)
        Me.btnAjusteGuardar.TabIndex = 15
        Me.btnAjusteGuardar.Text = "Guardar"
        Me.btnAjusteGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(HabLabel)
        Me.GroupBox3.Controls.Add(Me.HabTextBox)
        Me.GroupBox3.Controls.Add(Me.lblExplicacionH)
        Me.GroupBox3.Controls.Add(Me.PictureBox16)
        Me.GroupBox3.Controls.Add(Me.IdTextBox1)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(13, 47)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(526, 214)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Habitaciones"
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(147, 106)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(39, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(105, 106)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(39, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "<<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'HabTextBox
        '
        Me.HabTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HabitacionesBindingSource, "Hab", True))
        Me.HabTextBox.Location = New System.Drawing.Point(121, 78)
        Me.HabTextBox.Name = "HabTextBox"
        Me.HabTextBox.ReadOnly = True
        Me.HabTextBox.Size = New System.Drawing.Size(46, 22)
        Me.HabTextBox.TabIndex = 15
        '
        'HabitacionesBindingSource
        '
        Me.HabitacionesBindingSource.DataMember = "Habitaciones"
        Me.HabitacionesBindingSource.DataSource = Me.QuejasDataSet
        '
        'lblExplicacionH
        '
        Me.lblExplicacionH.AutoSize = True
        Me.lblExplicacionH.BackColor = System.Drawing.Color.Transparent
        Me.lblExplicacionH.Location = New System.Drawing.Point(188, 51)
        Me.lblExplicacionH.Name = "lblExplicacionH"
        Me.lblExplicacionH.Size = New System.Drawing.Size(314, 80)
        Me.lblExplicacionH.TabIndex = 14
        Me.lblExplicacionH.Text = resources.GetString("lblExplicacionH.Text")
        Me.lblExplicacionH.Visible = False
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = Global.Quejas.My.Resources.Resources.office_building1
        Me.PictureBox16.Location = New System.Drawing.Point(43, 31)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox16.TabIndex = 8
        Me.PictureBox16.TabStop = False
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HabitacionesBindingSource, "Id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(43, 31)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.ReadOnly = True
        Me.IdTextBox1.Size = New System.Drawing.Size(11, 22)
        Me.IdTextBox1.TabIndex = 22
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gray
        Me.TabPage2.Controls.Add(Me.btnAjusteCancelarM)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.lblAyudaM)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.btnAjusteEliminarM)
        Me.TabPage2.Controls.Add(Me.btnAjusteModificarM)
        Me.TabPage2.Controls.Add(Me.btnAjusteGuardarM)
        Me.TabPage2.Controls.Add(Me.btnAjusteNuevoM)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(593, 276)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Configuraciones de Correo"
        '
        'btnAjusteCancelarM
        '
        Me.btnAjusteCancelarM.Enabled = False
        Me.btnAjusteCancelarM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteCancelarM.Location = New System.Drawing.Point(446, 213)
        Me.btnAjusteCancelarM.Name = "btnAjusteCancelarM"
        Me.btnAjusteCancelarM.Size = New System.Drawing.Size(89, 38)
        Me.btnAjusteCancelarM.TabIndex = 23
        Me.btnAjusteCancelarM.Text = "Cancelar"
        Me.btnAjusteCancelarM.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Configuracion de Correo"
        '
        'lblAyudaM
        '
        Me.lblAyudaM.AutoSize = True
        Me.lblAyudaM.Location = New System.Drawing.Point(488, 20)
        Me.lblAyudaM.Name = "lblAyudaM"
        Me.lblAyudaM.Size = New System.Drawing.Size(47, 16)
        Me.lblAyudaM.TabIndex = 18
        Me.lblAyudaM.Text = "Ayuda"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Quejas.My.Resources.Resources.status_unknown
        Me.PictureBox1.Location = New System.Drawing.Point(446, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'btnAjusteEliminarM
        '
        Me.btnAjusteEliminarM.Enabled = False
        Me.btnAjusteEliminarM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteEliminarM.Image = Global.Quejas.My.Resources.Resources.maileliminar
        Me.btnAjusteEliminarM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteEliminarM.Location = New System.Drawing.Point(354, 213)
        Me.btnAjusteEliminarM.Name = "btnAjusteEliminarM"
        Me.btnAjusteEliminarM.Size = New System.Drawing.Size(89, 38)
        Me.btnAjusteEliminarM.TabIndex = 22
        Me.btnAjusteEliminarM.Text = "Eliminar"
        Me.btnAjusteEliminarM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteEliminarM.UseVisualStyleBackColor = True
        '
        'btnAjusteModificarM
        '
        Me.btnAjusteModificarM.Enabled = False
        Me.btnAjusteModificarM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteModificarM.Image = Global.Quejas.My.Resources.Resources.mail2modificar
        Me.btnAjusteModificarM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteModificarM.Location = New System.Drawing.Point(166, 213)
        Me.btnAjusteModificarM.Name = "btnAjusteModificarM"
        Me.btnAjusteModificarM.Size = New System.Drawing.Size(93, 38)
        Me.btnAjusteModificarM.TabIndex = 21
        Me.btnAjusteModificarM.Text = "Modificar"
        Me.btnAjusteModificarM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteModificarM.UseVisualStyleBackColor = True
        '
        'btnAjusteGuardarM
        '
        Me.btnAjusteGuardarM.Enabled = False
        Me.btnAjusteGuardarM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteGuardarM.Image = Global.Quejas.My.Resources.Resources.mail2guardar
        Me.btnAjusteGuardarM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteGuardarM.Location = New System.Drawing.Point(262, 213)
        Me.btnAjusteGuardarM.Name = "btnAjusteGuardarM"
        Me.btnAjusteGuardarM.Size = New System.Drawing.Size(89, 38)
        Me.btnAjusteGuardarM.TabIndex = 20
        Me.btnAjusteGuardarM.Text = "Guardar"
        Me.btnAjusteGuardarM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteGuardarM.UseVisualStyleBackColor = True
        '
        'btnAjusteNuevoM
        '
        Me.btnAjusteNuevoM.Enabled = False
        Me.btnAjusteNuevoM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAjusteNuevoM.Image = Global.Quejas.My.Resources.Resources.mail2add
        Me.btnAjusteNuevoM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjusteNuevoM.Location = New System.Drawing.Point(80, 213)
        Me.btnAjusteNuevoM.Name = "btnAjusteNuevoM"
        Me.btnAjusteNuevoM.Size = New System.Drawing.Size(83, 38)
        Me.btnAjusteNuevoM.TabIndex = 19
        Me.btnAjusteNuevoM.Text = "Nuevo"
        Me.btnAjusteNuevoM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjusteNuevoM.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnConfigAjuste)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Controls.Add(Me.txtDireccionM)
        Me.GroupBox4.Controls.Add(Label7)
        Me.GroupBox4.Controls.Add(Me.Button12)
        Me.GroupBox4.Controls.Add(Me.lblExplicacionM)
        Me.GroupBox4.Controls.Add(Me.Button13)
        Me.GroupBox4.Controls.Add(Me.IdTextBox3)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(18, 52)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(565, 211)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Correos"
        '
        'btnConfigAjuste
        '
        Me.btnConfigAjuste.Enabled = False
        Me.btnConfigAjuste.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnConfigAjuste.Location = New System.Drawing.Point(403, 71)
        Me.btnConfigAjuste.Name = "btnConfigAjuste"
        Me.btnConfigAjuste.Size = New System.Drawing.Size(114, 36)
        Me.btnConfigAjuste.TabIndex = 94
        Me.btnConfigAjuste.Text = "Congifuraciones "
        Me.btnConfigAjuste.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Quejas.My.Resources.Resources.mail21
        Me.PictureBox2.Location = New System.Drawing.Point(18, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'txtDireccionM
        '
        Me.txtDireccionM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CorreosBindingSource, "Direccion_Correos", True))
        Me.txtDireccionM.Enabled = False
        Me.txtDireccionM.Location = New System.Drawing.Point(80, 77)
        Me.txtDireccionM.Name = "txtDireccionM"
        Me.txtDireccionM.ReadOnly = True
        Me.txtDireccionM.Size = New System.Drawing.Size(228, 22)
        Me.txtDireccionM.TabIndex = 93
        '
        'CorreosBindingSource
        '
        Me.CorreosBindingSource.DataMember = "Correos"
        Me.CorreosBindingSource.DataSource = Me.QuejasDataSet
        '
        'Button12
        '
        Me.Button12.Enabled = False
        Me.Button12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button12.Location = New System.Drawing.Point(200, 104)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(39, 23)
        Me.Button12.TabIndex = 91
        Me.Button12.Text = ">>"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'lblExplicacionM
        '
        Me.lblExplicacionM.AutoSize = True
        Me.lblExplicacionM.BackColor = System.Drawing.Color.Transparent
        Me.lblExplicacionM.Location = New System.Drawing.Point(256, 33)
        Me.lblExplicacionM.Name = "lblExplicacionM"
        Me.lblExplicacionM.Size = New System.Drawing.Size(309, 80)
        Me.lblExplicacionM.TabIndex = 14
        Me.lblExplicacionM.Text = resources.GetString("lblExplicacionM.Text")
        Me.lblExplicacionM.Visible = False
        '
        'Button13
        '
        Me.Button13.Enabled = False
        Me.Button13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button13.Location = New System.Drawing.Point(158, 104)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(39, 23)
        Me.Button13.TabIndex = 90
        Me.Button13.Text = "<<"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'IdTextBox3
        '
        Me.IdTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CorreosBindingSource, "Id", True))
        Me.IdTextBox3.Location = New System.Drawing.Point(40, 47)
        Me.IdTextBox3.Name = "IdTextBox3"
        Me.IdTextBox3.Size = New System.Drawing.Size(21, 22)
        Me.IdTextBox3.TabIndex = 92
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        '
        'PersonalTableAdapter
        '
        Me.PersonalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CorreosTableAdapter = Nothing
        Me.TableAdapterManager.DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.HabitacionesTableAdapter = Nothing
        Me.TableAdapterManager.PersonalTableAdapter = Me.PersonalTableAdapter
        Me.TableAdapterManager.UpdateOrder = Quejas.QuejasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HabitacionesTableAdapter
        '
        Me.HabitacionesTableAdapter.ClearBeforeFill = True
        '
        'DepartamentosTableAdapter
        '
        Me.DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'CorreosTableAdapter
        '
        Me.CorreosTableAdapter.ClearBeforeFill = True
        '
        'frmAjustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(635, 327)
        Me.Controls.Add(Me.TabControl1)
        Me.Location = New System.Drawing.Point(22, 12)
        Me.Name = "frmAjustes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste de Sistema"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuejasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CorreosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblAjusteNombreH As System.Windows.Forms.Label
    Friend WithEvents lblFirma As System.Windows.Forms.Label
    Friend WithEvents btnCancelarFirma As System.Windows.Forms.Button
    Friend WithEvents btnAplicarFirma As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombreFirma As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombreInst As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnAjusteCancelarP As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAjusteEliminarP As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblAyudaP As System.Windows.Forms.Label
    Friend WithEvents btnAjusteModificarP As System.Windows.Forms.Button
    Friend WithEvents btnAjusteGuardarP As System.Windows.Forms.Button
    Friend WithEvents btnAjusteNuevoP As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PersonalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblExplicacionP As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAyudaD As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnAjusteCancelarD As System.Windows.Forms.Button
    Friend WithEvents btnAjusteEliminarD As System.Windows.Forms.Button
    Friend WithEvents btnAjusteNuevoD As System.Windows.Forms.Button
    Friend WithEvents btnAjusteModificarD As System.Windows.Forms.Button
    Friend WithEvents btnAjusteGuardarD As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DepartamentosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblExplicacionD As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents btnAjusteCancelarH As System.Windows.Forms.Button
    Friend WithEvents btnAjusteEliminarH As System.Windows.Forms.Button
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAjusteH As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnAjusteNuevoH As System.Windows.Forms.Button
    Friend WithEvents btnAjusteModificarH As System.Windows.Forms.Button
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAjusteGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents IdTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents HabTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblExplicacionH As System.Windows.Forms.Label
    Friend WithEvents PersonalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QuejasDataSet As Quejas.QuejasDataSet
    Friend WithEvents DepartamentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HabitacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PersonalTableAdapter As Quejas.QuejasDataSetTableAdapters.PersonalTableAdapter
    Friend WithEvents TableAdapterManager As Quejas.QuejasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HabitacionesTableAdapter As Quejas.QuejasDataSetTableAdapters.HabitacionesTableAdapter
    Friend WithEvents DepartamentosTableAdapter As Quejas.QuejasDataSetTableAdapters.DepartamentosTableAdapter
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnAjusteCancelarM As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAyudaM As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAjusteEliminarM As System.Windows.Forms.Button
    Friend WithEvents btnAjusteModificarM As System.Windows.Forms.Button
    Friend WithEvents btnAjusteGuardarM As System.Windows.Forms.Button
    Friend WithEvents btnAjusteNuevoM As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents lblExplicacionM As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents CorreosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CorreosTableAdapter As Quejas.QuejasDataSetTableAdapters.CorreosTableAdapter
    Friend WithEvents IdTextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccionM As System.Windows.Forms.TextBox
    Friend WithEvents btnConfigAjuste As System.Windows.Forms.Button
End Class
