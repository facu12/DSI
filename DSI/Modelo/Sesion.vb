Public Class Sesion
    Property usuario As Usuario

    Private Shared instance As Sesion 'Unica instancia de la clase

    Private Sub New(usuario As Usuario)
        usuario = usuario
    End Sub

    Public Shared Function getSesion(user As Usuario) As Sesion
        If IsNothing(instance) Then
            instance = New Sesion(user)
        End If
        Return instance
    End Function

    Public Function buscarInvestigadorLogueado() As Usuario
        Return Me.usuario
    End Function
End Class
