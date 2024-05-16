Imports System.Data.OleDb
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim kbum As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=E:\Programacion\2 Parcial\Codigos\Visual Studio\Sistema Matricula\Base de datos\Matricula.mdb")
        Try
            kbum.Open()
            MsgBox("Conectado")

            Dim query = "Select * from Alumnos"
            Dim waos As New OleDbDataAdapter(query, kbum)
            Dim vs As New DataTable
            waos.Fill(vs)
            DataGridView1.DataSource = vs

        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)
        End Try
    End Sub
End Class
