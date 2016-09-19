Public Class Evaluacion

    Property comentario As String
    Property puntajeAsignado As Integer
    Property aspectoEv As AspectoEvaluado

    Public Sub New(coment As String, puntaje As Integer, aspecto As AspectoEvaluado)
        comentario = coment
        puntajeAsignado = puntaje
        aspectoEv = aspecto
    End Sub
    Public Function conocerAspectoEvaluado()
        Return aspectoEv
    End Function


End Class
