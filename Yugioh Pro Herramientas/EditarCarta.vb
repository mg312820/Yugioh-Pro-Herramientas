Public Class EditarCarta
    Public indice As Integer
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        indice = e.RowIndex
        PictureBox2.ImageLocation = ADMBD.Carpeta & "\pics\" & (DataGridView1.Rows(indice).Cells(0).Value) & ".jpg"
        conexionbdsql("Select name from texts where texts.id=" & DataGridView1.Rows(indice).Cells(0).Value, txtNombre)
        conexionbdsql("Select desc from texts where texts.id=" & DataGridView1.Rows(indice).Cells(0).Value, txtDescripcion)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Modificar("texts", "name='" & txtNombre.Text & "'", "id=" & DataGridView1.Rows(indice).Cells(0).Value)
        Modificar("texts", "desc='" & txtDescripcion.Text & "'", "id=" & DataGridView1.Rows(indice).Cells(0).Value)
        Modificar("texts", "str15='Modificada'", "id=" & DataGridView1.Rows(indice).Cells(0).Value)
        If (conexionbdsql("select name from texts where name= name='" & txtNombre.Text & "'", True)) Then
            MsgBox("Modificacion con Error")
        Else
            MsgBox("Modificacion con exito")
        End If
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        conecta()
        conexionbdsql("Select datas.id,name from datas,texts where datas.id=texts.id ", DataGridView1)
        Label11.Text = DataGridView1.Rows.Count
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        conexionbdsql("Select datas.id,name from datas,texts where datas.id=texts.id ", DataGridView1)
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        conexionbdsql("Select texts.id,name from texts where name like '%" & txtnombreB.Text & "%'", DataGridView1)
        Label11.Text = DataGridView1.Rows.Count
    End Sub
    Private Sub CBAtributo_VisibleChanged(sender As Object, e As EventArgs) Handles CBAtributo.VisibleChanged
        Conecta2("Select Nombre from Atributos", CBAtributo)
        CBAtributo.SelectedIndex = 0
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(200, 100, 100, 100)
        Panel2.BackColor = Color.FromArgb(200, 100, 100, 100)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim result As DialogResult = FolderBrowserDialog1.ShowDialog
        If result = DialogResult.OK Then
            Carpeta = FolderBrowserDialog1.SelectedPath
            confconexion = "Data Source=" & FolderBrowserDialog1.SelectedPath & "\cards.cdb"
            conexionbdsql("Select datas.id,name from datas,texts where datas.id=texts.id ", DataGridView1)
            Label11.Text = DataGridView1.Rows.Count
        End If
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        conexionbdsql("Select texts.id,name from texts where id like '%" & txtid.Text & "%'", DataGridView1)
        Label11.Text = DataGridView1.Rows.Count
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim condicion As String = " "
        Dim contador As Integer = 0
        If CHBAtributo.CheckState = 1 Then
            condicion += "attribute='" & Conecta2("Select ID from Atributos where Nombre='" & CBAtributo.SelectedItem & "'", 2) & " ' "
            contador += 1
        End If
        If contador = 1 Then
            condicion += " and "
        End If
        If chbNombre.CheckState = 1 Then
            condicion += " name like '%" & txtnombreB.Text & "% "
            contador += 1
        End If
        If contador = 2 Then
            condicion += " and "
        End If
        If Chbnivel.CheckState = 1 Then
            condicion += " level = '" & cbnivel.SelectedItem & " '"
            contador += 1
        End If
        If contador = 3 Then
            condicion += " and "
        End If
        If ChbId.CheckState = 1 Then
            condicion += " texts.id = '" & txtid.Text & " '"
            contador += 1
        End If
        If contador = 4 Then
            condicion += " and "
        End If
        If ChbATKDEF.CheckState = 1 Then
            condicion += " atk = '" & TextBox5.Text & " ' and def='" & TextBox6.Text & "'"
            contador += 1
        End If
        MsgBox("Select texts.id,name from texts,datas where  datas.id = texts.id and " & condicion)

        conexionbdsql("Select texts.id,name from texts,datas where  datas.id = texts.id and " & condicion, DataGridView1)
        DataGridView1.RefreshEdit()
    End Sub
    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid.KeyPress
        verificarN(txtid, e, 25)
    End Sub
End Class