Public Class VentanaPrincipal
    Dim a As Boolean = True
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Application.Exit()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        colocarpanel(Panel2, EditarCarta)
    End Sub

    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseDown
        arrastrar(Me)
    End Sub
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If a Then
            Me.WindowState = FormWindowState.Maximized
            a = False
        Else
            Me.WindowState = FormWindowState.Normal
            a = True
        End If
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        colocarpanel(Panel2, Banlist)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        DataGridView1.DataSource = Nothing


    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        DataGridView1.DataSource = {1}
        DataGridView1.Refresh()

    End Sub
End Class
