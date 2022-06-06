Imports System.Drawing.Printing
Public Class frmReporteFecha

    Private Sub frmReporteFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    Dim SettingP = New PageSettings
        '    SettingP.Margins.Left = 0.2
        '    SettingP.Margins.Top = 0.5
        '    SettingP.Margins.Right = 0.2
        '    SettingP.Margins.Bottom = 0.2
        '    SettingP.Landscape = True
        Me.QuejasTableAdapter.buscarFechas(QuejasDataSet.Quejas, Fecha:=fechadesde, Fecha1:=fechahasta, Fecha2:=fechadesde)
        'Me.ReportViewer1.SetPageSettings(SettingP)
        Me.ReportViewer1.RefreshReport()

    End Sub

End Class