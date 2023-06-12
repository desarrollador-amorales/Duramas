<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormLogin))
        lblUser = New Label()
        lblContrasena = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        btnIngresar = New Button()
        PictureBox1 = New PictureBox()
        btnCancelar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Location = New Point(144, 47)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(50, 15)
        lblUser.TabIndex = 0
        lblUser.Text = "Usuario:"
        ' 
        ' lblContrasena
        ' 
        lblContrasena.AutoSize = True
        lblContrasena.Location = New Point(144, 90)
        lblContrasena.Name = "lblContrasena"
        lblContrasena.Size = New Size(70, 15)
        lblContrasena.TabIndex = 1
        lblContrasena.Text = "Contraseña:"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(225, 42)
        txtUser.Margin = New Padding(3, 2, 3, 2)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(115, 23)
        txtUser.TabIndex = 2
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(225, 88)
        txtPass.Margin = New Padding(3, 2, 3, 2)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(115, 23)
        txtPass.TabIndex = 3
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Location = New Point(127, 140)
        btnIngresar.Margin = New Padding(3, 2, 3, 2)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(85, 27)
        btnIngresar.TabIndex = 4
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(51, 47)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 62)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(255, 140)
        btnCancelar.Margin = New Padding(3, 2, 3, 2)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(85, 27)
        btnCancelar.TabIndex = 6
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(424, 194)
        ControlBox = False
        Controls.Add(btnCancelar)
        Controls.Add(PictureBox1)
        Controls.Add(btnIngresar)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(lblContrasena)
        Controls.Add(lblUser)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormLogin"
        Text = "Acceso de Usuarios"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents lblContrasena As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCancelar As Button
End Class
