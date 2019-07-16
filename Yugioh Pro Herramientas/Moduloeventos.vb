Module moduloeventos
    Dim panelactual As Integer = 15
    Sub menuDAdminidtstivoBotones(formulario As Form) 'Para cambiar paneles
        Try
            Select Case formulario.Name
                Case "Panel1"
                    panelactual = 0
            End Select

        Catch ex As Exception
            MsgBox("Error al cambiar ventana N 1.2")
        End Try
    End Sub
    Sub esconder() 'Panel corredizo
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
    Delegate Sub pasar(ByVal cargar As DataGridView, idgrupo As Integer)
End Module
