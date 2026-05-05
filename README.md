# 📘 Razor Pages & MVC Model Binding Assignment

This project demonstrates the implementation of **ASP.NET Core Razor Pages and MVC concepts**, including model binding, partial views, routing, and MVC architecture.

---

## 🚀 Technologies Used

* ASP.NET Core (.NET 10)
* Razor Pages
* MVC Pattern
* C#

---

# 📌 Assignment 1: Razor Pages

## ✅ Features Implemented

* Complex model binding (Product + Category list)
* Form handling with collections
* Partial Views for reusable UI
* Custom routing using `/Products/Details/{id}`

---

## 📂 Folder Structure

```
ProductApp/
 ├── Models/
 ├── Pages/
 │    ├── Products/
 │         ├── Index.cshtml
 │         ├── Details.cshtml
 │         ├── _ProductSummary.cshtml
```

---

## 🖥️ Sample Input

```
Name: Phone
Description: Smart Phone
Category 1: Electronics
Category 2: Gadgets
```

---

## 📊 Sample Output

```
Phone
Smart Phone
• Electronics
• Gadgets

[View Details]
```

👉 On clicking **View Details**

```
Phone
Smart Phone
• Electronics
• Gadgets
```

---

# 📌 Assignment 2: MVC Application

## ✅ Features Implemented

* MVC architecture (Model, View, Controller)
* Simple model binding (User details)
* Complex model binding (Nested Address model)
* Form submission and result display

---

## 📂 Folder Structure

```
UserMVCApp/
 ├── Models/
 ├── Controllers/
 ├── Views/
 │    ├── User/
 │         ├── Index.cshtml
 │         ├── Result.cshtml
```

---

## 🖥️ Sample Input

```
First Name: Giridhar
Last Name: Gopal
Age: 23

Street: Gola Road
City:  Patna
ZipCode: 801503
```

---

## 📊 Sample Output

```
Name: Giridhar Gopal
Age: 23

Address:
Gola Road
Patna
801503
```

---

# 🎯 Key Learnings

* Model Binding (Simple & Complex)
* Razor Pages vs MVC Architecture
* Partial Views for reusable components
* Routing and navigation handling

---

# ✅ Conclusion

This project successfully demonstrates core ASP.NET Core concepts required for building scalable web applications using Razor Pages and MVC.

---
