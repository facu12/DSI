Public Class IteradorTIs
    Inherits iIterador
    Private elementos As List(Of TrabajodeInvestigacion)
    Private index As Integer

    Public Sub New(elem As List(Of TrabajodeInvestigacion))
        elementos = elem
        index = 0

    End Sub
    Public Overrides Function haTerminado() As Boolean
        If index >= elementos.Count Then
            Return True
        End If
        Return False
    End Function
    Public Overrides Function actual() As Object
        Dim aux As TrabajodeInvestigacion

        aux = Nothing
        If cumpleFiltro() Then
            aux = elementos.Item(index)
        End If
        Return aux
    End Function
    Public Overrides Function cumpleFiltro() As Boolean
        Dim actual As TrabajodeInvestigacion = elementos.Item(index)
        Dim nombreEv As String = ""

        ' Tengo que recorrer los autores para comparar el usuario
        For Each evaluador In actual.evaluadorAsignados
            If evaluador.investigador.us.nombre = Sesion.getSesion.buscarInvestigadorLogueado.nombre Then
                nombreEv = evaluador.investigador.nombre
                nombreEv += evaluador.investigador.apellido
            End If
        Next

        If actual.esDeEvaluadorLogueado(nombreEv) Then
            'hacer el metodo es de evaluador logueado
            If actual.esEvaluacionInicial() Or actual.esPendienteDePrimeraEvaluacion() Then
                Return True
            End If
        Else Return False
        End If
        Return False
    End Function

    Public Overrides Sub primero()
        index = 0
    End Sub
    Public Overrides Sub siguiente()
        If Not haTerminado() Then
            index = index + 1
        End If
    End Sub
End Class