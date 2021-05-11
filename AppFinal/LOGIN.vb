

Public Class LOGIN

    Dim comandos As New OleDb.OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim lector As OleDb.OleDbDataReader

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectarse()
        
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim consulta As String
        
        consulta = "select * from usuarios where nombreUsuario = '" & TextBox1.Text & "'"
        sql += " and pass = '" & TextBox2.Text & "' "

        comandos = New OleDb.OleDbCommand(consulta, conn)
        adaptador.SelectCommand = comandos

        Dim user As String = Me.TextBox1.Text

        lector = comandos.ExecuteReader

        If lector.Read = True Then

            If lector("nivel").ToString() = "Invitado" Then
                nivel = "I"
            Else : nivel = "A"
            End If

            'If nivel = "I" Then
            '    Productos.TabPage3.Enabled = False
            '    index.btnhistorial.Enabled = False
            'End If

            Me.Hide()
            index.Show()

        Else
            MsgBox("Usuario o Contraseña Incorrectos Amigazo")

        End If


    End Sub



   
    
    
End Class