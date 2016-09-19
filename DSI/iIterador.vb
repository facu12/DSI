Public Class iIterador
    Public MustInherit Class iIterador
        Public MustOverride Function actual() As Object
        Public MustOverride Function cumpleFiltro() As Boolean
        Public MustOverride Function haTerminado() As Boolean
        Public MustOverride Sub primero()
        Public MustOverride Sub siguiente()
    End Class
End Class
