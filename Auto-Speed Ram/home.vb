Imports Microsoft.Win32
Imports System.IO.Stream

Public Class home
    Dim ram As Integer
    Dim cpu As Integer


    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Main()
        Dim reg As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", True)
        Dim path As String = Application.ExecutablePath
        reg.SetValue("Auto-Speed Ram", path)
        NotifyIcon1.BalloonTipText = "Tool Tip Text for Auto-Speed Ram"
        NotifyIcon1.Text = "Auto-Speed Ram"
        NotifyIcon1.ShowBalloonTip(5000)
        CreateContextMenu()

    End Sub
    Private Const maxGarbage As Integer = 1000
    Public Shared Property MyGCCollectClass As Object
    Public Sub CreateContextMenu()

        'Define New Context Menu and Menu Item 
        Dim contextMenu As New ContextMenu
        Dim menuItem2 As New MenuItem("Mở Auto-Speed Ram")
        contextMenu.MenuItems.Add(menuItem2)
        Dim menuItem As New MenuItem("Thoát")
        contextMenu.MenuItems.Add(menuItem)
        ' Associate context menu with Notify Icon 
        NotifyIcon1.ContextMenu = contextMenu

        'Add functionality for menu Item click 
        AddHandler menuItem.Click, AddressOf menuItem_Click
        AddHandler menuItem2.Click, AddressOf menuItem2_Click
    End Sub

    Private Sub menuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Show()
        so.Text = "5"
        Timer1.Start()
        Timer3.Start()
        Timer2.Stop()
        Timer4.Stop()

    End Sub

    Shared Sub Main()
        'Put some objects in memory.
        MyGCCollectClass.MakeSomeGarbage()
        Console.WriteLine("Memory used before collection:       {0:N0}",
                           GC.GetTotalMemory(False))

        'Collect all generations of memory.
        GC.Collect()
        Console.WriteLine("Memory used after full collection:   {0:N0}",
                           GC.GetTotalMemory(True))
    End Sub

    Shared Sub MakeSomeGarbage()
        Dim vt As Version

        Dim i As Integer
        For i = 0 To maxGarbage - 1
            'Create objects and release them to fill up memory with unused objects.
            vt = New Version()
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            System.GC.Collect()
            MessageBox.Show("Đã giải phóng " & Math.Round(Val(100 - PerformanceCounter1.NextValue - pb1.Value), 1) & "% hệ thống!")

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txt_gen.Text <> "" Then
                Dim gen As Integer = Convert.ToInt16(txt_gen.Text)
                System.GC.Collect(gen)
                MessageBox.Show("Đã giải phóng hệ thống theo số nghen!")
            Else
                MessageBox.Show("Vui lòng nhập nghen!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
        Try
            If txt_gen.Text <> "" Then
                Dim gen As Integer = Convert.ToInt16(txt_gen.Text)
                System.GC.Collect(gen, GCCollectionMode.Optimized)
                MessageBox.Show("Đã giải phóng hệ thống theo số nghen lần 2!")
            Else
                MessageBox.Show("Vui lòng nhập nghen!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub txt_gen_TextChanged(sender As Object, e As EventArgs) Handles txt_gen.TextChanged

    End Sub

    Private Sub txt_gen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_gen.KeyPress
        If Not (IsNumeric(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ck2_CheckedChanged(sender As Object, e As EventArgs) Handles ck2.CheckedChanged




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        so.Text = so.Text - 1
        If so.Text = 0 Then

            If ck2.Checked = True And ck3.Checked = False Then
                Me.Hide()
                Timer2.Enabled = True
                ' Timer3.Stop()
                Timer1.Enabled = False
            ElseIf ck2.Checked = False And ck3.Checked = True Then
                Me.Hide()
                Timer4.Start()
                'Timer3.Stop()
                Timer1.Enabled = False
            ElseIf ck2.Checked = False And ck3.Checked = False Then
                Me.Hide()
                ' Timer3.Stop()
                Timer1.Enabled = False
            ElseIf ck2.Checked = True And ck3.Checked = True Then
                Me.Hide()
                Timer2.Start()
                Timer4.Start()
                ' Timer3.Stop()
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub so_Click(sender As Object, e As EventArgs) Handles so.Click

        If Timer1.Enabled = True Then
            Timer1.Stop()
            Label5.Text = "(Click vào số để tiếp tục)"
        Else
            Timer1.Start()
            Label5.Text = "(Click vào số để dừng)"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            System.GC.Collect()
            ' MessageBox.Show("Đã giải phóng hệ thống!")
        Catch ex As Exception
            ' MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ram = PerformanceCounter1.NextValue
        rmm.Text = "RAM: " & ram & "%"
        pb1.Value = ram
        cpu = PerformanceCounter2.NextValue
        cpuu.Text = "CPU: " & cpu & "%"
        pb2.Value = cpu
        ' rmm.Text = "RAM: " & (My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / My.Computer.Info.TotalPhysicalMemory & "%"
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Try
            Dim gets As Integer = PerformanceCounter1.NextValue
            If gets >= 40 Then
                System.GC.Collect()
                'Timer3.Start()
                frmMSGctrl.Show()
                ' Timer3.Stop()
            End If
        Catch

        End Try
    End Sub
End Class
