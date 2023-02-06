<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matriculas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Matriculas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.search = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataListadoAlumnos = New System.Windows.Forms.DataGridView()
        Me.PanelFormulario = New System.Windows.Forms.Panel()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtNumeroDeRecibo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtComprobante = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MenuStrip6 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MenuStrip5 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataListadoAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFormulario.SuspendLayout()
        Me.MenuStrip4.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.MenuStrip6.SuspendLayout()
        Me.MenuStrip5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1171, 26)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1143, 0)
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
        Me.Panel3.Controls.Add(Me.txtBuscar)
        Me.Panel3.Controls.Add(Me.MenuStrip1)
        Me.Panel3.Controls.Add(Me.MenuStrip2)
        Me.Panel3.Location = New System.Drawing.Point(21, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(842, 44)
        Me.Panel3.TabIndex = 1
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(48, 9)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(747, 26)
        Me.txtBuscar.TabIndex = 2
        Me.txtBuscar.Text = "Ingrese nombre del alumno"
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
        'DataListadoAlumnos
        '
        Me.DataListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListadoAlumnos.Location = New System.Drawing.Point(688, 107)
        Me.DataListadoAlumnos.Name = "DataListadoAlumnos"
        Me.DataListadoAlumnos.Size = New System.Drawing.Size(136, 161)
        Me.DataListadoAlumnos.TabIndex = 2
        '
        'PanelFormulario
        '
        Me.PanelFormulario.Controls.Add(Me.MenuStrip4)
        Me.PanelFormulario.Controls.Add(Me.txtNumeroDeRecibo)
        Me.PanelFormulario.Controls.Add(Me.DataListadoAlumnos)
        Me.PanelFormulario.Controls.Add(Me.Label11)
        Me.PanelFormulario.Controls.Add(Me.MenuStrip3)
        Me.PanelFormulario.Controls.Add(Me.txtComprobante)
        Me.PanelFormulario.Controls.Add(Me.Label10)
        Me.PanelFormulario.Controls.Add(Me.DateTimePicker1)
        Me.PanelFormulario.Controls.Add(Me.TextBox4)
        Me.PanelFormulario.Controls.Add(Me.Label9)
        Me.PanelFormulario.Controls.Add(Me.TextBox3)
        Me.PanelFormulario.Controls.Add(Me.TextBox2)
        Me.PanelFormulario.Controls.Add(Me.TextBox1)
        Me.PanelFormulario.Controls.Add(Me.Panel5)
        Me.PanelFormulario.Controls.Add(Me.ComboBox3)
        Me.PanelFormulario.Controls.Add(Me.ComboBox2)
        Me.PanelFormulario.Controls.Add(Me.ComboBox1)
        Me.PanelFormulario.Controls.Add(Me.Label8)
        Me.PanelFormulario.Controls.Add(Me.Label7)
        Me.PanelFormulario.Controls.Add(Me.Label6)
        Me.PanelFormulario.Controls.Add(Me.Label5)
        Me.PanelFormulario.Controls.Add(Me.Label4)
        Me.PanelFormulario.Controls.Add(Me.Label3)
        Me.PanelFormulario.Controls.Add(Me.Label2)
        Me.PanelFormulario.Controls.Add(Me.Label1)
        Me.PanelFormulario.Location = New System.Drawing.Point(21, 87)
        Me.PanelFormulario.Name = "PanelFormulario"
        Me.PanelFormulario.Size = New System.Drawing.Size(842, 427)
        Me.PanelFormulario.TabIndex = 3
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
        'txtComprobante
        '
        Me.txtComprobante.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtComprobante.FormattingEnabled = True
        Me.txtComprobante.ItemHeight = 20
        Me.txtComprobante.Location = New System.Drawing.Point(171, 285)
        Me.txtComprobante.Name = "txtComprobante"
        Me.txtComprobante.Size = New System.Drawing.Size(203, 28)
        Me.txtComprobante.TabIndex = 590
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
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(163, 218)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(133, 20)
        Me.TextBox4.TabIndex = 16
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(461, 145)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(133, 20)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(163, 179)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(133, 20)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(163, 147)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(11, 202)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(285, 5)
        Me.Panel5.TabIndex = 11
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(111, 84)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(158, 21)
        Me.ComboBox3.TabIndex = 10
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(111, 57)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(158, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(111, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(158, 21)
        Me.ComboBox1.TabIndex = 8
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.MenuStrip6)
        Me.Panel4.Controls.Add(Me.TextBox6)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.MenuStrip5)
        Me.Panel4.Location = New System.Drawing.Point(1060, 119)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1040, 462)
        Me.Panel4.TabIndex = 4
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
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(31, 125)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(977, 288)
        Me.TextBox6.TabIndex = 2
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
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Button2)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Location = New System.Drawing.Point(1080, 99)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(532, 534)
        Me.Panel6.TabIndex = 5
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
        Me.PanelPrincipal.Controls.Add(Me.Panel3)
        Me.PanelPrincipal.Controls.Add(Me.PanelFormulario)
        Me.PanelPrincipal.Location = New System.Drawing.Point(3, 32)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(888, 543)
        Me.PanelPrincipal.TabIndex = 6
        '
        'Matriculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1171, 593)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
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
        CType(Me.DataListadoAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFormulario.ResumeLayout(False)
        Me.PanelFormulario.PerformLayout()
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.MenuStrip6.ResumeLayout(False)
        Me.MenuStrip6.PerformLayout()
        Me.MenuStrip5.ResumeLayout(False)
        Me.MenuStrip5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
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
    Friend WithEvents DataListadoAlumnos As DataGridView
    Friend WithEvents PanelFormulario As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
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
    Friend WithEvents txtComprobante As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MenuStrip6 As MenuStrip
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MenuStrip5 As MenuStrip
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents PanelPrincipal As Panel
End Class
