Public Class Investigador
    Property nombre As String
    Property apellido As String
    Property mail As String
    Property dni As String
    Property fechaNac As String
    Property us As Usuario


    Property grupoInvestigacion As GrupoInvestigacion


    Public Sub New(a As String, b As String, c As String, d As String, e As String, s As Usuario)
        nombre = a
        apellido = b
        mail = c
        dni = d
        fechaNac = e
        us = s
    End Sub

End Class
