# 🔐 19_Login_Authentication_System

A secure Login Authentication System built using **ASP.NET Core MVC**, **ASP.NET Core Identity**, **Entity Framework Core**, and **SQL Server**. This project demonstrates the complete user authentication process, including registration, login, password hashing, cookie authentication, session management, and protected pages.

---

## 🚀 Features

- User Registration
- User Login
- Password Hashing
- Authentication Cookies
- Session Management
- Form Validation
- Duplicate Email Check
- Service Layer Architecture
- Entity Framework Core
- SQL Server Database

---

## 🛠️ Technologies Used

- ASP.NET Core MVC
- ASP.NET Core Identity
- Entity Framework Core
- SQL Server
- C#
- Bootstrap 5
- Razor Views

---

## 📂 Project Structure

```
Controllers
│
└── AccountController

Models
│
└── ApplicationUser

Services
│
├── IAccountService
└── AccountService

Views
│
└── Account
    ├── Register.cshtml
    └── Login.cshtml

Data
│
└── ApplicationDbContext

Program.cs
```

---

## 🔑 Authentication Flow

```
User Registration
        │
        ▼
Validate User Input
        │
        ▼
Check Duplicate Email
        │
        ▼
Hash Password
        │
        ▼
Save User to Database
        │
        ▼
User Login
        │
        ▼
Verify Email & Password
        │
        ▼
Create Authentication Cookie
        │
        ▼
Access Protected Dashboard
        │
        ▼
Logout
        │
        ▼
Authentication Cookie Removed
```

---

## 📚 What I Learned

- ASP.NET Core Identity
- IdentityUser
- IdentityDbContext
- User Registration
- User Login
- Password Hashing
- Cookie Authentication
- Session Management
- Dependency Injection
- Entity Framework Core
- Service Layer
- Form Validation
- Authentication Flow

---

## 🎯 Future Improvements

- Forgot Password
- Email Verification
- Reset Password
- Remember Me
- Role-Based Authorization
- Admin Panel
- User Profile
- Change Password
- Two-Factor Authentication (2FA)

---

## 📸 Screenshots
<img width="2560" height="1600" alt="localhost_7111_(Nest Hub Max)" src="https://github.com/user-attachments/assets/0145195e-e100-4fde-941f-7f83123eeb64" /><img width="2560" height="1600" alt="localhost_7111_Account_Register(Nest Hub Max)" src="https://github.com/user-attachments/assets/736e4071-0db1-499f-9667-cf0ed95aab0c" /><img width="2560" height="1600" alt="localhost_7111_Home_Index(Nest Hub Max)" src="https://github.com/user-attachments/assets/8b7c7876-d95e-4162-8ef6-b86489bbdb47" />

---

## Project Status
✅ Completed

---

##  Author
Dhiraj Padhiyar
