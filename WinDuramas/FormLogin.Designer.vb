﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        lblUser.Location = New Point(165, 63)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(62, 20)
        lblUser.TabIndex = 0
        lblUser.Text = "Usuario:"
        ' 
        ' lblContrasena
        ' 
        lblContrasena.AutoSize = True
        lblContrasena.Location = New Point(165, 120)
        lblContrasena.Name = "lblContrasena"
        lblContrasena.Size = New Size(86, 20)
        lblContrasena.TabIndex = 1
        lblContrasena.Text = "Contraseña:"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(257, 56)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(131, 27)
        txtUser.TabIndex = 2
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(257, 117)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(131, 27)
        txtPass.TabIndex = 3
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Location = New Point(145, 187)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(97, 36)
        btnIngresar.TabIndex = 4
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(58, 63)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(75, 83)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(291, 187)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(97, 36)
        btnCancelar.TabIndex = 6
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(485, 259)
        ControlBox = False
        Controls.Add(btnCancelar)
        Controls.Add(PictureBox1)
        Controls.Add(btnIngresar)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(lblContrasena)
        Controls.Add(lblUser)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
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
