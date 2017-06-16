Imports System.Data.SqlClient
Public Class FrmInventario
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click
        If Validar() = False Then
        Else
            AgregarArma()
            Txtcalibre.Text = ""
            Txtserie.Text = ""
            Txtfabricacion.Text = ""
            CboTipoArma.Text = ""
            Cbomodelo.SelectedIndex = -1
            Cbomarca.SelectedIndex = -1
        End If
    End Sub

    Private Sub Btnatras_Click(sender As Object, e As EventArgs) Handles Btnatras.Click
        Me.Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub tBtninicio_Click(sender As Object, e As EventArgs) Handles tBtninicio.Click
        Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTipoArma()
        CargarModelo()
        CargarMarca()
        Cbomarca.Text = ""
        Cbomodelo.Text = ""
        CboTipoArma.Text = ""
    End Sub

    Private Sub CargarTipoArma()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarTipoArma1"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoArma")
                CboTipoArma.DataSource = ds.Tables(0)
                CboTipoArma.DisplayMember = ds.Tables(0).Columns("TipoArma").ToString
                CboTipoArma.ValueMember = ds.Tables(0).Columns("IdTipoArma").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub CargarModelo()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Modelo")
                Cbomodelo.DataSource = ds.Tables(0)
                Cbomodelo.DisplayMember = ds.Tables(0).Columns("Modelo").ToString
                Cbomodelo.ValueMember = ds.Tables(0).Columns("IdModelo").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub CargarMarca()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "CargarMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Marca")
                Cbomarca.DataSource = ds.Tables(0)
                Cbomarca.DisplayMember = ds.Tables(0).Columns("Marca").ToString
                Cbomarca.ValueMember = ds.Tables(0).Columns("IdMarca").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub
    Private Sub AgregarArma()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "InsertInventarioArmas"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn
                    .Parameters.Add("@Serie", SqlDbType.NVarChar).Value = Txtserie.Text
                    .Parameters.Add("@Calibre", SqlDbType.NVarChar).Value = Txtcalibre.Text
                    .Parameters.Add("@Fabricacion", SqlDbType.NVarChar).Value = Txtfabricacion.Text
                    .Parameters.Add("@IdTipoArma", SqlDbType.Int).Value = CboTipoArma.SelectedValue
                    .Parameters.Add("@IdModelo", SqlDbType.Int).Value = Cbomodelo.SelectedValue

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
    Private Function Validar() As Boolean
        Dim estado As Boolean
        If Txtserie.Text = "" And Txtcalibre.Text = "" And Txtfabricacion.Text = "" And Cbomarca.Text = "" And Cbomodelo.Text = "" And CboTipoArma.Text = "" Then
            EpError.SetError(Txtserie, "Campo obligatorio")
            EpError.SetError(Txtcalibre, "Campo obligatorio")
            EpError.SetError(Txtfabricacion, "Campo obligatorio")
            EpError.SetError(Cbomarca, "Campo obligatorio")
            EpError.SetError(Cbomodelo, "Campo obligatorio")
            EpError.SetError(CboTipoArma, "Campo obligatorio")
            estado = False
        ElseIf Txtcalibre.Text = "" And Txtfabricacion.Text = "" And Cbomarca.Text = "" And Cbomodelo.Text = "" And CboTipoArma.Text = "" Then
            EpError.SetError(Txtcalibre, "Campo obligatorio")
            EpError.SetError(Txtfabricacion, "Campo obligatorio")
            EpError.SetError(Cbomarca, "Campo obligatorio")
            EpError.SetError(Cbomodelo, "Campo obligatorio")
            EpError.SetError(CboTipoArma, "Campo obligatorio")
            estado = False
        ElseIf Txtfabricacion.Text = "" And Cbomarca.Text = "" And Cbomodelo.Text = "" And CboTipoArma.Text = "" Then
            EpError.SetError(Txtfabricacion, "Campo obligatorio")
            EpError.SetError(Cbomarca, "Campo obligatorio")
            EpError.SetError(Cbomodelo, "Campo obligatorio")
            EpError.SetError(CboTipoArma, "Campo obligatorio")
            estado = False
        ElseIf Cbomarca.Text = "" And Cbomodelo.Text = "" And CboTipoArma.Text = "" Then
            EpError.SetError(Cbomarca, "Campo obligatorio")
            EpError.SetError(Cbomodelo, "Campo obligatorio")
            EpError.SetError(CboTipoArma, "Campo obligatorio")
            estado = False
        ElseIf Cbomodelo.Text = "" And CboTipoArma.Text = "" Then
            EpError.SetError(Cbomodelo, "Campo obligatorio")
            EpError.SetError(CboTipoArma, "Campo obligatorio")
            estado = False
        ElseIf CboTipoArma.Text = "" Then
            EpError.SetError(CboTipoArma, "Campo obligatorio")
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function

    Private Sub Txtserie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtserie.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txtcalibre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtcalibre.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub Txtfabricacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtfabricacion.KeyPress
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
End Class