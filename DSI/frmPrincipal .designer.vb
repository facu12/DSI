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
        Me.col_nom_simposio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_descargar = New System.Windows.Forms.Button()
        Me.dgv_evaluacion = New System.Windows.Forms.DataGridView()
        Me.lbl_datos_TI = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.lbl_decision = New System.Windows.Forms.Label()
        Me.cmb_desicion_global = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.col_aspecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_puntaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_autores = New System.Windows.Forms.DataGridView()
        Me.col_nroOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_datos_autor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_ti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_evaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_autores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_log
        '
        Me.lbl_log.AutoSize = True
        Me.lbl_log.Location = New System.Drawing.Point(439, 21)
        Me.lbl_log.Name = "lbl_log"
        Me.lbl_log.Size = New System.Drawing.Size(43, 13)
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
        Me.dgv_ti.Location = New System.Drawing.Point(18, 32)
        Me.dgv_ti.Name = "dgv_ti"
        Me.dgv_ti.ReadOnly = True
        Me.dgv_ti.RowHeadersVisible = False
        Me.dgv_ti.Size = New System.Drawing.Size(413, 119)
        Me.dgv_ti.TabIndex = 1
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
        'btn_descargar
        '
        Me.btn_descargar.Location = New System.Drawing.Point(99, 408)
        Me.btn_descargar.Name = "btn_descargar"
        Me.btn_descargar.Size = New System.Drawing.Size(69, 22)
        Me.btn_descargar.TabIndex = 2
        Me.btn_descargar.Text = "Descargar"
        Me.btn_descargar.UseVisualStyleBackColor = True
        '
        'dgv_evaluacion
        '
        Me.dgv_evaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_evaluacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_aspecto, Me.col_puntaje, Me.col_comentario})
        Me.dgv_evaluacion.Location = New System.Drawing.Point(30, 509)
        Me.dgv_evaluacion.Name = "dgv_evaluacion"
        Me.dgv_evaluacion.Size = New System.Drawing.Size(413, 92)
        Me.dgv_evaluacion.TabIndex = 3
        '
        'lbl_datos_TI
        '
        Me.lbl_datos_TI.AutoSize = True
        Me.lbl_datos_TI.Location = New System.Drawing.Point(27, 253)
        Me.lbl_datos_TI.Name = "lbl_datos_TI"
        Me.lbl_datos_TI.Size = New System.Drawing.Size(60, 13)
        Me.lbl_datos_TI.TabIndex = 4
        Me.lbl_datos_TI.Text = "Datos del ti"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(274, 629)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(86, 21)
        Me.btn_aceptar.TabIndex = 6
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_decision
        '
        Me.lbl_decision.AutoSize = True
        Me.lbl_decision.Location = New System.Drawing.Point(27, 604)
        Me.lbl_decision.Name = "lbl_decision"
        Me.lbl_decision.Size = New System.Drawing.Size(81, 13)
        Me.lbl_decision.TabIndex = 8
        Me.lbl_decision.Text = "Decision Global"
        '
        'cmb_desicion_global
        '
        Me.cmb_desicion_global.FormattingEnabled = True
        Me.cmb_desicion_global.Location = New System.Drawing.Point(30, 629)
        Me.cmb_desicion_global.Name = "cmb_desicion_global"
        Me.cmb_desicion_global.Size = New System.Drawing.Size(121, 21)
        Me.cmb_desicion_global.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(399, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_ti)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(494, 176)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Trabajos de Investigacion"
        '
        'col_aspecto
        '
        Me.col_aspecto.HeaderText = "Aspecto"
        Me.col_aspecto.Name = "col_aspecto"
        Me.col_aspecto.ReadOnly = True
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
        'dgv_autores
        '
        Me.dgv_autores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_autores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nroOrden, Me.col_nombre, Me.col_apellido})
        Me.dgv_autores.Location = New System.Drawing.Point(30, 302)
        Me.dgv_autores.Name = "dgv_autores"
        Me.dgv_autores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_autores.Size = New System.Drawing.Size(387, 98)
        Me.dgv_autores.TabIndex = 12
        '
        'col_nroOrden
        '
        Me.col_nroOrden.HeaderText = "N°Orden"
        Me.col_nroOrden.Name = "col_nroOrden"
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        '
        'col_apellido
        '
        Me.col_apellido.HeaderText = "Apellido"
        Me.col_apellido.Name = "col_apellido"
        '
        'btn_datos_autor
        '
        Me.btn_datos_autor.Location = New System.Drawing.Point(303, 407)
        Me.btn_datos_autor.Name = "btn_datos_autor"
        Me.btn_datos_autor.Size = New System.Drawing.Size(75, 23)
        Me.btn_datos_autor.TabIndex = 13
        Me.btn_datos_autor.Text = "Datos Autor"
        Me.btn_datos_autor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 484)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Cargar puntajes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 685)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_datos_autor)
        Me.Controls.Add(Me.dgv_autores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmb_desicion_global)
        Me.Controls.Add(Me.lbl_decision)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.lbl_datos_TI)
        Me.Controls.Add(Me.dgv_evaluacion)
        Me.Controls.Add(Me.btn_descargar)
        Me.Controls.Add(Me.lbl_log)
        Me.Name = "Form1"
        Me.Text = "Registrar Evaluacion"
        CType(Me.dgv_ti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_evaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_autores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_log As Label
    Friend WithEvents dgv_ti As DataGridView
    Friend WithEvents btn_descargar As Button
    Friend WithEvents dgv_evaluacion As DataGridView
    Friend WithEvents lbl_datos_TI As Label
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lbl_decision As Label
    Friend WithEvents cmb_desicion_global As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents col_nom_simposio As DataGridViewTextBoxColumn
    Friend WithEvents col_nOrden As DataGridViewTextBoxColumn
    Friend WithEvents col_titulo As DataGridViewTextBoxColumn
    Friend WithEvents col_aspecto As DataGridViewTextBoxColumn
    Friend WithEvents col_puntaje As DataGridViewTextBoxColumn
    Friend WithEvents col_comentario As DataGridViewTextBoxColumn
    Friend WithEvents dgv_autores As DataGridView
    Friend WithEvents col_nroOrden As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_apellido As DataGridViewTextBoxColumn
    Friend WithEvents btn_datos_autor As Button
    Friend WithEvents Label1 As Label
End Class
