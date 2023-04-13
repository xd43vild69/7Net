# 7Net
7Net new features - IA - Clean Architecture - TDD

***

[//]: <> (should update to DDD) 
Architecture:
https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures

***
    
    Domain Services 
        :7NetCore (7Net legacy)
    Infrastructure
        :7NetInfrastructure
    User Interface
        :7NetMaui
    Test
        :7netTest

***
    TDD:
https://en.wikipedia.org/wiki/Test-driven_development
***

## Commands

create: `dotnet new classlib -o StringLibrary`

create: `dotnet new console -o Net6Migrations`

add lib ref

`dotnet add reference lib1/targetPro.csproj`

`dotnet add reference Net6Data.csproj ../Net6DTO/Net6DTO.csproj`

<ItemGroup>
  <ProjectReference Include="originPro.csproj" />
  <ProjectReference Include="..\lib2\lib2.csproj" />
  <ProjectReference Include="..\lib1\lib1.csproj" />
</ItemGroup>

`dotnet run --urls "http://localhost:5100"`


add lib to sln

`dotnet sln add StringLibrary/StringLibrary.csproj`


run project 

`dotnet run --project ShowCase/ShowCase.csproj`

Nuget
`dotnet add package Newtonsoft.Json`

`dotnet tool install --global dotnet-ef`

`dotnet add package Microsoft.EntityFrameworkCore`

`dotnet add package Microsoft.EntityFrameworkCore.Design`