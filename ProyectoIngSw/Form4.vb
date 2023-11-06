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
End Class