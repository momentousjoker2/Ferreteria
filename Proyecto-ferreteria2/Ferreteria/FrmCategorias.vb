Public Class frmCategorias
    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlDataAdapter1.Fill(DataSet11.Categoria)
        'Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        CategoriaBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnteriror_Click(sender As Object, e As EventArgs) Handles btnAnteriror.Click
        CategoriaBindingSource.MovePrevious()
    End Sub

    Private Sub btnSigueinte_Click(sender As Object, e As EventArgs) Handles btnSigueinte.Click
        CategoriaBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        CategoriaBindingSource.MoveLast()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtDescripcion.Enabled = True

        btnModificar.Enabled = False
        btnNuevo.Enabled = False
        btnGrabar.Enabled = True

        CategoriaBindingSource.AddNew()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txtDescripcion.Text.Length <> 0 Then
            CategoriaBindingSource.EndEdit()
            SqlDataAdapter1.Update(DataSet11.Categoria)
            txtDescripcion.Enabled = False
            btnModificar.Enabled = True
            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
        Else
            MsgBox("Error favor de ingresar todos los datos")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtDescripcion.Enabled = True

        btnModificar.Enabled = False
        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class