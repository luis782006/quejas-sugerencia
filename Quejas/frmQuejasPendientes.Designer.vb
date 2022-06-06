<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuejasPendientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuejasPendientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dgrillPendientes = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreHuespesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraAccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuejasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuejasDataSet = New Quejas.QuejasDataSet()
        Me.chkRealizadaP = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblGuardar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtHoraAccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNQuejas = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelarAccion = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAnteriorP = New System.Windows.Forms.Button()
        Me.btnProximoP = New System.Windows.Forms.Button()
        Me.QuejasTableAdapter = New Quejas.QuejasDataSetTableAdapters.QuejasTableAdapter()
        CType(Me.dgrillPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuejasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuejasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1leftarrow.png")
        Me.ImageList1.Images.SetKeyName(1, "1leftarrowBlancoNegro.png")
        Me.ImageList1.Images.SetKeyName(2, "1rightarrow.png")
        Me.ImageList1.Images.SetKeyName(3, "1rightarrowBlancoNegro.png")
        Me.ImageList1.Images.SetKeyName(4, "printer.png")
        '
        'dgrillPendientes
        '
        Me.dgrillPendientes.AllowUserToAddRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgrillPendientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgrillPendientes.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrillPendientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgrillPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrillPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.HoraDataGridViewTextBoxColumn, Me.HabDataGridViewTextBoxColumn, Me.NombreHuespesDataGridViewTextBoxColumn, Me.FechaInDataGridViewTextBoxColumn, Me.FechaOutDataGridViewTextBoxColumn, Me.PersonalDataGridViewTextBoxColumn, Me.DepartamentosDataGridViewTextBoxColumn, Me.ResponsableDataGridViewTextBoxColumn, Me.HoraAccionDataGridViewTextBoxColumn})
        Me.dgrillPendientes.DataSource = Me.QuejasBindingSource1
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrillPendientes.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgrillPendientes.GridColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dgrillPendientes.Location = New System.Drawing.Point(11, 12)
        Me.dgrillPendientes.Name = "dgrillPendientes"
        Me.dgrillPendientes.ReadOnly = True
        Me.dgrillPendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrillPendientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgrillPendientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgrillPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrillPendientes.Size = New System.Drawing.Size(811, 260)
        Me.dgrillPendientes.TabIndex = 20
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 80
        '
        'HoraDataGridViewTextBoxColumn
        '
        Me.HoraDataGridViewTextBoxColumn.DataPropertyName = "Hora"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Format = "t"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.HoraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.HoraDataGridViewTextBoxColumn.HeaderText = "Hora"
        Me.HoraDataGridViewTextBoxColumn.Name = "HoraDataGridViewTextBoxColumn"
        Me.HoraDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoraDataGridViewTextBoxColumn.Width = 60
        '
        'HabDataGridViewTextBoxColumn
        '
        Me.HabDataGridViewTextBoxColumn.DataPropertyName = "Hab"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HabDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.HabDataGridViewTextBoxColumn.HeaderText = "Hab"
        Me.HabDataGridViewTextBoxColumn.Name = "HabDataGridViewTextBoxColumn"
        Me.HabDataGridViewTextBoxColumn.ReadOnly = True
        Me.HabDataGridViewTextBoxColumn.Width = 40
        '
        'NombreHuespesDataGridViewTextBoxColumn
        '
        Me.NombreHuespesDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Huespes"
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NombreHuespesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.NombreHuespesDataGridViewTextBoxColumn.HeaderText = "N.Huesped"
        Me.NombreHuespesDataGridViewTextBoxColumn.Name = "NombreHuespesDataGridViewTextBoxColumn"
        Me.NombreHuespesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaInDataGridViewTextBoxColumn
        '
        Me.FechaInDataGridViewTextBoxColumn.DataPropertyName = "FechaIn"
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.FechaInDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.FechaInDataGridViewTextBoxColumn.HeaderText = "Fecha In"
        Me.FechaInDataGridViewTextBoxColumn.Name = "FechaInDataGridViewTextBoxColumn"
        Me.FechaInDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaInDataGridViewTextBoxColumn.Width = 85
        '
        'FechaOutDataGridViewTextBoxColumn
        '
        Me.FechaOutDataGridViewTextBoxColumn.DataPropertyName = "FechaOut"
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.FechaOutDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.FechaOutDataGridViewTextBoxColumn.HeaderText = "Fecha Out"
        Me.FechaOutDataGridViewTextBoxColumn.Name = "FechaOutDataGridViewTextBoxColumn"
        Me.FechaOutDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaOutDataGridViewTextBoxColumn.Width = 95
        '
        'PersonalDataGridViewTextBoxColumn
        '
        Me.PersonalDataGridViewTextBoxColumn.DataPropertyName = "Personal"
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PersonalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.PersonalDataGridViewTextBoxColumn.HeaderText = "Personal"
        Me.PersonalDataGridViewTextBoxColumn.Name = "PersonalDataGridViewTextBoxColumn"
        Me.PersonalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartamentosDataGridViewTextBoxColumn
        '
        Me.DepartamentosDataGridViewTextBoxColumn.DataPropertyName = "Departamentos"
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DepartamentosDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.DepartamentosDataGridViewTextBoxColumn.HeaderText = "Departamentos"
        Me.DepartamentosDataGridViewTextBoxColumn.Name = "DepartamentosDataGridViewTextBoxColumn"
        Me.DepartamentosDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartamentosDataGridViewTextBoxColumn.Width = 110
        '
        'ResponsableDataGridViewTextBoxColumn
        '
        Me.ResponsableDataGridViewTextBoxColumn.DataPropertyName = "Responsable"
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ResponsableDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.ResponsableDataGridViewTextBoxColumn.HeaderText = "Responsable"
        Me.ResponsableDataGridViewTextBoxColumn.Name = "ResponsableDataGridViewTextBoxColumn"
        Me.ResponsableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HoraAccionDataGridViewTextBoxColumn
        '
        Me.HoraAccionDataGridViewTextBoxColumn.DataPropertyName = "HoraAccion"
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.Format = "t"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.HoraAccionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.HoraAccionDataGridViewTextBoxColumn.HeaderText = "Hora de Accion"
        Me.HoraAccionDataGridViewTextBoxColumn.Name = "HoraAccionDataGridViewTextBoxColumn"
        Me.HoraAccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoraAccionDataGridViewTextBoxColumn.Visible = False
        Me.HoraAccionDataGridViewTextBoxColumn.Width = 126
        '
        'QuejasBindingSource1
        '
        Me.QuejasBindingSource1.DataMember = "Quejas"
        Me.QuejasBindingSource1.DataSource = Me.QuejasDataSet
        '
        'QuejasDataSet
        '
        Me.QuejasDataSet.DataSetName = "QuejasDataSet"
        Me.QuejasDataSet.EnforceConstraints = False
        Me.QuejasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkRealizadaP
        '
        Me.chkRealizadaP.AutoSize = True
        Me.chkRealizadaP.BackColor = System.Drawing.Color.Transparent
        Me.chkRealizadaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRealizadaP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkRealizadaP.Location = New System.Drawing.Point(836, 359)
        Me.chkRealizadaP.Name = "chkRealizadaP"
        Me.chkRealizadaP.Size = New System.Drawing.Size(81, 20)
        Me.chkRealizadaP.TabIndex = 1
        Me.chkRealizadaP.Text = "Resuelta"
        Me.ToolTip1.SetToolTip(Me.chkRealizadaP, "La queja ya esta procesada? Describa la Accion tomada.")
        Me.chkRealizadaP.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(9, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Quejas /Sugerencias"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuejasBindingSource1, "Quejas_Sugerencias", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 36)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(350, 192)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Doble Click para editar la queja o sugerencia")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(11, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Accion"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuejasBindingSource1, "Accion", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(14, 36)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(336, 192)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TextBox2, "Doble Click para editar la Accion")
        '
        'btnSalir
        '
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(828, 109)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 41)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblGuardar
        '
        Me.lblGuardar.AutoSize = True
        Me.lblGuardar.BackColor = System.Drawing.Color.Transparent
        Me.lblGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGuardar.Location = New System.Drawing.Point(89, 275)
        Me.lblGuardar.Name = "lblGuardar"
        Me.lblGuardar.Size = New System.Drawing.Size(49, 16)
        Me.lblGuardar.TabIndex = 31
        Me.lblGuardar.Text = "Label1"
        Me.lblGuardar.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(92, 294)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 234)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHoraAccion)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(466, 294)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 234)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'txtHoraAccion
        '
        Me.txtHoraAccion.Location = New System.Drawing.Point(285, 10)
        Me.txtHoraAccion.Name = "txtHoraAccion"
        Me.txtHoraAccion.ReadOnly = True
        Me.txtHoraAccion.Size = New System.Drawing.Size(65, 20)
        Me.txtHoraAccion.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(241, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Hora:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(16, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "N.Quejas"
        '
        'txtNQuejas
        '
        Me.txtNQuejas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuejasBindingSource1, "Id", True))
        Me.txtNQuejas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNQuejas.Location = New System.Drawing.Point(18, 326)
        Me.txtNQuejas.Name = "txtNQuejas"
        Me.txtNQuejas.ReadOnly = True
        Me.txtNQuejas.Size = New System.Drawing.Size(61, 20)
        Me.txtNQuejas.TabIndex = 35
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Guardar"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.Quejas.My.Resources.Resources.filesave
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(828, 11)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(89, 41)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelarAccion
        '
        Me.btnCancelarAccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelarAccion.Location = New System.Drawing.Point(828, 60)
        Me.btnCancelarAccion.Name = "btnCancelarAccion"
        Me.btnCancelarAccion.Size = New System.Drawing.Size(87, 41)
        Me.btnCancelarAccion.TabIndex = 36
        Me.btnCancelarAccion.Text = "Cancelar"
        Me.btnCancelarAccion.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Quejas.My.Resources.Resources.user_headsetRealizado1
        Me.PictureBox1.Location = New System.Drawing.Point(845, 303)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 50)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnAnteriorP
        '
        Me.btnAnteriorP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAnteriorP.ImageIndex = 1
        Me.btnAnteriorP.ImageList = Me.ImageList1
        Me.btnAnteriorP.Location = New System.Drawing.Point(828, 173)
        Me.btnAnteriorP.Name = "btnAnteriorP"
        Me.btnAnteriorP.Size = New System.Drawing.Size(41, 33)
        Me.btnAnteriorP.TabIndex = 2
        Me.btnAnteriorP.UseVisualStyleBackColor = True
        '
        'btnProximoP
        '
        Me.btnProximoP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProximoP.ImageIndex = 3
        Me.btnProximoP.ImageList = Me.ImageList1
        Me.btnProximoP.Location = New System.Drawing.Point(875, 173)
        Me.btnProximoP.Name = "btnProximoP"
        Me.btnProximoP.Size = New System.Drawing.Size(40, 33)
        Me.btnProximoP.TabIndex = 3
        Me.btnProximoP.UseVisualStyleBackColor = True
        '
        'QuejasTableAdapter
        '
        Me.QuejasTableAdapter.ClearBeforeFill = True
        '
        'frmQuejasPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(923, 540)
        Me.Controls.Add(Me.btnCancelarAccion)
        Me.Controls.Add(Me.txtNQuejas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkRealizadaP)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblGuardar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dgrillPendientes)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAnteriorP)
        Me.Controls.Add(Me.btnProximoP)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuejasPendientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quejas Pendientes"
        CType(Me.dgrillPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuejasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuejasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents dgrillPendientes As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkRealizadaP As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnAnteriorP As System.Windows.Forms.Button
    Friend WithEvents btnProximoP As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblGuardar As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents QuejasDataSet As Quejas.QuejasDataSet
    'Friend WithEvents QuejasTableAdapter As Quejas.QuejasDataSetTableAdapters.QuejasTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNQuejas As System.Windows.Forms.TextBox
    Friend WithEvents txtHoraAccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents QuejasTableAdapter As Quejas.QuejasDataSetTableAdapters.QuejasTableAdapter
    Friend WithEvents QuejasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btnCancelarAccion As System.Windows.Forms.Button
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HabDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreHuespesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaInDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaOutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartamentosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResponsableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraAccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
