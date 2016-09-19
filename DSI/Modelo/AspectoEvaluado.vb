Public Class AspectoEvaluado
    Property nombre As String
    Property descripcion As String

    Public Sub New(nom As String, desc As String)
        nombre = nom
        descripcion = desc
    End Sub

    Public Function mostrarNombre()
        Return nombre
    End Function
End Class
