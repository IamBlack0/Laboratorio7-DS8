Public Class Logica
    Private dataAccess As New DataAccess()

    ' Verifica la conexión a la base de datos
    Public Function VerificarConexion() As Boolean
        Return dataAccess.VerificarConexion()
    End Function

    ' Inserta una reserva en la base de datos
    Public Sub InsertarReserva(nombre As String, fechaEntrada As Date, fechaSalida As Date, tipoHabitacion As String, total As Decimal)
        dataAccess.InsertReserva(nombre, fechaEntrada, fechaSalida, tipoHabitacion, total)
    End Sub

    ' Actualiza la cantidad de habitaciones disponibles
    Public Sub ActualizarHabitaciones(tipoHabitacion As String, cantidad As Integer)
        dataAccess.ActualizarCantidadHabitaciones(tipoHabitacion, cantidad)
    End Sub

    ' Calcula el total de la reserva
    Public Function CalcularTotal(fechaEntrada As Date, fechaSalida As Date, tipoHabitacion As String) As Decimal
        Dim dias As Integer = (fechaSalida - fechaEntrada).Days
        If dias < 0 Then dias = 0
        Dim itbms = 0.07D
        Dim baseprecio, totalprecio As Decimal

        Select Case tipoHabitacion
            Case "Individual"
                baseprecio = 50 * dias
            Case "Doble"
                baseprecio = 75 * dias
            Case "Suite"
                baseprecio = 120 * dias
            Case Else
                baseprecio = 0
        End Select

        totalprecio = baseprecio + (baseprecio * itbms)
        Return totalprecio
    End Function

    ' Obtiene el ID de la habitación basado en el tipo de habitación
    Public Function ObtenerHabitacionId(tipoHabitacion As String) As Integer
        Select Case tipoHabitacion
            Case "Individual"
                Return 1
            Case "Doble"
                Return 2
            Case "Suite"
                Return 3
            Case Else
                Return 0
        End Select
    End Function
End Class
