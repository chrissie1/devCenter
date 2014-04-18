<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmd_On = New System.Windows.Forms.Button()
        Me.cmd_Off = New System.Windows.Forms.Button()
        Me.labelResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmd_On
        '
        Me.cmd_On.Location = New System.Drawing.Point(12, 12)
        Me.cmd_On.Name = "cmd_On"
        Me.cmd_On.Size = New System.Drawing.Size(75, 23)
        Me.cmd_On.TabIndex = 0
        Me.cmd_On.Text = "An"
        Me.cmd_On.UseVisualStyleBackColor = True
        '
        'cmd_Off
        '
        Me.cmd_Off.Location = New System.Drawing.Point(12, 41)
        Me.cmd_Off.Name = "cmd_Off"
        Me.cmd_Off.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Off.TabIndex = 1
        Me.cmd_Off.Text = "Aus"
        Me.cmd_Off.UseVisualStyleBackColor = True
        '
        'labelResult
        '
        Me.labelResult.AutoSize = True
        Me.labelResult.Location = New System.Drawing.Point(114, 32)
        Me.labelResult.Name = "labelResult"
        Me.labelResult.Size = New System.Drawing.Size(21, 13)
        Me.labelResult.TabIndex = 2
        Me.labelResult.Text = "Off"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 79)
        Me.Controls.Add(Me.labelResult)
        Me.Controls.Add(Me.cmd_Off)
        Me.Controls.Add(Me.cmd_On)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_On As System.Windows.Forms.Button
    Friend WithEvents cmd_Off As System.Windows.Forms.Button
    Friend WithEvents labelResult As System.Windows.Forms.Label

End Class
