
# ContactAPI

## Setup Instructions
Install .Net6 or above.

## Development server





## Clone the repository

https://github.com/sandy04121999/ContactAPI.git

## How to Run the Application(ContactAPI)
 1. First run API application
 ````bash
  dotnet run
  ````
 2. Run the Angular development server (Contract UI): 

  ````bash
  ng serve
  ````

## Frontend (Angular)
The Angular app follows a modular structure to keep the code organized and scalable:

Components:
contact-details.component.ts: Manages the display and CRUD operations for contacts.
contact-details.component.ts (if modularized): Handles the modal form for creating and editing contacts.
Services:
contact.service.ts: Provides HTTP methods for interacting with the .NET Core API.
Validation:
Built-in Angular validation with Bootstrap classes ensures a clean user interface and feedback for form errors.

## Backend (.NET Core API)
The .NET Core API is structured using the repository pattern:

Controllers:
ContactsController: Handles API endpoints for CRUD operations on contacts.
Models:
Contact(Model): Represents the contact entity with fields like Id, FirstName, LastName, and Email.
Services:
ContactService: Encapsulates business logic for managing contacts.
Database:
Json file using to CURD operation.
Utils:- user for Read and Write Json file


## Modular Architecture:

Components are divided by responsibility, ensuring reusability and easier maintenance.
A service (ContactsService) is used for API communication, keeping components focused on presentation.
Validation:

Angular's template-driven validation is combined with Bootstrap classes to provide real-time feedback.
Styling:

Bootstrap is used for styling to maintain a clean and responsive UI with minimal custom CSS.

## .NET Core and EF Core:

.NET Core provides a robust and scalable framework for building the backend API.
 json data using for CURD operations 

RESTful API Design:

Follows REST principles, making the API predictable and easy to integrate.

Repository Pattern:

Encapsulates data access logic, ensuring a clear separation of concerns and testability.

## Future Enhancements
Add authentication and authorization.
Include unit tests for both frontend and backend.
Enhance the UI for better responsiveness on mobile devices.
Support pagination and search functionality for contacts.
