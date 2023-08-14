Public Class editarMantenimientoPanel
    Public Sub AbrirFormHijo(formhijo As Object)
        If (Panel1.Controls.Count > 0) Then
            Panel1.Controls.RemoveAt(0)
        Else
            Dim form As Form
            form = formhijo
            form.TopLevel = False
            form.Dock = DockStyle.Fill
            Panel1.Controls.Add(form)
            Panel1.Tag = form
            form.Show()
        End If
    End Sub
    Public Sub CerrarFormHijo(formhijo As Object)
        If (Panel1.Controls.Count > 0) Then
            Panel1.Controls.RemoveAt(0)
        Else
            Dim form As Form
            form = formhijo
            form.Close()
        End If
    End Sub
    Private Sub editarMantenimientoPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirFormHijo(editarMantenimiento)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form2.Show()
    End Sub
End Class