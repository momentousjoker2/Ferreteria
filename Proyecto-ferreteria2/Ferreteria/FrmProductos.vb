Public Class FrmProductos
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlDataAdapter1.Fill(DataSet11.Productos)
        SqlDataAdapter2.Fill(DataSet11.Categoria)
        cboUnidadM.Items.Add("Pieza")
        cboUnidadM.Items.Add("Metros")
        cboUnidadM.Items.Add("Litros")
        cboUnidadM.Items.Add("Kilos")
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        ProductosBindingSource.MoveFirst()

    End Sub

    Private Sub btnAnteriror_Click(sender As Object, e As EventArgs) Handles btnAnteriror.Click
        ProductosBindingSource.MovePrevious()
    End Sub

    Private Sub btnSigueinte_Click(sender As Object, e As EventArgs) Handles btnSigueinte.Click
        ProductosBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        ProductosBindingSource.MoveLast()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtId.Enabled = True
        txtDescripcion.Enabled = True
        txtExistencia.Enabled = True
        txtPrecioC.Enabled = True
        txtPrecioV.Enabled = True
        txtCantidadMi.Enabled = True
        txtCantidadMa.Enabled = True
        cboCategoria.Enabled = True
        cboUnidadM.Enabled = True

        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnModificar.Enabled = False

        btnUltimo.Enabled = False
        btnSigueinte.Enabled = False
        btnAnteriror.Enabled = False
        btnInicio.Enabled = False

        ProductosBindingSource.AddNew()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Verificacion() Then
            ProductosBindingSource.Current("idCategoria") = cboCategoria.SelectedValue
            ProductosBindingSource.Current("unidadMedida") = cboUnidadM.Text
            ProductosBindingSource.EndEdit()
            txtId.Enabled = False
            txtDescripcion.Enabled = False
            txtExistencia.Enabled = False
            txtPrecioC.Enabled = False
            txtPrecioV.Enabled = False
            txtCantidadMi.Enabled = False
            txtCantidadMa.Enabled = False
            cboCategoria.Enabled = False
            cboUnidadM.Enabled = False

            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnModificar.Enabled = True

            btnUltimo.Enabled = True
            btnSigueinte.Enabled = True
            btnAnteriror.Enabled = True
            btnInicio.Enabled = True


            Try
                SqlDataAdapter1.Update(DataSet11.Productos)
            Catch
                MsgBox("Ocurrio un error: " & Err.Description)

            End Try
        Else
            MsgBox("Favor de llenar todos los campos")
        End If
    End Sub
    Private Function Verificacion() As Boolean

        Return (Not (String.IsNullOrEmpty(txtId.Text)) And Not (String.IsNullOrEmpty(txtDescripcion.Text)) And Not (String.IsNullOrEmpty(txtExistencia.Text)) And Not (String.IsNullOrEmpty(txtPrecioC.Text)) And Not (String.IsNullOrEmpty(txtPrecioV.Text)) And Not (String.IsNullOrEmpty(txtCantidadMi.Text)) And Not (String.IsNullOrEmpty(txtCantidadMa.Text)) And Not (String.IsNullOrEmpty(cboCategoria.Text)) And Not (String.IsNullOrEmpty(cboUnidadM.Text)))

    End Function
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtId.Enabled = True
        txtDescripcion.Enabled = True
        txtExistencia.Enabled = True
        txtPrecioC.Enabled = True
        txtPrecioV.Enabled = True
        txtCantidadMi.Enabled = True
        txtCantidadMa.Enabled = True
        cboCategoria.Enabled = True
        cboUnidadM.Enabled = True

        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnModificar.Enabled = False

        btnUltimo.Enabled = False
        btnSigueinte.Enabled = False
        btnAnteriror.Enabled = False
        btnInicio.Enabled = False

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub txtExistencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExistencia.KeyPress
        If Not String.IsNullOrEmpty(txtExistencia.Text) Then
            If CInt(txtExistencia.Text) < CInt(txtCantidadMi.Text) Or CInt(txtExistencia.Text) > CInt(txtCantidadMa.Text) Then
                MessageBox.Show("La existencia tiene que ser mayor que la cantidad minima y menor que la cantidad maxima", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtExistencia.Focus()
                txtExistencia.SelectAll()
            End If
        End If
    End Sub
End Class