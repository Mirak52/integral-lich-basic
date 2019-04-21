<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IntegralA = New System.Windows.Forms.TextBox()
        Me.integralB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Numbers = New System.Windows.Forms.TextBox()
        Me.numberN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Result = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xThree = New System.Windows.Forms.TextBox()
        Me.xTwo = New System.Windows.Forms.TextBox()
        Me.xOne = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.Location = New System.Drawing.Point(648, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 101)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "="
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 95)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "∫"
        '
        'IntegralA
        '
        Me.IntegralA.Location = New System.Drawing.Point(149, 219)
        Me.IntegralA.Name = "IntegralA"
        Me.IntegralA.Size = New System.Drawing.Size(28, 22)
        Me.IntegralA.TabIndex = 2
        '
        'integralB
        '
        Me.integralB.Location = New System.Drawing.Point(159, 140)
        Me.integralB.Name = "integralB"
        Me.integralB.Size = New System.Drawing.Size(28, 22)
        Me.integralB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(253, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = " x^3"
        '
        'Numbers
        '
        Me.Numbers.Location = New System.Drawing.Point(518, 183)
        Me.Numbers.Name = "Numbers"
        Me.Numbers.Size = New System.Drawing.Size(105, 22)
        Me.Numbers.TabIndex = 7
        Me.Numbers.TabStop = False
        '
        'numberN
        '
        Me.numberN.Location = New System.Drawing.Point(258, 239)
        Me.numberN.Name = "numberN"
        Me.numberN.Size = New System.Drawing.Size(50, 22)
        Me.numberN.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(209, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "n ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 58)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Výsledek: "
        '
        'Result
        '
        Me.Result.AutoSize = True
        Me.Result.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Result.Location = New System.Drawing.Point(380, 313)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(0, 58)
        Me.Result.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(331, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = " x^2"
        '
        'xThree
        '
        Me.xThree.Location = New System.Drawing.Point(225, 179)
        Me.xThree.Name = "xThree"
        Me.xThree.Size = New System.Drawing.Size(22, 22)
        Me.xThree.TabIndex = 14
        Me.xThree.TabStop = False
        '
        'xTwo
        '
        Me.xTwo.Location = New System.Drawing.Point(314, 178)
        Me.xTwo.Name = "xTwo"
        Me.xTwo.Size = New System.Drawing.Size(22, 22)
        Me.xTwo.TabIndex = 15
        Me.xTwo.TabStop = False
        '
        'xOne
        '
        Me.xOne.Location = New System.Drawing.Point(401, 178)
        Me.xOne.Name = "xOne"
        Me.xOne.Size = New System.Drawing.Size(22, 22)
        Me.xOne.TabIndex = 17
        Me.xOne.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(418, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = " x^1 +"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 664)
        Me.Controls.Add(Me.xOne)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.xTwo)
        Me.Controls.Add(Me.xThree)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.numberN)
        Me.Controls.Add(Me.Numbers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.integralB)
        Me.Controls.Add(Me.IntegralA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents IntegralA As TextBox
    Friend WithEvents integralB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Numbers As TextBox
    Friend WithEvents numberN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Result As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents xThree As TextBox
    Friend WithEvents xTwo As TextBox
    Friend WithEvents xOne As TextBox
    Friend WithEvents Label6 As Label
End Class
