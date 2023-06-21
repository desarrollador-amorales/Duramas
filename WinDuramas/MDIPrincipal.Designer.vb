<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MDIPrincipal))
        MenuStrip = New MenuStrip()
        FileMenu = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        RegistroDeItemsBodegaToolStripMenuItem = New ToolStripMenuItem()
        IngresoDePreciosPorAlmacenToolStripMenuItem = New ToolStripMenuItem()
        RegistroDeCostosToolStripMenuItem = New ToolStripMenuItem()
        RegistroDeCostosToolStripMenuItem1 = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        PrintPreviewToolStripMenuItem = New ToolStripMenuItem()
        PrintSetupToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditMenu = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        RedoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator7 = New ToolStripSeparator()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        ViewMenu = New ToolStripMenuItem()
        ToolBarToolStripMenuItem = New ToolStripMenuItem()
        StatusBarToolStripMenuItem = New ToolStripMenuItem()
        ToolsMenu = New ToolStripMenuItem()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        WindowsMenu = New ToolStripMenuItem()
        NewWindowToolStripMenuItem = New ToolStripMenuItem()
        CascadeToolStripMenuItem = New ToolStripMenuItem()
        TileVerticalToolStripMenuItem = New ToolStripMenuItem()
        TileHorizontalToolStripMenuItem = New ToolStripMenuItem()
        CloseAllToolStripMenuItem = New ToolStripMenuItem()
        ArrangeIconsToolStripMenuItem = New ToolStripMenuItem()
        HelpMenu = New ToolStripMenuItem()
        ContentsToolStripMenuItem = New ToolStripMenuItem()
        IndexToolStripMenuItem = New ToolStripMenuItem()
        SearchToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator8 = New ToolStripSeparator()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        SRIToolStripMenuItem = New ToolStripMenuItem()
        MantenimientosToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip = New ToolStrip()
        NewToolStripButton = New ToolStripButton()
        OpenToolStripButton = New ToolStripButton()
        SaveToolStripButton = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        PrintToolStripButton = New ToolStripButton()
        PrintPreviewToolStripButton = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        HelpToolStripButton = New ToolStripButton()
        StatusStrip = New StatusStrip()
        ToolStripStatusLabel = New ToolStripStatusLabel()
        ToolTip = New ToolTip(components)
        ActivarItemsDeImportacionParaFacturacionToolStripMenuItem = New ToolStripMenuItem()
        TransaccionesToolStripMenuItem = New ToolStripMenuItem()
        SesionDeToolStripMenuItem = New ToolStripMenuItem()
        AprobacionDeTransferenciasDeMaterialToolStripMenuItem = New ToolStripMenuItem()
        AprobarPackingListToolStripMenuItem = New ToolStripMenuItem()
        IngresoDeRetazosToolStripMenuItem = New ToolStripMenuItem()
        EgresoDeRetazosToolStripMenuItem = New ToolStripMenuItem()
        SesionOrdenesPedidosPorAprobarToolStripMenuItem = New ToolStripMenuItem()
        CierreMensualToolStripMenuItem = New ToolStripMenuItem()
        StocksYPreciosToolStripMenuItem = New ToolStripMenuItem()
        ExistenciaMenoresAlStockMinimoToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip.SuspendLayout()
        ToolStrip.SuspendLayout()
        StatusStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.ImageScalingSize = New Size(20, 20)
        MenuStrip.Items.AddRange(New ToolStripItem() {FileMenu, EditMenu, ViewMenu, ToolsMenu, WindowsMenu, HelpMenu, SRIToolStripMenuItem})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.MdiWindowListItem = WindowsMenu
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(8, 3, 0, 3)
        MenuStrip.Size = New Size(842, 30)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' FileMenu
        ' 
        FileMenu.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, ToolStripSeparator3, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ToolStripSeparator4, PrintToolStripMenuItem, PrintPreviewToolStripMenuItem, PrintSetupToolStripMenuItem, ToolStripSeparator5, ExitToolStripMenuItem})
        FileMenu.ImageTransparentColor = SystemColors.ActiveBorder
        FileMenu.Name = "FileMenu"
        FileMenu.Size = New Size(95, 24)
        FileMenu.Text = "&Inventarios"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegistroDeItemsBodegaToolStripMenuItem, IngresoDePreciosPorAlmacenToolStripMenuItem, RegistroDeCostosToolStripMenuItem, RegistroDeCostosToolStripMenuItem1, ActivarItemsDeImportacionParaFacturacionToolStripMenuItem})
        NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), Image)
        NewToolStripMenuItem.ImageTransparentColor = Color.Black
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NewToolStripMenuItem.Size = New Size(260, 26)
        NewToolStripMenuItem.Text = "&Mantenimiento"
        ' 
        ' RegistroDeItemsBodegaToolStripMenuItem
        ' 
        RegistroDeItemsBodegaToolStripMenuItem.Name = "RegistroDeItemsBodegaToolStripMenuItem"
        RegistroDeItemsBodegaToolStripMenuItem.Size = New Size(376, 26)
        RegistroDeItemsBodegaToolStripMenuItem.Text = "Registro de Items/Bodega"
        ' 
        ' IngresoDePreciosPorAlmacenToolStripMenuItem
        ' 
        IngresoDePreciosPorAlmacenToolStripMenuItem.Name = "IngresoDePreciosPorAlmacenToolStripMenuItem"
        IngresoDePreciosPorAlmacenToolStripMenuItem.Size = New Size(376, 26)
        IngresoDePreciosPorAlmacenToolStripMenuItem.Text = "Ingreso de precios por almacen"
        ' 
        ' RegistroDeCostosToolStripMenuItem
        ' 
        RegistroDeCostosToolStripMenuItem.Name = "RegistroDeCostosToolStripMenuItem"
        RegistroDeCostosToolStripMenuItem.Size = New Size(376, 26)
        RegistroDeCostosToolStripMenuItem.Text = "Registro de Costos (Por Compras)"
        ' 
        ' RegistroDeCostosToolStripMenuItem1
        ' 
        RegistroDeCostosToolStripMenuItem1.Name = "RegistroDeCostosToolStripMenuItem1"
        RegistroDeCostosToolStripMenuItem1.Size = New Size(376, 26)
        RegistroDeCostosToolStripMenuItem1.Text = "Registro de Productos en Liquidacion"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TransaccionesToolStripMenuItem, SesionDeToolStripMenuItem, AprobacionDeTransferenciasDeMaterialToolStripMenuItem, AprobarPackingListToolStripMenuItem, IngresoDeRetazosToolStripMenuItem, EgresoDeRetazosToolStripMenuItem, SesionOrdenesPedidosPorAprobarToolStripMenuItem, CierreMensualToolStripMenuItem})
        OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), Image)
        OpenToolStripMenuItem.ImageTransparentColor = Color.Black
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OpenToolStripMenuItem.Size = New Size(260, 26)
        OpenToolStripMenuItem.Text = "&Procesos"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(257, 6)
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StocksYPreciosToolStripMenuItem, ExistenciaMenoresAlStockMinimoToolStripMenuItem})
        SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), Image)
        SaveToolStripMenuItem.ImageTransparentColor = Color.Black
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SaveToolStripMenuItem.Size = New Size(260, 26)
        SaveToolStripMenuItem.Text = "&Reportes"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(260, 26)
        SaveAsToolStripMenuItem.Text = "Guardar &como"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(257, 6)
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), Image)
        PrintToolStripMenuItem.ImageTransparentColor = Color.Black
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.P
        PrintToolStripMenuItem.Size = New Size(260, 26)
        PrintToolStripMenuItem.Text = "&Imprimir"
        ' 
        ' PrintPreviewToolStripMenuItem
        ' 
        PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), Image)
        PrintPreviewToolStripMenuItem.ImageTransparentColor = Color.Black
        PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        PrintPreviewToolStripMenuItem.Size = New Size(260, 26)
        PrintPreviewToolStripMenuItem.Text = "&Vista previa de impresión"
        ' 
        ' PrintSetupToolStripMenuItem
        ' 
        PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem"
        PrintSetupToolStripMenuItem.Size = New Size(260, 26)
        PrintSetupToolStripMenuItem.Text = "Configurar impresión"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(257, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(260, 26)
        ExitToolStripMenuItem.Text = "&Salir"
        ' 
        ' EditMenu
        ' 
        EditMenu.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, RedoToolStripMenuItem, ToolStripSeparator6, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripSeparator7, SelectAllToolStripMenuItem})
        EditMenu.Name = "EditMenu"
        EditMenu.Size = New Size(82, 24)
        EditMenu.Text = "&Compras"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Image = CType(resources.GetObject("UndoToolStripMenuItem.Image"), Image)
        UndoToolStripMenuItem.ImageTransparentColor = Color.Black
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Z
        UndoToolStripMenuItem.Size = New Size(256, 26)
        UndoToolStripMenuItem.Text = "&Deshacer"
        ' 
        ' RedoToolStripMenuItem
        ' 
        RedoToolStripMenuItem.Image = CType(resources.GetObject("RedoToolStripMenuItem.Image"), Image)
        RedoToolStripMenuItem.ImageTransparentColor = Color.Black
        RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        RedoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Y
        RedoToolStripMenuItem.Size = New Size(256, 26)
        RedoToolStripMenuItem.Text = "&Rehacer"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(253, 6)
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), Image)
        CutToolStripMenuItem.ImageTransparentColor = Color.Black
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        CutToolStripMenuItem.Size = New Size(256, 26)
        CutToolStripMenuItem.Text = "Cor&tar"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), Image)
        CopyToolStripMenuItem.ImageTransparentColor = Color.Black
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        CopyToolStripMenuItem.Size = New Size(256, 26)
        CopyToolStripMenuItem.Text = "&Copiar"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), Image)
        PasteToolStripMenuItem.ImageTransparentColor = Color.Black
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        PasteToolStripMenuItem.Size = New Size(256, 26)
        PasteToolStripMenuItem.Text = "&Pegar"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(253, 6)
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        SelectAllToolStripMenuItem.Size = New Size(256, 26)
        SelectAllToolStripMenuItem.Text = "Seleccionar &todo"
        ' 
        ' ViewMenu
        ' 
        ViewMenu.DropDownItems.AddRange(New ToolStripItem() {ToolBarToolStripMenuItem, StatusBarToolStripMenuItem})
        ViewMenu.Name = "ViewMenu"
        ViewMenu.Size = New Size(66, 24)
        ViewMenu.Text = "&Ventas"
        ' 
        ' ToolBarToolStripMenuItem
        ' 
        ToolBarToolStripMenuItem.Checked = True
        ToolBarToolStripMenuItem.CheckOnClick = True
        ToolBarToolStripMenuItem.CheckState = CheckState.Checked
        ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        ToolBarToolStripMenuItem.Size = New Size(238, 26)
        ToolBarToolStripMenuItem.Text = "&Barra de herramientas"
        ' 
        ' StatusBarToolStripMenuItem
        ' 
        StatusBarToolStripMenuItem.Checked = True
        StatusBarToolStripMenuItem.CheckOnClick = True
        StatusBarToolStripMenuItem.CheckState = CheckState.Checked
        StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        StatusBarToolStripMenuItem.Size = New Size(238, 26)
        StatusBarToolStripMenuItem.Text = "&Barra de estado"
        ' 
        ' ToolsMenu
        ' 
        ToolsMenu.DropDownItems.AddRange(New ToolStripItem() {OptionsToolStripMenuItem})
        ToolsMenu.Name = "ToolsMenu"
        ToolsMenu.Size = New Size(109, 24)
        ToolsMenu.Text = "&Contabilidad"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(154, 26)
        OptionsToolStripMenuItem.Text = "&Opciones"
        ' 
        ' WindowsMenu
        ' 
        WindowsMenu.DropDownItems.AddRange(New ToolStripItem() {NewWindowToolStripMenuItem, CascadeToolStripMenuItem, TileVerticalToolStripMenuItem, TileHorizontalToolStripMenuItem, CloseAllToolStripMenuItem, ArrangeIconsToolStripMenuItem})
        WindowsMenu.Name = "WindowsMenu"
        WindowsMenu.Size = New Size(148, 24)
        WindowsMenu.Text = "&Consumos Internos"
        ' 
        ' NewWindowToolStripMenuItem
        ' 
        NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        NewWindowToolStripMenuItem.Size = New Size(219, 26)
        NewWindowToolStripMenuItem.Text = "&Nueva ventana"
        ' 
        ' CascadeToolStripMenuItem
        ' 
        CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        CascadeToolStripMenuItem.Size = New Size(219, 26)
        CascadeToolStripMenuItem.Text = "&Cascada"
        ' 
        ' TileVerticalToolStripMenuItem
        ' 
        TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        TileVerticalToolStripMenuItem.Size = New Size(219, 26)
        TileVerticalToolStripMenuItem.Text = "Mosaico &vertical"
        ' 
        ' TileHorizontalToolStripMenuItem
        ' 
        TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        TileHorizontalToolStripMenuItem.Size = New Size(219, 26)
        TileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal"
        ' 
        ' CloseAllToolStripMenuItem
        ' 
        CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        CloseAllToolStripMenuItem.Size = New Size(219, 26)
        CloseAllToolStripMenuItem.Text = "C&errar todo"
        ' 
        ' ArrangeIconsToolStripMenuItem
        ' 
        ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        ArrangeIconsToolStripMenuItem.Size = New Size(219, 26)
        ArrangeIconsToolStripMenuItem.Text = "&Organizar iconos"
        ' 
        ' HelpMenu
        ' 
        HelpMenu.DropDownItems.AddRange(New ToolStripItem() {ContentsToolStripMenuItem, IndexToolStripMenuItem, SearchToolStripMenuItem, ToolStripSeparator8, AboutToolStripMenuItem})
        HelpMenu.Name = "HelpMenu"
        HelpMenu.Size = New Size(109, 24)
        HelpMenu.Text = "&Rol de Pagos"
        ' 
        ' ContentsToolStripMenuItem
        ' 
        ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        ContentsToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F1
        ContentsToolStripMenuItem.Size = New Size(218, 26)
        ContentsToolStripMenuItem.Text = "&Contenido"
        ' 
        ' IndexToolStripMenuItem
        ' 
        IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), Image)
        IndexToolStripMenuItem.ImageTransparentColor = Color.Black
        IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        IndexToolStripMenuItem.Size = New Size(218, 26)
        IndexToolStripMenuItem.Text = "&Index"
        ' 
        ' SearchToolStripMenuItem
        ' 
        SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), Image)
        SearchToolStripMenuItem.ImageTransparentColor = Color.Black
        SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        SearchToolStripMenuItem.Size = New Size(218, 26)
        SearchToolStripMenuItem.Text = "&Buscar"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(215, 6)
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(218, 26)
        AboutToolStripMenuItem.Text = "&Acerca de..."
        ' 
        ' SRIToolStripMenuItem
        ' 
        SRIToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MantenimientosToolStripMenuItem})
        SRIToolStripMenuItem.Name = "SRIToolStripMenuItem"
        SRIToolStripMenuItem.Size = New Size(44, 24)
        SRIToolStripMenuItem.Text = "SRI"
        ' 
        ' MantenimientosToolStripMenuItem
        ' 
        MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        MantenimientosToolStripMenuItem.Size = New Size(199, 26)
        MantenimientosToolStripMenuItem.Text = "Mantenimientos"
        ' 
        ' ToolStrip
        ' 
        ToolStrip.ImageScalingSize = New Size(20, 20)
        ToolStrip.Items.AddRange(New ToolStripItem() {NewToolStripButton, OpenToolStripButton, SaveToolStripButton, ToolStripSeparator1, PrintToolStripButton, PrintPreviewToolStripButton, ToolStripSeparator2, HelpToolStripButton})
        ToolStrip.Location = New Point(0, 30)
        ToolStrip.Name = "ToolStrip"
        ToolStrip.Size = New Size(842, 27)
        ToolStrip.TabIndex = 6
        ToolStrip.Text = "ToolStrip"
        ' 
        ' NewToolStripButton
        ' 
        NewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), Image)
        NewToolStripButton.ImageTransparentColor = Color.Black
        NewToolStripButton.Name = "NewToolStripButton"
        NewToolStripButton.Size = New Size(29, 24)
        NewToolStripButton.Text = "Nuevo"
        ' 
        ' OpenToolStripButton
        ' 
        OpenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), Image)
        OpenToolStripButton.ImageTransparentColor = Color.Black
        OpenToolStripButton.Name = "OpenToolStripButton"
        OpenToolStripButton.Size = New Size(29, 24)
        OpenToolStripButton.Text = "Abrir"
        ' 
        ' SaveToolStripButton
        ' 
        SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), Image)
        SaveToolStripButton.ImageTransparentColor = Color.Black
        SaveToolStripButton.Name = "SaveToolStripButton"
        SaveToolStripButton.Size = New Size(29, 24)
        SaveToolStripButton.Text = "Guardar"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 27)
        ' 
        ' PrintToolStripButton
        ' 
        PrintToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), Image)
        PrintToolStripButton.ImageTransparentColor = Color.Black
        PrintToolStripButton.Name = "PrintToolStripButton"
        PrintToolStripButton.Size = New Size(29, 24)
        PrintToolStripButton.Text = "Imprimir"
        ' 
        ' PrintPreviewToolStripButton
        ' 
        PrintPreviewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PrintPreviewToolStripButton.Image = CType(resources.GetObject("PrintPreviewToolStripButton.Image"), Image)
        PrintPreviewToolStripButton.ImageTransparentColor = Color.Black
        PrintPreviewToolStripButton.Name = "PrintPreviewToolStripButton"
        PrintPreviewToolStripButton.Size = New Size(29, 24)
        PrintPreviewToolStripButton.Text = "Vista previa de impresión"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 27)
        ' 
        ' HelpToolStripButton
        ' 
        HelpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), Image)
        HelpToolStripButton.ImageTransparentColor = Color.Black
        HelpToolStripButton.Name = "HelpToolStripButton"
        HelpToolStripButton.Size = New Size(29, 24)
        HelpToolStripButton.Text = "Ayuda"
        ' 
        ' StatusStrip
        ' 
        StatusStrip.ImageScalingSize = New Size(20, 20)
        StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel})
        StatusStrip.Location = New Point(0, 671)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Padding = New Padding(1, 0, 18, 0)
        StatusStrip.Size = New Size(842, 26)
        StatusStrip.TabIndex = 7
        StatusStrip.Text = "StatusStrip"
        ' 
        ' ToolStripStatusLabel
        ' 
        ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        ToolStripStatusLabel.Size = New Size(54, 20)
        ToolStripStatusLabel.Text = "Estado"
        ' 
        ' ActivarItemsDeImportacionParaFacturacionToolStripMenuItem
        ' 
        ActivarItemsDeImportacionParaFacturacionToolStripMenuItem.Name = "ActivarItemsDeImportacionParaFacturacionToolStripMenuItem"
        ActivarItemsDeImportacionParaFacturacionToolStripMenuItem.Size = New Size(376, 26)
        ActivarItemsDeImportacionParaFacturacionToolStripMenuItem.Text = "Activar Items Importacion para Facturacion"
        ' 
        ' TransaccionesToolStripMenuItem
        ' 
        TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        TransaccionesToolStripMenuItem.Size = New Size(224, 26)
        TransaccionesToolStripMenuItem.Text = "Transacciones"
        ' 
        ' SesionDeToolStripMenuItem
        ' 
        SesionDeToolStripMenuItem.Name = "SesionDeToolStripMenuItem"
        SesionDeToolStripMenuItem.Size = New Size(368, 26)
        SesionDeToolStripMenuItem.Text = "Sesion de Transacciones"
        ' 
        ' AprobacionDeTransferenciasDeMaterialToolStripMenuItem
        ' 
        AprobacionDeTransferenciasDeMaterialToolStripMenuItem.Name = "AprobacionDeTransferenciasDeMaterialToolStripMenuItem"
        AprobacionDeTransferenciasDeMaterialToolStripMenuItem.Size = New Size(368, 26)
        AprobacionDeTransferenciasDeMaterialToolStripMenuItem.Text = "Aprobacion de Transferencias de Material"
        ' 
        ' AprobarPackingListToolStripMenuItem
        ' 
        AprobarPackingListToolStripMenuItem.Name = "AprobarPackingListToolStripMenuItem"
        AprobarPackingListToolStripMenuItem.Size = New Size(368, 26)
        AprobarPackingListToolStripMenuItem.Text = "Aprobar Packing List"
        ' 
        ' IngresoDeRetazosToolStripMenuItem
        ' 
        IngresoDeRetazosToolStripMenuItem.Name = "IngresoDeRetazosToolStripMenuItem"
        IngresoDeRetazosToolStripMenuItem.Size = New Size(368, 26)
        IngresoDeRetazosToolStripMenuItem.Text = "Ingreso de Retazos"
        ' 
        ' EgresoDeRetazosToolStripMenuItem
        ' 
        EgresoDeRetazosToolStripMenuItem.Name = "EgresoDeRetazosToolStripMenuItem"
        EgresoDeRetazosToolStripMenuItem.Size = New Size(368, 26)
        EgresoDeRetazosToolStripMenuItem.Text = "Egreso de Retazos"
        ' 
        ' SesionOrdenesPedidosPorAprobarToolStripMenuItem
        ' 
        SesionOrdenesPedidosPorAprobarToolStripMenuItem.Name = "SesionOrdenesPedidosPorAprobarToolStripMenuItem"
        SesionOrdenesPedidosPorAprobarToolStripMenuItem.Size = New Size(368, 26)
        SesionOrdenesPedidosPorAprobarToolStripMenuItem.Text = "Sesion Ordenes de Pedido por Egresar"
        ' 
        ' CierreMensualToolStripMenuItem
        ' 
        CierreMensualToolStripMenuItem.Name = "CierreMensualToolStripMenuItem"
        CierreMensualToolStripMenuItem.Size = New Size(368, 26)
        CierreMensualToolStripMenuItem.Text = "Cierre Mensual"
        ' 
        ' StocksYPreciosToolStripMenuItem
        ' 
        StocksYPreciosToolStripMenuItem.Name = "StocksYPreciosToolStripMenuItem"
        StocksYPreciosToolStripMenuItem.Size = New Size(329, 26)
        StocksYPreciosToolStripMenuItem.Text = "Stocks y Precios"
        ' 
        ' ExistenciaMenoresAlStockMinimoToolStripMenuItem
        ' 
        ExistenciaMenoresAlStockMinimoToolStripMenuItem.Name = "ExistenciaMenoresAlStockMinimoToolStripMenuItem"
        ExistenciaMenoresAlStockMinimoToolStripMenuItem.Size = New Size(329, 26)
        ExistenciaMenoresAlStockMinimoToolStripMenuItem.Text = "Existencia Menores al Stock Minimo"
        ' 
        ' MDIPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(842, 697)
        ControlBox = False
        Controls.Add(ToolStrip)
        Controls.Add(MenuStrip)
        Controls.Add(StatusStrip)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(5, 4, 5, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "MDIPrincipal"
        Text = "MDIPrincipal"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        ToolStrip.ResumeLayout(False)
        ToolStrip.PerformLayout()
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpMenu As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsMenu As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripButton As ToolStripButton
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents PrintSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileMenu As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents EditMenu As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMenu As ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsMenu As ToolStripMenuItem
    Friend WithEvents SRIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeItemsBodegaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoDePreciosPorAlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeCostosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeCostosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ActivarItemsDeImportacionParaFacturacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SesionDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AprobacionDeTransferenciasDeMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AprobarPackingListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoDeRetazosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EgresoDeRetazosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SesionOrdenesPedidosPorAprobarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CierreMensualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StocksYPreciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExistenciaMenoresAlStockMinimoToolStripMenuItem As ToolStripMenuItem
End Class
