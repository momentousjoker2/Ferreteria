Imports System.Data.SqlClient

Public Class frmVentasGeneral
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Ferreteria;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub frmVentasGeneral1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "Select nombre from Cliente"
        lector = comando.ExecuteReader
        While lector.Read
            cbCliente.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub cbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCliente.SelectedIndexChanged
        dgVentas.Rows.Clear()
        comando.CommandText = "Select * from Cliente where nombre='" & cbCliente.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdCliente.Text = lector(0)
        txtDomicilio.Text = lector(3)
        txtCp.Text = lector(5)
        txtTelefono.Text = lector(7)
        lector.Close()

        comando.CommandText = "Select * from Venta where idCliente=" & txtIdCliente.Text & " and status=1"
        lector = comando.ExecuteReader()
        Dim total = 0
        While lector.Read()
            dgVentas.Rows.Add(lector(0), lector(2), lector(3), lector(4), lector(5), lector(6))
            total = total + lector(6)
        End While
        txtGT.Text = total
        lector.Close()
    End Sub

    Private Sub dgVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVentas.CellContentClick
        Dim total = 0
        dgProductos.Rows.Clear()
        MsgBox(e.RowIndex)
        Dim idVenta = dgVentas.CurrentRow.Cells(0).Value
        comando.CommandText = "Select DV.idProducto, P.descripcion, DV.cantidad , DV.precioVenta, (DV.cantidad*DV.precioVenta) as importe From DetallesVenta as DV  inner join Productos as P on DV.idProducto =P.id WHERE DV.id=" & idVenta
        MsgBox(comando.CommandText)
        lector = comando.ExecuteReader()
        While lector.Read
            dgProductos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            total = total + lector(4)
        End While
        txtTotal.Text = total
        lector.Close()

    End Sub


End Class