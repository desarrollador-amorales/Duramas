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
        GboxListado.Location = New Point(12, 12)
        GboxListado.Name = "GboxListado"
        GboxListado.Size = New Size(400, 473)
        GboxListado.TabIndex = 0
        GboxListado.TabStop = False
        GboxListado.Text = "Listado de Almacenes"
        ' 
        ' TxtCriterio1
        ' 
        TxtCriterio1.Location = New Point(162, 22)
        TxtCriterio1.Name = "TxtCriterio1"
        TxtCriterio1.Size = New Size(205, 23)
        TxtCriterio1.TabIndex = 2
        ' 
        ' TxtCriterio
        ' 
        TxtCriterio.Location = New Point(32, 22)
        TxtCriterio.Name = "TxtCriterio"
        TxtCriterio.Size = New Size(124, 23)
        TxtCriterio.TabIndex = 1
        ' 
        ' ListaDatos
        ' 
        ListaDatos.Location = New Point(15, 51)
        ListaDatos.Name = "ListaDatos"
        ListaDatos.Size = New Size(368, 404)
        ListaDatos.TabIndex = 0
        ListaDatos.UseCompatibleStateImageBehavior = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmdNuevo)
        GroupBox1.Location = New Point(423, 428)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(362, 57)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' cmdNuevo
        ' 
        cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), Image)
        cmdNuevo.Location = New Point(6, 12)
        cmdNuevo.Name = "cmdNuevo"
        cmdNuevo.Size = New Size(47, 39)
        cmdNuevo.TabIndex = 0
        cmdNuevo.UseVisualStyleBackColor = True
        ' 
        ' FrmAlmacen
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 505)
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
End Class
