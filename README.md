# Cosmetic Shop Management System

A desktop-based **Cosmetic Shop Management System** developed using **C# Windows Forms** and **SQL Server**.  
This project is designed to manage cosmetic shop operations for different user roles such as **Customer**, **Admin / Shop Owner**, **Shop Employee**, and **Super Admin**.

---

## Project Overview

The main purpose of this project is to create a user-friendly desktop application where customers can browse and buy cosmetic products, while admins can manage shops, inventory, products, and order-related activities.

The system supports:

- user registration and login
- role-based access
- product browsing for male and female sections
- product search and filtering
- cart and checkout system
- order management
- review and rating system
- shop management
- admin dashboard
- database-driven storage and retrieval

This project was built as a real-life scenario-based application to demonstrate **Object-Oriented Programming**, **Graphical User Interface design**, and **database integration** using C#.

---

## Features

### Customer Features
- Register a new account
- Login with credentials
- Browse highlighted products
- Browse male cosmetic products
- Browse female cosmetic products
- Search products
- Filter products by category, stock status, and price range
- View product details
- Add products to cart
- Update cart quantity
- Remove products from cart
- Proceed to checkout
- Place orders
- Submit product reviews and ratings
- View order history

### Admin Features
- Admin login
- View admin dashboard
- See total products, orders, gross sales, net income, and low stock
- Manage shop profile
- Add new products
- Update product details
- Delete products
- Track stock and sold quantity
- Search and filter products

### Super Admin Features
- Platform-level control
- Review approval requests
- Monitor shops, employees, and products
- Observe marketplace records

### Employee Features
- Work under assigned shop
- Support shop-level management tasks

---

## Technologies Used

- **Programming Language:** C#
- **Framework:** .NET Windows Forms
- **Database:** Microsoft SQL Server
- **IDE:** Visual Studio
- **Database Tool:** SQL Server Management Studio (SSMS)

---

## User Roles

The system is designed with multiple roles:

1. **Customer**  
   Can register, login, browse products, add to cart, place orders, and review products.

2. **Admin / Shop Owner**  
   Can manage shop information, products, stock, and orders.

3. **Shop Employee**  
   Can assist shop operations under a specific shop.

4. **Super Admin**  
   Can supervise the overall platform and monitor approval requests and marketplace activities.

---

## Main Modules

- Login Form
- Register Form
- Customer Dashboard
- Male Products Form
- Female Products Form
- Product Details Form
- Cart Form
- Checkout Form
- Review Form
- My Orders Form
- Admin Dashboard Form
- Manage Shop Form
- Manage Products Form
- Add Product Form

---

## Database Design

The project uses a relational SQL Server database.

CREATE DATABASE CosmeticMarketplaceDB;
GO

USE CosmeticMarketplaceDB;
GO

-- =========================
-- 1. Roles Table
-- =========================
CREATE TABLE Roles
(
    RoleId INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(50) NOT NULL UNIQUE
);
GO

-- =========================
-- 2. Users Table
-- =========================
CREATE TABLE Users
(
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Phone NVARCHAR(20) NULL,
    Address NVARCHAR(255) NULL,

    PasswordHash NVARCHAR(255) NOT NULL,
    PasswordSalt NVARCHAR(255) NOT NULL,

    RoleId INT NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Users_Roles
    FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
);
GO

-- =========================
-- 3. Shops Table
-- Admin / Shop Owner owns shop
-- =========================
CREATE TABLE Shops
(
    ShopId INT IDENTITY(1,1) PRIMARY KEY,
    ShopName NVARCHAR(100) NOT NULL,
    ShopDescription NVARCHAR(500) NULL,
    OwnerUserId INT NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Shops_Users
    FOREIGN KEY (OwnerUserId) REFERENCES Users(UserId)
);
GO

