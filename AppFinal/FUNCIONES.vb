Module FUNCIONES


    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=App.accdb;Persist Security Info=False")
    Public nivel As Char
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader

    Public sql As String = ""

    Public Sub conectarse()

        Try
            conn.Open()
            'MsgBox("Bienvenido")


        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub


    Public Sub consultar(ByRef idproducto As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text


        If idproducto <> "" Then
            cmd.CommandText = "SELECT CATEGORIA, STOCK, PRECIOCOMPRA, PRECIOVENTA, PRECIOMAYORISTA FROM PRODUCTO  WHERE IDPRODUCTO=" + idproducto
        Else
            cmd.CommandText = "SELECT CATEGORIA, STOCK, PRECIOCOMPRA, PRECIOVENTA, PRECIOMAYORISTA FROM PRODUCTO"

        End If

        Try
            dr = cmd.ExecuteReader()


            If dr.HasRows Then
                While dr.Read()
                    MsgBox(dr(0).ToString + "" + dr(1).ToString + "" + dr(2).ToString + "" + dr(3).ToString)

                End While

            Else
                MsgBox("No existen registros para la consulta")


            End If

            dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    'Public Sub consultarProducto(ByVal Nombreproducto As String)

    '    cmd.Connection = conn
    '    cmd.CommandType = CommandType.Text
    '    cmd.CommandText = "SELECT CATEGORIA, STOCK, PRECIOCOMPRA, PRECIOVENTA, PRECIOMAYORISTA FROM PRODUCTO  WHERE NOMBREPRODUCTO LIKE '" & Nombreproducto & "'"

    '    Try
    '        dr = cmd.ExecuteReader()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)

    '    End Try

    'End Sub





End Module
