<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DictionaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Z = New System.Windows.Forms.Button()
        Me.Y = New System.Windows.Forms.Button()
        Me.X = New System.Windows.Forms.Button()
        Me.W = New System.Windows.Forms.Button()
        Me.V = New System.Windows.Forms.Button()
        Me.U = New System.Windows.Forms.Button()
        Me.A = New System.Windows.Forms.Button()
        Me.T = New System.Windows.Forms.Button()
        Me.S = New System.Windows.Forms.Button()
        Me.R = New System.Windows.Forms.Button()
        Me.Q = New System.Windows.Forms.Button()
        Me.P = New System.Windows.Forms.Button()
        Me.O = New System.Windows.Forms.Button()
        Me.N = New System.Windows.Forms.Button()
        Me.M = New System.Windows.Forms.Button()
        Me.L = New System.Windows.Forms.Button()
        Me.K = New System.Windows.Forms.Button()
        Me.I = New System.Windows.Forms.Button()
        Me.G = New System.Windows.Forms.Button()
        Me.J = New System.Windows.Forms.Button()
        Me.H = New System.Windows.Forms.Button()
        Me.F = New System.Windows.Forms.Button()
        Me.E = New System.Windows.Forms.Button()
        Me.D = New System.Windows.Forms.Button()
        Me.C = New System.Windows.Forms.Button()
        Me.B = New System.Windows.Forms.Button()
        Me.ComoJugarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Tip = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DictionaryToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(569, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'DictionaryToolStripMenuItem
        '
        Me.DictionaryToolStripMenuItem.Name = "DictionaryToolStripMenuItem"
        Me.DictionaryToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.DictionaryToolStripMenuItem.Text = "Dictionary"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComoJugarToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "A. Failed:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(43, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Z)
        Me.Panel1.Controls.Add(Me.Y)
        Me.Panel1.Controls.Add(Me.X)
        Me.Panel1.Controls.Add(Me.W)
        Me.Panel1.Controls.Add(Me.V)
        Me.Panel1.Controls.Add(Me.U)
        Me.Panel1.Controls.Add(Me.A)
        Me.Panel1.Controls.Add(Me.T)
        Me.Panel1.Controls.Add(Me.S)
        Me.Panel1.Controls.Add(Me.R)
        Me.Panel1.Controls.Add(Me.Q)
        Me.Panel1.Controls.Add(Me.P)
        Me.Panel1.Controls.Add(Me.O)
        Me.Panel1.Controls.Add(Me.N)
        Me.Panel1.Controls.Add(Me.M)
        Me.Panel1.Controls.Add(Me.L)
        Me.Panel1.Controls.Add(Me.K)
        Me.Panel1.Controls.Add(Me.I)
        Me.Panel1.Controls.Add(Me.G)
        Me.Panel1.Controls.Add(Me.J)
        Me.Panel1.Controls.Add(Me.H)
        Me.Panel1.Controls.Add(Me.F)
        Me.Panel1.Controls.Add(Me.E)
        Me.Panel1.Controls.Add(Me.D)
        Me.Panel1.Controls.Add(Me.C)
        Me.Panel1.Controls.Add(Me.B)
        Me.Panel1.Location = New System.Drawing.Point(370, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 276)
        Me.Panel1.TabIndex = 5
        '
        'Z
        '
        Me.Z.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Z.Location = New System.Drawing.Point(117, 195)
        Me.Z.Name = "Z"
        Me.Z.Size = New System.Drawing.Size(30, 30)
        Me.Z.TabIndex = 28
        Me.Z.TabStop = False
        Me.Z.Text = "Z"
        Me.Z.UseVisualStyleBackColor = True
        '
        'Y
        '
        Me.Y.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Y.Location = New System.Drawing.Point(45, 195)
        Me.Y.Name = "Y"
        Me.Y.Size = New System.Drawing.Size(30, 30)
        Me.Y.TabIndex = 26
        Me.Y.TabStop = False
        Me.Y.Text = "Y"
        Me.Y.UseVisualStyleBackColor = True
        '
        'X
        '
        Me.X.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.X.Location = New System.Drawing.Point(153, 159)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(30, 30)
        Me.X.TabIndex = 24
        Me.X.TabStop = False
        Me.X.Text = "X"
        Me.X.UseVisualStyleBackColor = True
        '
        'W
        '
        Me.W.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.W.Location = New System.Drawing.Point(117, 159)
        Me.W.Name = "W"
        Me.W.Size = New System.Drawing.Size(30, 30)
        Me.W.TabIndex = 23
        Me.W.TabStop = False
        Me.W.Text = "W"
        Me.W.UseVisualStyleBackColor = True
        '
        'V
        '
        Me.V.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V.Location = New System.Drawing.Point(81, 159)
        Me.V.Name = "V"
        Me.V.Size = New System.Drawing.Size(30, 30)
        Me.V.TabIndex = 22
        Me.V.TabStop = False
        Me.V.Text = "V"
        Me.V.UseVisualStyleBackColor = True
        '
        'U
        '
        Me.U.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U.Location = New System.Drawing.Point(45, 159)
        Me.U.Name = "U"
        Me.U.Size = New System.Drawing.Size(30, 30)
        Me.U.TabIndex = 21
        Me.U.TabStop = False
        Me.U.Text = "U"
        Me.U.UseVisualStyleBackColor = True
        '
        'A
        '
        Me.A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A.Location = New System.Drawing.Point(8, 15)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(30, 30)
        Me.A.TabIndex = 0
        Me.A.TabStop = False
        Me.A.Text = "A"
        Me.A.UseVisualStyleBackColor = True
        '
        'T
        '
        Me.T.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T.Location = New System.Drawing.Point(9, 159)
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(30, 30)
        Me.T.TabIndex = 20
        Me.T.TabStop = False
        Me.T.Text = "T"
        Me.T.UseVisualStyleBackColor = True
        '
        'S
        '
        Me.S.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S.Location = New System.Drawing.Point(152, 123)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(30, 30)
        Me.S.TabIndex = 19
        Me.S.TabStop = False
        Me.S.Text = "S"
        Me.S.UseVisualStyleBackColor = True
        '
        'R
        '
        Me.R.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R.Location = New System.Drawing.Point(116, 123)
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(30, 30)
        Me.R.TabIndex = 18
        Me.R.TabStop = False
        Me.R.Text = "R"
        Me.R.UseVisualStyleBackColor = True
        '
        'Q
        '
        Me.Q.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q.Location = New System.Drawing.Point(80, 123)
        Me.Q.Name = "Q"
        Me.Q.Size = New System.Drawing.Size(30, 30)
        Me.Q.TabIndex = 17
        Me.Q.TabStop = False
        Me.Q.Text = "Q"
        Me.Q.UseVisualStyleBackColor = True
        '
        'P
        '
        Me.P.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P.Location = New System.Drawing.Point(44, 123)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(30, 30)
        Me.P.TabIndex = 16
        Me.P.TabStop = False
        Me.P.Text = "P"
        Me.P.UseVisualStyleBackColor = True
        '
        'O
        '
        Me.O.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.O.Location = New System.Drawing.Point(8, 123)
        Me.O.Name = "O"
        Me.O.Size = New System.Drawing.Size(30, 30)
        Me.O.TabIndex = 15
        Me.O.TabStop = False
        Me.O.Text = "O"
        Me.O.UseVisualStyleBackColor = True
        '
        'N
        '
        Me.N.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N.Location = New System.Drawing.Point(117, 87)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(30, 30)
        Me.N.TabIndex = 13
        Me.N.TabStop = False
        Me.N.Text = "N"
        Me.N.UseVisualStyleBackColor = True
        '
        'M
        '
        Me.M.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M.Location = New System.Drawing.Point(81, 87)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(30, 30)
        Me.M.TabIndex = 12
        Me.M.TabStop = False
        Me.M.Text = "M"
        Me.M.UseVisualStyleBackColor = True
        '
        'L
        '
        Me.L.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.Location = New System.Drawing.Point(45, 87)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(30, 30)
        Me.L.TabIndex = 11
        Me.L.TabStop = False
        Me.L.Text = "L"
        Me.L.UseVisualStyleBackColor = True
        '
        'K
        '
        Me.K.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K.Location = New System.Drawing.Point(9, 87)
        Me.K.Name = "K"
        Me.K.Size = New System.Drawing.Size(30, 30)
        Me.K.TabIndex = 10
        Me.K.TabStop = False
        Me.K.Text = "K"
        Me.K.UseVisualStyleBackColor = True
        '
        'I
        '
        Me.I.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.I.Location = New System.Drawing.Point(116, 51)
        Me.I.Name = "I"
        Me.I.Size = New System.Drawing.Size(30, 30)
        Me.I.TabIndex = 9
        Me.I.TabStop = False
        Me.I.Text = "I"
        Me.I.UseVisualStyleBackColor = True
        '
        'G
        '
        Me.G.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G.Location = New System.Drawing.Point(44, 51)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(30, 30)
        Me.G.TabIndex = 8
        Me.G.TabStop = False
        Me.G.Text = "G"
        Me.G.UseVisualStyleBackColor = True
        '
        'J
        '
        Me.J.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.J.Location = New System.Drawing.Point(152, 51)
        Me.J.Name = "J"
        Me.J.Size = New System.Drawing.Size(30, 30)
        Me.J.TabIndex = 7
        Me.J.TabStop = False
        Me.J.Text = "J"
        Me.J.UseVisualStyleBackColor = True
        '
        'H
        '
        Me.H.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H.Location = New System.Drawing.Point(80, 51)
        Me.H.Name = "H"
        Me.H.Size = New System.Drawing.Size(30, 30)
        Me.H.TabIndex = 6
        Me.H.TabStop = False
        Me.H.Text = "H"
        Me.H.UseVisualStyleBackColor = True
        '
        'F
        '
        Me.F.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F.Location = New System.Drawing.Point(9, 51)
        Me.F.Name = "F"
        Me.F.Size = New System.Drawing.Size(30, 30)
        Me.F.TabIndex = 5
        Me.F.TabStop = False
        Me.F.Text = "F"
        Me.F.UseVisualStyleBackColor = True
        '
        'E
        '
        Me.E.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E.Location = New System.Drawing.Point(153, 15)
        Me.E.Name = "E"
        Me.E.Size = New System.Drawing.Size(30, 30)
        Me.E.TabIndex = 4
        Me.E.TabStop = False
        Me.E.Text = "E"
        Me.E.UseVisualStyleBackColor = True
        '
        'D
        '
        Me.D.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D.Location = New System.Drawing.Point(117, 15)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(30, 30)
        Me.D.TabIndex = 3
        Me.D.TabStop = False
        Me.D.Text = "D"
        Me.D.UseVisualStyleBackColor = True
        '
        'C
        '
        Me.C.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C.Location = New System.Drawing.Point(81, 15)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(30, 30)
        Me.C.TabIndex = 2
        Me.C.TabStop = False
        Me.C.Text = "C"
        Me.C.UseVisualStyleBackColor = True
        '
        'B
        '
        Me.B.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B.Location = New System.Drawing.Point(45, 15)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(30, 30)
        Me.B.TabIndex = 1
        Me.B.TabStop = False
        Me.B.Text = "Button1"
        Me.B.UseVisualStyleBackColor = True
        '
        'ComoJugarToolStripMenuItem
        '
        Me.ComoJugarToolStripMenuItem.Name = "ComoJugarToolStripMenuItem"
        Me.ComoJugarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ComoJugarToolStripMenuItem.Text = "Como Jugar"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Image = Global.practicahangman.My.Resources.Resources.imagen11
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.practicahangman.My.Resources.Resources.imagen1
        Me.PictureBox1.Location = New System.Drawing.Point(29, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 314)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Tip
        '
        Me.Tip.Enabled = False
        Me.Tip.Image = Global.practicahangman.My.Resources.Resources.tip
        Me.Tip.Location = New System.Drawing.Point(144, 36)
        Me.Tip.Name = "Tip"
        Me.Tip.Size = New System.Drawing.Size(60, 60)
        Me.Tip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Tip.TabIndex = 3
        Me.Tip.TabStop = False
        Me.Tip.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 442)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Tip)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DictionaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Tip As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Z As Button
    Friend WithEvents Y As Button
    Friend WithEvents X As Button
    Friend WithEvents W As Button
    Friend WithEvents V As Button
    Friend WithEvents U As Button
    Friend WithEvents T As Button
    Friend WithEvents S As Button
    Friend WithEvents R As Button
    Friend WithEvents Q As Button
    Friend WithEvents P As Button
    Friend WithEvents O As Button
    Friend WithEvents N As Button
    Friend WithEvents M As Button
    Friend WithEvents L As Button
    Friend WithEvents K As Button
    Friend WithEvents I As Button
    Friend WithEvents G As Button
    Friend WithEvents J As Button
    Friend WithEvents H As Button
    Friend WithEvents F As Button
    Friend WithEvents E As Button
    Friend WithEvents D As Button
    Friend WithEvents C As Button
    Friend WithEvents B As Button
    Friend WithEvents A As Button
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComoJugarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
End Class
