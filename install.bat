@echo off
set installFfmpegScriptPath="%~dp0\install_scripts\install_ffmpeg.ps1"
echo Installing ffmpeg for QuickVideoTrim...
echo ------------------------------------------------------
type "%installFfmpegScriptPath%" | powershell.exe -c -
pause