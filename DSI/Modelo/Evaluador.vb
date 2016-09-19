Public Class Evaluador
    Property fechaAsignacion As String
    Property orden As Integer
    Property investigador As Investigador

    Public Sub New(fechaasig As String, ord As Integer, inv As Investigador)
        fechaAsignacion = fechaasig
        orden = ord
        investigador = inv
    End Sub

End Class
