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
        cmdNuevo = New Button()
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
        GboxListado.Location = New Point(14, 16)
        GboxListado.Margin = New Padding(3, 4, 3, 4)
        GboxListado.Name = "GboxListado"
        GboxListado.Padding = New Padding(3, 4, 3, 4)
        GboxListado.Size = New Size(457, 631)
        GboxListado.TabIndex = 0
        GboxListado.TabStop = False
        GboxListado.Text = "Listado de Almacenes"
        ' 
        ' TxtCriterio1
        ' 
        TxtCriterio1.Location = New Point(185, 29)
        TxtCriterio1.Margin = New Padding(3, 4, 3, 4)
        TxtCriterio1.Name = "TxtCriterio1"
        TxtCriterio1.Size = New Size(234, 27)
        TxtCriterio1.TabIndex = 2
        ' 
        ' TxtCriterio
        ' 
        TxtCriterio.Location = New Point(37, 29)
        TxtCriterio.Margin = New Padding(3, 4, 3, 4)
        TxtCriterio.Name = "TxtCriterio"
        TxtCriterio.Size = New Size(141, 27)
        TxtCriterio.TabIndex = 1
        ' 
        ' ListaDatos
        ' 
        ListaDatos.Location = New Point(17, 68)
        ListaDatos.Margin = New Padding(3, 4, 3, 4)
        ListaDatos.Name = "ListaDatos"
        ListaDatos.Size = New Size(420, 537)
        ListaDatos.TabIndex = 0
        ListaDatos.UseCompatibleStateImageBehavior = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmdNuevo)
        GroupBox1.Location = New Point(483, 571)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(414, 76)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' cmdNuevo
        ' 
        cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), Image)
        cmdNuevo.Location = New Point(7, 16)
        cmdNuevo.Margin = New Padding(3, 4, 3, 4)
        cmdNuevo.Name = "cmdNuevo"
        cmdNuevo.Size = New Size(54, 52)
        cmdNuevo.TabIndex = 0
        cmdNuevo.UseVisualStyleBackColor = True
        ' 
        ' FrmAlmacen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 673)
        Controls.Add(GroupBox1)
        Controls.Add(GboxListado)
        Margin = New Padding(3, 4, 3, 4)
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
End Class
