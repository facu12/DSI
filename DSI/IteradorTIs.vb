Public Class IteradorTIs
    Inherits iIterador
    Private elementos As List(Of TrabajodeInvestigacion)
    Private index As Integer

    Public Sub New(elem As List(Of TrabajodeInvestigacion))
        elementos = elem
        index = 0
    End Sub
    Public Function haTerminado() As Boolean
        If index > elementos.Count Then
            Return True
        End If
        Return False
    End Function
    Public Function actual() As Object
        Dim aux As TrabajodeInvestigacion

        aux = Nothing
        If cumpleFiltro() Then
            aux = elementos.Item(index)
        End If
        Return aux
    End Function
    Public Function cumpleFiltro() As Boolean
        Dim actual As TrabajodeInvestigacion = elementos.Item(index)
        Dim sesion As Sesion
        Dim user As New Usuario

        sesion = Sesion.getSesion(user)

        If actual.esDeEvaluadorLogueado(sesion.usuario.nombre) Then
            'hacer el metodo es de evaluador logueado
            If actual.esEvaluacionInicial() Or actual.esPendienteDePrimeraEvaluacion() Then
                Return True
            End If
        Else Return False
        End If
    End Function

    Public Sub primero()
        index = 0
    End Sub
    Public Sub siguiente()
        index = index + 1
    End Sub
End Class