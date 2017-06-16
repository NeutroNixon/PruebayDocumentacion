Imports System.Data.SqlClient
Public Class FrmContratoCliente
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        FrmTipoContrato.Show()

    End Sub

    Private Sub FrmContratoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCliente()
        CboNombreCliente.Text = ""
    End Sub

    Private Sub AgregarContrato()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "InsertContratoCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@FechaInicio", SqlDbType.Date).Value = DtpFechaInicio.Value
                    .Parameters.Add("@FechaFinal", SqlDbType.Date).Value = DtpFechaFinal.Value
                    .Parameters.Add("@IdCliente", SqlDbType.Int).Value = CboNombreCliente.SelectedValue
                    .Parameters.Add("@Observacion", SqlDbType.NVarChar).Value = TxtObservaciones.Text
                    .Parameters.Add("@NumeroGuardia", SqlDbType.Int).Value = TxtNguardias.Text


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

    Private Sub CargarCliente()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "NombreCompañia")
                CboNombreCliente.DataSource = ds.Tables(0)
                CboNombreCliente.DisplayMember = ds.Tables(0).Columns("NombreCompañia").ToString
                CboNombreCliente.ValueMember = ds.Tables(0).Columns("IdCliente").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub PbxGuardar_Click(sender As Object, e As EventArgs) Handles PbxGuardar.Click
        If validar() = False Then
        Else
            AgregarContrato()

            TxtNguardias.Text = ""
            TxtObservaciones.Text = ""
            CboNombreCliente.Text = ""
        End If
    End Sub

    Private Function validar() As Boolean
        Dim estado As Boolean
        If TxtNguardias.Text = "" And TxtObservaciones.Text = "" And CboNombreCliente.Text = "" Then
            EpError.SetError(TxtNguardias, "Campo Obligatorio")
            EpError.SetError(TxtObservaciones, "Campo Obligatorio")
            EpError.SetError(CboNombreCliente, "Campo Obligatorio")
            estado = False
        ElseIf TxtNguardias.Text = "" And TxtObservaciones.Text = "" And CboNombreCliente.Text = "" Then
            EpError.SetError(TxtNguardias, "Campo Obligatorio")
            EpError.SetError(TxtObservaciones, "Campo Obligatorio")
            EpError.SetError(CboNombreCliente, "Campo Obligatorio")
            estado = False
        ElseIf TxtNguardias.Text = "" And TxtObservaciones.Text = "" And CboNombreCliente.Text = "" Then
            EpError.SetError(TxtNguardias, "Campo Obligatorio")
            EpError.SetError(TxtObservaciones, "Campo Obligatorio")
            EpError.SetError(CboNombreCliente, "Campo Obligatorio")
            estado = False
        ElseIf TxtObservaciones.Text = "" And CboNombreCliente.Text = "" Then
            EpError.SetError(TxtObservaciones, "Campo Obligatorio")
            EpError.SetError(CboNombreCliente, "Campo Obligatorio")
            estado = False
        ElseIf CboNombreCliente.Text = "" Then
            EpError.SetError(CboNombreCliente, "Campo Obligatorio")
        Else
            estado = True
        End If
        Return estado
    End Function
End Class