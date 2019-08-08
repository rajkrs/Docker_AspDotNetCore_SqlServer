# Docker_AspDotNetCore_SqlServer
Running asp.net core and sql server in docker container example.


Steps:
	1.	Go to working directory
	2.	run docker-compose build
	3.	run docker-compose up

You app should be running on port:52743
	Verify API on http://localhost:52743/api/values

Also try connect MS SQL Server on SSMS with
	Server name	:	localhost,1433
	Authentication	:	SQL Server uthentication
	Login		:	sa
	Password	:	Bassword@123



