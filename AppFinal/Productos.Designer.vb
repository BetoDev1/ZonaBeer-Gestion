<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Me.btnvolver1 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtnombre3 = New System.Windows.Forms.TextBox()
        Me.txtidproducto3 = New System.Windows.Forms.TextBox()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpreciomayorista2 = New System.Windows.Forms.TextBox()
        Me.txtpreciominorista2 = New System.Windows.Forms.TextBox()
        Me.txtpreciocompra2 = New System.Windows.Forms.TextBox()
        Me.txtstock2 = New System.Windows.Forms.TextBox()
        Me.txtnombre2 = New System.Windows.Forms.TextBox()
        Me.txtcategoria2 = New System.Windows.Forms.TextBox()
        Me.txtidproducto2 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtpreciocompra = New System.Windows.Forms.TextBox()
        Me.txtpreciomay = New System.Windows.Forms.TextBox()
        Me.txtpreciomin = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtnombrep = New System.Windows.Forms.TextBox()
        Me.txtcategoria = New System.Windows.Forms.TextBox()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.tabcontrol = New System.Windows.Forms.TabControl()
        Me.TabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.tabcontrol.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnvolver1
        '
        Me.btnvolver1.Location = New System.Drawing.Point(266, 570)
        Me.btnvolver1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnvolver1.Name = "btnvolver1"
        Me.btnvolver1.Size = New System.Drawing.Size(143, 30)
        Me.btnvolver1.TabIndex = 0
        Me.btnvolver1.Text = "Volver"
        Me.btnvolver1.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.DarkRed
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.txtnombre3)
        Me.TabPage4.Controls.Add(Me.txtidproducto3)
        Me.TabPage4.Controls.Add(Me.btnborrar)
        Me.TabPage4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(588, 483)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Eliminar"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(169, 271)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 20)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Nombre"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(140, 204)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 20)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "ID Producto"
        '
        'txtnombre3
        '
        Me.txtnombre3.Location = New System.Drawing.Point(245, 271)
        Me.txtnombre3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre3.Name = "txtnombre3"
        Me.txtnombre3.Size = New System.Drawing.Size(176, 23)
        Me.txtnombre3.TabIndex = 16
        '
        'txtidproducto3
        '
        Me.txtidproducto3.Location = New System.Drawing.Point(245, 203)
        Me.txtidproducto3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidproducto3.Name = "txtidproducto3"
        Me.txtidproducto3.Size = New System.Drawing.Size(176, 23)
        Me.txtidproducto3.TabIndex = 14
        '
        'btnborrar
        '
        Me.btnborrar.BackColor = System.Drawing.Color.Firebrick
        Me.btnborrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnborrar.Location = New System.Drawing.Point(241, 346)
        Me.btnborrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(138, 36)
        Me.btnborrar.TabIndex = 0
        Me.btnborrar.Text = "Borrar Producto"
        Me.btnborrar.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DodgerBlue
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.Controls.Add(Me.btnactualizar)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.txtpreciomayorista2)
        Me.TabPage3.Controls.Add(Me.txtpreciominorista2)
        Me.TabPage3.Controls.Add(Me.txtpreciocompra2)
        Me.TabPage3.Controls.Add(Me.txtstock2)
        Me.TabPage3.Controls.Add(Me.txtnombre2)
        Me.TabPage3.Controls.Add(Me.txtcategoria2)
        Me.TabPage3.Controls.Add(Me.txtidproducto2)
        Me.TabPage3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(588, 483)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Actualizar"
        '
        'btnactualizar
        '
        Me.btnactualizar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnactualizar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnactualizar.Location = New System.Drawing.Point(237, 413)
        Me.btnactualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(147, 36)
        Me.btnactualizar.TabIndex = 14
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(167, 354)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 17)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Precio Mayorista"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(185, 320)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Precio Venta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(148, 287)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Precio de Compra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(231, 257)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Stock"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(213, 223)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(199, 192)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Categoria"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(190, 161)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "ID Producto"
        '
        'txtpreciomayorista2
        '
        Me.txtpreciomayorista2.Location = New System.Drawing.Point(295, 350)
        Me.txtpreciomayorista2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpreciomayorista2.Name = "txtpreciomayorista2"
        Me.txtpreciomayorista2.Size = New System.Drawing.Size(85, 23)
        Me.txtpreciomayorista2.TabIndex = 6
        '
        'txtpreciominorista2
        '
        Me.txtpreciominorista2.Location = New System.Drawing.Point(295, 315)
        Me.txtpreciominorista2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpreciominorista2.Name = "txtpreciominorista2"
        Me.txtpreciominorista2.Size = New System.Drawing.Size(85, 23)
        Me.txtpreciominorista2.TabIndex = 5
        '
        'txtpreciocompra2
        '
        Me.txtpreciocompra2.Location = New System.Drawing.Point(295, 283)
        Me.txtpreciocompra2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpreciocompra2.Name = "txtpreciocompra2"
        Me.txtpreciocompra2.Size = New System.Drawing.Size(85, 23)
        Me.txtpreciocompra2.TabIndex = 4
        '
        'txtstock2
        '
        Me.txtstock2.Location = New System.Drawing.Point(295, 251)
        Me.txtstock2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtstock2.Name = "txtstock2"
        Me.txtstock2.Size = New System.Drawing.Size(85, 23)
        Me.txtstock2.TabIndex = 3
        '
        'txtnombre2
        '
        Me.txtnombre2.Location = New System.Drawing.Point(295, 220)
        Me.txtnombre2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre2.Name = "txtnombre2"
        Me.txtnombre2.Size = New System.Drawing.Size(132, 23)
        Me.txtnombre2.TabIndex = 2
        '
        'txtcategoria2
        '
        Me.txtcategoria2.Location = New System.Drawing.Point(295, 189)
        Me.txtcategoria2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcategoria2.Name = "txtcategoria2"
        Me.txtcategoria2.Size = New System.Drawing.Size(132, 23)
        Me.txtcategoria2.TabIndex = 1
        '
        'txtidproducto2
        '
        Me.txtidproducto2.Location = New System.Drawing.Point(295, 158)
        Me.txtidproducto2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidproducto2.Name = "txtidproducto2"
        Me.txtidproducto2.Size = New System.Drawing.Size(85, 23)
        Me.txtidproducto2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DodgerBlue
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.txtpreciocompra)
        Me.TabPage2.Controls.Add(Me.txtpreciomay)
        Me.TabPage2.Controls.Add(Me.txtpreciomin)
        Me.TabPage2.Controls.Add(Me.txtstock)
        Me.TabPage2.Controls.Add(Me.txtnombrep)
        Me.TabPage2.Controls.Add(Me.txtcategoria)
        Me.TabPage2.Controls.Add(Me.txtidproducto)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.btnagregar)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(588, 483)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Agregar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(151, 284)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 17)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Precio Compra"
        '
        'txtpreciocompra
        '
        Me.txtpreciocompra.Location = New System.Drawing.Point(270, 281)
        Me.txtpreciocompra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpreciocompra.Name = "txtpreciocompra"
        Me.txtpreciocompra.Size = New System.Drawing.Size(101, 23)
        Me.txtpreciocompra.TabIndex = 13
        '
        'txtpreciomay
        '
        Me.txtpreciomay.Location = New System.Drawing.Point(271, 345)
        Me.txtpreciomay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpreciomay.Name = "txtpreciomay"
        Me.txtpreciomay.Size = New System.Drawing.Size(99, 23)
        Me.txtpreciomay.TabIndex = 6
        '
        'txtpreciomin
        '
        Me.txtpreciomin.Location = New System.Drawing.Point(270, 312)
        Me.txtpreciomin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpreciomin.Name = "txtpreciomin"
        Me.txtpreciomin.Size = New System.Drawing.Size(101, 23)
        Me.txtpreciomin.TabIndex = 5
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(270, 250)
        Me.txtstock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(101, 23)
        Me.txtstock.TabIndex = 4
        '
        'txtnombrep
        '
        Me.txtnombrep.Location = New System.Drawing.Point(271, 220)
        Me.txtnombrep.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombrep.Name = "txtnombrep"
        Me.txtnombrep.Size = New System.Drawing.Size(140, 23)
        Me.txtnombrep.TabIndex = 3
        '
        'txtcategoria
        '
        Me.txtcategoria.Location = New System.Drawing.Point(271, 189)
        Me.txtcategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcategoria.Name = "txtcategoria"
        Me.txtcategoria.Size = New System.Drawing.Size(140, 23)
        Me.txtcategoria.TabIndex = 2
        '
        'txtidproducto
        '
        Me.txtidproducto.Location = New System.Drawing.Point(271, 158)
        Me.txtidproducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(100, 23)
        Me.txtidproducto.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(151, 345)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Precio Mayorista"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(151, 315)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Precio Minorista"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(214, 255)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(197, 224)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(183, 193)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(173, 162)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID Producto"
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnagregar.FlatAppearance.BorderSize = 0
        Me.btnagregar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.Location = New System.Drawing.Point(246, 404)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(123, 39)
        Me.btnagregar.TabIndex = 0
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'tabcontrol
        '
        Me.tabcontrol.Controls.Add(Me.TabPage2)
        Me.tabcontrol.Controls.Add(Me.TabPage3)
        Me.tabcontrol.Controls.Add(Me.TabPage4)
        Me.tabcontrol.Location = New System.Drawing.Point(25, 34)
        Me.tabcontrol.Margin = New System.Windows.Forms.Padding(4)
        Me.tabcontrol.Name = "tabcontrol"
        Me.tabcontrol.SelectedIndex = 0
        Me.tabcontrol.Size = New System.Drawing.Size(596, 513)
        Me.tabcontrol.TabIndex = 1
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(641, 633)
        Me.Controls.Add(Me.tabcontrol)
        Me.Controls.Add(Me.btnvolver1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.tabcontrol.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnvolver1 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtnombre3 As System.Windows.Forms.TextBox
    Friend WithEvents txtidproducto3 As System.Windows.Forms.TextBox
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnactualizar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtpreciomayorista2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciominorista2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciocompra2 As System.Windows.Forms.TextBox
    Friend WithEvents txtstock2 As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre2 As System.Windows.Forms.TextBox
    Friend WithEvents txtcategoria2 As System.Windows.Forms.TextBox
    Friend WithEvents txtidproducto2 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtpreciocompra As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciomay As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciomin As System.Windows.Forms.TextBox
    Friend WithEvents txtstock As System.Windows.Forms.TextBox
    Friend WithEvents txtnombrep As System.Windows.Forms.TextBox
    Friend WithEvents txtcategoria As System.Windows.Forms.TextBox
    Friend WithEvents txtidproducto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents tabcontrol As System.Windows.Forms.TabControl
End Class
