<#

.DESCRIPTION
script to load vs10 variables
allows to use tools such as msbuild

.NOTES

File Name: load_vs10.ps1
Author: Angello Astorga
Requires: PowerShell V5

#>

#Set environment variables for Visual Studio Command Prompt
pushd 'c:\Program Files (x86)\Microsoft Visual Studio 10.0\VC'
cmd /c "vcvarsall.bat&set" |
foreach {
  if ($_ -match "=") {
    $v = $_.split("="); set-item -force -path "ENV:\$($v[0])"  -value "$($v[1])"
  }
}
popd
write-host "`nVisual Studio 2010 Command Prompt variables set." -ForegroundColor Yellow