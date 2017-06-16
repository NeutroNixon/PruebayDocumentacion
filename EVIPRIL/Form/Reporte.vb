Imports System.Data.SqlClient
Public Class FrmReporte
    Dim sele As Integer
    Private Sub PbxAtras_Click(sender As Object, e As EventArgs) Handles PbxAtras.Click
        Me.Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub PbxEmpleado_Click(sender As Object, e As EventArgs) Handles PbxEmpleado.Click
        Me.Hide()
        Conexion.sele = 1
        Dim f As New FrmReportes
        f.Show()
    End Sub



    Private Sub PbxPlanilla_Click(sender As Object, e As EventArgs) Handles PbxPlanilla.Click
        Me.Hide()
        Conexion.sele = 2
        Dim f As New FrmReportes
        f.Show()
    End Sub

    Private Sub PbxInventario_Click(sender As Object, e As EventArgs) Handles PbxInventario.Click
        Me.Hide()
        Conexion.sele = 3
        Dim f As New FrmReportes
        f.Show()
    End Sub

    Private Sub PbxCliente_Click(sender As Object, e As EventArgs) Handles PbxCliente.Click
        Me.Hide()
        Conexion.sele = 4
        Dim f As New FrmReportes
        f.Show()

    End Sub

    Private Sub PbxPrestaciones_Click(sender As Object, e As EventArgs) Handles PbxPrestaciones.Click
        Me.Hide()
        Conexion.sele = 5
        Dim f As New FrmReportes
        f.Show()

    End Sub

    Private Sub PbxContrato_Click(sender As Object, e As EventArgs) Handles PbxContrato.Click
        Me.Hide()
        Conexion.sele = 6
        Dim f As New FrmReportes
        f.Show()
    End Sub

    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
