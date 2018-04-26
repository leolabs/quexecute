Namespace My

    ' Für MyApplication sind folgende Ereignisse verfügbar:
    ' 
    ' Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
    ' Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst. Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung nicht normal beendet wird.
    ' UnhandledException: Wird ausgelöst, wenn in der Anwendung eine unbehandelte Ausnahme auftritt.
    ' StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn diese bereits aktiv ist. 
    ' NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
    Partial Friend Class MyApplication
        Private Sub MyApplication_StartupNextInstance(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            e.BringToForeground = True

            MainWindow.Visible = True
            MainWindow.Activate()
            AppActivate(System.Diagnostics.Process.GetCurrentProcess().Id)
            MainWindow.Focus()

            Try
                If e.CommandLine(0) = "/msg" Then
                    If e.CommandLine(1) = MainWindow.appguid Then
                        MainWindow.ShowMsg(e.CommandLine(2), e.CommandLine(3), e.CommandLine(4), False, 10000)
                    End If
                Else
                    MainWindow.AddExternalShortcut(e.CommandLine(0))
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            ExceptionTracker.TrackException(e.Exception, True)

            e.ExitApplication = False

            MainWindow.DoRestart()
        End Sub
    End Class
End Namespace

