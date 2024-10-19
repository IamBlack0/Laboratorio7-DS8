Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

' -- Crear la base de datos HotelDB
' CREATE DATABASE HotelDB;

' -- Usar la base de datos HotelDB
' USE HotelDB;

' -- Crear la tabla Habitaciones
' CREATE TABLE Habitaciones (
'     Tipo VARCHAR(50) PRIMARY KEY, -- Tipo de habitación como clave primaria
'     Cantidad INT -- Cantidad de habitaciones disponibles
' );

' -- Insertar los tipos de habitaciones predeterminados
' INSERT INTO Habitaciones (Tipo, Cantidad) VALUES
' ('Individual', 10), 
' ('Doble', 20), 
' ('Suite', 5);

' -- Crear la tabla Reservas
' CREATE TABLE Reservas (
'     Id INT AUTO_INCREMENT PRIMARY KEY, -- Identificador único para cada reserva
'     Nombre VARCHAR(100), -- Nombre del cliente
'     FechaEntrada DATE, -- Fecha de entrada
'     FechaSalida DATE, -- Fecha de salida
'     TipoHabitacion VARCHAR(50), -- Tipo de habitación reservada
'     Total DECIMAL(10, 2), -- Total a pagar por la reserva
'     FOREIGN KEY (TipoHabitacion) REFERENCES Habitaciones(Tipo), -- Clave foránea que referencia a la tabla Habitaciones
'     CHECK (TipoHabitacion IN ('Individual', 'Doble', 'Suite')) -- Verificación para asegurar que el tipo de habitación es válido
' );

' -- Procedimiento para insertar una reserva
' DELIMITER //
' CREATE PROCEDURE InsertarReserva(
'     IN p_Nombre VARCHAR(100), -- Nombre del cliente
'     IN p_FechaEntrada DATE, -- Fecha de entrada
'     IN p_FechaSalida DATE, -- Fecha de salida
'     IN p_TipoHabitacion VARCHAR(50), -- Tipo de habitación
'     IN p_Total DECIMAL(10, 2) -- Total a pagar
' )
' BEGIN
'     INSERT INTO Reservas (Nombre, FechaEntrada, FechaSalida, TipoHabitacion, Total)
'     VALUES (p_Nombre, p_FechaEntrada, p_FechaSalida, p_TipoHabitacion, p_Total);
' END //
' DELIMITER ;

' -- Procedimiento para obtener reservas por tipo de habitación
' DELIMITER //
' CREATE PROCEDURE ObtenerReservasPorTipoHabitacion(
'     IN p_TipoHabitacion VARCHAR(50) -- Tipo de habitación
' )
' BEGIN
'     SELECT * 
'     FROM Reservas 
'     WHERE TipoHabitacion = p_TipoHabitacion;
' END //
' DELIMITER ;

' -- Procedimiento para obtener el monto total de reservaciones por tipo de habitación
' DELIMITER //
' CREATE PROCEDURE ObtenerMontoTotalPorTipoHabitacion(
'     IN p_TipoHabitacion VARCHAR(50) -- Tipo de habitación
' )
' BEGIN
'     SELECT SUM(Total) AS MontoTotal 
'     FROM Reservas 
'     WHERE TipoHabitacion = p_TipoHabitacion;
' END //
' DELIMITER ;

'-- Procedimiento para obtener todas las reservas
'DELIMITER //
'CREATE PROCEDURE ObtenerTodasLasReservas()
'BEGIN
'Select Case* From Reservas;
'End //
'DELIMITER ;

Public Class DataAccess
    Private connectionString As String = "Server=localhost;Database=HotelDB;Uid=root;Pwd=;"

    Public ReadOnly Property ConnectionStringPublic() As String
        Get
            Return connectionString
        End Get
    End Property

    Public Function VerificarConexion() As Boolean
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub InsertReserva(nombre As String, fechaEntrada As Date, fechaSalida As Date, tipoHabitacion As String, total As Decimal)
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand("InsertarReserva", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("p_Nombre", nombre)
                command.Parameters.AddWithValue("p_FechaEntrada", fechaEntrada)
                command.Parameters.AddWithValue("p_FechaSalida", fechaSalida)
                command.Parameters.AddWithValue("p_TipoHabitacion", tipoHabitacion)
                command.Parameters.AddWithValue("p_Total", total)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Public Function ObtenerReservasPorTipoHabitacion(tipoHabitacion As String) As DataTable
        Dim dt As New DataTable()
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand("ObtenerReservasPorTipoHabitacion", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("p_TipoHabitacion", tipoHabitacion)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function ObtenerMontoTotalPorTipoHabitacion(tipoHabitacion As String) As Decimal
        Dim total As Decimal = 0
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand("ObtenerMontoTotalPorTipoHabitacion", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("p_TipoHabitacion", tipoHabitacion)
                connection.Open()
                total = Convert.ToDecimal(command.ExecuteScalar())
            End Using
        End Using
        Return total
    End Function

    Public Sub ActualizarCantidadHabitaciones(tipoHabitacion As String, cantidad As Integer)
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "UPDATE Habitaciones SET Cantidad = Cantidad - @Cantidad WHERE Tipo = @TipoHabitacion AND Cantidad >= @Cantidad"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Cantidad", cantidad)
                command.Parameters.AddWithValue("@TipoHabitacion", tipoHabitacion)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub




End Class
