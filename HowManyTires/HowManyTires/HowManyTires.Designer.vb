<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HowManyTires
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
        Me.lblAuto = New System.Windows.Forms.Label()
        Me.lblMoto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAuto
        '
        Me.lblAuto.AutoSize = True
        Me.lblAuto.Location = New System.Drawing.Point(34, 46)
        Me.lblAuto.Name = "lblAuto"
        Me.lblAuto.Size = New System.Drawing.Size(0, 13)
        Me.lblAuto.TabIndex = 0
        '
        'lblMoto
        '
        Me.lblMoto.AutoSize = True
        Me.lblMoto.Location = New System.Drawing.Point(34, 94)
        Me.lblMoto.Name = "lblMoto"
        Me.lblMoto.Size = New System.Drawing.Size(0, 13)
        Me.lblMoto.TabIndex = 1
        '
        'HowManyTires
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 161)
        Me.Controls.Add(Me.lblMoto)
        Me.Controls.Add(Me.lblAuto)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(270, 200)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(270, 200)
        Me.Name = "HowManyTires"
        Me.Text = "How Many Tires?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAuto As Label
    Friend WithEvents lblMoto As Label
End Class
