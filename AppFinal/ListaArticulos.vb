Imports System.Data.OleDb

Public Class ListaArticulos

    Private Sub ListaArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarProductos()

    End Sub

    Private Sub MostrarProductos() 'esta funcion sirve para mostrar la tabla productos

        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "select *from producto"
        oda = New OleDbDataAdapter(consulta, conn)
        ods.Tables.Add("producto")
        oda.Fill(ods.Tables("producto"))

        listaarticulosdgv.DataSource = ods.Tables("producto")




    End Sub

    Private Sub btncrear2_Click(sender As Object, e As EventArgs) Handles btncrear2.Click
        Me.Close()
        index.Show()

    End Sub
End Class