# 🛒 Enterprise E-Commerce Platform

🎬 **[Watch the Full Project Demo Video Here](https://drive.google.com/drive/folders/1ETy2OlrRTI7qEdrn62LaDM-3x97JLnRb?usp=sharing)**

A fully-featured, enterprise-grade E-Commerce web application built with **ASP.NET Core MVC (.NET 9)** and **Entity Framework Core**. This project is engineered with clean architecture principles, emphasizing security, performance, and seamless payment integration.

---

## 📸 Project Showcase

| 🛍️ Customer Experience | 👨‍💻 Admin Dashboard & Security |
| :---: | :---: |
| **Home Page & Dynamic Filters**<br>![Home](Screenshot%202026-10-18%20192304.png) | **Product Management (CRUD)**<br>![Products](Screenshot%202026-10-18%20204358.png) |
| **Shopping Cart & Order Summary**<br>![Cart](Screenshot%202026-10-18%20204122.png) | **User Management & Instant Block**<br>![Users](Screenshot%202026-10-18%20204641.png) |
| **Secure Payment Integration**<br>![Stripe](Screenshot%202026-10-18%20204316.png) | **Product Details**<br>![Details](Screenshot%202026-10-18%20204714.png) |

---

## 🚀 Core Business & Technical Features

### 1. 🏗️ Architecture & Design Patterns
- **Repository & Unit of Work Patterns:** The application strictly separates the Data Access Layer from the Controllers. Repositories (`CartRepository`, `OrderRepository`, `ProductRepository`, etc.) handle direct database interactions safely and cleanly.
- **Dependency Injection:** Service configurations are heavily utilized to maintain loosely coupled and easily testable code.

### 2. 🔐 Advanced Identity & Security
- **Role Management (RBAC):** Distinct authorization policies for different user roles (SuperAdmin, Admin, Customer).
- **Instant Security Eviction:** Overrode the default identity behavior by setting `SecurityStampValidatorOptions.ValidationInterval = TimeSpan.Zero`. This ensures that if an Admin "Blocks" a user, the blocked user's session is invalidated instantly in real-time, kicking them out of the system without waiting for the default cookie expiration.

### 3. 💳 Secure Stripe Payment & Order Pipeline
The checkout process follows a strict and secure business pipeline:
- **Stripe Integration:** Generates a secure Stripe Checkout Session for processing credit cards.
- **Data Transformation & Inventory:** Upon successful payment, the application transforms the `Cart` items into `OrderItems`, and automatically decrements the `Product.Quantity` in the database.
- **Cart Clearance:** Cleans up and deletes the old shopping cart instantly after the order is confirmed.

### 4. 🛍️ Catalog & Cart Mechanics
- **Admin Dashboard:** Full CRUD capabilities for managing Categories, Brands, and Products, including physical image uploads to the server and cascading deletions.
- **Dynamic Cart:** Users can add products, increment/decrement quantities, and the system dynamically calculates the total price.

---

## 💻 Technology Stack
- **Backend:** C#, ASP.NET Core MVC (.NET 9)
- **Database & ORM:** Microsoft SQL Server, Entity Framework Core (Code-First)
- **Authentication:** ASP.NET Core Identity
- **Payment Gateway:** Stripe API
- **Email Service:** Custom IEmailSender implementation (SMTP)
- **Frontend:** HTML5, CSS3, Bootstrap 5, Razor Views

---

## ⚙️ How to Run Locally
1. **Clone the repository:** `git clone https://github.com/MernaSaad22/ECommerce-Platform.git`
2. **Configure Secrets:** Open `appsettings.json` and provide your SQL Server connection string, Stripe Test Keys, and your Email SMTP configurations.
3. **Apply Migrations:** Run `Update-Database` in the Package Manager Console. The `DBInitializer` will automatically seed the required Roles and SuperAdmin account on startup.
4. **Run the App:** Press `F5` in Visual Studio.

---

## 🔮 Future Enhancements (Roadmap)
- **B2B Integration:** Expanding the seeded "Company" role to support Business-to-Business accounts with custom tiered pricing.
- **Shipping Integration:** Connecting with third-party delivery APIs for real-time order tracking.
- **Advanced Analytics:** Adding a reporting dashboard for sales and inventory tracking.
