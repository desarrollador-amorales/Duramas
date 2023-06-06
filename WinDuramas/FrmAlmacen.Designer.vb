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
        GboxListado = New GroupBox()
        ListaDatos = New ListView()
        GboxListado.SuspendLayout()
        SuspendLayout()
        ' 
        ' GboxListado
        ' 
        GboxListado.Controls.Add(ListaDatos)
        GboxListado.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        GboxListado.Location = New Point(12, 12)
        GboxListado.Name = "GboxListado"
        GboxListado.Size = New Size(400, 473)
        GboxListado.TabIndex = 0
        GboxListado.TabStop = False
        GboxListado.Text = "Listado de Almacenes"
        ' 
        ' ListaDatos
        ' 
        ListaDatos.Location = New Point(15, 22)
        ListaDatos.Name = "ListaDatos"
        ListaDatos.Size = New Size(368, 427)
        ListaDatos.TabIndex = 0
        ListaDatos.UseCompatibleStateImageBehavior = False
        ' 
        ' FrmAlmacen
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 505)
        Controls.Add(GboxListado)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmAlmacen"
        Text = "FrmAlmacen"
        GboxListado.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GboxListado As GroupBox
    Friend WithEvents ListaDatos As ListView
End Class
