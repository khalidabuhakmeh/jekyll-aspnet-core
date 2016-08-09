# Running Jekyll On ASP.NET Core

This repository shows how to setup Jekyll running in conjunction with ASP.NET Core. I hooked up the `Jekyll build` process to `dotnet run` along with `gulp` tooling.

## Why?

Static sites are fast and most sites can get away with generating most of their content in advance. That said, there are scenarios where you might need a few parts of your site to be dynamic or have executing middleware (authentication and authorization).

## Getting Started

Prerequisites :
- Ruby
- Node
- .NET Core

1. Clone the repository 
2. gem install bundler
3. dotnet run

I think that should work :)