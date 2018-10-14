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
        Me.components = New System.ComponentModel.Container()
        Me.TmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PrgProgressBar = New System.Windows.Forms.ProgressBar()
        Me.BtnButton = New System.Windows.Forms.Button()
        Me.PicDice = New System.Windows.Forms.PictureBox()
        CType(Me.PicDice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmrTimer
        '
        '
        'PrgProgressBar
        '
        Me.PrgProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PrgProgressBar.Location = New System.Drawing.Point(0, 710)
        Me.PrgProgressBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PrgProgressBar.Name = "PrgProgressBar"
        Me.PrgProgressBar.Size = New System.Drawing.Size(660, 10)
        Me.PrgProgressBar.TabIndex = 0
        '
        'BtnButton
        '
        Me.BtnButton.BackColor = System.Drawing.Color.Red
        Me.BtnButton.Font = New System.Drawing.Font("Book Antiqua", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnButton.Location = New System.Drawing.Point(164, 639)
        Me.BtnButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnButton.Name = "BtnButton"
        Me.BtnButton.Size = New System.Drawing.Size(309, 66)
        Me.BtnButton.TabIndex = 1
        Me.BtnButton.Text = "Roll"
        Me.BtnButton.UseVisualStyleBackColor = False
        '
        'PicDice
        '
        Me.PicDice.Location = New System.Drawing.Point(13, 34)
        Me.PicDice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PicDice.Name = "PicDice"
        Me.PicDice.Size = New System.Drawing.Size(475, 475)
        Me.PicDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicDice.TabIndex = 2
        Me.PicDice.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(660, 720)
        Me.Controls.Add(Me.PicDice)
        Me.Controls.Add(Me.BtnButton)
        Me.Controls.Add(Me.PrgProgressBar)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "D20 Roller"
        CType(Me.PicDice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TmrTimer As Timer
    Friend WithEvents PrgProgressBar As ProgressBar
    Friend WithEvents BtnButton As Button
    Friend WithEvents PicDice As PictureBox
End Class
