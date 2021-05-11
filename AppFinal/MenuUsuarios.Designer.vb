<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUsuarios))
        Me.btncrear = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnlista = New System.Windows.Forms.Button()
        Me.btncrear2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btncrear
        '
        Me.btncrear.BackColor = System.Drawing.Color.Transparent
        Me.btncrear.FlatAppearance.BorderSize = 0
        Me.btncrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncrear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncrear.Image = CType(resources.GetObject("btncrear.Image"), System.Drawing.Image)
        Me.btncrear.Location = New System.Drawing.Point(77, 222)
        Me.btncrear.Margin = New System.Windows.Forms.Padding(4)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.Size = New System.Drawing.Size(96, 107)
        Me.btncrear.TabIndex = 2
        Me.btncrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncrear.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Transparent
        Me.btndelete.FlatAppearance.BorderSize = 0
        Me.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.Location = New System.Drawing.Point(193, 222)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(96, 107)
        Me.btndelete.TabIndex = 3
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnlista
        '
        Me.btnlista.BackColor = System.Drawing.Color.Transparent
        Me.btnlista.FlatAppearance.BorderSize = 0
        Me.btnlista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnlista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlista.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlista.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlista.Image = CType(resources.GetObject("btnlista.Image"), System.Drawing.Image)
        Me.btnlista.Location = New System.Drawing.Point(308, 222)
        Me.btnlista.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlista.Name = "btnlista"
        Me.btnlista.Size = New System.Drawing.Size(96, 107)
        Me.btnlista.TabIndex = 4
        Me.btnlista.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnlista.UseVisualStyleBackColor = False
        '
        'btncrear2
        '
        Me.btncrear2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrear2.Location = New System.Drawing.Point(169, 382)
        Me.btncrear2.Margin = New System.Windows.Forms.Padding(4)
        Me.btncrear2.Name = "btncrear2"
        Me.btncrear2.Size = New System.Drawing.Size(143, 30)
        Me.btncrear2.TabIndex = 8
        Me.btncrear2.Text = "Volver"
        Me.btncrear2.UseVisualStyleBackColor = True
        '
        'MenuUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.btncrear2)
        Me.Controls.Add(Me.btnlista)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btncrear)
        Me.Name = "MenuUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncrear As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnlista As System.Windows.Forms.Button
    Friend WithEvents btncrear2 As System.Windows.Forms.Button
End Class
