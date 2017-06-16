Public Class FrmTipoContrato
    Private Sub FrmTipoContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarTipocontrato()
    End Sub
    Private Sub LlenarTipocontrato()
        CboTipoContrato.Items.Add("Cliente")
        CboTipoContrato.Items.Add("Empleado")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        FrmPantallaPrincipal.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If CboTipoContrato.Text = "Cliente" Then
            FrmContratoCliente.Show()
            Me.Hide()
        ElseIf CboTipoContrato.Text = "Empleado" Then
            FrmContratoEmpleado.Show()
            Me.Hide()
        End If
    End Sub
    Private Function Validar() As Boolean
        Dim estado As Boolean
        If CboTipoContrato.Text = "" Then
            EpError.SetError(CboTipoContrato, "Campo Obligatorio")
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function

    Private Sub CboTipoContrato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTipoContrato.SelectedIndexChanged

    End Sub
End Class