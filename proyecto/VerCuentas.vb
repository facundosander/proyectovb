Imports MySql.Data.MySqlClient
Public Class VerCuentas
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comando As MySqlCommand = New MySqlCommand
    Public value As String
    Private Sub VerCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTabla()
    End Sub
    Public Sub cargarTabla()
        Try
            conexion.ConnectionString = "server = localhost;user = root;password =; database = bdproyecto0.51; Convert Zero Datetime=True"
            conexion.Open()
            Dim consulta As String
            consulta = "Select usuarioId as 'codigo', usuarioNombre as 'Nombre', usuarioTipo as 'Tipo' from usuario"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "usuario")
            DataGridView1.DataSource = datos.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexion.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        value = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub
End Class