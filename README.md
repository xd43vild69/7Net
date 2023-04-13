# 7Net
7Net new features - IA - Clean Architecture

***

[//]: <> (should update to DDD) 
Architecture

    Corp.DOMAIN
        BAL: Business logic layer.
        DTO: Data transfer objects.
    Corp.DATA
        DAL: Data acess layer.
        Migrations EF.
    Corp.API
        API: Web API.
    Corp.WEB:
        APP: Application client.
    Corp.TEST:
        UnitTest: Unit Test project.

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