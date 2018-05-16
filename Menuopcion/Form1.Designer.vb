<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_option1 = New System.Windows.Forms.Button()
        Me.btn_option2 = New System.Windows.Forms.Button()
        Me.btn_opcion3 = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_option1
        '
        Me.btn_option1.Location = New System.Drawing.Point(95, 38)
        Me.btn_option1.Name = "btn_option1"
        Me.btn_option1.Size = New System.Drawing.Size(75, 23)
        Me.btn_option1.TabIndex = 0
        Me.btn_option1.Text = "Opcion 1"
        Me.btn_option1.UseVisualStyleBackColor = True
        '
        'btn_option2
        '
        Me.btn_option2.Location = New System.Drawing.Point(95, 83)
        Me.btn_option2.Name = "btn_option2"
        Me.btn_option2.Size = New System.Drawing.Size(75, 23)
        Me.btn_option2.TabIndex = 1
        Me.btn_option2.Text = "Opcion 2"
        Me.btn_option2.UseVisualStyleBackColor = True
        '
        'btn_opcion3
        '
        Me.btn_opcion3.Location = New System.Drawing.Point(95, 131)
        Me.btn_opcion3.Name = "btn_opcion3"
        Me.btn_opcion3.Size = New System.Drawing.Size(75, 23)
        Me.btn_opcion3.TabIndex = 2
        Me.btn_opcion3.Text = "Opcion 3"
        Me.btn_opcion3.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(12, 189)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(235, 23)
        Me.btn_exit.TabIndex = 3
        Me.btn_exit.Text = "Salir"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 248)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_opcion3)
        Me.Controls.Add(Me.btn_option2)
        Me.Controls.Add(Me.btn_option1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_option1 As Button
    Friend WithEvents btn_option2 As Button
    Friend WithEvents btn_opcion3 As Button
    Friend WithEvents btn_exit As Button
End Class
