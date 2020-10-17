Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Form1
    Public Property SaveFileDialog2 As Object

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTEXTO.Click
        SaveFileDialog1.DefaultExt = "pdf"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim DOCUMENTO As New Document
                Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
                DOCUMENTO.Open()
                DOCUMENTO.Add(New Paragraph(TextBox1.Text))
                DOCUMENTO.Close()
                MsgBox("CREADO ARCHIVO PDF")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonIMAGEN.Click
        SaveFileDialog1.DefaultExt = "pdf"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim DOCUMENTO As New Document
                Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
                DOCUMENTO.Open()
                Dim IMAGEN As Image = Image.GetInstance(OpenFileDialog1.FileName)
                IMAGEN.ScalePercent(CInt(TextBoxREDUCIR.Text))
                DOCUMENTO.Add(IMAGEN)
                DOCUMENTO.Close()
                MsgBox("CREADO ARCHIVO PDF")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTODO.Click
        SaveFileDialog1.DefaultExt = "pdf"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim DOCUMENTO As New Document
                Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
                DOCUMENTO.Open()
                DOCUMENTO.Add(New Paragraph(TextBox1.Text))
                Dim IMAGEN As Image = Image.GetInstance(OpenFileDialog1.FileName)
                IMAGEN.ScalePercent(CInt(TextBoxREDUCIR.Text))
                DOCUMENTO.Add(IMAGEN)
                DOCUMENTO.Close()
                MsgBox("CREADO ARCHIVO PDF")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Bitmap.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' Creamos una lista de archivos para concatenar

        Dim Lista As New List(Of String)

        ' Identificamos los documentos que queremos unir

        Dim sFile1 As String = “C:\Datos\Documento1.pdf”

        Dim sFile2 As String = “C:\Datos\Documento2.pdf”

        ' Los añadimos a la lista

        Lista.Add(sFile1)

        Lista.Add(sFile2)

        ' Nombre del documento resultante

        Dim sFileJoin As String = “C:\Datos\DocumentoJoin.pdf”

        Dim Doc As New Document()

        Try

            Dim fs As New FileStream(sFileJoin, FileMode.Create, FileAccess.Write, FileShare.None)

            Dim copy As New PdfCopy(Doc, fs)

            Doc.Open()

            Dim Rd As PdfReader

            Dim n As Integer 'Número de páginas de cada pdf

            For Each file In Lista

                Rd = New PdfReader(file)

                n = Rd.NumberOfPages

                Dim page As Integer = 0

                Do While page < n

                    page += 1

                    copy.AddPage(copy.GetImportedPage(Rd, page))

                Loop

                copy.FreeReader(Rd)

                Rd.Close()


            Next
            MsgBox("Documento generado correctamente")
        Catch ex As Exception

            MsgBox(ex.Message, vbExclamation, “Error uniendo los pdf”)

        Finally

            ' Cerramos el documento

            Doc.Close()

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim pdf3 As New PdfReader(TextBox1.Text)
                Dim pdfnuevo1 As New Document()


                Dim pagina1 As New PdfCopy(pdfnuevo1, New FileStream(SaveFileDialog1.FileName, FileMode.Create))

                pdfnuevo1.Open()

                Dim importa1 As PdfImportedPage = pagina1.GetImportedPage(pdf3, 1)

                pagina1.AddPage(importa1)

                pdf3.Close()
                pagina1.Close()
                pdfnuevo1.Close()

                MessageBox.Show("Documento 1 creado correctamente")


            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try
        End If

        If SaveFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim pdf3 As New PdfReader(TextBox1.Text)
                Dim pdfnuevo2 As New Document()


                Dim pagina2 As New PdfCopy(pdfnuevo2, New FileStream(SaveFileDialog2.FileName, FileMode.Create))

                pdfnuevo2.Open()

                Dim importa2 As PdfImportedPage = pagina2.GetImportedPage(pdf3, 2)

                pagina2.AddPage(importa2)

                pdf3.Close()
                pagina2.Close()
                pdfnuevo2.Close()

                MessageBox.Show("Documento 2 creado correctamente")


            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try
        End If

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, ButtonTEXTO.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If

    End Sub

End Class
