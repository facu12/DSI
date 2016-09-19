Public Class Investigador
    Property nombre As String
    Property apellido As String
    Property mail As String
    Property dni As String
    Property fechaNac As String
    Property us As Usuario
    Property grupoinv As GrupoInvestigacion


    Property grupoInvestigacion As GrupoInvestigacion


    Public Sub New(nom As String, ape As String, mail As String, dni As String, fechanac As String, user As Usuario)
        nombre = nom
        apellido = ape
        mail = mail
        dni = dni
        fechanac = fechanac
        us = user
    End Sub

End Class
