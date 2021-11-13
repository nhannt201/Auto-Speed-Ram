<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMSGctrl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMSGctrl))
        Me.lbl_text = New System.Windows.Forms.Label()
        Me.main_pan_colour = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.left_pan_colour = New System.Windows.Forms.Panel()
        Me.Open_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Close_timer = New System.Windows.Forms.Timer(Me.components)
        Me.proxy_timer = New System.Windows.Forms.Timer(Me.components)
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.main_pan_colour.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_text
        '
        Me.lbl_text.BackColor = System.Drawing.Color.Transparent
        Me.lbl_text.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_text.Location = New System.Drawing.Point(22, 22)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Size = New System.Drawing.Size(268, 56)
        Me.lbl_text.TabIndex = 2
        Me.lbl_text.Text = "Label1"
        '
        'main_pan_colour
        '
        Me.main_pan_colour.BackColor = System.Drawing.Color.Azure
        Me.main_pan_colour.BackgroundImage = CType(resources.GetObject("main_pan_colour.BackgroundImage"), System.Drawing.Image)
        Me.main_pan_colour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.main_pan_colour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.main_pan_colour.Controls.Add(Me.PictureBox1)
        Me.main_pan_colour.Controls.Add(Me.lbl_text)
        Me.main_pan_colour.Controls.Add(Me.lbl_title)
        Me.main_pan_colour.Controls.Add(Me.left_pan_colour)
        Me.main_pan_colour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_pan_colour.Location = New System.Drawing.Point(0, 0)
        Me.main_pan_colour.Name = "main_pan_colour"
        Me.main_pan_colour.Size = New System.Drawing.Size(290, 78)
        Me.main_pan_colour.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(271, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(23, 2)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(245, 12)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Label1"
        '
        'left_pan_colour
        '
        Me.left_pan_colour.BackColor = System.Drawing.Color.SkyBlue
        Me.left_pan_colour.BackgroundImage = CType(resources.GetObject("left_pan_colour.BackgroundImage"), System.Drawing.Image)
        Me.left_pan_colour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.left_pan_colour.Dock = System.Windows.Forms.DockStyle.Left
        Me.left_pan_colour.Location = New System.Drawing.Point(0, 0)
        Me.left_pan_colour.Name = "left_pan_colour"
        Me.left_pan_colour.Size = New System.Drawing.Size(24, 76)
        Me.left_pan_colour.TabIndex = 0
        '
        'Open_timer
        '
        Me.Open_timer.Interval = 8
        '
        'Close_timer
        '
        Me.Close_timer.Interval = 5
        '
        'proxy_timer
        '
        Me.proxy_timer.Interval = 3000
        '
        'PerformanceCounter1
        '
        Me.PerformanceCounter1.CategoryName = "Processor"
        Me.PerformanceCounter1.CounterName = "% Processor Time"
        Me.PerformanceCounter1.InstanceName = "_Total"
        '
        'frmMSGctrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 78)
        Me.Controls.Add(Me.main_pan_colour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMSGctrl"
        Me.Text = "Thông báo"
        Me.main_pan_colour.ResumeLayout(False)
        Me.main_pan_colour.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_text As Label
    Friend WithEvents main_pan_colour As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents left_pan_colour As Panel
    Friend WithEvents Open_timer As Timer
    Friend WithEvents Close_timer As Timer
    Friend WithEvents proxy_timer As Timer
    Friend WithEvents PerformanceCounter1 As PerformanceCounter
End Class
