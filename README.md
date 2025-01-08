# IFIN

## Install nuget packages via Package Manager Console
 
- To restore all packages of all projects:
 ```
 Update-Package -Reinstall
 ```
- To install a particular package to a specific project:
 ```
 Install-Package Dapper -Version 2.1.35 -Project Presentation
 ```
