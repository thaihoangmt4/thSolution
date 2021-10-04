:: https://efg.loresoft.com/en/latest/configuration/
:: dotnet tool install --global EntityFrameworkCore.Generator

cd /d %~dp0

efg generate

pause