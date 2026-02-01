@echo on
setlocal

set CONFIG=Release
set BASE_OUTPUT=%~dp0publish_output

dotnet publish -c %CONFIG% -r win-x64   --self-contained false -o "%BASE_OUTPUT%\win-x64"   || goto :error
dotnet publish -c %CONFIG% -r linux-x64 --self-contained false -o "%BASE_OUTPUT%\linux-x64" || goto :error
dotnet publish -c %CONFIG% -r osx-x64   --self-contained false -o "%BASE_OUTPUT%\osx-x64"   || goto :error
dotnet publish -c %CONFIG% -r osx-arm64 --self-contained false -o "%BASE_OUTPUT%\osx-arm64" || goto :error

echo.
echo Publish succeeded.
echo Opening output folder:
echo %BASE_OUTPUT%
explorer "%BASE_OUTPUT%"
pause
exit /b 0

:error
echo.
echo Publish failed.
pause
exit /b 1
