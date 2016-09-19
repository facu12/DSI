Public Class GestorRegistrarEvaluacion
    Property seleccionado As TrabajodeInvestigacion
    Dim vigente As EdicionCongreso
    Dim constancia As String

    Public Sub finCasoDeUso()

    End Sub
    Public Function imprimirConstancia() As String
        Return constancia
    End Function
    Public Sub generarConstanciaEvaluacion()
        Dim aux As List(Of Investigador) = New List(Of Investigador)
        For Each a As Autor In seleccionado.autores
            aux.Add(a.investigador)
        Next

        Dim evlogueado As Investigador = obtenerEvaluadorLogueado(aux)

        Dim str As String
        'cabecera'
        str = "Nombre y Apellido: " + evlogueado.nombre + evlogueado.apellido + " Fecha de evaluacion: " + seleccionado.asigEva.fechaEvaluacion.ToString + " Simposio: " + seleccionado.simp.nombre + " Numero de orden: " + seleccionado.nroOrden.ToString + vbCrLf 'salto de linea 
        'cuerpo' 
        str += "Aspecto: " + seleccionado.asigEva.evaluacion.First.aspectoEv.nombre + " Puntaje: " + seleccionado.asigEva.evaluacion.First.puntajeAsignado.ToString + " Comentario: " + seleccionado.asigEva.evaluacion.First.comentario + vbCrLf
        'pie'
        str += "Decision global: " + seleccionado.asigEva.decisionAceptado + " Estado del Trabajo de Investigacion: " + seleccionado.historialEstado.estado.nombre


        constancia = str
    End Sub
    Public Function verificarTerceraEvaluacionYEvInicial() As Boolean
        If seleccionado.historialEstado.estado.esEvaluacionInicial() Then
            'se verifica que sea 3ra evaluacion'
        Else
            'codigo si no es evaluacion inicial'
        End If
        generarConstanciaEvaluacion()
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
            ae.Add(ev.aspectoEv)
        Next

        Return ae
    End Function
    Public Sub obtenerDatosCadaAutorDelTI()

    End Sub
    Public Function obtenerDatosCompletosTI() As TrabajodeInvestigacion


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
