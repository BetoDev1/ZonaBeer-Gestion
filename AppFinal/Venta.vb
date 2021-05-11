Imports System.Data.OleDb

Public Class Venta
    Private con As New OleDb.OleDbConnection
    Private command As OleDb.OleDbCommand
    Private adapter As OleDbDataAdapter
    Private reader As OleDbDataReader
    Private dataSt As DataSet
    Private sql As String

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Nombre del vendedor, segun quien inició sesión
        Me.txtvendedor.Text = LOGIN.TextBox1.Text


        Dim strCon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\App.accdb"
        With con
            If .State = ConnectionState.Closed Then
                .ConnectionString = strCon
                .Open()
            End If
        End With
       
        AutoComplete()
        Autocomplete2()

    End Sub

    'AUTOCOMPLETAR POR NOMBRE
    Private Sub AutoComplete()
        sql = "SELECT nombreproducto FROM Producto"
        command = New OleDbCommand(sql, con)
        reader = command.ExecuteReader()
        Dim autoComp As New AutoCompleteStringCollection()
        While reader.Read()
            autoComp.Add(reader("nombreproducto"))
        End While
        reader.Close()
        txtdetalle.AutoCompleteMode = AutoCompleteMode.Suggest
        txtdetalle.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtdetalle.AutoCompleteCustomSource = autoComp
    End Sub


    'AUTOCOMPLETAR POR ID
    Private Sub AutoComplete2()
        sql = "SELECT idproducto FROM Producto"
        command = New OleDbCommand(sql, con)
        reader = command.ExecuteReader()
        Dim autoComp As New AutoCompleteStringCollection()
        While reader.Read()
            autoComp.Add(reader("idproducto"))
        End While
        reader.Close()
        txtidproductov.AutoCompleteMode = AutoCompleteMode.Suggest
        txtidproductov.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtidproductov.AutoCompleteCustomSource = autoComp
    End Sub




    '-AUTOCOMPLETAR LOS DEMAS CAMPOS SEGUN NOMBRE
    Private Sub llenaprecio(ByVal Nombreproducto As String)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM PRODUCTO  WHERE NOMBREPRODUCTO LIKE '" & Nombreproducto & "'"

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub


    '-AUTOCOMPLETAR LOS DEMAS CAMPOS SEGUN ID 
    Private Sub llenaprecio2(ByVal idProducto As String)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM PRODUCTO  WHERE idPRODUCTO LIKE '" & idProducto & "'"

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub


    'CAMPOS DONDE SE APLICARA LA FUNCION ANTERIOR
    Private Sub txtdetalle_TextChanged(sender As Object, e As EventArgs) Handles txtdetalle.TextChanged

        If Me.txtdetalle.Text <> "" Then
            llenaprecio(Me.txtdetalle.Text)

            If dr.Read Then
                Me.txtidproductov.Text = dr(0).ToString
                Me.txtdetalle.Text = dr(2).ToString
                Me.txtstockv.Text = dr(3).ToString
                Me.txtpreciounitario.Text = dr(5).ToString


            Else
                Me.txtidproductov.Text = ""
                Me.txtpreciounitario.Text = ""


            End If


        End If
        dr.Close()

    End Sub

    'CAMPOS DONDE SE APLICARA LA FUNCION ANTERIOR
    'Private Sub txtidproductov_TextChanged(sender As Object, e As EventArgs) Handles txtidproductov.TextChanged

    '    If Me.txtidproductov.Text <> "" Then
    '        llenaprecio2(Me.txtidproductov.Text)

    '        If dr.Read Then
    '            'Me.txtidproductov.Text = dr(0).ToString
    '            Me.txtdetalle.Text = dr(2).ToString
    '            Me.txtpreciounitario.Text = dr(5).ToString


    '        Else
    '            Me.txtdetalle.Text = ""
    '            Me.txtpreciounitario.Text = ""


    '        End If


    '    End If
    '    dr.Close()

    'End Sub


    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        cmd.Connection = conn

        'PRIMERO COMPRUEBA STOCK

        Dim cantidadv As Double
        Dim stock As Double

        cantidadv = Me.txtcantidadv.Text
        stock = Me.txtstockv.Text

        If cantidadv > stock Then
            MsgBox("Stock Insuficiente")

        Else

            'AGREGA PRODUCTOS AL DATA GRID VIEW
            listaventa.Rows.Add(txtdetalle.Text, txtcantidadv.Text, txtpreciounitario.Text, txtpreciototal.Text)


            'RESTANDO STOCK

            Dim idproducto As Integer

            idproducto = Me.txtidproductov.Text

            If (Me.txtidproductov.Text = "''") Then
                MsgBox("el campo no puede estar vacio")
                Me.txtidproductov.Select()

            Else

                cmd.CommandType = CommandType.Text
                cmd.Connection = conn


                sql = "UPDATE PRODUCTO SET"
                sql += " Stock = stock - " & txtcantidadv.Text & ""
                sql += " where idProducto = " & idproducto & " "

                cmd.CommandText = sql

                Try
                    cmd.ExecuteNonQuery()


                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try

            End If

            Me.txtdetalle.Text = ""
            Me.txtcantidadv.Text = ""
            Me.txtpreciototal.Text = ""
            Me.txtidproductov.Text = ""
            Me.txtpreciounitario.Text = ""

            'SUMA DE PRECIOS DEL DATA GRID
            Dim Total As Single
            Dim Col As Integer = 3
            For Each row As DataGridViewRow In Me.listaventa.Rows
                Total += Val(row.Cells(Col).Value)
            Next
            Me.txtsubtotal.Text = Total.ToString
            txttotal.Text = Me.txtsubtotal.Text

            'que nada este seleccionado
            listaventa.ClearSelection()


        End If


    End Sub



    'CALCULO de CANTIDAD x PRECIO
    Private Sub txtcantidadv_TextChanged(sender As Object, e As EventArgs) Handles txtcantidadv.TextChanged

        If txtcantidadv.Text <> "" Then


            Dim t1 As Double = txtcantidadv.Text
            Dim t2 As Double = txtpreciounitario.Text

            txtpreciototal.Text = t1 * t2

        End If

    End Sub

    'APLICAR RECARGO TARJETA 
    Private Sub tarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles tarjeta.CheckedChanged
        Dim recargo As Double

        recargo = Val(txtsubtotal.Text) * 10 / 100

        If tarjeta.Checked = True Then
            recargo = txtsubtotal.Text + recargo
            txttotal.Text = recargo

        Else
            txttotal.Text = Val(txtsubtotal.Text)
        End If

       

    End Sub

    'APLICAR RECARGO HORARIO NO COMERCIAL
    Private Sub radiono_CheckedChanged(sender As Object, e As EventArgs) Handles radiono.CheckedChanged
        'Dim recargo2 As Double

        ''recargo2 = Val(txttotal.Text) * 10 / 100

        If radiono.Checked = True Then
            txttotal.Text = Val(txttotal.Text) + 50
            'txttotal.Text = recargo2

        Else
            txttotal.Text = Val(txtsubtotal.Text)
        End If
    End Sub

    'COMPROBANTE
    Private Sub Comprobante_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Comprobante.PrintPage
        Dim prFont As New Font("Arial", 20, FontStyle.Bold)

        e.Graphics.DrawString("ZONA BEER", prFont, Brushes.Black, 50, 120)
        prFont = New Font("Consolas", 11, FontStyle.Regular)
        e.Graphics.DrawString(Date.Now.ToShortDateString.ToString & " " & Date.Now.ToShortTimeString.ToString, prFont, Brushes.Black, 50, 155)
        prFont = New Font("Consolas", 11, FontStyle.Regular)
        e.Graphics.DrawString("CUIT Nº 20-5678912-3", prFont, Brushes.Black, 50, 170)
        prFont = New Font("Consolas", 11, FontStyle.Regular)
        e.Graphics.DrawString("ING.BR: 10234545-1", prFont, Brushes.Black, 50, 185)
        prFont = New Font("Consolas", 11, FontStyle.Regular)
        e.Graphics.DrawString("Misiones 444 - Formosa", prFont, Brushes.Black, 50, 200)

        prFont = New Font("Consolas", 11, FontStyle.Regular)
        e.Graphics.DrawString("Pedido Nº 435", prFont, Brushes.Black, 50, 250)

      
        prFont = New Font("Consolas", 12, FontStyle.Regular)
        e.Graphics.DrawString("Articulos Varios" & "  $" & txtsubtotal.Text, prFont, Brushes.Black, 50, 300)
        prFont = New Font("Consolas", 14, FontStyle.Regular)
        e.Graphics.DrawString("        Total $" & " " & txtsubtotal.Text, prFont, Brushes.Black, 50, 330)

        prFont = New Font("Consolas", 11, FontStyle.Regular)
        e.Graphics.DrawString("IVA RESPONSABLE INSCRIPTO", prFont, Brushes.Black, 50, 390)
        prFont = New Font("Consolas", 11, FontStyle.Regular)
        e.Graphics.DrawString("A CONSUMIDOR FINAL", prFont, Brushes.Black, 50, 405)
        prFont = New Font("Segoe Print", 12, FontStyle.Regular)
        e.Graphics.DrawString("Gracias por su compra!", prFont, Brushes.Black, 50, 430)
        'indicamos que hemos llegado al final de la pagina
        e.HasMorePages = False
    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        Comprobante.Print()

    End Sub

    
    'REGISTRANDO VENTA EN EL HISTORIAL
    Private Sub btnfinalizar_Click(sender As Object, e As EventArgs) Handles btnfinalizar.Click


        Dim vendedor As String = ""
        Dim importe As Double
        'Dim fecha As Integer

        vendedor = Me.txtvendedor.Text
        importe = Me.txttotal.Text
        'fecha = Me.txtsubtotal.Text



        sql = "INSERT INTO ventas (vendedor, importe)"
        sql += " VALUES ('" & vendedor & "' ," & importe & ")"

        MsgBox("Venta Realizada")

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

        txtdetalle.Text = ""
        txtcantidadv.Text = ""
        txtpreciototal.Text = ""
        txtstockv.Text = ""
        txtidproductov.Text = ""
        txtpreciounitario.Text = ""
        listaventa.Rows.Clear()
    End Sub


    Private Sub btneliminarv_Click(sender As Object, e As EventArgs) Handles btneliminarv.Click

        'DEVOLUCION DE PRODUCTO
        listaventa.Rows.RemoveAt(listaventa.CurrentRow.Index)

    End Sub
    
    'CHAU NOS VEMOS
    Private Sub btnvolver2_Click(sender As Object, e As EventArgs) Handles btnvolver2.Click
        Me.Close()
        index.Show()

    End Sub

   
 

    
End Class






