Public Class Estado
    Property ambito As String
    Property descripcion As String
    Property nombre As String

    Public Function esPendienteDePrimeraEvaluacion()
        Dim ban As Boolean
        ban = False
        If nombre = "PendienteDePrimeraEvaluacion" Then
            ban = True
        Else
            ban = False
        End If
        Return ban
    End Function
    Public Function esEvaluacionInicial()
        Dim ban As Boolean
        ban = False
        If nombre = "EvaluacionInicial" Then
            ban = True
        Else
            ban = False
        End If
        Return ban
    End Function
End Class
