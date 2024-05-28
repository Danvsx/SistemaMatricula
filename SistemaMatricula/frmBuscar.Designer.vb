<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnGrafica = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(31, 30)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(283, 20)
        Me.txtBuscar.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(774, 331)
        Me.DataGridView1.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(569, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 51)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnGrafica
        '
        Me.btnGrafica.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGrafica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGrafica.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrafica.ForeColor = System.Drawing.Color.White
        Me.btnGrafica.Image = CType(resources.GetObject("btnGrafica.Image"), System.Drawing.Image)
        Me.btnGrafica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrafica.Location = New System.Drawing.Point(334, 448)
        Me.btnGrafica.Name = "btnGrafica"
        Me.btnGrafica.Size = New System.Drawing.Size(103, 32)
        Me.btnGrafica.TabIndex = 8
        Me.btnGrafica.Text = "Grafica"
        Me.btnGrafica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrafica.UseVisualStyleBackColor = False
        '
        'frmBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 495)
        Me.Controls.Add(Me.btnGrafica)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Name = "frmBuscar"
        Me.Text = "Sistema de Matricula - Buscar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnGrafica As Button
End Class
