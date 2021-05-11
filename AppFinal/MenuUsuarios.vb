Public Class MenuUsuarios

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Me.Close()
        Crear.Show()

    End Sub

    Private Sub btncrear2_Click(sender As Object, e As EventArgs) Handles btncrear2.Click
        Me.Close()
        index.Show()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Me.Close()
        EliminarU.Show()

    End Sub

    Private Sub btnlista_Click(sender As Object, e As EventArgs) Handles btnlista.Click
        Me.Close()

        ListaUsuarios.Show()

    End Sub
End Class