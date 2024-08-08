# NotificationsHub

## Description
The application is a web platform for managing notifications. It features various tabs for registering each type of notification (email, SMS, and web). Each tab is made available only when the corresponding item is selected in the registration of the application that will consume NotificationsHub.

## Features
The application allows notifications to be registered by other applications for consumption. In this initial phase of the project, the registration steps were developed without support for images and files. In future iterations, we will incrementally develop additional features and validations.

## Technologies
C#
ASP.NET Core with .NET 8.0
Dapper
Automapper
Swagger
.NET 8.0
Visual Studio 2022 or VS Code

## Additional Project Details and Architecture
Monolithic service
Layered architecture with DDD

## Error Handling
404 Not Found: Returned when a task is not found.
400 Bad Request: Returned for invalid request data.
500 Internal Server Error: Returned for unexpected server errors.
Authentication
This API does not include authentication. You can add authentication by configuring JWT or other mechanisms as needed.

## Testing
You can use tools like Postman or cURL to test the API endpoints.

## Contributing
Fork the repository.
Create a new branch (git checkout -b feature-branch).
Commit your changes (git commit -am 'Add new feature').
Push to the branch (git push origin feature-branch).
Create a new Pull Request.
License
This project is licensed under the MIT License - see the LICENSE file for details.
