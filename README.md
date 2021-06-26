# EvolentHealthAPI

## Overview
- API url: https://localhost:44376/api/v1/
- Follows Repository Design pattern for application development
- EvolentHealth API has been developed using .Net Core(3.1), EntityFramework(5.0.7), SQL Server
- API Testing is done using Swagger
- Unit test case is written using xUnit framework

# Project Directory
- Project Solution contains API adn Test project

    ### API(EvolentHealthAPI) - A typical top-level directory layout

├── AutoMapper     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;         # Object-object mapper \
├── Controllers    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;     # Act as mediator between UI and Repositories \
├── Model          &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;         # Entity Framework model \
├── Repositories   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;         # Actual data manipulation logic \
├── appsettings.json  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;      # Connection settings \
├── Startup.cs    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;          # 

   ### Unit Test(EvolentHealthAPITest) - A typical top-level directory layout

- Unit test covers all method/function that has been used.
.
├── ControllerTests &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;# Covers UnitTest case for all controller's actions \
├── Repository     &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;   # Covers unit test case  for repository functions



### Swagger UI
- Swagger Index screen

![Alt text](https://github.com/asifmulla308/EvolentHealth_API/blob/master/images/swagger_main.png "swaggermain")

- Swagger real time example

![Alt text](https://github.com/asifmulla308/EvolentHealth_API/blob/master/images/swagger_get_demo.png "swaggermain")

### Development Details:
- Used SQL Server Database ('Database Name': "evolenthealth")
- Used .Net Core API
- For Database and application communication used Entity Framewor. Follows Database first approch.
- Controller has below methods


├── Get                     # Get All list of contacts \
├── GetContactById          # Get contact by passing Id \
├── Post                    # Insert new contact \
├── Put                     # Update existing Contact details \
├── UpdateStatus(Put)       # Update user status \
├── Delete                  # Delete contact details using Id




