Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe")
        Process.Start("C:\Program Files (x86)\Microsoft SQL Server\130\Tools\Binn\ManagementStudio\Ssms.exe")
        Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
        Process.Start("C:\Program Files (x86)\Microsoft VS Code\Code.exe")
        Process.Start("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office 2013\Outlook 2013")
        Process.Start("C:\Users\kdominguez\AppData\Local\atom\atom.exe")
        Application.ExitThread()
    End Sub
End Class
