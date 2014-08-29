<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutThis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutThis))
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(12, 19)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(42, 13)
        Me.LabelVersion.TabIndex = 0
        Me.LabelVersion.Text = "Version"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelProductName.Location = New System.Drawing.Point(12, 44)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(98, 13)
        Me.LabelProductName.TabIndex = 1
        Me.LabelProductName.Text = "LabelProductName"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Activate the developer Mode"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(181, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Deactivate the developer Mode"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'AboutThis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 104)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.LabelVersion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AboutThis"
        Me.Text = "About that..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
