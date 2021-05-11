<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaArticulos))
        Me.listaarticulosdgv = New System.Windows.Forms.DataGridView()
        Me.btncrear2 = New System.Windows.Forms.Button()
        CType(Me.listaarticulosdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listaarticulosdgv
        '
        Me.listaarticulosdgv.AllowUserToAddRows = False
        Me.listaarticulosdgv.AllowUserToDeleteRows = False
        Me.listaarticulosdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaarticulosdgv.Location = New System.Drawing.Point(31, 117)
        Me.listaarticulosdgv.Name = "listaarticulosdgv"
        Me.listaarticulosdgv.ReadOnly = True
        Me.listaarticulosdgv.Size = New System.Drawing.Size(740, 311)
        Me.listaarticulosdgv.TabIndex = 0
        '
        'btncrear2
        '
        Me.btncrear2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrear2.Location = New System.Drawing.Point(336, 461)
        Me.btncrear2.Margin = New System.Windows.Forms.Padding(4)
        Me.btncrear2.Name = "btncrear2"
        Me.btncrear2.Size = New System.Drawing.Size(143, 30)
        Me.btncrear2.TabIndex = 10
        Me.btncrear2.Text = "Volver"
        Me.btncrear2.UseVisualStyleBackColor = True
        '
        'ListaArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(818, 540)
        Me.Controls.Add(Me.btncrear2)
        Me.Controls.Add(Me.listaarticulosdgv)
        Me.Name = "ListaArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListaArticulos"
        CType(Me.listaarticulosdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listaarticulosdgv As System.Windows.Forms.DataGridView
    Friend WithEvents btncrear2 As System.Windows.Forms.Button
End Class
