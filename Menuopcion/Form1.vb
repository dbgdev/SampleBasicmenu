Public Class Form1
    Dim formOpt2 As Form
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_option1_Click(sender As Object, e As EventArgs) Handles btn_option1.Click
        'Sample launch menu
        MsgBox("Launch option 1")
    End Sub

    Private Sub btn_option2_Click(sender As Object, e As EventArgs) Handles btn_option2.Click
        If IsNothing(formOpt2) Then
            formOpt2 = New Form()
            'formOpt2.Name = "Prueba de ventanas de menu"
            formOpt2.Text = "Titulo de la ventana"
            formOpt2.Refresh()
            formOpt2.Show()
        End If
    End Sub
End Class
