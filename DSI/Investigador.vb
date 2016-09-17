Public Class Investigador
    Private nombre As String
    Private apellido As String
    Private mail As String
    Private dni As String
    Private fechaNac As String
    Private us As Usuario

    Public Sub New(a As String, b As String, c As String, d As String, e As String, s As Usuario)
        nombre = a
        apellido = b
        mail = c
        dni = d
        fechaNac = e
        us = s
    End Sub

End Class
