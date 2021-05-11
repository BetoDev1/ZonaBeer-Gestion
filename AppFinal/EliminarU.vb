Imports System.Data.OleDb

Public Class EliminarU

    Private con As New OleDb.OleDbConnection
    Private command As OleDb.OleDbCommand
    Private reader As OleDbDataReader

    Private Sub EliminarU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoCompleteBorrar()
    End Sub


    'AUTOCOMPLETAR
    Private Sub AutoCompleteBorrar()
        sql = "SELECT nombreusuario FROM usuarios"
        Command = New OleDbCommand(sql, conn)
        reader = Command.ExecuteReader()
        Dim autoComp As New AutoCompleteStringCollection()
        While reader.Read()
            autoComp.Add(reader("nombreusuario"))
        End While
        reader.Close()
        txtnick2.AutoCompleteMode = AutoCompleteMode.Suggest
        txtnick2.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtnick2.AutoCompleteCustomSource = autoComp
    End Sub


    'FUNCION PARA LLENAR ELRESTO DE LOS CAMPOS AUTOMaTICAMENTE
    Private Sub llenacamposborrar(ByVal nombreusuario As String)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM usuarios  WHERE nombreusuario LIKE '" & nombreusuario & "'"

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    'CAMPO QUE SE VA LLENAR AUTOMATICAMENTE AL INGRESAR EL ID
    Private Sub txtnick2_TextChanged(sender As Object, e As EventArgs) Handles txtnick2.TextChanged

        If Me.txtnick2.Text <> "" Then
            llenacamposborrar(Me.txtnick2.Text)

            If dr.Read Then
                Me.txtapellido2.Text = dr(4).ToString
                Me.txtnombres2.Text = dr(5).ToString



            Else
                Me.txtapellido2.Text = ""
                Me.txtnombres2.Text = ""




            End If


        End If
        dr.Close()



    End Sub


    'BORRAR PRODUCTOS DE LA BD 
    Private Sub btndeleteu_Click(sender As Object, e As EventArgs) Handles btndeleteu.Click



        Dim nombreusuario As String
        nombreusuario = Me.txtnick2.Text


        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = " DELETE FROM usuarios WHERE nombreusuario = '" & nombreusuario & "' "

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Usuario eliminado")

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MenuUsuarios.Show()

    End Sub
End Class