# Animal Shelter API
**Weekly Independent Project for Epicodus**  
**By Peter Grimm, 08.21.2020**

## Description

Weekly independent project for Epicodus, an API for a local animal shelter. The API will list the available cats and dogs at the shelter.

## Specifications
* Endpoints to create, update, delete animals in the database via API endpoints.
* Further exploration of one of the following objectives: authentication, versioning, pagination, Swagger documentation, or CORS.

## Setup/Installation Requirements
* .NET Core 2.2 will need to be installed, it can be found here https://dotnet.microsoft.com/download/dotnet-core/2.2
* For Mac users, download MySQL here: https://dev.mysql.com/downloads/file/?id=484914
* For Windows users, download MySQL here: https://dev.mysql.com/downloads/file/?id=484919
* Install MySQL and set the system path, more information on how to do that can be found here: https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql
* Clone the GitHub repository by running `git clone https://github.com/pagrimm/AnimalShelterAPI.Solution.git` in the terminal
* Navigate to the newly created `AnimalShelterAPI.Solution` folder
* Navigate to the `AnimalShelter` subfolder
* Run `dotnet restore` to get API dependencies
* Run `dotnet build` to build the API
* Run `dotnet ef database update` to create the API database
* Run `dotnet run` to run the API
* The web app will now be available on `http://localhost:5000/` in your browser
* Documentation of API endpoints can be found here `http://localhost:5000/swagger`
* A V2 endpoint exists for GET that allows querying by species, breed, gender, or name. Additionally allows requesting a random animal.

## Technologies Used

C#  
.NET Core 2.2  
ASP.NET Core MVC  
Entity Framework Core 2.2.6 
Pomelo Entity Framework Core 2.2.0
NSwag Asp.Net Core

## Legal

Copyright (c) 2020, Peter Grimm  
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) This software is licensed under the MIT license.