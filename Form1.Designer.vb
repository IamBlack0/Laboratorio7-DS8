<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.btEnviar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cbHabitacion = New System.Windows.Forms.ComboBox()
        Me.dtaFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtaFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbHabitacion = New System.Windows.Forms.Label()
        Me.LbFechaIni = New System.Windows.Forms.Label()
        Me.FechaSali = New System.Windows.Forms.Label()
        Me.btReportes = New System.Windows.Forms.Button()
        Me.btBackup = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(523, 152)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(271, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 31)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Reserva"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria Math", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, -87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 268)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ELPerroHotel"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(122, 229)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(71, 20)
        Me.lbNombre.TabIndex = 5
        Me.lbNombre.Text = "Nombre"
        '
        'btEnviar
        '
        Me.btEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEnviar.Location = New System.Drawing.Point(389, 451)
        Me.btEnviar.Name = "btEnviar"
        Me.btEnviar.Size = New System.Drawing.Size(110, 33)
        Me.btEnviar.TabIndex = 6
        Me.btEnviar.Text = "Reservar"
        Me.btEnviar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(3, 33)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(284, 20)
        Me.txtNombre.TabIndex = 7
        '
        'cbHabitacion
        '
        Me.cbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHabitacion.FormattingEnabled = True
        Me.cbHabitacion.Items.AddRange(New Object() {"Individual", "Doble", "Suite"})
        Me.cbHabitacion.Location = New System.Drawing.Point(3, 134)
        Me.cbHabitacion.Name = "cbHabitacion"
        Me.cbHabitacion.Size = New System.Drawing.Size(284, 21)
        Me.cbHabitacion.TabIndex = 8
        '
        'dtaFechaInicio
        '
        Me.dtaFechaInicio.Location = New System.Drawing.Point(3, 63)
        Me.dtaFechaInicio.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.dtaFechaInicio.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtaFechaInicio.Name = "dtaFechaInicio"
        Me.dtaFechaInicio.Size = New System.Drawing.Size(284, 20)
        Me.dtaFechaInicio.TabIndex = 9
        Me.dtaFechaInicio.Value = New Date(2024, 10, 18, 0, 0, 0, 0)
        '
        'dtaFechaSalida
        '
        Me.dtaFechaSalida.Location = New System.Drawing.Point(3, 102)
        Me.dtaFechaSalida.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.dtaFechaSalida.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtaFechaSalida.Name = "dtaFechaSalida"
        Me.dtaFechaSalida.Size = New System.Drawing.Size(284, 20)
        Me.dtaFechaSalida.TabIndex = 10
        Me.dtaFechaSalida.Value = New Date(2024, 10, 18, 0, 0, 0, 0)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.cbHabitacion)
        Me.Panel2.Controls.Add(Me.dtaFechaSalida)
        Me.Panel2.Controls.Add(Me.dtaFechaInicio)
        Me.Panel2.Location = New System.Drawing.Point(212, 196)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(290, 186)
        Me.Panel2.TabIndex = 11
        '
        'lbHabitacion
        '
        Me.lbHabitacion.AutoSize = True
        Me.lbHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHabitacion.Location = New System.Drawing.Point(37, 331)
        Me.lbHabitacion.Name = "lbHabitacion"
        Me.lbHabitacion.Size = New System.Drawing.Size(156, 20)
        Me.lbHabitacion.TabIndex = 12
        Me.lbHabitacion.Text = "Tipo de habitacion"
        '
        'LbFechaIni
        '
        Me.LbFechaIni.AutoSize = True
        Me.LbFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFechaIni.Location = New System.Drawing.Point(42, 260)
        Me.LbFechaIni.Name = "LbFechaIni"
        Me.LbFechaIni.Size = New System.Drawing.Size(151, 20)
        Me.LbFechaIni.TabIndex = 12
        Me.LbFechaIni.Text = "Fecha de entrada"
        '
        'FechaSali
        '
        Me.FechaSali.AutoSize = True
        Me.FechaSali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaSali.Location = New System.Drawing.Point(57, 299)
        Me.FechaSali.Name = "FechaSali"
        Me.FechaSali.Size = New System.Drawing.Size(136, 20)
        Me.FechaSali.TabIndex = 13
        Me.FechaSali.Text = "Fecha de salida"
        '
        'btReportes
        '
        Me.btReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReportes.Location = New System.Drawing.Point(215, 451)
        Me.btReportes.Name = "btReportes"
        Me.btReportes.Size = New System.Drawing.Size(110, 33)
        Me.btReportes.TabIndex = 15
        Me.btReportes.Text = "Reportes"
        Me.btReportes.UseVisualStyleBackColor = True
        '
        'btBackup
        '
        Me.btBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBackup.Location = New System.Drawing.Point(41, 451)
        Me.btBackup.Name = "btBackup"
        Me.btBackup.Size = New System.Drawing.Size(110, 33)
        Me.btBackup.TabIndex = 16
        Me.btBackup.Text = "Backup"
        Me.btBackup.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(550, 521)
        Me.Controls.Add(Me.btBackup)
        Me.Controls.Add(Me.btReportes)
        Me.Controls.Add(Me.FechaSali)
        Me.Controls.Add(Me.LbFechaIni)
        Me.Controls.Add(Me.lbHabitacion)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btEnviar)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "Lab 7 1 Ruben | Henry | Michael"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents btEnviar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cbHabitacion As ComboBox
    Friend WithEvents dtaFechaInicio As DateTimePicker
    Friend WithEvents dtaFechaSalida As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbHabitacion As Label
    Friend WithEvents LbFechaIni As Label
    Friend WithEvents FechaSali As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btReportes As Button
    Friend WithEvents btBackup As Button
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
