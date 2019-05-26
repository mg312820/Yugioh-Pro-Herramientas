Public Class Form2
    Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        conexionbdsql("Select * from datas ", DataGridView1)
    End Sub

    Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conecta()
        conexionbdsql("Select datas.id,name from datas,texts where datas.id=texts.id ", DataGridView1)
    End Sub
End Class