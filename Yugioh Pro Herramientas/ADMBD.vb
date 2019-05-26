Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Module ADMBD
    Dim comando As New SQLite.SQLiteCommand
    Public confconexion As String
    Public conexioninfo As New SQLite.SQLiteConnection
    Dim tipo As Integer
    Public Carpeta As String
    Sub conecta()
        Dim OpenFileDialog1 As New OpenFileDialog
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Carpeta = IO.Path.GetDirectoryName(OpenFileDialog1.FileName)
            confconexion = "Data Source=" & OpenFileDialog1.FileName
        End If
    End Sub

    Function buscar(opcion As String, parametro As String)
        Try
            Select Case opcion
                Case "Nombre-id"
                    Return conexionbdsql("select name from datas,texts where datas.id=texts.id and texto.id ='" & parametro & "'", 2)
                Case "Nombre-Atributo"
                    Return conexionbdsql("Select Nombre persona where nombre='" & parametro & "'", 2)
                Case "ci-Nombre"
                    Return conexionbdsql("Select nombre from persona where ci='" & parametro & "'", 2)
                Case "Nombre-ID_Grupo"
                    Return conexionbdsql("Select ID_GRUPO from grupo where nombre='" & parametro & "'", 2)
                Case "Nombre-ID_Tipo_Nota"
                    Return conexionbdsql("Select ID_TIPO from tipo_nota where nombre='" & parametro & "'", 2)
                Case "Nombre-ID_Materia"
                    Return conexionbdsql("Select id_materia from Materia where nombre='" & parametro & "'", 2)
                Case "ID_Tipo_Nota-Nombre"
                    Return conexionbdsql("Select nombre from tipo_nota where ID_TIPO='" & parametro & "'", 2)
                Case "Nombre-id_local"
                    Return conexionbdsql("Select id_local from local where nombre='" & parametro & "'", 2)
                Case "Nombre-ID_Orientacion"
                    Return conexionbdsql("Select id_orientacion from orientacion where nombre='" & parametro & "'", 2)
                Case "ID_Grupo-Nombre"
                    Return conexionbdsql("Select nombre from grupo where id_grupo='" & parametro & "'", 2)
            End Select
            Return MsgBox("No coloco una opcion no valida en buscar Error N 5.1.1")
        Catch ex As Exception
            Return MsgBox("Error N 5.1 ")
        End Try
    End Function
    Function buscar(opcion As String, parametro As String, parametro2 As String)
        Try
            Select Case opcion
                Case "ci-NROlista"
                    Return conexionbdsql("select nro_lista from lista where ci = " & parametro & "and ID_GRUPO= " & parametro2, 2)
            End Select
            Return MsgBox("No coloco una opcion valida en buscar Error N 5.4.1")
        Catch ex As Exception
            MsgBox(" ")
        End Try
    End Function
    Public Function Conectar()
        Try
            If (conexioninfo.State = ConnectionState.Open) Then
                conexioninfo.Close()
            End If
            conexioninfo.ConnectionString = confconexion
            conexioninfo.Open()
            comando.Connection = conexioninfo
            Return True
        Catch ex As SqlException
            MsgBox("Error de conexion Base N 5.5 " & ex.Number)
            conexioninfo.Close()
            Return False
        Catch ex As Exception
            MsgBox("Error de Programa N 5.5.2 " & ex.Message)
            conexioninfo.Close()
            Return False
        End Try
    End Function
    Function conexionbdsql(consulta As String, allenar As System.Object)
        Try
            If Conectar() Then
                Dim ds As New DataSet
                comando.CommandText = consulta
                comando.ExecuteReader()
                Dim Adaptador As New SQLite.SQLiteDataAdapter(consulta, conexioninfo)
                Adaptador.Fill(ds)
                comando.Dispose()
                conexioninfo.Close()
                If (TypeOf allenar Is TextBox And ds.Tables(0).Rows.Count > 0) Then
                    allenar.text = ds.Tables(0).Rows(0).Item(0)
                    Exit Function
                ElseIf (TypeOf allenar Is TextBox And ds.Tables(0).Rows.Count = 0) Then
                    Return False
                End If
                If ds.Tables(0).Rows.Count = 0 Then
                    If (TypeOf allenar Is ComboBox Or TypeOf allenar Is ListView Or TypeOf allenar Is ListBox) Then
                        allenar.Items().Clear()
                        allenar.items.add("No tiene")
                        allenar.Selecteditem = ("No tiene")
                    End If
                    Return False
                End If
                If (ds.Tables(0).Rows.Count) > 0 Then 'verifica que tenga mas de una fila
                    If (TypeOf allenar Is Integer) Then
                        If allenar = 5 Then
                            Return ds
                        End If
                        If allenar <> 5 Then
                            Return ds.Tables(0).Rows(0).Item(0)
                        End If
                    End If
                    If (TypeOf allenar Is ComboBox Or TypeOf allenar Is ListView Or TypeOf allenar Is ListBox Or TypeOf allenar Is CheckedListBox) Then 'Permite llenar un combobox con lo devuelto de una consulta sql
                        If (TypeOf allenar Is ListView) Then
                            allenar.Clear()
                        End If
                        allenar.Items().Clear()
                        For I As Integer = 0 To ds.Tables(0).Rows.Count - 1
                            allenar.items.add(ds.Tables(0).Rows(I).Item(0))
                        Next
                        If (TypeOf allenar Is ComboBox) Then allenar.Selecteditem = (allenar.Items(0)) 'Selecciona el primer elemento del combobox
                    End If
                    If (TypeOf allenar Is DataGridView) Then 'llena un datagridview con la consulta
                        For I As Integer = 0 To allenar.Rows.count
                            allenar.DataSource = Nothing
                            allenar.Refresh()
                        Next
                        allenar.DataSource = ds.Tables(0)
                    End If
                End If
                If (TypeOf allenar Is Boolean And ds.Tables(0).Rows.Count = 0) Then
                    Return False
                ElseIf (TypeOf allenar Is Boolean And ds.Tables(0).Rows.Count <> 0) Then
                    Return True
                End If
                conexioninfo.Close() 'cierra conexion
                Return "opcion no valida"
            End If
        Catch ex As Exception
            MsgBox("Error consulta N 5.6" & ex.Message)
        End Try
    End Function
    Sub eliminar(tabla As String, valor1 As String)
        Try
            consultasUpDel("DELETE from" & tabla & " WHERE " & valor1)
        Catch ex As Exception
            MsgBox("Error en eliminar N 5.7")
        End Try

    End Sub
    Sub Modificar(tabla As String, valor1 As String, valor2 As String)
        Try
            consultasUpDel("UPDATE " & tabla & " Set " & valor1 & " WHERE " & valor2)
        Catch ex As Exception
            MsgBox("Error en modificacion N 5.8" & ex.Message)
        End Try
    End Sub
    Sub Insert(tabla As String, valor As String, valor2 As String, verificador As String)
        Try
            If (conexionbdsql("Select " & valor & " From " & tabla & " where " & verificador, True)) Then
                MsgBox("ya esta en la base")
            Else
                consultasUpDel("INSERT INTO " & tabla & "(" & valor & ") VALUES(" & valor2 & ")")
            End If
        Catch ex As Exception
            MsgBox("Error en insert N 5.9")
        End Try
    End Sub
    Sub Insert(tabla As String, valor As String, valor2 As String)
        Try
            consultasUpDel("INSERT INTO " & tabla & "(" & valor & ") VALUES(" & valor2 & ")")
        Catch ex As Exception
            MsgBox("Error en insert N 6")
        End Try
    End Sub
    Sub consultasUpDel(sql As String)
        Try
            If Conectar() Then
                comando.CommandText = sql
                comando.ExecuteNonQuery()
                conexioninfo.Close()
            End If
        Catch ex As Exception
            MsgBox("Error en Modificacion o alta N 6.1" & ex.Message)
        End Try
    End Sub
End Module
