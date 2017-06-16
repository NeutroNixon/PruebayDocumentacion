Public Class AccesoDatos
    Shared ctx As New DataClasses1DataContext()

    Shared Sub CargarEmpleados(grid As DataGridView, Optional busqueda As String = "")

        If busqueda = "" Then
            grid.DataSource = (From a In ctx.Empleado
                               Order By a.Nombres
                               Select a.NumIdentidad, a.Nombres, a.Apellidos, a.Direccion, a.Telefono, a.FechaNac, a.NumCuenta, a.Profesion, a.EstadoCivil).ToList()


        Else
            grid.DataSource = (From a In ctx.Empleado
                               Where a.Nombres.Contains(busqueda)
                               Order By a.Nombres
                               Select a.NumIdentidad, a.Nombres, a.Apellidos, a.Direccion, a.Telefono, a.FechaNac, a.NumCuenta, a.IdProfesion, a.IdEstadoCivil).ToList()
        End If

    End Sub

    Shared Sub CargarDatosEmpleado(cuenta As String, txt2 As TextBox, txt3 As TextBox, txt4 As TextBox, txt5 As TextBox, txt6 As DateTimePicker, txt7 As TextBox, txt8 As ComboBox, txt9 As ComboBox)
        Dim datos = (From a In ctx.Empleado
                     Where a.NumIdentidad = cuenta
                     Select a).SingleOrDefault

        txt2.Text = datos.Nombres
        txt3.Text = datos.Apellidos
        txt4.Text = datos.Telefono
        txt5.Text = datos.Direccion
        txt6.Text = datos.FechaNac
        txt7.Text = datos.NumCuenta
        txt8.SelectedValue = datos.IdProfesion
        txt9.SelectedValue = datos.IdEstadoCivil
    End Sub

    Shared Sub CargarDatosContrato(IdentidadEmpleado As String, Nombre As TextBox, DiaIngreso As TextBox, MesIngreso As TextBox, AnioIngreso As TextBox)
        Dim datos = (From a In ctx.ContratoEmpleados
                     Where a.NumIdentidad = IdentidadEmpleado
                     Select a).SingleOrDefault

        Nombre.Text = datos.Empleado.Nombres
        DiaIngreso.Text = datos.FechaInicio.Day
        MesIngreso.Text = datos.FechaInicio.Month
        AnioIngreso.Text = datos.FechaInicio.Year
    End Sub

    Shared Sub CargarDatosEmpleadoPrestaciones(cuenta As String, txt2 As TextBox, txt3 As TextBox, txt4 As TextBox, txt5 As TextBox, txt6 As DateTimePicker, txt7 As TextBox, txt8 As ComboBox, txt9 As ComboBox)
        Dim datos = (From a In ctx.Empleado
                     Where a.NumIdentidad = cuenta
                     Select a).SingleOrDefault

        txt2.Text = datos.Nombres
        txt3.Text = datos.Apellidos
        txt4.Text = datos.Telefono
        txt5.Text = datos.Direccion
        txt6.Text = datos.FechaNac
        txt7.Text = datos.NumCuenta
        txt8.SelectedValue = datos.IdProfesion
        txt9.SelectedValue = datos.IdEstadoCivil
    End Sub
    Shared Sub CargarCliente(grid As DataGridView, Optional busqueda As String = "")

        If busqueda = "" Then
            grid.DataSource = (From a In ctx.Clientes
                               Order By a.NombreCompañia
                               Select a.IdCliente, a.NombreCompañia, a.NombreContacto, a.Direccion, a.Telefono).ToList()

        Else
            grid.DataSource = (From a In ctx.Clientes
                               Where a.NombreCompañia.Contains(busqueda)
                               Order By a.NombreCompañia
                               Select a.IdCliente, a.NombreCompañia, a.NombreContacto, a.Direccion, a.Telefono).ToList()
        End If

    End Sub
    Shared Sub CargarDatosCliente(cuenta As String, txt2 As TextBox, txt3 As TextBox, txt4 As TextBox, txt5 As TextBox)
        Dim datos = (From a In ctx.Clientes
                     Where a.IdCliente = cuenta
                     Select a).SingleOrDefault

        txt2.Text = datos.NombreCompañia
        txt3.Text = datos.NombreContacto
        txt4.Text = datos.Telefono
        txt5.Text = datos.Direccion
    End Sub
End Class
Public Interface IForm
    Sub ObtenerCuenta(cuenta As String)
End Interface
