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
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        cmdNuevo = New Button()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        GboxListado.SuspendLayout()
        GroupBox1.SuspendLayout()
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
        TxtCriterio1.Location = New Point(88, 21)
        TxtCriterio1.Margin = New Padding(3, 2, 3, 2)
        TxtCriterio1.Name = "TxtCriterio1"
        TxtCriterio1.Size = New Size(271, 23)
        TxtCriterio1.TabIndex = 2
        ' 
        ' TxtCriterio
        ' 
        TxtCriterio.Location = New Point(18, 21)
        TxtCriterio.Name = "TxtCriterio"
        TxtCriterio.Size = New Size(64, 23)
        TxtCriterio.TabIndex = 1
        ' 
        ' ListaDatos
        ' 
        ListaDatos.AllowColumnReorder = True
        ListaDatos.Location = New Point(6, 50)
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
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
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
        CmdSalir.Location = New Point(295, 13)
        CmdSalir.Margin = New Padding(3, 2, 3, 2)
        CmdSalir.Name = "CmdSalir"
        CmdSalir.Size = New Size(47, 39)
        CmdSalir.TabIndex = 4
        CmdSalir.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(231, 13)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(47, 39)
        Button3.TabIndex = 3
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(162, 13)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(47, 39)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(98, 13)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(47, 39)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cmdNuevo
        ' 
        cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), Image)
        cmdNuevo.Location = New Point(31, 13)
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
        GroupBox3.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        GroupBox3.Location = New Point(423, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(363, 410)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Datos del Almacén"
        ' 
        ' FrmAlmacen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 505)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(GboxListado)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmAlmacen"
        Text = "FrmAlmacen"
        GboxListado.ResumeLayout(False)
        GboxListado.PerformLayout()
        GroupBox1.ResumeLayout(False)
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
End Class
