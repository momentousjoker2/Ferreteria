Imports System.Data.SqlClient

Public Class FrmCompras
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Ferreteria;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim nFactura
    Private Sub FrmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "Select nombre From Proveedor"
        lector = comando.ExecuteReader()
        While lector.Read()
            cboProvedor.Items.Add(lector(0))
        End While
        lector.Close()

        comando = conexion.CreateCommand
        comando.CommandText = "Select Descripcion From Productos"
        lector = comando.ExecuteReader()
        While lector.Read()
            cboProducto.Items.Add(lector(0))
        End While
        lector.Close()
        cboTipoP.Items.Add("Credito")
        cboTipoP.Items.Add("Contado")
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cboProducto.Enabled = True
        cboProvedor.Enabled = True
        btnAceptar.Enabled = True
        btnQuitar.Enabled = True
        txtCantidad.Enabled = True
        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnQuitar.Enabled = True
        ckbDescuento.Enabled = True
        btnAceptar.Enabled = True
        DTPCompra.Enabled = True
        DTPCompraVen.Enabled = True
        cboTipoP.Enabled = True
        ckbFactura.Enabled = True
        cboTipoP.SelectedIndex = 0
        comando.CommandText = "Select count(*) From Compras"
        txtidCompra.Text = CStr(comando.ExecuteScalar())
        If txtidCompra.Text >= 1 Then
            comando = conexion.CreateCommand
            comando.CommandText = "Select max(factura) From Compras"
            nFactura = CStr(comando.ExecuteScalar())
        Else
            nFactura = 0
        End If

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim descuento = txtDescuento.Text
        If ckbDescuento.Checked <> True Then
            descuento = 0
        End If
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        Dim FechaCompra As String
        Dim fechaVencimeinto As String
        Dim c1 As String
        Dim c2, c3 As Double
        Dim c4 As Double
        FechaCompra = DTPCompra.Value.Day & "/" & DTPCompra.Value.Month & "/" & DTPCompra.Value.Year
        fechaVencimeinto = DTPCompraVen.Value.Day & "/" & DTPCompraVen.Value.Month & "/" & DTPCompraVen.Value.Year
        If cboTipoP.Text = "Credito" Then
            c4 = txtTotal.Text
            comando.CommandText = "Update Proveedor SET saldo=saldo+" & c4 & " WHERE id='" & txtIdProvedor.Text & "'"
            comando.ExecuteNonQuery()
        Else
            c4 = 0
        End If
        comando.CommandText = "insert into Compras(idProvedor,factura,fecha,fechaVencimiento,subTotal,descuento,iva,total,saldoFactura) values(" & (CInt(txtIdProvedor.Text)) & "," & txtFactura.Text & "," & "'" & FechaCompra & "', '" & fechaVencimeinto & "'," & (CDbl(txtSubtotal.Text)) & "," & (CDbl(descuento)) & "," & (CDbl(txtIVA.Text)) & "," & (CDbl(txtTotal.Text)) & ", " & c4 & " )"
        comando.ExecuteNonQuery()
        For i = 0 To DgVenta.Rows.Count - 2
            c1 = DgVenta.Item(0, i).Value
            c2 = Val(DgVenta.Item(3, i).Value)
            c3 = CDbl(DgVenta.Item(2, i).Value)
            comando.CommandText = "insert into DetallesCompra values(" & Val(txtidCompra.Text) + 1 & ",'" & c1 & "'," & c2 & "," & c3 & ")"
            comando.ExecuteNonQuery()

            comando.CommandText = "Update Productos SET Existencias=Existencias+" & c2 & " WHERE id='" & c1 & "'"
            comando.ExecuteNonQuery()
        Next


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        txtDescuento.Enabled = True
        ckbDescuento.Enabled = True

        Dim Total = 0
        Dim importe = CDbl(txtPrecio.Text) * CDbl(txtCantidad.Text)
        Dim subtotal = Total + importe
        Dim IVA = subtotal * 0.16
        Total = subtotal + IVA
        txtSubtotal.Text = txtSubtotal.Text + subtotal
        txtIVA.Text = txtIVA.Text + IVA
        txtTotal.Text = txtTotal.Text + Total

        DgVenta.Rows.Add(txtCodigo.Text, cboProducto.Text, txtPrecio.Text, txtCantidad.Text, importe)
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Dim x, Total As Double
        x = CDbl(DgVenta.CurrentRow.Cells(4).Value)

        Dim subtotal = CInt(txtSubtotal.Text) - x
        Dim IVA = subtotal * 0.16
        Total = subtotal + IVA
        txtSubtotal.Text = subtotal
        txtIVA.Text = IVA
        txtTotal.Text = Total


        DgVenta.Rows.Remove(DgVenta.CurrentRow)
    End Sub

    Private Sub cboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProducto.SelectedIndexChanged
        comando.CommandText = "Select * From Productos As P inner join Categoria As C on P.idCategoria = C.id WHERE P.Descripcion='" & cboProducto.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtCodigo.Text = lector("id")
        txtExistencia.Text = lector("Existencias")
        txtPrecio.Text = lector("precioCompra")
        lector.Close()


    End Sub

    Private Sub cboProvedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvedor.SelectedIndexChanged
        comando.CommandText = "Select * From Proveedor where nombre='" & cboProvedor.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtIdProvedor.Text = lector("id")
        txtDomicilio.Text = lector("Domicilio")
        txtCiudad.Text = lector("Ciudad")
        txtCP.Text = lector("codigoPostal")
        txtsaldoFacura.Text = lector("saldo")
        lector.Close()
    End Sub

    Private Sub ckbDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles ckbDescuento.CheckedChanged
        Dim descuento = txtDescuento.Text
        Dim IVA, Total As Double
        If ckbDescuento.Checked Then
            txtSubtotal.Text = CInt(txtSubtotal.Text) - CInt(descuento)
        Else
            txtSubtotal.Text = CInt(txtSubtotal.Text) + CInt(descuento)
        End If
        IVA = CInt(txtSubtotal.Text) * 0.16
        Total = CInt(txtSubtotal.Text) + IVA
        txtIVA.Text = IVA
        txtTotal.Text = Total
    End Sub

    Private Sub ckbFactura_CheckedChanged(sender As Object, e As EventArgs) Handles ckbFactura.CheckedChanged
        txtFactura.Text = nFactura
        If ckbFactura.Checked Then
            txtFactura.Text = nFactura + 1
        Else
            txtFactura.Text = 0
        End If
    End Sub
End Class