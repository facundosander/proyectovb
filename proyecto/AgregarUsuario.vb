Imports MySql.Data.MySqlClient
Public Class AgregarUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tabla As New DataTable
        Dim conexion As MySqlConnection
        Dim Ds As New DataSet
        conexion = New MySql.Data.MySqlClient.MySqlConnection
        conexion.ConnectionString = "server = localhost;user = 'root';password =''; database = bdproyecto0.51; Convert Zero Datetime=True"
        Dim insertar As New MySqlDataAdapter("DELETE FROM usuario WHERE usuarioId = '" & VerCuentas.value & "'", conexion)

        Try
            insertar.Fill(Tabla)
            conexion.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
        End Try
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        VerCuentas.cargarTabla()
    End Sub

    Private Sub AgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class