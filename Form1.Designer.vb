<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgvViagens = New System.Windows.Forms.DataGridView()
        Me.btnBuscarRegistos = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        CType(Me.dgvViagens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvViagens
        '
        Me.dgvViagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViagens.Location = New System.Drawing.Point(12, 12)
        Me.dgvViagens.Name = "dgvViagens"
        Me.dgvViagens.Size = New System.Drawing.Size(443, 245)
        Me.dgvViagens.TabIndex = 0
        '
        'btnBuscarRegistos
        '
        Me.btnBuscarRegistos.Location = New System.Drawing.Point(484, 12)
        Me.btnBuscarRegistos.Name = "btnBuscarRegistos"
        Me.btnBuscarRegistos.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarRegistos.TabIndex = 1
        Me.btnBuscarRegistos.Text = "Ver Registos"
        Me.btnBuscarRegistos.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(484, 63)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(75, 23)
        Me.btnBackup.TabIndex = 2
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 689)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnBuscarRegistos)
        Me.Controls.Add(Me.dgvViagens)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvViagens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvViagens As DataGridView
    Friend WithEvents btnBuscarRegistos As Button
    Friend WithEvents btnBackup As Button
End Class
