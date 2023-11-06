Imports System.Data.SqlClient

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mostramos los datos de la tabla productos'
        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()
            Dim query As String = "SELECT * FROM Inventario"
            Dim adaptador As New SqlDataAdapter(query, conexion)
            Dim dataSet As New DataSet()
            adaptador.Fill(dataSet, "Inventario")
            DataGridView1.DataSource = dataSet.Tables("Inventario")
            conexion.Close() ' Cierra la conexión al finalizar
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Modificacion As Integer
        'Piezas'
        ' Verifica si el TextBox está vacío o no contiene un número válido
        If String.IsNullOrEmpty(TextBox1.Text) Or Not Integer.TryParse(TextBox1.Text, Modificacion) Then
            MessageBox.Show("Por favor, ingrese un número válido en el TextBox que deseé modificar.")
        Else
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "UPDATE Inventario SET Piezas = Piezas + @Modificacion"
                Using command As New SqlCommand(query, conexion)
                    command.Parameters.AddWithValue("@Modificacion", Modificacion)
                    command.ExecuteNonQuery()
                End Using
                conexion.Close()
            End Using

            'Mostramos los datos de la tabla productos'
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "SELECT * FROM Inventario"
                Dim adaptador As New SqlDataAdapter(query, conexion)
                Dim dataSet As New DataSet()
                adaptador.Fill(dataSet, "Inventario")
                DataGridView1.DataSource = dataSet.Tables("Inventario")
                conexion.Close() ' Cierra la conexión al finalizar
            End Using
        End If

        'Tiras'
        If String.IsNullOrEmpty(TextBox2.Text) Or Not Integer.TryParse(TextBox2.Text, Modificacion) Then
            MessageBox.Show("Por favor, ingrese un número válido en el TextBox que deseé modificar.")
        Else
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "UPDATE Inventario SET Tiras = Tiras + @Modificacion"
                Using command As New SqlCommand(query, conexion)
                    command.Parameters.AddWithValue("@Modificacion", Modificacion)
                    command.ExecuteNonQuery()
                End Using
                conexion.Close()
            End Using

            'Mostramos los datos de la tabla productos'
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "SELECT * FROM Inventario"
                Dim adaptador As New SqlDataAdapter(query, conexion)
                Dim dataSet As New DataSet()
                adaptador.Fill(dataSet, "Inventario")
                DataGridView1.DataSource = dataSet.Tables("Inventario")
                conexion.Close() ' Cierra la conexión al finalizar
            End Using
        End If

        'BigKrunch'
        If String.IsNullOrEmpty(TextBox3.Text) Or Not Integer.TryParse(TextBox3.Text, Modificacion) Then
            MessageBox.Show("Por favor, ingrese un número válido en el TextBox que deseé modificar.")
        Else
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "UPDATE Inventario SET BigKrunch = BigKrunch + @Modificacion"
                Using command As New SqlCommand(query, conexion)
                    command.Parameters.AddWithValue("@Modificacion", Modificacion)
                    command.ExecuteNonQuery()
                End Using
                conexion.Close()
            End Using

            'Mostramos los datos de la tabla productos'
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "SELECT * FROM Inventario"
                Dim adaptador As New SqlDataAdapter(query, conexion)
                Dim dataSet As New DataSet()
                adaptador.Fill(dataSet, "Inventario")
                DataGridView1.DataSource = dataSet.Tables("Inventario")
                conexion.Close() ' Cierra la conexión al finalizar
            End Using
        End If

        'Papas'
        If String.IsNullOrEmpty(TextBox4.Text) Or Not Integer.TryParse(TextBox4.Text, Modificacion) Then
            MessageBox.Show("Por favor, ingrese un número válido en el TextBox que deseé modificar.")
        Else
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "UPDATE Inventario SET Papas = Papas + @Modificacion"
                Using command As New SqlCommand(query, conexion)
                    command.Parameters.AddWithValue("@Modificacion", Modificacion)
                    command.ExecuteNonQuery()
                End Using
                conexion.Close()
            End Using

            'Mostramos los datos de la tabla productos'
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "SELECT * FROM Inventario"
                Dim adaptador As New SqlDataAdapter(query, conexion)
                Dim dataSet As New DataSet()
                adaptador.Fill(dataSet, "Inventario")
                DataGridView1.DataSource = dataSet.Tables("Inventario")
                conexion.Close() ' Cierra la conexión al finalizar
            End Using
        End If

        'Pure'
        If String.IsNullOrEmpty(TextBox5.Text) Or Not Integer.TryParse(TextBox5.Text, Modificacion) Then
            MessageBox.Show("Por favor, ingrese un número válido en el TextBox que deseé modificar.")
        Else
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "UPDATE Inventario SET Pure = Pure + @Modificacion"
                Using command As New SqlCommand(query, conexion)
                    command.Parameters.AddWithValue("@Modificacion", Modificacion)
                    command.ExecuteNonQuery()
                End Using
                conexion.Close()
            End Using

            'Mostramos los datos de la tabla productos'
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "SELECT * FROM Inventario"
                Dim adaptador As New SqlDataAdapter(query, conexion)
                Dim dataSet As New DataSet()
                adaptador.Fill(dataSet, "Inventario")
                DataGridView1.DataSource = dataSet.Tables("Inventario")
                conexion.Close() ' Cierra la conexión al finalizar
            End Using
        End If

        'Ensalada'
        If String.IsNullOrEmpty(TextBox6.Text) Or Not Integer.TryParse(TextBox6.Text, Modificacion) Then
            MessageBox.Show("Por favor, ingrese un número válido en el TextBox que deseé modificar.")
        Else
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "UPDATE Inventario SET Ensalada = Ensalada + @Modificacion"
                Using command As New SqlCommand(query, conexion)
                    command.Parameters.AddWithValue("@Modificacion", Modificacion)
                    command.ExecuteNonQuery()
                End Using
                conexion.Close()
            End Using

            'Mostramos los datos de la tabla productos'
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "SELECT * FROM Inventario"
                Dim adaptador As New SqlDataAdapter(query, conexion)
                Dim dataSet As New DataSet()
                adaptador.Fill(dataSet, "Inventario")
                DataGridView1.DataSource = dataSet.Tables("Inventario")
                conexion.Close() ' Cierra la conexión al finalizar
            End Using
        End If

        'Bisquets'
        If String.IsNullOrEmpty(TextBox7.Text) Or Not Integer.TryParse(TextBox7.Text, Modificacion) Then
            MessageBox.Show("Por favor, ingrese un número válido en el TextBox que deseé modificar.")
        Else
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "UPDATE Inventario SET Bisquets = Bisquets + @Modificacion"
                Using command As New SqlCommand(query, conexion)
                    command.Parameters.AddWithValue("@Modificacion", Modificacion)
                    command.ExecuteNonQuery()
                End Using
                conexion.Close()
            End Using

            'Mostramos los datos de la tabla productos'
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "SELECT * FROM Inventario"
                Dim adaptador As New SqlDataAdapter(query, conexion)
                Dim dataSet As New DataSet()
                adaptador.Fill(dataSet, "Inventario")
                DataGridView1.DataSource = dataSet.Tables("Inventario")
                conexion.Close() ' Cierra la conexión al finalizar
            End Using
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Muestra una confirmación
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de vaciar la tabla?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            ' El usuario confirmó la acción, procede a actualizar los valores
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim queryActualizar As String = "UPDATE Inventario SET Piezas = 0, Tiras = 0, BigKrunch = 0, Papas = 0, Pure = 0, Ensalada = 0, Bisquets = 0"
                Using commandActualizar As New SqlCommand(queryActualizar, conexion)
                    commandActualizar.ExecuteNonQuery()
                End Using

                conexion.Close()
            End Using

            ' Actualiza el DataGridView para mostrar los valores actualizados
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                Dim query As String = "SELECT * FROM Inventario"
                Dim adaptador As New SqlDataAdapter(query, conexion)
                Dim dataSet As New DataSet()
                adaptador.Fill(dataSet, "Inventario")
                DataGridView1.DataSource = dataSet.Tables("Inventario")
                conexion.Close()
            End Using
        Else
            ' El usuario canceló la acción'
        End If
    End Sub
End Class