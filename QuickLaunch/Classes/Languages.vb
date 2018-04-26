Module Languages
    Public lngDict As New Dictionary(Of String, String)

    Public Sub InitLang(ByVal Language As String)
        lngDict.Clear()
        If Language.ToLower = "de" Then
            Try
                DE_Main()
                DE_Messages()
                DE_AvailableCommands()
                DE_Settings()
                DE_ExceptionHandling()
            Catch ex As Exception

            End Try
        ElseIf Language.ToLower = "en" Then
            Try
                EN_Main()
                EN_Messages()
                EN_AvailableCommands()
                EN_Settings()
                EN_ExceptionHandling()
            Catch ex As Exception

            End Try
        ElseIf Language.ToLower = "def" Then
            If System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName = "de" Then
                Try
                    DE_Main()
                    DE_Messages()
                    DE_AvailableCommands()
                    DE_Settings()
                    DE_ExceptionHandling()
                Catch ex As Exception

                End Try
            Else
                Try
                    EN_Main()
                    EN_Messages()
                    EN_AvailableCommands()
                    EN_Settings()
                    EN_ExceptionHandling()
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Public Function l(ByVal tag As String, ByVal ParamArray vars() As String)
        Try
            Return String.Format(lngDict(tag), vars)
        Catch ex As Exception
            Return tag & " is not yet Translated!"
        End Try
    End Function

