Friend MustInherit Class iEstadoTI
    Public MustOverride Sub registrarEstado()

    Public MustOverride Function verificarTercerEvaluacion() As Boolean

    Public MustOverride Function retirar() As Boolean
    Public MustOverride Function cancelar() As Boolean
    Public MustOverride Function mandarPendiente() As Boolean

    Public MustOverride Function esEvaluacionInicial() As Boolean
    Public MustOverride Function esRetirado() As Boolean
    Public MustOverride Function esPendienteDeSegundaEvaluacion() As Boolean
    Public MustOverride Function esPendienteEvaluacionDeChair() As Boolean
    Public MustOverride Function esAceptadoSujetoACorreciones() As Boolean
    Public MustOverride Function esAnulado() As Boolean
    Public MustOverride Function esAceptado() As Boolean
    Public MustOverride Function esRechazado() As Boolean
    Public MustOverride Function esPublicado() As Boolean
    Public MustOverride Function esPendienteDePrimeraEvaluacion() As Boolean
    Public MustOverride Function esPendienteDeAsignacionDeEvaluador() As Boolean
End Class
