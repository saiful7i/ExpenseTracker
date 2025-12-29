# 💰 Expense Tracker System

A simple and efficient **web-based application** built with **ASP.NET Core MVC** and **SQL Server** to help users record, categorize, and analyze their daily income and expenses.

---

## 🚀 Features
- Add, edit, and delete expenses and income
- Categorize transactions (e.g., Food, Rent, Transport)
- View monthly and yearly summaries
- Visual charts for better spending insights
- Secure user authentication and data management
- Responsive UI built with **Tailwind CSS**

---

## 🛠️ Technologies Used
- **Frontend:** ASP.NET Core MVC, Tailwind CSS
- **Backend:** C# (.NET 8)
- **Database:** SQL Server / SQLite
- **IDE:** Visual Studio 2022
- **Version Control:** Git & GitHub

---

## 📂 Project Structure
```
ExpenseTracker/
│
├── Controllers/
├── Models/
├── Views/
│ ├── Category/
│ ├── Transaction/
│ └── Shared/
│
├── wwwroot/
│ ├── css/
│ └── js/
│
├── appsettings.json
└── Program.cs
```

---

## ⚙️ How to Run
1. Clone the repository
```bash
git clone https://github.com/yourusername/expense-tracker.git
```
2. Open the project in **Visual Studio 2022**
3. Update the database connection string in `appsettings.json`
4. Run the following commands in **Package Manager Console**:
```bash
add-migration InitialCreate
update-database
```
5. Press **F5** or **Ctrl+F5** to run the project

---

## 📊 Future Improvements
- Add user authentication (multi-user support)
- Export reports to PDF or Excel
- Add budget planner and notifications

---

## 👨‍💻 Author
**Md. Saiful Islam**
📍 Dhaka, Bangladesh
🔗 [GitHub](https://github.com/saiful7i) | [LinkedIn](https://www.linkedin.com/in/saiful7i/)
