<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.WV = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.SystemTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SystemTrayIconContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenu_Show = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenu_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Startup = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenu_Restart = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.WV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SystemTrayIconContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'WV
        '
        Me.WV.CreationProperties = Nothing
        Me.WV.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WV.Location = New System.Drawing.Point(0, 0)
        Me.WV.Name = "WV"
        Me.WV.Size = New System.Drawing.Size(800, 450)
        Me.WV.Source = New System.Uri("https://app.simplifimoney.com/", System.UriKind.Absolute)
        Me.WV.TabIndex = 0
        Me.WV.ZoomFactor = 1.0R
        '
        'SystemTrayIcon
        '
        Me.SystemTrayIcon.ContextMenuStrip = Me.SystemTrayIconContextMenu
        Me.SystemTrayIcon.Icon = CType(resources.GetObject("SystemTrayIcon.Icon"), System.Drawing.Icon)
        Me.SystemTrayIcon.Text = "Simplifi"
        Me.SystemTrayIcon.Visible = True
        '
        'SystemTrayIconContextMenu
        '
        Me.SystemTrayIconContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextMenu_Show, Me.ContextMenu_Restart, Me.ContextMenu_Exit})
        Me.SystemTrayIconContextMenu.Name = "SystemTrayIconContextMenu"
        Me.SystemTrayIconContextMenu.Size = New System.Drawing.Size(181, 92)
        '
        'ContextMenu_Show
        '
        Me.ContextMenu_Show.Name = "ContextMenu_Show"
        Me.ContextMenu_Show.Size = New System.Drawing.Size(180, 22)
        Me.ContextMenu_Show.Text = "Show"
        '
        'ContextMenu_Exit
        '
        Me.ContextMenu_Exit.Name = "ContextMenu_Exit"
        Me.ContextMenu_Exit.Size = New System.Drawing.Size(180, 22)
        Me.ContextMenu_Exit.Text = "Exit"
        '
        'Startup
        '
        Me.Startup.Enabled = True
        Me.Startup.Interval = 10
        '
        'ContextMenu_Restart
        '
        Me.ContextMenu_Restart.Name = "ContextMenu_Restart"
        Me.ContextMenu_Restart.Size = New System.Drawing.Size(180, 22)
        Me.ContextMenu_Restart.Text = "Restart"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.WV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Simplifi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.WV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SystemTrayIconContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WV As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents SystemTrayIcon As NotifyIcon
    Friend WithEvents SystemTrayIconContextMenu As ContextMenuStrip
    Friend WithEvents ContextMenu_Show As ToolStripMenuItem
    Friend WithEvents ContextMenu_Exit As ToolStripMenuItem
    Friend WithEvents Startup As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenu_Restart As ToolStripMenuItem
End Class
