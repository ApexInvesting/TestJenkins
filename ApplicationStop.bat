REM add "&& call" to the end to catch exceptions
taskkill /f /im "TestJenkins.exe" || exit 0

