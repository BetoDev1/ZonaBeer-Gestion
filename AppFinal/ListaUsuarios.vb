Imports System.Data.OleDb

Public Class ListaUsuarios

    Private Sub ListaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarUsuarios()

    End Sub

    Private Sub MostrarUsuarios() 'esta funcion sirve para mostrar la tabla productos

        Dim oda As New OleDbDataAdapter
        Dim ods As New DataSet
        Dim consulta As String

        consulta = "select nombreusuario, apellido, nombres, telefono from usuarios"
        oda = New OleDbDataAdapter(consulta, conn)
        ods.Tables.Add("usuarios")
        oda.Fill(ods.Tables("usuarios"))

        listausuariosdgv.DataSource = ods.Tables("usuarios")




    End Sub

    Private Sub btncrear2_Click(sender As Object, e As EventArgs) Handles btncrear2.Click
        Me.Close()
        MenuUsuarios.Show()

    End Sub
End Class