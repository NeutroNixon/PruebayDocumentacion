Imports System.Data.SqlClient

Public Class FrmCliente
    Implements IForm
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validar() = True Then


        Else
            Call AgregarCliente()
        End If

    End Sub

    Private Sub AgregarCliente()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "InsertClientes"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    .Parameters.Add("@NombreCompañia", SqlDbType.NVarChar).Value = TxtNombreCompañia.Text
                    .Parameters.Add("@NombreContacto", SqlDbType.NVarChar).Value = TxtNombreContacto.Text
                    .Parameters.Add("@Direccion", SqlDbType.VarChar).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char).Value = TxtTelefono.Text
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

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        FrmPantallaPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnModificar.Enabled = False

    End Sub
    Public Sub ObtenerCuenta(cuenta As String) Implements IForm.ObtenerCuenta
        TxtCodigo.Text = cuenta
    End Sub

    Private Sub TxtCodigo_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigo.TextChanged
        If TxtCodigo.Text <> "" Then
            AccesoDatos.CargarDatosCliente(TxtCodigo.Text, TxtNombreCompañia, TxtNombreContacto, TxtTelefono, TxtDireccion)
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Conexion.sele = 4
        Dim frm As New FrmReportes()
        frm.Show(Me)
        BtnModificar.Enabled = True
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Call Editar()
        BtnModificar.Enabled = False
        TxtCodigo.Text = ""
        TxtNombreCompañia.Text = ""
        TxtNombreContacto.Text = ""
        TxtTelefono.Text = ""
        TxtDireccion.Text = ""
    End Sub
    Private Sub Editar()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    'establecer los parametros que espera el procedimiento almacenado
                    .Parameters.Add("@IdCliente", SqlDbType.Int).Value = CInt(TxtCodigo.Text)
                    .Parameters.Add("@NombreCompañia", SqlDbType.NVarChar, 100).Value = Trim(TxtNombreCompañia.Text)
                    .Parameters.Add("@NombreContacto", SqlDbType.NVarChar, 100).Value = Trim(TxtNombreContacto.Text)
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = Trim(TxtDireccion.Text)
                    .Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = Trim(TxtTelefono.Text)
                    .ExecuteNonQuery()
                    MessageBox.Show("Registro Modificado satisfactoriamente", "SeguridadLeon")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al  Modificar el cliente" + ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If TxtNombreCompañia.Text = Nothing And TxtNombreContacto.Text = Nothing And TxtTelefono.Text = Nothing And TxtDireccion.Text = Nothing Then
            EpError.SetError(TxtNombreCompañia, "Campo Obligatorio")
            EpError.SetError(TxtNombreContacto, "Campo Obligatorio")
            EpError.SetError(TxtTelefono, "Campo Obligatorio")
            EpError.SetError(TxtDireccion, "Campo Obligatorio")
            Estado = True
        ElseIf TxtNombreContacto.Text = Nothing And TxtTelefono.Text = Nothing And TxtDireccion.Text = Nothing Then
            EpError.SetError(TxtNombreContacto, "Campo Obligatorio")
            EpError.SetError(TxtTelefono, "Campo Obligatorio")
            EpError.SetError(TxtDireccion, "Campo Obligatorio")
            Estado = True
        ElseIf TxtTelefono.Text = Nothing And TxtDireccion.Text = Nothing Then
            EpError.SetError(TxtTelefono, "Campo Obligatorio")
            EpError.SetError(TxtDireccion, "Campo Obligatorio")
            Estado = True
        ElseIf TxtDireccion.Text = Nothing Then
            EpError.SetError(TxtDireccion, "Campo Obligatorio")
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub TxtNombreCompañia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombreCompañia.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNombreContacto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombreContacto.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
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
End Class