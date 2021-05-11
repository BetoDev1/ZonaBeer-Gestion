<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Historial))
        Me.historialventas = New System.Windows.Forms.DataGridView()
        Me.btnvolver1 = New System.Windows.Forms.Button()
        CType(Me.historialventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'historialventas
        '
        Me.historialventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.historialventas.Location = New System.Drawing.Point(48, 153)
        Me.historialventas.Name = "historialventas"
        Me.historialventas.Size = New System.Drawing.Size(443, 294)
        Me.historialventas.TabIndex = 0
        '
        'btnvolver1
        '
        Me.btnvolver1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver1.Location = New System.Drawing.Point(204, 477)
        Me.btnvolver1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnvolver1.Name = "btnvolver1"
        Me.btnvolver1.Size = New System.Drawing.Size(143, 30)
        Me.btnvolver1.TabIndex = 1
        Me.btnvolver1.Text = "Volver"
        Me.btnvolver1.UseVisualStyleBackColor = True
        '
        'Historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(534, 543)
        Me.Controls.Add(Me.btnvolver1)
        Me.Controls.Add(Me.historialventas)
        Me.Name = "Historial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.historialventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents historialventas As System.Windows.Forms.DataGridView
    Friend WithEvents btnvolver1 As System.Windows.Forms.Button
End Class
