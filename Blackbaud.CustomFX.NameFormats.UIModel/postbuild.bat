echo copy the html and js files to the deploy folder on the webserver...
xcopy "%~dp0htmlforms\*.*" "C:\bbcopy\bbappfx\vroot\browser\htmlforms\" /e /y /r

rem echo minify the html and js files to optimize their payload on the wire...
rem %~dp0..\..\..\..\Utils\Blackbaud.AppFx.JSMinifier\bin\JSMinifier.exe %~dp0..\..\..\..\Blackbaud.AppFx.Server\Deploy\browser\htmlforms\<subfolder>\*.html /pre
rem %~dp0..\..\..\..\Utils\Blackbaud.AppFx.JSMinifier\bin\JSMinifier.exe %~dp0..\..\..\..\Blackbaud.AppFx.Server\Deploy\browser\htmlforms\<subfolder>\*.js