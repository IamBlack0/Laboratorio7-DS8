Imports MySql.Data.MySqlClient
' Ruben Rivera | Michael Aparicio | Henry Maldonado
Public Class Form1
    Private logica As New Logica()

    ' Evento que se ejecuta al cargar el formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerificarConexionBaseDatos()
    End Sub

    ' Verifica la conexión a la base de datos y muestra un mensaje
    Private Sub VerificarConexionBaseDatos()
        If logica.VerificarConexion() Then
            MessageBox.Show("Conexión a la base de datos exitosa.", "Verificación de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al conectar a la base de datos.", "Verificación de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btEnviar_Click(sender As Object, e As EventArgs) Handles btEnviar.Click
        ' Validar que el campo de nombre no esté vacío
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MsgBox("Llena todos los campos, manin")
            Return
        End If

        ' Validar que se haya seleccionado un tipo de habitación
        If cbHabitacion.SelectedItem Is Nothing Then
            MsgBox("Selecciona un tipo de habitación, manin")
            Return
        End If

        ' Validar las fechas de entrada y salida
        Dim fechaEntrada As Date = dtaFechaInicio.Value
        Dim fechaSalida As Date = dtaFechaSalida.Value

        If fechaSalida <= fechaEntrada Then
            MessageBox.Show("La fecha de salida debe ser posterior a la fecha de entrada.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim nombre As String = txtNombre.Text
        Dim tipoHabitacion As String = cbHabitacion.SelectedItem.ToString()
        Dim habitacionId As Integer = logica.ObtenerHabitacionId(tipoHabitacion)
        Dim total As Decimal = logica.CalcularTotal(fechaEntrada, fechaSalida, tipoHabitacion)

        Try
            ' Inserta la reserva en la base de datos
            logica.InsertarReserva(nombre, fechaEntrada, fechaSalida, tipoHabitacion, total)
            ' Actualizar la cantidad de habitaciones disponibles
            logica.ActualizarHabitaciones(tipoHabitacion, 1) ' Asumiendo que se reserva una habitación

            MessageBox.Show("Reserva insertada correctamente.")

            ' Limpiar los campos después de insertar
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ' Función para limpiar los campos del formulario
    Private Sub LimpiarCampos()
        txtNombre.Clear()
        cbHabitacion.SelectedIndex = -1
        dtaFechaInicio.Value = Date.Today
        dtaFechaSalida.Value = Date.Today
    End Sub

    ' Evento que se ejecuta al hacer clic en el botón Reportes
    Private Sub btReportes_Click(sender As Object, e As EventArgs) Handles btReportes.Click
        ' Crear una nueva instancia del formulario FormReservas
        Dim formReservas As New FormReservas()

        ' Mostrar el formulario FormReservas
        formReservas.ShowDialog()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btBackup_Click(sender As Object, e As EventArgs) Handles btBackup.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\"
        backup.Title = "Backup de la base de datos"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "Archivos SQL (*.sql)|*.sql"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim con As MySqlConnection = New MySqlConnection("Server=localhost;Database=HotelDB;Uid=root;Pwd=;")
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = con
            con.Open()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)
            con.Close()
        ElseIf backup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return


        End If
    End Sub
End Class
