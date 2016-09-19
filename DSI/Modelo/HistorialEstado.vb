Public Class HistorialEstado
    Property fecha As Date
    Property estado As Estado
    Public Function esPendienteDePrimeraEvaluacion()

        Return estado.esPendienteDePrimeraEvaluacion()
    End Function

    Public Function esEvaluacionInicial()
        Return estado.esEvaluacionInicial()
    End Function
End Class
