Class MainWindow
    Private Sub AbrirButton_Click(sender As Object, e As RoutedEventArgs)
        Dim dialogo As New Microsoft.Win32.OpenFileDialog
        dialogo.Filter = "Archivos MOV|*.mov"

        If dialogo.ShowDialog() Then
            ReproductorMediaElement.Source = New Uri(dialogo.FileName)
        End If
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As RoutedEventArgs)
        ReproductorMediaElement.Play()
    End Sub


    Private Sub PauseButton_Click(sender As Object, e As RoutedEventArgs)
        ReproductorMediaElement.Pause()
    End Sub

    Private Sub StopButton_Click(sender As Object, e As RoutedEventArgs)
        ReproductorMediaElement.Stop()
    End Sub

    Private Sub SilencioCheckBox_Checked(sender As Object, e As RoutedEventArgs)
        ReproductorMediaElement.IsMuted = SilencioCheckBox.IsChecked
    End Sub

End Class
