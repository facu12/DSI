Public Class Facultad
    Property nombre As String
    Property univ As Universidad

    Public Sub New(nom As String, uni As Universidad)
        nombre = nom
        univ = uni
    End Sub
End Class
