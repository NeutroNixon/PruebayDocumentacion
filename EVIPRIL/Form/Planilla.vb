Imports System.Data.SqlClient
Public Class FrmPlanilla

    Private Sub CalcularPlanilla()
        Dim DiasTrabajados, SueldoDiario, Complemento, SueldoQuincenal, SubTotal, Ihss, DeducUniforme, Rap, OtrasDeduc, TotalDeduc, TotalPagar As Double

        SueldoDiario = CDbl(TxtSueldoDiario.Text)
        DiasTrabajados = CDbl(TxtDiasTrabajados.Text)
        Complemento = CDbl(TxtComplemento.Text)
        DeducUniforme = CDbl(TxtDeducUniforme.Text)
        OtrasDeduc = CDbl(TxtOtrasDeduc.Text)

        SueldoQuincenal = SueldoDiario * DiasTrabajados
        SubTotal = SueldoQuincenal + Complemento
        Ihss = SubTotal * 0.035
        Rap = SubTotal * 0.015
        TotalDeduc = Ihss + DeducUniforme + Rap + OtrasDeduc
        TotalPagar = SubTotal - TotalDeduc

        TxtSueldoQ.Text = SueldoQuincenal.ToString
        TxtSubTotal.Text = SubTotal.ToString
        TxtIhss.Text = Ihss.ToString
        TxtRap.Text = Rap.ToString
        TxtTotalDeduc.Text = TotalDeduc.ToString
        TxtTotalPagar.Text = TotalPagar.ToString

    End Sub

    Private Sub PbxCalcular_Click(sender As Object, e As EventArgs) Handles PbxCalcular.Click
        Call CalcularPlanilla()
    End Sub

    Private Sub PbxHome_Click(sender As Object, e As EventArgs) Handles PbxHome.Click
        Me.Hide()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub FrmPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PbxGuardar_Click(sender As Object, e As EventArgs) Handles PbxGuardar.Click
        If Validar() = False Then
        Else
            GuardarPlanilla()
        End If
    End Sub
    Private Sub GuardarPlanilla()
        cnn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertPlanilla"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cnn

                    .Parameters.Add("@SueldoDiario", SqlDbType.Int).Value = CDbl(TxtSueldoDiario.Text)
                    .Parameters.Add("@DiasTrabajados", SqlDbType.Int).Value = CDbl(TxtDiasTrabajados.Text)
                    .Parameters.Add("@Complemento", SqlDbType.Int).Value = CDbl(TxtComplemento.Text)
                    .Parameters.Add("@SubTotal", SqlDbType.Int).Value = CDbl(TxtSubTotal.Text)
                    .Parameters.Add("@IHSS", SqlDbType.Int).Value = CDbl(TxtIhss.Text)
                    .Parameters.Add("@DeduccionUniforme", SqlDbType.Int).Value = CDbl(TxtDeducUniforme.Text)
                    .Parameters.Add("@Rap", SqlDbType.Int).Value = CDbl(TxtRap.Text)
                    .Parameters.Add("@OtrasDeducciones", SqlDbType.Int).Value = CDbl(TxtOtrasDeduc.Text)
                    .Parameters.Add("@TotalDeducciones", SqlDbType.Int).Value = CDbl(TxtTotalDeduc.Text)
                    .Parameters.Add("@NetoPagar", SqlDbType.Int).Value = CDbl(TxtTotalPagar.Text)
                    .Parameters.Add("@NumIdentidad", SqlDbType.Char).Value = TxtNumIdentidad.Text
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
        If TxtNumIdentidad.Text = "" And TxtNombreEmpleado.Text = "" And TxtSueldoDiario.Text = "" And TxtDiasTrabajados.Text = "" And TxtComplemento.Text = "" And TxtDeducUniforme.Text = "" And TxtOtrasDeduc.Text = "" Then
            EpError.SetError(TxtNumIdentidad, "Campo Obligatorio")
            EpError.SetError(TxtNombreEmpleado, "Campo Obligatorio")
            EpError.SetError(TxtSueldoDiario, "Campo Obligatorio")
            EpError.SetError(TxtDiasTrabajados, "Campo Obligatorio")
            EpError.SetError(TxtComplemento, "Campo Obligatorio")
            EpError.SetError(TxtDeducUniforme, "Campo Obligatorio")
            EpError.SetError(TxtOtrasDeduc, "Campo Obligatorio")
            estado = False
        ElseIf TxtNombreEmpleado.Text = "" And TxtSueldoDiario.Text = "" And TxtDiasTrabajados.Text = "" And TxtComplemento.Text = "" And TxtDeducUniforme.Text = "" Then
            EpError.SetError(TxtNombreEmpleado, "Campo Obligatorio")
            EpError.SetError(TxtSueldoDiario, "Campo Obligatorio")
            EpError.SetError(TxtDiasTrabajados, "Campo Obligatorio")
            EpError.SetError(TxtComplemento, "Campo Obligatorio")
            EpError.SetError(TxtDeducUniforme, "Campo Obligatorio")
            estado = False
        ElseIf TxtSueldoDiario.Text = "" And TxtDiasTrabajados.Text = "" And TxtComplemento.Text = "" And TxtDeducUniforme.Text = "" Then
            EpError.SetError(TxtSueldoDiario, "Campo Obligatorio")
            EpError.SetError(TxtDiasTrabajados, "Campo Obligatorio")
            EpError.SetError(TxtComplemento, "Campo Obligatorio")
            EpError.SetError(TxtDeducUniforme, "Campo Obligatorio")
            estado = False
        ElseIf TxtDiasTrabajados.Text = "" And TxtComplemento.Text = "" And TxtDeducUniforme.Text = "" Then
            EpError.SetError(TxtDiasTrabajados, "Campo Obligatorio")
            EpError.SetError(TxtComplemento, "Campo Obligatorio")
            EpError.SetError(TxtDeducUniforme, "Campo Obligatorio")
            estado = False
        ElseIf TxtComplemento.Text = "" And TxtDeducUniforme.Text = "" Then
            EpError.SetError(TxtComplemento, "Campo Obligatorio")
            EpError.SetError(TxtDeducUniforme, "Campo Obligatorio")
            estado = False
        ElseIf TxtDeducUniforme.Text = "" Then
            EpError.SetError(TxtDeducUniforme, "Campo Obligatorio")
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function

    Private Sub TxtNumIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumIdentidad.KeyPress
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

    Private Sub TxtSueldoDiario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSueldoDiario.KeyPress
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

    Private Sub TxtDiasTrabajados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDiasTrabajados.KeyPress
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

    Private Sub TxtComplemento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtComplemento.KeyPress
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

    Private Sub TxtDeducUniforme_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDeducUniforme.KeyPress
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

    Private Sub TxtOtrasDeduc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOtrasDeduc.KeyPress
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

    Private Sub TxtNombreEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombreEmpleado.KeyPress
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