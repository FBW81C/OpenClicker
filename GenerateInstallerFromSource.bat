@echo off
setlocal enabledelayedexpansion

:: ===== CONFIGURATION =====
set PROJECT_DIR=%~dp0
set ISS_FILE=%PROJECT_DIR%assets\OpenClicker.iss
set INSTALLER_OUTPUT_DIR=%PROJECT_DIR%Installers
set INNO_SETUP_PATH="C:\Program Files (x86)\Inno Setup 6\ISCC.exe"

:: ===== GET CURRENT VERSION =====
for /f "tokens=3 delims== " %%A in ('findstr /B /C:"#define MyAppVersion" "%ISS_FILE%"') do set VERSION=%%A
:: for /f "tokens=2 delims=\"" %%A in ('findstr /B /C:"#define MyAppVersion" "%ISS_FILE%"') do set "VERSION=%%A"
set VERSION=%VERSION:"=%

echo Current version: %VERSION%
set /p NEW_VERSION=Enter new version (leave blank to keep current): 

if not "%NEW_VERSION%"=="" (
    set VERSION=%NEW_VERSION%
    echo Updating version in .iss file to %NEW_VERSION%...
    powershell -Command "(Get-Content '%ISS_FILE%') -replace '#define MyAppVersion \".*\"', '#define MyAppVersion \"%NEW_VERSION%\"' | Set-Content '%ISS_FILE%'"
)

:: ===== BUILD .NET APP =====
echo.
echo Building OpenClicker v%VERSION%...
dotnet publish "%PROJECT_DIR%OpenClicker" -c Release -r win-x64 --self-contained false -p:PublishSingleFile=true
if errorlevel 1 (
    echo ERROR: dotnet publish failed.
    pause
    exit /b 1
)

:: ===== CREATE OUTPUT DIR =====
if not exist "%INSTALLER_OUTPUT_DIR%" mkdir "%INSTALLER_OUTPUT_DIR%"

:: ===== COMPILE INSTALLER =====
echo.
echo Compiling installer...
%INNO_SETUP_PATH% "%ISS_FILE%"
if errorlevel 1 (
    echo ERROR: Inno Setup compilation failed.
    pause
    exit /b 1
)

:: ===== MOVE INSTALLER TO Installers FOLDER =====
if exist "%PROJECT_DIR%assets\Output\OpenClickerInstaller.exe" (
    move /Y "%PROJECT_DIR%assets\Output\OpenClickerInstaller.exe" "%INSTALLER_OUTPUT_DIR%\OpenClickerInstaller_v%VERSION%.exe"
	echo.
    echo Installer saved to: %INSTALLER_OUTPUT_DIR%\OpenClickerInstaller_v%VERSION%.exe
) else (
    echo ERROR: Could not find generated installer file.
)

:: ===== CLEANING UP =====
echo.
echo Cleaning up...
rd /s /q "%PROJECT_DIR%assets\Output"

:: ===== DONE =====
echo.
echo Done!
pause