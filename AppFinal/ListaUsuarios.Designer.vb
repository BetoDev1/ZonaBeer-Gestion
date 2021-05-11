<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaUsuarios))
        Me.listausuariosdgv = New System.Windows.Forms.DataGridView()
        Me.btncrear2 = New System.Windows.Forms.Button()
        CType(Me.listausuariosdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listausuariosdgv
        '
        Me.listausuariosdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.listausuariosdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listausuariosdgv.Enabled = False
        Me.listausuariosdgv.Location = New System.Drawing.Point(23, 140)
        Me.listausuariosdgv.Name = "listausuariosdgv"
        Me.listausuariosdgv.Size = New System.Drawing.Size(440, 218)
        Me.listausuariosdgv.TabIndex = 0
        '
        'btncrear2
        '
        Me.btncrear2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrear2.Location = New System.Drawing.Point(176, 385)
        Me.btncrear2.Margin = New System.Windows.Forms.Padding(4)
        Me.btncrear2.Name = "btncrear2"
        Me.btncrear2.Size = New System.Drawing.Size(143, 30)
        Me.btncrear2.TabIndex = 9
        Me.btncrear2.Text = "Volver"
        Me.btncrear2.UseVisualStyleBackColor = True
        '
        'ListaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.btncrear2)
        Me.Controls.Add(Me.listausuariosdgv)
        Me.Name = "ListaUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListaUsuarios"
        CType(Me.listausuariosdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listausuariosdgv As System.Windows.Forms.DataGridView
    Friend WithEvents btncrear2 As System.Windows.Forms.Button
End Class
