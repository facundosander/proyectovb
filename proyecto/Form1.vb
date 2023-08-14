Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class Form1
    Public userType As String
    Public userPass As String
    Public user As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btIngresar.Click
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "server = localhost;user = '" + userType + "';password = '" + userPass + "'; database = bdproyecto0.51"
            conexion.Open()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
        Dim has As New OC.Core.Crypto.Hash
        Dim texto As String = txtContra.Text
        Dim contra = has.Sha512(texto).ToLower
        user = txtUsuario.Text

        comando.CommandText = "SELECT * from usuario WHERE usuarioNombre='" + user + "'AND usuarioContraseña='" + contra + "' and usuarioTipo= '" + userType + "'"

        Dim r As MySqlDataReader
        r = comando.ExecuteReader

        If r.HasRows <> False Then
            r.Read()
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("El usuario es incorrecto")


        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Show()
        txtContra.Text = ""
        txtUsuario.Text = ""
        userType = ""
        userPass = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Hide()
        Button2.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles empBtn.Click
        userType = "Empleado"
        userPass = "Empleado"
        Panel2.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles admBtn.Click
        userType = "Administrativo"
        userPass = "Administrativo"
        Panel2.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles mtnBtn.Click
        userType = "Mantenimiento"
        userPass = "Mantenimiento"
        Panel2.Hide()
    End Sub


    Private Sub regBtn_Click(sender As Object, e As EventArgs) Handles regBtn.Click
        Panel3.Show()
        Button2.Show()
        Panel2.Hide()
        If (Panel3.Controls.Count > 0) Then
            Panel3.Controls.RemoveAt(0)
        Else
            Dim form As Form
            form = FormRegistrarse
            form.TopLevel = False
            form.Dock = DockStyle.Fill
            Panel3.Controls.Add(form)
            Panel3.Tag = form
            form.Show()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If (Panel3.Controls.Count > 0) Then
            Panel3.Controls.RemoveAt(0)
        Else
            Dim form As Form
            form = FormRegistrarse
            form.Close()
        End If
        Panel3.Hide()
        Panel2.Show()
        Button2.Hide()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
