Public Class Dictionary
    Dim orden As Boolean = False
    Private Sub Sort_Click(sender As Object, e As EventArgs) Handles Sort.Click
        'Genera una lista con todas las palabras del listbox
        Dim lista As New List(Of Object)
        For Each item In ListBox1.Items
            lista.Add(item)
        Next
        ListBox1.Items.Clear() ' limpia el listbox

        If Not orden Then 'si no esta ordenado, lo ordena de A-Z
            lista.Sort()
            orden = True
        Else ' si esta ordenado, invierte la lista.
            lista.Sort()
            lista.Reverse()
            orden = False
        End If
        ListBox1.Items.AddRange(lista.ToArray) 'Añade todas las palabras ordenadas en el listbox
    End Sub


    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If ListBox1.SelectedItem = Nothing Then ' si no seleccionas palabra te avisa.
            MsgBox("No tienes ninguna palabra seleccionada.")
        Else
            Dim resultado As DialogResult = MessageBox.Show("¿Quieres eliminar la palabra?" & vbCrLf & vbCrLf & ListBox1.SelectedItem.ToString, "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If resultado = DialogResult.OK Then ' borra palabra seleccionada si aceptas.
                ListBox1.Items.Remove(ListBox1.SelectedItem)
            End If
        End If
        ComprobarLista() 'Comprueba que no tengas 5 o menos palabras
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click

        Dim palabra As String = InputBox("Ingrese una palabra: ", "Entrada de palabra")

        If String.IsNullOrEmpty(palabra) Then 'Si las palabra puesta es nula o vacia te avisa

            MessageBox.Show("No se ingresó ninguna palabra.", "Información")
        Else
            If ListBox1.Items.Contains(LCase(palabra)) Then ' si la palabra esta en la lista, te avisa.
                MessageBox.Show("La palabra: " & palabra & " ya esta en la lista", "Información")
            Else 'Agrega a la lista la nueva palabra
                MessageBox.Show("La palabra añadida a la lista es: " & palabra, "Información")
                ListBox1.Items.Add(LCase(palabra))
            End If
        End If
    End Sub
    Private Sub ComprobarLista()
        If ListBox1.Items.Count <= 5 Then
            Delete.Enabled = False
        Else
            Delete.Enabled = True
        End If
    End Sub

    Private Sub Dictionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComprobarLista()
    End Sub
End Class