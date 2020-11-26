Imports System.Data.SqlClient

Public Class FrmVenta
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Ferreteria;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim subtotal
    Dim Total = 0

    Private Sub FrmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "Select nombre From Cliente"
        lector = comando.ExecuteReader()
        While lector.Read()
            cboClientes.Items.Add(lector(0))
        End While
        lector.Close()

        comando = conexion.CreateCommand
        comando.CommandText = "Select Descripcion From Productos"
        lector = comando.ExecuteReader()
        While lector.Read()
            cboProducto.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim descuento = txtDescuento.Text
        Dim IVA, Total As Double
        If CheckBox1.Checked Then
            txtSubtotal.Text = CInt(txtSubtotal.Text) - CInt(descuento)
        Else
            txtSubtotal.Text = CInt(txtSubtotal.Text) + CInt(descuento)
        End If
        IVA = CInt(txtSubtotal.Text) * 0.16
        Total = CInt(txtSubtotal.Text) + IVA
        txtIVA.Text = IVA
        txtTotal.Text = Total
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cboProducto.Enabled = True
        cboClientes.Enabled = True
        btnAceptar.Enabled = True
        btnQuitar.Enabled = True
        txtCantidad.Enabled = True
        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnQuitar.Enabled = True
        CheckBox1.Enabled = True
        btnAceptar.Enabled = True

        comando.CommandText = "Select count(*) From Venta"
        txtidVenta.Text = CStr(comando.ExecuteScalar())
    End Sub

    Private Sub cboClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClientes.SelectedIndexChanged
        comando.CommandText = "Select * From Cliente where Nombre='" & cboClientes.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtIdCliente.Text = lector("id")
        txtDomicilio.Text = lector("domicilio")
        txtCiudad.Text = lector("ciudad")
        txtCP.Text = lector("CodigoPostal")
        txtRFC.Text = lector("rfc")
        lector.Close()
    End Sub

    Private Sub cboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProducto.SelectedIndexChanged
        comando.CommandText = "Select * From Productos As P inner join Categoria As C on P.idCategoria = C.id WHERE P.Descripcion='" & cboProducto.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtCodigo.Text = lector("id")
        txtExistencia.Text = lector("Existencias")
        txtPrecio.Text = lector("precioVenta")
        lector.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        txtDescuento.Enabled = True
        CheckBox1.Enabled = True


        Dim importe = CDbl(txtPrecio.Text) * CDbl(txtCantidad.Text)
        subtotal = Total + importe
        Dim IVA = subtotal * 0.16
        Total = subtotal + IVA
        txtSubtotal.Text = +subtotal
        txtIVA.Text = +IVA
        txtTotal.Text = +Total


        DgVenta.Rows.Add(txtCodigo.Text, cboProducto.Text, txtPrecio.Text, txtCantidad.Text, importe)
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Dim x As Double
        x = CDbl(DgVenta.CurrentRow.Cells(4).Value)

        subtotal = CInt(txtSubtotal.Text) - x
        Dim IVA = subtotal * 0.16
        Total = subtotal + IVA
        txtSubtotal.Text = subtotal
        txtIVA.Text = IVA
        txtTotal.Text = Total

        DgVenta.Rows.Remove(DgVenta.CurrentRow)
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Verificacion() Then
            Dim descuento = txtDescuento.Text
            If CheckBox1.Checked <> True Then
                descuento = 0
                txtDescuento.Text = 0
            End If
            btnGrabar.Enabled = False
            btnNuevo.Enabled = True
            Dim Fecha As String
            Dim c1 As String
            Dim c2, c3 As Double
            Fecha = DTP.Value.Day & "/" & DTP.Value.Month & "/" & DTP.Value.Year
            comando.CommandText = "insert into Venta(idCliente,Fecha,subTotal,descuento,iva,total,status) values(" & (CInt(txtIdCliente.Text)) & ",'" & Fecha & "'," & (CDbl(txtSubtotal.Text)) & "," & (CDbl(descuento)) & "," & (CDbl(txtIVA.Text)) & "," & (CDbl(txtTotal.Text)) & ", 0 )"
            comando.ExecuteNonQuery()
            For i = 0 To DgVenta.Rows.Count - 2
                c1 = DgVenta.Item(0, i).Value
                c2 = Val(DgVenta.Item(3, i).Value)
                c3 = CDbl(DgVenta.Item(2, i).Value)
                comando.CommandText = "insert into DetallesVenta values(" & Val(txtidVenta.Text) & ",'" & c1 & "'," & c2 & "," & c3 & ")"
                comando.ExecuteNonQuery()

                comando.CommandText = "Update Productos SET Existencias=Existencias-" & c2 & " WHERE id='" & c1 & "'"
                comando.ExecuteNonQuery()
            Next
            limpiando()
        Else
            MsgBox("Favor de llenar todos los campos")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub limpiando()
        txtIdCliente.Text = ""
        txtRFC.Text = ""
        txtDomicilio.Text = ""
        txtCP.Text = ""
        txtCiudad.Text = ""
        txtCodigo.Text = ""
        txtPrecio.Text = ""
        txtExistencia.Text = ""
        txtCantidad.Text = 0
        txtDescuento.Text = 0
        txtSubtotal.Text = 0
        txtTotal.Text = 0
        txtIVA.Text = 0
        cboClientes.Enabled = False
        cboProducto.Enabled = False
        btnQuitar.Enabled = False
        btnAceptar.Enabled = False
        CheckBox1.Enabled = False
    End Sub
    Private Function Verificacion() As Boolean
        Return Not (String.IsNullOrEmpty(cboClientes.Text)) And Not (String.IsNullOrEmpty(cboProducto.Text)) And Not (String.IsNullOrEmpty(txtCantidad.Text)) And Not (String.IsNullOrEmpty(txtDescuento.Text))
    End Function

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        Try
            If CInt(txtExistencia.Text) - CInt(txtCantidad.Text) < 1 Then
                MessageBox.Show("La cantidad no puede superar la existencia", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCantidad.Focus()
                txtCantidad.SelectAll()
            End If
        Catch ex As Exception

        End Try

    End Sub


End Class