Imports System.Data.SqlClient

Public Class frmCXP
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Ferreteria;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub frmComprasConsultaGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "Select nombre from Provedor"
        lector = comando.ExecuteReader
        While lector.Read
            cbProvedor.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub cbProvedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProvedor.SelectedIndexChanged
        dgCompras.Rows.Clear()
        comando.CommandText = "Select * from Provedor where nombre='" & cbProvedor.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdProvedor.Text = lector(0)
        txtDomicilio.Text = lector(2)
        txtCp.Text = lector(4)
        txtTelefono.Text = lector(6)
        txtSaldo.Text = lector(9)
        lector.Close()

        comando.CommandText = "Select * from Compras where idProvedor=" & txtIdProvedor.Text & ""
        lector = comando.ExecuteReader()
        Dim total = 0
        While lector.Read()
            dgCompras.Rows.Add(lector(0), lector(3), lector(6), lector(7), lector(8), lector(9))
            total = total + lector(6)
        End While
        txtGT.Text = total
        lector.Close()
    End Sub
    Private Sub dgCompras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCompras.CellContentClick
        Dim total = 0
        dgProductos.Rows.Clear()
        Dim idCompra = dgCompras.CurrentRow.Cells(0).Value

        comando.CommandText = "Select DV.idProducto, P.descripcion, DV.cantidad , DV.precioCompra, (DV.cantidad*DV.precioCompra) as importe From DetallesCompra as DV  inner join Productos as P on DV.idProducto =P.id WHERE DV.id=" & idCompra

        lector = comando.ExecuteReader()
        While lector.Read
            dgProductos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            total = total + lector(4)
        End While
        txtTotal.Text = total
        lector.Close()

    End Sub
End Class