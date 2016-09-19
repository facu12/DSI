Public Class Estado
    Property ambito As String
    Property descripcion As String
    Property nombre As String

    Public Sub New(amb As String, desc As String, nom As String)
        ambito = amb
        descripcion = desc
        nombre = nom
    End Sub

    Public Function esPendienteDePrimeraEvaluacion() As Boolean
        If nombre = "PendienteDePrimeraEvaluacion" Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function esEvaluacionInicial() As Boolean
        If nombre = "EvaluacionInicial" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
