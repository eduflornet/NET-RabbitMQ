## Entity Framework Core Migration
    Startup MicroRabbit.Banking.Api as default and execute with package manager console the next instruction:
`Add-Migration "Initial Migration" -Context BankingDbContext`

	After that, update database:
`Update-Database -Context BankingDbContext`

	The result should be:
```
Build started...
Build succeeded.
Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 6.0.15 initialized 'BankingDbContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer:6.0.15' with options: None
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (17ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (66ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      
      IF EXISTS
          (SELECT *
           FROM [sys].[objects] o
           WHERE [o].[type] = 'U'
           AND [o].[is_ms_shipped] = 0
           AND NOT EXISTS (SELECT *
               FROM [sys].[extended_properties] AS [ep]
               WHERE [ep].[major_id] = [o].[object_id]
                   AND [ep].[minor_id] = 0
                   AND [ep].[class] = 1
                   AND [ep].[name] = N'microsoft_database_tools_support'
          )
      )
      SELECT 1 ELSE SELECT 0
Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (21ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      CREATE TABLE [Accounts] (
          [Id] int NOT NULL IDENTITY,
          [Type] nvarchar(max) NOT NULL,
          [Balance] decimal(18,2) NOT NULL,
          CONSTRAINT [PK_Accounts] PRIMARY KEY ([Id])
      );
To undo this action, use Remove-Migration.
```

## Insert data into Accounts table

```
USE [BankingDb]
GO

INSERT INTO [dbo].[Accounts] VALUES ('Checking', 1822.23)
INSERT INTO [dbo].[Accounts] VALUES ('Savings', 13987.56);

GO
```

## Banking Microservice Swagger Endpoint


<img src="https://images2.imgbox.com/26/d6/XAONtJcO_o.jpg?download=true" width="70%" height="70%">