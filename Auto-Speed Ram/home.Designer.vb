<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_gen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ck1 = New System.Windows.Forms.CheckBox()
        Me.ck2 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.so = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.rmm = New System.Windows.Forms.Label()
        Me.cpuu = New System.Windows.Forms.Label()
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.PerformanceCounter2 = New System.Diagnostics.PerformanceCounter()
        Me.pb1 = New System.Windows.Forms.ProgressBar()
        Me.pb2 = New System.Windows.Forms.ProgressBar()
        Me.ck3 = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerformanceCounter2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox1.Location = New System.Drawing.Point(98, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(429, 40)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox2.Location = New System.Drawing.Point(98, 180)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(429, 40)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Button1.Location = New System.Drawing.Point(127, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 57)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Giải phóng"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.ForeColor = System.Drawing.Color.LightGreen
        Me.Button2.Location = New System.Drawing.Point(349, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 57)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Giải phóng nghen"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_gen
        '
        Me.txt_gen.Location = New System.Drawing.Point(178, 154)
        Me.txt_gen.MaxLength = 4
        Me.txt_gen.Name = "txt_gen"
        Me.txt_gen.Size = New System.Drawing.Size(270, 20)
        Me.txt_gen.TabIndex = 4
        Me.txt_gen.Text = "1000"
        Me.txt_gen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nhập số nghen"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LightCoral
        Me.PictureBox3.Location = New System.Drawing.Point(98, 286)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(429, 40)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'ck1
        '
        Me.ck1.AutoSize = True
        Me.ck1.BackColor = System.Drawing.Color.Transparent
        Me.ck1.Checked = True
        Me.ck1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ck1.Enabled = False
        Me.ck1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ck1.Location = New System.Drawing.Point(116, 347)
        Me.ck1.Name = "ck1"
        Me.ck1.Size = New System.Drawing.Size(149, 17)
        Me.ck1.TabIndex = 7
        Me.ck1.Text = "Khởi động cùng Windows"
        Me.ck1.UseVisualStyleBackColor = False
        '
        'ck2
        '
        Me.ck2.AutoSize = True
        Me.ck2.BackColor = System.Drawing.Color.Transparent
        Me.ck2.Checked = True
        Me.ck2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ck2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ck2.Location = New System.Drawing.Point(116, 370)
        Me.ck2.Name = "ck2"
        Me.ck2.Size = New System.Drawing.Size(201, 17)
        Me.ck2.TabIndex = 8
        Me.ck2.Text = "Tự động giải phóng hệ thống liên tục"
        Me.ck2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(273, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Mặc định"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 497)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(550, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "* Tự động giải phóng hệ thống : Chức năng này sẽ chạy ẩn và tăng tốc hệ thông"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 466)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(410, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "* Khởi động cùng Windows : Tự động mở khi máy tính chạy!"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Location = New System.Drawing.Point(317, 332)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 76)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'so
        '
        Me.so.AutoSize = True
        Me.so.BackColor = System.Drawing.Color.Transparent
        Me.so.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.so.Location = New System.Drawing.Point(333, 350)
        Me.so.Name = "so"
        Me.so.Size = New System.Drawing.Size(37, 39)
        Me.so.TabIndex = 5
        Me.so.Text = "5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(376, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "giây nữa tự ẩn"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(276, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Thiết lập"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(276, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Công cụ"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Black
        Me.PictureBox5.Location = New System.Drawing.Point(317, 226)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Auto-Speed Ram"
        Me.NotifyIcon1.Visible = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(381, 395)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "(Click vào số để dừng)"
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'rmm
        '
        Me.rmm.AutoSize = True
        Me.rmm.BackColor = System.Drawing.Color.Transparent
        Me.rmm.Location = New System.Drawing.Point(12, 441)
        Me.rmm.Name = "rmm"
        Me.rmm.Size = New System.Drawing.Size(57, 13)
        Me.rmm.TabIndex = 18
        Me.rmm.Text = "RAM: 20%"
        '
        'cpuu
        '
        Me.cpuu.AutoSize = True
        Me.cpuu.BackColor = System.Drawing.Color.Transparent
        Me.cpuu.Location = New System.Drawing.Point(204, 441)
        Me.cpuu.Name = "cpuu"
        Me.cpuu.Size = New System.Drawing.Size(61, 13)
        Me.cpuu.TabIndex = 19
        Me.cpuu.Text = "CPU: 100%"
        '
        'PerformanceCounter1
        '
        Me.PerformanceCounter1.CategoryName = "Processor"
        Me.PerformanceCounter1.CounterName = "% Processor Time"
        Me.PerformanceCounter1.InstanceName = "_Total"
        '
        'Timer4
        '
        Me.Timer4.Interval = 2000
        '
        'PerformanceCounter2
        '
        Me.PerformanceCounter2.CategoryName = "Memory"
        Me.PerformanceCounter2.CounterName = "% Committed Bytes In Use"
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(75, 444)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(123, 10)
        Me.pb1.TabIndex = 20
        '
        'pb2
        '
        Me.pb2.Location = New System.Drawing.Point(271, 444)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(123, 10)
        Me.pb2.TabIndex = 21
        '
        'ck3
        '
        Me.ck3.AutoSize = True
        Me.ck3.BackColor = System.Drawing.Color.Transparent
        Me.ck3.Checked = True
        Me.ck3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ck3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ck3.Location = New System.Drawing.Point(116, 395)
        Me.ck3.Name = "ck3"
        Me.ck3.Size = New System.Drawing.Size(186, 17)
        Me.ck3.TabIndex = 22
        Me.ck3.Text = "Tự động giải phóng khi 40% RAM"
        Me.ck3.UseVisualStyleBackColor = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Auto_Speed_Ram.My.Resources.Resources.Untitled
        Me.ClientSize = New System.Drawing.Size(660, 522)
        Me.Controls.Add(Me.ck3)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.cpuu)
        Me.Controls.Add(Me.rmm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.so)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ck2)
        Me.Controls.Add(Me.ck1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_gen)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "home"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto-Speed Ram"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerformanceCounter2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_gen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ck1 As CheckBox
    Friend WithEvents ck2 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents so As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents rmm As Label
    Friend WithEvents cpuu As Label
    Friend WithEvents PerformanceCounter1 As PerformanceCounter
    Friend WithEvents Timer4 As Timer
    Friend WithEvents PerformanceCounter2 As PerformanceCounter
    Friend WithEvents pb1 As ProgressBar
    Friend WithEvents pb2 As ProgressBar
    Friend WithEvents ck3 As CheckBox
End Class
