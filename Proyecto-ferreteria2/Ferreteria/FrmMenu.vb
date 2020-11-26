Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Public Class FrmMenu
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Ferreteria;Integrated Security = Yes")
    Public Opcion As Integer = 0
    Public Titulo As String = ""


    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemMProducto.Click
        FrmProductos.Show()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemMCategoria.Click
        frmCategorias.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemMCliente.Click
        FrmClientes.Show()
    End Sub

    Private Sub ProvedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemMProvedor.Click
        FrmProvedor.Show()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemMSubVentas.Click
        FrmVenta.Show()
    End Sub

    Private Sub ConsultaIndividualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemMSubVCIndividual.Click
        FrmVentaConsultaI.Show()
    End Sub

    Private Sub ConsultaGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemMSubVConsultaXCliente.Click
        frmVentasGeneral.Show()
    End Sub

    Private Sub ComprarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemMSubCompras.Click
        FrmCompras.Show()
    End Sub

    Private Sub ConsultaGeneralToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ItemMSubCCXProvedor.Click
        frmCXP.Show()
    End Sub

    Private Sub PagosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem1.Click
        frmPagos.Show()
    End Sub

    Private Sub DevolucionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem1.Click
        FrmDevoluciones.Show()
    End Sub

    Private Sub ListaDePreciosPorCategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDePreciosPorCategoriasToolStripMenuItem.Click
        Opcion = 1
        frmReporteCatalagos.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click


        conexion.Open()
        Dim Cmd As New SqlCommand("ClientesReporte", conexion)
        Cmd.CommandType = CommandType.StoredProcedure
        Dim Adaptador As New SqlDataAdapter(Cmd)
        Dim Data As New Data.DataSet

        Adaptador.Fill(Data)
        Data.DataSetName = "DataSet1"
        Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()

        frmReportes.ReportViewer1.LocalReport.DataSources.Add(Reportes)

        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Proyecto-ferreteria\Ferreteria\ReporteCliente.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.Show()
        conexion.Close()

    End Sub

    Private Sub RelacionProvedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelacionProvedorToolStripMenuItem.Click
        conexion.Open()
        Dim Cmd As New SqlCommand("ProveedoresReportes", conexion)
        Cmd.CommandType = CommandType.StoredProcedure
        Dim Adaptador As New SqlDataAdapter(Cmd)
        Dim Data As New Data.DataSet

        Adaptador.Fill(Data)
        Data.DataSetName = "DataSet1"
        Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
        frmReportes.ReportViewer1.LocalReport.DataSources.Clear()

        frmReportes.ReportViewer1.LocalReport.DataSources.Add(Reportes)

        frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Proyecto-ferreteria\Ferreteria\ReporteProveedores.rdlc"
        frmReportes.ReportViewer1.RefreshReport()
        frmReportes.Show()
        conexion.Close()
    End Sub

    Private Sub InventarioPorCategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioPorCategoriasToolStripMenuItem.Click
        Opcion = 2
        frmReporteCatalagos.Show()

    End Sub

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem1.Click
        Opcion = 3
        Titulo = "Reporte de ventas"
        frmMovimientos.Show()

    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub PagosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem2.Click
        Opcion = 5
        Titulo = "Reporte de Pagos"
        frmMovimientos.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        Opcion = 6
        Titulo = "Reporte de ventas"
        frmMovimientos.Show()

    End Sub

    Private Sub DevolucionesReporte_Click(sender As Object, e As EventArgs) Handles DevolucionesReporte.Click
        Opcion = 4
        Titulo = "Reporte de Devoluciones"
        frmMovimientos.Show()

    End Sub


End Class
