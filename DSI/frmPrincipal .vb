Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        mostrarDatosEvaluadorLogueado()
        cargarTIs()
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

    Private Sub cargarTIs()
        Dim tis As List(Of TrabajodeInvestigacion)
        tis = gestor.obtenerTIs()

        dgv_ti.Rows.Clear()

        For Each a As TrabajodeInvestigacion In tis

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
        btn_descargar.Enabled = True
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

    Private Function mostrarCabeceraTrabajosdeDeinvestigacion()

        Dim listTIS As List(Of TrabajodeInvestigacion)
        listTIS = gestor.obtenerTIs()
        Dim str As String
        str = ""

        For Each x As TrabajodeInvestigacion In listTIS

            str += " " + x.nroOrden.ToString + " " + x.titulo.ToString + " " + x.palabraClave.ToString + " " + x.resumen.ToString + vbCrLf 'salto de linea 



        Next

        Return str
    End Function


    'dimensiona un Ti a partir de la seleccion (click) en dgv_ti's
    Private Sub tomarSeleccionTI()

        'Dim x As TrabajodeInvestigacion

        'With x
        '    .nroOrden = dgv_ti.CurrentRow.Cells.Item().values
        '    .palabraClave = dgv_ti.CurrentRow.Cells.Item().values
        '    .resumen = dgv_ti.CurrentRow.Cells.Item().values
        '    .titulo = dgv_ti.CurrentRow.Cells.Item().values


        'End With


    End Sub




    Private Sub mostrarDatosCompletosTISeleccionado()



    End Sub


    Private Sub habilitarBotonDescargarPDF()

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

    End Sub

    Private Sub tomarIngresoComentario()

    End Sub


    Private Sub solicitarDecisionGlobal()

    End Sub


    Private Sub tomarSeleccionDecisionGlobal()

    End Sub

    Private Sub solicitarConfirmacionDeEvaluacion()
        Dim resultado As Integer = MsgBox("confirmar registro de evaluacion", MsgBoxStyle.OkCancel, "Confirmacion")
        If resultado = DialogResult.OK Then
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
