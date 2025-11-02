⚙️ Entity Framework Loading Strategies – Console App (C#)

A C# Console Application designed to demonstrate and test different Entity Framework Core loading strategies —
Lazy Loading, Eager Loading, and Explicit Loading — for related data retrieval in database models.

This project serves as a learning and testing tool to understand how Entity Framework Core manages relationships and data fetching performance.

-----------------------------------------------------

🏗️ Overview

The project illustrates how navigation properties and loading techniques affect database queries and performance.
It provides hands-on examples of:

Lazy Loading – Related data is loaded automatically when accessed.

Eager Loading – Related data is loaded immediately with the main entity using .Include().

Explicit Loading – Related data is loaded manually using .Entry() and .Collection() or .Reference().

------------------------------------------------

🚀 Features
🔄 Loading Strategy Demonstrations

Test all three Entity Framework loading types in a single console app

Compare SQL queries generated for each loading mode

Analyze performance and behavior differences

🧱 Entity Relationships

Demonstrates One-to-Many and Many-to-One relationships

Example: Department ↔ Employees

🧠 Educational Focus

Ideal for developers learning EF Core internals

Helps understand when to use each loading strategy

---------------------------

🧰 Technologies Used
| Category      | Technology                         |
| ------------- | ---------------------------------- |
| **Language**  | C#                                 |
| **Framework** | .NET 6 / .NET 8                    |
| **ORM**       | Entity Framework Core              |
| **Database**  | SQL Server / SQLite (configurable) |
| **IDE**       | Visual Studio / VS Code            |

-----------------------------------

📊 Comparison Summary
| Loading Type | Trigger                | Queries                | Performance                     | Use Case                         |
| ------------ | ---------------------- | ---------------------- | ------------------------------- | -------------------------------- |
| **Lazy**     | When property accessed | Multiple small queries | Slower for large datasets       | Simplifies access                |
| **Eager**    | On initial query       | Single joined query    | Fastest for small sets          | Dashboard & reports              |
| **Explicit** | Manual trigger         | Controlled queries     | Optimized for selective loading | Large datasets or advanced logic |

--------------------------------------

🔮 Future Enhancements

Add timing and query logging comparison output

Implement many-to-many and one-to-one relationships

Include interactive menu to select loading mode at runtime

Add EF Core logging to console for SQL visualization
