﻿Public Class frmMain

    Private Sub btnWriteLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteLog.Click
        Dim T1 As String = TxtCH.Text
        Dim T2 As String = TxtLV.Text

        If T1.Length <= 0 Or T2.Length <= 0 Then Exit Sub
        CELOGDLL.CELog.WriteLog(T1, T2)
    End Sub
End Class
