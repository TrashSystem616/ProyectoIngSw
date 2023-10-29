Public Class Form3

    'Ponemos los datos de fecha en el label'
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub
End Class