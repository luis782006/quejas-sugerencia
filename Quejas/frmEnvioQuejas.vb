Imports System.Net
Imports System.Net.Mail

Public Class frmEnvioQuejas

    Dim Cadena_archivo As String
    Private correo As New MailMessage
    Private autenticar As New NetworkCredential
    Private envio As New SmtpClient
    Dim direccionCompleta As String
    Public variable As String 'variable para almacenar direccion mail
    Dim variable1 As String 'variable para almacenar el solo el texto y poder enviar el mensaje sin error de direccion por causa del vbnewline
    Public nombreD As String
    Sub enviar_correo_con_archivo()
        Try
            correo.To.Clear()
            correo.Body = ""
            correo.Subject = ""
            correo.Body = txtTema.Text      'El contenido del mensaje
            correo.Subject = Me.txtAsunto.Text   'El asunto
            correo.IsBodyHtml = True             'Estructura html ? le ponemos si
            correo.To.Add(variable)
            correo.Attachments.Add(New Attachment(lbAdjunto.Text)) 'archivo adjuntado , le mandamos la ruta
            correo.From = New MailAddress(desde)
            'correo.From = New MailAddress("luisfelipe782006@gmail.com")
            envio.Credentials = New NetworkCredential(credencial, contraseña) '  contraseña
            'envio.Credentials = New NetworkCredential("luisfelipe782006@gmail.com", "Luisfelipe") ' LuisFelipe es la contraseña
            envio.Host = host
            envio.Port = puerto
            'envio.Host = "smtp.gmail.com"
            'envio.Port = 587
            envio.EnableSsl = True
            envio.Send(correo) 'enviamos el mensaje


            Me.Cursor = Cursors.Default
            Me.Text = "Enviar mensaje"
            MsgBox(" El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")
            'limpiamos los campos

            txtTema.Text = String.Empty
            'lbAdjunto.Text = String.Empty

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmEnvioQuejas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Correos' Puede moverla o quitarla según sea necesario.
        Me.CorreosTableAdapter.Fill(Me.QuejasDataSet.Correos)
        txtAsunto.Text = "Quejas Realizadas " + Now.Date
        'TODO: esta línea de código carga datos en la tabla 'QuejasDataSet.Quejas' Puede moverla o quitarla según sea necesario.
        Me.QuejasTableAdapter.Consulta(Me.QuejasDataSet.Quejas)
        comboMail.SelectedIndex = -1
    End Sub

    Private Sub btnAgregarD_Click(sender As Object, e As EventArgs) Handles btnAgregarD.Click

        If comboMail.Text = "" Then
            MsgBox("Escoja una direccion de mail", MsgBoxStyle.Critical, "Direccion Mail")
        Else

            variable = variable + comboMail.Text + ","
            variable1 = variable1 + comboMail.Text + "," + vbNewLine
            txtDirecciones_Mail.Text = variable1

            comboMail.Text = ""
        End If

    End Sub

    
    Private Sub btEnviarM_Click_1(sender As Object, e As EventArgs) Handles btEnviarM.Click

        If txtDirecciones_Mail.Text = "" Then
            MsgBox("No existen direcciones para el envio del correo", MsgBoxStyle.Critical, "Direccion Mail")
        Else
            variable = Mid(variable, 1, Len(variable) - 1) 'mid toma la cant de cadena,1 es la punta de la cadena,len devuelve el valor entero y le resto 1
            Me.Cursor = Cursors.WaitCursor
            Me.Text = "Enviar mensaje [ Enviando ... ]"
            enviar_correo_con_archivo()
            lblDestinatario.Text = ""
            txtDirecciones_Mail.Text = ""
            lbAdjunto.Text = ""
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim abrirVentanaFileH As New OpenFileDialog  'declaro varible como nuevo openDialog para buscar la cadena dee conexion

        If abrirVentanaFileH.ShowDialog() = Windows.Forms.DialogResult.OK Then ' si la ventana se abre y se da ok se le pasa el valor al txt
            lbAdjunto.Text = abrirVentanaFileH.FileName ' se le da el valor al txt
        End If
    End Sub

    Private Sub frmEnvioQuejas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmGeneral.MEnviarQuejas.Enabled = True
        frmGeneral.btnEnviarQuejas.Enabled = True
        Call HabilitarMenu()
    End Sub

   
End Class