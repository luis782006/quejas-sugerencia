Imports System.Drawing.Printing
Public Class ReportesGeneral

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim SettingP = New PageSettings
        'SettingP.Margins.Left = 0.2
        'SettingP.Margins.Top = 0.5
        'SettingP.Margins.Right = 0.2
        'SettingP.Margins.Bottom = 0.2
        'SettingP.Landscape = True
        ''TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Quejas' Puede moverla o quitarla según sea necesario.
        Me.QuejasTableAdapter.Consulta(Me.QuejasDataSet.Quejas)
        'Me.ReportViewer1.SetPageSettings(SettingP)
        Me.ReportViewer1.RefreshReport()

    End Sub


End Class