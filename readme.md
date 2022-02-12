This project is use to change your DB anytime within some configuration changes like connectionstring

I have created project who does following things:
1.  Create database automatically
2.  Create tables 
3.  Save data and get data from database
4.  Alter column data type - for this you have to change datatype of your POCO model and fire command
5.  Migration files are required to maintain all DB related changes and you can restore your database anytime with master data.

Commands required to keep track of all DB changes:

dotnet ef migrations add migrationname

dotnet ef database update


