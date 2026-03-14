# Week 01–02: Backend Foundations (EF Core & SQL Server)

This project represents **Weeks 01–02** of the **.NET Backend Roadmap (Remote Job Ready)**.

The goal of this phase is a **mental and architectural transition** from desktop-oriented development to **backend data-driven thinking**.

---

## Goal of This Phase

- Move from **object-centric / in-memory thinking** to **data-centric backend design**
- Understand how backend applications interact with **relational databases**
- Learn how **Entity Framework Core** manages:
  - DbContext lifecycle
  - Change tracking
  - Migrations
- Treat the database as an **external system**, not a local file

---

## Problem Statement

A backend service needs to ingest sensor data produced externally (CSV files),
validate and model it, and persist it efficiently into a SQL Server database.

This project simulates that scenario using a **Console Application** to remove
any web-related noise and focus purely on the **data layer**.

---

## Solution Overview

- A `.NET 8` Console Application
- Reads sensor data from a CSV file
- Maps raw data into a domain entity (`SensorRecord`)
- Persists data into **SQL Server** using **Entity Framework Core**
- Uses **batch inserts** instead of per-row database calls
- Database schema is managed via **EF Core migrations**

---

## Core Backend Concepts Covered

### 1. DbContext Lifecycle
- Explicit creation and disposal of `DbContext`
- Understanding scoped lifetime vs long-lived contexts
- Avoiding common tracking and memory pitfalls

### 2. EF Core Migrations
- Code-first schema management
- Database creation and updates driven by migrations
- No database files committed to source control

### 3. Batch Data Ingestion
- CSV parsing separated from persistence logic
- Bulk insertion patterns using EF Core
- Clear separation between IO, domain modeling, and data access

### 4. SQL-Oriented Thinking
- Database treated as a persistent, shared resource
- Schema defined by code, not local state
- Preparation for future API-based access

---

## Why a Console Application?

This phase intentionally avoids ASP.NET Core.

The objective is to:
- Isolate **data access concerns**
- Build confidence with SQL Server and EF Core
- Prepare a solid data layer before introducing HTTP, controllers, and APIs

ASP.NET Core Web API is introduced in **Weeks 03–04**, building directly on top of this foundation.

---

## Outcome

After completing this phase:
- The database can be recreated entirely from migrations
- Data ingestion logic is deterministic and testable
- The project is ready to be reused by a Web API without redesigning the data layer

---

## Next Step

➡️ **Weeks 03–04: ASP.NET Core Web API**

The existing data layer will be reused to expose RESTful endpoints
for querying and managing sensor data over HTTP.
