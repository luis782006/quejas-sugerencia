Public Class frmQuejasPendientes

    Private Sub frmQuejasPendientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Call HabilitarMenu()
        Me.Refresh()
        frmGeneral.Refresh()
        lblGuardar.Visible = False
        frmGeneral.MQuejasPendientes.Enabled = True
      
    End Sub

    
    Private Sub chkRealizada_CheckedChanged(sender As Object, e As EventArgs) Handles chkRealizadaP.CheckedChanged
        If chkRealizadaP.CheckState = CheckState.Checked Then
            TextBox2.ReadOnly = False
            TextBox2.Focus()
            txtHoraAccion.Text = TimeOfDay
        Else
            lblGuardar.Visible = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Call HabilitarMenu()
        Me.Close()
        lblGuardar.Visible = False
       
    End Sub

    Private Sub btnAnteriorP_MouseHover(sender As Object, e As EventArgs) Handles btnAnteriorP.MouseHover
        btnAnteriorP.ImageIndex = 0
    End Sub

    Private Sub btnAnteriorP_MouseLeave(sender As Object, e As EventArgs) Handles btnAnteriorP.MouseLeave
        btnAnteriorP.ImageIndex = 1
    End Sub

    Private Sub btnProximoP_MouseHover(sender As Object, e As EventArgs) Handles btnProximoP.MouseHover
        btnProximoP.ImageIndex = 2
    End Sub

    Private Sub btnProximoP_MouseLeave(sender As Object, e As EventArgs) Handles btnProximoP.MouseLeave
        btnProximoP.ImageIndex = 3
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cntD As Integer
        Dim I As Integer
        lblGuardar.Text = ""
        If TextBox2.Text = "" Then
            MsgBox("No hay cambios que guardar", MsgBoxStyle.Information, "Quejas Pendientes")
        Else
            Try
                QuejasTableAdapter.ActualizarAccion(TextBox1.Text, TextBox2.Text, TimeOfDay, txtNQuejas.Text) ' Actualizo la queja, le paso el valor del txt que contiene la accion y el n.de queja
                MsgBox("La queja se modifico correctamente", MsgBoxStyle.Information, "Queja Procesada")
                Me.QuejasTableAdapter.Consulta(Me.QuejasDataSet.Quejas)
                lblGuardar.Visible = False
                chkRealizadaP.CheckState = False
                TextBox1.ReadOnly = True
                TextBox2.ReadOnly = True
                txtHoraAccion.Text = ""
            Catch ex As Exception
                If ex.ToString.Contains("de la cadena") Then
                    MsgBox("Se nececitan todos los parametros para Guardar los datos", MsgBoxStyle.Critical, "Quejas pendientes")
                    TextBox1.ReadOnly = True
                    TextBox1.Text = ""
                    TextBox2.ReadOnly = True
                    TextBox2.Text = ""
                    txtHoraAccion.Text = ""
                End If
            End Try
        End If
        cntD = dgrillPendientes.RowCount - 1
        Try
            For I = txtNQuejas.Text To cntD
                QuejasBindingSource1.MoveNext()

                If TextBox2.Text = "" Then
                    lblGuardar.Text = " Existen quejas pendientes"
                    lblGuardar.Visible = True
                    lblGuardar.ForeColor = Color.Red

                End If

            Next
        Catch ex As Exception
            MsgBox("Queja inexistente", MsgBoxStyle.Critical, "Quejas pendientes")

        End Try

        QuejasBindingSource1.MoveFirst()
        lblGuardar.Visible = True
    End Sub

    'Private Sub frmQuejasPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    ToolTip1.Hide(btnGuardar) ' oculto informacion del tiptool de boton guardar
    '    'Try
    '    dgrillPendientes.DataBindings.Clear() ' limpio la grilla para no sobrecargarla
    '    'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Quejas' Puede moverla o quitarla según sea necesario.
    '    Me.QuejasTableAdapter.FillBy(Me.QuejasDataSet.Quejas)
    '    lblGuardar.Visible = True
    '    lblGuardar.ForeColor = Color.Red
    '    lblGuardar.Text = " Existen quejas pendientes. Si la queja ya fue procesada realice los cambios"
    '    'Catch ex As Exception
    '    'MsgBox(ex.ToString)
    '    'End Try

    'End Sub

    Private Sub btnProximoP_Click(sender As Object, e As EventArgs) Handles btnProximoP.Click
        QuejasBindingSource1.MoveNext()
        If TextBox2.Text = "" Then
            lblGuardar.Visible = True
            lblGuardar.ForeColor = Color.White
            lblGuardar.Text = " Esta queja esta pendiente. Si la queja ya fue procesada realice los cambios"

        Else
            lblGuardar.Visible = False
        End If
    End Sub

    Private Sub btnAnteriorP_Click(sender As Object, e As EventArgs) Handles btnAnteriorP.Click
        QuejasBindingSource1.MovePrevious()
        If TextBox2.Text = "" Then
            lblGuardar.Visible = True
            lblGuardar.ForeColor = Color.White
            lblGuardar.Text = " Esta queja esta pendiente. Si la queja ya fue procesada realice los cambios"
        Else
            lblGuardar.Visible = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        lblGuardar.Text = "Guarde los cambios una vez realizada la modificacion"


    End Sub

   

    Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
        TextBox1.ReadOnly = False
    End Sub

    Private Sub TextBox2_DoubleClick(sender As Object, e As EventArgs) Handles TextBox2.DoubleClick
        If TextBox2.Text = "" Then
            MsgBox("Para modificar el estado de esta queja debe marcar el CheckMark (Resuelta) ", MsgBoxStyle.Information, "Queja a Modificar Accion")
            chkRealizadaP.Focus()
        Else
            TextBox2.ReadOnly = False
        End If
    End Sub

    Private Sub frmQuejasPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Quejas' Puede moverla o quitarla según sea necesario.
        Me.QuejasTableAdapter.Consulta(Me.QuejasDataSet.Quejas)


    End Sub

    Private Sub btnCancelarAccion_Click(sender As Object, e As EventArgs) Handles btnCancelarAccion.Click
        If TextBox1.Text = "" Then
            MsgBox("Inserte la Queja/Sugerencia del Huesped", MsgBoxStyle.Critical, "Quejas")
            TextBox1.Focus()
        Else
            QuejasTableAdapter.Consulta(QuejasDataSet.Quejas)
            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
        End If
    End Sub

    Private Sub dgrillPendientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrillPendientes.CellClick
        If TextBox2.Text = "" Then
            lblGuardar.Visible = True
            lblGuardar.ForeColor = Color.White
            lblGuardar.Text = " Esta queja esta pendiente. Si la queja ya fue procesada realice los cambios"
        Else
            lblGuardar.Visible = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    'Dim contenido As String
    '    contenido = TextBox2.Text
    '    ToolTip1.SetToolTip(TextBox1, contenido)
End Class