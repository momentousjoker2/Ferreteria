Imports System.Data.SqlClient

Public Class FrmVentaConsultaI
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Ferreteria;Integrated Security = Yes")
    Dim comando As New SqlCommand '=conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub FrmVentaReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgVentas.Rows.Clear()
        comando.CommandText = "Select V.fecha,V.idCliente,C.nombre,C.domicilio,C.RFC,C.codigoPostal,C.ciudad,V.subTotal,V.iva,V.total From Venta As V inner join Cliente As C on V.idCliente=C.id WHERE V.id=" & Val(txtFolioV.Text)
        lector = comando.ExecuteReader()

        lector.Read()
        DtpFecha.Text = lector("fecha")
        txtIdCliente.Text = lector("idCliente")
        txtNombre.Text = lector("nombre")
        txtDomicilio.Text = lector("domicilio")
        txtRFC.Text = lector("RFC")
        txtCP.Text = lector("codigoPostal")
        txtCiudad.Text = lector("ciudad")
        txtSubtotal.Text = lector("subTotal")
        txtIVA.Text = lector("iva")
        txtTotal.Text = lector("total")
        lector.Close()
        comando.CommandText = "Select DV.idProducto, P.descripcion, DV.cantidad , DV.precioVenta, (DV.cantidad*DV.precioVenta) as importe From DetallesVenta as DV  inner join Productos as P on DV.idProducto =P.id WHERE DV.id=" & Val(txtFolioV.Text)
        lector = comando.ExecuteReader()
        While lector.Read
            dgVentas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()

    End Sub

End Class