Imports System.Data.SqlClient

Public Class FrmReportes
    Dim cmd As New SqlCommand
    Dim dt As DataTable
    Dim da As New SqlDataAdapter

    Public Sub MostrarDatosEmpleado()
        da = New SqlDataAdapter("select e.NumIdentidad, e.Nombres,e.Apellidos,e.Direccion,e.Telefono,e.FechaNac,e.NumCuenta,p.Profesion,c.EstadoCivil from Empleado E inner join Profesion P on E.IdProfesion = p.IdProfesion inner join EstadoCivil C on E.IdEstadoCivil = C.IdEstadoCivil", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt

    End Sub
    Public Sub MostrarDatosContrato()
        da = New SqlDataAdapter("Select * from ContratoEmpleado", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt

    End Sub
    Public Sub MostrarDatosPlanilla()
        da = New SqlDataAdapter("select p.SueldoDiario,p.DiasTrabajados,p.SueldoQuincenal,p.Complemento,p.SubTotal,p.IHSS,p.DeduccionUniforme,p.RAP,p.OtrasDeducciones,p.TotalDeducciones,p.NetoPagar,p.NumIdentidad,c.fecha,c.horaentrada,c.horasalida,c.NumIdentidad from Planilla P inner join Controlempleado C on P.idcontrolemp = C.idcontrolemp ", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt

    End Sub
    Public Sub MostrarDatosInventario()
        da = New SqlDataAdapter("select i.Serie,i.Calibre,i.Fabricacion, t.TipoArma, m.Modelo from InventarioArmas I inner join TipoArma T on  I.IdTipoArma = t.IdTipoArma inner join Modelo M on i.IdModelo = M.IdModelo", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt

    End Sub
    Public Sub MostrarDatosCliente()
        da = New SqlDataAdapter("Select * from Clientes", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt

    End Sub
    Public Sub MostrarDatosPrestaciones()
        da = New SqlDataAdapter("Select * from Prestaciones", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt

    End Sub
    Private Sub PbxAtras_Click(sender As Object, e As EventArgs) Handles PbxAtras.Click
        Me.Close()
        FrmReporte.Show()
    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sele = 1 Then
            MostrarDatosEmpleado()
            LlenarOrdenarEmpleado()
        ElseIf sele = 2 Then
            MostrarDatosPlanilla()
            LlenarOrdenarPlanilla()
        ElseIf sele = 3 Then
            MostrarDatosInventario()
            LlenarOrdenarIventario()
        ElseIf sele = 4 Then
            MostrarDatosCliente()
            LlenarOrdenarCliente()
        ElseIf sele = 5 Then
            MostrarDatosPrestaciones()
        ElseIf sele = 6 Then
            MostrarDatosContrato()
        End If

    End Sub

    Private Sub TxtOrdenarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboOrdenar.SelectedIndexChanged
        Dim i As Integer
        i = CboOrdenar.SelectedIndex
        Select Case i
            Case 0
                If sele = 1 Then
                    OrdenarNombre()
                ElseIf sele = 2 Then
                    OrdenarSueldoDiario()
                ElseIf sele = 3 Then
                    OrdenarSerie()
                ElseIf sele = 4 Then
                    OrdenarCompañia()
                End If
            Case 1
                If sele = 1 Then
                    OrdenarApellido()
                ElseIf sele = 2 Then
                    OrdenarDiasTrabajados()
                ElseIf sele = 3 Then
                    OrdenarFabricacion()
                ElseIf sele = 4 Then
                    OrdenarContacto()
                End If

        End Select
    End Sub

    Public Sub OrdenarNombre()
        da = New SqlDataAdapter("Select * from Empleado order by Nombres", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt
    End Sub
    Public Sub OrdenarApellido()
        da = New SqlDataAdapter("Select * from Empleado order by Apellidos", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt
    End Sub
    Public Sub OrdenarNumeroIdentidad()
        da = New SqlDataAdapter("Select * from Empleado order by NumIdentidad", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt
    End Sub

    Private Sub LlenarOrdenarEmpleado()
        CboOrdenar.Items.Add("Nombre")
        CboOrdenar.Items.Add("Numero de Identidad")
    End Sub
    Private Sub LlenarOrdenarCliente()
        CboOrdenar.Items.Add("Nombre Compañia")
        CboOrdenar.Items.Add("Nombre Contacto")
    End Sub
    Private Sub LlenarOrdenarIventario()
        CboOrdenar.Items.Add("Serie")
        CboOrdenar.Items.Add("Fabricacion")
    End Sub
    Private Sub LlenarOrdenarPlanilla()
        CboOrdenar.Items.Add("Sueldo Diario")
        CboOrdenar.Items.Add("Dias Trabajado")
    End Sub


    Public Sub OrdenarSueldoDiario()
        da = New SqlDataAdapter("select p.SueldoDiario,p.DiasTrabajados,p.SueldoQuincenal,p.Complemento,p.SubTotal,p.IHSS,p.DeduccionUniforme,p.RAP,p.OtrasDeducciones,p.TotalDeducciones,p.NetoPagar,p.NumIdentidad,c.fecha,c.horaentrada,c.horasalida,c.NumIdentidad from Planilla P inner join Controlempleado C on P.idcontrolemp = C.idcontrolemp  order by P.SueldoDiario", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt
    End Sub
    Public Sub OrdenarDiasTrabajados()
        da = New SqlDataAdapter("select p.SueldoDiario,p.DiasTrabajados,p.SueldoQuincenal,p.Complemento,p.SubTotal,p.IHSS,p.DeduccionUniforme,p.RAP,p.OtrasDeducciones,p.TotalDeducciones,p.NetoPagar,p.NumIdentidad,c.fecha,c.horaentrada,c.horasalida,c.NumIdentidad from Planilla P inner join Controlempleado C on P.idcontrolemp = C.idcontrolemp  order by P.DiasTrabajados", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt
    End Sub
    Public Sub OrdenarSerie()
        da = New SqlDataAdapter("select i.Serie,i.Calibre,i.Fabricacion, t.TipoArma, m.Modelo from InventarioArmas I inner join TipoArma T on  I.IdTipoArma = t.IdTipoArma inner join Modelo M on i.IdModelo = M.IdModelo order by I.Serie", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt
    End Sub
    Public Sub OrdenarFabricacion()
        da = New SqlDataAdapter("select i.Serie,i.Calibre,i.Fabricacion, t.TipoArma, m.Modelo from InventarioArmas I inner join TipoArma T on  I.IdTipoArma = t.IdTipoArma inner join Modelo M on i.IdModelo = M.IdModelo order by i.Fabricacion", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt
    End Sub

    Public Sub OrdenarCompañia()
        da = New SqlDataAdapter("Select * from Clientes order by NombreCompañia", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt
    End Sub
    Public Sub OrdenarContacto()
        da = New SqlDataAdapter("Select * from Clientes order by NombreContacto", cnn)
        dt = New DataTable
        da.Fill(dt)
        DgvReporte.DataSource = dt
    End Sub

    Private Sub DgvReporte_DoubleClick(sender As Object, e As EventArgs) Handles DgvReporte.DoubleClick
        Dim cuenta As String = DgvReporte.CurrentRow.Cells(0).Value

        Dim InstanciaForm As IForm = CType(Me.Owner, IForm)

        If InstanciaForm IsNot Nothing Then
            InstanciaForm.ObtenerCuenta(cuenta)
        End If
        Close()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If sele = 1 Then
            AccesoDatos.CargarEmpleados(DgvReporte, TxtBuscar.Text)
        ElseIf sele = 4 Then
            AccesoDatos.CargarCliente(DgvReporte, TxtBuscar.Text)
        End If
    End Sub
End Class