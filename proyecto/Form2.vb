Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirFormHijo(FormPanelPrincipal)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Form1.Close()
        End
    End Sub
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub MantenimientosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MantenimientosToolStripMenuItem.Click
        VentanaMantenimiento.Show()
    End Sub

    Private Sub IngresarToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles IngresarToolStripMenuItem2.Click
        ingresarMantenimiento.Show()
    End Sub

    Private Sub EditarToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem2.Click
        editarMantenimientoPanel.Show()
    End Sub

    Private Sub IngresarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles IngresarToolStripMenuItem.Click
        ingresarArtefacto.Show()
    End Sub


    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        verAparato.Show()
    End Sub

    Private Sub CuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem.Click
        CuentasPanel.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub EwewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EwewToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class