#Region "Deutsch"
    Private Sub DE_Messages()
        lngDict.Add("msg_deffailtitle", "QuExeCute - Fehler!")

        lngDict.Add("msg_updatecomplete_title", "Update erfolgreich abgeschlossen!")
        lngDict.Add("msg_updatecomplete_text", "Das Update auf Version {0} (Build {1}) wurde erfolgreich abgeschlossen! Wenn Sie die Liste der Änderungen sehen wollen, gehen Sie auf http://qc.leolabs.org/changelog/.")

        lngDict.Add("msg_configerror_title", "Fehler beim Laden der Konfigurationsdatei!")
        lngDict.Add("msg_configerror_text", "Die Konfigurationsdatei konnte nicht geladen werden! Sehr wahrscheinlich gibt es einen Fehler in der XML-Struktur. Bitte versuchen Sie, den Fehler zu verbessern oder laden Sie sich eine korrekte Konfigurationsdatei unter http://qc.leolabs.org/res/config.xml herunter. QuExeCute wird sich nun beenden.")

        lngDict.Add("msg_configloadfail", "Beim Laden der Konfigurationsdatei ist ein schwerwiegender Fehler aufgetreten (siehe Log). QuExeCute wird sich nun beenden.")
        lngDict.Add("msg_nopathdefined", "Zum ausgewählten Shortcut wurde kein Ausführungspfad festgelegt! Bitte legen Sie den Pfad in den Einstellungen fest.")
        lngDict.Add("msg_createconfigfail", "Die Konfigurationsdateien konnten nicht erstellt werden! Dies könnte daran liegen, dass sie zZt. nicht mit dem Internet verbunden sind, die benötigten Rechte auf den Ordner %APPDATA% nicht haben oder ein Problem mit unseren Servern vorliegt.")

        lngDict.Add("msg_error_title", "Es ist ein schwerwiegender Fehler aufgetreten!")
        lngDict.Add("msg_error_text", "Während der Ausführung des letzten Befehls ist ein schwerwiegender Fehler aufgetreten." & vbCrLf & "Fehlermeldung: {0}" & vbCrLf & vbCrLf & "Details: " & vbCrLf & "{1}" & vbCrLf & vbCrLf & "Bitte kopieren Sie den Fehler aus der Logdatei in das QuExeCute Forum (http://qc.leolabs.org/forum/)" & vbCrLf & "QuExeCute wird sich in 5 Sekunden schließen")

        lngDict.Add("msg_icondownloadfailed", "Der Download des Icons ist fehlgeschlagen. Wollen Sie trotzdem fortfahren?")

        lngDict.Add("msg_noping", "Unsere Server sind momentan nicht erreichbar. Dies kann daran liegen, dass Sie im Moment kein Internet haben oder unsere Server gerade offline sind.")

        lngDict.Add("msg_duplicateCommand", "Der Shortcut {0} ist bereits mit ""{1}"" verbunden! Bitte wählen Sie einen anderen Shortcut oder löschen Sie ""{1}"".")

        lngDict.Add("msg_nospaces", "Der Shortcut darf keine Leerzeichen enthalten!")

        lngDict.Add("msg_needsrestart", "Um die neu gewählte Sprache anzuwenden muss QuExeCute neu gestartet werden.")

        lngDict.Add("msg_path_failed_title", "Der festgelegte Pfad konnte nicht gefunden werden!")
        lngDict.Add("msg_path_failed_text", "Bitte überprüfen Sie die Verfügbarkeit und Richtigkeit des Pfades in den Einstellungen")

        lngDict.Add("msg_addwebsc_title", "QuExeCute - Shortcut hinzufügen?")
        lngDict.Add("msg_addwebsc_text", "Eine Website oder ein Programm möchte den Shortcut ""{0}"" zu QuExeCute hinzufügen. Sie können die einzelnen Angaben im nächsten Schritt verändern. Wollen Sie dies zulassen?")

        lngDict.Add("msg_addwebscfail_title", "Hinzufügen des Shortcuts per URL fehlgeschlagen!")
        lngDict.Add("msg_addwebscfail_text", "Ein Programm oder eine Website hat versucht, einen Shortcut zu Ihren Shortcuts hinzuzufügen, hat aber eine ungültige URL angegeben. Bitte informieren Sie den Ersteller dieser URL über den Fehler.")

        lngDict.Add("msg_scexists_title", "Shortcut {0} besteht bereits!")
        lngDict.Add("msg_scexists_text", "Der Shortcut {0} ist bereits mit ""{1}"" verbunden und wird deshalb nicht hinzugefügt. Bitte geben Sie dem Befehl in den Einstellungen einen anderen Shortcut.")

        lngDict.Add("bubble_notfound_title", "Pfad/Befehl wurde nicht gefunden!")
        lngDict.Add("bubble_notfound_text", "Der Pfad oder Befehl ""{0}"" konnte nicht gefunden/geöffnet werden.")
    End Sub

    Private Sub DE_ExceptionHandling()
        lngDict.Add("exUserWindowDescription", "Es ist ein Fehler in QuExeCute aufgetreten. Bitte beschreiben Sie die Schritte, die zu dem Fehler geführt haben könnten, damit wir den ihn so schnell wie möglich beheben können.")
        lngDict.Add("exUserWindowGroupName", "Beschreibung des Fehlers")
        lngDict.Add("exUserWindowOK", "&OK")
        lngDict.Add("exUserWindowSkip", "Ü&berspringen")
    End Sub

    Private Sub DE_Main()
        lngDict.Add("title_openpath", "Pfad öffnen")
        lngDict.Add("title_openfile", "Datei öffnen")
        lngDict.Add("title_openadress", "Website öffnen")

        lngDict.Add("cancel", "Abbrechen")
        lngDict.Add("help", "Hilfe")
        lngDict.Add("search", "Suchen")
        lngDict.Add("startmenu", "Programm starten")
        lngDict.Add("loading", "Lädt...")

        lngDict.Add("manage_shortcuts", "Shortcuts verwalten")

        lngDict.Add("u_serverfail", "Beim Suchen nach Updates ist ein Serverseitiger Fehler aufgetreten!")
        lngDict.Add("u_newversion_title", "Es ist eine neue Version von QuExeCute verfügbar!")
        lngDict.Add("u_newversion_text", "Version {0} ist jetzt verfügbar, du benutzt Version {1}.")
        lngDict.Add("u_newestversion", "Sie benutzen die neuste Version von QuExeCute!")
        lngDict.Add("u_downstat", "{0} wird heruntergeladen - Heruntergeladen: {1} von {2} MB ({3} %)")
        lngDict.Add("u_wronghash", "Der Hash des Updates stimmt nicht mit dem vorgegebenen Hash überein! Dies kann bedeuten, dass das Update mit Schadsoftware verseucht oder die Datei beschädigt ist. Möchten Sie trotzdem fortfahren?")
        lngDict.Add("u_skipversion", "Version überspringen")
        lngDict.Add("u_remindlater", "Später erinnern")
        lngDict.Add("u_install", "Installieren")

        lngDict.Add("m_opencmdwindow", "Eingabefenster öffnen")
        lngDict.Add("m_available_commands", "Verfügbare Befehle")
        lngDict.Add("m_onlinehelp", "Online-Hilfe")
        lngDict.Add("m_checkupdates", "Auf Updates prüfen")
        lngDict.Add("m_settings", "Einstellungen")
        lngDict.Add("m_quit", "Beenden")
    End Sub

    Private Sub DE_AvailableCommands()
        lngDict.Add("lbl_intro", "Hier sehen Sie eine Liste mit den verfügbaren Befehlen bzw. Verknüpfungen. Wenn Sie die Befehle ändern wollen, können Sie das in den Einstellungen tun.")
        lngDict.Add("cll_name", "Name")
        lngDict.Add("cll_shortcut", "Shortcut")
        lngDict.Add("cll_path", "Pfad")
        lngDict.Add("ac_title", "Verfügbare Befehle")
    End Sub

    Private Sub DE_Settings()
        lngDict.Add("settings_title", "QuExeCute Einstellungen")

        lngDict.Add("ctlOpenConfig", "Erweitert: config.xml öffnen")
        lngDict.Add("tabGeneral", "Allgemein")
        lngDict.Add("tabCommands", "Shortcuts")
        lngDict.Add("tabAbout", "Info/Credits")
        lngDict.Add("tabCommandwindow", "Eingabefenster")
        lngDict.Add("tabTools", "Tools")

        lngDict.Add("sethotkey_title", "Hotkey festlegen")
        lngDict.Add("sethotkey_intro", "Bitte drücken Sie die gewünschte Tastenkombination.")

        lngDict.Add("lblTransparency", "Transparenz des Eingabefensters:")
        lngDict.Add("lblPosition", "Position des Eingabefensters:")
        lngDict.Add("lblWidth", "Breite des Eingabefensters:")
        lngDict.Add("lblACM", "Autovervollständigungs-Modus:")
        lngDict.Add("lblLanguage", "Sprache:")
        lngDict.Add("lblHotkey", "Hotkey zum Öffnen des Eingabefensters:")
        lngDict.Add("lblAutostart", "Autostart: ")
        lngDict.Add("lblOpenLinks", "QuExeCute-Links akzeptieren:")
        lngDict.Add("lblOpenSimpleURLs", "Einfache URLs im Browser öffnen:")
        lngDict.Add("cbOpenSimpleURLs", "Öffne einfache URLs im Browser")
        lngDict.Add("lblStdShortcut", "Standard-Shortcut:")
        lngDict.Add("cbStdShortcutNone", "Keiner")
        lngDict.Add("lblCloseCMDWin", "Eingabefenster schließen, wenn es den Fokus verliert:")
        lngDict.Add("lblPopulateStartMenu", "Programme aus dem Startmenü automatisch hinzufügen:")
        lngDict.Add("ctlOpenLinks", "Auf QuExeCute-Links reagieren")
        lngDict.Add("ctlAutostart", "QuExeCute mit Windows starten")

        lngDict.Add("ctlPositionTop", "Oberer Bildschirmrand")
        lngDict.Add("ctlPositionCenter", "Mitte des Bildschirms")

        lngDict.Add("addSC", "Hinzufügen")
        lngDict.Add("editSC", "Bearbeiten")
        lngDict.Add("deleteSC", "Entfernen")
        lngDict.Add("getnewSC", "Shortcut Galerie")

        lngDict.Add("ctlACMNone", "Nicht anzeigen")
        lngDict.Add("ctlACMSuggest", "Als Dropdown-Menü vorschlagen")
        lngDict.Add("ctlACMAppend", "Direkt im Textfeld anzeigen")
        lngDict.Add("ctlACMSuggestAppend", "Als Dropdown und im Textfeld anzeigen")

        lngDict.Add("ctlHotkey", "{0} - Ändern")

        lngDict.Add("addsc_title", "Shortcut zu QuExeCute hinzufügen")
        lngDict.Add("addsc_scname", "Name des Shortcuts:")
        lngDict.Add("addsc_command", "Shortcut(z.B. ""yt""):")
        lngDict.Add("addsc_execpath", "Ausgeführter Pfad:")
        lngDict.Add("addsc_iconpath", "Pfad zum Icon:")

        lngDict.Add("toolsIntro", "Über diese Seite kann das Programm QCToolset, welches mit QuExeCute geliefert wird und sich um systemeingreifende Aufgaben kümmert, gesteuert werden. Bitte benutzen Sie dieses Tool mit Vorsicht und lesen Sie sich vorher die Hilfe durch!")
        lngDict.Add("gbAutostart", "Autostart (wenn möglich, unter ""Allgemein"" ändern)")
        lngDict.Add("gbProtocol", "QuExeCute-Protokoll")
        lngDict.Add("gbConfig", "Konfigurationsdatei")
        lngDict.Add("toolsAddAutostart", "In den Autostart eintragen")
        lngDict.Add("toolsDeleteAutostart", "Aus dem Autostart entfernen")
        lngDict.Add("toolsRegisterProtocol", "QuExeCute-Protokoll registrieren")
        lngDict.Add("toolsUnregisterProtocol", "QuExeCute-Protokoll entfernen")
        lngDict.Add("toolsRestoreConfig", "Konfigurationsdatei wiederherstellen")

        lngDict.Add("credits", "Als Erstes: Vielen Dank an die Beta-Tester, die mir bei der Verbesserung und dem Debuggen von QuExeCute sehr geholfen haben!" & vbCrLf & vbCrLf & "QuExeCute wurde von Leo Bernard (leolabs) entwickelt" & vbCrLf & vbCrLf & "Alle Icons außer den zwei Logos auf dieser Seite sind von Mebaze entworfen worden" & vbCrLf & vbCrLf & "Die Shortcut-Icons wurden größtenteils von Paul Robert Lloyd erstellt." & vbCrLf & vbCrLf & "Wenn Sie einen Bug gefunden haben oder mit einer Idee zur Weiterentwicklung des Programms beitragen wollen, können Sie das im QuExeCute-Forum tun." & vbCrLf & vbCrLf & "Hilfe ist auf der QuExeCute-Website verfügbar" & vbCrLf & vbCrLf & "Beta tester:" & vbCrLf & "Marcus Weiner" & vbCrLf & "Jonas Seidel" & vbCrLf & "Andrew Smart" & vbCrLf & "Philip Kirschner")
    End Sub
