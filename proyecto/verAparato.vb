Imports MySql.Data.MySqlClient
Public Class verAparato
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comando As MySqlCommand = New MySqlCommand
    Public value As String
    Private Sub verAparato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password ='" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Tabla As New DataTable
        Dim conexion As MySqlConnection
        Dim Ds As New DataSet
        conexion = New MySql.Data.MySqlClient.MySqlConnection
        conexion.ConnectionString = "server = localhost;user = 'root';password =''; database = bdproyecto0.51; Convert Zero Datetime=True"
        Dim insertar As New MySqlDataAdapter("DELETE FROM artefactos WHERE ArtefactoId = '" & value & "'", conexion)

        Try
            insertar.Fill(Tabla)
            MessageBox.Show("Proceso de registro exitoso")
            conexion.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
        End Try
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        comando.Connection = conexion
        Try
            conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password ='" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        value = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub
End Class