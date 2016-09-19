Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        mostrarDatosEvaluadorLogueado()

        btn_datos_autor.Enabled = False


    End Sub


    Dim gestor As New GestorRegistrarEvaluacion


    'busca del gestor los datos del evaluador logueado 
    Private Sub mostrarDatosEvaluadorLogueado()
        Dim us As Usuario
        us = gestor.obtenerEvaluadorLogueado()

        lbl_log.Text = us.ToString

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

        lbl_datos_TI.Text = " " + dgv_ti.CurrentRow.Cells.Item("col_ti").Value




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

        Dim x As TrabajodeInvestigacion

        With x
            .nroOrden = dgv_ti.CurrentRow.Cells.Item().values
            .palabraClave = dgv_ti.CurrentRow.Cells.Item().values
            .resumen = dgv_ti.CurrentRow.Cells.Item().values
            .titulo = dgv_ti.CurrentRow.Cells.Item().values


        End With


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

    Private Sub btn_datos_autor_Click(sender As Object, e As EventArgs, ByVal x As Investigador) Handles btn_datos_autor.Click

        Dim aut As Investigador
        aut = x


        With aut
            MsgBox(" " + .grupoInvestigacion.nombre.ToString, "Aviso", MessageBoxButtons.OKCancel)

        End With

    End Sub


    Private Sub mostrarDatosProcAutor()

    End Sub


    Private Sub mostarAspectosAEvaluar()

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

    End Sub


    Private Sub tomarSeleccionConfirmacion()

    End Sub


    Private Sub solicitarFormaVisualizacionConstancia()

    End Sub

    Private Sub tomarSeleccionVisualizacionConstancia()

    End Sub


End Class
