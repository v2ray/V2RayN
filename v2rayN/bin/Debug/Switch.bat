@echo off

:head
set /p switch=����1������������0�رմ���:
if "%switch%" == "1" goto open
if "%switch%" == "0" goto close
goto head

:open
cd /d %~dp0
start v2ray.exe
echo ��������Project V...
ping 127.0.0.1 -n 4 > nul
netsh winhttp set proxy proxy-server="socks=localhost:1080" bypass-list="localhost"
echo ��ʼ���ϳ���......
goto end

:close
taskkill /f /im v2ray.exe
echo ���ڹر�Project V...
netsh winhttp reset proxy
echo ��ǿ����������������г�����ɡ�ƽ�ȡ����������Ρ���������ҵ�����š����ơ�
goto end

:end
pause