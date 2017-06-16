
Imports System.Data.SqlClient

Public Class FrmEmpleado
    Implements IForm
    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstadoCivil()
        CargarProfesion()
        cboEstadoCivil.Text = ""
        cboProfesion.Text = ""
    End Sub

    Private Sub CargarProfesion()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarProfesion2"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Profesion")
                cboProfesion.DataSource = ds.Tables(0)
                cboProfesion.DisplayMember = ds.Tables(0).Columns("Profesion").ToString
                cboProfesion.ValueMember = ds.Tables(0).Columns("IdProfesion").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub CargarEstadoCivil()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarEstadoCivil1"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "EstadoCivil")
                cboEstadoCivil.DataSource = ds.Tables(0)
                cboEstadoCivil.DisplayMember = ds.Tables(0).Columns("EstadoCivil").ToString
                cboEstadoCivil.ValueMember = ds.Tables(0).Columns("IdEstadoCivil").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub AgregarEmpleado()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "InsertEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@NumIdentidad", SqlDbType.Char).Value = txtNumIdentidad.Text
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = txtNombre.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar).Value = txtApellido.Text
                    .Parameters.Add("@Direccion", SqlDbType.VarChar).Value = txtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char).Value = txtTelefono.Text
                    .Parameters.Add("@FechaNac", SqlDbType.Date).Value = dtpFechaNacimiento.Value
                    .Parameters.Add("@NumCuenta", SqlDbType.Int).Value = txtNumCuenta.Text
                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = cboProfesion.SelectedValue
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = cboEstadoCivil.SelectedValue
                    .ExecuteNonQuery()
                    MsgBox("Guardado con éxito")
                End With
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            AgregarEmpleado()
            txtNumIdentidad.Clear()
            txtNombre.Text = ""
            txtApellido.Text = ""
            txtTelefono.Text = ""
            txtDireccion.Text = ""
            txtNumCuenta.Text = ""
            cboProfesion.Text = ""
            cboEstadoCivil.Text = ""
        Catch ex As Exception
        End Try



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Conexion.sele = 1
        Dim frm As New FrmReportes()
        frm.Show(Me)
        cboEstadoCivil.Text = ""
        cboProfesion.Text = ""
    End Sub



    Public Sub ObtenerCuenta(cuenta As String) Implements IForm.ObtenerCuenta
        txtNumIdentidad.Text = cuenta
        AccesoDatos.CargarDatosEmpleado(txtNumIdentidad.Text, txtNombre, txtApellido, txtTelefono, txtDireccion, dtpFechaNacimiento, txtNumCuenta, cboProfesion, cboEstadoCivil)
    End Sub


    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If txtNumIdentidad.Text = Nothing And txtNombre.Text = Nothing And txtApellido.Text = Nothing And txtTelefono.Text = Nothing And txtDireccion.Text = Nothing And txtNumCuenta.Text = Nothing And cboProfesion.Text = "" And cboEstadoCivil.Text = "" Then
            EpError.SetError(txtNumIdentidad, "Campo Obligatorio")
            EpError.SetError(txtNombre, "Campo Obligatorio")
            EpError.SetError(txtApellido, "Campo Obligatorio")
            EpError.SetError(txtTelefono, "Campo Obligatorio")
            EpError.SetError(txtDireccion, "Campo Obligatorio")
            EpError.SetError(txtNumCuenta, "Campo Obligatorio")
            EpError.SetError(cboProfesion, "Campo Obligatorio")
            EpError.SetError(cboEstadoCivil, "Campo Obligatorio")
            Estado = True
        ElseIf txtNombre.Text = Nothing And txtApellido.Text = Nothing And txtTelefono.Text = Nothing And txtDireccion.Text = Nothing And txtNumCuenta.Text = Nothing And cboProfesion.Text = "" And cboEstadoCivil.Text = "" Then
            EpError.SetError(txtNombre, "Campo Obligatorio")
            EpError.SetError(txtApellido, "Campo Obligatorio")
            EpError.SetError(txtTelefono, "Campo Obligatorio")
            EpError.SetError(txtDireccion, "Campo Obligatorio")
            EpError.SetError(txtNumCuenta, "Campo Obligatorio")
            EpError.SetError(cboProfesion, "Campo Obligatorio")
            EpError.SetError(cboEstadoCivil, "Campo Obligatorio")
            Estado = True
        ElseIf txtApellido.Text = Nothing And txtTelefono.Text = Nothing And txtDireccion.Text = Nothing And txtNumCuenta.Text = Nothing And cboProfesion.Text = "" And cboEstadoCivil.Text = "" Then
            EpError.SetError(txtApellido, "Campo Obligatorio")
            EpError.SetError(txtTelefono, "Campo Obligatorio")
            EpError.SetError(txtDireccion, "Campo Obligatorio")
            EpError.SetError(txtNumCuenta, "Campo Obligatorio")
            EpError.SetError(cboProfesion, "Campo Obligatorio")
            EpError.SetError(cboEstadoCivil, "Campo Obligatorio")
            Estado = True
        ElseIf txtTelefono.Text = Nothing And txtDireccion.Text = Nothing And txtNumCuenta.Text = Nothing And cboProfesion.Text = "" And cboEstadoCivil.Text = "" Then
            EpError.SetError(txtTelefono, "Campo Obligatorio")
            EpError.SetError(txtDireccion, "Campo Obligatorio")
            EpError.SetError(txtNumCuenta, "Campo Obligatorio")
            EpError.SetError(cboProfesion, "Campo Obligatorio")
            EpError.SetError(cboEstadoCivil, "Campo Obligatorio")
            Estado = True
        ElseIf txtDireccion.Text = Nothing And txtNumCuenta.Text = Nothing And cboProfesion.Text = "" And cboEstadoCivil.Text = "" Then
            EpError.SetError(txtDireccion, "Campo Obligatorio")
            EpError.SetError(txtNumCuenta, "Campo Obligatorio")
            EpError.SetError(cboProfesion, "Campo Obligatorio")
            EpError.SetError(cboEstadoCivil, "Campo Obligatorio")
            Estado = True
        ElseIf txtNumCuenta.Text = Nothing And cboProfesion.Text = "" And cboEstadoCivil.Text = "" Then
            EpError.SetError(txtNumCuenta, "Campo Obligatorio")
            EpError.SetError(cboProfesion, "Campo Obligatorio")
            EpError.SetError(cboEstadoCivil, "Campo Obligatorio")
            Estado = True
        ElseIf txtNumCuenta.Text = Nothing And cboProfesion.Text = "" And cboEstadoCivil.Text = "" Then
            EpError.SetError(txtNumCuenta, "Campo Obligatorio")
            EpError.SetError(cboProfesion, "Campo Obligatorio")
            EpError.SetError(cboEstadoCivil, "Campo Obligatorio")
            Estado = True
        ElseIf cboProfesion.Text = "" And cboEstadoCivil.Text = "" Then
            EpError.SetError(cboProfesion, "Campo Obligatorio")
            EpError.SetError(cboEstadoCivil, "Campo Obligatorio")
            Estado = True
        ElseIf cboEstadoCivil.Text = "" Then
            EpError.SetError(cboEstadoCivil, "Campo Obligatorio")
            Estado = True
        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub Editar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    'establecer los parametros que espera el procedimiento almacenado
                    .Parameters.Add("@NumIdentidad", SqlDbType.Char, 13).Value = Trim(txtNumIdentidad.Text)
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar, 50).Value = Trim(txtNombre.Text)
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = Trim(txtApellido.Text)
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = Trim(txtDireccion.Text)
                    .Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = Trim(txtTelefono.Text)
                    .Parameters.Add("@FechaNac", SqlDbType.Date).Value = Trim(dtpFechaNacimiento.Text)
                    .Parameters.Add("@NumCuenta", SqlDbType.Int).Value = Trim(txtNumCuenta.Text)
                    .Parameters.Add("@IdProfecion", SqlDbType.Int).Value = Trim(cboProfesion.SelectedValue)
                    .Parameters.Add("@IdEstaCivil", SqlDbType.Int).Value = Trim(cboEstadoCivil.SelectedValue)
                    .ExecuteNonQuery()
                    MessageBox.Show("Registro Modificado satisfactoriamente", "SeguridadLeon")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al  Modificar el empleado" + ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub txtNumIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumIdentidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub

    Private Sub txtNumCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumCuenta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub




End Class

