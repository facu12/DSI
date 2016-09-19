Public Class TrabajodeInvestigacion
    Property nroOrden As Integer
    Property palabraClave As String
    Property resumen As String
    Property titulo As String

    Property estado As Object
    Property evaluadorAsignados As List(Of Evaluador)


    Property autor As List(Of Investigador)


    Public Function conoceInvestigador()

        Return autor
    End Function

End Class
