Public MustInherit Class iIterador
    Public MustOverride Function actual() As Object
    Public MustOverride Function cumpleFiltro() As Boolean
    Public MustOverride Function haTerminado() As Boolean
    Public MustOverride Sub primero()
    Public MustOverride Sub siguiente()
End Class

'Friend Sub primero()
'    Throw New NotImplementedException()
'End Sub

'Friend Function actual() As Object
'    Throw New NotImplementedException()
'End Function

'Friend Function haTerminado() As Boolean
'    Throw New NotImplementedException()
'End Function

'Friend Sub siguiente()
'    Throw New NotImplementedException()
'End Sub
'End Class
