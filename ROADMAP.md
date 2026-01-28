# 3-Month .NET Backend Roadmap (Remote Job Ready)

This roadmap is designed for developers with solid C# experience who want
to transition into production-grade .NET backend development.

**Study assumption:** ~4 focused hours per day  
**Target role:** Remote .NET Backend Developer

---

## Weeks 01–02: Backend Foundations + SQL

### Focus
Mental transition from Desktop/System development to Backend thinking.

### Topics
- .NET 8 overview (backend-relevant features)
- Dependency Injection fundamentals
- LINQ (query-centric thinking)
- SQL Server: tables, joins, indexes, transactions
- EF Core: DbContext, migrations

### Output
A console application that reads data from CSV files and persists it into
SQL Server using Entity Framework Core with proper batching and migrations.

---

## Weeks 03–04: ASP.NET Core Web API

### Topics
- Controllers vs Minimal APIs
- Model binding & validation
- Middleware pipeline
- Structured logging (Serilog/NLog)
- Swagger & OpenAPI

### Output
A RESTful CRUD API (Todo / Task Management) with validation and logging.

---

## Weeks 05–06: EF Core Advanced & Data Design

### Topics
- Entity relationships
- Include / ThenInclude performance
- Query splitting
- Pagination & filtering
- DTO mapping

### Output
A Blog API with realistic data modeling and optimized EF Core queries.

---

## Weeks 07–08: Authentication & Docker

### Topics
- JWT authentication
- Role & policy-based authorization
- Dockerfile (multi-stage builds)
- Docker Compose

### Output
A secure, dockerized Blog API with JWT-based authentication.

---

## Weeks 09–10: Clean Architecture & Testing

### Topics
- Clean / Onion Architecture
- SOLID principles in backend design
- Unit testing (xUnit, Moq)
- Integration testing (WebApplicationFactory)

### Output
Refactored backend using Clean Architecture with at least 70% test coverage.

---

## Weeks 11–12: Final Project & Job Preparation

### Final Project
Text Analysis API:
- Text processing via POST requests
- Optional ML/ONNX integration
- EF Core persistence
- JWT authentication
- Dockerized setup

### Job Preparation
- Resume optimization (backend-focused)
- GitHub portfolio refinement
- .NET backend interview preparation
