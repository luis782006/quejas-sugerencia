
Public Class frmGeneral

    Public frmAbierto As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim QuejasRealizadas As New frmQuejasRealizadas
        QuejasRealizadas.MdiParent = Me
        QuejasRealizadas.Show()
        btnMostrar.Enabled = False
        Call DeshabilitarMenu()

    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles btnMostrar.MouseHover
        btnMostrar.ImageIndex = 1


    End Sub

    Private Sub btnMostrar_MouseLeave(sender As Object, e As EventArgs) Handles btnMostrar.MouseLeave
        btnMostrar.ImageIndex = 0

    End Sub


    Private Sub btnInsertarQueja_MouseHover(sender As Object, e As EventArgs) Handles btnInsertarQueja.MouseHover
        btnInsertarQueja.ImageIndex = 2
    End Sub

    Private Sub btnInsertarQueja_MouseLeave(sender As Object, e As EventArgs) Handles btnInsertarQueja.MouseLeave
        btnInsertarQueja.ImageIndex = 3
    End Sub


    Private Sub btnQuejasPendientes_MouseHover(sender As Object, e As EventArgs) Handles btnQuejasPendientes.MouseHover
        btnQuejasPendientes.ImageIndex = 4
    End Sub

    Private Sub btnQuejasPendientes_MouseLeave(sender As Object, e As EventArgs) Handles btnQuejasPendientes.MouseLeave
        btnQuejasPendientes.ImageIndex = 5
    End Sub

    Private Sub btnEnviarQuejas_MouseHover(sender As Object, e As EventArgs) Handles btnEnviarQuejas.MouseHover
        btnEnviarQuejas.ImageIndex = 6
    End Sub

    Private Sub btnEnviarQuejas_MouseLeave(sender As Object, e As EventArgs) Handles btnEnviarQuejas.MouseLeave
        btnEnviarQuejas.ImageIndex = 7
    End Sub

    Private Sub btnAjustes_MouseHover(sender As Object, e As EventArgs) Handles btnAjustes.MouseHover
        btnAjustes.ImageIndex = 8
    End Sub

    Private Sub btnAjustes_MouseLeave(sender As Object, e As EventArgs) Handles btnAjustes.MouseLeave
        btnAjustes.ImageIndex = 9
    End Sub

    Private Sub AcualizarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Refresh()
    End Sub

    Private Sub btnQuejasPendientes_Click(sender As Object, e As EventArgs) Handles btnQuejasPendientes.Click
        Dim QuejasPendientes As New frmQuejasPendientes
        QuejasPendientes.MdiParent = Me
        QuejasPendientes.Show()
        Call DeshabilitarMenu()




    End Sub

    Private Sub btnInsertarQueja_Click(sender As Object, e As EventArgs) Handles btnInsertarQueja.Click
        Dim InsertarQuejas As New frmInsertarQuejas
        InsertarQuejas.MdiParent = Me
        InsertarQuejas.Show()
        Call DeshabilitarMenu()
        Call Conectar_Base()


    End Sub

    Private Sub frmGeneral_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub



    Private Sub btnAjustes_Click(sender As Object, e As EventArgs) Handles btnAjustes.Click
        Dim Ajustes As New frmAjustes
        Ajustes.MdiParent = Me
        Ajustes.Show()
        Call DeshabilitarMenu()
        MAjusteDeSistema.Enabled = False
    End Sub

    Private Sub btnEnviarQuejas_Click(sender As Object, e As EventArgs) Handles btnEnviarQuejas.Click
        Dim EnvioQuejas As New frmEnvioQuejas
        Dim abrirVentanaFileH As New OpenFileDialog  'declaro varible como nuevo openDialog para buscar la cadena dee conexion

        EnvioQuejas.MdiParent = Me
        EnvioQuejas.StartPosition = FormStartPosition.CenterScreen

        If abrirVentanaFileH.ShowDialog() = Windows.Forms.DialogResult.OK Then ' si la ventana se abre y se da ok se le pasa el valor al txt
            Call DeshabilitarMenu()
            EnvioQuejas.lbAdjunto.Text = abrirVentanaFileH.FileName ' se le da el valor al txt
            EnvioQuejas.Show()
            btnEnviarQuejas.Enabled = False
            MEnviarQuejas.Enabled = False
        End If
    End Sub
    Private Sub frmGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HelpProvider1.HelpNamespace = rutaHelp

    End Sub
    'Para el uso del keyCode se debe llamar el namespace dentro del sub.
    Private Sub frmGeneral_Keyup(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F1 Then
            Help.ShowHelp(Me, HelpProvider1.HelpNamespace)
        End If
    End Sub

    Private Sub InsertarQuejasALTIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MInsertarQuejas.Click
        Dim InsertarQuejas As New frmInsertarQuejas
        InsertarQuejas.MdiParent = Me
        InsertarQuejas.Show()
        Call DeshabilitarMenu()
        Call Conectar_Base()
        MInsertarQuejas.Enabled = False
    End Sub

    Private Sub MQuejasPendientes_Click(sender As Object, e As EventArgs) Handles MQuejasPendientes.Click
        Dim QuejasPendientes As New frmQuejasPendientes
        QuejasPendientes.MdiParent = Me
        QuejasPendientes.Show()
        Call DeshabilitarMenu()
        MQuejasPendientes.Enabled = False
    End Sub

    Private Sub MMostrarQuejas_Click(sender As Object, e As EventArgs) Handles MMostrarQuejas.Click
        Dim QuejasRealizadas As New frmQuejasRealizadas
        QuejasRealizadas.MdiParent = Me
        QuejasRealizadas.Show()
        btnMostrar.Enabled = False
        Call DeshabilitarMenu()
        MMostrarQuejas.Enabled = False
    End Sub

    Private Sub MEnviarQuejas_Click(sender As Object, e As EventArgs) Handles MEnviarQuejas.Click
        Dim EnvioQuejas As New frmEnvioQuejas
        Dim abrirVentanaFileH As New OpenFileDialog  'declaro varible como nuevo openDialog para buscar la cadena dee conexion

        EnvioQuejas.MdiParent = Me
        EnvioQuejas.StartPosition = FormStartPosition.CenterScreen

        If abrirVentanaFileH.ShowDialog() = Windows.Forms.DialogResult.OK Then ' si la ventana se abre y se da ok se le pasa el valor al txt
            EnvioQuejas.lbAdjunto.Text = abrirVentanaFileH.FileName ' se le da el valor al txt
            EnvioQuejas.Show()
        End If

        MEnviarQuejas.Enabled = True
    End Sub


    Private Sub MAjusteDeSistema_Click(sender As Object, e As EventArgs) Handles MAjusteDeSistema.Click
        Dim Ajustes As New frmAjustes
        Ajustes.MdiParent = Me
        Ajustes.Show()
        Call DeshabilitarMenu()
        MAjusteDeSistema.Enabled = False
    End Sub

    Private Sub VerLaAyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerLaAyudaToolStripMenuItem.Click
        Help.ShowHelp(Me, HelpProvider1.HelpNamespace)

    End Sub

    Private Sub AcercaDeSistemasQuejasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeSistemasQuejasToolStripMenuItem.Click
        frmAcercade.Show()
    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MConfiguracion.Click
        Dim configCorreos As New frmConfigCorreos
        configCorreos.MdiParent = Me
        configCorreos.Show()
        Call DeshabilitarMenu()
        MConfiguracion.Enabled = False
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class