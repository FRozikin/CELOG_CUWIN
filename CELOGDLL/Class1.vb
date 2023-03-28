Imports System.IO

Public Class CELog

    Public Shared Function CekDir() As String
        Dim Dr As String = Directory.GetDirectoryRoot(Directory.GetCurrentDirectory)
        Dim Y As String = (Today.Year).ToString
        Dim M As String = Format(Today.Month, "00")

        Dim cDir As String = Dr & Y
        Dim cDirM As String = Dr & Y & "\" & M
        If Directory.Exists(cDir) Then
            'MsgBox(cDir & " : Direktori Exist")
            Directory.SetCurrentDirectory(cDir)
            If Directory.Exists(cDirM) Then
                'MsgBox(cDirM & " : Direktori Exist")
                Directory.SetCurrentDirectory(cDirM)
            Else
                Directory.CreateDirectory(cDirM)
                Directory.SetCurrentDirectory(cDirM)
            End If
        Else
            'MsgBox(cDir & " : Direktori not Exist")
            Directory.CreateDirectory(cDir)
            Directory.SetCurrentDirectory(cDir)
            If Directory.Exists(cDirM) Then
                'MsgBox(cDirM & " : Direktori Exist")
                Directory.SetCurrentDirectory(cDirM)
            Else
                Directory.CreateDirectory(cDirM)
                Directory.SetCurrentDirectory(cDirM)
            End If
        End If
        CekDir = Directory.GetCurrentDirectory
    End Function

    Public Shared Sub WriteLog(ByVal WL As String, ByVal HJ As String)
        Dim filePath As String = String.Format("{0}.csv", DateTime.Today.ToString("yyyy-MM-dd"))
        Dim T As String = String.Format(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"))
        T = T & ", " & WL & ", " & HJ
        Dim CDir As String = CekDir() & "\" & filePath
        '        Dim fileExist As Boolean = File.Exists(filePath)
        Dim fileExist As Boolean = File.Exists(CDir)

        Using writer As New StreamWriter(CDir, True)
            Console.WriteLine(CDir)
            If Not fileExist Then
                writer.WriteLine("Date_Time, WaterLevel, RainFall")
            End If
            writer.WriteLine(T)

        End Using

    End Sub

End Class
