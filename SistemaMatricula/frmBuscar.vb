Imports System.Data.OleDb
Public Class frmBuscar
    Private Sub frmBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnGrafica_Click(sender As Object, e As EventArgs) Handles btnGrafica.Click
        frmGrafica.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim kbum As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=E:\Programacion\2 Parcial\Codigos\Visual Studio\Sistema Matricula\Base de datos\Matricula.mdb")
        Try
            kbum.Open()
            MsgBox("Registro Encontrado",, "Buscar")

            Dim query = "Select * from Alumnos where Nombre like'" & txtBuscar.Text & "%'"
            Dim waos As New OleDbDataAdapter(query, kbum)
            Dim vs As New DataTable
            waos.Fill(vs)
            DataGridView1.DataSource = vs

        Catch ex As Exception
            MsgBox("No se encontro: " & ex.Message)
        End Try
    End Sub

End Class