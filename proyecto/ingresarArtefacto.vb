Imports MySql.Data.MySqlClient
Public Class ingresarArtefacto
    Dim datos As DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comando As MySqlCommand = New MySqlCommand

    Public Sub cargarcombonom()
        comando.Connection = conexion
        Dim tabla As New DataTable
        Dim sql As String = "Select sectorTipo, sectorId from sector where sectorId not in(7,8)"
        Dim adp As New MySqlDataAdapter(sql, conexion)
        adp.Fill(tabla)
        ComboBox1.DataSource = tabla
        ComboBox1.DisplayMember = "sectorTipo"
        ComboBox1.ValueMember = "sectprId"

    End Sub
    Private Sub ingresarArtefacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comando.Connection = conexion

        Try
            conexion.ConnectionString = "server = localhost;user = root;password =; database = bdproyecto0.51; Convert Zero Datetime=True"
            conexion.Open()
            cargarcombonom()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tabla As New DataTable
        Dim conexion As MySqlConnection
        Dim Ds As New DataSet
        conexion = New MySql.Data.MySqlClient.MySqlConnection
        conexion.ConnectionString = "server = localhost;user = '" & Form1.userType & "';password = '" & Form1.userPass & "'; database = bdproyecto0.51;"
        If TextBox4.Text.Equals("") Then
            Dim insertar As New MySqlDataAdapter("INSERT INTO `artefactos` (`ArtefactoId`, `artefactoTipo`, `ArtefactoNombre`, `ArtefactoMarca`, `ArtefactoUltFechaReparacion`, `ArtefactoIntervaloMant`, `ArtefactoModelo`, `artefactoCValor`, `artefactoCUnidad`, `artefactoCParte1`, `artefactoCParte2`, `artefactoCParte3`, `artefactoCParte4`, `artefactoCParte5`, `artefactoCParte6`, `id_sector`, `sectorNhabitacion`) 
            VALUES ('" & TextBox7.Text & "', 's', '" & TextBox2.Text + "', '" & TextBox3.Text & "', ' " & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', '" & TextBox5.Text & "', ' " & TextBox6.Text & " ', '0', '0', '0', '0', '0', '0', '0', '0', ' " & ComboBox1.SelectedIndex & " ', '0')", conexion)

            Try
                insertar.Fill(Tabla)
                MessageBox.Show("Proceso de registro exitoso")
                'conexion.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
            End Try
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            Dim nhab As Integer
            nhab = Val(TextBox4.Text) Mod 2
            If nhab = 0 Then
                Dim insertar As New MySqlDataAdapter("INSERT INTO `artefactos` (`ArtefactoId`, `artefactoTipo`, `ArtefactoNombre`, `ArtefactoMarca`, `ArtefactoUltFechaReparacion`, `ArtefactoIntervaloMant`, `ArtefactoModelo`, `artefactoCValor`, `artefactoCUnidad`, `artefactoCParte1`, `artefactoCParte2`, `artefactoCParte3`, `artefactoCParte4`, `artefactoCParte5`, `artefactoCParte6`, `id_sector`, `sectorNhabitacion`) 
            VALUES ('" & TextBox7.Text & "', 's', '" & TextBox2.Text + "', '" & TextBox3.Text & "', ' " & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', '" & TextBox5.Text & "', ' " & TextBox6.Text & " ', '0', '0', '0', '0', '0', '0', '0', '0', '7', '" & Val(TextBox4.Text) & "')", conexion)

                Try
                    insertar.Fill(Tabla)
                    MessageBox.Show("Proceso de registro exitoso")
                    'conexion.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                End Try
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Else
                Dim insertar As New MySqlDataAdapter("INSERT INTO `artefactos` (`ArtefactoId`, `artefactoTipo`, `ArtefactoNombre`, `ArtefactoMarca`, `ArtefactoUltFechaReparacion`, `ArtefactoIntervaloMant`, `ArtefactoModelo`, `artefactoCValor`, `artefactoCUnidad`, `artefactoCParte1`, `artefactoCParte2`, `artefactoCParte3`, `artefactoCParte4`, `artefactoCParte5`, `artefactoCParte6`, `id_sector`, `sectorNhabitacion`) 
            VALUES ('" & TextBox7.Text & "', 's', '" & TextBox2.Text + "', '" & TextBox3.Text & "', ' " & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', '" & TextBox5.Text & "', ' " & TextBox6.Text & " ', '0', '0', '0', '0', '0', '0', '0', '0', '8', '" & Val(TextBox4.Text) & "')", conexion)

                Try
                    insertar.Fill(Tabla)
                    MessageBox.Show("Proceso de registro exitoso")
                    'conexion.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                End Try
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class