-- =========================
-- 4. Shop Employees Table
-- Employee assigned to one shop
-- =========================
CREATE TABLE ShopEmployees
(
    ShopEmployeeId INT IDENTITY(1,1) PRIMARY KEY,
    ShopId INT NOT NULL,
    EmployeeUserId INT NOT NULL,
    AssignedAt DATETIME NOT NULL DEFAULT GETDATE(),
    IsActive BIT NOT NULL DEFAULT 1,

    CONSTRAINT FK_ShopEmployees_Shops
    FOREIGN KEY (ShopId) REFERENCES Shops(ShopId),

    CONSTRAINT FK_ShopEmployees_Users
    FOREIGN KEY (EmployeeUserId) REFERENCES Users(UserId)
);
GO

-- =========================
-- 5. Categories Table
-- =========================
CREATE TABLE Categories
(
    CategoryId INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL UNIQUE
);
GO

-- =========================
-- 6. Products Table
-- ImagePath is better than storing image inside DB
-- =========================
CREATE TABLE Products
(
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    ShopId INT NOT NULL,
    CategoryId INT NOT NULL,

    ProductName NVARCHAR(150) NOT NULL,
    Description NVARCHAR(1000) NULL,
    Price DECIMAL(10,2) NOT NULL CHECK (Price >= 0),
    StockQty INT NOT NULL DEFAULT 0 CHECK (StockQty >= 0),
    SoldQty INT NOT NULL DEFAULT 0 CHECK (SoldQty >= 0),

    GenderSection NVARCHAR(20) NOT NULL CHECK (GenderSection IN ('Male', 'Female', 'Unisex')),
    ImagePath NVARCHAR(500) NULL,
    IsHighlighted BIT NOT NULL DEFAULT 0,
    IsActive BIT NOT NULL DEFAULT 1,

    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Products_Shops
    FOREIGN KEY (ShopId) REFERENCES Shops(ShopId),

    CONSTRAINT FK_Products_Categories
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);
GO

-- =========================
-- 7. Cart Table
-- One active cart per customer
-- =========================
CREATE TABLE Cart
(
    CartId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerUserId INT NOT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Cart_Users
    FOREIGN KEY (CustomerUserId) REFERENCES Users(UserId)
);
GO

-- =========================
-- 8. Cart Items Table
-- =========================
CREATE TABLE CartItems
(
    CartItemId INT IDENTITY(1,1) PRIMARY KEY,
    CartId INT NOT NULL,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),

    CONSTRAINT FK_CartItems_Cart
    FOREIGN KEY (CartId) REFERENCES Cart(CartId),

    CONSTRAINT FK_CartItems_Products
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);
GO

-- =========================
-- 9. Orders Table
-- =========================
CREATE TABLE Orders
(
    OrderId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerUserId INT NOT NULL,

    OrderDate DATETIME NOT NULL DEFAULT GETDATE(),
    TotalAmount DECIMAL(10,2) NOT NULL DEFAULT 0,
    OrderStatus NVARCHAR(50) NOT NULL DEFAULT 'Pending',

    CONSTRAINT FK_Orders_Users
    FOREIGN KEY (CustomerUserId) REFERENCES Users(UserId)
);
GO

-- =========================
-- 10. Order Items Table
-- Shop income and commission are stored per item
-- because one order can contain products from multiple shops
-- =========================
CREATE TABLE OrderItems
(
    OrderItemId INT IDENTITY(1,1) PRIMARY KEY,
    OrderId INT NOT NULL,
    ProductId INT NOT NULL,
    ShopId INT NOT NULL,

    Quantity INT NOT NULL CHECK (Quantity > 0),
    UnitPrice DECIMAL(10,2) NOT NULL CHECK (UnitPrice >= 0),
    LineTotal DECIMAL(10,2) NOT NULL CHECK (LineTotal >= 0),

    ShopIncome DECIMAL(10,2) NOT NULL DEFAULT 0,
    PlatformCommission DECIMAL(10,2) NOT NULL DEFAULT 0,

    CONSTRAINT FK_OrderItems_Orders
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),

    CONSTRAINT FK_OrderItems_Products
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId),

    CONSTRAINT FK_OrderItems_Shops
    FOREIGN KEY (ShopId) REFERENCES Shops(ShopId)
);
GO

