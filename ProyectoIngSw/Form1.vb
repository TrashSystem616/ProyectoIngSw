Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim contraseña As String = TextBox2.Text
        Dim usuario As String = ""

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
            conexion.Open()

            Dim query As String = "SELECT COUNT(*) FROM Usuarios WHERE Contraseña = @Contraseña"
            Using command As New SqlCommand(query, conexion)
                command.Parameters.AddWithValue("@Contraseña", contraseña)

                Dim count As Integer = CInt(command.ExecuteScalar())

                If count > 0 Then
                    ' Realizar una consulta adicional para obtener el nombre del usuario
                    Dim queryNombre As String = "SELECT NombreUsuario FROM Usuarios WHERE Contraseña = @Contraseña"
                    Using commandNombre As New SqlCommand(queryNombre, conexion)
                        commandNombre.Parameters.AddWithValue("@Contraseña", contraseña)
                        usuario = CStr(commandNombre.ExecuteScalar())
                    End Using

                    MessageBox.Show("¡Bienvenido, " & usuario & "!")
                Else
                    MessageBox.Show("Contraseña incorrecta. Inténtalo de nuevo.")
                End If
            End Using

            conexion.Close() ' Cierra la conexión al finalizar
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()
                conexion.Open()
                MessageBox.Show("Conexión exitosa a la base de datos", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Aquí puedes realizar otras operaciones de base de datos si es necesario
            End Using
        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class