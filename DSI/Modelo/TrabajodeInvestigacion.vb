Public Class TrabajodeInvestigacion
    Property nroOrden As Integer
    Property palabraClave As String
    Property resumen As String
    Property titulo As String
    Property historialEstado As HistorialEstado
    Property estado As Object
    Property evaluadorAsignados As List(Of Evaluador)
    Property asigEva As AsignacionEvaluador
    Property autores As List(Of Autor)
    Property simp As EdicionSimposio

    Public Sub New(ord As Integer, clave As String, resum As String, tit As String, hist As HistorialEstado,
                   est As Estado, evasig As List(Of Evaluador), asigev As AsignacionEvaluador,
                   aut As List(Of Autor), sim As EdicionSimposio)
        nroOrden = ord
        palabraClave = clave
        resumen = resum
        titulo = tit
        historialEstado = hist
        estado = est
        evaluadorAsignados = evasig
        asigEva = asigev
        autores = aut
        simp = sim
    End Sub

    Public Function conocerSimposio()
        Return simp
    End Function

    Public Function conocerAsignacionEvaluador()
        Return asigEva
    End Function

    Public Function conocerAutores()

        Return autores
    End Function
    Public Function esDeEvaluadorLogueado(ByVal nombre As String) As Boolean
        Dim str As String
        For Each ev As Evaluador In evaluadorAsignados
            str = ev.investigador.nombre + ev.investigador.apellido
            If (nombre = str) Then
                Return True
            Else
                str = ""
            End If
        Next
        Return False
    End Function

    Public Function esPendienteDePrimeraEvaluacion()
        Return historialEstado.esPendienteDePrimeraEvaluacion()
    End Function

    Public Function esEvaluacionInicial()
        Return historialEstado.esEvaluacionInicial()
    End Function


End Class
