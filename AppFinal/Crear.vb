Public Class Crear

    Private Sub btncrear2_Click(sender As Object, e As EventArgs) Handles btncrear2.Click
        cmd.Connection = conn

        If (Me.txtnick.Text = "") Then
            MsgBox("el campo no puede estar vacio")
            Me.txtnick.Select()

        Else
            Dim apellido As String = ""
            Dim nombres As String = ""
            Dim telefono As String = ""
            Dim nombreuser As String = ""
            Dim pass As String = ""
            Dim acceso As String = ""

            If RadioButton1.Checked = True Then
                acceso = "Admin"
            Else : acceso = "Invitado"
            End If

            apellido = Me.txtapellido.Text
            nombres = Me.txtnombres.Text
            telefono = Me.txttelefono.Text
            nombreuser = Me.txtnick.Text
            pass = Me.txtpass.Text





            sql = "INSERT INTO usuarios (apellido, nombres, telefono, nombreusuario, pass, nivel)"
            sql += " VALUES ('" & apellido & "' ,'" & nombres & "','" & telefono & "','" & nombreuser & "', '" & pass & "',  '" & acceso & "')"



            MsgBox("Usuario Agregado")

            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try

            txtapellido.Text = ""
            txtnombres.Text = ""
            txttelefono.Text = ""
            txtnick.Text = ""
            txtpass.Text = ""

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MenuUsuarios.Show()

    End Sub
End Class