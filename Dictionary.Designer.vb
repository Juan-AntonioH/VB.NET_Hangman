<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dictionary
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Sort = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"hola", "adios", "pepe", "jose", "pelicula", "cualquiera", "cosa", "piedra", "azulejo", "profesor"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 47)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(166, 251)
        Me.ListBox1.TabIndex = 0
        '
        'Sort
        '
        Me.Sort.Location = New System.Drawing.Point(241, 47)
        Me.Sort.Name = "Sort"
        Me.Sort.Size = New System.Drawing.Size(75, 34)
        Me.Sort.TabIndex = 1
        Me.Sort.Text = "Sort"
        Me.Sort.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(241, 264)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 34)
        Me.Delete.TabIndex = 2
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(241, 207)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(75, 34)
        Me.Agregar.TabIndex = 3
        Me.Agregar.Text = "Add"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Dictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 328)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Sort)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Dictionary"
        Me.Text = "Dictionary"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Sort As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Agregar As Button
End Class
