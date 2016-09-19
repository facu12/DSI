Public Class AsignacionEvaluador
    Property decisionAceptado As String
    Property fechaEvaluacion As Date
    Property fechaAsignacion As Date
    Property evaluacion As List(Of Evaluacion)

    Public Function conocerEvaluacion()
        Return evaluacion
    End Function


End Class
