# Clean Architecture with ASP.NET Core 3.1 WebApi

An Implementation of Clean Architecture with ASP.NET Core 3.1 WebApi. With this Open-Source BoilerPlate Template, you will get access to the world of Loosely-Coupled and Inverted-Dependency Architecture in ASP.NET Core 3.1 WebApi with a lot of best practices.

### v1 Preview.
Follow these steps to get started with this Boiler Plate Template.
1. Clone this Repository and Extract it to a Folder.
3. Change the Connection Strings for the Application and Identity in the WebApi/appsettings.json - (WebApi Project)
2. Run the following commands on Powershell in the WebApi Projecct's Directory.
- dotnet restore
- dotnet ef database update -Context ApplicationDbContext
- dotnet ef database update -Context IdentityContext
- dotnet run (OR) Run the Solution using Visual Studio 2019

Check out my [blog](https://www.codewithmukesh.com) or say [Hi on Twitter!](https://twitter.com/codewithmukesh)

## Purpose of this Project

Does it really make sense to Setup your ASP.NET Core Solution everytime you start a new WebApi Project ? Aren't we wasting quite a lot of time in doing this over and over gain?

This is the exact Problem that I intend to solve with this Full-Fledged ASP.NET Core 3.1 WebApi Solution Template, that also follows various principles of Clean Architecture.

The primary goal is to create a Full-Fledged implementation, that is well documented along with the steps taken to build this Solution from Scratch. This Solution Template will also be available within Visual Studio 2019 (by installing the required Nuget Package / Extension).
- Demonstrate Clean Monolith Architecture in ASP.NET Core 3.1 
- This is not a Proof of Concept
- Implementation that is ready for Production
- Integrate the most essential libraries and packages

## Give a Star ⭐️
If you found this Implementation helpful or used it in your Projects, do give it a star. Thanks!
Or, If you are feeling really generous, [Support the Project with a small contribution!](https://www.buymeacoffee.com/codewithmukesh)

## Technologies
- ASP.NET Core 3.1 WebApi
- REST Standards
- .NET Core 3.1 / Standard 2.1 Libraries

## Features
- [x] Onion Architecture
- [x] CQRS with MediatR Library
- [x] Entity Framework Core - Code First
- [x] Repository Pattern - Generic
- [x] MediatR Pipeline Logging & Validation
- [x] Serilog
- [x] Swagger UI
- [x] Response Wrappers
- [ ] Healthchecks
- [x] Pagination
- [ ] Redis Caching
- [x] In-Memory Database
- [x] Microsoft Identity with JWT Authentication
- [ ] Role based Authorization
- [ ] Identity Seeding
- [ ] Database Seeding
- [x] Custom Exception Handling Middlewares
- [x] API Versioning
- [x] Fluent Validation
- [x] Automapper
- [ ] SMPT / Mailkit / Sendgrid Email Service
- [ ] Complete User Management Module (Register / Generate Token / Forgot Password / Confirmation Mail)

## Brief Overview
![alt text](https://www.codewithmukesh.com/wp-content/uploads/2020/06/Onion-Architecture-In-ASP.NET-Core.png)

## Prerequisites
- Visual Studio 2019 Community and above
- .NET Core 3.1 SDK and above
- Basic Understanding of Architectures and Clean Code Principles

## Getting Started

## Changelog
Every changes / additions / deletions will be recorded in the [Changelog file](https://github.com/iammukeshm/CleanArchitecture.WebApi/blob/master/CHANGELOG.md).

## Questions? Bugs? Suggestions for Improvement?
Having any issues or troubles getting started? [Get in touch with me](https://www.codewithmukesh.com/contact) or [Raise a Bug or Feature Request](https://github.com/iammukeshm/CleanArchitecture.WebApi/issues/new/choose). Always happy to help.

## Support
Has this Project helped you learn something New? or Helped you at work? Do Consider Supporting.

<a href="https://www.buymeacoffee.com/codewithmukesh" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" width="200"  ></a>

## Share it!
I have personally not come across a clean implementation on a WebAPI, which is the reason that I started building this up. There are quite a lot of improvements and fixes along the way from the day I started out. Thanks to the community for the support and suggestions.
Please share this Repository within your developer community, if you think that this would a difference! Thanks.

## About the Author
### Mukesh Murugan
- Blogs at [codewithmukesh.com](https://www.codewithmukesh.com)
- Facebook - [codewithmukesh](https://www.facebook.com/codewithmukesh)
- Twitter - [Mukesh Murugan](https://www.twitter.com/iammukeshm)
- Twitter - [codewithmukesh](https://www.twitter.com/codewithmukesh)
- Linkedin - [Mukesh Murugan](https://www.linkedin.com/in/iammukeshm/)

## Licensing
iammukeshm/CleanArchitecture.WebApi Project is licensed with the [MIT License](https://github.com/iammukeshm/CleanArchitecture.WebApi/blob/master/LICENSE).
