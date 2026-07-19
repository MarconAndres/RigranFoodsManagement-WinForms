  Rigran Foods - Enterprise Management System

A enterprise-grade management system (CRM & Logistics) custom-built for Rigran Foods to streamline international commodity sales, multi-currency contract execution, global ports logistics, and end-to-end shipment tracking.

This desktop application replaces scattered spreadsheets with a centralized database, specifically tailored to handle agricultural export workflows.


  Key Features

* Commercial CRM & Sales: Manage international customers, track business sectors, and map contract conditions.
* Global Logistics & Supply Chain: Built-in tracking for international ports, loading/destination hubs, and shipment statuses.
* International Trade Compliance: Native handling of multi-currency contracts, customized grain metrics, and Incoterms (FOB, CFR, CIF, EXW).
* Advanced Customer Insights: Optimized architectures prepared for feature expansions such as customer activity "temperature" tracking and Product Purchase Profiles.


  Architecture & Tech Stack

The system follows a Multi-Layered Architecture to ensure maintainability, separation of concerns, and ease of migration to web environments (ASP.NET Core) in the future.

* Presentation Layer: .NET Windows Forms (WinForms) featuring dynamic data binding, regionalized user input validation.
* Business Logic Layer (BLL): Service-oriented architecture handling enterprise rules, validations, and business logic mapping.
* Data Access Layer (DAL): Repository pattern utilizing Dapper.
* Database: SQL Server (SSMS) with a normalized relational schema, handling foreign  and primary keys.


  Tech Stack & Tools

* Language: C# 
* Framework: .NET (WinForms)
* ORM: Dapper
* Database Engine: Microsoft SQL Server
* Environment: Visual Studio & SQL Server Management Studio (SSMS)


  Future Roadmap

Web Migration: Transition the Presentation Layer to an ASP.NET Core Web API to expose endpoints to modern web frontends or mobile devices.

Smart Analytics: Implementation of customer "temperature" logic based on historical purchase frequency.

Advanced CRM Features: Customer Product Profiles to auto-suggest custom commodity offers based on historic cargo patterns.

