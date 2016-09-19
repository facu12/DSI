Public Class AsignacionEvaluador
    Property decisionAceptado As String
    Property fechaEvaluacion As Date
    Property fechaAsignacion As Date
    Property evaluacion As List(Of Evaluacion)

    Public Function conocerEvaluacion() As List(Of Evaluacion)
        Return evaluacion
    End Function

    Public Sub New(decision As String, fechaev As String, fechaasig As String, ev As List(Of Evaluacion))
        decisionAceptado = decision
        fechaEvaluacion = fechaev
        fechaAsignacion = fechaasig
        evaluacion = ev
    End Sub

End Class
