# Animal Shelter API
#### By Jake C. Haley

## Technologies Used

* C#
* ASP.NET Core MVC
* MySQL Workbench
* Entity Framework Core
* Postman

## Description

An API used to keep track of dogs and cats in a shelter. User is able to view API results in the browser as well as Postman. API Utilizes Swagger for it's documentation.

## Setup/Installation Requirements

#### Install .NET Core
* For MacOs Mojave or later click [HERE](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-2.2.106-macos-x64-installer) to download.
* For Windows 10 or later click [HERE](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-2.2.203-windows-x64-installer) to download.

#### Install dotnet script
* Type `dotnet tool install -g dotnet-script` in Terminal

#### Install MySQL WorkBench 

[Download and install the appropriate version of MySQL Workbench.](https://dev.mysql.com/downloads/workbench/)

#### Install Postman (Optional)

[Download and install Postman](https://www.postman.com/downloads/)

#### Cloning 

* Clone `AnimalShelter.Solution` Onto your local machine.
* Run `cd AnimalShelter` in your terminal to navigate to project directory.

#### AppSettings

* While in `AnimalShelter` directory, create a new file and name it `appsettings.json`.
* Add the following code to this file: `{
  "Logging": {
      "LogLevel": {
      "Default": "Warning"
      }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=firstname_lastname_api;uid=root;pwd=YourPassword;"
  }
}`
* Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

#### Database
* From the `AnimalShelter` directory, Run the command dotnet ef database update to generate the database through Entity Framework Core.

#### Launch the API
* From the `AnimalShelter` directory, run the command `dotnet run` to access the API in the browser or Postman.

## Documentation

Explore the API endpoints in Postman or a browser.

### Using Swagger Documentation

To explore the AnimalShelter API with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: http://localhost:5000/swagger

### Endpoints

Base URL: `https://localhost:5000`

### HTTP Request Structure

* GET /api/Animals
* POST /api/Animals
* GET /api/Animals/{id}
* PUT /api/Animals/{id}
* DELETE /api/Animals/{id}
* GET /api/Animals/Random



## Known Bugs

* No Known Bugs
* Let me know if you find any!

## License

ISC License

Copyright (c) [2022] [Jake C. Haley]

Permission to use, copy, modify, and/or distribute this software for any purpose with or without fee is hereby granted, provided that the above copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.