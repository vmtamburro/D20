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
        Me.selectDice = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.picDragon = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.D4 = New System.Windows.Forms.Button()
        Me.D6 = New System.Windows.Forms.Button()
        Me.D10 = New System.Windows.Forms.Button()
        Me.D12 = New System.Windows.Forms.Button()
        Me.D20 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.picDragon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'selectDice
        '
        Me.selectDice.BackColor = System.Drawing.Color.RoyalBlue
        Me.selectDice.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectDice.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.selectDice.Location = New System.Drawing.Point(264, 30)
        Me.selectDice.Margin = New System.Windows.Forms.Padding(2)
        Me.selectDice.Name = "selectDice"
        Me.selectDice.Size = New System.Drawing.Size(240, 86)
        Me.selectDice.TabIndex = 0
        Me.selectDice.Text = "Select a Dice"
        Me.selectDice.UseVisualStyleBackColor = False
        Me.selectDice.UseWaitCursor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'picDragon
        '
        Me.picDragon.Image = Global.RPG_Dice_App.My.Resources.Resources.Embellish2
        Me.picDragon.Location = New System.Drawing.Point(56, 164)
        Me.picDragon.Name = "picDragon"
        Me.picDragon.Size = New System.Drawing.Size(184, 183)
        Me.picDragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDragon.TabIndex = 3
        Me.picDragon.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RPG_Dice_App.My.Resources.Resources.Embellish3
        Me.PictureBox1.Location = New System.Drawing.Point(507, 164)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'D4
        '
        Me.D4.BackColor = System.Drawing.Color.RoyalBlue
        Me.D4.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.D4.Location = New System.Drawing.Point(300, 164)
        Me.D4.Margin = New System.Windows.Forms.Padding(2)
        Me.D4.Name = "D4"
        Me.D4.Size = New System.Drawing.Size(155, 71)
        Me.D4.TabIndex = 4
        Me.D4.Text = "D4"
        Me.D4.UseVisualStyleBackColor = False
        Me.D4.UseWaitCursor = True
        '
        'D6
        '
        Me.D6.BackColor = System.Drawing.Color.RoyalBlue
        Me.D6.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.D6.Location = New System.Drawing.Point(300, 240)
        Me.D6.Margin = New System.Windows.Forms.Padding(2)
        Me.D6.Name = "D6"
        Me.D6.Size = New System.Drawing.Size(155, 70)
        Me.D6.TabIndex = 5
        Me.D6.Text = "D6"
        Me.D6.UseVisualStyleBackColor = False
        Me.D6.UseWaitCursor = True
        '
        'D10
        '
        Me.D10.BackColor = System.Drawing.Color.RoyalBlue
        Me.D10.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.D10.Location = New System.Drawing.Point(300, 315)
        Me.D10.Margin = New System.Windows.Forms.Padding(2)
        Me.D10.Name = "D10"
        Me.D10.Size = New System.Drawing.Size(155, 71)
        Me.D10.TabIndex = 6
        Me.D10.Text = "D10"
        Me.D10.UseVisualStyleBackColor = False
        Me.D10.UseWaitCursor = True
        '
        'D12
        '
        Me.D12.BackColor = System.Drawing.Color.RoyalBlue
        Me.D12.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.D12.Location = New System.Drawing.Point(302, 391)
        Me.D12.Margin = New System.Windows.Forms.Padding(2)
        Me.D12.Name = "D12"
        Me.D12.Size = New System.Drawing.Size(153, 66)
        Me.D12.TabIndex = 7
        Me.D12.Text = "D12"
        Me.D12.UseVisualStyleBackColor = False
        Me.D12.UseWaitCursor = True
        '
        'D20
        '
        Me.D20.BackColor = System.Drawing.Color.RoyalBlue
        Me.D20.Font = New System.Drawing.Font("Book Antiqua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.D20.Location = New System.Drawing.Point(302, 462)
        Me.D20.Margin = New System.Windows.Forms.Padding(2)
        Me.D20.Name = "D20"
        Me.D20.Size = New System.Drawing.Size(155, 68)
        Me.D20.TabIndex = 8
        Me.D20.Text = "D20"
        Me.D20.UseVisualStyleBackColor = False
        Me.D20.UseWaitCursor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RPG_Dice_App.My.Resources.Resources.Embellish1
        Me.PictureBox2.Location = New System.Drawing.Point(507, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(215, 86)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.RPG_Dice_App.My.Resources.Resources.Embellish1
        Me.PictureBox3.Location = New System.Drawing.Point(42, 30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(217, 86)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(761, 592)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.D20)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.D12)
        Me.Controls.Add(Me.picDragon)
        Me.Controls.Add(Me.D10)
        Me.Controls.Add(Me.D6)
        Me.Controls.Add(Me.selectDice)
        Me.Controls.Add(Me.D4)
        Me.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "RPG Dice Menu"
        CType(Me.picDragon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents selectDice As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents picDragon As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents D4 As Button
    Friend WithEvents D6 As Button
    Friend WithEvents D10 As Button
    Friend WithEvents D12 As Button
    Friend WithEvents D20 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
