<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventario))
        Me.Cbomarca = New System.Windows.Forms.ComboBox()
        Me.Cbomodelo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtfabricacion = New System.Windows.Forms.TextBox()
        Me.Txtserie = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tBtninicio = New System.Windows.Forms.PictureBox()
        Me.Btnguardar = New System.Windows.Forms.PictureBox()
        Me.Btnatras = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtcalibre = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CboTipoArma = New System.Windows.Forms.ComboBox()
        Me.EpError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.tBtninicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btnguardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btnatras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.EpError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cbomarca
        '
        Me.Cbomarca.FormattingEnabled = True
        Me.Cbomarca.Location = New System.Drawing.Point(223, 278)
        Me.Cbomarca.Name = "Cbomarca"
        Me.Cbomarca.Size = New System.Drawing.Size(121, 21)
        Me.Cbomarca.TabIndex = 44
        '
        'Cbomodelo
        '
        Me.Cbomodelo.FormattingEnabled = True
        Me.Cbomodelo.Location = New System.Drawing.Point(223, 240)
        Me.Cbomodelo.Name = "Cbomodelo"
        Me.Cbomodelo.Size = New System.Drawing.Size(121, 21)
        Me.Cbomodelo.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(166, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Marca"
        '
        'Txtfabricacion
        '
        Me.Txtfabricacion.Location = New System.Drawing.Point(223, 173)
        Me.Txtfabricacion.Name = "Txtfabricacion"
        Me.Txtfabricacion.Size = New System.Drawing.Size(121, 20)
        Me.Txtfabricacion.TabIndex = 40
        '
        'Txtserie
        '
        Me.Txtserie.Location = New System.Drawing.Point(223, 100)
        Me.Txtserie.Name = "Txtserie"
        Me.Txtserie.Size = New System.Drawing.Size(121, 20)
        Me.Txtserie.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(157, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Modelo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(116, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Tipo de arma"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(127, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Fabricacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Calibre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(166, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Serie"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel2.Controls.Add(Me.tBtninicio)
        Me.Panel2.Controls.Add(Me.Btnguardar)
        Me.Panel2.Controls.Add(Me.Btnatras)
        Me.Panel2.Location = New System.Drawing.Point(-4, 339)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(544, 70)
        Me.Panel2.TabIndex = 31
        '
        'tBtninicio
        '
        Me.tBtninicio.Image = CType(resources.GetObject("tBtninicio.Image"), System.Drawing.Image)
        Me.tBtninicio.Location = New System.Drawing.Point(124, 6)
        Me.tBtninicio.Name = "tBtninicio"
        Me.tBtninicio.Size = New System.Drawing.Size(58, 58)
        Me.tBtninicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tBtninicio.TabIndex = 28
        Me.tBtninicio.TabStop = False
        '
        'Btnguardar
        '
        Me.Btnguardar.Image = CType(resources.GetObject("Btnguardar.Image"), System.Drawing.Image)
        Me.Btnguardar.Location = New System.Drawing.Point(257, 11)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(53, 53)
        Me.Btnguardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btnguardar.TabIndex = 26
        Me.Btnguardar.TabStop = False
        '
        'Btnatras
        '
        Me.Btnatras.Image = CType(resources.GetObject("Btnatras.Image"), System.Drawing.Image)
        Me.Btnatras.Location = New System.Drawing.Point(384, 11)
        Me.Btnatras.Margin = New System.Windows.Forms.Padding(0)
        Me.Btnatras.Name = "Btnatras"
        Me.Btnatras.Size = New System.Drawing.Size(53, 53)
        Me.Btnatras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btnatras.TabIndex = 27
        Me.Btnatras.TabStop = False
        Me.Btnatras.WaitOnLoad = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inventario"
        '
        'Txtcalibre
        '
        Me.Txtcalibre.Location = New System.Drawing.Point(223, 134)
        Me.Txtcalibre.Name = "Txtcalibre"
        Me.Txtcalibre.Size = New System.Drawing.Size(121, 20)
        Me.Txtcalibre.TabIndex = 39
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 70)
        Me.Panel1.TabIndex = 29
        '
        'CboTipoArma
        '
        Me.CboTipoArma.FormattingEnabled = True
        Me.CboTipoArma.Location = New System.Drawing.Point(223, 206)
        Me.CboTipoArma.Name = "CboTipoArma"
        Me.CboTipoArma.Size = New System.Drawing.Size(121, 21)
        Me.CboTipoArma.TabIndex = 45
        '
        'EpError
        '
        Me.EpError.ContainerControl = Me
        '
        'FrmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(536, 408)
        Me.Controls.Add(Me.CboTipoArma)
        Me.Controls.Add(Me.Cbomarca)
        Me.Controls.Add(Me.Cbomodelo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Txtfabricacion)
        Me.Controls.Add(Me.Txtserie)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txtcalibre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInventario"
        Me.Panel2.ResumeLayout(False)
        CType(Me.tBtninicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btnguardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btnatras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EpError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tBtninicio As PictureBox
    Friend WithEvents Btnatras As PictureBox
    Friend WithEvents Cbomarca As ComboBox
    Friend WithEvents Cbomodelo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Btnguardar As PictureBox
    Friend WithEvents Txtfabricacion As TextBox
    Friend WithEvents Txtserie As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtcalibre As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CboTipoArma As ComboBox
    Friend WithEvents EpError As ErrorProvider
End Class
