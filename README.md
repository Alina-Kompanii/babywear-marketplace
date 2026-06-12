 Babywear Marketplace  | Pink Crocodile 

A Windows Forms desktop application for a children's clothing online store.  
Developed in C# with WinForms as a portfolio pet project.

> **"Pink Crocodile – creating a happy childhood through fashion!"**

---

 Table of Contents

- [Features](#features)
- [Screenshots](#screenshots)
- [Forms Overview](#forms-overview)
- [Architecture](#architecture)
- [Technologies](#technologies)
- [How to Run](#how-to-run)
- [Project Structure](#project-structure)
- [Future Improvements](#future-improvements)
- [Author](#author)

---

 Features

 For Users
- **Welcome screen** — Entry point with login/register options
- **Authentication** — Login and registration system
- **Product catalog** — Browse children's clothing by category
- **29 product cards** — Detailed information for each clothing item
- **Size guides** — Clothing and shoe size charts (Forms 11-13)
- **Parenting tips** — Advice on choosing children's clothing (Forms 6-10)
- **Shopping cart** — Add/remove items, calculate total price
- **Order checkout** — Customer info, delivery method, card payment
- **Personal account** — User profile management

 Product Categories
| Category | Russian |
|----------|---------|
| Baby clothes | Одежда для младенцев |
| Outerwear | Верхняя одежда |
| Holiday wear | Для праздников |
| Home wear | Для дома |
| Swimwear | Купальники и плавки |
| Accessories | Аксессуары |

---

 Screenshots

1. Main Menu & Personal Account
Navigation menu, product categories, user profile, and helpful tips for parents.

[![Main Menu](screenshots/main-menu.png)](https://github.com/Alina-Kompanii/babywear-marketplace/blob/main/main-menu.png)

2. Product Card (one of 29)
Detailed product specifications including size range, color, age, season, fabric composition, country of origin, and "Add to Cart" button.

[![Product Card](screenshots/product-card.png)](https://github.com/Alina-Kompanii/babywear-marketplace/blob/main/cart.png)

3. Shopping Cart
View selected items, remove a single product, or clear the entire cart before proceeding to payment.

[![Shopping Cart](screenshots/cart.png)](https://github.com/Alina-Kompanii/babywear-marketplace/blob/main/product-card.png)

4. Payment Form
Customer information (name, phone, address), delivery method selection, card payment fields with helpful input hints.

[![Payment Form](screenshots/payment-form.png)](https://github.com/Alina-Kompanii/babywear-marketplace/blob/main/payment-form.png)

---

 Forms Overview

| Form | Class | Purpose |
|------|-------|---------|
| Form1 | `Form1.cs` | Welcome screen (Login / Register buttons) |
| Form2 | `Form2.cs` | Login (existing users) |
| Form3 | `Form3.cs` | Registration (new users) |
| Form4 | `Form4.cs` | Main menu / product catalog |
| Form5 | `Form5.cs` | Personal account |
| Form6-10 | `Form6.cs` - `Form10.cs` | Parenting tips (5 forms) |
| Form11-13 | `Form11.cs` - `Form13.cs` | Size guides (clothing & shoes) |
| Form14-42 | `Form14.cs` - `Form42.cs` | Product cards (29 forms) |
| Form43 | `Form43.cs` | Shopping cart |
| Form44 | `Form44.cs` | Checkout / payment |

 Form Flow Diagram
Form1 (Welcome)
├── Form2 (Login) → Form4 (Main Menu)
└── Form3 (Register) → Form4 (Main Menu)
Form4 (Main Menu)
├── Form5 (Personal Account)
├── Form6-10 (Tips)
├── Form11-13 (Size Guides)
├── Form14-42 (Product Cards) → Form43 (Cart)
└── Form43 (Cart) → Form44 (Payment)

 Architecture
Global Class
The `Global` class serves as the application's central data hub:

- Stores all **product data** for 29 clothing items
- Manages **shopping cart** state
- Holds **current user** session data
- Makes data accessible across all 44 forms without passing references

csharp
// Example structure of Global class
public static class Global
{
    public static List<Product> Products = new List<Product>();  // 29 items
    public static List<CartItem> Cart = new List<CartItem>();
    public static User CurrentUser;
}

 Technologies
Technology     Version             Description
C#             .NET                Main programming language
Windows Forms  .NET                Desktop UI framework
.NET	       6+ / Framework 4.8  Runtime environment
Visual Studio  2022	           Integrated Development Environment

 How to Run
Prerequisites
Windows OS
Visual Studio 2022 (Community edition is free)
.NET desktop development workload installed
 Steps
Clone or download this repository
Open the .sln solution file in Visual Studio
Press F5 to build and run the application
Register or login to start shopping

 Project Structure
babywear-marketplace/
│
├── screenshots/
│   ├── main-menu.png
│   ├── product-card.png
│   ├── cart.png
│   └── payment-form.png
│
├── Form1.cs                 # Welcome screen
├── Form2.cs                 # Login
├── Form3.cs                 # Registration
├── Form4.cs                 # Main menu / catalog
├── Form5.cs                 # Personal account
├── Form6.cs - Form10.cs     # Parenting tips (5 forms)
├── Form11.cs - Form13.cs    # Size guides (3 forms)
├── Form14.cs - Form42.cs    # Product cards (29 forms)
├── Form43.cs                # Shopping cart
├── Form44.cs                # Checkout / payment
│
├── Global.cs                # Data hub (products, cart, user)
├── Program.cs               # Application entry point
├── Properties/              # Assembly info and resources
│
├── .gitignore               # Excludes bin/, obj/, .vs/
└── README.md

Statistics
Category	Count
Total Forms	44
Product Cards	29
Size Guides	3
Tips Forms	5
Auth Forms	3
Cart + Payment	2
Main + Profile	2

Future Improvements
Database integration — Move data from Global class to SQLite / SQL Server

Product search — Add search and filter functionality

Admin panel — Interface to manage 29 products (CRUD operations)

Order export — Export orders to PDF or Excel

Product images — Add image support for each product card

Payment gateway — Integrate real payment processing

Order history — Save and view past orders

Author
Alina
Student / Junior C# Developer

GitHub: Alina-Kompanii

Project: babywear-marketplace

This is a learning / pet project created for portfolio purposes.
Data is currently stored in-memory via the Global static class, so all data resets when the application closes.
The brand name "Розовый Крокодил" (Pink Crocodile) reflects the playful and loving spirit of children's fashion.
Built with ❤️ for little fashion lovers
