<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_log = New System.Windows.Forms.Label()
        Me.dgv_ti = New System.Windows.Forms.DataGridView()
        Me.col_nom_simposio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv_evaluacion = New System.Windows.Forms.DataGridView()
        Me.col_aspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_puntaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_datos_TI = New System.Windows.Forms.Label()
        Me.btn_datos_autor = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.lbl_decision = New System.Windows.Forms.Label()
        Me.cmb_desicion_global = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_ti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_evaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_log
        '
        Me.lbl_log.AutoSize = True
        Me.lbl_log.Location = New System.Drawing.Point(9, 9)
        Me.lbl_log.Name = "lbl_log"
        Me.lbl_log.Size = New System.Drawing.Size(130, 13)
        Me.lbl_log.TabIndex = 0
        Me.lbl_log.Text = "Nombre apellido logueado"
        '
        'dgv_ti
        '
        Me.dgv_ti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nom_simposio, Me.col_nOrden, Me.col_titulo})
        Me.dgv_ti.Location = New System.Drawing.Point(12, 113)
        Me.dgv_ti.Name = "dgv_ti"
        Me.dgv_ti.Size = New System.Drawing.Size(413, 108)
        Me.dgv_ti.TabIndex = 1
        '
        'col_nom_simposio
        '
        Me.col_nom_simposio.HeaderText = "Simposio"
        Me.col_nom_simposio.Name = "col_nom_simposio"
        '
        'col_nOrden
        '
        Me.col_nOrden.HeaderText = "N Orden"
        Me.col_nOrden.Name = "col_nOrden"
        '
        'col_titulo
        '
        Me.col_titulo.HeaderText = "Titulo"
        Me.col_titulo.Name = "col_titulo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 57)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Descargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv_evaluacion
        '
        Me.dgv_evaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_evaluacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_aspecto, Me.col_puntaje, Me.col_comentario})
        Me.dgv_evaluacion.Location = New System.Drawing.Point(12, 398)
        Me.dgv_evaluacion.Name = "dgv_evaluacion"
        Me.dgv_evaluacion.Size = New System.Drawing.Size(413, 92)
        Me.dgv_evaluacion.TabIndex = 3
        '
        'col_aspecto
        '
        Me.col_aspecto.HeaderText = "Aspecto"
        Me.col_aspecto.Name = "col_aspecto"
        '
        'col_puntaje
        '
        Me.col_puntaje.HeaderText = "Puntaje"
        Me.col_puntaje.Name = "col_puntaje"
        '
        'col_comentario
        '
        Me.col_comentario.HeaderText = "Comentario"
        Me.col_comentario.Name = "col_comentario"
        '
        'lbl_datos_TI
        '
        Me.lbl_datos_TI.AutoSize = True
        Me.lbl_datos_TI.Location = New System.Drawing.Point(9, 234)
        Me.lbl_datos_TI.Name = "lbl_datos_TI"
        Me.lbl_datos_TI.Size = New System.Drawing.Size(60, 13)
        Me.lbl_datos_TI.TabIndex = 4
        Me.lbl_datos_TI.Text = "Datos del ti"
        '
        'btn_datos_autor
        '
        Me.btn_datos_autor.Location = New System.Drawing.Point(102, 306)
        Me.btn_datos_autor.Name = "btn_datos_autor"
        Me.btn_datos_autor.Size = New System.Drawing.Size(83, 57)
        Me.btn_datos_autor.TabIndex = 5
        Me.btn_datos_autor.Text = "Datos Autor"
        Me.btn_datos_autor.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(256, 512)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(98, 58)
        Me.btn_aceptar.TabIndex = 6
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_decision
        '
        Me.lbl_decision.AutoSize = True
        Me.lbl_decision.Location = New System.Drawing.Point(9, 524)
        Me.lbl_decision.Name = "lbl_decision"
        Me.lbl_decision.Size = New System.Drawing.Size(81, 13)
        Me.lbl_decision.TabIndex = 8
        Me.lbl_decision.Text = "Decision Global"
        '
        'cmb_desicion_global
        '
        Me.cmb_desicion_global.FormattingEnabled = True
        Me.cmb_desicion_global.Location = New System.Drawing.Point(12, 549)
        Me.cmb_desicion_global.Name = "cmb_desicion_global"
        Me.cmb_desicion_global.Size = New System.Drawing.Size(121, 21)
        Me.cmb_desicion_global.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 660)
        Me.Controls.Add(Me.cmb_desicion_global)
        Me.Controls.Add(Me.lbl_decision)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_datos_autor)
        Me.Controls.Add(Me.lbl_datos_TI)
        Me.Controls.Add(Me.dgv_evaluacion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_ti)
        Me.Controls.Add(Me.lbl_log)
        Me.Name = "Form1"
        Me.Text = "Registrar Evaluacion"
        CType(Me.dgv_ti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_evaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_log As Label
    Friend WithEvents dgv_ti As DataGridView
    Friend WithEvents col_nom_simposio As DataGridViewTextBoxColumn
    Friend WithEvents col_nOrden As DataGridViewTextBoxColumn
    Friend WithEvents col_titulo As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents dgv_evaluacion As DataGridView
    Friend WithEvents col_aspecto As DataGridViewTextBoxColumn
    Friend WithEvents col_puntaje As DataGridViewTextBoxColumn
    Friend WithEvents col_comentario As DataGridViewTextBoxColumn
    Friend WithEvents lbl_datos_TI As Label
    Friend WithEvents btn_datos_autor As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lbl_decision As Label
    Friend WithEvents cmb_desicion_global As ComboBox
End Class
