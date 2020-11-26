Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Public Class frmMovimientos
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog= Ferreteria;Integrated Security = Yes")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        Dim f1 As String
        Dim f2 As String
        f1 = DTP1.Value.Day & "/" & DTP1.Value.Month & "/" & DTP1.Value.Year



        f2 = DTP2.Value.Day & "/" & DTP2.Value.Month & "/" & DTP2.Value.Year

        If (FrmMenu.Opcion = 3) Then
            conexion.Open()
            Dim Adaptador As New SqlDataAdapter
            Adaptador.SelectCommand = New SqlCommand
            Adaptador.SelectCommand.Connection = conexion
            Adaptador.SelectCommand.CommandText = "VentasReporte"
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@FI", SqlDbType.Date)
            Dim param2 = New SqlParameter("@FF", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)

            Adaptador.SelectCommand.Parameters.Add(param1)
            Adaptador.SelectCommand.Parameters.Add(param2)

            Dim Data As New DataSet
            Adaptador.Fill(Data)
            Data.DataSetName = "Data1"
            Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
            Datasource.Name = "DataSet1"
            Datasource.Value = Data.Tables(0)
            Dim p1 As New ReportParameter("FI", f1)
            Dim p2 As New ReportParameter("FF", f2)

            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Proyecto-ferreteria\Ferreteria\ReporteVentas.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.Show()
            conexion.Close()
        ElseIf (FrmMenu.Opcion = 4) Then
            MsgBox("SI ENTRE")
            conexion.Open()
            Dim Adaptador As New SqlDataAdapter
            Adaptador.SelectCommand = New SqlCommand
            Adaptador.SelectCommand.Connection = conexion
            Adaptador.SelectCommand.CommandText = "PagosReporte"
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@FI", SqlDbType.Date)
            Dim param2 = New SqlParameter("@FF", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)

            Adaptador.SelectCommand.Parameters.Add(param1)
            Adaptador.SelectCommand.Parameters.Add(param2)

            Dim Data As New DataSet
            Adaptador.Fill(Data)
            Data.DataSetName = "Data1"
            Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
            Datasource.Name = "DataSet1"
            Datasource.Value = Data.Tables(0)
            Dim p1 As New ReportParameter("FI", f1)
            Dim p2 As New ReportParameter("FF", f2)

            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Proyecto-ferreteria\Ferreteria\ReportePagos.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.Show()
            conexion.Close()


        ElseIf (FrmMenu.Opcion = 5) Then
            conexion.Open()
            Dim Adaptador As New SqlDataAdapter
            Adaptador.SelectCommand = New SqlCommand
            Adaptador.SelectCommand.Connection = conexion
            Adaptador.SelectCommand.CommandText = "DevolucionesReporte"
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@FI", SqlDbType.Date)
            Dim param2 = New SqlParameter("@FF", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)

            Adaptador.SelectCommand.Parameters.Add(param1)
            Adaptador.SelectCommand.Parameters.Add(param2)

            Dim Data As New DataSet
            Adaptador.Fill(Data)
            Data.DataSetName = "Data1"
            Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
            Datasource.Name = "DataSet1"
            Datasource.Value = Data.Tables(0)
            Dim p1 As New ReportParameter("FI", f1)
            Dim p2 As New ReportParameter("FF", f2)

            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Proyecto-ferreteria\Ferreteria\ReporteDevolucione.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.Show()
            conexion.Close()

        ElseIf (FrmMenu.Opcion = 6) Then
            conexion.Open()
            Dim Adaptador As New SqlDataAdapter
            Adaptador.SelectCommand = New SqlCommand
            Adaptador.SelectCommand.Connection = conexion
            Adaptador.SelectCommand.CommandText = "ComprasReporte"
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@FI", SqlDbType.Date)
            Dim param2 = New SqlParameter("@FF", SqlDbType.Date)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param1.Value = CDate(f1)
            param2.Value = CDate(f2)

            Adaptador.SelectCommand.Parameters.Add(param1)
            Adaptador.SelectCommand.Parameters.Add(param2)

            Dim Data As New DataSet
            Adaptador.Fill(Data)
            Data.DataSetName = "Data1"
            Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
            Datasource.Name = "DataSet1"
            Datasource.Value = Data.Tables(0)
            Dim p1 As New ReportParameter("FI", f1)
            Dim p2 As New ReportParameter("FF", f2)

            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Proyecto-ferreteria\Ferreteria\ReporteCompras.rdlc"
            frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.Show()
            conexion.Close()

        End If



    End Sub

    Private Sub frmMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = FrmMenu.Titulo
    End Sub
End Class