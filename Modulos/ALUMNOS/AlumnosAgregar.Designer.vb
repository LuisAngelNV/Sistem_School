<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlumnosAgregar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlumnosAgregar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Curp = New System.Windows.Forms.TextBox()
        Me.txt_Materno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_paterno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Num_Usuario = New System.Windows.Forms.Label()
        Me.IdUsuario = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTBGuardarCambios = New System.Windows.Forms.ToolStripMenuItem()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eli = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Restaurar_alumno = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestaurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Restaurar_alumno.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(996, 66)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(243, 20)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(119, 36)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(111, 32)
        Me.ToolStripMenuItem2.Text = "Agregar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(74, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Alumnos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Panel2.Controls.Add(Me.tbBuscarUsuario)
        Me.Panel2.Controls.Add(Me.MenuStrip2)
        Me.Panel2.Location = New System.Drawing.Point(435, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(549, 54)
        Me.Panel2.TabIndex = 2
        '
        'tbBuscarUsuario
        '
        Me.tbBuscarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBuscarUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.tbBuscarUsuario.Location = New System.Drawing.Point(51, 14)
        Me.tbBuscarUsuario.Name = "tbBuscarUsuario"
        Me.tbBuscarUsuario.Size = New System.Drawing.Size(477, 26)
        Me.tbBuscarUsuario.TabIndex = 4
        Me.tbBuscarUsuario.Text = "Buscar Alumno"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(12, 15)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(36, 24)
        Me.MenuStrip2.TabIndex = 3
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 20)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.MenuStrip3)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(59, 98)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(881, 329)
        Me.Panel4.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txt_email)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.txt_Curp)
        Me.Panel6.Controls.Add(Me.txt_Materno)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.txt_nombre)
        Me.Panel6.Controls.Add(Me.txt_paterno)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Location = New System.Drawing.Point(12, 31)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(589, 247)
        Me.Panel6.TabIndex = 20
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(174, 173)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(243, 26)
        Me.txt_email.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(9, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Correo Electronico"
        '
        'txt_Curp
        '
        Me.txt_Curp.Location = New System.Drawing.Point(174, 133)
        Me.txt_Curp.Name = "txt_Curp"
        Me.txt_Curp.Size = New System.Drawing.Size(243, 26)
        Me.txt_Curp.TabIndex = 9
        '
        'txt_Materno
        '
        Me.txt_Materno.Location = New System.Drawing.Point(174, 49)
        Me.txt_Materno.Name = "txt_Materno"
        Me.txt_Materno.Size = New System.Drawing.Size(243, 26)
        Me.txt_Materno.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(95, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "CURP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(84, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Apellido Paterno"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(174, 89)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(243, 26)
        Me.txt_nombre.TabIndex = 8
        '
        'txt_paterno
        '
        Me.txt_paterno.Location = New System.Drawing.Point(174, 11)
        Me.txt_paterno.Name = "txt_paterno"
        Me.txt_paterno.Size = New System.Drawing.Size(243, 26)
        Me.txt_paterno.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(21, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Apellido Materno"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Num_Usuario)
        Me.Panel3.Controls.Add(Me.IdUsuario)
        Me.Panel3.Location = New System.Drawing.Point(3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 10)
        Me.Panel3.TabIndex = 17
        '
        'Num_Usuario
        '
        Me.Num_Usuario.AutoSize = True
        Me.Num_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Num_Usuario.ForeColor = System.Drawing.Color.Black
        Me.Num_Usuario.Location = New System.Drawing.Point(16, 4)
        Me.Num_Usuario.Name = "Num_Usuario"
        Me.Num_Usuario.Size = New System.Drawing.Size(105, 20)
        Me.Num_Usuario.TabIndex = 14
        Me.Num_Usuario.Text = "Núm. Usuario"
        '
        'IdUsuario
        '
        Me.IdUsuario.AutoSize = True
        Me.IdUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.IdUsuario.ForeColor = System.Drawing.Color.Black
        Me.IdUsuario.Location = New System.Drawing.Point(129, 0)
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.Size = New System.Drawing.Size(0, 20)
        Me.IdUsuario.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(814, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 38)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar, Me.BTBGuardarCambios})
        Me.MenuStrip3.Location = New System.Drawing.Point(111, 292)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(228, 29)
        Me.MenuStrip3.TabIndex = 13
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(79, 25)
        Me.btnGuardar.Text = "Guardar"
        '
        'BTBGuardarCambios
        '
        Me.BTBGuardarCambios.Name = "BTBGuardarCambios"
        Me.BTBGuardarCambios.Size = New System.Drawing.Size(141, 25)
        Me.BTBGuardarCambios.Text = "Guardar cambios"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AllowUserToResizeColumns = False
        Me.datalistado.AllowUserToResizeRows = False
        Me.datalistado.BackgroundColor = System.Drawing.Color.White
        Me.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eli})
        Me.datalistado.ContextMenuStrip = Me.Restaurar_alumno
        Me.datalistado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistado.EnableHeadersVisualStyles = False
        Me.datalistado.Location = New System.Drawing.Point(0, 66)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.datalistado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistado.RowTemplate.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(996, 373)
        Me.datalistado.TabIndex = 4
        '
        'Eli
        '
        Me.Eli.HeaderText = ""
        Me.Eli.Image = CType(resources.GetObject("Eli.Image"), System.Drawing.Image)
        Me.Eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eli.Name = "Eli"
        '
        'Restaurar_alumno
        '
        Me.Restaurar_alumno.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestaurarToolStripMenuItem})
        Me.Restaurar_alumno.Name = "Restaurar_alumno"
        Me.Restaurar_alumno.Size = New System.Drawing.Size(181, 48)
        '
        'RestaurarToolStripMenuItem
        '
        Me.RestaurarToolStripMenuItem.Image = CType(resources.GetObject("RestaurarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RestaurarToolStripMenuItem.Name = "RestaurarToolStripMenuItem"
        Me.RestaurarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RestaurarToolStripMenuItem.Text = "Restaurar"
        '
        'AlumnosAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 439)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.datalistado)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AlumnosAgregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AlumnosAgregar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Restaurar_alumno.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbBuscarUsuario As TextBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Curp As TextBox
    Friend WithEvents txt_Materno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_paterno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Num_Usuario As Label
    Friend WithEvents IdUsuario As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents btnGuardar As ToolStripMenuItem
    Friend WithEvents BTBGuardarCambios As ToolStripMenuItem
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eli As DataGridViewImageColumn
    Friend WithEvents Restaurar_alumno As ContextMenuStrip
    Friend WithEvents RestaurarToolStripMenuItem As ToolStripMenuItem
End Class
