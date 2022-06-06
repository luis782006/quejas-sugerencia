Public Class frmQuejasRealizadas

    Private Sub frmQuejasRealizadas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        'Me.Hide()
        frmGeneral.btnMostrar.Enabled = True
        Call HabilitarMenu()
        frmGeneral.Refresh() 'Refresco el form para que no se afecte el fondo
        Me.progresBar.Refresh()
        frmGeneral.MMostrarQuejas.Enabled = True
    End Sub

    Private Sub frmQuejasRealizadas_Load(sender As Object, e As EventArgs)
        ToolTip1.Active = True ' Activo el Tooltip
        btnMostar.Focus()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub btnAnterior_MouseHover(sender As Object, e As EventArgs) Handles btnAnterior.MouseHover
        btnAnterior.ImageIndex = 0
    End Sub

    Private Sub btnAnterior_MouseLeave(sender As Object, e As EventArgs) Handles btnAnterior.MouseLeave
        btnAnterior.ImageIndex = 1
    End Sub

    Private Sub btnProximo_MouseHover(sender As Object, e As EventArgs) Handles btnProximo.MouseHover
        btnProximo.ImageIndex = 2
    End Sub

    Private Sub btnProximo_MouseLeave(sender As Object, e As EventArgs) Handles btnProximo.MouseLeave
        btnProximo.ImageIndex = 3
    End Sub

   
    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub btnBuscarFecha_Click(sender As Object, e As EventArgs) Handles btnBuscarFecha.Click
        Dim cntR As Integer ' cantidad de registro
        fechadesde = datepickDesde.Text
        If datepickHasta.Value < datepickDesde.Value Then
            MsgBox("Los paremtros de fecha son erroneos", MsgBoxStyle.Critical, "Quejas realizadas")
        Else
            cntR = QuejasBindingSource.Count
            progresBar.Maximum = cntR
            Do While progresBar.Value < cntR
                progresBar.Increment(1)

                btnExportar.Enabled = False
                btnSalir.Enabled = False
                grupoFiltrarF.Enabled = False
                grupoFiltrarD.Enabled = False
                grupoFiltrarE.Enabled = False
            Loop
            progresBar.Value = 0
            grupoQuejas.Text = "Quejas desde el " + datepickDesde.Text + " hasta " + datepickHasta.Text
            Me.QuejasTableAdapter.buscarFechas(QuejasDataSet.Quejas, Fecha:=datepickDesde.Text, Fecha1:=datepickHasta.Text, Fecha2:=datepickDesde.Text)

            btnExportar.Enabled = True
            btnSalir.Enabled = True
            grupoFiltrarF.Enabled = True
            grupoFiltrarD.Enabled = True
            grupoFiltrarE.Enabled = True
            comboxDepartamento.SelectedItem = -1
        End If

    End Sub

    Private Sub btnBuscarDepartamento_Click(sender As Object, e As EventArgs) Handles btnBuscarDepartamento.Click
        Dim cntR As Integer
        cntR = QuejasBindingSource.Count
        progresBar.Maximum = cntR
        Do While progresBar.Value < cntR
            progresBar.Increment(1)

            btnExportar.Enabled = False
            btnSalir.Enabled = False
            grupoFiltrarF.Enabled = False
            grupoFiltrarD.Enabled = False
            grupoFiltrarE.Enabled = False
        Loop
        progresBar.Value = 0
        grupoQuejas.Text = "Quejas del departamento" + comboxDepartamento.Text
        Me.QuejasTableAdapter.buscarDepartamento(QuejasDataSet.Quejas, Departamentos:=comboxDepartamento.Text)
        chkRealizada.Checked = False
        grupoFiltrarF.Enabled = True
        grupoFiltrarD.Enabled = True
        grupoFiltrarE.Enabled = True

        btnExportar.Enabled = True
        btnSalir.Enabled = True


    End Sub

    Private Sub chkRealizada_CheckedChanged(sender As Object, e As EventArgs) Handles chkRealizada.CheckedChanged
        Dim cntR As Integer
        cntR = QuejasBindingSource.Count
        chkNoRealizada.Enabled = False
        progresBar.Maximum = cntR
        If chkRealizada.CheckState = CheckState.Checked Then ' Compruebo el estado de chkmark si esta checheado hago el loop
            'En la propiedad   _CheckedChanged si cambia el estadose activa. 

            Do While progresBar.Value < cntR
                progresBar.Increment(1)

                btnExportar.Enabled = False
                btnSalir.Enabled = False
                grupoFiltrarF.Enabled = False
                grupoFiltrarD.Enabled = False
                grupoFiltrarE.Enabled = False
            Loop
            progresBar.Value = 0
            grupoQuejas.Text = "Quejas realizadas"
            Me.QuejasTableAdapter.Realizadas(QuejasDataSet.Quejas)
            grupoFiltrarF.Enabled = True
            grupoFiltrarD.Enabled = True
            grupoFiltrarE.Enabled = True

            btnExportar.Enabled = True
            btnSalir.Enabled = True
            comboxDepartamento.Text = ""
        Else
            Me.QuejasTableAdapter.Consulta(QuejasDataSet.Quejas)
            comboxDepartamento.Text = ""
            chkNoRealizada.Enabled = True
        End If
    End Sub

    Private Sub chkNoRealizada_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoRealizada.CheckedChanged
        Dim cntR As Integer
        cntR = QuejasBindingSource.Count
        progresBar.Maximum = cntR
        chkRealizada.Enabled = False
        If chkNoRealizada.CheckState = CheckState.Checked Then ' Compruebo el estado de chkmark si esta checheado hago el loop
            'En la propiedad   _CheckedChanged si cambia el estado se activa. 

            Do While progresBar.Value < cntR
                progresBar.Increment(1)

                btnExportar.Enabled = False
                btnSalir.Enabled = False
                grupoFiltrarF.Enabled = False
                grupoFiltrarD.Enabled = False
                grupoFiltrarE.Enabled = False
            Loop

            progresBar.Value = 0
            grupoQuejas.Text = "Quejas No realizadas"
            Me.QuejasTableAdapter.noRea(QuejasDataSet.Quejas)
            grupoFiltrarF.Enabled = True
            grupoFiltrarD.Enabled = True
            grupoFiltrarE.Enabled = True

            btnExportar.Enabled = True
            btnSalir.Enabled = True
            comboxDepartamento.Text = ""
        Else
            Me.QuejasTableAdapter.Consulta(QuejasDataSet.Quejas)
            chkNoRealizada.Checked = False
            comboxDepartamento.Text = ""
            chkRealizada.Enabled = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        frmGeneral.Refresh() 'Refresco el form para que no se afecte el fondo
        Me.Hide()
        Call HabilitarMenu()
    End Sub

    Private Sub btnMostar_Click(sender As Object, e As EventArgs) Handles btnMostar.Click
        grupoQuejas.Text = "Todas las Quejas"
        QuejasTableAdapter.Consulta(QuejasDataSet.Quejas)
        chkRealizada.CheckState = CheckState.Unchecked
        chkNoRealizada.CheckState = CheckState.Unchecked
        chkRealizada.Enabled = True
        chkNoRealizada.Enabled = True
        comboxDepartamento.SelectedItem = -1
     
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If grupoQuejas.Text = "Todas las Quejas" Then
            ReportesGeneral.Show()
        Else
            If grupoQuejas.Text = "Quejas desde el " + datepickDesde.Text + " hasta " + datepickHasta.Text Then
                fechadesde = datepickDesde.Text
                fechahasta = datepickHasta.Text
                frmReporteFecha.Show()
            Else
                If grupoQuejas.Text = "Quejas del departamento" + comboxDepartamento.Text Then
                    departamento = comboxDepartamento.Text
                    ReportesDepartamentos.Show()
                Else
                    If chkRealizada.Checked = True Then
                        ReportesRealizadas.Show()
                    Else
                        If chkNoRealizada.Checked = True Then
                            ReportesNoRea.Show()
                        End If
                    End If

                End If
            End If
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs)
        'Este boton servira para imprimir las quejas que hayan en el datagridview 
    End Sub

    Private Sub frmQuejasRealizadas_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Departamentos' Puede moverla o quitarla según sea necesario.
        Me.DepartamentosTableAdapter.Fill(Me.QuejasDataSet.Departamentos)
        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Quejas' Puede moverla o quitarla según sea necesario.
        Me.QuejasTableAdapter.Consulta(Me.QuejasDataSet.Quejas)
        btnMostar.Focus()
        comboxDepartamento.SelectedIndex = -1
        datepickDesde.Value = Date.Today
        datepickHasta.Value = Date.Today


    End Sub

    Private Sub grupoFiltrarF_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        QuejasBindingSource.MoveNext()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        QuejasBindingSource.MovePrevious()
    End Sub

End Class