#End Region

#Region "English"
    Private Sub EN_Messages()
        lngDict.Add("msg_deffailtitle", "QuExeCute - Error!")

        lngDict.Add("msg_updatecomplete_title", "Update successfully completed!")
        lngDict.Add("msg_updatecomplete_text", "The Update to Version {0} (Build {1}) has been successfully completed! If you want to see the Changelog, go to http://qc.leolabs.org/changelog/.")

        lngDict.Add("msg_configerror_title", "Error while loading the Configuration file!")
        lngDict.Add("msg_configerror_text", "The Configuration file couldn't be loaded! Probably, there is an error in the XML Structure. Please try correcting the error or download a correct Configuration file at http://qc.leolabs.org/get/config.xml. QuExeCute will quit now.")

        lngDict.Add("msg_configloadfail", "A heavy error occured while loading the Configuration file (see Log-File). QuExeCute will quit now.")
        lngDict.Add("msg_nopathdefined", "No Executed Path was defined for the chosen Shortcut! Please define that Path in the Settings.")
        lngDict.Add("msg_createconfigfail", "The Config Files couldn't be created! This could be because you aren't connected to the Internet, you don't have the needed rights for the %APPDATA% folder or there's a problem with our servers.")

        lngDict.Add("msg_error_title", "A heavy error occured!")
        lngDict.Add("msg_error_text", "While trying to execute the last command, a heavy error occured." & vbCrLf & "Exception: {0}" & vbCrLf & vbCrLf & "Details: " & vbCrLf & "{1}" & vbCrLf & vbCrLf & "Please copy the error from the Log File and Post it in our Forum (http://qc.leolabs.org/forum/)" & vbCrLf & "QuExeCute will quit in 5 Seconds.")

        lngDict.Add("msg_icondownloadfailed", "The Icon couldn't be downloaded. Do you want to continue?")

        lngDict.Add("msg_noping", "Our Servers can't be reached. Maybe you don't have an Internet Connection at the Moment or our Servers are offline.")

        lngDict.Add("msg_duplicateCommand", "The Shortcut {0} is already connected to ""{1}""! Please choose another Shortcut or delete ""{1}"".")

        lngDict.Add("msg_nospaces", "Spaces are not allowed in the Shortcut!")

        lngDict.Add("msg_needsrestart", "QuExeCute has to be restarted to use the new language.")

        lngDict.Add("msg_path_failed_title", "The defined Path couldn't be found!")
        lngDict.Add("msg_path_failed_text", "Please check if the Path is correct and available in the Settings")

        lngDict.Add("msg_addwebsc_title", "QuExeCute - Add Shortcut?")
        lngDict.Add("msg_addwebsc_text", "A Website or an Aplication wants to add the Shortcut ""{0}"" to QuExeCute. You can change the parameters in the next step. Do you want to accept this?")

        lngDict.Add("msg_addwebscfail_title", "Adding a Shortcut per URL failed!")
        lngDict.Add("msg_addwebscfail_text", "An application or a website tried to add a Shortcut to QuExeCute, but used an invalid URL. Please inform the creator of this URL about that error.")

        lngDict.Add("msg_scexists_title", "Shortcut {0} already exists!")
        lngDict.Add("msg_scexists_text", "The Shortcut {0} ist already connected to ""{1}"" and won't be added. Please change the Shortcut of that Command in the Settings.")

        lngDict.Add("bubble_notfound_title", "Path/Command not found!")
        lngDict.Add("bubble_notfound_text", "The Path or the Command ""{0}"" couldn't be found or opened.")
    End Sub

    Private Sub EN_ExceptionHandling()
        lngDict.Add("exUserWindowDescription", "A fatal error occured in QuExeCute. Please describe the steps that yould have lead to this error, so we can fix it as soon as possible.")
        lngDict.Add("exUserWindowGroupName", "Error description")
        lngDict.Add("exUserWindowOK", "&OK")
        lngDict.Add("exUserWindowSkip", "S&kip")
    End Sub

    Private Sub EN_Main()
        lngDict.Add("title_openpath", "Open Path")
        lngDict.Add("title_openfile", "Open File")
        lngDict.Add("title_openadress", "Open Website")

        lngDict.Add("cancel", "Cancel")
        lngDict.Add("help", "Help")
        lngDict.Add("search", "Search")
        lngDict.Add("startmenu", "Start application")
        lngDict.Add("loading", "Loading...")

        lngDict.Add("manage_shortcuts", "Manage Shortcuts")

        lngDict.Add("u_serverfail", "A server-side error occured while searching for updates!")
        lngDict.Add("u_newversion_title", "A new version of QuExeCute is available!")
        lngDict.Add("u_newversion_text", "Version {0} is now available, you are using Version {1}.")
        lngDict.Add("u_newestversion", "You're using the newest Version of QuExeCute!")
        lngDict.Add("u_downstat", "Downloading {0} - Downloaded {1} of {2} MB ({3} %)")
        lngDict.Add("u_wronghash", "The Hash of the Update doesn't match with the defined Hash! This could mean that the update is damaged or contains malware. Do you want to continue?")
        lngDict.Add("u_skipversion", "Skip this Version")
        lngDict.Add("u_remindlater", "Remind later")
        lngDict.Add("u_install", "Install")

        lngDict.Add("m_opencmdwindow", "Open Command Window")
        lngDict.Add("m_available_commands", "Available Commands")
        lngDict.Add("m_onlinehelp", "Online Help")
        lngDict.Add("m_checkupdates", "Check for Updates")
        lngDict.Add("m_settings", "Settings")
        lngDict.Add("m_quit", "Quit")
    End Sub

    Private Sub EN_AvailableCommands()
        lngDict.Add("lbl_intro", "Here you see a list of the available Commands/Shortcuts. If you want to change the Commands, you can do so in the Settings.")
        lngDict.Add("cll_name", "Name")
        lngDict.Add("cll_shortcut", "Shortcut")
        lngDict.Add("cll_path", "Path")
        lngDict.Add("ac_title", "Available Commands")
    End Sub

    Private Sub EN_Settings()
        lngDict.Add("settings_title", "QuExeCute Settings")

        lngDict.Add("ctlOpenConfig", "Advances: Open config.xml")
        lngDict.Add("tabGeneral", "General")
        lngDict.Add("tabCommands", "Shortcuts")
        lngDict.Add("tabAbout", "Info/Credits")
        lngDict.Add("tabCommandwindow", "Command Window")
        lngDict.Add("tabTools", "Tools")

        lngDict.Add("sethotkey_title", "Define Hotkey")
        lngDict.Add("sethotkey_intro", "Please press the desired Key Combination.")

        lngDict.Add("lblTransparency", "Opacity of the Command Window:")
        lngDict.Add("lblPosition", "Position of the Command Window:")
        lngDict.Add("lblWidth", "Width of the Command Window:")
        lngDict.Add("lblACM", "Autocomplete-Mode:")
        lngDict.Add("lblLanguage", "Language:")
        lngDict.Add("lblHotkey", "Hotkey to open the Command Window:")
        lngDict.Add("lblAutostart", "Autostart: ")
        lngDict.Add("lblOpenLinks", "Accept QuExeCute-Links:")
        lngDict.Add("lblOpenSimpleURLs", "Open simple URLs in the browser:")
        lngDict.Add("cbOpenSimpleURLs", "Open simple URLs in the browser")
        lngDict.Add("lblStdShortcut", "Default shortcut:")
        lngDict.Add("cbStdShortcutNone", "None")
        lngDict.Add("lblCloseCMDWin", "Close Command Window when it loses the Focus:")
        lngDict.Add("lblPopulateStartMenu", "Add Apps from the Start Menu automatically:")
        lngDict.Add("ctlOpenLinks", "React to QuExeCute-Links")
        lngDict.Add("ctlAutostart", "Start QuExeCute with Windows")

        lngDict.Add("ctlPositionTop", "Upper Edge of the Screen")
        lngDict.Add("ctlPositionCenter", "Center")

        lngDict.Add("addSC", "Add")
        lngDict.Add("editSC", "Edit")
        lngDict.Add("deleteSC", "Delete")
        lngDict.Add("getnewSC", "Shortcut Gallery")

        lngDict.Add("ctlACMNone", "Don't show")
        lngDict.Add("ctlACMSuggest", "Show as Dropdown-Menu")
        lngDict.Add("ctlACMAppend", "Append in Textfield")
        lngDict.Add("ctlACMSuggestAppend", "Show as Dropdown and append in Textfield")

        lngDict.Add("ctlHotkey", "{0} - Change")

        lngDict.Add("addsc_title", "Add Shortcut to QuExeCute")
        lngDict.Add("addsc_scname", "Shortcut Name:")
        lngDict.Add("addsc_command", "Shortcut(e.g. ""yt""):")
        lngDict.Add("addsc_execpath", "Executed Path:")
        lngDict.Add("addsc_iconpath", "Icon Path:")

        lngDict.Add("toolsIntro", "In this Tab, you can control QCToolset, an application that is delivered with QuExeCute and handles tasks in the system. Please use it with care and read the help before!")
        lngDict.Add("gbAutostart", "Autostart (change under ""General"", if possible)")
        lngDict.Add("gbProtocol", "QuExeCute-Protocol")
        lngDict.Add("gbConfig", "Configuration File")
        lngDict.Add("toolsAddAutostart", "Add to Autostart")
        lngDict.Add("toolsDeleteAutostart", "Remove from Autostart")
        lngDict.Add("toolsRegisterProtocol", "Register QuExeCute-Protocol")
        lngDict.Add("toolsUnregisterProtocol", "Remove QuExeCute-Protocol")
        lngDict.Add("toolsRestoreConfig", "Restore Configuration File")

        lngDict.Add("credits", "At first: Many thanks to the Beta testers who really helped me improving and debugging QuExeCute!" & vbCrLf & vbCrLf & "QuExeCute is developed by Leo Bernard (leolabs)" & vbCrLf & vbCrLf & "All the Icons used in this Application except for the logos on this page were created by Mebaze" & vbCrLf & vbCrLf & "Most of the Shortcut-Icons were created by Paul Robert Lloyd." & vbCrLf & vbCrLf & "If you've found a bug or you want to contribute to the development by adding your own Ideas, you can do so in the Forums." & vbCrLf & vbCrLf & "Help is available on the QuExeCute Website" & vbCrLf & vbCrLf & "Beta testers:" & vbCrLf & "Marcus Weiner" & vbCrLf & "Jonas Seidel" & vbCrLf & "Andrew Smart" & vbCrLf & "Philip Kirschner")
    End Sub
#End Region

End Module
