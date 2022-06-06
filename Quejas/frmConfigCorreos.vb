Public Class frmConfigCorreos

    Private Sub frmConfigCorreos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Call HabilitarMenu()
        frmGeneral.MConfiguracion.Enabled = True
        Call ConfigBloqueo()
    End Sub

    Private Sub ConfigCorreosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ConfigCorreosBindingSource.EndEdit()


    End Sub


    Private Sub frmConfigCorreos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet2.ConfigCorreos' Puede moverla o quitarla según sea necesario.
        Me.ConfigCorreosTableAdapter.Fill(Me.QuejasDataSet2.ConfigCorreos)

        IdConfig.Focus()
        If IdConfig.Text <> "" Then
            btnModificarConfig.Enabled = True
            borrarConfig.Enabled = True
            btnConfig.Enabled = True
            btnConfigGuardar.Enabled = False
        End If
    End Sub

    Private Sub btnConfigGuardar_Click(sender As Object, e As EventArgs) Handles btnConfigGuardar.Click
        If txtHost.Text = "" Or txtPort.Text = "" Or txtDesde.Text = "" Or txtCredencial.Text = "" Or txtContraseña.Text = "" Then
            MsgBox("Debe llenar todos los campos para guardar la configuracion", MsgBoxStyle.Exclamation, "Configuracion de Correos")
            btnConfigGuardar.Enabled = True
            btnConfig.Enabled = False
            btnModificarConfig.Enabled = False
            borrarConfig.Enabled = False
        Else
            Me.ConfigCorreosTableAdapter.Insert(txtHost.Text, txtPort.Text, txtDesde.Text, txtContraseña.Text, txtCredencial.Text)
            Me.ConfigCorreosTableAdapter.Fill(QuejasDataSet2.ConfigCorreos)
            MsgBox("Se han ajustado los cambios necesarios para el envio de correos", MsgBoxStyle.Information, "Configuracion de correos")
            host = txtHost.Text
            puerto = txtPort.Text
            contraseña = txtContraseña.Text
            desde = txtDesde.Text
            credencial = txtCredencial.Text
            btnConfigGuardar.Enabled = False
            btnConfig.Enabled = False
            btnConfig.Enabled = True
            btnModificarConfig.Enabled = True
            borrarConfig.Enabled = True
            txtPort.ReadOnly = True
            txtHost.ReadOnly = True
            txtDesde.ReadOnly = True
            txtCredencial.ReadOnly = True
            txtContraseña.ReadOnly = True

        End If
       


     
    End Sub

    Private Sub borrarConfig_Click(sender As Object, e As EventArgs) Handles borrarConfig.Click
        Dim respuesta As Object
        If txtPort.Text = "" Or txtHost.Text = "" Or txtDesde.Text = "" Or txtCredencial.Text = "" Or txtContraseña.Text = "" Then
            MsgBox("No hay datos que resetear", MsgBoxStyle.Exclamation, "Configuracion de Correos")
        Else
            respuesta = MsgBox("Desea resetear los parametros de Configuracion", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Configuracion de Correos")
            If respuesta = vbYes Then
                txtPort.Text = ""
                txtHost.Text = ""
                txtDesde.Text = ""
                txtCredencial.Text = ""
                txtContraseña.Text = ""
                btnConfigGuardar.Enabled = True
                btnModificarConfig.Enabled = False
                borrarConfig.Enabled = False

            End If
        End If
    End Sub


    Private Sub txtPort_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPort.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        txtHost.Focus()
        txtPort.ReadOnly = False
        txtHost.ReadOnly = False
        txtDesde.ReadOnly = False
        txtCredencial.ReadOnly = False
        txtContraseña.ReadOnly = False
        btnConfig.Enabled = False
    End Sub

    Private Sub btnModificarConfig_Click(sender As Object, e As EventArgs) Handles btnModificarConfig.Click
        Me.ConfigCorreosTableAdapter.Modificar(txtHost.Text, txtPort.Text, txtDesde.Text, txtContraseña.Text, txtCredencial.Text, IdConfig.Text)
        Me.ConfigCorreosTableAdapter.Fill(QuejasDataSet2.ConfigCorreos)
        MsgBox("Se han modificados los cambios necesarios para el envio de correos", MsgBoxStyle.Information, "Configuracion de correos")
        host = txtHost.Text
        puerto = txtPort.Text
        contraseña = txtContraseña.Text
        desde = txtDesde.Text
        credencial = txtCredencial.Text
        txtPort.ReadOnly = True
        txtHost.ReadOnly = True
        txtDesde.ReadOnly = True
        txtCredencial.ReadOnly = True
        txtContraseña.ReadOnly = True
    End Sub

End Class