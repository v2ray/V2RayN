@echo off

:head
set /p switch=输入1开启代理，输入0关闭代理:
if "%switch%" == "1" goto open
if "%switch%" == "0" goto close
goto head

:open
cd /d %~dp0
start v2ray.exe
echo 正在启动Project V...
ping 127.0.0.1 -n 4 > nul
netsh winhttp set proxy proxy-server="socks=localhost:1080" bypass-list="localhost"
echo 开始网上冲浪......
goto end

:close
taskkill /f /im v2ray.exe
echo 正在关闭Project V...
netsh winhttp reset proxy
echo 富强、民主、文明、和谐、自由、平等、公正、法治、爱国、敬业、诚信、友善。
goto end

:end
pause