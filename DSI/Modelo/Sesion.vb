Public Class Sesion
    Private Property usuario As Usuario

    Private Shared instance As Sesion 'Unica instancia de la clase

    Private Sub New()
        usuario = usuario
    End Sub

    Public Shared Function getSesion() As Sesion
        If IsNothing(instance) Then
            instance = New Sesion()
        End If
        Return instance
    End Function

    Public Function buscarInvestigadorLogueado() As Usuario
        Return usuario
    End Function

    Public Sub setUsuario(user As Usuario)
        usuario = user
    End Sub
End Class
