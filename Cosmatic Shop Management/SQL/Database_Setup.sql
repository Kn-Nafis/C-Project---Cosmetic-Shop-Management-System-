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
