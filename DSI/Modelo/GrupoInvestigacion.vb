Public Class GrupoInvestigacion


    Property nombre As String
    Property centroInve As CentroInvestigacion

    Public Sub New(nom As String, cent As CentroInvestigacion)
        nombre = nom
        centroInve = cent
    End Sub
End Class
