Public Class CuentasPanel
    Private Sub CuetasPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Panel1.Controls.Count > 0) Then
            Panel1.Controls.RemoveAt(0)
        Else
            Dim form As Form
            form = AgregarUsuario
            form.TopLevel = False
            form.Dock = DockStyle.Fill
            Panel1.Controls.Add(form)
            Panel1.Tag = form
            form.Show()
        End If

        If (Panel2.Controls.Count > 0) Then
            Panel2.Controls.RemoveAt(0)
        Else
            Dim form As Form
            form = VerCuentas
            form.TopLevel = False
            form.Dock = DockStyle.Fill
            Panel2.Controls.Add(form)
            Panel2.Tag = form
            form.Show()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class