# ✅ TodoApi - .NET 9 Web API with xUnit Unit Testing

This is a simple `.NET 9` Web API project demonstrating **unit testing using xUnit**.

It includes:
- A basic `TodoService` for managing tasks
- An xUnit test project validating its logic
- No database or controller involved (pure logic testing)

---

## 📁 Project Structure

/TodoApi
/Models
TodoItem.cs
/Services
ITodoService.cs
TodoService.cs

/TodoApi.Test
TodoServiceTests.cs

---

## ✅ Features

| Layer        | Function                                      |
|--------------|-----------------------------------------------|
| `TodoItem`   | Represents a task (Id, Title, IsCompleted)    |
| `TodoService`| Stores todos in memory, handles Add/Get/Delete|
| `xUnit`      | Tests the service logic                       |

---

## 🧪 Unit Tests Covered

All tests are in `TodoServiceTests.cs`:

| Test Name                | Purpose                                           |
|--------------------------|--------------------------------------------------|
| `Add_ShouldIncreaseCount`| Checks that `Add()` stores a todo item           |
| `GetById_ShouldReturnItem`| Verifies `GetById()` returns correct item       |
| `Delete_ShouldRemoveItem`| Ensures `Delete()` actually removes the item     |

---

## ▶️ How to Run

### 🛠 Requirements
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

### 🧾 Commands

```bash
# Navigate to the solution folder
cd TodoApi

# Build
dotnet build

# Run tests
dotnet test

