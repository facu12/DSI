Public Class GestorRegistrarEvaluacion
    Dim seleccionado As TrabajodeInvestigacion
    Dim vigente As EdicionCongreso
    Dim actual As Sesion
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
    Public Function obtenerTIs() As List(Of TrabajodeInvestigacion)
        Dim edSimp As New EdicionSimposio

        edSimp.buscarTrabajoDeInvestigacion()

    End Function
    Public Function obtenerEdicionCongresoVigente() As EdicionCongreso

    End Function
    Public Function getSystemDate() As Date
        Return Date.Now
    End Function
    Public Function obtenerEvaluadorLogueado() As Usuario
        Return Me.actual.buscarInvestigadorLogueado()
    End Function

    Public Sub tomarVisualizacionConstancia(ByVal visualizacion As String)

    End Sub
    Public Sub tomarConfirmacion(ByVal confirma As Boolean)

    End Sub

    Public Sub tomarDecisionGlobal(ByVal decision As String)

    End Sub
    Public Sub tomarPuntajeYComentario()

    End Sub
    Public Sub tomarVisualizarDatosProcAutor()

    End Sub
    Public Sub tomarTI(ByVal ti As TrabajodeInvestigacion)

    End Sub
    Public Sub nuevaEvaluacion()

    End Sub
End Class
