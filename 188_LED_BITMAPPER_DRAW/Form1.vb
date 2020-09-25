Public Class Form1
    'using DLL called ImageMagnifier for better looking pixel art
    'https://www.codeproject.com/Articles/15925/Image-Magnifier-Control?PageFlow=FixedWidth
    Dim xWidth = 16
    Dim yHeight = 16
    Dim xMin As Integer = 8 'magic numbers found experimentally. not sure the issue
    Dim xMax As Integer = 327
    Dim yMin As Integer = 31
    Dim yMax As Integer = 350
    Dim Image_File As Integer = 1
    Dim BMP As New Drawing.Bitmap(16, 16) 'image size
    Dim GFX As Graphics = Graphics.FromImage(BMP)
    Dim myColor As Color = Color.Black

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GFX.FillRectangle(Brushes.White, 0, 0, ImageMagnifier.Width, ImageMagnifier.Height)
    End Sub


    Function myMap(ByVal x As Integer, ByVal in_min As Integer, ByVal in_max As Integer, ByVal out_min As Integer, ByVal out_max As Integer) As Integer
        Return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min
    End Function


    Private Sub MySubY(ByVal myBMP As Image) 'subroutine for the picturebox to hex conversion
        txtbox.Clear() 'clear the damn text box d3rp
        Dim LineCount As Integer = 0
        Dim LineCountOffset As Integer = 0

        '----------------------------------Image to byte stream (HEX)--------------------------------------------    
        Dim myImage As Image = myBMP 'declare and set image to load as hex data
        Dim imgByteArray As Byte() = Nothing
        Dim result As String
        Dim imgMemoryStream As IO.MemoryStream = New IO.MemoryStream()
        myImage.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Bmp)
        imgByteArray = imgMemoryStream.GetBuffer()
        result = BitConverter.ToString(imgByteArray, 0) 'CONVERS DATA BUFFER HEX to STRING DATA SEPERATED BY "-"

        result = result.Remove(0, 186) 'REMOVES HEADER INFO from hex file
        For LineCount = 1 To 15
            result = result.Remove(6 * LineCount, 6)
        Next

        result = result.Remove(96, 395) 'REMOVES FOOTER INFO from hex file
        result = result.TrimEnd("-")
        result = result.Replace("-", ",0x")
        result = "0x" + result
        For LineCount = 1 To 15
            result = result.Insert(10 * LineCount + LineCountOffset, Environment.NewLine)
            LineCountOffset = LineCountOffset + 2
        Next
        result = "const char " + TextBox3.Text + "[32] PROGMEM = { " + Environment.NewLine + result + " };"
        txtbox.Text = result

        myImage.Dispose()

    End Sub


    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove 'raw mouse position
        Dim MPx As Point = MousePosition()
        TextBox2.Text = MPx.ToString
    End Sub


    Private Sub SetIndexedPixel(ByVal x As Integer, ByVal y As Integer, ByVal bmd As System.Drawing.Imaging.BitmapData, ByVal pixel As Boolean)
        Dim index As Integer = y * bmd.Stride + (x >> 3)
        Dim p As Byte = System.Runtime.InteropServices.Marshal.ReadByte(bmd.Scan0, index)
        Dim mask As Byte = &H80 >> (x And &H7)
        If pixel Then
            p = p Or mask
        Else
            p = p And CByte(mask ^ &HFF)
        End If
        System.Runtime.InteropServices.Marshal.WriteByte(bmd.Scan0, index, p)
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'clear screen
        txtbox.Clear() 'clear hex code window
        GFX.FillRectangle(Brushes.White, 0, 0, ImageMagnifier.Width, ImageMagnifier.Height)
        ImageMagnifier.ImageToMagnify = BMP
    End Sub



    Private Sub ImageMagnifier_Hover(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ImageMagnifier.MouseMove, ImageMagnifier.MouseClick
        Dim myx As Integer = MousePosition.X - Me.Location.X - ImageMagnifier.Location.X
        Dim myy As Integer = MousePosition.Y - Me.Location.Y - ImageMagnifier.Location.Y
        myx = myMap(myx, xMin, xMax, 0, xWidth - 1)
        myy = myMap(myy, yMin, yMax, 0, yHeight - 1)
        TextBox5.Text = "x:" + myx.ToString + " , " + "y:" + myy.ToString
        Dim MPx As Point = MousePosition()
        TextBox2.Text = MPx.ToString


        If e.Button = MouseButtons.Left And 0 <= myx And myx < 16 And 0 <= myy And myy < xWidth Then
            BMP.SetPixel(myx, myy, Color.Black)
        End If
        If e.Button = MouseButtons.Right And 0 <= myx And myx < 16 And 0 <= myy And myy < yHeight Then
            BMP.SetPixel(myx, myy, Color.White)
        End If

        ImageMagnifier.ImageToMagnify = BMP

        'convert to monochrome
        Dim bm As New Bitmap(BMP.Width, BMP.Height, Imaging.PixelFormat.Format1bppIndexed)
        Dim bmdn As System.Drawing.Imaging.BitmapData = bm.LockBits(New Rectangle(0, 0, bm.Width, bm.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, Imaging.PixelFormat.Format1bppIndexed)

        Dim y As Integer
        For y = 0 To BMP.Height - 1

            Dim x As Integer
            For x = 0 To BMP.Width - 1
                Dim pixelColor As Color = BMP.GetPixel(x, y)
                If pixelColor.Name = "ffffffff" Then
                    SetIndexedPixel(x, y, bmdn, True)
                End If

            Next x
        Next y
        bm.UnlockBits(bmdn)
        Call MySubY(bm) 'convert to hex code

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtbox2.Text = OpenFileDialog1.FileName
        End If

        Dim imagelocation As String = txtbox2.Text ' sets the image
        BMP = MyConverters.ConvertTo16bpp(Image.FromFile(imagelocation))
        GFX = Graphics.FromImage(BMP)
        ImageMagnifier.ImageToMagnify = BMP  ' update on load
        ImageMagnifier1.ImageToMagnify = BMP ' preview only gets updated on load
        txtbox.Clear()


    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim bm As New Bitmap(BMP.Width, BMP.Height, Imaging.PixelFormat.Format1bppIndexed)
            Dim bmdn As System.Drawing.Imaging.BitmapData = bm.LockBits(New Rectangle(0, 0, bm.Width, bm.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, Imaging.PixelFormat.Format1bppIndexed)

            For y As Integer = 0 To BMP.Height - 1
                For x As Integer = 0 To BMP.Width - 1
                    Dim pixelColor As Color = BMP.GetPixel(x, y)
                    If pixelColor.Name = "ffffffff" Then
                        SetIndexedPixel(x, y, bmdn, True)
                    End If
                Next x
            Next y
            bm.UnlockBits(bmdn)
            bm.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
            MsgBox("File probably Saved")
        End If

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtbox.Clear() 'clear hex code window
        GFX.FillRectangle(Brushes.Black, 0, 0, ImageMagnifier.Width, ImageMagnifier.Height)
        ImageMagnifier.ImageToMagnify = BMP
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Clipboard.SetText(txtbox.Text)
    End Sub


End Class