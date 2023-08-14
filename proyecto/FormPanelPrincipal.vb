Public Class FormPanelPrincipal

    Private Sub sectorHabR_Click(sender As Object, e As EventArgs) Handles sectorHabR.Click
        Form2.CerrarFormHijo(Me)
        FormPanelTablas.cargarTabla("7")
        Form2.AbrirFormHijo(FormPanelTablas)
    End Sub

    Private Sub admVerde_Click(sender As Object, e As EventArgs) Handles admVerde.Click
        Form2.CerrarFormHijo(Me)
        FormPanelTablas.cargarTabla("1")
        Form2.AbrirFormHijo(FormPanelTablas)
    End Sub

    Private Sub admAzulC_Click(sender As Object, e As EventArgs) Handles admAzulC.Click
        Form2.CerrarFormHijo(Me)
        FormPanelTablas.cargarTabla("2")
        Form2.AbrirFormHijo(FormPanelTablas)
    End Sub

    Private Sub admAzulO_Click(sender As Object, e As EventArgs) Handles admAzulO.Click
        Form2.CerrarFormHijo(Me)
        FormPanelTablas.cargarTabla("3")
        Form2.AbrirFormHijo(FormPanelTablas)
    End Sub

    Private Sub sectorAmarillo_Click(sender As Object, e As EventArgs) Handles sectorAmarillo.Click
        Form2.CerrarFormHijo(Me)
        FormPanelTablas.cargarTabla("4")
        Form2.AbrirFormHijo(FormPanelTablas)
    End Sub

    Private Sub sectorRosado_Click(sender As Object, e As EventArgs) Handles sectorRosado.Click
        Form2.CerrarFormHijo(Me)
        FormPanelTablas.cargarTabla("5")
        Form2.AbrirFormHijo(FormPanelTablas)
    End Sub

    Private Sub sectorNaranja_Click(sender As Object, e As EventArgs) Handles sectorNaranja.Click
        Form2.CerrarFormHijo(Me)
        FormPanelTablas.cargarTabla("6")
        Form2.AbrirFormHijo(FormPanelTablas)
    End Sub

    Private Sub sectorHabM_Click(sender As Object, e As EventArgs) Handles sectorHabM.Click
        Form2.CerrarFormHijo(Me)
        FormPanelTablas.cargarTabla("8")
        Form2.AbrirFormHijo(FormPanelTablas)
    End Sub

End Class