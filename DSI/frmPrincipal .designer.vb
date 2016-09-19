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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl_log = New System.Windows.Forms.Label()
        Me.dgv_ti = New System.Windows.Forms.DataGridView()
        Me.btn_descargar = New System.Windows.Forms.Button()
        Me.dgv_evaluacion = New System.Windows.Forms.DataGridView()
        Me.col_aspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_puntaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_datos_TI = New System.Windows.Forms.Label()
        Me.btn_datos_autor = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.lbl_decision = New System.Windows.Forms.Label()
        Me.cmb_desicion_global = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.col_nom_simposio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_ti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_evaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_log
        '
        Me.lbl_log.AutoSize = True
        Me.lbl_log.Location = New System.Drawing.Point(585, 26)
        Me.lbl_log.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_log.Name = "lbl_log"
        Me.lbl_log.Size = New System.Drawing.Size(57, 17)
        Me.lbl_log.TabIndex = 0
        Me.lbl_log.Text = "Usuario"
        '
        'dgv_ti
        '
        Me.dgv_ti.AllowUserToAddRows = False
        Me.dgv_ti.AllowUserToDeleteRows = False
        Me.dgv_ti.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_ti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nom_simposio, Me.col_nOrden, Me.col_titulo})
        Me.dgv_ti.Location = New System.Drawing.Point(24, 40)
        Me.dgv_ti.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_ti.Name = "dgv_ti"
        Me.dgv_ti.ReadOnly = True
        Me.dgv_ti.RowHeadersVisible = False
        Me.dgv_ti.Size = New System.Drawing.Size(506, 146)
        Me.dgv_ti.TabIndex = 1
        '
        'btn_descargar
        '
        Me.btn_descargar.Location = New System.Drawing.Point(16, 377)
        Me.btn_descargar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_descargar.Name = "btn_descargar"
        Me.btn_descargar.Size = New System.Drawing.Size(100, 70)
        Me.btn_descargar.TabIndex = 2
        Me.btn_descargar.Text = "Descargar"
        Me.btn_descargar.UseVisualStyleBackColor = True
        '
        'dgv_evaluacion
        '
        Me.dgv_evaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_evaluacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_aspecto, Me.col_puntaje, Me.col_comentario})
        Me.dgv_evaluacion.Location = New System.Drawing.Point(16, 490)
        Me.dgv_evaluacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_evaluacion.Name = "dgv_evaluacion"
        Me.dgv_evaluacion.Size = New System.Drawing.Size(551, 113)
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
        Me.lbl_datos_TI.Location = New System.Drawing.Point(12, 288)
        Me.lbl_datos_TI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_datos_TI.Name = "lbl_datos_TI"
        Me.lbl_datos_TI.Size = New System.Drawing.Size(79, 17)
        Me.lbl_datos_TI.TabIndex = 4
        Me.lbl_datos_TI.Text = "Datos del ti"
        '
        'btn_datos_autor
        '
        Me.btn_datos_autor.Location = New System.Drawing.Point(136, 377)
        Me.btn_datos_autor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_datos_autor.Name = "btn_datos_autor"
        Me.btn_datos_autor.Size = New System.Drawing.Size(111, 70)
        Me.btn_datos_autor.TabIndex = 5
        Me.btn_datos_autor.Text = "Datos Autor"
        Me.btn_datos_autor.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(341, 630)
        Me.btn_aceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(131, 71)
        Me.btn_aceptar.TabIndex = 6
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_decision
        '
        Me.lbl_decision.AutoSize = True
        Me.lbl_decision.Location = New System.Drawing.Point(12, 645)
        Me.lbl_decision.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_decision.Name = "lbl_decision"
        Me.lbl_decision.Size = New System.Drawing.Size(107, 17)
        Me.lbl_decision.TabIndex = 8
        Me.lbl_decision.Text = "Decision Global"
        '
        'cmb_desicion_global
        '
        Me.cmb_desicion_global.FormattingEnabled = True
        Me.cmb_desicion_global.Location = New System.Drawing.Point(16, 676)
        Me.cmb_desicion_global.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_desicion_global.Name = "cmb_desicion_global"
        Me.cmb_desicion_global.Size = New System.Drawing.Size(160, 24)
        Me.cmb_desicion_global.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(532, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_ti)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(659, 216)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Trabajos de Investigacion"
        '
        'col_nom_simposio
        '
        Me.col_nom_simposio.HeaderText = "Simposio"
        Me.col_nom_simposio.Name = "col_nom_simposio"
        Me.col_nom_simposio.ReadOnly = True
        Me.col_nom_simposio.Width = 200
        '
        'col_nOrden
        '
        Me.col_nOrden.HeaderText = "Nro Orden"
        Me.col_nOrden.Name = "col_nOrden"
        Me.col_nOrden.ReadOnly = True
        '
        'col_titulo
        '
        Me.col_titulo.HeaderText = "Titulo"
        Me.col_titulo.Name = "col_titulo"
        Me.col_titulo.ReadOnly = True
        Me.col_titulo.Width = 200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 733)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmb_desicion_global)
        Me.Controls.Add(Me.lbl_decision)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_datos_autor)
        Me.Controls.Add(Me.lbl_datos_TI)
        Me.Controls.Add(Me.dgv_evaluacion)
        Me.Controls.Add(Me.btn_descargar)
        Me.Controls.Add(Me.lbl_log)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Registrar Evaluacion"
        CType(Me.dgv_ti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_evaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_log As Label
    Friend WithEvents dgv_ti As DataGridView
    Friend WithEvents btn_descargar As Button
    Friend WithEvents dgv_evaluacion As DataGridView
    Friend WithEvents col_aspecto As DataGridViewTextBoxColumn
    Friend WithEvents col_puntaje As DataGridViewTextBoxColumn
    Friend WithEvents col_comentario As DataGridViewTextBoxColumn
    Friend WithEvents lbl_datos_TI As Label
    Friend WithEvents btn_datos_autor As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lbl_decision As Label
    Friend WithEvents cmb_desicion_global As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents col_nom_simposio As DataGridViewTextBoxColumn
    Friend WithEvents col_nOrden As DataGridViewTextBoxColumn
    Friend WithEvents col_titulo As DataGridViewTextBoxColumn
End Class
