Imports System.Data.OleDb

Public Class Historial

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarVentas()
    End Sub

    Private Sub MostrarVentas() 'esta funcion sirve para mostrar el historial de ventas

        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "select *from ventas"
        oda = New OleDbDataAdapter(consulta, conn)
        ods.Tables.Add("ventas")
        oda.Fill(ods.Tables("ventas"))

        historialventas.DataSource = ods.Tables("ventas")




    End Sub

    Private Sub btnvolver1_Click(sender As Object, e As EventArgs) Handles btnvolver1.Click
        index.Show()
        Me.Close()

    End Sub
End Class