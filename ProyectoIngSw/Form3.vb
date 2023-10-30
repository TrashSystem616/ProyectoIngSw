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
        Label7.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
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
                PictureBox1.Image = My.Resources._8pzas
            End If

            '10 piezas'
            If valorColumna = 2 Then
                ComboBox2.Text = 10 'Valor de las piezas'
                ComboBox4.Text = 1 'Valor del pure'
                ComboBox5.Text = 1 'Valor de la ensalada'
                ComboBox6.Text = 4 'valor de los bisquets'
                PictureBox1.Image = My.Resources._8pzas
            End If

            '14 piezas'

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
End Class