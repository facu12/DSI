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

        Dim invest4 As New Investigador("evaluador ", "1", "ev1@gmail.com", "12488766", "23/01/1980", user1)
        Dim invest5 As New Investigador("evaluador ", "2", "ev2@gmail.com", "36712389", "13/03/1994", user2)
        Dim invest6 As New Investigador("evaluador ", "3", "ev3@gmail.com", "38119000", "12/08/1995", user3)
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

        mostrarDatosEvaluadorLogueado()
        cargarTIs(edicionsimposio, listaTis)
        MsgBox("Por favor seleccione un Trabajo de Investigacion", MsgBoxResult.Ok)
        btn_datos_autor.Enabled = False
        btn_descargar.Enabled = False
        dgv_evaluacion.Visible = False

    End Sub


    Dim gestor As New GestorRegistrarEvaluacion


    'busca del gestor los datos del evaluador logueado 
    Private Sub mostrarDatosEvaluadorLogueado()
        Dim us As Usuario
        us = gestor.obtenerEvaluadorLogueado()

        lbl_log.Text = us.nombre

    End Sub

    Private Sub cargarTIs(edSimp As EdicionSimposio, TIs As List(Of TrabajodeInvestigacion))
        TIs = gestor.obtenerTIs(edSimp, TIs)

        dgv_ti.Rows.Clear()

        For Each a As TrabajodeInvestigacion In TIs

            With a
                dgv_ti.Rows.Add(New String() {"Proyecto de DSI", a.nroOrden.ToString, a.titulo.ToString})

            End With
        Next

    End Sub

    Private Sub dgv_ti_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ti.CellContentClick
        Dim autores As List(Of Autor) = dgv_ti.CurrentRow.DataBoundItem.conocerAutores()
        Dim str As String
        str = ""
        For Each x As Autor In autores

            str += "Numero de orden: " + x.orden.ToString + " " + x.conocerInvestigador().apellido + " " + x.conocerInvestigador().nombre + " " + vbCrLf

        Next

        lbl_datos_TI.Text = " " + dgv_ti.CurrentRow.DataBoundItem.getPalabraClave() + vbCrLf + dgv_ti.CurrentRow.DataBoundItem.getestado() + vbCrLf + dgv_ti.CurrentRow.DataBoundItem.getresumen() + vbCrLf + str
        habilitarBotonDescargarPDF()
        habilitarOpcionVisualizarDatosProcAutor()
        dgv_evaluacion.Visible = True
        mostarAspectosAEvaluar()
    End Sub


    'utlimo metodo que toma la evaluacion y la registra
    Private Sub opcionRegistrarEvaluacionRealizadaporEvaluador()

    End Sub
    'habilita los campos para editar la dgv_aspecto
    Private Sub habilitarPantallaRegistrarEvaluacion()

    End Sub

    'crea un string con todos los ti's devueltos por el gestor 

    Private Function mostrarCabeceraTrabajosdeDeinvestigacion(edSimp As EdicionSimposio, TIs As List(Of TrabajodeInvestigacion))

        Dim listTIS As List(Of TrabajodeInvestigacion)
        listTIS = gestor.obtenerTIs(edSimp, TIs)
        Dim str As String
        str = ""

        For Each x As TrabajodeInvestigacion In listTIS

            str += " " + x.nroOrden.ToString + " " + x.titulo.ToString + " " + x.palabraClave.ToString + " " + x.resumen.ToString + vbCrLf 'salto de linea 



        Next

        Return str
    End Function


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

            With aux.conocerInvestigador
                str += ("autor: " + .grupoInvestigacion.nombre + " Grupo Investigacion: " + .grupoinv.nombre + " Centro Investigacion: " + .grupoinv.centroinve.nombre + " Facultad: " + .grupoinv.centroinve.facultad.nombre + " Universidad: " + .grupoinv.centroinve.facultad.universidad.nombre + vbCrLf)
            End With

        Next


        MsgBox(str, "Aviso", MessageBoxButtons.OK)
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

    End Sub

    Private Sub solicitarIngresoPuntajeYComentario()

    End Sub

    Private Sub tomarIngresoPuntaje()
        If Convert.ToInt32(dgv_evaluacion.SelectedCells.Item("col_puntaje").Value) > 0 And Convert.ToInt32(dgv_evaluacion.SelectedCells.Item("col_puntaje").Value) < 5 Then
            TI.asigEva.conocerEvaluacion().puntajeAsignado = Convert.ToInt32(dgv_evaluacion.SelectedCells.Item("col_puntaje").Value)
        Else
            MsgBox("ingrese un puntaje entre 1 y 5 Valor entero", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub tomarIngresoComentario()
        If dgv_evaluacion.SelectedCells.Item("col_comentario").Value.ToString <> "" Then
            TI.asigEva.conocerEvaluacion.comentario = dgv_evaluacion.SelectedCells.Item("col_comentario").Value.ToString
        Else
            MsgBox("ingrese un comentario", MsgBoxStyle.OkOnly)
        End If
    End Sub

    'Carga el combo de decision
    Private Sub solicitarDecisionGlobal()
        cmb_desicion_global.Items.Clear()
        cmb_desicion_global.Items.Add("Aceptado")
        cmb_desicion_global.Items.Add("Rechazado c/correcciones")
        cmb_desicion_global.Items.Add("Rechazado")
        cmb_desicion_global.SelectedIndex = -1
    End Sub


    Private Sub tomarSeleccionDecisionGlobal()
        'asigna la decision tomada al TI Hardcodeado
        TI.asigEva.decisionAceptado = cmb_desicion_global.SelectedItem.value.ToString
    End Sub

    Private Sub solicitarConfirmacionDeEvaluacion()
        Dim resultado As Integer = MsgBox("confirmar registro de evaluacion", MsgBoxStyle.OkCancel, "Confirmacion")
        If resultado = DialogResult.OK Then
            'carga todos los datos al TI Hardcodeado
            tomarSeleccionDecisionGlobal()
            tomarIngresoPuntaje()
            tomarIngresoComentario()

            'pasa a solicitar visualizacion
            solicitarFormaVisualizacionConstancia()
        Else
            'no deberia hacer nada. volver al form
        End If
    End Sub


    Private Sub tomarSeleccionConfirmacion()

    End Sub


    Private Sub solicitarFormaVisualizacionConstancia()

    End Sub

    Private Sub tomarSeleccionVisualizacionConstancia()

    End Sub



    Private Sub dgv_evaluacion_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_evaluacion.CellContentDoubleClick


        'NO SE COMO SETEAR EL VALOR DEL DGV AL PUNTAJEEE


        dgv_evaluacion.CurrentRow.Cells.Item("col_puntaje").Value = "5656"




    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        solicitarConfirmacionDeEvaluacion()
    End Sub
End Class
