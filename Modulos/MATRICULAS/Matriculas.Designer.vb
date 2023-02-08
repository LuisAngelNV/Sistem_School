<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Matriculas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Matriculas))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblBuscarAlumno = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.search = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelFormulario = New System.Windows.Forms.Panel()
        Me.TXTFECHA = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataListadoAlumnos = New System.Windows.Forms.DataGridView()
        Me.Marcar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtComprobante = New System.Windows.Forms.ComboBox()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtNumeroDeRecibo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCostoPension = New System.Windows.Forms.TextBox()
        Me.txt_cantidad_de_importe = New System.Windows.Forms.TextBox()
        Me.txtCostoMastriculas = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtHorario = New System.Windows.Forms.ComboBox()
        Me.txtSeccion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelOBSERVACION = New System.Windows.Forms.Panel()
        Me.MenuStrip6 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MenuStrip5 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelMAtricula_ya_hecha = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.datalistadoNumero_de_recibo = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TXTCANTIDAD_DE_CUOTAS = New System.Windows.Forms.DomainUpDown()
        Me.txtGrado = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.PanelFormulario.SuspendLayout()
        CType(Me.DataListadoAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip4.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.PanelOBSERVACION.SuspendLayout()
        Me.MenuStrip6.SuspendLayout()
        Me.MenuStrip5.SuspendLayout()
        Me.PanelMAtricula_ya_hecha.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrincipal.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.datalistadoNumero_de_recibo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1297, 26)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1269, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(28, 26)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, -6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblBuscarAlumno)
        Me.Panel3.Controls.Add(Me.txtBuscar)
        Me.Panel3.Controls.Add(Me.MenuStrip1)
        Me.Panel3.Controls.Add(Me.MenuStrip2)
        Me.Panel3.Location = New System.Drawing.Point(21, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(842, 44)
        Me.Panel3.TabIndex = 1
        '
        'lblBuscarAlumno
        '
        Me.lblBuscarAlumno.AutoSize = True
        Me.lblBuscarAlumno.BackColor = System.Drawing.Color.White
        Me.lblBuscarAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarAlumno.ForeColor = System.Drawing.Color.Black
        Me.lblBuscarAlumno.Location = New System.Drawing.Point(82, 12)
        Me.lblBuscarAlumno.Name = "lblBuscarAlumno"
        Me.lblBuscarAlumno.Size = New System.Drawing.Size(202, 20)
        Me.lblBuscarAlumno.TabIndex = 4
        Me.lblBuscarAlumno.Text = "Ingrese nombre del alumno"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(48, 9)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(747, 26)
        Me.txtBuscar.TabIndex = 2
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.search})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(36, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'search
        '
        Me.search.Image = CType(resources.GetObject("search.Image"), System.Drawing.Image)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(28, 20)
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(788, 6)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(36, 32)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 28)
        '
        'PanelFormulario
        '
        Me.PanelFormulario.Controls.Add(Me.txtGrado)
        Me.PanelFormulario.Controls.Add(Me.TXTCANTIDAD_DE_CUOTAS)
        Me.PanelFormulario.Controls.Add(Me.TXTFECHA)
        Me.PanelFormulario.Controls.Add(Me.Label15)
        Me.PanelFormulario.Controls.Add(Me.txtComprobante)
        Me.PanelFormulario.Controls.Add(Me.MenuStrip4)
        Me.PanelFormulario.Controls.Add(Me.txtNumeroDeRecibo)
        Me.PanelFormulario.Controls.Add(Me.Label11)
        Me.PanelFormulario.Controls.Add(Me.MenuStrip3)
        Me.PanelFormulario.Controls.Add(Me.Label10)
        Me.PanelFormulario.Controls.Add(Me.DateTimePicker1)
        Me.PanelFormulario.Controls.Add(Me.txtSaldo)
        Me.PanelFormulario.Controls.Add(Me.Label9)
        Me.PanelFormulario.Controls.Add(Me.txtCostoPension)
        Me.PanelFormulario.Controls.Add(Me.txt_cantidad_de_importe)
        Me.PanelFormulario.Controls.Add(Me.txtCostoMastriculas)
        Me.PanelFormulario.Controls.Add(Me.Panel5)
        Me.PanelFormulario.Controls.Add(Me.txtHorario)
        Me.PanelFormulario.Controls.Add(Me.txtSeccion)
        Me.PanelFormulario.Controls.Add(Me.Label8)
        Me.PanelFormulario.Controls.Add(Me.Label7)
        Me.PanelFormulario.Controls.Add(Me.Label6)
        Me.PanelFormulario.Controls.Add(Me.Label5)
        Me.PanelFormulario.Controls.Add(Me.Label4)
        Me.PanelFormulario.Controls.Add(Me.Label3)
        Me.PanelFormulario.Controls.Add(Me.Label2)
        Me.PanelFormulario.Controls.Add(Me.Label1)
        Me.PanelFormulario.Location = New System.Drawing.Point(21, 60)
        Me.PanelFormulario.Name = "PanelFormulario"
        Me.PanelFormulario.Size = New System.Drawing.Size(842, 454)
        Me.PanelFormulario.TabIndex = 3
        Me.PanelFormulario.Visible = False
        '
        'TXTFECHA
        '
        Me.TXTFECHA.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTFECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTFECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXTFECHA.Location = New System.Drawing.Point(163, 244)
        Me.TXTFECHA.Name = "TXTFECHA"
        Me.TXTFECHA.Size = New System.Drawing.Size(133, 26)
        Me.TXTFECHA.TabIndex = 596
        Me.TXTFECHA.Value = New Date(2020, 2, 6, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(82, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 20)
        Me.Label15.TabIndex = 595
        Me.Label15.Text = "Fecha"
        '
        'DataListadoAlumnos
        '
        Me.DataListadoAlumnos.AllowUserToAddRows = False
        Me.DataListadoAlumnos.AllowUserToDeleteRows = False
        Me.DataListadoAlumnos.AllowUserToResizeRows = False
        Me.DataListadoAlumnos.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataListadoAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataListadoAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataListadoAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListadoAlumnos.ColumnHeadersVisible = False
        Me.DataListadoAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Marcar})
        Me.DataListadoAlumnos.EnableHeadersVisualStyles = False
        Me.DataListadoAlumnos.GridColor = System.Drawing.Color.Gainsboro
        Me.DataListadoAlumnos.Location = New System.Drawing.Point(869, 25)
        Me.DataListadoAlumnos.Name = "DataListadoAlumnos"
        Me.DataListadoAlumnos.ReadOnly = True
        Me.DataListadoAlumnos.RowHeadersVisible = False
        Me.DataListadoAlumnos.RowHeadersWidth = 9
        Me.DataListadoAlumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro
        Me.DataListadoAlumnos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataListadoAlumnos.RowTemplate.Height = 35
        Me.DataListadoAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListadoAlumnos.Size = New System.Drawing.Size(91, 75)
        Me.DataListadoAlumnos.TabIndex = 593
        '
        'Marcar
        '
        Me.Marcar.DataPropertyName = "Marcar"
        Me.Marcar.HeaderText = "Marcar"
        Me.Marcar.Image = CType(resources.GetObject("Marcar.Image"), System.Drawing.Image)
        Me.Marcar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Marcar.Name = "Marcar"
        Me.Marcar.ReadOnly = True
        Me.Marcar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'txtComprobante
        '
        Me.txtComprobante.BackColor = System.Drawing.Color.White
        Me.txtComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtComprobante.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtComprobante.FormattingEnabled = True
        Me.txtComprobante.Location = New System.Drawing.Point(153, 279)
        Me.txtComprobante.Name = "txtComprobante"
        Me.txtComprobante.Size = New System.Drawing.Size(213, 33)
        Me.txtComprobante.TabIndex = 591
        '
        'MenuStrip4
        '
        Me.MenuStrip4.AutoSize = False
        Me.MenuStrip4.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.MenuStrip4.Location = New System.Drawing.Point(355, 358)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.Size = New System.Drawing.Size(392, 38)
        Me.MenuStrip4.TabIndex = 22
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GuardarToolStripMenuItem.Image = CType(resources.GetObject("GuardarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(95, 34)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.BackColor = System.Drawing.Color.Gray
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(289, 34)
        Me.ToolStripMenuItem3.Text = "Ya fue gestionada en otra institución"
        '
        'txtNumeroDeRecibo
        '
        Me.txtNumeroDeRecibo.Location = New System.Drawing.Point(171, 328)
        Me.txtNumeroDeRecibo.Name = "txtNumeroDeRecibo"
        Me.txtNumeroDeRecibo.Size = New System.Drawing.Size(133, 20)
        Me.txtNumeroDeRecibo.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 328)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Nro. De Recibo"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuStrip3.Location = New System.Drawing.Point(384, 285)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(36, 32)
        Me.MenuStrip3.TabIndex = 3
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.AutoSize = False
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(28, 28)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Comprobante"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(432, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(315, 26)
        Me.DateTimePicker1.TabIndex = 17
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(163, 218)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(133, 20)
        Me.txtSaldo.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(86, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Saldo"
        '
        'txtCostoPension
        '
        Me.txtCostoPension.Location = New System.Drawing.Point(461, 145)
        Me.txtCostoPension.Name = "txtCostoPension"
        Me.txtCostoPension.Size = New System.Drawing.Size(133, 20)
        Me.txtCostoPension.TabIndex = 14
        '
        'txt_cantidad_de_importe
        '
        Me.txt_cantidad_de_importe.Location = New System.Drawing.Point(163, 179)
        Me.txt_cantidad_de_importe.Name = "txt_cantidad_de_importe"
        Me.txt_cantidad_de_importe.Size = New System.Drawing.Size(133, 20)
        Me.txt_cantidad_de_importe.TabIndex = 13
        '
        'txtCostoMastriculas
        '
        Me.txtCostoMastriculas.Location = New System.Drawing.Point(163, 147)
        Me.txtCostoMastriculas.Name = "txtCostoMastriculas"
        Me.txtCostoMastriculas.Size = New System.Drawing.Size(133, 20)
        Me.txtCostoMastriculas.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(11, 202)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(285, 5)
        Me.Panel5.TabIndex = 11
        '
        'txtHorario
        '
        Me.txtHorario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtHorario.FormattingEnabled = True
        Me.txtHorario.Location = New System.Drawing.Point(111, 84)
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.Size = New System.Drawing.Size(158, 21)
        Me.txtHorario.TabIndex = 10
        '
        'txtSeccion
        '
        Me.txtSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSeccion.FormattingEnabled = True
        Me.txtSeccion.Location = New System.Drawing.Point(111, 57)
        Me.txtSeccion.Name = "txtSeccion"
        Me.txtSeccion.Size = New System.Drawing.Size(158, 21)
        Me.txtSeccion.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(351, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(306, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cant. De Pensión"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(303, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Presio de pensión"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(86, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Importe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio Matricula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Horario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sección"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grado"
        '
        'PanelOBSERVACION
        '
        Me.PanelOBSERVACION.Controls.Add(Me.MenuStrip6)
        Me.PanelOBSERVACION.Controls.Add(Me.txtObservacion)
        Me.PanelOBSERVACION.Controls.Add(Me.Label13)
        Me.PanelOBSERVACION.Controls.Add(Me.Label12)
        Me.PanelOBSERVACION.Controls.Add(Me.MenuStrip5)
        Me.PanelOBSERVACION.Location = New System.Drawing.Point(1060, 119)
        Me.PanelOBSERVACION.Name = "PanelOBSERVACION"
        Me.PanelOBSERVACION.Size = New System.Drawing.Size(1040, 462)
        Me.PanelOBSERVACION.TabIndex = 4
        '
        'MenuStrip6
        '
        Me.MenuStrip6.AutoSize = False
        Me.MenuStrip6.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip6.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5})
        Me.MenuStrip6.Location = New System.Drawing.Point(906, 413)
        Me.MenuStrip6.Name = "MenuStrip6"
        Me.MenuStrip6.Size = New System.Drawing.Size(102, 43)
        Me.MenuStrip6.TabIndex = 4
        Me.MenuStrip6.Text = "MenuStrip6"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(82, 39)
        Me.ToolStripMenuItem5.Text = "Volver"
        '
        'txtObservacion
        '
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(31, 125)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(977, 288)
        Me.txtObservacion.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(192, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(656, 58)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Descripción de la institución donde se llevo el curso anterior" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(144, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(802, 39)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Este grado ya ha sido procesado en otro instituto"
        '
        'MenuStrip5
        '
        Me.MenuStrip5.AutoSize = False
        Me.MenuStrip5.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip5.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.MenuStrip5.Location = New System.Drawing.Point(651, 413)
        Me.MenuStrip5.Name = "MenuStrip5"
        Me.MenuStrip5.Size = New System.Drawing.Size(102, 43)
        Me.MenuStrip5.TabIndex = 3
        Me.MenuStrip5.Text = "MenuStrip5"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(95, 39)
        Me.ToolStripMenuItem4.Text = "Guardar"
        '
        'PanelMAtricula_ya_hecha
        '
        Me.PanelMAtricula_ya_hecha.Controls.Add(Me.Button2)
        Me.PanelMAtricula_ya_hecha.Controls.Add(Me.Label14)
        Me.PanelMAtricula_ya_hecha.Controls.Add(Me.PictureBox1)
        Me.PanelMAtricula_ya_hecha.Location = New System.Drawing.Point(1006, 298)
        Me.PanelMAtricula_ya_hecha.Name = "PanelMAtricula_ya_hecha"
        Me.PanelMAtricula_ya_hecha.Size = New System.Drawing.Size(532, 534)
        Me.PanelMAtricula_ya_hecha.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(440, 482)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 30)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(29, 401)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(475, 78)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Ya se encuentra matriculado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en este grado"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(68, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(396, 347)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.PanelPrincipal.Controls.Add(Me.Panel3)
        Me.PanelPrincipal.Controls.Add(Me.PanelFormulario)
        Me.PanelPrincipal.Controls.Add(Me.DataListadoAlumnos)
        Me.PanelPrincipal.Location = New System.Drawing.Point(3, 32)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(878, 543)
        Me.PanelPrincipal.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.datalistadoNumero_de_recibo)
        Me.Panel7.Location = New System.Drawing.Point(973, 128)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(158, 110)
        Me.Panel7.TabIndex = 589
        '
        'datalistadoNumero_de_recibo
        '
        Me.datalistadoNumero_de_recibo.AllowUserToAddRows = False
        Me.datalistadoNumero_de_recibo.AllowUserToDeleteRows = False
        Me.datalistadoNumero_de_recibo.AllowUserToResizeRows = False
        Me.datalistadoNumero_de_recibo.BackgroundColor = System.Drawing.Color.LightGray
        Me.datalistadoNumero_de_recibo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistadoNumero_de_recibo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistadoNumero_de_recibo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datalistadoNumero_de_recibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadoNumero_de_recibo.ColumnHeadersVisible = False
        Me.datalistadoNumero_de_recibo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1})
        Me.datalistadoNumero_de_recibo.EnableHeadersVisualStyles = False
        Me.datalistadoNumero_de_recibo.GridColor = System.Drawing.Color.Gainsboro
        Me.datalistadoNumero_de_recibo.Location = New System.Drawing.Point(15, 15)
        Me.datalistadoNumero_de_recibo.Name = "datalistadoNumero_de_recibo"
        Me.datalistadoNumero_de_recibo.ReadOnly = True
        Me.datalistadoNumero_de_recibo.RowHeadersVisible = False
        Me.datalistadoNumero_de_recibo.RowHeadersWidth = 9
        Me.datalistadoNumero_de_recibo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro
        Me.datalistadoNumero_de_recibo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistadoNumero_de_recibo.RowTemplate.Height = 35
        Me.datalistadoNumero_de_recibo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadoNumero_de_recibo.Size = New System.Drawing.Size(143, 95)
        Me.datalistadoNumero_de_recibo.TabIndex = 588
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Marcar"
        Me.DataGridViewImageColumn1.HeaderText = "Marcar"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'TXTCANTIDAD_DE_CUOTAS
        '
        Me.TXTCANTIDAD_DE_CUOTAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TXTCANTIDAD_DE_CUOTAS.Location = New System.Drawing.Point(461, 171)
        Me.TXTCANTIDAD_DE_CUOTAS.Name = "TXTCANTIDAD_DE_CUOTAS"
        Me.TXTCANTIDAD_DE_CUOTAS.Size = New System.Drawing.Size(133, 26)
        Me.TXTCANTIDAD_DE_CUOTAS.TabIndex = 597
        Me.TXTCANTIDAD_DE_CUOTAS.Text = "8"
        '
        'txtGrado
        '
        Me.txtGrado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtGrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtGrado.FormattingEnabled = True
        Me.txtGrado.Location = New System.Drawing.Point(111, 22)
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.Size = New System.Drawing.Size(158, 28)
        Me.txtGrado.TabIndex = 598
        '
        'Matriculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1297, 663)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.PanelMAtricula_ya_hecha)
        Me.Controls.Add(Me.PanelOBSERVACION)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Matriculas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriculas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.PanelFormulario.ResumeLayout(False)
        Me.PanelFormulario.PerformLayout()
        CType(Me.DataListadoAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.PanelOBSERVACION.ResumeLayout(False)
        Me.PanelOBSERVACION.PerformLayout()
        Me.MenuStrip6.ResumeLayout(False)
        Me.MenuStrip6.PerformLayout()
        Me.MenuStrip5.ResumeLayout(False)
        Me.MenuStrip5.PerformLayout()
        Me.PanelMAtricula_ya_hecha.ResumeLayout(False)
        Me.PanelMAtricula_ya_hecha.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.datalistadoNumero_de_recibo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents search As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PanelFormulario As Panel
    Friend WithEvents txtCostoPension As TextBox
    Friend WithEvents txt_cantidad_de_importe As TextBox
    Friend WithEvents txtCostoMastriculas As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtHorario As ComboBox
    Friend WithEvents txtSeccion As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip4 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents txtNumeroDeRecibo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelOBSERVACION As Panel
    Friend WithEvents MenuStrip6 As MenuStrip
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MenuStrip5 As MenuStrip
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents PanelMAtricula_ya_hecha As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents txtComprobante As ComboBox
    Friend WithEvents lblBuscarAlumno As Label
    Friend WithEvents DataListadoAlumnos As DataGridView
    Friend WithEvents Marcar As DataGridViewImageColumn
    Friend WithEvents TXTFECHA As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents datalistadoNumero_de_recibo As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents TXTCANTIDAD_DE_CUOTAS As DomainUpDown
    Friend WithEvents txtGrado As ComboBox
End Class
