<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBancos
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FrmBancos))
        GroupBox1 = New GroupBox()
        ListaDatos = New ListView()
        TxtCriterio1 = New TextBox()
        TxtCriterio = New TextBox()
        GroupBox2 = New GroupBox()
        TxtCoopJep = New TextBox()
        TxtCodProdubanco = New TextBox()
        TxtCodPichincha = New TextBox()
        TxtCodGye = New TextBox()
        TxtDescripcion = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TxtCampos0 = New TextBox()
        Label1 = New Label()
        GroupBox3 = New GroupBox()
        CmdSalir = New Button()
        CmdImprimir = New Button()
        CmdEliminar = New Button()
        CmdGrabar = New Button()
        cmdNuevo = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ListaDatos)
        GroupBox1.Controls.Add(TxtCriterio1)
        GroupBox1.Controls.Add(TxtCriterio)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(396, 384)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Listado Bancos"
        ' 
        ' ListaDatos
        ' 
        ListaDatos.AllowColumnReorder = True
        ListaDatos.FullRowSelect = True
        ListaDatos.Location = New Point(6, 70)
        ListaDatos.Name = "ListaDatos"
        ListaDatos.Size = New Size(367, 308)
        ListaDatos.TabIndex = 2
        ListaDatos.UseCompatibleStateImageBehavior = False
        ListaDatos.View = View.Details
        ' 
        ' TxtCriterio1
        ' 
        TxtCriterio1.Location = New Point(102, 26)
        TxtCriterio1.Name = "TxtCriterio1"
        TxtCriterio1.Size = New Size(271, 27)
        TxtCriterio1.TabIndex = 1
        ' 
        ' TxtCriterio
        ' 
        TxtCriterio.Location = New Point(6, 26)
        TxtCriterio.Name = "TxtCriterio"
        TxtCriterio.Size = New Size(90, 27)
        TxtCriterio.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TxtCoopJep)
        GroupBox2.Controls.Add(TxtCodProdubanco)
        GroupBox2.Controls.Add(TxtCodPichincha)
        GroupBox2.Controls.Add(TxtCodGye)
        GroupBox2.Controls.Add(TxtDescripcion)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(TxtCampos0)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(427, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(439, 258)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos del Banco"
        ' 
        ' TxtCoopJep
        ' 
        TxtCoopJep.Location = New Point(222, 225)
        TxtCoopJep.Margin = New Padding(3, 4, 3, 4)
        TxtCoopJep.Name = "TxtCoopJep"
        TxtCoopJep.Size = New Size(188, 27)
        TxtCoopJep.TabIndex = 13
        ' 
        ' TxtCodProdubanco
        ' 
        TxtCodProdubanco.Location = New Point(222, 187)
        TxtCodProdubanco.Margin = New Padding(3, 4, 3, 4)
        TxtCodProdubanco.Name = "TxtCodProdubanco"
        TxtCodProdubanco.Size = New Size(188, 27)
        TxtCodProdubanco.TabIndex = 12
        ' 
        ' TxtCodPichincha
        ' 
        TxtCodPichincha.Location = New Point(222, 151)
        TxtCodPichincha.Margin = New Padding(3, 4, 3, 4)
        TxtCodPichincha.Name = "TxtCodPichincha"
        TxtCodPichincha.Size = New Size(188, 27)
        TxtCodPichincha.TabIndex = 11
        ' 
        ' TxtCodGye
        ' 
        TxtCodGye.Location = New Point(222, 111)
        TxtCodGye.Margin = New Padding(3, 4, 3, 4)
        TxtCodGye.Name = "TxtCodGye"
        TxtCodGye.Size = New Size(188, 27)
        TxtCodGye.TabIndex = 10
        ' 
        ' TxtDescripcion
        ' 
        TxtDescripcion.Location = New Point(156, 76)
        TxtDescripcion.Margin = New Padding(3, 4, 3, 4)
        TxtDescripcion.Name = "TxtDescripcion"
        TxtDescripcion.Size = New Size(254, 27)
        TxtDescripcion.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(40, 228)
        Label6.Name = "Label6"
        Label6.Size = New Size(167, 20)
        Label6.TabIndex = 8
        Label6.Text = "Código CooperativaJEP:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(40, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 20)
        Label5.TabIndex = 7
        Label5.Text = "Código ProduBanco:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(172, 20)
        Label4.TabIndex = 6
        Label4.Text = "Código Banco Pichincha:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(176, 20)
        Label3.TabIndex = 5
        Label3.Text = "Código Banco Guayaquil:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 4
        Label2.Text = "Descripcion:"
        ' 
        ' TxtCampos0
        ' 
        TxtCampos0.Location = New Point(156, 35)
        TxtCampos0.Margin = New Padding(3, 4, 3, 4)
        TxtCampos0.Name = "TxtCampos0"
        TxtCampos0.Size = New Size(90, 27)
        TxtCampos0.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 20)
        Label1.TabIndex = 1
        Label1.Text = "Código:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(CmdSalir)
        GroupBox3.Controls.Add(CmdImprimir)
        GroupBox3.Controls.Add(CmdEliminar)
        GroupBox3.Controls.Add(CmdGrabar)
        GroupBox3.Controls.Add(cmdNuevo)
        GroupBox3.Location = New Point(440, 303)
        GroupBox3.Margin = New Padding(3, 4, 3, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 4, 3, 4)
        GroupBox3.Size = New Size(414, 76)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        ' 
        ' CmdSalir
        ' 
        CmdSalir.Image = CType(resources.GetObject("CmdSalir.Image"), Image)
        CmdSalir.Location = New Point(331, 17)
        CmdSalir.Name = "CmdSalir"
        CmdSalir.Size = New Size(54, 52)
        CmdSalir.TabIndex = 4
        CmdSalir.UseVisualStyleBackColor = True
        ' 
        ' CmdImprimir
        ' 
        CmdImprimir.Image = CType(resources.GetObject("CmdImprimir.Image"), Image)
        CmdImprimir.Location = New Point(256, 17)
        CmdImprimir.Name = "CmdImprimir"
        CmdImprimir.Size = New Size(54, 52)
        CmdImprimir.TabIndex = 3
        CmdImprimir.UseVisualStyleBackColor = True
        ' 
        ' CmdEliminar
        ' 
        CmdEliminar.Image = CType(resources.GetObject("CmdEliminar.Image"), Image)
        CmdEliminar.Location = New Point(181, 17)
        CmdEliminar.Name = "CmdEliminar"
        CmdEliminar.Size = New Size(54, 52)
        CmdEliminar.TabIndex = 2
        CmdEliminar.UseVisualStyleBackColor = True
        ' 
        ' CmdGrabar
        ' 
        CmdGrabar.Image = CType(resources.GetObject("CmdGrabar.Image"), Image)
        CmdGrabar.Location = New Point(105, 17)
        CmdGrabar.Name = "CmdGrabar"
        CmdGrabar.Size = New Size(54, 52)
        CmdGrabar.TabIndex = 1
        CmdGrabar.UseVisualStyleBackColor = True
        ' 
        ' cmdNuevo
        ' 
        cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), Image)
        cmdNuevo.Location = New Point(30, 17)
        cmdNuevo.Name = "cmdNuevo"
        cmdNuevo.Size = New Size(54, 52)
        cmdNuevo.TabIndex = 0
        cmdNuevo.UseVisualStyleBackColor = True
        ' 
        ' FrmBancos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(878, 408)
        ControlBox = False
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "FrmBancos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mantenimiento de Bancos"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCriterio As TextBox
    Friend WithEvents TxtCriterio1 As TextBox
    Friend WithEvents ListaDatos As ListView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCampos0 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCodPichincha As TextBox
    Friend WithEvents TxtCodGye As TextBox
    Friend WithEvents TxtCodProdubanco As TextBox
    Friend WithEvents TxtCoopJep As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmdSalir As Button
    Friend WithEvents CmdImprimir As Button
    Friend WithEvents CmdEliminar As Button
    Friend WithEvents CmdGrabar As Button
    Friend WithEvents cmdNuevo As Button
End Class
