Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports System.Runtime.InteropServices
Module Funcion
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Sub ReleaseCapture()
    End Sub 'Arrastrar panel
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub 'Arrastrar panel
    'Conexion Informix
    Sub selecionador(ParamArray opcion() As Form)
        For contador As Integer = 0 To opcion.Length - 1
            If opcion(contador).Visible Then
                opcion(contador).Close()
            End If
        Next
    End Sub
    Sub colocarpanel(panel As Panel, f2 As Object)
        f2.TopLevel = False
        f2.Parent = panel
        f2.Show()
    End Sub
    Sub agrandar(imagen As System.Object)
        imagen.Size = New Size(imagen.Size.Width + 15, imagen.Size.Height + 15) 'Agranda 5 pixel de ancho y alto de un objeto
    End Sub
    Sub achicar(imagen As System.Object)
        imagen.Size = New Size(imagen.Size.Width - 15, imagen.Size.Height - 15) 'Reduce 5 pixel de ancho y alto de un objeto
    End Sub
    Sub cerrar() 'Subrutina para cerrar el programa al apretar el boton x de la barra
        Application.Exit()
    End Sub
    Sub arrastrar(form As Form)
        ReleaseCapture()
        SendMessage(form.Handle, &H112&, &HF012&, 0)
    End Sub

    Sub limpieza(formulario As Form)   'limpia todo textbox del form
        For Each Control In formulario.Controls
            If TypeOf Control Is TextBox Then
                Control.text = ""
            End If
            If TypeOf Control Is NumericUpDown Then
                Control.Value = 0
            End If
        Next
    End Sub
    Sub verificarN(objeto As Object, evento As KeyPressEventArgs, limite As Integer)
        Dim acii As Integer = Asc(evento.KeyChar)
        If acii = 8 Or acii = 13 Then
            evento.Handled = False
        ElseIf objeto.text.ToString.Length > limite - 1 Then
            MsgBox("Se exedio el maximo")
            evento.Handled = True
        ElseIf (acii >= 48 And acii < 58) Then
            evento.Handled = False
        Else
            MsgBox("No introduzca simbolos o letras")
            evento.Handled = True
        End If
    End Sub
    Sub verificarD(evento As KeyPressEventArgs)
        Dim acii As Integer = Asc(evento.KeyChar)
        If acii = 8 Or acii = 13 Then
            evento.Handled = False
        ElseIf (acii >= 48 And acii < 58) Or acii = 77 Or acii = 53 Or acii = 109 Or acii = 115 Or acii = 32 Then
            evento.Handled = False
        Else
            MsgBox("No introduzca simbolos o letras sin ser M o S")
            evento.Handled = True
        End If
    End Sub
    Sub VerificarG(evento As KeyPressEventArgs)
        Dim acii As Integer = Asc(evento.KeyChar)
        If acii = 8 Or acii = 13 Then
            evento.Handled = False
        ElseIf (acii >= 48 And acii < 58) Or (acii >= 65 And acii < 91) Or (acii >= 97 And acii < 123) Or acii = 77 Or acii = 53 Or acii = 109 Or acii = 115 Or acii = 32 Then
            evento.Handled = False
        Else
            MsgBox("No introduzca simbolos ")
            evento.Handled = True
        End If
    End Sub
    Sub verificarC(evento As KeyPressEventArgs)
        Dim acii As Integer = Asc(evento.KeyChar)
        If acii = 8 Or acii = 13 Then
            evento.Handled = False
        ElseIf (acii >= 48 And acii < 58) Or acii = 46 Or acii = 64 Or (acii >= 65 And acii < 91) Or (acii >= 97 And acii < 123) Or acii = 77 Or acii = 53 Or acii = 109 Or acii = 115 Or acii = 32 Then
            evento.Handled = False
        Else
            MsgBox("No introduzca simbolos sin ser @ o punto")
            evento.Handled = True
        End If
    End Sub
    Sub verificar59(evento As KeyPressEventArgs)
        Dim acii As Integer = Asc(evento.KeyChar)
        If (acii > 64 And acii < 91) Or (acii > 96 And acii < 123) Or acii = 32 Or acii = 8 Or acii = 13 Then
            evento.Handled = False
        Else
            MsgBox("No introduzca simbolos o numeros")
            evento.Handled = True
        End If
    End Sub
    Sub VERIFICAR(texto As TextBox, opcion As Integer, Optional minimo As Double = 0, Optional maximo As Double = 10) 'Verificador por tamanio y tipo de informacion
        Select Case opcion
            Case 0
                If Not (IsNumeric(texto.Text)) Or texto.Text = "" Then
                    Dim salida As String = 0
                    For Each LETRA In texto.Text
                        Select Case Asc(LETRA)
                            Case 65 To 90, 97 To 122
                                salida = salida + LETRA
                            Case Else
                                texto.Text = ""
                        End Select
                    Next
                    texto.Text = ""
                End If
            Case 1
                If IsNumeric(texto.Text) Or texto.Text = "" Then
                    texto.Text = ""
                End If
            Case 3
                If (texto.Text.Length <= maximo And texto.Text.Length >= minimo) Then
                    MsgBox("No pasa el minimo o se exede el maximo" & texto.Text)
                End If
        End Select
    End Sub
    Function VERIFICAR(formulario As Form, opcion As Integer) 'Verificador mas especifico segun el caso
        For Each Control In formulario.Controls
            If TypeOf Control Is TextBox Then
                Select Case opcion
                    Case 1
                        VERIFICAR(Control, 1,,)
                    Case 2
                        If Control.text = "" Then
                            MsgBox("Esta vacio" & Control.Name)
                            Return False
                        Else
                            Return True
                        End If
                End Select
            End If
        Next
        Return MsgBox("hola")
    End Function
    Sub Colocar_pistas(textoa As TextBox, pista As String) 'Agregar pistas
        textoa.ForeColor = Color.Gray
        textoa.Text = pista
    End Sub
    Sub Sacar_pista(texto As TextBox, pista As String) 'Saca pistas
        If texto.Text.Equals(pista) Then
            texto.Text = String.Empty
            texto.ForeColor = SystemColors.WindowText
        End If
    End Sub
    Sub volver_A_colocar_pista(txt As TextBox, pista As String) 'coloca pista si esta vacio
        If txt.Text.Trim() = String.Empty Then
            txt.Text = pista
        End If
    End Sub
    Sub CambiarVentanas(Ventanaanterior As Form, ventananueva As Form) 'subrutina para cambiar de una ventana a otra
        ventananueva.Show()
        Ventanaanterior.Hide()
    End Sub
    Function CalculoNotas(nota As Double)
        Dim maximoA As Integer = conexionbdsql("select nombre from variableprograma WHERE utilidad='APROBADO' ORDER BY cast(nombre as int) desc ", 2)
        Dim minimor1 As Integer = conexionbdsql("select nombre from variableprograma WHERE utilidad='REPROBADO2' ORDER BY cast(nombre as int) asc ", 2)
        If conexionbdsql("select nombre from variableprograma WHERE utilidad='REPROBADO2' ORDER BY cast(nombre as int) desc ", 2) < nota And maximoA >= nota Then
            Return "Aprobado"
        ElseIf minimor1 <= nota And maximoA >= nota Then
            Return "Examen Diciembre"
        ElseIf conexionbdsql("select nombre from variableprograma WHERE utilidad='REPROBADO1' ORDER BY cast(nombre as int) asc ", 2) <= nota And minimor1 > nota Then
            Return "Examen Febrero"
        End If
        Return MsgBox("Error nota invalida")
    End Function
End Module
