# 🌿 Plant CRUD Management CSharp

## 📌 Project Overview
This is a **console-based Plant Management System** developed using **C#**.  
It supports **CRUD operations (Create, Read, Update, Delete)** on plant data.  
Each plant has properties like name, type, origin, soil type, fertilizer, flower-bearing info, price, and auto-calculated charges.

The system also uses the **Factory Design Pattern** to apply dynamic pricing logic based on plant attributes.

---

## 👨‍💻 Author Info
- **Name:** Md. Rifat Hossain
-  
---

## 🧰 Technologies Used
- C# (.NET Console Application)
- Object Oriented Programming (OOP)
- Enum and Custom Types
- Factory Design Pattern
- Layered Architecture:
  - `Entities`
  - `Repositories`
  - `Factory`

---

## 🚀 Features
✅ Menu-driven Console Interface  
✅ Input validation with retry  
✅ Custom Enum handling for plant types and origins  
✅ Factory Pattern for applying additional cost  
✅ Table-formatted output for plant listing  
✅ Lightweight & Fast Execution  

---

## 🛠️ How to Run
1. Open the solution in **Visual Studio**.
2. Set the `PlantSellManagement` project as the **Startup Project**.
3. Press `Ctrl + F5` to run without debugging.
4. Follow the menu instructions to perform CRUD operations.

---

## 🖼️ Sample Output Table

```
==============================================================================================================
|ID |Name        |Plant Type|Plants Origin|Flower Bearing|Soil      |Fertilizer     |Price|Extra Cost|Net Price|
==============================================================================================================
|1  |Tulsi       |Indoor    |Native       |Yes           |Cocopit   |Vermi Compost  |200  |10        |210      |
--------------------------------------------------------------------------------------------------------------
```

---

## 📂 Project Structure

```
📦 Plant-CRUD-Management-CSharp
│
├── 📁 Entities
│   └── Plant.cs
├── 📁 Factory
│   └── PlantManagerFactory.cs, BasePlantFactory.cs, etc.
├── 📁 Repositories
│   └── PlantRepository.cs
├── 📁 MyEnums
│   └── MyPlantType.cs, MyPlantsOrigin.cs
├── Program.cs
└── README.md
```

---

## 📄 License
This project is for academic and educational use only. No license is included.




