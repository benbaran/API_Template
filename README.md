# API #

## Goals ##

* Implement API with .NET Core best practices
* Reduce external dependencies
* Reduce project bloat

## Projects ##

Api - API Project

* Controllers - API Endpoints

* Startup.cs - Configuration and Dependency Injection

Core - Shared Components

* Models          - Domain Models (what we get from the database)

* Profiles        - Automapper Profiles for Object Mapping

* Repositories    - Repositories and Interfaces

* Requests        - API Request Models (for POST, PUT requests)

* Responses       - API Response Models

* Services        - Business Logic and Object Mapping

Tests.Integraton - Integration Tests

Tests.Unit - Unit Tests

## Dependencies ##
* Swagger     - OpenApi
* SeriLog     - Structured Logging
* Automapper  - Object Mapping
* ORM         - TBD