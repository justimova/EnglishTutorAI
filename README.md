# EnglishTutorAI

AI-powered English learning web application built with ASP.NET Core, Angular and OpenAI API.

EnglishTutorAI is a full-stack diploma project that helps users practice English through AI-generated writing tasks, reading materials, grammar explanations and personalized feedback.

## Project Overview

This project was developed as a graduation project and implemented as a full-stack web application rather than a small isolated demo.

The main goal was to build a structured learning platform with user authentication, backend business logic, database access, an Angular frontend and integration with an external AI service.

## Features

- User registration and login
- JWT-based authentication
- Personal user profile management
- AI-generated writing tasks
- AI feedback for writing practice
- AI-generated reading texts with translations
- Grammar explanations adapted to the user's English level
- Personal dictionary management
- Essay draft and completed essay tracking
- REST API for frontend/backend communication

## Tech Stack

### Backend

- C#
- .NET 8
- ASP.NET Core Web API
- ASP.NET Core Identity
- JWT Bearer Authentication
- Entity Framework Core
- AutoMapper
- OpenAI API

### Frontend

- Angular
- TypeScript
- HTML
- CSS

## Architecture

The backend is organized as a multi-project ASP.NET Core solution with separated responsibilities:

```text
EnglishTutorAI/
├── EnglishTutorAI/              # Web API and Angular SPA host
├── AiServices/                  # OpenAI integration
├── DomainServices/              # Business logic
├── InfrastructureService/       # User and auth-related services
├── UnitOfWork/                  # EF Core context, repositories and migrations
├── DbModels/                    # Database entities
├── DataTransferObjects/         # DTOs used by the API
└── BootstrapModule/             # Dependency injection configuration
```

## Engineering Highlights

### AI service layer

The project has a dedicated service layer for AI-related functionality. It is responsible for generating learning materials and feedback, including:

- writing practice tasks;
- writing recommendations;
- reading texts with translations;
- grammar explanations adapted to the user's English level.

### Authentication

The application uses JWT Bearer authentication to protect user-specific API endpoints. Authenticated users can work with their profile, dictionary, essays and learning progress.

### Layered backend design

The backend is split into several projects to separate responsibilities:

- controllers handle HTTP requests;
- DTOs define API contracts;
- domain services contain business logic;
- infrastructure services handle authentication and user-related logic;
- repositories and Unit of Work isolate data access.

This structure makes the project easier to extend, test and maintain.

## Project Status

Completed diploma project.

The main functionality was implemented as part of the graduation work. The project is no longer under active development, but it remains a representative example of my experience with full-stack .NET development, authentication, database access, frontend integration and AI API usage.

Possible future improvements:

- extend the platform with speaking practice features, such as pronunciation exercises, speech recognition and AI-generated speaking prompts
- add automated tests
- improve frontend UI/UX
- add Swagger/OpenAPI documentation
- add Docker configuration

## What I Practiced

While building this project, I practiced:

- designing a multi-project ASP.NET Core solution
- implementing JWT authentication
- working with Entity Framework Core repositories and migrations
- integrating an external AI API into a real application flow
- connecting an Angular frontend with an ASP.NET Core backend
- structuring code beyond a simple CRUD application

## Author

Developed by [@justimova](https://github.com/justimova)
