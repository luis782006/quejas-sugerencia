Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration


Module Procedimiento
    Sub Conectar_Base() ' Procedimiento de conexion
        Base_Quejas = Application.StartupPath & "\Quejas.accdb " 'Le doy el valor de la variable creada.Aplicacion.StartPath le da la ruta
        'para que encuentre la base de datos quejas, en este caso esta creada en sqlCompact

        If Not System.IO.File.Exists(Base_Quejas) Then 'Si no existe la base de datos pasara el mensaje

            MsgBox("Lo sentimos no se puedo conectar a la base de datos", vbCritical, "Error de Conexion")
            Exit Sub ' cierro el procedimiento
        Else
            Try
                Cadenas = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Base_Quejas
                'Paso el valor de la ruta base_quejas a la variable cadena
                Conexion = New OleDb.OleDbConnection(Cadenas)
                Conexion.ConnectionString = Cadenas ' a la conecionstring le paso el valor de la variable cadena que contiene la direccion
                Comando.CommandType = CommandType.Text ' al comando le digo el type que va ser
                Comando.Connection = Conexion ' al comando de conexion le paso el valo dela conexion

                ' Paso el valor de la variable conexion de tipo sqlconection (variable cadena)
                If Conexion.State = ConnectionState.Open Then ' Si el estado de conexion es abierto entonces la cierro y la abro de nuevo
                    Conexion.Close()
                    Conexion.Open()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, vbCritical, "No se puede conectar a la base de datos.Por favor especifique la ruta de la base de datos")
            End Try
        End If
    End Sub
   
End Module

