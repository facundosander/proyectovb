Imports MySql.Data.MySqlClient
Public Class FormPanelTablas
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comando As MySqlCommand = New MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.CerrarFormHijo(Me)
        Form2.AbrirFormHijo(FormPanelPrincipal)
        conexion.Close()
    End Sub

    Private Sub FormPanelTablas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comando.Connection = conexion
    End Sub
    Public Sub cargarTabla(s As String)

        Try
            conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password = '" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
            conexion.Open()
            Dim consulta As String
            consulta = "Select reparaciones.reparacionesProblema, reparaciones.reparacionesEstado, reparaciones.reparacionesFecha, reparaciones.usuarioId, artefactos.ArtefactoMarca, artefactos.ArtefactoModelo FROM  reparaciones JOIN artefactos on reparaciones.id_artefacto=artefactos.ArtefactoId WHERE artefactos.id_sector='" + s + "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "reparaciones")
            DataGridView1.DataSource = datos.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class