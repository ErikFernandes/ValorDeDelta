<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fundo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.LabelA = New System.Windows.Forms.Label()
        Me.LabelB = New System.Windows.Forms.Label()
        Me.LabelC = New System.Windows.Forms.Label()
        Me.Formula = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Egg = New System.Windows.Forms.Button()
        Me.valorA = New System.Windows.Forms.TextBox()
        Me.valorB = New System.Windows.Forms.TextBox()
        Me.valorC = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Titulo.Location = New System.Drawing.Point(26, 23)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(208, 20)
        Me.Titulo.TabIndex = 0
        Me.Titulo.Text = "INSIRA OS VALOR DE A, B E C"
        '
        'LabelA
        '
        Me.LabelA.AutoSize = True
        Me.LabelA.Location = New System.Drawing.Point(43, 71)
        Me.LabelA.Name = "LabelA"
        Me.LabelA.Size = New System.Drawing.Size(15, 15)
        Me.LabelA.TabIndex = 1
        Me.LabelA.Text = "A"
        '
        'LabelB
        '
        Me.LabelB.AutoSize = True
        Me.LabelB.Location = New System.Drawing.Point(124, 71)
        Me.LabelB.Name = "LabelB"
        Me.LabelB.Size = New System.Drawing.Size(14, 15)
        Me.LabelB.TabIndex = 2
        Me.LabelB.Text = "B"
        '
        'LabelC
        '
        Me.LabelC.AutoSize = True
        Me.LabelC.Location = New System.Drawing.Point(204, 71)
        Me.LabelC.Name = "LabelC"
        Me.LabelC.Size = New System.Drawing.Size(15, 15)
        Me.LabelC.TabIndex = 3
        Me.LabelC.Text = "C"
        '
        'Formula
        '
        Me.Formula.AutoSize = True
        Me.Formula.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Formula.Location = New System.Drawing.Point(89, 132)
        Me.Formula.Name = "Formula"
        Me.Formula.Size = New System.Drawing.Size(80, 17)
        Me.Formula.TabIndex = 10
        Me.Formula.Text = "∆ = B² - 4ac"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(92, 167)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 60)
        Me.Calcular.TabIndex = 11
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Egg
        '
        Me.Egg.Font = New System.Drawing.Font("Yu Gothic", 3.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Egg.Location = New System.Drawing.Point(229, 223)
        Me.Egg.Name = "Egg"
        Me.Egg.Size = New System.Drawing.Size(27, 15)
        Me.Egg.TabIndex = 12
        Me.Egg.Text = "Não"
        Me.Egg.UseVisualStyleBackColor = True
        '
        'valorA
        '
        Me.valorA.Location = New System.Drawing.Point(26, 89)
        Me.valorA.MaxLength = 3
        Me.valorA.Name = "valorA"
        Me.valorA.Size = New System.Drawing.Size(47, 23)
        Me.valorA.TabIndex = 13
        '
        'valorB
        '
        Me.valorB.Location = New System.Drawing.Point(107, 89)
        Me.valorB.MaxLength = 3
        Me.valorB.Name = "valorB"
        Me.valorB.Size = New System.Drawing.Size(47, 23)
        Me.valorB.TabIndex = 14
        '
        'valorC
        '
        Me.valorC.Location = New System.Drawing.Point(187, 89)
        Me.valorC.MaxLength = 3
        Me.valorC.Name = "valorC"
        Me.valorC.Size = New System.Drawing.Size(47, 23)
        Me.valorC.TabIndex = 15
        '
        'Fundo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(258, 239)
        Me.Controls.Add(Me.valorC)
        Me.Controls.Add(Me.valorB)
        Me.Controls.Add(Me.valorA)
        Me.Controls.Add(Me.Egg)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Formula)
        Me.Controls.Add(Me.LabelC)
        Me.Controls.Add(Me.LabelB)
        Me.Controls.Add(Me.LabelA)
        Me.Controls.Add(Me.Titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Fundo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Valor de Delta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents LabelA As Label
    Friend WithEvents LabelB As Label
    Friend WithEvents LabelC As Label
    Friend WithEvents Formula As Label
    Friend WithEvents Calcular As Button
    Friend WithEvents Egg As Button
    Friend WithEvents valorA As TextBox
    Friend WithEvents valorB As TextBox
    Friend WithEvents valorC As TextBox
End Class
