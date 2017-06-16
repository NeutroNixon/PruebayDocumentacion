Public Class FrmPantallaPrincipal
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        FrmReporte.Show()
    End Sub

    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblNombre.Text = Identificador.Nombre

    End Sub



    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        FrmTipoContrato.Show()
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.Hide()
        FrmPlanilla.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        FrmEmpleado.Show()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.Hide()
        FrmCliente.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        FrmInventario.Show()
    End Sub

    Private Sub LblCerrar_Click(sender As Object, e As EventArgs) Handles LblCerrar.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        FrmPrestaciones.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmInicioSesion.TxtContraseña.Text = ""
        FrmInicioSesion.TxtContraseña.Focus()
        Me.Hide()
        FrmInicioSesion.Show()
    End Sub

    Private Sub LbRegistrar_Click(sender As Object, e As EventArgs) Handles LbRegistrar.Click
        Me.Hide()
        Registrar.Show()
    End Sub
End Class