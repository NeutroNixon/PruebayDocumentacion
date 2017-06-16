<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporte))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PbxAtras = New System.Windows.Forms.PictureBox()
        Me.PbxEmpleado = New System.Windows.Forms.PictureBox()
        Me.PbxCliente = New System.Windows.Forms.PictureBox()
        Me.PbxContrato = New System.Windows.Forms.PictureBox()
        Me.PbxInventario = New System.Windows.Forms.PictureBox()
        Me.PbxPlanilla = New System.Windows.Forms.PictureBox()
        Me.PbxPrestaciones = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxPrestaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 70)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reportes"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PbxAtras)
        Me.Panel2.Location = New System.Drawing.Point(0, 382)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(874, 70)
        Me.Panel2.TabIndex = 1
        '
        'PbxAtras
        '
        Me.PbxAtras.Image = CType(resources.GetObject("PbxAtras.Image"), System.Drawing.Image)
        Me.PbxAtras.Location = New System.Drawing.Point(397, 7)
        Me.PbxAtras.Name = "PbxAtras"
        Me.PbxAtras.Size = New System.Drawing.Size(53, 53)
        Me.PbxAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxAtras.TabIndex = 0
        Me.PbxAtras.TabStop = False
        '
        'PbxEmpleado
        '
        Me.PbxEmpleado.Image = CType(resources.GetObject("PbxEmpleado.Image"), System.Drawing.Image)
        Me.PbxEmpleado.Location = New System.Drawing.Point(368, 96)
        Me.PbxEmpleado.Name = "PbxEmpleado"
        Me.PbxEmpleado.Size = New System.Drawing.Size(112, 92)
        Me.PbxEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxEmpleado.TabIndex = 2
        Me.PbxEmpleado.TabStop = False
        '
        'PbxCliente
        '
        Me.PbxCliente.Image = CType(resources.GetObject("PbxCliente.Image"), System.Drawing.Image)
        Me.PbxCliente.Location = New System.Drawing.Point(368, 243)
        Me.PbxCliente.Name = "PbxCliente"
        Me.PbxCliente.Size = New System.Drawing.Size(112, 92)
        Me.PbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxCliente.TabIndex = 3
        Me.PbxCliente.TabStop = False
        '
        'PbxContrato
        '
        Me.PbxContrato.Image = CType(resources.GetObject("PbxContrato.Image"), System.Drawing.Image)
        Me.PbxContrato.Location = New System.Drawing.Point(139, 96)
        Me.PbxContrato.Name = "PbxContrato"
        Me.PbxContrato.Size = New System.Drawing.Size(112, 92)
        Me.PbxContrato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxContrato.TabIndex = 4
        Me.PbxContrato.TabStop = False
        '
        'PbxInventario
        '
        Me.PbxInventario.Image = CType(resources.GetObject("PbxInventario.Image"), System.Drawing.Image)
        Me.PbxInventario.Location = New System.Drawing.Point(139, 243)
        Me.PbxInventario.Name = "PbxInventario"
        Me.PbxInventario.Size = New System.Drawing.Size(112, 92)
        Me.PbxInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxInventario.TabIndex = 5
        Me.PbxInventario.TabStop = False
        '
        'PbxPlanilla
        '
        Me.PbxPlanilla.Enabled = False
        Me.PbxPlanilla.Image = CType(resources.GetObject("PbxPlanilla.Image"), System.Drawing.Image)
        Me.PbxPlanilla.Location = New System.Drawing.Point(600, 96)
        Me.PbxPlanilla.Name = "PbxPlanilla"
        Me.PbxPlanilla.Size = New System.Drawing.Size(112, 92)
        Me.PbxPlanilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxPlanilla.TabIndex = 6
        Me.PbxPlanilla.TabStop = False
        '
        'PbxPrestaciones
        '
        Me.PbxPrestaciones.Image = CType(resources.GetObject("PbxPrestaciones.Image"), System.Drawing.Image)
        Me.PbxPrestaciones.Location = New System.Drawing.Point(600, 243)
        Me.PbxPrestaciones.Name = "PbxPrestaciones"
        Me.PbxPrestaciones.Size = New System.Drawing.Size(112, 92)
        Me.PbxPrestaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxPrestaciones.TabIndex = 7
        Me.PbxPrestaciones.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(361, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Reporte Empleado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(371, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Reporte Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(137, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Reporte Contrato"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(132, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Reporte Inventario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(600, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Reporte Planilla"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(582, 338)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Reporte Prestaciones"
        '
        'FrmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 452)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PbxPrestaciones)
        Me.Controls.Add(Me.PbxPlanilla)
        Me.Controls.Add(Me.PbxInventario)
        Me.Controls.Add(Me.PbxContrato)
        Me.Controls.Add(Me.PbxCliente)
        Me.Controls.Add(Me.PbxEmpleado)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxContrato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxPrestaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PbxEmpleado As PictureBox
    Friend WithEvents PbxAtras As PictureBox
    Friend WithEvents PbxCliente As PictureBox
    Friend WithEvents PbxContrato As PictureBox
    Friend WithEvents PbxInventario As PictureBox
    Friend WithEvents PbxPlanilla As PictureBox
    Friend WithEvents PbxPrestaciones As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
