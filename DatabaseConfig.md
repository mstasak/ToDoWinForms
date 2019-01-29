To create the SQLExpress Local database:

- In Visual Studio, go to Server Explorer.  Right Click Data Connections.  Select 'Create new SQL Server Database...'.  Enter (localdb)\sqllocaldb for the server name, and DailyToDos for the new database name.  Click OK.
- note the connect string, from the properties of the newly created database connection:
    Data Source=(localdb)\mssqllocaldb;Initial Catalog=DailyToDos;Integrated Security=True;Pooling=False
