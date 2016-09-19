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

    Public Function conocerAsignacionEvaluador()
        Return asigEva
    End Function

    Public Function conocerAutores()

        Return autores
    End Function
    Public Function esDeEvaluadorLogueado(ByVal nombre As String)
        Dim ban As Boolean
        ban = False
        Dim str As String
        str = ""
        For Each a As Autor In autores
            str = a.conocerInvestigador.nombre + a.conocerInvestigador.apellido
            If (nombre = str) Then
                ban = True
            Else
                str = ""
            End If
        Next
        Return ban
    End Function

    Public Function esPendienteDePrimeraEvaluacion()
        Return historialEstado.esPendienteDePrimeraEvaluacion()
    End Function

    Public Function esEvaluacionInicial()
        Return historialEstado.esEvaluacionInicial()
    End Function


End Class
