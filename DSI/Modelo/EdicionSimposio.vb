Public MustInherit Class EdicionSimposio
    Inherits iAgregado

    Property cantDiasParaCorrecciones As Integer
    Property fechaFin As Date
    Property fechaInicio As Date
    Property fechaLimitePresTrab As Date
    Property TIs As List(Of TrabajodeInvestigacion)




    Public Function buscarTrabajoDeInvestigacion() As List(Of TrabajodeInvestigacion)

        Dim itera As iIterador = crearIterador(TIs)
        Dim aux As New List(Of TrabajodeInvestigacion)
        itera.primero()
        While (itera.haTerminado())
            Dim ti As Object = itera.actual()

            If ti IsNot Nothing Then
                aux.Add(ti)
            End If
            itera.siguiente()
        End While
        Return aux
    End Function


    Public Overrides Function crearIterador(elementos As List(Of TrabajodeInvestigacion)) As iIterador

        Dim iterador As New IteradorTIs(elementos)
        Return iterador
    End Function





End Class
