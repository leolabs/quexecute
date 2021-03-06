; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "QuickLaunch"
#define MyAppVersion "1.5 Beta"
#define MyAppPublisher "Leo Bernard"
#define MyAppURL "http://ql.leolabs.org/"
#define MyAppExeName "QuickLaunch.exe"
#define BuildFolderPath "D:\Projekte\Visual Studio 2010\Projects\QuickLaunch1\builds\20120326 - 1.5 Beta"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{3800EC41-29EE-4B6C-AB1F-6AB18D29C158}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName}
AppPublisher={#MyAppPublisher}
AppPublisherURL="http://leolabs.org/"
AppSupportURL="{#MyAppURL}help"
AppUpdatesURL="{#MyAppURL}changelog"
DefaultDirName={pf}\{#MyAppName}
DisableDirPage=yes
DefaultGroupName={#MyAppName}
LicenseFile={#BuildFolderPath}\LICENSES\license.rtf
InfoBeforeFile={#BuildFolderPath}\LICENSES\before.rtf
DisableProgramGroupPage=yes
OutputDir={#BuildFolderPath}
OutputBaseFilename=setup
SetupIconFile="D:\Projekte\Visual Studio 2010\Projects\QuickLaunch1\images\Icons\QuickLaunch-Logo128.ico"
Compression=lzma
SolidCompression=yes
UninstallDisplayIcon={app}\QuickLaunch.exe


[Languages]
Name: "english"; MessagesFile: "{#BuildFolderPath}\LANGUAGES\English.isl"
Name: "german"; MessagesFile: "{#BuildFolderPath}\LANGUAGES\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1
Name: "registerprotocol"; Description: "{cm:RegisterProtocol}"; GroupDescription: "{cm:GroupTasks}";
Name: "setautostart"; Description: "{cm:Autostart}"; GroupDescription: "{cm:GroupTasks}";
Name: "restoreconfig"; Description: "{cm:RestoreConfig}"; GroupDescription: "{cm:GroupTasks}"; Flags: unchecked;

[Files]
Source: "{#BuildFolderPath}\APPFOLDER\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "{#BuildFolderPath}\APPDATA\*"; DestDir: "{userappdata}"; Flags: recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
Filename: "http://ql.leolabs.org/forum"; Description: "Visit Forum"; Flags: nowait postinstall skipifsilent shellexec unchecked  
Filename: "{app}\QLToolset.exe"; Parameters: "/registerProtocol /s"; Tasks: registerprotocol;
Filename: "{app}\QLToolset.exe"; Parameters: "/setAutostart /s"; Tasks: setautostart;
Filename: "{app}\QLToolset.exe"; Parameters: "/restoreConfig /s"; Tasks: restoreconfig;

[UninstallRun]
Filename: "Taskkill"; Parameters: "/IM QuickLaunch.exe /F";
Filename: "{app}\QLToolset.exe"; Parameters: "/unregisterProtocol /s";
Filename: "{app}\QLToolset.exe"; Parameters: "/deleteAutostart /s";


