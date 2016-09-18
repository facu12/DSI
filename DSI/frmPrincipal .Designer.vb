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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.lbl_datos_TI = New System.Windows.Forms.Label()
        Me.col_nom_simposio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_datos_autor = New System.Windows.Forms.Button()
        Me.col_aspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_puntaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.lbl_decision = New System.Windows.Forms.Label()
        Me.cmb_desicion_global = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nom_simposio, Me.col_nOrden, Me.col_titulo})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(413, 108)
        Me.DataGridView1.TabIndex = 1
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
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_aspecto, Me.col_puntaje, Me.col_comentario})
        Me.DataGridView2.Location = New System.Drawing.Point(12, 398)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(413, 92)
        Me.DataGridView2.TabIndex = 3
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
        'btn_datos_autor
        '
        Me.btn_datos_autor.Location = New System.Drawing.Point(102, 306)
        Me.btn_datos_autor.Name = "btn_datos_autor"
        Me.btn_datos_autor.Size = New System.Drawing.Size(83, 57)
        Me.btn_datos_autor.TabIndex = 5
        Me.btn_datos_autor.Text = "Datos Autor"
        Me.btn_datos_autor.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_log)
        Me.Name = "Form1"
        Me.Text = "Registrar Evaluacion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_log As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents col_nom_simposio As DataGridViewTextBoxColumn
    Friend WithEvents col_nOrden As DataGridViewTextBoxColumn
    Friend WithEvents col_titulo As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents col_aspecto As DataGridViewTextBoxColumn
    Friend WithEvents col_puntaje As DataGridViewTextBoxColumn
    Friend WithEvents col_comentario As DataGridViewTextBoxColumn
    Friend WithEvents lbl_datos_TI As Label
    Friend WithEvents btn_datos_autor As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lbl_decision As Label
    Friend WithEvents cmb_desicion_global As ComboBox
End Class
