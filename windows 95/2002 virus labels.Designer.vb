﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _2002_virus_labels
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
        Me.original = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'original
        '
        Me.original.AutoSize = True
        Me.original.BackColor = System.Drawing.Color.Transparent
        Me.original.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.original.Location = New System.Drawing.Point(0, 0)
        Me.original.Name = "original"
        Me.original.Size = New System.Drawing.Size(303, 20)
        Me.original.TabIndex = 1
        Me.original.Text = "Welcome to the end of the internet!!!"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        '_2002_virus_labels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(300, 18)
        Me.Controls.Add(Me.original)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_2002_virus_labels"
        Me.ShowInTaskbar = False
        Me.Text = "_2002_virus_labels"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents original As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
