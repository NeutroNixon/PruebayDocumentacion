Imports System.Data.SqlClient
Public Class FrmContratoEmpleado
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        FrmTipoContrato.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        FrmTipoContrato.Close()
        FrmPantallaPrincipal.Show()
    End Sub



    Private Sub AgregarContratoEmpleado()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "InsertContratoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@FechaInicio", SqlDbType.Date).Value = DtpFechaInicio.Value
                    .Parameters.Add("@FechaFinal", SqlDbType.Date).Value = DtpFechaFinal.Value
                    .Parameters.Add("@IdTipoContrato", SqlDbType.Int).Value = CboTipoContrato.SelectedValue
                    .Parameters.Add("@IdBeneficiario", SqlDbType.Int).Value = CboBeneficiario.SelectedValue
                    .Parameters.Add("@NumIdentidad", SqlDbType.Char).Value = TxtNumIdentidad.Text
                    .Parameters.Add("@IdTipoEmpleado", SqlDbType.Int).Value = CboTipoEmpleado.SelectedValue


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

    Private Sub CargarTipoEmpleado()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarTipoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoEmpleado")
                CboTipoEmpleado.DataSource = ds.Tables(0)
                CboTipoEmpleado.DisplayMember = ds.Tables(0).Columns("TipoEmpleado").ToString
                CboTipoEmpleado.ValueMember = ds.Tables(0).Columns("IdTipoEmpleado").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub CargarTipoContrato()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarTipoContrato"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoContrato")
                CboTipoContrato.DataSource = ds.Tables(0)
                CboTipoContrato.DisplayMember = ds.Tables(0).Columns("TipoContrato").ToString
                CboTipoContrato.ValueMember = ds.Tables(0).Columns("IdTipoContrato").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub
    Private Sub CargarBeneficiario()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarBeneficiario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Nombre")
                CboBeneficiario.DataSource = ds.Tables(0)
                CboBeneficiario.DisplayMember = ds.Tables(0).Columns("Nombre").ToString
                CboBeneficiario.ValueMember = ds.Tables(0).Columns("IdBeneficiario").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Validar() = False Then
        Else
            AgregarContratoEmpleado()
            TxtNumIdentidad.Text = ""
            CboBeneficiario.Text = ""
            CboTipoContrato.Text = ""
            CboTipoEmpleado.Text = ""
        End If
    End Sub

    Private Sub FrmContratoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarBeneficiario()
        CargarTipoContrato()
        CargarTipoEmpleado()
        CboBeneficiario.Text = ""
        CboTipoContrato.Text = ""
        CboTipoEmpleado.Text = ""

    End Sub
    Private Function Validar() As Boolean
        Dim estado As Boolean
        If CboTipoEmpleado.Text = "" And TxtNumIdentidad.Text = "" And CboTipoContrato.Text = "" And CboBeneficiario.Text = "" Then
            EpError.SetError(CboTipoEmpleado, "Campo Obligatorio")
            EpError.SetError(TxtNumIdentidad, "Campo Obligatorio")
            EpError.SetError(CboTipoContrato, "Campo Obligatorio")
            EpError.SetError(CboBeneficiario, "Campo Obligatorio")
            estado = False
        ElseIf TxtNumIdentidad.Text = "" And CboTipoContrato.Text = "" And CboBeneficiario.Text = "" Then
            EpError.SetError(TxtNumIdentidad, "Campo Obligatorio")
            EpError.SetError(CboTipoContrato, "Campo Obligatorio")
            EpError.SetError(CboBeneficiario, "Campo Obligatorio")
            estado = False
        ElseIf TxtNumIdentidad.Text = "" And CboTipoContrato.Text = "" And CboBeneficiario.Text = "" Then
            EpError.SetError(TxtNumIdentidad, "Campo Obligatorio")
            EpError.SetError(CboTipoContrato, "Campo Obligatorio")
            EpError.SetError(CboBeneficiario, "Campo Obligatorio")
            estado = False
        ElseIf TxtNumIdentidad.Text = "" And CboTipoContrato.Text = "" And CboBeneficiario.Text = "" Then
            EpError.SetError(TxtNumIdentidad, "Campo Obligatorio")
            EpError.SetError(CboTipoContrato, "Campo Obligatorio")
            EpError.SetError(CboBeneficiario, "Campo Obligatorio")
            estado = False
        ElseIf CboTipoContrato.Text = "" And CboBeneficiario.Text = "" Then
            EpError.SetError(CboTipoContrato, "Campo Obligatorio")
            EpError.SetError(CboBeneficiario, "Campo Obligatorio")
            estado = False
        ElseIf CboBeneficiario.Text = "" Then
            EpError.SetError(CboBeneficiario, "Campo Obligatorio")
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function
End Class