Public Class HistorialEstado
    Property fecha As Date
    Property estado As Estado

    Public Sub New(fec As String, est As Estado)
        fecha = fec
        estado = est
    End Sub
    Public Function esPendienteDePrimeraEvaluacion()

        Return estado.esPendienteDePrimeraEvaluacion()
    End Function

    Public Function esEvaluacionInicial()
        Return estado.esEvaluacionInicial()
    End Function
End Class
