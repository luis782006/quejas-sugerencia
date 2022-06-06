<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesNoRea
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportesNoRea))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.QuejasDataSet = New Quejas.QuejasDataSet()
        Me.QuejasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuejasTableAdapter = New Quejas.QuejasDataSetTableAdapters.QuejasTableAdapter()
        CType(Me.QuejasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuejasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetNoRea"
        ReportDataSource1.Value = Me.QuejasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Quejas.ReporteNoRea.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(667, 534)
        Me.ReportViewer1.TabIndex = 0
        '
        'QuejasDataSet
        '
        Me.QuejasDataSet.DataSetName = "QuejasDataSet"
        Me.QuejasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuejasBindingSource
        '
        Me.QuejasBindingSource.DataMember = "Quejas"
        Me.QuejasBindingSource.DataSource = Me.QuejasDataSet
        '
        'QuejasTableAdapter
        '
        Me.QuejasTableAdapter.ClearBeforeFill = True
        '
        'ReportesNoRea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 534)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportesNoRea"
        Me.Text = "Reportes No Realizadas"
        CType(Me.QuejasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuejasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents QuejasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QuejasDataSet As Quejas.QuejasDataSet
    Friend WithEvents QuejasTableAdapter As Quejas.QuejasDataSetTableAdapters.QuejasTableAdapter
End Class
