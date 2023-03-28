<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.btnWriteLog = New System.Windows.Forms.Button
        Me.TxtLV = New System.Windows.Forms.TextBox
        Me.lblCH = New System.Windows.Forms.Label
        Me.TxtCH = New System.Windows.Forms.TextBox
        Me.lblLV = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnWriteLog
        '
        Me.btnWriteLog.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.btnWriteLog.Location = New System.Drawing.Point(5, 82)
        Me.btnWriteLog.Name = "btnWriteLog"
        Me.btnWriteLog.Size = New System.Drawing.Size(217, 36)
        Me.btnWriteLog.TabIndex = 23
        Me.btnWriteLog.Text = "Write File Exist(Now)"
        '
        'TxtLV
        '
        Me.TxtLV.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.TxtLV.Location = New System.Drawing.Point(54, 44)
        Me.TxtLV.Name = "TxtLV"
        Me.TxtLV.Size = New System.Drawing.Size(100, 32)
        Me.TxtLV.TabIndex = 22
        Me.TxtLV.Text = "20"
        '
        'lblCH
        '
        Me.lblCH.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lblCH.Location = New System.Drawing.Point(5, 44)
        Me.lblCH.Name = "lblCH"
        Me.lblCH.Size = New System.Drawing.Size(51, 32)
        Me.lblCH.Text = "CH:"
        '
        'TxtCH
        '
        Me.TxtCH.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.TxtCH.Location = New System.Drawing.Point(54, 3)
        Me.TxtCH.Name = "TxtCH"
        Me.TxtCH.Size = New System.Drawing.Size(100, 32)
        Me.TxtCH.TabIndex = 21
        Me.TxtCH.Text = "10"
        '
        'lblLV
        '
        Me.lblLV.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lblLV.Location = New System.Drawing.Point(5, 3)
        Me.lblLV.Name = "lblLV"
        Me.lblLV.Size = New System.Drawing.Size(43, 29)
        Me.lblLV.Text = "LV:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(388, 185)
        Me.Controls.Add(Me.btnWriteLog)
        Me.Controls.Add(Me.TxtLV)
        Me.Controls.Add(Me.lblCH)
        Me.Controls.Add(Me.TxtCH)
        Me.Controls.Add(Me.lblLV)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmMain"
        Me.Text = "Call DLL CELOGDLL"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnWriteLog As System.Windows.Forms.Button
    Friend WithEvents TxtLV As System.Windows.Forms.TextBox
    Friend WithEvents lblCH As System.Windows.Forms.Label
    Friend WithEvents TxtCH As System.Windows.Forms.TextBox
    Friend WithEvents lblLV As System.Windows.Forms.Label

End Class
