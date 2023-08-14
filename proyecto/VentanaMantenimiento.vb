Imports System.Globalization
Imports MySql.Data.MySqlClient
Public Class VentanaMantenimiento
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comando As MySqlCommand = New MySqlCommand

    Private Sub VentanaMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comando.Connection = conexion

        Try
            conexion.ConnectionString = "server = localhost;user = root;password =; database = bdproyecto0.51; Convert Zero Datetime=True"
            conexion.Open()
            Dim consulta As String
            consulta = "Select artefactos.ArtefactoId, artefactos.ArtefactoNombre, reparacionesFecha, reparacionesProblema, reparacionesEstado, reparacionesSolucion, usuario.usuarioNombre from artefactos JOIN reparaciones on artefactos.ArtefactoId = reparaciones.id_artefacto JOIN usuario on reparaciones.usuarioId = usuario.usuarioId"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "reparaciones")
            DataGridView1.DataSource = datos.Tables(0)
            cargarcombonom()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub cargarcombonom()
        comando.Connection = conexion
        Dim tabla As New DataTable
        Dim sql As String = "Select usuarioNombre, usuarioId from usuario"
        Dim adp As New MySqlDataAdapter(sql, conexion)
        adp.Fill(tabla)
        ComboBox1.DataSource = tabla
        ComboBox1.DisplayMember = "usuarioNombre"
        ComboBox1.ValueMember = "usuarioId"

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cod As Integer = Val(ComboBox1.SelectedValue.ToString)
        comando.Connection = conexion
        Dim consulta As String
        If (cod > 0) Then
            Try
                consulta = "Select artefactos.ArtefactoId, artefactos.ArtefactoNombre, reparacionesFecha, reparacionesProblema, reparacionesEstado, reparacionesSolucion, usuario.usuarioNombre from artefactos JOIN reparaciones on artefactos.ArtefactoId = reparaciones.id_artefacto JOIN usuario on reparaciones.usuarioId = usuario.usuarioId where usuario.usuarioId= " & cod
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "reparaciones")
                DataGridView1.DataSource = datos.Tables(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            Try
                consulta = "Select artefactos.ArtefactoId, artefactos.ArtefactoNombre, reparacionesFecha, reparacionesProblema, reparacionesEstado, reparacionesSolucion, usuario.usuarioNombre from artefactos JOIN reparaciones on artefactos.ArtefactoId = reparaciones.id_artefacto JOIN usuario on reparaciones.usuarioId = usuario.usuarioId"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "reparaciones")
                DataGridView1.DataSource = datos.Tables(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim cod As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        comando.Connection = conexion
        Dim consulta As String
        Try
            consulta = "Select artefactos.ArtefactoId, artefactos.ArtefactoNombre, reparacionesFecha, reparacionesProblema, reparacionesEstado, reparacionesSolucion, usuario.usuarioNombre from artefactos JOIN reparaciones on artefactos.ArtefactoId = reparaciones.id_artefacto JOIN usuario on reparaciones.usuarioId = usuario.usuarioId where reparacionesFecha= '" & cod & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "reparaciones")
            DataGridView1.DataSource = datos.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim cod As String = TextBox2.Text
        comando.Connection = conexion
        Dim consulta As String
        Try
            consulta = "Select artefactos.ArtefactoId, artefactos.ArtefactoNombre, reparacionesFecha, reparacionesProblema, reparacionesEstado, reparacionesSolucion, usuario.usuarioNombre from artefactos JOIN reparaciones on artefactos.ArtefactoId = reparaciones.id_artefacto JOIN usuario on reparaciones.usuarioId = usuario.usuarioId where artefactos.ArtefactoNombre LIKE '" & cod & "%'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "reparaciones")
            DataGridView1.DataSource = datos.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim cod As String = TextBox1.Text
        comando.Connection = conexion
        Dim consulta As String
        Try
            consulta = "Select artefactos.ArtefactoId, artefactos.ArtefactoNombre, reparacionesFecha, reparacionesProblema, reparacionesEstado, reparacionesSolucion, usuario.usuarioNombre from artefactos JOIN reparaciones on artefactos.ArtefactoId = reparaciones.id_artefacto JOIN usuario on reparaciones.usuarioId = usuario.usuarioId where artefactos.ArtefactoId LIKE '" & cod & "%'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "reparaciones")
            DataGridView1.DataSource = datos.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class