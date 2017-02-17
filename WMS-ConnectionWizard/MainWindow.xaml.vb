Class MainWindow
    Private Sub cmdClose_Click(sender As Object, e As RoutedEventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmdAbout_Click(sender As Object, e As RoutedEventArgs) Handles cmdAbout.Click
        MsgBox("Version " & System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(), MsgBoxStyle.Information, "About")
    End Sub
End Class
