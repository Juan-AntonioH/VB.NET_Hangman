Public Class Form1
    Dim fails As Integer = 0
    Public maxFails As Integer = 10
    Dim longitudPalabra As Integer
    Dim palabra As String
    Dim aciertos As Integer = 0
    Dim longitudLista As Integer
    Dim rnd As New Random()
    Dim ayuda As Boolean = True
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'NuevoJuego()
        activarBotones(False)
    End Sub
    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        NuevoJuego()
    End Sub
    Private Sub NuevoJuego() 'Inicia un nuevo juego reiniciando los botones, la ayuda, la imagen.
        Level.ShowDialog()
        EliminarPalabra()
        activarBotones(True)
        Tip.Visible = False
        Tip.Enabled = False
        ayuda = True
        fails = 0
        aciertos = 0
        TextBox1.Text = fails
        PictureBox1.Image = My.Resources.imagen1
        longitudLista = Dictionary.ListBox1.Items.Count
        palabra = UCase(Dictionary.ListBox1.Items.Item(rnd.Next(longitudLista)))
        longitudPalabra = palabra.Count
        GenerarPalabra()

    End Sub
    Private Sub activarBotones(habilitado As Boolean) ' Segun el parametro activa o desactiva todos los botones.
        Dim botones = Panel1.Controls
        For Each boton As Control In botones
            boton.Enabled = habilitado
        Next
    End Sub
    Private Sub ImagesHangman() 'Cambia la imagen segun el numero de fallos.
        Dim nombreImagen As String = "imagen" & fails + 1
        If fails = maxFails Then
            nombreImagen = "imagen11"
        End If
        Dim image As Image = DirectCast(My.Resources.ResourceManager.GetObject(nombreImagen), Image)
        PictureBox1.Image = image
    End Sub

    Private Sub GenerarPalabra() ' Crea labels en la posicion establecidad tantas veces como letras tiene la palabra.
        For index = 0 To longitudPalabra - 1
            Dim miLabel As New Label
            miLabel.Name = "palabra" & index
            miLabel.Parent = Me
            miLabel.Text = "_"
            miLabel.Width = 10
            miLabel.Top = 40
            miLabel.Left = 320 + index * miLabel.Width
        Next
    End Sub
    Private Sub EliminarPalabra() ' Elimina la palabra a descubrir.
        For index = 0 To longitudPalabra - 1
            Dim control As Control = Me.Controls.Item("palabra" & index)
            Me.Controls.Remove(control)
        Next
    End Sub
    Private Sub Tip_Click(sender As Object, e As EventArgs) Handles Tip.Click ' Al darle al icono, encuentra la siguiente letra faltante, y pone todas las que esten
        For index = 0 To longitudPalabra - 1
            If Controls("palabra" & index).Text = "_" Then
                Dim letra As Char
                letra = palabra(index) ' Letra equivalente a la letra que falta en la palabra
                ComprobarPalabra(letra)
                Tip.Visible = False
                Tip.Enabled = False
                Exit Sub
            End If
        Next
    End Sub

    Private Sub DictionaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DictionaryToolStripMenuItem.Click
        Dictionary.ShowDialog()
    End Sub

    Private Sub Button_click(sender As Button, e As EventArgs) Handles A.Click, Z.Click, Y.Click, X.Click, W.Click, V.Click, U.Click, T.Click, S.Click, R.Click, Q.Click, P.Click, O.Click, N.Click, M.Click, L.Click, K.Click, J.Click, I.Click, H.Click, G.Click, F.Click, E.Click, D.Click, C.Click, B.Click
        sender.Enabled = False
        ComprobarPalabra(sender.Text)
    End Sub
    Private Sub ComprobarPalabra(letra As String) ' Comprueba la letra si esta en la palabra oculta.
        Dim encontrado As Boolean = False
        'recorre la palabra, si encuentra letras que sean como la seleccionada, la muestra y suma aciertos.
        For index = 0 To longitudPalabra - 1
            Dim control As Control = Me.Controls.Item("palabra" & index)
            If palabra(index) = letra Then
                control.Text = letra
                Panel1.Controls.Item(letra).Enabled = False
                encontrado = True
                aciertos += 1
            End If
        Next
        'Si no encontro la letra, suma fallos y cambia imagen.
        If Not encontrado Then
            fails += 1
            TextBox1.Text = fails
            ImagesHangman()
        End If
        ComprobarGanador()
    End Sub
    Private Sub ComprobarGanador() 'Si acertastes todas o fallastes todos los intentos, se muestra un aviso.
        Dim comprobar As Boolean = False
        If aciertos = longitudPalabra Then
            MsgBox("Felicidades, has ganado.")
            comprobar = True
        ElseIf fails = maxFails Then
            MsgBox("Has perdido, intentalo de nuevo")
            comprobar = True
        End If
        If comprobar Then
            activarBotones(False)
            Tip.Visible = False
            Tip.Enabled = False
        End If
        If fails = 5 And ayuda Then
            Tip.Visible = True
            Tip.Enabled = True
            ayuda = False
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ComoJugarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComoJugarToolStripMenuItem.Click
        ComoJugar.ShowDialog() ' Muestra el formulario de ayuda para saber como funciona el juego
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AcercaDe.ShowDialog() ' Muestra el creador.
    End Sub
End Class
