# Docker Asp.NetCore Sql Server
Running asp.net core and sql server in docker container example.


Steps:
1.	Go to working directory
2.	run docker-compose build
3.	run docker-compose up

You app should be running on port:52743, Verify API on http://localhost:52743/api/values

Also try connect MS SQL Server on SSMS with:
1.	Server name: localhost,1433
2.	Authentication: SQL Server uthentication
3.	Login: sa
4.	Password: Bassword@123

Refer basic docker commands : https://www.asptricks.net/2019/07/basic-docker-commands.html

