Public Class GestorRegistrarEvaluacion
    Dim seleccionado As TrabajodeInvestigacion
    Dim vigente As EdicionCongreso

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
        Dim ae As New List(Of AspectoEvaluado)

        For Each ev As Evaluacion In seleccionado.conocerAsignacionEvaluador.conocerEvaluacion()
            ae += seleccionado.conocerAsignacionEvaluador.conocerEvaluacion().conocerAspectoEvaluado()
        Next

        Return ae
    End Function
    Public Sub obtenerDatosCadaAutorDelTI()

    End Sub
    Public Function obtenerDatosCompletosTI() As String

    End Function
    Public Function obtenerTIs(EdSimp As EdicionSimposio, TIs As List(Of TrabajodeInvestigacion)) As List(Of TrabajodeInvestigacion)
        Return EdSimp.buscarTrabajoDeInvestigacion(TIs)
    End Function
    Public Function obtenerEdicionCongresoVigente() As EdicionCongreso

    End Function
    Public Function getSystemDate() As Date
        Return Date.Now
    End Function
    Public Function obtenerEvaluadorLogueado(investigadores As List(Of Investigador)) As Investigador
        Dim evaluador As Investigador = Nothing

        'recorro evaluadores para encontrar el usuario logueado
        For Each ev In investigadores
            If ev.us.nombre = Sesion.getSesion.buscarInvestigadorLogueado().nombre Then
                Return ev
            End If
        Next
        Return evaluador
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
