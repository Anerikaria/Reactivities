**Overview
This project showcases a cutting-edge, full-stack web application leveraging RESTful APIs, MediatR and CQRS patterns for efficient backend operations, coupled with a React frontend utilizing functional components and hooks. 
It demonstrates a modern approach to application development, focusing on clean architecture, scalability,and the seamless integration of front-end and back-end technologies.

**Architecture
**The application is structured into five main components, each fulfilling a specific role within the overall architecture:

API: Serves as the gateway for the frontend, handling HTTP requests and responses following RESTful principles. It's where the controllers are defined to manage the CRUD operations for the application resources.
Application: Implements the business logic layer, using MediatR for mediating commands and queries, effectively applying the CQRS pattern to separate reads and writes, which simplifies maintenance and scalability.
Domain: Defines the core entities and business rules of the application, ensuring that the application's business logic is properly encapsulated.
Persistence: Manages data persistence, utilizing Entity Framework Core for a Code First approach to database design. This layer interacts with the database to store and retrieve application data.
Frontend
client-app: Built with React, this layer uses hooks for managing component states and MobX for state management across the app. It communicates with the backend via RESTful APIs to perform operations on the application data.
Key Features
RESTful API Design: Utilizes HTTP methods (GET, POST, PUT, DELETE) for resource manipulation, adhering to REST principles for clear, standardized client-server communication.
CQRS and MediatR: Employs the Command Query Responsibility Segregation pattern to separate read and write operations, enhancing performance and scalability. MediatR is used for request handling, decoupling the application's core logic from external frameworks.
Entity Framework Core: Implements the Code First approach for database management, allowing for a more agile development process.
React with Hooks: Provides a dynamic and responsive user interface, making use of functional components and hooks for efficient state management.
Getting Started
To get a local copy up and running, follow these simple steps:

**Clone the repo
Set up your database
Install necessary dependencies for both the backend (.NET Core) and frontend (React)
Run the application
