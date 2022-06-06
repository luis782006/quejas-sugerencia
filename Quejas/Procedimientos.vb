Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Module Procedimientos
    Public Conexion As OleDb.OleDbConnection   'Variable que almacena la conexion de tipo de conexion,
    'segun el provedor de base de datos que se utilice
    Public Cadenas As String 'Variable que almacena la cadena de conexion

    Public Base_Quejas As String = Application.StartupPath & "\Quejas.accdb " ' Variable que almacena la ruta de lla base de datos
    Public rutaHelp As String = Application.StartupPath & "\Ayuda y Soporte.chm"

    Public Comando As New OleDb.OleDbCommand    ' Variable que almacena los comandos para insertar .....y demas,segun el tipo de provedor que se utilice
    Public ConsultaSql As String = "" 'Variable que almacena las consultas en sql y la dejo vacia para llenarla luego
    'Public Lector As SqlCeDataReader  'Variable que almacena un comando de lectura,segun el provedor de base de dato
    Public fileReaderH As String ' variable string para la cadena de ubicacion del texto
    Public fileReaderF As String  'variable string para sobreescribir el texto
    Public direccion As String ' variable para la direccion de la cadena
    Public openDialog As New OpenFileDialog

    '******fechas*******
    Public fechadesde As String
    Public fechahasta As String
    Public departamento As String
    '******Varibale de Mail******
    Public DMail As String
    '******Variables de Config de Correos**********
    Public host As String
    Public desde As String
    Public contraseña As String
    Public puerto As Int16
    Public credencial As String
    '******Control de CntR**********
    Public cntR As Integer



    Public Sub DeshabilitarMenu()
        frmGeneral.btnInsertarQueja.Enabled = False
        frmGeneral.btnMostrar.Enabled = False
        frmGeneral.btnQuejasPendientes.Enabled = False
        frmGeneral.btnEnviarQuejas.Enabled = False
        frmGeneral.btnAjustes.Enabled = False


    End Sub
    Public Sub HabilitarMenu()
        frmGeneral.btnInsertarQueja.Enabled = True
        frmGeneral.btnMostrar.Enabled = True
        frmGeneral.btnQuejasPendientes.Enabled = True
        frmGeneral.btnEnviarQuejas.Enabled = True
        frmGeneral.btnAjustes.Enabled = True


    End Sub
    Public Sub AbrirVentanaP()
        Dim QuejasPendientes As New frmQuejasPendientes
        QuejasPendientes.MdiParent = frmGeneral
        QuejasPendientes.Show()
        QuejasPendientes.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Public Sub AbrirEnvioQuejas()
        Dim EnvioQuejas As New frmEnvioQuejas
        EnvioQuejas.MdiParent = frmGeneral
        EnvioQuejas.Show()
        EnvioQuejas.StartPosition = FormStartPosition.CenterScreen
    End Sub
    'Public PersonalTableAdapter As OleDbDataAdapter
    '    PersonalTableAdapter = New OleDbDataAdapter
    '    PersonalTableAdapter.SelectCommand = New OleDbCommand("Select Personal form Personal", Conexion)
    'Public PersonalDataSet As DataSet
    '    PersonalDataSet = New DataSet
    '    PersonalDataSet.Tables.Add("Personal")
    '    PersonalTableAdapter.Fill(PersonalDataSet.Tables("Personal"))

    Public Sub ConfigBloqueo()
        frmConfigCorreos.txtPort.ReadOnly = True
        frmConfigCorreos.txtHost.ReadOnly = True
        frmConfigCorreos.txtDesde.ReadOnly = True
        frmConfigCorreos.txtCredencial.ReadOnly = True
        frmConfigCorreos.txtContraseña.ReadOnly = True
    End Sub

End Module
