Public Class frmInsertarQuejas

    Private Sub frmInsertarQuejas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Call HabilitarMenu()
        frmGeneral.Refresh()
        frmGeneral.MInsertarQuejas.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Call HabilitarMenu()
        Me.Close()
    End Sub

    Private Sub frmInsertarQuejas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
        Me.DepartamentosTableAdapter.Fill(Me.QuejasDataSet.Departamentos)
        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Personal' Puede moverla o quitarla según sea necesario.
        Me.PersonalTableAdapter.Fill(Me.QuejasDataSet.Personal)
        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
        Me.HabitacionesTableAdapter.Fill(Me.QuejasDataSet.Habitaciones)
        txtHoraQH.Text = TimeOfDay
        comboxHab.Focus()
        comboxHab.SelectedIndex = -1
        txtNombreH.Text = ""
        comboxColaborador.SelectedIndex = -1
        TextBox1.Text = ""
        ComboBox1.SelectedIndex = -1
        txtResponsable.Text = ""
        txtAccion.Text = ""
        txtHoraQAccion.Text = ""
    End Sub

   
    Private Sub btnQuejasP_Click(sender As Object, e As EventArgs) Handles btnQuejasP.Click
        Me.Hide()
        Call AbrirVentanaP()
        Call DeshabilitarMenu()

    End Sub

    Private Sub chkHoraAccion_CheckedChanged(sender As Object, e As EventArgs) Handles chkHoraAccion.CheckedChanged
        If chkHoraAccion.CheckState = CheckState.Checked Then
            txtHoraQAccion.Text = TimeOfDay
        Else
            txtHoraQAccion.Text = ""
            chkHoraAccion.CheckState = False
        End If

    End Sub

    Private Sub btnInserta_Quejas_Click(sender As Object, e As EventArgs) Handles btnInserta_Quejas.Click
        If chkInfoH.CheckState = CheckState.Checked Then
            datePickerIn.Text = TimeOfDay
            datePieckerOut.Text = TimeOfDay
            comboxHab.SelectedIndex = 0
            txtNombreH.Text = "InfoGeneral"
            ConsultaSql = "Insert into Quejas (Fecha,Hora,Hab,Nombre_Huespes,FechaIn,FechaOut,Colaborador,Quejas_Sugerencias,Departamento,Responsable) Values('" & DateTimePicker1.Text & "','" & txtHoraQH.Text & "','" & comboxHab.SelectedValue & "','" & txtNombreH.Text & "','" & datePickerIn.Text & "','" & datePieckerOut.Text & "','" & comboxColaborador.SelectedValue & "','" & TextBox1.Text & "','" & ComboBox1.SelectedValue & "','" & txtResponsable.Text & "')"
            Comando.CommandType = CommandType.Text 'al comando le digo que sera tipo Type y que el type es de text
            Comando.CommandText = ConsultaSql ' al comando tipo texto le doy el valo dela consulta 
            Call Conectar_Base() ' me conecto a la base
            Conexion.Open() ' abro conexion
            Try
                Comando.ExecuteNonQuery() ' Ejecuto el comando
                MsgBox("Se ingreso la info", MsgBoxStyle.Information, "Nueva informacion general")
                comboxHab.SelectedIndex = -1
                txtNombreH.Text = ""
                comboxColaborador.SelectedIndex = -1
                TextBox1.Text = ""
                ComboBox1.SelectedIndex = -1
                txtResponsable.Text = ""
                txtAccion.Text = ""
                txtHoraQAccion.Text = ""
                chkInfoH.Checked = False
            Catch ex As Exception

                If ex.ToString.Contains("los tipos de datos") Then
                    MsgBox("Uhmmm.Existen campos vacios.Para insertar una queja llene todos los campos", MsgBoxStyle.Critical, "Informacion General")
                End If

            End Try
        Else
                    'probando codigo infocheck.
                    datePickerIn.Text = TimeOfDay
            datePieckerOut.Text = TimeOfDay
            ConsultaSql = "Insert into Quejas (Fecha,Hora,Hab,Nombre_Huespes,FechaIn,FechaOut,Colaborador,Quejas_Sugerencias,Departamento,Responsable) Values('" & DateTimePicker1.Text & "','" & txtHoraQH.Text & "','" & comboxHab.SelectedValue & "','" & txtNombreH.Text & "','" & datePickerIn.Text & "','" & datePieckerOut.Text & "','" & comboxColaborador.SelectedValue & "','" & TextBox1.Text & "','" & ComboBox1.SelectedValue & "','" & txtResponsable.Text & "')"
            Comando.CommandType = CommandType.Text 'al comando le digo que sera tipo Type y que el type es de text
            Comando.CommandText = ConsultaSql ' al comando tipo texto le doy el valo dela consulta 
            Call Conectar_Base() ' me conecto a la base
            Conexion.Open() ' abro conexion
            Try
                Comando.ExecuteNonQuery() ' Ejecuto el comando
                MsgBox("Se ingreso la queja", MsgBoxStyle.Information, "Nuevo Queja")
                comboxHab.SelectedIndex = -1
                txtNombreH.Text = ""
                comboxColaborador.SelectedIndex = -1
                TextBox1.Text = ""
                ComboBox1.SelectedIndex = -1
                txtResponsable.Text = ""
                txtAccion.Text = ""
                txtHoraQAccion.Text = ""
                chkInfoH.Checked = False
            Catch ex As Exception

                If ex.ToString.Contains("los tipos de datos") Then
                    MsgBox("Existen campos vacios.Para insertar una queja llene todos los campos", MsgBoxStyle.Critical, "Insertar Quejas")
                End If

            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(comboxHab.SelectedIndex)
    End Sub

    Private Sub txtNombreH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreH.KeyPress
        If Not (Char.IsLetter(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And Not (Char.IsSeparator(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtResponsable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtResponsable.KeyPress
        If Not (Char.IsLetter(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And Not (Char.IsSeparator(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub



    Private Sub chkInfoH_CheckedChanged(sender As Object, e As EventArgs) Handles chkInfoH.CheckedChanged
        If chkInfoH.CheckState = CheckState.Checked Then
            grpDatos.Enabled = False
            txtNombreH.Text = "InfoGeneral"


        ElseIf chkInfoH.CheckState = CheckState.Unchecked Then
            grpDatos.Enabled = True
            txtNombreH.Text = ""


        End If
    End Sub


End Class