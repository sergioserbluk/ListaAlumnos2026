Imports System.IO

Public Class Form1
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim curso As String = txtCurso.Text

        Using archivo As New StreamWriter(ruta, True)

            archivo.WriteLine(nombre & ";" & apellido & ";" & curso)

        End Using

        MessageBox.Show("Registro guardado")
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        lstRegistros.Items.Clear()

        If File.Exists(ruta) Then

            Using archivo As New StreamReader(ruta)

                While Not archivo.EndOfStream

                    Dim linea As String = archivo.ReadLine()

                    lstRegistros.Items.Add(linea)
                    'Dim datos() As String = linea.Split(";"c)

                    'Dim nombre As String = datos(0)
                    'Dim apellido As String = datos(1)
                    'Dim curso As String = datos(2)

                    'lstRegistros.Items.Add(apellido & ", " & nombre & " - " & curso)

                End While

            End Using

        Else

            MessageBox.Show("Todavía no existe el archivo")

        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        If File.Exists(ruta) Then

            File.Delete(ruta)

            lstRegistros.Items.Clear()

            MessageBox.Show("Archivo eliminado")

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class
