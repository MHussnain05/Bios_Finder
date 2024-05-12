[Setup]
; Basic settings
AppName=BIOS Finder
AppVersion=1.0
DefaultDirName={pf}\BIOSFinder
DefaultGroupName=BIOS Finder
OutputBaseFilename=BIOSFinderInstaller
WizardStyle=modern

; Files to install
[Files]
Source: "BIOSFinder.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "manifest.json"; DestDir: "{app}"; Flags: ignoreversion

; Create a desktop shortcut with the specified icon
[Icons]
Name: "{commondesktop}\BIOS Finder"; Filename: "{app}\BIOSFinder.exe"; IconFilename: "{app}\BIOSFinder.ico"


