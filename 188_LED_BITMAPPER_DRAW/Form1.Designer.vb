<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtbox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ImageMagnifier = New ImageMagnifier.ImageMagnifier()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ImageMagnifier1 = New ImageMagnifier.ImageMagnifier()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OliveDrab
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button1.Location = New System.Drawing.Point(18, 97)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(428, 70)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Load and Convert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtbox
        '
        Me.txtbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox.ForeColor = System.Drawing.Color.Red
        Me.txtbox.Location = New System.Drawing.Point(651, 425)
        Me.txtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbox.Multiline = True
        Me.txtbox.Name = "txtbox"
        Me.txtbox.Size = New System.Drawing.Size(438, 599)
        Me.txtbox.TabIndex = 74
        Me.txtbox.Text = "OUTPUT HEX"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.Location = New System.Drawing.Point(19, 177)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(427, 137)
        Me.TextBox1.TabIndex = 75
        Me.TextBox1.Text = "FILE MUST BE:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BMP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "16x16 Pixels" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1-Bit MonoChrome" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Only Black and White Colors"
        '
        'txtbox2
        '
        Me.txtbox2.BackColor = System.Drawing.Color.Black
        Me.txtbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox2.ForeColor = System.Drawing.Color.LightGreen
        Me.txtbox2.Location = New System.Drawing.Point(11, 13)
        Me.txtbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(928, 39)
        Me.txtbox2.TabIndex = 76
        Me.txtbox2.Text = "C:\"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.ForeColor = System.Drawing.Color.LimeGreen
        Me.TextBox2.Location = New System.Drawing.Point(883, 372)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(206, 29)
        Me.TextBox2.TabIndex = 79
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Firebrick
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(165, 1043)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 66)
        Me.Button4.TabIndex = 81
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.OliveDrab
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(674, 1180)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(265, 66)
        Me.Button5.TabIndex = 81
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Black
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.LightGreen
        Me.TextBox4.Location = New System.Drawing.Point(14, 1126)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(925, 39)
        Me.TextBox4.TabIndex = 83
        Me.TextBox4.Text = "C:\"
        '
        'ImageMagnifier
        '
        Me.ImageMagnifier.BackColor = System.Drawing.Color.SlateBlue
        Me.ImageMagnifier.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ImageMagnifier.ImageToMagnify = Global.bitmapperdraw.My.Resources.Resources._1
        Me.ImageMagnifier.Location = New System.Drawing.Point(19, 425)
        Me.ImageMagnifier.MagnificationCoefficient = 20
        Me.ImageMagnifier.Name = "ImageMagnifier"
        Me.ImageMagnifier.Size = New System.Drawing.Size(320, 320)
        Me.ImageMagnifier.TabIndex = 85
        Me.ImageMagnifier.Text = "ImageMagnifier1"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Black
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.GreenYellow
        Me.TextBox5.Location = New System.Drawing.Point(19, 324)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(366, 77)
        Me.TextBox5.TabIndex = 86
        '
        'ImageMagnifier1
        '
        Me.ImageMagnifier1.BackColor = System.Drawing.Color.Black
        Me.ImageMagnifier1.ForeColor = System.Drawing.Color.Black
        Me.ImageMagnifier1.ImageToMagnify = Nothing
        Me.ImageMagnifier1.Location = New System.Drawing.Point(464, 97)
        Me.ImageMagnifier1.MagnificationCoefficient = 8
        Me.ImageMagnifier1.Name = "ImageMagnifier1"
        Me.ImageMagnifier1.Size = New System.Drawing.Size(200, 200)
        Me.ImageMagnifier1.TabIndex = 87
        Me.ImageMagnifier1.Text = "ImageMagnifier1"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(946, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 49)
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "Change Dir..."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(946, 1120)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 55)
        Me.Button3.TabIndex = 89
        Me.Button3.Text = "Change Dir..."
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Yellow
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(325, 1043)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 66)
        Me.Button6.TabIndex = 90
        Me.Button6.Text = "Fill"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkMagenta
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1103, 1257)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ImageMagnifier1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.ImageMagnifier)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtbox)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Form1"
        Me.Text = "16x16 bitmap to Hex + Draw"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtbox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtbox2 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ImageMagnifier As ImageMagnifier.ImageMagnifier
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ImageMagnifier1 As ImageMagnifier.ImageMagnifier
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents Button6 As Button
End Class
