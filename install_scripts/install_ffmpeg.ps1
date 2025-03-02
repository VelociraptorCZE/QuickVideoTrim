$isFfmpegInstalled = (Get-Command -Name ffmpeg.exe -ErrorAction SilentlyContinue).length -gt 0

if (!$isFfmpegInstalled) {
	$isChocoInstalled = (Get-Command -Name choco.exe -ErrorAction SilentlyContinue).length -gt 0

	if (!$isChocoInstalled) {
		echo "`n`n- Installing Chocolatey"
		Set-ExecutionPolicy AllSigned
		Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))
	}

	echo "- Installing ffmpeg`n`n"
	choco install ffmpeg	
}

echo "=============================================================="
echo "Everything is ready to go, you can use QuickVideoTrim app now."
echo "=============================================================="