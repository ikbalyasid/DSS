<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formdata
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
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.btnhps = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txnama = New System.Windows.Forms.TextBox()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvdata
        '
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Location = New System.Drawing.Point(13, 93)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.Size = New System.Drawing.Size(1018, 492)
        Me.dgvdata.TabIndex = 0
        '
        'btnhps
        '
        Me.btnhps.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhps.Location = New System.Drawing.Point(28, 12)
        Me.btnhps.Name = "btnhps"
        Me.btnhps.Size = New System.Drawing.Size(197, 56)
        Me.btnhps.TabIndex = 1
        Me.btnhps.Text = "HAPUS DATA "
        Me.btnhps.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari Data"
        '
        'txnama
        '
        Me.txnama.Location = New System.Drawing.Point(353, 32)
        Me.txnama.Name = "txnama"
        Me.txnama.Size = New System.Drawing.Size(149, 20)
        Me.txnama.TabIndex = 3
        '
        'formdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 597)
        Me.Controls.Add(Me.txnama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnhps)
        Me.Controls.Add(Me.dgvdata)
        Me.Name = "formdata"
        Me.Text = "formdata"
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvdata As System.Windows.Forms.DataGridView
    Friend WithEvents btnhps As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txnama As TextBox
End Class
