Public Class Form1

    Dim ti As TrabajodeInvestigacion

    Public Sub setTrabajodeInvestigacion(trab As TrabajodeInvestigacion)
        ti = trab
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user1, user2, user3, user4, user5, user6 As New Usuario

        ' creo usuarios
        user1.nombre = "fmallia"
        user1.contrasena = "1234"

        user2.nombre = "jbere"
        user2.contrasena = "1234"

        user3.nombre = "jdan"
        user3.contrasena = "1234"

        user3.nombre = "ev1"
        user3.contrasena = "1234"

        user4.nombre = "ev2"
        user4.contrasena = "1234"

        user5.nombre = "ev3"
        user5.contrasena = "1234"

        'creo la sesion que es solo del usuario 3 que es un evaluador
        Sesion.getSesion.setUsuario(user3)

        'crear universidad
        Dim univ As New Universidad("UTN")
        'crear facultad
        Dim facu As New Facultad("Ing en Sitemas", univ)
        'crear centro de investigacion
        Dim centro As New CentroInvestigacion("Laboratorio de ciencias", "lab 4", facu)
        'crear grupo investigacion
        Dim grupo As New GrupoInvestigacion("Cientifico de la NASA", centro)
        'crear investigador
        Dim invest1 As New Investigador("Facu", "Mallia", "fmallia@gmail.com", "25988766", "23/12/1980", user1)
        Dim invest2 As New Investigador("Juan", "Bere", "jbere@gmail.com", "36789789", "13/12/1990", user2)
        Dim invest3 As New Investigador("Juli", "Dangelis", "jdange@gmail.com", "38999000", "17/12/1990", user3)
        invest1.grupoinv = grupo
        invest2.grupoinv = grupo
        invest3.grupoinv = grupo
        Dim invest4 As New Investigador("evaluador ", "1", "ev1@gmail.com", "12488766", "23/01/1980", user1)
        Dim invest5 As New Investigador("evaluador ", "2", "ev2@gmail.com", "36712389", "13/03/1994", user2)
        Dim invest6 As New Investigador("evaluador ", "3", "ev3@gmail.com", "38119000", "12/08/1995", user3)

        'crear lista con todos los investigadores
        Dim listaInvestigadores As New List(Of Investigador)
        listaInvestigadores.Add(invest1)
        listaInvestigadores.Add(invest2)
        listaInvestigadores.Add(invest3)
        listaInvestigadores.Add(invest4)
        listaInvestigadores.Add(invest5)
        listaInvestigadores.Add(invest6)

        ' creo los autores
        Dim autor1 As New Autor(1, invest1)
        Dim autor2 As New Autor(2, invest2)
        Dim autor3 As New Autor(3, invest3)
        'creo evaluadores
        Dim ev1 As New Evaluador("25/10/2016", 1, invest4)
        Dim ev2 As New Evaluador("25/10/2016", 2, invest5)
        Dim ev3 As New Evaluador("25/10/2016", 3, invest6)
        'creo estado
        Dim estado As New Estado("ti", "el ti se encuentra pendiente de primera evaluacion", "PendienteDePrimeraEvaluacion")
        'creo historial estados
        Dim hist As New HistorialEstado("17/10/2016", estado)
        'creo lista de evaluadores
        Dim listaevaluador As New List(Of Evaluador)
        listaevaluador.Add(ev1)
        listaevaluador.Add(ev2)
        listaevaluador.Add(ev3)
        'creo aspecto evaluado
        Dim aspecto As New AspectoEvaluado("Teorico", "se evalua la parte teorica")
        'creo evaluacion
        Dim evaluacion As New Evaluacion("Comentario 1", 7, aspecto)
        'creo lista de evaluacion
        Dim listaevaluacion As New List(Of Evaluacion)
        listaevaluacion.Add(evaluacion)
        'creo asignacion de evaluador
        Dim asigevaluador As New AsignacionEvaluador("aprobado", "25/10/2016", "17/09/2016", listaevaluacion)
        'creo lista de autores
        Dim listaAutores As New List(Of Autor)
        listaAutores.Add(autor1)
        listaAutores.Add(autor2)
        listaAutores.Add(autor3)
        'creo edicion simposio
        Dim edicionsimposio As New EdicionSimposio("Edicion 2016", 1, "30/10/2016", "01/10/2016", "30/10/2016")
        ' creo los tis
        Dim ti1 As New TrabajodeInvestigacion(1, "Clave 1", "Resumen 1", "Titulo 1", hist, estado, listaevaluador, asigevaluador, listaAutores, edicionsimposio)
        Dim ti2 As New TrabajodeInvestigacion(2, "Clave 2", "Resumen 2", "Titulo 2", hist, estado, listaevaluador, asigevaluador, listaAutores, edicionsimposio)
        Dim ti3 As New TrabajodeInvestigacion(3, "Clave 3", "Resumen 3", "Titulo 3", hist, estado, listaevaluador, asigevaluador, listaAutores, edicionsimposio)
        'creo la lista de tis
        Dim listaTis As New List(Of TrabajodeInvestigacion)
        listaTis.Add(ti1)
        listaTis.Add(ti2)
        listaTis.Add(ti3)

        mostrarDatosEvaluadorLogueado(listaInvestigadores)
        cargarTIs(edicionsimposio, listaTis)
        MsgBox("Por favor seleccione un Trabajo de Investigacion", MsgBoxResult.Ok)
        btn_datos_autor.Enabled = False
        btn_descargar.Enabled = False
        dgv_evaluacion.Visible = False
        btn_datos_autor.Enabled = False

        solicitarDecisionGlobal()

    End Sub


    Dim gestor As New GestorRegistrarEvaluacion


    'busca del gestor los datos del evaluador logueado 
    Private Sub mostrarDatosEvaluadorLogueado(investigadores As List(Of Investigador))
        Dim ev As Investigador
        ev = gestor.obtenerEvaluadorLogueado(investigadores)
        lbl_log.Text = ev.nombre + " " + ev.apellido
    End Sub

    Private Sub cargarTIs(edSimp As EdicionSimposio, TIs As List(Of TrabajodeInvestigacion))
        Dim aux As List(Of TrabajodeInvestigacion) = gestor.obtenerTIs(edSimp, TIs)

        dgv_ti.Rows.Clear()
        dgv_ti.AutoGenerateColumns = False
        dgv_ti.DataSource = aux 'asigno el datasource a la lista'
        dgv_ti.Columns.Item(0).DataPropertyName = "simp.nombre" 'no sirve este, lo arregle con el for de abajo'
        dgv_ti.Columns.Item(1).DataPropertyName = "nroOrden" 'asigno la columna Nro Orden al atributo nroOrden'
        dgv_ti.Columns.Item(2).DataPropertyName = "titulo" 'mismo que arriba'

        For index = 0 To (dgv_ti.Rows.Count - 1)
            dgv_ti.Rows.Item(index).Cells(0).Value = "Proyecto de DSI"
        Next





    End Sub

    Private Sub dgv_ti_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ti.CellContentClick
        Dim aux As TrabajodeInvestigacion = TryCast(dgv_ti.CurrentRow.DataBoundItem, TrabajodeInvestigacion)
        Dim str As String
        str = ""
        Me.llenarGridAutores(aux)
        ti = aux
        gestor.seleccionado = aux
        lbl_datos_TI.Text = "Palabras clave: " + aux.palabraClave + vbCrLf + "Estado: " + aux.historialEstado.estado.nombre + vbCrLf + "Resumen: " + aux.resumen + vbCrLf '+ str'
        habilitarBotonDescargarPDF()
        habilitarOpcionVisualizarDatosProcAutor()
        dgv_evaluacion.Visible = True
        mostarAspectosAEvaluar()
        solicitarDecisionGlobal()



    End Sub


    'utlimo metodo que toma la evaluacion y la registra
    Private Sub opcionRegistrarEvaluacionRealizadaporEvaluador()

    End Sub
    'habilita los campos para editar la dgv_aspecto
    Private Sub habilitarPantallaRegistrarEvaluacion()

    End Sub

    'crea un string con todos los ti's devueltos por el gestor 




    'dimensiona un Ti a partir de la seleccion (click) en dgv_ti's
    Private Sub tomarSeleccionTI()

        With TI
            '    .nroOrden = dgv_ti.CurrentRow.Cells.Item().values
            '    .palabraClave = dgv_ti.CurrentRow.Cells.Item().values
            '    .resumen = dgv_ti.CurrentRow.Cells.Item().values
            '    .titulo = dgv_ti.CurrentRow.Cells.Item().values
            .nroOrden = Convert.ToInt32(dgv_ti.SelectedCells.Item("col_nOrden").Value)
            .titulo = dgv_ti.SelectedCells.Item("col_titulo").Value.ToString



        End With


    End Sub




    Private Sub mostrarDatosCompletosTISeleccionado()



    End Sub


    Private Sub habilitarBotonDescargarPDF()
        btn_descargar.Enabled = True
    End Sub

    'habilita btn datos autor
    Private Sub habilitarOpcionVisualizarDatosProcAutor()

        btn_datos_autor.Enabled = True

    End Sub
    ' tomarSeleccionVisualizarDatosProcAutor() mismo metodo que click en el boton  datos en el autor 

    Private Sub btn_datos_autor_Click(sender As Object, e As EventArgs) Handles btn_datos_autor.Click

        mostrarDatosProcAutor()

    End Sub


    Private Sub mostrarDatosProcAutor()
        Dim str As String
        str = ""

        'lista autores del ti seleccionado 

        Dim listita As List(Of Autor) = dgv_ti.CurrentRow.DataBoundItem.conocerAutores()


        For Each aux As Autor In listita

            With aux.conocerInvestigador()
                str += ("Autor: " + .grupoinv.nombre + " Grupo Investigacion: " + .grupoinv.nombre + " Centro Investigacion: " + .grupoinv.centroInve.nombre + " Facultad: " + .grupoinv.centroInve.facultad.nombre + " Universidad: " + .grupoinv.centroInve.facultad.univ.nombre + vbCrLf)
            End With

        Next


        MsgBox(str, MessageBoxButtons.OK, "Aviso")
    End Sub


    Private Sub mostarAspectosAEvaluar()
        Dim asp As List(Of AspectoEvaluado)
        asp = gestor.obtenerAspectosAEvaluar()

        dgv_evaluacion.Rows.Clear()

        For Each a As AspectoEvaluado In asp

            With a
                dgv_evaluacion.Rows.Add(New String() {a.nombre, "", ""})

            End With
        Next
        dgv_evaluacion.Rows.Item(dgv_evaluacion.Rows.Count - 1).ReadOnly = True 'no dejamos que se pueda editar la ultima fila'
        'sino se pueden agregar n filas al grid ya que es editable por defecto'
    End Sub

    Private Sub solicitarIngresoPuntajeYComentario()

    End Sub

    Private Function tomarIngresoPuntaje() As Integer
        Dim puntaje As Integer = Convert.ToInt32(dgv_evaluacion.CurrentRow.Cells.Item("col_puntaje").Value)
        If puntaje > 0 And puntaje < 6 Then
            ti.asigEva.conocerEvaluacion().First.puntajeAsignado = puntaje
            Return 1
        Else
            MsgBox("ingrese un puntaje entre 1 y 5 Valor entero", MsgBoxStyle.OkOnly)
            Return 0
        End If
    End Function

    Private Function tomarIngresoComentario() As Integer
        Dim str = dgv_evaluacion.CurrentRow.Cells.Item("col_comentario").Value.ToString
        If str <> "" Then
            ti.asigEva.conocerEvaluacion().First.comentario = str
            Return 1
        Else
            MsgBox("ingrese un comentario", MsgBoxStyle.OkOnly)
            Return 0
        End If
    End Function

    'Carga el combo de decision
    Private Sub solicitarDecisionGlobal()
        cmb_desicion_global.Items.Clear()
        cmb_desicion_global.Items.Add("Aceptado")
        cmb_desicion_global.Items.Add("Rechazado c/correcciones")
        cmb_desicion_global.Items.Add("Rechazado")
        cmb_desicion_global.SelectedIndex = -1
    End Sub


    Private Function tomarSeleccionDecisionGlobal() As Integer
        'asigna la decision tomada al TI Hardcodeado
        If Not cmb_desicion_global.SelectedIndex = -1 Then
            ti.asigEva.decisionAceptado = cmb_desicion_global.SelectedItem.ToString
            Return 1
        Else
            MsgBox("Seleccione una decision", MsgBoxStyle.OkOnly)
            Return 0
        End If

    End Function

    Private Sub solicitarConfirmacionDeEvaluacion()
        Dim resultado As Integer = MsgBox("Confirmar registro de evaluacion", MsgBoxStyle.OkCancel, "Confirmacion")
        If resultado = DialogResult.OK Then
            'carga todos los datos al TI Hardcodeado

            'validamos que se hayan ingresado correctamente los puntajes, comentarios y la decision global'
            If tomarIngresoPuntaje() = 0 Or tomarIngresoComentario() = 0 Or tomarSeleccionDecisionGlobal() = 0 Then
                Return
            End If
            ti.asigEva.fechaEvaluacion = Date.Today
            gestor.seleccionado.asigEva = ti.asigEva
            gestor.verificarTerceraEvaluacionYEvInicial()
            'pasa a solicitar visualizacion
            solicitarFormaVisualizacionConstancia()
            Else
                'no deberia hacer nada. volver al form
            End If
    End Sub


    Private Sub tomarSeleccionConfirmacion()

    End Sub


    Private Sub solicitarFormaVisualizacionConstancia()
        MsgBox("Forma de visualizacion: Impresion", MsgBoxStyle.YesNo, "Constancia")
        Dim str As String = gestor.imprimirConstancia()
        MsgBox(str, MsgBoxStyle.OkOnly, "Constancia") 'Deberia imprimirla'
    End Sub

    Private Sub tomarSeleccionVisualizacionConstancia()

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        solicitarConfirmacionDeEvaluacion()
    End Sub

    Private Sub dgv_autores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_autores.CellContentClick

        btn_datos_autor.Enabled = True




    End Sub


    Private Sub llenarGridAutores(ByVal ti As TrabajodeInvestigacion)
        Dim aux As TrabajodeInvestigacion
        aux = ti


        For Each x As Autor In aux.conocerAutores()

            dgv_autores.Rows.Add(New String() {x.orden.ToString, x.conocerInvestigador.nombre.ToString, x.investigador.apellido.ToString})

        Next


    End Sub


End Class
