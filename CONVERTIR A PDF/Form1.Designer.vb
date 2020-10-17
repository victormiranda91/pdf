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
        Me.ButtonTEXTO = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonIMAGEN = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBoxREDUCIR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonTODO = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonTEXTO
        '
        Me.ButtonTEXTO.BackColor = System.Drawing.Color.Black
        Me.ButtonTEXTO.Location = New System.Drawing.Point(133, 270)
        Me.ButtonTEXTO.Name = "ButtonTEXTO"
        Me.ButtonTEXTO.Size = New System.Drawing.Size(140, 40)
        Me.ButtonTEXTO.TabIndex = 0
        Me.ButtonTEXTO.Text = "TEXTO A PDF"
        Me.ButtonTEXTO.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 13)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(400, 250)
        Me.TextBox1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Cyan
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(452, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ButtonIMAGEN
        '
        Me.ButtonIMAGEN.BackColor = System.Drawing.Color.Black
        Me.ButtonIMAGEN.Location = New System.Drawing.Point(712, 269)
        Me.ButtonIMAGEN.Name = "ButtonIMAGEN"
        Me.ButtonIMAGEN.Size = New System.Drawing.Size(140, 40)
        Me.ButtonIMAGEN.TabIndex = 3
        Me.ButtonIMAGEN.Text = "IMAGEN A PDF"
        Me.ButtonIMAGEN.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBoxREDUCIR
        '
        Me.TextBoxREDUCIR.Location = New System.Drawing.Point(571, 281)
        Me.TextBoxREDUCIR.Name = "TextBoxREDUCIR"
        Me.TextBoxREDUCIR.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxREDUCIR.TabIndex = 4
        Me.TextBoxREDUCIR.Text = "100"
        Me.TextBoxREDUCIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(449, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "REDUCIR AL %:"
        '
        'ButtonTODO
        '
        Me.ButtonTODO.BackColor = System.Drawing.Color.Black
        Me.ButtonTODO.Location = New System.Drawing.Point(369, 303)
        Me.ButtonTODO.Name = "ButtonTODO"
        Me.ButtonTODO.Size = New System.Drawing.Size(140, 71)
        Me.ButtonTODO.TabIndex = 6
        Me.ButtonTODO.Text = "CONVERTIR IMAGEN Y TEXTO"
        Me.ButtonTODO.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(133, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 71)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "UNIR PDF"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(417, 443)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 28)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "EXPLORAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(107, 449)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(286, 22)
        Me.TextBox2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Selecciona archivo a dividir"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(540, 425)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 71)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "DIVIDIR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(877, 515)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonTODO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxREDUCIR)
        Me.Controls.Add(Me.ButtonIMAGEN)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonTEXTO)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONVERTIR A PDF"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonTEXTO As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonIMAGEN As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBoxREDUCIR As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonTODO As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
End Class
