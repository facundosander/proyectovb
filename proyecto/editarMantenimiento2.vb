Imports MySql.Data.MySqlClient
Public Class editarMantenimiento2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        editarMantenimientoPanel.AbrirFormHijo(editarMantenimiento)
    End Sub

    Private Sub editarMantenimiento2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = editarMantenimiento.value1
        TextBox1.Text = editarMantenimiento.value2
        RichTextBox3.Text = editarMantenimiento.value3
        RichTextBox1.Text = editarMantenimiento.value4
        DateTimePicker1.Value = editarMantenimiento.value5
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tabla As New DataTable
        Dim conexion As MySqlConnection



        Dim Ds As New DataSet
        conexion = New MySql.Data.MySqlClient.MySqlConnection
        MsgBox(Form1.user)
        conexion.ConnectionString = "server = localhost;user = '" + Form1.userType + "';password ='" + Form1.userPass + "'; database = bdproyecto0.51; Convert Zero Datetime=True"
        Dim insertar As New MySqlDataAdapter("UPDATE reparaciones SET reparacionesEstado='" & RichTextBox3.Text & "', reparacionesSolucion='" & RichTextBox1.Text & "', reparacionesProblema='" & TextBox1.Text & "' where reparacionesId='" & editarMantenimiento.value7 & "'", conexion)

        Try
            insertar.Fill(Tabla)
            MessageBox.Show("Proceso de registro exitoso")
            conexion.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
        End Try
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
End Class