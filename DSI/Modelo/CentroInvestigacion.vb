Public Class CentroInvestigacion
    Property Descripcion As String
    Property nombre As String
    Property facultad As Facultad

    Public Sub New(desc As String, nom As String, fac As Facultad)
        Descripcion = desc
        nombre = nom
        facultad = fac
    End Sub
End Class
