Public Class GestorRegistrarEvaluacion
    Public Sub finCasoDeUso()

    End Sub
    Public Sub imprimirConstancia()

    End Sub
    Public Function generarConstanciaEvaluacion() As String

    End Function
    Public Function verificarTerceraEvaluacionYEvInicial() As Boolean

    End Function
    Public Sub asignarFechaEvaluacion(ByVal fecha As Date)

    End Sub
    Public Sub asignarDecisionGlobal(ByVal decision As String)

    End Sub
    Public Sub registrarEvaluacion(ByVal evaluacion As Evaluacion)

    End Sub
    Public Function verificarEvaluacionIngresada(ByVal evaluacion As Evaluacion) As Boolean

    End Function
    Public Function obtenerAspectosAEvaluar() As List(Of AspectoEvaluado)

    End Function
    Public Sub obtenerDatosCadaAutorDelTI()

    End Sub
    Public Function obtenerDatosCompletosTI() As String

    End Function
    Public Function obtenerTI() As TrabajodeInvestigacion

    End Function
    Public Function obtenerEdicionCongresoVigente() As EdicionCongreso

    End Function
    Public Function getSystemDate() As Date

    End Function
    Public Function obtenerEvaluadorLogueado() As Usuario

    End Function
End Class
