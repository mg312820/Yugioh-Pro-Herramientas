Public Class Banlist
    Private Sub ListBox4_SelectedIndexChanged(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox4.MouseDown
        Dim Selecteditems As String = ListBox4.SelectedItem
        MsgBox(Selecteditems)
        ListBox4.DoDragDrop(Selecteditems, DragDropEffects.Copy Or DragDropEffects.Move)
    End Sub
    Private Sub TextBox1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub
    Private Sub TextBox1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragDrop
        ListBox1.Items.Add(e.Data.GetData(DataFormats.Text).ToString)
    End Sub

End Class