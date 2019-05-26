Module moduloeventos
    Dim panelactual As Integer = 15
    Sub menuDAdminidtstivoBotones(formulario As Form)
        Try
            Select Case formulario.Name
                Case "Nuevo_Orientacion"
                    panelactual = 0
                Case "ADMNotatipos"
                    panelactual = 1
                Case "ADMMaterias"
                    panelactual = 2
                Case "nuevo_instituto"
                    panelactual = 3
                Case "Nuevo_grupo"
                    panelactual = 4
                Case "ADMAlumno"
                    panelactual = 5
                Case "Nuevo_Docente"
                    panelactual = 6
                Case "Agregar_Notas"
                    panelactual = 8
            End Select
            '        If MenuAdministrativo.Visible = True Then
            '        colocarpanel(MenuAdministrativo.Panel1, formulario) 'Cambiar Del Menu al menu correspondiente
            '       ElseIf MenuAdministrador.Visible = True Then
            '      colocarpanel(MenuAdministrador.Panel1, formulario) 'Cambiar Del Menu al menu correspondiente
            '       ElseIf MenuDocente.Visible = True Then
            '           colocarpanel(MenuDocente.Panel2, formulario)
            '        End If
        Catch ex As Exception
            MsgBox("Error al cambiar ventana N 1.2")
        End Try
    End Sub
    Sub esconder()
        ' Try
        '  If (ocultar2 = 0) Then
        '   Agregar_Notas.PanelEditarNotas.Location = New Point(0, 0)
        '   ocultar2 = 1
        '   ElseIf (ocultar2 = 1) Then
        '           Agregar_Notas.Panel1.Location = New Point(0, 0)
        ' '    Agregar_Notas.PanelEditarNotas.Location = New Point(800, -10)
        '   ocultar2 = 0
        '       End If
        '     Catch ex As Exception
        '    MsgBox("Error N 1.3")
        '    End Try
    End Sub
    Sub cargarmodificacionnota(e As DataGridViewCellEventArgs)
        '     CACHE = Agregar_Notas.DWGNotas.Rows.Item(e.RowIndex).Cells(0).Value
        '     Agregar_Notas.DateTimePicker2.Value = Agregar_Notas.DWGNotas.Rows.Item(e.RowIndex).Cells(4).Value
        '      Agregar_Notas.CBTiponotas.SelectedItem = Agregar_Notas.DWGNotas.Rows.Item(e.RowIndex).Cells(5).Value
        '     Agregar_Notas.cbnotas2.SelectedItem = Agregar_Notas.DWGNotas.Rows.Item(e.RowIndex).Cells(3).Value.ToString
    End Sub
    Delegate Sub pasar(ByVal cargar As DataGridView, idgrupo As Integer)
End Module
