<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.BtnButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrgProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PicDice = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PicDice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnButton
        '
        Me.BtnButton.Font = New System.Drawing.Font("Book Antiqua", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnButton.Location = New System.Drawing.Point(475, 699)
        Me.BtnButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnButton.Name = "BtnButton"
        Me.BtnButton.Size = New System.Drawing.Size(179, 65)
        Me.BtnButton.TabIndex = 0
        Me.BtnButton.Text = "Roll"
        Me.BtnButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(441, 645)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 39)
        Me.Label1.TabIndex = 2
        '
        'PrgProgressBar
        '
        Me.PrgProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PrgProgressBar.Location = New System.Drawing.Point(0, 794)
        Me.PrgProgressBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PrgProgressBar.Name = "PrgProgressBar"
        Me.PrgProgressBar.Size = New System.Drawing.Size(1219, 23)
        Me.PrgProgressBar.TabIndex = 3
        Me.PrgProgressBar.Visible = False
        '
        'TmrTimer
        '
        '
        'PicDice
        '
        Me.PicDice.Location = New System.Drawing.Point(275, 38)
        Me.PicDice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicDice.Name = "PicDice"
        Me.PicDice.Size = New System.Drawing.Size(475, 475)
        Me.PicDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicDice.TabIndex = 1
        Me.PicDice.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RPG_Dice_App.My.Resources.Resources.Embellish2
        Me.PictureBox1.Location = New System.Drawing.Point(16, 209)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 246)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RPG_Dice_App.My.Resources.Resources.Embellish3
        Me.PictureBox2.Location = New System.Drawing.Point(1019, 209)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(187, 246)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1219, 817)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PrgProgressBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicDice)
        Me.Controls.Add(Me.BtnButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PicDice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnButton As Button
    Friend WithEvents PicDice As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PrgProgressBar As ProgressBar
    Friend WithEvents TmrTimer As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
