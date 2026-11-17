# EduSys
> An enterprise-grade, modular College & Institutional Management System built with **ASP.NET Core MVC** and an interface-driven N-tier architecture, designed to unify complete academic and administrative lifecycles.

---

## 🏛️ Architecture & Design Philosophy

To prevent premature schema lock-in and high-cost database migrations during rapid feature evolution, **CampusCore ERP** implements a **database-agnostic, interface-driven design pattern**:

* **Strict Separation of Concerns (N-Tier):** The solution is decoupled into isolated layers—API/Web (`EduSys`), Business Logic Abstract/Impl (`BusinessObject.*`), Data Access Abstract/Impl (`Datastore.*`), and Domain Models (`Models.*`).
* **Dependency Injection & Mock Repositories:** All business workflows execute against structured in-memory mock data providers injected via DI containers. 
* **Zero-Rework Persistence Migration:** Transitioning from the current mock state to a production-grade SQL Server + Entity Framework Core implementation requires **zero changes** to controller or UI logic—only registering the SQL provider bindings in the DI container.

---

## 🚀 Tech Stack

* **Core Language:** C# (.NET Core)
* **Backend Framework:** ASP.NET Core MVC / Web API
* **Architecture Patterns:** Model-View-Controller (MVC), Repository Pattern, Dependency Injection (DI), Interface-Driven Abstraction
* **Data Layer (Current / Planned):** Structured In-Memory Mock Data Providers *(Current)* → Pluggable SQL Server & EF Core *(Planned)*
* **Frontend & UI:** Razor Views (`.cshtml`), HTML5, CSS3, Bootstrap, jQuery / JavaScript
* **Access Control:** Role-Based Access Control (RBAC) supporting Admins, Faculty, Librarians, and Students

---

## 📂 Project Structure

```text
EduSys/
│
├── EduSys.API/                     # Presentation & Web Controller Layer
│   ├── Controllers/                # Domain-specific MVC Controllers
│   │   ├── AttendanceController.cs
│   │   ├── BookController.cs
│   │   ├── CourseController.cs
│   │   ├── FeesController.cs
│   │   ├── HomeController.cs
│   │   ├── MarksController.cs
│   │   ├── TimeTableController.cs
│   │   └── UserController.cs
│   └── Views/                      # Razor UI views grouped by module
│
├── BusinessObject.Abstract/        # Business service contracts & interfaces
├── BusinessObject.Impl/            # Concrete business logic implementations
├── Datastore.Abstract/             # Data repository contracts
├── Datastore.Impl/                 # In-memory mock datastores (pluggable)
├── Models.Abstract/                # Base models and abstractions
└── Models.Impl/                    # Concrete domain entity models
```

---

## ⚙️ Core Implemented Modules

| Module | Controller | Key Capabilities |
| :--- | :--- | :--- |
| **User & Admissions** | `UserController.cs` | End-to-end student admissions, faculty onboarding, profile management, and RBAC permissions. |
| **Academic Administration** | `CourseController.cs` | Degree programs, department hierarchies, semester structures, and subject-to-faculty mappings. |
| **Timetable Scheduling** | `TimeTableController.cs` | Daily/weekly class scheduling, classroom allocation, and conflict-free period assignments. |
| **Attendance Tracking** | `AttendanceController.cs` | Real-time daily/subject-wise attendance logging with automated exam eligibility threshold checks. |
| **Examination & Grading** | `MarksController.cs` | Internal assessments, semester exam scores, automated CGPA calculations, and report card generation. |
| **Fee & Financial Ledger** | `FeesController.cs` | Tuition fee structures, installment schedules, payment receipts, pending dues, and fine calculations. |
| **Library Inventory** | `BookController.cs` | Book catalogs, ISBN tracking, issuance/return logs, and overdue fine synchronization with student profiles. |
| **Executive Dashboard** | `HomeController.cs` | Role-specific executive summaries, key institutional metrics, and quick-navigation workflows. |

---

## 💡 Key Engineering Problems Solved

1. **Zero-Rework Database Decoupling via DI:** Abstracted data access behind clean repository interfaces (`Datastore.Abstract`) and injected mock repositories into controllers. This eliminates schema migration friction during early feature iterations.
2. **Eliminating Departmental Data Silos:** Anchored relational object models around unified student and user identities (`UserController`), allowing administrative checks—such as overdue library books (`BookController`) or fee dues (`FeesController`)—to link directly to a student's core record.
3. **Modular Controller Isolation:** Isolated institutional domains into dedicated controllers, ensuring that updates to fee calculation rules or grading logic never break scheduling or attendance modules.

---

## 🗺️ Roadmap

- [x] **Phase 1:** Core ASP.NET MVC architecture, controllers, views, and interface-driven in-memory mock repositories.
- [ ] **Phase 2:** SQL Server & Entity Framework Core Provider Integration (Plug-and-play via Dependency Injection).
- [ ] **Phase 3:** Advanced JWT Authentication & Granular RBAC Permission Policies.

---

## 🛠️ Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/shuaibshuaib728/CampusCore-ERP.git
   ```
2. **Open the solution** in Visual Studio or VS Code (`EduSys.sln`).
3. **Restore NuGet packages and run the application:**
   ```bash
   dotnet restore
   dotnet run --project EduSys.API
   ```
4. Navigate to `https://localhost:5001` in your browser.

---

## 📄 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
