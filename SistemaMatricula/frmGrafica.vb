Imports System.Data.OleDb
Public Class frmGrafica
    Private Sub frmGrafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim kbum As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=E:\Programacion\2 Parcial\Codigos\Visual Studio\Sistema Matricula\Base de datos\Matricula.mdb")
        Try
            kbum.Open()
            MsgBox("Conectado")

            Dim query = "Select * from Alumnos"
            Dim waos As New OleDbDataAdapter(query, kbum)
            Dim vs As New DataTable
            waos.Fill(vs)

            Chart1.Series("Series1").XValueMember = "Nombre"
            Chart1.Series("Series1").YValueMembers = "Edad"
            Chart1.DataSource = vs


        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)
        End Try
    End Sub
End Class