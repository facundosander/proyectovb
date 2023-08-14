Imports System.Security.Principal
Imports MySql.Data.MySqlClient
Public Class ingresarMantenimiento
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comando As MySqlCommand = New MySqlCommand
    Private Sub ingresarMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        comando.Connection = conexion
        Try
            conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password = '" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
            conexion.Open()
            Dim consulta As String
            consulta = "Select * from artefactos"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "artefactos")
            DataGridView1.DataSource = datos.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexion.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles prbTxt.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tabla As New DataTable
        Dim conexion As MySqlConnection
        Dim Ds As New DataSet
        Dim fechax As DateTime
        Dim fechatxt As String
        fecha.Format = DateTimePickerFormat.Custom
        fecha.CustomFormat = "yyyy-MM-dd"
        'fechax = fecha.MinDate.Date.

        fechatxt = fechax.ToString
        conexion = New MySql.Data.MySqlClient.MySqlConnection
        MsgBox(Form1.user)
        conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password ='" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
        Dim insertar As New MySqlDataAdapter("INSERT INTO reparaciones (reparacionesId, reparacionesFecha, reparacionesProblema, reparacionesEstado, reparacionesSolucion, usuarioId, id_artefacto) 
                                            Select MAX(reparacionesId)+1,'" + fecha.Value.ToString("yyyy-MM-dd") + "', '" + prbTxt.Text + "', '" + estTxt.Text + "', '" + solTxt.Text + "', (SELECT usuarioId FROM usuario WHERE usuarioNombre='" + Form1.user + "'), '" + nSerieTxt.Text + "' FROM reparaciones", conexion)
        Try
            insertar.Fill(Tabla)
            MessageBox.Show("Proceso de registro exitoso")
            'conexion.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
        End Try
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If marcaTxt.Text <> Nothing Then
            Try
                conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password ='" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
                conexion.Open()
                Dim consulta As String
                consulta = "Select * from artefactos where ArtefactoMarca = '" + marcaTxt.Text + "'"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "artefactos")
                DataGridView1.DataSource = datos.Tables(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf tipoTxt.Text <> Nothing Then
            Try
                conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password ='" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
                Dim consulta As String
                consulta = "Select * from artefactos where ArtefactoTipo = '" + tipoTxt.Text + "'"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "artefactos")
                DataGridView1.DataSource = datos.Tables(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf sectorTxt.Text <> Nothing Then
            Try
                conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password ='" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
                Dim consulta As String
                consulta = "Select * from artefactos where id_sector = '" + sectorTxt.Text + "'"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "artefactos")
                DataGridView1.DataSource = datos.Tables(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf marcaTxt.Text <> Nothing And tipoTxt.Text <> Nothing Then
            Try
                conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password ='" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
                Dim consulta As String
                consulta = "Select * from artefactos where ArtefactoMarca = '" + marcaTxt.Text + "' and ArtefactoTipo = '" + tipoTxt.Text + "'"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "artefactos")
                DataGridView1.DataSource = datos.Tables(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf tipoTxt.Text <> Nothing And sectorTxt.Text <> Nothing Then
            Try
                conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password ='" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
                Dim consulta As String
                consulta = "Select * from artefactos where ArtefactoTipo = '" + tipoTxt.Text + "' and id_sector='" + sectorTxt.Text + "'"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "artefactos")
                DataGridView1.DataSource = datos.Tables(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf marcaTxt.Text <> Nothing And sectorTxt.Text <> Nothing Then
            Try
                conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password ='" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
                Dim consulta As String
                consulta = "Select * from artefactos where ArtefactoMarca = '" + marcaTxt.Text + "' and id_sector = '" + sectorTxt.Text + "'"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "artefactos")
                DataGridView1.DataSource = datos.Tables(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password ='" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
                Dim consulta As String
                consulta = "Select * from artefactos where ArtefactoMarca = '" + marcaTxt.Text + "' and ArtefactoTipo='" + tipoTxt.Text + "' and id_sector='" + sectorTxt.Text + "'"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "artefactos")
                DataGridView1.DataSource = datos.Tables(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        conexion.Close()
    End Sub

    Private Sub marcaTxt_TextChanged(sender As Object, e As EventArgs) Handles marcaTxt.TextChanged
        If marcaTxt.Text = Nothing Then
            comando.Connection = conexion
            Try
                conexion.ConnectionString = "server = localhost;user = root;password =; database = bdproyecto0.51; Convert Zero Datetime=True"
                conexion.Open()
                Dim consulta As String
                consulta = "Select * from artefactos"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "artefactos")
                DataGridView1.DataSource = datos.Tables(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            conexion.Close()
        End If
    End Sub

    Private Sub tipoTxt_TextChanged(sender As Object, e As EventArgs) Handles tipoTxt.TextChanged
        If tipoTxt.Text = Nothing Then
            comando.Connection = conexion
            Try
                conexion.ConnectionString = "server = localhost;user = root;password =; database = bdproyecto0.51; Convert Zero Datetime=True"
                conexion.Open()
                Dim consulta As String
                consulta = "Select * from artefactos"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "artefactos")
                DataGridView1.DataSource = datos.Tables(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            conexion.Close()
        End If
    End Sub

    Private Sub sectorTxt_TextChanged(sender As Object, e As EventArgs) Handles sectorTxt.TextChanged
        If sectorTxt.Text = Nothing Then
            comando.Connection = conexion
            Try
                conexion.ConnectionString = "server = localhost;user = root;password =; database = bdproyecto0.51; Convert Zero Datetime=True"
                conexion.Open()
                Dim consulta As String
                consulta = "Select * from artefactos"
                adaptador = New MySqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "artefactos")
                DataGridView1.DataSource = datos.Tables(0)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            conexion.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim value As Object = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

        If IsDBNull(value) Then
            nSerieTxt.Text = CType(value, String)
        Else
            nSerieTxt.Text = CType(value, String)
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class