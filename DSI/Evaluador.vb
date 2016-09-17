Public Class Evaluador
    Private fechaAsignacion As String
    Private orden As Integer
    Private Investigador As Investigador

    Public Sub New(Str As String, i As Integer, inv As Investigador)
        fechaAsignacion = Str
        i = orden
        inv = Investigador
    End Sub


    Public Function getFechaAsignacion() As String
        Return fechaAsignacion
    End Function

    Public Sub setFechaAsignacion(fechaAsignacion As String)
        fechaAsignacion = fechaAsignacion
    End Sub

    Public Function getOrden() As Integer
        Return orden
    End Function

    Public Sub setOrden(orden As Integer)
        orden = orden
    End Sub
End Class
