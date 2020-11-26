<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMProvedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMCategoria = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMSubVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMSubVCIndividual = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMSubVConsultaXCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMSubVCXPeriodo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComparToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMSubCompras = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMSubCCIndividual = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMSubCCXProvedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMSubCCXPeriodo = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeneralToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelacionProvedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioPorCategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDePreciosPorCategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucionesReporte = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalagosToolStripMenuItem, Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(630, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalagosToolStripMenuItem
        '
        Me.CatalagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemMProvedor, Me.ItemMProducto, Me.ItemMCategoria, Me.ItemMCliente})
        Me.CatalagosToolStripMenuItem.Name = "CatalagosToolStripMenuItem"
        Me.CatalagosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CatalagosToolStripMenuItem.Text = "Catalagos"
        '
        'ItemMProvedor
        '
        Me.ItemMProvedor.Name = "ItemMProvedor"
        Me.ItemMProvedor.Size = New System.Drawing.Size(125, 22)
        Me.ItemMProvedor.Text = "Provedor"
        '
        'ItemMProducto
        '
        Me.ItemMProducto.Name = "ItemMProducto"
        Me.ItemMProducto.Size = New System.Drawing.Size(125, 22)
        Me.ItemMProducto.Text = "Producto"
        '
        'ItemMCategoria
        '
        Me.ItemMCategoria.Name = "ItemMCategoria"
        Me.ItemMCategoria.Size = New System.Drawing.Size(125, 22)
        Me.ItemMCategoria.Text = "Categoria"
        '
        'ItemMCliente
        '
        Me.ItemMCliente.Name = "ItemMCliente"
        Me.ItemMCliente.Size = New System.Drawing.Size(125, 22)
        Me.ItemMCliente.Text = "Cliente"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.ComparToolStripMenuItem, Me.PagosToolStripMenuItem, Me.DevolucionesToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemMSubVentas, Me.ItemMSubVCIndividual, Me.ItemMSubVConsultaXCliente, Me.ItemMSubVCXPeriodo})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ItemMSubVentas
        '
        Me.ItemMSubVentas.Name = "ItemMSubVentas"
        Me.ItemMSubVentas.Size = New System.Drawing.Size(186, 22)
        Me.ItemMSubVentas.Text = "Venta"
        '
        'ItemMSubVCIndividual
        '
        Me.ItemMSubVCIndividual.Name = "ItemMSubVCIndividual"
        Me.ItemMSubVCIndividual.Size = New System.Drawing.Size(186, 22)
        Me.ItemMSubVCIndividual.Text = "Consulta Individual"
        '
        'ItemMSubVConsultaXCliente
        '
        Me.ItemMSubVConsultaXCliente.Name = "ItemMSubVConsultaXCliente"
        Me.ItemMSubVConsultaXCliente.Size = New System.Drawing.Size(186, 22)
        Me.ItemMSubVConsultaXCliente.Text = "Consulta Por Cliente"
        '
        'ItemMSubVCXPeriodo
        '
        Me.ItemMSubVCXPeriodo.Name = "ItemMSubVCXPeriodo"
        Me.ItemMSubVCXPeriodo.Size = New System.Drawing.Size(186, 22)
        Me.ItemMSubVCXPeriodo.Text = "Consulta Por Periodo"
        '
        'ComparToolStripMenuItem
        '
        Me.ComparToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemMSubCompras, Me.ItemMSubCCIndividual, Me.ItemMSubCCXProvedor, Me.ItemMSubCCXPeriodo})
        Me.ComparToolStripMenuItem.Name = "ComparToolStripMenuItem"
        Me.ComparToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ComparToolStripMenuItem.Text = "Compras"
        '
        'ItemMSubCompras
        '
        Me.ItemMSubCompras.Name = "ItemMSubCompras"
        Me.ItemMSubCompras.Size = New System.Drawing.Size(193, 22)
        Me.ItemMSubCompras.Text = "Comprar"
        '
        'ItemMSubCCIndividual
        '
        Me.ItemMSubCCIndividual.Name = "ItemMSubCCIndividual"
        Me.ItemMSubCCIndividual.Size = New System.Drawing.Size(193, 22)
        Me.ItemMSubCCIndividual.Text = "Consulta Individual"
        '
        'ItemMSubCCXProvedor
        '
        Me.ItemMSubCCXProvedor.Name = "ItemMSubCCXProvedor"
        Me.ItemMSubCCXProvedor.Size = New System.Drawing.Size(193, 22)
        Me.ItemMSubCCXProvedor.Text = "Consulta por provedor"
        '
        'ItemMSubCCXPeriodo
        '
        Me.ItemMSubCCXPeriodo.Name = "ItemMSubCCXPeriodo"
        Me.ItemMSubCCXPeriodo.Size = New System.Drawing.Size(193, 22)
        Me.ItemMSubCCXPeriodo.Text = "Consulta Por Periodo"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagosToolStripMenuItem1, Me.ConsultaGeneralToolStripMenuItem1})
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'PagosToolStripMenuItem1
        '
        Me.PagosToolStripMenuItem1.Name = "PagosToolStripMenuItem1"
        Me.PagosToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.PagosToolStripMenuItem1.Text = "Pagos"
        '
        'ConsultaGeneralToolStripMenuItem1
        '
        Me.ConsultaGeneralToolStripMenuItem1.Name = "ConsultaGeneralToolStripMenuItem1"
        Me.ConsultaGeneralToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.ConsultaGeneralToolStripMenuItem1.Text = "Consulta General"
        '
        'DevolucionesToolStripMenuItem
        '
        Me.DevolucionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DevolucionesToolStripMenuItem1, Me.ConsultaGeneralToolStripMenuItem})
        Me.DevolucionesToolStripMenuItem.Name = "DevolucionesToolStripMenuItem"
        Me.DevolucionesToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DevolucionesToolStripMenuItem.Text = "Devoluciones"
        '
        'DevolucionesToolStripMenuItem1
        '
        Me.DevolucionesToolStripMenuItem1.Name = "DevolucionesToolStripMenuItem1"
        Me.DevolucionesToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.DevolucionesToolStripMenuItem1.Text = "Devoluciones"
        '
        'ConsultaGeneralToolStripMenuItem
        '
        Me.ConsultaGeneralToolStripMenuItem.Name = "ConsultaGeneralToolStripMenuItem"
        Me.ConsultaGeneralToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ConsultaGeneralToolStripMenuItem.Text = "Consulta General"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.RelacionProvedorToolStripMenuItem, Me.InventarioPorCategoriasToolStripMenuItem, Me.ListaDePreciosPorCategoriasToolStripMenuItem, Me.VentasToolStripMenuItem1, Me.DevolucionesReporte, Me.PagosToolStripMenuItem2, Me.ComprasToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(233, 22)
        Me.ToolStripMenuItem1.Text = "Relacion clientes"
        '
        'RelacionProvedorToolStripMenuItem
        '
        Me.RelacionProvedorToolStripMenuItem.Name = "RelacionProvedorToolStripMenuItem"
        Me.RelacionProvedorToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.RelacionProvedorToolStripMenuItem.Text = "Relacion Provedor"
        '
        'InventarioPorCategoriasToolStripMenuItem
        '
        Me.InventarioPorCategoriasToolStripMenuItem.Name = "InventarioPorCategoriasToolStripMenuItem"
        Me.InventarioPorCategoriasToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.InventarioPorCategoriasToolStripMenuItem.Text = "Inventario por categorias"
        '
        'ListaDePreciosPorCategoriasToolStripMenuItem
        '
        Me.ListaDePreciosPorCategoriasToolStripMenuItem.Name = "ListaDePreciosPorCategoriasToolStripMenuItem"
        Me.ListaDePreciosPorCategoriasToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ListaDePreciosPorCategoriasToolStripMenuItem.Text = "Lista de precios por categorias"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(233, 22)
        Me.VentasToolStripMenuItem1.Text = "Ventas"
        '
        'DevolucionesReporte
        '
        Me.DevolucionesReporte.Name = "DevolucionesReporte"
        Me.DevolucionesReporte.Size = New System.Drawing.Size(233, 22)
        Me.DevolucionesReporte.Text = "Devoluciones"
        '
        'PagosToolStripMenuItem2
        '
        Me.PagosToolStripMenuItem2.Name = "PagosToolStripMenuItem2"
        Me.PagosToolStripMenuItem2.Size = New System.Drawing.Size(233, 22)
        Me.PagosToolStripMenuItem2.Text = "Pagos"
        '
        'ComprasToolStripMenuItem1
        '
        Me.ComprasToolStripMenuItem1.Name = "ComprasToolStripMenuItem1"
        Me.ComprasToolStripMenuItem1.Size = New System.Drawing.Size(233, 22)
        Me.ComprasToolStripMenuItem1.Text = "Compras"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ferreteria.My.Resources.Resources.Imagen1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(609, 550)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 589)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemMProvedor As ToolStripMenuItem
    Friend WithEvents ItemMProducto As ToolStripMenuItem
    Friend WithEvents ItemMCategoria As ToolStripMenuItem
    Friend WithEvents ItemMCliente As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemMSubVentas As ToolStripMenuItem
    Friend WithEvents ItemMSubVCIndividual As ToolStripMenuItem
    Friend WithEvents ItemMSubVConsultaXCliente As ToolStripMenuItem
    Friend WithEvents ComparToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemMSubCompras As ToolStripMenuItem
    Friend WithEvents ItemMSubCCIndividual As ToolStripMenuItem
    Friend WithEvents ItemMSubCCXProvedor As ToolStripMenuItem
    Friend WithEvents ItemMSubVCXPeriodo As ToolStripMenuItem
    Friend WithEvents ItemMSubCCXPeriodo As ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DevolucionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevolucionesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsultaGeneralToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsultaGeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RelacionProvedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioPorCategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDePreciosPorCategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DevolucionesReporte As ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
