Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration

Public Class frmAjustes

    Private Sub frmAjustes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Correos' Puede moverla o quitarla según sea necesario.
        Me.CorreosTableAdapter.Fill(Me.QuejasDataSet.Correos)
        Call Conectar_Base()
        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Departamentos' Puede moverla o quitarla según sea necesario.
        Me.DepartamentosTableAdapter.Fill(Me.QuejasDataSet.Departamentos)

        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Habitaciones' Puede moverla o quitarla según sea necesario.
        Me.HabitacionesTableAdapter.Fill(Me.QuejasDataSet.Habitaciones)

        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Personal' Puede moverla o quitarla según sea necesario.
        Me.PersonalTableAdapter.Fill(Me.QuejasDataSet.Personal)
        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Personal' Puede moverla o quitarla según sea necesario.
        lblFirma.Text = frmInicio.lblFirma.Text
        txtNombreInst.Text = frmInicio.lblInicioNombreH.Text
        btnAplicarFirma.Enabled = False
        lblAjusteNombreH.Text = frmInicio.lblInicioNombreH.Text
        txtNombreFirma.Text = lblFirma.Text
     

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
        Call HabilitarMenu()
    End Sub


    Private Sub lblAyudaP_MouseHover(sender As Object, e As EventArgs) Handles lblAyudaP.MouseHover
        lblAyudaP.ForeColor = Color.Blue
    End Sub

    Private Sub lblAyudaP_MouseLeave(sender As Object, e As EventArgs) Handles lblAyudaP.MouseLeave
        lblAyudaP.ForeColor = Color.Black
    End Sub

    Private Sub lblAyudaP_Click(sender As Object, e As EventArgs) Handles lblAyudaP.Click
        If lblExplicacionP.Visible = False Then
            lblExplicacionP.Visible = True
        Else
            lblExplicacionP.Visible = False
        End If
    End Sub

    Private Sub frmAjustes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Call HabilitarMenu()
        frmGeneral.Refresh()
        frmGeneral.MAjusteDeSistema.Enabled = True


    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnAjusteNuevoP.Click
        PersonalTextBox.ReadOnly = False
        PersonalTextBox.Focus()
        PersonalTextBox.Text = ""
        btnAjusteModificarP.Enabled = False
        btnAjusteEliminarP.Enabled = False
        btnAjusteGuardarP.Enabled = True
        btnAjusteNuevoP.Enabled = False
    End Sub


    Private Sub btnCancelarFirma_Click(sender As Object, e As EventArgs) Handles btnCancelarFirma.Click
        lblAjusteNombreH.Text = frmInicio.lblInicioNombreH.Text
        lblFirma.Text = frmInicio.lblFirma.Text
        txtNombreInst.Text = frmInicio.lblInicioNombreH.Text
        txtNombreFirma.Text = frmInicio.lblFirma.Text
        txtNombreInst.ReadOnly = True
        txtNombreFirma.ReadOnly = True
    End Sub

    Private Sub lblAyudaD_MouseHover(sender As Object, e As EventArgs) Handles lblAyudaD.MouseHover
        lblAyudaD.ForeColor = Color.Blue
    End Sub

    Private Sub lblAyudaD_MouseLeave(sender As Object, e As EventArgs) Handles lblAyudaD.MouseLeave
        lblAyudaD.ForeColor = Color.Black
    End Sub



    Private Sub txtNombreInst_DoubleClick(sender As Object, e As EventArgs) Handles txtNombreInst.DoubleClick
        txtNombreInst.ReadOnly = False
        txtNombreInst.SelectAll()
        btnAplicarFirma.Enabled = True


    End Sub

    Private Sub txtNombreFirma_DoubleClick(sender As Object, e As EventArgs) Handles txtNombreFirma.DoubleClick
        txtNombreFirma.ReadOnly = False
        txtNombreFirma.SelectAll()
    End Sub

    Private Sub lblAyudaD_Click(sender As Object, e As EventArgs) Handles lblAyudaD.Click
        If lblExplicacionD.Visible = False Then
            lblExplicacionD.Visible = True
        Else
            lblExplicacionD.Visible = False
        End If

    End Sub

    Private Sub lblAjusteH_Click(sender As Object, e As EventArgs) Handles lblAjusteH.Click
        If lblExplicacionH.Visible = False Then
            lblExplicacionH.Visible = True
        Else
            lblExplicacionH.Visible = False
        End If
    End Sub

    Private Sub lblAjusteH_MouseHover(sender As Object, e As EventArgs) Handles lblAjusteH.MouseHover
        lblAjusteH.ForeColor = Color.Blue
    End Sub

    Private Sub lblAjusteH_MouseLeave(sender As Object, e As EventArgs) Handles lblAjusteH.MouseLeave
        lblAjusteH.ForeColor = Color.Black
    End Sub

    'Private Sub btnRutaNombre_Click(sender As Object, e As EventArgs) Handles btnRutaNombre.Click, btnRutaNombre.Click
    '    Dim abrirVentanaFileH As New OpenFileDialog() 'declaro varible como nuevo openDialo para buscar la cadena dee conexion
    '    If abrirVentanaFileH.ShowDialog() = Windows.Forms.DialogResult.OK Then ' si la ventana se abre y se da ok se le pasa el valor al txt
    '        txtDireccionArchivo.Text = abrirVentanaFileH.FileName ' se le da el valor al txt

    '    End If


    'End Sub

    'Private Sub btnBucarRutaFirma_Click(sender As Object, e As EventArgs) Handles btnBucarRutaFirma.Click
    '    Dim abrirVentanaFileF As New OpenFileDialog() 'declaro varible como nuevo openDialo para buscar la cadena dee conexion
    '    If abrirVentanaFileF.ShowDialog() = Windows.Forms.DialogResult.OK Then ' si la ventana se abre y se da ok se le pasa el valor al txt
    '        txtDireccionArchivoF.Text = abrirVentanaFileF.FileName ' se le da el valor al txt
    '    End If
    'End Sub


    Private Sub btnAplicarFirma_Click(sender As Object, e As EventArgs) Handles btnAplicarFirma.Click
        Dim NombreH As Object ' Declaro los ojetos que van a contener el valor del txt
        Dim ArchivoH As Object
        Dim NombreF As Object
        Dim ArchivoF As Object
        Try
            '******************Nombre del Hotel*******************
            NombreH = CreateObject("Scripting.FileSystemObject") 'le doy el valor al objeto NombreH tipo CREATEOBJECTO con el scripting 
            ArchivoH = NombreH.CreateTextFile(Application.StartupPath & "\NombreHotel.txt") 'al objeto archivo le digo que cree un txt y le paso la direccion
            ArchivoH.writeline(txtNombreInst.Text) ' por ultimo le doy el valor a la linea del txt que es lo que contiene la caja de texto

            '******************Nombre de la Firma****************
            NombreF = CreateObject("Scripting.FileSystemObject") 'le doy el valor al objeto NombreH tipo CREATEOBJECTO con el scripting 
            ArchivoF = NombreF.CreateTextFile(Application.StartupPath & "\NombreFirma.txt") 'al objeto archivo le digo que cree un txt y le paso la direccion
            ArchivoF.writeline(txtNombreFirma.Text) ' por ultimo le doy el valor a la linea del txt que es lo que contiene la caja de texto
            MsgBox("Nuevo nombre del Hotel y Firma fue modificado con exito,los cambios lo notara al reiniciar el sistema", MsgBoxStyle.Exclamation, "Nombre del Hotel y Firma Hotelera")
            txtNombreFirma.ReadOnly = True
            txtNombreInst.ReadOnly = True
        Catch ex As Exception
            MsgBox("El nombre de la Instalcion ya ha sido cambiado. Al reiniciar los cambios notara los cambio", MsgBoxStyle.Critical, "Ajustes")
            txtNombreFirma.ReadOnly = True
            txtNombreInst.ReadOnly = True

        End Try

    End Sub



    Private Sub btnAjusteGuardarP_Click(sender As Object, e As EventArgs) Handles btnAjusteGuardarP.Click
        If PersonalTextBox.Text = "" Then
            MsgBox("Por favor llene el campo de personal", MsgBoxStyle.Critical, "Personal")
            PersonalTextBox.Focus()
        Else
            ConsultaSql = "Insert into Personal (Personal) Values('" & PersonalTextBox.Text & "')" ' Le doy valo a la consulta tipo string
            Comando.CommandType = CommandType.Text 'al comando le digo que sera tipo Type y que el type es de text
            Comando.CommandText = ConsultaSql ' al comando tipo texto le doy el valo dela consulta 
            Call Conectar_Base() ' me conecto a la base
            Conexion.Open() ' abro conexio
            Comando.ExecuteNonQuery() ' Ejecuto el comando
            MsgBox("Se ingreso un nuevo Personal", MsgBoxStyle.Information, "Nuevo Personal")
            Me.PersonalTableAdapter.Fill(Me.QuejasDataSet.Personal) ' lleno el tabla adapter para ver los cmabios
            btnAjusteEliminarP.Enabled = True
            btnAjusteNuevoP.Enabled = True
            btnAjusteModificarP.Enabled = True
            btnAjusteGuardarP.Enabled = False
            btnAjusteNuevoP.Focus()
            PersonalTextBox.ReadOnly = True
            btnAjusteModificarP.Enabled = False
        End If

    End Sub




    Private Sub btnAjusteCancelarP_Click(sender As Object, e As EventArgs) Handles btnAjusteCancelarP.Click
        Dim respuesta As MsgBoxResult
        If PersonalTextBox.ReadOnly = False Then
            respuesta = MsgBox("Guarde los cambios o cancele", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Guardar Cambios")
            If respuesta = MsgBoxResult.Ok Then
                If PersonalTextBox.Text = "" Then
                    PersonalTextBox.Focus()
                    MsgBox("Agregue un nuevo personal", MsgBoxStyle.Information, "Personal")
                Else
                    ConsultaSql = "Insert into Personal (Personal) Values('" & PersonalTextBox.Text & "')" ' Le doy valo a la consulta tipo string
                    Comando.CommandType = CommandType.Text 'al comando le digo que sera tipo Type y que el type es de text
                    Comando.CommandText = ConsultaSql ' al comando tipo texto le doy el valo dela consulta 
                    Call Conectar_Base() ' me conecto a la base
                    Conexion.Open() ' abro conexio
                    Comando.ExecuteNonQuery() ' Ejecuto el comando
                    MsgBox("Se ingreso un nuevo Personal", MsgBoxStyle.Information, "Personal")
                    Me.PersonalTableAdapter.Fill(Me.QuejasDataSet.Personal) ' lleno el tabla adapter para ver los cmabios
                    btnAjusteEliminarP.Enabled = True
                    btnAjusteNuevoP.Enabled = True
                    btnAjusteModificarP.Enabled = True
                    btnAjusteGuardarP.Enabled = False
                    btnAjusteNuevoP.Focus()
                    PersonalTextBox.ReadOnly = True
                    btnAjusteModificarP.Enabled = False
                End If
            Else

                btnAjusteModificarP.Enabled = False
                btnAjusteEliminarP.Enabled = True
                btnAjusteGuardarP.Enabled = False
                btnAjusteNuevoP.Enabled = True
                btnAjusteNuevoD.Focus()
                PersonalTextBox.ReadOnly = True
                PersonalTableAdapter.Fill(QuejasDataSet.Personal)
            End If
        End If
    End Sub

    '***********************Escondido detras del pictbox esta el txt que contiene el codigo de la persona o sea el ID
    Private Sub btnAjusteModificarP_Click(sender As Object, e As EventArgs) Handles btnAjusteModificarP.Click
        If PersonalTextBox.Text = "" Then
            MsgBox("Aun no existen Personal", MsgBoxStyle.Exclamation, "Personal")
        Else
            Me.PersonalTableAdapter.Modificar(PersonalTextBox.Text, IdTextBox.Text) ' Para modificar se necesita pasarle el valor en donde se vaya hacer la modificacion, por eso le agrego
            'al final el Campo IdTextBox.Text
            MsgBox("Modificacion Satifatoria", MsgBoxStyle.Information, "Modificacion de Personal")
            Me.PersonalTableAdapter.Fill(Me.QuejasDataSet.Personal)
            PersonalTextBox.Focus()
            btnAjusteModificarP.Enabled = True
            btnAjusteEliminarP.Enabled = True
            btnAjusteGuardarP.Enabled = False
            btnAjusteNuevoP.Enabled = True
            btnAjusteModificarP.Enabled = False
            PersonalTextBox.ReadOnly = True
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PersonalBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.PersonalBindingSource.MovePrevious()
    End Sub

    Private Sub btnAjuesteAceptarT_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnAjusteNuevoH_Click(sender As Object, e As EventArgs) Handles btnAjusteNuevoH.Click
        HabTextBox.ReadOnly = False
        HabTextBox.Text = ""
        HabTextBox.Focus()
        btnAjusteGuardar.Enabled = True
        btnAjusteModificarH.Enabled = False
        btnAjusteEliminarH.Enabled = False
        btnAjusteNuevoH.Enabled = False


    End Sub

    Private Sub btnAjusteGuardar_Click(sender As Object, e As EventArgs) Handles btnAjusteGuardar.Click
        If HabTextBox.Text = "" Then
            MsgBox("Por favor llene el campo de Hab", MsgBoxStyle.Critical, "Habitaciones")
            HabTextBox.Focus()
        Else
            Me.HabitacionesTableAdapter.Insert(HabTextBox.Text)
            MsgBox("Se inserto una nueva habitacion", MsgBoxStyle.Information, "Habitaciones")
            Me.HabitacionesTableAdapter.Fill(Me.QuejasDataSet.Habitaciones)
            btnAjusteGuardar.Enabled = False
            btnAjusteNuevoH.Enabled = True
            btnAjusteModificarH.Enabled = True
            btnAjusteEliminarH.Enabled = True
            btnAjusteNuevoH.Focus()
            HabTextBox.ReadOnly = True
            btnAjusteModificarH.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        HabitacionesBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HabitacionesBindingSource.MovePrevious()
    End Sub

    Private Sub btnAjusteCancelarH_Click(sender As Object, e As EventArgs) Handles btnAjusteCancelarH.Click
        Dim respuesta As MsgBoxResult
        If HabTextBox.ReadOnly = False Then
            respuesta = MsgBox("Guarde los cambios o cancele", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Guardar cambios")
            If respuesta = MsgBoxResult.Ok Then
                If HabTextBox.Text = "" Then
                    HabTextBox.Focus()
                    MsgBox("Agregue una nueva habitacion", MsgBoxStyle.Information, "Habitacion")
                Else
                    Me.HabitacionesTableAdapter.Insert(HabTextBox.Text)
                    MsgBox("Se inserto una nueva habitacion", MsgBoxStyle.Information, "Habitaciones")
                    Me.HabitacionesTableAdapter.Fill(Me.QuejasDataSet.Habitaciones)
                    btnAjusteGuardar.Enabled = False
                    btnAjusteNuevoH.Enabled = True
                    btnAjusteModificarH.Enabled = True
                    btnAjusteEliminarH.Enabled = True
                    btnAjusteNuevoH.Focus()
                    HabTextBox.ReadOnly = True
                    btnAjusteModificarH.Enabled = False
                End If
            Else
                HabitacionesTableAdapter.Fill(QuejasDataSet.Habitaciones)
                btnAjusteGuardar.Enabled = False
                btnAjusteNuevoH.Enabled = True
                btnAjusteModificarH.Enabled = False
                btnAjusteEliminarH.Enabled = True
                btnAjusteNuevoH.Focus()
                HabTextBox.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub btnAjusteModificarH_Click(sender As Object, e As EventArgs) Handles btnAjusteModificarH.Click
        If HabTextBox.Text = "" Then
            MsgBox("Aun no exixten habitaciones", MsgBoxStyle.Exclamation, "habitaciones")
        Else
            Me.HabitacionesTableAdapter.Modificar(HabTextBox.Text, IdTextBox1.Text)
            MsgBox("Se ha modificado el numero de hab", MsgBoxStyle.Information, "Habitaciones")
            Me.HabitacionesTableAdapter.Fill(Me.QuejasDataSet.Habitaciones)
            btnAjusteNuevoH.Focus()
            btnAjusteModificarH.Enabled = False
            HabTextBox.ReadOnly = True

        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub btnAjusteEliminarH_Click(sender As Object, e As EventArgs) Handles btnAjusteEliminarH.Click
        If IdTextBox1.Text = "" Then
            MsgBox("No hay Habitaciones que eliminar", MsgBoxStyle.Exclamation, "Ajustes")
        Else
            Dim respuesta As Object
            respuesta = MsgBox("Desea eliminar esta Habitacion", MsgBoxStyle.YesNo, "Eliminar Habitacion")
            If respuesta = vbYes Then
                Me.HabitacionesTableAdapter.Borrar(IdTextBox1.Text)
                Me.HabitacionesTableAdapter.Fill(Me.QuejasDataSet.Habitaciones)
                btnAjusteNuevoH.Focus()

            End If
        End If
    End Sub

    Private Sub btnAjusteEliminarP_Click(sender As Object, e As EventArgs) Handles btnAjusteEliminarP.Click
        Dim Respuesta As Object 'Declaro una variable tipo ojeto, el objeto en este caso es el mensaje
        If IdTextBox.Text = "" Then
            MsgBox("No hay personal que eliminar", MsgBoxStyle.Exclamation, "Ajuestes")
        Else
            Respuesta = MsgBox("Desea eliminar esta persona", MsgBoxStyle.YesNo, "Eliminar Persona") ' le doy el valor a la variable
            If Respuesta = vbYes Then ' creo la condicion para respuesta
                Me.PersonalTableAdapter.Borrar(IdTextBox.Text)
                Me.PersonalTableAdapter.Fill(Me.QuejasDataSet.Personal)
                btnAjusteNuevoP.Focus()
            End If

        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DepartamentosBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DepartamentosBindingSource.MoveNext()
    End Sub

    Private Sub btnAjusteNuevoD_Click(sender As Object, e As EventArgs) Handles btnAjusteNuevoD.Click
        DepartamentosTextBox.ReadOnly = False
        DepartamentosTextBox.Focus()
        DepartamentosTextBox.Text = ""
        btnAjusteModificarD.Enabled = False
        btnAjusteEliminarD.Enabled = False
        btnAjusteGuardarD.Enabled = True
        btnAjusteNuevoD.Enabled = False


    End Sub

    Private Sub btnAjusteModificarD_Click(sender As Object, e As EventArgs) Handles btnAjusteModificarD.Click
        If DepartamentosTextBox.Text = "" Then
            MsgBox("Aun no existen Departamentos", MsgBoxStyle.Exclamation, "Departamentos")
        Else
            Me.DepartamentosTableAdapter.Modificar(DepartamentosTextBox.Text, IdTextBox2.Text)
            MsgBox("Se ha modificado el departamento", MsgBoxStyle.Information, "Modificacion Departamento")
            Me.DepartamentosTableAdapter.Fill(Me.QuejasDataSet.Departamentos)
            btnAjusteNuevoD.Focus()
            HabTextBox.ReadOnly = True
            btnAjusteModificarD.Enabled = False
        End If
    End Sub

    Private Sub btnAjusteGuardarD_Click(sender As Object, e As EventArgs) Handles btnAjusteGuardarD.Click
        If DepartamentosTextBox.Text = "" Then
            MsgBox("Por favor llene el campo Departamento", MsgBoxStyle.Critical, "Departamento")
            DepartamentosTextBox.Focus()
        Else
            Me.DepartamentosTableAdapter.Insert(DepartamentosTextBox.Text)
            MsgBox("Se ha insertado un nuevo Departamento", MsgBoxStyle.Information, "Nuevo Departamento")
            Me.DepartamentosTableAdapter.Fill(Me.QuejasDataSet.Departamentos)
            btnAjusteModificarD.Enabled = True
            btnAjusteEliminarD.Enabled = True
            btnAjusteGuardarD.Enabled = False
            btnAjusteNuevoD.Enabled = True
            btnAjusteNuevoH.Focus()
            DepartamentosTextBox.ReadOnly = True
            btnAjusteModificarD.Enabled = False
        End If

    End Sub

    Private Sub btnAjusteEliminarD_Click(sender As Object, e As EventArgs) Handles btnAjusteEliminarD.Click
        If IdTextBox2.Text = "" Then
            MsgBox("No hay Departamento que eliminar", MsgBoxStyle.Exclamation, "Ajuste")
        Else

            Dim Respuesta As Object 'Declaro una variable tipo ojeto, el objeto en este caso es el mensaje
            Respuesta = MsgBox("Desea eliminar este departamento", MsgBoxStyle.YesNo, "Eliminar departamento") ' le doy el valor a la variable
            If Respuesta = vbYes Then ' creo la condicion para respuesta
                Me.DepartamentosTableAdapter.Borrar(IdTextBox2.Text)
                Me.DepartamentosTableAdapter.Fill(Me.QuejasDataSet.Departamentos)
                btnAjusteNuevoD.Focus()
            End If
        End If


    End Sub

    Private Sub btnAjusteCancelarD_Click(sender As Object, e As EventArgs) Handles btnAjusteCancelarD.Click
        Dim respuesta As MsgBoxResult
        If DepartamentosTextBox.ReadOnly = False Then
            respuesta = MsgBox("Guarde los cambios o cancele", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Guardar cambios")
            If respuesta = MsgBoxResult.Ok Then
                If DepartamentosTextBox.Text = "" Then
                    DepartamentosTextBox.Focus()
                    MsgBox("Agregue un nuevo Departamento", MsgBoxStyle.Information, "Departamento")
                Else
                    Me.DepartamentosTableAdapter.Insert(DepartamentosTextBox.Text)
                    MsgBox("Se ha insertado un nuevo Departamento", MsgBoxStyle.Information, "nuevo Ddepartamento")
                    Me.DepartamentosTableAdapter.Fill(Me.QuejasDataSet.Departamentos)
                    btnAjusteModificarD.Enabled = True
                    btnAjusteEliminarD.Enabled = True
                    btnAjusteGuardarD.Enabled = False
                    btnAjusteNuevoD.Enabled = True
                    btnAjusteNuevoH.Focus()
                    DepartamentosTextBox.ReadOnly = True
                    btnAjusteModificarD.Enabled = False
                End If
            Else
                DepartamentosTableAdapter.Fill(QuejasDataSet.Departamentos)
                btnAjusteModificarD.Enabled = False
                btnAjusteEliminarD.Enabled = True
                btnAjusteGuardarD.Enabled = False
                btnAjusteNuevoD.Enabled = True
                btnAjusteNuevoH.Focus()
                DepartamentosTextBox.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub PersonalTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PersonalTextBox.KeyPress
        If Not (Char.IsLetter(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And Not (Char.IsSeparator(e.KeyChar)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then ' controlar por codigo ascii al presionar enter en el evento keypress
            If PersonalTextBox.Text = "" Then
                MsgBox("Por favor llene el campo de personal", MsgBoxStyle.Critical, "Personal")
                PersonalTextBox.Focus()
            Else
                ConsultaSql = "Insert into Personal (Personal) Values('" & PersonalTextBox.Text & "')" ' Le doy valo a la consulta tipo string
                Comando.CommandType = CommandType.Text 'al comando le digo que sera tipo Type y que el type es de text
                Comando.CommandText = ConsultaSql ' al comando tipo texto le doy el valo dela consulta 
                Call Conectar_Base() ' me conecto a la base
                Conexion.Open() ' abro conexio
                Comando.ExecuteNonQuery() ' Ejecuto el comando
                MsgBox("Se ingreso un nuevo Personal", MsgBoxStyle.Information, "Nuevo Personal")
                Me.PersonalTableAdapter.Fill(Me.QuejasDataSet.Personal) ' lleno el tabla adapter para ver los cmabios
                btnAjusteEliminarP.Enabled = True
                btnAjusteNuevoP.Enabled = True
                btnAjusteModificarP.Enabled = True
                btnAjusteGuardarP.Enabled = False
                btnAjusteNuevoP.Focus()
                PersonalTextBox.ReadOnly = True
                btnAjusteModificarP.Enabled = False
            End If
        End If

    End Sub

    Private Sub DepartamentosTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DepartamentosTextBox.KeyPress
        If Not (Char.IsLetter(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) And Not (Char.IsSeparator(e.KeyChar)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If DepartamentosTextBox.Text = "" Then
                MsgBox("Por favor llene el campo Departamento", MsgBoxStyle.Critical, "Departamento")
                DepartamentosTextBox.Focus()
            Else
                Me.DepartamentosTableAdapter.Insert(DepartamentosTextBox.Text)
                MsgBox("Se ha insertado un nuevo Departamento", MsgBoxStyle.Information, "nuevo Ddepartamento")
                Me.DepartamentosTableAdapter.Fill(Me.QuejasDataSet.Departamentos)
                btnAjusteModificarD.Enabled = True
                btnAjusteEliminarD.Enabled = True
                btnAjusteGuardarD.Enabled = False
                btnAjusteNuevoD.Enabled = True
                btnAjusteNuevoH.Focus()
                DepartamentosTextBox.ReadOnly = True
                btnAjusteModificarD.Enabled = False
            End If
        End If

    End Sub

    Private Sub HabTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HabTextBox.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) And Not (Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If HabTextBox.Text = "" Then
                MsgBox("Por favor llene el campo de Hab", MsgBoxStyle.Critical, "Habitaciones")
                HabTextBox.Focus()
            Else
                Me.HabitacionesTableAdapter.Insert(HabTextBox.Text)
                MsgBox("Se inserto una nueva habitacion", MsgBoxStyle.Information, "Habitaciones")
                Me.HabitacionesTableAdapter.Fill(Me.QuejasDataSet.Habitaciones)
                btnAjusteGuardar.Enabled = False
                btnAjusteNuevoH.Enabled = True
                btnAjusteModificarH.Enabled = True
                btnAjusteEliminarH.Enabled = True
                btnAjusteNuevoH.Focus()
                HabTextBox.ReadOnly = True
                btnAjusteModificarH.Enabled = False
            End If
        End If
    End Sub

    Private Sub PersonalTextBox_DoubleClick(sender As Object, e As EventArgs) Handles PersonalTextBox.DoubleClick
        If PersonalTextBox.Text = "" Then
            MsgBox("No hay datos que modificar", MsgBoxStyle.Information, "Personal")
        Else
            btnAjusteModificarP.Enabled = True
            PersonalTextBox.ReadOnly = False
        End If
    End Sub


    Private Sub DepartamentosTextBox_DoubleClick(sender As Object, e As EventArgs) Handles DepartamentosTextBox.DoubleClick
        If DepartamentosTextBox.Text = "" Then
            MsgBox("No hay datos que modificar", MsgBoxStyle.Information, "Departamentos")
        Else
            btnAjusteModificarD.Enabled = True
            DepartamentosTextBox.ReadOnly = False
        End If
    End Sub

    Private Sub HabTextBox_DoubleClick(sender As Object, e As EventArgs) Handles HabTextBox.DoubleClick
        If HabTextBox.Text = "" Then
            MsgBox("No hay datos que modificar", MsgBoxStyle.Information, "Habitaciones")
        Else
            btnAjusteModificarH.Enabled = True
            HabTextBox.ReadOnly = False
        End If
    End Sub

    Private Sub frmAjustes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim respuesta As MsgBoxResult ' declaro una variable que guarda el valor al dar click en uno de los botones, Yes, No
        If PersonalTextBox.ReadOnly = False Then
            respuesta = MsgBox("Desea salir? No ha guardado los datos aun de la Nueva Persona", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Salir") ' si alguno cumple la condicion tiro msg
            If respuesta = MsgBoxResult.No Then
                e.Cancel = True     ' cancelo el cierre
            End If
        End If

        If HabTextBox.ReadOnly = False Then
            respuesta = MsgBox("Desea salir? No ha guardado los datos aun de la Nueva Hab", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Salir") ' si alguno cumple la condicion tiro msg
            If respuesta = MsgBoxResult.No Then
                e.Cancel = True     ' cancelo el cierre
            End If
        End If

        If DepartamentosTextBox.ReadOnly = False Then
            respuesta = MsgBox("Desea salir? No ha guardado los datos aun del Nuevo departamento" + " Personal", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Salir") ' si alguno cumple la condicion tiro msg
            If respuesta = MsgBoxResult.No Then
                e.Cancel = True     ' cancelo el cierre
            End If
            If txtDireccionM.ReadOnly = False Then
                respuesta = MsgBox("Desea salir?No ha guadardo los datos del la Nueva direccion mail", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Salir")
                If respuesta = MsgBoxResult.No Then
                    e.Cancel = True
                End If
            End If
        End If



    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnAjusteNuevoM.Click
        txtDireccionM.Focus()
        txtDireccionM.ReadOnly = False
        btnAjusteGuardarM.Enabled = True
        txtDireccionM.Text = ""
    End Sub

    Private Sub lblAyudaM_Click(sender As Object, e As EventArgs) Handles lblAyudaM.Click

        If lblExplicacionM.Visible = False Then
            lblExplicacionM.Visible = True
            btnConfigAjuste.Visible = False
        Else
            lblExplicacionM.Visible = False
            btnConfigAjuste.Visible = True

        End If
    End Sub

    Private Sub btnAjusteGuardarM_Click(sender As Object, e As EventArgs) Handles btnAjusteGuardarM.Click
        If txtDireccionM.Text = "" Then
            MsgBox("Por favor llene el campo de Direccion Mail", MsgBoxStyle.Critical, "Direccion Mail")
            txtDireccionM.Focus()
        Else
            If Not txtDireccionM.ToString.Contains("@") Then
                MsgBox("La direccion de correo no es valida '@' ", MsgBoxStyle.Critical, "Direccion Mail")
                txtDireccionM.Focus()
            Else
                Me.CorreosTableAdapter.Insert(txtDireccionM.Text)
                MsgBox("Se inserto una nueva Direccion Mail", MsgBoxStyle.Information, "Direccion Mail")
                Me.CorreosTableAdapter.Fill(Me.QuejasDataSet.Correos)
                btnAjusteGuardarM.Enabled = False
                btnAjusteNuevoM.Enabled = True
                btnAjusteModificarM.Enabled = True
                btnAjusteEliminarM.Enabled = True
                btnAjusteNuevoM.Focus()
                txtDireccionM.ReadOnly = True
            End If
        End If
        
    End Sub

    Private Sub btnAjusteModificarM_Click(sender As Object, e As EventArgs) Handles btnAjusteModificarM.Click
        If txtDireccionM.Text = "" Then
            MsgBox("Aun no exixten Direccion Mail", MsgBoxStyle.Exclamation, "Direccion Mail")
        Else
            Me.CorreosTableAdapter.Modificar(txtDireccionM.Text, IdTextBox3.Text)
            MsgBox("Se ha modificado la direccion Mail", MsgBoxStyle.Information, "Direccion Mail")
            Me.CorreosTableAdapter.Fill(Me.QuejasDataSet.Correos)
            btnAjusteNuevoM.Focus()
            btnAjusteModificarM.Enabled = False
            txtDireccionM.ReadOnly = True

        End If
    End Sub

    Private Sub txtDireccionM_DoubleClick(sender As Object, e As EventArgs)
        txtDireccionM.ReadOnly = False
    End Sub

    Private Sub btnAjusteEliminarM_Click(sender As Object, e As EventArgs) Handles btnAjusteEliminarM.Click
        If IdTextBox3.Text = "" Then
            MsgBox("No hay Direccion Mail que eliminar", MsgBoxStyle.Exclamation, "Direccio Mail")
        Else
            Dim respuesta As Object
            respuesta = MsgBox("Desea eliminar esta Direccion Mail", MsgBoxStyle.YesNo, "Eliminar Direccion Mail")
            If respuesta = vbYes Then
                Me.CorreosTableAdapter.Borrar(IdTextBox3.Text)
                Me.CorreosTableAdapter.Fill(Me.QuejasDataSet.Correos)
                btnAjusteNuevoM.Focus()

            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        CorreosBindingSource.MoveNext()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        CorreosBindingSource.MovePrevious()
    End Sub

    Private Sub txtDireccionM_DoubleClick_1(sender As Object, e As EventArgs) Handles txtDireccionM.DoubleClick
        txtDireccionM.ReadOnly = False
        btnAjusteModificarM.Enabled = True
    End Sub

    Private Sub lblAyudaM_MouseHover(sender As Object, e As EventArgs) Handles lblAyudaM.MouseHover
        lblAyudaM.ForeColor = Color.Blue
    End Sub

    Private Sub lblAyudaM_MouseLeave(sender As Object, e As EventArgs) Handles lblAyudaM.MouseLeave
        lblAyudaM.ForeColor = Color.Black
    End Sub

   
    Private Sub txtDireccionM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccionM.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtDireccionM.Text = "" Then
                MsgBox("Por favor llene el campo de direccion", MsgBoxStyle.Critical, "Direccion Mail")
                txtDireccionM.Focus()
            Else
                Me.CorreosTableAdapter.Insert(txtDireccionM.Text)
                MsgBox("Se inserto una nueva Direccion Mail", MsgBoxStyle.Information, "Direccion Mail")
                Me.CorreosTableAdapter.Fill(Me.QuejasDataSet.Correos)
                btnAjusteGuardar.Enabled = False
                btnAjusteNuevoM.Enabled = True
                btnAjusteModificarM.Enabled = True
                btnAjusteEliminarM.Enabled = True
                btnAjusteNuevoM.Focus()
                txtDireccionM.ReadOnly = True
                btnAjusteModificarM.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnAjusteCancelarM_Click(sender As Object, e As EventArgs) Handles btnAjusteCancelarM.Click
        Dim respuesta As MsgBoxResult
        If txtDireccionM.ReadOnly = False Then
            respuesta = MsgBox("Guarde los cambios o cancele", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Guardar cambios")
            If respuesta = MsgBoxResult.Ok Then
                If txtDireccionM.Text = "" Then
                    txtDireccionM.Focus()
                    MsgBox("Agregue una nueva direccion mail", MsgBoxStyle.Information, "Direccion Mail")
                Else
                    Me.CorreosTableAdapter.Insert(txtDireccionM.Text)
                    MsgBox("Se inserto una nueva direccion", MsgBoxStyle.Information, "Direccion Mail")
                    Me.CorreosTableAdapter.Fill(Me.QuejasDataSet.Correos)
                    btnAjusteGuardarM.Enabled = False
                    btnAjusteNuevoM.Enabled = True
                    btnAjusteModificarM.Enabled = True
                    btnAjusteEliminarM.Enabled = True
                    btnAjusteNuevoM.Focus()
                    txtDireccionM.ReadOnly = True
                    btnAjusteModificarM.Enabled = False
                End If
            Else
                CorreosTableAdapter.Fill(QuejasDataSet.Correos)
                btnAjusteGuardarM.Enabled = False
                btnAjusteNuevoM.Enabled = True
                btnAjusteModificarM.Enabled = False
                btnAjusteEliminarM.Enabled = True
                btnAjusteNuevoM.Focus()
                txtDireccionM.ReadOnly = True
            End If
        End If
    End Sub

 

    Private Sub btnConfigAjuste_Click(sender As Object, e As EventArgs) Handles btnConfigAjuste.Click
        frmConfigCorreos.Show()
    End Sub
End Class

