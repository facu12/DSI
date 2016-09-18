Public Class Evaluador
    Property fechaAsignacion As String
    Property orden As Integer
    Property investigador As Investigador

    Public Sub New(Str As String, i As Integer, inv As Investigador)
        fechaAsignacion = Str
        orden = i
        investigador = inv
    End Sub

End Class
