Imports System.Threading

Public Class Form2
    Public hilo As Thread
    Public indice As Integer
    Private Sub CargarDatosHilo(ByVal cargar As DataGridView, idgrupo As String)
        '' rancio(DataGridView1, txtnombreB.Text)
        '      Me.Refresh()
        ' hilo.Abort()
    End Sub

    Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        '   Me.CheckForIllegalCrossThreadCalls = False
        '  hilo = New Thread(New ThreadStart(AddressOf CargarDatosHilo))
        '  hilo.Start()
        '  DataGridView1.Refresh()
        conexionbdsql("Select texts.id,name from texts where texts.name ='" & txtnombreB.Text & "'", DataGridView1)
        DataGridView1.Refresh()
        DataGridView1.RefreshEdit()
    End Sub
    Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        indice = e.RowIndex
        PictureBox2.ImageLocation = ADMBD.Carpeta & "\pics\" & (DataGridView1.Rows(indice).Cells(0).Value) & ".jpg"
        conexionbdsql("Select name from texts where texts.id=" & DataGridView1.Rows(indice).Cells(0).Value, txtNombre)
        conexionbdsql("Select desc from texts where texts.id=" & DataGridView1.Rows(indice).Cells(0).Value, txtDescripcion)
    End Sub
    Delegate Sub pasar(ByVal cargar As DataGridView, idgrupo As String)
    Sub rancio(ByVal cargar As DataGridView, idgrupo As String)
        If InvokeRequired Then
            Invoke(New pasar(AddressOf rancio))
        Else
            cargar.Rows.Clear()
            If (conexioninfo.State = ConnectionState.Open) Then
                conexioninfo.Close()
            End If
            conexionbdsql("Select datas.id,name from datas,texts where datas.id=texts.id and texts.name= '" & idgrupo & "'", DataGridView1)
            Me.Refresh()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Modificar("texts", "name='" & txtNombre.Text & "'", "id=" & DataGridView1.Rows(indice).Cells(0).Value)
        Modificar("texts", "desc='" & txtDescripcion.Text & "'", "id=" & DataGridView1.Rows(indice).Cells(0).Value)
        If (conexionbdsql("select name from texts where name= name='" & txtNombre.Text & "'", True)) Then
            MsgBox("Modificacion con Error")
        Else
            MsgBox("Modificacion con exito")
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        conecta()
        conexionbdsql("Select datas.id,name from datas,texts where datas.id=texts.id ", DataGridView1)
        DataGridView1.Refresh()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        conexionbdsql("Select datas.id,name from datas,texts where datas.id=texts.id ", DataGridView1)
        DataGridView1.Refresh()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 5000
        Timer1.Enabled = True

    End Sub

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        MsgBox("hola")

    End Sub
End Class