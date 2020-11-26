Imports System.Data.SqlClient
Public Class FrmDevoluciones

    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Ferreteria;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim comando2 As New SqlCommand
    Dim lector2 As SqlDataReader
    Private Sub FrmDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando2 = conexion.CreateCommand
        comando.CommandText = "Select nombre From Cliente"
        lector = comando.ExecuteReader()
        While lector.Read()
            cboCliente.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged
        dgVentas.Rows.Clear()
        comando.CommandText = "Select * From Cliente where nombre='" & cboCliente.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtidCliente.Text = lector("id")
        txtDireccion.Text = lector("domicilio")
        txtCiudad.Text = lector("ciudad")
        txtEmail.Text = lector("email")
        lector.Close()

        comando.CommandText = "Select * from Venta where idCliente=" & txtidCliente.Text & " and status=0"
        lector = comando.ExecuteReader()
        While lector.Read()
            dgVentas.Rows.Add(lector(0), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While

        lector.Close()

        comando.CommandText = "Select * from Venta where idCliente=" & txtidCliente.Text & " and status=0"
        lector = comando.ExecuteReader()
        While lector.Read()
            cboVenta.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim FechaVenta As String

        FechaVenta = DTPdevolucion.Value.Day & "/" & DTPdevolucion.Value.Month & "/" & DTPdevolucion.Value.Year
        comando.CommandText = "insert into Devoluciones(idVenta,fecha,motivo) values(" & cboVenta.Text & ",'" & FechaVenta & "','" & txtMotivo.Text & "' )"
        comando.ExecuteNonQuery()


        comando.CommandText = "Update Venta SET status=1  WHERE id=" & cboVenta.Text & ""
        comando.ExecuteNonQuery()

        comando2.CommandText = "Select * from DetallesVenta where id=" & cboVenta.Text & ""
        lector2 = comando2.ExecuteReader()
        While lector2.Read()
            comando.CommandText = "Update Productos SET cantidad=+" & lector(2) & "  WHERE id=" & lector(1) & ""
            comando.ExecuteNonQuery()
        End While

    End Sub
End Class