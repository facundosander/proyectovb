Imports MySql.Data.MySqlClient
Public Class FormRegistrarse
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "server = localhost;user = root;password = ''; database = bdproyecto0.51"
            conexion.Open()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
        Dim has As New OC.Core.Crypto.Hash
        Dim texto As String = Verifitxt.Text
        Dim contra = has.Sha512(texto).ToLower

        comando.CommandText = "SELECT * from usuario WHERE usuarioNombre='Admin'AND usuarioContraseña='" + contra + "'"

        Dim r As MySqlDataReader
        r = comando.ExecuteReader

        If r.HasRows <> False Then
            r.Read()

            Dim Tabla As New DataTable
            Dim Ds As New DataSet
        conexion = New MySql.Data.MySqlClient.MySqlConnection
            If TextBox2.Text.Equals(TextBox3.Text) Then
                Dim hasc As New OC.Core.Crypto.Hash
                Dim textoc As String = TextBox2.Text
                conexion.ConnectionString = "server = localhost;user = root;password =; database = bdproyecto0.51;"
                Dim insertar As New MySqlDataAdapter("INSERT INTO usuario (usuarioId, usuarioNombre, usuarioContraseña, usuarioTipo) SELECT MAX(usuarioId)+1, '" + TextBox1.Text + "', '" + hasc.Sha512(textoc).ToLower + "',
                                                  '" + ComboBox1.SelectedItem + "' FROM usuario", conexion)

                Try
                    insertar.Fill(Tabla)
                    conexion.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                End Try
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                MsgBox("Registrado correctamente")
            Else
                MsgBox("Las contraseñas no coinciden")
            End If
        Else
            MsgBox("El usuario es incorrecto")
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Verifitxt.TextChanged

    End Sub
End Class