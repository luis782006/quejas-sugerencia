Imports System.Drawing.Printing
Public Class ReportesRealizadas

    Private Sub ReportesRealizadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Quejas' Puede moverla o quitarla según sea necesario.
        Me.QuejasTableAdapter.Realizadas(Me.QuejasDataSet.Quejas)
        'Dim SettingP = New PageSettings
        'Dim SettingG = New PageSettings
        ''**********PrintSetting************
        'SettingP.Margins.Left = 0.2
        'SettingP.Margins.Top = 0.5
        'SettingP.Margins.Right = 0.2
        'SettingP.Margins.Bottom = 0.2
        'SettingP.Landscape = True
        ''*******************************
        ''**********GuardarPdfSetting*************

        ''******************
        ''TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Quejas' Puede moverla o quitarla según sea necesario.
        'Me.QuejasTableAdapter.Realizadas(Me.QuejasDataSet.Quejas)
        'Me.ReportViewer1.SetPageSettings(SettingP)
       

        Me.ReportViewer1.RefreshReport()


    End Sub

  
End Class