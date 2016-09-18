Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cargarFrm()


    End Sub


    Dim gestor As New GestorRegistrarEvaluacion


    Private Sub cargarFrm()

        Dim us As Usuario
        us = gestor.obtenerEvaluadorLogueado()

        lbl_log.Text = us.ToString





    End Sub

    Private Sub cargarTI()
        Dim tis As List(Of TrabajodeInvestigacion)
        tis = gestor.obtenerTIs()



    End Sub

    Private Sub dgv_ti_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ti.CellContentClick

        lbl_datos_TI.Text = " " + dgv_ti.CurrentRow.Cells.Item("col_ti").Value

    End Sub
End Class
