Imports System.Data.SqlClient

Public Class frmPagos
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Ferreteria;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub Pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "Select nombre From Proveedor"
        lector = comando.ExecuteReader()
        While lector.Read()
            cboProveedor.Items.Add(lector(0))
        End While
        lector.Close()

    End Sub

    Private Sub cboProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedor.SelectedIndexChanged
        comando.CommandText = "Select * From Proveedor where Nombre='" & cboProveedor.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtidProveedor.Text = lector("id")
        txtDireccion.Text = lector("domicilio")
        txtCiudad.Text = lector("ciudad")
        txtContacto.Text = lector("contacto")
        lector.Close()

        comando.CommandText = "Select * from Compras where idProvedor=" & txtidProveedor.Text & " and saldoFactura > 0"
        lector = comando.ExecuteReader()
        While lector.Read()
            dgCompras.Rows.Add(lector(0), lector(3), lector(6), lector(7), lector(8), lector(10))
        End While

        lector.Close()

        comando.CommandText = "Select * from Compras where idProvedor=" & txtidProveedor.Text & " and saldoFactura > 0"
        lector = comando.ExecuteReader()
        While lector.Read()
            cboCompra.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim FechaCompra As String
        ''Aqui se tiene que crear un comentario
        ''Aqui se tiene que limpiar los cambios y crar una verificaicon decente 

        FechaCompra = DTPpago.Value.Day & "/" & DTPpago.Value.Month & "/" & DTPpago.Value.Year
        comando.CommandText = "insert into pagos(idCompra,fecha,importe) values(" & cboCompra.Text & ",'" & FechaCompra & "'," & CInt(txtCantidad.Text) & " )"
        comando.ExecuteNonQuery()

        comando.CommandText = "Update Proveedor SET saldo=saldo-" & CInt(txtCantidad.Text) & " WHERE id='" & txtidProveedor.Text & "'"
        comando.ExecuteNonQuery()

        comando.CommandText = "Update Compras SET saldoFactura=saldoFactura-" & CInt(txtCantidad.Text) & " WHERE id='" & cboCompra.Text & "'"
        comando.ExecuteNonQuery()

    End Sub
End Class