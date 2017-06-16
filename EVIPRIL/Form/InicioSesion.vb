
Imports System.Data.SqlClient
Public Class FrmInicioSesion
    Private Sub BtnInisioSesion_Click(sender As Object, e As EventArgs) Handles BtnInisioSesion.Click
        Using cnn As New SqlConnection(My.Settings.ConexionTemporal)

            Try
                cnn.Open()

                Dim user As String = Replace(TxtUsuario.Text, "", "'")
                Dim pass As String = SHA1(TxtContraseña.Text)

                Using cmd As New SqlCommand("Select * from Usuario Where Usuario = '" & user & "' and Contraseña = '" & pass & "'", cnn)

                    Dim reader As SqlDataReader = cmd.ExecuteReader


                    If reader.HasRows Then
                        reader.Read()
                        'UsuarioActivo.NombreCompleto = String.Format("Bienvenido {0} {(1)}", reader.GetValue(1), reader.GetValue(2))
                        Identificador.Nombre = TxtUsuario.Text
                        Dim f As New FrmPantallaPrincipal
                        f.Show()
                        Me.Hide()
                    Else
                        MsgBox("Usuario y contraseña invalido")
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub TxtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuario.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            TxtContraseña.Focus()

        End If


    End Sub

    Private Sub TxtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContraseña.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Registrar.Show()
    End Sub

    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.ConexionTemporal = My.Settings.Conexion
        My.Settings.Save()
        If Conexion() = False Then
            Dim frm As New FrmConfiguracion()
            frm.Show()
        End If
    End Sub

    Private Function Conexion() As Boolean
        Try
            cnn.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
