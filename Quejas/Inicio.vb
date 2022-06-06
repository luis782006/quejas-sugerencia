Public Class frmInicio

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 20 Then
            lblDatos.Text = "Actualizando Datos"
        End If

        If ProgressBar1.Value = 50 Then
            lblDatos.Text = "Recuperando Datos"
        End If

        If ProgressBar1.Value = 80 Then
            lblDatos.Text = "Bienvenidos al Sistema Quejas"
        End If

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            frmGeneral.Show()
        End If



    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntR = frmQuejasRealizadas.QuejasBindingSource.Count

        If cntR >= 500 Then
            Me.Show()
            MsgBox("Superada las cantidad de quejas dentro del sistema. Póngase en contacto con el proovedor ", MsgBoxStyle.Critical, "Sistemas de quejas")
            Me.Close()
        Else
            Timer1.Start()
            '************Cargo el nombre del Hotel*************
            fileReaderH = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\NombreHotel.txt ") 'Le paso el valor de la variable, que es la 
            'ubicacion
            lblInicioNombreH.Text = fileReaderH

            '************Cargo el nombre de la firma******************
            fileReaderF = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\NombreFirma.txt ") 'Le paso el valor de la variable, que es la 
            'ubicacion
            lblFirma.Text = fileReaderF

        End If



    End Sub

   
 

 
End Class
'Imports System
'Imports System.Data
'Imports System.Data.SqlClient
'Imports System.Configuration
'Module Procedimiento
'    Sub Conectar_Base() ' Procedimiento de conexion
'        Base_Quejas = Application.StartupPath & "\Quejas.sdf " 'Le doy el valor de la variable creada.Aplicacion.StartPath le da la ruta
'        'para que encunetre la base de datos quejas, en este caso esta creada en sqlCompact

'        If Not System.IO.File.Exists(Base_Quejas) Then 'Si no existe la base de datos pasara el mensaje

'            MsgBox("Lo sentimos no se puedo conectar a la base de datos", vbCritical, "Error de Conexion")
'            Exit Sub ' cierro el procedimiento
'        Else
'            Try
'                Cadenas = "Data Source=" & Base_Quejas
'                'Paso el valor de la ruta base_quejas a la variabble cadena
'                Conexion = New SqlServerCe.SqlCeConnection(Cadenas)
'                ' Paso el valor de la variable conexion de tipo sqlconection (variable cadena)
'                If Conexion.State = ConnectionState.Open Then ' Si el estado de conexion es abierto entonces la cierro y la abro de nuevo
'                    Conexion.Close()
'                    Conexion.Open()
'                End If
'            Catch ex As Exception
'                MsgBox(ex.ToString, vbCritical, "No se puede conectar a la base de datos.Por favor espesifique la ruta de la base de datos")
'            End Try
'        End If
'    End Sub

'    'C:\Users\Luis\Documents\Almacen de informacion\Tutoriales Melia Recoleta\Otra mas\Quejas\Quejas\Quejas.sdf
'    'Data Source=|DataDirectory|\Quejas.sdf
'End Module