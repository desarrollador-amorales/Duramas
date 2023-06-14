<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmacen
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmAlmacen))
        GboxListado = New GroupBox()
        TxtCriterio1 = New TextBox()
        TxtCriterio = New TextBox()
        ListaDatos = New ListView()
        GroupBox1 = New GroupBox()
        CmdSalir = New Button()
        CmdImprimir = New Button()
        CmdEliminar = New Button()
        CmdGrabar = New Button()
        cmdNuevo = New Button()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        TxtCampos0 = New TextBox()
        Label1 = New Label()
        TxtCampos1 = New TextBox()
        Label2 = New Label()
        TxtCampos2 = New TextBox()
        Label3 = New Label()
        TxtCampos3 = New TextBox()
        Label4 = New Label()
        TxtCampos4 = New TextBox()
        Label5 = New Label()
        GboxListado.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GboxListado
        ' 
        GboxListado.Controls.Add(TxtCriterio1)
        GboxListado.Controls.Add(TxtCriterio)
        GboxListado.Controls.Add(ListaDatos)
        GboxListado.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        GboxListado.Location = New Point(12, 12)
        GboxListado.Name = "GboxListado"
        GboxListado.Size = New Size(400, 473)
        GboxListado.TabIndex = 0
        GboxListado.TabStop = False
        GboxListado.Text = "Listado de Almacenes"
        ' 
        ' TxtCriterio1
        ' 
        TxtCriterio1.Location = New Point(103, 21)
        TxtCriterio1.Margin = New Padding(3, 2, 3, 2)
        TxtCriterio1.Name = "TxtCriterio1"
        TxtCriterio1.Size = New Size(271, 23)
        TxtCriterio1.TabIndex = 2
        ' 
        ' TxtCriterio
        ' 
        TxtCriterio.Location = New Point(33, 21)
        TxtCriterio.Name = "TxtCriterio"
        TxtCriterio.Size = New Size(64, 23)
        TxtCriterio.TabIndex = 1
        ' 
        ' ListaDatos
        ' 
        ListaDatos.AllowColumnReorder = True
        ListaDatos.Location = New Point(18, 48)
        ListaDatos.Margin = New Padding(3, 2, 3, 2)
        ListaDatos.Name = "ListaDatos"
        ListaDatos.Size = New Size(368, 414)
        ListaDatos.TabIndex = 0
        ListaDatos.UseCompatibleStateImageBehavior = False
        ListaDatos.View = View.Details
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CmdSalir)
        GroupBox1.Controls.Add(CmdImprimir)
        GroupBox1.Controls.Add(CmdEliminar)
        GroupBox1.Controls.Add(CmdGrabar)
        GroupBox1.Controls.Add(cmdNuevo)
        GroupBox1.Location = New Point(423, 428)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(362, 57)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' CmdSalir
        ' 
        CmdSalir.Image = CType(resources.GetObject("CmdSalir.Image"), Image)
        CmdSalir.Location = New Point(290, 13)
        CmdSalir.Margin = New Padding(3, 2, 3, 2)
        CmdSalir.Name = "CmdSalir"
        CmdSalir.Size = New Size(47, 39)
        CmdSalir.TabIndex = 4
        CmdSalir.UseVisualStyleBackColor = True
        ' 
        ' CmdImprimir
        ' 
        CmdImprimir.Image = CType(resources.GetObject("CmdImprimir.Image"), Image)
        CmdImprimir.Location = New Point(224, 13)
        CmdImprimir.Margin = New Padding(3, 2, 3, 2)
        CmdImprimir.Name = "CmdImprimir"
        CmdImprimir.Size = New Size(47, 39)
        CmdImprimir.TabIndex = 3
        CmdImprimir.UseVisualStyleBackColor = True
        ' 
        ' CmdEliminar
        ' 
        CmdEliminar.Image = CType(resources.GetObject("CmdEliminar.Image"), Image)
        CmdEliminar.Location = New Point(158, 13)
        CmdEliminar.Margin = New Padding(3, 2, 3, 2)
        CmdEliminar.Name = "CmdEliminar"
        CmdEliminar.Size = New Size(47, 39)
        CmdEliminar.TabIndex = 2
        CmdEliminar.UseVisualStyleBackColor = True
        ' 
        ' CmdGrabar
        ' 
        CmdGrabar.Image = CType(resources.GetObject("CmdGrabar.Image"), Image)
        CmdGrabar.Location = New Point(92, 13)
        CmdGrabar.Margin = New Padding(3, 2, 3, 2)
        CmdGrabar.Name = "CmdGrabar"
        CmdGrabar.Size = New Size(47, 39)
        CmdGrabar.TabIndex = 1
        CmdGrabar.UseVisualStyleBackColor = True
        ' 
        ' cmdNuevo
        ' 
        cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), Image)
        cmdNuevo.Location = New Point(26, 13)
        cmdNuevo.Margin = New Padding(3, 2, 3, 2)
        cmdNuevo.Name = "cmdNuevo"
        cmdNuevo.Size = New Size(47, 39)
        cmdNuevo.TabIndex = 0
        cmdNuevo.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        GroupBox2.Location = New Point(423, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(365, 410)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos del Almacén"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TxtCampos4)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(TxtCampos3)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(TxtCampos2)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(TxtCampos1)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(TxtCampos0)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        GroupBox3.Location = New Point(423, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(363, 410)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Datos del Almacén"
        ' 
        ' TxtCampos0
        ' 
        TxtCampos0.Location = New Point(102, 36)
        TxtCampos0.Name = "TxtCampos0"
        TxtCampos0.Size = New Size(79, 23)
        TxtCampos0.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 0
        Label1.Text = "Código:"
        ' 
        ' TxtCampos1
        ' 
        TxtCampos1.Location = New Point(102, 65)
        TxtCampos1.Name = "TxtCampos1"
        TxtCampos1.Size = New Size(244, 23)
        TxtCampos1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 3
        Label2.Text = "Descripción:"
        ' 
        ' TxtCampos2
        ' 
        TxtCampos2.Location = New Point(102, 94)
        TxtCampos2.Name = "TxtCampos2"
        TxtCampos2.Size = New Size(136, 23)
        TxtCampos2.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 5
        Label3.Text = "RUC:"
        ' 
        ' TxtCampos3
        ' 
        TxtCampos3.Location = New Point(102, 123)
        TxtCampos3.Name = "TxtCampos3"
        TxtCampos3.Size = New Size(79, 23)
        TxtCampos3.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(58, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 7
        Label4.Text = "Serie:"
        ' 
        ' TxtCampos4
        ' 
        TxtCampos4.Location = New Point(102, 152)
        TxtCampos4.Multiline = True
        TxtCampos4.Name = "TxtCampos4"
        TxtCampos4.ScrollBars = ScrollBars.Vertical
        TxtCampos4.Size = New Size(244, 152)
        TxtCampos4.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(47, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 15)
        Label5.TabIndex = 9
        Label5.Text = "Detalle:"
        ' 
        ' FrmAlmacen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 505)
        ControlBox = False
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(GboxListado)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmAlmacen"
        Text = "Mantenimiento de Almacenes"
        GboxListado.ResumeLayout(False)
        GboxListado.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GboxListado As GroupBox
    Friend WithEvents ListaDatos As ListView
    Friend WithEvents TxtCriterio1 As TextBox
    Friend WithEvents TxtCriterio As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmdSalir As Button
    Friend WithEvents CmdImprimir As Button
    Friend WithEvents CmdEliminar As Button
    Friend WithEvents CmdGrabar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtCampos0 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCampos1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCampos4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCampos3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCampos2 As TextBox
    Friend WithEvents Label3 As Label
End Class
