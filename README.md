# OracleCore3EF64Sample
##### Sample application to use ODP.NET, Managed Driver with Entity Framework 6.4 on .NET Core 3.x

OracleCore3EF64Sample sample aplication targeting **netcoreapp3.1** framework (SDK 3.1.200) and using this NuGet packages:

**EntityFramework version 6.4.0** (*netstandard2.1*) - Entity Framework 6.4 for .NET Core 3.x

**Oracle.ManagedDataAccess.Core version 2.19.60** - Official Oracle ODP.NET, Managed Driver for EF Core 2.x, certified for .NET Core 3.x.

**Oracle.ManagedDataAccess.EntityFramework.Core** (*netstandard2.1*) - My **NOT OFFICIAL** NuGet (for my private use).  
It's recompilation of offical **Oracle.ManagedDataAccess.EntityFramework version 19.6.0 (net45) NuGet** and *Oracle.ManagedDataAccess.EntityFramework.dll assembly* (v. 6.122.19.1) using *Oracle.ManagedDataAccess.Core NuGet* instead of *Oracle.ManagedDataAccess NuGet*.  
This NuGet is not included in this repo (due to license), but it is in my private repo.  

To compile this sample you must add *Oracle.ManagedDataAccess.EntityFramework.Core.19.6.0.nupkg* to **.\Packages** folder and edit connection string in *Program.cs* source file.
