Public Class FrmProvedor
    Private Sub FrmProvedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlDataAdapter1.Fill(DataSet11.Proveedor)
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        ProveedorBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnteriror_Click(sender As Object, e As EventArgs) Handles btnAnteriror.Click
        ProveedorBindingSource.MovePrevious()
    End Sub

    Private Sub btnSigueinte_Click(sender As Object, e As EventArgs) Handles btnSigueinte.Click
        ProveedorBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        ProveedorBindingSource.MoveLast()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtId.Enabled = False
        txtNombre.Enabled = True
        txtCiudad.Enabled = True
        txtContacto.Enabled = True
        txtDomicilio.Enabled = True
        txtColonia.Enabled = True
        txtCP.Enabled = True
        txtCiudad.Enabled = True
        txtTelefono.Enabled = True
        txtEmail.Enabled = True
        'txtSaldo.Enabled = True

        btnNuevo.Enabled = False
        btnGrabar.Enabled = True
        btnModificar.Enabled = False

        btnUltimo.Enabled = False
        btnSigueinte.Enabled = False
        btnAnteriror.Enabled = False
        btnInicio.Enabled = False

        ProveedorBindingSource.AddNew()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Verificacion() Then
            txtId.Enabled = False
            txtNombre.Enabled = False
            txtCiudad.Enabled = False
            txtContacto.Enabled = False
            txtDomicilio.Enabled = False
            txtColonia.Enabled = False
            txtCP.Enabled = False
            txtCiudad.Enabled = False
            txtTelefono.Enabled = False
            txtEmail.Enabled = False
            ' txtSaldo.Enabled = False
            ProveedorBindingSource.EndEdit()

            btnNuevo.Enabled = True
            btnGrabar.Enabled = False
            btnModificar.Enabled = True

            btnUltimo.Enabled = True
            btnSigueinte.Enabled = True
            btnAnteriror.Enabled = True
            btnInicio.Enabled = True
            Try
                SqlDataAdapter1.Update(DataSet11.Proveedor)
            Catch
                MsgBox("Ocurrio un error: " & Err.Description)
            End Try

        Else
            MsgBox("Favor de llenar todos los campos")
        End If
    End Sub

    Private Function Verificacion() As Boolean

        Return (Not (String.IsNullOrEmpty(txtNombre.Text)) And Not (String.IsNullOrEmpty(txtCiudad.Text)) And Not (String.IsNullOrEmpty(txtContacto.Text)) And Not (String.IsNullOrEmpty(txtDomicilio.Text)) And Not (String.IsNullOrEmpty(txtColonia.Text)) And Not (String.IsNullOrEmpty(txtEmail.Text)) And Not (String.IsNullOrEmpty(txtCP.Text)) And Not (String.IsNullOrEmpty(txtTelefono.Text)) And Not (String.IsNullOrEmpty(txtCP.Text)))

    End Function

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtId.Enabled = False
        txtNombre.Enabled = True '
        txtCiudad.Enabled = True '
        txtContacto.Enabled = True '
        txtDomicilio.Enabled = True '
        txtColonia.Enabled = True '
        txtCP.Enabled = True '
        txtCiudad.Enabled = True '
        txtTelefono.Enabled = True '
        txtEmail.Enabled = True '
        ' txtSaldo.Enabled = True

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
End Class