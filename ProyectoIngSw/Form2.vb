Public Class Form2

    'Muestra el formulario 3'
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Form3.ShowDialog()

    End Sub

    Private Sub InventarioGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioGeneralToolStripMenuItem.Click
        Form4.ShowDialog()
    End Sub
End Class