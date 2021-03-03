# Net Core with EntityFramework Core Api Rest Demo

The next command are very important in this process, please use in case of problem with migrations.
This code run with Visual Studio Code.

## dotnet ef cli install globally
```dotnet tool install --global dotnet-ef```

## dotnet ef start migration
```dotnet ef migrations add InitialCreate```

## dotnet ef update migration
```dotnet ef database update```

## for the start of new proyect by cli
```dotnet new webapi -o <application_name>```

## EntityFramework Core Install
```dotnet add package Microsoft.EntityFramework --version 5.0.3```

## EntityFramework Core SQL Server Install
```dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.3```

## EntityFramework Core Tools (uses for migrations) Install
```dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.3```

## Linq Install
```dotnet add package System.Linq --version 4.3.0```