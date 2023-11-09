Imports System.Data.SqlClient
Imports System.Text

Public Class Form3


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mostramos los datos de la tabla productos'
        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()
            Dim query As String = "SELECT * FROM Productos"
            Dim adaptador As New SqlDataAdapter(query, conexion)
            Dim dataSet As New DataSet()
            adaptador.Fill(dataSet, "Productos")
            DataGridView1.DataSource = dataSet.Tables("Productos")
            conexion.Close() ' Cierra la conexión al finalizar
        End Using

        'Ponemos los datos de fecha en el label'
        Label7.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Verifica si la celda clicada está en una fila válida (no en el encabezado)
        If e.RowIndex >= 0 Then
            ' Obtén el valor de la celda de la columna deseada
            Dim valorColumna As String = DataGridView1.Rows(e.RowIndex).Cells("ProductoID").Value.ToString()

            '8 piezas'
            If valorColumna = 1 Then
                ' Llena los ComboBoxes con los valores obtenidos
                ComboBox2.Text = 8 'Valor de las piezas'
                ComboBox4.Text = 1 'Valor del pure'
                ComboBox5.Text = 1 'Valor de la ensalada'
                ComboBox6.Text = 3 'valor de los bisquets'
                ComboBox3.Text = "" 'valor de las tiras'
                ComboBox9.Text = "" 'valor de las papas '
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = "" 'valor del refresco'
                PictureBox1.Image = My.Resources._8pzas
            End If

            '10 piezas'
            If valorColumna = 2 Then
                ComboBox2.Text = 10 'Valor de las piezas'
                ComboBox4.Text = 1 'Valor del pure'
                ComboBox5.Text = 1 'Valor de la ensalada'
                ComboBox6.Text = 4 'valor de los bisquets'
                ComboBox3.Text = "" 'valor de las tiras'
                ComboBox9.Text = "" 'valor de las papas '
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = "" 'valor del refresco'
                PictureBox1.Image = My.Resources._8pzas
            End If

            '12 piezas'
            If valorColumna = 3 Then
                ComboBox2.Text = 12 'Valor de las piezas'
                ComboBox4.Text = 1 'Valor del pure'
                ComboBox5.Text = 1 'Valor de la ensalada'
                ComboBox6.Text = 4 'valor de los bisquets'
                ComboBox3.Text = "" 'valor de las tiras'
                ComboBox9.Text = "" 'valor de las papas '
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = "" 'valor del refresco'
                PictureBox1.Image = My.Resources._8pzas
            End If

            'Ke tiras love'
            If valorColumna = 4 Then
                ComboBox2.Text = "" 'Valor de las piezas'
                ComboBox4.Text = "" 'Valor del pure'
                ComboBox5.Text = "" 'Valor de la ensalada'
                ComboBox6.Text = "" 'valor de los bisquets'
                ComboBox7.Text = "" 'valor de la hamburgesa'
                ComboBox8.Text = "" 'valor del refresco'
                ComboBox3.Text = 9 'valor de las tiras'
                ComboBox9.Text = 10 'valor de las papas '
                PictureBox1.Image = My.Resources.KTiras
            End If

            'Hamburgesa big krunch'
            If valorColumna = 5 Then
                ComboBox2.Text = "" 'Valor de las piezas'
                ComboBox4.Text = "" 'Valor del pure'
                ComboBox5.Text = "" 'Valor de la ensalada'
                ComboBox6.Text = "" 'valor de los bisquets'
                ComboBox3.Text = "" 'valor de las tiras'
                ComboBox7.Text = 1 'valor de la hamburgesa'
                ComboBox8.Text = 1 'valor del refresco'
                ComboBox9.Text = 1 'valor de las papas '
                PictureBox1.Image = My.Resources.bigcrunch

            End If

        End If
    End Sub

    'Filtro De Busqueda'
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim filtro As String = TextBox2.Text
        Dim vista As DataView = DirectCast(DataGridView1.DataSource, DataTable).DefaultView

        Dim filtroGlobal As New StringBuilder()

        If Not String.IsNullOrEmpty(filtro) Then
            filtroGlobal.Append("(")
            Dim primeraColumna As Boolean = True

            For Each columna As DataGridViewColumn In DataGridView1.Columns
                If columna.ValueType Is GetType(String) Then
                    If primeraColumna Then
                        primeraColumna = False
                    Else
                        filtroGlobal.Append(" OR ")
                    End If
                    filtroGlobal.Append(columna.DataPropertyName)
                    filtroGlobal.Append(" LIKE '%")
                    filtroGlobal.Append(filtro)
                    filtroGlobal.Append("%'")
                End If
            Next

            filtroGlobal.Append(")")
        End If

        vista.RowFilter = filtroGlobal.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox2.Text = "" 'Valor de las piezas'
        ComboBox4.Text = "" 'Valor del pure'
        ComboBox5.Text = "" 'Valor de la ensalada'
        ComboBox6.Text = "" 'valor de los bisquets'
        ComboBox3.Text = "" 'valor de las tiras'
        ComboBox9.Text = "" 'valor de las papas familiares'
        ComboBox7.Text = "" 'valor de la hamburgesa'
        ComboBox8.Text = "" 'valor del refresco'
        TextBox2.Text = ""
        TextBox1.Text = ""
        PictureBox1.Image = My.Resources.LogoKFC
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cantidadARestar As Integer ' Declarar la variable
        'Esto es para las Piezas'
        ' Verifica que el ComboBox tenga un valor de texto no vacío
        If Not String.IsNullOrEmpty(ComboBox2.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox2.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarPiezas As String = "SELECT Piezas FROM Inventario"
                        Using commandVerificarPiezas As New SqlCommand(queryVerificarPiezas, conexion)
                            Dim piezasEnInventario As Integer = CInt(commandVerificarPiezas.ExecuteScalar())
                            If piezasEnInventario > 0 AndAlso piezasEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET Piezas = Piezas - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Piezas en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para las Tiras'
        If Not String.IsNullOrEmpty(ComboBox3.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox3.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarTiras As String = "SELECT Tiras FROM Inventario"
                        Using commandVerificarTiras As New SqlCommand(queryVerificarTiras, conexion)
                            Dim TirasEnInventario As Integer = CInt(commandVerificarTiras.ExecuteScalar())
                            If TirasEnInventario > 0 AndAlso TirasEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET Tiras = Tiras - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Tiras en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para el Pure'
        If Not String.IsNullOrEmpty(ComboBox4.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox4.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarPure As String = "SELECT Pure FROM Inventario"
                        Using commandVerificarPure As New SqlCommand(queryVerificarPure, conexion)
                            Dim PureEnInventario As Integer = CInt(commandVerificarPure.ExecuteScalar())
                            If PureEnInventario > 0 AndAlso PureEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET Pure = Pure - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Pure en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para la Ensalada'
        If Not String.IsNullOrEmpty(ComboBox5.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox5.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarEnsalada As String = "SELECT Ensalada FROM Inventario"
                        Using commandVerificarEnsalada As New SqlCommand(queryVerificarEnsalada, conexion)
                            Dim EnsaladaEnInventario As Integer = CInt(commandVerificarEnsalada.ExecuteScalar())
                            If EnsaladaEnInventario > 0 AndAlso EnsaladaEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET Ensalada = Ensalada - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Ensalada en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para los bisquets'
        If Not String.IsNullOrEmpty(ComboBox6.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox6.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarBisquets As String = "SELECT Bisquets FROM Inventario"
                        Using commandVerificarBisquets As New SqlCommand(queryVerificarBisquets, conexion)
                            Dim BisquetsEnInventario As Integer = CInt(commandVerificarBisquets.ExecuteScalar())
                            If BisquetsEnInventario > 0 AndAlso BisquetsEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET Bisquets = Bisquets - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Bisquets en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para las hamburgesas'
        If Not String.IsNullOrEmpty(ComboBox7.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox7.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarHamburgesa As String = "SELECT BigKrunch FROM Inventario"
                        Using commandVerificarHamburgesa As New SqlCommand(queryVerificarHamburgesa, conexion)
                            Dim HamburgesaEnInventario As Integer = CInt(commandVerificarHamburgesa.ExecuteScalar())
                            If HamburgesaEnInventario > 0 AndAlso HamburgesaEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET BigKrunch = BigKrunch - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes BigKrunch en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para el Refresco'
        If Not String.IsNullOrEmpty(ComboBox8.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox8.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarRefresco As String = "SELECT Refresco FROM Inventario"
                        Using commandVerificarRefresco As New SqlCommand(queryVerificarRefresco, conexion)
                            Dim RefrescoEnInventario As Integer = CInt(commandVerificarRefresco.ExecuteScalar())
                            If RefrescoEnInventario > 0 AndAlso RefrescoEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET Refresco = Refresco  - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Refrescos en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If

        'Esto es para las Papas'
        If Not String.IsNullOrEmpty(ComboBox9.Text) Then
            ' Intenta convertir el valor del ComboBox a un número
            If Integer.TryParse(ComboBox9.Text, cantidadARestar) Then
                ' Verifica si la cantidad a restar es mayor que cero
                If cantidadARestar > 0 Then
                    Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                        conexion.Open()
                        ' Verificar si la cantidad de piezas en el inventario es suficiente
                        Dim queryVerificarPapas As String = "SELECT Papas FROM Inventario"
                        Using commandVerificarPapas As New SqlCommand(queryVerificarPapas, conexion)
                            Dim PapasEnInventario As Integer = CInt(commandVerificarPapas.ExecuteScalar())
                            If PapasEnInventario > 0 AndAlso PapasEnInventario >= cantidadARestar Then
                                ' Restar la cantidad ingresada a la columna correspondiente en la tabla Inventario
                                Dim query As String = "UPDATE Inventario SET Papas = Papas  - @CantidadARestar"
                                Using command As New SqlCommand(query, conexion)
                                    command.Parameters.AddWithValue("@CantidadARestar", cantidadARestar)
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("¡Venta exitosa! La venta se ha realizado con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Using
                            Else
                                MessageBox.Show("No hay suficientes Papas en el inventario para realizar la venta.")
                            End If
                        End Using
                        conexion.Close()
                    End Using
                Else
                    MessageBox.Show("La cantidad ingresada debe ser mayor que cero.")
                End If
            End If
        End If


    End Sub
End Class