Imports MySql.Data.MySqlClient
' Ruben Rivera | Michael Aparicio | Henry Maldonado
Public Class FormReservas

    Private dataAccess As New DataAccess()

    Private Sub FormReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarReservas()

        ' Configurar el DataGridView para que sea de solo lectura
        dgvReservas.ReadOnly = True
    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Me.Close()
    End Sub

    Private Sub CargarReservas()
        Dim dt As New DataTable()
        Using connection As New MySqlConnection(dataAccess.ConnectionStringPublic)
            Using command As New MySqlCommand("ObtenerTodasLasReservas", connection)
                command.CommandType = CommandType.StoredProcedure
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    dt.Load(reader) ' Carga los datos del lector en el DataTable
                End Using
            End Using
        End Using
        dgvReservas.DataSource = dt ' Establece el DataSource del DataGridView
    End Sub

End Class
