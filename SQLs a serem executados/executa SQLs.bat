for %%G in (*.sql) do sqlcmd /S YGORNOTE\SQLEXPRESS /d DBCaronas -E -i"%%G"
pause