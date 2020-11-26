Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Public Class frmReporteCatalagos
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Ferreteria;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim edo = cmbCategoria.SelectedValue.ToString
        If (FrmMenu.Opcion = 1) Then
            conexion.Open()
            Dim Adaptador As New SqlDataAdapter
            Adaptador.SelectCommand = New SqlCommand
            Adaptador.SelectCommand.Connection = conexion
            Adaptador.SelectCommand.CommandText = "CategoriasReporteP"
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@ID", SqlDbType.Int)
            param1.Direction = ParameterDirection.Input
            param1.Value = edo
            Adaptador.SelectCommand.Parameters.Add(param1)
            Dim Data As New DataSet
            Adaptador.Fill(Data)
            Data.DataSetName = "Data1"
            Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
            Datasource.Name = "DataSet1"
            Datasource.Value = Data.Tables(0)
            Dim p1 As New ReportParameter("ID", edo)
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "D:\Proyecto-ferreteria\Ferreteria\ReportePrecio.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.Show()
            conexion.Close()
        Else
            conexion.Open()
            Dim Adaptador As New SqlDataAdapter
            Adaptador.SelectCommand = New SqlCommand
            Adaptador.SelectCommand.Connection = conexion
            Adaptador.SelectCommand.CommandText = "CategoriasReporteI"
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@ID", SqlDbType.Int)
            param1.Direction = ParameterDirection.Input
            param1.Value = edo
            Adaptador.SelectCommand.Parameters.Add(param1)
            Dim Data As New DataSet
            Adaptador.Fill(Data)
            Data.DataSetName = "Data1"
            Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
            Datasource.Name = "DataSet1"
            Datasource.Value = Data.Tables(0)
            Dim p1 As New ReportParameter("ID", edo)
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Proyecto-ferreteria\Ferreteria\ReporteExistencias.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.Show()
            conexion.Close()
        End If
    End Sub

    Private Sub frmReportePrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlDataAdapter1.Fill(DataSet11.Categoria)

    End Sub
End Class