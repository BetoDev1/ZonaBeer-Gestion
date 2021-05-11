<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.listaventa = New System.Windows.Forms.DataGridView()
        Me.txtdetalle = New System.Windows.Forms.TextBox()
        Me.txtidproductov = New System.Windows.Forms.TextBox()
        Me.txtcantidadv = New System.Windows.Forms.TextBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.btnfinalizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AppDataSet = New AppFinal.AppDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New AppFinal.AppDataSetTableAdapters.ProductoTableAdapter()
        Me.txtpreciounitario = New System.Windows.Forms.TextBox()
        Me.txtpreciototal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Comprobante = New System.Drawing.Printing.PrintDocument()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.efectivo = New System.Windows.Forms.RadioButton()
        Me.tarjeta = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtvendedor = New System.Windows.Forms.TextBox()
        Me.Vendedor = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnvolver2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.radiosi = New System.Windows.Forms.RadioButton()
        Me.radiono = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btneliminarv = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtstockv = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.columnapreciototal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnapreciounidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnacantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.listaventa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listaventa
        '
        Me.listaventa.AllowUserToAddRows = False
        Me.listaventa.AllowUserToDeleteRows = False
        Me.listaventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaventa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnaproducto, Me.columnacantidad, Me.columnapreciounidad, Me.columnapreciototal})
        Me.listaventa.Enabled = False
        Me.listaventa.Location = New System.Drawing.Point(64, 267)
        Me.listaventa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.listaventa.Name = "listaventa"
        Me.listaventa.ReadOnly = True
        Me.listaventa.Size = New System.Drawing.Size(645, 197)
        Me.listaventa.TabIndex = 0
        '
        'txtdetalle
        '
        Me.txtdetalle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtdetalle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtdetalle.Location = New System.Drawing.Point(74, 221)
        Me.txtdetalle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(287, 22)
        Me.txtdetalle.TabIndex = 1
        '
        'txtidproductov
        '
        Me.txtidproductov.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtidproductov.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtidproductov.Location = New System.Drawing.Point(74, 163)
        Me.txtidproductov.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtidproductov.Name = "txtidproductov"
        Me.txtidproductov.Size = New System.Drawing.Size(76, 22)
        Me.txtidproductov.TabIndex = 2
        '
        'txtcantidadv
        '
        Me.txtcantidadv.Location = New System.Drawing.Point(421, 110)
        Me.txtcantidadv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcantidadv.Name = "txtcantidadv"
        Me.txtcantidadv.Size = New System.Drawing.Size(116, 22)
        Me.txtcantidadv.TabIndex = 3
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnagregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnagregar.Location = New System.Drawing.Point(575, 134)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(127, 30)
        Me.btnagregar.TabIndex = 4
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(623, 492)
        Me.txtsubtotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(79, 22)
        Me.txtsubtotal.TabIndex = 5
        '
        'btnfinalizar
        '
        Me.btnfinalizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnfinalizar.Location = New System.Drawing.Point(585, 590)
        Me.btnfinalizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnfinalizar.Name = "btnfinalizar"
        Me.btnfinalizar.Size = New System.Drawing.Size(116, 30)
        Me.btnfinalizar.TabIndex = 6
        Me.btnfinalizar.Text = "Finalizar"
        Me.btnfinalizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(72, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(72, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Detalle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(420, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cantidad"
        '
        'AppDataSet
        '
        Me.AppDataSet.DataSetName = "AppDataSet"
        Me.AppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.AppDataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'txtpreciounitario
        '
        Me.txtpreciounitario.Enabled = False
        Me.txtpreciounitario.Location = New System.Drawing.Point(422, 162)
        Me.txtpreciounitario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpreciounitario.Name = "txtpreciounitario"
        Me.txtpreciounitario.Size = New System.Drawing.Size(116, 22)
        Me.txtpreciounitario.TabIndex = 10
        '
        'txtpreciototal
        '
        Me.txtpreciototal.Enabled = False
        Me.txtpreciototal.Location = New System.Drawing.Point(422, 220)
        Me.txtpreciototal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpreciototal.Name = "txtpreciototal"
        Me.txtpreciototal.Size = New System.Drawing.Size(116, 22)
        Me.txtpreciototal.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(419, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Precio Unitario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(419, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Precio Final"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(527, 495)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "SUB-TOTAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(601, 494)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(406, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(406, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "$"
        '
        'Comprobante
        '
        '
        'btnimprimir
        '
        Me.btnimprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnimprimir.Location = New System.Drawing.Point(423, 590)
        Me.btnimprimir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(127, 30)
        Me.btnimprimir.TabIndex = 19
        Me.btnimprimir.Text = "Imprimir Ticket"
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'efectivo
        '
        Me.efectivo.AutoSize = True
        Me.efectivo.BackColor = System.Drawing.Color.Transparent
        Me.efectivo.Checked = True
        Me.efectivo.Location = New System.Drawing.Point(25, 30)
        Me.efectivo.Name = "efectivo"
        Me.efectivo.Size = New System.Drawing.Size(76, 21)
        Me.efectivo.TabIndex = 20
        Me.efectivo.TabStop = True
        Me.efectivo.Text = "Efectivo"
        Me.efectivo.UseVisualStyleBackColor = False
        '
        'tarjeta
        '
        Me.tarjeta.AutoSize = True
        Me.tarjeta.BackColor = System.Drawing.Color.Transparent
        Me.tarjeta.Location = New System.Drawing.Point(25, 48)
        Me.tarjeta.Name = "tarjeta"
        Me.tarjeta.Size = New System.Drawing.Size(67, 21)
        Me.tarjeta.TabIndex = 21
        Me.tarjeta.Text = "Tarjeta"
        Me.tarjeta.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.efectivo)
        Me.Panel1.Controls.Add(Me.tarjeta)
        Me.Panel1.Location = New System.Drawing.Point(64, 490)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(123, 76)
        Me.Panel1.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "FORMA DE PAGO"
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.Red
        Me.txttotal.Location = New System.Drawing.Point(623, 527)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(80, 33)
        Me.txttotal.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(536, 536)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 21)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "TOTAL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(601, 537)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 18)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "$"
        '
        'txtvendedor
        '
        Me.txtvendedor.Enabled = False
        Me.txtvendedor.Location = New System.Drawing.Point(227, 163)
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.Size = New System.Drawing.Size(131, 22)
        Me.txtvendedor.TabIndex = 26
        '
        'Vendedor
        '
        Me.Vendedor.AutoSize = True
        Me.Vendedor.BackColor = System.Drawing.Color.Transparent
        Me.Vendedor.Location = New System.Drawing.Point(229, 143)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Size = New System.Drawing.Size(68, 17)
        Me.Vendedor.TabIndex = 27
        Me.Vendedor.Text = "Vendedor"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DateTimePicker1.Location = New System.Drawing.Point(422, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(276, 22)
        Me.DateTimePicker1.TabIndex = 28
        '
        'btnvolver2
        '
        Me.btnvolver2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnvolver2.Location = New System.Drawing.Point(272, 590)
        Me.btnvolver2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnvolver2.Name = "btnvolver2"
        Me.btnvolver2.Size = New System.Drawing.Size(120, 30)
        Me.btnvolver2.TabIndex = 29
        Me.btnvolver2.Text = "Volver"
        Me.btnvolver2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.radiosi)
        Me.Panel2.Controls.Add(Me.radiono)
        Me.Panel2.Location = New System.Drawing.Point(216, 490)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(146, 69)
        Me.Panel2.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 17)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "HORARIO COMERCIAL"
        '
        'radiosi
        '
        Me.radiosi.AutoSize = True
        Me.radiosi.BackColor = System.Drawing.Color.Transparent
        Me.radiosi.Checked = True
        Me.radiosi.Location = New System.Drawing.Point(24, 35)
        Me.radiosi.Name = "radiosi"
        Me.radiosi.Size = New System.Drawing.Size(36, 21)
        Me.radiosi.TabIndex = 20
        Me.radiosi.TabStop = True
        Me.radiosi.Text = "Si"
        Me.radiosi.UseVisualStyleBackColor = False
        '
        'radiono
        '
        Me.radiono.AutoSize = True
        Me.radiono.BackColor = System.Drawing.Color.Transparent
        Me.radiono.Location = New System.Drawing.Point(80, 35)
        Me.radiono.Name = "radiono"
        Me.radiono.Size = New System.Drawing.Size(43, 21)
        Me.radiono.TabIndex = 21
        Me.radiono.Text = "No"
        Me.radiono.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(310, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'btneliminarv
        '
        Me.btneliminarv.BackColor = System.Drawing.Color.Gainsboro
        Me.btneliminarv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btneliminarv.Location = New System.Drawing.Point(575, 186)
        Me.btneliminarv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btneliminarv.Name = "btneliminarv"
        Me.btneliminarv.Size = New System.Drawing.Size(127, 30)
        Me.btneliminarv.TabIndex = 31
        Me.btneliminarv.Text = "Eliminar"
        Me.btneliminarv.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(582, 137)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(583, 190)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'txtstockv
        '
        Me.txtstockv.Enabled = False
        Me.txtstockv.Location = New System.Drawing.Point(160, 163)
        Me.txtstockv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtstockv.Name = "txtstockv"
        Me.txtstockv.Size = New System.Drawing.Size(54, 22)
        Me.txtstockv.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(160, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 17)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Stock"
        '
        'columnapreciototal
        '
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.columnapreciototal.DefaultCellStyle = DataGridViewCellStyle4
        Me.columnapreciototal.HeaderText = "Precio Final"
        Me.columnapreciototal.Name = "columnapreciototal"
        Me.columnapreciototal.ReadOnly = True
        '
        'columnapreciounidad
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.columnapreciounidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnapreciounidad.HeaderText = "Precio Unitario"
        Me.columnapreciounidad.Name = "columnapreciounidad"
        Me.columnapreciounidad.ReadOnly = True
        '
        'columnacantidad
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.columnacantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnacantidad.HeaderText = "Cantidad"
        Me.columnacantidad.Name = "columnacantidad"
        Me.columnacantidad.ReadOnly = True
        '
        'columnaproducto
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.columnaproducto.DefaultCellStyle = DataGridViewCellStyle1
        Me.columnaproducto.HeaderText = "Producto(s)"
        Me.columnaproducto.Name = "columnaproducto"
        Me.columnaproducto.ReadOnly = True
        Me.columnaproducto.Width = 300
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 644)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtstockv)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btneliminarv)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnvolver2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Vendedor)
        Me.Controls.Add(Me.txtvendedor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpreciototal)
        Me.Controls.Add(Me.txtpreciounitario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnfinalizar)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.txtcantidadv)
        Me.Controls.Add(Me.txtidproductov)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.listaventa)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta"
        CType(Me.listaventa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listaventa As System.Windows.Forms.DataGridView
    Friend WithEvents txtdetalle As System.Windows.Forms.TextBox
    Friend WithEvents txtidproductov As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidadv As System.Windows.Forms.TextBox
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents txtsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents btnfinalizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AppDataSet As AppFinal.AppDataSet
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As AppFinal.AppDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents txtpreciounitario As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciototal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Comprobante As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    Friend WithEvents efectivo As System.Windows.Forms.RadioButton
    Friend WithEvents tarjeta As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtvendedor As System.Windows.Forms.TextBox
    Friend WithEvents Vendedor As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnvolver2 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents radiosi As System.Windows.Forms.RadioButton
    Friend WithEvents radiono As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btneliminarv As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtstockv As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents columnaproducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnacantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnapreciounidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnapreciototal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
