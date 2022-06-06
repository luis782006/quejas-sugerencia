<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuejasRealizadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuejasRealizadas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.chkNoRealizada = New System.Windows.Forms.CheckBox()
        Me.chkRealizada = New System.Windows.Forms.CheckBox()
        Me.btnMostar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.QuejasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuejasDataSet = New Quejas.QuejasDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBuscarDepartamento = New System.Windows.Forms.Button()
        Me.comboxDepartamento = New System.Windows.Forms.ComboBox()
        Me.DepartamentosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBuscarFecha = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datepickHasta = New System.Windows.Forms.DateTimePicker()
        Me.datepickDesde = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.progresBar = New System.Windows.Forms.ProgressBar()
        Me.grupoMostrar = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grupoFiltrarF = New System.Windows.Forms.GroupBox()
        Me.grupoFiltrarD = New System.Windows.Forms.GroupBox()
        Me.grupoQuejas = New System.Windows.Forms.GroupBox()
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
        Me.grupoFiltrarE = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DepartamentosTableAdapter = New Quejas.QuejasDataSetTableAdapters.DepartamentosTableAdapter()
        Me.QuejasTableAdapter = New Quejas.QuejasDataSetTableAdapters.QuejasTableAdapter()
        CType(Me.QuejasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuejasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoMostrar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grupoFiltrarF.SuspendLayout()
        Me.grupoFiltrarD.SuspendLayout()
        Me.grupoQuejas.SuspendLayout()
        CType(Me.dgrillPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoFiltrarE.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProximo
        '
        Me.btnProximo.ImageIndex = 3
        Me.btnProximo.ImageList = Me.ImageList1
        Me.btnProximo.Location = New System.Drawing.Point(84, 347)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(53, 33)
        Me.btnProximo.TabIndex = 3
        Me.btnProximo.UseVisualStyleBackColor = True
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
        'btnAnterior
        '
        Me.btnAnterior.ImageIndex = 1
        Me.btnAnterior.ImageList = Me.ImageList1
        Me.btnAnterior.Location = New System.Drawing.Point(27, 347)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(53, 33)
        Me.btnAnterior.TabIndex = 2
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'chkNoRealizada
        '
        Me.chkNoRealizada.AutoSize = True
        Me.chkNoRealizada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoRealizada.Location = New System.Drawing.Point(9, 43)
        Me.chkNoRealizada.Name = "chkNoRealizada"
        Me.chkNoRealizada.Size = New System.Drawing.Size(110, 20)
        Me.chkNoRealizada.TabIndex = 10
        Me.chkNoRealizada.Text = "No Realizada"
        Me.chkNoRealizada.UseVisualStyleBackColor = True
        '
        'chkRealizada
        '
        Me.chkRealizada.AutoSize = True
        Me.chkRealizada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRealizada.Location = New System.Drawing.Point(9, 21)
        Me.chkRealizada.Name = "chkRealizada"
        Me.chkRealizada.Size = New System.Drawing.Size(89, 20)
        Me.chkRealizada.TabIndex = 9
        Me.chkRealizada.Text = "Realizada"
        Me.chkRealizada.UseVisualStyleBackColor = True
        '
        'btnMostar
        '
        Me.btnMostar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMostar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMostar.Image = Global.Quejas.My.Resources.Resources.funnel1
        Me.btnMostar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMostar.Location = New System.Drawing.Point(13, 34)
        Me.btnMostar.Name = "btnMostar"
        Me.btnMostar.Size = New System.Drawing.Size(104, 33)
        Me.btnMostar.TabIndex = 1
        Me.btnMostar.Text = "Mostrar Quejas"
        Me.btnMostar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnMostar, "Muestra todas las quejas realizadas")
        Me.btnMostar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuejasBindingSource, "Quejas_Sugerencias", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 33)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(345, 105)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.TabStop = False
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Quejas /Sugerencias"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Quejas.My.Resources.Resources.office_building
        Me.PictureBox1.Location = New System.Drawing.Point(9, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 37)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnBuscarDepartamento
        '
        Me.btnBuscarDepartamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscarDepartamento.Location = New System.Drawing.Point(190, 27)
        Me.btnBuscarDepartamento.Name = "btnBuscarDepartamento"
        Me.btnBuscarDepartamento.Size = New System.Drawing.Size(90, 31)
        Me.btnBuscarDepartamento.TabIndex = 8
        Me.btnBuscarDepartamento.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.btnBuscarDepartamento, "Busca las quejas realizadas por departamentos")
        Me.btnBuscarDepartamento.UseVisualStyleBackColor = True
        '
        'comboxDepartamento
        '
        Me.comboxDepartamento.DataSource = Me.DepartamentosBindingSource1
        Me.comboxDepartamento.DisplayMember = "Departamentos"
        Me.comboxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboxDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxDepartamento.FormattingEnabled = True
        Me.comboxDepartamento.Location = New System.Drawing.Point(57, 30)
        Me.comboxDepartamento.Name = "comboxDepartamento"
        Me.comboxDepartamento.Size = New System.Drawing.Size(121, 24)
        Me.comboxDepartamento.TabIndex = 7
        Me.comboxDepartamento.ValueMember = "Id"
        '
        'DepartamentosBindingSource1
        '
        Me.DepartamentosBindingSource1.DataMember = "Departamentos"
        Me.DepartamentosBindingSource1.DataSource = Me.QuejasDataSet
        '
        'DepartamentosBindingSource
        '
        Me.DepartamentosBindingSource.DataMember = "Departamentos"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Quejas.My.Resources.Resources.calendar
        Me.PictureBox2.Location = New System.Drawing.Point(7, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'btnBuscarFecha
        '
        Me.btnBuscarFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscarFecha.Location = New System.Drawing.Point(359, 26)
        Me.btnBuscarFecha.Name = "btnBuscarFecha"
        Me.btnBuscarFecha.Size = New System.Drawing.Size(85, 31)
        Me.btnBuscarFecha.TabIndex = 6
        Me.btnBuscarFecha.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.btnBuscarFecha, "Busca las quejas realizadas en un rango de fechas")
        Me.btnBuscarFecha.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde"
        '
        'datepickHasta
        '
        Me.datepickHasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.datepickHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepickHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepickHasta.Location = New System.Drawing.Point(245, 30)
        Me.datepickHasta.MinDate = New Date(2014, 11, 1, 0, 0, 0, 0)
        Me.datepickHasta.Name = "datepickHasta"
        Me.datepickHasta.Size = New System.Drawing.Size(110, 22)
        Me.datepickHasta.TabIndex = 5
        Me.datepickHasta.Value = New Date(2014, 11, 1, 0, 0, 0, 0)
        '
        'datepickDesde
        '
        Me.datepickDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.datepickDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepickDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepickDesde.Location = New System.Drawing.Point(87, 30)
        Me.datepickDesde.MinDate = New Date(2014, 11, 1, 0, 0, 0, 0)
        Me.datepickDesde.Name = "datepickDesde"
        Me.datepickDesde.Size = New System.Drawing.Size(110, 22)
        Me.datepickDesde.TabIndex = 4
        Me.datepickDesde.Value = New Date(2014, 11, 1, 0, 0, 0, 0)
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 20
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        '
        'btnExportar
        '
        Me.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExportar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExportar.Image = Global.Quejas.My.Resources.Resources.printer1
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(6, 487)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(178, 41)
        Me.btnExportar.TabIndex = 12
        Me.btnExportar.Text = "Imprimir y Exportar"
        Me.ToolTip1.SetToolTip(Me.btnExportar, "Imprmir o Exportar a carpeta local ")
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(190, 487)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(85, 41)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'progresBar
        '
        Me.progresBar.Location = New System.Drawing.Point(281, 487)
        Me.progresBar.Maximum = 200
        Me.progresBar.Name = "progresBar"
        Me.progresBar.Size = New System.Drawing.Size(629, 41)
        Me.progresBar.TabIndex = 26
        '
        'grupoMostrar
        '
        Me.grupoMostrar.Controls.Add(Me.btnMostar)
        Me.grupoMostrar.Location = New System.Drawing.Point(14, 259)
        Me.grupoMostrar.Name = "grupoMostrar"
        Me.grupoMostrar.Size = New System.Drawing.Size(130, 144)
        Me.grupoMostrar.TabIndex = 27
        Me.grupoMostrar.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(150, 259)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 144)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'grupoFiltrarF
        '
        Me.grupoFiltrarF.Controls.Add(Me.datepickHasta)
        Me.grupoFiltrarF.Controls.Add(Me.datepickDesde)
        Me.grupoFiltrarF.Controls.Add(Me.Label1)
        Me.grupoFiltrarF.Controls.Add(Me.Label2)
        Me.grupoFiltrarF.Controls.Add(Me.btnBuscarFecha)
        Me.grupoFiltrarF.Controls.Add(Me.PictureBox2)
        Me.grupoFiltrarF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grupoFiltrarF.Location = New System.Drawing.Point(8, 409)
        Me.grupoFiltrarF.Name = "grupoFiltrarF"
        Me.grupoFiltrarF.Size = New System.Drawing.Size(451, 72)
        Me.grupoFiltrarF.TabIndex = 30
        Me.grupoFiltrarF.TabStop = False
        Me.grupoFiltrarF.Text = "Filtrar por Fechas"
        '
        'grupoFiltrarD
        '
        Me.grupoFiltrarD.Controls.Add(Me.btnBuscarDepartamento)
        Me.grupoFiltrarD.Controls.Add(Me.comboxDepartamento)
        Me.grupoFiltrarD.Controls.Add(Me.PictureBox1)
        Me.grupoFiltrarD.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grupoFiltrarD.Location = New System.Drawing.Point(465, 409)
        Me.grupoFiltrarD.Name = "grupoFiltrarD"
        Me.grupoFiltrarD.Size = New System.Drawing.Size(291, 72)
        Me.grupoFiltrarD.TabIndex = 31
        Me.grupoFiltrarD.TabStop = False
        Me.grupoFiltrarD.Text = "Filtrar por Departamentos"
        '
        'grupoQuejas
        '
        Me.grupoQuejas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.grupoQuejas.Controls.Add(Me.dgrillPendientes)
        Me.grupoQuejas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grupoQuejas.Location = New System.Drawing.Point(12, 12)
        Me.grupoQuejas.Name = "grupoQuejas"
        Me.grupoQuejas.Size = New System.Drawing.Size(904, 241)
        Me.grupoQuejas.TabIndex = 32
        Me.grupoQuejas.TabStop = False
        Me.grupoQuejas.Text = "Todas las Quejas"
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
        Me.dgrillPendientes.DataSource = Me.QuejasBindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrillPendientes.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgrillPendientes.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgrillPendientes.Location = New System.Drawing.Point(6, 23)
        Me.dgrillPendientes.Name = "dgrillPendientes"
        Me.dgrillPendientes.ReadOnly = True
        Me.dgrillPendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrillPendientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgrillPendientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgrillPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrillPendientes.Size = New System.Drawing.Size(892, 212)
        Me.dgrillPendientes.TabIndex = 21
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.FechaInDataGridViewTextBoxColumn.HeaderText = "Fecha In"
        Me.FechaInDataGridViewTextBoxColumn.Name = "FechaInDataGridViewTextBoxColumn"
        Me.FechaInDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaInDataGridViewTextBoxColumn.Width = 85
        '
        'FechaOutDataGridViewTextBoxColumn
        '
        Me.FechaOutDataGridViewTextBoxColumn.DataPropertyName = "FechaOut"
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FechaOutDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.FechaOutDataGridViewTextBoxColumn.HeaderText = "Fecha Out"
        Me.FechaOutDataGridViewTextBoxColumn.Name = "FechaOutDataGridViewTextBoxColumn"
        Me.FechaOutDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaOutDataGridViewTextBoxColumn.Width = 95
        '
        'PersonalDataGridViewTextBoxColumn
        '
        Me.PersonalDataGridViewTextBoxColumn.DataPropertyName = "Personal"
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PersonalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.PersonalDataGridViewTextBoxColumn.HeaderText = "Personal"
        Me.PersonalDataGridViewTextBoxColumn.Name = "PersonalDataGridViewTextBoxColumn"
        Me.PersonalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartamentosDataGridViewTextBoxColumn
        '
        Me.DepartamentosDataGridViewTextBoxColumn.DataPropertyName = "Departamentos"
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DepartamentosDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.DepartamentosDataGridViewTextBoxColumn.HeaderText = "Departamentos"
        Me.DepartamentosDataGridViewTextBoxColumn.Name = "DepartamentosDataGridViewTextBoxColumn"
        Me.DepartamentosDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartamentosDataGridViewTextBoxColumn.Width = 110
        '
        'ResponsableDataGridViewTextBoxColumn
        '
        Me.ResponsableDataGridViewTextBoxColumn.DataPropertyName = "Responsable"
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ResponsableDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.ResponsableDataGridViewTextBoxColumn.HeaderText = "Responsable"
        Me.ResponsableDataGridViewTextBoxColumn.Name = "ResponsableDataGridViewTextBoxColumn"
        Me.ResponsableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HoraAccionDataGridViewTextBoxColumn
        '
        Me.HoraAccionDataGridViewTextBoxColumn.DataPropertyName = "HoraAccion"
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle11.Format = "t"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.HoraAccionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.HoraAccionDataGridViewTextBoxColumn.HeaderText = "Hora A"
        Me.HoraAccionDataGridViewTextBoxColumn.Name = "HoraAccionDataGridViewTextBoxColumn"
        Me.HoraAccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoraAccionDataGridViewTextBoxColumn.Width = 90
        '
        'grupoFiltrarE
        '
        Me.grupoFiltrarE.Controls.Add(Me.chkRealizada)
        Me.grupoFiltrarE.Controls.Add(Me.chkNoRealizada)
        Me.grupoFiltrarE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grupoFiltrarE.Location = New System.Drawing.Point(762, 409)
        Me.grupoFiltrarE.Name = "grupoFiltrarE"
        Me.grupoFiltrarE.Size = New System.Drawing.Size(148, 72)
        Me.grupoFiltrarE.TabIndex = 33
        Me.grupoFiltrarE.TabStop = False
        Me.grupoFiltrarE.Text = "Estados"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuejasBindingSource, "Accion", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(20, 33)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(345, 105)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Accion"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(533, 259)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(383, 144)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        '
        'DepartamentosTableAdapter
        '
        Me.DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'QuejasTableAdapter
        '
        Me.QuejasTableAdapter.ClearBeforeFill = True
        '
        'frmQuejasRealizadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(928, 540)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnProximo)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.progresBar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.grupoMostrar)
        Me.Controls.Add(Me.grupoFiltrarF)
        Me.Controls.Add(Me.grupoFiltrarD)
        Me.Controls.Add(Me.grupoQuejas)
        Me.Controls.Add(Me.grupoFiltrarE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuejasRealizadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Todas las Quejas"
        Me.TopMost = True
        CType(Me.QuejasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuejasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoMostrar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grupoFiltrarF.ResumeLayout(False)
        Me.grupoFiltrarF.PerformLayout()
        Me.grupoFiltrarD.ResumeLayout(False)
        Me.grupoQuejas.ResumeLayout(False)
        CType(Me.dgrillPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoFiltrarE.ResumeLayout(False)
        Me.grupoFiltrarE.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscarDepartamento As System.Windows.Forms.Button
    Friend WithEvents comboxDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscarFecha As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datepickHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents datepickDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnMostar As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnProximo As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents chkNoRealizada As System.Windows.Forms.CheckBox
    Friend WithEvents chkRealizada As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents progresBar As System.Windows.Forms.ProgressBar
    Friend WithEvents grupoMostrar As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grupoFiltrarF As System.Windows.Forms.GroupBox
    Friend WithEvents grupoFiltrarD As System.Windows.Forms.GroupBox
    Friend WithEvents grupoQuejas As System.Windows.Forms.GroupBox
    Friend WithEvents grupoFiltrarE As System.Windows.Forms.GroupBox
    Friend WithEvents dgrillPendientes As System.Windows.Forms.DataGridView
    Friend WithEvents DepartamentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartamentosTableAdapter As Quejas.QuejasDataSetTableAdapters.DepartamentosTableAdapter
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents QuejasTableAdapter As Quejas.QuejasDataSetTableAdapters.QuejasTableAdapter
    Friend WithEvents QuejasDataSet As Quejas.QuejasDataSet
    Friend WithEvents QuejasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartamentosBindingSource1 As System.Windows.Forms.BindingSource
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
