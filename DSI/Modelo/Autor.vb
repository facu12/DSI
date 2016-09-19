Public Class Autor
    Property orden As Integer
    Property investigador As Investigador
    Public Function conocerInvestigador()
        Return Investigador
    End Function
    Public Sub New(ord As Integer, invest As Investigador)
        orden = ord
        investigador = invest
    End Sub
End Class

