Public Class index


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If nivel = "I" Then
            Productos.TabPage3.Enabled = False
            Productos.TabPage4.Enabled = False
            Me.btnhistorial.Enabled = False
            Me.btnproductos.Enabled = False
            Me.btnmenuusuarios.Enabled = False
        End If
    End Sub

    Private Sub btnproductos_Click(sender As Object, e As EventArgs) Handles btnproductos.Click
        Productos.Show()
        
    End Sub

    Private Sub btnventas_Click(sender As Object, e As EventArgs) Handles btnventas.Click
        Venta.Show()
        Me.Close()

    End Sub

    

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Historial.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnhistorial.Click
        Historial.Show()
        Me.Close()

    End Sub

    
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
        LOGIN.Show()

    End Sub

    Private Sub btnmenuusuarios_Click(sender As Object, e As EventArgs) Handles btnmenuusuarios.Click
        Me.Hide()
        MenuUsuarios.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        LOGIN.Show()
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

        ListaArticulos.Show()

    End Sub
End Class
