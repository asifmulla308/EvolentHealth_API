# EvolentHealthAPI

* Overview
- API url: https://localhost:44376/api/v1/
- EvolentHealth API has been developed using .Net Core, 
- API Testing is done using Swagger
- Unit test case is written using xUnit framework

* Project Directory
- Project Solution contains API adn Test project

# API(EvolentHealthAPI) - A typical top-level directory layout
.
├── AutoMapper              # Object-object mapper__
├── Controllers             # Act as mediator between UI and Repositories__
├── Model                   # Entity Framework model__
├── Repositories            # Actual data manipulation logic__
├── appsettings.json        # Connection settings__
├── Startup.cs              #__

# Unit Test(EvolentHealthAPITest) - A typical top-level directory layout
.
├── ControllerTests         # Covers unit test case  for all controller's actions
├── Repository              # Covers unit test case  for repository functions



* Swagger UI
![Alt text](https://github.com/asifmulla308/EvolentHealth_API/blob/master/images/swagger_main.png "swaggermain")

* Development Details:
- Used SQL Server Database ('Database Name': "evolenthealth")
- Used .Net Core API
- For Database and application communication used Entity Framewor. Follows Database first approch.
- Follows Repository Design pattern for application development



