Public Class Form1

    Private Sub NUEVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NUEVOToolStripMenuItem.Click
        My.Forms.fromMotos.MdiParent = Me
        My.Forms.fromMotos.Show()
    End Sub

    Private Sub NUEVOToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NUEVOToolStripMenuItem1.Click
        My.Forms.fromPersonas.MdiParent = Me
        My.Forms.fromPersonas.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        My.Forms.fromConsultarMotos.MdiParent = Me
        My.Forms.fromConsultarMotos.Show()
    End Sub

    Private Sub CONSULTARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem1.Click
        My.Forms.fromConsultarPersonas.MdiParent = Me
        My.Forms.fromConsultarPersonas.Show()
    End Sub

    Private Sub NUEVOToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NUEVOToolStripMenuItem2.Click
        My.Forms.fromAlquiler.MdiParent = Me
        My.Forms.fromAlquiler.Show()
    End Sub
End Class
