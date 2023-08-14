Imports MySql.Data.MySqlClient
Public Class editarMantenimiento
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comando As MySqlCommand = New MySqlCommand
    Public value1, value2, value3, value4, value5, value6, value7 As Object
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        editarMantenimientoPanel.CerrarFormHijo(Me)
        value1 = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        value2 = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        value3 = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        value4 = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        value5 = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        value6 = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        value7 = DataGridView1.Rows(e.RowIndex).Cells(0).Value

        editarMantenimientoPanel.AbrirFormHijo(editarMantenimiento2)

    End Sub
    Private Sub cargarTabla()
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password ='" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
            conexion.Open()
            Dim consulta As String
            consulta = "Select reparacionesId as 'Ids', id_artefacto as 'Artefacto', reparacionesProblema as 'Problema', reparacionesEstado as 'Estado', reparacionesSolucion as 'Solución', reparacionesFecha as 'Fecha', usuario.usuarioNombre as 'Nombre' from reparaciones JOIN usuario on usuario.usuarioId = reparaciones.usuarioId"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "reparaciones")
            DataGridView1.DataSource = datos.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub editarMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comando.Connection = conexion
        Try
            cargarTabla()
            cargarcombo()
            'MessageBox.Show("exito")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub cargarcombo()
        comando.Connection = conexion
        Dim tabla As New DataTable
        Dim sql As String = "Select usuarioNombre, usuarioId from usuario"
        Dim adp As New MySqlDataAdapter(sql, conexion)
        adp.Fill(tabla)
        ComboBox1.DataSource = tabla
        ComboBox1.DisplayMember = "usuarioNombre"
        ComboBox1.ValueMember = "usuarioId"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        editarMantenimientoPanel.Close()
        Form2.Show()
    End Sub
End Class