-- =========================
-- 11. Payments Table
-- =========================
CREATE TABLE Payments
(
    PaymentId INT IDENTITY(1,1) PRIMARY KEY,
    OrderId INT NOT NULL,
    PaymentMethod NVARCHAR(50) NOT NULL,
    PaymentStatus NVARCHAR(50) NOT NULL DEFAULT 'Pending',
    PaidAmount DECIMAL(10,2) NOT NULL DEFAULT 0,
    PaymentDate DATETIME NULL,

    CONSTRAINT FK_Payments_Orders
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId)
);
GO

-- =========================
-- 12. Platform Commission Table
-- Super Admin earns 2%
-- =========================
CREATE TABLE PlatformCommission
(
    CommissionId INT IDENTITY(1,1) PRIMARY KEY,
    OrderId INT NOT NULL,
    TotalOrderAmount DECIMAL(10,2) NOT NULL,
    CommissionRate DECIMAL(5,2) NOT NULL DEFAULT 2.00,
    CommissionAmount DECIMAL(10,2) NOT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_PlatformCommission_Orders
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId)
);
GO

-- =========================
-- 13. Reviews Table
-- Customer can review only purchased product
-- This rule will be checked in C# code later
-- =========================
CREATE TABLE Reviews
(
    ReviewId INT IDENTITY(1,1) PRIMARY KEY,
    ProductId INT NOT NULL,
    CustomerUserId INT NOT NULL,
    Rating INT NOT NULL CHECK (Rating BETWEEN 1 AND 5),
    ReviewText NVARCHAR(1000) NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Reviews_Products
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId),

    CONSTRAINT FK_Reviews_Users
    FOREIGN KEY (CustomerUserId) REFERENCES Users(UserId)
);
GO

-- =========================
-- 14. Admin Approval Requests
-- Customer can request to become Admin / Shop Owner
-- Super Admin approves or rejects
-- =========================
CREATE TABLE AdminApprovalRequests
(
    RequestId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    RequestedShopName NVARCHAR(100) NOT NULL,
    RequestStatus NVARCHAR(50) NOT NULL DEFAULT 'Pending',
    RequestedAt DATETIME NOT NULL DEFAULT GETDATE(),
    ReviewedAt DATETIME NULL,
    ReviewedBySuperAdminId INT NULL,

    CONSTRAINT FK_AdminApprovalRequests_Users
    FOREIGN KEY (UserId) REFERENCES Users(UserId),

    CONSTRAINT FK_AdminApprovalRequests_SuperAdmin
    FOREIGN KEY (ReviewedBySuperAdminId) REFERENCES Users(UserId)
);
GO

### Main Tables
- `Roles`
- `Users`
- `AdminApprovalRequests`
- `Shops`
- `Categories`
- `Products`
- `Cart`
- `CartItems`
- `Orders`
- `OrderItems`
- `Payments`
- `Reviews`
- `ShopEmployees`
- `PlatformCommission`

### Important Relationships
- One role can be assigned to many users
- One customer can place many orders
- One order can contain many order items
- One product belongs to one category and one shop
- One product can receive many reviews
- One shop can have many employees
- One cart belongs to one customer
- One cart can contain many cart items

---

## Database Schema Summary
<img src="Cosmatic Shop Management/Images" alt="Description">
## Project Screenshots



### Users
Stores user account and profile information:
- UserId
- FullName
- Email
- Phone
- Address
- PasswordHash
- PasswordSalt
- RoleId
- IsActive
- CreatedAt

### Shops
Stores shop information:
- ShopId
- ShopName
- ShopDescription
- OwnerUserId
- IsActive
- CreatedAt
- BrandAffiliation
- ContactPhone
- EmailAddress
- PhysicalAddress
- LogoPath

### Products
Stores product details:
- ProductId
- ShopId
- CategoryId
- ProductName
- Description
- Price
- StockQty
- SoldQty
- GenderSection
- ImagePath
- IsHighlighted
- IsActive
- CreatedAt

### Orders
Stores customer order data:
- OrderId
- CustomerUserId
- OrderDate
- TotalAmount
- OrderStatus

