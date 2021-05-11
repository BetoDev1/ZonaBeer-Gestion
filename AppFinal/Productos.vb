Imports System.Data.OleDb

Public Class Productos

    Private con As New OleDb.OleDbConnection
    Private command As OleDb.OleDbCommand
    Private reader As OleDbDataReader

    Private Property Sql As String

    Private Sub btnvolver1_Click(sender As Object, e As EventArgs) Handles btnvolver1.Click
        Me.Close()
        index.Show()

    End Sub


    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        index.Close()


        AutoComplete()
        AutoCompleteBorrar()


    End Sub


    'AGREGAR PRODUCTOS A LA BASE DE DATOS PESTAÑA 1
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

        cmd.Connection = conn

        If (Me.txtidproducto.Text = "") Then
            MsgBox("el campo no puede estar vacio")
            Me.txtidproducto.Select()

        Else
            Dim idproducto As Integer
            Dim categoria As String = ""
            Dim nombrep As String = ""
            Dim stock As Integer
            Dim preciocompra As Integer
            Dim preciomin As Integer
            Dim preciomay As Integer

            idproducto = Me.txtidproducto.Text
            categoria = Me.txtcategoria.Text
            nombrep = Me.txtnombrep.Text
            stock = Me.txtstock.Text
            preciocompra = Me.txtpreciocompra.Text
            preciomin = Me.txtpreciomin.Text
            preciomay = Me.txtpreciomay.Text



            Sql = "INSERT INTO PRODUCTO (IDPRODUCTO, IDCATEGORIA, NOMBREPRODUCTO, STOCK, PRECIOCOMPRA, PRECIOVENTA, PRECIOMAYORISTA)"
            Sql += " VALUES (" & idproducto & " ,'" & categoria & "','" & nombrep & "'," & stock & ", " & preciocompra & "," & preciomin & "," & preciomay & ")"

            MsgBox("Producto Agregado")

            Me.txtidproducto.Text = ""
            Me.txtcategoria.Text = ""
            Me.txtnombrep.Text = ""
            Me.txtstock.Text = ""
            Me.txtpreciocompra.Text = ""
            Me.txtpreciomin.Text = ""
            Me.txtpreciomay.Text = ""

            cmd.CommandText = Sql

            Try
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try


        End If

    End Sub

    'SECCION ACTUALIZAR - PESTAÑA 2 ------------------------------------


    'FUNCION AUTOCOMPLETAR CAMPO DE NOMBREPRODUCTO
    Private Sub AutoComplete()
        Sql = "SELECT nombreproducto FROM Producto"
        Command = New OleDbCommand(Sql, conn)
        reader = Command.ExecuteReader()
        Dim autoComp As New AutoCompleteStringCollection()
        While reader.Read()
            autoComp.Add(reader("NombreProducto"))
        End While
        reader.Close()
        txtnombre2.AutoCompleteMode = AutoCompleteMode.Suggest
        txtnombre2.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtnombre2.AutoCompleteCustomSource = autoComp
    End Sub


    'FUNCION LLENAR EL RESTO DE LOS CAMPOS AUTOMATICAMENTE
    Private Sub llenacampos(ByVal Nombreproducto As String)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM PRODUCTO  WHERE NOMBREPRODUCTO LIKE '" & Nombreproducto & "'"

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    'CAMPOS DONDE SE APLICARA LA FUNCION ANTERIOR 
    Private Sub txtnombre2_TextChanged(sender As Object, e As EventArgs) Handles txtnombre2.TextChanged

        If Me.txtnombre2.Text <> "" Then
            llenacampos(Me.txtnombre2.Text)

            If dr.Read Then
                Me.txtidproducto2.Text = dr(0).ToString
                Me.txtcategoria2.Text = dr(1).ToString
                'Me.txtnombre2.Text = dr(2).ToString
                Me.txtstock2.Text = dr(3).ToString
                Me.txtpreciocompra2.Text = dr(4).ToString
                Me.txtpreciominorista2.Text = dr(5).ToString
                Me.txtpreciomayorista2.Text = dr(6).ToString


            Else
                Me.txtidproducto2.Text = ""
                Me.txtcategoria2.Text = ""
                'Me.txtnombre2.Text = ""
                Me.txtstock2.Text = ""
                Me.txtpreciocompra2.Text = ""
                Me.txtpreciominorista2.Text = ""
                Me.txtpreciomayorista2.Text = ""



            End If


        End If
        dr.Close()



    End Sub


    'ACTUALIZACION DE DATOS
    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click

        cmd.Connection = conn

        If (Me.txtidproducto2.Text = "") Then
            MsgBox("el campo no puede estar vacio")
            Me.txtidproducto2.Select()

        Else
            Dim idproducto As Integer
            Dim categoria As String = ""
            Dim nombrep As String = ""
            Dim stock As Integer
            Dim preciocompra As Integer
            Dim precioventa As Integer
            Dim preciomayorista As Integer

            idproducto = Me.txtidproducto2.Text
            categoria = Me.txtcategoria2.Text
            nombrep = Me.txtnombre2.Text
            stock = Me.txtstock2.Text
            preciocompra = Me.txtpreciocompra2.Text
            precioventa = Me.txtpreciominorista2.Text
            preciomayorista = Me.txtpreciomayorista2.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            Sql = "UPDATE PRODUCTO SET"
            Sql += " idCategoria = '" & categoria & "',"
            Sql += " NombreProducto = '" & nombrep & "',"
            Sql += " Stock = " & stock & ","
            Sql += " PrecioCompra = " & preciocompra & ", "
            Sql += " PrecioVenta = " & precioventa & ", "
            Sql += " PrecioMayorista = " & preciomayorista & " "
            Sql += " where idProducto = " & idproducto & " "

            cmd.CommandText = Sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro actualizado")
                Me.txtidproducto2.Text = ""
                Me.txtcategoria2.Text = ""
                Me.txtnombre2.Text = ""
                Me.txtstock2.Text = ""
                Me.txtpreciocompra2.Text = ""
                Me.txtpreciominorista2.Text = ""
                Me.txtpreciomayorista2.Text = ""



            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try


        End If



    End Sub


    'SECCION ELIMINAR- PESTAÑA 3 ----------------------------------------


    'AUTOCOMPLETAR
    Private Sub AutoCompleteBorrar()
        Sql = "SELECT idproducto FROM Producto"
        command = New OleDbCommand(Sql, conn)
        reader = command.ExecuteReader()
        Dim autoComp As New AutoCompleteStringCollection()
        While reader.Read()
            autoComp.Add(reader("idProducto"))
        End While
        reader.Close()
        txtidproducto3.AutoCompleteMode = AutoCompleteMode.Suggest
        txtidproducto3.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtidproducto3.AutoCompleteCustomSource = autoComp
    End Sub


    'FUNCION PARA LLENAR ELRESTO DE LOS CAMPOS AUTOMaTICAMENTE
    Private Sub llenacamposborrar(ByVal idproducto As String)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM PRODUCTO  WHERE idPRODUCTO LIKE " & idproducto & ""

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    'CAMPO QUE SE VA LLENAR AUTOMATICAMENTE AL INGRESAR EL ID
    Private Sub txtidproducto3_TextChanged(sender As Object, e As EventArgs) Handles txtidproducto3.TextChanged

        If Me.txtidproducto3.Text <> "" Then
            llenacamposborrar(Me.txtidproducto3.Text)

            If dr.Read Then
                Me.txtnombre3.Text = dr(2).ToString
                'Me.txtnombre2.Text = dr(2).ToString



            Else
                Me.txtnombre3.Text = ""
                'Me.txtnombre2.Text = ""




            End If


        End If
        dr.Close()



    End Sub


    'BORRAR PRODUCTOS DE LA BD 
    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click



        Dim idproducto As Integer
        idproducto = Me.txtidproducto3.Text


        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        Sql = " DELETE FROM PRODUCTO WHERE idProducto = " & idproducto & " "

        cmd.CommandText = Sql

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Registro eliminado")

            Me.txtidproducto3.Text = ""
            Me.txtnombre3.Text = ""

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Sub






    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    
    
    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtnombrep_TextChanged(sender As Object, e As EventArgs) Handles txtnombrep.TextChanged

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub
End Class