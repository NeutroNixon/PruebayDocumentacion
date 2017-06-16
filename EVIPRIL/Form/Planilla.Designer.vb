<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPlanilla
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlanilla))
        Me.TxtTotalPagar = New System.Windows.Forms.TextBox()
        Me.TxtTotalDeduc = New System.Windows.Forms.TextBox()
        Me.TxtOtrasDeduc = New System.Windows.Forms.TextBox()
        Me.TxtRap = New System.Windows.Forms.TextBox()
        Me.TxtDeducUniforme = New System.Windows.Forms.TextBox()
        Me.TxtIhss = New System.Windows.Forms.TextBox()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.TxtComplemento = New System.Windows.Forms.TextBox()
        Me.TxtSueldoQ = New System.Windows.Forms.TextBox()
        Me.TxtDiasTrabajados = New System.Windows.Forms.TextBox()
        Me.TxtSueldoDiario = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PbxCalcular = New System.Windows.Forms.PictureBox()
        Me.PbxImprimir = New System.Windows.Forms.PictureBox()
        Me.PbxHome = New System.Windows.Forms.PictureBox()
        Me.PbxGuardar = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNumIdentidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EpError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PbxCalcular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EpError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTotalPagar
        '
        Me.TxtTotalPagar.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtTotalPagar.Enabled = False
        Me.TxtTotalPagar.Location = New System.Drawing.Point(404, 428)
        Me.TxtTotalPagar.Multiline = True
        Me.TxtTotalPagar.Name = "TxtTotalPagar"
        Me.TxtTotalPagar.Size = New System.Drawing.Size(198, 25)
        Me.TxtTotalPagar.TabIndex = 73
        Me.TxtTotalPagar.Text = "0"
        '
        'TxtTotalDeduc
        '
        Me.TxtTotalDeduc.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtTotalDeduc.Enabled = False
        Me.TxtTotalDeduc.Location = New System.Drawing.Point(649, 380)
        Me.TxtTotalDeduc.Multiline = True
        Me.TxtTotalDeduc.Name = "TxtTotalDeduc"
        Me.TxtTotalDeduc.Size = New System.Drawing.Size(198, 25)
        Me.TxtTotalDeduc.TabIndex = 72
        Me.TxtTotalDeduc.Text = "0"
        '
        'TxtOtrasDeduc
        '
        Me.TxtOtrasDeduc.Location = New System.Drawing.Point(649, 339)
        Me.TxtOtrasDeduc.Multiline = True
        Me.TxtOtrasDeduc.Name = "TxtOtrasDeduc"
        Me.TxtOtrasDeduc.Size = New System.Drawing.Size(198, 25)
        Me.TxtOtrasDeduc.TabIndex = 71
        '
        'TxtRap
        '
        Me.TxtRap.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtRap.Enabled = False
        Me.TxtRap.Location = New System.Drawing.Point(649, 296)
        Me.TxtRap.Multiline = True
        Me.TxtRap.Name = "TxtRap"
        Me.TxtRap.Size = New System.Drawing.Size(198, 25)
        Me.TxtRap.TabIndex = 70
        Me.TxtRap.Text = "0"
        '
        'TxtDeducUniforme
        '
        Me.TxtDeducUniforme.Location = New System.Drawing.Point(649, 256)
        Me.TxtDeducUniforme.Multiline = True
        Me.TxtDeducUniforme.Name = "TxtDeducUniforme"
        Me.TxtDeducUniforme.Size = New System.Drawing.Size(198, 25)
        Me.TxtDeducUniforme.TabIndex = 69
        '
        'TxtIhss
        '
        Me.TxtIhss.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtIhss.Enabled = False
        Me.TxtIhss.Location = New System.Drawing.Point(649, 217)
        Me.TxtIhss.Multiline = True
        Me.TxtIhss.Name = "TxtIhss"
        Me.TxtIhss.Size = New System.Drawing.Size(198, 25)
        Me.TxtIhss.TabIndex = 68
        Me.TxtIhss.Text = "0"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtSubTotal.Enabled = False
        Me.TxtSubTotal.Location = New System.Drawing.Point(200, 383)
        Me.TxtSubTotal.Multiline = True
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.Size = New System.Drawing.Size(198, 25)
        Me.TxtSubTotal.TabIndex = 67
        Me.TxtSubTotal.Text = "0"
        '
        'TxtComplemento
        '
        Me.TxtComplemento.Location = New System.Drawing.Point(200, 341)
        Me.TxtComplemento.Multiline = True
        Me.TxtComplemento.Name = "TxtComplemento"
        Me.TxtComplemento.Size = New System.Drawing.Size(198, 25)
        Me.TxtComplemento.TabIndex = 66
        '
        'TxtSueldoQ
        '
        Me.TxtSueldoQ.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtSueldoQ.Enabled = False
        Me.TxtSueldoQ.Location = New System.Drawing.Point(200, 300)
        Me.TxtSueldoQ.Multiline = True
        Me.TxtSueldoQ.Name = "TxtSueldoQ"
        Me.TxtSueldoQ.Size = New System.Drawing.Size(198, 25)
        Me.TxtSueldoQ.TabIndex = 65
        Me.TxtSueldoQ.Text = "0"
        '
        'TxtDiasTrabajados
        '
        Me.TxtDiasTrabajados.Location = New System.Drawing.Point(200, 257)
        Me.TxtDiasTrabajados.Multiline = True
        Me.TxtDiasTrabajados.Name = "TxtDiasTrabajados"
        Me.TxtDiasTrabajados.Size = New System.Drawing.Size(198, 25)
        Me.TxtDiasTrabajados.TabIndex = 64
        '
        'TxtSueldoDiario
        '
        Me.TxtSueldoDiario.Location = New System.Drawing.Point(200, 217)
        Me.TxtSueldoDiario.Multiline = True
        Me.TxtSueldoDiario.Name = "TxtSueldoDiario"
        Me.TxtSueldoDiario.Size = New System.Drawing.Size(198, 25)
        Me.TxtSueldoDiario.TabIndex = 63
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 70)
        Me.Panel1.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(421, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 31)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Planilla"
        '
        'TxtNombreEmpleado
        '
        Me.TxtNombreEmpleado.Location = New System.Drawing.Point(404, 128)
        Me.TxtNombreEmpleado.Multiline = True
        Me.TxtNombreEmpleado.Name = "TxtNombreEmpleado"
        Me.TxtNombreEmpleado.Size = New System.Drawing.Size(198, 25)
        Me.TxtNombreEmpleado.TabIndex = 61
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PbxCalcular)
        Me.Panel2.Controls.Add(Me.PbxImprimir)
        Me.Panel2.Controls.Add(Me.PbxHome)
        Me.Panel2.Controls.Add(Me.PbxGuardar)
        Me.Panel2.Location = New System.Drawing.Point(0, 475)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 70)
        Me.Panel2.TabIndex = 59
        '
        'PbxCalcular
        '
        Me.PbxCalcular.Image = CType(resources.GetObject("PbxCalcular.Image"), System.Drawing.Image)
        Me.PbxCalcular.Location = New System.Drawing.Point(518, 7)
        Me.PbxCalcular.Name = "PbxCalcular"
        Me.PbxCalcular.Size = New System.Drawing.Size(58, 58)
        Me.PbxCalcular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxCalcular.TabIndex = 10
        Me.PbxCalcular.TabStop = False
        '
        'PbxImprimir
        '
        Me.PbxImprimir.Enabled = False
        Me.PbxImprimir.Image = CType(resources.GetObject("PbxImprimir.Image"), System.Drawing.Image)
        Me.PbxImprimir.Location = New System.Drawing.Point(680, 10)
        Me.PbxImprimir.Name = "PbxImprimir"
        Me.PbxImprimir.Size = New System.Drawing.Size(58, 58)
        Me.PbxImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxImprimir.TabIndex = 9
        Me.PbxImprimir.TabStop = False
        '
        'PbxHome
        '
        Me.PbxHome.Image = CType(resources.GetObject("PbxHome.Image"), System.Drawing.Image)
        Me.PbxHome.Location = New System.Drawing.Point(226, 9)
        Me.PbxHome.Name = "PbxHome"
        Me.PbxHome.Size = New System.Drawing.Size(58, 58)
        Me.PbxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxHome.TabIndex = 8
        Me.PbxHome.TabStop = False
        '
        'PbxGuardar
        '
        Me.PbxGuardar.Image = CType(resources.GetObject("PbxGuardar.Image"), System.Drawing.Image)
        Me.PbxGuardar.Location = New System.Drawing.Point(370, 11)
        Me.PbxGuardar.Name = "PbxGuardar"
        Me.PbxGuardar.Size = New System.Drawing.Size(53, 53)
        Me.PbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxGuardar.TabIndex = 6
        Me.PbxGuardar.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(295, 431)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 16)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Total a Pagar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(504, 383)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 16)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Total Deducciones"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(503, 342)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 16)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Otras Deducciones"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(592, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 16)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "R.A.P."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(473, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 16)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Deduccion de Uniforme"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(591, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "I.H.S.S."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(119, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Sub Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(90, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Complemento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(63, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 16)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Sueldo Quincenal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 16)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Dias Trabajados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(90, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Sueldo Diario"
        '
        'TxtNumIdentidad
        '
        Me.TxtNumIdentidad.Location = New System.Drawing.Point(404, 84)
        Me.TxtNumIdentidad.Multiline = True
        Me.TxtNumIdentidad.Name = "TxtNumIdentidad"
        Me.TxtNumIdentidad.Size = New System.Drawing.Size(198, 25)
        Me.TxtNumIdentidad.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Nombre Empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Número de Identidad"
        '
        'EpError
        '
        Me.EpError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.EpError.ContainerControl = Me
        '
        'FrmPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(985, 545)
        Me.Controls.Add(Me.TxtTotalPagar)
        Me.Controls.Add(Me.TxtTotalDeduc)
        Me.Controls.Add(Me.TxtOtrasDeduc)
        Me.Controls.Add(Me.TxtRap)
        Me.Controls.Add(Me.TxtDeducUniforme)
        Me.Controls.Add(Me.TxtIhss)
        Me.Controls.Add(Me.TxtSubTotal)
        Me.Controls.Add(Me.TxtComplemento)
        Me.Controls.Add(Me.TxtSueldoQ)
        Me.Controls.Add(Me.TxtDiasTrabajados)
        Me.Controls.Add(Me.TxtSueldoDiario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtNombreEmpleado)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNumIdentidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPlanilla"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PbxCalcular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EpError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTotalPagar As TextBox
    Friend WithEvents TxtTotalDeduc As TextBox
    Friend WithEvents TxtOtrasDeduc As TextBox
    Friend WithEvents TxtRap As TextBox
    Friend WithEvents TxtDeducUniforme As TextBox
    Friend WithEvents TxtIhss As TextBox
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents TxtComplemento As TextBox
    Friend WithEvents TxtSueldoQ As TextBox
    Friend WithEvents TxtDiasTrabajados As TextBox
    Friend WithEvents TxtSueldoDiario As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtNombreEmpleado As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNumIdentidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PbxCalcular As PictureBox
    Friend WithEvents PbxImprimir As PictureBox
    Friend WithEvents PbxHome As PictureBox
    Friend WithEvents PbxGuardar As PictureBox
    Friend WithEvents EpError As ErrorProvider
End Class