### OrderItems
Stores detailed products under each order:
- OrderItemId
- OrderId
- ProductId
- ShopId
- Quantity
- UnitPrice
- LineTotal
- ShopIncome
- PlatformCommission

### Reviews
Stores customer feedback:
- ReviewId
- ProductId
- CustomerUserId
- Rating
- ReviewText
- CreatedAt

---

## Case Study

In a modern cosmetic retail business, managing product stock, customer orders, payments, and reviews manually can be difficult and inefficient. A cosmetic store may have many products, different categories, customer accounts, and multiple operational roles. Without a proper software system, inventory errors, delayed service, and poor record management can occur.

To solve this problem, the **Cosmetic Shop Management System** has been developed as a desktop-based application. This system provides a digital environment where customers can browse products, add items to cart, place orders, and submit reviews. At the same time, admins can manage products, shops, and stock information from a dedicated dashboard.

The application supports multiple roles such as **Customer**, **Admin**, **Shop Employee**, and **Super Admin**. Customers use the system for shopping purposes, while admins and employees handle business operations. The super admin oversees the entire platform and marketplace-level activities.

The system is backed by a relational database that stores users, roles, shops, categories, products, carts, orders, reviews, payments, and employee assignments. These components are connected using primary key and foreign key relationships to maintain consistency and proper data flow.

This project demonstrates how C# GUI development and SQL Server database integration can be used together to build a practical, real-life management application.

---

## Functional Requirements

- User can register with valid information
- Registered user can login
- User access depends on assigned role
- Customers can browse products by section
- Customers can search and filter products
- Customers can add items to cart
- Customers can checkout and place orders
- Customers can submit reviews
- Customers can view order history
- Admin can manage shop profile
- Admin can add, update, and delete products
- Admin can monitor product stock
- Admin can view dashboard statistics
- Super Admin can monitor full platform activities

---

## Interface Overview

The application contains multiple Windows Forms for separate tasks.

### Customer Side
- Login page
- Register page
- Customer dashboard
- Product listing pages
- Product details page
- Cart page
- Checkout page
- Review page
- My Orders page

### Admin Side
- Admin dashboard
- Manage shop page
- Manage products page
- Add product page

---

## Validation and Verification

### Validation
The system performs different validations, such as:
- empty field checking
- required input validation
- quantity limits
- password confirmation
- basic image selection validation

### Verification
The system verifies:
- correct login by user role
- correct data insertion into database
- product loading from database
- cart and order processing
- review submission
- shop and product updates

---

## Advantages

- Easy to use desktop interface
- Organized product and order management
- Multi-role support
- Structured SQL database integration
- Faster access to records
- Better stock monitoring
- Improved customer shopping experience

---

## Limitations

- Some advanced modules are still simple or incomplete
- Payment system is basic
- Image loading may require standard JPG or PNG files
- Some future features like invoice generation can be added later

---

## Future Improvements

Possible future upgrades:
- PDF invoice generation
- Advanced sales reports
- Discount and coupon system
- Wishlist module
- Notification system
- Real payment gateway integration
- Better analytics for admin and super admin
- More complete employee workflow

---

## Sample Project Forms

This project includes forms such as:

- `LoginForm`
- `RegisterForm`
- `CustomerDashboardForm`
- `MaleProductsForm`
- `FemaleProductsForm`
- `ProductDetailsForm`
- `CartForm`
- `CheckoutForm`
- `ReviewForm`
- `MyOrdersForm`
- `AdminDashboardForm`
- `ManageShopForm`
- `ManageProductsForm`
- `AddProductForm`

---

## How to Run the Project

1. Open the project in **Visual Studio**
2. Make sure **SQL Server** is running
3. Create the database in **SSMS**
4. Run the required SQL scripts for tables and sample data
5. Update the **connection string** in the project if necessary
6. Build and run the application

---

## Project Folder Idea

```text
Cosmatic Shop Management/
│
├── Program.cs
├── App.config
├── README.md
│
├── DAL/
├── Models/
├── Helpers/
├── Forms/
│
└── Database Scripts/
